<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCargaManual
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TxtNombre_Apellido = New System.Windows.Forms.TextBox()
        Me.TxtCp = New System.Windows.Forms.TextBox()
        Me.TxtProvincia = New System.Windows.Forms.TextBox()
        Me.TxtNro_Carta2 = New System.Windows.Forms.TextBox()
        Me.TxtCalle = New System.Windows.Forms.TextBox()
        Me.TxtLocalidad = New System.Windows.Forms.TextBox()
        Me.TxtEmpresa = New System.Windows.Forms.TextBox()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.LblCalle = New System.Windows.Forms.Label()
        Me.LblCP = New System.Windows.Forms.Label()
        Me.LblLocalidad = New System.Windows.Forms.Label()
        Me.LblProvincia = New System.Windows.Forms.Label()
        Me.LblEmpresa = New System.Windows.Forms.Label()
        Me.LblNro_Carta2 = New System.Windows.Forms.Label()
        Me.LblSocio = New System.Windows.Forms.Label()
        Me.TxtSocio = New System.Windows.Forms.TextBox()
        Me.LblObs = New System.Windows.Forms.Label()
        Me.TxtObs = New System.Windows.Forms.TextBox()
        Me.LblObs2 = New System.Windows.Forms.Label()
        Me.TxtObs2 = New System.Windows.Forms.TextBox()
        Me.LblObs3 = New System.Windows.Forms.Label()
        Me.TxtObs3 = New System.Windows.Forms.TextBox()
        Me.LblObs4 = New System.Windows.Forms.Label()
        Me.TxtObs4 = New System.Windows.Forms.TextBox()
        Me.TxtNro_Carta = New System.Windows.Forms.TextBox()
        Me.LblNro_Carta = New System.Windows.Forms.Label()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnIngresar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.CmbRemitente = New System.Windows.Forms.ComboBox()
        Me.LblServicio = New System.Windows.Forms.Label()
        Me.LblNroTrabajo = New System.Windows.Forms.Label()
        Me.CmbNroTrab = New System.Windows.Forms.ComboBox()
        Me.BtnSeleccionar = New System.Windows.Forms.Button()
        Me.DtFechTrab = New System.Windows.Forms.DateTimePicker()
        Me.LblFecha_Trab = New System.Windows.Forms.Label()
        Me.LvlPisoDepto = New System.Windows.Forms.Label()
        Me.TxtPisoDepto = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'TxtNombre_Apellido
        '
        Me.TxtNombre_Apellido.BackColor = System.Drawing.Color.Gainsboro
        Me.TxtNombre_Apellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNombre_Apellido.Enabled = False
        Me.TxtNombre_Apellido.Location = New System.Drawing.Point(55, 78)
        Me.TxtNombre_Apellido.Name = "TxtNombre_Apellido"
        Me.TxtNombre_Apellido.Size = New System.Drawing.Size(263, 20)
        Me.TxtNombre_Apellido.TabIndex = 1
        '
        'TxtCp
        '
        Me.TxtCp.BackColor = System.Drawing.Color.Gainsboro
        Me.TxtCp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCp.Enabled = False
        Me.TxtCp.Location = New System.Drawing.Point(55, 123)
        Me.TxtCp.Name = "TxtCp"
        Me.TxtCp.Size = New System.Drawing.Size(124, 20)
        Me.TxtCp.TabIndex = 3
        '
        'TxtProvincia
        '
        Me.TxtProvincia.BackColor = System.Drawing.Color.Gainsboro
        Me.TxtProvincia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtProvincia.Enabled = False
        Me.TxtProvincia.Location = New System.Drawing.Point(56, 172)
        Me.TxtProvincia.Name = "TxtProvincia"
        Me.TxtProvincia.Size = New System.Drawing.Size(263, 20)
        Me.TxtProvincia.TabIndex = 6
        '
        'TxtNro_Carta2
        '
        Me.TxtNro_Carta2.BackColor = System.Drawing.Color.Gainsboro
        Me.TxtNro_Carta2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNro_Carta2.Enabled = False
        Me.TxtNro_Carta2.Location = New System.Drawing.Point(325, 172)
        Me.TxtNro_Carta2.Name = "TxtNro_Carta2"
        Me.TxtNro_Carta2.Size = New System.Drawing.Size(226, 20)
        Me.TxtNro_Carta2.TabIndex = 7
        '
        'TxtCalle
        '
        Me.TxtCalle.BackColor = System.Drawing.Color.Gainsboro
        Me.TxtCalle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCalle.Enabled = False
        Me.TxtCalle.Location = New System.Drawing.Point(324, 78)
        Me.TxtCalle.Name = "TxtCalle"
        Me.TxtCalle.Size = New System.Drawing.Size(225, 20)
        Me.TxtCalle.TabIndex = 2
        '
        'TxtLocalidad
        '
        Me.TxtLocalidad.BackColor = System.Drawing.Color.Gainsboro
        Me.TxtLocalidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtLocalidad.Enabled = False
        Me.TxtLocalidad.Location = New System.Drawing.Point(323, 123)
        Me.TxtLocalidad.Name = "TxtLocalidad"
        Me.TxtLocalidad.Size = New System.Drawing.Size(225, 20)
        Me.TxtLocalidad.TabIndex = 5
        '
        'TxtEmpresa
        '
        Me.TxtEmpresa.BackColor = System.Drawing.Color.Gainsboro
        Me.TxtEmpresa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtEmpresa.Enabled = False
        Me.TxtEmpresa.Location = New System.Drawing.Point(56, 216)
        Me.TxtEmpresa.Name = "TxtEmpresa"
        Me.TxtEmpresa.Size = New System.Drawing.Size(263, 20)
        Me.TxtEmpresa.TabIndex = 8
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.Location = New System.Drawing.Point(52, 62)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(112, 13)
        Me.LblNombre.TabIndex = 8
        Me.LblNombre.Text = "NOMBRE_APELLIDO"
        '
        'LblCalle
        '
        Me.LblCalle.AutoSize = True
        Me.LblCalle.Location = New System.Drawing.Point(321, 62)
        Me.LblCalle.Name = "LblCalle"
        Me.LblCalle.Size = New System.Drawing.Size(40, 13)
        Me.LblCalle.TabIndex = 9
        Me.LblCalle.Text = "CALLE"
        '
        'LblCP
        '
        Me.LblCP.AutoSize = True
        Me.LblCP.Location = New System.Drawing.Point(54, 109)
        Me.LblCP.Name = "LblCP"
        Me.LblCP.Size = New System.Drawing.Size(21, 13)
        Me.LblCP.TabIndex = 10
        Me.LblCP.Text = "CP"
        '
        'LblLocalidad
        '
        Me.LblLocalidad.AutoSize = True
        Me.LblLocalidad.Location = New System.Drawing.Point(320, 109)
        Me.LblLocalidad.Name = "LblLocalidad"
        Me.LblLocalidad.Size = New System.Drawing.Size(67, 13)
        Me.LblLocalidad.TabIndex = 11
        Me.LblLocalidad.Text = "LOCALIDAD"
        '
        'LblProvincia
        '
        Me.LblProvincia.AutoSize = True
        Me.LblProvincia.Location = New System.Drawing.Point(52, 158)
        Me.LblProvincia.Name = "LblProvincia"
        Me.LblProvincia.Size = New System.Drawing.Size(65, 13)
        Me.LblProvincia.TabIndex = 12
        Me.LblProvincia.Text = "PROVINCIA"
        '
        'LblEmpresa
        '
        Me.LblEmpresa.AutoSize = True
        Me.LblEmpresa.Location = New System.Drawing.Point(56, 200)
        Me.LblEmpresa.Name = "LblEmpresa"
        Me.LblEmpresa.Size = New System.Drawing.Size(59, 13)
        Me.LblEmpresa.TabIndex = 13
        Me.LblEmpresa.Text = "EMPRESA"
        '
        'LblNro_Carta2
        '
        Me.LblNro_Carta2.AutoSize = True
        Me.LblNro_Carta2.Location = New System.Drawing.Point(325, 156)
        Me.LblNro_Carta2.Name = "LblNro_Carta2"
        Me.LblNro_Carta2.Size = New System.Drawing.Size(79, 13)
        Me.LblNro_Carta2.TabIndex = 14
        Me.LblNro_Carta2.Text = "NRO_CARTA2"
        '
        'LblSocio
        '
        Me.LblSocio.AutoSize = True
        Me.LblSocio.Location = New System.Drawing.Point(325, 200)
        Me.LblSocio.Name = "LblSocio"
        Me.LblSocio.Size = New System.Drawing.Size(40, 13)
        Me.LblSocio.TabIndex = 17
        Me.LblSocio.Text = "SOCIO"
        '
        'TxtSocio
        '
        Me.TxtSocio.BackColor = System.Drawing.Color.Gainsboro
        Me.TxtSocio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtSocio.Enabled = False
        Me.TxtSocio.Location = New System.Drawing.Point(328, 216)
        Me.TxtSocio.Name = "TxtSocio"
        Me.TxtSocio.Size = New System.Drawing.Size(222, 20)
        Me.TxtSocio.TabIndex = 9
        '
        'LblObs
        '
        Me.LblObs.AutoSize = True
        Me.LblObs.Location = New System.Drawing.Point(55, 246)
        Me.LblObs.Name = "LblObs"
        Me.LblObs.Size = New System.Drawing.Size(29, 13)
        Me.LblObs.TabIndex = 27
        Me.LblObs.Text = "OBS"
        '
        'TxtObs
        '
        Me.TxtObs.BackColor = System.Drawing.Color.Gainsboro
        Me.TxtObs.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtObs.Enabled = False
        Me.TxtObs.Location = New System.Drawing.Point(56, 262)
        Me.TxtObs.Name = "TxtObs"
        Me.TxtObs.Size = New System.Drawing.Size(263, 20)
        Me.TxtObs.TabIndex = 10
        '
        'LblObs2
        '
        Me.LblObs2.AutoSize = True
        Me.LblObs2.Location = New System.Drawing.Point(325, 246)
        Me.LblObs2.Name = "LblObs2"
        Me.LblObs2.Size = New System.Drawing.Size(35, 13)
        Me.LblObs2.TabIndex = 29
        Me.LblObs2.Text = "OBS2"
        '
        'TxtObs2
        '
        Me.TxtObs2.BackColor = System.Drawing.Color.Gainsboro
        Me.TxtObs2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtObs2.Enabled = False
        Me.TxtObs2.Location = New System.Drawing.Point(328, 262)
        Me.TxtObs2.Name = "TxtObs2"
        Me.TxtObs2.Size = New System.Drawing.Size(222, 20)
        Me.TxtObs2.TabIndex = 11
        '
        'LblObs3
        '
        Me.LblObs3.AutoSize = True
        Me.LblObs3.Location = New System.Drawing.Point(55, 285)
        Me.LblObs3.Name = "LblObs3"
        Me.LblObs3.Size = New System.Drawing.Size(35, 13)
        Me.LblObs3.TabIndex = 31
        Me.LblObs3.Text = "OBS3"
        '
        'TxtObs3
        '
        Me.TxtObs3.BackColor = System.Drawing.Color.Gainsboro
        Me.TxtObs3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtObs3.Enabled = False
        Me.TxtObs3.Location = New System.Drawing.Point(56, 301)
        Me.TxtObs3.Name = "TxtObs3"
        Me.TxtObs3.Size = New System.Drawing.Size(263, 20)
        Me.TxtObs3.TabIndex = 12
        '
        'LblObs4
        '
        Me.LblObs4.AutoSize = True
        Me.LblObs4.Location = New System.Drawing.Point(327, 285)
        Me.LblObs4.Name = "LblObs4"
        Me.LblObs4.Size = New System.Drawing.Size(35, 13)
        Me.LblObs4.TabIndex = 33
        Me.LblObs4.Text = "OBS4"
        '
        'TxtObs4
        '
        Me.TxtObs4.BackColor = System.Drawing.Color.Gainsboro
        Me.TxtObs4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtObs4.Enabled = False
        Me.TxtObs4.Location = New System.Drawing.Point(330, 301)
        Me.TxtObs4.Name = "TxtObs4"
        Me.TxtObs4.Size = New System.Drawing.Size(221, 20)
        Me.TxtObs4.TabIndex = 13
        '
        'TxtNro_Carta
        '
        Me.TxtNro_Carta.BackColor = System.Drawing.Color.Silver
        Me.TxtNro_Carta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNro_Carta.Enabled = False
        Me.TxtNro_Carta.Location = New System.Drawing.Point(439, 39)
        Me.TxtNro_Carta.Name = "TxtNro_Carta"
        Me.TxtNro_Carta.Size = New System.Drawing.Size(102, 20)
        Me.TxtNro_Carta.TabIndex = 21
        '
        'LblNro_Carta
        '
        Me.LblNro_Carta.AutoSize = True
        Me.LblNro_Carta.Location = New System.Drawing.Point(436, 23)
        Me.LblNro_Carta.Name = "LblNro_Carta"
        Me.LblNro_Carta.Size = New System.Drawing.Size(73, 13)
        Me.LblNro_Carta.TabIndex = 35
        Me.LblNro_Carta.Text = "NRO_CARTA"
        '
        'BtnSalir
        '
        Me.BtnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnSalir.Image = Global.Correo.My.Resources.Resources.door_out
        Me.BtnSalir.Location = New System.Drawing.Point(483, 357)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(41, 45)
        Me.BtnSalir.TabIndex = 19
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'BtnIngresar
        '
        Me.BtnIngresar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnIngresar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnIngresar.Enabled = False
        Me.BtnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnIngresar.Image = Global.Correo.My.Resources.Resources.agt_action_success1
        Me.BtnIngresar.Location = New System.Drawing.Point(276, 357)
        Me.BtnIngresar.Name = "BtnIngresar"
        Me.BtnIngresar.Size = New System.Drawing.Size(41, 45)
        Me.BtnIngresar.TabIndex = 14
        Me.BtnIngresar.UseVisualStyleBackColor = True
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnNuevo.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnNuevo.Image = Global.Correo.My.Resources.Resources.edit
        Me.BtnNuevo.Location = New System.Drawing.Point(43, 357)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(41, 45)
        Me.BtnNuevo.TabIndex = 20
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'CmbRemitente
        '
        Me.CmbRemitente.BackColor = System.Drawing.Color.White
        Me.CmbRemitente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbRemitente.Enabled = False
        Me.CmbRemitente.FormattingEnabled = True
        Me.CmbRemitente.Location = New System.Drawing.Point(55, 38)
        Me.CmbRemitente.Name = "CmbRemitente"
        Me.CmbRemitente.Size = New System.Drawing.Size(89, 21)
        Me.CmbRemitente.TabIndex = 0
        '
        'LblServicio
        '
        Me.LblServicio.AutoSize = True
        Me.LblServicio.Location = New System.Drawing.Point(54, 22)
        Me.LblServicio.Name = "LblServicio"
        Me.LblServicio.Size = New System.Drawing.Size(70, 13)
        Me.LblServicio.TabIndex = 40
        Me.LblServicio.Text = "REMITENTE"
        '
        'LblNroTrabajo
        '
        Me.LblNroTrabajo.AutoSize = True
        Me.LblNroTrabajo.Location = New System.Drawing.Point(162, 22)
        Me.LblNroTrabajo.Name = "LblNroTrabajo"
        Me.LblNroTrabajo.Size = New System.Drawing.Size(86, 13)
        Me.LblNroTrabajo.TabIndex = 42
        Me.LblNroTrabajo.Text = "NRO_TRABAJO"
        '
        'CmbNroTrab
        '
        Me.CmbNroTrab.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbNroTrab.Enabled = False
        Me.CmbNroTrab.FormattingEnabled = True
        Me.CmbNroTrab.Location = New System.Drawing.Point(166, 38)
        Me.CmbNroTrab.Name = "CmbNroTrab"
        Me.CmbNroTrab.Size = New System.Drawing.Size(85, 21)
        Me.CmbNroTrab.TabIndex = 43
        '
        'BtnSeleccionar
        '
        Me.BtnSeleccionar.Enabled = False
        Me.BtnSeleccionar.Location = New System.Drawing.Point(253, 37)
        Me.BtnSeleccionar.Name = "BtnSeleccionar"
        Me.BtnSeleccionar.Size = New System.Drawing.Size(20, 23)
        Me.BtnSeleccionar.TabIndex = 44
        Me.BtnSeleccionar.Text = ">"
        Me.BtnSeleccionar.UseVisualStyleBackColor = True
        '
        'DtFechTrab
        '
        Me.DtFechTrab.Enabled = False
        Me.DtFechTrab.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtFechTrab.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtFechTrab.Location = New System.Drawing.Point(305, 37)
        Me.DtFechTrab.Name = "DtFechTrab"
        Me.DtFechTrab.Size = New System.Drawing.Size(96, 21)
        Me.DtFechTrab.TabIndex = 45
        '
        'LblFecha_Trab
        '
        Me.LblFecha_Trab.AutoSize = True
        Me.LblFecha_Trab.Location = New System.Drawing.Point(302, 22)
        Me.LblFecha_Trab.Name = "LblFecha_Trab"
        Me.LblFecha_Trab.Size = New System.Drawing.Size(70, 13)
        Me.LblFecha_Trab.TabIndex = 46
        Me.LblFecha_Trab.Text = "FECH_TRAB"
        Me.LblFecha_Trab.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'LvlPisoDepto
        '
        Me.LvlPisoDepto.AutoSize = True
        Me.LvlPisoDepto.Location = New System.Drawing.Point(182, 107)
        Me.LvlPisoDepto.Name = "LvlPisoDepto"
        Me.LvlPisoDepto.Size = New System.Drawing.Size(72, 13)
        Me.LvlPisoDepto.TabIndex = 19
        Me.LvlPisoDepto.Text = "PISO DEPTO"
        '
        'TxtPisoDepto
        '
        Me.TxtPisoDepto.BackColor = System.Drawing.Color.Gainsboro
        Me.TxtPisoDepto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtPisoDepto.Enabled = False
        Me.TxtPisoDepto.Location = New System.Drawing.Point(185, 123)
        Me.TxtPisoDepto.Name = "TxtPisoDepto"
        Me.TxtPisoDepto.Size = New System.Drawing.Size(132, 20)
        Me.TxtPisoDepto.TabIndex = 4
        '
        'FrmCargaManual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(619, 414)
        Me.Controls.Add(Me.LblFecha_Trab)
        Me.Controls.Add(Me.DtFechTrab)
        Me.Controls.Add(Me.BtnSeleccionar)
        Me.Controls.Add(Me.CmbNroTrab)
        Me.Controls.Add(Me.LblNroTrabajo)
        Me.Controls.Add(Me.LblServicio)
        Me.Controls.Add(Me.CmbRemitente)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.BtnIngresar)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.LblNro_Carta)
        Me.Controls.Add(Me.TxtNro_Carta)
        Me.Controls.Add(Me.LblObs4)
        Me.Controls.Add(Me.TxtObs4)
        Me.Controls.Add(Me.LblObs3)
        Me.Controls.Add(Me.TxtObs3)
        Me.Controls.Add(Me.LblObs2)
        Me.Controls.Add(Me.TxtObs2)
        Me.Controls.Add(Me.LblObs)
        Me.Controls.Add(Me.TxtObs)
        Me.Controls.Add(Me.LvlPisoDepto)
        Me.Controls.Add(Me.TxtPisoDepto)
        Me.Controls.Add(Me.LblSocio)
        Me.Controls.Add(Me.TxtSocio)
        Me.Controls.Add(Me.LblNro_Carta2)
        Me.Controls.Add(Me.LblEmpresa)
        Me.Controls.Add(Me.LblProvincia)
        Me.Controls.Add(Me.LblLocalidad)
        Me.Controls.Add(Me.LblCP)
        Me.Controls.Add(Me.LblCalle)
        Me.Controls.Add(Me.LblNombre)
        Me.Controls.Add(Me.TxtEmpresa)
        Me.Controls.Add(Me.TxtLocalidad)
        Me.Controls.Add(Me.TxtCalle)
        Me.Controls.Add(Me.TxtNro_Carta2)
        Me.Controls.Add(Me.TxtProvincia)
        Me.Controls.Add(Me.TxtCp)
        Me.Controls.Add(Me.TxtNombre_Apellido)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmCargaManual"
        Me.Text = "Carga Manual"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtNombre_Apellido As System.Windows.Forms.TextBox
    Friend WithEvents TxtCp As System.Windows.Forms.TextBox
    Friend WithEvents TxtProvincia As System.Windows.Forms.TextBox
    Friend WithEvents TxtNro_Carta2 As System.Windows.Forms.TextBox
    Friend WithEvents TxtCalle As System.Windows.Forms.TextBox
    Friend WithEvents TxtLocalidad As System.Windows.Forms.TextBox
    Friend WithEvents TxtEmpresa As System.Windows.Forms.TextBox
    Friend WithEvents LblNombre As System.Windows.Forms.Label
    Friend WithEvents LblCalle As System.Windows.Forms.Label
    Friend WithEvents LblCP As System.Windows.Forms.Label
    Friend WithEvents LblLocalidad As System.Windows.Forms.Label
    Friend WithEvents LblProvincia As System.Windows.Forms.Label
    Friend WithEvents LblEmpresa As System.Windows.Forms.Label
    Friend WithEvents LblNro_Carta2 As System.Windows.Forms.Label
    Friend WithEvents LblSocio As System.Windows.Forms.Label
    Friend WithEvents TxtSocio As System.Windows.Forms.TextBox
    Friend WithEvents LblObs As System.Windows.Forms.Label
    Friend WithEvents TxtObs As System.Windows.Forms.TextBox
    Friend WithEvents LblObs2 As System.Windows.Forms.Label
    Friend WithEvents TxtObs2 As System.Windows.Forms.TextBox
    Friend WithEvents LblObs3 As System.Windows.Forms.Label
    Friend WithEvents TxtObs3 As System.Windows.Forms.TextBox
    Friend WithEvents LblObs4 As System.Windows.Forms.Label
    Friend WithEvents TxtObs4 As System.Windows.Forms.TextBox
    Friend WithEvents TxtNro_Carta As System.Windows.Forms.TextBox
    Friend WithEvents LblNro_Carta As System.Windows.Forms.Label
    Public WithEvents BtnSalir As System.Windows.Forms.Button
    Public WithEvents BtnIngresar As System.Windows.Forms.Button
    Public WithEvents BtnNuevo As System.Windows.Forms.Button
    Friend WithEvents CmbRemitente As System.Windows.Forms.ComboBox
    Friend WithEvents LblServicio As System.Windows.Forms.Label
    Friend WithEvents LblNroTrabajo As System.Windows.Forms.Label
    Friend WithEvents CmbNroTrab As System.Windows.Forms.ComboBox
    Friend WithEvents BtnSeleccionar As System.Windows.Forms.Button
    Friend WithEvents DtFechTrab As System.Windows.Forms.DateTimePicker
    Friend WithEvents LblFecha_Trab As System.Windows.Forms.Label
    Friend WithEvents LvlPisoDepto As Label
    Friend WithEvents TxtPisoDepto As TextBox
End Class
