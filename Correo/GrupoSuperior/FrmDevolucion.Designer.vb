<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDevolucion
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
        Me.TxtPlanillaDevo = New System.Windows.Forms.TextBox()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.CmbMotivos = New System.Windows.Forms.ComboBox()
        Me.Cantidad = New System.Windows.Forms.Label()
        Me.TxtCartas = New System.Windows.Forms.TextBox()
        Me.TxtCantidad = New System.Windows.Forms.TextBox()
        Me.LblCartas = New System.Windows.Forms.Label()
        Me.DgvCartaDev = New System.Windows.Forms.DataGridView()
        Me.Asociado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Lote = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Integrante = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fech_trab = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tema1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tema2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Motivo_devo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fech_devo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Devo_plani = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Calle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Localidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nro_carta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnFinalizar = New System.Windows.Forms.Button()
        Me.BtnOkNoentregada = New System.Windows.Forms.Button()
        Me.DtpFechaDevo = New System.Windows.Forms.DateTimePicker()
        Me.TxtBarraCliente = New System.Windows.Forms.TextBox()
        Me.LblNroCarta2 = New System.Windows.Forms.Label()
        Me.LblFecha = New System.Windows.Forms.Label()
        Me.LblNroPLani = New System.Windows.Forms.Label()
        Me.LblMotivo = New System.Windows.Forms.Label()
        Me.ChkFijarMotivo = New System.Windows.Forms.CheckBox()
        Me.BtnGenerar = New System.Windows.Forms.Button()
        Me.CmbHasta = New System.Windows.Forms.ComboBox()
        Me.CmbDesde = New System.Windows.Forms.ComboBox()
        Me.LblDesde = New System.Windows.Forms.Label()
        Me.Lblhasta = New System.Windows.Forms.Label()
        Me.DgvExcel = New System.Windows.Forms.DataGridView()
        Me.LblVerPLanillaAnerior = New System.Windows.Forms.Label()
        Me.CmbVolverAVerPlanilla = New System.Windows.Forms.ComboBox()
        Me.LblCantidad = New System.Windows.Forms.Label()
        Me.BtnDevolucionSeprit = New System.Windows.Forms.Button()
        Me.ChkFijarBarraCliente = New System.Windows.Forms.CheckBox()
        Me.ChkFijarcarta = New System.Windows.Forms.CheckBox()
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Gb.SuspendLayout()
        CType(Me.DgvCartaDev, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvExcel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PBLogo
        '
        Me.PBLogo.Location = New System.Drawing.Point(5, 550)
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(852, 550)
        '
        'Gb
        '
        Me.Gb.Controls.Add(Me.ChkFijarcarta)
        Me.Gb.Controls.Add(Me.ChkFijarBarraCliente)
        Me.Gb.Controls.Add(Me.BtnDevolucionSeprit)
        Me.Gb.Controls.Add(Me.LblCantidad)
        Me.Gb.Controls.Add(Me.LblVerPLanillaAnerior)
        Me.Gb.Controls.Add(Me.CmbVolverAVerPlanilla)
        Me.Gb.Controls.Add(Me.DgvExcel)
        Me.Gb.Controls.Add(Me.Lblhasta)
        Me.Gb.Controls.Add(Me.LblDesde)
        Me.Gb.Controls.Add(Me.CmbDesde)
        Me.Gb.Controls.Add(Me.CmbHasta)
        Me.Gb.Controls.Add(Me.BtnGenerar)
        Me.Gb.Controls.Add(Me.ChkFijarMotivo)
        Me.Gb.Controls.Add(Me.LblMotivo)
        Me.Gb.Controls.Add(Me.LblNroPLani)
        Me.Gb.Controls.Add(Me.LblFecha)
        Me.Gb.Controls.Add(Me.LblNroCarta2)
        Me.Gb.Controls.Add(Me.TxtBarraCliente)
        Me.Gb.Controls.Add(Me.DtpFechaDevo)
        Me.Gb.Controls.Add(Me.BtnOkNoentregada)
        Me.Gb.Controls.Add(Me.BtnFinalizar)
        Me.Gb.Controls.Add(Me.BtnNuevo)
        Me.Gb.Controls.Add(Me.TxtPlanillaDevo)
        Me.Gb.Controls.Add(Me.CmbMotivos)
        Me.Gb.Controls.Add(Me.DgvCartaDev)
        Me.Gb.Controls.Add(Me.Cantidad)
        Me.Gb.Controls.Add(Me.TxtCartas)
        Me.Gb.Controls.Add(Me.LblCartas)
        Me.Gb.Controls.Add(Me.TxtCantidad)
        Me.Gb.Location = New System.Drawing.Point(1, 1)
        Me.Gb.Size = New System.Drawing.Size(999, 601)
        Me.Gb.Controls.SetChildIndex(Me.TxtCantidad, 0)
        Me.Gb.Controls.SetChildIndex(Me.LblCartas, 0)
        Me.Gb.Controls.SetChildIndex(Me.TxtCartas, 0)
        Me.Gb.Controls.SetChildIndex(Me.Cantidad, 0)
        Me.Gb.Controls.SetChildIndex(Me.DgvCartaDev, 0)
        Me.Gb.Controls.SetChildIndex(Me.CmbMotivos, 0)
        Me.Gb.Controls.SetChildIndex(Me.TxtPlanillaDevo, 0)
        Me.Gb.Controls.SetChildIndex(Me.BtnNuevo, 0)
        Me.Gb.Controls.SetChildIndex(Me.BtnFinalizar, 0)
        Me.Gb.Controls.SetChildIndex(Me.BtnOkNoentregada, 0)
        Me.Gb.Controls.SetChildIndex(Me.DtpFechaDevo, 0)
        Me.Gb.Controls.SetChildIndex(Me.TxtBarraCliente, 0)
        Me.Gb.Controls.SetChildIndex(Me.LblNroCarta2, 0)
        Me.Gb.Controls.SetChildIndex(Me.LblFecha, 0)
        Me.Gb.Controls.SetChildIndex(Me.LblNroPLani, 0)
        Me.Gb.Controls.SetChildIndex(Me.LblMotivo, 0)
        Me.Gb.Controls.SetChildIndex(Me.ChkFijarMotivo, 0)
        Me.Gb.Controls.SetChildIndex(Me.BtnGenerar, 0)
        Me.Gb.Controls.SetChildIndex(Me.CmbHasta, 0)
        Me.Gb.Controls.SetChildIndex(Me.CmbDesde, 0)
        Me.Gb.Controls.SetChildIndex(Me.LblDesde, 0)
        Me.Gb.Controls.SetChildIndex(Me.Lblhasta, 0)
        Me.Gb.Controls.SetChildIndex(Me.DgvExcel, 0)
        Me.Gb.Controls.SetChildIndex(Me.CmbVolverAVerPlanilla, 0)
        Me.Gb.Controls.SetChildIndex(Me.LblVerPLanillaAnerior, 0)
        Me.Gb.Controls.SetChildIndex(Me.LblCantidad, 0)
        Me.Gb.Controls.SetChildIndex(Me.BtnDevolucionSeprit, 0)
        Me.Gb.Controls.SetChildIndex(Me.ChkFijarBarraCliente, 0)
        Me.Gb.Controls.SetChildIndex(Me.ChkFijarcarta, 0)
        Me.Gb.Controls.SetChildIndex(Me.PBLogo, 0)
        Me.Gb.Controls.SetChildIndex(Me.BtnSalir, 0)
        '
        'TxtPlanillaDevo
        '
        Me.TxtPlanillaDevo.Enabled = False
        Me.TxtPlanillaDevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPlanillaDevo.Location = New System.Drawing.Point(98, 93)
        Me.TxtPlanillaDevo.Name = "TxtPlanillaDevo"
        Me.TxtPlanillaDevo.Size = New System.Drawing.Size(80, 20)
        Me.TxtPlanillaDevo.TabIndex = 51
        '
        'BtnNuevo
        '
        Me.BtnNuevo.BackColor = System.Drawing.Color.SpringGreen
        Me.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNuevo.Location = New System.Drawing.Point(11, 78)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(80, 40)
        Me.BtnNuevo.TabIndex = 60
        Me.BtnNuevo.Text = "Nuevo"
        Me.BtnNuevo.UseVisualStyleBackColor = False
        '
        'CmbMotivos
        '
        Me.CmbMotivos.Enabled = False
        Me.CmbMotivos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbMotivos.FormattingEnabled = True
        Me.CmbMotivos.Location = New System.Drawing.Point(679, 94)
        Me.CmbMotivos.Name = "CmbMotivos"
        Me.CmbMotivos.Size = New System.Drawing.Size(150, 21)
        Me.CmbMotivos.TabIndex = 53
        '
        'Cantidad
        '
        Me.Cantidad.AutoSize = True
        Me.Cantidad.Location = New System.Drawing.Point(11, 404)
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.Size = New System.Drawing.Size(49, 13)
        Me.Cantidad.TabIndex = 58
        Me.Cantidad.Text = "Cantidad"
        '
        'TxtCartas
        '
        Me.TxtCartas.Enabled = False
        Me.TxtCartas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCartas.Location = New System.Drawing.Point(300, 95)
        Me.TxtCartas.Name = "TxtCartas"
        Me.TxtCartas.Size = New System.Drawing.Size(100, 20)
        Me.TxtCartas.TabIndex = 55
        '
        'TxtCantidad
        '
        Me.TxtCantidad.Enabled = False
        Me.TxtCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCantidad.Location = New System.Drawing.Point(14, 448)
        Me.TxtCantidad.Name = "TxtCantidad"
        Me.TxtCantidad.Size = New System.Drawing.Size(50, 20)
        Me.TxtCantidad.TabIndex = 59
        Me.TxtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LblCartas
        '
        Me.LblCartas.AutoSize = True
        Me.LblCartas.Location = New System.Drawing.Point(297, 76)
        Me.LblCartas.Name = "LblCartas"
        Me.LblCartas.Size = New System.Drawing.Size(37, 13)
        Me.LblCartas.TabIndex = 54
        Me.LblCartas.Text = "Cartas"
        '
        'DgvCartaDev
        '
        Me.DgvCartaDev.AllowUserToAddRows = False
        Me.DgvCartaDev.AllowUserToDeleteRows = False
        Me.DgvCartaDev.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvCartaDev.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvCartaDev.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvCartaDev.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Asociado, Me.Lote, Me.Integrante, Me.Fech_trab, Me.Tema1, Me.Fecha1, Me.Tema2, Me.Fecha2, Me.Motivo_devo, Me.Fech_devo, Me.Devo_plani, Me.Apellido, Me.Calle, Me.Cp, Me.Localidad, Me.Nro_carta})
        Me.DgvCartaDev.EnableHeadersVisualStyles = False
        Me.DgvCartaDev.Location = New System.Drawing.Point(11, 123)
        Me.DgvCartaDev.MultiSelect = False
        Me.DgvCartaDev.Name = "DgvCartaDev"
        Me.DgvCartaDev.ReadOnly = True
        Me.DgvCartaDev.RowHeadersVisible = False
        Me.DgvCartaDev.Size = New System.Drawing.Size(979, 300)
        Me.DgvCartaDev.TabIndex = 57
        '
        'Asociado
        '
        Me.Asociado.FillWeight = 150.0!
        Me.Asociado.HeaderText = "Asociado"
        Me.Asociado.Name = "Asociado"
        Me.Asociado.ReadOnly = True
        '
        'Lote
        '
        Me.Lote.HeaderText = "Lote"
        Me.Lote.Name = "Lote"
        Me.Lote.ReadOnly = True
        '
        'Integrante
        '
        Me.Integrante.FillWeight = 150.0!
        Me.Integrante.HeaderText = "Integrante"
        Me.Integrante.Name = "Integrante"
        Me.Integrante.ReadOnly = True
        '
        'Fech_trab
        '
        Me.Fech_trab.FillWeight = 150.0!
        Me.Fech_trab.HeaderText = "Fech_trab"
        Me.Fech_trab.Name = "Fech_trab"
        Me.Fech_trab.ReadOnly = True
        '
        'Tema1
        '
        Me.Tema1.HeaderText = "Tema1"
        Me.Tema1.Name = "Tema1"
        Me.Tema1.ReadOnly = True
        '
        'Fecha1
        '
        Me.Fecha1.HeaderText = "Fecha1"
        Me.Fecha1.Name = "Fecha1"
        Me.Fecha1.ReadOnly = True
        '
        'Tema2
        '
        Me.Tema2.HeaderText = "Tema2"
        Me.Tema2.Name = "Tema2"
        Me.Tema2.ReadOnly = True
        '
        'Fecha2
        '
        Me.Fecha2.HeaderText = "Fecha2"
        Me.Fecha2.Name = "Fecha2"
        Me.Fecha2.ReadOnly = True
        '
        'Motivo_devo
        '
        Me.Motivo_devo.FillWeight = 150.0!
        Me.Motivo_devo.HeaderText = "Motivo_devo"
        Me.Motivo_devo.Name = "Motivo_devo"
        Me.Motivo_devo.ReadOnly = True
        '
        'Fech_devo
        '
        Me.Fech_devo.FillWeight = 150.0!
        Me.Fech_devo.HeaderText = "Fech_devo"
        Me.Fech_devo.Name = "Fech_devo"
        Me.Fech_devo.ReadOnly = True
        '
        'Devo_plani
        '
        Me.Devo_plani.FillWeight = 150.0!
        Me.Devo_plani.HeaderText = "Devo_plani"
        Me.Devo_plani.Name = "Devo_plani"
        Me.Devo_plani.ReadOnly = True
        '
        'Apellido
        '
        Me.Apellido.FillWeight = 150.0!
        Me.Apellido.HeaderText = "Apellido"
        Me.Apellido.Name = "Apellido"
        Me.Apellido.ReadOnly = True
        '
        'Calle
        '
        Me.Calle.FillWeight = 150.0!
        Me.Calle.HeaderText = "Calle"
        Me.Calle.Name = "Calle"
        Me.Calle.ReadOnly = True
        '
        'Cp
        '
        Me.Cp.HeaderText = "Cp"
        Me.Cp.Name = "Cp"
        Me.Cp.ReadOnly = True
        '
        'Localidad
        '
        Me.Localidad.FillWeight = 150.0!
        Me.Localidad.HeaderText = "Localidad"
        Me.Localidad.Name = "Localidad"
        Me.Localidad.ReadOnly = True
        '
        'Nro_carta
        '
        Me.Nro_carta.HeaderText = "Nro_carta"
        Me.Nro_carta.Name = "Nro_carta"
        Me.Nro_carta.ReadOnly = True
        '
        'BtnFinalizar
        '
        Me.BtnFinalizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnFinalizar.BackColor = System.Drawing.Color.LightGreen
        Me.BtnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFinalizar.Location = New System.Drawing.Point(899, 437)
        Me.BtnFinalizar.Name = "BtnFinalizar"
        Me.BtnFinalizar.Size = New System.Drawing.Size(90, 40)
        Me.BtnFinalizar.TabIndex = 62
        Me.BtnFinalizar.Text = "Finalizar"
        Me.BtnFinalizar.UseVisualStyleBackColor = False
        '
        'BtnOkNoentregada
        '
        Me.BtnOkNoentregada.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnOkNoentregada.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnOkNoentregada.Image = Global.Correo.My.Resources.Resources.apply
        Me.BtnOkNoentregada.Location = New System.Drawing.Point(861, 88)
        Me.BtnOkNoentregada.Name = "BtnOkNoentregada"
        Me.BtnOkNoentregada.Size = New System.Drawing.Size(30, 30)
        Me.BtnOkNoentregada.TabIndex = 95
        Me.BtnOkNoentregada.UseVisualStyleBackColor = True
        '
        'DtpFechaDevo
        '
        Me.DtpFechaDevo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaDevo.Location = New System.Drawing.Point(184, 94)
        Me.DtpFechaDevo.Name = "DtpFechaDevo"
        Me.DtpFechaDevo.Size = New System.Drawing.Size(100, 20)
        Me.DtpFechaDevo.TabIndex = 96
        '
        'TxtBarraCliente
        '
        Me.TxtBarraCliente.Enabled = False
        Me.TxtBarraCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBarraCliente.Location = New System.Drawing.Point(431, 95)
        Me.TxtBarraCliente.Name = "TxtBarraCliente"
        Me.TxtBarraCliente.Size = New System.Drawing.Size(220, 20)
        Me.TxtBarraCliente.TabIndex = 97
        '
        'LblNroCarta2
        '
        Me.LblNroCarta2.AutoSize = True
        Me.LblNroCarta2.Location = New System.Drawing.Point(428, 79)
        Me.LblNroCarta2.Name = "LblNroCarta2"
        Me.LblNroCarta2.Size = New System.Drawing.Size(81, 13)
        Me.LblNroCarta2.TabIndex = 98
        Me.LblNroCarta2.Text = "Barra de cliente"
        '
        'LblFecha
        '
        Me.LblFecha.AutoSize = True
        Me.LblFecha.Location = New System.Drawing.Point(181, 77)
        Me.LblFecha.Name = "LblFecha"
        Me.LblFecha.Size = New System.Drawing.Size(37, 13)
        Me.LblFecha.TabIndex = 99
        Me.LblFecha.Text = "Fecha"
        '
        'LblNroPLani
        '
        Me.LblNroPLani.AutoSize = True
        Me.LblNroPLani.Location = New System.Drawing.Point(98, 77)
        Me.LblNroPLani.Name = "LblNroPLani"
        Me.LblNroPLani.Size = New System.Drawing.Size(40, 13)
        Me.LblNroPLani.TabIndex = 100
        Me.LblNroPLani.Text = "Planilla"
        '
        'LblMotivo
        '
        Me.LblMotivo.AutoSize = True
        Me.LblMotivo.Location = New System.Drawing.Point(676, 78)
        Me.LblMotivo.Name = "LblMotivo"
        Me.LblMotivo.Size = New System.Drawing.Size(39, 13)
        Me.LblMotivo.TabIndex = 101
        Me.LblMotivo.Text = "Motivo"
        '
        'ChkFijarMotivo
        '
        Me.ChkFijarMotivo.AutoSize = True
        Me.ChkFijarMotivo.Location = New System.Drawing.Point(761, 74)
        Me.ChkFijarMotivo.Name = "ChkFijarMotivo"
        Me.ChkFijarMotivo.Size = New System.Drawing.Size(68, 17)
        Me.ChkFijarMotivo.TabIndex = 102
        Me.ChkFijarMotivo.Text = "Bloquear"
        Me.ChkFijarMotivo.UseVisualStyleBackColor = True
        '
        'BtnGenerar
        '
        Me.BtnGenerar.BackColor = System.Drawing.Color.LightGreen
        Me.BtnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGenerar.Location = New System.Drawing.Point(544, 439)
        Me.BtnGenerar.Name = "BtnGenerar"
        Me.BtnGenerar.Size = New System.Drawing.Size(120, 40)
        Me.BtnGenerar.TabIndex = 103
        Me.BtnGenerar.Text = "GenerarArchivos"
        Me.BtnGenerar.UseVisualStyleBackColor = False
        '
        'CmbHasta
        '
        Me.CmbHasta.FormattingEnabled = True
        Me.CmbHasta.Location = New System.Drawing.Point(417, 439)
        Me.CmbHasta.Name = "CmbHasta"
        Me.CmbHasta.Size = New System.Drawing.Size(121, 21)
        Me.CmbHasta.TabIndex = 104
        '
        'CmbDesde
        '
        Me.CmbDesde.FormattingEnabled = True
        Me.CmbDesde.Location = New System.Drawing.Point(290, 439)
        Me.CmbDesde.Name = "CmbDesde"
        Me.CmbDesde.Size = New System.Drawing.Size(121, 21)
        Me.CmbDesde.TabIndex = 105
        '
        'LblDesde
        '
        Me.LblDesde.AutoSize = True
        Me.LblDesde.Location = New System.Drawing.Point(287, 423)
        Me.LblDesde.Name = "LblDesde"
        Me.LblDesde.Size = New System.Drawing.Size(38, 13)
        Me.LblDesde.TabIndex = 106
        Me.LblDesde.Text = "Desde"
        '
        'Lblhasta
        '
        Me.Lblhasta.AutoSize = True
        Me.Lblhasta.Location = New System.Drawing.Point(414, 423)
        Me.Lblhasta.Name = "Lblhasta"
        Me.Lblhasta.Size = New System.Drawing.Size(35, 13)
        Me.Lblhasta.TabIndex = 107
        Me.Lblhasta.Text = "Hasta"
        '
        'DgvExcel
        '
        Me.DgvExcel.AllowUserToAddRows = False
        Me.DgvExcel.AllowUserToDeleteRows = False
        Me.DgvExcel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvExcel.Location = New System.Drawing.Point(290, 466)
        Me.DgvExcel.Name = "DgvExcel"
        Me.DgvExcel.ReadOnly = True
        Me.DgvExcel.Size = New System.Drawing.Size(150, 50)
        Me.DgvExcel.TabIndex = 108
        Me.DgvExcel.Visible = False
        '
        'LblVerPLanillaAnerior
        '
        Me.LblVerPLanillaAnerior.AutoSize = True
        Me.LblVerPLanillaAnerior.Location = New System.Drawing.Point(119, 432)
        Me.LblVerPLanillaAnerior.Name = "LblVerPLanillaAnerior"
        Me.LblVerPLanillaAnerior.Size = New System.Drawing.Size(59, 13)
        Me.LblVerPLanillaAnerior.TabIndex = 110
        Me.LblVerPLanillaAnerior.Text = "Ver Planilla"
        '
        'CmbVolverAVerPlanilla
        '
        Me.CmbVolverAVerPlanilla.FormattingEnabled = True
        Me.CmbVolverAVerPlanilla.Location = New System.Drawing.Point(115, 448)
        Me.CmbVolverAVerPlanilla.Name = "CmbVolverAVerPlanilla"
        Me.CmbVolverAVerPlanilla.Size = New System.Drawing.Size(121, 21)
        Me.CmbVolverAVerPlanilla.TabIndex = 109
        '
        'LblCantidad
        '
        Me.LblCantidad.AutoSize = True
        Me.LblCantidad.Location = New System.Drawing.Point(11, 432)
        Me.LblCantidad.Name = "LblCantidad"
        Me.LblCantidad.Size = New System.Drawing.Size(49, 13)
        Me.LblCantidad.TabIndex = 111
        Me.LblCantidad.Text = "Cantidad"
        '
        'BtnDevolucionSeprit
        '
        Me.BtnDevolucionSeprit.BackColor = System.Drawing.Color.LightGreen
        Me.BtnDevolucionSeprit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDevolucionSeprit.Location = New System.Drawing.Point(544, 485)
        Me.BtnDevolucionSeprit.Name = "BtnDevolucionSeprit"
        Me.BtnDevolucionSeprit.Size = New System.Drawing.Size(120, 40)
        Me.BtnDevolucionSeprit.TabIndex = 112
        Me.BtnDevolucionSeprit.Text = "Devolucion Seprit"
        Me.BtnDevolucionSeprit.UseVisualStyleBackColor = False
        '
        'ChkFijarBarraCliente
        '
        Me.ChkFijarBarraCliente.AutoSize = True
        Me.ChkFijarBarraCliente.Location = New System.Drawing.Point(583, 76)
        Me.ChkFijarBarraCliente.Name = "ChkFijarBarraCliente"
        Me.ChkFijarBarraCliente.Size = New System.Drawing.Size(68, 17)
        Me.ChkFijarBarraCliente.TabIndex = 113
        Me.ChkFijarBarraCliente.Text = "Bloquear"
        Me.ChkFijarBarraCliente.UseVisualStyleBackColor = True
        '
        'ChkFijarcarta
        '
        Me.ChkFijarcarta.AutoSize = True
        Me.ChkFijarcarta.Location = New System.Drawing.Point(340, 75)
        Me.ChkFijarcarta.Name = "ChkFijarcarta"
        Me.ChkFijarcarta.Size = New System.Drawing.Size(68, 17)
        Me.ChkFijarcarta.TabIndex = 114
        Me.ChkFijarcarta.Text = "Bloquear"
        Me.ChkFijarcarta.UseVisualStyleBackColor = True
        '
        'FrmDevolucion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1000, 603)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmDevolucion"
        Me.Text = "Devolucion"
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Gb.ResumeLayout(False)
        Me.Gb.PerformLayout()
        CType(Me.DgvCartaDev, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvExcel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnNuevo As System.Windows.Forms.Button
    Friend WithEvents TxtPlanillaDevo As System.Windows.Forms.TextBox
    Friend WithEvents CmbMotivos As System.Windows.Forms.ComboBox
    Friend WithEvents DgvCartaDev As System.Windows.Forms.DataGridView
    Friend WithEvents Cantidad As System.Windows.Forms.Label
    Friend WithEvents TxtCartas As System.Windows.Forms.TextBox
    Friend WithEvents LblCartas As System.Windows.Forms.Label
    Friend WithEvents TxtCantidad As System.Windows.Forms.TextBox
    Friend WithEvents BtnFinalizar As System.Windows.Forms.Button
    Public WithEvents BtnOkNoentregada As System.Windows.Forms.Button
    Friend WithEvents DtpFechaDevo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Asociado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Lote As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Integrante As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fech_trab As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tema1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fecha1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tema2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fecha2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Motivo_devo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fech_devo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Devo_plani As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Apellido As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Calle As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Localidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nro_carta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LblMotivo As System.Windows.Forms.Label
    Friend WithEvents LblNroPLani As System.Windows.Forms.Label
    Friend WithEvents LblFecha As System.Windows.Forms.Label
    Friend WithEvents LblNroCarta2 As System.Windows.Forms.Label
    Friend WithEvents TxtBarraCliente As System.Windows.Forms.TextBox
    Friend WithEvents ChkFijarMotivo As System.Windows.Forms.CheckBox
    Friend WithEvents BtnGenerar As System.Windows.Forms.Button
    Friend WithEvents Lblhasta As System.Windows.Forms.Label
    Friend WithEvents LblDesde As System.Windows.Forms.Label
    Friend WithEvents CmbDesde As System.Windows.Forms.ComboBox
    Friend WithEvents CmbHasta As System.Windows.Forms.ComboBox
    Friend WithEvents DgvExcel As System.Windows.Forms.DataGridView
    Friend WithEvents LblCantidad As System.Windows.Forms.Label
    Friend WithEvents LblVerPLanillaAnerior As System.Windows.Forms.Label
    Friend WithEvents CmbVolverAVerPlanilla As System.Windows.Forms.ComboBox
    Friend WithEvents BtnDevolucionSeprit As System.Windows.Forms.Button
    Friend WithEvents ChkFijarcarta As System.Windows.Forms.CheckBox
    Friend WithEvents ChkFijarBarraCliente As System.Windows.Forms.CheckBox

End Class
