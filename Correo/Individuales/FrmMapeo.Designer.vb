<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMapeo
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
        Me.BtnConsultar = New System.Windows.Forms.Button()
        Me.Btnmapeo = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnOpen = New System.Windows.Forms.Button()
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Gb.SuspendLayout()
        CType(Me.DgvDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PBLogo
        '
        Me.PBLogo.Location = New System.Drawing.Point(5, 699)
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(1216, 699)
        '
        'Gb
        '
        Me.Gb.Controls.Add(Me.BtnOpen)
        Me.Gb.Controls.Add(Me.Button1)
        Me.Gb.Controls.Add(Me.Btnmapeo)
        Me.Gb.Controls.Add(Me.BtnConsultar)
        Me.Gb.Controls.Add(Me.DgvDatos)
        Me.Gb.Size = New System.Drawing.Size(1263, 750)
        Me.Gb.Controls.SetChildIndex(Me.PBLogo, 0)
        Me.Gb.Controls.SetChildIndex(Me.BtnSalir, 0)
        Me.Gb.Controls.SetChildIndex(Me.DgvDatos, 0)
        Me.Gb.Controls.SetChildIndex(Me.BtnConsultar, 0)
        Me.Gb.Controls.SetChildIndex(Me.Btnmapeo, 0)
        Me.Gb.Controls.SetChildIndex(Me.Button1, 0)
        Me.Gb.Controls.SetChildIndex(Me.BtnOpen, 0)
        '
        'DgvDatos
        '
        Me.DgvDatos.AllowUserToAddRows = False
        Me.DgvDatos.AllowUserToDeleteRows = False
        Me.DgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvDatos.Location = New System.Drawing.Point(32, 43)
        Me.DgvDatos.Name = "DgvDatos"
        Me.DgvDatos.ReadOnly = True
        Me.DgvDatos.Size = New System.Drawing.Size(900, 600)
        Me.DgvDatos.TabIndex = 29
        '
        'BtnConsultar
        '
        Me.BtnConsultar.Location = New System.Drawing.Point(32, 14)
        Me.BtnConsultar.Name = "BtnConsultar"
        Me.BtnConsultar.Size = New System.Drawing.Size(75, 23)
        Me.BtnConsultar.TabIndex = 30
        Me.BtnConsultar.Text = "Consultar"
        Me.BtnConsultar.UseVisualStyleBackColor = True
        '
        'Btnmapeo
        '
        Me.Btnmapeo.Location = New System.Drawing.Point(857, 14)
        Me.Btnmapeo.Name = "Btnmapeo"
        Me.Btnmapeo.Size = New System.Drawing.Size(75, 23)
        Me.Btnmapeo.TabIndex = 32
        Me.Btnmapeo.Text = "Consultar"
        Me.Btnmapeo.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(950, 584)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(150, 23)
        Me.Button1.TabIndex = 33
        Me.Button1.Text = "obtener coordenadas"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BtnOpen
        '
        Me.BtnOpen.Location = New System.Drawing.Point(857, 649)
        Me.BtnOpen.Name = "BtnOpen"
        Me.BtnOpen.Size = New System.Drawing.Size(75, 23)
        Me.BtnOpen.TabIndex = 34
        Me.BtnOpen.Text = "Consultar"
        Me.BtnOpen.UseVisualStyleBackColor = True
        '
        'FrmMapeo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1263, 749)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmMapeo"
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Gb.ResumeLayout(False)
        CType(Me.DgvDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DgvDatos As DataGridView
    Friend WithEvents BtnConsultar As Button
    Friend WithEvents Btnmapeo As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents BtnOpen As Button
End Class
