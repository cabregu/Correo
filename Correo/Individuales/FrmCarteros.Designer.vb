<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCarteros
    Inherits Correo.FrmPlantilla

    'Form invalida a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.TxtApellido = New System.Windows.Forms.TextBox()
        Me.LblApellido = New System.Windows.Forms.Label()
        Me.LblDni = New System.Windows.Forms.Label()
        Me.TxtNroDni = New System.Windows.Forms.TextBox()
        Me.LblDireccion = New System.Windows.Forms.Label()
        Me.TxtDireccion = New System.Windows.Forms.TextBox()
        Me.LblTelefono = New System.Windows.Forms.Label()
        Me.TxtTelefono = New System.Windows.Forms.TextBox()
        Me.Lblcelular = New System.Windows.Forms.Label()
        Me.TxtCelular = New System.Windows.Forms.TextBox()
        Me.LblCP = New System.Windows.Forms.Label()
        Me.Txtcp = New System.Windows.Forms.TextBox()
        Me.LblLocalidad = New System.Windows.Forms.Label()
        Me.TxtLocalidad = New System.Windows.Forms.TextBox()
        Me.LblIngreso = New System.Windows.Forms.Label()
        Me.DtpIngreso = New System.Windows.Forms.DateTimePicker()
        Me.LblProvincia = New System.Windows.Forms.Label()
        Me.Txtprovincia = New System.Windows.Forms.TextBox()
        Me.TxtTipodni = New System.Windows.Forms.TextBox()
        Me.Cmbtipoproveedor = New System.Windows.Forms.ComboBox()
        Me.LblTipoProveedor = New System.Windows.Forms.Label()
        Me.LbltipoVehiculo = New System.Windows.Forms.Label()
        Me.txttipovehiculo = New System.Windows.Forms.TextBox()
        Me.Lblvehiculo = New System.Windows.Forms.Label()
        Me.Txtvehiculo = New System.Windows.Forms.TextBox()
        Me.LvlPatente = New System.Windows.Forms.Label()
        Me.Txtpatente = New System.Windows.Forms.TextBox()
        Me.LblMarca = New System.Windows.Forms.Label()
        Me.Txtmarca = New System.Windows.Forms.TextBox()
        Me.LblGps = New System.Windows.Forms.Label()
        Me.Txtgps = New System.Windows.Forms.TextBox()
        Me.LblMailPropietario = New System.Windows.Forms.Label()
        Me.TxtEmailPropietario = New System.Windows.Forms.TextBox()
        Me.Lblnombrepropietario = New System.Windows.Forms.Label()
        Me.Txtnombrepropietario = New System.Windows.Forms.TextBox()
        Me.Lbltelefonopropietario = New System.Windows.Forms.Label()
        Me.TxtTelefonoPropietario = New System.Windows.Forms.TextBox()
        Me.Direccionpropietario = New System.Windows.Forms.Label()
        Me.TxtDireccionpropietario = New System.Windows.Forms.TextBox()
        Me.LblMail = New System.Windows.Forms.Label()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.BtnBaja = New System.Windows.Forms.Button()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.DtpFechaBaja = New System.Windows.Forms.DateTimePicker()
        Me.LblFechaBaja = New System.Windows.Forms.Label()
        Me.LblCartero = New System.Windows.Forms.Label()
        Me.CmbCartero = New System.Windows.Forms.ComboBox()
        Me.LblIdCartero = New System.Windows.Forms.Label()
        Me.TxtIdCartero = New System.Windows.Forms.TextBox()
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Gb.SuspendLayout()
        Me.SuspendLayout()
        '
        'PBLogo
        '
        Me.PBLogo.Location = New System.Drawing.Point(5, 418)
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(651, 419)
        '
        'Gb
        '
        Me.Gb.Controls.Add(Me.LblIdCartero)
        Me.Gb.Controls.Add(Me.TxtIdCartero)
        Me.Gb.Controls.Add(Me.LblCartero)
        Me.Gb.Controls.Add(Me.CmbCartero)
        Me.Gb.Controls.Add(Me.DtpFechaBaja)
        Me.Gb.Controls.Add(Me.LblFechaBaja)
        Me.Gb.Controls.Add(Me.BtnAceptar)
        Me.Gb.Controls.Add(Me.BtnBaja)
        Me.Gb.Controls.Add(Me.BtnBuscar)
        Me.Gb.Controls.Add(Me.BtnNuevo)
        Me.Gb.Controls.Add(Me.TxtEmail)
        Me.Gb.Controls.Add(Me.LblMail)
        Me.Gb.Controls.Add(Me.LblMailPropietario)
        Me.Gb.Controls.Add(Me.TxtEmailPropietario)
        Me.Gb.Controls.Add(Me.Lblnombrepropietario)
        Me.Gb.Controls.Add(Me.Txtnombrepropietario)
        Me.Gb.Controls.Add(Me.Lbltelefonopropietario)
        Me.Gb.Controls.Add(Me.TxtTelefonoPropietario)
        Me.Gb.Controls.Add(Me.Direccionpropietario)
        Me.Gb.Controls.Add(Me.TxtDireccionpropietario)
        Me.Gb.Controls.Add(Me.LblGps)
        Me.Gb.Controls.Add(Me.Txtgps)
        Me.Gb.Controls.Add(Me.LbltipoVehiculo)
        Me.Gb.Controls.Add(Me.txttipovehiculo)
        Me.Gb.Controls.Add(Me.Lblvehiculo)
        Me.Gb.Controls.Add(Me.Txtvehiculo)
        Me.Gb.Controls.Add(Me.LvlPatente)
        Me.Gb.Controls.Add(Me.Txtpatente)
        Me.Gb.Controls.Add(Me.LblMarca)
        Me.Gb.Controls.Add(Me.Txtmarca)
        Me.Gb.Controls.Add(Me.LblTipoProveedor)
        Me.Gb.Controls.Add(Me.Cmbtipoproveedor)
        Me.Gb.Controls.Add(Me.TxtTipodni)
        Me.Gb.Controls.Add(Me.LblProvincia)
        Me.Gb.Controls.Add(Me.Txtprovincia)
        Me.Gb.Controls.Add(Me.DtpIngreso)
        Me.Gb.Controls.Add(Me.LblIngreso)
        Me.Gb.Controls.Add(Me.LblLocalidad)
        Me.Gb.Controls.Add(Me.TxtLocalidad)
        Me.Gb.Controls.Add(Me.LblCP)
        Me.Gb.Controls.Add(Me.Txtcp)
        Me.Gb.Controls.Add(Me.Lblcelular)
        Me.Gb.Controls.Add(Me.TxtCelular)
        Me.Gb.Controls.Add(Me.LblTelefono)
        Me.Gb.Controls.Add(Me.TxtTelefono)
        Me.Gb.Controls.Add(Me.LblDireccion)
        Me.Gb.Controls.Add(Me.TxtDireccion)
        Me.Gb.Controls.Add(Me.LblDni)
        Me.Gb.Controls.Add(Me.TxtNroDni)
        Me.Gb.Controls.Add(Me.LblApellido)
        Me.Gb.Controls.Add(Me.TxtApellido)
        Me.Gb.Controls.Add(Me.LblNombre)
        Me.Gb.Controls.Add(Me.TxtNombre)
        Me.Gb.Location = New System.Drawing.Point(0, 0)
        Me.Gb.Size = New System.Drawing.Size(698, 469)
        Me.Gb.Controls.SetChildIndex(Me.TxtNombre, 0)
        Me.Gb.Controls.SetChildIndex(Me.LblNombre, 0)
        Me.Gb.Controls.SetChildIndex(Me.PBLogo, 0)
        Me.Gb.Controls.SetChildIndex(Me.BtnSalir, 0)
        Me.Gb.Controls.SetChildIndex(Me.TxtApellido, 0)
        Me.Gb.Controls.SetChildIndex(Me.LblApellido, 0)
        Me.Gb.Controls.SetChildIndex(Me.TxtNroDni, 0)
        Me.Gb.Controls.SetChildIndex(Me.LblDni, 0)
        Me.Gb.Controls.SetChildIndex(Me.TxtDireccion, 0)
        Me.Gb.Controls.SetChildIndex(Me.LblDireccion, 0)
        Me.Gb.Controls.SetChildIndex(Me.TxtTelefono, 0)
        Me.Gb.Controls.SetChildIndex(Me.LblTelefono, 0)
        Me.Gb.Controls.SetChildIndex(Me.TxtCelular, 0)
        Me.Gb.Controls.SetChildIndex(Me.Lblcelular, 0)
        Me.Gb.Controls.SetChildIndex(Me.Txtcp, 0)
        Me.Gb.Controls.SetChildIndex(Me.LblCP, 0)
        Me.Gb.Controls.SetChildIndex(Me.TxtLocalidad, 0)
        Me.Gb.Controls.SetChildIndex(Me.LblLocalidad, 0)
        Me.Gb.Controls.SetChildIndex(Me.LblIngreso, 0)
        Me.Gb.Controls.SetChildIndex(Me.DtpIngreso, 0)
        Me.Gb.Controls.SetChildIndex(Me.Txtprovincia, 0)
        Me.Gb.Controls.SetChildIndex(Me.LblProvincia, 0)
        Me.Gb.Controls.SetChildIndex(Me.TxtTipodni, 0)
        Me.Gb.Controls.SetChildIndex(Me.Cmbtipoproveedor, 0)
        Me.Gb.Controls.SetChildIndex(Me.LblTipoProveedor, 0)
        Me.Gb.Controls.SetChildIndex(Me.Txtmarca, 0)
        Me.Gb.Controls.SetChildIndex(Me.LblMarca, 0)
        Me.Gb.Controls.SetChildIndex(Me.Txtpatente, 0)
        Me.Gb.Controls.SetChildIndex(Me.LvlPatente, 0)
        Me.Gb.Controls.SetChildIndex(Me.Txtvehiculo, 0)
        Me.Gb.Controls.SetChildIndex(Me.Lblvehiculo, 0)
        Me.Gb.Controls.SetChildIndex(Me.txttipovehiculo, 0)
        Me.Gb.Controls.SetChildIndex(Me.LbltipoVehiculo, 0)
        Me.Gb.Controls.SetChildIndex(Me.Txtgps, 0)
        Me.Gb.Controls.SetChildIndex(Me.LblGps, 0)
        Me.Gb.Controls.SetChildIndex(Me.TxtDireccionpropietario, 0)
        Me.Gb.Controls.SetChildIndex(Me.Direccionpropietario, 0)
        Me.Gb.Controls.SetChildIndex(Me.TxtTelefonoPropietario, 0)
        Me.Gb.Controls.SetChildIndex(Me.Lbltelefonopropietario, 0)
        Me.Gb.Controls.SetChildIndex(Me.Txtnombrepropietario, 0)
        Me.Gb.Controls.SetChildIndex(Me.Lblnombrepropietario, 0)
        Me.Gb.Controls.SetChildIndex(Me.TxtEmailPropietario, 0)
        Me.Gb.Controls.SetChildIndex(Me.LblMailPropietario, 0)
        Me.Gb.Controls.SetChildIndex(Me.LblMail, 0)
        Me.Gb.Controls.SetChildIndex(Me.TxtEmail, 0)
        Me.Gb.Controls.SetChildIndex(Me.BtnNuevo, 0)
        Me.Gb.Controls.SetChildIndex(Me.BtnBuscar, 0)
        Me.Gb.Controls.SetChildIndex(Me.BtnBaja, 0)
        Me.Gb.Controls.SetChildIndex(Me.BtnAceptar, 0)
        Me.Gb.Controls.SetChildIndex(Me.LblFechaBaja, 0)
        Me.Gb.Controls.SetChildIndex(Me.DtpFechaBaja, 0)
        Me.Gb.Controls.SetChildIndex(Me.CmbCartero, 0)
        Me.Gb.Controls.SetChildIndex(Me.LblCartero, 0)
        Me.Gb.Controls.SetChildIndex(Me.TxtIdCartero, 0)
        Me.Gb.Controls.SetChildIndex(Me.LblIdCartero, 0)
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.Location = New System.Drawing.Point(31, 120)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(44, 13)
        Me.LblNombre.TabIndex = 30
        Me.LblNombre.Text = "Nombre"
        '
        'TxtNombre
        '
        Me.TxtNombre.BackColor = System.Drawing.Color.LightGray
        Me.TxtNombre.Enabled = False
        Me.TxtNombre.Location = New System.Drawing.Point(112, 120)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(220, 20)
        Me.TxtNombre.TabIndex = 2
        '
        'TxtApellido
        '
        Me.TxtApellido.BackColor = System.Drawing.Color.LightGray
        Me.TxtApellido.Enabled = False
        Me.TxtApellido.Location = New System.Drawing.Point(112, 146)
        Me.TxtApellido.Name = "TxtApellido"
        Me.TxtApellido.Size = New System.Drawing.Size(220, 20)
        Me.TxtApellido.TabIndex = 3
        '
        'LblApellido
        '
        Me.LblApellido.AutoSize = True
        Me.LblApellido.Location = New System.Drawing.Point(31, 146)
        Me.LblApellido.Name = "LblApellido"
        Me.LblApellido.Size = New System.Drawing.Size(44, 13)
        Me.LblApellido.TabIndex = 33
        Me.LblApellido.Text = "Apellido"
        '
        'LblDni
        '
        Me.LblDni.AutoSize = True
        Me.LblDni.Location = New System.Drawing.Point(31, 171)
        Me.LblDni.Name = "LblDni"
        Me.LblDni.Size = New System.Drawing.Size(62, 13)
        Me.LblDni.TabIndex = 35
        Me.LblDni.Text = "Documento"
        '
        'TxtNroDni
        '
        Me.TxtNroDni.BackColor = System.Drawing.Color.LightGray
        Me.TxtNroDni.Enabled = False
        Me.TxtNroDni.Location = New System.Drawing.Point(163, 172)
        Me.TxtNroDni.Name = "TxtNroDni"
        Me.TxtNroDni.Size = New System.Drawing.Size(100, 20)
        Me.TxtNroDni.TabIndex = 5
        '
        'LblDireccion
        '
        Me.LblDireccion.AutoSize = True
        Me.LblDireccion.Location = New System.Drawing.Point(31, 197)
        Me.LblDireccion.Name = "LblDireccion"
        Me.LblDireccion.Size = New System.Drawing.Size(52, 13)
        Me.LblDireccion.TabIndex = 37
        Me.LblDireccion.Text = "Direccion"
        '
        'TxtDireccion
        '
        Me.TxtDireccion.BackColor = System.Drawing.Color.LightGray
        Me.TxtDireccion.Enabled = False
        Me.TxtDireccion.Location = New System.Drawing.Point(112, 198)
        Me.TxtDireccion.Name = "TxtDireccion"
        Me.TxtDireccion.Size = New System.Drawing.Size(220, 20)
        Me.TxtDireccion.TabIndex = 6
        '
        'LblTelefono
        '
        Me.LblTelefono.AutoSize = True
        Me.LblTelefono.Location = New System.Drawing.Point(31, 305)
        Me.LblTelefono.Name = "LblTelefono"
        Me.LblTelefono.Size = New System.Drawing.Size(49, 13)
        Me.LblTelefono.TabIndex = 39
        Me.LblTelefono.Text = "Telefono"
        '
        'TxtTelefono
        '
        Me.TxtTelefono.BackColor = System.Drawing.Color.LightGray
        Me.TxtTelefono.Enabled = False
        Me.TxtTelefono.Location = New System.Drawing.Point(112, 302)
        Me.TxtTelefono.Name = "TxtTelefono"
        Me.TxtTelefono.Size = New System.Drawing.Size(100, 20)
        Me.TxtTelefono.TabIndex = 10
        '
        'Lblcelular
        '
        Me.Lblcelular.AutoSize = True
        Me.Lblcelular.Location = New System.Drawing.Point(31, 331)
        Me.Lblcelular.Name = "Lblcelular"
        Me.Lblcelular.Size = New System.Drawing.Size(39, 13)
        Me.Lblcelular.TabIndex = 41
        Me.Lblcelular.Text = "Celular"
        '
        'TxtCelular
        '
        Me.TxtCelular.BackColor = System.Drawing.Color.LightGray
        Me.TxtCelular.Enabled = False
        Me.TxtCelular.Location = New System.Drawing.Point(112, 328)
        Me.TxtCelular.Name = "TxtCelular"
        Me.TxtCelular.Size = New System.Drawing.Size(100, 20)
        Me.TxtCelular.TabIndex = 11
        '
        'LblCP
        '
        Me.LblCP.AutoSize = True
        Me.LblCP.Location = New System.Drawing.Point(31, 222)
        Me.LblCP.Name = "LblCP"
        Me.LblCP.Size = New System.Drawing.Size(20, 13)
        Me.LblCP.TabIndex = 43
        Me.LblCP.Text = "Cp"
        '
        'Txtcp
        '
        Me.Txtcp.BackColor = System.Drawing.Color.LightGray
        Me.Txtcp.Enabled = False
        Me.Txtcp.Location = New System.Drawing.Point(112, 224)
        Me.Txtcp.Name = "Txtcp"
        Me.Txtcp.Size = New System.Drawing.Size(50, 20)
        Me.Txtcp.TabIndex = 7
        '
        'LblLocalidad
        '
        Me.LblLocalidad.AutoSize = True
        Me.LblLocalidad.Location = New System.Drawing.Point(31, 249)
        Me.LblLocalidad.Name = "LblLocalidad"
        Me.LblLocalidad.Size = New System.Drawing.Size(53, 13)
        Me.LblLocalidad.TabIndex = 45
        Me.LblLocalidad.Text = "Localidad"
        '
        'TxtLocalidad
        '
        Me.TxtLocalidad.BackColor = System.Drawing.Color.LightGray
        Me.TxtLocalidad.Enabled = False
        Me.TxtLocalidad.Location = New System.Drawing.Point(112, 250)
        Me.TxtLocalidad.Name = "TxtLocalidad"
        Me.TxtLocalidad.Size = New System.Drawing.Size(100, 20)
        Me.TxtLocalidad.TabIndex = 8
        '
        'LblIngreso
        '
        Me.LblIngreso.AutoSize = True
        Me.LblIngreso.Location = New System.Drawing.Point(31, 383)
        Me.LblIngreso.Name = "LblIngreso"
        Me.LblIngreso.Size = New System.Drawing.Size(75, 13)
        Me.LblIngreso.TabIndex = 48
        Me.LblIngreso.Text = "Fecha Ingreso"
        '
        'DtpIngreso
        '
        Me.DtpIngreso.Enabled = False
        Me.DtpIngreso.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpIngreso.Location = New System.Drawing.Point(112, 380)
        Me.DtpIngreso.Name = "DtpIngreso"
        Me.DtpIngreso.Size = New System.Drawing.Size(95, 20)
        Me.DtpIngreso.TabIndex = 13
        '
        'LblProvincia
        '
        Me.LblProvincia.AutoSize = True
        Me.LblProvincia.Location = New System.Drawing.Point(31, 279)
        Me.LblProvincia.Name = "LblProvincia"
        Me.LblProvincia.Size = New System.Drawing.Size(51, 13)
        Me.LblProvincia.TabIndex = 51
        Me.LblProvincia.Text = "Provincia"
        '
        'Txtprovincia
        '
        Me.Txtprovincia.BackColor = System.Drawing.Color.LightGray
        Me.Txtprovincia.Enabled = False
        Me.Txtprovincia.Location = New System.Drawing.Point(112, 276)
        Me.Txtprovincia.Name = "Txtprovincia"
        Me.Txtprovincia.Size = New System.Drawing.Size(100, 20)
        Me.Txtprovincia.TabIndex = 9
        '
        'TxtTipodni
        '
        Me.TxtTipodni.BackColor = System.Drawing.Color.LightGray
        Me.TxtTipodni.Enabled = False
        Me.TxtTipodni.Location = New System.Drawing.Point(112, 172)
        Me.TxtTipodni.Name = "TxtTipodni"
        Me.TxtTipodni.Size = New System.Drawing.Size(45, 20)
        Me.TxtTipodni.TabIndex = 4
        '
        'Cmbtipoproveedor
        '
        Me.Cmbtipoproveedor.BackColor = System.Drawing.SystemColors.Window
        Me.Cmbtipoproveedor.Enabled = False
        Me.Cmbtipoproveedor.FormattingEnabled = True
        Me.Cmbtipoproveedor.Location = New System.Drawing.Point(112, 65)
        Me.Cmbtipoproveedor.Name = "Cmbtipoproveedor"
        Me.Cmbtipoproveedor.Size = New System.Drawing.Size(170, 21)
        Me.Cmbtipoproveedor.TabIndex = 0
        '
        'LblTipoProveedor
        '
        Me.LblTipoProveedor.AutoSize = True
        Me.LblTipoProveedor.Location = New System.Drawing.Point(31, 68)
        Me.LblTipoProveedor.Name = "LblTipoProveedor"
        Me.LblTipoProveedor.Size = New System.Drawing.Size(80, 13)
        Me.LblTipoProveedor.TabIndex = 57
        Me.LblTipoProveedor.Text = "Tipo Proveedor"
        '
        'LbltipoVehiculo
        '
        Me.LbltipoVehiculo.AutoSize = True
        Me.LbltipoVehiculo.Location = New System.Drawing.Point(356, 94)
        Me.LbltipoVehiculo.Name = "LbltipoVehiculo"
        Me.LbltipoVehiculo.Size = New System.Drawing.Size(28, 13)
        Me.LbltipoVehiculo.TabIndex = 65
        Me.LbltipoVehiculo.Text = "Tipo"
        '
        'txttipovehiculo
        '
        Me.txttipovehiculo.BackColor = System.Drawing.Color.LightGray
        Me.txttipovehiculo.Enabled = False
        Me.txttipovehiculo.Location = New System.Drawing.Point(469, 93)
        Me.txttipovehiculo.Name = "txttipovehiculo"
        Me.txttipovehiculo.Size = New System.Drawing.Size(100, 20)
        Me.txttipovehiculo.TabIndex = 16
        '
        'Lblvehiculo
        '
        Me.Lblvehiculo.AutoSize = True
        Me.Lblvehiculo.Location = New System.Drawing.Point(356, 68)
        Me.Lblvehiculo.Name = "Lblvehiculo"
        Me.Lblvehiculo.Size = New System.Drawing.Size(48, 13)
        Me.Lblvehiculo.TabIndex = 63
        Me.Lblvehiculo.Text = "Vehiculo"
        '
        'Txtvehiculo
        '
        Me.Txtvehiculo.BackColor = System.Drawing.Color.LightGray
        Me.Txtvehiculo.Enabled = False
        Me.Txtvehiculo.Location = New System.Drawing.Point(469, 67)
        Me.Txtvehiculo.Name = "Txtvehiculo"
        Me.Txtvehiculo.Size = New System.Drawing.Size(100, 20)
        Me.Txtvehiculo.TabIndex = 15
        '
        'LvlPatente
        '
        Me.LvlPatente.AutoSize = True
        Me.LvlPatente.Location = New System.Drawing.Point(356, 146)
        Me.LvlPatente.Name = "LvlPatente"
        Me.LvlPatente.Size = New System.Drawing.Size(44, 13)
        Me.LvlPatente.TabIndex = 61
        Me.LvlPatente.Text = "Patente"
        '
        'Txtpatente
        '
        Me.Txtpatente.BackColor = System.Drawing.Color.LightGray
        Me.Txtpatente.Enabled = False
        Me.Txtpatente.Location = New System.Drawing.Point(469, 145)
        Me.Txtpatente.Name = "Txtpatente"
        Me.Txtpatente.Size = New System.Drawing.Size(100, 20)
        Me.Txtpatente.TabIndex = 18
        '
        'LblMarca
        '
        Me.LblMarca.AutoSize = True
        Me.LblMarca.Location = New System.Drawing.Point(356, 120)
        Me.LblMarca.Name = "LblMarca"
        Me.LblMarca.Size = New System.Drawing.Size(37, 13)
        Me.LblMarca.TabIndex = 59
        Me.LblMarca.Text = "Marca"
        '
        'Txtmarca
        '
        Me.Txtmarca.BackColor = System.Drawing.Color.LightGray
        Me.Txtmarca.Enabled = False
        Me.Txtmarca.Location = New System.Drawing.Point(469, 119)
        Me.Txtmarca.Name = "Txtmarca"
        Me.Txtmarca.Size = New System.Drawing.Size(100, 20)
        Me.Txtmarca.TabIndex = 17
        '
        'LblGps
        '
        Me.LblGps.AutoSize = True
        Me.LblGps.Location = New System.Drawing.Point(356, 172)
        Me.LblGps.Name = "LblGps"
        Me.LblGps.Size = New System.Drawing.Size(29, 13)
        Me.LblGps.TabIndex = 67
        Me.LblGps.Text = "GPS"
        '
        'Txtgps
        '
        Me.Txtgps.BackColor = System.Drawing.Color.LightGray
        Me.Txtgps.Enabled = False
        Me.Txtgps.Location = New System.Drawing.Point(469, 171)
        Me.Txtgps.Name = "Txtgps"
        Me.Txtgps.Size = New System.Drawing.Size(100, 20)
        Me.Txtgps.TabIndex = 19
        '
        'LblMailPropietario
        '
        Me.LblMailPropietario.AutoSize = True
        Me.LblMailPropietario.Location = New System.Drawing.Point(356, 276)
        Me.LblMailPropietario.Name = "LblMailPropietario"
        Me.LblMailPropietario.Size = New System.Drawing.Size(85, 13)
        Me.LblMailPropietario.TabIndex = 75
        Me.LblMailPropietario.Text = "eMail Propietario"
        '
        'TxtEmailPropietario
        '
        Me.TxtEmailPropietario.BackColor = System.Drawing.Color.LightGray
        Me.TxtEmailPropietario.Enabled = False
        Me.TxtEmailPropietario.Location = New System.Drawing.Point(469, 275)
        Me.TxtEmailPropietario.Name = "TxtEmailPropietario"
        Me.TxtEmailPropietario.Size = New System.Drawing.Size(200, 20)
        Me.TxtEmailPropietario.TabIndex = 23
        '
        'Lblnombrepropietario
        '
        Me.Lblnombrepropietario.AutoSize = True
        Me.Lblnombrepropietario.Location = New System.Drawing.Point(356, 198)
        Me.Lblnombrepropietario.Name = "Lblnombrepropietario"
        Me.Lblnombrepropietario.Size = New System.Drawing.Size(97, 13)
        Me.Lblnombrepropietario.TabIndex = 73
        Me.Lblnombrepropietario.Text = "Nombre Propietario"
        '
        'Txtnombrepropietario
        '
        Me.Txtnombrepropietario.BackColor = System.Drawing.Color.LightGray
        Me.Txtnombrepropietario.Enabled = False
        Me.Txtnombrepropietario.Location = New System.Drawing.Point(469, 197)
        Me.Txtnombrepropietario.Name = "Txtnombrepropietario"
        Me.Txtnombrepropietario.Size = New System.Drawing.Size(200, 20)
        Me.Txtnombrepropietario.TabIndex = 20
        '
        'Lbltelefonopropietario
        '
        Me.Lbltelefonopropietario.AutoSize = True
        Me.Lbltelefonopropietario.Location = New System.Drawing.Point(356, 250)
        Me.Lbltelefonopropietario.Name = "Lbltelefonopropietario"
        Me.Lbltelefonopropietario.Size = New System.Drawing.Size(102, 13)
        Me.Lbltelefonopropietario.TabIndex = 71
        Me.Lbltelefonopropietario.Text = "Telefono Propietario"
        '
        'TxtTelefonoPropietario
        '
        Me.TxtTelefonoPropietario.BackColor = System.Drawing.Color.LightGray
        Me.TxtTelefonoPropietario.Enabled = False
        Me.TxtTelefonoPropietario.Location = New System.Drawing.Point(469, 249)
        Me.TxtTelefonoPropietario.Name = "TxtTelefonoPropietario"
        Me.TxtTelefonoPropietario.Size = New System.Drawing.Size(200, 20)
        Me.TxtTelefonoPropietario.TabIndex = 22
        '
        'Direccionpropietario
        '
        Me.Direccionpropietario.AutoSize = True
        Me.Direccionpropietario.Location = New System.Drawing.Point(356, 224)
        Me.Direccionpropietario.Name = "Direccionpropietario"
        Me.Direccionpropietario.Size = New System.Drawing.Size(105, 13)
        Me.Direccionpropietario.TabIndex = 69
        Me.Direccionpropietario.Text = "Direccion Propietario"
        '
        'TxtDireccionpropietario
        '
        Me.TxtDireccionpropietario.BackColor = System.Drawing.Color.LightGray
        Me.TxtDireccionpropietario.Enabled = False
        Me.TxtDireccionpropietario.Location = New System.Drawing.Point(469, 223)
        Me.TxtDireccionpropietario.Name = "TxtDireccionpropietario"
        Me.TxtDireccionpropietario.Size = New System.Drawing.Size(200, 20)
        Me.TxtDireccionpropietario.TabIndex = 21
        '
        'LblMail
        '
        Me.LblMail.AutoSize = True
        Me.LblMail.Location = New System.Drawing.Point(31, 357)
        Me.LblMail.Name = "LblMail"
        Me.LblMail.Size = New System.Drawing.Size(32, 13)
        Me.LblMail.TabIndex = 76
        Me.LblMail.Text = "eMail"
        '
        'TxtEmail
        '
        Me.TxtEmail.BackColor = System.Drawing.Color.LightGray
        Me.TxtEmail.Enabled = False
        Me.TxtEmail.Location = New System.Drawing.Point(112, 354)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(200, 20)
        Me.TxtEmail.TabIndex = 12
        '
        'BtnNuevo
        '
        Me.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNuevo.Location = New System.Drawing.Point(518, 347)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.BtnNuevo.TabIndex = 81
        Me.BtnNuevo.Text = "Nuevo"
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'BtnBuscar
        '
        Me.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBuscar.Location = New System.Drawing.Point(518, 376)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.BtnBuscar.TabIndex = 82
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'BtnBaja
        '
        Me.BtnBaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBaja.Location = New System.Drawing.Point(595, 376)
        Me.BtnBaja.Name = "BtnBaja"
        Me.BtnBaja.Size = New System.Drawing.Size(75, 23)
        Me.BtnBaja.TabIndex = 83
        Me.BtnBaja.Text = "Baja"
        Me.BtnBaja.UseVisualStyleBackColor = True
        '
        'BtnAceptar
        '
        Me.BtnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAceptar.Location = New System.Drawing.Point(594, 347)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.BtnAceptar.TabIndex = 84
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = True
        Me.BtnAceptar.Visible = False
        '
        'DtpFechaBaja
        '
        Me.DtpFechaBaja.Enabled = False
        Me.DtpFechaBaja.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaBaja.Location = New System.Drawing.Point(469, 39)
        Me.DtpFechaBaja.Name = "DtpFechaBaja"
        Me.DtpFechaBaja.Size = New System.Drawing.Size(95, 20)
        Me.DtpFechaBaja.TabIndex = 14
        Me.DtpFechaBaja.Visible = False
        '
        'LblFechaBaja
        '
        Me.LblFechaBaja.AutoSize = True
        Me.LblFechaBaja.Location = New System.Drawing.Point(356, 43)
        Me.LblFechaBaja.Name = "LblFechaBaja"
        Me.LblFechaBaja.Size = New System.Drawing.Size(61, 13)
        Me.LblFechaBaja.TabIndex = 85
        Me.LblFechaBaja.Text = "Fecha Baja"
        Me.LblFechaBaja.Visible = False
        '
        'LblCartero
        '
        Me.LblCartero.AutoSize = True
        Me.LblCartero.Location = New System.Drawing.Point(31, 46)
        Me.LblCartero.Name = "LblCartero"
        Me.LblCartero.Size = New System.Drawing.Size(41, 13)
        Me.LblCartero.TabIndex = 88
        Me.LblCartero.Text = "Cartero"
        Me.LblCartero.Visible = False
        '
        'CmbCartero
        '
        Me.CmbCartero.BackColor = System.Drawing.SystemColors.Window
        Me.CmbCartero.FormattingEnabled = True
        Me.CmbCartero.Location = New System.Drawing.Point(112, 43)
        Me.CmbCartero.Name = "CmbCartero"
        Me.CmbCartero.Size = New System.Drawing.Size(170, 21)
        Me.CmbCartero.TabIndex = 87
        Me.CmbCartero.Visible = False
        '
        'LblIdCartero
        '
        Me.LblIdCartero.AutoSize = True
        Me.LblIdCartero.Location = New System.Drawing.Point(31, 95)
        Me.LblIdCartero.Name = "LblIdCartero"
        Me.LblIdCartero.Size = New System.Drawing.Size(53, 13)
        Me.LblIdCartero.TabIndex = 89
        Me.LblIdCartero.Text = "Id Cartero"
        '
        'TxtIdCartero
        '
        Me.TxtIdCartero.BackColor = System.Drawing.Color.LightGray
        Me.TxtIdCartero.Enabled = False
        Me.TxtIdCartero.Location = New System.Drawing.Point(112, 92)
        Me.TxtIdCartero.Name = "TxtIdCartero"
        Me.TxtIdCartero.Size = New System.Drawing.Size(150, 20)
        Me.TxtIdCartero.TabIndex = 1
        '
        'FrmCarteros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(699, 471)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmCarteros"
        Me.Text = "Carteros"
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Gb.ResumeLayout(False)
        Me.Gb.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LblNombre As System.Windows.Forms.Label
    Friend WithEvents TxtNombre As System.Windows.Forms.TextBox
    Friend WithEvents TxtApellido As System.Windows.Forms.TextBox
    Friend WithEvents LblLocalidad As System.Windows.Forms.Label
    Friend WithEvents TxtLocalidad As System.Windows.Forms.TextBox
    Friend WithEvents LblCP As System.Windows.Forms.Label
    Friend WithEvents Txtcp As System.Windows.Forms.TextBox
    Friend WithEvents Lblcelular As System.Windows.Forms.Label
    Friend WithEvents TxtCelular As System.Windows.Forms.TextBox
    Friend WithEvents LblTelefono As System.Windows.Forms.Label
    Friend WithEvents TxtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents LblDireccion As System.Windows.Forms.Label
    Friend WithEvents TxtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents LblDni As System.Windows.Forms.Label
    Friend WithEvents TxtNroDni As System.Windows.Forms.TextBox
    Friend WithEvents LblApellido As System.Windows.Forms.Label
    Friend WithEvents DtpIngreso As System.Windows.Forms.DateTimePicker
    Friend WithEvents LblIngreso As System.Windows.Forms.Label
    Friend WithEvents LblProvincia As System.Windows.Forms.Label
    Friend WithEvents Txtprovincia As System.Windows.Forms.TextBox
    Friend WithEvents TxtTipodni As System.Windows.Forms.TextBox
    Friend WithEvents LblTipoProveedor As System.Windows.Forms.Label
    Friend WithEvents Cmbtipoproveedor As System.Windows.Forms.ComboBox
    Friend WithEvents LblGps As System.Windows.Forms.Label
    Friend WithEvents Txtgps As System.Windows.Forms.TextBox
    Friend WithEvents LbltipoVehiculo As System.Windows.Forms.Label
    Friend WithEvents txttipovehiculo As System.Windows.Forms.TextBox
    Friend WithEvents Lblvehiculo As System.Windows.Forms.Label
    Friend WithEvents Txtvehiculo As System.Windows.Forms.TextBox
    Friend WithEvents LvlPatente As System.Windows.Forms.Label
    Friend WithEvents Txtpatente As System.Windows.Forms.TextBox
    Friend WithEvents LblMarca As System.Windows.Forms.Label
    Friend WithEvents Txtmarca As System.Windows.Forms.TextBox
    Friend WithEvents TxtEmail As System.Windows.Forms.TextBox
    Friend WithEvents LblMail As System.Windows.Forms.Label
    Friend WithEvents LblMailPropietario As System.Windows.Forms.Label
    Friend WithEvents TxtEmailPropietario As System.Windows.Forms.TextBox
    Friend WithEvents Lblnombrepropietario As System.Windows.Forms.Label
    Friend WithEvents Txtnombrepropietario As System.Windows.Forms.TextBox
    Friend WithEvents Lbltelefonopropietario As System.Windows.Forms.Label
    Friend WithEvents TxtTelefonoPropietario As System.Windows.Forms.TextBox
    Friend WithEvents Direccionpropietario As System.Windows.Forms.Label
    Friend WithEvents TxtDireccionpropietario As System.Windows.Forms.TextBox
    Friend WithEvents BtnBaja As System.Windows.Forms.Button
    Friend WithEvents BtnBuscar As System.Windows.Forms.Button
    Friend WithEvents BtnNuevo As System.Windows.Forms.Button
    Friend WithEvents BtnAceptar As System.Windows.Forms.Button
    Friend WithEvents DtpFechaBaja As System.Windows.Forms.DateTimePicker
    Friend WithEvents LblFechaBaja As System.Windows.Forms.Label
    Friend WithEvents LblCartero As System.Windows.Forms.Label
    Friend WithEvents CmbCartero As System.Windows.Forms.ComboBox
    Friend WithEvents LblIdCartero As System.Windows.Forms.Label
    Friend WithEvents TxtIdCartero As System.Windows.Forms.TextBox

End Class
