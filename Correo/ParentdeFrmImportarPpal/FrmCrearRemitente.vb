Public Class FrmCrearRemitente

  
    Private Sub FrmCrearRemitente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
        Dim Servicios As New ArrayList
        Servicios = ConfigCorreo.CN_Correo.CargarClientes
        CmbClientes.Items.Clear()
        For i As Integer = 0 To Servicios.Count - 1
            CmbClientes.Items.Add(Servicios.Item(i).ToString)
        Next
    End Sub

    Private Sub BtnAñadir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAñadir.Click
        If CmbClientes.Text <> "" And TxtRemitente.Text <> "" Then

            If (ConfigCorreo.CN_Correo.InsertarRemitente(CmbClientes.Text, TxtRemitente.Text)) = True Then
                MsgBox("Remitente cargado correctamente")
                Me.Close()

            End If


        Else
            MsgBox("Debe cargar ambos campos")


        End If
    End Sub
End Class