Imports System.Drawing.Printing
Imports System.Threading


Public Class Frmrdlc
    Public seleccionetiqueta As String
    Public dt As New DataTable

    'Private Sub cargar()
    '    dt = ConfigCorreo.CN_Correo.LlenarDatatableImprimir("123")


    '    'If Len(seleccionetiqueta) > 0 Then
    '    rpv.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
    '    rpv.LocalReport.ReportPath = "C:\Crisis\Correo\Etiqueta.rdlc"
    '    rpv.LocalReport.DataSources.Clear()
    '    rpv.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("CorreoDSCartas_cartas", dt))

    '    rpv.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
    '    rpv.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent
    '    rpv.RefreshReport()

    '    'End If

    'End Sub

    Private Sub FrmEtiquetas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'CheckForIllegalCrossThreadCalls = False
        'Dim TR As Thread
        'TR = New Thread(AddressOf cargar)
        'TR.Start()
        'cargar()
    End Sub

    Private Sub InitializeComponent()
        Me.SuspendLayout()
        '
        'Frmrdlc
        '
        Me.ClientSize = New System.Drawing.Size(453, 305)
        Me.Name = "Frmrdlc"
        Me.ResumeLayout(False)

    End Sub

    Private Sub Frmrdlc_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class