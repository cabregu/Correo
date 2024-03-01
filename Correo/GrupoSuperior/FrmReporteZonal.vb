Imports ConfigCorreo.CN_Correo

Public Class FrmReporteZonal


    Dim arrayplanillas As New ArrayList

    Private Sub FrmReporteZonal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ArrayCarteros As New ArrayList
        ArrayCarteros = ConfigCorreo.CN_Correo.CargarCarteros
        CmbCartero.Items.Clear()
        CmbCartero.Enabled = True
        For i As Integer = 0 To ArrayCarteros.Count - 1
            CmbCartero.Items.Add(ArrayCarteros.Item(i).ToString)
        Next
    End Sub
    Private Sub BtnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscar.Click
        Dgvdatos.DataSource = Nothing
        DgvCalculo.DataSource = Nothing
        If CmbCartero.Text <> "" Then
            Dim dt As New DataTable

            dt = ConfigCorreo.CN_Correo.CargarRecorridosCarteroFecha(CmbCartero.Text, DtpDesde.Value.ToShortDateString, DtpHasta.Value.ToShortDateString)
            LblCant.Text = ""
            LblCant.Text = dt.Rows.Count
            Dgvdatos.DataSource = Nothing
            Dgvdatos.DataSource = dt
            TxtDat.Text = ""
            Txttotal.Text = ""

        End If

    End Sub
    Private Sub BtnExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExcel.Click
        Excel()
    End Sub
    Private Sub Excel()
        'Creamos las variables
        Try
            Dim exApp As New Microsoft.Office.Interop.Excel.Application
            Dim exLibro As Microsoft.Office.Interop.Excel.Workbook
            Dim exHoja As Microsoft.Office.Interop.Excel.Worksheet


            'Añadimos el Libro al programa, y la hoja al libro
            exLibro = exApp.Workbooks.Add
            exHoja = exLibro.Worksheets.Add()
            exHoja.Cells.NumberFormat = "@"
            ' ¿Cuantas columnas y cuantas filas?
            Dim NCol As Integer = Dgvdatos.ColumnCount
            Dim NRow As Integer = Dgvdatos.RowCount


            'Aqui recorremos todas las filas, y por cada fila todas las columnas y vamos escribiendo.
            For i As Integer = 1 To NCol
                exHoja.Cells.Item(1, i) = Dgvdatos.Columns(i - 1).Name.ToString
                'exHoja.Cells.Item(1, i).HorizontalAlignment = 3
            Next

            For Fila As Integer = 0 To NRow - 1
                For Col As Integer = 0 To NCol - 1
                    exHoja.Cells.Item(Fila + 2, Col + 1) = Dgvdatos.Rows(Fila).Cells(Col).Value
                Next
            Next
            'Titulo en negrita, Alineado al centro y que el tamaño de la columna se
            'ajuste al texto

            'exHoja.Rows.Item(5).Font.Bold = 1
            'exHoja.Rows.Item(5).HorizontalAlignment = 3
            exHoja.Columns.AutoFit()



            'Aplicación visible
            exApp.Application.Visible = True

            exHoja = Nothing
            exLibro = Nothing
            exApp = Nothing

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al exportar a Excel")

        End Try

    End Sub
    Private Sub BtnEstadistica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEstadistica.Click
        Dim ArrayEstados As New ArrayList
        For Each drws As DataGridViewRow In Dgvdatos.Rows
            If Not ArrayEstados.Contains(drws.Cells("Estado").Value) Then
                ArrayEstados.Add(drws.Cells("Estado").Value)
            End If
        Next
        Dim ArrayestadosYCantidades As New ArrayList


        For i As Integer = 0 To ArrayEstados.Count - 1
            Dim Cant As Integer = 0
            For Each dw As DataGridViewRow In Dgvdatos.Rows
                If dw.Cells("Estado").Value = ArrayEstados.Item(i).ToString Then
                    Cant = Cant + 1
                End If
            Next
            ArrayestadosYCantidades.Add(ArrayEstados.Item(i).ToString & "  -  " & Cant)
            Cant = 0
        Next


        For d As Integer = 0 To ArrayestadosYCantidades.Count - 1
            TxtDat.Text += ArrayestadosYCantidades.Item(d).ToString & vbCrLf
        Next

    End Sub
    Private Sub BtnCalculoCash_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCalculoCash.Click

        For Each drw As DataGridViewRow In Dgvdatos.Rows
            If Not arrayplanillas.Contains(drw.Cells("planilla_recorrido").Value) Then
                arrayplanillas.Add(drw.Cells("planilla_recorrido").Value)
            End If
        Next
        Dim DtCash As New DataTable
        DtCash.Columns.Add("Distribuidor")
        DtCash.Columns.Add("Nro Planilla")
        DtCash.Columns.Add("Fecha recorrido")
        DtCash.Columns.Add("Servicio")
        DtCash.Columns.Add("Cantidad")
        DtCash.Columns.Add("Precio Unitario")
        DtCash.Columns.Add("Subtotal")
        DtCash.Columns.Add("SinRendir")






        For i As Integer = 0 To arrayplanillas.Count - 1
            Dim datosservico As New DataTable
            datosservico = ObtenerServisoSimpleConAcuse(arrayplanillas.Item(i).ToString)
            Dim nroplanilla As String = arrayplanillas.Item(i).ToString
            Dim cantidad As Integer = datosservico.Rows(0)("cantidad").ToString
            Dim servicio As String = datosservico.Rows(0)("servicio").ToString()
            Dim fecharecorrido As Date = datosservico.Rows(0)("fecharecorrido").ToString()
            Dim preciounitario As Decimal = ObtenerPrecioPorCartero(CmbCartero.Text, servicio)
            Dim cantidadendistrib As Integer = Obtenercantidadesendistrib(nroplanilla)


            DtCash.Rows.Add(CmbCartero.Text, nroplanilla, fecharecorrido.ToShortDateString, servicio, cantidad, preciounitario, cantidad * preciounitario, cantidadendistrib)

        Next

        DgvCalculo.DataSource = Nothing
        DgvCalculo.DataSource = DtCash

        Dim suma As Decimal = "0.00"
        For Each drgv As DataGridViewRow In DgvCalculo.Rows
            suma += drgv.Cells("Subtotal").Value
        Next
        Txttotal.Text = suma.ToString("0.000")



        arrayplanillas.Clear()


    End Sub

  
    Private Sub BtnExcelControl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExcelControl.Click
        Try
            Dim exApp As New Microsoft.Office.Interop.Excel.Application
            Dim exLibro As Microsoft.Office.Interop.Excel.Workbook
            Dim exHoja As Microsoft.Office.Interop.Excel.Worksheet


            'Añadimos el Libro al programa, y la hoja al libro
            exLibro = exApp.Workbooks.Add
            exHoja = exLibro.Worksheets.Add()
            exHoja.Cells.NumberFormat = "@"
            ' ¿Cuantas columnas y cuantas filas?
            Dim NCol As Integer = DgvCalculo.ColumnCount
            Dim NRow As Integer = DgvCalculo.RowCount


            'Aqui recorremos todas las filas, y por cada fila todas las columnas y vamos escribiendo.
            For i As Integer = 1 To NCol
                exHoja.Cells.Item(1, i) = DgvCalculo.Columns(i - 1).Name.ToString
                'exHoja.Cells.Item(1, i).HorizontalAlignment = 3
            Next

            For Fila As Integer = 0 To NRow - 1
                For Col As Integer = 0 To NCol - 1
                    exHoja.Cells.Item(Fila + 2, Col + 1) = DgvCalculo.Rows(Fila).Cells(Col).Value
                Next
            Next
            'Titulo en negrita, Alineado al centro y que el tamaño de la columna se
            'ajuste al texto

            'exHoja.Rows.Item(5).Font.Bold = 1
            'exHoja.Rows.Item(5).HorizontalAlignment = 3
            exHoja.Columns.AutoFit()



            'Aplicación visible
            exApp.Application.Visible = True

            exHoja = Nothing
            exLibro = Nothing
            exApp = Nothing

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al exportar a Excel")

        End Try

    End Sub
End Class
