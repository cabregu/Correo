<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCrearRemitente
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
        Me.BtnAñadir = New System.Windows.Forms.Button()
        Me.LblServicio = New System.Windows.Forms.Label()
        Me.CmbClientes = New System.Windows.Forms.ComboBox()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.TxtRemitente = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'BtnAñadir
        '
        Me.BtnAñadir.Location = New System.Drawing.Point(209, 80)
        Me.BtnAñadir.Name = "BtnAñadir"
        Me.BtnAñadir.Size = New System.Drawing.Size(20, 23)
        Me.BtnAñadir.TabIndex = 55
        Me.BtnAñadir.Text = ">"
        Me.BtnAñadir.UseVisualStyleBackColor = True
        '
        'LblServicio
        '
        Me.LblServicio.AutoSize = True
        Me.LblServicio.Location = New System.Drawing.Point(11, 11)
        Me.LblServicio.Name = "LblServicio"
        Me.LblServicio.Size = New System.Drawing.Size(52, 13)
        Me.LblServicio.TabIndex = 52
        Me.LblServicio.Text = "CLIENTE"
        '
        'CmbClientes
        '
        Me.CmbClientes.BackColor = System.Drawing.Color.White
        Me.CmbClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbClientes.FormattingEnabled = True
        Me.CmbClientes.Location = New System.Drawing.Point(12, 27)
        Me.CmbClientes.Name = "CmbClientes"
        Me.CmbClientes.Size = New System.Drawing.Size(191, 21)
        Me.CmbClientes.TabIndex = 47
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.Location = New System.Drawing.Point(12, 64)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(70, 13)
        Me.LblNombre.TabIndex = 50
        Me.LblNombre.Text = "REMITENTE"
        '
        'TxtRemitente
        '
        Me.TxtRemitente.BackColor = System.Drawing.Color.Gainsboro
        Me.TxtRemitente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtRemitente.Location = New System.Drawing.Point(15, 80)
        Me.TxtRemitente.Name = "TxtRemitente"
        Me.TxtRemitente.Size = New System.Drawing.Size(188, 20)
        Me.TxtRemitente.TabIndex = 48
        '
        'FrmCrearRemitente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(266, 130)
        Me.Controls.Add(Me.BtnAñadir)
        Me.Controls.Add(Me.LblServicio)
        Me.Controls.Add(Me.CmbClientes)
        Me.Controls.Add(Me.LblNombre)
        Me.Controls.Add(Me.TxtRemitente)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmCrearRemitente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmCrearRemitente"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnAñadir As System.Windows.Forms.Button
    Friend WithEvents LblServicio As System.Windows.Forms.Label
    Friend WithEvents CmbClientes As System.Windows.Forms.ComboBox
    Friend WithEvents LblNombre As System.Windows.Forms.Label
    Friend WithEvents TxtRemitente As System.Windows.Forms.TextBox
End Class
