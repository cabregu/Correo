Imports CrystalDecisions.CrystalReports.Engine

Public Class FrmReportEtiquetasExcel

    Public DTRegImprimir As New DataTable

    Public EtiquetaSeleccionada As String
    'Public RemitoNro As String
    'Public RemitenteNombre As String
    Public Cant As Integer = 0

    Private Sub FrmReportEtiquetasExcel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim cryRpt As New ReportDocument
            cryRpt.Load(EtiquetaSeleccionada, CrystalDecisions.Shared.OpenReportMethod.OpenReportByTempCopy)
            cryRpt.SetDataSource(DTRegImprimir)
            crv.ReportSource = cryRpt
            crv.Refresh()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try


    End Sub
End Class
