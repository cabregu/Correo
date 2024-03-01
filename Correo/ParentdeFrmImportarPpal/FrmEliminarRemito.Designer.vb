<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEliminarRemito
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DGVRemito = New System.Windows.Forms.DataGridView()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        CType(Me.DGVRemito, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGVRemito
        '
        Me.DGVRemito.AllowUserToAddRows = False
        Me.DGVRemito.AllowUserToDeleteRows = False
        Me.DGVRemito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVRemito.Location = New System.Drawing.Point(12, 12)
        Me.DGVRemito.Name = "DGVRemito"
        Me.DGVRemito.ReadOnly = True
        Me.DGVRemito.RowTemplate.Height = 25
        Me.DGVRemito.Size = New System.Drawing.Size(513, 165)
        Me.DGVRemito.TabIndex = 7
        '
        'BtnSalir
        '
        Me.BtnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnSalir.Image = Global.Correo.My.Resources.Resources.door_out
        Me.BtnSalir.Location = New System.Drawing.Point(485, 183)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(40, 37)
        Me.BtnSalir.TabIndex = 20
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnEliminar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnEliminar.Image = Global.Correo.My.Resources.Resources.agt_stop
        Me.BtnEliminar.Location = New System.Drawing.Point(438, 183)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(41, 37)
        Me.BtnEliminar.TabIndex = 21
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'FrmEliminarRemito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(536, 227)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.DGVRemito)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmEliminarRemito"
        Me.Text = "FrmEliminarRemito"
        CType(Me.DGVRemito, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DGVRemito As System.Windows.Forms.DataGridView
    Public WithEvents BtnSalir As System.Windows.Forms.Button
    Public WithEvents BtnEliminar As System.Windows.Forms.Button
End Class
