Public Class FrmProgreso
    Private Sub FrmProgreso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ProgressBar1.Minimum = 1
        ProgressBar1.Maximum = 10
        Timer1.Start()

    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value < 10 Then
            ProgressBar1.Value = ProgressBar1.Value + 1
        Else
            ProgressBar1.Value = 1
        End If




    End Sub
End Class