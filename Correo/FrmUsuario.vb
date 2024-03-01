Public Class FrmUsuario
    Public Niv As Integer
    Public Function ObtenerCadenaDeConeccionProduccion() As String
        Dim fileReader As System.IO.StreamReader
        fileReader =
        My.Computer.FileSystem.OpenTextFileReader("C:\\CnfgProduccion.txt")
        Dim stringReader As String
        stringReader = fileReader.ReadLine()
        Return stringReader

    End Function
    Public Function ObtenerCadenaDeConeccionAnterior() As String
        Dim fileReader As System.IO.StreamReader
        fileReader =
        My.Computer.FileSystem.OpenTextFileReader("C:\\CnfgAnterior.txt")
        Dim stringReader As String
        stringReader = fileReader.ReadLine()
        Return stringReader
    End Function
    Private Sub FrmUsuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ConfigCorreo.CN_Correo.CadenaDeConeccionAnterior = ObtenerCadenaDeConeccionAnterior()
        ConfigCorreo.CN_Correo.CadenaDeConeccionProduccion = ObtenerCadenaDeConeccionProduccion()

        Dim ArrUsuarios As New ArrayList
        ArrUsuarios = ConfigCorreo.CN_Correo.CargarUsuarios
        cmbusuario.Items.Clear()
        For i As Integer = 0 To ArrUsuarios.Count - 1
            cmbusuario.Items.Add(ArrUsuarios.Item(i).ToString)
        Next


    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click

        If Len(txtpsw.Text) > 1 Then
            Niv = ConfigCorreo.CN_Correo.ClaveUsuario(cmbusuario.Text, txtpsw.Text)
            If Niv > 0 Then
                CargarForm(Niv)
                FrmPpal.Usuario = cmbusuario.Text
                FrmPpal.Nivel = Niv
                FrmPpal.Show()
                Me.Visible = False
            End If
        End If


    End Sub

    Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        Me.Close()
    End Sub

    Public Sub CargarForm(ByVal nivel As String)
        'FrmPpal.Txtnivel.Text = nivel
        If nivel = "1" Then
            FrmPpal.PanelAltasyModificaciones.Enabled = False
            'FrmPpal.PanelArmado.Enabled = False
            FrmPpal.Paneldeimportacion.Enabled = False
            FrmPpal.PanelInfoCte.Enabled = False

        ElseIf nivel = "2" Then
            FrmPpal.PanelAltasyModificaciones.Enabled = False
            FrmPpal.Paneldeimportacion.Enabled = False
            'FrmPpal.PanelInfoCte.Enabled = False
            FrmPpal.PanelEtapas.Enabled = False
            'FrmPpal.PanelNumeracion.Enabled = False
        ElseIf nivel = "3" Then
            FrmPpal.PanelAltasyModificaciones.Enabled = False
            FrmPpal.Paneldeimportacion.Enabled = False
            FrmPpal.PanelInfoCte.Enabled = False

        ElseIf nivel = "4" Then
            FrmPpal.Paneldeimportacion.Enabled = False
            FrmPpal.PanelInfoCte.Enabled = False
        ElseIf nivel = "5" Then
        ElseIf nivel = "6" Then
        ElseIf nivel = "7" Then
        End If

    End Sub

End Class