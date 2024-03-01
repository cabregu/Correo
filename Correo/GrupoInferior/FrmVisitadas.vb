Imports System.Data.OleDb
Imports ConfigCorreo.CN_Correo
Imports ConfigCorreo.zipcomp
Imports Microsoft.Office.Interop


Public Class FrmVisitadas
    Public dtnew As New DataTable

   
 


 
    Private Shared Function Normalizar(ByVal Dato As String) As String
        Dato = Dato.Replace("-", "")
        Dato = Dato.Replace("  ", "")
        Dato = Dato.Replace("30/12/1899", "")
        Dato = Dato.Replace(" 0:00:00", "")
        Dato = Dato.Replace("'", "")
        Dato = Dato.Replace(",", "")
        Dato = Dato.Replace(" 12:00:00 a.m.", "")

        Return Dato
    End Function


    Private Sub BtnCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCalcular.Click
        BtnCalcular.Enabled = False


        Dim FechaV As Date = Nothing
        Dim fechadesdedistrib As Date = Now.ToShortDateString
        fechadesdedistrib = fechadesdedistrib.AddDays(-45)
        fechadesdedistrib = fechadesdedistrib.ToShortDateString
        Dim fechacons As String = Converfecha(fechadesdedistrib)




        Dim Dtn As New DataTable
        Dtn = ObtenerVisitadas(fechacons)
        Dtn.Columns.Add("fech1")
        Dtn.Columns.Add("tema1")
        Dtn.Columns.Add("fech2")
        Dtn.Columns.Add("tema2")
        Dtn.Columns.Add("Socio")
        Dtn.Columns.Add("Lote")
        Dtn.Columns.Add("Integrante")

        Dim DtVisiTr As New DataTable
        DtVisiTr = BuscarPorNrosocioDtTransito()
        Dim ArraytransVisit As New ArrayList


        For Each drwt As DataRow In DtVisiTr.Rows
            ArraytransVisit.Add(drwt("nro_carta"))
        Next

        For Each dr As DataRow In Dtn.Rows
            FechaV = dr("FECHA_TRABAJO")
            FechaV = FechaV.ToShortDateString

            If IsNumeric(dr("CP")) Then
                FechaV = FechaV.AddDays(ObtenerCantDiasCP(dr("CP")))
            Else
                FechaV = FechaV.AddDays(3)
            End If

            FechaV = AgregardiaFeriado(FechaV)
            FechaV = Sabadoydomingo(FechaV)
            FechaV = AgregardiaFeriado(FechaV)
            Dim fechahoy As Date = Now.ToShortDateString
            If FechaV > fechahoy Then
                FechaV = fechahoy
            End If

            FechaV = AgregardiaFeriado(FechaV.ToShortDateString)
            dr("Fech1") = FechaV.ToShortDateString
            dr("tema1") = "21-Visitado"


            If Len(dr("NRO_CART2")) > 15 Then
                Dim NroCart2 As String = dr("NRO_CART2")

                Dim Socio As String
                Dim Lote As String
                Dim integrante As String
                Socio = NroCart2.Substring(0, 7)
                Lote = NroCart2.Substring(8, 7)
                integrante = NroCart2.Substring(16, Len(NroCart2) - 16)
                dr("Socio") = Socio
                dr("Lote") = Lote
                dr("Integrante") = integrante
            End If
        Next

            For Each drw As DataRow In Dtn.Rows
                Dim fechtrab As Date = drw("fecha_trabajo")
                fechtrab = fechtrab.ToShortDateString

            If Len(drw("NRO_CART2")) > 15 Then
                If VerificarVisitadaEnElDiario(drw("nro_carta").ToString) = False Then
                    If Not ArraytransVisit.Contains(drw("nro_carta")) Then
                        DgvVisitadas.Rows.Add(drw("socio"), drw("lote").ToString.TrimStart("0"), drw("integrante"), Normalizar(fechtrab.ToString), drw("apellido"), drw("calle"), drw("cp"), drw("localidad"), drw("Fech1"), drw("Tema1"), "", "", drw("nro_carta"), drw("remitente"))
                    End If
                End If
            End If

            Next

            Lblcantidad.Text = DgvVisitadas.Rows.Count
            BtnCalcular.Enabled = True



    End Sub

    Private Sub BtnXls_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGeneraryenviar.Click

        If DgvVisitadas.Rows.Count > 1 Then

            Try
                Dim exApp As New Microsoft.Office.Interop.Excel.Application
                Dim exLibro As Microsoft.Office.Interop.Excel.Workbook
                Dim exHoja As Microsoft.Office.Interop.Excel.Worksheet


                'Añadimos el Libro al programa, y la hoja al libro
                exLibro = exApp.Workbooks.Add
                exHoja = exLibro.Worksheets.Add()
                exHoja.Cells.NumberFormat = "@"
                ' ¿Cuantas columnas y cuantas filas?
                Dim NCol As Integer = DgvVisitadas.ColumnCount
                Dim NRow As Integer = DgvVisitadas.RowCount


                'Aqui recorremos todas las filas, y por cada fila todas las columnas y vamos escribiendo.
                For i As Integer = 1 To NCol
                    exHoja.Cells.Item(1, i) = DgvVisitadas.Columns(i - 1).Name.ToString
                Next

                For Fila As Integer = 0 To NRow - 1
                    For Col As Integer = 0 To NCol - 1
                        exHoja.Cells.Item(Fila + 2, Col + 1) = DgvVisitadas.Rows(Fila).Cells(Col).Value
                    Next
                Next

                exHoja.Columns.AutoFit()
                exApp.Application.Visible = False
                Dim NroVisit As Integer
                NroVisit = ObtenerNroVisitada()
                Dim FechaTx As String = Now.ToShortDateString
                FechaTx = FechaTx.Replace("/", "-")

                exLibro.SaveAs("C:\temp\Visitadas_" & NroVisit & "_" & FechaTx & ".xls")

                exLibro.Close()
                exHoja = Nothing
                exLibro = Nothing
                exApp = Nothing


                Dim cadena As New System.Text.StringBuilder
                For Each dgw As DataGridViewRow In DgvVisitadas.Rows
                    cadena.AppendLine(dgw.Cells("socio").Value & ";" & dgw.Cells("integrante").Value & ";" & dgw.Cells("lote").Value & ";6;" & dgw.Cells("fech1").Value)
                Next
                Dim texto As String
                texto = cadena.ToString
                Dim objEscritor As IO.StreamWriter
                objEscritor = IO.File.AppendText("C:\temp\Visitadas_" & NroVisit & "_" & FechaTx & ".txt")
                objEscritor.Write(texto)
                objEscritor.Close()
                ActualizarNroVisitada(NroVisit + 1)




                If MessageBox.Show("Enviar mail", "Enviar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then


                    If enviaCorreo("C:\temp\Visitadas_" & NroVisit & "_" & FechaTx & ".xls", "C:\temp\Visitadas_" & NroVisit & "_" & FechaTx & ".txt", "Archivo Visitadas_Nro_" & NroVisit) = True Then


                        Dim cadenavisitadas As New System.Text.StringBuilder
                        For Each drw As DataGridViewRow In DgvVisitadas.Rows
                            Dim txtsql As String = ""

                            txtsql = "(" & "'" & drw.Cells("socio").Value & "' , " _
                                & "'" & drw.Cells("lote").Value & "'" & ", " _
                                & "'" & drw.Cells("integrante").Value & "'" & ", " _
                                & "'" & Converfecha(drw.Cells("fech_trab").Value) & "'" & ", " _
                                & "'" & drw.Cells("apellido").Value & "'" & ", " _
                                & "'" & drw.Cells("calle").Value & "'" & ", " _
                                & "'" & drw.Cells("cp").Value & "'" & ", " _
                                & "'" & drw.Cells("localidad").Value & "'" & ", " _
                                & "'" & drw.Cells("fech1").Value & "'" & ", " _
                                & "'" & drw.Cells("tema1").Value & "'" & ", " _
                                & "'" & drw.Cells("fech2").Value & "'" & ", " _
                                & "'" & drw.Cells("tema2").Value & "'" & ", " _
                                & "'" & drw.Cells("nro_carta").Value & "'" & ", " _
                                & "'" & drw.Cells("remitente").Value & "'" & ", " _
                                & "'" & NroVisit & "'" & ", " _
                                & "'" & FechaTx & "'" & ")" & ", "

                            cadenavisitadas.Append(txtsql)
                        Next
                        Dim Archtxt3 As String

                        Archtxt3 = cadenavisitadas.ToString
                        If Len(Archtxt3) > 0 Then
                            Archtxt3 = Mid(Archtxt3, 1, Len(Archtxt3) - 2)
                        End If

                        ConfigCorreo.CN_Correo.InstertarVisitadas(Archtxt3)

                    Else

                        MsgBox("No se envio mail")

                    End If

                End If


            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al exportar a Excel")
            End Try

        Else
            MsgBox("Sin Datos")
        End If

    End Sub


    Private Function enviaCorreo(ByVal Archivo As String, ByVal Archivo2 As String, ByVal Asunto As String) As Boolean

        Return True
        'Try
        '    Dim oApp As Outlook._Application
        '    oApp = New Outlook.Application()

        '    Dim oMsg As Outlook._MailItem
        '    oMsg = oApp.CreateItem(Outlook.OlItemType.olMailItem)
        '    oMsg.Subject = Asunto
        '    oMsg.Body = ""
        '    '"Se adjunta Archivo de Visitadas"

        '    'Dim Destinatarios As String = ""

        '    'Dim ArrayDestinatarios As New ArrayList
        '    'ArrayDestinatarios = MailsparaEnvio("")

        '    'For i As Integer = 0 To ArrayDestinatarios.Count - 1
        '    'Destinatarios = Destinatarios & ArrayDestinatarios.Item(i).ToString & " ;"
        '    'Next
        '    'Dim DtMails As New DataTable
        '    'DtMails = ObtenerMailClientes("SWISS")
        '    'For Each dtr As DataRow In DtMails.Rows
        '    '    Destinatarios = Destinatarios & dtr("email").ToString & " ;"
        '    '    'Correo.To.Add(dtr("email").ToString)
        '    'Next
        '    'Destinatarios = Destinatarios.Substring(0, Len(Destinatarios) - 2)


        '    oMsg.To = "romina.arrieta@swissmedical.com.ar; AlejandroAdrian.Mangione@swissmedical.com.ar"
        '    oMsg.CC = "Jorge.Baragiola@swissmedical.com.ar; Maximiliano.Mastrachio@swissmedical.com.ar; AldanaAyelen.Robles@swissmedical.com.ar; operaciones@lexs.com.ar; guillermo.a@lexs.com.ar; seguimiento@lexs.com.ar; planificacion@lexs.com.ar"

        '    Dim sSource As String = Archivo
        '    Dim sSource2 As String = Archivo2
        '    Dim sDisplayName As String = "Archivo"
        '    'Dim sBodyLen As String = oMsg.Body.Length
        '    Dim oAttachs As Outlook.Attachments = oMsg.Attachments
        '    Dim oAttach As Outlook.Attachment

        '    oAttach = oAttachs.Add(sSource)
        '    oAttach = oAttachs.Add(sSource2)
        '    oMsg.Save()


        '    'oMsg.Send()
        '    'oApp = Nothing
        '    'oMsg = Nothing
        '    'oAttach = Nothing
        '    'oAttachs = Nothing
        '    Return True


        'Catch ex As Exception
        '    Return False

        '    MsgBox(ex.ToString)

        'End Try

    End Function

End Class
