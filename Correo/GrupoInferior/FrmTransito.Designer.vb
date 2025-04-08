<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTransito
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
        Me.BtnExcel = New System.Windows.Forms.Button()
        Me.txtPath = New System.Windows.Forms.TextBox()
        Me.BNBUSCAR = New System.Windows.Forms.Button()
        Me.BtnEstados = New System.Windows.Forms.Button()
        Me.Btnexcel2 = New System.Windows.Forms.Button()
        Me.GrpTransito = New System.Windows.Forms.GroupBox()
        Me.BtnEstadistica = New System.Windows.Forms.Button()
        Me.BtnFechasReales = New System.Windows.Forms.Button()
        Me.PgbAnalisis = New System.Windows.Forms.ProgressBar()
        Me.BtnConfirmar = New System.Windows.Forms.Button()
        Me.BtnAnalisisEstados = New System.Windows.Forms.Button()
        Me.Btncsv = New System.Windows.Forms.Button()
        Me.Btntxt = New System.Windows.Forms.Button()
        Me.BtnPorCarta = New System.Windows.Forms.Button()
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Gb.SuspendLayout()
        CType(Me.DgvDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpTransito.SuspendLayout()
        Me.SuspendLayout()
        '
        'PBLogo
        '
        Me.PBLogo.Location = New System.Drawing.Point(5, 534)
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(1348, 534)
        '
        'Gb
        '
        Me.Gb.Controls.Add(Me.BtnPorCarta)
        Me.Gb.Controls.Add(Me.Btncsv)
        Me.Gb.Controls.Add(Me.Btntxt)
        Me.Gb.Controls.Add(Me.GrpTransito)
        Me.Gb.Controls.Add(Me.BtnEstados)
        Me.Gb.Location = New System.Drawing.Point(0, 0)
        Me.Gb.Size = New System.Drawing.Size(1026, 556)
        Me.Gb.Text = "x"
        Me.Gb.Controls.SetChildIndex(Me.BtnEstados, 0)
        Me.Gb.Controls.SetChildIndex(Me.GrpTransito, 0)
        Me.Gb.Controls.SetChildIndex(Me.PBLogo, 0)
        Me.Gb.Controls.SetChildIndex(Me.Btntxt, 0)
        Me.Gb.Controls.SetChildIndex(Me.BtnSalir, 0)
        Me.Gb.Controls.SetChildIndex(Me.Btncsv, 0)
        Me.Gb.Controls.SetChildIndex(Me.BtnPorCarta, 0)
        '
        'DgvDatos
        '
        Me.DgvDatos.AllowUserToAddRows = False
        Me.DgvDatos.AllowUserToDeleteRows = False
        Me.DgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvDatos.Location = New System.Drawing.Point(6, 58)
        Me.DgvDatos.Name = "DgvDatos"
        Me.DgvDatos.ReadOnly = True
        Me.DgvDatos.Size = New System.Drawing.Size(535, 358)
        Me.DgvDatos.TabIndex = 31
        '
        'BtnExcel
        '
        Me.BtnExcel.Location = New System.Drawing.Point(262, 26)
        Me.BtnExcel.Name = "BtnExcel"
        Me.BtnExcel.Size = New System.Drawing.Size(17, 23)
        Me.BtnExcel.TabIndex = 33
        Me.BtnExcel.Text = "..."
        Me.BtnExcel.UseVisualStyleBackColor = True
        '
        'txtPath
        '
        Me.txtPath.Location = New System.Drawing.Point(6, 28)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.Size = New System.Drawing.Size(250, 20)
        Me.txtPath.TabIndex = 34
        '
        'BNBUSCAR
        '
        Me.BNBUSCAR.Location = New System.Drawing.Point(547, 27)
        Me.BNBUSCAR.Name = "BNBUSCAR"
        Me.BNBUSCAR.Size = New System.Drawing.Size(102, 23)
        Me.BNBUSCAR.TabIndex = 39
        Me.BNBUSCAR.Text = "BUSCAR"
        Me.BNBUSCAR.UseVisualStyleBackColor = True
        '
        'BtnEstados
        '
        Me.BtnEstados.Location = New System.Drawing.Point(16, 487)
        Me.BtnEstados.Name = "BtnEstados"
        Me.BtnEstados.Size = New System.Drawing.Size(102, 23)
        Me.BtnEstados.TabIndex = 40
        Me.BtnEstados.Text = "FECHAS"
        Me.BtnEstados.UseVisualStyleBackColor = True
        Me.BtnEstados.Visible = False
        '
        'Btnexcel2
        '
        Me.Btnexcel2.Location = New System.Drawing.Point(6, 422)
        Me.Btnexcel2.Name = "Btnexcel2"
        Me.Btnexcel2.Size = New System.Drawing.Size(36, 23)
        Me.Btnexcel2.TabIndex = 41
        Me.Btnexcel2.Text = "XLS"
        Me.Btnexcel2.UseVisualStyleBackColor = True
        '
        'GrpTransito
        '
        Me.GrpTransito.Controls.Add(Me.BtnEstadistica)
        Me.GrpTransito.Controls.Add(Me.BtnFechasReales)
        Me.GrpTransito.Controls.Add(Me.PgbAnalisis)
        Me.GrpTransito.Controls.Add(Me.BtnConfirmar)
        Me.GrpTransito.Controls.Add(Me.BtnAnalisisEstados)
        Me.GrpTransito.Controls.Add(Me.txtPath)
        Me.GrpTransito.Controls.Add(Me.DgvDatos)
        Me.GrpTransito.Controls.Add(Me.BtnExcel)
        Me.GrpTransito.Controls.Add(Me.Btnexcel2)
        Me.GrpTransito.Controls.Add(Me.BNBUSCAR)
        Me.GrpTransito.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpTransito.Location = New System.Drawing.Point(10, 19)
        Me.GrpTransito.Name = "GrpTransito"
        Me.GrpTransito.Size = New System.Drawing.Size(655, 451)
        Me.GrpTransito.TabIndex = 46
        Me.GrpTransito.TabStop = False
        Me.GrpTransito.Text = "Transito"
        '
        'BtnEstadistica
        '
        Me.BtnEstadistica.Location = New System.Drawing.Point(547, 186)
        Me.BtnEstadistica.Name = "BtnEstadistica"
        Me.BtnEstadistica.Size = New System.Drawing.Size(102, 50)
        Me.BtnEstadistica.TabIndex = 55
        Me.BtnEstadistica.Text = "ESTADISTICA EN_RENDICION"
        Me.BtnEstadistica.UseVisualStyleBackColor = True
        '
        'BtnFechasReales
        '
        Me.BtnFechasReales.Location = New System.Drawing.Point(547, 377)
        Me.BtnFechasReales.Name = "BtnFechasReales"
        Me.BtnFechasReales.Size = New System.Drawing.Size(102, 23)
        Me.BtnFechasReales.TabIndex = 54
        Me.BtnFechasReales.Text = "FECHAS"
        Me.BtnFechasReales.UseVisualStyleBackColor = True
        '
        'PgbAnalisis
        '
        Me.PgbAnalisis.Location = New System.Drawing.Point(48, 435)
        Me.PgbAnalisis.Name = "PgbAnalisis"
        Me.PgbAnalisis.Size = New System.Drawing.Size(456, 10)
        Me.PgbAnalisis.TabIndex = 51
        '
        'BtnConfirmar
        '
        Me.BtnConfirmar.Location = New System.Drawing.Point(547, 406)
        Me.BtnConfirmar.Name = "BtnConfirmar"
        Me.BtnConfirmar.Size = New System.Drawing.Size(102, 39)
        Me.BtnConfirmar.TabIndex = 50
        Me.BtnConfirmar.Text = "Confirmar"
        Me.BtnConfirmar.UseVisualStyleBackColor = True
        '
        'BtnAnalisisEstados
        '
        Me.BtnAnalisisEstados.Location = New System.Drawing.Point(547, 56)
        Me.BtnAnalisisEstados.Name = "BtnAnalisisEstados"
        Me.BtnAnalisisEstados.Size = New System.Drawing.Size(102, 25)
        Me.BtnAnalisisEstados.TabIndex = 49
        Me.BtnAnalisisEstados.Text = "ESTADOS"
        Me.BtnAnalisisEstados.UseVisualStyleBackColor = True
        '
        'Btncsv
        '
        Me.Btncsv.Location = New System.Drawing.Point(476, 487)
        Me.Btncsv.Name = "Btncsv"
        Me.Btncsv.Size = New System.Drawing.Size(75, 23)
        Me.Btncsv.TabIndex = 61
        Me.Btncsv.Text = "csv"
        Me.Btncsv.UseVisualStyleBackColor = True
        '
        'Btntxt
        '
        Me.Btntxt.Location = New System.Drawing.Point(355, 487)
        Me.Btntxt.Name = "Btntxt"
        Me.Btntxt.Size = New System.Drawing.Size(75, 23)
        Me.Btntxt.TabIndex = 60
        Me.Btntxt.Text = "txt"
        Me.Btntxt.UseVisualStyleBackColor = True
        '
        'BtnPorCarta
        '
        Me.BtnPorCarta.Location = New System.Drawing.Point(671, 19)
        Me.BtnPorCarta.Name = "BtnPorCarta"
        Me.BtnPorCarta.Size = New System.Drawing.Size(150, 23)
        Me.BtnPorCarta.TabIndex = 56
        Me.BtnPorCarta.Text = "Busqueda Por Carta"
        Me.BtnPorCarta.UseVisualStyleBackColor = True
        '
        'FrmTransito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1020, 528)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmTransito"
        Me.Text = "Transito"
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Gb.ResumeLayout(False)
        CType(Me.DgvDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpTransito.ResumeLayout(False)
        Me.GrpTransito.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DgvDatos As System.Windows.Forms.DataGridView
    Friend WithEvents BtnExcel As System.Windows.Forms.Button
    Friend WithEvents txtPath As System.Windows.Forms.TextBox
    Friend WithEvents BNBUSCAR As System.Windows.Forms.Button
    Friend WithEvents BtnEstados As System.Windows.Forms.Button
    Friend WithEvents Btnexcel2 As System.Windows.Forms.Button
    Friend WithEvents GrpTransito As System.Windows.Forms.GroupBox
    Friend WithEvents BtnAnalisisEstados As System.Windows.Forms.Button
    Friend WithEvents BtnConfirmar As System.Windows.Forms.Button
    Friend WithEvents PgbAnalisis As System.Windows.Forms.ProgressBar
    Friend WithEvents BtnFechasReales As System.Windows.Forms.Button
    Friend WithEvents Btntxt As System.Windows.Forms.Button
    Friend WithEvents Btncsv As System.Windows.Forms.Button
    Friend WithEvents BtnEstadistica As Button
    Friend WithEvents BtnPorCarta As Button
End Class
