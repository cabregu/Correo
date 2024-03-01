<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConfiguracion
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
        Me.BtnFeriados = New System.Windows.Forms.Button
        Me.DgvControl = New System.Windows.Forms.DataGridView
        Me.BtncargarDatos = New System.Windows.Forms.Button
        Me.BtnVerificarArchivos = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Gb.SuspendLayout()
        CType(Me.DgvControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PBLogo
        '
        Me.PBLogo.Location = New System.Drawing.Point(5, 447)
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(946, 447)
        '
        'Gb
        '
        Me.Gb.Controls.Add(Me.Button1)
        Me.Gb.Controls.Add(Me.DgvControl)
        Me.Gb.Controls.Add(Me.BtnFeriados)
        Me.Gb.Controls.Add(Me.BtnVerificarArchivos)
        Me.Gb.Controls.Add(Me.BtncargarDatos)
        Me.Gb.Location = New System.Drawing.Point(0, 0)
        Me.Gb.Size = New System.Drawing.Size(993, 498)
        Me.Gb.Controls.SetChildIndex(Me.BtncargarDatos, 0)
        Me.Gb.Controls.SetChildIndex(Me.BtnVerificarArchivos, 0)
        Me.Gb.Controls.SetChildIndex(Me.BtnFeriados, 0)
        Me.Gb.Controls.SetChildIndex(Me.DgvControl, 0)
        Me.Gb.Controls.SetChildIndex(Me.Button1, 0)
        Me.Gb.Controls.SetChildIndex(Me.PBLogo, 0)
        Me.Gb.Controls.SetChildIndex(Me.BtnSalir, 0)
        '
        'BtnFeriados
        '
        Me.BtnFeriados.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnFeriados.Location = New System.Drawing.Point(907, 19)
        Me.BtnFeriados.Name = "BtnFeriados"
        Me.BtnFeriados.Size = New System.Drawing.Size(75, 23)
        Me.BtnFeriados.TabIndex = 32
        Me.BtnFeriados.Text = "Feriados"
        Me.BtnFeriados.UseVisualStyleBackColor = True
        '
        'DgvControl
        '
        Me.DgvControl.AllowUserToAddRows = False
        Me.DgvControl.AllowUserToDeleteRows = False
        Me.DgvControl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvControl.Location = New System.Drawing.Point(47, 36)
        Me.DgvControl.Name = "DgvControl"
        Me.DgvControl.ReadOnly = True
        Me.DgvControl.Size = New System.Drawing.Size(636, 400)
        Me.DgvControl.TabIndex = 33
        '
        'BtncargarDatos
        '
        Me.BtncargarDatos.Location = New System.Drawing.Point(704, 36)
        Me.BtncargarDatos.Name = "BtncargarDatos"
        Me.BtncargarDatos.Size = New System.Drawing.Size(75, 23)
        Me.BtncargarDatos.TabIndex = 34
        Me.BtncargarDatos.Text = "Cargar"
        Me.BtncargarDatos.UseVisualStyleBackColor = True
        '
        'BtnVerificarArchivos
        '
        Me.BtnVerificarArchivos.Location = New System.Drawing.Point(704, 65)
        Me.BtnVerificarArchivos.Name = "BtnVerificarArchivos"
        Me.BtnVerificarArchivos.Size = New System.Drawing.Size(75, 23)
        Me.BtnVerificarArchivos.TabIndex = 35
        Me.BtnVerificarArchivos.Text = "Verificar"
        Me.BtnVerificarArchivos.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(788, 161)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 36
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FrmConfiguracion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(994, 499)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmConfiguracion"
        Me.Text = "Configuracion"
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Gb.ResumeLayout(False)
        CType(Me.DgvControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnFeriados As System.Windows.Forms.Button
    Friend WithEvents DgvControl As System.Windows.Forms.DataGridView
    Friend WithEvents BtncargarDatos As System.Windows.Forms.Button
    Friend WithEvents BtnVerificarArchivos As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
