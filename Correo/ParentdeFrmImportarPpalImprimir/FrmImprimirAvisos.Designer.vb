<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmImprimirAvisos
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
        Me.DgvImprimir = New System.Windows.Forms.DataGridView()
        Me.LblPath = New System.Windows.Forms.Label()
        Me.TxtPath = New System.Windows.Forms.TextBox()
        Me.Btnimprimir = New System.Windows.Forms.Button()
        Me.BtnSelectEtic = New System.Windows.Forms.Button()
        Me.DtpFechaAviso = New System.Windows.Forms.DateTimePicker()
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Gb.SuspendLayout()
        CType(Me.DgvImprimir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PBLogo
        '
        Me.PBLogo.Location = New System.Drawing.Point(5, 356)
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(876, 356)
        '
        'Gb
        '
        Me.Gb.Controls.Add(Me.DtpFechaAviso)
        Me.Gb.Controls.Add(Me.BtnSelectEtic)
        Me.Gb.Size = New System.Drawing.Size(923, 407)
        Me.Gb.Controls.SetChildIndex(Me.BtnSelectEtic, 0)
        Me.Gb.Controls.SetChildIndex(Me.PBLogo, 0)
        Me.Gb.Controls.SetChildIndex(Me.BtnSalir, 0)
        Me.Gb.Controls.SetChildIndex(Me.DtpFechaAviso, 0)
        '
        'DgvImprimir
        '
        Me.DgvImprimir.AllowUserToAddRows = False
        Me.DgvImprimir.AllowUserToDeleteRows = False
        Me.DgvImprimir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvImprimir.Location = New System.Drawing.Point(20, 78)
        Me.DgvImprimir.Name = "DgvImprimir"
        Me.DgvImprimir.ReadOnly = True
        Me.DgvImprimir.Size = New System.Drawing.Size(889, 268)
        Me.DgvImprimir.TabIndex = 41
        '
        'LblPath
        '
        Me.LblPath.AutoSize = True
        Me.LblPath.Location = New System.Drawing.Point(16, 22)
        Me.LblPath.Name = "LblPath"
        Me.LblPath.Size = New System.Drawing.Size(46, 13)
        Me.LblPath.TabIndex = 40
        Me.LblPath.Text = "Etiqueta"
        '
        'TxtPath
        '
        Me.TxtPath.Enabled = False
        Me.TxtPath.Location = New System.Drawing.Point(19, 38)
        Me.TxtPath.Name = "TxtPath"
        Me.TxtPath.Size = New System.Drawing.Size(273, 20)
        Me.TxtPath.TabIndex = 39
        '
        'Btnimprimir
        '
        Me.Btnimprimir.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Btnimprimir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btnimprimir.Image = Global.Correo.My.Resources.Resources.Print
        Me.Btnimprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btnimprimir.Location = New System.Drawing.Point(792, 25)
        Me.Btnimprimir.Name = "Btnimprimir"
        Me.Btnimprimir.Size = New System.Drawing.Size(117, 47)
        Me.Btnimprimir.TabIndex = 37
        Me.Btnimprimir.Text = "   Imprimir"
        Me.Btnimprimir.UseVisualStyleBackColor = True
        '
        'BtnSelectEtic
        '
        Me.BtnSelectEtic.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnSelectEtic.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnSelectEtic.Image = Global.Correo.My.Resources.Resources.filefind
        Me.BtnSelectEtic.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BtnSelectEtic.Location = New System.Drawing.Point(522, 26)
        Me.BtnSelectEtic.Name = "BtnSelectEtic"
        Me.BtnSelectEtic.Size = New System.Drawing.Size(108, 47)
        Me.BtnSelectEtic.TabIndex = 38
        Me.BtnSelectEtic.Text = "Seleccionar Etiqueta"
        Me.BtnSelectEtic.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSelectEtic.UseVisualStyleBackColor = True
        '
        'DtpFechaAviso
        '
        Me.DtpFechaAviso.Location = New System.Drawing.Point(298, 40)
        Me.DtpFechaAviso.Name = "DtpFechaAviso"
        Me.DtpFechaAviso.Size = New System.Drawing.Size(200, 20)
        Me.DtpFechaAviso.TabIndex = 39
        '
        'FrmImprimirAvisos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(924, 367)
        Me.Controls.Add(Me.DgvImprimir)
        Me.Controls.Add(Me.LblPath)
        Me.Controls.Add(Me.TxtPath)
        Me.Controls.Add(Me.Btnimprimir)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmImprimirAvisos"
        Me.Controls.SetChildIndex(Me.Gb, 0)
        Me.Controls.SetChildIndex(Me.Btnimprimir, 0)
        Me.Controls.SetChildIndex(Me.TxtPath, 0)
        Me.Controls.SetChildIndex(Me.LblPath, 0)
        Me.Controls.SetChildIndex(Me.DgvImprimir, 0)
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Gb.ResumeLayout(False)
        CType(Me.DgvImprimir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DgvImprimir As System.Windows.Forms.DataGridView
    Friend WithEvents LblPath As System.Windows.Forms.Label
    Friend WithEvents TxtPath As System.Windows.Forms.TextBox
    Friend WithEvents Btnimprimir As System.Windows.Forms.Button
    Friend WithEvents BtnSelectEtic As System.Windows.Forms.Button
    Friend WithEvents DtpFechaAviso As System.Windows.Forms.DateTimePicker

End Class
