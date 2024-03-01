<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmImpDesdeExcel
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmImpDesdeExcel))
        Me.LblCodigo = New System.Windows.Forms.Label()
        Me.CmbCodigo = New System.Windows.Forms.ComboBox()
        Me.CmbRemito = New System.Windows.Forms.ComboBox()
        Me.LblRemito = New System.Windows.Forms.Label()
        Me.DtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.LblFechalimite = New System.Windows.Forms.Label()
        Me.BtnImportar = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Dgvimportar = New System.Windows.Forms.DataGridView()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnSeleccionDirecta = New System.Windows.Forms.Button()
        Me.TxtNro = New System.Windows.Forms.TextBox()
        Me.LblNro = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblCantidad = New System.Windows.Forms.Label()
        Me.BtnExcel = New System.Windows.Forms.Button()
        Me.BtnAchivoComun = New System.Windows.Forms.Button()
        CType(Me.Dgvimportar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblCodigo
        '
        Me.LblCodigo.AutoSize = True
        Me.LblCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCodigo.ForeColor = System.Drawing.Color.Maroon
        Me.LblCodigo.Location = New System.Drawing.Point(3, 8)
        Me.LblCodigo.Name = "LblCodigo"
        Me.LblCodigo.Size = New System.Drawing.Size(46, 13)
        Me.LblCodigo.TabIndex = 69
        Me.LblCodigo.Text = "Codigo"
        '
        'CmbCodigo
        '
        Me.CmbCodigo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbCodigo.FormattingEnabled = True
        Me.CmbCodigo.Location = New System.Drawing.Point(6, 27)
        Me.CmbCodigo.Name = "CmbCodigo"
        Me.CmbCodigo.Size = New System.Drawing.Size(165, 21)
        Me.CmbCodigo.TabIndex = 68
        '
        'CmbRemito
        '
        Me.CmbRemito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbRemito.Enabled = False
        Me.CmbRemito.FormattingEnabled = True
        Me.CmbRemito.Location = New System.Drawing.Point(203, 27)
        Me.CmbRemito.Name = "CmbRemito"
        Me.CmbRemito.Size = New System.Drawing.Size(135, 21)
        Me.CmbRemito.TabIndex = 75
        '
        'LblRemito
        '
        Me.LblRemito.AutoSize = True
        Me.LblRemito.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRemito.ForeColor = System.Drawing.Color.Maroon
        Me.LblRemito.Location = New System.Drawing.Point(200, 8)
        Me.LblRemito.Name = "LblRemito"
        Me.LblRemito.Size = New System.Drawing.Size(46, 13)
        Me.LblRemito.TabIndex = 76
        Me.LblRemito.Text = "Remito"
        '
        'DtpFecha
        '
        Me.DtpFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpFecha.Location = New System.Drawing.Point(630, 27)
        Me.DtpFecha.Name = "DtpFecha"
        Me.DtpFecha.Size = New System.Drawing.Size(240, 21)
        Me.DtpFecha.TabIndex = 81
        '
        'LblFechalimite
        '
        Me.LblFechalimite.AutoSize = True
        Me.LblFechalimite.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFechalimite.ForeColor = System.Drawing.Color.Maroon
        Me.LblFechalimite.Location = New System.Drawing.Point(627, 8)
        Me.LblFechalimite.Name = "LblFechalimite"
        Me.LblFechalimite.Size = New System.Drawing.Size(109, 13)
        Me.LblFechalimite.TabIndex = 82
        Me.LblFechalimite.Text = "Fecha De Trabajo"
        '
        'BtnImportar
        '
        Me.BtnImportar.Enabled = False
        Me.BtnImportar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnImportar.ForeColor = System.Drawing.Color.Maroon
        Me.BtnImportar.Location = New System.Drawing.Point(6, 457)
        Me.BtnImportar.Name = "BtnImportar"
        Me.BtnImportar.Size = New System.Drawing.Size(165, 45)
        Me.BtnImportar.TabIndex = 73
        Me.BtnImportar.Text = "Importar"
        Me.BtnImportar.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'Dgvimportar
        '
        Me.Dgvimportar.AllowUserToAddRows = False
        Me.Dgvimportar.AllowUserToDeleteRows = False
        Me.Dgvimportar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgvimportar.Location = New System.Drawing.Point(3, 157)
        Me.Dgvimportar.Name = "Dgvimportar"
        Me.Dgvimportar.ReadOnly = True
        Me.Dgvimportar.Size = New System.Drawing.Size(891, 275)
        Me.Dgvimportar.TabIndex = 85
        '
        'BtnSalir
        '
        Me.BtnSalir.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnSalir.Image = CType(resources.GetObject("BtnSalir.Image"), System.Drawing.Image)
        Me.BtnSalir.Location = New System.Drawing.Point(856, 457)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(41, 45)
        Me.BtnSalir.TabIndex = 80
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'BtnSeleccionDirecta
        '
        Me.BtnSeleccionDirecta.Enabled = False
        Me.BtnSeleccionDirecta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSeleccionDirecta.ForeColor = System.Drawing.Color.Maroon
        Me.BtnSeleccionDirecta.Location = New System.Drawing.Point(6, 128)
        Me.BtnSeleccionDirecta.Name = "BtnSeleccionDirecta"
        Me.BtnSeleccionDirecta.Size = New System.Drawing.Size(147, 23)
        Me.BtnSeleccionDirecta.TabIndex = 94
        Me.BtnSeleccionDirecta.Text = "Seleccion Directa"
        Me.BtnSeleccionDirecta.UseVisualStyleBackColor = True
        '
        'TxtNro
        '
        Me.TxtNro.Location = New System.Drawing.Point(6, 80)
        Me.TxtNro.Name = "TxtNro"
        Me.TxtNro.Size = New System.Drawing.Size(100, 20)
        Me.TxtNro.TabIndex = 95
        '
        'LblNro
        '
        Me.LblNro.AutoSize = True
        Me.LblNro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNro.ForeColor = System.Drawing.Color.Maroon
        Me.LblNro.Location = New System.Drawing.Point(3, 60)
        Me.LblNro.Name = "LblNro"
        Me.LblNro.Size = New System.Drawing.Size(171, 13)
        Me.LblNro.TabIndex = 96
        Me.LblNro.Text = "Fecha del Archivo de trabajo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(3, 103)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 97
        Me.Label1.Text = "D XX-XX"
        '
        'LblCantidad
        '
        Me.LblCantidad.AutoSize = True
        Me.LblCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCantidad.ForeColor = System.Drawing.Color.Maroon
        Me.LblCantidad.Location = New System.Drawing.Point(737, 435)
        Me.LblCantidad.Name = "LblCantidad"
        Me.LblCantidad.Size = New System.Drawing.Size(14, 13)
        Me.LblCantidad.TabIndex = 98
        Me.LblCantidad.Text = "0"
        '
        'BtnExcel
        '
        Me.BtnExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnExcel.Image = Global.Correo.My.Resources.Resources.table_excel
        Me.BtnExcel.Location = New System.Drawing.Point(847, 103)
        Me.BtnExcel.Name = "BtnExcel"
        Me.BtnExcel.Size = New System.Drawing.Size(47, 48)
        Me.BtnExcel.TabIndex = 99
        Me.BtnExcel.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.BtnExcel.UseVisualStyleBackColor = True
        '
        'BtnAchivoComun
        '
        Me.BtnAchivoComun.Enabled = False
        Me.BtnAchivoComun.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAchivoComun.ForeColor = System.Drawing.Color.Maroon
        Me.BtnAchivoComun.Location = New System.Drawing.Point(191, 128)
        Me.BtnAchivoComun.Name = "BtnAchivoComun"
        Me.BtnAchivoComun.Size = New System.Drawing.Size(147, 23)
        Me.BtnAchivoComun.TabIndex = 101
        Me.BtnAchivoComun.Text = "Archivo Comun"
        Me.BtnAchivoComun.UseVisualStyleBackColor = True
        '
        'FrmImpDesdeExcel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(906, 514)
        Me.Controls.Add(Me.BtnAchivoComun)
        Me.Controls.Add(Me.BtnExcel)
        Me.Controls.Add(Me.LblCantidad)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblNro)
        Me.Controls.Add(Me.TxtNro)
        Me.Controls.Add(Me.BtnSeleccionDirecta)
        Me.Controls.Add(Me.Dgvimportar)
        Me.Controls.Add(Me.LblFechalimite)
        Me.Controls.Add(Me.DtpFecha)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.LblRemito)
        Me.Controls.Add(Me.CmbRemito)
        Me.Controls.Add(Me.BtnImportar)
        Me.Controls.Add(Me.LblCodigo)
        Me.Controls.Add(Me.CmbCodigo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmImpDesdeExcel"
        Me.Text = "Importar Desde Excel"
        CType(Me.Dgvimportar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnImportar As System.Windows.Forms.Button
    Friend WithEvents LblCodigo As System.Windows.Forms.Label
    Friend WithEvents CmbCodigo As System.Windows.Forms.ComboBox
    Friend WithEvents CmbRemito As System.Windows.Forms.ComboBox
    Friend WithEvents LblRemito As System.Windows.Forms.Label
    Public WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents DtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents LblFechalimite As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Dgvimportar As System.Windows.Forms.DataGridView
    Friend WithEvents BtnSeleccionDirecta As Button
    Friend WithEvents TxtNro As TextBox
    Friend WithEvents LblNro As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LblCantidad As Label
    Friend WithEvents BtnExcel As Button
    Friend WithEvents BtnAchivoComun As Button
End Class
