<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConsultaTR
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
        Me.Dgvdatos = New System.Windows.Forms.DataGridView()
        Me.Gpbcontroles = New System.Windows.Forms.GroupBox()
        Me.TxtNroSocio = New System.Windows.Forms.TextBox()
        Me.Btnsalir = New System.Windows.Forms.Button()
        CType(Me.Dgvdatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Gpbcontroles.SuspendLayout()
        Me.SuspendLayout()
        '
        'Dgvdatos
        '
        Me.Dgvdatos.AllowUserToAddRows = False
        Me.Dgvdatos.AllowUserToDeleteRows = False
        Me.Dgvdatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgvdatos.Location = New System.Drawing.Point(12, 75)
        Me.Dgvdatos.Name = "Dgvdatos"
        Me.Dgvdatos.ReadOnly = True
        Me.Dgvdatos.Size = New System.Drawing.Size(721, 193)
        Me.Dgvdatos.TabIndex = 280
        '
        'Gpbcontroles
        '
        Me.Gpbcontroles.Controls.Add(Me.TxtNroSocio)
        Me.Gpbcontroles.Location = New System.Drawing.Point(12, 12)
        Me.Gpbcontroles.Name = "Gpbcontroles"
        Me.Gpbcontroles.Size = New System.Drawing.Size(296, 57)
        Me.Gpbcontroles.TabIndex = 281
        Me.Gpbcontroles.TabStop = False
        '
        'TxtNroSocio
        '
        Me.TxtNroSocio.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNroSocio.Location = New System.Drawing.Point(6, 14)
        Me.TxtNroSocio.Name = "TxtNroSocio"
        Me.TxtNroSocio.Size = New System.Drawing.Size(279, 31)
        Me.TxtNroSocio.TabIndex = 282
        '
        'Btnsalir
        '
        Me.Btnsalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btnsalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btnsalir.Image = Global.Correo.My.Resources.Resources.door_out
        Me.Btnsalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btnsalir.Location = New System.Drawing.Point(662, 293)
        Me.Btnsalir.Name = "Btnsalir"
        Me.Btnsalir.Size = New System.Drawing.Size(71, 54)
        Me.Btnsalir.TabIndex = 23
        Me.Btnsalir.Text = "Salir"
        Me.Btnsalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btnsalir.UseVisualStyleBackColor = True
        '
        'FrmConsultaTR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(745, 359)
        Me.Controls.Add(Me.Gpbcontroles)
        Me.Controls.Add(Me.Btnsalir)
        Me.Controls.Add(Me.Dgvdatos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmConsultaTR"
        Me.Text = " Consulta TR"
        CType(Me.Dgvdatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Gpbcontroles.ResumeLayout(False)
        Me.Gpbcontroles.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Dgvdatos As System.Windows.Forms.DataGridView
    Friend WithEvents Gpbcontroles As System.Windows.Forms.GroupBox
    Public WithEvents Btnsalir As System.Windows.Forms.Button
    Friend WithEvents TxtNroSocio As System.Windows.Forms.TextBox
End Class
