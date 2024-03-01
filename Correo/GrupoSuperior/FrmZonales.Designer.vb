<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmZonales
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
        Me.CmbZonales = New System.Windows.Forms.ComboBox()
        Me.TxtEnvio = New System.Windows.Forms.TextBox()
        Me.LblC = New System.Windows.Forms.Label()
        Me.LblCartero = New System.Windows.Forms.Label()
        Me.BtnTerminar = New System.Windows.Forms.Button()
        Me.BtnGenerar = New System.Windows.Forms.Button()
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Gb.SuspendLayout()
        CType(Me.DgvDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PBLogo
        '
        Me.PBLogo.Location = New System.Drawing.Point(5, 602)
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(1103, 602)
        '
        'Gb
        '
        Me.Gb.Controls.Add(Me.BtnGenerar)
        Me.Gb.Controls.Add(Me.BtnTerminar)
        Me.Gb.Controls.Add(Me.LblCartero)
        Me.Gb.Controls.Add(Me.LblC)
        Me.Gb.Controls.Add(Me.TxtEnvio)
        Me.Gb.Controls.Add(Me.CmbZonales)
        Me.Gb.Controls.Add(Me.DgvDatos)
        Me.Gb.Location = New System.Drawing.Point(1, 0)
        Me.Gb.Size = New System.Drawing.Size(1150, 653)
        Me.Gb.Controls.SetChildIndex(Me.DgvDatos, 0)
        Me.Gb.Controls.SetChildIndex(Me.CmbZonales, 0)
        Me.Gb.Controls.SetChildIndex(Me.TxtEnvio, 0)
        Me.Gb.Controls.SetChildIndex(Me.LblC, 0)
        Me.Gb.Controls.SetChildIndex(Me.LblCartero, 0)
        Me.Gb.Controls.SetChildIndex(Me.BtnTerminar, 0)
        Me.Gb.Controls.SetChildIndex(Me.BtnGenerar, 0)
        Me.Gb.Controls.SetChildIndex(Me.PBLogo, 0)
        Me.Gb.Controls.SetChildIndex(Me.BtnSalir, 0)
        '
        'DgvDatos
        '
        Me.DgvDatos.AllowUserToAddRows = False
        Me.DgvDatos.AllowUserToDeleteRows = False
        Me.DgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvDatos.Location = New System.Drawing.Point(11, 19)
        Me.DgvDatos.Name = "DgvDatos"
        Me.DgvDatos.ReadOnly = True
        Me.DgvDatos.Size = New System.Drawing.Size(1120, 358)
        Me.DgvDatos.TabIndex = 38
        '
        'CmbZonales
        '
        Me.CmbZonales.FormattingEnabled = True
        Me.CmbZonales.Location = New System.Drawing.Point(70, 383)
        Me.CmbZonales.Name = "CmbZonales"
        Me.CmbZonales.Size = New System.Drawing.Size(150, 21)
        Me.CmbZonales.TabIndex = 39
        '
        'TxtEnvio
        '
        Me.TxtEnvio.Enabled = False
        Me.TxtEnvio.Location = New System.Drawing.Point(295, 384)
        Me.TxtEnvio.Name = "TxtEnvio"
        Me.TxtEnvio.Size = New System.Drawing.Size(400, 20)
        Me.TxtEnvio.TabIndex = 40
        '
        'LblC
        '
        Me.LblC.AutoSize = True
        Me.LblC.Location = New System.Drawing.Point(240, 387)
        Me.LblC.Name = "LblC"
        Me.LblC.Size = New System.Drawing.Size(34, 13)
        Me.LblC.TabIndex = 42
        Me.LblC.Text = "Envio"
        '
        'LblCartero
        '
        Me.LblCartero.AutoSize = True
        Me.LblCartero.Location = New System.Drawing.Point(15, 391)
        Me.LblCartero.Name = "LblCartero"
        Me.LblCartero.Size = New System.Drawing.Size(41, 13)
        Me.LblCartero.TabIndex = 44
        Me.LblCartero.Text = "Cartero"
        '
        'BtnTerminar
        '
        Me.BtnTerminar.Enabled = False
        Me.BtnTerminar.Location = New System.Drawing.Point(794, 384)
        Me.BtnTerminar.Name = "BtnTerminar"
        Me.BtnTerminar.Size = New System.Drawing.Size(75, 23)
        Me.BtnTerminar.TabIndex = 45
        Me.BtnTerminar.Text = "Terminar"
        Me.BtnTerminar.UseVisualStyleBackColor = True
        '
        'BtnGenerar
        '
        Me.BtnGenerar.Location = New System.Drawing.Point(713, 383)
        Me.BtnGenerar.Name = "BtnGenerar"
        Me.BtnGenerar.Size = New System.Drawing.Size(75, 23)
        Me.BtnGenerar.TabIndex = 46
        Me.BtnGenerar.Text = "Generar"
        Me.BtnGenerar.UseVisualStyleBackColor = True
        '
        'FrmZonales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1152, 654)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmZonales"
        Me.Text = "Zonales"
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Gb.ResumeLayout(False)
        Me.Gb.PerformLayout()
        CType(Me.DgvDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DgvDatos As System.Windows.Forms.DataGridView
    Friend WithEvents CmbZonales As System.Windows.Forms.ComboBox
    Friend WithEvents TxtEnvio As System.Windows.Forms.TextBox
    Friend WithEvents LblCartero As System.Windows.Forms.Label
    Friend WithEvents LblC As System.Windows.Forms.Label
    Friend WithEvents BtnGenerar As System.Windows.Forms.Button
    Friend WithEvents BtnTerminar As System.Windows.Forms.Button

End Class
