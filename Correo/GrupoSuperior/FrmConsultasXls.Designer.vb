<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConsultasXls
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
        Me.txtPath = New System.Windows.Forms.TextBox
        Me.BtnExcel = New System.Windows.Forms.Button
        Me.DgvDatos = New System.Windows.Forms.DataGridView
        Me.BNBUSCAR = New System.Windows.Forms.Button
        Me.BtnXls = New System.Windows.Forms.Button
        Me.PgbAnalisis = New System.Windows.Forms.ProgressBar
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Gb.SuspendLayout()
        CType(Me.DgvDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Gb
        '
        Me.Gb.Controls.Add(Me.PgbAnalisis)
        Me.Gb.Controls.Add(Me.BtnXls)
        Me.Gb.Controls.Add(Me.BNBUSCAR)
        Me.Gb.Controls.Add(Me.DgvDatos)
        Me.Gb.Controls.Add(Me.txtPath)
        Me.Gb.Controls.Add(Me.BtnExcel)
        Me.Gb.Controls.SetChildIndex(Me.PBLogo, 0)
        Me.Gb.Controls.SetChildIndex(Me.BtnSalir, 0)
        Me.Gb.Controls.SetChildIndex(Me.BtnExcel, 0)
        Me.Gb.Controls.SetChildIndex(Me.txtPath, 0)
        Me.Gb.Controls.SetChildIndex(Me.DgvDatos, 0)
        Me.Gb.Controls.SetChildIndex(Me.BNBUSCAR, 0)
        Me.Gb.Controls.SetChildIndex(Me.BtnXls, 0)
        Me.Gb.Controls.SetChildIndex(Me.PgbAnalisis, 0)
        '
        'txtPath
        '
        Me.txtPath.Location = New System.Drawing.Point(12, 29)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.Size = New System.Drawing.Size(250, 20)
        Me.txtPath.TabIndex = 36
        '
        'BtnExcel
        '
        Me.BtnExcel.Location = New System.Drawing.Point(268, 27)
        Me.BtnExcel.Name = "BtnExcel"
        Me.BtnExcel.Size = New System.Drawing.Size(17, 23)
        Me.BtnExcel.TabIndex = 35
        Me.BtnExcel.Text = "..."
        Me.BtnExcel.UseVisualStyleBackColor = True
        '
        'DgvDatos
        '
        Me.DgvDatos.AllowUserToAddRows = False
        Me.DgvDatos.AllowUserToDeleteRows = False
        Me.DgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvDatos.Location = New System.Drawing.Point(12, 55)
        Me.DgvDatos.Name = "DgvDatos"
        Me.DgvDatos.ReadOnly = True
        Me.DgvDatos.Size = New System.Drawing.Size(535, 358)
        Me.DgvDatos.TabIndex = 37
        '
        'BNBUSCAR
        '
        Me.BNBUSCAR.Location = New System.Drawing.Point(553, 55)
        Me.BNBUSCAR.Name = "BNBUSCAR"
        Me.BNBUSCAR.Size = New System.Drawing.Size(102, 23)
        Me.BNBUSCAR.TabIndex = 40
        Me.BNBUSCAR.Text = "BUSCAR"
        Me.BNBUSCAR.UseVisualStyleBackColor = True
        '
        'BtnXls
        '
        Me.BtnXls.Location = New System.Drawing.Point(472, 419)
        Me.BtnXls.Name = "BtnXls"
        Me.BtnXls.Size = New System.Drawing.Size(75, 23)
        Me.BtnXls.TabIndex = 41
        Me.BtnXls.Text = "Xls"
        Me.BtnXls.UseVisualStyleBackColor = True
        '
        'PgbAnalisis
        '
        Me.PgbAnalisis.Location = New System.Drawing.Point(12, 419)
        Me.PgbAnalisis.Name = "PgbAnalisis"
        Me.PgbAnalisis.Size = New System.Drawing.Size(456, 10)
        Me.PgbAnalisis.TabIndex = 52
        '
        'FrmConsultasXls
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(699, 479)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmConsultasXls"
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Gb.ResumeLayout(False)
        Me.Gb.PerformLayout()
        CType(Me.DgvDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtPath As System.Windows.Forms.TextBox
    Friend WithEvents BtnExcel As System.Windows.Forms.Button
    Friend WithEvents DgvDatos As System.Windows.Forms.DataGridView
    Friend WithEvents BNBUSCAR As System.Windows.Forms.Button
    Friend WithEvents BtnXls As System.Windows.Forms.Button
    Friend WithEvents PgbAnalisis As System.Windows.Forms.ProgressBar

End Class
