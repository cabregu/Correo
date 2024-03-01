<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEstadistica
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
        Me.DgvResultado1 = New System.Windows.Forms.DataGridView()
        Me.BtnConsultar = New System.Windows.Forms.Button()
        Me.LblCantidad = New System.Windows.Forms.Label()
        Me.Btnxls = New System.Windows.Forms.Button()
        Me.Dgvcontador = New System.Windows.Forms.DataGridView()
        Me.Btnxls2 = New System.Windows.Forms.Button()
        Me.DtpDesde = New System.Windows.Forms.DateTimePicker()
        Me.DtpHasta = New System.Windows.Forms.DateTimePicker()
        Me.LblDe = New System.Windows.Forms.Label()
        Me.LblA = New System.Windows.Forms.Label()
        Me.BtnPlanilla = New System.Windows.Forms.Button()
        Me.DgvPlanilla = New System.Windows.Forms.DataGridView()
        Me.Xls3 = New System.Windows.Forms.Button()
        Me.DgvCarteros = New System.Windows.Forms.DataGridView()
        Me.BtnCarteros = New System.Windows.Forms.Button()
        Me.DgvEstados = New System.Windows.Forms.DataGridView()
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Gb.SuspendLayout()
        CType(Me.DgvResultado1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dgvcontador, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvPlanilla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvCarteros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvEstados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PBLogo
        '
        Me.PBLogo.Location = New System.Drawing.Point(5, 699)
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(1323, 699)
        '
        'Gb
        '
        Me.Gb.Controls.Add(Me.DgvEstados)
        Me.Gb.Controls.Add(Me.BtnCarteros)
        Me.Gb.Controls.Add(Me.DgvCarteros)
        Me.Gb.Controls.Add(Me.Xls3)
        Me.Gb.Controls.Add(Me.DgvPlanilla)
        Me.Gb.Controls.Add(Me.BtnPlanilla)
        Me.Gb.Controls.Add(Me.LblA)
        Me.Gb.Controls.Add(Me.LblDe)
        Me.Gb.Controls.Add(Me.DtpHasta)
        Me.Gb.Controls.Add(Me.DtpDesde)
        Me.Gb.Controls.Add(Me.Btnxls2)
        Me.Gb.Controls.Add(Me.DgvResultado1)
        Me.Gb.Controls.Add(Me.Dgvcontador)
        Me.Gb.Controls.Add(Me.BtnConsultar)
        Me.Gb.Controls.Add(Me.LblCantidad)
        Me.Gb.Controls.Add(Me.Btnxls)
        Me.Gb.Size = New System.Drawing.Size(1370, 750)
        Me.Gb.Controls.SetChildIndex(Me.Btnxls, 0)
        Me.Gb.Controls.SetChildIndex(Me.LblCantidad, 0)
        Me.Gb.Controls.SetChildIndex(Me.BtnConsultar, 0)
        Me.Gb.Controls.SetChildIndex(Me.Dgvcontador, 0)
        Me.Gb.Controls.SetChildIndex(Me.DgvResultado1, 0)
        Me.Gb.Controls.SetChildIndex(Me.PBLogo, 0)
        Me.Gb.Controls.SetChildIndex(Me.BtnSalir, 0)
        Me.Gb.Controls.SetChildIndex(Me.Btnxls2, 0)
        Me.Gb.Controls.SetChildIndex(Me.DtpDesde, 0)
        Me.Gb.Controls.SetChildIndex(Me.DtpHasta, 0)
        Me.Gb.Controls.SetChildIndex(Me.LblDe, 0)
        Me.Gb.Controls.SetChildIndex(Me.LblA, 0)
        Me.Gb.Controls.SetChildIndex(Me.BtnPlanilla, 0)
        Me.Gb.Controls.SetChildIndex(Me.DgvPlanilla, 0)
        Me.Gb.Controls.SetChildIndex(Me.Xls3, 0)
        Me.Gb.Controls.SetChildIndex(Me.DgvCarteros, 0)
        Me.Gb.Controls.SetChildIndex(Me.BtnCarteros, 0)
        Me.Gb.Controls.SetChildIndex(Me.DgvEstados, 0)
        '
        'DgvResultado1
        '
        Me.DgvResultado1.AllowUserToAddRows = False
        Me.DgvResultado1.AllowUserToDeleteRows = False
        Me.DgvResultado1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvResultado1.Location = New System.Drawing.Point(368, 50)
        Me.DgvResultado1.Name = "DgvResultado1"
        Me.DgvResultado1.ReadOnly = True
        Me.DgvResultado1.Size = New System.Drawing.Size(260, 240)
        Me.DgvResultado1.TabIndex = 29
        '
        'BtnConsultar
        '
        Me.BtnConsultar.Location = New System.Drawing.Point(287, 19)
        Me.BtnConsultar.Name = "BtnConsultar"
        Me.BtnConsultar.Size = New System.Drawing.Size(75, 23)
        Me.BtnConsultar.TabIndex = 30
        Me.BtnConsultar.Text = "Consultar"
        Me.BtnConsultar.UseVisualStyleBackColor = True
        '
        'LblCantidad
        '
        Me.LblCantidad.AutoSize = True
        Me.LblCantidad.Location = New System.Drawing.Point(299, 301)
        Me.LblCantidad.Name = "LblCantidad"
        Me.LblCantidad.Size = New System.Drawing.Size(63, 13)
        Me.LblCantidad.TabIndex = 31
        Me.LblCantidad.Text = "LblCantidad"
        '
        'Btnxls
        '
        Me.Btnxls.Location = New System.Drawing.Point(12, 296)
        Me.Btnxls.Name = "Btnxls"
        Me.Btnxls.Size = New System.Drawing.Size(75, 23)
        Me.Btnxls.TabIndex = 32
        Me.Btnxls.Text = "Xls"
        Me.Btnxls.UseVisualStyleBackColor = True
        '
        'Dgvcontador
        '
        Me.Dgvcontador.AllowUserToAddRows = False
        Me.Dgvcontador.AllowUserToDeleteRows = False
        Me.Dgvcontador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgvcontador.Location = New System.Drawing.Point(12, 50)
        Me.Dgvcontador.Name = "Dgvcontador"
        Me.Dgvcontador.ReadOnly = True
        Me.Dgvcontador.Size = New System.Drawing.Size(350, 240)
        Me.Dgvcontador.TabIndex = 33
        '
        'Btnxls2
        '
        Me.Btnxls2.Location = New System.Drawing.Point(368, 296)
        Me.Btnxls2.Name = "Btnxls2"
        Me.Btnxls2.Size = New System.Drawing.Size(75, 23)
        Me.Btnxls2.TabIndex = 34
        Me.Btnxls2.Text = "Xls"
        Me.Btnxls2.UseVisualStyleBackColor = True
        '
        'DtpDesde
        '
        Me.DtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpDesde.Location = New System.Drawing.Point(39, 20)
        Me.DtpDesde.Name = "DtpDesde"
        Me.DtpDesde.Size = New System.Drawing.Size(100, 20)
        Me.DtpDesde.TabIndex = 35
        '
        'DtpHasta
        '
        Me.DtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpHasta.Location = New System.Drawing.Point(165, 20)
        Me.DtpHasta.Name = "DtpHasta"
        Me.DtpHasta.Size = New System.Drawing.Size(100, 20)
        Me.DtpHasta.TabIndex = 36
        '
        'LblDe
        '
        Me.LblDe.AutoSize = True
        Me.LblDe.Location = New System.Drawing.Point(12, 25)
        Me.LblDe.Name = "LblDe"
        Me.LblDe.Size = New System.Drawing.Size(22, 13)
        Me.LblDe.TabIndex = 37
        Me.LblDe.Text = "DE"
        '
        'LblA
        '
        Me.LblA.AutoSize = True
        Me.LblA.Location = New System.Drawing.Point(145, 25)
        Me.LblA.Name = "LblA"
        Me.LblA.Size = New System.Drawing.Size(14, 13)
        Me.LblA.TabIndex = 38
        Me.LblA.Text = "A"
        '
        'BtnPlanilla
        '
        Me.BtnPlanilla.Location = New System.Drawing.Point(15, 347)
        Me.BtnPlanilla.Name = "BtnPlanilla"
        Me.BtnPlanilla.Size = New System.Drawing.Size(75, 23)
        Me.BtnPlanilla.TabIndex = 39
        Me.BtnPlanilla.Text = "Planilla"
        Me.BtnPlanilla.UseVisualStyleBackColor = True
        '
        'DgvPlanilla
        '
        Me.DgvPlanilla.AllowUserToAddRows = False
        Me.DgvPlanilla.AllowUserToDeleteRows = False
        Me.DgvPlanilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvPlanilla.Location = New System.Drawing.Point(108, 347)
        Me.DgvPlanilla.Name = "DgvPlanilla"
        Me.DgvPlanilla.ReadOnly = True
        Me.DgvPlanilla.Size = New System.Drawing.Size(520, 250)
        Me.DgvPlanilla.TabIndex = 40
        '
        'Xls3
        '
        Me.Xls3.Location = New System.Drawing.Point(553, 603)
        Me.Xls3.Name = "Xls3"
        Me.Xls3.Size = New System.Drawing.Size(75, 23)
        Me.Xls3.TabIndex = 41
        Me.Xls3.Text = "Xls"
        Me.Xls3.UseVisualStyleBackColor = True
        '
        'DgvCarteros
        '
        Me.DgvCarteros.AllowUserToAddRows = False
        Me.DgvCarteros.AllowUserToDeleteRows = False
        Me.DgvCarteros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvCarteros.Location = New System.Drawing.Point(634, 347)
        Me.DgvCarteros.Name = "DgvCarteros"
        Me.DgvCarteros.ReadOnly = True
        Me.DgvCarteros.Size = New System.Drawing.Size(260, 250)
        Me.DgvCarteros.TabIndex = 42
        '
        'BtnCarteros
        '
        Me.BtnCarteros.Location = New System.Drawing.Point(634, 318)
        Me.BtnCarteros.Name = "BtnCarteros"
        Me.BtnCarteros.Size = New System.Drawing.Size(75, 23)
        Me.BtnCarteros.TabIndex = 43
        Me.BtnCarteros.Text = "Carteros"
        Me.BtnCarteros.UseVisualStyleBackColor = True
        '
        'DgvEstados
        '
        Me.DgvEstados.AllowUserToAddRows = False
        Me.DgvEstados.AllowUserToDeleteRows = False
        Me.DgvEstados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvEstados.Location = New System.Drawing.Point(634, 50)
        Me.DgvEstados.Name = "DgvEstados"
        Me.DgvEstados.ReadOnly = True
        Me.DgvEstados.Size = New System.Drawing.Size(260, 240)
        Me.DgvEstados.TabIndex = 44
        '
        'FrmEstadistica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmEstadistica"
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Gb.ResumeLayout(False)
        Me.Gb.PerformLayout()
        CType(Me.DgvResultado1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dgvcontador, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvPlanilla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvCarteros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvEstados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DgvResultado1 As System.Windows.Forms.DataGridView
    Friend WithEvents BtnConsultar As System.Windows.Forms.Button
    Friend WithEvents LblCantidad As System.Windows.Forms.Label
    Friend WithEvents Btnxls As System.Windows.Forms.Button
    Friend WithEvents Dgvcontador As System.Windows.Forms.DataGridView
    Friend WithEvents Btnxls2 As System.Windows.Forms.Button
    Friend WithEvents LblA As System.Windows.Forms.Label
    Friend WithEvents LblDe As System.Windows.Forms.Label
    Friend WithEvents DtpHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents DtpDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents DgvPlanilla As System.Windows.Forms.DataGridView
    Friend WithEvents BtnPlanilla As System.Windows.Forms.Button
    Friend WithEvents Xls3 As System.Windows.Forms.Button
    Friend WithEvents DgvCarteros As System.Windows.Forms.DataGridView
    Friend WithEvents BtnCarteros As System.Windows.Forms.Button
    Friend WithEvents DgvEstados As System.Windows.Forms.DataGridView

End Class
