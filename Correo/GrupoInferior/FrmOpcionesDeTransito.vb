Public Class FrmOpcionesDeTransito

 
    Private Sub BtnNormal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNormal.Click
        FrmTransito.Seleccionar()
        FrmTransito.Visible = True
        Me.Close()
    End Sub

    Private Sub BtnOtro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOtro.Click
        FrmTransito.SeleccionarOtro()
        FrmTransito.Visible = True
        Me.Close()
    End Sub
End Class