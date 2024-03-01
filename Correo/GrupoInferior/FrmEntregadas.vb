Imports System.Data.OleDb
Imports ConfigCorreo.CN_Correo
Imports ConfigCorreo.zipcomp
Imports Microsoft.Office.Interop
Public Class FrmEntregadas
    Public dtnew As New DataTable

    Private Shared Function Normalizar(ByVal Dato As String) As String
        If Not Dato = Nothing Then
            Dato = Dato.Replace("-", "")
            Dato = Dato.Replace("30/12/1899", "")
            Dato = Dato.Replace("'", "")
            Dato = Dato.Replace(",", "")
            Dato = Dato.Replace("12:00:00 a.m.", "")
            Dato = Dato.Replace("01/01/0001", "")
            Dato = Dato.Replace("  ", "")
            Dato = Dato.Replace(" 12:00:00 a.m.", "")
            Dato = Dato.Replace("0:00:00", "")

            Return Dato
        Else
            Return ""
        End If


    End Function
    Private Function enviaCorreo(ByVal Archivo As String, ByVal Archivo2 As String, ByVal Asunto As String) As Boolean


        'Try
        '    Dim oApp As Outlook._Application
        '    oApp = New Outlook.Application()

        '    Dim oMsg As Outlook._MailItem
        '    oMsg = oApp.CreateItem(Outlook.OlItemType.olMailItem)
        '    oMsg.Subject = Asunto
        '    oMsg.Body = ""
        '    '"Se adjunta Archivo de Entregadas"

        '    Dim Destinatarios As String = ""

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
        Return True

        'MsgBox(ex.ToString)

        'End Try

    End Function
    Private Sub BtnGeneraryenviar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGeneraryenviar.Click
        If ChkAyudaAdmin.CheckState = CheckState.Checked Then
            If MessageBox.Show("Bajar Con Ayuda de errores?", "Desea bajar con ayuda de errores?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                Ejecutar()
            End If
        Else
            Ejecutar()
        End If



    End Sub
    Private Sub BtnCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCalcular.Click
        BtnCalcular.Enabled = False
        DgvEntregadas.Rows.Clear()
        Dim FechaDesdeEntreg As Date = Now.ToShortDateString
        FechaDesdeEntreg = FechaDesdeEntreg.AddDays(-60)
        FechaDesdeEntreg = FechaDesdeEntreg.ToShortDateString
        Dim fechatexto As String = Converfecha(FechaDesdeEntreg)
        Dim Dtn As New DataTable
        Dtn = ObtenerEntregadas(fechatexto)

        Dtn.Columns.Add("Socio")
        Dtn.Columns.Add("Lote")
        Dtn.Columns.Add("Integrante")

        Dim DtTransito As New DataTable

        DtTransito = BuscarPorNrosocioDtTransitoEntregadas()


        For Each dr As DataRow In Dtn.Rows
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


                If VerificarSiFueEntregadaEnDiarioParaDiario(dr("Nro_carta").ToString) = False Then
                    If BuscarEnDT(dr("Nro_Carta").ToString, DtTransito) = False Then
                        DgvEntregadas.Rows.Add(Socio, Lote.ToString.TrimStart("0"), dr("integrante"), Normalizar(dr("Fech_Trab")), dr("apellido"), dr("calle"), dr("cp"), dr("localidad"), "", "", "", "", "", dr("Nro_Carta").ToString, dr("remitente"), "", "")

                    End If

                End If



            End If
        Next
        Lblcantidad.Text = DgvEntregadas.Rows.Count
        '**********************************************************


        For Each drdgwv As DataGridViewRow In DgvEntregadas.Rows
            Dim Fecha1 As String = ObtenerPrimeraVisitaEnRecorrido(drdgwv.Cells("nro_carta").Value)
            If Len(Fecha1) > 0 Then
                drdgwv.Cells("Fech1").Value = Fecha1
                drdgwv.Cells("Tema1").Value = "21-Visitado"
            End If
        Next


        For Each drdgw As DataGridViewRow In DgvEntregadas.Rows
            drdgw.Cells("fecha_entr").Value = ObtenerFechaEntregadaEnRecorrido(drdgw.Cells("nro_carta").Value)

        Next



        ''*********************obtiene fechas CP*************************************
        For Each drdgw2 As DataGridViewRow In DgvEntregadas.Rows
            Dim FechaCP As Date
            FechaCP = drdgw2.Cells("FECH_TRAB").Value
            If Not IsNumeric(drdgw2.Cells("CP").Value) Then
                Try
                    FechaCP = FechaCP.AddDays(ObtenerCantDiasCP(drdgw2.Cells("CP").Value))
                Catch ex As Exception
                End Try
            Else
                FechaCP = FechaCP.AddDays(2)
            End If


            '******************si la fecha de cp es mayor limita al dia de hoy***
            Dim fechahoy As Date = Now.ToShortDateString
            If FechaCP > fechahoy Then
                FechaCP = fechahoy
            End If
            Dim FechEntre As Date
            If IsDate(drdgw2.Cells("fecha_entr").Value) Then
                FechEntre = drdgw2.Cells("fecha_entr").Value
            End If


            '*********limita fecha entrega a valor fechaCP
            '*********para todo el cp1890 en adelante coloca fecha CP


            If FechEntre >= FechaCP Then
                If Normalizar3(drdgw2.Cells("CP").Value) <> "" Then
                    If Normalizar3(drdgw2.Cells("CP").Value) > 1600 Then
                        drdgw2.Cells("fecha_entr").Value = Normalizar(FechaCP.ToShortDateString)
                        drdgw2.Cells("interno").Value = drdgw2.Cells("interno").Value & "/" & "FechaCP1890"

                    End If
                End If
            End If

            '*********Si fecha de entrega no es una fecha coloca el dia de hoy
            If Not IsDate(drdgw2.Cells("fecha_entr").Value) Then
                drdgw2.Cells("interno").Value = drdgw2.Cells("interno").Value & "*" & drdgw2.Cells("fecha_entr").Value & "*"
                drdgw2.Cells("fecha_entr").Value = Normalizar(FechaCP)
                drdgw2.Cells("interno").Value = drdgw2.Cells("interno").Value & "/" & "FechCP"
            End If

            If Len(drdgw2.Cells("Fech1").Value) > 0 Then
                Dim FechaEntVisit As Date = FechaCP
                FechaEntVisit = FechaEntVisit.AddDays(ObtenerCantDiasCP(drdgw2.Cells("CP").Value))
                drdgw2.Cells("fecha_entr").Value = Normalizar(FechaEntVisit)
                drdgw2.Cells("interno").Value = drdgw2.Cells("interno").Value & "/" & "FechCPDeVisit"

            End If


            Dim FechaEntregaFinal As Date = drdgw2.Cells("fecha_entr").Value
            If FechaEntregaFinal.ToShortDateString > Now.ToShortDateString Then
                drdgw2.Cells("fecha_entr").Value = Now.ToShortDateString
                drdgw2.Cells("interno").Value = drdgw2.Cells("interno").Value & "/" & "NowFechMay"
            End If



        Next

        '********* solucion Sabado y domingo

        For Each dr As DataGridViewRow In DgvEntregadas.Rows
            If dr.Cells("fecha_entr").Value <> "" Then
                Dim FechEntre As Date = dr.Cells("fecha_entr").Value
                Dim EsSabaDom As Date = Sabadoydomingo(dr.Cells("fecha_entr").Value)
                If FechEntre.ToShortDateString = EsSabaDom.ToShortDateString Then
                    dr.Cells("fecha_entr").Value = FechEntre.ToShortDateString
                Else
                    dr.Cells("fecha_entr").Value = EsSabaDom.ToShortDateString
                    dr.Cells("interno").Value = dr.Cells("interno").Value & "/" & "SabDom"
                End If
            End If

            Dim Diferenciadias As Integer
            Dim Fechadetrabajo As Date = dr.Cells("fecha_entr").Value
            Dim Fechadeentrega As Date = dr.Cells("fech_trab").Value
            Diferenciadias = (Fechadetrabajo - Fechadeentrega).TotalDays
            dr.Cells("Diferencia").Value = Diferenciadias
        Next

        For Each drvisit As DataGridViewRow In DgvEntregadas.Rows
            Dim Fechatexto1 As String
            Fechatexto1 = ObtenerFechaEnVisitadas(drvisit.Cells("nro_carta").Value)
            If Len(Fechatexto1) > 0 Then
                Dim fechaF1 As Date = Fechatexto1
                drvisit.Cells("fech1").Value = fechaF1.ToShortDateString
            End If
        Next


        For Each dr As DataGridViewRow In DgvEntregadas.Rows
            Dim FechaAct As Date = dr.Cells("fecha_entr").Value
            Dim FechaAhora As Date = Now
            If FechaAct > FechaAhora Then
                dr.Cells("fecha_entr").Value = FechaAhora.ToShortDateString
            End If


        Next

        BtnCalcular.Enabled = True


    End Sub

    Private Function BuscarEnDT(ByVal Dato As String, ByVal DTTabla As DataTable) As Boolean
        Dim Validar As Integer = 0

        For Each drw As DataRow In DTTabla.Rows
            If drw("NRO_CARTA").ToString = Dato Then
                Validar = 1
            End If
        Next

        If Validar = 0 Then
            Return False
        Else
            Return True
        End If

    End Function


    Private Function Ejecutar()
        If DgvEntregadas.Rows.Count > 1 Then

            'Try
            Dim exApp As New Microsoft.Office.Interop.Excel.Application
            Dim exLibro As Microsoft.Office.Interop.Excel.Workbook
            Dim exHoja As Microsoft.Office.Interop.Excel.Worksheet


            'Añadimos el Libro al programa, y la hoja al libro
            exLibro = exApp.Workbooks.Add
            exHoja = exLibro.Worksheets.Add()
            exHoja.Cells.NumberFormat = "@"
            ' ¿Cuantas columnas y cuantas filas?
            Dim NCol As Integer = DgvEntregadas.ColumnCount
            Dim NRow As Integer = DgvEntregadas.RowCount


            'Aqui recorremos todas las filas, y por cada fila todas las columnas y vamos escribiendo.
            For i As Integer = 1 To NCol
                exHoja.Cells.Item(1, i) = DgvEntregadas.Columns(i - 1).Name.ToString
            Next

            For Fila As Integer = 0 To NRow - 1
                For Col As Integer = 0 To NCol - 1
                    exHoja.Cells.Item(Fila + 2, Col + 1) = DgvEntregadas.Rows(Fila).Cells(Col).Value
                Next
            Next


            exHoja.Columns.AutoFit()
            exApp.Application.Visible = False
            Dim NroEntreg As Integer
            NroEntreg = ObtenerNroVisitada()
            Dim FechaTx As String = Now.ToShortDateString
            FechaTx = FechaTx.Replace("/", "-")

            exLibro.SaveAs("C:\temp\Entregadas_" & NroEntreg & "_" & FechaTx & ".xls")

            exLibro.Close()
            exHoja = Nothing
            exLibro = Nothing
            exApp = Nothing


            Dim cadena As New System.Text.StringBuilder
            For Each dgw As DataGridViewRow In DgvEntregadas.Rows
                cadena.AppendLine(dgw.Cells("socio").Value & ";" & dgw.Cells("integrante").Value & ";" & dgw.Cells("lote").Value & ";3;" & dgw.Cells("fecha_entr").Value)
            Next
            Dim texto As String
            texto = cadena.ToString
            Dim objEscritor As IO.StreamWriter
            objEscritor = IO.File.AppendText("C:\temp\Entregadas_" & NroEntreg & "_" & FechaTx & ".txt")
            objEscritor.Write(texto)
            objEscritor.Close()
            ActualizarNroVisitada(NroEntreg + 1)




            If MessageBox.Show("Enviar mail", "Enviar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then


                If enviaCorreo("C:\temp\Entregadas_" & NroEntreg & "_" & FechaTx & ".xls", "C:\temp\Entregadas_" & NroEntreg & "_" & FechaTx & ".txt", "Archivo Entregadas_Nro_" & NroEntreg) = True Then


                    Dim cadenavisitadas As New System.Text.StringBuilder
                    For Each drw As DataGridViewRow In DgvEntregadas.Rows
                        Dim txtsql As String = ""

                        txtsql = "(" & "'" & drw.Cells("socio").Value & "' , " _
                            & "'" & drw.Cells("lote").Value & "'" & ", " _
                            & "'" & drw.Cells("integrante").Value & "'" & ", " _
                            & "'" & Converfecha(drw.Cells("fech_trab").Value) & "'" & ", " _
                            & "'" & drw.Cells("apellido").Value & "'" & ", " _
                            & "'" & Trim(drw.Cells("calle").Value) & "'" & ", " _
                            & "'" & drw.Cells("cp").Value & "'" & ", " _
                            & "'" & drw.Cells("localidad").Value & "'" & ", " _
                            & "'" & drw.Cells("fech1").Value & "'" & ", " _
                            & "'" & drw.Cells("tema1").Value & "'" & ", " _
                            & "'" & drw.Cells("fech2").Value & "'" & ", " _
                            & "'" & drw.Cells("tema2").Value & "'" & ", " _
                            & "'" & drw.Cells("fecha_entr").Value & "'" & ", " _
                            & "'" & drw.Cells("nro_carta").Value & "'" & ", " _
                            & "'" & drw.Cells("remitente").Value & "'" & ", " _
                            & "'" & NroEntreg & "'" & ", " _
                            & "'" & FechaTx & "'" & ")" & ", "

                        cadenavisitadas.Append(txtsql)
                    Next
                    Dim Archtxt3 As String

                    Archtxt3 = cadenavisitadas.ToString
                    If Len(Archtxt3) > 0 Then
                        Archtxt3 = Mid(Archtxt3, 1, Len(Archtxt3) - 2)
                    End If

                    ConfigCorreo.CN_Correo.InstertarEntregada(Archtxt3)

                Else

                    MsgBox("No se envio mail")

                End If

            End If


            'Catch ex As Exception
            '    MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al exportar a Excel")
            'End Try

        Else
            MsgBox("Sin Datos")
        End If



    End Function
    Private Sub ChkAyudaAdmin_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ChkAyudaAdmin.CheckStateChanged
        If ChkAyudaAdmin.CheckState = CheckState.Unchecked Then
            If DgvEntregadas.Rows.Count > 0 Then
                DgvEntregadas.Columns.Remove(DgvEntregadas.Columns("interno"))
                DgvEntregadas.Columns.Remove(DgvEntregadas.Columns("Diferencia"))
                ChkAyudaAdmin.Visible = False
            End If
        End If
    End Sub

    Private Sub FrmEntregadas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ChkAyudaAdmin.CheckState = CheckState.Checked
    End Sub

End Class
