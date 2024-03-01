Imports ConfigCorreo.CN_Correo
Public Class FrmCargaFeriado

    Private Sub BtnAgregarFeriado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAgregarFeriado.Click

        If InsertarFeriado(Txtdetalle.Text, Dtdiaferiado.Value.ToShortDateString) = True Then
            Dgvferiados.Rows.Add(Txtdetalle.Text, Dtdiaferiado.Value.ToShortDateString)
            MsgBox("OK")
        Else
            MsgBox("Ya existe")
        End If

    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

 
    Private Sub FrmCargaFeriado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dt As New DataTable
        dt = ObtenerFeriados()
        Dgvferiados.Columns.Add("Detalle", "Detalle")
        Dgvferiados.Columns.Add("Dia", "Dia")

        For Each drw As DataRow In dt.Rows
            Dgvferiados.Rows.Add(drw("detalle"), drw("dia"))
        Next


    End Sub
End Class