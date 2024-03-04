Imports iTextSharp.text.pdf
Imports Microsoft.Office.Interop

Public Class FrmDevolucion

    Dim ArrMotiv As New ArrayList
    Dim ArrNroCartaLeido As New ArrayList
    Dim ArrNroCart2Leido As New ArrayList
    Dim ArrNrosPlanilla As New ArrayList


    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click
        Dim NroRecorrido As Integer
        NroRecorrido = ConfigCorreo.CN_Correo.ObtenerNroPlanillaDevolucion
        TxtPlanillaDevo.Text = NroRecorrido

        TxtCartas.Enabled = True
        CmbMotivos.Enabled = True
        TxtBarraCliente.Enabled = True
        TxtCartas.Focus()

        ConfigCorreo.CN_Correo.ActualizarNroPlanillaDevolucion(NroRecorrido)
        BtnFinalizar.Enabled = True
        DgvCartaDev.Rows.Clear()
        TxtCantidad.Text = ""
        CmbVolverAVerPlanilla.Text = ""


    End Sub

    Private Sub FrmDevolucion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        TxtCartas.Focus()

        Dim ListaItems As New List(Of String)
        ListaItems.Clear()
        ArrMotiv = ConfigCorreo.CN_Correo.CargarMotivos
        For i As Integer = 0 To ArrMotiv.Count - 1
            ListaItems.Add(ArrMotiv.Item(i).ToString)
        Next

        CmbMotivos.DataSource = ListaItems
        CmbMotivos.AutoCompleteMode = AutoCompleteMode.Suggest
        CmbMotivos.AutoCompleteSource = AutoCompleteSource.ListItems

        CmbMotivos.Show()
        CmbMotivos.Text = ""

        ArrNroCartaLeido.Clear()
        ArrNroCart2Leido.Clear()

        CargarPLanillasDesde()
        CargarPLanillasHasta()
        CargarPlanillaParaVolver()
        btnAgregarCarta.Visible = False
        BtnActualizar.Visible = False





    End Sub
    Private Sub Gb_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Gb.Enter

    End Sub
    Public Function EstadoincorrectoNroCarta(ByVal NroCartaCarga As String)

        If Len(NroCartaCarga) > 0 Then
            Dim EstadoEnTR As String = ""
            EstadoEnTR = ConfigCorreo.CN_Correo.BuscarEnTransitoPorNroCartaParaDevuelta(NroCartaCarga)

            If EstadoEnTR.Contains("ENT") Then
                MsgBox("La Pieza no se debe devolver, estado " & EstadoEnTR)
                TxtBarraCliente.Text = ""
                TxtCartas.Text = ""
            Else
                CmbMotivos.Focus()
            End If
            CmbMotivos.Focus()
        End If


    End Function

    Private Sub TxtCartas_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCartas.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If ChkFijarMotivo.Checked = False Then
                e.Handled = True 'quita sonido 
                Try
                    If EstadoincorrectoNroCarta(TxtCartas.Text) > 0 Then

                        EstadoincorrectoNroCarta(TxtCartas.Text)

                    End If
                Catch ex As Exception

                End Try


            Else
                e.Handled = True 'quita sonido 
                If Len(TxtCartas.Text) > 0 Then
                    BtnOkNoentregada.Focus()
                End If
            End If

        End If

    End Sub
    Private Sub TxtBarraCliente_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtBarraCliente.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If ChkFijarMotivo.Checked = False Then
                e.Handled = True 'quita sonido 
                If Len(TxtBarraCliente.Text) > 0 Then

                    Dim NroCarta As String = ConfigCorreo.CN_Correo.BuscarEnTransitoPorNroCartaParaDevueltaPorCarta2(TxtBarraCliente.Text)

                    If NroCarta = "" Then
                        NroCarta = ConfigCorreo.CN_Correo.BuscarNroCartaParaDevueltaPorCarta2(TxtBarraCliente.Text)
                    End If

                    TxtCartas.Text = NroCarta
                    EstadoincorrectoNroCarta(NroCarta)


                    CmbMotivos.Focus()
                End If

            Else
                e.Handled = True 'quita sonido 
                If Len(TxtBarraCliente.Text) > 0 Then
                    BtnOkNoentregada.Focus()
                End If
            End If

        End If
    End Sub
    Private Sub CmbMotivos_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbMotivos.KeyDown
        If e.KeyCode = Keys.Return Then
            e.Handled = True

            If Len(CmbMotivos.Text) > 0 Then
                If ArrMotiv.Contains(CmbMotivos.Text) Then
                    BtnOkNoentregada.Focus()
                Else
                    MsgBox("El motivo no corresponde")
                    CmbMotivos.Focus()
                End If


            End If
        End If
    End Sub

    Private Sub BtnOkNoentregada_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOkNoentregada.Click

        If Len(TxtBarraCliente.Text) > 0 Or Len(TxtCartas.Text) > 0 Then
            CargarNroCarta(TxtCartas.Text)
            TxtBarraCliente.Text = ""
            TxtCartas.Text = ""
            If ChkFijarBarraCliente.Checked = True Then
                TxtCartas.Focus()
            Else
                TxtBarraCliente.Focus()
            End If

        End If




    End Sub
    Private Sub BtnFinalizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFinalizar.Click
        If DgvCartaDev.RowCount > 0 Then

            If ConfigCorreo.CN_Correo.InsertarPlanillaDevo(DtpFechaDevo.Value.ToShortDateString, TxtPlanillaDevo.Text, TxtCantidad.Text, "") = True Then
                Dim Devoplani As String = TxtPlanillaDevo.Text



                For Each drw As DataGridViewRow In DgvCartaDev.Rows
                    ConfigCorreo.CN_Correo.InsertarDevolucionDetalle(drw.Cells("asociado").Value, drw.Cells("lote").Value, drw.Cells("integrante").Value, drw.Cells("fech_trab").Value, drw.Cells("tema1").Value, drw.Cells("fecha1").Value, drw.Cells("tema2").Value, drw.Cells("fecha2").Value, drw.Cells("motivo_devo").Value, drw.Cells("fech_devo").Value, Devoplani, drw.Cells("apellido").Value, drw.Cells("calle").Value, drw.Cells("cp").Value, drw.Cells("localidad").Value, drw.Cells("nro_carta").Value)
                    ConfigCorreo.CN_Correo.ActualizarEstadoDevolucion(drw.Cells("nro_carta").Value)
                    ConfigCorreo.CN_Correo.VerificarEstadoAlerta(drw.Cells("nro_carta").Value, "Devuelta")
                Next

                ConfigCorreo.CN_Correo.ActualizarNroPlaniDevo(TxtPlanillaDevo.Text + 1)
                DgvCartaDev.Rows.Clear()
                TxtPlanillaDevo.Text = ""
            End If
            ArrNroCartaLeido.Clear()
            ArrNroCart2Leido.Clear()
            CargarPLanillasDesde()
            CargarPLanillasHasta()
            CargarPlanillaParaVolver()

        End If



    End Sub


    Public Function CargarNroCarta(ByVal nroc As String) As Boolean
        BtnFinalizar.Enabled = True
        If Not ArrNroCartaLeido.Contains(nroc) Then

            If Len(CmbMotivos.Text) > 0 And Len(TxtCartas.Text) > 0 Then
                If ArrMotiv.Contains(CmbMotivos.Text) Then
                    If TxtCartas.Text <> "" Then
                        '**
                        Dim Dt As DataTable = ConfigCorreo.CN_Correo.BuscarCartaPorNroCarta(nroc)
                        If Dt.Rows.Count > 0 Then
                            For Each drw As DataRow In Dt.Rows

                                Dim NroCart2 As String = drw("NRO_CART2").ToString
                                Dim Socio As String = ""
                                Dim Lote As String = ""
                                Dim integrante As String = ""

                                Try
                                    ' Split the NroCart2 using hyphen as separator
                                    Dim parts As String() = NroCart2.Split("-"c)
                                    Socio = parts(0).Trim()
                                    Lote = parts(1).Trim()

                                    ' Check if there are additional integrantes
                                    If parts.Length > 2 Then
                                        For i As Integer = 2 To parts.Length - 1
                                            integrante &= parts(i).Trim() & " "
                                        Next
                                    End If

                                Catch ex As Exception
                                    ' Handle any exceptions that may occur during the split
                                End Try

                                Dim Fech_trab As Date = drw("fech_trab").ToString

                                DgvCartaDev.Rows.Insert(0, Socio, Lote, integrante.Trim(), Fech_trab.ToShortDateString, " - ", " - ", " - ", " - ", CmbMotivos.Text, DtpFechaDevo.Value.ToShortDateString, TxtPlanillaDevo.Text, drw("apellido").ToString, drw("calle").ToString, drw("cp").ToString, drw("localidad").ToString, drw("nro_carta").ToString)

                                'DgvCartaDev.Rows.Add(Socio, Lote, integrante, Fech_trab.ToShortDateString, " - ", " - ", " - ", " - ", CmbMotivos.Text, DtpFechaDevo.Value.ToShortDateString, TxtPlanillaDevo.Text, drw("apellido").ToString, drw("calle").ToString, drw("cp").ToString, drw("localidad").ToString, drw("nro_carta").ToString)

                                DgvCartaDev.CurrentCell = DgvCartaDev.Rows(0).Cells(0)

                            Next
                            TxtCantidad.Text = DgvCartaDev.Rows.Count
                            ArrNroCartaLeido.Add(nroc)

                            If ChkFijarMotivo.Checked = False Then
                                CmbMotivos.Text = ""
                            End If

                            If ChkFijarMotivo.Checked = True Then
                                TxtBarraCliente.Text = ""
                                TxtBarraCliente.Focus()
                            Else
                                TxtCartas.Text = ""
                                TxtCartas.Focus()
                            End If

                        End If

                    End If

                Else
                    MsgBox("El motivo no corresponde")
                    CmbMotivos.Focus()

                End If
                Return True

            End If

        End If

    End Function



    Public Function CargarNroCart2(ByVal NroC As String) As Boolean
        BtnFinalizar.Enabled = True
        If Not ArrNroCart2Leido.Contains(NroC) Then

            If Len(CmbMotivos.Text) > 0 And Len(TxtBarraCliente.Text) > 0 Then
                If ArrMotiv.Contains(CmbMotivos.Text) Then
                    If TxtBarraCliente.Text <> "" Then
                        If TxtCartas.Text = "" Then
                            Dim Dt As DataTable = ConfigCorreo.CN_Correo.BuscarCartaPorNroCart2(NroC)
                            If Dt.Rows.Count > 0 Then
                                For Each drw As DataRow In Dt.Rows
                                    If Len(drw("NRO_CART2").ToString) > 15 Then
                                        Dim NroCart2 As String = drw("NRO_CART2").ToString

                                        Dim Socio As String
                                        Dim Lote As String
                                        Dim integrante As String
                                        Socio = NroCart2.Substring(0, 7)
                                        Lote = NroCart2.Substring(8, 7)
                                        integrante = NroCart2.Substring(16, Len(NroCart2) - 16)
                                        Dim Fech_trab As Date = drw("fech_trab").ToString
                                        DgvCartaDev.Rows.Add(Socio, Lote, integrante, Fech_trab.ToShortDateString, " - ", " - ", " - ", " - ", CmbMotivos.Text, DtpFechaDevo.Value.ToShortDateString, TxtPlanillaDevo.Text, drw("apellido").ToString, drw("calle").ToString, drw("cp").ToString, drw("localidad").ToString, drw("nro_carta").ToString)
                                    End If
                                Next
                                TxtCantidad.Text = DgvCartaDev.Rows.Count

                                If ChkFijarMotivo.Checked = False Then

                                    CmbMotivos.Text = ""
                                End If
                                TxtBarraCliente.Text = ""
                                TxtBarraCliente.Focus()
                            End If
                        End If
                    End If
                End If
            End If
            ArrNroCart2Leido.Add(NroC)
        End If
    End Function
    Public Function CargarPLanillasDesde()
        Dim ListaItems As New List(Of String)
        Dim dt As New DataTable
        dt = ConfigCorreo.CN_Correo.CargarPlanillasDev
        For Each drw As DataRow In dt.Rows
            ListaItems.Add(drw("Plani_devo"))
        Next
        CmbDesde.DataSource = ListaItems
        CmbDesde.AutoCompleteMode = AutoCompleteMode.Suggest
        CmbDesde.AutoCompleteSource = AutoCompleteSource.ListItems
        CmbDesde.Show()
        CmbDesde.Text = ""
        Return True
    End Function
    Public Function CargarPlanillaParaVolver()
        Dim ListaItems As New List(Of String)
        Dim dt As New DataTable
        dt = ConfigCorreo.CN_Correo.CargarPlanillasDev
        ArrNrosPlanilla.Clear()
        For Each drw As DataRow In dt.Rows
            ListaItems.Add(drw("Plani_devo"))
            ArrNrosPlanilla.Add(drw("Plani_devo"))
        Next
        CmbVolverAVerPlanilla.DataSource = ListaItems
        CmbVolverAVerPlanilla.AutoCompleteMode = AutoCompleteMode.Suggest
        CmbVolverAVerPlanilla.AutoCompleteSource = AutoCompleteSource.ListItems
        CmbVolverAVerPlanilla.Show()
        CmbVolverAVerPlanilla.Text = ""
        DgvCartaDev.Rows.Clear()
        Return True

    End Function
    Public Function CargarPLanillasHasta()
        Dim ListaItems As New List(Of String)
        Dim dt As New DataTable
        dt = ConfigCorreo.CN_Correo.CargarPlanillasDev
        For Each drw As DataRow In dt.Rows
            ListaItems.Add(drw("Plani_devo"))
        Next
        CmbHasta.DataSource = ListaItems
        CmbHasta.AutoCompleteMode = AutoCompleteMode.Suggest
        CmbHasta.AutoCompleteSource = AutoCompleteSource.ListItems
        CmbHasta.Show()
        CmbHasta.Text = ""
        Return True

    End Function
    Private Sub BtnGenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGenerar.Click
        If CmbDesde.Text <> "" And CmbHasta.Text <> "" Then
            BtnDevolucionSeprit.Enabled = False
            BtnGenerar.Enabled = False

            BajarDevuelta(CmbDesde.Text, CmbHasta.Text)
            CmbDesde.Text = ""
            CmbHasta.Text = ""

        End If
    End Sub
    Private Sub BajarDevuelta(ByVal NroDesde As String, ByVal NroHasta As String)

        Dim Dt As New DataTable
        Dt = ConfigCorreo.CN_Correo.CargarPlanillasDevParaTxt(NroDesde, NroHasta)

        Dt.Columns.Add("EMPRESA")
        Dt.Columns.Add("SOCIO")
        Dt.Columns.Add("NRO_CART2")
        Dt.Columns.Add("FECHA_RECORRIDO")



        For Each drw As DataRow In Dt.Rows
            Dim DTESN As DataTable
            DTESN = ConfigCorreo.CN_Correo.BuscarEmpresaSocioNrocart2(drw("nro_carta"))
            For Each drw2 As DataRow In DTESN.Rows
                Dim Fechaf As Date
                drw("EMPRESA") = drw2("EMPRESA")
                drw("SOCIO") = drw2("SOCIO")
                drw("NRO_CART2") = drw2("NRO_CART2")
                Fechaf = ConfigCorreo.CN_Correo.ObtenerFechaRecorridoPorCarta(drw("nro_carta"))
                drw("FECHA_RECORRIDO") = Fechaf.ToShortDateString

            Next
        Next
        For Each drw As DataRow In Dt.Rows
            Dim NroCart2 As String = drw("NRO_CART2").ToString

            Dim parts As String() = NroCart2.Split("-"c)
            drw("ASOCIADO") = parts(0).Trim()
            drw("LOTE") = parts(1).Trim()

            If parts.Length > 2 Then
                Dim integrantesList As New List(Of String)()

                ' Agregar cada integrante a la lista
                For i As Integer = 2 To parts.Length - 1
                    integrantesList.Add(parts(i).Trim())
                Next

                ' Unir los integrantes con guiones y asignarlos al campo "INTEGRANTE"
                drw("INTEGRANTE") = String.Join("-", integrantesList)
            End If

            drw("LOTE") = drw("LOTE").ToString().PadLeft(7, "0"c)
        Next


        DgvExcel.DataSource = Dt

        Try
            Dim exApp As New Microsoft.Office.Interop.Excel.Application
            Dim exLibro As Microsoft.Office.Interop.Excel.Workbook
            Dim exHoja As Microsoft.Office.Interop.Excel.Worksheet

            exLibro = exApp.Workbooks.Add
            exHoja = exLibro.Worksheets.Add()
            exHoja.Cells.NumberFormat = "@"

            Dim NCol As Integer = DgvExcel.ColumnCount
            Dim NRow As Integer = DgvExcel.RowCount

            For i As Integer = 1 To NCol
                exHoja.Cells.Item(1, i) = DgvExcel.Columns(i - 1).Name.ToString

            Next

            For Fila As Integer = 0 To NRow - 1
                For Col As Integer = 0 To NCol - 1
                    exHoja.Cells.Item(Fila + 2, Col + 1) = DgvExcel.Rows(Fila).Cells(Col).Value
                Next
            Next
            exHoja.Columns.AutoFit()
            exApp.Application.Visible = False

            Dim NroDevuelta As Integer
            NroDevuelta = ConfigCorreo.CN_Correo.ObtenerNroDevuelta()

            Dim FechaTx As String = Now.ToShortDateString
            FechaTx = FechaTx.Replace("/", "-")
            exLibro.SaveAs("C:\temp\Devolucion_" & NroDevuelta & "_" & FechaTx & ".xls")
            exLibro.Close()




            exHoja = Nothing
            exLibro = Nothing
            exApp = Nothing


            Dim cadena As New System.Text.StringBuilder
            For Each dgw As DataGridViewRow In DgvExcel.Rows
                Dim PrimerosDos As String
                PrimerosDos = dgw.Cells("motivo_devo").Value
                PrimerosDos = PrimerosDos.Substring(0, 2)
                Dim Lote As Integer = dgw.Cells("lote").Value

                cadena.AppendLine(dgw.Cells("asociado").Value & ";" & dgw.Cells("integrante").Value & ";" & Val(Lote) & ";5;" & dgw.Cells("fech_devo").Value & ";" & Val(PrimerosDos))
            Next
            Dim texto As String
            texto = cadena.ToString
            Dim objEscritor As IO.StreamWriter
            objEscritor = IO.File.AppendText("C:\temp\Devolucion_" & NroDevuelta & "_" & FechaTx & ".txt")
            objEscritor.Write(texto)
            objEscritor.Close()

            ConfigCorreo.CN_Correo.ActualizarNroDevuelta(NroDevuelta)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al exportar a Excel")
        End Try


    End Sub
    Private Sub CmbVolverAVerPlanilla_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbVolverAVerPlanilla.TextChanged
        If CmbVolverAVerPlanilla.Text <> "" Then
            If ArrNrosPlanilla.Contains(CmbVolverAVerPlanilla.Text) Then
                DgvCartaDev.Rows.Clear()
                Dim Dtplanilla As DataTable
                Dtplanilla = ConfigCorreo.CN_Correo.ConsultarDevueltas(CmbVolverAVerPlanilla.Text)
                For Each drw As DataRow In Dtplanilla.Rows
                    DgvCartaDev.Rows.Add(drw("asociado").ToString, drw("lote").ToString, drw("integrante").ToString, drw("fech_trab").ToString, drw("tema1").ToString, drw("fecha1").ToString, drw("tema2").ToString, drw("fecha2").ToString, drw("motivo_devo").ToString, drw("fech_devo").ToString, drw("devo_plani").ToString, drw("apellido").ToString, drw("calle").ToString, drw("cp").ToString, drw("localidad").ToString, drw("nro_carta").ToString)
                Next
            End If
        End If
        BtnFinalizar.Enabled = False
    End Sub
    Private Sub DgvCartaDev_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DgvCartaDev.DoubleClick
        Dim N As String = DgvCartaDev.SelectedCells(0).RowIndex.ToString
        Dim STR As String = DgvCartaDev.Rows(N).Cells("Nro_Carta").Value
        Dim STR2 As String = DgvCartaDev.Rows(N).Cells("asociado").Value & "-" & DgvCartaDev.Rows(N).Cells("lote").Value & "-" & DgvCartaDev.Rows(N).Cells("integrante").Value

        If ConfigCorreo.CN_Correo.VerificarCartaEnDevolucion(STR) = True Then
            If MessageBox.Show("Atencion Esta a punto de eliminar la carta nro: " & STR & "", "Seguro Desea Eliminar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If ConfigCorreo.CN_Correo.EliminarCartaDePlanillaDevolucion(STR) = True Then
                    MsgBox("Carta " & STR & " Eliminada")
                    DgvCartaDev.Rows.Remove(DgvCartaDev.Rows(N))
                    ArrNroCartaLeido.Remove(STR)
                    ArrNroCart2Leido.Remove(STR2)
                End If
            End If
        Else
            DgvCartaDev.Rows.Remove(DgvCartaDev.Rows(N))
            ArrNroCartaLeido.Remove(STR)
            ArrNroCart2Leido.Remove(STR2)
        End If


    End Sub

    Private Sub BtnDevolucionSeprit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDevolucionSeprit.Click
        BtnDevolucionSeprit.Enabled = False
        BtnGenerar.Enabled = False
        BajarDevueltaSeprit(CmbDesde.Text, CmbHasta.Text)
        CmbDesde.Text = ""
        CmbHasta.Text = ""
    End Sub
    Private Sub BajarDevueltaSeprit(ByVal NroDesde As String, ByVal NroHasta As String)

        Dim Dt As New DataTable
        Dt = ConfigCorreo.CN_Correo.CargarPlanillasDevParaSeprit(NroDesde, NroHasta)
        Dt.Columns.Add("NRO_CART2")


        For Each drw As DataRow In Dt.Rows
            Dim DTESN As DataTable
            DTESN = ConfigCorreo.CN_Correo.BuscarEmpresaSocioNrocart2(drw("nro_carta"))
            For Each drw2 As DataRow In DTESN.Rows
                drw("NRO_CART2") = drw2("NRO_CART2")
            Next
        Next

        Dt.Columns(7).SetOrdinal(0)


        DgvExcel.DataSource = Dt

        Try
            Dim exApp As New Microsoft.Office.Interop.Excel.Application
            Dim exLibro As Microsoft.Office.Interop.Excel.Workbook
            Dim exHoja As Microsoft.Office.Interop.Excel.Worksheet

            exLibro = exApp.Workbooks.Add
            exHoja = exLibro.Worksheets.Add()
            exHoja.Cells.NumberFormat = "@"

            Dim NCol As Integer = DgvExcel.ColumnCount
            Dim NRow As Integer = DgvExcel.RowCount

            For i As Integer = 1 To NCol
                exHoja.Cells.Item(1, i) = DgvExcel.Columns(i - 1).Name.ToString

            Next

            For Fila As Integer = 0 To NRow - 1
                For Col As Integer = 0 To NCol - 1
                    exHoja.Cells.Item(Fila + 2, Col + 1) = DgvExcel.Rows(Fila).Cells(Col).Value
                Next
            Next
            exHoja.Columns.AutoFit()
            exApp.Application.Visible = False

            'Dim NroDevuelta As Integer
            'NroDevuelta = ConfigCorreo.CN_Correo.ObtenerNroDevuelta()

            Dim FechaTx As String = Now.ToShortDateString
            FechaTx = FechaTx.Replace("/", "-")
            exLibro.SaveAs("C:\temp\Archivo_de_credenciales_swiss_medical_OP118260-1_" & FechaTx & ".xls")
            exLibro.Close()




            exHoja = Nothing
            exLibro = Nothing
            exApp = Nothing



        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al exportar a Excel")
        End Try


    End Sub

    Private Sub ChkFijarMotivo_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ChkFijarMotivo.CheckedChanged
        If ChkFijarMotivo.Checked = True Then
            CmbMotivos.Enabled = False
        Else
            CmbMotivos.Enabled = True
        End If
    End Sub

    Private Sub ChkFijarBarraCliente_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkFijarBarraCliente.CheckedChanged
        If ChkFijarBarraCliente.Checked = True Then
            TxtBarraCliente.Enabled = False
        Else
            TxtBarraCliente.Enabled = True
        End If
    End Sub

    Private Sub ChkFijarcarta_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkFijarcarta.CheckedChanged
        If ChkFijarcarta.Checked = True Then
            TxtCartas.Enabled = False
        Else
            TxtCartas.Enabled = True
        End If
    End Sub

    Private Sub btnAgregarCarta_Click(sender As Object, e As EventArgs) Handles btnAgregarCarta.Click

        BtnNuevo.Visible = False

        LblFecha.Visible = False
        LblNroCarta2.Visible = False
        ChkFijarcarta.Visible = False
        ChkFijarBarraCliente.Visible = False
        ChkFijarMotivo.Visible = False
        BtnNuevo.Visible = False
        TxtBarraCliente.Visible = False
        DtpFechaDevo.Visible = False
        BtnFinalizar.Visible = False
        BtnActualizar.Visible = True
        TxtCartas.Enabled = True
        CmbMotivos.Enabled = True
        TxtPlanillaDevo.Text = CmbVolverAVerPlanilla.Text





    End Sub

    Private Sub CmbVolverAVerPlanilla_SelectedValueChanged(sender As Object, e As EventArgs) Handles CmbVolverAVerPlanilla.SelectedValueChanged
        If CmbVolverAVerPlanilla.Text <> "" Then
            btnAgregarCarta.Visible = True
            TxtCantidad.Text = DgvCartaDev.RowCount
        End If

    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click

        For Each drw As DataGridViewRow In DgvCartaDev.Rows
            Dim NroCarta As String = drw.Cells("nro_carta").Value
            Dim Devoplani As String = TxtPlanillaDevo.Text




            If ConfigCorreo.CN_Correo.NumeroCartaYaIngresadoEnDevolucion(NroCarta) = False Then

                ConfigCorreo.CN_Correo.InsertarDevolucionDetalle(drw.Cells("asociado").Value, drw.Cells("lote").Value, drw.Cells("integrante").Value, drw.Cells("fech_trab").Value, drw.Cells("tema1").Value, drw.Cells("fecha1").Value, drw.Cells("tema2").Value, drw.Cells("fecha2").Value, drw.Cells("motivo_devo").Value, drw.Cells("fech_devo").Value, Devoplani, drw.Cells("apellido").Value, drw.Cells("calle").Value, drw.Cells("cp").Value, drw.Cells("localidad").Value, drw.Cells("nro_carta").Value)
                ConfigCorreo.CN_Correo.ActualizarEstadoDevolucion(drw.Cells("nro_carta").Value)
                ConfigCorreo.CN_Correo.ActualizarCantidadEnPlanillaDeDevolucion(TxtPlanillaDevo.Text)

            End If

        Next
        DgvCartaDev.Rows.Clear()
        ArrNroCartaLeido.Clear()
        ArrNroCart2Leido.Clear()
        CargarPLanillasDesde()
        CargarPLanillasHasta()
        CargarPlanillaParaVolver()


    End Sub


End Class
