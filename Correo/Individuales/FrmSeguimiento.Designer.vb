<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSeguimiento
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
        Me.TxtNroCartaEntregada = New System.Windows.Forms.TextBox()
        Me.LblNroCartaEntregada = New System.Windows.Forms.Label()
        Me.DgvRecorrido = New System.Windows.Forms.DataGridView()
        Me.NRO_CARTA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PLANILLA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CARTERO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ESTADO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MOTIVO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NRO_CARTA2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDENT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtNroCartaNoEntregada = New System.Windows.Forms.TextBox()
        Me.CmbNoEntregada = New System.Windows.Forms.ComboBox()
        Me.LblNroCartaSinEntregar = New System.Windows.Forms.Label()
        Me.LblMotivoNoEntregada = New System.Windows.Forms.Label()
        Me.LblConEntre = New System.Windows.Forms.Label()
        Me.GpbNoEntregadas = New System.Windows.Forms.GroupBox()
        Me.LblfechaNoentregada = New System.Windows.Forms.Label()
        Me.dtpFechaSinEntregar = New System.Windows.Forms.DateTimePicker()
        Me.BtnOkNoentregada = New System.Windows.Forms.Button()
        Me.GpbEntregadas = New System.Windows.Forms.GroupBox()
        Me.lblFechaEntregada = New System.Windows.Forms.Label()
        Me.DtpFechaEntrega = New System.Windows.Forms.DateTimePicker()
        Me.ChkEntregada = New System.Windows.Forms.CheckBox()
        Me.ChkNoEntregada = New System.Windows.Forms.CheckBox()
        Me.TxtTotal = New System.Windows.Forms.TextBox()
        Me.Lbltotal = New System.Windows.Forms.Label()
        Me.BtnConfirmar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Gb.SuspendLayout()
        CType(Me.DgvRecorrido, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GpbNoEntregadas.SuspendLayout()
        Me.GpbEntregadas.SuspendLayout()
        Me.SuspendLayout()
        '
        'PBLogo
        '
        Me.PBLogo.Location = New System.Drawing.Point(6, 658)
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(1074, 662)
        '
        'Gb
        '
        Me.Gb.Controls.Add(Me.BtnCancelar)
        Me.Gb.Controls.Add(Me.BtnConfirmar)
        Me.Gb.Controls.Add(Me.Lbltotal)
        Me.Gb.Controls.Add(Me.TxtTotal)
        Me.Gb.Controls.Add(Me.ChkNoEntregada)
        Me.Gb.Controls.Add(Me.ChkEntregada)
        Me.Gb.Controls.Add(Me.GpbEntregadas)
        Me.Gb.Controls.Add(Me.GpbNoEntregadas)
        Me.Gb.Controls.Add(Me.LblConEntre)
        Me.Gb.Controls.Add(Me.DgvRecorrido)
        Me.Gb.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Gb.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gb.Location = New System.Drawing.Point(-1, 0)
        Me.Gb.Size = New System.Drawing.Size(1121, 713)
        Me.Gb.Controls.SetChildIndex(Me.DgvRecorrido, 0)
        Me.Gb.Controls.SetChildIndex(Me.LblConEntre, 0)
        Me.Gb.Controls.SetChildIndex(Me.PBLogo, 0)
        Me.Gb.Controls.SetChildIndex(Me.BtnSalir, 0)
        Me.Gb.Controls.SetChildIndex(Me.GpbNoEntregadas, 0)
        Me.Gb.Controls.SetChildIndex(Me.GpbEntregadas, 0)
        Me.Gb.Controls.SetChildIndex(Me.ChkEntregada, 0)
        Me.Gb.Controls.SetChildIndex(Me.ChkNoEntregada, 0)
        Me.Gb.Controls.SetChildIndex(Me.TxtTotal, 0)
        Me.Gb.Controls.SetChildIndex(Me.Lbltotal, 0)
        Me.Gb.Controls.SetChildIndex(Me.BtnConfirmar, 0)
        Me.Gb.Controls.SetChildIndex(Me.BtnCancelar, 0)
        '
        'TxtNroCartaEntregada
        '
        Me.TxtNroCartaEntregada.Location = New System.Drawing.Point(470, 43)
        Me.TxtNroCartaEntregada.Name = "TxtNroCartaEntregada"
        Me.TxtNroCartaEntregada.Size = New System.Drawing.Size(150, 31)
        Me.TxtNroCartaEntregada.TabIndex = 38
        '
        'LblNroCartaEntregada
        '
        Me.LblNroCartaEntregada.AutoSize = True
        Me.LblNroCartaEntregada.Location = New System.Drawing.Point(343, 43)
        Me.LblNroCartaEntregada.Name = "LblNroCartaEntregada"
        Me.LblNroCartaEntregada.Size = New System.Drawing.Size(110, 24)
        Me.LblNroCartaEntregada.TabIndex = 39
        Me.LblNroCartaEntregada.Text = "Nro Carta"
        '
        'DgvRecorrido
        '
        Me.DgvRecorrido.AllowUserToAddRows = False
        Me.DgvRecorrido.AllowUserToDeleteRows = False
        Me.DgvRecorrido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvRecorrido.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NRO_CARTA, Me.PLANILLA, Me.CARTERO, Me.FECHA, Me.ESTADO, Me.MOTIVO, Me.NRO_CARTA2, Me.IDENT, Me.ID})
        Me.DgvRecorrido.Location = New System.Drawing.Point(11, 335)
        Me.DgvRecorrido.Name = "DgvRecorrido"
        Me.DgvRecorrido.ReadOnly = True
        Me.DgvRecorrido.Size = New System.Drawing.Size(900, 145)
        Me.DgvRecorrido.TabIndex = 46
        '
        'NRO_CARTA
        '
        Me.NRO_CARTA.HeaderText = "NRO_CARTA"
        Me.NRO_CARTA.Name = "NRO_CARTA"
        Me.NRO_CARTA.ReadOnly = True
        '
        'PLANILLA
        '
        Me.PLANILLA.HeaderText = "PLANILLA"
        Me.PLANILLA.Name = "PLANILLA"
        Me.PLANILLA.ReadOnly = True
        '
        'CARTERO
        '
        Me.CARTERO.HeaderText = "CARTERO"
        Me.CARTERO.Name = "CARTERO"
        Me.CARTERO.ReadOnly = True
        '
        'FECHA
        '
        Me.FECHA.HeaderText = "FECHA"
        Me.FECHA.Name = "FECHA"
        Me.FECHA.ReadOnly = True
        '
        'ESTADO
        '
        Me.ESTADO.HeaderText = "ESTADO"
        Me.ESTADO.Name = "ESTADO"
        Me.ESTADO.ReadOnly = True
        '
        'MOTIVO
        '
        Me.MOTIVO.HeaderText = "MOTIVO"
        Me.MOTIVO.Name = "MOTIVO"
        Me.MOTIVO.ReadOnly = True
        '
        'NRO_CARTA2
        '
        Me.NRO_CARTA2.HeaderText = "NRO_CARTA2"
        Me.NRO_CARTA2.Name = "NRO_CARTA2"
        Me.NRO_CARTA2.ReadOnly = True
        '
        'IDENT
        '
        Me.IDENT.HeaderText = "IDENT"
        Me.IDENT.Name = "IDENT"
        Me.IDENT.ReadOnly = True
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        '
        'TxtNroCartaNoEntregada
        '
        Me.TxtNroCartaNoEntregada.Location = New System.Drawing.Point(150, 80)
        Me.TxtNroCartaNoEntregada.Name = "TxtNroCartaNoEntregada"
        Me.TxtNroCartaNoEntregada.Size = New System.Drawing.Size(150, 31)
        Me.TxtNroCartaNoEntregada.TabIndex = 47
        '
        'CmbNoEntregada
        '
        Me.CmbNoEntregada.FormattingEnabled = True
        Me.CmbNoEntregada.Location = New System.Drawing.Point(429, 79)
        Me.CmbNoEntregada.Name = "CmbNoEntregada"
        Me.CmbNoEntregada.Size = New System.Drawing.Size(250, 32)
        Me.CmbNoEntregada.TabIndex = 48
        '
        'LblNroCartaSinEntregar
        '
        Me.LblNroCartaSinEntregar.AutoSize = True
        Me.LblNroCartaSinEntregar.Location = New System.Drawing.Point(20, 83)
        Me.LblNroCartaSinEntregar.Name = "LblNroCartaSinEntregar"
        Me.LblNroCartaSinEntregar.Size = New System.Drawing.Size(110, 24)
        Me.LblNroCartaSinEntregar.TabIndex = 49
        Me.LblNroCartaSinEntregar.Text = "Nro Carta"
        '
        'LblMotivoNoEntregada
        '
        Me.LblMotivoNoEntregada.AutoSize = True
        Me.LblMotivoNoEntregada.Location = New System.Drawing.Point(343, 83)
        Me.LblMotivoNoEntregada.Name = "LblMotivoNoEntregada"
        Me.LblMotivoNoEntregada.Size = New System.Drawing.Size(80, 24)
        Me.LblMotivoNoEntregada.TabIndex = 52
        Me.LblMotivoNoEntregada.Text = "Motivo"
        '
        'LblConEntre
        '
        Me.LblConEntre.AutoSize = True
        Me.LblConEntre.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblConEntre.ForeColor = System.Drawing.Color.DarkBlue
        Me.LblConEntre.Location = New System.Drawing.Point(6, 14)
        Me.LblConEntre.Name = "LblConEntre"
        Me.LblConEntre.Size = New System.Drawing.Size(0, 25)
        Me.LblConEntre.TabIndex = 64
        '
        'GpbNoEntregadas
        '
        Me.GpbNoEntregadas.Controls.Add(Me.LblfechaNoentregada)
        Me.GpbNoEntregadas.Controls.Add(Me.dtpFechaSinEntregar)
        Me.GpbNoEntregadas.Controls.Add(Me.BtnOkNoentregada)
        Me.GpbNoEntregadas.Controls.Add(Me.CmbNoEntregada)
        Me.GpbNoEntregadas.Controls.Add(Me.TxtNroCartaNoEntregada)
        Me.GpbNoEntregadas.Controls.Add(Me.LblMotivoNoEntregada)
        Me.GpbNoEntregadas.Controls.Add(Me.LblNroCartaSinEntregar)
        Me.GpbNoEntregadas.Enabled = False
        Me.GpbNoEntregadas.Font = New System.Drawing.Font("MS Reference Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GpbNoEntregadas.Location = New System.Drawing.Point(9, 189)
        Me.GpbNoEntregadas.Name = "GpbNoEntregadas"
        Me.GpbNoEntregadas.Size = New System.Drawing.Size(750, 120)
        Me.GpbNoEntregadas.TabIndex = 85
        Me.GpbNoEntregadas.TabStop = False
        Me.GpbNoEntregadas.Text = "SIN ENTREGAR"
        '
        'LblfechaNoentregada
        '
        Me.LblfechaNoentregada.AutoSize = True
        Me.LblfechaNoentregada.Location = New System.Drawing.Point(20, 35)
        Me.LblfechaNoentregada.Name = "LblfechaNoentregada"
        Me.LblfechaNoentregada.Size = New System.Drawing.Size(70, 24)
        Me.LblfechaNoentregada.TabIndex = 42
        Me.LblfechaNoentregada.Text = "Fecha"
        '
        'dtpFechaSinEntregar
        '
        Me.dtpFechaSinEntregar.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaSinEntregar.Location = New System.Drawing.Point(150, 30)
        Me.dtpFechaSinEntregar.Name = "dtpFechaSinEntregar"
        Me.dtpFechaSinEntregar.Size = New System.Drawing.Size(150, 31)
        Me.dtpFechaSinEntregar.TabIndex = 95
        '
        'BtnOkNoentregada
        '
        Me.BtnOkNoentregada.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnOkNoentregada.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnOkNoentregada.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnOkNoentregada.Image = Global.Correo.My.Resources.Resources.apply
        Me.BtnOkNoentregada.Location = New System.Drawing.Point(711, 82)
        Me.BtnOkNoentregada.Name = "BtnOkNoentregada"
        Me.BtnOkNoentregada.Size = New System.Drawing.Size(30, 30)
        Me.BtnOkNoentregada.TabIndex = 94
        Me.BtnOkNoentregada.UseVisualStyleBackColor = True
        '
        'GpbEntregadas
        '
        Me.GpbEntregadas.Controls.Add(Me.lblFechaEntregada)
        Me.GpbEntregadas.Controls.Add(Me.DtpFechaEntrega)
        Me.GpbEntregadas.Controls.Add(Me.LblNroCartaEntregada)
        Me.GpbEntregadas.Controls.Add(Me.TxtNroCartaEntregada)
        Me.GpbEntregadas.Enabled = False
        Me.GpbEntregadas.Font = New System.Drawing.Font("MS Reference Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GpbEntregadas.Location = New System.Drawing.Point(9, 31)
        Me.GpbEntregadas.Name = "GpbEntregadas"
        Me.GpbEntregadas.Size = New System.Drawing.Size(750, 120)
        Me.GpbEntregadas.TabIndex = 86
        Me.GpbEntregadas.TabStop = False
        Me.GpbEntregadas.Text = "ENTREGADAS"
        '
        'lblFechaEntregada
        '
        Me.lblFechaEntregada.AutoSize = True
        Me.lblFechaEntregada.Location = New System.Drawing.Point(20, 40)
        Me.lblFechaEntregada.Name = "lblFechaEntregada"
        Me.lblFechaEntregada.Size = New System.Drawing.Size(70, 24)
        Me.lblFechaEntregada.TabIndex = 41
        Me.lblFechaEntregada.Text = "Fecha"
        '
        'DtpFechaEntrega
        '
        Me.DtpFechaEntrega.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaEntrega.Location = New System.Drawing.Point(150, 40)
        Me.DtpFechaEntrega.Name = "DtpFechaEntrega"
        Me.DtpFechaEntrega.Size = New System.Drawing.Size(150, 31)
        Me.DtpFechaEntrega.TabIndex = 40
        '
        'ChkEntregada
        '
        Me.ChkEntregada.AutoSize = True
        Me.ChkEntregada.Location = New System.Drawing.Point(765, 44)
        Me.ChkEntregada.Name = "ChkEntregada"
        Me.ChkEntregada.Size = New System.Drawing.Size(15, 14)
        Me.ChkEntregada.TabIndex = 88
        Me.ChkEntregada.UseVisualStyleBackColor = True
        '
        'ChkNoEntregada
        '
        Me.ChkNoEntregada.AutoSize = True
        Me.ChkNoEntregada.Location = New System.Drawing.Point(765, 202)
        Me.ChkNoEntregada.Name = "ChkNoEntregada"
        Me.ChkNoEntregada.Size = New System.Drawing.Size(15, 14)
        Me.ChkNoEntregada.TabIndex = 89
        Me.ChkNoEntregada.UseVisualStyleBackColor = True
        '
        'TxtTotal
        '
        Me.TxtTotal.Enabled = False
        Me.TxtTotal.Location = New System.Drawing.Point(871, 499)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.Size = New System.Drawing.Size(40, 20)
        Me.TxtTotal.TabIndex = 91
        '
        'Lbltotal
        '
        Me.Lbltotal.AutoSize = True
        Me.Lbltotal.Location = New System.Drawing.Point(875, 483)
        Me.Lbltotal.Name = "Lbltotal"
        Me.Lbltotal.Size = New System.Drawing.Size(36, 13)
        Me.Lbltotal.TabIndex = 93
        Me.Lbltotal.Text = "Total"
        '
        'BtnConfirmar
        '
        Me.BtnConfirmar.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.BtnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnConfirmar.Image = Global.Correo.My.Resources.Resources.tick
        Me.BtnConfirmar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnConfirmar.Location = New System.Drawing.Point(13, 492)
        Me.BtnConfirmar.Name = "BtnConfirmar"
        Me.BtnConfirmar.Size = New System.Drawing.Size(100, 38)
        Me.BtnConfirmar.TabIndex = 94
        Me.BtnConfirmar.Text = "Confirmar"
        Me.BtnConfirmar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnConfirmar.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnCancelar.Image = Global.Correo.My.Resources.Resources.agt_stop
        Me.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCancelar.Location = New System.Drawing.Point(139, 492)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(100, 38)
        Me.BtnCancelar.TabIndex = 95
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'FrmSeguimiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1119, 712)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmSeguimiento"
        Me.Text = "Seguimiento"
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Gb.ResumeLayout(False)
        Me.Gb.PerformLayout()
        CType(Me.DgvRecorrido, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GpbNoEntregadas.ResumeLayout(False)
        Me.GpbNoEntregadas.PerformLayout()
        Me.GpbEntregadas.ResumeLayout(False)
        Me.GpbEntregadas.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TxtNroCartaEntregada As System.Windows.Forms.TextBox
    Friend WithEvents LblNroCartaEntregada As System.Windows.Forms.Label
    Friend WithEvents DgvRecorrido As System.Windows.Forms.DataGridView
    Friend WithEvents CmbNoEntregada As System.Windows.Forms.ComboBox
    Friend WithEvents TxtNroCartaNoEntregada As System.Windows.Forms.TextBox
    Friend WithEvents LblNroCartaSinEntregar As System.Windows.Forms.Label
    Friend WithEvents LblMotivoNoEntregada As System.Windows.Forms.Label
    Friend WithEvents LblConEntre As System.Windows.Forms.Label
    Friend WithEvents GpbEntregadas As System.Windows.Forms.GroupBox
    Friend WithEvents GpbNoEntregadas As System.Windows.Forms.GroupBox
    Friend WithEvents ChkNoEntregada As System.Windows.Forms.CheckBox
    Friend WithEvents ChkEntregada As System.Windows.Forms.CheckBox
    Friend WithEvents Lbltotal As System.Windows.Forms.Label
    Friend WithEvents TxtTotal As System.Windows.Forms.TextBox
    Public WithEvents BtnOkNoentregada As System.Windows.Forms.Button
    Friend WithEvents lblFechaEntregada As System.Windows.Forms.Label
    Friend WithEvents DtpFechaEntrega As System.Windows.Forms.DateTimePicker
    Friend WithEvents LblfechaNoentregada As System.Windows.Forms.Label
    Friend WithEvents dtpFechaSinEntregar As System.Windows.Forms.DateTimePicker
    Friend WithEvents BtnConfirmar As System.Windows.Forms.Button
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
    Friend WithEvents NRO_CARTA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PLANILLA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CARTERO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FECHA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ESTADO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MOTIVO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NRO_CARTA2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDENT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ID As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
