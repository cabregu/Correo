<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmImprimirDesdeExcel
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
        Me.DgvImprimir = New System.Windows.Forms.DataGridView()
        Me.LblPath = New System.Windows.Forms.Label()
        Me.TxtPath = New System.Windows.Forms.TextBox()
        Me.BtnSelectEtic = New System.Windows.Forms.Button()
        Me.Btnimprimir = New System.Windows.Forms.Button()
        Me.BtnSeleccionarExcel = New System.Windows.Forms.Button()
        Me.BtnExcel = New System.Windows.Forms.Button()
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Gb.SuspendLayout()
        CType(Me.DgvImprimir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PBLogo
        '
        Me.PBLogo.Location = New System.Drawing.Point(5, 567)
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(1090, 567)
        '
        'Gb
        '
        Me.Gb.Controls.Add(Me.BtnExcel)
        Me.Gb.Controls.Add(Me.BtnSeleccionarExcel)
        Me.Gb.Controls.Add(Me.LblCant)
        Me.Gb.Controls.Add(Me.DgvImprimir)
        Me.Gb.Controls.Add(Me.LblPath)
        Me.Gb.Controls.Add(Me.TxtPath)
        Me.Gb.Controls.Add(Me.Btnimprimir)
        Me.Gb.Controls.Add(Me.BtnSelectEtic)
        Me.Gb.Size = New System.Drawing.Size(1137, 618)
        Me.Gb.Controls.SetChildIndex(Me.BtnSelectEtic, 0)
        Me.Gb.Controls.SetChildIndex(Me.Btnimprimir, 0)
        Me.Gb.Controls.SetChildIndex(Me.TxtPath, 0)
        Me.Gb.Controls.SetChildIndex(Me.PBLogo, 0)
        Me.Gb.Controls.SetChildIndex(Me.LblPath, 0)
        Me.Gb.Controls.SetChildIndex(Me.DgvImprimir, 0)
        Me.Gb.Controls.SetChildIndex(Me.BtnSalir, 0)
        Me.Gb.Controls.SetChildIndex(Me.LblCant, 0)
        Me.Gb.Controls.SetChildIndex(Me.BtnSeleccionarExcel, 0)
        Me.Gb.Controls.SetChildIndex(Me.BtnExcel, 0)
        '
        'LblCant
        '
        Me.LblCant.AutoSize = True
        Me.LblCant.Location = New System.Drawing.Point(887, 510)
        Me.LblCant.Name = "LblCant"
        Me.LblCant.Size = New System.Drawing.Size(13, 13)
        Me.LblCant.TabIndex = 35
        Me.LblCant.Text = "0"
        '
        'DgvImprimir
        '
        Me.DgvImprimir.AllowUserToAddRows = False
        Me.DgvImprimir.AllowUserToDeleteRows = False
        Me.DgvImprimir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvImprimir.Location = New System.Drawing.Point(12, 107)
        Me.DgvImprimir.Name = "DgvImprimir"
        Me.DgvImprimir.ReadOnly = True
        Me.DgvImprimir.Size = New System.Drawing.Size(889, 400)
        Me.DgvImprimir.TabIndex = 34
        '
        'LblPath
        '
        Me.LblPath.AutoSize = True
        Me.LblPath.Location = New System.Drawing.Point(170, 30)
        Me.LblPath.Name = "LblPath"
        Me.LblPath.Size = New System.Drawing.Size(46, 13)
        Me.LblPath.TabIndex = 33
        Me.LblPath.Text = "Etiqueta"
        '
        'TxtPath
        '
        Me.TxtPath.Enabled = False
        Me.TxtPath.Location = New System.Drawing.Point(173, 54)
        Me.TxtPath.Name = "TxtPath"
        Me.TxtPath.Size = New System.Drawing.Size(273, 20)
        Me.TxtPath.TabIndex = 32
        '
        'BtnSelectEtic
        '
        Me.BtnSelectEtic.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnSelectEtic.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnSelectEtic.Image = Global.Correo.My.Resources.Resources.filefind
        Me.BtnSelectEtic.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BtnSelectEtic.Location = New System.Drawing.Point(452, 30)
        Me.BtnSelectEtic.Name = "BtnSelectEtic"
        Me.BtnSelectEtic.Size = New System.Drawing.Size(108, 47)
        Me.BtnSelectEtic.TabIndex = 31
        Me.BtnSelectEtic.Text = "Seleccionar Etiqueta"
        Me.BtnSelectEtic.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSelectEtic.UseVisualStyleBackColor = True
        '
        'Btnimprimir
        '
        Me.Btnimprimir.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Btnimprimir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btnimprimir.Image = Global.Correo.My.Resources.Resources.Print
        Me.Btnimprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btnimprimir.Location = New System.Drawing.Point(784, 40)
        Me.Btnimprimir.Name = "Btnimprimir"
        Me.Btnimprimir.Size = New System.Drawing.Size(117, 47)
        Me.Btnimprimir.TabIndex = 30
        Me.Btnimprimir.Text = "   Imprimir"
        Me.Btnimprimir.UseVisualStyleBackColor = True
        '
        'BtnSeleccionarExcel
        '
        Me.BtnSeleccionarExcel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnSeleccionarExcel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnSeleccionarExcel.Image = Global.Correo.My.Resources.Resources.Attachment_32x32
        Me.BtnSeleccionarExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSeleccionarExcel.Location = New System.Drawing.Point(12, 27)
        Me.BtnSeleccionarExcel.Name = "BtnSeleccionarExcel"
        Me.BtnSeleccionarExcel.Size = New System.Drawing.Size(120, 47)
        Me.BtnSeleccionarExcel.TabIndex = 36
        Me.BtnSeleccionarExcel.Text = "Buscar Archivo"
        Me.BtnSeleccionarExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSeleccionarExcel.UseVisualStyleBackColor = True
        '
        'BtnExcel
        '
        Me.BtnExcel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnExcel.Image = Global.Correo.My.Resources.Resources.table_excel
        Me.BtnExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnExcel.Location = New System.Drawing.Point(917, 460)
        Me.BtnExcel.Name = "BtnExcel"
        Me.BtnExcel.Size = New System.Drawing.Size(120, 47)
        Me.BtnExcel.TabIndex = 37
        Me.BtnExcel.Text = "Bajar Archivo"
        Me.BtnExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnExcel.UseVisualStyleBackColor = True
        '
        'FrmImprimirDesdeExcel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1137, 617)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmImprimirDesdeExcel"
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Gb.ResumeLayout(False)
        Me.Gb.PerformLayout()
        CType(Me.DgvImprimir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LblCant As System.Windows.Forms.Label
    Friend WithEvents DgvImprimir As System.Windows.Forms.DataGridView
    Friend WithEvents LblPath As System.Windows.Forms.Label
    Friend WithEvents TxtPath As System.Windows.Forms.TextBox
    Friend WithEvents Btnimprimir As System.Windows.Forms.Button
    Friend WithEvents BtnSelectEtic As System.Windows.Forms.Button
    Friend WithEvents BtnSeleccionarExcel As System.Windows.Forms.Button
    Friend WithEvents BtnExcel As Button
End Class
