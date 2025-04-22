Imports ConfigCorreo.CN_Correo
Imports Microsoft.Office.Interop
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
        CargarDatosPlanillas()
    End Sub

    Private Function CargarDatosPlanillas()
        cargarrecorridos("")
        Dim ArrayCarteros As New ArrayList
        ArrayCarteros = ConfigCorreo.CN_Correo.CargarCarteros
        Cmbcambiar.Items.Clear()
        Cmbcambiar.Enabled = True
        For i As Integer = 0 To ArrayCarteros.Count - 1
            Cmbcambiar.Items.Add(ArrayCarteros.Item(i).ToString)
        Next
    End Function



    Private Sub BtnImpresion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnImpresion.Click

        If DgvContenido.RowCount > 0 Then
            crearexcel(txtrecorrido.Text, txcaminante.Text, txtzona.Text, "SWISS", txcantidad.Text, txtfecha.Text, dtn)
        End If

    End Sub
    Private Sub DtpFecha_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DtpFecha.TextChanged
        cargarrecorridos(DtpFecha.Value.ToShortDateString)
    End Sub
    Private Sub BtnImprimirPlanillasFecha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnImprimirPlanillasFecha.Click
        crearexcelplanillasdiarias(DtpFecha.Value.ToShortDateString)
    End Sub
    Private Function cargarrecorridos(ByVal Fechastr As String) As Boolean
        Try
            ' Obtener las planillas desde la base de datos online
            Dim planillasOnline As List(Of String) = ObtenerPlanillasRecorrido()

            DgvRecorridos.Rows.Clear()
            Dim dtrecorridos As New DataTable

            ' Cargar los recorridos según si hay fecha o no
            If Fechastr = "" Then
                dtrecorridos = ConfigCorreo.CN_Correo.CargarRecorridospl()
            Else
                dtrecorridos = ConfigCorreo.CN_Correo.CargarRecorridosplFecha(Fechastr)
            End If

            ' Llenar el DataGridView
            For Each drw As DataRow In dtrecorridos.Rows
                Dim fech As Date = drw("fecharecorrido").ToString
                Dim nroPlanilla As String = drw("nroplanilla").ToString

                ' Agregar la fila
                Dim rowIndex As Integer = DgvRecorridos.Rows.Add(
                nroPlanilla,
                drw("cartero").ToString,
                fech.ToShortDateString,
                drw("zona").ToString,
                drw("cantidad").ToString
            )
            Next

            ' Aplicar formato a las filas
            PintarFilas(Fechastr, planillasOnline)

            ' Limpiar los controles
            DgvContenido.DataSource = Nothing
            txcaminante.Text = ""
            txcantidad.Text = ""
            txtcliente.Text = ""
            txtfecha.Text = ""
            txtrecorrido.Text = ""
            txtzona.Text = ""

            Return True
        Catch ex As System.Exception
            MsgBox("Error al cargar recorridos: " & ex.Message)
            Return False
        End Try
    End Function

    Private Sub PintarFilas(ByVal Fechastr As String, ByVal planillasOnline As List(Of String))
        For Each row As DataGridViewRow In DgvRecorridos.Rows
            Dim nroPlanilla As String = row.Cells(0).Value.ToString()
            Dim fech As String = row.Cells(2).Value.ToString()

            ' Si no hay filtro de fecha o la fecha coincide
            If Fechastr = "" OrElse Fechastr = fech Then
                ' Verificar si la planilla está en la base online
                If planillasOnline.Contains(nroPlanilla) Then
                    ' Marcar la fila en verde
                    row.DefaultCellStyle.BackColor = Color.LightGreen
                End If
            End If
        Next
    End Sub


    Private Sub crearexcel(ByVal NroRecorrido As String, ByVal caminante As String, ByVal zona As String,
                      ByVal cliente As String, ByVal Cantidad As String, ByVal fecharecorrido As String,
                      ByVal dtn As DataTable)

        Dim exApp As New Microsoft.Office.Interop.Excel.Application
        Dim exLibro As Microsoft.Office.Interop.Excel.Workbook
        Dim exHoja As Microsoft.Office.Interop.Excel.Worksheet

        Try
            exLibro = exApp.Workbooks.Add
            exHoja = exLibro.Worksheets.Add()
            exHoja.Cells.NumberFormat = "@"
            exApp.ActiveWindow.DisplayGridlines = False

            '--- Configuración de página ---
            exHoja.PageSetup.Orientation = Microsoft.Office.Interop.Excel.XlPageOrientation.xlPortrait
            exHoja.PageSetup.Zoom = False
            exHoja.PageSetup.FitToPagesWide = 1
            exHoja.PageSetup.FitToPagesTall = False

            '--- Encabezado centrado ---
            exHoja.Range("B1:G3").Merge()
            exHoja.Cells.Item(1, 2) = "PLANILLA DE RECORRIDO"
            exHoja.Cells.Item(1, 2).Font.Bold = True
            exHoja.Cells.Item(1, 2).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            exHoja.Cells.Item(1, 2).Font.Size = 14

            '--- Datos principales centrados ---
            exHoja.Cells.Item(5, 2) = "Recorrido:"
            exHoja.Cells.Item(5, 3) = NroRecorrido
            exHoja.Cells.Item(5, 5) = "Caminante:"
            exHoja.Cells.Item(5, 6) = caminante
            exHoja.Cells.Item(6, 5) = "Zona:"
            exHoja.Cells.Item(6, 6) = zona
            exHoja.Cells.Item(7, 2) = "Cliente:"
            exHoja.Cells.Item(7, 3) = cliente
            exHoja.Range("B7:D7").BorderAround()

            '--- Ajuste de tamaños de columnas ---
            exHoja.Columns("A:A").ColumnWidth = 1  'Columna margen izquierdo
            exHoja.Columns("B:B").ColumnWidth = 5  'Columna para números correlativos (3 dígitos)
            exHoja.Columns("C:C").ColumnWidth = 10 'Columna para números de carta (6 dígitos)
            exHoja.Columns("D:D").ColumnWidth = 3  'Espacio entre columnas
            exHoja.Columns("E:E").ColumnWidth = 10 'Columna para números correlativos (3 dígitos)
            exHoja.Columns("F:F").ColumnWidth = 10 'Columna para números de carta (6 dígitos)
            exHoja.Columns("G:G").ColumnWidth = 3  'Espacio entre columnas
            exHoja.Columns("H:H").ColumnWidth = 5  'Columna para números correlativos (3 dígitos)
            exHoja.Columns("I:I").ColumnWidth = 10 'Columna para números de carta (6 dígitos)

            '--- Organización de piezas en columnas ---
            Dim itemsPorColumna As Integer = 40
            Dim startRow As Integer = 9
            Dim currentCol As Integer = 2 'Empieza en columna B

            For i As Integer = 0 To dtn.Rows.Count - 1
                Dim currentRow As Integer = startRow + (i Mod itemsPorColumna)

                'Nueva columna cada 40 items
                If i > 0 AndAlso i Mod itemsPorColumna = 0 Then
                    currentCol += 3 'Espacio entre columnas
                End If

                'Número correlativo (3 dígitos)
                exHoja.Cells.Item(currentRow, currentCol) = (i + 1).ToString().PadLeft(3, "0"c)
                exHoja.Cells.Item(currentRow, currentCol).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight

                'Número de carta (6 dígitos)
                exHoja.Cells.Item(currentRow, currentCol + 1) = dtn.Rows(i)("nro_carta").ToString()
                exHoja.Cells.Item(currentRow, currentCol + 1).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

                'Bordes para mejor legibilidad
                exHoja.Range(exHoja.Cells.Item(currentRow, currentCol), exHoja.Cells.Item(currentRow, currentCol + 1)).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
            Next

            '--- Pie de página ---
            Dim lastRow As Integer = startRow + Math.Min(itemsPorColumna, dtn.Rows.Count) + 2
            exHoja.Cells.Item(lastRow, 2) = "Total Piezas:"
            exHoja.Cells.Item(lastRow, 3) = Cantidad
            exHoja.Cells.Item(lastRow + 2, 2) = "Firma y Aclaración:"
            exHoja.Cells.Item(lastRow + 2, 3) = "_________________________"
            exHoja.Cells.Item(lastRow + 3, 2) = "Fecha: " & fecharecorrido

            '--- Ajustes finales ---
            exHoja.Rows("1:100").RowHeight = 15 'Ajuste uniforme
            exApp.Visible = True

            'Liberar recursos
            ReleaseObject(exHoja)
            ReleaseObject(exLibro)
            ReleaseObject(exApp)

        Catch ex As System.Exception
            MsgBox("Error al generar Excel: " & ex.Message, MsgBoxStyle.Critical)
            If exApp IsNot Nothing Then exApp.Quit()
            ReleaseObject(exHoja)
            ReleaseObject(exLibro)
            ReleaseObject(exApp)
        End Try
    End Sub


    'Private Sub crearexcel(ByVal NroRecorrido As String, ByVal caminante As String, ByVal zona As String,
    '                  ByVal cliente As String, ByVal Cantidad As String, ByVal fecharecorrido As String,
    '                  ByVal dtn As DataTable)

    '    Dim exApp As New Microsoft.Office.Interop.Excel.Application
    '    Dim exLibro As Microsoft.Office.Interop.Excel.Workbook
    '    Dim exHoja As Microsoft.Office.Interop.Excel.Worksheet

    '    Try
    '        exLibro = exApp.Workbooks.Add
    '        exHoja = exLibro.Worksheets.Add()
    '        exHoja.Cells.NumberFormat = "@"
    '        exApp.ActiveWindow.DisplayGridlines = False

    '        '--- Configuración de página ---
    '        exHoja.PageSetup.Orientation = Microsoft.Office.Interop.Excel.XlPageOrientation.xlPortrait 'Vertical
    '        exHoja.PageSetup.Zoom = False
    '        exHoja.PageSetup.FitToPagesWide = 1
    '        exHoja.PageSetup.FitToPagesTall = False 'Permite múltiples páginas si es necesario

    '        '--- Encabezado ---
    '        exHoja.Range("A1:D3").Merge()
    '        exHoja.Cells.Item(1, 1) = "PLANILLA DE RECORRIDO"
    '        exHoja.Cells.Item(1, 1).Font.Bold = True
    '        exHoja.Cells.Item(1, 1).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

    '        '--- Datos principales ---
    '        exHoja.Cells.Item(5, 1) = "Recorrido:"
    '        exHoja.Cells.Item(5, 2) = NroRecorrido
    '        exHoja.Cells.Item(5, 4) = "Caminante:"
    '        exHoja.Cells.Item(5, 5) = caminante
    '        exHoja.Cells.Item(6, 4) = "Zona:"
    '        exHoja.Cells.Item(6, 5) = zona
    '        exHoja.Cells.Item(7, 1) = "Cliente:"
    '        exHoja.Cells.Item(7, 2) = cliente
    '        exHoja.Range("A7:D7").BorderAround()

    '        '--- Organización de piezas en columnas ---
    '        Dim itemsPorColumna As Integer = 40 'Ajusta según fuente/tamaño
    '        Dim startRow As Integer = 9
    '        Dim currentCol As Integer = 1 'Columna A

    '        For i As Integer = 0 To dtn.Rows.Count - 1
    '            Dim currentRow As Integer = startRow + (i Mod itemsPorColumna)

    '            'Nueva columna cada 40 items
    '            If i > 0 AndAlso i Mod itemsPorColumna = 0 Then
    '                currentCol += 3 'Espacio entre columnas
    '            End If

    '            exHoja.Cells.Item(currentRow, currentCol) = (i + 1).ToString() 'Número de orden
    '            exHoja.Cells.Item(currentRow, currentCol + 1) = dtn.Rows(i)("nro_carta").ToString()

    '            'Bordes para mejor legibilidad
    '            exHoja.Range(exHoja.Cells.Item(currentRow, currentCol), exHoja.Cells.Item(currentRow, currentCol + 1)).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
    '        Next

    '        '--- Pie de página ---
    '        Dim lastRow As Integer = startRow + Math.Min(itemsPorColumna, dtn.Rows.Count) + 2
    '        exHoja.Cells.Item(lastRow, 1) = "Total Piezas:"
    '        exHoja.Cells.Item(lastRow, 2) = Cantidad
    '        exHoja.Cells.Item(lastRow + 2, 1) = "Firma y Aclaración:"
    '        exHoja.Cells.Item(lastRow + 2, 2) = "_________________________"
    '        exHoja.Cells.Item(lastRow + 3, 1) = "Fecha: " & fecharecorrido

    '        '--- Ajustes finales ---
    '        exHoja.Columns("A:Z").AutoFit()
    '        exHoja.Rows("1:100").RowHeight = 15 'Ajuste uniforme

    '        'Mostrar Excel
    '        exApp.Visible = True

    '        'Liberar recursos
    '        ReleaseObject(exHoja)
    '        ReleaseObject(exLibro)
    '        ReleaseObject(exApp)

    '    Catch ex As System.Exception
    '        MsgBox("Error al generar Excel: " & ex.Message, MsgBoxStyle.Critical)
    '        If exApp IsNot Nothing Then exApp.Quit()
    '        ReleaseObject(exHoja)
    '        ReleaseObject(exLibro)
    '        ReleaseObject(exApp)
    '    End Try
    'End Sub

    'Liberar objetos COM
    Private Sub ReleaseObject(ByVal obj As Object)
        Try
            If obj IsNot Nothing Then
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
                obj = Nothing
            End If
        Catch ex As System.Exception
            obj = Nothing
        Finally
            GC.Collect()
            GC.WaitForPendingFinalizers()
        End Try
    End Sub






    'Private Sub crearexcel(ByVal NroRecorrido As String, ByVal caminante As String, ByVal zona As String, ByVal cliente As String, ByVal Cantidad As String, ByVal fecharecorrido As String, ByVal dtn As DataTable)

    '    Dim exApp As New Microsoft.Office.Interop.Excel.Application
    '    Dim exLibro As Microsoft.Office.Interop.Excel.Workbook
    '    Dim exHoja As Microsoft.Office.Interop.Excel.Worksheet

    '    Try

    '        exLibro = exApp.Workbooks.Add
    '        exHoja = exLibro.Worksheets.Add()
    '        exHoja.Cells.NumberFormat = "@"

    '        exApp.ActiveWindow.DisplayGridlines = False


    '        exHoja.Cells.Item(1, 1) = "Recorrido:"
    '        exHoja.Cells.Item(1, 2) = NroRecorrido
    '        exHoja.Cells.Item(2, 2) = NroRecorrido
    '        exHoja.Cells.Item(1, 4) = "Caminante:"
    '        exHoja.Cells.Item(1, 5) = caminante
    '        exHoja.Cells.Item(1, 7) = "Zona"
    '        exHoja.Cells.Item(1, 8) = zona

    '        '**********************************
    '        exHoja.Cells.Item(3, 1) = "Cliente:"
    '        exHoja.Cells.Item(3, 2) = cliente
    '        exHoja.Range("A3:J3").BorderAround()
    '        exHoja.Range("A1:J19").BorderAround()
    '        '**************************************

    '        Dim fila As Integer = 5
    '        Dim colum As Integer = 2
    '        For Each dr As DataRow In dtn.Rows
    '            exHoja.Cells.Item(fila, colum) = dr("nro_carta").ToString
    '            If fila = 14 Then
    '                colum = colum + 1
    '                fila = 4
    '            End If
    '            fila = fila + 1
    '        Next


    '        '***************************************
    '        exHoja.Cells.Item(21, 7) = "Cantidad Piezas:"
    '        exHoja.Cells.Item(21, 8) = Cantidad

    '        exHoja.Cells.Item(24, 2) = "Firma Aclaracion:"
    '        exHoja.Cells.Item(24, 3) = "-----------------"
    '        exHoja.Cells.Item(25, 2) = fecharecorrido

    '        exHoja.PageSetup.Orientation = Microsoft.Office.Interop.Excel.XlPageOrientation.xlLandscape

    '        exHoja.Columns.AutoFit()
    '        exApp.Application.Visible = True

    '        exHoja = Nothing
    '        exLibro = Nothing
    '        exApp = Nothing



    '    Catch ex As System.Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al exportar a Excel")

    '    End Try


    'End Sub



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



        Catch ex As System.Exception
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

        Catch ex As System.Exception
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

        ' Comienza la consulta SQL
        cadena.Append("INSERT INTO recorridos (NRO_CARTA, PLANILLA_RECORRIDO, FECHA_RECORRIDO, CARTERO, ZONA, REMITENTE, TRABAJO, FECHA_TRABAJO, NOMBRE_APELLIDO, CP, CALLE, LOCALIDAD, PROVINCIA, EMPRESA, NRO_CARTA2, FECHAF, ESTADO, MOTIVO) VALUES ")

        For Each drw As DataRow In Dtenviar.Rows
            txtsql = "(" & "'" & If(IsDBNull(drw("NRO_CARTA")), "", drw("NRO_CARTA")) & "' , " _
        & "'" & If(IsDBNull(drw("PLANILLA_RECORRIDO")), "", drw("PLANILLA_RECORRIDO")) & "'" & ", " _
        & "'" & If(IsDBNull(drw("FECHA_RECORRIDO")), "", Converfecha(drw("FECHA_RECORRIDO"))) & "'" & ", " _
        & "'" & If(IsDBNull(drw("CARTERO")), "", drw("CARTERO")) & "'" & ", " _
        & "'" & If(IsDBNull(drw("ZONA")), "", drw("ZONA")) & "'" & ", " _
        & "'" & If(IsDBNull(drw("REMITENTE")), "", drw("REMITENTE")) & "'" & ", " _
        & "'" & If(IsDBNull(drw("TRABAJO")), "", drw("TRABAJO")) & "'" & ", " _
        & "'" & If(IsDBNull(drw("FECHA_TRABAJO")), "", Converfecha(drw("FECHA_TRABAJO"))) & "'" & ", " _
        & "'" & If(IsDBNull(drw("NOMBRE_APELLIDO")), "", drw("NOMBRE_APELLIDO")) & "'" & ", " _
        & "'" & If(IsDBNull(drw("CP")), "", drw("CP")) & "'" & ", " _
        & "'" & If(IsDBNull(drw("CALLE")), "", drw("CALLE")) & "'" & ", " _
        & "'" & If(IsDBNull(drw("LOCALIDAD")), "", drw("LOCALIDAD")) & "'" & ", " _
        & "'" & If(IsDBNull(drw("PROVINCIA")), "", drw("PROVINCIA")) & "'" & ", " _
        & "'" & If(IsDBNull(drw("EMPRESA")), "", drw("EMPRESA")) & "'" & ", " _
        & "'" & If(IsDBNull(drw("NRO_CARTA2")), "", drw("NRO_CARTA2")) & "'" & ", " _
        & "'" & If(IsDBNull(drw("FECHAF")), "", Converfecha(drw("FECHAF"))) & "'" & ", " _
        & "'" & If(IsDBNull(drw("ESTADO")), "", drw("ESTADO")) & "'" & ", " _
        & "'" & If(IsDBNull(drw("MOTIVO")), "", drw("MOTIVO")) & "'" & ")" & ", "

            cadena.Append(txtsql)
        Next

        Dim Archtxt3 As String = cadena.ToString()
        If Len(Archtxt3) > 0 Then
            Archtxt3 = Mid(Archtxt3, 1, Len(Archtxt3) - 2)
        End If


        ' Enviar la consulta al endpoint
        If ConfigCorreo.CN_Correo.InstertarRecorridosWeb(Archtxt3) = True Then
            'MsgBox("OK")
        Else
            MsgBox("Error")
        End If

        CargarDatosPlanillas()

    End Sub



    Private Sub BtnMapeo_Click(sender As Object, e As EventArgs) Handles BtnMapeo.Click
        FrmMapeo.dt2 = dtn
        FrmMapeo.Show()

    End Sub

    Private Sub GpbCartas_Enter(sender As Object, e As EventArgs) Handles GpbCartas.Enter

    End Sub
End Class
