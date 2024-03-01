Imports System.Data.OleDb
Imports System.ComponentModel

Public Class FrmEstadistica

    Dim DTInformeMensual As New DataTable
    Private Sub BtnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnConsultar.Click
        ObtenerEstadosyCantDiasEntrega()
    End Sub
    Private Sub Btnxls_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnxls.Click
        XLS(Dgvcontador)
    End Sub
    Private Sub Btnxls2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnxls2.Click
        XLS(DgvResultado1)
    End Sub
    Private Sub Xls3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Xls3.Click
        XLS(DgvPlanilla)
    End Sub

    Private Sub ObtenerPlanillasCarteros()
        Dim ruta As String
        ruta = ConfigCorreo.CN_Correo.ObtenerRutaDBF()
        Dim FechaLect As Date
        FechaLect = Now.ToShortDateString
        FechaLect = "01/01/2019"
        Dim dtnew As New DataTable

        Dim cnn As New OleDbConnection( _
           "Provider = VFPOLEDB;" & _
           "Data Source=" & ruta & ";" & _
           "Mode=Share Deny None;" & _
           "Mask Password=False;" & _
           "Cache Authentication=False;" & _
           "Encrypt Password=False;" & _
           "Collating Sequence=MACHINE;")
        Using cnn

            Dim sql As String = "SELECT RECORRIDO, FECHA, TRAMITO, CANT_ITEM, ZONA FROM PLANILLA.DBF WHERE FECHA > {^" & ConfigCorreo.CN_Correo.Converfecha(FechaLect) & "}"
            Dim da As New OleDbDataAdapter(sql, cnn)
            Dim ds As New DataSet
            da.Fill(ds, sql)
            Dim dt As DataTable = ds.Tables(sql)
            dtnew = dt
            dtnew.Columns.Add("Cantidad")
            dtnew.Columns.Add("Diferencia")

            For Each dr As DataRow In dtnew.Rows
                Dim cant As Integer = 0
                cant = ConfigCorreo.CN_Correo.ContarPlanillas(dr("recorrido"))
                dr("Cantidad") = cant
                dr("Diferencia") = dr("CANT_ITEM") - cant
            Next

            DgvPlanilla.DataSource = dtnew


        End Using



    End Sub
    Private Sub ObtenerEstadosyCantDiasEntrega()

        Dim TotalMes As Integer = 0


        Dim DTSumadeestados As New DataTable    '*****Cantidad*por*Estados*****
        DTSumadeestados.Columns.Add("Estado")
        DTSumadeestados.Columns.Add("Total")
        DTSumadeestados.Columns.Add("Porcentaje")

        Dim dtEntregadas As New DataTable       '****dias*de*entregadas********
        dtEntregadas.Columns.Add("Estado")
        dtEntregadas.Columns.Add("CantDias")
        Dim dtEntregadasresultadodias As New DataTable
        dtEntregadasresultadodias.Columns.Add("Estado")
        dtEntregadasresultadodias.Columns.Add("Dias")

        Dim Fechadesde As Date = DtpDesde.Value
        Dim FechaHasta As Date = DtpHasta.Value

        DTInformeMensual = ConfigCorreo.CN_Correo.ObtenerInformeMensual(Fechadesde.ToShortDateString, FechaHasta.ToShortDateString)
        TotalMes = DTInformeMensual.Rows.Count
        Dim ListaArray As New ArrayList
        For Each drw As DataRow In DTInformeMensual.Rows
            If Not ListaArray.Contains(drw("ESTADO")) Then
                ListaArray.Add(drw("ESTADO"))
            End If
        Next
        For i As Integer = 0 To ListaArray.Count - 1
            Dim contar As Integer = 0
            For Each drw As DataRow In DTInformeMensual.Rows
                If drw("Estado") = ListaArray.Item(i).ToString Then
                    contar = contar + 1
                End If
            Next
            DTSumadeestados.Rows.Add(ListaArray.Item(i).ToString, contar)
        Next


        For Each drw As DataRow In DTSumadeestados.Rows
            Dim valor As Double = drw("Total") * 100 / TotalMes
            drw("Porcentaje") = FormatNumber(valor, 2) & " %"
        Next

        DTSumadeestados.Rows.Add("Total", TotalMes, "100 %")

        For Each dr As DataRow In DTInformeMensual.Rows
            If dr("ESTADO") = "ENTREGADA" Then
                Dim FECHTRAB As Date = Nothing
                Dim FECHENTRE As Date = Nothing
                Dim DIFERENCIA As Integer = 0
                FECHTRAB = dr("FECH_TRAB")
                If dr("FECHA_ENTR") <> "" Then
                    FECHENTRE = dr("FECHA_ENTR")
                Else
                    FECHENTRE = FECHTRAB.AddDays(7)
                End If
                DIFERENCIA = FECHENTRE.Day - FECHTRAB.Day
                dtEntregadas.Rows.Add("ENTREGADA", DIFERENCIA)
            End If
        Next

        Dim Diasmenos10 As Integer = 0
        Dim Diashasta14 As Integer = 0
        Dim Diasmasde15 As Integer = 0

        For Each drw As DataRow In dtEntregadas.Rows
            If drw("CantDias") < 10 Then
                Diasmenos10 = Diasmenos10 + 1
            ElseIf drw("CantDias") > 10 And drw("CantDias") < 15 Then
                Diashasta14 = Diashasta14 + 1
            ElseIf drw("CantDias") > 14 Then
                Diasmasde15 = Diasmasde15 + 1
            End If
        Next

        dtEntregadasresultadodias.Rows.Add("Entregada menos de 10", Diasmenos10)
        dtEntregadasresultadodias.Rows.Add("Entregada hasta 14", Diashasta14)
        dtEntregadasresultadodias.Rows.Add("Entregada mas de 15", Diasmasde15)



        DgvResultado1.DataSource = dtEntregadasresultadodias
        Dgvcontador.DataSource = DTSumadeestados
        LblCantidad.Text = TotalMes
    End Sub
    Private Function XLS(ByVal Dgv As DataGridView)

        Try
            Dim exApp As New Microsoft.Office.Interop.Excel.Application
            Dim exLibro As Microsoft.Office.Interop.Excel.Workbook
            Dim exHoja As Microsoft.Office.Interop.Excel.Worksheet


            'Añadimos el Libro al programa, y la hoja al libro
            exLibro = exApp.Workbooks.Add
            exHoja = exLibro.Worksheets.Add()
            exHoja.Cells.NumberFormat = "@"
            ' ¿Cuantas columnas y cuantas filas?
            Dim NCol As Integer = Dgv.ColumnCount
            Dim NRow As Integer = Dgv.RowCount


            'Aqui recorremos todas las filas, y por cada fila todas las columnas y vamos escribiendo.
            For i As Integer = 1 To NCol
                exHoja.Cells.Item(1, i) = Dgv.Columns(i - 1).Name.ToString
            Next

            For Fila As Integer = 0 To NRow - 1
                For Col As Integer = 0 To NCol - 1
                    exHoja.Cells.Item(Fila + 2, Col + 1) = Dgv.Rows(Fila).Cells(Col).Value
                Next
            Next

            exLibro.Worksheets("Hoja1").Delete()
            exLibro.Worksheets("Hoja2").Delete()
            exLibro.Worksheets("Hoja3").Delete()
            exHoja.Name = "Informe"
            'exHoja.Cells.Item(1, 1) = "Nro_Carta"

            exHoja.Columns.AutoFit()
            exApp.Application.Visible = True

            exHoja = Nothing
            exLibro = Nothing
            exApp = Nothing

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al exportar a Excel")
        End Try

    End Function


    Private Sub Dgvcontador_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Dgvcontador.DoubleClick
        DgvEstados.DataSource = Nothing

        Dim dtNew As New DataTable
        dtNew.Columns.Add("Nro_Carta")
        Dim N As String = Dgvcontador.SelectedCells(0).RowIndex.ToString
        Dim STR As String = Dgvcontador.Rows(N).Cells("Estado").Value
        For Each drw As DataRow In DTInformeMensual.Rows
            If drw("Estado") = STR Then
                dtNew.Rows.Add(drw("Nro_Carta"))
            End If
        Next
        DgvEstados.DataSource = dtNew
    End Sub

    Private Sub BtnCarteros_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCarteros.Click
        Dim dt As New DataTable
        dt = ConfigCorreo.CN_Correo.ObtenerCarteros("01/01/2019", Now.ToShortDateString)
        DgvCarteros.DataSource = dt
        DgvCarteros.Sort(DgvCarteros.Columns(0), ListSortDirection.Ascending)

    End Sub
End Class
