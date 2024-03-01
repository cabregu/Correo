Imports ConfigCorreo.CN_Correo
Imports Microsoft.Office.Interop


Public Class FrmEstados
    Dim Tipo As Integer = 0


    'Private Sub BtnCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCalcular.Click
    '    Tipo = 1

    '    Dim remite As String = "SWRECR"


    '    BtnCalcular.Enabled = False
    '    DgvDatos.Rows.Clear()

    '    Dim FechaDesdeEntreg As Date = Now.ToShortDateString
    '    FechaDesdeEntreg = FechaDesdeEntreg.AddDays(-90)
    '    FechaDesdeEntreg = FechaDesdeEntreg.ToShortDateString
    '    Dim fechatexto As String = Converfecha(FechaDesdeEntreg)

    '    Dim Dtn As New DataTable
    '    Dtn = ObtenerEntregadasRemitente()

    '    Dtn.Columns.Add("fech1")
    '    Dtn.Columns.Add("tema1")
    '    Dtn.Columns.Add("fech2")
    '    Dtn.Columns.Add("tema2")
    '    Dtn.Columns.Add("Socio")
    '    Dtn.Columns.Add("Lote")
    '    Dtn.Columns.Add("Integrante")



    '    For Each dr As DataRow In Dtn.Rows
    '        If Len(dr("NRO_CART2")) > 15 Then
    '            Dim NroCart2 As String = dr("NRO_CART2")

    '            Dim Socio As String
    '            Dim Lote As String
    '            Dim integrante As String
    '            Socio = NroCart2.Substring(0, 7)
    '            Lote = NroCart2.Substring(8, 7)
    '            integrante = NroCart2.Substring(16, Len(NroCart2) - 16)
    '            dr("Socio") = Socio
    '            dr("Lote") = Lote
    '            dr("Integrante") = integrante

    '        End If
    '    Next

    '    ''**********************************************************
    '    Dim ArrEnt As New ArrayList
    '    ArrEnt = BuscarEntregada()

    '    For Each drw As DataRow In Dtn.Rows
    '        Dim fechtrab As Date = drw("fech_trab").ToString
    '        Dim Nrocart As Integer = drw("nro_carta").ToString
    '        fechtrab = fechtrab.ToShortDateString


    '        If Len(drw("NRO_CART2")) > 15 Then
    '            If Not ArrEnt.Contains(Nrocart) Then
    '                DgvDatos.Rows.Add(drw("socio"), drw("lote"), drw("integrante"), Normalizar(fechtrab.ToString), drw("apellido"), drw("calle"), drw("cp"), drw("localidad"), drw("fech1"), drw("tema1"), drw("fech2"), drw("tema2"), drw("fecha_entr"), drw("nro_carta"), drw("remitente"))
    '            End If
    '        End If

    '    Next

    '    Lblcantidad.Text = DgvDatos.Rows.Count
    '    MsgBox("ok")
    '    BtnCalcular.Enabled = True

    '    'Catch ex As Exception
    '    '    MsgBox("Verifique el remitente")
    '    'End Try

    'End Sub



    Private Sub BtnCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCalcular.Click
 
        BtnCalcular.Enabled = False
        DgvDatos.Rows.Clear()

        Dim Dtn As New DataTable
        Dtn = ObtenerEntregadasRemitente()

        Dtn.Columns.Add("fech1")
        Dtn.Columns.Add("tema1")
        Dtn.Columns.Add("fech2")
        Dtn.Columns.Add("tema2")
        Dtn.Columns.Add("Socio")
        Dtn.Columns.Add("Lote")
        Dtn.Columns.Add("Integrante")



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

            End If
        Next

        ''**********************************************************
        Dim ArrEnt As New ArrayList
        ArrEnt = BuscarEntregada()

        Dim ArrTrans As New ArrayList
        ArrTrans = BuscarTransito()

        For Each drw As DataRow In Dtn.Rows
            Dim fechtrab As Date = drw("fech_trab").ToString
            Dim Nrocart As Integer = drw("nro_carta").ToString
            fechtrab = fechtrab.ToShortDateString


            If Len(drw("NRO_CART2")) > 15 Then
                If Not ArrEnt.Contains(Nrocart) Then
                    If Not ArrTrans.Contains(Nrocart) Then
                        DgvDatos.Rows.Add(drw("socio"), drw("lote"), drw("integrante"), Normalizar(fechtrab.ToString), drw("apellido"), drw("calle"), drw("cp"), drw("localidad"), drw("fech1"), drw("tema1"), drw("fech2"), drw("tema2"), drw("fecha_entr"), drw("nro_carta"), drw("remitente"))
                    End If
                End If
            End If

        Next

        Lblcantidad.Text = DgvDatos.Rows.Count
        MsgBox("ok")
        BtnCalcular.Enabled = True

        'Catch ex As Exception
        '    MsgBox("Verifique el remitente")
        'End Try

        For Each drdgw2 As DataGridViewRow In DgvDatos.Rows

            If Len(drdgw2.Cells("FECHA_ENTR").Value) = 0 Then
                Dim FechaENT As Date
                FechaENT = drdgw2.Cells("FECH_TRAB").Value
                If drdgw2.Cells("CP").Value <> "" Then
                    If drdgw2.Cells("CP").Value > 1000 And drdgw2.Cells("CP").Value < 9999 Then
                        FechaENT = FechaENT.AddDays(7)
                    End If
                End If
                '**********************************************************
                drdgw2.Cells("FECHA_ENTR").Value = FechaENT

            End If
        Next





        For Each dr As DataGridViewRow In DgvDatos.Rows
            Dim FechEntre As Date = Nothing
            FechEntre = dr.Cells("fecha_entr").Value
            FechEntre = Sabadoydomingo(FechEntre)
            FechEntre = AgregardiaFeriado(FechEntre)
            dr.Cells("fecha_entr").Value = FechEntre.ToShortDateString
        Next
        Lblcantidad.Text = DgvDatos.Rows.Count
        BtnCalcular.Enabled = True


    End Sub


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
    Private Sub BtnGenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGenerar.Click

            If DgvDatos.Rows.Count > 1 Then

                Try
                    Dim exApp As New Microsoft.Office.Interop.Excel.Application
                    Dim exLibro As Microsoft.Office.Interop.Excel.Workbook
                    Dim exHoja As Microsoft.Office.Interop.Excel.Worksheet


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
                    Next

                    For Fila As Integer = 0 To NRow - 1
                        For Col As Integer = 0 To NCol - 1
                            exHoja.Cells.Item(Fila + 2, Col + 1) = DgvDatos.Rows(Fila).Cells(Col).Value
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
                    For Each dgw As DataGridViewRow In DgvDatos.Rows
                        cadena.AppendLine(dgw.Cells("socio").Value & ";" & dgw.Cells("integrante").Value & ";" & dgw.Cells("lote").Value.Substring(3, 4) & ";3;" & dgw.Cells("fecha_entr").Value)
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
                            For Each drw As DataGridViewRow In DgvDatos.Rows
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


                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al exportar a Excel")
                End Try

            Else
                MsgBox("Sin Datos")
            End If


      
    End Sub
    Private Function enviaCorreo(ByVal Archivo As String, ByVal Archivo2 As String, ByVal Asunto As String) As Boolean


        Try
            'Dim oApp As Outlook._Application
            'oApp = New Outlook.Application()

            'Dim oMsg As Outlook._MailItem
            'oMsg = oApp.CreateItem(Outlook.OlItemType.olMailItem)
            'oMsg.Subject = Asunto
            'oMsg.Body = ""

            'Dim Destinatarios As String = ""

            'oMsg.To = "romina.arrieta@swissmedical.com.ar; AlejandroAdrian.Mangione@swissmedical.com.ar"
            'oMsg.CC = "Jorge.Baragiola@swissmedical.com.ar; Maximiliano.Mastrachio@swissmedical.com.ar; AldanaAyelen.Robles@swissmedical.com.ar; operaciones@lexs.com.ar; guillermo.a@lexs.com.ar; seguimiento@lexs.com.ar; planificacion@lexs.com.ar"

            'Dim sSource As String = Archivo
            'Dim sSource2 As String = Archivo2
            'Dim sDisplayName As String = "Archivo"
            ''Dim sBodyLen As String = oMsg.Body.Length
            'Dim oAttachs As Outlook.Attachments = oMsg.Attachments
            'Dim oAttach As Outlook.Attachment

            'oAttach = oAttachs.Add(sSource)
            'oAttach = oAttachs.Add(sSource2)
            'oMsg.Save()


            Return True


        Catch ex As Exception
            Return False

            'MsgBox(ex.ToString)

        End Try

    End Function

End Class
