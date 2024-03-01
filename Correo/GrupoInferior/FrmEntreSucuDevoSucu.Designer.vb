<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEntreSucuDevoSucu
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
        Me.DgvControl = New System.Windows.Forms.DataGridView()
        Me.BtnActualizarDesdeExcel = New System.Windows.Forms.Button()
        Me.BtncargarDatos = New System.Windows.Forms.Button()
        Me.txtPath = New System.Windows.Forms.TextBox()
        Me.LblDescripcion = New System.Windows.Forms.Label()
        Me.ChkEntreSucu = New System.Windows.Forms.CheckBox()
        Me.ChkDevoSucu = New System.Windows.Forms.CheckBox()
        Me.PgbAnalisis = New System.Windows.Forms.ProgressBar()
        Me.ChkOtro = New System.Windows.Forms.CheckBox()
        Me.BtnActualizarOtroDato = New System.Windows.Forms.Button()
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Gb.SuspendLayout()
        CType(Me.DgvControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PBLogo
        '
        Me.PBLogo.Location = New System.Drawing.Point(5, 658)
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(841, 658)
        '
        'Gb
        '
        Me.Gb.Controls.Add(Me.BtnActualizarOtroDato)
        Me.Gb.Controls.Add(Me.ChkOtro)
        Me.Gb.Controls.Add(Me.PgbAnalisis)
        Me.Gb.Controls.Add(Me.ChkDevoSucu)
        Me.Gb.Controls.Add(Me.ChkEntreSucu)
        Me.Gb.Controls.Add(Me.LblDescripcion)
        Me.Gb.Controls.Add(Me.txtPath)
        Me.Gb.Controls.Add(Me.DgvControl)
        Me.Gb.Controls.Add(Me.BtnActualizarDesdeExcel)
        Me.Gb.Controls.Add(Me.BtncargarDatos)
        Me.Gb.Location = New System.Drawing.Point(1, 3)
        Me.Gb.Size = New System.Drawing.Size(888, 709)
        Me.Gb.Controls.SetChildIndex(Me.PBLogo, 0)
        Me.Gb.Controls.SetChildIndex(Me.BtncargarDatos, 0)
        Me.Gb.Controls.SetChildIndex(Me.BtnSalir, 0)
        Me.Gb.Controls.SetChildIndex(Me.BtnActualizarDesdeExcel, 0)
        Me.Gb.Controls.SetChildIndex(Me.DgvControl, 0)
        Me.Gb.Controls.SetChildIndex(Me.txtPath, 0)
        Me.Gb.Controls.SetChildIndex(Me.LblDescripcion, 0)
        Me.Gb.Controls.SetChildIndex(Me.ChkEntreSucu, 0)
        Me.Gb.Controls.SetChildIndex(Me.ChkDevoSucu, 0)
        Me.Gb.Controls.SetChildIndex(Me.PgbAnalisis, 0)
        Me.Gb.Controls.SetChildIndex(Me.ChkOtro, 0)
        Me.Gb.Controls.SetChildIndex(Me.BtnActualizarOtroDato, 0)
        '
        'DgvControl
        '
        Me.DgvControl.AllowUserToAddRows = False
        Me.DgvControl.AllowUserToDeleteRows = False
        Me.DgvControl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvControl.Location = New System.Drawing.Point(11, 122)
        Me.DgvControl.Name = "DgvControl"
        Me.DgvControl.ReadOnly = True
        Me.DgvControl.Size = New System.Drawing.Size(600, 500)
        Me.DgvControl.TabIndex = 36
        '
        'BtnActualizarDesdeExcel
        '
        Me.BtnActualizarDesdeExcel.Location = New System.Drawing.Point(617, 122)
        Me.BtnActualizarDesdeExcel.Name = "BtnActualizarDesdeExcel"
        Me.BtnActualizarDesdeExcel.Size = New System.Drawing.Size(150, 23)
        Me.BtnActualizarDesdeExcel.TabIndex = 38
        Me.BtnActualizarDesdeExcel.Text = "Actualizar Cartas"
        Me.BtnActualizarDesdeExcel.UseVisualStyleBackColor = True
        '
        'BtncargarDatos
        '
        Me.BtncargarDatos.Enabled = False
        Me.BtncargarDatos.Location = New System.Drawing.Point(317, 85)
        Me.BtncargarDatos.Name = "BtncargarDatos"
        Me.BtncargarDatos.Size = New System.Drawing.Size(75, 23)
        Me.BtncargarDatos.TabIndex = 37
        Me.BtncargarDatos.Text = "..."
        Me.BtncargarDatos.UseVisualStyleBackColor = True
        '
        'txtPath
        '
        Me.txtPath.Location = New System.Drawing.Point(11, 88)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.Size = New System.Drawing.Size(300, 20)
        Me.txtPath.TabIndex = 39
        '
        'LblDescripcion
        '
        Me.LblDescripcion.AutoSize = True
        Me.LblDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDescripcion.Location = New System.Drawing.Point(11, 34)
        Me.LblDescripcion.Name = "LblDescripcion"
        Me.LblDescripcion.Size = New System.Drawing.Size(818, 29)
        Me.LblDescripcion.TabIndex = 40
        Me.LblDescripcion.Text = "Los campo deben ser ""Nro_carta, Fecha y Estado"" y la hoja debe ser ""Lexs"""
        '
        'ChkEntreSucu
        '
        Me.ChkEntreSucu.AutoSize = True
        Me.ChkEntreSucu.Location = New System.Drawing.Point(413, 90)
        Me.ChkEntreSucu.Name = "ChkEntreSucu"
        Me.ChkEntreSucu.Size = New System.Drawing.Size(79, 17)
        Me.ChkEntreSucu.TabIndex = 41
        Me.ChkEntreSucu.Text = "Entre Sucu"
        Me.ChkEntreSucu.UseVisualStyleBackColor = True
        '
        'ChkDevoSucu
        '
        Me.ChkDevoSucu.AutoSize = True
        Me.ChkDevoSucu.Location = New System.Drawing.Point(498, 90)
        Me.ChkDevoSucu.Name = "ChkDevoSucu"
        Me.ChkDevoSucu.Size = New System.Drawing.Size(80, 17)
        Me.ChkDevoSucu.TabIndex = 42
        Me.ChkDevoSucu.Text = "Devo Sucu"
        Me.ChkDevoSucu.UseVisualStyleBackColor = True
        '
        'PgbAnalisis
        '
        Me.PgbAnalisis.Location = New System.Drawing.Point(11, 628)
        Me.PgbAnalisis.Name = "PgbAnalisis"
        Me.PgbAnalisis.Size = New System.Drawing.Size(600, 10)
        Me.PgbAnalisis.TabIndex = 52
        '
        'ChkOtro
        '
        Me.ChkOtro.AutoSize = True
        Me.ChkOtro.Location = New System.Drawing.Point(584, 91)
        Me.ChkOtro.Name = "ChkOtro"
        Me.ChkOtro.Size = New System.Drawing.Size(72, 17)
        Me.ChkOtro.TabIndex = 53
        Me.ChkOtro.Text = "Otro Dato"
        Me.ChkOtro.UseVisualStyleBackColor = True
        '
        'BtnActualizarOtroDato
        '
        Me.BtnActualizarOtroDato.Location = New System.Drawing.Point(617, 151)
        Me.BtnActualizarOtroDato.Name = "BtnActualizarOtroDato"
        Me.BtnActualizarOtroDato.Size = New System.Drawing.Size(150, 23)
        Me.BtnActualizarOtroDato.TabIndex = 54
        Me.BtnActualizarOtroDato.Text = "Actualizar Otro Dato"
        Me.BtnActualizarOtroDato.UseVisualStyleBackColor = True
        '
        'FrmEntreSucuDevoSucu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(891, 712)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmEntreSucuDevoSucu"
        Me.Text = "Reporte de excel"
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Gb.ResumeLayout(False)
        Me.Gb.PerformLayout()
        CType(Me.DgvControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DgvControl As System.Windows.Forms.DataGridView
    Friend WithEvents BtnActualizarDesdeExcel As System.Windows.Forms.Button
    Friend WithEvents BtncargarDatos As System.Windows.Forms.Button
    Friend WithEvents txtPath As System.Windows.Forms.TextBox
    Friend WithEvents LblDescripcion As System.Windows.Forms.Label
    Friend WithEvents ChkDevoSucu As System.Windows.Forms.CheckBox
    Friend WithEvents ChkEntreSucu As System.Windows.Forms.CheckBox
    Friend WithEvents PgbAnalisis As System.Windows.Forms.ProgressBar
    Friend WithEvents ChkOtro As System.Windows.Forms.CheckBox
    Friend WithEvents BtnActualizarOtroDato As System.Windows.Forms.Button

End Class
