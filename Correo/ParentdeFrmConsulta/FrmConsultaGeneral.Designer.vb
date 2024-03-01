<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConsultaGeneral
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
        Dim NRO_CARTA2Label As System.Windows.Forms.Label
        Dim OBSLabel As System.Windows.Forms.Label
        Dim EMPRESALabel As System.Windows.Forms.Label
        Dim OBS3Label As System.Windows.Forms.Label
        Dim OBS4Label As System.Windows.Forms.Label
        Dim OBS2Label As System.Windows.Forms.Label
        Dim NRO_CARTALabel As System.Windows.Forms.Label
        Dim NOMBRE_APELLIDOLabel As System.Windows.Forms.Label
        Dim CALLELabel As System.Windows.Forms.Label
        Dim CPLabel As System.Windows.Forms.Label
        Dim FECH_TRABLabel As System.Windows.Forms.Label
        Me.NRO_CARTA2TextBox = New System.Windows.Forms.TextBox()
        Me.OBSTextBox = New System.Windows.Forms.TextBox()
        Me.EMPRESATextBox = New System.Windows.Forms.TextBox()
        Me.OBS3TextBox = New System.Windows.Forms.TextBox()
        Me.OBS2TextBox = New System.Windows.Forms.TextBox()
        Me.OBS4TextBox = New System.Windows.Forms.TextBox()
        Me.NRO_CARTATextdesdeBoxDESDE = New System.Windows.Forms.TextBox()
        Me.NOMBRE_APELLIDOTextBox = New System.Windows.Forms.TextBox()
        Me.CALLETextBox = New System.Windows.Forms.TextBox()
        Me.NRO_CARTATextdesdeBoxHASTA = New System.Windows.Forms.TextBox()
        Me.CPTextBoxHASTA = New System.Windows.Forms.TextBox()
        Me.CPTextBoxDESDE = New System.Windows.Forms.TextBox()
        Me.MKFECH_TRABHASTA = New System.Windows.Forms.MaskedTextBox()
        Me.MKFECH_TRABDESDE = New System.Windows.Forms.MaskedTextBox()
        Me.GpbUnitario = New System.Windows.Forms.GroupBox()
        Me.LblCuenta = New System.Windows.Forms.Label()
        Me.Dgvdatos = New System.Windows.Forms.DataGridView()
        Me.Gpbcontroles = New System.Windows.Forms.GroupBox()
        Me.BtnBuscarRecorridos = New System.Windows.Forms.Button()
        Me.BtnCsv = New System.Windows.Forms.Button()
        Me.Btnsalir = New System.Windows.Forms.Button()
        Me.Btnxls = New System.Windows.Forms.Button()
        Me.BtnConsulta = New System.Windows.Forms.Button()
        Me.Pgbavance = New System.Windows.Forms.ProgressBar()
        NRO_CARTA2Label = New System.Windows.Forms.Label()
        OBSLabel = New System.Windows.Forms.Label()
        EMPRESALabel = New System.Windows.Forms.Label()
        OBS3Label = New System.Windows.Forms.Label()
        OBS4Label = New System.Windows.Forms.Label()
        OBS2Label = New System.Windows.Forms.Label()
        NRO_CARTALabel = New System.Windows.Forms.Label()
        NOMBRE_APELLIDOLabel = New System.Windows.Forms.Label()
        CALLELabel = New System.Windows.Forms.Label()
        CPLabel = New System.Windows.Forms.Label()
        FECH_TRABLabel = New System.Windows.Forms.Label()
        Me.GpbUnitario.SuspendLayout()
        CType(Me.Dgvdatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Gpbcontroles.SuspendLayout()
        Me.SuspendLayout()
        '
        'NRO_CARTA2Label
        '
        NRO_CARTA2Label.AutoSize = True
        NRO_CARTA2Label.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NRO_CARTA2Label.Location = New System.Drawing.Point(11, 173)
        NRO_CARTA2Label.Name = "NRO_CARTA2Label"
        NRO_CARTA2Label.Size = New System.Drawing.Size(102, 18)
        NRO_CARTA2Label.TabIndex = 231
        NRO_CARTA2Label.Text = "BARRA CTE:"
        '
        'OBSLabel
        '
        OBSLabel.AutoSize = True
        OBSLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        OBSLabel.Location = New System.Drawing.Point(384, 68)
        OBSLabel.Name = "OBSLabel"
        OBSLabel.Size = New System.Drawing.Size(46, 18)
        OBSLabel.TabIndex = 227
        OBSLabel.Text = "OBS:"
        '
        'EMPRESALabel
        '
        EMPRESALabel.AutoSize = True
        EMPRESALabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EMPRESALabel.Location = New System.Drawing.Point(11, 106)
        EMPRESALabel.Name = "EMPRESALabel"
        EMPRESALabel.Size = New System.Drawing.Size(91, 18)
        EMPRESALabel.TabIndex = 229
        EMPRESALabel.Text = "EMPRESA:"
        '
        'OBS3Label
        '
        OBS3Label.AutoSize = True
        OBS3Label.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        OBS3Label.Location = New System.Drawing.Point(383, 102)
        OBS3Label.Name = "OBS3Label"
        OBS3Label.Size = New System.Drawing.Size(55, 18)
        OBS3Label.TabIndex = 237
        OBS3Label.Text = "OBS3:"
        '
        'OBS4Label
        '
        OBS4Label.AutoSize = True
        OBS4Label.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        OBS4Label.Location = New System.Drawing.Point(384, 135)
        OBS4Label.Name = "OBS4Label"
        OBS4Label.Size = New System.Drawing.Size(55, 18)
        OBS4Label.TabIndex = 239
        OBS4Label.Text = "OBS4:"
        '
        'OBS2Label
        '
        OBS2Label.AutoSize = True
        OBS2Label.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        OBS2Label.Location = New System.Drawing.Point(383, 165)
        OBS2Label.Name = "OBS2Label"
        OBS2Label.Size = New System.Drawing.Size(55, 18)
        OBS2Label.TabIndex = 235
        OBS2Label.Text = "OBS2:"
        '
        'NRO_CARTALabel
        '
        NRO_CARTALabel.AutoSize = True
        NRO_CARTALabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NRO_CARTALabel.Location = New System.Drawing.Point(10, 24)
        NRO_CARTALabel.Name = "NRO_CARTALabel"
        NRO_CARTALabel.Size = New System.Drawing.Size(103, 18)
        NRO_CARTALabel.TabIndex = 193
        NRO_CARTALabel.Text = "NRO CARTA:"
        '
        'NOMBRE_APELLIDOLabel
        '
        NOMBRE_APELLIDOLabel.AutoSize = True
        NOMBRE_APELLIDOLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NOMBRE_APELLIDOLabel.Location = New System.Drawing.Point(11, 140)
        NOMBRE_APELLIDOLabel.Name = "NOMBRE_APELLIDOLabel"
        NOMBRE_APELLIDOLabel.Size = New System.Drawing.Size(77, 18)
        NOMBRE_APELLIDOLabel.TabIndex = 199
        NOMBRE_APELLIDOLabel.Text = "NOMBRE"
        '
        'CALLELabel
        '
        CALLELabel.AutoSize = True
        CALLELabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CALLELabel.Location = New System.Drawing.Point(11, 68)
        CALLELabel.Name = "CALLELabel"
        CALLELabel.Size = New System.Drawing.Size(64, 18)
        CALLELabel.TabIndex = 203
        CALLELabel.Text = "CALLE:"
        '
        'CPLabel
        '
        CPLabel.AutoSize = True
        CPLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CPLabel.Location = New System.Drawing.Point(384, 29)
        CPLabel.Name = "CPLabel"
        CPLabel.Size = New System.Drawing.Size(35, 18)
        CPLabel.TabIndex = 272
        CPLabel.Text = "CP:"
        '
        'FECH_TRABLabel
        '
        FECH_TRABLabel.AutoSize = True
        FECH_TRABLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FECH_TRABLabel.Location = New System.Drawing.Point(11, 207)
        FECH_TRABLabel.Name = "FECH_TRABLabel"
        FECH_TRABLabel.Size = New System.Drawing.Size(102, 18)
        FECH_TRABLabel.TabIndex = 215
        FECH_TRABLabel.Text = "FECH TRAB:"
        '
        'NRO_CARTA2TextBox
        '
        Me.NRO_CARTA2TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NRO_CARTA2TextBox.Location = New System.Drawing.Point(119, 165)
        Me.NRO_CARTA2TextBox.Name = "NRO_CARTA2TextBox"
        Me.NRO_CARTA2TextBox.Size = New System.Drawing.Size(229, 26)
        Me.NRO_CARTA2TextBox.TabIndex = 4
        '
        'OBSTextBox
        '
        Me.OBSTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OBSTextBox.Location = New System.Drawing.Point(546, 62)
        Me.OBSTextBox.Name = "OBSTextBox"
        Me.OBSTextBox.Size = New System.Drawing.Size(258, 26)
        Me.OBSTextBox.TabIndex = 7
        '
        'EMPRESATextBox
        '
        Me.EMPRESATextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EMPRESATextBox.Location = New System.Drawing.Point(119, 98)
        Me.EMPRESATextBox.Name = "EMPRESATextBox"
        Me.EMPRESATextBox.Size = New System.Drawing.Size(229, 26)
        Me.EMPRESATextBox.TabIndex = 3
        '
        'OBS3TextBox
        '
        Me.OBS3TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OBS3TextBox.Location = New System.Drawing.Point(546, 94)
        Me.OBS3TextBox.Name = "OBS3TextBox"
        Me.OBS3TextBox.Size = New System.Drawing.Size(258, 26)
        Me.OBS3TextBox.TabIndex = 9
        '
        'OBS2TextBox
        '
        Me.OBS2TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OBS2TextBox.Location = New System.Drawing.Point(546, 157)
        Me.OBS2TextBox.Name = "OBS2TextBox"
        Me.OBS2TextBox.Size = New System.Drawing.Size(258, 26)
        Me.OBS2TextBox.TabIndex = 8
        '
        'OBS4TextBox
        '
        Me.OBS4TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OBS4TextBox.Location = New System.Drawing.Point(546, 125)
        Me.OBS4TextBox.Name = "OBS4TextBox"
        Me.OBS4TextBox.Size = New System.Drawing.Size(258, 26)
        Me.OBS4TextBox.TabIndex = 10
        '
        'NRO_CARTATextdesdeBoxDESDE
        '
        Me.NRO_CARTATextdesdeBoxDESDE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NRO_CARTATextdesdeBoxDESDE.Location = New System.Drawing.Point(119, 16)
        Me.NRO_CARTATextdesdeBoxDESDE.Name = "NRO_CARTATextdesdeBoxDESDE"
        Me.NRO_CARTATextdesdeBoxDESDE.Size = New System.Drawing.Size(110, 26)
        Me.NRO_CARTATextdesdeBoxDESDE.TabIndex = 0
        '
        'NOMBRE_APELLIDOTextBox
        '
        Me.NOMBRE_APELLIDOTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NOMBRE_APELLIDOTextBox.Location = New System.Drawing.Point(118, 132)
        Me.NOMBRE_APELLIDOTextBox.Name = "NOMBRE_APELLIDOTextBox"
        Me.NOMBRE_APELLIDOTextBox.Size = New System.Drawing.Size(229, 26)
        Me.NOMBRE_APELLIDOTextBox.TabIndex = 6
        '
        'CALLETextBox
        '
        Me.CALLETextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CALLETextBox.Location = New System.Drawing.Point(119, 64)
        Me.CALLETextBox.Name = "CALLETextBox"
        Me.CALLETextBox.Size = New System.Drawing.Size(229, 26)
        Me.CALLETextBox.TabIndex = 2
        '
        'NRO_CARTATextdesdeBoxHASTA
        '
        Me.NRO_CARTATextdesdeBoxHASTA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NRO_CARTATextdesdeBoxHASTA.Location = New System.Drawing.Point(246, 16)
        Me.NRO_CARTATextdesdeBoxHASTA.Name = "NRO_CARTATextdesdeBoxHASTA"
        Me.NRO_CARTATextdesdeBoxHASTA.Size = New System.Drawing.Size(101, 26)
        Me.NRO_CARTATextdesdeBoxHASTA.TabIndex = 1
        '
        'CPTextBoxHASTA
        '
        Me.CPTextBoxHASTA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CPTextBoxHASTA.Location = New System.Drawing.Point(694, 21)
        Me.CPTextBoxHASTA.Name = "CPTextBoxHASTA"
        Me.CPTextBoxHASTA.Size = New System.Drawing.Size(111, 26)
        Me.CPTextBoxHASTA.TabIndex = 14
        '
        'CPTextBoxDESDE
        '
        Me.CPTextBoxDESDE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CPTextBoxDESDE.Location = New System.Drawing.Point(547, 20)
        Me.CPTextBoxDESDE.Name = "CPTextBoxDESDE"
        Me.CPTextBoxDESDE.Size = New System.Drawing.Size(115, 26)
        Me.CPTextBoxDESDE.TabIndex = 13
        '
        'MKFECH_TRABHASTA
        '
        Me.MKFECH_TRABHASTA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MKFECH_TRABHASTA.Location = New System.Drawing.Point(246, 199)
        Me.MKFECH_TRABHASTA.Mask = "00/00/0000"
        Me.MKFECH_TRABHASTA.Name = "MKFECH_TRABHASTA"
        Me.MKFECH_TRABHASTA.Size = New System.Drawing.Size(101, 26)
        Me.MKFECH_TRABHASTA.TabIndex = 12
        Me.MKFECH_TRABHASTA.ValidatingType = GetType(Date)
        '
        'MKFECH_TRABDESDE
        '
        Me.MKFECH_TRABDESDE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MKFECH_TRABDESDE.Location = New System.Drawing.Point(119, 199)
        Me.MKFECH_TRABDESDE.Mask = "00/00/0000"
        Me.MKFECH_TRABDESDE.Name = "MKFECH_TRABDESDE"
        Me.MKFECH_TRABDESDE.Size = New System.Drawing.Size(110, 26)
        Me.MKFECH_TRABDESDE.TabIndex = 11
        Me.MKFECH_TRABDESDE.ValidatingType = GetType(Date)
        '
        'GpbUnitario
        '
        Me.GpbUnitario.BackColor = System.Drawing.Color.SteelBlue
        Me.GpbUnitario.Controls.Add(Me.LblCuenta)
        Me.GpbUnitario.Controls.Add(CPLabel)
        Me.GpbUnitario.Controls.Add(NOMBRE_APELLIDOLabel)
        Me.GpbUnitario.Controls.Add(CALLELabel)
        Me.GpbUnitario.Controls.Add(Me.NRO_CARTATextdesdeBoxHASTA)
        Me.GpbUnitario.Controls.Add(Me.CALLETextBox)
        Me.GpbUnitario.Controls.Add(Me.MKFECH_TRABHASTA)
        Me.GpbUnitario.Controls.Add(Me.CPTextBoxHASTA)
        Me.GpbUnitario.Controls.Add(Me.MKFECH_TRABDESDE)
        Me.GpbUnitario.Controls.Add(FECH_TRABLabel)
        Me.GpbUnitario.Controls.Add(Me.NOMBRE_APELLIDOTextBox)
        Me.GpbUnitario.Controls.Add(OBS2Label)
        Me.GpbUnitario.Controls.Add(Me.CPTextBoxDESDE)
        Me.GpbUnitario.Controls.Add(NRO_CARTA2Label)
        Me.GpbUnitario.Controls.Add(Me.OBS4TextBox)
        Me.GpbUnitario.Controls.Add(Me.NRO_CARTA2TextBox)
        Me.GpbUnitario.Controls.Add(OBS4Label)
        Me.GpbUnitario.Controls.Add(Me.OBSTextBox)
        Me.GpbUnitario.Controls.Add(NRO_CARTALabel)
        Me.GpbUnitario.Controls.Add(OBS3Label)
        Me.GpbUnitario.Controls.Add(Me.NRO_CARTATextdesdeBoxDESDE)
        Me.GpbUnitario.Controls.Add(OBSLabel)
        Me.GpbUnitario.Controls.Add(Me.OBS2TextBox)
        Me.GpbUnitario.Controls.Add(EMPRESALabel)
        Me.GpbUnitario.Controls.Add(Me.OBS3TextBox)
        Me.GpbUnitario.Controls.Add(Me.EMPRESATextBox)
        Me.GpbUnitario.Location = New System.Drawing.Point(12, 3)
        Me.GpbUnitario.Name = "GpbUnitario"
        Me.GpbUnitario.Size = New System.Drawing.Size(845, 247)
        Me.GpbUnitario.TabIndex = 0
        Me.GpbUnitario.TabStop = False
        '
        'LblCuenta
        '
        Me.LblCuenta.AutoSize = True
        Me.LblCuenta.Location = New System.Drawing.Point(544, 212)
        Me.LblCuenta.Name = "LblCuenta"
        Me.LblCuenta.Size = New System.Drawing.Size(13, 13)
        Me.LblCuenta.TabIndex = 281
        Me.LblCuenta.Text = "0"
        '
        'Dgvdatos
        '
        Me.Dgvdatos.AllowUserToAddRows = False
        Me.Dgvdatos.AllowUserToDeleteRows = False
        Me.Dgvdatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgvdatos.Location = New System.Drawing.Point(12, 256)
        Me.Dgvdatos.Name = "Dgvdatos"
        Me.Dgvdatos.ReadOnly = True
        Me.Dgvdatos.Size = New System.Drawing.Size(845, 213)
        Me.Dgvdatos.TabIndex = 279
        '
        'Gpbcontroles
        '
        Me.Gpbcontroles.Controls.Add(Me.BtnBuscarRecorridos)
        Me.Gpbcontroles.Controls.Add(Me.BtnCsv)
        Me.Gpbcontroles.Controls.Add(Me.Btnsalir)
        Me.Gpbcontroles.Controls.Add(Me.Btnxls)
        Me.Gpbcontroles.Controls.Add(Me.BtnConsulta)
        Me.Gpbcontroles.Location = New System.Drawing.Point(12, 491)
        Me.Gpbcontroles.Name = "Gpbcontroles"
        Me.Gpbcontroles.Size = New System.Drawing.Size(845, 78)
        Me.Gpbcontroles.TabIndex = 280
        Me.Gpbcontroles.TabStop = False
        '
        'BtnBuscarRecorridos
        '
        Me.BtnBuscarRecorridos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnBuscarRecorridos.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnBuscarRecorridos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnBuscarRecorridos.Image = Global.Correo.My.Resources.Resources.email_to_friend
        Me.BtnBuscarRecorridos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBuscarRecorridos.Location = New System.Drawing.Point(480, 27)
        Me.BtnBuscarRecorridos.Name = "BtnBuscarRecorridos"
        Me.BtnBuscarRecorridos.Size = New System.Drawing.Size(126, 36)
        Me.BtnBuscarRecorridos.TabIndex = 25
        Me.BtnBuscarRecorridos.Text = "Añadir Carteros?"
        Me.BtnBuscarRecorridos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnBuscarRecorridos.UseVisualStyleBackColor = True
        '
        'BtnCsv
        '
        Me.BtnCsv.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCsv.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnCsv.Enabled = False
        Me.BtnCsv.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnCsv.Image = Global.Correo.My.Resources.Resources.storage
        Me.BtnCsv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCsv.Location = New System.Drawing.Point(319, 27)
        Me.BtnCsv.Name = "BtnCsv"
        Me.BtnCsv.Size = New System.Drawing.Size(94, 36)
        Me.BtnCsv.TabIndex = 24
        Me.BtnCsv.Text = "Csv"
        Me.BtnCsv.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCsv.UseVisualStyleBackColor = True
        '
        'Btnsalir
        '
        Me.Btnsalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btnsalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btnsalir.Image = Global.Correo.My.Resources.Resources.door_out
        Me.Btnsalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btnsalir.Location = New System.Drawing.Point(741, 27)
        Me.Btnsalir.Name = "Btnsalir"
        Me.Btnsalir.Size = New System.Drawing.Size(94, 36)
        Me.Btnsalir.TabIndex = 23
        Me.Btnsalir.Text = "Salir"
        Me.Btnsalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btnsalir.UseVisualStyleBackColor = True
        '
        'Btnxls
        '
        Me.Btnxls.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btnxls.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Btnxls.Enabled = False
        Me.Btnxls.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btnxls.Image = Global.Correo.My.Resources.Resources.table_excel
        Me.Btnxls.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btnxls.Location = New System.Drawing.Point(219, 27)
        Me.Btnxls.Name = "Btnxls"
        Me.Btnxls.Size = New System.Drawing.Size(94, 36)
        Me.Btnxls.TabIndex = 22
        Me.Btnxls.Text = "Excel"
        Me.Btnxls.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btnxls.UseVisualStyleBackColor = True
        '
        'BtnConsulta
        '
        Me.BtnConsulta.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnConsulta.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnConsulta.Image = Global.Correo.My.Resources.Resources.agt_action_success2
        Me.BtnConsulta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnConsulta.Location = New System.Drawing.Point(11, 27)
        Me.BtnConsulta.Name = "BtnConsulta"
        Me.BtnConsulta.Size = New System.Drawing.Size(94, 36)
        Me.BtnConsulta.TabIndex = 21
        Me.BtnConsulta.Text = "Consultar"
        Me.BtnConsulta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnConsulta.UseVisualStyleBackColor = True
        '
        'Pgbavance
        '
        Me.Pgbavance.Location = New System.Drawing.Point(12, 475)
        Me.Pgbavance.Name = "Pgbavance"
        Me.Pgbavance.Size = New System.Drawing.Size(845, 10)
        Me.Pgbavance.TabIndex = 282
        '
        'FrmConsultaGeneral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(878, 578)
        Me.Controls.Add(Me.Pgbavance)
        Me.Controls.Add(Me.Gpbcontroles)
        Me.Controls.Add(Me.Dgvdatos)
        Me.Controls.Add(Me.GpbUnitario)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmConsultaGeneral"
        Me.GpbUnitario.ResumeLayout(False)
        Me.GpbUnitario.PerformLayout()
        CType(Me.Dgvdatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Gpbcontroles.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents NRO_CARTA2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents OBSTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EMPRESATextBox As System.Windows.Forms.TextBox
    Friend WithEvents OBS3TextBox As System.Windows.Forms.TextBox
    Friend WithEvents OBS2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents OBS4TextBox As System.Windows.Forms.TextBox
    Friend WithEvents NRO_CARTATextdesdeBoxDESDE As System.Windows.Forms.TextBox
    Friend WithEvents NOMBRE_APELLIDOTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CALLETextBox As System.Windows.Forms.TextBox
    Friend WithEvents NRO_CARTATextdesdeBoxHASTA As System.Windows.Forms.TextBox
    Friend WithEvents CPTextBoxHASTA As System.Windows.Forms.TextBox
    Friend WithEvents CPTextBoxDESDE As System.Windows.Forms.TextBox
    Friend WithEvents GpbUnitario As System.Windows.Forms.GroupBox
    Friend WithEvents Dgvdatos As System.Windows.Forms.DataGridView
    Friend WithEvents MKFECH_TRABHASTA As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MKFECH_TRABDESDE As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Gpbcontroles As System.Windows.Forms.GroupBox
    Public WithEvents BtnConsulta As System.Windows.Forms.Button
    Public WithEvents Btnsalir As System.Windows.Forms.Button
    Public WithEvents Btnxls As System.Windows.Forms.Button
    Friend WithEvents LblCuenta As System.Windows.Forms.Label
    Public WithEvents BtnCsv As System.Windows.Forms.Button
    Public WithEvents BtnBuscarRecorridos As System.Windows.Forms.Button
    Friend WithEvents Pgbavance As System.Windows.Forms.ProgressBar
End Class
