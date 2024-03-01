Public Class FrmImprimirAvisos
    Dim frmrep As FrmReportEtiquetasExcel

    Dim DTFinal As New DataTable
    Private Sub FrmImprimirAvisos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        DTFinal.Columns.Add("NRO_CARTA")
        DTFinal.Columns.Add("REMITENTE")
        DTFinal.Columns.Add("TRABAJO")
        DTFinal.Columns.Add("FECH_TRAB")
        DTFinal.Columns.Add("APELLIDO")
        DTFinal.Columns.Add("CALLE")
        DTFinal.Columns.Add("NRO")
        DTFinal.Columns.Add("CP")
        DTFinal.Columns.Add("LOCALIDAD")
        DTFinal.Columns.Add("PROVINCIA")
        DTFinal.Columns.Add("EMPRESA")
        DTFinal.Columns.Add("NRO_CART2")
        DTFinal.Columns.Add("SOCIO")
        DTFinal.Columns.Add("OBS")
        DTFinal.Columns.Add("OBS2")
        DTFinal.Columns.Add("OBS3")
        DTFinal.Columns.Add("OBS4")


        CargarAvisos()
    End Sub
    Private Sub BtnSelectEtic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSelectEtic.Click
        Dim openFD As New OpenFileDialog()
        With openFD
            .Title = "Seleccionar archivos"
            .Filter = "Todos los archivos (*.Rpt)|*.Rpt"
            .Multiselect = False
            .InitialDirectory = "C:\Crisisproduccion\Correo\Etiquetas"
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                TxtPath.Text = .FileName
            Else
                openFD.Dispose()
            End If
        End With
    End Sub
    Private Sub Btnimprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnimprimir.Click
        frmrep = Nothing
        frmrep = New FrmReportEtiquetasExcel
        frmrep.EtiquetaSeleccionada = TxtPath.Text
        frmrep.DTRegImprimir = DTFinal
        frmrep.Cant = DgvImprimir.Rows.Count
        frmrep.Show()


    End Sub
    Private Function CargarAvisos()

        Dim Dtbuscaravisos As New DataTable
        Dtbuscaravisos = ConfigCorreo.CN_Correo.ObtenerAvisoDeVisitaPorFecha(DtpFechaAviso.Value.ToShortDateString)

        For Each drwAvisos As DataRow In Dtbuscaravisos.Rows
            Dim Dtbuscar As New DataTable
            Dtbuscar = ConfigCorreo.CN_Correo.BuscarPorNroCartaImpresion(drwAvisos("Nro_Carta").ToString)

            For Each drw As DataRow In Dtbuscar.Rows
                Dim Fecha As Date = drw("FECH_TRAB").ToString
                DTFinal.Rows.Add(drw("NRO_CARTA").ToString, drw("REMITENTE").ToString, drw("TRABAJO").ToString, Fecha.ToShortDateString, drw("APELLIDO").ToString, drwAvisos("CALLE").ToString, drw("NRO").ToString, drwAvisos("CP").ToString, drwAvisos("LOCALIDAD").ToString, drwAvisos("PROVINCIA").ToString, drw("EMPRESA").ToString, drw("NRO_CART2").ToString, drw("SOCIO").ToString, drwAvisos("OBS").ToString, drw("OBS2").ToString, drw("OBS3").ToString, drw("OBS4").ToString)
            Next
        Next

        DgvImprimir.DataSource = DTFinal


    End Function

    Private Sub DtpFechaAviso_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DtpFechaAviso.TextChanged
        CargarAvisos()

    End Sub
End Class
