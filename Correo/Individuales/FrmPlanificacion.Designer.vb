<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPlanificacion
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
        Me.LblPlanillaRecorrido = New System.Windows.Forms.Label()
        Me.TxtPlanillaRecorrido = New System.Windows.Forms.TextBox()
        Me.LblFecha = New System.Windows.Forms.Label()
        Me.TxtProgramador = New System.Windows.Forms.TextBox()
        Me.Lblcartero = New System.Windows.Forms.Label()
        Me.CmbCarteroEmpresa = New System.Windows.Forms.ComboBox()
        Me.LblCartas = New System.Windows.Forms.Label()
        Me.TxtCartas = New System.Windows.Forms.TextBox()
        Me.LblZona = New System.Windows.Forms.Label()
        Me.TxtZona = New System.Windows.Forms.TextBox()
        Me.DgvCartaPlanif = New System.Windows.Forms.DataGridView()
        Me.NRO_CARTA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REMITENTE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TRABAJO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECH_TRAB = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBRE_APELLIDO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CALLE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LOCALIDAD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PROVINCIA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMPRESA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NRO_CARTA2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrdenLectura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.Label()
        Me.TxtCantidad = New System.Windows.Forms.TextBox()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.LblUsuario = New System.Windows.Forms.Label()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.h = New System.Windows.Forms.GroupBox()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.LblServico = New System.Windows.Forms.Label()
        Me.CmbServicio = New System.Windows.Forms.ComboBox()
        Me.Btneliminar = New System.Windows.Forms.Button()
        Me.DtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.BtnImpimirPlanificaion = New System.Windows.Forms.Button()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.dgv11 = New System.Windows.Forms.DataGridView()
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Gb.SuspendLayout()
        CType(Me.DgvCartaPlanif, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.h.SuspendLayout()
        CType(Me.dgv11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PBLogo
        '
        Me.PBLogo.Location = New System.Drawing.Point(5, 524)
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(1119, 525)
        '
        'Gb
        '
        Me.Gb.Controls.Add(Me.dgv11)
        Me.Gb.Controls.Add(Me.BtnActualizar)
        Me.Gb.Controls.Add(Me.BtnImpimirPlanificaion)
        Me.Gb.Controls.Add(Me.h)
        Me.Gb.Controls.Add(Me.LblUsuario)
        Me.Gb.Controls.Add(Me.TxtProgramador)
        Me.Gb.Location = New System.Drawing.Point(0, 0)
        Me.Gb.Size = New System.Drawing.Size(1166, 575)
        Me.Gb.Controls.SetChildIndex(Me.PBLogo, 0)
        Me.Gb.Controls.SetChildIndex(Me.BtnSalir, 0)
        Me.Gb.Controls.SetChildIndex(Me.TxtProgramador, 0)
        Me.Gb.Controls.SetChildIndex(Me.LblUsuario, 0)
        Me.Gb.Controls.SetChildIndex(Me.h, 0)
        Me.Gb.Controls.SetChildIndex(Me.BtnImpimirPlanificaion, 0)
        Me.Gb.Controls.SetChildIndex(Me.BtnActualizar, 0)
        Me.Gb.Controls.SetChildIndex(Me.dgv11, 0)
        '
        'LblPlanillaRecorrido
        '
        Me.LblPlanillaRecorrido.AutoSize = True
        Me.LblPlanillaRecorrido.Location = New System.Drawing.Point(227, 21)
        Me.LblPlanillaRecorrido.Name = "LblPlanillaRecorrido"
        Me.LblPlanillaRecorrido.Size = New System.Drawing.Size(118, 16)
        Me.LblPlanillaRecorrido.TabIndex = 29
        Me.LblPlanillaRecorrido.Text = "Planilla_Recorrido"
        '
        'TxtPlanillaRecorrido
        '
        Me.TxtPlanillaRecorrido.Enabled = False
        Me.TxtPlanillaRecorrido.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPlanillaRecorrido.Location = New System.Drawing.Point(231, 44)
        Me.TxtPlanillaRecorrido.Name = "TxtPlanillaRecorrido"
        Me.TxtPlanillaRecorrido.Size = New System.Drawing.Size(100, 20)
        Me.TxtPlanillaRecorrido.TabIndex = 30
        '
        'LblFecha
        '
        Me.LblFecha.AutoSize = True
        Me.LblFecha.Location = New System.Drawing.Point(687, 22)
        Me.LblFecha.Name = "LblFecha"
        Me.LblFecha.Size = New System.Drawing.Size(45, 16)
        Me.LblFecha.TabIndex = 31
        Me.LblFecha.Text = "Fecha"
        '
        'TxtProgramador
        '
        Me.TxtProgramador.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtProgramador.Enabled = False
        Me.TxtProgramador.Location = New System.Drawing.Point(1060, 12)
        Me.TxtProgramador.Name = "TxtProgramador"
        Me.TxtProgramador.Size = New System.Drawing.Size(100, 20)
        Me.TxtProgramador.TabIndex = 36
        '
        'Lblcartero
        '
        Me.Lblcartero.AutoSize = True
        Me.Lblcartero.Location = New System.Drawing.Point(354, 21)
        Me.Lblcartero.Name = "Lblcartero"
        Me.Lblcartero.Size = New System.Drawing.Size(116, 16)
        Me.Lblcartero.TabIndex = 37
        Me.Lblcartero.Text = "Cartero / Empresa"
        '
        'CmbCarteroEmpresa
        '
        Me.CmbCarteroEmpresa.Enabled = False
        Me.CmbCarteroEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbCarteroEmpresa.FormattingEnabled = True
        Me.CmbCarteroEmpresa.Location = New System.Drawing.Point(358, 43)
        Me.CmbCarteroEmpresa.Name = "CmbCarteroEmpresa"
        Me.CmbCarteroEmpresa.Size = New System.Drawing.Size(200, 21)
        Me.CmbCarteroEmpresa.TabIndex = 38
        '
        'LblCartas
        '
        Me.LblCartas.AutoSize = True
        Me.LblCartas.Location = New System.Drawing.Point(227, 87)
        Me.LblCartas.Name = "LblCartas"
        Me.LblCartas.Size = New System.Drawing.Size(46, 16)
        Me.LblCartas.TabIndex = 39
        Me.LblCartas.Text = "Cartas"
        '
        'TxtCartas
        '
        Me.TxtCartas.Enabled = False
        Me.TxtCartas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCartas.Location = New System.Drawing.Point(230, 109)
        Me.TxtCartas.Name = "TxtCartas"
        Me.TxtCartas.Size = New System.Drawing.Size(100, 20)
        Me.TxtCartas.TabIndex = 40
        '
        'LblZona
        '
        Me.LblZona.AutoSize = True
        Me.LblZona.Location = New System.Drawing.Point(7, 87)
        Me.LblZona.Name = "LblZona"
        Me.LblZona.Size = New System.Drawing.Size(38, 16)
        Me.LblZona.TabIndex = 43
        Me.LblZona.Text = "Zona"
        '
        'TxtZona
        '
        Me.TxtZona.Enabled = False
        Me.TxtZona.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtZona.Location = New System.Drawing.Point(10, 109)
        Me.TxtZona.Name = "TxtZona"
        Me.TxtZona.Size = New System.Drawing.Size(200, 20)
        Me.TxtZona.TabIndex = 44
        '
        'DgvCartaPlanif
        '
        Me.DgvCartaPlanif.AllowUserToAddRows = False
        Me.DgvCartaPlanif.AllowUserToDeleteRows = False
        Me.DgvCartaPlanif.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvCartaPlanif.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvCartaPlanif.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NRO_CARTA, Me.REMITENTE, Me.TRABAJO, Me.FECH_TRAB, Me.NOMBRE_APELLIDO, Me.CP, Me.CALLE, Me.LOCALIDAD, Me.PROVINCIA, Me.EMPRESA, Me.NRO_CARTA2, Me.OrdenLectura, Me.id})
        Me.DgvCartaPlanif.EnableHeadersVisualStyles = False
        Me.DgvCartaPlanif.Location = New System.Drawing.Point(9, 135)
        Me.DgvCartaPlanif.MultiSelect = False
        Me.DgvCartaPlanif.Name = "DgvCartaPlanif"
        Me.DgvCartaPlanif.ReadOnly = True
        Me.DgvCartaPlanif.RowHeadersVisible = False
        Me.DgvCartaPlanif.Size = New System.Drawing.Size(720, 300)
        Me.DgvCartaPlanif.TabIndex = 45
        '
        'NRO_CARTA
        '
        Me.NRO_CARTA.HeaderText = "NRO_CARTA"
        Me.NRO_CARTA.Name = "NRO_CARTA"
        Me.NRO_CARTA.ReadOnly = True
        '
        'REMITENTE
        '
        Me.REMITENTE.HeaderText = "REMITENTE"
        Me.REMITENTE.Name = "REMITENTE"
        Me.REMITENTE.ReadOnly = True
        '
        'TRABAJO
        '
        Me.TRABAJO.HeaderText = "TRABAJO"
        Me.TRABAJO.Name = "TRABAJO"
        Me.TRABAJO.ReadOnly = True
        '
        'FECH_TRAB
        '
        Me.FECH_TRAB.HeaderText = "FECH_TRAB"
        Me.FECH_TRAB.Name = "FECH_TRAB"
        Me.FECH_TRAB.ReadOnly = True
        '
        'NOMBRE_APELLIDO
        '
        Me.NOMBRE_APELLIDO.HeaderText = "NOMBRE_APELLIDO"
        Me.NOMBRE_APELLIDO.Name = "NOMBRE_APELLIDO"
        Me.NOMBRE_APELLIDO.ReadOnly = True
        '
        'CP
        '
        Me.CP.HeaderText = "CP"
        Me.CP.Name = "CP"
        Me.CP.ReadOnly = True
        '
        'CALLE
        '
        Me.CALLE.HeaderText = "CALLE"
        Me.CALLE.Name = "CALLE"
        Me.CALLE.ReadOnly = True
        '
        'LOCALIDAD
        '
        Me.LOCALIDAD.HeaderText = "LOCALIDAD"
        Me.LOCALIDAD.Name = "LOCALIDAD"
        Me.LOCALIDAD.ReadOnly = True
        '
        'PROVINCIA
        '
        Me.PROVINCIA.HeaderText = "PROVINCIA"
        Me.PROVINCIA.Name = "PROVINCIA"
        Me.PROVINCIA.ReadOnly = True
        '
        'EMPRESA
        '
        Me.EMPRESA.HeaderText = "EMPRESA"
        Me.EMPRESA.Name = "EMPRESA"
        Me.EMPRESA.ReadOnly = True
        '
        'NRO_CARTA2
        '
        Me.NRO_CARTA2.HeaderText = "NRO_CARTA2"
        Me.NRO_CARTA2.Name = "NRO_CARTA2"
        Me.NRO_CARTA2.ReadOnly = True
        '
        'OrdenLectura
        '
        Me.OrdenLectura.HeaderText = "OrdenLectura"
        Me.OrdenLectura.Name = "OrdenLectura"
        Me.OrdenLectura.ReadOnly = True
        '
        'id
        '
        Me.id.HeaderText = "id"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        '
        'Cantidad
        '
        Me.Cantidad.AutoSize = True
        Me.Cantidad.Location = New System.Drawing.Point(667, 90)
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.Size = New System.Drawing.Size(61, 16)
        Me.Cantidad.TabIndex = 46
        Me.Cantidad.Text = "Cantidad"
        '
        'TxtCantidad
        '
        Me.TxtCantidad.Enabled = False
        Me.TxtCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCantidad.Location = New System.Drawing.Point(679, 109)
        Me.TxtCantidad.Name = "TxtCantidad"
        Me.TxtCantidad.Size = New System.Drawing.Size(50, 20)
        Me.TxtCantidad.TabIndex = 47
        Me.TxtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'BtnNuevo
        '
        Me.BtnNuevo.BackColor = System.Drawing.Color.SpringGreen
        Me.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNuevo.Location = New System.Drawing.Point(10, 24)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(90, 40)
        Me.BtnNuevo.TabIndex = 50
        Me.BtnNuevo.Text = "Nuevo"
        Me.BtnNuevo.UseVisualStyleBackColor = False
        '
        'LblUsuario
        '
        Me.LblUsuario.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblUsuario.AutoSize = True
        Me.LblUsuario.Location = New System.Drawing.Point(1011, 16)
        Me.LblUsuario.Name = "LblUsuario"
        Me.LblUsuario.Size = New System.Drawing.Size(43, 13)
        Me.LblUsuario.TabIndex = 51
        Me.LblUsuario.Text = "Usuario"
        '
        'BtnAceptar
        '
        Me.BtnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAceptar.Location = New System.Drawing.Point(629, 441)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(100, 30)
        Me.BtnAceptar.TabIndex = 52
        Me.BtnAceptar.Text = "Terminar"
        Me.BtnAceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'h
        '
        Me.h.Controls.Add(Me.BtnBuscar)
        Me.h.Controls.Add(Me.LblServico)
        Me.h.Controls.Add(Me.CmbServicio)
        Me.h.Controls.Add(Me.Btneliminar)
        Me.h.Controls.Add(Me.DtpFecha)
        Me.h.Controls.Add(Me.LblPlanillaRecorrido)
        Me.h.Controls.Add(Me.BtnAceptar)
        Me.h.Controls.Add(Me.TxtPlanillaRecorrido)
        Me.h.Controls.Add(Me.BtnNuevo)
        Me.h.Controls.Add(Me.LblFecha)
        Me.h.Controls.Add(Me.Lblcartero)
        Me.h.Controls.Add(Me.CmbCarteroEmpresa)
        Me.h.Controls.Add(Me.Cantidad)
        Me.h.Controls.Add(Me.TxtCartas)
        Me.h.Controls.Add(Me.TxtCantidad)
        Me.h.Controls.Add(Me.LblCartas)
        Me.h.Controls.Add(Me.DgvCartaPlanif)
        Me.h.Controls.Add(Me.LblZona)
        Me.h.Controls.Add(Me.TxtZona)
        Me.h.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.h.ForeColor = System.Drawing.Color.Black
        Me.h.Location = New System.Drawing.Point(12, 16)
        Me.h.Name = "h"
        Me.h.Size = New System.Drawing.Size(800, 550)
        Me.h.TabIndex = 53
        Me.h.TabStop = False
        Me.h.Text = "Planificacion"
        '
        'BtnBuscar
        '
        Me.BtnBuscar.BackColor = System.Drawing.Color.SpringGreen
        Me.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBuscar.Location = New System.Drawing.Point(120, 25)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(90, 40)
        Me.BtnBuscar.TabIndex = 57
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = False
        '
        'LblServico
        '
        Me.LblServico.AutoSize = True
        Me.LblServico.Location = New System.Drawing.Point(561, 21)
        Me.LblServico.Name = "LblServico"
        Me.LblServico.Size = New System.Drawing.Size(56, 16)
        Me.LblServico.TabIndex = 55
        Me.LblServico.Text = "Servicio"
        '
        'CmbServicio
        '
        Me.CmbServicio.Enabled = False
        Me.CmbServicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbServicio.FormattingEnabled = True
        Me.CmbServicio.Items.AddRange(New Object() {"", "CON ACUSE", "SIMPLE"})
        Me.CmbServicio.Location = New System.Drawing.Point(564, 44)
        Me.CmbServicio.Name = "CmbServicio"
        Me.CmbServicio.Size = New System.Drawing.Size(120, 21)
        Me.CmbServicio.TabIndex = 56
        '
        'Btneliminar
        '
        Me.Btneliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btneliminar.Image = Global.Correo.My.Resources.Resources.agt_stop
        Me.Btneliminar.Location = New System.Drawing.Point(735, 185)
        Me.Btneliminar.Name = "Btneliminar"
        Me.Btneliminar.Size = New System.Drawing.Size(53, 38)
        Me.Btneliminar.TabIndex = 54
        Me.Btneliminar.UseVisualStyleBackColor = True
        '
        'DtpFecha
        '
        Me.DtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFecha.Location = New System.Drawing.Point(690, 42)
        Me.DtpFecha.Name = "DtpFecha"
        Me.DtpFecha.Size = New System.Drawing.Size(100, 22)
        Me.DtpFecha.TabIndex = 53
        '
        'BtnImpimirPlanificaion
        '
        Me.BtnImpimirPlanificaion.BackColor = System.Drawing.Color.SpringGreen
        Me.BtnImpimirPlanificaion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnImpimirPlanificaion.Location = New System.Drawing.Point(890, 76)
        Me.BtnImpimirPlanificaion.Name = "BtnImpimirPlanificaion"
        Me.BtnImpimirPlanificaion.Size = New System.Drawing.Size(90, 40)
        Me.BtnImpimirPlanificaion.TabIndex = 53
        Me.BtnImpimirPlanificaion.Text = "Impimir Planificaion"
        Me.BtnImpimirPlanificaion.UseVisualStyleBackColor = False
        '
        'BtnActualizar
        '
        Me.BtnActualizar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnActualizar.Image = Global.Correo.My.Resources.Resources.comment_edit
        Me.BtnActualizar.Location = New System.Drawing.Point(890, 179)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(100, 38)
        Me.BtnActualizar.TabIndex = 57
        Me.BtnActualizar.UseVisualStyleBackColor = True
        Me.BtnActualizar.Visible = False
        '
        'dgv11
        '
        Me.dgv11.AllowUserToAddRows = False
        Me.dgv11.AllowUserToDeleteRows = False
        Me.dgv11.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv11.Location = New System.Drawing.Point(818, 270)
        Me.dgv11.Name = "dgv11"
        Me.dgv11.ReadOnly = True
        Me.dgv11.Size = New System.Drawing.Size(300, 300)
        Me.dgv11.TabIndex = 58
        Me.dgv11.Visible = False
        '
        'FrmPlanificacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1166, 572)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmPlanificacion"
        Me.Text = "Planificacion"
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Gb.ResumeLayout(False)
        Me.Gb.PerformLayout()
        CType(Me.DgvCartaPlanif, System.ComponentModel.ISupportInitialize).EndInit()
        Me.h.ResumeLayout(False)
        Me.h.PerformLayout()
        CType(Me.dgv11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LblPlanillaRecorrido As System.Windows.Forms.Label
    Friend WithEvents TxtPlanillaRecorrido As System.Windows.Forms.TextBox
    Friend WithEvents LblZona As System.Windows.Forms.Label
    Friend WithEvents TxtZona As System.Windows.Forms.TextBox
    Friend WithEvents LblCartas As System.Windows.Forms.Label
    Friend WithEvents TxtCartas As System.Windows.Forms.TextBox
    Friend WithEvents CmbCarteroEmpresa As System.Windows.Forms.ComboBox
    Friend WithEvents Lblcartero As System.Windows.Forms.Label
    Friend WithEvents TxtProgramador As System.Windows.Forms.TextBox
    Friend WithEvents LblFecha As System.Windows.Forms.Label
    Friend WithEvents Cantidad As System.Windows.Forms.Label
    Friend WithEvents TxtCantidad As System.Windows.Forms.TextBox
    Friend WithEvents BtnNuevo As System.Windows.Forms.Button
    Friend WithEvents LblUsuario As System.Windows.Forms.Label
    Friend WithEvents BtnAceptar As System.Windows.Forms.Button
    Friend WithEvents h As System.Windows.Forms.GroupBox
    Friend WithEvents DgvCartaPlanif As System.Windows.Forms.DataGridView
    Friend WithEvents BtnImpimirPlanificaion As System.Windows.Forms.Button
    Friend WithEvents NRO_CARTA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents REMITENTE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TRABAJO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FECH_TRAB As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOMBRE_APELLIDO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CALLE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LOCALIDAD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PROVINCIA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EMPRESA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NRO_CARTA2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OrdenLectura As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Btneliminar As System.Windows.Forms.Button
    Friend WithEvents LblServico As System.Windows.Forms.Label
    Friend WithEvents CmbServicio As System.Windows.Forms.ComboBox
    Friend WithEvents BtnActualizar As System.Windows.Forms.Button
    Friend WithEvents dgv11 As System.Windows.Forms.DataGridView
    Friend WithEvents BtnBuscar As System.Windows.Forms.Button

End Class
