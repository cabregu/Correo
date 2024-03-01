<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMotivos
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
        Me.DgvMotivos = New System.Windows.Forms.DataGridView()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.BtnExcel = New System.Windows.Forms.Button()
        Me.Txtident = New System.Windows.Forms.TextBox()
        Me.TxtMotivo = New System.Windows.Forms.TextBox()
        Me.CmbReprogramacion = New System.Windows.Forms.ComboBox()
        Me.BtnIngresar = New System.Windows.Forms.Button()
        Me.LblIdentificador = New System.Windows.Forms.Label()
        Me.LblMotivo = New System.Windows.Forms.Label()
        Me.LblReprogramacion = New System.Windows.Forms.Label()
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Gb.SuspendLayout()
        CType(Me.DgvMotivos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PBLogo
        '
        Me.PBLogo.Location = New System.Drawing.Point(0, 513)
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(766, 513)
        '
        'Gb
        '
        Me.Gb.Controls.Add(Me.LblReprogramacion)
        Me.Gb.Controls.Add(Me.LblMotivo)
        Me.Gb.Controls.Add(Me.LblIdentificador)
        Me.Gb.Controls.Add(Me.BtnIngresar)
        Me.Gb.Controls.Add(Me.CmbReprogramacion)
        Me.Gb.Controls.Add(Me.TxtMotivo)
        Me.Gb.Controls.Add(Me.Txtident)
        Me.Gb.Controls.Add(Me.BtnExcel)
        Me.Gb.Controls.Add(Me.BtnActualizar)
        Me.Gb.Controls.Add(Me.DgvMotivos)
        Me.Gb.Location = New System.Drawing.Point(-1, 1)
        Me.Gb.Size = New System.Drawing.Size(813, 564)
        Me.Gb.Controls.SetChildIndex(Me.PBLogo, 0)
        Me.Gb.Controls.SetChildIndex(Me.BtnSalir, 0)
        Me.Gb.Controls.SetChildIndex(Me.DgvMotivos, 0)
        Me.Gb.Controls.SetChildIndex(Me.BtnActualizar, 0)
        Me.Gb.Controls.SetChildIndex(Me.BtnExcel, 0)
        Me.Gb.Controls.SetChildIndex(Me.Txtident, 0)
        Me.Gb.Controls.SetChildIndex(Me.TxtMotivo, 0)
        Me.Gb.Controls.SetChildIndex(Me.CmbReprogramacion, 0)
        Me.Gb.Controls.SetChildIndex(Me.BtnIngresar, 0)
        Me.Gb.Controls.SetChildIndex(Me.LblIdentificador, 0)
        Me.Gb.Controls.SetChildIndex(Me.LblMotivo, 0)
        Me.Gb.Controls.SetChildIndex(Me.LblReprogramacion, 0)
        '
        'DgvMotivos
        '
        Me.DgvMotivos.AllowUserToAddRows = False
        Me.DgvMotivos.AllowUserToDeleteRows = False
        Me.DgvMotivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvMotivos.Location = New System.Drawing.Point(37, 38)
        Me.DgvMotivos.Name = "DgvMotivos"
        Me.DgvMotivos.Size = New System.Drawing.Size(600, 360)
        Me.DgvMotivos.TabIndex = 29
        '
        'BtnActualizar
        '
        Me.BtnActualizar.Location = New System.Drawing.Point(643, 38)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(75, 23)
        Me.BtnActualizar.TabIndex = 30
        Me.BtnActualizar.Text = "Actualizar"
        Me.BtnActualizar.UseVisualStyleBackColor = True
        '
        'BtnExcel
        '
        Me.BtnExcel.Location = New System.Drawing.Point(643, 375)
        Me.BtnExcel.Name = "BtnExcel"
        Me.BtnExcel.Size = New System.Drawing.Size(75, 23)
        Me.BtnExcel.TabIndex = 31
        Me.BtnExcel.Text = "Xls"
        Me.BtnExcel.UseVisualStyleBackColor = True
        '
        'Txtident
        '
        Me.Txtident.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txtident.Location = New System.Drawing.Point(37, 429)
        Me.Txtident.Name = "Txtident"
        Me.Txtident.Size = New System.Drawing.Size(100, 20)
        Me.Txtident.TabIndex = 32
        '
        'TxtMotivo
        '
        Me.TxtMotivo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtMotivo.Location = New System.Drawing.Point(143, 429)
        Me.TxtMotivo.Name = "TxtMotivo"
        Me.TxtMotivo.Size = New System.Drawing.Size(200, 20)
        Me.TxtMotivo.TabIndex = 33
        '
        'CmbReprogramacion
        '
        Me.CmbReprogramacion.FormattingEnabled = True
        Me.CmbReprogramacion.Items.AddRange(New Object() {"SI", "NO"})
        Me.CmbReprogramacion.Location = New System.Drawing.Point(349, 428)
        Me.CmbReprogramacion.Name = "CmbReprogramacion"
        Me.CmbReprogramacion.Size = New System.Drawing.Size(50, 21)
        Me.CmbReprogramacion.TabIndex = 34
        '
        'BtnIngresar
        '
        Me.BtnIngresar.Location = New System.Drawing.Point(405, 427)
        Me.BtnIngresar.Name = "BtnIngresar"
        Me.BtnIngresar.Size = New System.Drawing.Size(75, 23)
        Me.BtnIngresar.TabIndex = 35
        Me.BtnIngresar.Text = "Ingresar"
        Me.BtnIngresar.UseVisualStyleBackColor = True
        '
        'LblIdentificador
        '
        Me.LblIdentificador.AutoSize = True
        Me.LblIdentificador.Location = New System.Drawing.Point(34, 413)
        Me.LblIdentificador.Name = "LblIdentificador"
        Me.LblIdentificador.Size = New System.Drawing.Size(51, 13)
        Me.LblIdentificador.TabIndex = 36
        Me.LblIdentificador.Text = "Identidad"
        '
        'LblMotivo
        '
        Me.LblMotivo.AutoSize = True
        Me.LblMotivo.Location = New System.Drawing.Point(143, 413)
        Me.LblMotivo.Name = "LblMotivo"
        Me.LblMotivo.Size = New System.Drawing.Size(39, 13)
        Me.LblMotivo.TabIndex = 37
        Me.LblMotivo.Text = "Motivo"
        '
        'LblReprogramacion
        '
        Me.LblReprogramacion.AutoSize = True
        Me.LblReprogramacion.Location = New System.Drawing.Point(346, 412)
        Me.LblReprogramacion.Name = "LblReprogramacion"
        Me.LblReprogramacion.Size = New System.Drawing.Size(65, 13)
        Me.LblReprogramacion.TabIndex = 38
        Me.LblReprogramacion.Text = "Reprograma"
        '
        'FrmMotivos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(812, 566)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmMotivos"
        Me.Text = "Armado"
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Gb.ResumeLayout(False)
        Me.Gb.PerformLayout()
        CType(Me.DgvMotivos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DgvMotivos As System.Windows.Forms.DataGridView
    Friend WithEvents BtnActualizar As System.Windows.Forms.Button
    Friend WithEvents BtnExcel As System.Windows.Forms.Button
    Friend WithEvents LblIdentificador As System.Windows.Forms.Label
    Friend WithEvents BtnIngresar As System.Windows.Forms.Button
    Friend WithEvents CmbReprogramacion As System.Windows.Forms.ComboBox
    Friend WithEvents TxtMotivo As System.Windows.Forms.TextBox
    Friend WithEvents Txtident As System.Windows.Forms.TextBox
    Friend WithEvents LblReprogramacion As System.Windows.Forms.Label
    Friend WithEvents LblMotivo As System.Windows.Forms.Label

End Class
