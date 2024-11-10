<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmRemitosLexs
    Inherits Correo.FrmPlantilla

    'Form invalida a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.DtpDesde = New System.Windows.Forms.DateTimePicker()
        Me.PbRemito = New System.Windows.Forms.PictureBox()
        Me.BtnConfirmar = New System.Windows.Forms.Button()
        Me.TxtRemito = New System.Windows.Forms.TextBox()
        Me.CmbRemitente = New System.Windows.Forms.ComboBox()
        Me.BtnPegar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.DgvRemitos = New System.Windows.Forms.DataGridView()
        Me.MarcarMenuItem = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TxtRemitoDesde = New System.Windows.Forms.TextBox()
        Me.TxtRemitoHasta = New System.Windows.Forms.TextBox()
        Me.BtnRemitos = New System.Windows.Forms.Button()
        Me.LblRemitodesde = New System.Windows.Forms.Label()
        Me.LblRemitohasta = New System.Windows.Forms.Label()
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Gb.SuspendLayout()
        CType(Me.PbRemito, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvRemitos, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Gb.Controls.Add(Me.LblRemitohasta)
        Me.Gb.Controls.Add(Me.LblRemitodesde)
        Me.Gb.Controls.Add(Me.BtnRemitos)
        Me.Gb.Controls.Add(Me.TxtRemitoHasta)
        Me.Gb.Controls.Add(Me.TxtRemitoDesde)
        Me.Gb.Controls.Add(Me.DgvRemitos)
        Me.Gb.Controls.Add(Me.BtnGuardar)
        Me.Gb.Controls.Add(Me.BtnPegar)
        Me.Gb.Controls.Add(Me.CmbRemitente)
        Me.Gb.Controls.Add(Me.TxtRemito)
        Me.Gb.Controls.Add(Me.BtnConfirmar)
        Me.Gb.Controls.Add(Me.PbRemito)
        Me.Gb.Controls.Add(Me.DtpDesde)
        Me.Gb.Controls.Add(Me.BtnNuevo)
        Me.Gb.Size = New System.Drawing.Size(1370, 750)
        Me.Gb.Controls.SetChildIndex(Me.PBLogo, 0)
        Me.Gb.Controls.SetChildIndex(Me.BtnSalir, 0)
        Me.Gb.Controls.SetChildIndex(Me.BtnNuevo, 0)
        Me.Gb.Controls.SetChildIndex(Me.DtpDesde, 0)
        Me.Gb.Controls.SetChildIndex(Me.PbRemito, 0)
        Me.Gb.Controls.SetChildIndex(Me.BtnConfirmar, 0)
        Me.Gb.Controls.SetChildIndex(Me.TxtRemito, 0)
        Me.Gb.Controls.SetChildIndex(Me.CmbRemitente, 0)
        Me.Gb.Controls.SetChildIndex(Me.BtnPegar, 0)
        Me.Gb.Controls.SetChildIndex(Me.BtnGuardar, 0)
        Me.Gb.Controls.SetChildIndex(Me.DgvRemitos, 0)
        Me.Gb.Controls.SetChildIndex(Me.TxtRemitoDesde, 0)
        Me.Gb.Controls.SetChildIndex(Me.TxtRemitoHasta, 0)
        Me.Gb.Controls.SetChildIndex(Me.BtnRemitos, 0)
        Me.Gb.Controls.SetChildIndex(Me.LblRemitodesde, 0)
        Me.Gb.Controls.SetChildIndex(Me.LblRemitohasta, 0)
        '
        'BtnNuevo
        '
        Me.BtnNuevo.BackColor = System.Drawing.Color.Teal
        Me.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNuevo.Location = New System.Drawing.Point(12, 39)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(80, 40)
        Me.BtnNuevo.TabIndex = 61
        Me.BtnNuevo.Text = "Nuevo"
        Me.BtnNuevo.UseVisualStyleBackColor = False
        '
        'DtpDesde
        '
        Me.DtpDesde.Enabled = False
        Me.DtpDesde.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.DtpDesde.Location = New System.Drawing.Point(458, 48)
        Me.DtpDesde.Name = "DtpDesde"
        Me.DtpDesde.Size = New System.Drawing.Size(350, 29)
        Me.DtpDesde.TabIndex = 107
        '
        'PbRemito
        '
        Me.PbRemito.Location = New System.Drawing.Point(12, 109)
        Me.PbRemito.Name = "PbRemito"
        Me.PbRemito.Size = New System.Drawing.Size(1100, 500)
        Me.PbRemito.TabIndex = 108
        Me.PbRemito.TabStop = False
        '
        'BtnConfirmar
        '
        Me.BtnConfirmar.BackColor = System.Drawing.Color.Teal
        Me.BtnConfirmar.Enabled = False
        Me.BtnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnConfirmar.Image = Global.Correo.My.Resources.Resources.tick
        Me.BtnConfirmar.Location = New System.Drawing.Point(830, 44)
        Me.BtnConfirmar.Name = "BtnConfirmar"
        Me.BtnConfirmar.Size = New System.Drawing.Size(80, 40)
        Me.BtnConfirmar.TabIndex = 109
        Me.BtnConfirmar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnConfirmar.UseVisualStyleBackColor = False
        '
        'TxtRemito
        '
        Me.TxtRemito.Enabled = False
        Me.TxtRemito.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRemito.Location = New System.Drawing.Point(115, 46)
        Me.TxtRemito.Name = "TxtRemito"
        Me.TxtRemito.Size = New System.Drawing.Size(150, 31)
        Me.TxtRemito.TabIndex = 283
        '
        'CmbRemitente
        '
        Me.CmbRemitente.Enabled = False
        Me.CmbRemitente.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbRemitente.FormattingEnabled = True
        Me.CmbRemitente.Location = New System.Drawing.Point(290, 47)
        Me.CmbRemitente.Name = "CmbRemitente"
        Me.CmbRemitente.Size = New System.Drawing.Size(150, 32)
        Me.CmbRemitente.TabIndex = 284
        '
        'BtnPegar
        '
        Me.BtnPegar.BackColor = System.Drawing.Color.Transparent
        Me.BtnPegar.Enabled = False
        Me.BtnPegar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPegar.Image = Global.Correo.My.Resources.Resources.PasteSpecial_32x32
        Me.BtnPegar.Location = New System.Drawing.Point(916, 44)
        Me.BtnPegar.Name = "BtnPegar"
        Me.BtnPegar.Size = New System.Drawing.Size(80, 40)
        Me.BtnPegar.TabIndex = 286
        Me.BtnPegar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnPegar.UseVisualStyleBackColor = False
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackColor = System.Drawing.Color.Transparent
        Me.BtnGuardar.Enabled = False
        Me.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGuardar.Image = Global.Correo.My.Resources.Resources.Save_32x32
        Me.BtnGuardar.Location = New System.Drawing.Point(1032, 615)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(80, 40)
        Me.BtnGuardar.TabIndex = 287
        Me.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGuardar.UseVisualStyleBackColor = False
        '
        'DgvRemitos
        '
        Me.DgvRemitos.AllowUserToAddRows = False
        Me.DgvRemitos.AllowUserToDeleteRows = False
        Me.DgvRemitos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvRemitos.Location = New System.Drawing.Point(1118, 109)
        Me.DgvRemitos.Name = "DgvRemitos"
        Me.DgvRemitos.ReadOnly = True
        Me.DgvRemitos.Size = New System.Drawing.Size(230, 500)
        Me.DgvRemitos.TabIndex = 288
        '
        'MarcarMenuItem
        '
        Me.MarcarMenuItem.Name = "MarcarMenuItem"
        Me.MarcarMenuItem.Size = New System.Drawing.Size(61, 4)
        '
        'TxtRemitoDesde
        '
        Me.TxtRemitoDesde.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRemitoDesde.Location = New System.Drawing.Point(1055, 46)
        Me.TxtRemitoDesde.Name = "TxtRemitoDesde"
        Me.TxtRemitoDesde.Size = New System.Drawing.Size(114, 31)
        Me.TxtRemitoDesde.TabIndex = 289
        '
        'TxtRemitoHasta
        '
        Me.TxtRemitoHasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRemitoHasta.Location = New System.Drawing.Point(1187, 46)
        Me.TxtRemitoHasta.Name = "TxtRemitoHasta"
        Me.TxtRemitoHasta.Size = New System.Drawing.Size(114, 31)
        Me.TxtRemitoHasta.TabIndex = 290
        '
        'BtnRemitos
        '
        Me.BtnRemitos.BackColor = System.Drawing.Color.Teal
        Me.BtnRemitos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRemitos.Image = Global.Correo.My.Resources.Resources.Attachment_32x32
        Me.BtnRemitos.Location = New System.Drawing.Point(1307, 39)
        Me.BtnRemitos.Name = "BtnRemitos"
        Me.BtnRemitos.Size = New System.Drawing.Size(49, 40)
        Me.BtnRemitos.TabIndex = 291
        Me.BtnRemitos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnRemitos.UseVisualStyleBackColor = False
        '
        'LblRemitodesde
        '
        Me.LblRemitodesde.AutoSize = True
        Me.LblRemitodesde.Location = New System.Drawing.Point(1052, 30)
        Me.LblRemitodesde.Name = "LblRemitodesde"
        Me.LblRemitodesde.Size = New System.Drawing.Size(74, 13)
        Me.LblRemitodesde.TabIndex = 292
        Me.LblRemitodesde.Text = "Remito Desde"
        '
        'LblRemitohasta
        '
        Me.LblRemitohasta.AutoSize = True
        Me.LblRemitohasta.Location = New System.Drawing.Point(1184, 30)
        Me.LblRemitohasta.Name = "LblRemitohasta"
        Me.LblRemitohasta.Size = New System.Drawing.Size(71, 13)
        Me.LblRemitohasta.TabIndex = 293
        Me.LblRemitohasta.Text = "Remito Hasta"
        '
        'FrmRemitosLexs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmRemitosLexs"
        Me.Controls.SetChildIndex(Me.Gb, 0)
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Gb.ResumeLayout(False)
        Me.Gb.PerformLayout()
        CType(Me.PbRemito, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvRemitos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnNuevo As Button
    Friend WithEvents DtpDesde As DateTimePicker
    Friend WithEvents PbRemito As PictureBox
    Friend WithEvents BtnConfirmar As Button
    Friend WithEvents TxtRemito As TextBox
    Friend WithEvents CmbRemitente As ComboBox
    Friend WithEvents BtnPegar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents DgvRemitos As DataGridView
    Friend WithEvents MarcarMenuItem As ContextMenuStrip
    Friend WithEvents LblRemitohasta As Label
    Friend WithEvents LblRemitodesde As Label
    Friend WithEvents BtnRemitos As Button
    Friend WithEvents TxtRemitoHasta As TextBox
    Friend WithEvents TxtRemitoDesde As TextBox
End Class
