<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEscaneo
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
        Me.components = New System.ComponentModel.Container()
        Me.DgvDetalleArchivos = New System.Windows.Forms.DataGridView()
        Me.NroCartaLeido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ruta_Completa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnFinalizarCompletar = New System.Windows.Forms.Button()
        Me.BtnTermometro = New System.Windows.Forms.Button()
        Me.LblNro = New System.Windows.Forms.Label()
        Me.LblDescripNroPLanilla = New System.Windows.Forms.Label()
        Me.LblNroPLanilla = New System.Windows.Forms.Label()
        Me.LblControlrecorre = New System.Windows.Forms.Label()
        Me.Dtp1 = New System.Windows.Forms.DateTimePicker()
        Me.LblFechaEntrega = New System.Windows.Forms.Label()
        Me.BtnRotacion = New System.Windows.Forms.Button()
        Me.LblRotar = New System.Windows.Forms.Label()
        Me.BtnAbrir = New System.Windows.Forms.Button()
        Me.Btninforme = New System.Windows.Forms.Button()
        Me.BtnPlanillar = New System.Windows.Forms.Button()
        Me.LblCantidadNro = New System.Windows.Forms.Label()
        Me.LblCantidad = New System.Windows.Forms.Label()
        Me.Lblver = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.LblBusqueda = New System.Windows.Forms.Label()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnAcusesMalLeidos = New System.Windows.Forms.Button()
        Me.BtnBack = New System.Windows.Forms.Button()
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Gb.SuspendLayout()
        CType(Me.DgvDetalleArchivos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PBLogo
        '
        Me.PBLogo.Location = New System.Drawing.Point(5, 1132)
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(985, 510)
        '
        'Gb
        '
        Me.Gb.Controls.Add(Me.BtnBack)
        Me.Gb.Controls.Add(Me.BtnAcusesMalLeidos)
        Me.Gb.Controls.Add(Me.BtnCancelar)
        Me.Gb.Controls.Add(Me.LblBusqueda)
        Me.Gb.Controls.Add(Me.Lblver)
        Me.Gb.Controls.Add(Me.LblCantidadNro)
        Me.Gb.Controls.Add(Me.LblCantidad)
        Me.Gb.Controls.Add(Me.BtnPlanillar)
        Me.Gb.Controls.Add(Me.Btninforme)
        Me.Gb.Controls.Add(Me.BtnAbrir)
        Me.Gb.Controls.Add(Me.LblRotar)
        Me.Gb.Controls.Add(Me.BtnRotacion)
        Me.Gb.Controls.Add(Me.LblFechaEntrega)
        Me.Gb.Controls.Add(Me.Dtp1)
        Me.Gb.Controls.Add(Me.LblControlrecorre)
        Me.Gb.Controls.Add(Me.LblNroPLanilla)
        Me.Gb.Controls.Add(Me.LblDescripNroPLanilla)
        Me.Gb.Controls.Add(Me.LblNro)
        Me.Gb.Controls.Add(Me.BtnTermometro)
        Me.Gb.Controls.Add(Me.DgvDetalleArchivos)
        Me.Gb.Controls.Add(Me.BtnFinalizarCompletar)
        Me.Gb.Size = New System.Drawing.Size(1635, 1182)
        Me.Gb.Controls.SetChildIndex(Me.BtnFinalizarCompletar, 0)
        Me.Gb.Controls.SetChildIndex(Me.DgvDetalleArchivos, 0)
        Me.Gb.Controls.SetChildIndex(Me.BtnTermometro, 0)
        Me.Gb.Controls.SetChildIndex(Me.LblNro, 0)
        Me.Gb.Controls.SetChildIndex(Me.LblDescripNroPLanilla, 0)
        Me.Gb.Controls.SetChildIndex(Me.LblNroPLanilla, 0)
        Me.Gb.Controls.SetChildIndex(Me.LblControlrecorre, 0)
        Me.Gb.Controls.SetChildIndex(Me.Dtp1, 0)
        Me.Gb.Controls.SetChildIndex(Me.LblFechaEntrega, 0)
        Me.Gb.Controls.SetChildIndex(Me.BtnRotacion, 0)
        Me.Gb.Controls.SetChildIndex(Me.LblRotar, 0)
        Me.Gb.Controls.SetChildIndex(Me.BtnAbrir, 0)
        Me.Gb.Controls.SetChildIndex(Me.Btninforme, 0)
        Me.Gb.Controls.SetChildIndex(Me.BtnPlanillar, 0)
        Me.Gb.Controls.SetChildIndex(Me.LblCantidad, 0)
        Me.Gb.Controls.SetChildIndex(Me.LblCantidadNro, 0)
        Me.Gb.Controls.SetChildIndex(Me.Lblver, 0)
        Me.Gb.Controls.SetChildIndex(Me.LblBusqueda, 0)
        Me.Gb.Controls.SetChildIndex(Me.BtnCancelar, 0)
        Me.Gb.Controls.SetChildIndex(Me.BtnAcusesMalLeidos, 0)
        Me.Gb.Controls.SetChildIndex(Me.PBLogo, 0)
        Me.Gb.Controls.SetChildIndex(Me.BtnSalir, 0)
        Me.Gb.Controls.SetChildIndex(Me.BtnBack, 0)
        '
        'DgvDetalleArchivos
        '
        Me.DgvDetalleArchivos.AllowUserToAddRows = False
        Me.DgvDetalleArchivos.AllowUserToDeleteRows = False
        Me.DgvDetalleArchivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvDetalleArchivos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NroCartaLeido, Me.Estado, Me.Ruta_Completa})
        Me.DgvDetalleArchivos.Location = New System.Drawing.Point(13, 92)
        Me.DgvDetalleArchivos.Name = "DgvDetalleArchivos"
        Me.DgvDetalleArchivos.RowTemplate.Height = 25
        Me.DgvDetalleArchivos.Size = New System.Drawing.Size(710, 433)
        Me.DgvDetalleArchivos.TabIndex = 29
        '
        'NroCartaLeido
        '
        Me.NroCartaLeido.HeaderText = "NroCartaLeido"
        Me.NroCartaLeido.Name = "NroCartaLeido"
        '
        'Estado
        '
        Me.Estado.HeaderText = "Estado"
        Me.Estado.Name = "Estado"
        '
        'Ruta_Completa
        '
        Me.Ruta_Completa.HeaderText = "Ruta_Completa"
        Me.Ruta_Completa.Name = "Ruta_Completa"
        Me.Ruta_Completa.Width = 350
        '
        'BtnFinalizarCompletar
        '
        Me.BtnFinalizarCompletar.Location = New System.Drawing.Point(732, 114)
        Me.BtnFinalizarCompletar.Name = "BtnFinalizarCompletar"
        Me.BtnFinalizarCompletar.Size = New System.Drawing.Size(125, 49)
        Me.BtnFinalizarCompletar.TabIndex = 33
        Me.BtnFinalizarCompletar.Text = "Finalizar Lectura"
        Me.BtnFinalizarCompletar.UseVisualStyleBackColor = True
        '
        'BtnTermometro
        '
        Me.BtnTermometro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnTermometro.Image = Global.Correo.My.Resources.Resources.temperature_1
        Me.BtnTermometro.Location = New System.Drawing.Point(1004, 12)
        Me.BtnTermometro.Name = "BtnTermometro"
        Me.BtnTermometro.Size = New System.Drawing.Size(22, 48)
        Me.BtnTermometro.TabIndex = 35
        Me.BtnTermometro.UseVisualStyleBackColor = True
        '
        'LblNro
        '
        Me.LblNro.AutoSize = True
        Me.LblNro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNro.Location = New System.Drawing.Point(1171, 18)
        Me.LblNro.Name = "LblNro"
        Me.LblNro.Size = New System.Drawing.Size(14, 13)
        Me.LblNro.TabIndex = 36
        Me.LblNro.Text = "1"
        Me.LblNro.Visible = False
        '
        'LblDescripNroPLanilla
        '
        Me.LblDescripNroPLanilla.AutoSize = True
        Me.LblDescripNroPLanilla.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDescripNroPLanilla.ForeColor = System.Drawing.Color.White
        Me.LblDescripNroPLanilla.Location = New System.Drawing.Point(6, 16)
        Me.LblDescripNroPLanilla.Name = "LblDescripNroPLanilla"
        Me.LblDescripNroPLanilla.Size = New System.Drawing.Size(404, 39)
        Me.LblDescripNroPLanilla.TabIndex = 37
        Me.LblDescripNroPLanilla.Text = "Proximo Nro De Planilla :"
        '
        'LblNroPLanilla
        '
        Me.LblNroPLanilla.AutoSize = True
        Me.LblNroPLanilla.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNroPLanilla.ForeColor = System.Drawing.Color.White
        Me.LblNroPLanilla.Location = New System.Drawing.Point(404, 16)
        Me.LblNroPLanilla.Name = "LblNroPLanilla"
        Me.LblNroPLanilla.Size = New System.Drawing.Size(36, 39)
        Me.LblNroPLanilla.TabIndex = 38
        Me.LblNroPLanilla.Text = "0"
        '
        'LblControlrecorre
        '
        Me.LblControlrecorre.AutoSize = True
        Me.LblControlrecorre.ForeColor = System.Drawing.Color.White
        Me.LblControlrecorre.Location = New System.Drawing.Point(12, 528)
        Me.LblControlrecorre.Name = "LblControlrecorre"
        Me.LblControlrecorre.Size = New System.Drawing.Size(40, 13)
        Me.LblControlrecorre.TabIndex = 40
        Me.LblControlrecorre.Text = "Estado"
        '
        'Dtp1
        '
        Me.Dtp1.Location = New System.Drawing.Point(732, 89)
        Me.Dtp1.Name = "Dtp1"
        Me.Dtp1.Size = New System.Drawing.Size(210, 20)
        Me.Dtp1.TabIndex = 41
        '
        'LblFechaEntrega
        '
        Me.LblFechaEntrega.AutoSize = True
        Me.LblFechaEntrega.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFechaEntrega.ForeColor = System.Drawing.Color.White
        Me.LblFechaEntrega.Location = New System.Drawing.Point(729, 71)
        Me.LblFechaEntrega.Name = "LblFechaEntrega"
        Me.LblFechaEntrega.Size = New System.Drawing.Size(131, 13)
        Me.LblFechaEntrega.TabIndex = 42
        Me.LblFechaEntrega.Text = "FECHA DE ENTREGA"
        '
        'BtnRotacion
        '
        Me.BtnRotacion.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnRotacion.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnRotacion.Image = Global.Correo.My.Resources.Resources._2
        Me.BtnRotacion.Location = New System.Drawing.Point(732, 289)
        Me.BtnRotacion.Name = "BtnRotacion"
        Me.BtnRotacion.Size = New System.Drawing.Size(35, 35)
        Me.BtnRotacion.TabIndex = 43
        Me.BtnRotacion.UseVisualStyleBackColor = True
        '
        'LblRotar
        '
        Me.LblRotar.AutoSize = True
        Me.LblRotar.ForeColor = System.Drawing.Color.White
        Me.LblRotar.Location = New System.Drawing.Point(729, 273)
        Me.LblRotar.Name = "LblRotar"
        Me.LblRotar.Size = New System.Drawing.Size(45, 13)
        Me.LblRotar.TabIndex = 44
        Me.LblRotar.Text = "ROTAR"
        '
        'BtnAbrir
        '
        Me.BtnAbrir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnAbrir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnAbrir.Image = Global.Correo.My.Resources.Resources.edit
        Me.BtnAbrir.Location = New System.Drawing.Point(732, 491)
        Me.BtnAbrir.Name = "BtnAbrir"
        Me.BtnAbrir.Size = New System.Drawing.Size(35, 35)
        Me.BtnAbrir.TabIndex = 45
        Me.BtnAbrir.UseVisualStyleBackColor = True
        '
        'Btninforme
        '
        Me.Btninforme.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btninforme.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btninforme.Image = Global.Correo.My.Resources.Resources.chart_bar
        Me.Btninforme.Location = New System.Drawing.Point(880, 119)
        Me.Btninforme.Name = "Btninforme"
        Me.Btninforme.Size = New System.Drawing.Size(53, 38)
        Me.Btninforme.TabIndex = 46
        Me.Btninforme.UseVisualStyleBackColor = True
        Me.Btninforme.Visible = False
        '
        'BtnPlanillar
        '
        Me.BtnPlanillar.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.BtnPlanillar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPlanillar.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.BtnPlanillar.Location = New System.Drawing.Point(559, 51)
        Me.BtnPlanillar.Name = "BtnPlanillar"
        Me.BtnPlanillar.Size = New System.Drawing.Size(160, 35)
        Me.BtnPlanillar.TabIndex = 47
        Me.BtnPlanillar.Text = "Crear Planilla"
        Me.BtnPlanillar.UseVisualStyleBackColor = False
        '
        'LblCantidadNro
        '
        Me.LblCantidadNro.AutoSize = True
        Me.LblCantidadNro.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCantidadNro.ForeColor = System.Drawing.Color.White
        Me.LblCantidadNro.Location = New System.Drawing.Point(886, 12)
        Me.LblCantidadNro.Name = "LblCantidadNro"
        Me.LblCantidadNro.Size = New System.Drawing.Size(36, 39)
        Me.LblCantidadNro.TabIndex = 49
        Me.LblCantidadNro.Text = "0"
        '
        'LblCantidad
        '
        Me.LblCantidad.AutoSize = True
        Me.LblCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCantidad.ForeColor = System.Drawing.Color.White
        Me.LblCantidad.Location = New System.Drawing.Point(725, 12)
        Me.LblCantidad.Name = "LblCantidad"
        Me.LblCantidad.Size = New System.Drawing.Size(155, 39)
        Me.LblCantidad.TabIndex = 48
        Me.LblCantidad.Text = "Cantidad"
        '
        'Lblver
        '
        Me.Lblver.AutoSize = True
        Me.Lblver.ForeColor = System.Drawing.Color.White
        Me.Lblver.Location = New System.Drawing.Point(734, 475)
        Me.Lblver.Name = "Lblver"
        Me.Lblver.Size = New System.Drawing.Size(29, 13)
        Me.Lblver.TabIndex = 50
        Me.Lblver.Text = "VER"
        '
        'Timer1
        '
        Me.Timer1.Interval = 800
        '
        'LblBusqueda
        '
        Me.LblBusqueda.AutoSize = True
        Me.LblBusqueda.Location = New System.Drawing.Point(673, 528)
        Me.LblBusqueda.Name = "LblBusqueda"
        Me.LblBusqueda.Size = New System.Drawing.Size(53, 13)
        Me.LblBusqueda.TabIndex = 51
        Me.LblBusqueda.Text = "En Pausa"
        Me.LblBusqueda.Visible = False
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackColor = System.Drawing.Color.Red
        Me.BtnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.BtnCancelar.Location = New System.Drawing.Point(12, 51)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(160, 35)
        Me.BtnCancelar.TabIndex = 52
        Me.BtnCancelar.Text = "Cancelar Planilla"
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'BtnAcusesMalLeidos
        '
        Me.BtnAcusesMalLeidos.BackColor = System.Drawing.Color.Maroon
        Me.BtnAcusesMalLeidos.Location = New System.Drawing.Point(568, 528)
        Me.BtnAcusesMalLeidos.Name = "BtnAcusesMalLeidos"
        Me.BtnAcusesMalLeidos.Size = New System.Drawing.Size(155, 23)
        Me.BtnAcusesMalLeidos.TabIndex = 53
        Me.BtnAcusesMalLeidos.Text = "Acuses con errores"
        Me.BtnAcusesMalLeidos.UseVisualStyleBackColor = False
        Me.BtnAcusesMalLeidos.Visible = False
        '
        'BtnBack
        '
        Me.BtnBack.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnBack.Image = Global.Correo.My.Resources.Resources.bookshelf
        Me.BtnBack.Location = New System.Drawing.Point(985, 461)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(40, 40)
        Me.BtnBack.TabIndex = 54
        Me.BtnBack.UseVisualStyleBackColor = True
        '
        'FrmEscaneo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1038, 564)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmEscaneo"
        Me.Text = "Escaneo"
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Gb.ResumeLayout(False)
        Me.Gb.PerformLayout()
        CType(Me.DgvDetalleArchivos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DgvDetalleArchivos As System.Windows.Forms.DataGridView
    Friend WithEvents BtnFinalizarCompletar As System.Windows.Forms.Button
    Friend WithEvents BtnTermometro As System.Windows.Forms.Button
    Friend WithEvents LblNro As System.Windows.Forms.Label
    Friend WithEvents LblNroPLanilla As System.Windows.Forms.Label
    Friend WithEvents LblDescripNroPLanilla As System.Windows.Forms.Label
    Friend WithEvents NroCartaLeido As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Estado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ruta_Completa As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LblControlrecorre As System.Windows.Forms.Label
    Friend WithEvents Dtp1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents LblFechaEntrega As System.Windows.Forms.Label
    Public WithEvents BtnRotacion As System.Windows.Forms.Button
    Friend WithEvents LblRotar As System.Windows.Forms.Label
    Public WithEvents BtnAbrir As System.Windows.Forms.Button
    Friend WithEvents Btninforme As System.Windows.Forms.Button
    Friend WithEvents BtnPlanillar As System.Windows.Forms.Button
    Friend WithEvents LblCantidadNro As System.Windows.Forms.Label
    Friend WithEvents LblCantidad As System.Windows.Forms.Label
    Friend WithEvents Lblver As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents LblBusqueda As System.Windows.Forms.Label
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
    Friend WithEvents BtnAcusesMalLeidos As System.Windows.Forms.Button
    Public WithEvents BtnBack As System.Windows.Forms.Button

End Class
