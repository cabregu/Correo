Public Class FrmCarteros

    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click
        Cmbtipoproveedor.Enabled = True
        Dim ArrayCarteros As New ArrayList
        ArrayCarteros = ConfigCorreo.CN_Correo.CargarTipoCarteros
        Cmbtipoproveedor.Items.Clear()
        For i As Integer = 0 To ArrayCarteros.Count - 1
            Cmbtipoproveedor.Items.Add(ArrayCarteros.Item(i).ToString)
        Next
        BtnNuevo.Visible = False
        BtnAceptar.Visible = True
    End Sub
    Private Sub Cmbtipoproveedor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmbtipoproveedor.SelectedIndexChanged
        If Len(Cmbtipoproveedor.Text) > 0 Then
            If Cmbtipoproveedor.Text = "Chofer" Then
                Carterolocal()
                CarteroChofer()
            Else
                Carterolocal()
                Nochofer()
            End If
        End If
    End Sub

    Private Sub BtnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click

        If Len(TxtIdCartero.Text) > 0 Then
            ConfigCorreo.CN_Correo.IngresarCartero(TxtIdCartero.Text, TxtNombre.Text, TxtApellido.Text, TxtTipodni.Text, TxtNroDni.Text, TxtDireccion.Text, Txtcp.Text, TxtLocalidad.Text, Txtprovincia.Text, TxtTelefono.Text, TxtCelular.Text, TxtEmail.Text, ConfigCorreo.CN_Correo.Converfecha(DtpIngreso.Value.ToShortDateString), Txtvehiculo.Text, txttipovehiculo.Text, Txtmarca.Text, Txtpatente.Text, Txtgps.Text, Txtnombrepropietario.Text, TxtDireccionpropietario.Text, TxtTelefonoPropietario.Text, TxtEmailPropietario.Text, ConfigCorreo.CN_Correo.Converfecha(DtpIngreso.Value.ToShortDateString))
            Limpiar()
            DesactivarTodo()
            volveragris()
            BtnNuevo.Visible = True
            BtnAceptar.Visible = False
            DtpIngreso.Enabled = False
        End If

    End Sub
    Private Sub Limpiar()
        Cmbtipoproveedor.Text = ""
        TxtIdCartero.Text = ""
        TxtNombre.Text = ""
        TxtApellido.Text = ""
        TxtTipodni.Text = ""
        TxtNroDni.Text = ""
        TxtDireccion.Text = ""
        Txtcp.Text = ""
        TxtLocalidad.Text = ""
        Txtprovincia.Text = ""
        TxtTelefono.Text = ""
        TxtCelular.Text = ""
        TxtEmail.Text = ""
        Txtvehiculo.Text = ""
        txttipovehiculo.Text = ""
        Txtmarca.Text = ""
        Txtpatente.Text = ""
        Txtgps.Text = ""
        Txtnombrepropietario.Text = ""
        TxtDireccionpropietario.Text = ""
        TxtTelefonoPropietario.Text = ""
        TxtEmailPropietario.Text = ""
        DtpIngreso.Value = Now.ToShortDateString

    End Sub
    Private Sub DesactivarTodo()
        TxtIdCartero.Enabled = False
        TxtNombre.Enabled = False
        TxtApellido.Enabled = False
        TxtTipodni.Enabled = False
        TxtNroDni.Enabled = False
        TxtDireccion.Enabled = False
        Txtcp.Enabled = False
        TxtLocalidad.Enabled = False
        Txtprovincia.Enabled = False
        TxtTelefono.Enabled = False
        TxtCelular.Enabled = False
        TxtEmail.Enabled = False
        Txtvehiculo.Enabled = False
        txttipovehiculo.Enabled = False
        Txtmarca.Enabled = False
        Txtpatente.Enabled = False
        Txtgps.Enabled = False
        Txtnombrepropietario.Enabled = False
        TxtDireccionpropietario.Enabled = False
        TxtTelefonoPropietario.Enabled = False
        TxtEmailPropietario.Enabled = False
        Cmbtipoproveedor.Enabled = False

    End Sub
    Private Sub volveragris()
        TxtIdCartero.BackColor = Color.LightGray
        TxtNombre.BackColor = Color.LightGray
        TxtApellido.BackColor = Color.LightGray
        TxtTipodni.BackColor = Color.LightGray
        TxtNroDni.BackColor = Color.LightGray
        TxtDireccion.BackColor = Color.LightGray
        Txtcp.BackColor = Color.LightGray
        TxtLocalidad.BackColor = Color.LightGray
        Txtprovincia.BackColor = Color.LightGray
        TxtTelefono.BackColor = Color.LightGray
        TxtCelular.BackColor = Color.LightGray
        TxtEmail.BackColor = Color.LightGray
        Txtvehiculo.BackColor = Color.LightGray
        txttipovehiculo.BackColor = Color.LightGray
        Txtmarca.BackColor = Color.LightGray
        Txtpatente.BackColor = Color.LightGray
        Txtgps.BackColor = Color.LightGray
        Txtnombrepropietario.BackColor = Color.LightGray
        TxtDireccionpropietario.BackColor = Color.LightGray
        TxtTelefonoPropietario.BackColor = Color.LightGray
        TxtEmailPropietario.BackColor = Color.LightGray

    End Sub

    Private Sub Carterolocal()

        TxtIdCartero.Enabled = True
        TxtIdCartero.BackColor = Color.White
        TxtNombre.Enabled = True
        TxtNombre.BackColor = Color.White
        TxtApellido.Enabled = True
        TxtApellido.BackColor = Color.White
        TxtTipodni.Enabled = True
        TxtTipodni.BackColor = Color.White
        TxtNroDni.Enabled = True
        TxtNroDni.BackColor = Color.White
        TxtDireccion.Enabled = True
        TxtDireccion.BackColor = Color.White
        Txtcp.Enabled = True
        Txtcp.BackColor = Color.White
        TxtLocalidad.Enabled = True
        TxtLocalidad.BackColor = Color.White
        Txtprovincia.Enabled = True
        Txtprovincia.BackColor = Color.White
        TxtTelefono.Enabled = True
        TxtTelefono.BackColor = Color.White
        TxtCelular.Enabled = True
        TxtCelular.BackColor = Color.White
        TxtEmail.Enabled = True
        TxtEmail.BackColor = Color.White
        DtpIngreso.Enabled = True

    End Sub
    Private Sub CarteroChofer()

        Txtvehiculo.Enabled = True
        Txtvehiculo.BackColor = Color.White
        txttipovehiculo.Enabled = True
        txttipovehiculo.BackColor = Color.White
        Txtmarca.Enabled = True
        Txtmarca.BackColor = Color.White
        Txtpatente.Enabled = True
        Txtpatente.BackColor = Color.White
        Txtgps.Enabled = True
        Txtgps.BackColor = Color.White
        Txtnombrepropietario.Enabled = True
        Txtnombrepropietario.BackColor = Color.White
        TxtDireccionpropietario.Enabled = True
        TxtDireccionpropietario.BackColor = Color.White
        TxtTelefonoPropietario.Enabled = True
        TxtTelefonoPropietario.BackColor = Color.White
        TxtEmailPropietario.Enabled = True
        TxtEmailPropietario.BackColor = Color.White




    End Sub
    Private Sub Nochofer()

        Txtvehiculo.Enabled = False
        Txtvehiculo.BackColor = Color.LightGray
        txttipovehiculo.Enabled = False
        txttipovehiculo.BackColor = Color.LightGray
        Txtmarca.Enabled = False
        Txtmarca.BackColor = Color.LightGray
        Txtpatente.Enabled = False
        Txtpatente.BackColor = Color.LightGray
        Txtgps.Enabled = False
        Txtgps.BackColor = Color.LightGray
        Txtnombrepropietario.Enabled = False
        Txtnombrepropietario.BackColor = Color.LightGray
        TxtDireccionpropietario.Enabled = False
        TxtDireccionpropietario.BackColor = Color.LightGray
        TxtTelefonoPropietario.Enabled = False
        TxtTelefonoPropietario.BackColor = Color.LightGray
        TxtEmailPropietario.Enabled = False
        TxtEmailPropietario.BackColor = Color.LightGray
    End Sub


    Private Sub BtnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscar.Click
        CmbCartero.Visible = True
        LblCartero.Visible = True
        Cmbtipoproveedor.Visible = False
        LblTipoProveedor.Visible = False


    End Sub
End Class
