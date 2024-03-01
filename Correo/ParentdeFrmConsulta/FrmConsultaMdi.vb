Public Class FrmConsultamdi
    Private Sub FrmConsulta_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        FrmPpal.Visible = True
    End Sub

    Private Sub ConsultaUnicaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim Frmundato As New FrmConsultaUndato
        Frmundato.NRO_CARTATextBox.Enabled = True
        Frmundato.MdiParent = Me
        Frmundato.Show()

    End Sub

    Private Sub ConsultasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultasToolStripMenuItem.Click
        FrmConsultaGeneral.MdiParent = Me
        FrmConsultaGeneral.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub


End Class