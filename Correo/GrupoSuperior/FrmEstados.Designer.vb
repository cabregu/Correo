<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEstados
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
        Me.BtnCalcular = New System.Windows.Forms.Button
        Me.BtnGenerar = New System.Windows.Forms.Button
        Me.Lblcantidad = New System.Windows.Forms.Label
        Me.DgvDatos = New System.Windows.Forms.DataGridView
        Me.Socio = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Lote = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Integrante = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.fech_trab = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.apellido = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.calle = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cp = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.localidad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.fech1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.tema1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.fech2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.tema2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.fecha_entr = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.nro_carta = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.remitente = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LblRecred = New System.Windows.Forms.Label
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Gb.SuspendLayout()
        CType(Me.DgvDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PBLogo
        '
        Me.PBLogo.Location = New System.Drawing.Point(5, 416)
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(650, 416)
        '
        'Gb
        '
        Me.Gb.BackColor = System.Drawing.Color.ForestGreen
        Me.Gb.Controls.Add(Me.LblRecred)
        Me.Gb.Controls.Add(Me.DgvDatos)
        Me.Gb.Controls.Add(Me.BtnCalcular)
        Me.Gb.Controls.Add(Me.Lblcantidad)
        Me.Gb.Controls.Add(Me.BtnGenerar)
        Me.Gb.Location = New System.Drawing.Point(1, 1)
        Me.Gb.Size = New System.Drawing.Size(697, 467)
        Me.Gb.Controls.SetChildIndex(Me.BtnGenerar, 0)
        Me.Gb.Controls.SetChildIndex(Me.Lblcantidad, 0)
        Me.Gb.Controls.SetChildIndex(Me.BtnCalcular, 0)
        Me.Gb.Controls.SetChildIndex(Me.PBLogo, 0)
        Me.Gb.Controls.SetChildIndex(Me.BtnSalir, 0)
        Me.Gb.Controls.SetChildIndex(Me.DgvDatos, 0)
        Me.Gb.Controls.SetChildIndex(Me.LblRecred, 0)
        '
        'BtnCalcular
        '
        Me.BtnCalcular.Location = New System.Drawing.Point(11, 17)
        Me.BtnCalcular.Name = "BtnCalcular"
        Me.BtnCalcular.Size = New System.Drawing.Size(125, 23)
        Me.BtnCalcular.TabIndex = 30
        Me.BtnCalcular.Text = "Calcular Entregadas" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.BtnCalcular.UseVisualStyleBackColor = True
        '
        'BtnGenerar
        '
        Me.BtnGenerar.Location = New System.Drawing.Point(11, 369)
        Me.BtnGenerar.Name = "BtnGenerar"
        Me.BtnGenerar.Size = New System.Drawing.Size(150, 23)
        Me.BtnGenerar.TabIndex = 31
        Me.BtnGenerar.Text = "Generar y Enviar"
        Me.BtnGenerar.UseVisualStyleBackColor = True
        '
        'Lblcantidad
        '
        Me.Lblcantidad.AutoSize = True
        Me.Lblcantidad.Location = New System.Drawing.Point(673, 379)
        Me.Lblcantidad.Name = "Lblcantidad"
        Me.Lblcantidad.Size = New System.Drawing.Size(13, 13)
        Me.Lblcantidad.TabIndex = 32
        Me.Lblcantidad.Text = "0"
        '
        'DgvDatos
        '
        Me.DgvDatos.AllowUserToAddRows = False
        Me.DgvDatos.AllowUserToDeleteRows = False
        Me.DgvDatos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Socio, Me.Lote, Me.Integrante, Me.fech_trab, Me.apellido, Me.calle, Me.cp, Me.localidad, Me.fech1, Me.tema1, Me.fech2, Me.tema2, Me.fecha_entr, Me.nro_carta, Me.remitente})
        Me.DgvDatos.Cursor = System.Windows.Forms.Cursors.Default
        Me.DgvDatos.Location = New System.Drawing.Point(11, 45)
        Me.DgvDatos.Name = "DgvDatos"
        Me.DgvDatos.ReadOnly = True
        Me.DgvDatos.RowHeadersVisible = False
        Me.DgvDatos.Size = New System.Drawing.Size(675, 318)
        Me.DgvDatos.TabIndex = 38
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
        'fecha_entr
        '
        Me.fecha_entr.HeaderText = "fecha_entr"
        Me.fecha_entr.Name = "fecha_entr"
        Me.fecha_entr.ReadOnly = True
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
        'LblRecred
        '
        Me.LblRecred.AutoSize = True
        Me.LblRecred.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblRecred.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRecred.Location = New System.Drawing.Point(296, 16)
        Me.LblRecred.Name = "LblRecred"
        Me.LblRecred.Size = New System.Drawing.Size(89, 22)
        Me.LblRecred.TabIndex = 40
        Me.LblRecred.Text = "SWRECR"
        '
        'FrmEstados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(699, 471)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmEstados"
        Me.Text = "Estados"
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Gb.ResumeLayout(False)
        Me.Gb.PerformLayout()
        CType(Me.DgvDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnCalcular As System.Windows.Forms.Button
    Friend WithEvents BtnGenerar As System.Windows.Forms.Button
    Friend WithEvents Lblcantidad As System.Windows.Forms.Label
    Friend WithEvents DgvDatos As System.Windows.Forms.DataGridView
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
    Friend WithEvents LblRecred As System.Windows.Forms.Label

End Class
