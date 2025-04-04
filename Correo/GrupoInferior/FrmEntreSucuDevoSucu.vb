Imports System.Data.OleDb
Imports System.IO
Imports System.Threading


Public Class FrmEntreSucuDevoSucu




    Private Sub BtncargarDatos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtncargarDatos.Click
        If ChkOtro.Checked = True Then
            SeleccionarOtro()
        Else
            Seleccionar()
        End If

    End Sub


    Public Sub SeleccionarOtro()

        Dim openFD As New OpenFileDialog()
        With openFD
            .Title = "Seleccionar archivos"
            .Filter = "Todos los archivos (*.xls)|*.xls"
            .Multiselect = False
            .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                If impExcelOtro(.FileName) = True Then
                    txtPath.Text = .FileName
                End If
            Else
                openFD.Dispose()
            End If
        End With

    End Sub
    Private Function impExcelOtro(ByVal Archivo As String) As Boolean


        Dim strconn As String
        strconn = "Provider=Microsoft.Jet.Oledb.4.0; data source= " + Archivo + ";Extended properties=""Excel 8.0;hdr=yes;imex=1"""
        Dim mconn As New OleDbConnection(strconn)
        Dim ad As New OleDbDataAdapter("Select * from [" & "Lexs" & "$]", mconn)
        Dim dt2 As New DataTable

        mconn.Open()
        ad.Fill(dt2)
        mconn.Close()
        DgvControl.DataSource = dt2


 



    End Function







    Public Sub Seleccionar()

        Dim openFD As New OpenFileDialog()
        With openFD
            .Title = "Seleccionar archivos"
            .Filter = "Todos los archivos (*.xls)|*.xls"
            .Multiselect = False
            .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                If impExcel(.FileName) = True Then
                    txtPath.Text = .FileName
                End If
            Else
                openFD.Dispose()
            End If
        End With

    End Sub
    Private Function impExcel(ByVal Archivo As String) As Boolean

        Try
            Dim strconn As String
            strconn = "Provider=Microsoft.Jet.Oledb.4.0; data source= " + Archivo + ";Extended properties=""Excel 8.0;hdr=yes;imex=1"""
            Dim mconn As New OleDbConnection(strconn)
            Dim ad As New OleDbDataAdapter("Select Nro_carta, Fecha from [" & "Lexs" & "$]", mconn)
            Dim dt2 As New DataTable

            mconn.Open()
            ad.Fill(dt2)
            mconn.Close()
            dt2.Columns.Add("Estado")
            dt2.Columns.Add("EstadoEnSistema")

            For Each dr As DataRow In dt2.Rows

                If ChkDevoSucu.CheckState = CheckState.Checked Then
                    dr("Estado") = "DEVO_SUCU"
                End If
                If ChkEntreSucu.CheckState = CheckState.Checked Then
                    dr("Estado") = "ENTRE_SUCU"
                End If

                dr("EstadoEnSistema") = ConfigCorreo.CN_Correo.BuscarPorNroCartaParaConfEntre(dr("Nro_carta").ToString)


            Next

            DgvControl.DataSource = dt2

            ChkDevoSucu.Enabled = False
            ChkEntreSucu.Enabled = False


        Catch ex As System.Exception
            MsgBox("Archivo incompatible detalle de error : " & ex.ToString)
        End Try




    End Function

    Private Sub ChkDevoSucu_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ChkDevoSucu.CheckStateChanged
        If ChkDevoSucu.CheckState = CheckState.Checked Then
            ChkEntreSucu.CheckState = CheckState.Unchecked
        End If
    End Sub

    Private Sub ChkEntreSucu_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ChkEntreSucu.CheckStateChanged
        If ChkEntreSucu.CheckState = CheckState.Checked Then
            ChkDevoSucu.CheckState = CheckState.Unchecked
        End If
    End Sub

    Private Sub BtnActualizarDesdeExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnActualizarDesdeExcel.Click
        Dim Numero As Integer = 0
        PgbAnalisis.Minimum = 0
        PgbAnalisis.Maximum = DgvControl.Rows.Count

        If DgvControl.RowCount > 0 Then
            For Each drwg As DataGridViewRow In DgvControl.Rows
                ConfigCorreo.CN_Correo.ActualizarPorCartaEstadoEnCartasActualizadoConfEntreDeoSucu(drwg.Cells("Nro_carta").Value, drwg.Cells("Estado").Value, drwg.Cells("Fecha").Value)
                Try
                    ConfigCorreo.CN_Correo.VerificarEstadoAlerta(drwg.Cells("Nro_carta").Value, drwg.Cells("Estado").Value)
                Catch ex As System.Exception

                End Try

                Numero = Numero + 1
                PgbAnalisis.Value = Numero
            Next
        End If

        DgvControl.DataSource = Nothing
        txtPath.Text = ""

    End Sub

    Private Sub ChkEntreSucu_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkEntreSucu.CheckedChanged
        BtncargarDatos.Enabled = True
        BtnActualizarOtroDato.Enabled = False
    End Sub

    Private Sub ChkDevoSucu_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkDevoSucu.CheckedChanged
        BtncargarDatos.Enabled = True
        BtnActualizarOtroDato.Enabled = False

    End Sub

    Private Sub ChkOtro_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles ChkOtro.CheckedChanged
        BtncargarDatos.Enabled = True
        BtnActualizarDesdeExcel.Enabled = False
        BtnActualizarOtroDato.Enabled = True


    End Sub



    'Private Sub BtnActualizarOtroDato_Click(sender As System.Object, e As System.EventArgs) Handles BtnActualizarOtroDato.Click

    '    Dim Numero As Integer = 0
    '    PgbAnalisis.Minimum = 0
    '    PgbAnalisis.Maximum = DgvControl.Rows.Count

    '    Dim CampoActualizar As String = ""

    '    For Each dc As DataGridViewColumn In DgvControl.Columns
    '        If dc.Name.ToString <> "NRO_CARTA" Then
    '            CampoActualizar = dc.Name.ToString
    '        End If

    '    Next

    '    If DgvControl.RowCount > 0 Then
    '        For Each drwg As DataGridViewRow In DgvControl.Rows
    '            ConfigCorreo.CN_Correo.ActualizarPorCartaEstadoEnCartasActualizadoCampoEspecifico(drwg.Cells("Nro_carta").Value, CampoActualizar, drwg.Cells(CampoActualizar).Value)


    '            Numero = Numero + 1
    '            PgbAnalisis.Value = Numero
    '        Next
    '    End If

    '    DgvControl.DataSource = Nothing
    '    txtPath.Text = ""


    'End Sub
    Private Sub BtnActualizarOtroDato_Click(sender As System.Object, e As System.EventArgs) Handles BtnActualizarOtroDato.Click
        Dim CampoActualizar As String = ""

        For Each dc As DataGridViewColumn In DgvControl.Columns
            If dc.Name.ToString <> "NRO_CARTA" Then
                CampoActualizar = dc.Name.ToString
            End If
        Next

        Dim actualizaciones As New List(Of KeyValuePair(Of Object, Object))()

        If DgvControl.RowCount > 0 Then
            For Each drwg As DataGridViewRow In DgvControl.Rows
                actualizaciones.Add(New KeyValuePair(Of Object, Object)(drwg.Cells("Nro_carta").Value, drwg.Cells(CampoActualizar).Value))
            Next
        End If

        ' Crear un nuevo hilo para la actualización
        Dim updateThread As New Thread(Sub() RealizarActualizaciones(actualizaciones, CampoActualizar))
        updateThread.Start()
    End Sub

    Private Sub RealizarActualizaciones(actualizaciones As List(Of KeyValuePair(Of Object, Object)), campoActualizar As String)
        Try


            Dim Numero As Integer = 0
            PgbAnalisis.Invoke(Sub() PgbAnalisis.Minimum = 0)
            PgbAnalisis.Invoke(Sub() PgbAnalisis.Maximum = actualizaciones.Count)

            For Each actualizacion As KeyValuePair(Of Object, Object) In actualizaciones
                ConfigCorreo.CN_Correo.ActualizarPorCartaEstadoEnCartasActualizadoCampoEspecifico(actualizacion.Key, campoActualizar, actualizacion.Value)

                Numero += 1
                PgbAnalisis.Invoke(Sub() PgbAnalisis.Value = Numero)
            Next

            ' Actualizar el DataGridView después de la actualización en el hilo principal
            DgvControl.Invoke(Sub() DgvControl.DataSource = Nothing)
            txtPath.Invoke(Sub() txtPath.Text = "")

        Catch ex As System.Exception

        End Try

    End Sub



End Class
