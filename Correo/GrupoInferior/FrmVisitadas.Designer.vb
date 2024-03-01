<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVisitadas
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
        Me.DgvVisitadas = New System.Windows.Forms.DataGridView()
        Me.Socio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Lote = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Integrante = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fech_trab = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.calle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.localidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fech1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tema1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fech2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tema2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nro_carta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.remitente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Empresa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnCalcular = New System.Windows.Forms.Button()
        Me.BtnGeneraryenviar = New System.Windows.Forms.Button()
        Me.Lblcantidad = New System.Windows.Forms.Label()
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Gb.SuspendLayout()
        CType(Me.DgvVisitadas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PBLogo
        '
        Me.PBLogo.Location = New System.Drawing.Point(5, 661)
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(1118, 661)
        '
        'Gb
        '
        Me.Gb.Controls.Add(Me.DgvVisitadas)
        Me.Gb.Controls.Add(Me.BtnGeneraryenviar)
        Me.Gb.Controls.Add(Me.BtnCalcular)
        Me.Gb.Controls.Add(Me.Lblcantidad)
        Me.Gb.Location = New System.Drawing.Point(0, 0)
        Me.Gb.Size = New System.Drawing.Size(1165, 712)
        Me.Gb.Controls.SetChildIndex(Me.Lblcantidad, 0)
        Me.Gb.Controls.SetChildIndex(Me.BtnCalcular, 0)
        Me.Gb.Controls.SetChildIndex(Me.BtnGeneraryenviar, 0)
        Me.Gb.Controls.SetChildIndex(Me.DgvVisitadas, 0)
        Me.Gb.Controls.SetChildIndex(Me.PBLogo, 0)
        Me.Gb.Controls.SetChildIndex(Me.BtnSalir, 0)
        '
        'DgvVisitadas
        '
        Me.DgvVisitadas.AllowUserToAddRows = False
        Me.DgvVisitadas.AllowUserToDeleteRows = False
        Me.DgvVisitadas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DgvVisitadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvVisitadas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Socio, Me.Lote, Me.Integrante, Me.fech_trab, Me.apellido, Me.calle, Me.cp, Me.localidad, Me.fech1, Me.tema1, Me.fech2, Me.tema2, Me.nro_carta, Me.remitente, Me.Empresa})
        Me.DgvVisitadas.Cursor = System.Windows.Forms.Cursors.Default
        Me.DgvVisitadas.Location = New System.Drawing.Point(10, 39)
        Me.DgvVisitadas.Name = "DgvVisitadas"
        Me.DgvVisitadas.ReadOnly = True
        Me.DgvVisitadas.RowHeadersVisible = False
        Me.DgvVisitadas.Size = New System.Drawing.Size(834, 321)
        Me.DgvVisitadas.TabIndex = 31
        '
        'Socio
        '
        Me.Socio.HeaderText = "Socio"
        Me.Socio.Name = "Socio"
        Me.Socio.ReadOnly = True
        '
        'Lote
        '
        Me.Lote.HeaderText = "Lote"
        Me.Lote.Name = "Lote"
        Me.Lote.ReadOnly = True
        '
        'Integrante
        '
        Me.Integrante.HeaderText = "Integrante"
        Me.Integrante.Name = "Integrante"
        Me.Integrante.ReadOnly = True
        '
        'fech_trab
        '
        Me.fech_trab.HeaderText = "fech_trab"
        Me.fech_trab.Name = "fech_trab"
        Me.fech_trab.ReadOnly = True
        '
        'apellido
        '
        Me.apellido.HeaderText = "apellido"
        Me.apellido.Name = "apellido"
        Me.apellido.ReadOnly = True
        '
        'calle
        '
        Me.calle.HeaderText = "calle"
        Me.calle.Name = "calle"
        Me.calle.ReadOnly = True
        '
        'cp
        '
        Me.cp.HeaderText = "cp"
        Me.cp.Name = "cp"
        Me.cp.ReadOnly = True
        '
        'localidad
        '
        Me.localidad.HeaderText = "localidad"
        Me.localidad.Name = "localidad"
        Me.localidad.ReadOnly = True
        '
        'fech1
        '
        Me.fech1.HeaderText = "fech1"
        Me.fech1.Name = "fech1"
        Me.fech1.ReadOnly = True
        '
        'tema1
        '
        Me.tema1.HeaderText = "tema1"
        Me.tema1.Name = "tema1"
        Me.tema1.ReadOnly = True
        '
        'fech2
        '
        Me.fech2.HeaderText = "fech2"
        Me.fech2.Name = "fech2"
        Me.fech2.ReadOnly = True
        '
        'tema2
        '
        Me.tema2.HeaderText = "tema2"
        Me.tema2.Name = "tema2"
        Me.tema2.ReadOnly = True
        '
        'nro_carta
        '
        Me.nro_carta.HeaderText = "nro_carta"
        Me.nro_carta.Name = "nro_carta"
        Me.nro_carta.ReadOnly = True
        '
        'remitente
        '
        Me.remitente.HeaderText = "remitente"
        Me.remitente.Name = "remitente"
        Me.remitente.ReadOnly = True
        '
        'Empresa
        '
        Me.Empresa.HeaderText = "Empresa"
        Me.Empresa.Name = "Empresa"
        Me.Empresa.ReadOnly = True
        Me.Empresa.Visible = False
        '
        'BtnCalcular
        '
        Me.BtnCalcular.Location = New System.Drawing.Point(12, 12)
        Me.BtnCalcular.Name = "BtnCalcular"
        Me.BtnCalcular.Size = New System.Drawing.Size(226, 23)
        Me.BtnCalcular.TabIndex = 32
        Me.BtnCalcular.Text = "Calcular Visitadas"
        Me.BtnCalcular.UseVisualStyleBackColor = True
        '
        'BtnGeneraryenviar
        '
        Me.BtnGeneraryenviar.Location = New System.Drawing.Point(10, 366)
        Me.BtnGeneraryenviar.Name = "BtnGeneraryenviar"
        Me.BtnGeneraryenviar.Size = New System.Drawing.Size(134, 23)
        Me.BtnGeneraryenviar.TabIndex = 33
        Me.BtnGeneraryenviar.Text = "Generar y Enviar"
        Me.BtnGeneraryenviar.UseVisualStyleBackColor = True
        '
        'Lblcantidad
        '
        Me.Lblcantidad.AutoSize = True
        Me.Lblcantidad.Location = New System.Drawing.Point(815, 371)
        Me.Lblcantidad.Name = "Lblcantidad"
        Me.Lblcantidad.Size = New System.Drawing.Size(29, 13)
        Me.Lblcantidad.TabIndex = 34
        Me.Lblcantidad.Text = "Cant"
        '
        'FrmVisitadas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1166, 712)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmVisitadas"
        Me.Text = "Visitadas"
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Gb.ResumeLayout(False)
        Me.Gb.PerformLayout()
        CType(Me.DgvVisitadas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnCalcular As System.Windows.Forms.Button
    Friend WithEvents DgvVisitadas As System.Windows.Forms.DataGridView
    Friend WithEvents BtnGeneraryenviar As System.Windows.Forms.Button
    Friend WithEvents Lblcantidad As System.Windows.Forms.Label
    Friend WithEvents Socio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Lote As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Integrante As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fech_trab As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents apellido As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents calle As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents localidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fech1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tema1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fech2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tema2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nro_carta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents remitente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Empresa As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
