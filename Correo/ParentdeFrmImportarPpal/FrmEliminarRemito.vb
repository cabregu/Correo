Public Class FrmEliminarRemito

    Private Sub FrmEliminarRemito_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim DtServ As New DataTable
        DtServ = ConfigCorreo.CN_Correo.CargarRemitosPendientes
        DGVRemito.DataSource = DtServ
    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub BtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminar.Click
        Dim N As String = DGVRemito.SelectedCells(0).RowIndex.ToString
        Dim Remito As String = DGVRemito.Rows(N).Cells("Nro_Remito").Value
        Dim TipoServicio As String = DGVRemito.Rows(N).Cells("TipoRemitente").Value
        If MessageBox.Show("Eliminar " & Remito & " Para El Servicio " & TipoServicio, "Seguro desea Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            DGVRemito.Rows.Remove(DGVRemito.Rows(N))
            ConfigCorreo.CN_Correo.EliminarRemito(Remito, TipoServicio)
        End If
    End Sub
End Class