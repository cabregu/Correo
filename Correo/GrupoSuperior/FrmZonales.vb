Imports Microsoft.Office.Interop

Public Class FrmZonales
    Dim ArrPlanillaZonal As New ArrayList
    Dim Dtn As New DataTable


    Private Sub FrmZonales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CargarZonales()
        TxtEnvio.Text = ""

        Dtn.Columns.Add("nro_carta")
        Dtn.Columns.Add("remitente")
        Dtn.Columns.Add("Nombre_apellido")
        Dtn.Columns.Add("cp")
        Dtn.Columns.Add("calle")
        Dtn.Columns.Add("localidad")
        Dtn.Columns.Add("provincia")
        Dtn.Columns.Add("planilla_recorrido")
        Dtn.Columns.Add("empresa")
        Dtn.Columns.Add("nro_carta2")
        Dtn.Columns.Add("fecha_recorrido")
        Dtn.Columns.Add("cartero")

    End Sub

    'Private Sub CmbZonales_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbZonales.TextChanged
    '    If CmbZonales.Text <> "" Then
    '        DgvDatos.DataSource = Nothing
    '        If Len(CmbZonales.Text) > 0 Then
    '            CargarPlanillaZonal(CmbZonales.Text)
    '            TxtEnvio.Text = ConfigCorreo.CN_Correo.ObtenerMailCartero(CmbZonales.Text)

    '        End If
    '    End If
    'End Sub

    Public Function CargarZonales()
        Dim ListaItems As New List(Of String)
        Dim dt As New DataTable
        dt = ConfigCorreo.CN_Correo.CargarCarterosMailParaZonales
        For Each drw As DataRow In dt.Rows
            ListaItems.Add(drw("CODIGO"))
            'ArrZonal.Add(drw("CODIGO"))
        Next
        CmbZonales.DataSource = ListaItems
        CmbZonales.AutoCompleteMode = AutoCompleteMode.Suggest
        CmbZonales.AutoCompleteSource = AutoCompleteSource.ListItems
        CmbZonales.Show()
        CmbZonales.Text = ""
        Return True
    End Function

    Private Function CargarPlanillaZonal(ByVal cartero As String)

        Dim dt As New DataTable
        dt = ConfigCorreo.CN_Correo.CargarPlanillasParaZonales(cartero)
        For Each drw As DataRow In dt.Rows
            ArrPlanillaZonal.Add(drw("nroplanilla").ToString)
            CargarPlanillasZonalEnDgv()
        Next

    End Function

    Private Function CargarPlanillasZonalEnDgv()
        'Try


        For i As Integer = 0 To ArrPlanillaZonal.Count - 1
                Dim dt As New DataTable
                dt = ConfigCorreo.CN_Correo.CargarPlanillasParaEnviar(ArrPlanillaZonal.Item(i).ToString)

                For Each drw As DataRow In dt.Rows
                    Dim fecharecorrido As Date = drw("fecha_recorrido")
                    Dtn.Rows.Add(drw("nro_carta"), drw("remitente"), drw("Nombre_apellido"), drw("cp"), drw("calle"), drw("localidad"), drw("provincia"), drw("PLANILLA_RECORRIDO"), drw("empresa"), drw("nro_carta2"), fecharecorrido.ToShortDateString, drw("cartero"))
                Next


            Next

            DgvDatos.DataSource = Dtn
        'Catch ex As Exception

        'End Try
    End Function

    Private Sub BtnEnviar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTerminar.Click

        For i As Integer = 0 To ArrPlanillaZonal.Count - 1
            ConfigCorreo.CN_Correo.ActualizarPlanillaZonales(ArrPlanillaZonal.Item(i).ToString)
        Next
        ArrPlanillaZonal.Clear()
        DgvDatos.DataSource = Nothing
        CmbZonales.Text = ""
        TxtEnvio.Text = ""
        BtnGenerar.Enabled = True
        BtnTerminar.Enabled = False

    End Sub

    Public Shared Sub BajarExceldesdeDatatable(ByVal NroPLanil As String, ByVal dt As DataTable, ByVal Mail As String)

        Try
            Dim ArrArchivos As New ArrayList

            'Dim strFile As String = MYFilelocation
            Dim excel As New Microsoft.Office.Interop.Excel.Application
            Dim wBook As Microsoft.Office.Interop.Excel.Workbook
            Dim wSheet As Microsoft.Office.Interop.Excel.Worksheet

            wBook = excel.Workbooks.Add()
            wSheet = wBook.ActiveSheet()

            Dim dc As System.Data.DataColumn
            Dim dr As System.Data.DataRow
            Dim colIndex As Integer = 0
            Dim rowIndex As Integer = 0

            For Each dc In dt.Columns
                colIndex = colIndex + 1
                excel.Cells(1, colIndex) = dc.ColumnName
            Next

            For Each dr In dt.Rows
                rowIndex = rowIndex + 1
                colIndex = 0
                For Each dc In dt.Columns
                    colIndex = colIndex + 1
                    excel.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
                Next
            Next
            Dim Servico As String
            Servico = ConfigCorreo.CN_Correo.ObtenerservicioSimpleyconacuse(NroPLanil)

            Dim FechaTx As String = Now.ToShortDateString
            FechaTx = FechaTx.Replace("/", "-")
            wSheet.Columns.AutoFit()
            wBook.SaveAs("C:\temp\PlanillaZonal" & "_" & NroPLanil & "_" & FechaTx & "_" & Servico & ".xls")
            ArrArchivos.Add("C:\temp\PlanillaZonal" & "_" & NroPLanil & "_" & FechaTx & "_" & Servico & ".xls")
            wBook.Close()

            'enviaCorreo(ArrArchivos, "Archivos Zonal", Mail)



        Catch ex As Exception
            MessageBox.Show("there was an issue Exporting to Excel" & ex.ToString)
        End Try


    End Sub

    Private Sub BtnGenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGenerar.Click
        If CmbZonales.Text <> "" Then
            If OutLookAbierto() = False Then
                MsgBox("Debe abrir el Outlook")
            Else
                For i As Integer = 0 To ArrPlanillaZonal.Count - 1
                    Dim dt As New DataTable
                    dt = ConfigCorreo.CN_Correo.CargarPlanillasParaEnviar(ArrPlanillaZonal.Item(i).ToString)
                    BajarExceldesdeDatatable(ArrPlanillaZonal.Item(i).ToString, dt, TxtEnvio.Text)
                Next
                BtnTerminar.Enabled = True
                BtnGenerar.Enabled = False

            End If

        End If


    End Sub

    'Private Shared Function enviaCorreo(ByVal ArrArchivos As ArrayList, ByVal Asunto As String, ByVal Mail As String) As Boolean


    '    'Try
    '    Dim oApp As Outlook._Application
    '    oApp = New Outlook.Application()


    '    Dim oMsg As Outlook._MailItem
    '    oMsg = oApp.CreateItem(Outlook.OlItemType.olMailItem)
    '    oMsg.Subject = Asunto

    '    oMsg.Body = " * SOLICITAMOS LA CONFIRMACIÓN DE LA RECEPCIÓN DEL MATERIAL FÍSICO CORRESPONDIENTE A ESTAS PLANILLAS*" & vbCrLf & vbCrLf &
    '            "Buenos días/ tardes" & vbCrLf & vbCrLf &
    '            "Se adjuntan planillas de referencia."

    '    Dim Destinatarios As String = ""
    '    Destinatarios = Mail

    '    oMsg.To = Destinatarios

    '    Dim sDisplayName As String = "Archivo"

    '    Dim oAttachs As Outlook.Attachments = oMsg.Attachments
    '    Dim oAttach As Outlook.Attachment

    '    For i As Integer = 0 To ArrArchivos.Count - 1
    '        oAttach = oAttachs.Add(ArrArchivos.Item(i).ToString)
    '    Next

    '    oMsg.Save()


    '    Return True




    'End Function

    Private Function OutLookAbierto() As Boolean

        For Each proceso As Process In Process.GetProcesses()
            If (proceso.ProcessName.Equals("OUTLOOK", StringComparison.CurrentCultureIgnoreCase)) Then
                Return True
            End If
        Next

        Return False

    End Function


End Class
