<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListadoPiezas
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
        Me.ChkFijar = New System.Windows.Forms.CheckBox()
        Me.LblMotivo = New System.Windows.Forms.Label()
        Me.LblNroPLani = New System.Windows.Forms.Label()
        Me.LblFecha = New System.Windows.Forms.Label()
        Me.LblNroCarta2 = New System.Windows.Forms.Label()
        Me.TxtBarraCliente = New System.Windows.Forms.TextBox()
        Me.DtpFechaDevo = New System.Windows.Forms.DateTimePicker()
        Me.BtnOkNoentregada = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.TxtPlanillaDevo = New System.Windows.Forms.TextBox()
        Me.CmbMotivos = New System.Windows.Forms.ComboBox()
        Me.DgvListado = New System.Windows.Forms.DataGridView()
        Me.TxtCartas = New System.Windows.Forms.TextBox()
        Me.LblCartas = New System.Windows.Forms.Label()
        Me.Btnxls = New System.Windows.Forms.Button()
        Me.Nro_carta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fech_trab = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Calle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Localidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Gb.SuspendLayout()
        CType(Me.DgvListado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PBLogo
        '
        Me.PBLogo.Location = New System.Drawing.Point(5, 415)
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(1129, 415)
        '
        'Gb
        '
        Me.Gb.Controls.Add(Me.Btnxls)
        Me.Gb.Controls.Add(Me.ChkFijar)
        Me.Gb.Controls.Add(Me.LblMotivo)
        Me.Gb.Controls.Add(Me.LblNroPLani)
        Me.Gb.Controls.Add(Me.LblFecha)
        Me.Gb.Controls.Add(Me.LblNroCarta2)
        Me.Gb.Controls.Add(Me.TxtBarraCliente)
        Me.Gb.Controls.Add(Me.DtpFechaDevo)
        Me.Gb.Controls.Add(Me.BtnOkNoentregada)
        Me.Gb.Controls.Add(Me.BtnNuevo)
        Me.Gb.Controls.Add(Me.TxtPlanillaDevo)
        Me.Gb.Controls.Add(Me.CmbMotivos)
        Me.Gb.Controls.Add(Me.DgvListado)
        Me.Gb.Controls.Add(Me.TxtCartas)
        Me.Gb.Controls.Add(Me.LblCartas)
        Me.Gb.Location = New System.Drawing.Point(0, 2)
        Me.Gb.Size = New System.Drawing.Size(1176, 466)
        Me.Gb.Controls.SetChildIndex(Me.PBLogo, 0)
        Me.Gb.Controls.SetChildIndex(Me.BtnSalir, 0)
        Me.Gb.Controls.SetChildIndex(Me.LblCartas, 0)
        Me.Gb.Controls.SetChildIndex(Me.TxtCartas, 0)
        Me.Gb.Controls.SetChildIndex(Me.DgvListado, 0)
        Me.Gb.Controls.SetChildIndex(Me.CmbMotivos, 0)
        Me.Gb.Controls.SetChildIndex(Me.TxtPlanillaDevo, 0)
        Me.Gb.Controls.SetChildIndex(Me.BtnNuevo, 0)
        Me.Gb.Controls.SetChildIndex(Me.BtnOkNoentregada, 0)
        Me.Gb.Controls.SetChildIndex(Me.DtpFechaDevo, 0)
        Me.Gb.Controls.SetChildIndex(Me.TxtBarraCliente, 0)
        Me.Gb.Controls.SetChildIndex(Me.LblNroCarta2, 0)
        Me.Gb.Controls.SetChildIndex(Me.LblFecha, 0)
        Me.Gb.Controls.SetChildIndex(Me.LblNroPLani, 0)
        Me.Gb.Controls.SetChildIndex(Me.LblMotivo, 0)
        Me.Gb.Controls.SetChildIndex(Me.ChkFijar, 0)
        Me.Gb.Controls.SetChildIndex(Me.Btnxls, 0)
        '
        'ChkFijar
        '
        Me.ChkFijar.AutoSize = True
        Me.ChkFijar.Location = New System.Drawing.Point(793, 36)
        Me.ChkFijar.Name = "ChkFijar"
        Me.ChkFijar.Size = New System.Drawing.Size(45, 17)
        Me.ChkFijar.TabIndex = 116
        Me.ChkFijar.Text = "Fijar"
        Me.ChkFijar.UseVisualStyleBackColor = True
        '
        'LblMotivo
        '
        Me.LblMotivo.AutoSize = True
        Me.LblMotivo.Location = New System.Drawing.Point(624, 17)
        Me.LblMotivo.Name = "LblMotivo"
        Me.LblMotivo.Size = New System.Drawing.Size(39, 13)
        Me.LblMotivo.TabIndex = 115
        Me.LblMotivo.Text = "Motivo"
        '
        'LblNroPLani
        '
        Me.LblNroPLani.AutoSize = True
        Me.LblNroPLani.Location = New System.Drawing.Point(99, 17)
        Me.LblNroPLani.Name = "LblNroPLani"
        Me.LblNroPLani.Size = New System.Drawing.Size(40, 13)
        Me.LblNroPLani.TabIndex = 114
        Me.LblNroPLani.Text = "Planilla"
        '
        'LblFecha
        '
        Me.LblFecha.AutoSize = True
        Me.LblFecha.Location = New System.Drawing.Point(182, 17)
        Me.LblFecha.Name = "LblFecha"
        Me.LblFecha.Size = New System.Drawing.Size(37, 13)
        Me.LblFecha.TabIndex = 113
        Me.LblFecha.Text = "Fecha"
        '
        'LblNroCarta2
        '
        Me.LblNroCarta2.AutoSize = True
        Me.LblNroCarta2.Location = New System.Drawing.Point(394, 17)
        Me.LblNroCarta2.Name = "LblNroCarta2"
        Me.LblNroCarta2.Size = New System.Drawing.Size(81, 13)
        Me.LblNroCarta2.TabIndex = 112
        Me.LblNroCarta2.Text = "Barra de cliente"
        '
        'TxtBarraCliente
        '
        Me.TxtBarraCliente.Enabled = False
        Me.TxtBarraCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBarraCliente.Location = New System.Drawing.Point(397, 33)
        Me.TxtBarraCliente.Name = "TxtBarraCliente"
        Me.TxtBarraCliente.Size = New System.Drawing.Size(220, 20)
        Me.TxtBarraCliente.TabIndex = 111
        '
        'DtpFechaDevo
        '
        Me.DtpFechaDevo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaDevo.Location = New System.Drawing.Point(185, 34)
        Me.DtpFechaDevo.Name = "DtpFechaDevo"
        Me.DtpFechaDevo.Size = New System.Drawing.Size(100, 20)
        Me.DtpFechaDevo.TabIndex = 110
        '
        'BtnOkNoentregada
        '
        Me.BtnOkNoentregada.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnOkNoentregada.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnOkNoentregada.Image = Global.Correo.My.Resources.Resources.apply
        Me.BtnOkNoentregada.Location = New System.Drawing.Point(862, 28)
        Me.BtnOkNoentregada.Name = "BtnOkNoentregada"
        Me.BtnOkNoentregada.Size = New System.Drawing.Size(30, 30)
        Me.BtnOkNoentregada.TabIndex = 109
        Me.BtnOkNoentregada.UseVisualStyleBackColor = True
        '
        'BtnNuevo
        '
        Me.BtnNuevo.BackColor = System.Drawing.Color.SpringGreen
        Me.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNuevo.Location = New System.Drawing.Point(12, 18)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(80, 40)
        Me.BtnNuevo.TabIndex = 108
        Me.BtnNuevo.Text = "Nuevo"
        Me.BtnNuevo.UseVisualStyleBackColor = False
        '
        'TxtPlanillaDevo
        '
        Me.TxtPlanillaDevo.Enabled = False
        Me.TxtPlanillaDevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPlanillaDevo.Location = New System.Drawing.Point(99, 33)
        Me.TxtPlanillaDevo.Name = "TxtPlanillaDevo"
        Me.TxtPlanillaDevo.Size = New System.Drawing.Size(80, 20)
        Me.TxtPlanillaDevo.TabIndex = 103
        '
        'CmbMotivos
        '
        Me.CmbMotivos.Enabled = False
        Me.CmbMotivos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbMotivos.FormattingEnabled = True
        Me.CmbMotivos.Location = New System.Drawing.Point(627, 33)
        Me.CmbMotivos.Name = "CmbMotivos"
        Me.CmbMotivos.Size = New System.Drawing.Size(150, 21)
        Me.CmbMotivos.TabIndex = 104
        '
        'DgvListado
        '
        Me.DgvListado.AllowUserToAddRows = False
        Me.DgvListado.AllowUserToDeleteRows = False
        Me.DgvListado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvListado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvListado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nro_carta, Me.Fech_trab, Me.Apellido, Me.Calle, Me.Cp, Me.Localidad})
        Me.DgvListado.EnableHeadersVisualStyles = False
        Me.DgvListado.Location = New System.Drawing.Point(12, 63)
        Me.DgvListado.MultiSelect = False
        Me.DgvListado.Name = "DgvListado"
        Me.DgvListado.ReadOnly = True
        Me.DgvListado.RowHeadersVisible = False
        Me.DgvListado.Size = New System.Drawing.Size(979, 300)
        Me.DgvListado.TabIndex = 107
        '
        'TxtCartas
        '
        Me.TxtCartas.Enabled = False
        Me.TxtCartas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCartas.Location = New System.Drawing.Point(291, 33)
        Me.TxtCartas.Name = "TxtCartas"
        Me.TxtCartas.Size = New System.Drawing.Size(100, 20)
        Me.TxtCartas.TabIndex = 106
        '
        'LblCartas
        '
        Me.LblCartas.AutoSize = True
        Me.LblCartas.Location = New System.Drawing.Point(288, 17)
        Me.LblCartas.Name = "LblCartas"
        Me.LblCartas.Size = New System.Drawing.Size(37, 13)
        Me.LblCartas.TabIndex = 105
        Me.LblCartas.Text = "Cartas"
        '
        'Btnxls
        '
        Me.Btnxls.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btnxls.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Btnxls.Enabled = False
        Me.Btnxls.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btnxls.Image = Global.Correo.My.Resources.Resources.table_excel
        Me.Btnxls.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btnxls.Location = New System.Drawing.Point(897, 369)
        Me.Btnxls.Name = "Btnxls"
        Me.Btnxls.Size = New System.Drawing.Size(94, 36)
        Me.Btnxls.TabIndex = 117
        Me.Btnxls.Text = "Excel"
        Me.Btnxls.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btnxls.UseVisualStyleBackColor = True
        '
        'Nro_carta
        '
        Me.Nro_carta.HeaderText = "Nro_carta"
        Me.Nro_carta.Name = "Nro_carta"
        Me.Nro_carta.ReadOnly = True
        '
        'Fech_trab
        '
        Me.Fech_trab.FillWeight = 150.0!
        Me.Fech_trab.HeaderText = "Fech_trab"
        Me.Fech_trab.Name = "Fech_trab"
        Me.Fech_trab.ReadOnly = True
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
        'FrmListadoPiezas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1177, 471)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmListadoPiezas"
        Me.Text = "Stock"
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Gb.ResumeLayout(False)
        Me.Gb.PerformLayout()
        CType(Me.DgvListado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ChkFijar As System.Windows.Forms.CheckBox
    Friend WithEvents LblMotivo As System.Windows.Forms.Label
    Friend WithEvents LblNroPLani As System.Windows.Forms.Label
    Friend WithEvents LblFecha As System.Windows.Forms.Label
    Friend WithEvents LblNroCarta2 As System.Windows.Forms.Label
    Friend WithEvents TxtBarraCliente As System.Windows.Forms.TextBox
    Friend WithEvents DtpFechaDevo As System.Windows.Forms.DateTimePicker
    Public WithEvents BtnOkNoentregada As System.Windows.Forms.Button
    Friend WithEvents BtnNuevo As System.Windows.Forms.Button
    Friend WithEvents TxtPlanillaDevo As System.Windows.Forms.TextBox
    Friend WithEvents CmbMotivos As System.Windows.Forms.ComboBox
    Friend WithEvents DgvListado As System.Windows.Forms.DataGridView
    Friend WithEvents TxtCartas As System.Windows.Forms.TextBox
    Friend WithEvents LblCartas As System.Windows.Forms.Label
    Public WithEvents Btnxls As System.Windows.Forms.Button
    Friend WithEvents Nro_carta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fech_trab As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Apellido As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Calle As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Localidad As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
