<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRefeenciado
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
        Me.LblCant = New System.Windows.Forms.Label()
        Me.LblRemitente = New System.Windows.Forms.Label()
        Me.CmbRemitente = New System.Windows.Forms.ComboBox()
        Me.LblRemitoPendiente = New System.Windows.Forms.Label()
        Me.CmbRemitoPendiente = New System.Windows.Forms.ComboBox()
        Me.LblReferenciado = New System.Windows.Forms.Label()
        Me.DgvImprimir = New System.Windows.Forms.DataGridView()
        Me.LblPath = New System.Windows.Forms.Label()
        Me.TxtPath = New System.Windows.Forms.TextBox()
        Me.BtnSelectEtic = New System.Windows.Forms.Button()
        Me.Btnimprimir = New System.Windows.Forms.Button()
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Gb.SuspendLayout()
        CType(Me.DgvImprimir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PBLogo
        '
        Me.PBLogo.Location = New System.Drawing.Point(5, 479)
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(975, 479)
        '
        'Gb
        '
        Me.Gb.Controls.Add(Me.LblCant)
        Me.Gb.Controls.Add(Me.LblRemitente)
        Me.Gb.Controls.Add(Me.CmbRemitente)
        Me.Gb.Controls.Add(Me.DgvImprimir)
        Me.Gb.Controls.Add(Me.LblRemitoPendiente)
        Me.Gb.Controls.Add(Me.Btnimprimir)
        Me.Gb.Controls.Add(Me.CmbRemitoPendiente)
        Me.Gb.Controls.Add(Me.BtnSelectEtic)
        Me.Gb.Controls.Add(Me.LblReferenciado)
        Me.Gb.Controls.Add(Me.TxtPath)
        Me.Gb.Controls.Add(Me.LblPath)
        Me.Gb.Size = New System.Drawing.Size(1022, 530)
        Me.Gb.Controls.SetChildIndex(Me.LblPath, 0)
        Me.Gb.Controls.SetChildIndex(Me.TxtPath, 0)
        Me.Gb.Controls.SetChildIndex(Me.LblReferenciado, 0)
        Me.Gb.Controls.SetChildIndex(Me.BtnSelectEtic, 0)
        Me.Gb.Controls.SetChildIndex(Me.CmbRemitoPendiente, 0)
        Me.Gb.Controls.SetChildIndex(Me.Btnimprimir, 0)
        Me.Gb.Controls.SetChildIndex(Me.LblRemitoPendiente, 0)
        Me.Gb.Controls.SetChildIndex(Me.DgvImprimir, 0)
        Me.Gb.Controls.SetChildIndex(Me.CmbRemitente, 0)
        Me.Gb.Controls.SetChildIndex(Me.PBLogo, 0)
        Me.Gb.Controls.SetChildIndex(Me.LblRemitente, 0)
        Me.Gb.Controls.SetChildIndex(Me.BtnSalir, 0)
        Me.Gb.Controls.SetChildIndex(Me.LblCant, 0)
        '
        'LblCant
        '
        Me.LblCant.AutoSize = True
        Me.LblCant.Location = New System.Drawing.Point(25, 476)
        Me.LblCant.Name = "LblCant"
        Me.LblCant.Size = New System.Drawing.Size(13, 13)
        Me.LblCant.TabIndex = 52
        Me.LblCant.Text = "0"
        '
        'LblRemitente
        '
        Me.LblRemitente.AutoSize = True
        Me.LblRemitente.Location = New System.Drawing.Point(33, 26)
        Me.LblRemitente.Name = "LblRemitente"
        Me.LblRemitente.Size = New System.Drawing.Size(55, 13)
        Me.LblRemitente.TabIndex = 51
        Me.LblRemitente.Text = "Remitente"
        '
        'CmbRemitente
        '
        Me.CmbRemitente.FormattingEnabled = True
        Me.CmbRemitente.Location = New System.Drawing.Point(36, 46)
        Me.CmbRemitente.Name = "CmbRemitente"
        Me.CmbRemitente.Size = New System.Drawing.Size(118, 21)
        Me.CmbRemitente.TabIndex = 50
        '
        'LblRemitoPendiente
        '
        Me.LblRemitoPendiente.AutoSize = True
        Me.LblRemitoPendiente.Location = New System.Drawing.Point(189, 26)
        Me.LblRemitoPendiente.Name = "LblRemitoPendiente"
        Me.LblRemitoPendiente.Size = New System.Drawing.Size(101, 13)
        Me.LblRemitoPendiente.TabIndex = 49
        Me.LblRemitoPendiente.Text = "Remitos Pendientes"
        '
        'CmbRemitoPendiente
        '
        Me.CmbRemitoPendiente.FormattingEnabled = True
        Me.CmbRemitoPendiente.Location = New System.Drawing.Point(192, 46)
        Me.CmbRemitoPendiente.Name = "CmbRemitoPendiente"
        Me.CmbRemitoPendiente.Size = New System.Drawing.Size(117, 21)
        Me.CmbRemitoPendiente.TabIndex = 48
        '
        'LblReferenciado
        '
        Me.LblReferenciado.AutoSize = True
        Me.LblReferenciado.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblReferenciado.Location = New System.Drawing.Point(716, 16)
        Me.LblReferenciado.Name = "LblReferenciado"
        Me.LblReferenciado.Size = New System.Drawing.Size(269, 37)
        Me.LblReferenciado.TabIndex = 47
        Me.LblReferenciado.Text = "REFERENCIADO"
        '
        'DgvImprimir
        '
        Me.DgvImprimir.AllowUserToAddRows = False
        Me.DgvImprimir.AllowUserToDeleteRows = False
        Me.DgvImprimir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvImprimir.Location = New System.Drawing.Point(25, 153)
        Me.DgvImprimir.Name = "DgvImprimir"
        Me.DgvImprimir.ReadOnly = True
        Me.DgvImprimir.Size = New System.Drawing.Size(889, 320)
        Me.DgvImprimir.TabIndex = 46
        '
        'LblPath
        '
        Me.LblPath.AutoSize = True
        Me.LblPath.Location = New System.Drawing.Point(33, 89)
        Me.LblPath.Name = "LblPath"
        Me.LblPath.Size = New System.Drawing.Size(46, 13)
        Me.LblPath.TabIndex = 45
        Me.LblPath.Text = "Etiqueta"
        '
        'TxtPath
        '
        Me.TxtPath.Enabled = False
        Me.TxtPath.Location = New System.Drawing.Point(36, 105)
        Me.TxtPath.Name = "TxtPath"
        Me.TxtPath.Size = New System.Drawing.Size(273, 20)
        Me.TxtPath.TabIndex = 44
        '
        'BtnSelectEtic
        '
        Me.BtnSelectEtic.Enabled = False
        Me.BtnSelectEtic.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnSelectEtic.Image = Global.Correo.My.Resources.Resources.filefind
        Me.BtnSelectEtic.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BtnSelectEtic.Location = New System.Drawing.Point(343, 91)
        Me.BtnSelectEtic.Name = "BtnSelectEtic"
        Me.BtnSelectEtic.Size = New System.Drawing.Size(150, 47)
        Me.BtnSelectEtic.TabIndex = 43
        Me.BtnSelectEtic.Text = "Seleccionar Etiqueta"
        Me.BtnSelectEtic.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSelectEtic.UseVisualStyleBackColor = True
        '
        'Btnimprimir
        '
        Me.Btnimprimir.Enabled = False
        Me.Btnimprimir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btnimprimir.Image = Global.Correo.My.Resources.Resources.Print
        Me.Btnimprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btnimprimir.Location = New System.Drawing.Point(499, 91)
        Me.Btnimprimir.Name = "Btnimprimir"
        Me.Btnimprimir.Size = New System.Drawing.Size(159, 47)
        Me.Btnimprimir.TabIndex = 42
        Me.Btnimprimir.Text = "   Imprimir"
        Me.Btnimprimir.UseVisualStyleBackColor = True
        '
        'FrmRefeenciado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1022, 529)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmRefeenciado"
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Gb.ResumeLayout(False)
        Me.Gb.PerformLayout()
        CType(Me.DgvImprimir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LblCant As Label
    Friend WithEvents LblRemitente As Label
    Friend WithEvents CmbRemitente As ComboBox
    Friend WithEvents DgvImprimir As DataGridView
    Friend WithEvents LblRemitoPendiente As Label
    Friend WithEvents Btnimprimir As Button
    Friend WithEvents CmbRemitoPendiente As ComboBox
    Friend WithEvents BtnSelectEtic As Button
    Friend WithEvents LblReferenciado As Label
    Friend WithEvents TxtPath As TextBox
    Friend WithEvents LblPath As Label
End Class
