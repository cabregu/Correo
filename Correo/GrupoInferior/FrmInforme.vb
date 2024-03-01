Imports ConfigCorreo.CN_Correo
Public Class FrmInforme



    Private Sub FrmInforme_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
 

        Dim DT As New DataTable
        DT = ConsultarEscaneo()

        For Each drw As DataRow In DT.Rows
            Dim Fech As Date = drw("Fecha_Entrega").ToString
            Dim Planilla As String = drw("Ruta_Archivo").ToString
            Planilla = Planilla.Substring(22, 6)
            Planilla = Planilla.Replace("\ ", "")

            DgvEscaneo.Rows.Add(drw("NroCartaLeido").ToString, "ESCANEADO", Fech.ToShortDateString, Planilla)
        Next



        'DgvEscaneo.DataSource = DT


    End Sub

    Private Sub Btnxls_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnxls.Click
        XLS()
    End Sub

    Private Function XLS()
 
        Try
            Dim exApp As New Microsoft.Office.Interop.Excel.Application
            Dim exLibro As Microsoft.Office.Interop.Excel.Workbook
            Dim exHoja As Microsoft.Office.Interop.Excel.Worksheet


            'Añadimos el Libro al programa, y la hoja al libro
            exLibro = exApp.Workbooks.Add
            exHoja = exLibro.Worksheets.Add()
            exHoja.Cells.NumberFormat = "@"
            ' ¿Cuantas columnas y cuantas filas?
            Dim NCol As Integer = DgvEscaneo.ColumnCount
            Dim NRow As Integer = DgvEscaneo.RowCount


            'Aqui recorremos todas las filas, y por cada fila todas las columnas y vamos escribiendo.
            For i As Integer = 1 To NCol
                exHoja.Cells.Item(1, i) = DgvEscaneo.Columns(i - 1).Name.ToString
            Next

            For Fila As Integer = 0 To NRow - 1
                For Col As Integer = 0 To NCol - 1
                    exHoja.Cells.Item(Fila + 2, Col + 1) = DgvEscaneo.Rows(Fila).Cells(Col).Value
                Next
            Next

            exLibro.Worksheets("Hoja1").Delete()
            exLibro.Worksheets("Hoja2").Delete()
            exLibro.Worksheets("Hoja3").Delete()
            exHoja.Name = "Informe"
            exHoja.Cells.Item(1, 1) = "Nro_Carta"

            exHoja.Columns.AutoFit()
            exApp.Application.Visible = True


            If MessageBox.Show("Actualizar las cartas informadas?", "Actualizar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                For Each drw As DataGridViewRow In DgvEscaneo.Rows
                    ActualizarCartaInformado(drw.Cells("Nro_carta").Value)
                Next
                MsgBox("OK")
            End If
            exHoja = Nothing
            exLibro = Nothing
            exApp = Nothing

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al exportar a Excel")
        End Try

        '        Dim cadena As New System.Text.StringBuilder
        '        For Each dgw As DataGridViewRow In DgvVisitadas.Rows
        '            cadena.AppendLine(dgw.Cells("socio").Value & ";" & dgw.Cells("integrante").Value & ";" & dgw.Cells("lote").Value.Substring(3, 4) & ";6;" & dgw.Cells("fech1").Value)
        '        Next
        '        Dim texto As String
        '        texto = cadena.ToString
        '        Dim objEscritor As IO.StreamWriter
        '        objEscritor = IO.File.AppendText("C:\temp\Visitadas_" & NroVisit & "_" & FechaTx & ".txt")
        '        objEscritor.Write(texto)
        '        objEscritor.Close()
        '        ActualizarNroVisitada(NroVisit + 1)




        '        If MessageBox.Show("Enviar mail", "Enviar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then


        '            If enviaCorreo("C:\temp\Visitadas_" & NroVisit & "_" & FechaTx & ".xls", "C:\temp\Visitadas_" & NroVisit & "_" & FechaTx & ".txt", "Archivo Visitadas_Nro_" & NroVisit) = True Then


        '                Dim cadenavisitadas As New System.Text.StringBuilder
        '                For Each drw As DataGridViewRow In DgvVisitadas.Rows
        '                    Dim txtsql As String = ""

        '                    txtsql = "(" & "'" & drw.Cells("socio").Value & "' , " _
        '                        & "'" & drw.Cells("lote").Value & "'" & ", " _
        '                        & "'" & drw.Cells("integrante").Value & "'" & ", " _
        '                        & "'" & Converfecha(drw.Cells("fech_trab").Value) & "'" & ", " _
        '                        & "'" & drw.Cells("apellido").Value & "'" & ", " _
        '                        & "'" & drw.Cells("calle").Value & "'" & ", " _
        '                        & "'" & drw.Cells("cp").Value & "'" & ", " _
        '                        & "'" & drw.Cells("localidad").Value & "'" & ", " _
        '                        & "'" & drw.Cells("fech1").Value & "'" & ", " _
        '                        & "'" & drw.Cells("tema1").Value & "'" & ", " _
        '                        & "'" & drw.Cells("fech2").Value & "'" & ", " _
        '                        & "'" & drw.Cells("tema2").Value & "'" & ", " _
        '                        & "'" & drw.Cells("nro_carta").Value & "'" & ", " _
        '                        & "'" & drw.Cells("remitente").Value & "'" & ", " _
        '                        & "'" & NroVisit & "'" & ", " _
        '                        & "'" & FechaTx & "'" & ")" & ", "

        '                    cadenavisitadas.Append(txtsql)
        '                Next
        '                Dim Archtxt3 As String

        '                Archtxt3 = cadenavisitadas.ToString
        '                If Len(Archtxt3) > 0 Then
        '                    Archtxt3 = Mid(Archtxt3, 1, Len(Archtxt3) - 2)
        '                End If

        '                ConfigCorreo.CN_Correo.InstertarVisitadas(Archtxt3)

        '            Else

        '                MsgBox("No se envio mail")

        '            End If

        '        End If




        'Else
        '    MsgBox("Sin Datos")
        'End If


    End Function

  
End Class
