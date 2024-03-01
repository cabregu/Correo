<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInforme
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
        Me.DgvEscaneo = New System.Windows.Forms.DataGridView
        Me.NRO_CARTA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ESTADO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FECHA_ENTR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.OBS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Btnxls = New System.Windows.Forms.Button
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Gb.SuspendLayout()
        CType(Me.DgvEscaneo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PBLogo
        '
        Me.PBLogo.Location = New System.Drawing.Point(5, 415)
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(649, 415)
        '
        'Gb
        '
        Me.Gb.Controls.Add(Me.DgvEscaneo)
        Me.Gb.Controls.Add(Me.Btnxls)
        Me.Gb.Location = New System.Drawing.Point(1, 3)
        Me.Gb.Size = New System.Drawing.Size(696, 466)
        Me.Gb.Controls.SetChildIndex(Me.Btnxls, 0)
        Me.Gb.Controls.SetChildIndex(Me.DgvEscaneo, 0)
        Me.Gb.Controls.SetChildIndex(Me.PBLogo, 0)
        Me.Gb.Controls.SetChildIndex(Me.BtnSalir, 0)
        '
        'DgvEscaneo
        '
        Me.DgvEscaneo.AllowUserToAddRows = False
        Me.DgvEscaneo.AllowUserToDeleteRows = False
        Me.DgvEscaneo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DgvEscaneo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DgvEscaneo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvEscaneo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NRO_CARTA, Me.ESTADO, Me.FECHA_ENTR, Me.OBS})
        Me.DgvEscaneo.Location = New System.Drawing.Point(17, 23)
        Me.DgvEscaneo.Name = "DgvEscaneo"
        Me.DgvEscaneo.ReadOnly = True
        Me.DgvEscaneo.RowHeadersVisible = False
        Me.DgvEscaneo.RowTemplate.Height = 25
        Me.DgvEscaneo.ShowRowErrors = False
        Me.DgvEscaneo.Size = New System.Drawing.Size(410, 500)
        Me.DgvEscaneo.TabIndex = 29
        '
        'NRO_CARTA
        '
        Me.NRO_CARTA.HeaderText = "NRO_CARTA"
        Me.NRO_CARTA.Name = "NRO_CARTA"
        Me.NRO_CARTA.ReadOnly = True
        '
        'ESTADO
        '
        Me.ESTADO.HeaderText = "ESTADO"
        Me.ESTADO.Name = "ESTADO"
        Me.ESTADO.ReadOnly = True
        '
        'FECHA_ENTR
        '
        Me.FECHA_ENTR.HeaderText = "FECHA_ENTR"
        Me.FECHA_ENTR.Name = "FECHA_ENTR"
        Me.FECHA_ENTR.ReadOnly = True
        '
        'OBS
        '
        Me.OBS.HeaderText = "OBS"
        Me.OBS.Name = "OBS"
        Me.OBS.ReadOnly = True
        '
        'Btnxls
        '
        Me.Btnxls.Location = New System.Drawing.Point(445, 23)
        Me.Btnxls.Name = "Btnxls"
        Me.Btnxls.Size = New System.Drawing.Size(65, 25)
        Me.Btnxls.TabIndex = 31
        Me.Btnxls.Text = "XLS"
        Me.Btnxls.UseVisualStyleBackColor = True
        '
        'FrmInforme
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(699, 471)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmInforme"
        Me.Text = "Informe"
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Gb.ResumeLayout(False)
        CType(Me.DgvEscaneo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DgvEscaneo As System.Windows.Forms.DataGridView
    Friend WithEvents Btnxls As System.Windows.Forms.Button
    Friend WithEvents NRO_CARTA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ESTADO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FECHA_ENTR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OBS As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
