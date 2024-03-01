<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCargaFeriado
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
        Me.BtnAgregarFeriado = New System.Windows.Forms.Button
        Me.Dtdiaferiado = New System.Windows.Forms.DateTimePicker
        Me.Txtdetalle = New System.Windows.Forms.TextBox
        Me.BtnSalir = New System.Windows.Forms.Button
        Me.Dgvferiados = New System.Windows.Forms.DataGridView
        CType(Me.Dgvferiados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnAgregarFeriado
        '
        Me.BtnAgregarFeriado.Location = New System.Drawing.Point(12, 372)
        Me.BtnAgregarFeriado.Name = "BtnAgregarFeriado"
        Me.BtnAgregarFeriado.Size = New System.Drawing.Size(66, 29)
        Me.BtnAgregarFeriado.TabIndex = 46
        Me.BtnAgregarFeriado.Text = "Agregar"
        Me.BtnAgregarFeriado.UseVisualStyleBackColor = True
        '
        'Dtdiaferiado
        '
        Me.Dtdiaferiado.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dtdiaferiado.Location = New System.Drawing.Point(12, 12)
        Me.Dtdiaferiado.Name = "Dtdiaferiado"
        Me.Dtdiaferiado.Size = New System.Drawing.Size(113, 20)
        Me.Dtdiaferiado.TabIndex = 45
        '
        'Txtdetalle
        '
        Me.Txtdetalle.Location = New System.Drawing.Point(131, 13)
        Me.Txtdetalle.Name = "Txtdetalle"
        Me.Txtdetalle.Size = New System.Drawing.Size(123, 20)
        Me.Txtdetalle.TabIndex = 47
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(188, 372)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(66, 29)
        Me.BtnSalir.TabIndex = 48
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'Dgvferiados
        '
        Me.Dgvferiados.AllowUserToAddRows = False
        Me.Dgvferiados.AllowUserToDeleteRows = False
        Me.Dgvferiados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgvferiados.Location = New System.Drawing.Point(12, 38)
        Me.Dgvferiados.Name = "Dgvferiados"
        Me.Dgvferiados.ReadOnly = True
        Me.Dgvferiados.Size = New System.Drawing.Size(242, 328)
        Me.Dgvferiados.TabIndex = 49
        '
        'FrmCargaFeriado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.ClientSize = New System.Drawing.Size(265, 413)
        Me.Controls.Add(Me.Dgvferiados)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.Txtdetalle)
        Me.Controls.Add(Me.BtnAgregarFeriado)
        Me.Controls.Add(Me.Dtdiaferiado)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmCargaFeriado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cargar Feriado"
        CType(Me.Dgvferiados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnAgregarFeriado As System.Windows.Forms.Button
    Friend WithEvents Dtdiaferiado As System.Windows.Forms.DateTimePicker
    Friend WithEvents Txtdetalle As System.Windows.Forms.TextBox
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents Dgvferiados As System.Windows.Forms.DataGridView
End Class
