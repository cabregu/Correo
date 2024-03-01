Public Class FrmCargaManual
    Dim m_controlPresionado As Boolean = False
    Private Sub FrmCargaManual_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ArrServi As New ArrayList
        ArrServi = ConfigCorreo.CN_Correo.CargarTodoslosServicios
        CmbRemitente.Items.Clear()
        For i As Integer = 0 To ArrServi.Count - 1
            CmbRemitente.Items.Add(ArrServi.Item(i).ToString)
        Next
    End Sub

    '*****************************************************************

    Private Sub TxtNombre_Apellido_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtNombre_Apellido.GotFocus
        TxtNombre_Apellido.BackColor = Color.White
    End Sub
    Private Sub TxtCalle_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtCalle.GotFocus
        TxtCalle.BackColor = Color.White
    End Sub
    Private Sub TxtCp_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtCp.GotFocus
        TxtCp.BackColor = Color.White
    End Sub
    Private Sub TxtLocalidad_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtLocalidad.GotFocus
        TxtLocalidad.BackColor = Color.White
    End Sub
    Private Sub TxtProvincia_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtProvincia.GotFocus
        TxtProvincia.BackColor = Color.White
    End Sub
    Private Sub TxtEmpresa_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtEmpresa.GotFocus
        TxtEmpresa.BackColor = Color.White
    End Sub
    Private Sub TxtNro_Carta2_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtNro_Carta2.GotFocus
        TxtNro_Carta2.BackColor = Color.White
    End Sub
    Private Sub TxtSocio_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtSocio.GotFocus
        TxtSocio.BackColor = Color.White
    End Sub
    Private Sub TxtObs2_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtObs2.GotFocus
        TxtObs2.BackColor = Color.White
    End Sub
    Private Sub TxtObs3_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtObs3.GotFocus
        TxtObs3.BackColor = Color.White
    End Sub
    Private Sub TxtObs4_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtObs4.GotFocus
        TxtObs4.BackColor = Color.White
    End Sub
    Private Sub TxtNombre_Apellido_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtNombre_Apellido.LostFocus
        TxtNombre_Apellido.BackColor = Color.Silver
    End Sub
    Private Sub TxtCalle_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtCalle.LostFocus
        TxtCalle.BackColor = Color.Silver
    End Sub
    Private Sub TxtCp_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtCp.LostFocus
        TxtCp.BackColor = Color.Silver
    End Sub
    Private Sub TxtLocalidad_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtLocalidad.LostFocus
        TxtLocalidad.BackColor = Color.Silver
    End Sub
    Private Sub TxtProvincia_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtProvincia.LostFocus
        TxtProvincia.BackColor = Color.Silver
    End Sub
    Private Sub TxtEmpresa_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtEmpresa.LostFocus
        TxtEmpresa.BackColor = Color.Silver
    End Sub
    Private Sub TxtNro_Carta2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtNro_Carta2.LostFocus
        TxtNro_Carta2.BackColor = Color.Silver
    End Sub
    Private Sub TxtValor_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtPisoDepto.LostFocus
        TxtPisoDepto.BackColor = Color.Silver
    End Sub
    Private Sub TxtObs_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtObs.LostFocus
        TxtObs.BackColor = Color.Silver
    End Sub
    Private Sub TxtObs2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtObs2.LostFocus
        TxtObs2.BackColor = Color.Silver
    End Sub
    Private Sub TxtObs3_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtObs3.LostFocus
        TxtObs3.BackColor = Color.Silver
    End Sub
    Private Sub TxtObs4_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtObs4.LostFocus
        TxtObs4.BackColor = Color.Silver
    End Sub
    Private Sub TxtSocio_LostFocus(sender As Object, e As EventArgs) Handles TxtSocio.LostFocus
        TxtSocio.BackColor = Color.Silver
    End Sub
    Private Sub TxtPisoDepto_GotFocus(sender As Object, e As EventArgs) Handles TxtPisoDepto.GotFocus
        TxtPisoDepto.BackColor = Color.Black
    End Sub


    '********************************************************************

    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click
        Activar()
    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    '********************************************************************

    Private Sub Activar()
        TxtNombre_Apellido.Enabled = True
        TxtCalle.Enabled = True
        TxtCp.Enabled = True
        TxtLocalidad.Enabled = True
        TxtProvincia.Enabled = True
        TxtEmpresa.Enabled = True
        TxtNro_Carta2.Enabled = True
        TxtSocio.Enabled = True
        TxtPisoDepto.Enabled = True
        TxtObs.Enabled = True
        TxtObs2.Enabled = True
        TxtObs3.Enabled = True
        TxtObs4.Enabled = True
        CmbRemitente.Enabled = True
        CmbNroTrab.Enabled = True
        BtnSeleccionar.Enabled = True
        CmbRemitente.Focus()
        BtnIngresar.Enabled = True


    End Sub
    Private Sub Desactivar()
        CmbRemitente.Enabled = False
        TxtNombre_Apellido.Enabled = False
        TxtCalle.Enabled = False
        TxtCp.Enabled = False
        TxtLocalidad.Enabled = False
        TxtProvincia.Enabled = False
        TxtEmpresa.Enabled = False
        TxtNro_Carta2.Enabled = False
        TxtSocio.Enabled = False
        TxtPisoDepto.Enabled = False
        TxtObs.Enabled = False
        TxtObs2.Enabled = False
        TxtObs3.Enabled = False
        TxtObs4.Enabled = False
    End Sub
    Private Sub Limpiar()
        CmbRemitente.Text = ""
        TxtNombre_Apellido.Text = ""
        TxtCalle.Text = ""
        TxtCp.Text = ""
        TxtLocalidad.Text = ""
        TxtProvincia.Text = ""
        TxtEmpresa.Text = ""
        TxtNro_Carta2.Text = ""
        TxtSocio.Text = ""
        TxtPisoDepto.Text = ""
        TxtObs.Text = ""
        TxtObs2.Text = ""
        TxtObs3.Text = ""
        TxtObs4.Text = ""
    End Sub

    Private Sub ObtenerNroCarta()
        Dim NroCarta As String

        If Len(CmbNroTrab.Text) > 1 Then
            TxtNombre_Apellido.Focus()
            CmbNroTrab.Enabled = False
            CmbRemitente.Enabled = False
            NroCarta = ConfigCorreo.CN_Correo.ObtenerNroCarta
            TxtNro_Carta.Text = NroCarta
            BtnSeleccionar.Enabled = False


            If Len(CmbNroTrab.Text) > 1 Then
                Dim CodServ As String = ConfigCorreo.CN_Correo.ObtenerServicio(CmbNroTrab.Text, CmbRemitente.Text)
                Dim Cantdias As Integer = ConfigCorreo.CN_Correo.ObtenerDiasServicio(CodServ)
                Dim dias As Date = Now.ToShortDateString
                DtFechTrab.Value = dias.AddDays(Cantdias)
                BtnSeleccionar.Enabled = True
            End If
            BtnSeleccionar.Enabled = False

        End If
    End Sub

    '*********************************************************************
    Private Sub CmbRemitente_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbRemitente.SelectedIndexChanged
        Dim ArrServicios As New ArrayList
        ArrServicios = ConfigCorreo.CN_Correo.RemitosdeCteremitosLexsIngresado(CmbRemitente.Text)
        CmbNroTrab.Items.Clear()
        For i As Integer = 0 To ArrServicios.Count - 1
            CmbNroTrab.Items.Add(ArrServicios.Item(i).ToString)
        Next

    End Sub
    Private Sub BtnSeleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSeleccionar.Click
        Dim NroCarta As Integer = 0
        If Len(CmbNroTrab.Text) > 1 Then
            If Len(CmbRemitente.Text) > 1 Then
                TxtNombre_Apellido.Focus()
                CmbNroTrab.Enabled = False
                CmbRemitente.Enabled = False
                NroCarta = ConfigCorreo.CN_Correo.ObtenerNroCarta
                TxtNro_Carta.Text = NroCarta
                BtnSeleccionar.Enabled = False
                If Len(CmbNroTrab.Text) > 1 Then
                    Dim CodServ As String = ConfigCorreo.CN_Correo.ObtenerServicio(CmbNroTrab.Text, CmbRemitente.Text)
                    Dim Cantdias As Integer = ConfigCorreo.CN_Correo.ObtenerDiasServicio(CodServ)
                    Dim dias As Date = Now.ToShortDateString
                    DtFechTrab.Value = dias.AddDays(Cantdias)
                    BtnSeleccionar.Enabled = False

                End If

            End If
        End If

    End Sub


    Private Sub CmbRemitente_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbRemitente.KeyDown
        If (e.KeyCode = Keys.ControlKey) Then
            m_controlPresionado = True
        Else
            If (e.KeyCode = Keys.I AndAlso m_controlPresionado) Then
                'MessageBox.Show("control i")
                CargarCarta()
            Else
                If (e.KeyCode = Keys.N AndAlso m_controlPresionado) Then
                    Limpiar()
                    Activar()
                    'MessageBox.Show("control n")
                End If

            End If
            m_controlPresionado = False
        End If
    End Sub

    Private Sub BtnIngresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnIngresar.Click
        CargarCarta()
    End Sub

    Private Sub CargarCarta()

        Dim nroCarta As String = TxtNro_Carta.Text
        Dim remitente As String = CmbRemitente.Text
        Dim trabajo As String = CmbNroTrab.Text
        Dim fechTrab As Date = DtFechTrab.Value
        Dim apellido As String = TxtNombre_Apellido.Text
        Dim cp As String = TxtCp.Text
        Dim calle As String = TxtCalle.Text
        Dim pisoDepto As String = TxtPisoDepto.Text
        Dim localidad As String = TxtLocalidad.Text
        Dim provincia As String = TxtProvincia.Text
        Dim nroCart2 As String = TxtNro_Carta2.Text
        Dim empresa As String = TxtEmpresa.Text
        Dim socio As String = TxtSocio.Text
        Dim obs As String = TxtObs.Text
        Dim obs2 As String = TxtObs2.Text
        Dim obs3 As String = TxtObs3.Text
        Dim obs4 As String = TxtObs4.Text


        If ConfigCorreo.CN_Correo.InsertarRegistroCartas(nroCarta, remitente, trabajo, fechTrab, apellido, cp, calle, pisoDepto, localidad, provincia, nroCart2, empresa, socio, obs, obs2, obs3, obs4) = True Then
            ConfigCorreo.CN_Correo.ActualizarNroCarta(TxtNro_Carta.Text + 1)
            Limpiar()
            ObtenerNroCarta()

        End If

    End Sub


End Class
