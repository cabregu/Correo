<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReporteZonal
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
        Me.CmbCartero = New System.Windows.Forms.ComboBox()
        Me.Dgvdatos = New System.Windows.Forms.DataGridView()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.DtpDesde = New System.Windows.Forms.DateTimePicker()
        Me.DtpHasta = New System.Windows.Forms.DateTimePicker()
        Me.LbaCartero = New System.Windows.Forms.Label()
        Me.Lblesde = New System.Windows.Forms.Label()
        Me.LblHasta = New System.Windows.Forms.Label()
        Me.BtnExcel = New System.Windows.Forms.Button()
        Me.BtnEstadistica = New System.Windows.Forms.Button()
        Me.TxtDat = New System.Windows.Forms.TextBox()
        Me.LblCant = New System.Windows.Forms.Label()
        Me.DgvCalculo = New System.Windows.Forms.DataGridView()
        Me.BtnCalculoCash = New System.Windows.Forms.Button()
        Me.BtnExcelControl = New System.Windows.Forms.Button()
        Me.Txttotal = New System.Windows.Forms.TextBox()
        Me.LblTotal = New System.Windows.Forms.Label()
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Gb.SuspendLayout()
        CType(Me.Dgvdatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvCalculo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PBLogo
        '
        Me.PBLogo.Location = New System.Drawing.Point(5, 659)
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(1092, 659)
        '
        'Gb
        '
        Me.Gb.Controls.Add(Me.LblTotal)
        Me.Gb.Controls.Add(Me.Txttotal)
        Me.Gb.Controls.Add(Me.BtnExcelControl)
        Me.Gb.Controls.Add(Me.BtnCalculoCash)
        Me.Gb.Controls.Add(Me.DgvCalculo)
        Me.Gb.Controls.Add(Me.LblCant)
        Me.Gb.Controls.Add(Me.TxtDat)
        Me.Gb.Controls.Add(Me.BtnEstadistica)
        Me.Gb.Controls.Add(Me.BtnExcel)
        Me.Gb.Controls.Add(Me.LblHasta)
        Me.Gb.Controls.Add(Me.Lblesde)
        Me.Gb.Controls.Add(Me.LbaCartero)
        Me.Gb.Controls.Add(Me.DtpHasta)
        Me.Gb.Controls.Add(Me.DtpDesde)
        Me.Gb.Controls.Add(Me.CmbCartero)
        Me.Gb.Controls.Add(Me.Dgvdatos)
        Me.Gb.Controls.Add(Me.BtnBuscar)
        Me.Gb.Location = New System.Drawing.Point(1, 1)
        Me.Gb.Size = New System.Drawing.Size(1139, 710)
        Me.Gb.Controls.SetChildIndex(Me.BtnBuscar, 0)
        Me.Gb.Controls.SetChildIndex(Me.PBLogo, 0)
        Me.Gb.Controls.SetChildIndex(Me.Dgvdatos, 0)
        Me.Gb.Controls.SetChildIndex(Me.BtnSalir, 0)
        Me.Gb.Controls.SetChildIndex(Me.CmbCartero, 0)
        Me.Gb.Controls.SetChildIndex(Me.DtpDesde, 0)
        Me.Gb.Controls.SetChildIndex(Me.DtpHasta, 0)
        Me.Gb.Controls.SetChildIndex(Me.LbaCartero, 0)
        Me.Gb.Controls.SetChildIndex(Me.Lblesde, 0)
        Me.Gb.Controls.SetChildIndex(Me.LblHasta, 0)
        Me.Gb.Controls.SetChildIndex(Me.BtnExcel, 0)
        Me.Gb.Controls.SetChildIndex(Me.BtnEstadistica, 0)
        Me.Gb.Controls.SetChildIndex(Me.TxtDat, 0)
        Me.Gb.Controls.SetChildIndex(Me.LblCant, 0)
        Me.Gb.Controls.SetChildIndex(Me.DgvCalculo, 0)
        Me.Gb.Controls.SetChildIndex(Me.BtnCalculoCash, 0)
        Me.Gb.Controls.SetChildIndex(Me.BtnExcelControl, 0)
        Me.Gb.Controls.SetChildIndex(Me.Txttotal, 0)
        Me.Gb.Controls.SetChildIndex(Me.LblTotal, 0)
        '
        'CmbCartero
        '
        Me.CmbCartero.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbCartero.FormattingEnabled = True
        Me.CmbCartero.Location = New System.Drawing.Point(11, 63)
        Me.CmbCartero.Name = "CmbCartero"
        Me.CmbCartero.Size = New System.Drawing.Size(180, 28)
        Me.CmbCartero.TabIndex = 35
        '
        'Dgvdatos
        '
        Me.Dgvdatos.AllowUserToAddRows = False
        Me.Dgvdatos.AllowUserToDeleteRows = False
        Me.Dgvdatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgvdatos.Location = New System.Drawing.Point(11, 134)
        Me.Dgvdatos.Name = "Dgvdatos"
        Me.Dgvdatos.ReadOnly = True
        Me.Dgvdatos.Size = New System.Drawing.Size(900, 268)
        Me.Dgvdatos.TabIndex = 34
        '
        'BtnBuscar
        '
        Me.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnBuscar.Image = Global.Correo.My.Resources.Resources.agt_action_success2
        Me.BtnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBuscar.Location = New System.Drawing.Point(487, 54)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(50, 47)
        Me.BtnBuscar.TabIndex = 30
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'DtpDesde
        '
        Me.DtpDesde.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpDesde.Location = New System.Drawing.Point(210, 65)
        Me.DtpDesde.Name = "DtpDesde"
        Me.DtpDesde.Size = New System.Drawing.Size(120, 26)
        Me.DtpDesde.TabIndex = 36
        '
        'DtpHasta
        '
        Me.DtpHasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpHasta.Location = New System.Drawing.Point(336, 65)
        Me.DtpHasta.Name = "DtpHasta"
        Me.DtpHasta.Size = New System.Drawing.Size(120, 26)
        Me.DtpHasta.TabIndex = 37
        '
        'LbaCartero
        '
        Me.LbaCartero.AutoSize = True
        Me.LbaCartero.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbaCartero.Location = New System.Drawing.Point(10, 42)
        Me.LbaCartero.Name = "LbaCartero"
        Me.LbaCartero.Size = New System.Drawing.Size(94, 20)
        Me.LbaCartero.TabIndex = 38
        Me.LbaCartero.Text = "CARTERO"
        '
        'Lblesde
        '
        Me.Lblesde.AutoSize = True
        Me.Lblesde.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblesde.Location = New System.Drawing.Point(206, 42)
        Me.Lblesde.Name = "Lblesde"
        Me.Lblesde.Size = New System.Drawing.Size(71, 20)
        Me.Lblesde.TabIndex = 39
        Me.Lblesde.Text = "DESDE"
        '
        'LblHasta
        '
        Me.LblHasta.AutoSize = True
        Me.LblHasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHasta.Location = New System.Drawing.Point(332, 42)
        Me.LblHasta.Name = "LblHasta"
        Me.LblHasta.Size = New System.Drawing.Size(68, 20)
        Me.LblHasta.TabIndex = 40
        Me.LblHasta.Text = "HASTA"
        '
        'BtnExcel
        '
        Me.BtnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnExcel.Image = Global.Correo.My.Resources.Resources.table_excel
        Me.BtnExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnExcel.Location = New System.Drawing.Point(917, 135)
        Me.BtnExcel.Name = "BtnExcel"
        Me.BtnExcel.Size = New System.Drawing.Size(50, 47)
        Me.BtnExcel.TabIndex = 41
        Me.BtnExcel.UseVisualStyleBackColor = True
        '
        'BtnEstadistica
        '
        Me.BtnEstadistica.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnEstadistica.Image = Global.Correo.My.Resources.Resources.filefind
        Me.BtnEstadistica.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEstadistica.Location = New System.Drawing.Point(917, 188)
        Me.BtnEstadistica.Name = "BtnEstadistica"
        Me.BtnEstadistica.Size = New System.Drawing.Size(50, 47)
        Me.BtnEstadistica.TabIndex = 42
        Me.BtnEstadistica.UseVisualStyleBackColor = True
        '
        'TxtDat
        '
        Me.TxtDat.Location = New System.Drawing.Point(917, 243)
        Me.TxtDat.Multiline = True
        Me.TxtDat.Name = "TxtDat"
        Me.TxtDat.Size = New System.Drawing.Size(200, 150)
        Me.TxtDat.TabIndex = 43
        '
        'LblCant
        '
        Me.LblCant.AutoSize = True
        Me.LblCant.Location = New System.Drawing.Point(862, 118)
        Me.LblCant.Name = "LblCant"
        Me.LblCant.Size = New System.Drawing.Size(49, 13)
        Me.LblCant.TabIndex = 44
        Me.LblCant.Text = "Cantidad"
        '
        'DgvCalculo
        '
        Me.DgvCalculo.AllowUserToAddRows = False
        Me.DgvCalculo.AllowUserToDeleteRows = False
        Me.DgvCalculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvCalculo.Location = New System.Drawing.Point(81, 408)
        Me.DgvCalculo.Name = "DgvCalculo"
        Me.DgvCalculo.ReadOnly = True
        Me.DgvCalculo.Size = New System.Drawing.Size(830, 180)
        Me.DgvCalculo.TabIndex = 45
        '
        'BtnCalculoCash
        '
        Me.BtnCalculoCash.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnCalculoCash.Image = Global.Correo.My.Resources.Resources.cash
        Me.BtnCalculoCash.Location = New System.Drawing.Point(14, 408)
        Me.BtnCalculoCash.Name = "BtnCalculoCash"
        Me.BtnCalculoCash.Size = New System.Drawing.Size(50, 47)
        Me.BtnCalculoCash.TabIndex = 46
        Me.BtnCalculoCash.UseVisualStyleBackColor = True
        '
        'BtnExcelControl
        '
        Me.BtnExcelControl.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnExcelControl.Image = Global.Correo.My.Resources.Resources.table_excel
        Me.BtnExcelControl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnExcelControl.Location = New System.Drawing.Point(917, 408)
        Me.BtnExcelControl.Name = "BtnExcelControl"
        Me.BtnExcelControl.Size = New System.Drawing.Size(50, 47)
        Me.BtnExcelControl.TabIndex = 47
        Me.BtnExcelControl.UseVisualStyleBackColor = True
        '
        'Txttotal
        '
        Me.Txttotal.Location = New System.Drawing.Point(811, 594)
        Me.Txttotal.Name = "Txttotal"
        Me.Txttotal.Size = New System.Drawing.Size(100, 20)
        Me.Txttotal.TabIndex = 48
        '
        'LblTotal
        '
        Me.LblTotal.AutoSize = True
        Me.LblTotal.Location = New System.Drawing.Point(754, 601)
        Me.LblTotal.Name = "LblTotal"
        Me.LblTotal.Size = New System.Drawing.Size(42, 13)
        Me.LblTotal.TabIndex = 49
        Me.LblTotal.Text = "TOTAL"
        '
        'FrmReporteZonal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1142, 712)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmReporteZonal"
        Me.Text = "Asignar Zonal"
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Gb.ResumeLayout(False)
        Me.Gb.PerformLayout()
        CType(Me.Dgvdatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvCalculo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DtpHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents DtpDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents CmbCartero As System.Windows.Forms.ComboBox
    Friend WithEvents Dgvdatos As System.Windows.Forms.DataGridView
    Friend WithEvents BtnBuscar As System.Windows.Forms.Button
    Friend WithEvents LblHasta As System.Windows.Forms.Label
    Friend WithEvents Lblesde As System.Windows.Forms.Label
    Friend WithEvents LbaCartero As System.Windows.Forms.Label
    Friend WithEvents BtnExcel As System.Windows.Forms.Button
    Friend WithEvents BtnEstadistica As System.Windows.Forms.Button
    Friend WithEvents TxtDat As System.Windows.Forms.TextBox
    Friend WithEvents LblCant As System.Windows.Forms.Label
    Friend WithEvents BtnCalculoCash As System.Windows.Forms.Button
    Friend WithEvents DgvCalculo As System.Windows.Forms.DataGridView
    Friend WithEvents BtnExcelControl As System.Windows.Forms.Button
    Friend WithEvents LblTotal As System.Windows.Forms.Label
    Friend WithEvents Txttotal As System.Windows.Forms.TextBox

End Class
