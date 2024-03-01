<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmImprimir
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
        Me.LblCant = New System.Windows.Forms.Label
        Me.LblRemitente = New System.Windows.Forms.Label
        Me.CmbRemitente = New System.Windows.Forms.ComboBox
        Me.DgvImprimir = New System.Windows.Forms.DataGridView
        Me.LblPath = New System.Windows.Forms.Label
        Me.TxtPath = New System.Windows.Forms.TextBox
        Me.BtnSelectEtic = New System.Windows.Forms.Button
        Me.LblRemitoPendiente = New System.Windows.Forms.Label
        Me.CmbRemitoPendiente = New System.Windows.Forms.ComboBox
        Me.Btnimprimir = New System.Windows.Forms.Button
        Me.TxtFecha = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Gb.SuspendLayout()
        CType(Me.DgvImprimir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PBLogo
        '
        Me.PBLogo.Location = New System.Drawing.Point(5, 418)
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(651, 418)
        '
        'Gb
        '
        Me.Gb.Controls.Add(Me.Button1)
        Me.Gb.Controls.Add(Me.TxtFecha)
        Me.Gb.Controls.Add(Me.LblCant)
        Me.Gb.Controls.Add(Me.LblRemitente)
        Me.Gb.Controls.Add(Me.CmbRemitente)
        Me.Gb.Controls.Add(Me.DgvImprimir)
        Me.Gb.Controls.Add(Me.LblPath)
        Me.Gb.Controls.Add(Me.TxtPath)
        Me.Gb.Controls.Add(Me.BtnSelectEtic)
        Me.Gb.Controls.Add(Me.LblRemitoPendiente)
        Me.Gb.Controls.Add(Me.CmbRemitoPendiente)
        Me.Gb.Controls.Add(Me.Btnimprimir)
        Me.Gb.Location = New System.Drawing.Point(1, 1)
        Me.Gb.Size = New System.Drawing.Size(698, 469)
        Me.Gb.Controls.SetChildIndex(Me.PBLogo, 0)
        Me.Gb.Controls.SetChildIndex(Me.BtnSalir, 0)
        Me.Gb.Controls.SetChildIndex(Me.Btnimprimir, 0)
        Me.Gb.Controls.SetChildIndex(Me.CmbRemitoPendiente, 0)
        Me.Gb.Controls.SetChildIndex(Me.LblRemitoPendiente, 0)
        Me.Gb.Controls.SetChildIndex(Me.BtnSelectEtic, 0)
        Me.Gb.Controls.SetChildIndex(Me.TxtPath, 0)
        Me.Gb.Controls.SetChildIndex(Me.LblPath, 0)
        Me.Gb.Controls.SetChildIndex(Me.DgvImprimir, 0)
        Me.Gb.Controls.SetChildIndex(Me.CmbRemitente, 0)
        Me.Gb.Controls.SetChildIndex(Me.LblRemitente, 0)
        Me.Gb.Controls.SetChildIndex(Me.LblCant, 0)
        Me.Gb.Controls.SetChildIndex(Me.TxtFecha, 0)
        Me.Gb.Controls.SetChildIndex(Me.Button1, 0)
        '
        'LblCant
        '
        Me.LblCant.AutoSize = True
        Me.LblCant.Location = New System.Drawing.Point(648, 231)
        Me.LblCant.Name = "LblCant"
        Me.LblCant.Size = New System.Drawing.Size(13, 13)
        Me.LblCant.TabIndex = 40
        Me.LblCant.Text = "0"
        '
        'LblRemitente
        '
        Me.LblRemitente.AutoSize = True
        Me.LblRemitente.Location = New System.Drawing.Point(27, 16)
        Me.LblRemitente.Name = "LblRemitente"
        Me.LblRemitente.Size = New System.Drawing.Size(55, 13)
        Me.LblRemitente.TabIndex = 39
        Me.LblRemitente.Text = "Remitente"
        '
        'CmbRemitente
        '
        Me.CmbRemitente.FormattingEnabled = True
        Me.CmbRemitente.Location = New System.Drawing.Point(30, 36)
        Me.CmbRemitente.Name = "CmbRemitente"
        Me.CmbRemitente.Size = New System.Drawing.Size(108, 21)
        Me.CmbRemitente.TabIndex = 38
        '
        'DgvImprimir
        '
        Me.DgvImprimir.AllowUserToAddRows = False
        Me.DgvImprimir.AllowUserToDeleteRows = False
        Me.DgvImprimir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvImprimir.Location = New System.Drawing.Point(30, 63)
        Me.DgvImprimir.Name = "DgvImprimir"
        Me.DgvImprimir.ReadOnly = True
        Me.DgvImprimir.Size = New System.Drawing.Size(636, 145)
        Me.DgvImprimir.TabIndex = 37
        '
        'LblPath
        '
        Me.LblPath.AutoSize = True
        Me.LblPath.Location = New System.Drawing.Point(27, 217)
        Me.LblPath.Name = "LblPath"
        Me.LblPath.Size = New System.Drawing.Size(46, 13)
        Me.LblPath.TabIndex = 36
        Me.LblPath.Text = "Etiqueta"
        '
        'TxtPath
        '
        Me.TxtPath.Enabled = False
        Me.TxtPath.Location = New System.Drawing.Point(79, 214)
        Me.TxtPath.Name = "TxtPath"
        Me.TxtPath.Size = New System.Drawing.Size(373, 20)
        Me.TxtPath.TabIndex = 35
        '
        'BtnSelectEtic
        '
        Me.BtnSelectEtic.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnSelectEtic.Enabled = False
        Me.BtnSelectEtic.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnSelectEtic.Image = Global.Correo.My.Resources.Resources.filefind
        Me.BtnSelectEtic.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BtnSelectEtic.Location = New System.Drawing.Point(30, 244)
        Me.BtnSelectEtic.Name = "BtnSelectEtic"
        Me.BtnSelectEtic.Size = New System.Drawing.Size(108, 47)
        Me.BtnSelectEtic.TabIndex = 33
        Me.BtnSelectEtic.Text = "Seleccionar Etiqueta"
        Me.BtnSelectEtic.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSelectEtic.UseVisualStyleBackColor = True
        '
        'LblRemitoPendiente
        '
        Me.LblRemitoPendiente.AutoSize = True
        Me.LblRemitoPendiente.Location = New System.Drawing.Point(144, 16)
        Me.LblRemitoPendiente.Name = "LblRemitoPendiente"
        Me.LblRemitoPendiente.Size = New System.Drawing.Size(101, 13)
        Me.LblRemitoPendiente.TabIndex = 32
        Me.LblRemitoPendiente.Text = "Remitos Pendientes"
        '
        'CmbRemitoPendiente
        '
        Me.CmbRemitoPendiente.FormattingEnabled = True
        Me.CmbRemitoPendiente.Location = New System.Drawing.Point(148, 36)
        Me.CmbRemitoPendiente.Name = "CmbRemitoPendiente"
        Me.CmbRemitoPendiente.Size = New System.Drawing.Size(98, 21)
        Me.CmbRemitoPendiente.TabIndex = 31
        '
        'Btnimprimir
        '
        Me.Btnimprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Btnimprimir.Enabled = False
        Me.Btnimprimir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btnimprimir.Image = Global.Correo.My.Resources.Resources.Print
        Me.Btnimprimir.Location = New System.Drawing.Point(148, 244)
        Me.Btnimprimir.Name = "Btnimprimir"
        Me.Btnimprimir.Size = New System.Drawing.Size(38, 47)
        Me.Btnimprimir.TabIndex = 30
        Me.Btnimprimir.UseVisualStyleBackColor = True
        '
        'TxtFecha
        '
        Me.TxtFecha.Enabled = False
        Me.TxtFecha.Location = New System.Drawing.Point(592, 36)
        Me.TxtFecha.Name = "TxtFecha"
        Me.TxtFecha.Size = New System.Drawing.Size(74, 20)
        Me.TxtFecha.TabIndex = 41
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(342, 309)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 42
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FrmImprimir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(699, 471)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmImprimir"
        Me.Text = "Imprimir"
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Gb.ResumeLayout(False)
        Me.Gb.PerformLayout()
        CType(Me.DgvImprimir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LblCant As System.Windows.Forms.Label
    Friend WithEvents LblRemitente As System.Windows.Forms.Label
    Friend WithEvents CmbRemitente As System.Windows.Forms.ComboBox
    Friend WithEvents DgvImprimir As System.Windows.Forms.DataGridView
    Friend WithEvents LblPath As System.Windows.Forms.Label
    Friend WithEvents TxtPath As System.Windows.Forms.TextBox
    Friend WithEvents BtnSelectEtic As System.Windows.Forms.Button
    Friend WithEvents LblRemitoPendiente As System.Windows.Forms.Label
    Friend WithEvents CmbRemitoPendiente As System.Windows.Forms.ComboBox
    Friend WithEvents Btnimprimir As System.Windows.Forms.Button
    Friend WithEvents TxtFecha As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
