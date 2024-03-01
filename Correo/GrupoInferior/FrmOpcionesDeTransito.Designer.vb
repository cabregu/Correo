<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmOpcionesDeTransito
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
        Me.BtnNormal = New System.Windows.Forms.Button
        Me.BtnOtro = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'BtnNormal
        '
        Me.BtnNormal.Location = New System.Drawing.Point(48, 25)
        Me.BtnNormal.Name = "BtnNormal"
        Me.BtnNormal.Size = New System.Drawing.Size(114, 30)
        Me.BtnNormal.TabIndex = 0
        Me.BtnNormal.Text = "Normal"
        Me.BtnNormal.UseVisualStyleBackColor = True
        '
        'BtnOtro
        '
        Me.BtnOtro.Location = New System.Drawing.Point(215, 25)
        Me.BtnOtro.Name = "BtnOtro"
        Me.BtnOtro.Size = New System.Drawing.Size(114, 30)
        Me.BtnOtro.TabIndex = 1
        Me.BtnOtro.Text = "Otro"
        Me.BtnOtro.UseVisualStyleBackColor = True
        '
        'FrmOpcionesDeTransito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.ClientSize = New System.Drawing.Size(373, 86)
        Me.Controls.Add(Me.BtnOtro)
        Me.Controls.Add(Me.BtnNormal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "FrmOpcionesDeTransito"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Opciones De Transito"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnNormal As System.Windows.Forms.Button
    Friend WithEvents BtnOtro As System.Windows.Forms.Button
End Class
