Imports ConfigCorreo.CN_Correo
Public Class FrmImprimirPlanificacion
    Dim dtn As New DataTable
    Dim ArrayRemitentes As New ArrayList


    Private Sub DgvRecorridos_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DgvRecorridos.DoubleClick
        DgvContenido.DataSource = Nothing
        Dim N As String = DgvRecorridos.SelectedCells(0).RowIndex.ToString
        Dim nro As String = DgvRecorridos.Rows(N).Cells("Nro_Recorrido_r").Value
        Dim caminante As String = DgvRecorridos.Rows(N).Cells("Cartero_r").Value
        Dim fecha As String = DgvRecorridos.Rows(N).Cells("Fecha_r").Value
        Dim zona As String = DgvRecorridos.Rows(N).Cells("Zona_r").Value
        Dim cant As String = DgvRecorridos.Rows(N).Cells("Cantidad_r").Value

        txtrecorrido.Text = nro
        txcaminante.Text = caminante
        txtfecha.Text = fecha
        txtzona.Text = zona
        txcantidad.Text = cant

        dtn = ConfigCorreo.CN_Correo.ConsultarRecorridos(nro)
        DgvContenido.DataSource = dtn
        DgvContenido.AutoResizeColumns()

        Dim Remitenter As String = ""

        For Each dr As DataRow In dtn.Rows
            Remitenter = ConfigCorreo.CN_Correo.ObtenerClientePorRemitente(dr("remitente").ToString)
        Next
        txtcliente.Text = Remitenter
        CmbRemitentes.Text = ""
        Dim DtRemitente As New DataTable
        DtRemitente = ConfigCorreo.CN_Correo.ObtenerRemitentesDeRecorrido(nro)

        CmbRemitentes.Items.Clear()
        ArrayRemitentes.Clear()
        For Each dr As DataRow In DtRemitente.Rows
            CmbRemitentes.Items.Add(dr("REMITENTE"))
            ArrayRemitentes.Add(dr("REMITENTE"))
        Next

        CmbRemitentes.Items.Add("TODOS")
        TxtNuevaCarta.Text = ""



    End Sub
    Private Sub FrmImprimirPlanificacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargarrecorridos("")
        Dim ArrayCarteros As New ArrayList
        ArrayCarteros = ConfigCorreo.CN_Correo.CargarCarteros
        Cmbcambiar.Items.Clear()
        Cmbcambiar.Enabled = True
        For i As Integer = 0 To ArrayCarteros.Count - 1
            Cmbcambiar.Items.Add(ArrayCarteros.Item(i).ToString)
        Next
    End Sub
    Private Sub BtnImpresion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnImpresion.Click

        If DgvContenido.RowCount > 0 Then
            crearexcel(txtrecorrido.Text, txcaminante.Text, txtzona.Text, txtcliente.Text, txcantidad.Text, txtfecha.Text, dtn)
        End If

    End Sub
    Private Sub DtpFecha_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DtpFecha.TextChanged
        cargarrecorridos(DtpFecha.Value.ToShortDateString)
    End Sub
    Private Sub BtnImprimirPlanillasFecha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnImprimirPlanillasFecha.Click
        crearexcelplanillasdiarias(DtpFecha.Value.ToShortDateString)
    End Sub
    Private Function cargarrecorridos(ByVal Fechastr As String) As Boolean

        If Fechastr = "" Then

            DgvRecorridos.Rows.Clear()
            Dim dtrecorridos As New DataTable
            dtrecorridos = ConfigCorreo.CN_Correo.CargarRecorridospl()
            For Each drw As DataRow In dtrecorridos.Rows
                Dim fech As Date = drw("fecharecorrido").ToString
                DgvRecorridos.Rows.Add(drw("nroplanilla").ToString, drw("cartero").ToString, fech.ToShortDateString, drw("zona").ToString, drw("cantidad").ToString)
            Next
        Else

            DgvRecorridos.Rows.Clear()
            Dim dtrecorridos As New DataTable
            dtrecorridos = ConfigCorreo.CN_Correo.CargarRecorridosplFecha(Fechastr)
            For Each drw As DataRow In dtrecorridos.Rows
                Dim fech As Date = drw("fecharecorrido").ToString
                If Fechastr = fech Then
                    DgvRecorridos.Rows.Add(drw("nroplanilla").ToString, drw("cartero").ToString, fech.ToShortDateString, drw("zona").ToString, drw("cantidad").ToString)
                End If
            Next
        End If

        DgvContenido.DataSource = Nothing
        txcaminante.Text = ""
        txcantidad.Text = ""
        txtcliente.Text = ""
        txtfecha.Text = ""
        txtrecorrido.Text = ""
        txtzona.Text = ""


    End Function
    Private Sub crearexcel(ByVal NroRecorrido As String, ByVal caminante As String, ByVal zona As String, ByVal cliente As String, ByVal Cantidad As String, ByVal fecharecorrido As String, ByVal dtn As DataTable)

        Dim exApp As New Microsoft.Office.Interop.Excel.Application
        Dim exLibro As Microsoft.Office.Interop.Excel.Workbook
        Dim exHoja As Microsoft.Office.Interop.Excel.Worksheet

        Try

            exLibro = exApp.Workbooks.Add
            exHoja = exLibro.Worksheets.Add()
            exHoja.Cells.NumberFormat = "@"

            exApp.ActiveWindow.DisplayGridlines = False


            exHoja.Cells.Item(1, 1) = "Recorrido:"
            exHoja.Cells.Item(1, 2) = NroRecorrido
            exHoja.Cells.Item(2, 2) = NroRecorrido
            exHoja.Cells.Item(1, 4) = "Caminante:"
            exHoja.Cells.Item(1, 5) = caminante
            exHoja.Cells.Item(1, 7) = "Zona"
            exHoja.Cells.Item(1, 8) = zona

            '**********************************
            exHoja.Cells.Item(3, 1) = "Cliente:"
            exHoja.Cells.Item(3, 2) = cliente
            exHoja.Range("A3:J3").BorderAround()
            exHoja.Range("A1:J19").BorderAround()
            '**************************************

            Dim fila As Integer = 5
            Dim colum As Integer = 2
            For Each dr As DataRow In dtn.Rows
                exHoja.Cells.Item(fila, colum) = dr("nro_carta").ToString
                If fila = 14 Then
                    colum = colum + 1
                    fila = 4
                End If
                fila = fila + 1
            Next


            '***************************************
            exHoja.Cells.Item(21, 7) = "Cantidad Piezas:"
            exHoja.Cells.Item(21, 8) = Cantidad

            exHoja.Cells.Item(24, 2) = "Firma Aclaracion:"
            exHoja.Cells.Item(24, 3) = "-----------------"
            exHoja.Cells.Item(25, 2) = fecharecorrido

            exHoja.PageSetup.Orientation = Microsoft.Office.Interop.Excel.XlPageOrientation.xlLandscape

            exHoja.Columns.AutoFit()
            exApp.Application.Visible = True

            exHoja = Nothing
            exLibro = Nothing
            exApp = Nothing



        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al exportar a Excel")

        End Try


    End Sub
    Private Sub crearexcelplanillasdiarias(ByVal fecha As String)
        Dim dtnpls As New DataTable
        dtnpls.Columns.Add("nro_planilla")
        dtnpls.Columns.Add("cartero")
        dtnpls.Columns.Add("fecha")
        dtnpls.Columns.Add("zona")
        dtnpls.Columns.Add("cantidad")

        For Each drw As DataGridViewRow In DgvRecorridos.Rows
            dtnpls.Rows.Add(drw.Cells("Nro_Recorrido_r").Value, drw.Cells("Cartero_r").Value, drw.Cells("Fecha_r").Value, drw.Cells("Zona_r").Value, drw.Cells("Cantidad_r").Value)
        Next


        Try
            Dim exApp As New Microsoft.Office.Interop.Excel.Application
            Dim exLibro As Microsoft.Office.Interop.Excel.Workbook
            Dim exHoja As Microsoft.Office.Interop.Excel.Worksheet
            exLibro = exApp.Workbooks.Add
            exHoja = exLibro.Worksheets.Add()
            exHoja.Cells.NumberFormat = "@"

            exApp.ActiveWindow.DisplayGridlines = False
            exHoja.Cells.Item(1, 5) = "Planilla diaria:"


            '**********************************
            exHoja.Cells.Item(1, 7) = "Fecha:"
            exHoja.Cells.Item(1, 8) = fecha
            'exHoja.Range("A3:J3").BorderAround()
            'exHoja.Range("A1:J19").BorderAround()
            '**************************************

            Dim fila As Integer = 4

            exHoja.Cells.Item(3, 2) = "FECHA"
            exHoja.Cells.Item(3, 3) = "NRO_PLANILLA"
            exHoja.Cells.Item(3, 4) = "CARTERO"
            exHoja.Cells.Item(3, 5) = "ZONA"
            exHoja.Cells.Item(3, 6) = "CANTIDAD"

            For Each dr As DataRow In dtnpls.Rows
                exHoja.Cells.Item(fila, 2) = dr("fecha").ToString
                exHoja.Cells.Item(fila, 3) = dr("nro_planilla").ToString
                exHoja.Cells.Item(fila, 4) = dr("cartero").ToString
                exHoja.Cells.Item(fila, 5) = dr("zona").ToString
                exHoja.Cells.Item(fila, 6) = dr("cantidad").ToString

                fila = fila + 1
            Next


            exHoja.PageSetup.Orientation = Microsoft.Office.Interop.Excel.XlPageOrientation.xlLandscape
            exHoja.Columns.AutoFit()
            exApp.Application.Visible = True

            exHoja = Nothing
            exLibro = Nothing
            exApp = Nothing



        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al exportar a Excel")

        End Try


    End Sub
    Private Sub BtnCambiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCambiar.Click
        If txtrecorrido.Text <> "" Then
            If Cmbcambiar.Text <> "" Then

                If MessageBox.Show("Cambiar Cartero " & txcaminante.Text & " por " & Cmbcambiar.Text & "", "Cambiar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    ConfigCorreo.CN_Correo.ActualizarCarteroPorCartero(Cmbcambiar.Text, txtrecorrido.Text)
                    cargarrecorridos(DtpFecha.Value.ToShortDateString)
                End If

            End If
        End If
    End Sub
    Private Sub BtnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnImprimir.Click
        If CmbRemitentes.Text <> "TODOS" Then
            If ArrayRemitentes.Contains(CmbRemitentes.Text) Then
                Dim DTrec As New DataTable
                DTrec = ConfigCorreo.CN_Correo.ObtenerRecorridoDeRemitenteYplanilla(txtrecorrido.Text, CmbRemitentes.Text)

                BajarExceldesdeDatatable(DTrec, txtfecha.Text, txcaminante.Text, txtrecorrido.Text)
            End If
        Else

            Dim DTrecpl As New DataTable
            DTrecpl = ConfigCorreo.CN_Correo.ObtenerRecorridoDeplanilla(txtrecorrido.Text)

            BajarExceldesdeDatatable(DTrecpl, txtfecha.Text, txcaminante.Text, txtrecorrido.Text)
        End If
    End Sub
    Public Shared Sub BajarExceldesdeDatatable(ByVal dt As DataTable, ByVal fecha As Date, ByVal Cartero As String, ByVal Planilla As String)

        Try

            'Dim strFile As String = MYFilelocation
            Dim excel As New Microsoft.Office.Interop.Excel.Application
            Dim wBook As Microsoft.Office.Interop.Excel.Workbook
            Dim wSheet As Microsoft.Office.Interop.Excel.Worksheet



            wBook = excel.Workbooks.Add()
            wSheet = wBook.ActiveSheet()
            wSheet.PageSetup.PaperSize = Microsoft.Office.Interop.Excel.XlPaperSize.xlPaperA4
            wSheet.PageSetup.Zoom = 75


            Dim dc As System.Data.DataColumn
            Dim dr As System.Data.DataRow
            Dim colIndex As Integer = 0
            Dim rowIndex As Integer = 3

            excel.Cells(2, 2) = "FECHA: " & fecha.ToShortDateString
            excel.Cells(3, 2) = "CARTERO: " & Cartero
            excel.Cells(1, 1) = "NRO PLANILLA: " & Planilla

            excel.Cells(4, 4) = "FIRMA / LL"
            excel.Cells(4, 5) = "ACLARACION / LD"
            excel.Cells(4, 6) = "DNI / RELACION C/TITULAR"
            excel.Cells(4, 7) = "AVISO / OBSERVACIONES"
            excel.Cells(4, 4).borders.LineStyle = 12
            excel.Cells(4, 5).borders.LineStyle = 12
            excel.Cells(4, 6).borders.LineStyle = 12
            excel.Cells(4, 7).borders.LineStyle = 12




            For Each dc In dt.Columns
                colIndex = colIndex + 1
                excel.Cells(4, colIndex) = dc.ColumnName
                excel.Cells(4, colIndex).borders.LineStyle = 12
            Next

            For Each dr In dt.Rows
                rowIndex = rowIndex + 1
                colIndex = 0
                For Each dc In dt.Columns
                    colIndex = colIndex + 1
                    excel.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
                    excel.Cells(rowIndex + 1, colIndex).borders.LineStyle = 12
                    excel.Cells(rowIndex + 1, colIndex + 1).borders.LineStyle = 12
                    excel.Cells(rowIndex + 1, colIndex + 2).borders.LineStyle = 12
                    excel.Cells(rowIndex + 1, colIndex + 3).borders.LineStyle = 12
                    excel.Cells(rowIndex + 1, colIndex + 4).borders.LineStyle = 12
                Next
            Next

            excel.Cells.RowHeight = 20

            excel.Visible = True
            wSheet.Columns.AutoFit()
            wSheet.Columns("B").ColumnWidth = 45
            wSheet.Columns("A").ColumnWidth = 10



            excel = Nothing
            wBook = Nothing
            wSheet = Nothing

        Catch ex As Exception
            MessageBox.Show("there was an issue Exporting to Excel" & ex.ToString)
        End Try


    End Sub
    Private Sub BtnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAgregar.Click

        If DgvContenido.RowCount > 0 Then



            If TxtNuevaCarta.Text <> "" Then
                Dim DT As New DataTable
                DT = Buscarpornrodecarta(TxtNuevaCarta.Text)


                If DT.Rows.Count > 0 Then


                    If MessageBox.Show("Desea agregar la carta " & DT.Rows(0)("Nro_carta").ToString() & " De la calle " & DT.Rows(0)("Calle").ToString() & " ?", "Se Eliminara de otro recorrido si existe", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then


                        If DT.Rows.Count > 0 Then
                            Dim PlanillaAnt As String
                            PlanillaAnt = ConfigCorreo.CN_Correo.VerificarRecorridoPorCarta(TxtNuevaCarta.Text)
                            If Len(PlanillaAnt) > 0 Then
                                EliminarCartaDeRecorridoPorCartaYPlanilla(TxtNuevaCarta.Text, PlanillaAnt)
                            End If
                            '************************************************
                            For Each drw As DataRow In DT.Rows
                                If IngresarNuevoRecorrido(drw("Nro_carta"), txtrecorrido.Text, txtfecha.Text, txcaminante.Text, txtzona.Text, drw("REMITENTE"),
                                    drw("TRABAJO"), drw("FECH_TRAB"), drw("APELLIDO"), drw("CP"), drw("CALLE"), drw("LOCALIDAD"),
                                    drw("PROVINCIA"), drw("EMPRESA"), drw("NRO_CART2"), ContarCantidadcartasenrecorrido(txtrecorrido.Text) + 1, drw("id")) = True Then
                                    ActualizarCartas(drw("id"))
                                    AgregarUnoAPlanilla(txtrecorrido.Text)
                                    TxtNuevaCarta.Text = ""
                                    cargarrecorridos("")
                                Else
                                    MsgBox("error")
                                End If
                            Next
                        End If
                    End If
                Else

                    Dim PlanillaAnt As String
                    PlanillaAnt = ConfigCorreo.CN_Correo.VerificarRecorridoPorCarta(TxtNuevaCarta.Text)
                    If Len(PlanillaAnt) > 0 Then
                        EliminarCartaDeRecorridoPorCartaYPlanilla(TxtNuevaCarta.Text, PlanillaAnt)
                    End If

                    Dim dtarm As New DataTable
                    dtarm = Buscarpornrodearm(TxtNuevaCarta.Text)

                    If dtarm.Rows.Count > 0 Then
                        For Each dr As DataRow In dtarm.Rows
                            Dim fechtrab As Date = dr.Item("FECH_TRAB")
                            If IngresarNuevoRecorrido(TxtNuevaCarta.Text, txtrecorrido.Text, txtfecha.Text, txcaminante.Text, txtzona.Text, dr.Item("REMITENTE"), dr.Item("TRABAJO"), fechtrab.ToShortDateString, dr.Item("APELLIDO"), dr.Item("CP"), dr.Item("CALLE"), dr.Item("LOCALIDAD"), dr.Item("PROVINCIA"), dr.Item("EMPRESA"), dr.Item("NRO_CART2"), ContarCantidadcartasenrecorrido(txtrecorrido.Text) + 1, dr.Item("ARM")) = True Then
                                TxtNuevaCarta.Text = ""
                                AgregarUnoAPlanilla(txtrecorrido.Text)
                                cargarrecorridos("")
                            End If
                        Next
                    End If


                End If


            End If
        End If

    End Sub

  

    Private Sub BtnSubirRecorrido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSubirRecorrido.Click

        Dim cadena As New System.Text.StringBuilder
        Dim txtsql As String = ""
        Dim Dtenviar As New DataTable

        Dtenviar = ConsultarRecorridosParaEnviarWeb(txtrecorrido.Text)
        For Each drw As DataRow In Dtenviar.Rows


            txtsql = "(" & "'" & drw("NRO_CARTA") & "' , " _
            & "'" & drw("PLANILLA_RECORRIDO") & "'" & ", " _
            & "'" & Converfecha(drw("FECHA_RECORRIDO")) & "'" & ", " _
            & "'" & drw("CARTERO") & "'" & ", " _
            & "'" & drw("ZONA") & "'" & ", " _
            & "'" & drw("REMITENTE") & "'" & ", " _
            & "'" & drw("TRABAJO") & "'" & ", " _
            & "'" & drw("FECHA_TRABAJO") & "'" & ", " _
            & "'" & drw("NOMBRE_APELLIDO") & "'" & ", " _
            & "'" & drw("CALLE") & "'" & ", " _
            & "'" & drw("LOCALIDAD") & "'" & ", " _
            & "'" & drw("PROVINCIA") & "'" & ", " _
            & "'" & drw("EMPRESA") & "'" & ", " _
            & "'" & drw("NRO_CARTA2") & "'" & ", " _
            & "'" & drw("ORDEN_LECT") & "'" & ", " _
            & "'" & drw("NOMBRE_APELLIDO") & "'" & ", " _
            & "'" & drw("ESTADO") & "'" & ", " _
            & "'" & drw("IDENTIFICADOR") & "'" & ", " _
            & "'" & drw("RECORRIDO") & "'" & ")" & ", "

            cadena.Append(txtsql)
        Next

        Dim Archtxt3 As String

        Archtxt3 = cadena.ToString
        If Len(Archtxt3) > 0 Then
            Archtxt3 = Mid(Archtxt3, 1, Len(Archtxt3) - 2)
        End If

        If ConfigCorreo.CN_Correo.InstertarRecorridosWeb(Archtxt3) = True Then
            MsgBox("OK")
        Else
            MsgBox("Error")
        End If


    End Sub



End Class
