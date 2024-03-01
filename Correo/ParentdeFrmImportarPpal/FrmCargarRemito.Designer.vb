<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCargarRemito
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
        Me.CmbCliente = New System.Windows.Forms.ComboBox()
        Me.CmbRemitente = New System.Windows.Forms.ComboBox()
        Me.TxtNroRemito = New System.Windows.Forms.TextBox()
        Me.DtpFecha_retiro = New System.Windows.Forms.DateTimePicker()
        Me.BtnIngresar = New System.Windows.Forms.Button()
        Me.DGVRemito = New System.Windows.Forms.DataGridView()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nro_Remito = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Servicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.LblCliente = New System.Windows.Forms.Label()
        Me.LblFecha = New System.Windows.Forms.Label()
        Me.LblRemitente = New System.Windows.Forms.Label()
        Me.LblNro = New System.Windows.Forms.Label()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.CmbServicio = New System.Windows.Forms.ComboBox()
        Me.LblServicio = New System.Windows.Forms.Label()
        CType(Me.DGVRemito, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CmbCliente
        '
        Me.CmbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbCliente.FormattingEnabled = True
        Me.CmbCliente.Location = New System.Drawing.Point(257, 26)
        Me.CmbCliente.Name = "CmbCliente"
        Me.CmbCliente.Size = New System.Drawing.Size(139, 21)
        Me.CmbCliente.TabIndex = 0
        '
        'CmbRemitente
        '
        Me.CmbRemitente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbRemitente.FormattingEnabled = True
        Me.CmbRemitente.Location = New System.Drawing.Point(447, 25)
        Me.CmbRemitente.Name = "CmbRemitente"
        Me.CmbRemitente.Size = New System.Drawing.Size(109, 21)
        Me.CmbRemitente.TabIndex = 1
        '
        'TxtNroRemito
        '
        Me.TxtNroRemito.Enabled = False
        Me.TxtNroRemito.Location = New System.Drawing.Point(257, 76)
        Me.TxtNroRemito.Name = "TxtNroRemito"
        Me.TxtNroRemito.Size = New System.Drawing.Size(91, 20)
        Me.TxtNroRemito.TabIndex = 2
        '
        'DtpFecha_retiro
        '
        Me.DtpFecha_retiro.Location = New System.Drawing.Point(12, 26)
        Me.DtpFecha_retiro.Name = "DtpFecha_retiro"
        Me.DtpFecha_retiro.Size = New System.Drawing.Size(209, 20)
        Me.DtpFecha_retiro.TabIndex = 3
        '
        'BtnIngresar
        '
        Me.BtnIngresar.Location = New System.Drawing.Point(481, 75)
        Me.BtnIngresar.Name = "BtnIngresar"
        Me.BtnIngresar.Size = New System.Drawing.Size(71, 24)
        Me.BtnIngresar.TabIndex = 4
        Me.BtnIngresar.Text = "Ingresar"
        Me.BtnIngresar.UseVisualStyleBackColor = True
        '
        'DGVRemito
        '
        Me.DGVRemito.AllowUserToAddRows = False
        Me.DGVRemito.AllowUserToDeleteRows = False
        Me.DGVRemito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVRemito.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Fecha, Me.Cliente, Me.Tipo, Me.Nro_Remito, Me.Servicio})
        Me.DGVRemito.Location = New System.Drawing.Point(12, 105)
        Me.DGVRemito.Name = "DGVRemito"
        Me.DGVRemito.ReadOnly = True
        Me.DGVRemito.RowTemplate.Height = 25
        Me.DGVRemito.Size = New System.Drawing.Size(544, 73)
        Me.DGVRemito.TabIndex = 5
        '
        'Fecha
        '
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        '
        'Cliente
        '
        Me.Cliente.HeaderText = "Cliente"
        Me.Cliente.Name = "Cliente"
        Me.Cliente.ReadOnly = True
        '
        'Tipo
        '
        Me.Tipo.HeaderText = "Tipo"
        Me.Tipo.Name = "Tipo"
        Me.Tipo.ReadOnly = True
        '
        'Nro_Remito
        '
        Me.Nro_Remito.HeaderText = "Nro_Remito"
        Me.Nro_Remito.Name = "Nro_Remito"
        Me.Nro_Remito.ReadOnly = True
        '
        'Servicio
        '
        Me.Servicio.HeaderText = "Servicio"
        Me.Servicio.Name = "Servicio"
        Me.Servicio.ReadOnly = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(12, 184)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(109, 20)
        Me.BtnEliminar.TabIndex = 6
        Me.BtnEliminar.Text = "Eliminar Seleccion"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'LblCliente
        '
        Me.LblCliente.AutoSize = True
        Me.LblCliente.Location = New System.Drawing.Point(254, 7)
        Me.LblCliente.Name = "LblCliente"
        Me.LblCliente.Size = New System.Drawing.Size(39, 13)
        Me.LblCliente.TabIndex = 7
        Me.LblCliente.Text = "Cliente"
        '
        'LblFecha
        '
        Me.LblFecha.AutoSize = True
        Me.LblFecha.Location = New System.Drawing.Point(12, 9)
        Me.LblFecha.Name = "LblFecha"
        Me.LblFecha.Size = New System.Drawing.Size(78, 13)
        Me.LblFecha.TabIndex = 8
        Me.LblFecha.Text = "Fecha de retiro"
        '
        'LblRemitente
        '
        Me.LblRemitente.AutoSize = True
        Me.LblRemitente.Location = New System.Drawing.Point(444, 7)
        Me.LblRemitente.Name = "LblRemitente"
        Me.LblRemitente.Size = New System.Drawing.Size(55, 13)
        Me.LblRemitente.TabIndex = 9
        Me.LblRemitente.Text = "Remitente"
        '
        'LblNro
        '
        Me.LblNro.AutoSize = True
        Me.LblNro.Location = New System.Drawing.Point(254, 59)
        Me.LblNro.Name = "LblNro"
        Me.LblNro.Size = New System.Drawing.Size(75, 13)
        Me.LblNro.TabIndex = 10
        Me.LblNro.Text = "Nro de Remito"
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(481, 184)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(75, 20)
        Me.BtnSalir.TabIndex = 11
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'CmbServicio
        '
        Me.CmbServicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbServicio.Enabled = False
        Me.CmbServicio.FormattingEnabled = True
        Me.CmbServicio.Location = New System.Drawing.Point(12, 78)
        Me.CmbServicio.Name = "CmbServicio"
        Me.CmbServicio.Size = New System.Drawing.Size(151, 21)
        Me.CmbServicio.TabIndex = 12
        '
        'LblServicio
        '
        Me.LblServicio.AutoSize = True
        Me.LblServicio.Location = New System.Drawing.Point(12, 59)
        Me.LblServicio.Name = "LblServicio"
        Me.LblServicio.Size = New System.Drawing.Size(75, 13)
        Me.LblServicio.TabIndex = 13
        Me.LblServicio.Text = "Nro de Remito"
        '
        'FrmCargarRemito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(571, 230)
        Me.Controls.Add(Me.LblServicio)
        Me.Controls.Add(Me.CmbServicio)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.LblNro)
        Me.Controls.Add(Me.LblRemitente)
        Me.Controls.Add(Me.LblFecha)
        Me.Controls.Add(Me.LblCliente)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.DGVRemito)
        Me.Controls.Add(Me.BtnIngresar)
        Me.Controls.Add(Me.DtpFecha_retiro)
        Me.Controls.Add(Me.TxtNroRemito)
        Me.Controls.Add(Me.CmbRemitente)
        Me.Controls.Add(Me.CmbCliente)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmCargarRemito"
        Me.Text = "Cargar Remito"
        CType(Me.DGVRemito, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CmbCliente As System.Windows.Forms.ComboBox
    Friend WithEvents CmbRemitente As System.Windows.Forms.ComboBox
    Friend WithEvents TxtNroRemito As System.Windows.Forms.TextBox
    Friend WithEvents DtpFecha_retiro As System.Windows.Forms.DateTimePicker
    Friend WithEvents BtnIngresar As System.Windows.Forms.Button
    Friend WithEvents DGVRemito As System.Windows.Forms.DataGridView
    Friend WithEvents BtnEliminar As System.Windows.Forms.Button
    Friend WithEvents LblCliente As System.Windows.Forms.Label
    Friend WithEvents LblFecha As System.Windows.Forms.Label
    Friend WithEvents LblRemitente As System.Windows.Forms.Label
    Friend WithEvents LblNro As System.Windows.Forms.Label
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents Fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nro_Remito As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Servicio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CmbServicio As System.Windows.Forms.ComboBox
    Friend WithEvents LblServicio As System.Windows.Forms.Label
End Class
