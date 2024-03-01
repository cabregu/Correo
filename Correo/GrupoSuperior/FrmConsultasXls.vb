Imports System.Data.OleDb
Imports System.IO
Imports ConfigCorreo.CN_Correo


Public Class FrmConsultasXls

    Private Sub BtnExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExcel.Click
        Seleccionar()
    End Sub
    Private Sub BtnXls_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnXls.Click
        Excel()
    End Sub




    Private Sub Seleccionar()

        Dim openFD As New OpenFileDialog()
        With openFD
            .Title = "Seleccionar archivos"
            .Filter = "Todos los archivos (*.xls)|*.xls"
            .Multiselect = False
            .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                If impExcel(.FileName) = True Then
                    txtPath.Text = Path.GetFileName(.FileName)
                End If
            Else
                openFD.Dispose()
            End If
        End With

    End Sub
    Private Function impExcel(ByVal Archivo As String) As Boolean

        Try
            Dim dt2 As New DataTable
            Dim strconn As String
            strconn = "Provider=Microsoft.Jet.Oledb.4.0; data source= " + Archivo + ";Extended properties=""Excel 8.0;hdr=yes;imex=1"""
            Dim mconn As New OleDbConnection(strconn)
            Dim ad As New OleDbDataAdapter("Select * from [" & "Hoja1" & "$]", mconn)
            mconn.Open()
            ad.Fill(dt2)
            mconn.Close()

            dt2.Columns.Add("NroCarta")
            dt2.Columns.Add("Fech_trab")
            dt2.Columns.Add("EstadoF")
            dt2.Columns.Add("FechaVisit")
            dt2.Columns.Add("FechaEntre")
            dt2.Columns.Add("FechaEnTransito")

            DgvDatos.DataSource = dt2
        Catch ex As Exception

        End Try

    End Function
    Private Function Excel()
        'Agregar referencia Microsoft.Office.Interop.Excel()
        'Creamos las variables
        Dim exApp As New Microsoft.Office.Interop.Excel.Application
        Dim exLibro As Microsoft.Office.Interop.Excel.Workbook
        Dim exHoja As Microsoft.Office.Interop.Excel.Worksheet

        Try
            'Añadimos el Libro al programa, y la hoja al libro
            exLibro = exApp.Workbooks.Add
            exHoja = exLibro.Worksheets.Add()
            exHoja.Cells.NumberFormat = "@"
            ' ¿Cuantas columnas y cuantas filas?
            Dim NCol As Integer = DgvDatos.ColumnCount
            Dim NRow As Integer = DgvDatos.RowCount


            'Aqui recorremos todas las filas, y por cada fila todas las columnas y vamos escribiendo.
            For i As Integer = 1 To NCol
                exHoja.Cells.Item(1, i) = DgvDatos.Columns(i - 1).Name.ToString
                'exHoja.Cells.Item(1, i).HorizontalAlignment = 3
            Next

            For Fila As Integer = 0 To NRow - 1
                For Col As Integer = 0 To NCol - 1
                    exHoja.Cells.Item(Fila + 2, Col + 1) = DgvDatos.Rows(Fila).Cells(Col).Value
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

    End Function

    Private Sub BNBUSCAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BNBUSCAR.Click
        Dim Numero As Integer = 0
        PgbAnalisis.Minimum = 0
        PgbAnalisis.Maximum = DgvDatos.Rows.Count


        For Each dr As DataGridViewRow In DgvDatos.Rows
            Dim dt As New DataTable
            Dim Socio As String = dr.Cells("asociado").Value
            Dim LOTE As String = dr.Cells("lote").Value
            LOTE = LOTE.TrimStart("0")
            dt = ObtenerMAXIMA(Socio, LOTE)

            If dt Is Nothing Then
                dr.Cells("ESTADO").Value = "NO_ENCONTRADO"
            Else
                For Each drw As DataRow In dt.Rows
                    'If drw("NRO_CART2").ToString.Contains(LOTE) Then


                    Dim FechaEntregada As String = Normalizar(VerificarSiFueEntregadaEnDiario(dr.Cells("asociado").Value, dr.Cells("lote").Value))
                    'Dim FechaEnTransito As String = Normalizar(VerificarSiFueEntregadaEnTransito(dr.Cells("asociado").Value, dr.Cells("lote").Value))
                    'Dim Fech As String = VerificarVisitada(dr.Cells("asociado").Value, dr.Cells("lote").Value.ToString.TrimStart("0"))

                    dr.Cells("NROCARTA").Value = drw("NRO_CARTA").ToString
                    dr.Cells("FECH_TRAB").Value = drw("FECH_TRAB").ToString
                    '    dr.Cells("ESTADOF").Value = drw("ESTADO").ToString
                    '    'If Len(Fech) > 0 Then
                    '    dr.Cells("FECHAVISIT").Value = Fech
                    'End If
                    'dr.Cells("FECHAENTRE").Value = FechaEntregada
                    'dr.Cells("FECHAENTRANSITO").Value = FechaEnTransito

                    ''
                    'End If
                Next
            End If
            Numero = Numero + 1
            PgbAnalisis.Value = Numero
        Next
        PgbAnalisis.Value = 0





    End Sub
End Class
