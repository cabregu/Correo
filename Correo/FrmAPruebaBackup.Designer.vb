<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAPruebaBackup
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
        Me.components = New System.ComponentModel.Container
        Me.dgvDatos = New System.Windows.Forms.DataGridView
        Me.BtnSeleccionar = New System.Windows.Forms.Button
        Me.DgvHoja = New System.Windows.Forms.DataGridView
        Me.NombreHoja = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BtnProcesar = New System.Windows.Forms.Button
        Me.LblNombreHoja = New System.Windows.Forms.Label
        Me.LblDatosHoja = New System.Windows.Forms.Label
        Me.DgvBaseCartas = New System.Windows.Forms.DataGridView
        Me.PBANALIZAR = New System.Windows.Forms.PictureBox
        Me.ProgressB = New System.Windows.Forms.ProgressBar
        Me.BtnExcel = New System.Windows.Forms.Button
        Me.BtnActualizar = New System.Windows.Forms.Button
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BtnBuscar = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvHoja, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvBaseCartas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBANALIZAR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvDatos
        '
        Me.dgvDatos.AllowUserToAddRows = False
        Me.dgvDatos.AllowUserToDeleteRows = False
        Me.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDatos.Location = New System.Drawing.Point(174, 25)
        Me.dgvDatos.Name = "dgvDatos"
        Me.dgvDatos.ReadOnly = True
        Me.dgvDatos.Size = New System.Drawing.Size(482, 138)
        Me.dgvDatos.TabIndex = 2
        '
        'BtnSeleccionar
        '
        Me.BtnSeleccionar.Location = New System.Drawing.Point(133, 25)
        Me.BtnSeleccionar.Name = "BtnSeleccionar"
        Me.BtnSeleccionar.Size = New System.Drawing.Size(27, 19)
        Me.BtnSeleccionar.TabIndex = 5
        Me.BtnSeleccionar.Text = "..."
        Me.BtnSeleccionar.UseVisualStyleBackColor = True
        '
        'DgvHoja
        '
        Me.DgvHoja.AllowUserToAddRows = False
        Me.DgvHoja.AllowUserToDeleteRows = False
        Me.DgvHoja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvHoja.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NombreHoja})
        Me.DgvHoja.EnableHeadersVisualStyles = False
        Me.DgvHoja.Location = New System.Drawing.Point(12, 25)
        Me.DgvHoja.Name = "DgvHoja"
        Me.DgvHoja.ReadOnly = True
        Me.DgvHoja.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DgvHoja.RowHeadersVisible = False
        Me.DgvHoja.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.DgvHoja.Size = New System.Drawing.Size(115, 138)
        Me.DgvHoja.TabIndex = 6
        '
        'NombreHoja
        '
        Me.NombreHoja.HeaderText = "NombreHoja"
        Me.NombreHoja.Name = "NombreHoja"
        Me.NombreHoja.ReadOnly = True
        '
        'BtnProcesar
        '
        Me.BtnProcesar.Enabled = False
        Me.BtnProcesar.Location = New System.Drawing.Point(133, 50)
        Me.BtnProcesar.Name = "BtnProcesar"
        Me.BtnProcesar.Size = New System.Drawing.Size(27, 19)
        Me.BtnProcesar.TabIndex = 7
        Me.BtnProcesar.Text = ">>"
        Me.BtnProcesar.UseVisualStyleBackColor = True
        '
        'LblNombreHoja
        '
        Me.LblNombreHoja.AutoSize = True
        Me.LblNombreHoja.Location = New System.Drawing.Point(12, 5)
        Me.LblNombreHoja.Name = "LblNombreHoja"
        Me.LblNombreHoja.Size = New System.Drawing.Size(29, 13)
        Me.LblNombreHoja.TabIndex = 8
        Me.LblNombreHoja.Text = "Hoja"
        '
        'LblDatosHoja
        '
        Me.LblDatosHoja.AutoSize = True
        Me.LblDatosHoja.Location = New System.Drawing.Point(171, 5)
        Me.LblDatosHoja.Name = "LblDatosHoja"
        Me.LblDatosHoja.Size = New System.Drawing.Size(75, 13)
        Me.LblDatosHoja.TabIndex = 9
        Me.LblDatosHoja.Text = "Datos de Hoja"
        '
        'DgvBaseCartas
        '
        Me.DgvBaseCartas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvBaseCartas.Location = New System.Drawing.Point(12, 169)
        Me.DgvBaseCartas.Name = "DgvBaseCartas"
        Me.DgvBaseCartas.Size = New System.Drawing.Size(644, 125)
        Me.DgvBaseCartas.TabIndex = 12
        '
        'PBANALIZAR
        '
        Me.PBANALIZAR.Image = Global.Correo.My.Resources.Resources.R1
        Me.PBANALIZAR.Location = New System.Drawing.Point(662, 169)
        Me.PBANALIZAR.Name = "PBANALIZAR"
        Me.PBANALIZAR.Size = New System.Drawing.Size(43, 35)
        Me.PBANALIZAR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PBANALIZAR.TabIndex = 16
        Me.PBANALIZAR.TabStop = False
        '
        'ProgressB
        '
        Me.ProgressB.Location = New System.Drawing.Point(15, 300)
        Me.ProgressB.Name = "ProgressB"
        Me.ProgressB.Size = New System.Drawing.Size(644, 10)
        Me.ProgressB.TabIndex = 18
        '
        'BtnExcel
        '
        Me.BtnExcel.Location = New System.Drawing.Point(662, 227)
        Me.BtnExcel.Name = "BtnExcel"
        Me.BtnExcel.Size = New System.Drawing.Size(31, 21)
        Me.BtnExcel.TabIndex = 19
        Me.BtnExcel.Text = "Xls"
        Me.BtnExcel.UseVisualStyleBackColor = True
        '
        'BtnActualizar
        '
        Me.BtnActualizar.Location = New System.Drawing.Point(662, 25)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(70, 23)
        Me.BtnActualizar.TabIndex = 21
        Me.BtnActualizar.Text = "Convertir"
        Me.BtnActualizar.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(289, 0)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(70, 23)
        Me.BtnBuscar.TabIndex = 22
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(661, 125)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(71, 38)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "Prueba"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FrmAPruebaBackup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(772, 322)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.BtnActualizar)
        Me.Controls.Add(Me.BtnExcel)
        Me.Controls.Add(Me.ProgressB)
        Me.Controls.Add(Me.PBANALIZAR)
        Me.Controls.Add(Me.DgvBaseCartas)
        Me.Controls.Add(Me.LblDatosHoja)
        Me.Controls.Add(Me.LblNombreHoja)
        Me.Controls.Add(Me.BtnProcesar)
        Me.Controls.Add(Me.DgvHoja)
        Me.Controls.Add(Me.BtnSeleccionar)
        Me.Controls.Add(Me.dgvDatos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmAPruebaBackup"
        Me.Text = "FrmAPruebaanalisis operaciones Gece"
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvHoja, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvBaseCartas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBANALIZAR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvDatos As System.Windows.Forms.DataGridView
    Friend WithEvents BtnSeleccionar As System.Windows.Forms.Button
    Friend WithEvents DgvHoja As System.Windows.Forms.DataGridView
    Friend WithEvents NombreHoja As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BtnProcesar As System.Windows.Forms.Button
    Friend WithEvents LblNombreHoja As System.Windows.Forms.Label
    Friend WithEvents LblDatosHoja As System.Windows.Forms.Label
    Friend WithEvents DgvBaseCartas As System.Windows.Forms.DataGridView
    Friend WithEvents PBANALIZAR As System.Windows.Forms.PictureBox
    Friend WithEvents ProgressB As System.Windows.Forms.ProgressBar
    Friend WithEvents BtnExcel As System.Windows.Forms.Button
    Friend WithEvents BtnActualizar As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents BtnBuscar As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
