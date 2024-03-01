Imports Bytescout.BarCodeReader
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Data.OleDb
Imports ConfigCorreo.CN_Correo
Public Class FrmEscaneo
    Dim Minimo As Integer = 0
    Dim frminform As FrmInforme



    Private Sub BtnSeleccionarCarpeta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'RecorrerCarpeta()
        CrearPlanilla()

    End Sub


    Private Sub BtnRotar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim newimage As Bitmap

        newimage = System.Drawing.Image.FromFile("D:\acuses\ACUSE CREDENCIALES2.jpg")

        newimage.RotateFlip(RotateFlipType.Rotate90FlipNone)
        newimage.Save("D:\acuses\ACUSE CREDENCIALES9.jpg", ImageFormat.Jpeg)


    End Sub
    Private Sub DgvDetalleArchivos_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DgvDetalleArchivos.DoubleClick

        Dim N As String = DgvDetalleArchivos.SelectedCells(0).RowIndex.ToString
        DgvDetalleArchivos.Rows(N).Cells("Estado").Value = "No_encontrado"

    End Sub
    'Private Function Verificar()
    '    If Not LblControlrecorre.Text = "MODO_LECTURA" Then
    '        Dim Nroplanilla As Integer = ConfigCorreo.CN_Correo.ObtenerNroDevoPlani - 1
    '        LblControlrecorre.Text = ConfigCorreo.CN_Correo.ObtenerEstadoScan(Nroplanilla)
    '        LblNroPLanilla.Text = Nroplanilla

    '    End If
    'End Function



    'Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
    '    Dim N As String = DgvDetalleArchivos.SelectedCells(0).RowIndex.ToString
    '    Dim Ruta As String = DgvDetalleArchivos.Rows(N).Cells("Ruta_Completa").Value
    '    FrmImagenScan.Imagen = Ruta
    '    FrmImagenScan.Show()


    'End Sub

    'Private Shared Function rotar2(ByVal ruta As String) As String
    '    Try

    '        Dim newimage As Bitmap

    '        newimage = System.Drawing.Image.FromFile(ruta)
    '        newimage.RotateFlip(RotateFlipType.Rotate90FlipNone)
    '        newimage.Save(ruta, ImageFormat.Jpeg)

    '        Dim reader As New Reader()
    '        reader.BarcodeTypesToFind.Code39 = True
    '        Dim barcodes As FoundBarcode() = reader.ReadFrom(ruta)

    '        Dim TxBarcode As String = ""
    '        TxBarcode = barcodes(0).Value
    '        TxBarcode = TxBarcode.Substring(0, TxBarcode.IndexOf("("))
    '        Return TxBarcode.ToString
    '    Catch ex As Exception

    '    End Try


    'End Function





    'Private Sub DgvDetalleArchivos_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles DgvDetalleArchivos.Enter
    '    Dim N As String = DgvDetalleArchivos.SelectedCells(0).RowIndex.ToString
    '    Dim carta As String = DgvDetalleArchivos.Rows(N).Cells("NroCartaLeido").Value

    '    Dim Estado As String = ConfigCorreo.CN_Correo.ObtenerCalleCartaEscaneo(carta)
    '    DgvDetalleArchivos.Rows(N).Cells("Estado").Value = Estado

    'End Sub


    Private Sub BtnFinalizarCompletar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFinalizarCompletar.Click
        BtnFinalizarCompletar.Enabled = False

        If DgvDetalleArchivos.RowCount > 0 Then
            Dim cant As Integer = 0
            For Each drw As DataGridViewRow In DgvDetalleArchivos.Rows
                If drw.Cells("Estado").Value = "No_encontrado" Then
                    cant = cant + 1
                End If
            Next
            If cant > 0 Then
                MsgBox("Hay archivos que no fueron leidos")
            Else

                For Each drw1 As DataGridViewRow In DgvDetalleArchivos.Rows

                    ConfigCorreo.CN_Correo.InsertarCartaLeida(drw1.Cells("NroCartaLeido").Value, "Entregada", ConfigCorreo.CN_Correo.Converfecha(Dtp1.Value.ToShortDateString), ConfigCorreo.CN_Correo.Converfecha(Now.ToShortDateString), drw1.Cells("Ruta_completa").Value, LblNroPLanilla.Text)
                    ConfigCorreo.CN_Correo.ActualizarPorCartaRecorrido(drw1.Cells("NroCartaLeido").Value, "ESCANEADO", ConfigCorreo.CN_Correo.Converfecha(Dtp1.Value.ToShortDateString))
                    ConfigCorreo.CN_Correo.VerificarEstadoAlerta(drw1.Cells("NroCartaLeido").Value, "ESCANEADO")

                Next
                Dim Nroplan As Integer = ConfigCorreo.CN_Correo.ObtenerNroPlanillaEscaner - 1
                ConfigCorreo.CN_Correo.ActualizarEstadoEscaneoControl(Nroplan)
                LblControlrecorre.Text = "SIN_ARCHIVOS"
                DgvDetalleArchivos.Rows.Clear()
                LblCantidadNro.Text = "0"
                LblNroPLanilla.Text = "0"
            End If
        End If
        BtnFinalizarCompletar.Enabled = True


    End Sub
    Private Sub BtnRotacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRotacion.Click

        If MessageBox.Show("Desea rotar y releer?", "Rotar y releer?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            'PBox1 = Nothing
            If DgvDetalleArchivos.RowCount > 0 Then
                DgvDetalleArchivos.Rows.Clear()
                RotarYleer()
            End If
        End If


        'Dim N As String = DgvDetalleArchivos.SelectedCells(0).RowIndex.ToString
        'Dim Ruta As String = DgvDetalleArchivos.Rows(N).Cells("Ruta_Completa").Value
        'Dim newimage As Bitmap
        'newimage = System.Drawing.Image.FromFile(Ruta)
        'newimage.RotateFlip(RotateFlipType.Rotate90FlipNone)
        'newimage.Save(Ruta, ImageFormat.Jpeg)

    End Sub
    Private Sub RotarYleer()

        Dim NroPlanilla As String = ""
        NroPlanilla = ConfigCorreo.CN_Correo.ObtenerNroPlanillaEscaner
        Dim Ruta As String = ConfigCorreo.CN_Correo.ObtenerRutaDeArchivos(NroPlanilla - 1)
        If Len(Ruta) > 0 Then
            For Each Archivo As String In My.Computer.FileSystem.GetFiles(Ruta)
                Dim newimage As Bitmap
                newimage = System.Drawing.Image.FromFile(Archivo)
                newimage.RotateFlip(RotateFlipType.Rotate90FlipNone)
                newimage.Save(Archivo, ImageFormat.Jpeg)

                DgvDetalleArchivos.Rows.Add(ObtenerCartaBarcode(Archivo), "", Archivo)
            Next
        End If

        For Each drw As DataGridViewRow In DgvDetalleArchivos.Rows
            Dim Carta1 As Integer
            If IsNumeric(drw.Cells("NroCartaLeido").Value) Then
                Carta1 = drw.Cells("NroCartaLeido").Value
            Else
                Carta1 = 0
            End If
            Dim Estado As String = ConfigCorreo.CN_Correo.ObtenerCalleCartaEscaneo(Carta1)
            drw.Cells("Estado").Value = Estado

        Next



    End Sub
    Private Sub BtnAbrir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAbrir.Click
        If DgvDetalleArchivos.Rows.Count > 0 Then
            Dim N As String = DgvDetalleArchivos.SelectedCells(0).RowIndex.ToString
            Dim Ruta As String = DgvDetalleArchivos.Rows(N).Cells("Ruta_Completa").Value
            EjecutarArchivos(Ruta)
        End If
    End Sub
    Private Sub Btninforme_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btninforme.Click
        frminform = Nothing
        If frminform Is Nothing Then
            frminform = New FrmInforme
            frminform.Show()
            Me.Visible = False
        ElseIf frminform.IsDisposed Then
            Me.Visible = True
        End If
    End Sub
    Private Sub BtnPlanilla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPlanillar.Click
        BtnPlanillar.Enabled = False
        CrearPlanilla()
        MoverArchivos()
        LeerCartas()
        BtnPlanillar.Enabled = True

    End Sub
    Private Function CrearPlanilla() As Boolean



        Dim RutaArchivos As String = ConfigCorreo.CN_Correo.ObtenerRutaArchivosScaner
        Dim RutaEscaneo As String = ConfigCorreo.CN_Correo.ObtenerRutaEscaneo()
        Dim FechaCarpeta As String = Now.ToShortDateString
        Dim ContadorDeArchivos As System.Collections.ObjectModel.ReadOnlyCollection(Of String)
        ContadorDeArchivos = My.Computer.FileSystem.GetFiles(RutaArchivos)
        Dim NroPlanilla As String = ConfigCorreo.CN_Correo.ObtenerNroPlanillaEscaner

        Dim PlanillaSinEscanear As String = ConfigCorreo.CN_Correo.ObtenerPlanillaLibre(NroPlanilla)

        If PlanillaSinEscanear = "ESCANEADO" Then
        Else
            If ContadorDeArchivos.Count > 0 Then


                If Not My.Computer.FileSystem.DirectoryExists(RutaEscaneo & "\" & ConfigCorreo.CN_Correo.Converfechaescaneo(FechaCarpeta)) Then
                    My.Computer.FileSystem.CreateDirectory(RutaEscaneo & "\" & ConfigCorreo.CN_Correo.Converfechaescaneo(FechaCarpeta))
                End If

                My.Computer.FileSystem.CreateDirectory(RutaEscaneo & "\" & ConfigCorreo.CN_Correo.Converfechaescaneo(FechaCarpeta) & "\" & NroPlanilla)
                Dim rutappal As String = RutaEscaneo & "\" & ConfigCorreo.CN_Correo.Converfechaescaneo(FechaCarpeta) & "\" & NroPlanilla & "\"
                rutappal = rutappal.Replace("\", "\\")
                ConfigCorreo.CN_Correo.InsertarPlanillaEscaneo(ConfigCorreo.CN_Correo.Converfechaescaneo(FechaCarpeta), NroPlanilla, ContadorDeArchivos.Count, rutappal)
                ConfigCorreo.CN_Correo.ActualizarNroPlaniEscaner(NroPlanilla + 1)
            Else
                MsgBox("No Hay Archivos")
            End If

        End If

    End Function
    Private Function MoverArchivos() As Boolean

        'Try
        Dim NroPlanilla As Integer = ConfigCorreo.CN_Correo.ObtenerNroPlanillaEscaner
        Dim PlanillaSinEscanear As String = ConfigCorreo.CN_Correo.ObtenerPlanillaLibre(NroPlanilla - 1)
        Dim RutaArchivosScaner As String = ConfigCorreo.CN_Correo.ObtenerRutaArchivosScaner
        Dim RutaDeArchivos As String = ConfigCorreo.CN_Correo.ObtenerRutaDeArchivos(NroPlanilla - 1)

        'MsgBox(NroPlanilla & "-" & PlanillaSinEscanear & "-" & RutaArchivosScaner & "-" & RutaDeArchivos)



        If PlanillaSinEscanear = "SIN_ARCHIVOS" Then
            Dim folder As New DirectoryInfo(RutaArchivosScaner)
            For Each file As FileInfo In folder.GetFiles()
                file.MoveTo(Trim(RutaDeArchivos) & Trim(file.Name))
            Next
            ConfigCorreo.CN_Correo.ActualizarPlanillaSinArchivos(NroPlanilla - 1)
        End If



        'Catch ex As Exception

        'End Try




    End Function
    Public Sub LeerCartas()

        Try
            LblBusqueda.Text = "Buscando"
            LblBusqueda.Refresh()
            Dim NroPlanilla As String = ""
            NroPlanilla = ConfigCorreo.CN_Correo.ObtenerNroPlanillaEscaner
            Dim Ruta As String = ConfigCorreo.CN_Correo.ObtenerRutaDeArchivos(NroPlanilla - 1)
            Dim EstadoArchiv As String = ConfigCorreo.CN_Correo.ObtenerEstadoScan(NroPlanilla - 1)
            If EstadoArchiv = "CON_ARCHIVOS" Then
                Dim ContadorDeArchivos As System.Collections.ObjectModel.ReadOnlyCollection(Of String)
                ContadorDeArchivos = My.Computer.FileSystem.GetFiles(Ruta)

                LblCantidadNro.Text = ContadorDeArchivos.Count
                LblCantidadNro.Refresh()
                LblNroPLanilla.Text = NroPlanilla - 1
                LblNroPLanilla.Refresh()
                If Len(Ruta) > 0 Then
                    For Each Archivo As String In My.Computer.FileSystem.GetFiles(Ruta)
                        LblControlrecorre.Text = Archivo
                        LblControlrecorre.Refresh()
                        If Not Archivo.Contains("Thumbs") Then
                            Dim NroLeido As String = ObtenerCartaBarcode(Archivo)
                            DgvDetalleArchivos.Rows.Add(NroLeido.Replace("/", "-"), "", Archivo)
                        End If
                    Next
                End If

                LblControlrecorre.Text = "Lectura finalizada"

                'For Each drw As DataGridViewRow In DgvDetalleArchivos.Rows
                '    Dim Carta1 As String = drw.Cells("NroCartaLeido").Value
                '    Dim Estado As String = ConfigCorreo.CN_Correo.ObtenerCalleCartaEscaneo(Carta1)
                '    If Estado <> "" Then
                '        drw.Cells("Estado").Value = Estado
                '    Else
                '        Dim NroCarta As String = ObtenerCalleCartaEscaneoPorNroCart2(Carta1)
                '        If Len(NroCarta) > 0 Then
                '            drw.Cells("Estado").Value = "ENTREGADA"
                '            drw.Cells("NroCartaLeido").Value = NroCarta
                '        End If


                '    End If

                'Next
                Releer()


            End If
            LblBusqueda.Text = "En Pausa"
            LblBusqueda.Refresh()

        Catch oe As Exception
            MsgBox(oe.Message, MsgBoxStyle.Critical)
        End Try


    End Sub

    Private Function Releer()
        For Each drw As DataGridViewRow In DgvDetalleArchivos.Rows
            Dim Carta1 As String = drw.Cells("NroCartaLeido").Value
            Dim Estado As String = ConfigCorreo.CN_Correo.ObtenerCalleCartaEscaneo(Carta1)
            If Estado <> "" Then
                drw.Cells("Estado").Value = Estado
            Else
                Dim NroCarta As String = ObtenerCalleCartaEscaneoPorNroCart2(Carta1)
                If Len(NroCarta) > 0 Then
                    drw.Cells("Estado").Value = "ENTREGADA"
                    drw.Cells("NroCartaLeido").Value = NroCarta
                End If


            End If

        Next

    End Function

    Public Sub EjecutarArchivos(ByVal ruta As String)
        Dim ejecutarShell As Object
        ejecutarShell = Shell("rundll32.exe url.dll,FileProtocolHandler " & (ruta), 1)
    End Sub

    Private Function ObtenerCartaBarcode(ByVal Ruta As String) As String


        Try
            Dim reader As New Reader()
            reader.BarcodeTypesToFind.Code39 = True
            Dim TxBarcode As String = ""
            Dim barcodes As FoundBarcode() = reader.ReadFrom(Ruta)
            TxBarcode = barcodes(0).Value

            If Len(TxBarcode) > 10 Then
                TxBarcode = TxBarcode.Substring(0, TxBarcode.IndexOf("("))
            End If

            Return TxBarcode.ToString
            'MsgBox(TxBarcode)

        Catch ex As Exception
            Return "0000"
        End Try





    End Function

    Private Sub FrmEscaneo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub


    Private Sub Timer1_Tick_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If LblNro.Text = "1" Then
            BtnTermometro.Image = My.Resources.temperature_1
            LblNro.Text = "2"
        ElseIf LblNro.Text = "2" Then
            BtnTermometro.Image = My.Resources.temperature_2
            LblNro.Text = "3"
        ElseIf LblNro.Text = "3" Then
            BtnTermometro.Image = My.Resources.temperature_3
            LblNro.Text = "4"
        ElseIf LblNro.Text = "4" Then
            BtnTermometro.Image = My.Resources.temperature_4
            LblNro.Text = "5"
        ElseIf LblNro.Text = "5" Then
            BtnTermometro.Image = My.Resources.temperature_5

            NoEncontradosOK()

            LblNro.Text = "1"

        End If
    End Sub

    Private Function NoEncontradosOK()
        Releer()

        'If LblBusqueda.Text = "En Pausa" Then

        '    If DgvDetalleArchivos.RowCount > 0 Then


        '        Dim cant As Integer = 0
        '        For Each drw As DataGridViewRow In DgvDetalleArchivos.Rows
        '            If drw.Cells("Estado").Value = "No_encontrado" Then
        '                cant = cant + 1
        '            End If
        '        Next

        '        If cant > 0 Then
        '            Try
        '                For Each drw As DataGridViewRow In DgvDetalleArchivos.Rows

        '                    Dim Estado1 As String = ConfigCorreo.CN_Correo.ObtenerCalleCartaEscaneo(drw.Cells("NroCartaLeido").Value)
        '                    drw.Cells("Estado").Value = Estado1

        '                    drw.Cells("Estado").Value = "No_encontrado"

        '                Next
        '            Catch ex As Exception
        '            End Try
        '        Else
        '        End If
        '    End If
        'End If


    End Function



    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        If LblNroPLanilla.Text <> "0" Then
            If MessageBox.Show("Eliminar Planilla " & LblNroPLanilla.Text & " y reintentar?", "Eliminar Planilla?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                Dim ruta As String = ObtenerRutaDeArchivos(LblNroPLanilla.Text)
                ruta = ruta.Substring(0, ruta.LastIndexOf("\"))
                EliminarCarpeta(ruta, LblNroPLanilla.Text)
                DgvDetalleArchivos.Rows.Clear()
            End If
        End If

    End Sub


    Private Sub EliminarCarpeta(ByVal Ruta As String, ByVal NroPlanilla As String)
        Try
            My.Computer.FileSystem.DeleteDirectory(Ruta, FileIO.UIOption.AllDialogs, FileIO.RecycleOption.SendToRecycleBin, FileIO.UICancelOption.DoNothing)
            EliminarPlanillaEscaneo(NroPlanilla)
            LblNroPLanilla.Text = "0"
            LblCantidadNro.Text = "0"
            ActualizarNroPlaniEscaner(NroPlanilla)

        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
        End Try

    End Sub


    Private Sub BtnAcusesMalLeidos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAcusesMalLeidos.Click

        For Each foundFile As String In My.Computer.FileSystem.GetFiles("C:\ARCHIVOS_ESCANER", Microsoft.VisualBasic.FileIO.SearchOption.SearchAllSubDirectories, "*.*")
            My.Computer.FileSystem.DeleteFile(foundFile, Microsoft.VisualBasic.FileIO.UIOption.AllDialogs, Microsoft.VisualBasic.FileIO.RecycleOption.SendToRecycleBin)
        Next
        MsgBox("ok")
    End Sub

    Private Sub BtnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBack.Click

        Try

            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''  
            For Each Archivo As String In My.Computer.FileSystem.GetFiles( _
                                    "D:\ESCANEO\31_10_2016", _
                                    FileIO.SearchOption.SearchAllSubDirectories, _
                                    "*.jpg")
                MsgBox(Archivo)

            Next
            ' errores  
        Catch oe As Exception
            MsgBox(oe.Message, MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub BtnTermometro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTermometro.Click
        Obteneractualizarplanillas()
        MsgBox("ok")
    End Sub

End Class
