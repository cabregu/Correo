<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmrdlc
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
    '<System.Diagnostics.DebuggerStepThrough()> _
    'Private Sub InitializeComponent()
    '    Me.Panel1 = New System.Windows.Forms.Panel
    '    Me.rpv = New Microsoft.Reporting.WinForms.ReportViewer
    '    Me.Panel1.SuspendLayout()
    '    Me.SuspendLayout()
    '    '
    '    'Panel1
    '    '
    '    Me.Panel1.Controls.Add(Me.rpv)
    '    Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
    '    Me.Panel1.Location = New System.Drawing.Point(0, 0)
    '    Me.Panel1.Name = "Panel1"
    '    Me.Panel1.Size = New System.Drawing.Size(785, 397)
    '    Me.Panel1.TabIndex = 0
    '    '
    '    'rpv
    '    '
    '    Me.rpv.Dock = System.Windows.Forms.DockStyle.Fill
    '    Me.rpv.Location = New System.Drawing.Point(0, 0)
    '    Me.rpv.Name = "rpv"
    '    Me.rpv.ShowBackButton = False
    '    Me.rpv.ShowContextMenu = False
    '    Me.rpv.ShowCredentialPrompts = False
    '    Me.rpv.ShowDocumentMapButton = False
    '    Me.rpv.ShowExportButton = False
    '    Me.rpv.ShowFindControls = False
    '    Me.rpv.ShowPageNavigationControls = False
    '    Me.rpv.ShowParameterPrompts = False
    '    Me.rpv.ShowProgress = False
    '    Me.rpv.ShowPromptAreaButton = False
    '    Me.rpv.ShowRefreshButton = False
    '    Me.rpv.ShowStopButton = False
    '    Me.rpv.ShowZoomControl = False
    '    Me.rpv.Size = New System.Drawing.Size(785, 397)
    '    Me.rpv.TabIndex = 0
    '    '
    '    'FrmEtiquetas
    '    '
    '    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 15.0!)
    '    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    '    Me.ClientSize = New System.Drawing.Size(785, 397)
    '    Me.Controls.Add(Me.Panel1)
    '    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
    '    Me.Name = "FrmEtiquetas"
    '    Me.Text = "FrmEtiquetas"
    '    Me.Panel1.ResumeLayout(False)
    '    Me.ResumeLayout(False)

    'End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    'Friend WithEvents rpv As Microsoft.Reporting.WinForms.ReportViewer
End Class
