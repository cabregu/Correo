<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmimprimirEtiqueta
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.CmbRemitoPendiente = New System.Windows.Forms.ComboBox()
        Me.LblRemitoPendiente = New System.Windows.Forms.Label()
        Me.TxtPath = New System.Windows.Forms.TextBox()
        Me.LblPath = New System.Windows.Forms.Label()
        Me.DgvImprimir = New System.Windows.Forms.DataGridView()
        Me.LblRemitente = New System.Windows.Forms.Label()
        Me.CmbRemitente = New System.Windows.Forms.ComboBox()
        Me.LblCant = New System.Windows.Forms.Label()
        Me.BtnCambiarEstado = New System.Windows.Forms.Button()
        Me.BtnSelectEtic = New System.Windows.Forms.Button()
        Me.Btnimprimir = New System.Windows.Forms.Button()
        CType(Me.DgvImprimir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CmbRemitoPendiente
        '
        Me.CmbRemitoPendiente.FormattingEnabled = True
        Me.CmbRemitoPendiente.Location = New System.Drawing.Point(167, 26)
        Me.CmbRemitoPendiente.Name = "CmbRemitoPendiente"
        Me.CmbRemitoPendiente.Size = New System.Drawing.Size(117, 21)
        Me.CmbRemitoPendiente.TabIndex = 20
        '
        'LblRemitoPendiente
        '
        Me.LblRemitoPendiente.AutoSize = True
        Me.LblRemitoPendiente.Location = New System.Drawing.Point(164, 6)
        Me.LblRemitoPendiente.Name = "LblRemitoPendiente"
        Me.LblRemitoPendiente.Size = New System.Drawing.Size(101, 13)
        Me.LblRemitoPendiente.TabIndex = 21
        Me.LblRemitoPendiente.Text = "Remitos Pendientes"
        '
        'TxtPath
        '
        Me.TxtPath.Enabled = False
        Me.TxtPath.Location = New System.Drawing.Point(11, 66)
        Me.TxtPath.Name = "TxtPath"
        Me.TxtPath.Size = New System.Drawing.Size(273, 20)
        Me.TxtPath.TabIndex = 24
        '
        'LblPath
        '
        Me.LblPath.AutoSize = True
        Me.LblPath.Location = New System.Drawing.Point(8, 50)
        Me.LblPath.Name = "LblPath"
        Me.LblPath.Size = New System.Drawing.Size(46, 13)
        Me.LblPath.TabIndex = 25
        Me.LblPath.Text = "Etiqueta"
        '
        'DgvImprimir
        '
        Me.DgvImprimir.AllowUserToAddRows = False
        Me.DgvImprimir.AllowUserToDeleteRows = False
        Me.DgvImprimir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvImprimir.Location = New System.Drawing.Point(11, 157)
        Me.DgvImprimir.Name = "DgvImprimir"
        Me.DgvImprimir.ReadOnly = True
        Me.DgvImprimir.Size = New System.Drawing.Size(889, 370)
        Me.DgvImprimir.TabIndex = 26
        '
        'LblRemitente
        '
        Me.LblRemitente.AutoSize = True
        Me.LblRemitente.Location = New System.Drawing.Point(8, 6)
        Me.LblRemitente.Name = "LblRemitente"
        Me.LblRemitente.Size = New System.Drawing.Size(55, 13)
        Me.LblRemitente.TabIndex = 28
        Me.LblRemitente.Text = "Remitente"
        '
        'CmbRemitente
        '
        Me.CmbRemitente.FormattingEnabled = True
        Me.CmbRemitente.Location = New System.Drawing.Point(11, 26)
        Me.CmbRemitente.Name = "CmbRemitente"
        Me.CmbRemitente.Size = New System.Drawing.Size(118, 21)
        Me.CmbRemitente.TabIndex = 27
        '
        'LblCant
        '
        Me.LblCant.AutoSize = True
        Me.LblCant.Location = New System.Drawing.Point(11, 530)
        Me.LblCant.Name = "LblCant"
        Me.LblCant.Size = New System.Drawing.Size(13, 13)
        Me.LblCant.TabIndex = 29
        Me.LblCant.Text = "0"
        '
        'BtnCambiarEstado
        '
        Me.BtnCambiarEstado.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnCambiarEstado.Image = Global.Correo.My.Resources.Resources.tick
        Me.BtnCambiarEstado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCambiarEstado.Location = New System.Drawing.Point(733, 104)
        Me.BtnCambiarEstado.Name = "BtnCambiarEstado"
        Me.BtnCambiarEstado.Size = New System.Drawing.Size(167, 47)
        Me.BtnCambiarEstado.TabIndex = 30
        Me.BtnCambiarEstado.Text = "Cambiar Estado"
        Me.BtnCambiarEstado.UseVisualStyleBackColor = True
        '
        'BtnSelectEtic
        '
        Me.BtnSelectEtic.Enabled = False
        Me.BtnSelectEtic.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnSelectEtic.Image = Global.Correo.My.Resources.Resources.filefind
        Me.BtnSelectEtic.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BtnSelectEtic.Location = New System.Drawing.Point(11, 104)
        Me.BtnSelectEtic.Name = "BtnSelectEtic"
        Me.BtnSelectEtic.Size = New System.Drawing.Size(150, 47)
        Me.BtnSelectEtic.TabIndex = 22
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
        Me.Btnimprimir.Location = New System.Drawing.Point(167, 104)
        Me.Btnimprimir.Name = "Btnimprimir"
        Me.Btnimprimir.Size = New System.Drawing.Size(159, 47)
        Me.Btnimprimir.TabIndex = 18
        Me.Btnimprimir.Text = "   Imprimir"
        Me.Btnimprimir.UseVisualStyleBackColor = True
        '
        'FrmimprimirEtiqueta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(912, 552)
        Me.Controls.Add(Me.BtnCambiarEstado)
        Me.Controls.Add(Me.LblCant)
        Me.Controls.Add(Me.LblRemitente)
        Me.Controls.Add(Me.CmbRemitente)
        Me.Controls.Add(Me.DgvImprimir)
        Me.Controls.Add(Me.LblPath)
        Me.Controls.Add(Me.TxtPath)
        Me.Controls.Add(Me.BtnSelectEtic)
        Me.Controls.Add(Me.LblRemitoPendiente)
        Me.Controls.Add(Me.CmbRemitoPendiente)
        Me.Controls.Add(Me.Btnimprimir)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "FrmimprimirEtiqueta"
        Me.Text = "Imprimir Etiqueta"
        CType(Me.DgvImprimir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Btnimprimir As System.Windows.Forms.Button
    Friend WithEvents CmbRemitoPendiente As System.Windows.Forms.ComboBox
    Friend WithEvents LblRemitoPendiente As System.Windows.Forms.Label
    Friend WithEvents BtnSelectEtic As System.Windows.Forms.Button
    Friend WithEvents TxtPath As System.Windows.Forms.TextBox
    Friend WithEvents LblPath As System.Windows.Forms.Label
    Friend WithEvents DgvImprimir As System.Windows.Forms.DataGridView
    Friend WithEvents LblRemitente As System.Windows.Forms.Label
    Friend WithEvents CmbRemitente As System.Windows.Forms.ComboBox
    Friend WithEvents LblCant As System.Windows.Forms.Label
    Friend WithEvents BtnCambiarEstado As System.Windows.Forms.Button
End Class
