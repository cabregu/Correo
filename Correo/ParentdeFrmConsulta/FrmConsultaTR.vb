Imports ConfigCorreo.CN_Correo

Public Class FrmConsultaTR



    Private Sub TxtNroSocio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNroSocio.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If IsNumeric(TxtNroSocio.Text) Then
                Dim dt As New DataTable
                dt = BuscarPorNrosocio(TxtNroSocio.Text)
                Dgvdatos.DataSource = Nothing

                Dgvdatos.DataSource = dt
                Dgvdatos.AutoResizeColumns()

            Else
                MsgBox("Solo se aceptan numeros")
            End If


        End If

    End Sub



    Private Sub Btnsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnsalir.Click
        Me.Close()
        FrmPpal.Visible = True

    End Sub




    Private Sub Dgvdatos_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Dgvdatos.CellContentClick

    End Sub

    Private Sub FrmConsultaTR_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class