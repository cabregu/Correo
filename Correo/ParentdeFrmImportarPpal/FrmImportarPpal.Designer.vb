<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmImportarPpal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmImportarPpal))
        Me.Menu = New System.Windows.Forms.MenuStrip()
        Me.CargarRemitoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportarDesdeXlsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BusquedaExcelsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EtiquetasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarRemitoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AplocativoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu.SuspendLayout()
        Me.SuspendLayout()
        '
        'Menu
        '
        Me.Menu.BackColor = System.Drawing.Color.SteelBlue
        Me.Menu.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CargarRemitoToolStripMenuItem1, Me.ImportarDesdeXlsToolStripMenuItem, Me.BusquedaExcelsToolStripMenuItem, Me.EtiquetasToolStripMenuItem, Me.ToolStripMenuItem4, Me.ToolStripMenuItem5, Me.ToolStripMenuItem2, Me.EliminarRemitoToolStripMenuItem, Me.AplocativoToolStripMenuItem, Me.ToolStripMenuItem3, Me.ToolStripMenuItem1})
        Me.Menu.Location = New System.Drawing.Point(0, 0)
        Me.Menu.Name = "Menu"
        Me.Menu.Size = New System.Drawing.Size(1370, 40)
        Me.Menu.TabIndex = 1
        Me.Menu.Text = "MenuStrip1"
        '
        'CargarRemitoToolStripMenuItem1
        '
        Me.CargarRemitoToolStripMenuItem1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CargarRemitoToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.CargarRemitoToolStripMenuItem1.Image = Global.Correo.My.Resources.Resources.red_line
        Me.CargarRemitoToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CargarRemitoToolStripMenuItem1.Name = "CargarRemitoToolStripMenuItem1"
        Me.CargarRemitoToolStripMenuItem1.Size = New System.Drawing.Size(125, 36)
        Me.CargarRemitoToolStripMenuItem1.Text = "Cargar Remito"
        '
        'ImportarDesdeXlsToolStripMenuItem
        '
        Me.ImportarDesdeXlsToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ImportarDesdeXlsToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ImportarDesdeXlsToolStripMenuItem.Image = Global.Correo.My.Resources.Resources.table_excel
        Me.ImportarDesdeXlsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ImportarDesdeXlsToolStripMenuItem.Name = "ImportarDesdeXlsToolStripMenuItem"
        Me.ImportarDesdeXlsToolStripMenuItem.Size = New System.Drawing.Size(140, 36)
        Me.ImportarDesdeXlsToolStripMenuItem.Text = "Importar Desde Xls"
        '
        'BusquedaExcelsToolStripMenuItem
        '
        Me.BusquedaExcelsToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.BusquedaExcelsToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.BusquedaExcelsToolStripMenuItem.Image = Global.Correo.My.Resources.Resources.table_excel
        Me.BusquedaExcelsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BusquedaExcelsToolStripMenuItem.Name = "BusquedaExcelsToolStripMenuItem"
        Me.BusquedaExcelsToolStripMenuItem.Size = New System.Drawing.Size(116, 36)
        Me.BusquedaExcelsToolStripMenuItem.Text = "Busqueda Xls"
        '
        'EtiquetasToolStripMenuItem
        '
        Me.EtiquetasToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.EtiquetasToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.EtiquetasToolStripMenuItem.Image = Global.Correo.My.Resources.Resources.Print
        Me.EtiquetasToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.EtiquetasToolStripMenuItem.Name = "EtiquetasToolStripMenuItem"
        Me.EtiquetasToolStripMenuItem.Size = New System.Drawing.Size(95, 36)
        Me.EtiquetasToolStripMenuItem.Text = "Etiquetas"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ToolStripMenuItem2.ForeColor = System.Drawing.Color.White
        Me.ToolStripMenuItem2.Image = Global.Correo.My.Resources.Resources.comment_edit
        Me.ToolStripMenuItem2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(107, 36)
        Me.ToolStripMenuItem2.Text = "Ing_Manual"
        '
        'EliminarRemitoToolStripMenuItem
        '
        Me.EliminarRemitoToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.EliminarRemitoToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.EliminarRemitoToolStripMenuItem.Image = Global.Correo.My.Resources.Resources.agt_stop
        Me.EliminarRemitoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.EliminarRemitoToolStripMenuItem.Name = "EliminarRemitoToolStripMenuItem"
        Me.EliminarRemitoToolStripMenuItem.Size = New System.Drawing.Size(115, 36)
        Me.EliminarRemitoToolStripMenuItem.Text = "Borrar Remito"
        '
        'AplocativoToolStripMenuItem
        '
        Me.AplocativoToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.AplocativoToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.AplocativoToolStripMenuItem.Image = Global.Correo.My.Resources.Resources.edit
        Me.AplocativoToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AplocativoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AplocativoToolStripMenuItem.Name = "AplocativoToolStripMenuItem"
        Me.AplocativoToolStripMenuItem.Size = New System.Drawing.Size(134, 36)
        Me.AplocativoToolStripMenuItem.Text = "Nuevo Remitente"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Checked = True
        Me.ToolStripMenuItem3.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ToolStripMenuItem3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ToolStripMenuItem3.ForeColor = System.Drawing.Color.White
        Me.ToolStripMenuItem3.Image = Global.Correo.My.Resources.Resources.book_addresses
        Me.ToolStripMenuItem3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(82, 36)
        Me.ToolStripMenuItem3.Text = "Avisos"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Checked = True
        Me.ToolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ToolStripMenuItem1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ToolStripMenuItem1.ForeColor = System.Drawing.Color.White
        Me.ToolStripMenuItem1.Image = CType(resources.GetObject("ToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(71, 36)
        Me.ToolStripMenuItem1.Text = "Salir"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Checked = True
        Me.ToolStripMenuItem4.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ToolStripMenuItem4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ToolStripMenuItem4.ForeColor = System.Drawing.Color.White
        Me.ToolStripMenuItem4.Image = Global.Correo.My.Resources.Resources.BOProductGroup_32x32
        Me.ToolStripMenuItem4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(69, 36)
        Me.ToolStripMenuItem4.Text = "Arm"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Checked = True
        Me.ToolStripMenuItem5.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ToolStripMenuItem5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ToolStripMenuItem5.ForeColor = System.Drawing.Color.White
        Me.ToolStripMenuItem5.Image = Global.Correo.My.Resources.Resources.BOProduct_32x32
        Me.ToolStripMenuItem5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(88, 36)
        Me.ToolStripMenuItem5.Text = "Modo S"
        '
        'FrmImportarPpal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(1370, 494)
        Me.Controls.Add(Me.Menu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.Menu
        Me.Name = "FrmImportarPpal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmImportarPpal"
        Me.TransparencyKey = System.Drawing.Color.DeepSkyBlue
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Menu.ResumeLayout(False)
        Me.Menu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Menu As System.Windows.Forms.MenuStrip
    Friend WithEvents CargarRemitoToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImportarDesdeXlsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarRemitoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EtiquetasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AplocativoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BusquedaExcelsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As ToolStripMenuItem
End Class
