<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEntregadas
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
        Me.Lblcantidad = New System.Windows.Forms.Label()
        Me.BtnCalcular = New System.Windows.Forms.Button()
        Me.DgvEntregadas = New System.Windows.Forms.DataGridView()
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
        Me.fecha_entr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nro_carta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.remitente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.interno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Diferencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnGeneraryenviar = New System.Windows.Forms.Button()
        Me.ChkAyudaAdmin = New System.Windows.Forms.CheckBox()
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Gb.SuspendLayout()
        CType(Me.DgvEntregadas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PBLogo
        '
        Me.PBLogo.Location = New System.Drawing.Point(5, 643)
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(852, 643)
        '
        'Gb
        '
        Me.Gb.Controls.Add(Me.Lblcantidad)
        Me.Gb.Controls.Add(Me.BtnGeneraryenviar)
        Me.Gb.Controls.Add(Me.ChkAyudaAdmin)
        Me.Gb.Controls.Add(Me.BtnCalcular)
        Me.Gb.Controls.Add(Me.DgvEntregadas)
        Me.Gb.Location = New System.Drawing.Point(1, -1)
        Me.Gb.Size = New System.Drawing.Size(899, 694)
        Me.Gb.Controls.SetChildIndex(Me.DgvEntregadas, 0)
        Me.Gb.Controls.SetChildIndex(Me.BtnCalcular, 0)
        Me.Gb.Controls.SetChildIndex(Me.ChkAyudaAdmin, 0)
        Me.Gb.Controls.SetChildIndex(Me.BtnGeneraryenviar, 0)
        Me.Gb.Controls.SetChildIndex(Me.PBLogo, 0)
        Me.Gb.Controls.SetChildIndex(Me.Lblcantidad, 0)
        Me.Gb.Controls.SetChildIndex(Me.BtnSalir, 0)
        '
        'Lblcantidad
        '
        Me.Lblcantidad.AutoSize = True
        Me.Lblcantidad.Location = New System.Drawing.Point(633, 371)
        Me.Lblcantidad.Name = "Lblcantidad"
        Me.Lblcantidad.Size = New System.Drawing.Size(29, 13)
        Me.Lblcantidad.TabIndex = 40
        Me.Lblcantidad.Text = "Cant"
        '
        'BtnCalcular
        '
        Me.BtnCalcular.Location = New System.Drawing.Point(11, 13)
        Me.BtnCalcular.Name = "BtnCalcular"
        Me.BtnCalcular.Size = New System.Drawing.Size(208, 23)
        Me.BtnCalcular.TabIndex = 38
        Me.BtnCalcular.Text = "Calcular Entregadas"
        Me.BtnCalcular.UseVisualStyleBackColor = True
        '
        'DgvEntregadas
        '
        Me.DgvEntregadas.AllowUserToAddRows = False
        Me.DgvEntregadas.AllowUserToDeleteRows = False
        Me.DgvEntregadas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DgvEntregadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvEntregadas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Socio, Me.Lote, Me.Integrante, Me.fech_trab, Me.apellido, Me.calle, Me.cp, Me.localidad, Me.fech1, Me.tema1, Me.fech2, Me.tema2, Me.fecha_entr, Me.nro_carta, Me.remitente, Me.interno, Me.Diferencia})
        Me.DgvEntregadas.Cursor = System.Windows.Forms.Cursors.Default
        Me.DgvEntregadas.Location = New System.Drawing.Point(11, 42)
        Me.DgvEntregadas.Name = "DgvEntregadas"
        Me.DgvEntregadas.RowHeadersVisible = False
        Me.DgvEntregadas.Size = New System.Drawing.Size(675, 318)
        Me.DgvEntregadas.TabIndex = 37
        '
        'Socio
        '
        Me.Socio.HeaderText = "Socio"
        Me.Socio.Name = "Socio"
        '
        'Lote
        '
        Me.Lote.HeaderText = "Lote"
        Me.Lote.Name = "Lote"
        '
        'Integrante
        '
        Me.Integrante.HeaderText = "Integrante"
        Me.Integrante.Name = "Integrante"
        '
        'fech_trab
        '
        Me.fech_trab.HeaderText = "fech_trab"
        Me.fech_trab.Name = "fech_trab"
        '
        'apellido
        '
        Me.apellido.HeaderText = "apellido"
        Me.apellido.Name = "apellido"
        '
        'calle
        '
        Me.calle.HeaderText = "calle"
        Me.calle.Name = "calle"
        '
        'cp
        '
        Me.cp.HeaderText = "cp"
        Me.cp.Name = "cp"
        '
        'localidad
        '
        Me.localidad.HeaderText = "localidad"
        Me.localidad.Name = "localidad"
        '
        'fech1
        '
        Me.fech1.HeaderText = "fech1"
        Me.fech1.Name = "fech1"
        '
        'tema1
        '
        Me.tema1.HeaderText = "tema1"
        Me.tema1.Name = "tema1"
        '
        'fech2
        '
        Me.fech2.HeaderText = "fech2"
        Me.fech2.Name = "fech2"
        '
        'tema2
        '
        Me.tema2.HeaderText = "tema2"
        Me.tema2.Name = "tema2"
        '
        'fecha_entr
        '
        Me.fecha_entr.HeaderText = "fecha_entr"
        Me.fecha_entr.Name = "fecha_entr"
        '
        'nro_carta
        '
        Me.nro_carta.HeaderText = "nro_carta"
        Me.nro_carta.Name = "nro_carta"
        '
        'remitente
        '
        Me.remitente.HeaderText = "remitente"
        Me.remitente.Name = "remitente"
        '
        'interno
        '
        Me.interno.HeaderText = "Interno"
        Me.interno.Name = "interno"
        '
        'Diferencia
        '
        Me.Diferencia.HeaderText = "Diferencia"
        Me.Diferencia.Name = "Diferencia"
        '
        'BtnGeneraryenviar
        '
        Me.BtnGeneraryenviar.Location = New System.Drawing.Point(11, 366)
        Me.BtnGeneraryenviar.Name = "BtnGeneraryenviar"
        Me.BtnGeneraryenviar.Size = New System.Drawing.Size(134, 23)
        Me.BtnGeneraryenviar.TabIndex = 39
        Me.BtnGeneraryenviar.Text = "Generar"
        Me.BtnGeneraryenviar.UseVisualStyleBackColor = True
        '
        'ChkAyudaAdmin
        '
        Me.ChkAyudaAdmin.AutoSize = True
        Me.ChkAyudaAdmin.Location = New System.Drawing.Point(151, 372)
        Me.ChkAyudaAdmin.Name = "ChkAyudaAdmin"
        Me.ChkAyudaAdmin.Size = New System.Drawing.Size(148, 17)
        Me.ChkAyudaAdmin.TabIndex = 41
        Me.ChkAyudaAdmin.Text = "Con Deteccion de Errores"
        Me.ChkAyudaAdmin.UseVisualStyleBackColor = True
        '
        'FrmEntregadas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(902, 695)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmEntregadas"
        Me.Text = "Entregadas"
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Gb.ResumeLayout(False)
        Me.Gb.PerformLayout()
        CType(Me.DgvEntregadas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Lblcantidad As System.Windows.Forms.Label
    Friend WithEvents BtnGeneraryenviar As System.Windows.Forms.Button
    Friend WithEvents BtnCalcular As System.Windows.Forms.Button
    Friend WithEvents DgvEntregadas As System.Windows.Forms.DataGridView
    Friend WithEvents ChkAyudaAdmin As System.Windows.Forms.CheckBox
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
    Friend WithEvents fecha_entr As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nro_carta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents remitente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents interno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Diferencia As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
