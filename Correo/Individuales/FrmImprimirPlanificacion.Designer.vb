<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmImprimirPlanificacion
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
        Me.GpbRecorridos = New System.Windows.Forms.GroupBox()
        Me.DgvRecorridos = New System.Windows.Forms.DataGridView()
        Me.Nro_Recorrido_r = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cartero_r = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha_r = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Zona_r = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad_r = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GpbCartas = New System.Windows.Forms.GroupBox()
        Me.BtnSubirRecorrido = New System.Windows.Forms.Button()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.TxtNuevaCarta = New System.Windows.Forms.TextBox()
        Me.BtnImprimir = New System.Windows.Forms.Button()
        Me.LblPLanillaImprimir = New System.Windows.Forms.Label()
        Me.CmbRemitentes = New System.Windows.Forms.ComboBox()
        Me.BtnCambiar = New System.Windows.Forms.Button()
        Me.BtnImpresion = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Cmbcambiar = New System.Windows.Forms.ComboBox()
        Me.LblFecha = New System.Windows.Forms.Label()
        Me.txtfecha = New System.Windows.Forms.TextBox()
        Me.LblCantidad = New System.Windows.Forms.Label()
        Me.Lblcliente = New System.Windows.Forms.Label()
        Me.Lblzona = New System.Windows.Forms.Label()
        Me.Lblcaminante = New System.Windows.Forms.Label()
        Me.LblRecorrido = New System.Windows.Forms.Label()
        Me.txcantidad = New System.Windows.Forms.TextBox()
        Me.txtcliente = New System.Windows.Forms.TextBox()
        Me.txtzona = New System.Windows.Forms.TextBox()
        Me.txcaminante = New System.Windows.Forms.TextBox()
        Me.txtrecorrido = New System.Windows.Forms.TextBox()
        Me.DgvContenido = New System.Windows.Forms.DataGridView()
        Me.DtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.BtnImprimirPlanillasFecha = New System.Windows.Forms.Button()
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Gb.SuspendLayout()
        Me.GpbRecorridos.SuspendLayout()
        CType(Me.DgvRecorridos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GpbCartas.SuspendLayout()
        CType(Me.DgvContenido, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PBLogo
        '
        Me.PBLogo.Location = New System.Drawing.Point(5, 661)
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(1246, 661)
        '
        'Gb
        '
        Me.Gb.Controls.Add(Me.GpbCartas)
        Me.Gb.Controls.Add(Me.GpbRecorridos)
        Me.Gb.Controls.Add(Me.DtpFecha)
        Me.Gb.Controls.Add(Me.BtnImprimirPlanillasFecha)
        Me.Gb.Location = New System.Drawing.Point(0, 0)
        Me.Gb.Size = New System.Drawing.Size(1293, 712)
        Me.Gb.Controls.SetChildIndex(Me.BtnImprimirPlanillasFecha, 0)
        Me.Gb.Controls.SetChildIndex(Me.DtpFecha, 0)
        Me.Gb.Controls.SetChildIndex(Me.GpbRecorridos, 0)
        Me.Gb.Controls.SetChildIndex(Me.GpbCartas, 0)
        Me.Gb.Controls.SetChildIndex(Me.PBLogo, 0)
        Me.Gb.Controls.SetChildIndex(Me.BtnSalir, 0)
        '
        'GpbRecorridos
        '
        Me.GpbRecorridos.Controls.Add(Me.DgvRecorridos)
        Me.GpbRecorridos.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GpbRecorridos.ForeColor = System.Drawing.Color.Black
        Me.GpbRecorridos.Location = New System.Drawing.Point(22, 62)
        Me.GpbRecorridos.Name = "GpbRecorridos"
        Me.GpbRecorridos.Size = New System.Drawing.Size(500, 550)
        Me.GpbRecorridos.TabIndex = 55
        Me.GpbRecorridos.TabStop = False
        Me.GpbRecorridos.Text = "Recorridos"
        '
        'DgvRecorridos
        '
        Me.DgvRecorridos.AllowUserToAddRows = False
        Me.DgvRecorridos.AllowUserToDeleteRows = False
        Me.DgvRecorridos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvRecorridos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nro_Recorrido_r, Me.Cartero_r, Me.Fecha_r, Me.Zona_r, Me.Cantidad_r})
        Me.DgvRecorridos.Location = New System.Drawing.Point(22, 34)
        Me.DgvRecorridos.Name = "DgvRecorridos"
        Me.DgvRecorridos.ReadOnly = True
        Me.DgvRecorridos.RowHeadersVisible = False
        Me.DgvRecorridos.Size = New System.Drawing.Size(460, 500)
        Me.DgvRecorridos.TabIndex = 0
        '
        'Nro_Recorrido_r
        '
        Me.Nro_Recorrido_r.FillWeight = 150.0!
        Me.Nro_Recorrido_r.Frozen = True
        Me.Nro_Recorrido_r.HeaderText = "Nro_Recorrido"
        Me.Nro_Recorrido_r.Name = "Nro_Recorrido_r"
        Me.Nro_Recorrido_r.ReadOnly = True
        Me.Nro_Recorrido_r.Width = 150
        '
        'Cartero_r
        '
        Me.Cartero_r.Frozen = True
        Me.Cartero_r.HeaderText = "Cartero"
        Me.Cartero_r.Name = "Cartero_r"
        Me.Cartero_r.ReadOnly = True
        Me.Cartero_r.Width = 150
        '
        'Fecha_r
        '
        Me.Fecha_r.Frozen = True
        Me.Fecha_r.HeaderText = "Fecha"
        Me.Fecha_r.Name = "Fecha_r"
        Me.Fecha_r.ReadOnly = True
        Me.Fecha_r.Width = 150
        '
        'Zona_r
        '
        Me.Zona_r.Frozen = True
        Me.Zona_r.HeaderText = "Zona"
        Me.Zona_r.Name = "Zona_r"
        Me.Zona_r.ReadOnly = True
        '
        'Cantidad_r
        '
        Me.Cantidad_r.Frozen = True
        Me.Cantidad_r.HeaderText = "Cantidad"
        Me.Cantidad_r.Name = "Cantidad_r"
        Me.Cantidad_r.ReadOnly = True
        '
        'GpbCartas
        '
        Me.GpbCartas.Controls.Add(Me.BtnSubirRecorrido)
        Me.GpbCartas.Controls.Add(Me.BtnAgregar)
        Me.GpbCartas.Controls.Add(Me.TxtNuevaCarta)
        Me.GpbCartas.Controls.Add(Me.BtnImprimir)
        Me.GpbCartas.Controls.Add(Me.LblPLanillaImprimir)
        Me.GpbCartas.Controls.Add(Me.CmbRemitentes)
        Me.GpbCartas.Controls.Add(Me.BtnCambiar)
        Me.GpbCartas.Controls.Add(Me.BtnImpresion)
        Me.GpbCartas.Controls.Add(Me.Label1)
        Me.GpbCartas.Controls.Add(Me.Cmbcambiar)
        Me.GpbCartas.Controls.Add(Me.LblFecha)
        Me.GpbCartas.Controls.Add(Me.txtfecha)
        Me.GpbCartas.Controls.Add(Me.LblCantidad)
        Me.GpbCartas.Controls.Add(Me.Lblcliente)
        Me.GpbCartas.Controls.Add(Me.Lblzona)
        Me.GpbCartas.Controls.Add(Me.Lblcaminante)
        Me.GpbCartas.Controls.Add(Me.LblRecorrido)
        Me.GpbCartas.Controls.Add(Me.txcantidad)
        Me.GpbCartas.Controls.Add(Me.txtcliente)
        Me.GpbCartas.Controls.Add(Me.txtzona)
        Me.GpbCartas.Controls.Add(Me.txcaminante)
        Me.GpbCartas.Controls.Add(Me.txtrecorrido)
        Me.GpbCartas.Controls.Add(Me.DgvContenido)
        Me.GpbCartas.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GpbCartas.ForeColor = System.Drawing.Color.Black
        Me.GpbCartas.Location = New System.Drawing.Point(541, 62)
        Me.GpbCartas.Name = "GpbCartas"
        Me.GpbCartas.Size = New System.Drawing.Size(800, 550)
        Me.GpbCartas.TabIndex = 56
        Me.GpbCartas.TabStop = False
        Me.GpbCartas.Text = "Recorridos"
        '
        'BtnSubirRecorrido
        '
        Me.BtnSubirRecorrido.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSubirRecorrido.Location = New System.Drawing.Point(488, 489)
        Me.BtnSubirRecorrido.Name = "BtnSubirRecorrido"
        Me.BtnSubirRecorrido.Size = New System.Drawing.Size(120, 50)
        Me.BtnSubirRecorrido.TabIndex = 66
        Me.BtnSubirRecorrido.Text = "Subir recorrido"
        Me.BtnSubirRecorrido.UseVisualStyleBackColor = True
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Location = New System.Drawing.Point(678, 67)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(110, 30)
        Me.BtnAgregar.TabIndex = 65
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'TxtNuevaCarta
        '
        Me.TxtNuevaCarta.Location = New System.Drawing.Point(678, 34)
        Me.TxtNuevaCarta.Name = "TxtNuevaCarta"
        Me.TxtNuevaCarta.Size = New System.Drawing.Size(110, 27)
        Me.TxtNuevaCarta.TabIndex = 64
        '
        'BtnImprimir
        '
        Me.BtnImprimir.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnImprimir.Location = New System.Drawing.Point(635, 422)
        Me.BtnImprimir.Name = "BtnImprimir"
        Me.BtnImprimir.Size = New System.Drawing.Size(84, 50)
        Me.BtnImprimir.TabIndex = 63
        Me.BtnImprimir.Text = "Bajar Imprimir"
        Me.BtnImprimir.UseVisualStyleBackColor = True
        '
        'LblPLanillaImprimir
        '
        Me.LblPLanillaImprimir.AutoSize = True
        Me.LblPLanillaImprimir.Location = New System.Drawing.Point(559, 365)
        Me.LblPLanillaImprimir.Name = "LblPLanillaImprimir"
        Me.LblPLanillaImprimir.Size = New System.Drawing.Size(235, 20)
        Me.LblPLanillaImprimir.TabIndex = 62
        Me.LblPLanillaImprimir.Text = "Imprimir Planilla de Control"
        '
        'CmbRemitentes
        '
        Me.CmbRemitentes.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!)
        Me.CmbRemitentes.FormattingEnabled = True
        Me.CmbRemitentes.Location = New System.Drawing.Point(572, 388)
        Me.CmbRemitentes.Name = "CmbRemitentes"
        Me.CmbRemitentes.Size = New System.Drawing.Size(200, 28)
        Me.CmbRemitentes.TabIndex = 61
        '
        'BtnCambiar
        '
        Me.BtnCambiar.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCambiar.Location = New System.Drawing.Point(398, 490)
        Me.BtnCambiar.Name = "BtnCambiar"
        Me.BtnCambiar.Size = New System.Drawing.Size(84, 50)
        Me.BtnCambiar.TabIndex = 60
        Me.BtnCambiar.Text = "Cambiar"
        Me.BtnCambiar.UseVisualStyleBackColor = True
        '
        'BtnImpresion
        '
        Me.BtnImpresion.Location = New System.Drawing.Point(678, 284)
        Me.BtnImpresion.Name = "BtnImpresion"
        Me.BtnImpresion.Size = New System.Drawing.Size(100, 50)
        Me.BtnImpresion.TabIndex = 57
        Me.BtnImpresion.Text = "Impresion Detallada"
        Me.BtnImpresion.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(186, 478)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 20)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Caminante"
        '
        'Cmbcambiar
        '
        Me.Cmbcambiar.Enabled = False
        Me.Cmbcambiar.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!)
        Me.Cmbcambiar.FormattingEnabled = True
        Me.Cmbcambiar.Location = New System.Drawing.Point(184, 501)
        Me.Cmbcambiar.Name = "Cmbcambiar"
        Me.Cmbcambiar.Size = New System.Drawing.Size(200, 28)
        Me.Cmbcambiar.TabIndex = 40
        '
        'LblFecha
        '
        Me.LblFecha.AutoSize = True
        Me.LblFecha.Location = New System.Drawing.Point(334, 418)
        Me.LblFecha.Name = "LblFecha"
        Me.LblFecha.Size = New System.Drawing.Size(56, 20)
        Me.LblFecha.TabIndex = 13
        Me.LblFecha.Text = "Fecha"
        '
        'txtfecha
        '
        Me.txtfecha.Enabled = False
        Me.txtfecha.Location = New System.Drawing.Point(338, 441)
        Me.txtfecha.Name = "txtfecha"
        Me.txtfecha.Size = New System.Drawing.Size(135, 27)
        Me.txtfecha.TabIndex = 12
        '
        'LblCantidad
        '
        Me.LblCantidad.AutoSize = True
        Me.LblCantidad.Location = New System.Drawing.Point(30, 478)
        Me.LblCantidad.Name = "LblCantidad"
        Me.LblCantidad.Size = New System.Drawing.Size(82, 20)
        Me.LblCantidad.TabIndex = 11
        Me.LblCantidad.Text = "Cantidad"
        '
        'Lblcliente
        '
        Me.Lblcliente.AutoSize = True
        Me.Lblcliente.Location = New System.Drawing.Point(30, 418)
        Me.Lblcliente.Name = "Lblcliente"
        Me.Lblcliente.Size = New System.Drawing.Size(67, 20)
        Me.Lblcliente.TabIndex = 10
        Me.Lblcliente.Text = "Cliente"
        '
        'Lblzona
        '
        Me.Lblzona.AutoSize = True
        Me.Lblzona.Location = New System.Drawing.Point(334, 365)
        Me.Lblzona.Name = "Lblzona"
        Me.Lblzona.Size = New System.Drawing.Size(50, 20)
        Me.Lblzona.TabIndex = 9
        Me.Lblzona.Text = "Zona"
        '
        'Lblcaminante
        '
        Me.Lblcaminante.AutoSize = True
        Me.Lblcaminante.Location = New System.Drawing.Point(183, 365)
        Me.Lblcaminante.Name = "Lblcaminante"
        Me.Lblcaminante.Size = New System.Drawing.Size(97, 20)
        Me.Lblcaminante.TabIndex = 8
        Me.Lblcaminante.Text = "Caminante"
        '
        'LblRecorrido
        '
        Me.LblRecorrido.AutoSize = True
        Me.LblRecorrido.Location = New System.Drawing.Point(30, 365)
        Me.LblRecorrido.Name = "LblRecorrido"
        Me.LblRecorrido.Size = New System.Drawing.Size(85, 20)
        Me.LblRecorrido.TabIndex = 7
        Me.LblRecorrido.Text = "Recorrido"
        '
        'txcantidad
        '
        Me.txcantidad.Enabled = False
        Me.txcantidad.Location = New System.Drawing.Point(34, 501)
        Me.txcantidad.Name = "txcantidad"
        Me.txcantidad.Size = New System.Drawing.Size(90, 27)
        Me.txcantidad.TabIndex = 5
        '
        'txtcliente
        '
        Me.txtcliente.Enabled = False
        Me.txtcliente.Location = New System.Drawing.Point(34, 441)
        Me.txtcliente.Name = "txtcliente"
        Me.txtcliente.Size = New System.Drawing.Size(290, 27)
        Me.txtcliente.TabIndex = 4
        '
        'txtzona
        '
        Me.txtzona.Enabled = False
        Me.txtzona.Location = New System.Drawing.Point(338, 388)
        Me.txtzona.Name = "txtzona"
        Me.txtzona.Size = New System.Drawing.Size(135, 27)
        Me.txtzona.TabIndex = 3
        '
        'txcaminante
        '
        Me.txcaminante.Enabled = False
        Me.txcaminante.Location = New System.Drawing.Point(187, 388)
        Me.txcaminante.Name = "txcaminante"
        Me.txcaminante.Size = New System.Drawing.Size(135, 27)
        Me.txcaminante.TabIndex = 2
        '
        'txtrecorrido
        '
        Me.txtrecorrido.Enabled = False
        Me.txtrecorrido.Location = New System.Drawing.Point(34, 388)
        Me.txtrecorrido.Name = "txtrecorrido"
        Me.txtrecorrido.Size = New System.Drawing.Size(135, 27)
        Me.txtrecorrido.TabIndex = 1
        '
        'DgvContenido
        '
        Me.DgvContenido.AllowUserToAddRows = False
        Me.DgvContenido.AllowUserToDeleteRows = False
        Me.DgvContenido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvContenido.Location = New System.Drawing.Point(22, 34)
        Me.DgvContenido.Name = "DgvContenido"
        Me.DgvContenido.ReadOnly = True
        Me.DgvContenido.RowHeadersVisible = False
        Me.DgvContenido.Size = New System.Drawing.Size(650, 300)
        Me.DgvContenido.TabIndex = 0
        '
        'DtpFecha
        '
        Me.DtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFecha.Location = New System.Drawing.Point(31, 618)
        Me.DtpFecha.Name = "DtpFecha"
        Me.DtpFecha.Size = New System.Drawing.Size(100, 20)
        Me.DtpFecha.TabIndex = 58
        '
        'BtnImprimirPlanillasFecha
        '
        Me.BtnImprimirPlanillasFecha.Location = New System.Drawing.Point(137, 615)
        Me.BtnImprimirPlanillasFecha.Name = "BtnImprimirPlanillasFecha"
        Me.BtnImprimirPlanillasFecha.Size = New System.Drawing.Size(150, 30)
        Me.BtnImprimirPlanillasFecha.TabIndex = 59
        Me.BtnImprimirPlanillasFecha.Text = "Imprimir Planillas"
        Me.BtnImprimirPlanillasFecha.UseVisualStyleBackColor = True
        '
        'FrmImprimirPlanificacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1294, 712)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmImprimirPlanificacion"
        Me.Text = "Imprimir Planificacion"
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Gb.ResumeLayout(False)
        Me.GpbRecorridos.ResumeLayout(False)
        CType(Me.DgvRecorridos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GpbCartas.ResumeLayout(False)
        Me.GpbCartas.PerformLayout()
        CType(Me.DgvContenido, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GpbRecorridos As System.Windows.Forms.GroupBox
    Friend WithEvents DgvRecorridos As System.Windows.Forms.DataGridView
    Friend WithEvents GpbCartas As System.Windows.Forms.GroupBox
    Friend WithEvents DgvContenido As System.Windows.Forms.DataGridView
    Friend WithEvents DtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents BtnImpresion As System.Windows.Forms.Button
    Friend WithEvents BtnImprimirPlanillasFecha As System.Windows.Forms.Button
    Friend WithEvents LblRecorrido As System.Windows.Forms.Label
    Friend WithEvents txcantidad As System.Windows.Forms.TextBox
    Friend WithEvents txtcliente As System.Windows.Forms.TextBox
    Friend WithEvents txtzona As System.Windows.Forms.TextBox
    Friend WithEvents txcaminante As System.Windows.Forms.TextBox
    Friend WithEvents txtrecorrido As System.Windows.Forms.TextBox
    Friend WithEvents LblCantidad As System.Windows.Forms.Label
    Friend WithEvents Lblcliente As System.Windows.Forms.Label
    Friend WithEvents Lblzona As System.Windows.Forms.Label
    Friend WithEvents Lblcaminante As System.Windows.Forms.Label
    Friend WithEvents LblFecha As System.Windows.Forms.Label
    Friend WithEvents txtfecha As System.Windows.Forms.TextBox
    Friend WithEvents Nro_Recorrido_r As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cartero_r As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fecha_r As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Zona_r As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cantidad_r As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BtnCambiar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Cmbcambiar As System.Windows.Forms.ComboBox
    Friend WithEvents BtnImprimir As System.Windows.Forms.Button
    Friend WithEvents LblPLanillaImprimir As System.Windows.Forms.Label
    Friend WithEvents CmbRemitentes As System.Windows.Forms.ComboBox
    Friend WithEvents BtnAgregar As System.Windows.Forms.Button
    Friend WithEvents TxtNuevaCarta As System.Windows.Forms.TextBox
    Friend WithEvents BtnSubirRecorrido As System.Windows.Forms.Button

End Class
