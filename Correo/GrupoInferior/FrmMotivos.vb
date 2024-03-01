Public Class FrmMotivos

    Private Sub FrmMotivos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cargarmotivos()
    End Sub

    Private Sub Cargarmotivos()
        Dim DtMotivos As New DataTable
        DtMotivos = ConfigCorreo.CN_Correo.ObtenerMotivos
        DgvMotivos.DataSource = DtMotivos
    End Sub


    Private Sub BtnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnActualizar.Click
        For Each drw As DataGridViewRow In DgvMotivos.Rows
            If ConfigCorreo.CN_Correo.VerificarSiEstaCreadoElMotivo(drw.Cells("id").Value) = True Then
                ConfigCorreo.CN_Correo.ActualizarMotivos(drw.Cells("idmotivo").Value, drw.Cells("motivo").Value, drw.Cells("reprogramacion").Value, drw.Cells("id").Value)

            End If
        Next
        MsgBox("FINALIZADO")
        BtnActualizar.Enabled = False

    End Sub

    Private Sub BtnExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExcel.Click
        Xls()
    End Sub
    Private Sub Xls()
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
            Dim NCol As Integer = DgvMotivos.ColumnCount
            Dim NRow As Integer = DgvMotivos.RowCount


            'Aqui recorremos todas las filas, y por cada fila todas las columnas y vamos escribiendo.
            For i As Integer = 1 To NCol
                exHoja.Cells.Item(1, i) = DgvMotivos.Columns(i - 1).Name.ToString
                'exHoja.Cells.Item(1, i).HorizontalAlignment = 3
            Next

            For Fila As Integer = 0 To NRow - 1
                For Col As Integer = 0 To NCol - 1
                    exHoja.Cells.Item(Fila + 2, Col + 1) = DgvMotivos.Rows(Fila).Cells(Col).Value
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

  
    Private Sub BtnIngresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnIngresar.Click
        If Txtident.Text <> "" Or TxtMotivo.Text <> "" Or CmbReprogramacion.Text <> "" Then

            ConfigCorreo.CN_Correo.InsertarMotivos(Txtident.Text, TxtMotivo.Text, CmbReprogramacion.Text)
            Txtident.Text = ""
            TxtMotivo.Text = ""
            CmbReprogramacion.Text = ""
            MsgBox("ok")
            Cargarmotivos()
        Else
            MsgBox("Debe cargar todos los campos")

        End If
    End Sub
End Class
