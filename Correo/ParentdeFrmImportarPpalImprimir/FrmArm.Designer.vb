<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmArm
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
        Me.DgvSeleccion = New System.Windows.Forms.DataGridView()
        Me.LblCant = New System.Windows.Forms.Label()
        Me.BtnPdf = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.TxtNroArm = New System.Windows.Forms.TextBox()
        Me.TxtNroCarta = New System.Windows.Forms.TextBox()
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Gb.SuspendLayout()
        CType(Me.DgvSeleccion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PBLogo
        '
        Me.PBLogo.Location = New System.Drawing.Point(5, 561)
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(861, 561)
        '
        'Gb
        '
        Me.Gb.Controls.Add(Me.TxtNroCarta)
        Me.Gb.Controls.Add(Me.TxtNroArm)
        Me.Gb.Controls.Add(Me.BtnNuevo)
        Me.Gb.Controls.Add(Me.BtnPdf)
        Me.Gb.Controls.Add(Me.LblCant)
        Me.Gb.Controls.Add(Me.DgvSeleccion)
        Me.Gb.Size = New System.Drawing.Size(928, 612)
        Me.Gb.Controls.SetChildIndex(Me.PBLogo, 0)
        Me.Gb.Controls.SetChildIndex(Me.BtnSalir, 0)
        Me.Gb.Controls.SetChildIndex(Me.DgvSeleccion, 0)
        Me.Gb.Controls.SetChildIndex(Me.LblCant, 0)
        Me.Gb.Controls.SetChildIndex(Me.BtnPdf, 0)
        Me.Gb.Controls.SetChildIndex(Me.BtnNuevo, 0)
        Me.Gb.Controls.SetChildIndex(Me.TxtNroArm, 0)
        Me.Gb.Controls.SetChildIndex(Me.TxtNroCarta, 0)
        '
        'DgvSeleccion
        '
        Me.DgvSeleccion.AllowUserToAddRows = False
        Me.DgvSeleccion.AllowUserToDeleteRows = False
        Me.DgvSeleccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvSeleccion.Location = New System.Drawing.Point(30, 77)
        Me.DgvSeleccion.Name = "DgvSeleccion"
        Me.DgvSeleccion.ReadOnly = True
        Me.DgvSeleccion.Size = New System.Drawing.Size(750, 450)
        Me.DgvSeleccion.TabIndex = 35
        '
        'LblCant
        '
        Me.LblCant.AutoSize = True
        Me.LblCant.Location = New System.Drawing.Point(27, 529)
        Me.LblCant.Name = "LblCant"
        Me.LblCant.Size = New System.Drawing.Size(13, 13)
        Me.LblCant.TabIndex = 30
        Me.LblCant.Text = "0"
        '
        'BtnPdf
        '
        Me.BtnPdf.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnPdf.Image = Global.Correo.My.Resources.Resources.PasteSpecial_32x32
        Me.BtnPdf.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnPdf.Location = New System.Drawing.Point(464, 25)
        Me.BtnPdf.Name = "BtnPdf"
        Me.BtnPdf.Size = New System.Drawing.Size(50, 47)
        Me.BtnPdf.TabIndex = 39
        Me.BtnPdf.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnPdf.UseVisualStyleBackColor = True
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNuevo.Location = New System.Drawing.Point(30, 37)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(100, 35)
        Me.BtnNuevo.TabIndex = 40
        Me.BtnNuevo.Text = "Nuevo"
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'TxtNroArm
        '
        Me.TxtNroArm.Enabled = False
        Me.TxtNroArm.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNroArm.Location = New System.Drawing.Point(146, 40)
        Me.TxtNroArm.Name = "TxtNroArm"
        Me.TxtNroArm.Size = New System.Drawing.Size(100, 31)
        Me.TxtNroArm.TabIndex = 41
        '
        'TxtNroCarta
        '
        Me.TxtNroCarta.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNroCarta.Location = New System.Drawing.Point(295, 41)
        Me.TxtNroCarta.Name = "TxtNroCarta"
        Me.TxtNroCarta.Size = New System.Drawing.Size(120, 31)
        Me.TxtNroCarta.TabIndex = 42
        '
        'FrmArm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(914, 611)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmArm"
        Me.Text = "Arm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Normal
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Gb.ResumeLayout(False)
        Me.Gb.PerformLayout()
        CType(Me.DgvSeleccion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DgvSeleccion As DataGridView
    Friend WithEvents LblCant As Label
    Friend WithEvents BtnPdf As Button
    Friend WithEvents TxtNroCarta As TextBox
    Friend WithEvents TxtNroArm As TextBox
    Friend WithEvents BtnNuevo As Button
End Class
