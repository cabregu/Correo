<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPendientes
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
        Me.DgvDatos = New System.Windows.Forms.DataGridView()
        Me.CmbCarteros = New System.Windows.Forms.ComboBox()
        Me.LblCarteros = New System.Windows.Forms.Label()
        Me.BtnConsultar = New System.Windows.Forms.Button()
        Me.BtnGeneraryenviar = New System.Windows.Forms.Button()
        Me.Lblcartero = New System.Windows.Forms.Label()
        Me.Lblcant = New System.Windows.Forms.Label()
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Gb.SuspendLayout()
        CType(Me.DgvDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PBLogo
        '
        Me.PBLogo.Location = New System.Drawing.Point(5, 418)
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(867, 418)
        '
        'Gb
        '
        Me.Gb.Controls.Add(Me.Lblcant)
        Me.Gb.Controls.Add(Me.Lblcartero)
        Me.Gb.Controls.Add(Me.BtnGeneraryenviar)
        Me.Gb.Controls.Add(Me.BtnConsultar)
        Me.Gb.Controls.Add(Me.LblCarteros)
        Me.Gb.Controls.Add(Me.CmbCarteros)
        Me.Gb.Controls.Add(Me.DgvDatos)
        Me.Gb.Location = New System.Drawing.Point(1, 1)
        Me.Gb.Size = New System.Drawing.Size(914, 469)
        Me.Gb.Controls.SetChildIndex(Me.PBLogo, 0)
        Me.Gb.Controls.SetChildIndex(Me.BtnSalir, 0)
        Me.Gb.Controls.SetChildIndex(Me.DgvDatos, 0)
        Me.Gb.Controls.SetChildIndex(Me.CmbCarteros, 0)
        Me.Gb.Controls.SetChildIndex(Me.LblCarteros, 0)
        Me.Gb.Controls.SetChildIndex(Me.BtnConsultar, 0)
        Me.Gb.Controls.SetChildIndex(Me.BtnGeneraryenviar, 0)
        Me.Gb.Controls.SetChildIndex(Me.Lblcartero, 0)
        Me.Gb.Controls.SetChildIndex(Me.Lblcant, 0)
        '
        'DgvDatos
        '
        Me.DgvDatos.AllowUserToAddRows = False
        Me.DgvDatos.AllowUserToDeleteRows = False
        Me.DgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvDatos.Location = New System.Drawing.Point(11, 42)
        Me.DgvDatos.Name = "DgvDatos"
        Me.DgvDatos.ReadOnly = True
        Me.DgvDatos.Size = New System.Drawing.Size(469, 331)
        Me.DgvDatos.TabIndex = 51
        '
        'CmbCarteros
        '
        Me.CmbCarteros.FormattingEnabled = True
        Me.CmbCarteros.Location = New System.Drawing.Point(63, 13)
        Me.CmbCarteros.Name = "CmbCarteros"
        Me.CmbCarteros.Size = New System.Drawing.Size(162, 21)
        Me.CmbCarteros.TabIndex = 52
        '
        'LblCarteros
        '
        Me.LblCarteros.AutoSize = True
        Me.LblCarteros.Location = New System.Drawing.Point(11, 16)
        Me.LblCarteros.Name = "LblCarteros"
        Me.LblCarteros.Size = New System.Drawing.Size(46, 13)
        Me.LblCarteros.TabIndex = 53
        Me.LblCarteros.Text = "Carteros"
        '
        'BtnConsultar
        '
        Me.BtnConsultar.Location = New System.Drawing.Point(231, 11)
        Me.BtnConsultar.Name = "BtnConsultar"
        Me.BtnConsultar.Size = New System.Drawing.Size(75, 23)
        Me.BtnConsultar.TabIndex = 54
        Me.BtnConsultar.Text = "Consultar"
        Me.BtnConsultar.UseVisualStyleBackColor = True
        '
        'BtnGeneraryenviar
        '
        Me.BtnGeneraryenviar.Location = New System.Drawing.Point(312, 11)
        Me.BtnGeneraryenviar.Name = "BtnGeneraryenviar"
        Me.BtnGeneraryenviar.Size = New System.Drawing.Size(117, 23)
        Me.BtnGeneraryenviar.TabIndex = 56
        Me.BtnGeneraryenviar.Text = "Generar y enviar"
        Me.BtnGeneraryenviar.UseVisualStyleBackColor = True
        '
        'Lblcartero
        '
        Me.Lblcartero.AutoSize = True
        Me.Lblcartero.Location = New System.Drawing.Point(8, 385)
        Me.Lblcartero.Name = "Lblcartero"
        Me.Lblcartero.Size = New System.Drawing.Size(59, 13)
        Me.Lblcartero.TabIndex = 57
        Me.Lblcartero.Text = "CARTERO"
        '
        'Lblcant
        '
        Me.Lblcant.AutoSize = True
        Me.Lblcant.Location = New System.Drawing.Point(160, 385)
        Me.Lblcant.Name = "Lblcant"
        Me.Lblcant.Size = New System.Drawing.Size(13, 13)
        Me.Lblcant.TabIndex = 58
        Me.Lblcant.Text = "0"
        '
        'FrmPendientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(917, 471)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmPendientes"
        Me.Text = "Pendientes"
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Gb.ResumeLayout(False)
        Me.Gb.PerformLayout()
        CType(Me.DgvDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DgvDatos As System.Windows.Forms.DataGridView
    Friend WithEvents CmbCarteros As System.Windows.Forms.ComboBox
    Friend WithEvents LblCarteros As System.Windows.Forms.Label
    Friend WithEvents BtnConsultar As System.Windows.Forms.Button
    Friend WithEvents BtnGeneraryenviar As System.Windows.Forms.Button
    Friend WithEvents Lblcartero As System.Windows.Forms.Label
    Friend WithEvents Lblcant As System.Windows.Forms.Label

End Class
