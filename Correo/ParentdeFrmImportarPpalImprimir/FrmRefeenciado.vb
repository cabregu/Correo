Public Class FrmRefeenciado

    Public DtImprimir As New DataTable


    Private Sub FrmModoS_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim ArrayRemitentes As New ArrayList
        ArrayRemitentes = ConfigCorreo.CN_Correo.CargarTodoslosremitente
        CmbRemitente.Items.Clear()
        For i As Integer = 0 To ArrayRemitentes.Count - 1
            CmbRemitente.Items.Add(ArrayRemitentes.Item(i).ToString)
        Next

    End Sub

    Private Sub CmbRemitente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbRemitente.SelectedIndexChanged

        Dim ArrServiciosremitoslexs As New ArrayList
        ArrServiciosremitoslexs = ConfigCorreo.CN_Correo.RemitosdeCteremitosLexsImportado(CmbRemitente.Text)

        For i As Integer = 0 To ArrServiciosremitoslexs.Count - 1
            CmbRemitoPendiente.Items.Add(ArrServiciosremitoslexs.Item(i).ToString)
        Next

        CmbRemitente.Enabled = False
        CmbRemitoPendiente.Enabled = True
    End Sub

    Private Sub CmbRemitoPendiente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbRemitoPendiente.SelectedIndexChanged
        If Len(CmbRemitente.Text) > 0 Then
            CmbRemitoPendiente.Enabled = False
            BtnSelectEtic.Enabled = True
            DtImprimir = ConfigCorreo.CN_Correo.LlenarDatatableImprimirSoloReferenciado(CmbRemitoPendiente.Text)
            DgvImprimir.DataSource = DtImprimir
            LblCant.Text = DgvImprimir.RowCount

        End If
    End Sub

    Private Sub BtnSelectEtic_Click(sender As Object, e As EventArgs) Handles BtnSelectEtic.Click
        Dim openFD As New OpenFileDialog()
        With openFD
            .Title = "Seleccionar archivos"
            .Filter = "Todos los archivos (*.Rpt)|*.Rpt"
            .Multiselect = False
            .InitialDirectory = "C:\Crisis\Correo\Etiquetas"
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                TxtPath.Text = .FileName
            Else
                openFD.Dispose()
            End If
        End With
        Btnimprimir.Enabled = True
    End Sub

    Private Sub Btnimprimir_Click(sender As Object, e As EventArgs) Handles Btnimprimir.Click
        FrmReportEtiquetas.EtiquetaSeleccionada = TxtPath.Text
        FrmReportEtiquetas.DTRegImprimir = DtImprimir
        FrmReportEtiquetas.Cant = DgvImprimir.Rows.Count
        FrmReportEtiquetas.Show()

    End Sub


End Class
