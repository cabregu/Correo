<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmModoS
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
        Me.Dgvresultado = New System.Windows.Forms.DataGridView()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dgvtabla = New System.Windows.Forms.DataGridView()
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Gb.SuspendLayout()
        CType(Me.Dgvresultado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvtabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(926, 429)
        '
        'Gb
        '
        Me.Gb.Controls.Add(Me.dgvtabla)
        Me.Gb.Controls.Add(Me.Button1)
        Me.Gb.Controls.Add(Me.Button2)
        Me.Gb.Controls.Add(Me.Dgvresultado)
        Me.Gb.Size = New System.Drawing.Size(973, 480)
        Me.Gb.Controls.SetChildIndex(Me.PBLogo, 0)
        Me.Gb.Controls.SetChildIndex(Me.BtnSalir, 0)
        Me.Gb.Controls.SetChildIndex(Me.Dgvresultado, 0)
        Me.Gb.Controls.SetChildIndex(Me.Button2, 0)
        Me.Gb.Controls.SetChildIndex(Me.Button1, 0)
        Me.Gb.Controls.SetChildIndex(Me.dgvtabla, 0)
        '
        'Dgvresultado
        '
        Me.Dgvresultado.AllowUserToAddRows = False
        Me.Dgvresultado.AllowUserToDeleteRows = False
        Me.Dgvresultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgvresultado.Location = New System.Drawing.Point(480, 52)
        Me.Dgvresultado.Name = "Dgvresultado"
        Me.Dgvresultado.ReadOnly = True
        Me.Dgvresultado.Size = New System.Drawing.Size(400, 300)
        Me.Dgvresultado.TabIndex = 29
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(35, 23)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 32
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(835, 358)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 33
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dgvtabla
        '
        Me.dgvtabla.AllowUserToAddRows = False
        Me.dgvtabla.AllowUserToDeleteRows = False
        Me.dgvtabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvtabla.Location = New System.Drawing.Point(59, 52)
        Me.dgvtabla.Name = "dgvtabla"
        Me.dgvtabla.ReadOnly = True
        Me.dgvtabla.Size = New System.Drawing.Size(400, 300)
        Me.dgvtabla.TabIndex = 34
        '
        'FrmModoS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(973, 479)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmModoS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Normal
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Gb.ResumeLayout(False)
        CType(Me.Dgvresultado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvtabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Dgvresultado As DataGridView
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents dgvtabla As DataGridView
End Class
