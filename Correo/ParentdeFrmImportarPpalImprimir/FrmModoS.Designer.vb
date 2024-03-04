<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmModoS
    Inherits Correo.FrmPlantilla

    'Form invalida a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.DgvImprimir = New System.Windows.Forms.DataGridView()
        Me.LblPath = New System.Windows.Forms.Label()
        Me.TxtPath = New System.Windows.Forms.TextBox()
        Me.BtnSelectEtic = New System.Windows.Forms.Button()
        Me.Btnimprimir = New System.Windows.Forms.Button()
        Me.LblModoS = New System.Windows.Forms.Label()
        Me.LblRemitente = New System.Windows.Forms.Label()
        Me.CmbRemitente = New System.Windows.Forms.ComboBox()
        Me.LblRemitoPendiente = New System.Windows.Forms.Label()
        Me.CmbRemitoPendiente = New System.Windows.Forms.ComboBox()
        Me.LblCant = New System.Windows.Forms.Label()
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Gb.SuspendLayout()
        CType(Me.DgvImprimir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PBLogo
        '
        Me.PBLogo.Location = New System.Drawing.Point(5, 527)
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(926, 527)
        '
        'Gb
        '
        Me.Gb.BackColor = System.Drawing.Color.Khaki
        Me.Gb.Controls.Add(Me.LblCant)
        Me.Gb.Controls.Add(Me.LblRemitente)
        Me.Gb.Controls.Add(Me.CmbRemitente)
        Me.Gb.Controls.Add(Me.LblRemitoPendiente)
        Me.Gb.Controls.Add(Me.CmbRemitoPendiente)
        Me.Gb.Controls.Add(Me.LblModoS)
        Me.Gb.Controls.Add(Me.DgvImprimir)
        Me.Gb.Controls.Add(Me.LblPath)
        Me.Gb.Controls.Add(Me.TxtPath)
        Me.Gb.Controls.Add(Me.BtnSelectEtic)
        Me.Gb.Controls.Add(Me.Btnimprimir)
        Me.Gb.Size = New System.Drawing.Size(973, 578)
        Me.Gb.Controls.SetChildIndex(Me.PBLogo, 0)
        Me.Gb.Controls.SetChildIndex(Me.BtnSalir, 0)
        Me.Gb.Controls.SetChildIndex(Me.Btnimprimir, 0)
        Me.Gb.Controls.SetChildIndex(Me.BtnSelectEtic, 0)
        Me.Gb.Controls.SetChildIndex(Me.TxtPath, 0)
        Me.Gb.Controls.SetChildIndex(Me.LblPath, 0)
        Me.Gb.Controls.SetChildIndex(Me.DgvImprimir, 0)
        Me.Gb.Controls.SetChildIndex(Me.LblModoS, 0)
        Me.Gb.Controls.SetChildIndex(Me.CmbRemitoPendiente, 0)
        Me.Gb.Controls.SetChildIndex(Me.LblRemitoPendiente, 0)
        Me.Gb.Controls.SetChildIndex(Me.CmbRemitente, 0)
        Me.Gb.Controls.SetChildIndex(Me.LblRemitente, 0)
        Me.Gb.Controls.SetChildIndex(Me.LblCant, 0)
        '
        'DgvImprimir
        '
        Me.DgvImprimir.AllowUserToAddRows = False
        Me.DgvImprimir.AllowUserToDeleteRows = False
        Me.DgvImprimir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvImprimir.Location = New System.Drawing.Point(12, 141)
        Me.DgvImprimir.Name = "DgvImprimir"
        Me.DgvImprimir.ReadOnly = True
        Me.DgvImprimir.Size = New System.Drawing.Size(889, 320)
        Me.DgvImprimir.TabIndex = 35
        '
        'LblPath
        '
        Me.LblPath.AutoSize = True
        Me.LblPath.Location = New System.Drawing.Point(20, 77)
        Me.LblPath.Name = "LblPath"
        Me.LblPath.Size = New System.Drawing.Size(46, 13)
        Me.LblPath.TabIndex = 34
        Me.LblPath.Text = "Etiqueta"
        '
        'TxtPath
        '
        Me.TxtPath.Enabled = False
        Me.TxtPath.Location = New System.Drawing.Point(23, 93)
        Me.TxtPath.Name = "TxtPath"
        Me.TxtPath.Size = New System.Drawing.Size(273, 20)
        Me.TxtPath.TabIndex = 33
        '
        'BtnSelectEtic
        '
        Me.BtnSelectEtic.Enabled = False
        Me.BtnSelectEtic.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnSelectEtic.Image = Global.Correo.My.Resources.Resources.filefind
        Me.BtnSelectEtic.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BtnSelectEtic.Location = New System.Drawing.Point(330, 79)
        Me.BtnSelectEtic.Name = "BtnSelectEtic"
        Me.BtnSelectEtic.Size = New System.Drawing.Size(150, 47)
        Me.BtnSelectEtic.TabIndex = 32
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
        Me.Btnimprimir.Location = New System.Drawing.Point(486, 79)
        Me.Btnimprimir.Name = "Btnimprimir"
        Me.Btnimprimir.Size = New System.Drawing.Size(159, 47)
        Me.Btnimprimir.TabIndex = 29
        Me.Btnimprimir.Text = "   Imprimir"
        Me.Btnimprimir.UseVisualStyleBackColor = True
        '
        'LblModoS
        '
        Me.LblModoS.AutoSize = True
        Me.LblModoS.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblModoS.Location = New System.Drawing.Point(785, 11)
        Me.LblModoS.Name = "LblModoS"
        Me.LblModoS.Size = New System.Drawing.Size(127, 37)
        Me.LblModoS.TabIndex = 36
        Me.LblModoS.Text = "Modo S"
        '
        'LblRemitente
        '
        Me.LblRemitente.AutoSize = True
        Me.LblRemitente.Location = New System.Drawing.Point(20, 14)
        Me.LblRemitente.Name = "LblRemitente"
        Me.LblRemitente.Size = New System.Drawing.Size(55, 13)
        Me.LblRemitente.TabIndex = 40
        Me.LblRemitente.Text = "Remitente"
        '
        'CmbRemitente
        '
        Me.CmbRemitente.FormattingEnabled = True
        Me.CmbRemitente.Location = New System.Drawing.Point(23, 34)
        Me.CmbRemitente.Name = "CmbRemitente"
        Me.CmbRemitente.Size = New System.Drawing.Size(118, 21)
        Me.CmbRemitente.TabIndex = 39
        '
        'LblRemitoPendiente
        '
        Me.LblRemitoPendiente.AutoSize = True
        Me.LblRemitoPendiente.Location = New System.Drawing.Point(176, 14)
        Me.LblRemitoPendiente.Name = "LblRemitoPendiente"
        Me.LblRemitoPendiente.Size = New System.Drawing.Size(101, 13)
        Me.LblRemitoPendiente.TabIndex = 38
        Me.LblRemitoPendiente.Text = "Remitos Pendientes"
        '
        'CmbRemitoPendiente
        '
        Me.CmbRemitoPendiente.FormattingEnabled = True
        Me.CmbRemitoPendiente.Location = New System.Drawing.Point(179, 34)
        Me.CmbRemitoPendiente.Name = "CmbRemitoPendiente"
        Me.CmbRemitoPendiente.Size = New System.Drawing.Size(117, 21)
        Me.CmbRemitoPendiente.TabIndex = 37
        '
        'LblCant
        '
        Me.LblCant.AutoSize = True
        Me.LblCant.Location = New System.Drawing.Point(12, 464)
        Me.LblCant.Name = "LblCant"
        Me.LblCant.Size = New System.Drawing.Size(13, 13)
        Me.LblCant.TabIndex = 41
        Me.LblCant.Text = "0"
        '
        'FrmModoS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(973, 577)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmModoS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Normal
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Gb.ResumeLayout(False)
        Me.Gb.PerformLayout()
        CType(Me.DgvImprimir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LblModoS As Label
    Friend WithEvents DgvImprimir As DataGridView
    Friend WithEvents LblPath As Label
    Friend WithEvents TxtPath As TextBox
    Friend WithEvents BtnSelectEtic As Button
    Friend WithEvents Btnimprimir As Button
    Friend WithEvents LblRemitente As Label
    Friend WithEvents CmbRemitente As ComboBox
    Friend WithEvents LblRemitoPendiente As Label
    Friend WithEvents CmbRemitoPendiente As ComboBox
    Friend WithEvents LblCant As Label
End Class
