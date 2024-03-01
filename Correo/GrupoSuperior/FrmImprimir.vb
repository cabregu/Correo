Public Class FrmImprimir

    Public DtImprimir As New DataTable

    Private Sub FrmImprimir_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ArrayRemitentes As New ArrayList
        ArrayRemitentes = ConfigCorreo.CN_Correo.CargarTodoslosremitente
        CmbRemitente.Items.Clear()
        For i As Integer = 0 To ArrayRemitentes.Count - 1
            CmbRemitente.Items.Add(ArrayRemitentes.Item(i).ToString)
        Next

        TxtFecha.Text = Now.ToShortDateString
        TxtFecha.Enabled = False

    End Sub

    Private Sub CmbRemitente_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbRemitente.SelectedIndexChanged
        CmbRemitoPendiente.Text = ""
        DgvImprimir.DataSource = Nothing


        Dim ArrayPendImpr As New ArrayList
        ArrayPendImpr = ConfigCorreo.CN_Correo.ObtenerTodoslosRemitos(CmbRemitente.Text)
        CmbRemitoPendiente.Items.Clear()
        For i As Integer = 0 To ArrayPendImpr.Count - 1
            CmbRemitoPendiente.Items.Add(ArrayPendImpr.Item(i).ToString)
        Next
        'CmbRemitente.Enabled = False


    End Sub

    Private Sub BtnSelectEtic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSelectEtic.Click
        Dim openFD As New OpenFileDialog()
        With openFD
            .Title = "Seleccionar archivos"
            .Filter = "Todos los archivos (*.Rpt)|*.Rpt"
            .Multiselect = False
            .InitialDirectory = "C:\Etiquetas"
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                TxtPath.Text = .FileName
            Else
                openFD.Dispose()
            End If
        End With
        Btnimprimir.Enabled = True
    End Sub

    Private Sub CmbRemitoPendiente_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbRemitoPendiente.SelectedIndexChanged
        If Len(CmbRemitente.Text) > 0 Then
            'CmbRemitoPendiente.Enabled = False
            BtnSelectEtic.Enabled = True
            DtImprimir = ConfigCorreo.CN_Correo.LlenarDatatableImprimir(CmbRemitoPendiente.Text)
            DgvImprimir.DataSource = DtImprimir
            LblCant.Text = DgvImprimir.RowCount
        End If
    End Sub


    Private Sub Btnimprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnimprimir.Click

        FrmReportEtiquetas.EtiquetaSeleccionada = TxtPath.Text
        FrmReportEtiquetas.DTRegImprimir = DtImprimir
        'FrmReportEtiquetas.RemitenteNombre = CmbRemitente.Text
        'FrmReportEtiquetas.RemitoNro = CmbRemitoPendiente.Text

        FrmReportEtiquetas.Show()



    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

    End Sub
End Class
