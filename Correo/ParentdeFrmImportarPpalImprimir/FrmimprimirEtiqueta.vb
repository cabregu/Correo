Public Class FrmimprimirEtiqueta
    Public DtImprimir As New DataTable

    Private Sub CmbRemitoPendiente_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbRemitoPendiente.SelectedIndexChanged
        If Len(CmbRemitente.Text) > 0 Then
            CmbRemitoPendiente.Enabled = False
            BtnSelectEtic.Enabled = True
            DtImprimir = ConfigCorreo.CN_Correo.LlenarDatatableImprimir(CmbRemitoPendiente.Text)
            DgvImprimir.DataSource = DtImprimir
            LblCant.Text = DgvImprimir.RowCount

        End If
    End Sub
    Private Sub BtnSelectEtic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSelectEtic.Click
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
    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
    Private Sub CmbRemitente_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbRemitente.SelectedIndexChanged


        Dim ArrServiciosremitoslexs As New ArrayList
        ArrServiciosremitoslexs = ConfigCorreo.CN_Correo.RemitosdeCteremitosLexsImportado(CmbRemitente.Text)

        For i As Integer = 0 To ArrServiciosremitoslexs.Count - 1
            CmbRemitoPendiente.Items.Add(ArrServiciosremitoslexs.Item(i).ToString)
        Next

        CmbRemitente.Enabled = False
        CmbRemitoPendiente.Enabled = True


    End Sub
    Private Sub FrmimprimirEtiqueta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ArrayRemitentes As New ArrayList
        ArrayRemitentes = ConfigCorreo.CN_Correo.CargarTodoslosremitente
        CmbRemitente.Items.Clear()
        For i As Integer = 0 To ArrayRemitentes.Count - 1
            CmbRemitente.Items.Add(ArrayRemitentes.Item(i).ToString)
        Next



    End Sub

  
    Private Sub Btnimprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnimprimir.Click

        FrmReportEtiquetas.EtiquetaSeleccionada = TxtPath.Text
        FrmReportEtiquetas.DTRegImprimir = DtImprimir
        FrmReportEtiquetas.Cant = DgvImprimir.Rows.Count
        FrmReportEtiquetas.Show()

    End Sub

    Private Sub BtnCambiarEstado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCambiarEstado.Click
        If CmbRemitente.Text <> "" And CmbRemitoPendiente.Text <> "" Then

            If MessageBox.Show("Vas a Cambiar estado de todo el remito nro: " & CmbRemitoPendiente.Text & " a ESP_PROG? Ya no podras hacer ARM ni Modo S ", "Actualizar", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                '*Cambia estado demitos lexs a Impreso y ya no se muestra para imprimir etiquetas para mostrar cambiar a Importado
                ConfigCorreo.CN_Correo.CambiarEstadoRemitosLexs(CmbRemitoPendiente.Text, "Impreso")
                ConfigCorreo.CN_Correo.ActualizarEstado(CmbRemitoPendiente.Text, CmbRemitente.Text, "ESP_PROG")
                Me.Close()

            End If
        Else
            MsgBox("Seleccione remito y remitente")
        End If

    End Sub

    Private Sub BtnArm_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtnModoS_Click(sender As Object, e As EventArgs)
        BtnCambiarEstado.Enabled = False
        FiltrarYMostrarDatos(DtImprimir, DgvImprimir)
    End Sub
    Private Sub BtnArm_Click_1(sender As Object, e As EventArgs)
        BtnCambiarEstado.Enabled = False
    End Sub

    Private Function FiltrarYMostrarDatos(ByVal dtOriginal As DataTable, ByVal dgvDestino As DataGridView) As DataTable
        ' Filtrar los datos por el campo "OBS" igual a "MODO S"
        Dim dtFiltrado As DataTable = dtOriginal.Clone()
        Dim rows As DataRow() = dtOriginal.Select("OBS = 'MODO S'")
        For Each row As DataRow In rows
            dtFiltrado.ImportRow(row)
        Next

        ' Mostrar los datos filtrados en el DataGridView
        dgvDestino.DataSource = dtFiltrado

        Return dtFiltrado
    End Function


End Class