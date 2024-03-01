Public Class FrmConfiguracion

    'Private Sub FrmConfiguracion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    '    Dim Ruta As String
    '    Ruta = ConfigCorreo.CN_Correo.ObtenerRutaDBF
    '    TxtRutaDbf.Text = Ruta

    'End Sub

    'Private Sub BtnActualizarRuta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If ConfigCorreo.CN_Correo.ActualizarRutaDBF(TxtRutaDbf.Text) = True Then
    '        MsgBox("OK")
    '    End If
    'End Sub

    Private Sub BtnFeriados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFeriados.Click
        FrmCargaFeriado.ShowDialog()
    End Sub

    Private Sub BtncargarDatos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtncargarDatos.Click

        BtncargarDatos.Enabled = False
        DgvControl.Rows.Clear()
        DgvControl.DataSource = ConfigCorreo.CN_Correo.ObtenerRutas

        If Not DgvControl.Columns.Contains("Existencia") Then
            DgvControl.Columns.Add("Existencia", "Existencia")
        End If
       
    End Sub


 
    Private Sub BtnVerificarArchivos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVerificarArchivos.Click
        BtnVerificarArchivos.Enabled = False

        For Each drw As DataGridViewRow In DgvControl.Rows
            drw.Cells("Existencia").Value = VerificarRuta(drw.Cells("Ruta_Archivo").Value)
        Next
        BtnVerificarArchivos.Enabled = False

    End Sub


    Public Function VerificarRuta(ByVal Ruta As String) As String


        If System.IO.File.Exists(Ruta) = True Then
            Ruta = Ruta
            Return Ruta
        Else
            If System.IO.File.Exists(Trim(Ruta)) = True Then
                Return "Trim-" & Trim(Ruta)

            Else
                Ruta = Ruta.Replace(" ", "")
                If System.IO.File.Exists(Ruta) = True Then
                    Return "Espacio" & Ruta
                End If

            End If


        End If



    End Function




    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
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
            Dim NCol As Integer = DgvControl.ColumnCount
            Dim NRow As Integer = DgvControl.RowCount


            'Aqui recorremos todas las filas, y por cada fila todas las columnas y vamos escribiendo.
            For i As Integer = 1 To NCol
                exHoja.Cells.Item(1, i) = DgvControl.Columns(i - 1).Name.ToString
            Next

            For Fila As Integer = 0 To NRow - 1
                For Col As Integer = 0 To NCol - 1
                    exHoja.Cells.Item(Fila + 2, Col + 1) = DgvControl.Rows(Fila).Cells(Col).Value
                Next
            Next

            exLibro.Worksheets("Hoja1").Delete()
            exLibro.Worksheets("Hoja2").Delete()
            exLibro.Worksheets("Hoja3").Delete()
            exHoja.Name = "Informe"
            exHoja.Cells.Item(1, 1) = "Nro_Carta"

            exHoja.Columns.AutoFit()
            exApp.Application.Visible = True


            'If MessageBox.Show("Actualizar las cartas informadas?", "Actualizar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            '    For Each drw As DataGridViewRow In DgvControl.Rows
            '        ActualizarCartaInformado(drw.Cells("Nro_carta").Value)
            '    Next
            '    MsgBox("OK")
            'End If
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
