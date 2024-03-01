<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPpal
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPpal))
        Me.PanelAltasyModificaciones = New System.Windows.Forms.Panel()
        Me.BtnListadoPiezas = New System.Windows.Forms.Button()
        Me.BtnConfEntreDevoSucu = New System.Windows.Forms.Button()
        Me.BtnReporteZonales = New System.Windows.Forms.Button()
        Me.Btncarteros = New System.Windows.Forms.Button()
        Me.LblAltasyModificaciones = New System.Windows.Forms.Label()
        Me.PanelEtapas = New System.Windows.Forms.Panel()
        Me.BtnMotivos = New System.Windows.Forms.Button()
        Me.BtnConfirmacionAcuse = New System.Windows.Forms.Button()
        Me.FrmPLanillaZonales = New System.Windows.Forms.Button()
        Me.FrmDevolucion = New System.Windows.Forms.Button()
        Me.Btnimpresionplanificacion = New System.Windows.Forms.Button()
        Me.Btnplanificacion = New System.Windows.Forms.Button()
        Me.BtnSeguimiento = New System.Windows.Forms.Button()
        Me.LblSeguimiento = New System.Windows.Forms.Label()
        Me.Panelinteriorpendientes = New System.Windows.Forms.Panel()
        Me.Lblpendientes = New System.Windows.Forms.Label()
        Me.Btnpendientes = New System.Windows.Forms.Button()
        Me.Panelinteriortransito = New System.Windows.Forms.Panel()
        Me.Lbltransito = New System.Windows.Forms.Label()
        Me.Btntransito = New System.Windows.Forms.Button()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.Panelinteriorentregadas = New System.Windows.Forms.Panel()
        Me.Btnentregadas = New System.Windows.Forms.Button()
        Me.Lblentregadas = New System.Windows.Forms.Label()
        Me.Paneldeimportacion = New System.Windows.Forms.Panel()
        Me.PanelinteriorEscaneo = New System.Windows.Forms.Panel()
        Me.LblEscaneo = New System.Windows.Forms.Label()
        Me.BtnEscaneo = New System.Windows.Forms.Button()
        Me.Panelinteriorimportar = New System.Windows.Forms.Panel()
        Me.Lblimportar = New System.Windows.Forms.Label()
        Me.Btnimportar = New System.Windows.Forms.Button()
        Me.PanelInfoCte = New System.Windows.Forms.Panel()
        Me.Panelinteriorvisitadas = New System.Windows.Forms.Panel()
        Me.Lblvisitada = New System.Windows.Forms.Label()
        Me.Btnvisitadas = New System.Windows.Forms.Button()
        Me.Panelinternoconsulta = New System.Windows.Forms.Panel()
        Me.Lblconsulta = New System.Windows.Forms.Label()
        Me.Btnconsulta = New System.Windows.Forms.Button()
        Me.Panelconsulta = New System.Windows.Forms.Panel()
        Me.PanelinteriorConsultaTR = New System.Windows.Forms.Panel()
        Me.LblConsultaTR = New System.Windows.Forms.Label()
        Me.BtnConsultaTR = New System.Windows.Forms.Button()
        Me.PanelInformes = New System.Windows.Forms.Panel()
        Me.LblNro = New System.Windows.Forms.Label()
        Me.BtnConfiguracion = New System.Windows.Forms.Button()
        Me.PnlConfiguracion = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ChkActivarConfig = New System.Windows.Forms.CheckBox()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnTermometro = New System.Windows.Forms.Button()
        Me.BtnTransoft = New System.Windows.Forms.Button()
        Me.PanelAltasyModificaciones.SuspendLayout()
        Me.PanelEtapas.SuspendLayout()
        Me.Panelinteriorpendientes.SuspendLayout()
        Me.Panelinteriortransito.SuspendLayout()
        Me.Panelinteriorentregadas.SuspendLayout()
        Me.Paneldeimportacion.SuspendLayout()
        Me.PanelinteriorEscaneo.SuspendLayout()
        Me.Panelinteriorimportar.SuspendLayout()
        Me.PanelInfoCte.SuspendLayout()
        Me.Panelinteriorvisitadas.SuspendLayout()
        Me.Panelinternoconsulta.SuspendLayout()
        Me.Panelconsulta.SuspendLayout()
        Me.PanelinteriorConsultaTR.SuspendLayout()
        Me.PanelInformes.SuspendLayout()
        Me.PnlConfiguracion.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelAltasyModificaciones
        '
        Me.PanelAltasyModificaciones.BackColor = System.Drawing.Color.DarkGray
        Me.PanelAltasyModificaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelAltasyModificaciones.Controls.Add(Me.BtnListadoPiezas)
        Me.PanelAltasyModificaciones.Controls.Add(Me.BtnConfEntreDevoSucu)
        Me.PanelAltasyModificaciones.Controls.Add(Me.BtnReporteZonales)
        Me.PanelAltasyModificaciones.Controls.Add(Me.Btncarteros)
        Me.PanelAltasyModificaciones.Controls.Add(Me.LblAltasyModificaciones)
        Me.PanelAltasyModificaciones.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PanelAltasyModificaciones.Location = New System.Drawing.Point(12, 11)
        Me.PanelAltasyModificaciones.Name = "PanelAltasyModificaciones"
        Me.PanelAltasyModificaciones.Size = New System.Drawing.Size(183, 278)
        Me.PanelAltasyModificaciones.TabIndex = 14
        '
        'BtnListadoPiezas
        '
        Me.BtnListadoPiezas.BackColor = System.Drawing.Color.White
        Me.BtnListadoPiezas.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnListadoPiezas.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnListadoPiezas.ForeColor = System.Drawing.Color.Maroon
        Me.BtnListadoPiezas.Location = New System.Drawing.Point(6, 110)
        Me.BtnListadoPiezas.Name = "BtnListadoPiezas"
        Me.BtnListadoPiezas.Size = New System.Drawing.Size(156, 23)
        Me.BtnListadoPiezas.TabIndex = 44
        Me.BtnListadoPiezas.Text = "Listado de Piezas"
        Me.BtnListadoPiezas.UseVisualStyleBackColor = False
        '
        'BtnConfEntreDevoSucu
        '
        Me.BtnConfEntreDevoSucu.BackColor = System.Drawing.Color.White
        Me.BtnConfEntreDevoSucu.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnConfEntreDevoSucu.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConfEntreDevoSucu.ForeColor = System.Drawing.Color.Maroon
        Me.BtnConfEntreDevoSucu.Location = New System.Drawing.Point(6, 81)
        Me.BtnConfEntreDevoSucu.Name = "BtnConfEntreDevoSucu"
        Me.BtnConfEntreDevoSucu.Size = New System.Drawing.Size(156, 23)
        Me.BtnConfEntreDevoSucu.TabIndex = 3
        Me.BtnConfEntreDevoSucu.Text = "Reporte En Excel"
        Me.BtnConfEntreDevoSucu.UseVisualStyleBackColor = False
        '
        'BtnReporteZonales
        '
        Me.BtnReporteZonales.BackColor = System.Drawing.Color.White
        Me.BtnReporteZonales.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnReporteZonales.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReporteZonales.ForeColor = System.Drawing.Color.Maroon
        Me.BtnReporteZonales.Location = New System.Drawing.Point(6, 52)
        Me.BtnReporteZonales.Name = "BtnReporteZonales"
        Me.BtnReporteZonales.Size = New System.Drawing.Size(156, 23)
        Me.BtnReporteZonales.TabIndex = 2
        Me.BtnReporteZonales.Text = "Reporte Zonal"
        Me.BtnReporteZonales.UseVisualStyleBackColor = False
        '
        'Btncarteros
        '
        Me.Btncarteros.BackColor = System.Drawing.Color.White
        Me.Btncarteros.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Btncarteros.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btncarteros.ForeColor = System.Drawing.Color.Maroon
        Me.Btncarteros.Location = New System.Drawing.Point(6, 22)
        Me.Btncarteros.Name = "Btncarteros"
        Me.Btncarteros.Size = New System.Drawing.Size(156, 23)
        Me.Btncarteros.TabIndex = 1
        Me.Btncarteros.Text = "Carteros"
        Me.Btncarteros.UseVisualStyleBackColor = False
        '
        'LblAltasyModificaciones
        '
        Me.LblAltasyModificaciones.AutoSize = True
        Me.LblAltasyModificaciones.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAltasyModificaciones.ForeColor = System.Drawing.Color.Maroon
        Me.LblAltasyModificaciones.Location = New System.Drawing.Point(41, 7)
        Me.LblAltasyModificaciones.Name = "LblAltasyModificaciones"
        Me.LblAltasyModificaciones.Size = New System.Drawing.Size(88, 16)
        Me.LblAltasyModificaciones.TabIndex = 0
        Me.LblAltasyModificaciones.Text = "Altas y Modif"
        '
        'PanelEtapas
        '
        Me.PanelEtapas.BackColor = System.Drawing.Color.DarkGray
        Me.PanelEtapas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelEtapas.Controls.Add(Me.BtnMotivos)
        Me.PanelEtapas.Controls.Add(Me.BtnConfirmacionAcuse)
        Me.PanelEtapas.Controls.Add(Me.FrmPLanillaZonales)
        Me.PanelEtapas.Controls.Add(Me.FrmDevolucion)
        Me.PanelEtapas.Controls.Add(Me.Btnimpresionplanificacion)
        Me.PanelEtapas.Controls.Add(Me.Btnplanificacion)
        Me.PanelEtapas.Controls.Add(Me.BtnSeguimiento)
        Me.PanelEtapas.Controls.Add(Me.LblSeguimiento)
        Me.PanelEtapas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PanelEtapas.Location = New System.Drawing.Point(201, 12)
        Me.PanelEtapas.Name = "PanelEtapas"
        Me.PanelEtapas.Size = New System.Drawing.Size(226, 277)
        Me.PanelEtapas.TabIndex = 13
        '
        'BtnMotivos
        '
        Me.BtnMotivos.BackColor = System.Drawing.Color.White
        Me.BtnMotivos.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnMotivos.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMotivos.ForeColor = System.Drawing.Color.Maroon
        Me.BtnMotivos.Location = New System.Drawing.Point(27, 194)
        Me.BtnMotivos.Name = "BtnMotivos"
        Me.BtnMotivos.Size = New System.Drawing.Size(165, 23)
        Me.BtnMotivos.TabIndex = 8
        Me.BtnMotivos.Text = "Editar motivos"
        Me.BtnMotivos.UseVisualStyleBackColor = False
        '
        'BtnConfirmacionAcuse
        '
        Me.BtnConfirmacionAcuse.BackColor = System.Drawing.Color.White
        Me.BtnConfirmacionAcuse.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnConfirmacionAcuse.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConfirmacionAcuse.ForeColor = System.Drawing.Color.Maroon
        Me.BtnConfirmacionAcuse.Location = New System.Drawing.Point(27, 166)
        Me.BtnConfirmacionAcuse.Name = "BtnConfirmacionAcuse"
        Me.BtnConfirmacionAcuse.Size = New System.Drawing.Size(165, 23)
        Me.BtnConfirmacionAcuse.TabIndex = 7
        Me.BtnConfirmacionAcuse.Text = "Confirmacion Acuse"
        Me.BtnConfirmacionAcuse.UseVisualStyleBackColor = False
        '
        'FrmPLanillaZonales
        '
        Me.FrmPLanillaZonales.BackColor = System.Drawing.Color.White
        Me.FrmPLanillaZonales.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.FrmPLanillaZonales.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FrmPLanillaZonales.ForeColor = System.Drawing.Color.Maroon
        Me.FrmPLanillaZonales.Location = New System.Drawing.Point(27, 108)
        Me.FrmPLanillaZonales.Name = "FrmPLanillaZonales"
        Me.FrmPLanillaZonales.Size = New System.Drawing.Size(165, 23)
        Me.FrmPLanillaZonales.TabIndex = 6
        Me.FrmPLanillaZonales.Text = "Planilla Zonales"
        Me.FrmPLanillaZonales.UseVisualStyleBackColor = False
        '
        'FrmDevolucion
        '
        Me.FrmDevolucion.BackColor = System.Drawing.Color.White
        Me.FrmDevolucion.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.FrmDevolucion.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FrmDevolucion.ForeColor = System.Drawing.Color.Maroon
        Me.FrmDevolucion.Location = New System.Drawing.Point(27, 137)
        Me.FrmDevolucion.Name = "FrmDevolucion"
        Me.FrmDevolucion.Size = New System.Drawing.Size(165, 23)
        Me.FrmDevolucion.TabIndex = 5
        Me.FrmDevolucion.Text = "Devolucion"
        Me.FrmDevolucion.UseVisualStyleBackColor = False
        '
        'Btnimpresionplanificacion
        '
        Me.Btnimpresionplanificacion.BackColor = System.Drawing.Color.White
        Me.Btnimpresionplanificacion.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Btnimpresionplanificacion.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnimpresionplanificacion.ForeColor = System.Drawing.Color.Maroon
        Me.Btnimpresionplanificacion.Location = New System.Drawing.Point(27, 79)
        Me.Btnimpresionplanificacion.Name = "Btnimpresionplanificacion"
        Me.Btnimpresionplanificacion.Size = New System.Drawing.Size(165, 23)
        Me.Btnimpresionplanificacion.TabIndex = 4
        Me.Btnimpresionplanificacion.Text = "Imprimir Planillas "
        Me.Btnimpresionplanificacion.UseVisualStyleBackColor = False
        '
        'Btnplanificacion
        '
        Me.Btnplanificacion.BackColor = System.Drawing.Color.White
        Me.Btnplanificacion.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Btnplanificacion.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnplanificacion.ForeColor = System.Drawing.Color.Maroon
        Me.Btnplanificacion.Location = New System.Drawing.Point(27, 50)
        Me.Btnplanificacion.Name = "Btnplanificacion"
        Me.Btnplanificacion.Size = New System.Drawing.Size(165, 23)
        Me.Btnplanificacion.TabIndex = 2
        Me.Btnplanificacion.Text = "Planificacion"
        Me.Btnplanificacion.UseVisualStyleBackColor = False
        '
        'BtnSeguimiento
        '
        Me.BtnSeguimiento.BackColor = System.Drawing.Color.White
        Me.BtnSeguimiento.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnSeguimiento.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSeguimiento.ForeColor = System.Drawing.Color.Maroon
        Me.BtnSeguimiento.Location = New System.Drawing.Point(27, 22)
        Me.BtnSeguimiento.Name = "BtnSeguimiento"
        Me.BtnSeguimiento.Size = New System.Drawing.Size(165, 23)
        Me.BtnSeguimiento.TabIndex = 1
        Me.BtnSeguimiento.Text = "Seguimiento"
        Me.BtnSeguimiento.UseVisualStyleBackColor = False
        '
        'LblSeguimiento
        '
        Me.LblSeguimiento.AutoSize = True
        Me.LblSeguimiento.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSeguimiento.ForeColor = System.Drawing.Color.Maroon
        Me.LblSeguimiento.Location = New System.Drawing.Point(87, 6)
        Me.LblSeguimiento.Name = "LblSeguimiento"
        Me.LblSeguimiento.Size = New System.Drawing.Size(47, 16)
        Me.LblSeguimiento.TabIndex = 0
        Me.LblSeguimiento.Text = "Etapas"
        '
        'Panelinteriorpendientes
        '
        Me.Panelinteriorpendientes.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panelinteriorpendientes.BackColor = System.Drawing.Color.LightGray
        Me.Panelinteriorpendientes.Controls.Add(Me.Lblpendientes)
        Me.Panelinteriorpendientes.Controls.Add(Me.Btnpendientes)
        Me.Panelinteriorpendientes.Location = New System.Drawing.Point(92, 13)
        Me.Panelinteriorpendientes.Name = "Panelinteriorpendientes"
        Me.Panelinteriorpendientes.Size = New System.Drawing.Size(79, 74)
        Me.Panelinteriorpendientes.TabIndex = 24
        '
        'Lblpendientes
        '
        Me.Lblpendientes.AutoSize = True
        Me.Lblpendientes.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblpendientes.ForeColor = System.Drawing.Color.Maroon
        Me.Lblpendientes.Location = New System.Drawing.Point(5, 6)
        Me.Lblpendientes.Name = "Lblpendientes"
        Me.Lblpendientes.Size = New System.Drawing.Size(68, 16)
        Me.Lblpendientes.TabIndex = 0
        Me.Lblpendientes.Text = "Pendientes"
        '
        'Btnpendientes
        '
        Me.Btnpendientes.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btnpendientes.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btnpendientes.Image = Global.Correo.My.Resources.Resources.arrow_in
        Me.Btnpendientes.Location = New System.Drawing.Point(14, 30)
        Me.Btnpendientes.Name = "Btnpendientes"
        Me.Btnpendientes.Size = New System.Drawing.Size(53, 38)
        Me.Btnpendientes.TabIndex = 21
        Me.Btnpendientes.UseVisualStyleBackColor = True
        '
        'Panelinteriortransito
        '
        Me.Panelinteriortransito.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panelinteriortransito.BackColor = System.Drawing.Color.LightGray
        Me.Panelinteriortransito.Controls.Add(Me.Lbltransito)
        Me.Panelinteriortransito.Controls.Add(Me.Btntransito)
        Me.Panelinteriortransito.Location = New System.Drawing.Point(7, 13)
        Me.Panelinteriortransito.Name = "Panelinteriortransito"
        Me.Panelinteriortransito.Size = New System.Drawing.Size(79, 74)
        Me.Panelinteriortransito.TabIndex = 26
        '
        'Lbltransito
        '
        Me.Lbltransito.AutoSize = True
        Me.Lbltransito.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbltransito.ForeColor = System.Drawing.Color.Maroon
        Me.Lbltransito.Location = New System.Drawing.Point(16, 8)
        Me.Lbltransito.Name = "Lbltransito"
        Me.Lbltransito.Size = New System.Drawing.Size(55, 16)
        Me.Lbltransito.TabIndex = 0
        Me.Lbltransito.Text = "Transito"
        '
        'Btntransito
        '
        Me.Btntransito.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btntransito.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btntransito.Image = Global.Correo.My.Resources.Resources.brain_trainer
        Me.Btntransito.Location = New System.Drawing.Point(12, 32)
        Me.Btntransito.Name = "Btntransito"
        Me.Btntransito.Size = New System.Drawing.Size(53, 38)
        Me.Btntransito.TabIndex = 20
        Me.Btntransito.UseVisualStyleBackColor = True
        '
        'Timer
        '
        Me.Timer.Interval = 500
        '
        'Panelinteriorentregadas
        '
        Me.Panelinteriorentregadas.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panelinteriorentregadas.BackColor = System.Drawing.Color.LightGray
        Me.Panelinteriorentregadas.Controls.Add(Me.Btnentregadas)
        Me.Panelinteriorentregadas.Controls.Add(Me.Lblentregadas)
        Me.Panelinteriorentregadas.Location = New System.Drawing.Point(6, 13)
        Me.Panelinteriorentregadas.Name = "Panelinteriorentregadas"
        Me.Panelinteriorentregadas.Size = New System.Drawing.Size(79, 74)
        Me.Panelinteriorentregadas.TabIndex = 31
        '
        'Btnentregadas
        '
        Me.Btnentregadas.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btnentregadas.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btnentregadas.Image = Global.Correo.My.Resources.Resources.email
        Me.Btnentregadas.Location = New System.Drawing.Point(12, 30)
        Me.Btnentregadas.Name = "Btnentregadas"
        Me.Btnentregadas.Size = New System.Drawing.Size(53, 38)
        Me.Btnentregadas.TabIndex = 20
        Me.Btnentregadas.UseVisualStyleBackColor = True
        '
        'Lblentregadas
        '
        Me.Lblentregadas.AutoSize = True
        Me.Lblentregadas.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblentregadas.ForeColor = System.Drawing.Color.Maroon
        Me.Lblentregadas.Location = New System.Drawing.Point(4, 6)
        Me.Lblentregadas.Name = "Lblentregadas"
        Me.Lblentregadas.Size = New System.Drawing.Size(73, 16)
        Me.Lblentregadas.TabIndex = 0
        Me.Lblentregadas.Text = "Entregadas"
        '
        'Paneldeimportacion
        '
        Me.Paneldeimportacion.BackColor = System.Drawing.Color.DarkGray
        Me.Paneldeimportacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Paneldeimportacion.Controls.Add(Me.PanelinteriorEscaneo)
        Me.Paneldeimportacion.Controls.Add(Me.Panelinteriorimportar)
        Me.Paneldeimportacion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Paneldeimportacion.Location = New System.Drawing.Point(451, 12)
        Me.Paneldeimportacion.Name = "Paneldeimportacion"
        Me.Paneldeimportacion.Size = New System.Drawing.Size(183, 100)
        Me.Paneldeimportacion.TabIndex = 35
        '
        'PanelinteriorEscaneo
        '
        Me.PanelinteriorEscaneo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PanelinteriorEscaneo.BackColor = System.Drawing.Color.LightGray
        Me.PanelinteriorEscaneo.Controls.Add(Me.LblEscaneo)
        Me.PanelinteriorEscaneo.Controls.Add(Me.BtnEscaneo)
        Me.PanelinteriorEscaneo.Location = New System.Drawing.Point(90, 13)
        Me.PanelinteriorEscaneo.Name = "PanelinteriorEscaneo"
        Me.PanelinteriorEscaneo.Size = New System.Drawing.Size(79, 74)
        Me.PanelinteriorEscaneo.TabIndex = 27
        '
        'LblEscaneo
        '
        Me.LblEscaneo.AutoSize = True
        Me.LblEscaneo.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEscaneo.ForeColor = System.Drawing.Color.Maroon
        Me.LblEscaneo.Location = New System.Drawing.Point(16, 8)
        Me.LblEscaneo.Name = "LblEscaneo"
        Me.LblEscaneo.Size = New System.Drawing.Size(46, 16)
        Me.LblEscaneo.TabIndex = 0
        Me.LblEscaneo.Text = "Remito"
        '
        'BtnEscaneo
        '
        Me.BtnEscaneo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnEscaneo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnEscaneo.Image = Global.Correo.My.Resources.Resources.remito
        Me.BtnEscaneo.Location = New System.Drawing.Point(12, 32)
        Me.BtnEscaneo.Name = "BtnEscaneo"
        Me.BtnEscaneo.Size = New System.Drawing.Size(53, 38)
        Me.BtnEscaneo.TabIndex = 20
        Me.BtnEscaneo.UseVisualStyleBackColor = True
        '
        'Panelinteriorimportar
        '
        Me.Panelinteriorimportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panelinteriorimportar.BackColor = System.Drawing.Color.LightGray
        Me.Panelinteriorimportar.Controls.Add(Me.Lblimportar)
        Me.Panelinteriorimportar.Controls.Add(Me.Btnimportar)
        Me.Panelinteriorimportar.Location = New System.Drawing.Point(6, 13)
        Me.Panelinteriorimportar.Name = "Panelinteriorimportar"
        Me.Panelinteriorimportar.Size = New System.Drawing.Size(79, 74)
        Me.Panelinteriorimportar.TabIndex = 28
        '
        'Lblimportar
        '
        Me.Lblimportar.AutoSize = True
        Me.Lblimportar.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblimportar.ForeColor = System.Drawing.Color.Maroon
        Me.Lblimportar.Location = New System.Drawing.Point(13, 8)
        Me.Lblimportar.Name = "Lblimportar"
        Me.Lblimportar.Size = New System.Drawing.Size(60, 16)
        Me.Lblimportar.TabIndex = 0
        Me.Lblimportar.Text = "Importar"
        '
        'Btnimportar
        '
        Me.Btnimportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btnimportar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btnimportar.Image = Global.Correo.My.Resources.Resources.red_line
        Me.Btnimportar.Location = New System.Drawing.Point(12, 32)
        Me.Btnimportar.Name = "Btnimportar"
        Me.Btnimportar.Size = New System.Drawing.Size(53, 38)
        Me.Btnimportar.TabIndex = 20
        Me.Btnimportar.UseVisualStyleBackColor = True
        '
        'PanelInfoCte
        '
        Me.PanelInfoCte.BackColor = System.Drawing.Color.DarkGray
        Me.PanelInfoCte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelInfoCte.Controls.Add(Me.Panelinteriorentregadas)
        Me.PanelInfoCte.Controls.Add(Me.Panelinteriorvisitadas)
        Me.PanelInfoCte.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PanelInfoCte.Location = New System.Drawing.Point(451, 155)
        Me.PanelInfoCte.Name = "PanelInfoCte"
        Me.PanelInfoCte.Size = New System.Drawing.Size(183, 100)
        Me.PanelInfoCte.TabIndex = 36
        '
        'Panelinteriorvisitadas
        '
        Me.Panelinteriorvisitadas.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panelinteriorvisitadas.BackColor = System.Drawing.Color.LightGray
        Me.Panelinteriorvisitadas.Controls.Add(Me.Lblvisitada)
        Me.Panelinteriorvisitadas.Controls.Add(Me.Btnvisitadas)
        Me.Panelinteriorvisitadas.Location = New System.Drawing.Point(90, 13)
        Me.Panelinteriorvisitadas.Name = "Panelinteriorvisitadas"
        Me.Panelinteriorvisitadas.Size = New System.Drawing.Size(79, 74)
        Me.Panelinteriorvisitadas.TabIndex = 28
        '
        'Lblvisitada
        '
        Me.Lblvisitada.AutoSize = True
        Me.Lblvisitada.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblvisitada.ForeColor = System.Drawing.Color.Maroon
        Me.Lblvisitada.Location = New System.Drawing.Point(12, 7)
        Me.Lblvisitada.Name = "Lblvisitada"
        Me.Lblvisitada.Size = New System.Drawing.Size(60, 16)
        Me.Lblvisitada.TabIndex = 0
        Me.Lblvisitada.Text = "Visitadas"
        '
        'Btnvisitadas
        '
        Me.Btnvisitadas.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btnvisitadas.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btnvisitadas.Image = Global.Correo.My.Resources.Resources.tick
        Me.Btnvisitadas.Location = New System.Drawing.Point(15, 31)
        Me.Btnvisitadas.Name = "Btnvisitadas"
        Me.Btnvisitadas.Size = New System.Drawing.Size(53, 38)
        Me.Btnvisitadas.TabIndex = 20
        Me.Btnvisitadas.UseVisualStyleBackColor = True
        '
        'Panelinternoconsulta
        '
        Me.Panelinternoconsulta.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panelinternoconsulta.BackColor = System.Drawing.Color.LightGray
        Me.Panelinternoconsulta.Controls.Add(Me.Lblconsulta)
        Me.Panelinternoconsulta.Controls.Add(Me.Btnconsulta)
        Me.Panelinternoconsulta.Location = New System.Drawing.Point(7, 12)
        Me.Panelinternoconsulta.Name = "Panelinternoconsulta"
        Me.Panelinternoconsulta.Size = New System.Drawing.Size(79, 74)
        Me.Panelinternoconsulta.TabIndex = 22
        '
        'Lblconsulta
        '
        Me.Lblconsulta.AutoSize = True
        Me.Lblconsulta.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblconsulta.ForeColor = System.Drawing.Color.Maroon
        Me.Lblconsulta.Location = New System.Drawing.Point(13, 7)
        Me.Lblconsulta.Name = "Lblconsulta"
        Me.Lblconsulta.Size = New System.Drawing.Size(54, 16)
        Me.Lblconsulta.TabIndex = 0
        Me.Lblconsulta.Text = "Consulta"
        '
        'Btnconsulta
        '
        Me.Btnconsulta.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btnconsulta.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btnconsulta.Image = Global.Correo.My.Resources.Resources.comment_edit
        Me.Btnconsulta.Location = New System.Drawing.Point(13, 32)
        Me.Btnconsulta.Name = "Btnconsulta"
        Me.Btnconsulta.Size = New System.Drawing.Size(53, 38)
        Me.Btnconsulta.TabIndex = 17
        Me.Btnconsulta.UseVisualStyleBackColor = True
        '
        'Panelconsulta
        '
        Me.Panelconsulta.BackColor = System.Drawing.Color.DarkGray
        Me.Panelconsulta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panelconsulta.Controls.Add(Me.PanelinteriorConsultaTR)
        Me.Panelconsulta.Controls.Add(Me.Panelinternoconsulta)
        Me.Panelconsulta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Panelconsulta.Location = New System.Drawing.Point(640, 15)
        Me.Panelconsulta.Name = "Panelconsulta"
        Me.Panelconsulta.Size = New System.Drawing.Size(188, 100)
        Me.Panelconsulta.TabIndex = 40
        '
        'PanelinteriorConsultaTR
        '
        Me.PanelinteriorConsultaTR.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PanelinteriorConsultaTR.BackColor = System.Drawing.Color.LightGray
        Me.PanelinteriorConsultaTR.Controls.Add(Me.LblConsultaTR)
        Me.PanelinteriorConsultaTR.Controls.Add(Me.BtnConsultaTR)
        Me.PanelinteriorConsultaTR.Location = New System.Drawing.Point(92, 12)
        Me.PanelinteriorConsultaTR.Name = "PanelinteriorConsultaTR"
        Me.PanelinteriorConsultaTR.Size = New System.Drawing.Size(79, 74)
        Me.PanelinteriorConsultaTR.TabIndex = 25
        '
        'LblConsultaTR
        '
        Me.LblConsultaTR.AutoSize = True
        Me.LblConsultaTR.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblConsultaTR.ForeColor = System.Drawing.Color.Maroon
        Me.LblConsultaTR.Location = New System.Drawing.Point(5, 8)
        Me.LblConsultaTR.Name = "LblConsultaTR"
        Me.LblConsultaTR.Size = New System.Drawing.Size(70, 16)
        Me.LblConsultaTR.TabIndex = 0
        Me.LblConsultaTR.Text = "ConsultaTR"
        '
        'BtnConsultaTR
        '
        Me.BtnConsultaTR.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnConsultaTR.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnConsultaTR.Image = Global.Correo.My.Resources.Resources.comment_edit
        Me.BtnConsultaTR.Location = New System.Drawing.Point(13, 32)
        Me.BtnConsultaTR.Name = "BtnConsultaTR"
        Me.BtnConsultaTR.Size = New System.Drawing.Size(53, 38)
        Me.BtnConsultaTR.TabIndex = 17
        Me.BtnConsultaTR.UseVisualStyleBackColor = True
        '
        'PanelInformes
        '
        Me.PanelInformes.BackColor = System.Drawing.Color.DarkGray
        Me.PanelInformes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelInformes.Controls.Add(Me.Panelinteriortransito)
        Me.PanelInformes.Controls.Add(Me.Panelinteriorpendientes)
        Me.PanelInformes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PanelInformes.Location = New System.Drawing.Point(640, 155)
        Me.PanelInformes.Name = "PanelInformes"
        Me.PanelInformes.Size = New System.Drawing.Size(188, 100)
        Me.PanelInformes.TabIndex = 41
        '
        'LblNro
        '
        Me.LblNro.AutoSize = True
        Me.LblNro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNro.Location = New System.Drawing.Point(814, 394)
        Me.LblNro.Name = "LblNro"
        Me.LblNro.Size = New System.Drawing.Size(14, 13)
        Me.LblNro.TabIndex = 0
        Me.LblNro.Text = "1"
        Me.LblNro.Visible = False
        '
        'BtnConfiguracion
        '
        Me.BtnConfiguracion.BackColor = System.Drawing.Color.White
        Me.BtnConfiguracion.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnConfiguracion.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConfiguracion.ForeColor = System.Drawing.Color.Maroon
        Me.BtnConfiguracion.Location = New System.Drawing.Point(6, 46)
        Me.BtnConfiguracion.Name = "BtnConfiguracion"
        Me.BtnConfiguracion.Size = New System.Drawing.Size(165, 23)
        Me.BtnConfiguracion.TabIndex = 8
        Me.BtnConfiguracion.Text = "Configuracion"
        Me.BtnConfiguracion.UseVisualStyleBackColor = False
        '
        'PnlConfiguracion
        '
        Me.PnlConfiguracion.BackColor = System.Drawing.Color.DarkGray
        Me.PnlConfiguracion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlConfiguracion.Controls.Add(Me.Label1)
        Me.PnlConfiguracion.Controls.Add(Me.BtnConfiguracion)
        Me.PnlConfiguracion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PnlConfiguracion.Enabled = False
        Me.PnlConfiguracion.Location = New System.Drawing.Point(12, 347)
        Me.PnlConfiguracion.Name = "PnlConfiguracion"
        Me.PnlConfiguracion.Size = New System.Drawing.Size(183, 114)
        Me.PnlConfiguracion.TabIndex = 42
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(41, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Altas y Modif"
        '
        'ChkActivarConfig
        '
        Me.ChkActivarConfig.AutoSize = True
        Me.ChkActivarConfig.Location = New System.Drawing.Point(12, 324)
        Me.ChkActivarConfig.Name = "ChkActivarConfig"
        Me.ChkActivarConfig.Size = New System.Drawing.Size(59, 17)
        Me.ChkActivarConfig.TabIndex = 43
        Me.ChkActivarConfig.Text = "Activar"
        Me.ChkActivarConfig.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnSalir.Image = CType(resources.GetObject("BtnSalir.Image"), System.Drawing.Image)
        Me.BtnSalir.Location = New System.Drawing.Point(775, 515)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(53, 48)
        Me.BtnSalir.TabIndex = 19
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'BtnTermometro
        '
        Me.BtnTermometro.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnTermometro.Image = Global.Correo.My.Resources.Resources.temperature_1
        Me.BtnTermometro.Location = New System.Drawing.Point(748, 515)
        Me.BtnTermometro.Name = "BtnTermometro"
        Me.BtnTermometro.Size = New System.Drawing.Size(22, 48)
        Me.BtnTermometro.TabIndex = 20
        Me.BtnTermometro.UseVisualStyleBackColor = True
        '
        'BtnTransoft
        '
        Me.BtnTransoft.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnTransoft.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnTransoft.Image = Global.Correo.My.Resources.Resources.comment_edit
        Me.BtnTransoft.Location = New System.Drawing.Point(12, 505)
        Me.BtnTransoft.Name = "BtnTransoft"
        Me.BtnTransoft.Size = New System.Drawing.Size(73, 58)
        Me.BtnTransoft.TabIndex = 21
        Me.BtnTransoft.UseVisualStyleBackColor = True
        '
        'FrmPpal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(840, 579)
        Me.Controls.Add(Me.BtnTransoft)
        Me.Controls.Add(Me.ChkActivarConfig)
        Me.Controls.Add(Me.PnlConfiguracion)
        Me.Controls.Add(Me.PanelInformes)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.LblNro)
        Me.Controls.Add(Me.Panelconsulta)
        Me.Controls.Add(Me.BtnTermometro)
        Me.Controls.Add(Me.PanelInfoCte)
        Me.Controls.Add(Me.Paneldeimportacion)
        Me.Controls.Add(Me.PanelAltasyModificaciones)
        Me.Controls.Add(Me.PanelEtapas)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmPpal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PanelAltasyModificaciones.ResumeLayout(False)
        Me.PanelAltasyModificaciones.PerformLayout()
        Me.PanelEtapas.ResumeLayout(False)
        Me.PanelEtapas.PerformLayout()
        Me.Panelinteriorpendientes.ResumeLayout(False)
        Me.Panelinteriorpendientes.PerformLayout()
        Me.Panelinteriortransito.ResumeLayout(False)
        Me.Panelinteriortransito.PerformLayout()
        Me.Panelinteriorentregadas.ResumeLayout(False)
        Me.Panelinteriorentregadas.PerformLayout()
        Me.Paneldeimportacion.ResumeLayout(False)
        Me.PanelinteriorEscaneo.ResumeLayout(False)
        Me.PanelinteriorEscaneo.PerformLayout()
        Me.Panelinteriorimportar.ResumeLayout(False)
        Me.Panelinteriorimportar.PerformLayout()
        Me.PanelInfoCte.ResumeLayout(False)
        Me.Panelinteriorvisitadas.ResumeLayout(False)
        Me.Panelinteriorvisitadas.PerformLayout()
        Me.Panelinternoconsulta.ResumeLayout(False)
        Me.Panelinternoconsulta.PerformLayout()
        Me.Panelconsulta.ResumeLayout(False)
        Me.PanelinteriorConsultaTR.ResumeLayout(False)
        Me.PanelinteriorConsultaTR.PerformLayout()
        Me.PanelInformes.ResumeLayout(False)
        Me.PnlConfiguracion.ResumeLayout(False)
        Me.PnlConfiguracion.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PanelAltasyModificaciones As System.Windows.Forms.Panel
    Friend WithEvents Btncarteros As System.Windows.Forms.Button
    Friend WithEvents LblAltasyModificaciones As System.Windows.Forms.Label
    Friend WithEvents PanelEtapas As System.Windows.Forms.Panel
    Friend WithEvents BtnSeguimiento As System.Windows.Forms.Button
    Friend WithEvents LblSeguimiento As System.Windows.Forms.Label
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents Btnpendientes As System.Windows.Forms.Button
    Friend WithEvents Panelinteriorpendientes As System.Windows.Forms.Panel
    Friend WithEvents Lblpendientes As System.Windows.Forms.Label
    Friend WithEvents Panelinteriortransito As System.Windows.Forms.Panel
    Friend WithEvents Lbltransito As System.Windows.Forms.Label
    Friend WithEvents Btntransito As System.Windows.Forms.Button
    Friend WithEvents Timer As System.Windows.Forms.Timer
    Friend WithEvents Panelinteriorentregadas As System.Windows.Forms.Panel
    Friend WithEvents Btnentregadas As System.Windows.Forms.Button
    Friend WithEvents Lblentregadas As System.Windows.Forms.Label
    Friend WithEvents Paneldeimportacion As System.Windows.Forms.Panel
    Friend WithEvents PanelInfoCte As System.Windows.Forms.Panel
    Friend WithEvents Panelinteriorvisitadas As System.Windows.Forms.Panel
    Friend WithEvents Lblvisitada As System.Windows.Forms.Label
    Friend WithEvents Btnvisitadas As System.Windows.Forms.Button
    Friend WithEvents BtnTermometro As System.Windows.Forms.Button
    Friend WithEvents Panelinteriorimportar As System.Windows.Forms.Panel
    Friend WithEvents Lblimportar As System.Windows.Forms.Label
    Friend WithEvents Btnimportar As System.Windows.Forms.Button
    Friend WithEvents Btnplanificacion As System.Windows.Forms.Button
    Friend WithEvents Btnimpresionplanificacion As System.Windows.Forms.Button
    Friend WithEvents Panelconsulta As System.Windows.Forms.Panel
    Friend WithEvents Panelinternoconsulta As System.Windows.Forms.Panel
    Friend WithEvents Lblconsulta As System.Windows.Forms.Label
    Friend WithEvents Btnconsulta As System.Windows.Forms.Button
    Friend WithEvents PanelinteriorConsultaTR As System.Windows.Forms.Panel
    Friend WithEvents LblConsultaTR As System.Windows.Forms.Label
    Friend WithEvents BtnConsultaTR As System.Windows.Forms.Button
    Friend WithEvents PanelinteriorEscaneo As System.Windows.Forms.Panel
    Friend WithEvents LblEscaneo As System.Windows.Forms.Label
    Friend WithEvents BtnEscaneo As System.Windows.Forms.Button
    Friend WithEvents PanelInformes As System.Windows.Forms.Panel
    Friend WithEvents LblNro As System.Windows.Forms.Label
    Friend WithEvents FrmDevolucion As System.Windows.Forms.Button
    Friend WithEvents FrmPLanillaZonales As System.Windows.Forms.Button
    Friend WithEvents BtnReporteZonales As System.Windows.Forms.Button
    Friend WithEvents BtnConfEntreDevoSucu As System.Windows.Forms.Button
    Friend WithEvents BtnConfirmacionAcuse As System.Windows.Forms.Button
    Friend WithEvents BtnConfiguracion As System.Windows.Forms.Button
    Friend WithEvents PnlConfiguracion As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ChkActivarConfig As System.Windows.Forms.CheckBox
    Friend WithEvents BtnTransoft As System.Windows.Forms.Button
    Friend WithEvents BtnMotivos As System.Windows.Forms.Button
    Friend WithEvents BtnListadoPiezas As System.Windows.Forms.Button

End Class
