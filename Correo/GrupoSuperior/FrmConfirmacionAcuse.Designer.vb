<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConfirmacionAcuse
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DgvCartaConf = New System.Windows.Forms.DataGridView()
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
        Me.ESTADO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.TxtCartas = New System.Windows.Forms.TextBox()
        Me.LblCartas = New System.Windows.Forms.Label()
        Me.LblFecha = New System.Windows.Forms.Label()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.TxtNroplanilla = New System.Windows.Forms.TextBox()
        Me.LblPLanilla = New System.Windows.Forms.Label()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.TxtCantidad = New System.Windows.Forms.TextBox()
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Gb.SuspendLayout()
        CType(Me.DgvCartaConf, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PBLogo
        '
        Me.PBLogo.Location = New System.Drawing.Point(5, 421)
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(1247, 421)
        '
        'Gb
        '
        Me.Gb.Controls.Add(Me.TxtCantidad)
        Me.Gb.Controls.Add(Me.BtnNuevo)
        Me.Gb.Controls.Add(Me.TxtNroplanilla)
        Me.Gb.Controls.Add(Me.LblPLanilla)
        Me.Gb.Controls.Add(Me.BtnAceptar)
        Me.Gb.Controls.Add(Me.LblFecha)
        Me.Gb.Controls.Add(Me.TxtCartas)
        Me.Gb.Controls.Add(Me.LblCartas)
        Me.Gb.Controls.Add(Me.DtpFecha)
        Me.Gb.Controls.Add(Me.DgvCartaConf)
        Me.Gb.Location = New System.Drawing.Point(-1, 0)
        Me.Gb.Size = New System.Drawing.Size(1294, 472)
        Me.Gb.Controls.SetChildIndex(Me.PBLogo, 0)
        Me.Gb.Controls.SetChildIndex(Me.BtnSalir, 0)
        Me.Gb.Controls.SetChildIndex(Me.DgvCartaConf, 0)
        Me.Gb.Controls.SetChildIndex(Me.DtpFecha, 0)
        Me.Gb.Controls.SetChildIndex(Me.LblCartas, 0)
        Me.Gb.Controls.SetChildIndex(Me.TxtCartas, 0)
        Me.Gb.Controls.SetChildIndex(Me.LblFecha, 0)
        Me.Gb.Controls.SetChildIndex(Me.BtnAceptar, 0)
        Me.Gb.Controls.SetChildIndex(Me.LblPLanilla, 0)
        Me.Gb.Controls.SetChildIndex(Me.TxtNroplanilla, 0)
        Me.Gb.Controls.SetChildIndex(Me.BtnNuevo, 0)
        Me.Gb.Controls.SetChildIndex(Me.TxtCantidad, 0)
        '
        'DgvCartaConf
        '
        Me.DgvCartaConf.AllowUserToAddRows = False
        Me.DgvCartaConf.AllowUserToDeleteRows = False
        Me.DgvCartaConf.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvCartaConf.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvCartaConf.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvCartaConf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvCartaConf.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NRO_CARTA, Me.REMITENTE, Me.TRABAJO, Me.FECH_TRAB, Me.NOMBRE_APELLIDO, Me.CP, Me.CALLE, Me.LOCALIDAD, Me.PROVINCIA, Me.EMPRESA, Me.NRO_CARTA2, Me.ESTADO})
        Me.DgvCartaConf.EnableHeadersVisualStyles = False
        Me.DgvCartaConf.Location = New System.Drawing.Point(13, 83)
        Me.DgvCartaConf.MultiSelect = False
        Me.DgvCartaConf.Name = "DgvCartaConf"
        Me.DgvCartaConf.ReadOnly = True
        Me.DgvCartaConf.RowHeadersVisible = False
        Me.DgvCartaConf.Size = New System.Drawing.Size(1200, 300)
        Me.DgvCartaConf.TabIndex = 46
        '
        'NRO_CARTA
        '
        Me.NRO_CARTA.FillWeight = 200.0!
        Me.NRO_CARTA.HeaderText = "NRO_CARTA"
        Me.NRO_CARTA.Name = "NRO_CARTA"
        Me.NRO_CARTA.ReadOnly = True
        '
        'REMITENTE
        '
        Me.REMITENTE.FillWeight = 150.0!
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
        Me.FECH_TRAB.FillWeight = 200.0!
        Me.FECH_TRAB.HeaderText = "FECH_TRAB"
        Me.FECH_TRAB.Name = "FECH_TRAB"
        Me.FECH_TRAB.ReadOnly = True
        '
        'NOMBRE_APELLIDO
        '
        Me.NOMBRE_APELLIDO.FillWeight = 300.0!
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
        Me.NRO_CARTA2.FillWeight = 200.0!
        Me.NRO_CARTA2.HeaderText = "NRO_CARTA2"
        Me.NRO_CARTA2.Name = "NRO_CARTA2"
        Me.NRO_CARTA2.ReadOnly = True
        '
        'ESTADO
        '
        Me.ESTADO.HeaderText = "ESTADO"
        Me.ESTADO.Name = "ESTADO"
        Me.ESTADO.ReadOnly = True
        '
        'DtpFecha
        '
        Me.DtpFecha.Location = New System.Drawing.Point(243, 51)
        Me.DtpFecha.Name = "DtpFecha"
        Me.DtpFecha.Size = New System.Drawing.Size(200, 20)
        Me.DtpFecha.TabIndex = 47
        '
        'TxtCartas
        '
        Me.TxtCartas.Enabled = False
        Me.TxtCartas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCartas.Location = New System.Drawing.Point(469, 49)
        Me.TxtCartas.Name = "TxtCartas"
        Me.TxtCartas.Size = New System.Drawing.Size(100, 20)
        Me.TxtCartas.TabIndex = 49
        '
        'LblCartas
        '
        Me.LblCartas.AutoSize = True
        Me.LblCartas.Location = New System.Drawing.Point(466, 35)
        Me.LblCartas.Name = "LblCartas"
        Me.LblCartas.Size = New System.Drawing.Size(37, 13)
        Me.LblCartas.TabIndex = 48
        Me.LblCartas.Text = "Cartas"
        '
        'LblFecha
        '
        Me.LblFecha.AutoSize = True
        Me.LblFecha.Location = New System.Drawing.Point(240, 35)
        Me.LblFecha.Name = "LblFecha"
        Me.LblFecha.Size = New System.Drawing.Size(37, 13)
        Me.LblFecha.TabIndex = 50
        Me.LblFecha.Text = "Cartas"
        '
        'BtnAceptar
        '
        Me.BtnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAceptar.Location = New System.Drawing.Point(1113, 389)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(100, 30)
        Me.BtnAceptar.TabIndex = 53
        Me.BtnAceptar.Text = "Terminar"
        Me.BtnAceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'TxtNroplanilla
        '
        Me.TxtNroplanilla.Enabled = False
        Me.TxtNroplanilla.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNroplanilla.Location = New System.Drawing.Point(109, 49)
        Me.TxtNroplanilla.Name = "TxtNroplanilla"
        Me.TxtNroplanilla.Size = New System.Drawing.Size(100, 20)
        Me.TxtNroplanilla.TabIndex = 55
        '
        'LblPLanilla
        '
        Me.LblPLanilla.AutoSize = True
        Me.LblPLanilla.Location = New System.Drawing.Point(106, 33)
        Me.LblPLanilla.Name = "LblPLanilla"
        Me.LblPLanilla.Size = New System.Drawing.Size(40, 13)
        Me.LblPLanilla.TabIndex = 54
        Me.LblPLanilla.Text = "Planilla"
        '
        'BtnNuevo
        '
        Me.BtnNuevo.BackColor = System.Drawing.Color.SpringGreen
        Me.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNuevo.Location = New System.Drawing.Point(13, 35)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(90, 40)
        Me.BtnNuevo.TabIndex = 56
        Me.BtnNuevo.Text = "Nuevo"
        Me.BtnNuevo.UseVisualStyleBackColor = False
        '
        'TxtCantidad
        '
        Me.TxtCantidad.Enabled = False
        Me.TxtCantidad.Location = New System.Drawing.Point(13, 389)
        Me.TxtCantidad.Name = "TxtCantidad"
        Me.TxtCantidad.Size = New System.Drawing.Size(50, 20)
        Me.TxtCantidad.TabIndex = 57
        '
        'FrmConfirmacionAcuse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1294, 471)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmConfirmacionAcuse"
        Me.Text = "Costos"
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Gb.ResumeLayout(False)
        Me.Gb.PerformLayout()
        CType(Me.DgvCartaConf, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DgvCartaConf As System.Windows.Forms.DataGridView
    Friend WithEvents DtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents LblFecha As System.Windows.Forms.Label
    Friend WithEvents TxtCartas As System.Windows.Forms.TextBox
    Friend WithEvents LblCartas As System.Windows.Forms.Label
    Friend WithEvents BtnAceptar As System.Windows.Forms.Button
    Friend WithEvents TxtNroplanilla As System.Windows.Forms.TextBox
    Friend WithEvents LblPLanilla As System.Windows.Forms.Label
    Friend WithEvents BtnNuevo As System.Windows.Forms.Button
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
    Friend WithEvents ESTADO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TxtCantidad As System.Windows.Forms.TextBox

End Class
