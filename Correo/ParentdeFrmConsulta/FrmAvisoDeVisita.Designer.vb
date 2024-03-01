<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAvisoDeVisita
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
        Dim ESTADOLabel As System.Windows.Forms.Label
        Dim LblSeparacion As System.Windows.Forms.Label
        Dim SOCIOLabel As System.Windows.Forms.Label
        Dim F_LIMITELabel As System.Windows.Forms.Label
        Dim NRO_CARTA2Label As System.Windows.Forms.Label
        Dim ARTICULOLabel As System.Windows.Forms.Label
        Dim EMPRESALabel As System.Windows.Forms.Label
        Dim OBSAvisos As System.Windows.Forms.Label
        Dim SERVICIOLabel As System.Windows.Forms.Label
        Dim NRO_CARTALabel As System.Windows.Forms.Label
        Dim FECH_TRABLabel As System.Windows.Forms.Label
        Dim REMITENTELabel As System.Windows.Forms.Label
        Dim TRABAJOLabel As System.Windows.Forms.Label
        Dim NOMBRE_APELLIDOLabel As System.Windows.Forms.Label
        Dim CPLabel As System.Windows.Forms.Label
        Dim LOCALIDADLabel As System.Windows.Forms.Label
        Dim CALLELabel As System.Windows.Forms.Label
        Dim PROVINCIALabel As System.Windows.Forms.Label
        Dim ObsLabel1 As System.Windows.Forms.Label
        Me.BtnAvisoDeVisita = New System.Windows.Forms.Button()
        Me.ESTADOTextBox = New System.Windows.Forms.TextBox()
        Me.F_LIMITETextBox = New System.Windows.Forms.TextBox()
        Me.SOCIOTextBox = New System.Windows.Forms.TextBox()
        Me.ARTICULOTextBox = New System.Windows.Forms.TextBox()
        Me.NRO_CART2TextBox = New System.Windows.Forms.TextBox()
        Me.OBSTextBox = New System.Windows.Forms.TextBox()
        Me.SERVICIOTextBox = New System.Windows.Forms.TextBox()
        Me.EMPRESATextBox = New System.Windows.Forms.TextBox()
        Me.NRO_CARTATextBox = New System.Windows.Forms.TextBox()
        Me.FECH_TRABTextBox = New System.Windows.Forms.TextBox()
        Me.REMITENTETextBox = New System.Windows.Forms.TextBox()
        Me.TRABAJOTextBox = New System.Windows.Forms.TextBox()
        Me.NOMBRE_APELLIDOTextBox = New System.Windows.Forms.TextBox()
        Me.CPTextBox = New System.Windows.Forms.TextBox()
        Me.CALLETextBox = New System.Windows.Forms.TextBox()
        Me.LOCALIDADTextBox = New System.Windows.Forms.TextBox()
        Me.PROVINCIATextBox = New System.Windows.Forms.TextBox()
        Me.DgvAvisos = New System.Windows.Forms.DataGridView()
        ESTADOLabel = New System.Windows.Forms.Label()
        LblSeparacion = New System.Windows.Forms.Label()
        SOCIOLabel = New System.Windows.Forms.Label()
        F_LIMITELabel = New System.Windows.Forms.Label()
        NRO_CARTA2Label = New System.Windows.Forms.Label()
        ARTICULOLabel = New System.Windows.Forms.Label()
        EMPRESALabel = New System.Windows.Forms.Label()
        OBSAvisos = New System.Windows.Forms.Label()
        SERVICIOLabel = New System.Windows.Forms.Label()
        NRO_CARTALabel = New System.Windows.Forms.Label()
        FECH_TRABLabel = New System.Windows.Forms.Label()
        REMITENTELabel = New System.Windows.Forms.Label()
        TRABAJOLabel = New System.Windows.Forms.Label()
        NOMBRE_APELLIDOLabel = New System.Windows.Forms.Label()
        CPLabel = New System.Windows.Forms.Label()
        LOCALIDADLabel = New System.Windows.Forms.Label()
        CALLELabel = New System.Windows.Forms.Label()
        PROVINCIALabel = New System.Windows.Forms.Label()
        ObsLabel1 = New System.Windows.Forms.Label()
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Gb.SuspendLayout()
        CType(Me.DgvAvisos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PBLogo
        '
        Me.PBLogo.Location = New System.Drawing.Point(5, 322)
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(676, 322)
        '
        'Gb
        '
        Me.Gb.Controls.Add(Me.DgvAvisos)
        Me.Gb.Controls.Add(ObsLabel1)
        Me.Gb.Controls.Add(Me.BtnAvisoDeVisita)
        Me.Gb.Controls.Add(ESTADOLabel)
        Me.Gb.Controls.Add(Me.ESTADOTextBox)
        Me.Gb.Controls.Add(Me.F_LIMITETextBox)
        Me.Gb.Controls.Add(LblSeparacion)
        Me.Gb.Controls.Add(SOCIOLabel)
        Me.Gb.Controls.Add(Me.SOCIOTextBox)
        Me.Gb.Controls.Add(F_LIMITELabel)
        Me.Gb.Controls.Add(Me.ARTICULOTextBox)
        Me.Gb.Controls.Add(NRO_CARTA2Label)
        Me.Gb.Controls.Add(ARTICULOLabel)
        Me.Gb.Controls.Add(Me.NRO_CART2TextBox)
        Me.Gb.Controls.Add(EMPRESALabel)
        Me.Gb.Controls.Add(Me.OBSTextBox)
        Me.Gb.Controls.Add(OBSAvisos)
        Me.Gb.Controls.Add(SERVICIOLabel)
        Me.Gb.Controls.Add(Me.SERVICIOTextBox)
        Me.Gb.Controls.Add(Me.EMPRESATextBox)
        Me.Gb.Controls.Add(NRO_CARTALabel)
        Me.Gb.Controls.Add(FECH_TRABLabel)
        Me.Gb.Controls.Add(Me.NRO_CARTATextBox)
        Me.Gb.Controls.Add(Me.FECH_TRABTextBox)
        Me.Gb.Controls.Add(REMITENTELabel)
        Me.Gb.Controls.Add(Me.REMITENTETextBox)
        Me.Gb.Controls.Add(TRABAJOLabel)
        Me.Gb.Controls.Add(Me.TRABAJOTextBox)
        Me.Gb.Controls.Add(NOMBRE_APELLIDOLabel)
        Me.Gb.Controls.Add(Me.NOMBRE_APELLIDOTextBox)
        Me.Gb.Controls.Add(CPLabel)
        Me.Gb.Controls.Add(Me.CPTextBox)
        Me.Gb.Controls.Add(Me.CALLETextBox)
        Me.Gb.Controls.Add(LOCALIDADLabel)
        Me.Gb.Controls.Add(CALLELabel)
        Me.Gb.Controls.Add(PROVINCIALabel)
        Me.Gb.Controls.Add(Me.LOCALIDADTextBox)
        Me.Gb.Controls.Add(Me.PROVINCIATextBox)
        Me.Gb.Size = New System.Drawing.Size(723, 373)
        Me.Gb.Controls.SetChildIndex(Me.PBLogo, 0)
        Me.Gb.Controls.SetChildIndex(Me.BtnSalir, 0)
        Me.Gb.Controls.SetChildIndex(Me.PROVINCIATextBox, 0)
        Me.Gb.Controls.SetChildIndex(Me.LOCALIDADTextBox, 0)
        Me.Gb.Controls.SetChildIndex(PROVINCIALabel, 0)
        Me.Gb.Controls.SetChildIndex(CALLELabel, 0)
        Me.Gb.Controls.SetChildIndex(LOCALIDADLabel, 0)
        Me.Gb.Controls.SetChildIndex(Me.CALLETextBox, 0)
        Me.Gb.Controls.SetChildIndex(Me.CPTextBox, 0)
        Me.Gb.Controls.SetChildIndex(CPLabel, 0)
        Me.Gb.Controls.SetChildIndex(Me.NOMBRE_APELLIDOTextBox, 0)
        Me.Gb.Controls.SetChildIndex(NOMBRE_APELLIDOLabel, 0)
        Me.Gb.Controls.SetChildIndex(Me.TRABAJOTextBox, 0)
        Me.Gb.Controls.SetChildIndex(TRABAJOLabel, 0)
        Me.Gb.Controls.SetChildIndex(Me.REMITENTETextBox, 0)
        Me.Gb.Controls.SetChildIndex(REMITENTELabel, 0)
        Me.Gb.Controls.SetChildIndex(Me.FECH_TRABTextBox, 0)
        Me.Gb.Controls.SetChildIndex(Me.NRO_CARTATextBox, 0)
        Me.Gb.Controls.SetChildIndex(FECH_TRABLabel, 0)
        Me.Gb.Controls.SetChildIndex(NRO_CARTALabel, 0)
        Me.Gb.Controls.SetChildIndex(Me.EMPRESATextBox, 0)
        Me.Gb.Controls.SetChildIndex(Me.SERVICIOTextBox, 0)
        Me.Gb.Controls.SetChildIndex(SERVICIOLabel, 0)
        Me.Gb.Controls.SetChildIndex(OBSAvisos, 0)
        Me.Gb.Controls.SetChildIndex(Me.OBSTextBox, 0)
        Me.Gb.Controls.SetChildIndex(EMPRESALabel, 0)
        Me.Gb.Controls.SetChildIndex(Me.NRO_CART2TextBox, 0)
        Me.Gb.Controls.SetChildIndex(ARTICULOLabel, 0)
        Me.Gb.Controls.SetChildIndex(NRO_CARTA2Label, 0)
        Me.Gb.Controls.SetChildIndex(Me.ARTICULOTextBox, 0)
        Me.Gb.Controls.SetChildIndex(F_LIMITELabel, 0)
        Me.Gb.Controls.SetChildIndex(Me.SOCIOTextBox, 0)
        Me.Gb.Controls.SetChildIndex(SOCIOLabel, 0)
        Me.Gb.Controls.SetChildIndex(LblSeparacion, 0)
        Me.Gb.Controls.SetChildIndex(Me.F_LIMITETextBox, 0)
        Me.Gb.Controls.SetChildIndex(Me.ESTADOTextBox, 0)
        Me.Gb.Controls.SetChildIndex(ESTADOLabel, 0)
        Me.Gb.Controls.SetChildIndex(Me.BtnAvisoDeVisita, 0)
        Me.Gb.Controls.SetChildIndex(ObsLabel1, 0)
        Me.Gb.Controls.SetChildIndex(Me.DgvAvisos, 0)
        '
        'ESTADOLabel
        '
        ESTADOLabel.AutoSize = True
        ESTADOLabel.Enabled = False
        ESTADOLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ESTADOLabel.Location = New System.Drawing.Point(498, 99)
        ESTADOLabel.Name = "ESTADOLabel"
        ESTADOLabel.Size = New System.Drawing.Size(39, 9)
        ESTADOLabel.TabIndex = 308
        ESTADOLabel.Text = "ESTADO:"
        '
        'LblSeparacion
        '
        LblSeparacion.AutoSize = True
        LblSeparacion.Enabled = False
        LblSeparacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LblSeparacion.Location = New System.Drawing.Point(9, 135)
        LblSeparacion.Name = "LblSeparacion"
        LblSeparacion.Size = New System.Drawing.Size(550, 13)
        LblSeparacion.TabIndex = 304
        LblSeparacion.Text = "---------------------------------------------------------------------------------" & _
            "--------------------------------------------------------------------------------" & _
            "--------------------"
        '
        'SOCIOLabel
        '
        SOCIOLabel.AutoSize = True
        SOCIOLabel.Enabled = False
        SOCIOLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SOCIOLabel.Location = New System.Drawing.Point(16, 147)
        SOCIOLabel.Name = "SOCIOLabel"
        SOCIOLabel.Size = New System.Drawing.Size(32, 9)
        SOCIOLabel.TabIndex = 299
        SOCIOLabel.Text = "SOCIO:"
        '
        'F_LIMITELabel
        '
        F_LIMITELabel.AutoSize = True
        F_LIMITELabel.Enabled = False
        F_LIMITELabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        F_LIMITELabel.Location = New System.Drawing.Point(592, 64)
        F_LIMITELabel.Name = "F_LIMITELabel"
        F_LIMITELabel.Size = New System.Drawing.Size(39, 9)
        F_LIMITELabel.TabIndex = 298
        F_LIMITELabel.Text = "F LIMITE:"
        '
        'NRO_CARTA2Label
        '
        NRO_CARTA2Label.AutoSize = True
        NRO_CARTA2Label.Enabled = False
        NRO_CARTA2Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NRO_CARTA2Label.Location = New System.Drawing.Point(438, 29)
        NRO_CARTA2Label.Name = "NRO_CARTA2Label"
        NRO_CARTA2Label.Size = New System.Drawing.Size(53, 9)
        NRO_CARTA2Label.TabIndex = 288
        NRO_CARTA2Label.Text = "NRO CART2:"
        '
        'ARTICULOLabel
        '
        ARTICULOLabel.AutoSize = True
        ARTICULOLabel.Enabled = False
        ARTICULOLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ARTICULOLabel.Location = New System.Drawing.Point(148, 148)
        ARTICULOLabel.Name = "ARTICULOLabel"
        ARTICULOLabel.Size = New System.Drawing.Size(47, 9)
        ARTICULOLabel.TabIndex = 301
        ARTICULOLabel.Text = "ARTICULO:"
        '
        'EMPRESALabel
        '
        EMPRESALabel.AutoSize = True
        EMPRESALabel.Enabled = False
        EMPRESALabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EMPRESALabel.Location = New System.Drawing.Point(266, 99)
        EMPRESALabel.Name = "EMPRESALabel"
        EMPRESALabel.Size = New System.Drawing.Size(45, 9)
        EMPRESALabel.TabIndex = 286
        EMPRESALabel.Text = "EMPRESA:"
        '
        'OBSAvisos
        '
        OBSAvisos.AutoSize = True
        OBSAvisos.Enabled = False
        OBSAvisos.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        OBSAvisos.Location = New System.Drawing.Point(12, 204)
        OBSAvisos.Name = "OBSAvisos"
        OBSAvisos.Size = New System.Drawing.Size(35, 9)
        OBSAvisos.TabIndex = 284
        OBSAvisos.Text = "AVISOS:"
        '
        'SERVICIOLabel
        '
        SERVICIOLabel.AutoSize = True
        SERVICIOLabel.Enabled = False
        SERVICIOLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SERVICIOLabel.Location = New System.Drawing.Point(331, 29)
        SERVICIOLabel.Name = "SERVICIOLabel"
        SERVICIOLabel.Size = New System.Drawing.Size(44, 9)
        SERVICIOLabel.TabIndex = 290
        SERVICIOLabel.Text = "SERVICIO:"
        '
        'NRO_CARTALabel
        '
        NRO_CARTALabel.AutoSize = True
        NRO_CARTALabel.Enabled = False
        NRO_CARTALabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NRO_CARTALabel.Location = New System.Drawing.Point(14, 30)
        NRO_CARTALabel.Name = "NRO_CARTALabel"
        NRO_CARTALabel.Size = New System.Drawing.Size(54, 9)
        NRO_CARTALabel.TabIndex = 266
        NRO_CARTALabel.Text = "NRO CARTA:"
        '
        'FECH_TRABLabel
        '
        FECH_TRABLabel.AutoSize = True
        FECH_TRABLabel.Enabled = False
        FECH_TRABLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FECH_TRABLabel.Location = New System.Drawing.Point(627, 29)
        FECH_TRABLabel.Name = "FECH_TRABLabel"
        FECH_TRABLabel.Size = New System.Drawing.Size(52, 9)
        FECH_TRABLabel.TabIndex = 282
        FECH_TRABLabel.Text = "FECH TRAB:"
        '
        'REMITENTELabel
        '
        REMITENTELabel.AutoSize = True
        REMITENTELabel.Enabled = False
        REMITENTELabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        REMITENTELabel.Location = New System.Drawing.Point(115, 29)
        REMITENTELabel.Name = "REMITENTELabel"
        REMITENTELabel.Size = New System.Drawing.Size(53, 9)
        REMITENTELabel.TabIndex = 268
        REMITENTELabel.Text = "REMITENTE:"
        '
        'TRABAJOLabel
        '
        TRABAJOLabel.AutoSize = True
        TRABAJOLabel.Enabled = False
        TRABAJOLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TRABAJOLabel.Location = New System.Drawing.Point(221, 29)
        TRABAJOLabel.Name = "TRABAJOLabel"
        TRABAJOLabel.Size = New System.Drawing.Size(43, 9)
        TRABAJOLabel.TabIndex = 270
        TRABAJOLabel.Text = "TRABAJO:"
        '
        'NOMBRE_APELLIDOLabel
        '
        NOMBRE_APELLIDOLabel.AutoSize = True
        NOMBRE_APELLIDOLabel.Enabled = False
        NOMBRE_APELLIDOLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NOMBRE_APELLIDOLabel.Location = New System.Drawing.Point(13, 62)
        NOMBRE_APELLIDOLabel.Name = "NOMBRE_APELLIDOLabel"
        NOMBRE_APELLIDOLabel.Size = New System.Drawing.Size(40, 9)
        NOMBRE_APELLIDOLabel.TabIndex = 272
        NOMBRE_APELLIDOLabel.Text = "NOMBRE"
        '
        'CPLabel
        '
        CPLabel.AutoSize = True
        CPLabel.Enabled = False
        CPLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CPLabel.Location = New System.Drawing.Point(522, 62)
        CPLabel.Name = "CPLabel"
        CPLabel.Size = New System.Drawing.Size(18, 9)
        CPLabel.TabIndex = 274
        CPLabel.Text = "CP:"
        '
        'LOCALIDADLabel
        '
        LOCALIDADLabel.AutoSize = True
        LOCALIDADLabel.Enabled = False
        LOCALIDADLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LOCALIDADLabel.Location = New System.Drawing.Point(13, 99)
        LOCALIDADLabel.Name = "LOCALIDADLabel"
        LOCALIDADLabel.Size = New System.Drawing.Size(51, 9)
        LOCALIDADLabel.TabIndex = 278
        LOCALIDADLabel.Text = "LOCALIDAD:"
        '
        'CALLELabel
        '
        CALLELabel.AutoSize = True
        CALLELabel.Enabled = False
        CALLELabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CALLELabel.Location = New System.Drawing.Point(265, 64)
        CALLELabel.Name = "CALLELabel"
        CALLELabel.Size = New System.Drawing.Size(31, 9)
        CALLELabel.TabIndex = 276
        CALLELabel.Text = "CALLE:"
        '
        'PROVINCIALabel
        '
        PROVINCIALabel.AutoSize = True
        PROVINCIALabel.Enabled = False
        PROVINCIALabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PROVINCIALabel.Location = New System.Drawing.Point(153, 98)
        PROVINCIALabel.Name = "PROVINCIALabel"
        PROVINCIALabel.Size = New System.Drawing.Size(50, 9)
        PROVINCIALabel.TabIndex = 280
        PROVINCIALabel.Text = "PROVINCIA:"
        '
        'ObsLabel1
        '
        ObsLabel1.AutoSize = True
        ObsLabel1.Enabled = False
        ObsLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ObsLabel1.Location = New System.Drawing.Point(257, 147)
        ObsLabel1.Name = "ObsLabel1"
        ObsLabel1.Size = New System.Drawing.Size(23, 9)
        ObsLabel1.TabIndex = 311
        ObsLabel1.Text = "OBS:"
        '
        'BtnAvisoDeVisita
        '
        Me.BtnAvisoDeVisita.Location = New System.Drawing.Point(593, 160)
        Me.BtnAvisoDeVisita.Name = "BtnAvisoDeVisita"
        Me.BtnAvisoDeVisita.Size = New System.Drawing.Size(115, 23)
        Me.BtnAvisoDeVisita.TabIndex = 310
        Me.BtnAvisoDeVisita.Text = "Confirmar de Visita"
        Me.BtnAvisoDeVisita.UseVisualStyleBackColor = True
        '
        'ESTADOTextBox
        '
        Me.ESTADOTextBox.Enabled = False
        Me.ESTADOTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ESTADOTextBox.Location = New System.Drawing.Point(497, 112)
        Me.ESTADOTextBox.Name = "ESTADOTextBox"
        Me.ESTADOTextBox.Size = New System.Drawing.Size(211, 18)
        Me.ESTADOTextBox.TabIndex = 309
        '
        'F_LIMITETextBox
        '
        Me.F_LIMITETextBox.Enabled = False
        Me.F_LIMITETextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.F_LIMITETextBox.Location = New System.Drawing.Point(595, 76)
        Me.F_LIMITETextBox.Name = "F_LIMITETextBox"
        Me.F_LIMITETextBox.Size = New System.Drawing.Size(114, 18)
        Me.F_LIMITETextBox.TabIndex = 303
        '
        'SOCIOTextBox
        '
        Me.SOCIOTextBox.Enabled = False
        Me.SOCIOTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SOCIOTextBox.Location = New System.Drawing.Point(12, 160)
        Me.SOCIOTextBox.Name = "SOCIOTextBox"
        Me.SOCIOTextBox.Size = New System.Drawing.Size(116, 18)
        Me.SOCIOTextBox.TabIndex = 300
        '
        'ARTICULOTextBox
        '
        Me.ARTICULOTextBox.Enabled = False
        Me.ARTICULOTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ARTICULOTextBox.Location = New System.Drawing.Point(146, 160)
        Me.ARTICULOTextBox.Name = "ARTICULOTextBox"
        Me.ARTICULOTextBox.Size = New System.Drawing.Size(107, 18)
        Me.ARTICULOTextBox.TabIndex = 302
        '
        'NRO_CART2TextBox
        '
        Me.NRO_CART2TextBox.Enabled = False
        Me.NRO_CART2TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NRO_CART2TextBox.Location = New System.Drawing.Point(437, 42)
        Me.NRO_CART2TextBox.Name = "NRO_CART2TextBox"
        Me.NRO_CART2TextBox.Size = New System.Drawing.Size(180, 18)
        Me.NRO_CART2TextBox.TabIndex = 289
        '
        'OBSTextBox
        '
        Me.OBSTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OBSTextBox.Location = New System.Drawing.Point(259, 160)
        Me.OBSTextBox.Name = "OBSTextBox"
        Me.OBSTextBox.Size = New System.Drawing.Size(240, 18)
        Me.OBSTextBox.TabIndex = 285
        '
        'SERVICIOTextBox
        '
        Me.SERVICIOTextBox.Enabled = False
        Me.SERVICIOTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SERVICIOTextBox.Location = New System.Drawing.Point(330, 42)
        Me.SERVICIOTextBox.Name = "SERVICIOTextBox"
        Me.SERVICIOTextBox.Size = New System.Drawing.Size(100, 18)
        Me.SERVICIOTextBox.TabIndex = 291
        '
        'EMPRESATextBox
        '
        Me.EMPRESATextBox.Enabled = False
        Me.EMPRESATextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EMPRESATextBox.Location = New System.Drawing.Point(265, 112)
        Me.EMPRESATextBox.Name = "EMPRESATextBox"
        Me.EMPRESATextBox.Size = New System.Drawing.Size(226, 18)
        Me.EMPRESATextBox.TabIndex = 287
        '
        'NRO_CARTATextBox
        '
        Me.NRO_CARTATextBox.Enabled = False
        Me.NRO_CARTATextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NRO_CARTATextBox.Location = New System.Drawing.Point(12, 42)
        Me.NRO_CARTATextBox.Name = "NRO_CARTATextBox"
        Me.NRO_CARTATextBox.Size = New System.Drawing.Size(100, 18)
        Me.NRO_CARTATextBox.TabIndex = 267
        '
        'FECH_TRABTextBox
        '
        Me.FECH_TRABTextBox.Enabled = False
        Me.FECH_TRABTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FECH_TRABTextBox.Location = New System.Drawing.Point(629, 42)
        Me.FECH_TRABTextBox.Name = "FECH_TRABTextBox"
        Me.FECH_TRABTextBox.Size = New System.Drawing.Size(80, 18)
        Me.FECH_TRABTextBox.TabIndex = 283
        '
        'REMITENTETextBox
        '
        Me.REMITENTETextBox.Enabled = False
        Me.REMITENTETextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REMITENTETextBox.Location = New System.Drawing.Point(118, 42)
        Me.REMITENTETextBox.Name = "REMITENTETextBox"
        Me.REMITENTETextBox.Size = New System.Drawing.Size(100, 18)
        Me.REMITENTETextBox.TabIndex = 269
        '
        'TRABAJOTextBox
        '
        Me.TRABAJOTextBox.Enabled = False
        Me.TRABAJOTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TRABAJOTextBox.Location = New System.Drawing.Point(224, 42)
        Me.TRABAJOTextBox.Name = "TRABAJOTextBox"
        Me.TRABAJOTextBox.Size = New System.Drawing.Size(100, 18)
        Me.TRABAJOTextBox.TabIndex = 271
        '
        'NOMBRE_APELLIDOTextBox
        '
        Me.NOMBRE_APELLIDOTextBox.Enabled = False
        Me.NOMBRE_APELLIDOTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NOMBRE_APELLIDOTextBox.Location = New System.Drawing.Point(12, 76)
        Me.NOMBRE_APELLIDOTextBox.Name = "NOMBRE_APELLIDOTextBox"
        Me.NOMBRE_APELLIDOTextBox.Size = New System.Drawing.Size(250, 18)
        Me.NOMBRE_APELLIDOTextBox.TabIndex = 273
        '
        'CPTextBox
        '
        Me.CPTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CPTextBox.Location = New System.Drawing.Point(521, 76)
        Me.CPTextBox.Name = "CPTextBox"
        Me.CPTextBox.Size = New System.Drawing.Size(65, 18)
        Me.CPTextBox.TabIndex = 275
        '
        'CALLETextBox
        '
        Me.CALLETextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CALLETextBox.Location = New System.Drawing.Point(265, 76)
        Me.CALLETextBox.Name = "CALLETextBox"
        Me.CALLETextBox.Size = New System.Drawing.Size(250, 18)
        Me.CALLETextBox.TabIndex = 277
        '
        'LOCALIDADTextBox
        '
        Me.LOCALIDADTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LOCALIDADTextBox.Location = New System.Drawing.Point(12, 112)
        Me.LOCALIDADTextBox.Name = "LOCALIDADTextBox"
        Me.LOCALIDADTextBox.Size = New System.Drawing.Size(116, 18)
        Me.LOCALIDADTextBox.TabIndex = 279
        '
        'PROVINCIATextBox
        '
        Me.PROVINCIATextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PROVINCIATextBox.Location = New System.Drawing.Point(146, 112)
        Me.PROVINCIATextBox.Name = "PROVINCIATextBox"
        Me.PROVINCIATextBox.Size = New System.Drawing.Size(116, 18)
        Me.PROVINCIATextBox.TabIndex = 281
        '
        'DgvAvisos
        '
        Me.DgvAvisos.AllowUserToAddRows = False
        Me.DgvAvisos.AllowUserToDeleteRows = False
        Me.DgvAvisos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvAvisos.Location = New System.Drawing.Point(12, 216)
        Me.DgvAvisos.Name = "DgvAvisos"
        Me.DgvAvisos.ReadOnly = True
        Me.DgvAvisos.Size = New System.Drawing.Size(646, 100)
        Me.DgvAvisos.TabIndex = 258
        '
        'FrmAvisoDeVisita
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(723, 372)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmAvisoDeVisita"
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Gb.ResumeLayout(False)
        Me.Gb.PerformLayout()
        CType(Me.DgvAvisos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnAvisoDeVisita As System.Windows.Forms.Button
    Friend WithEvents ESTADOTextBox As System.Windows.Forms.TextBox
    Friend WithEvents F_LIMITETextBox As System.Windows.Forms.TextBox
    Friend WithEvents SOCIOTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ARTICULOTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NRO_CART2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents OBSTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SERVICIOTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EMPRESATextBox As System.Windows.Forms.TextBox
    Friend WithEvents NRO_CARTATextBox As System.Windows.Forms.TextBox
    Friend WithEvents FECH_TRABTextBox As System.Windows.Forms.TextBox
    Friend WithEvents REMITENTETextBox As System.Windows.Forms.TextBox
    Friend WithEvents TRABAJOTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NOMBRE_APELLIDOTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CPTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CALLETextBox As System.Windows.Forms.TextBox
    Friend WithEvents LOCALIDADTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PROVINCIATextBox As System.Windows.Forms.TextBox
    Friend WithEvents DgvAvisos As System.Windows.Forms.DataGridView

End Class
