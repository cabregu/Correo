Imports System.Data.OleDb
Imports System.Windows.Forms
Imports System.IO
Imports ConfigCorreo.CN_Correo
Imports System.Globalization
Imports System.Threading
Imports System.Text.RegularExpressions

Public Class FrmTransito
    Dim dt2 As New DataTable
    Dim dtnew As New DataTable
    Public path2 As String = ""



    Private Sub BtnExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExcel.Click
        Dim frmOpcion As FrmOpcionesDeTransito
        frmOpcion = Nothing
        If frmOpcion Is Nothing Then
            frmOpcion = New FrmOpcionesDeTransito
            frmOpcion.Show()
            Me.Visible = False
        ElseIf frmOpcion.IsDisposed Then
            Me.Visible = True
        End If
    End Sub
    Public Sub Seleccionar()

        Dim openFD As New OpenFileDialog()
        With openFD
            .Title = "Seleccionar archivos"
            .Filter = "Todos los archivos (*.xls)|*.xls"
            .Multiselect = False
            .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                If impExcel(.FileName) = True Then
                    txtPath.Text = Path.GetFileName(.FileName)
                End If
            Else
                openFD.Dispose()
            End If
        End With

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
                    txtPath.Text = Path.GetFileName(.FileName)
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
            Dim ad As New OleDbDataAdapter("Select * from [" & "Lexs" & "$]", mconn)
            mconn.Open()
            ad.Fill(dt2)
            mconn.Close()

            Dim dcarr As New ArrayList
            For Each dc As DataColumn In dt2.Columns
                dcarr.Add(dc.ColumnName.ToString)
            Next

            If dcarr.Contains("Agrup") And dcarr.Contains("FECHA_ULT_ESTADO") Then
                DgvDatos.DataSource = dt2
                If Not DgvDatos.Columns.Contains("CONTRA") Then
                    DgvDatos.Columns.Add("CONTRA", "CONTRA")
                    DgvDatos.Columns.Add("LOTE", "LOTE")
                End If


                For Each drgv As DataGridViewRow In DgvDatos.Rows
                    drgv.Cells("CONTRA").Value = drgv.Cells("Agrup").Value.ToString.Substring(0, 7)
                    drgv.Cells("LOTE").Value = drgv.Cells("Agrup").Value.ToString.Substring(8, 7).TrimStart("0")
                Next

                If Not DgvDatos.Columns.Contains("NRO_CART2") Then

                    DgvDatos.Columns.Add("NRO_CARTA", "NRO_CARTA")
                    DgvDatos.Columns.Add("REMITENTE", "REMITENTE")
                    DgvDatos.Columns.Add("FECH_TRAB", "FECH_TRAB")
                    DgvDatos.Columns.Add("APELLIDO", "APELLIDO")
                    DgvDatos.Columns.Add("CALLE", "CALLE")
                    DgvDatos.Columns.Add("CP", "CP")
                    DgvDatos.Columns.Add("LOCALIDAD", "LOCALIDAD")
                    DgvDatos.Columns.Add("PROVINCIA", "PROVINCIA")
                    DgvDatos.Columns.Add("FECHA_ENTR", "FECHA_ENTR")
                    DgvDatos.Columns.Add("NRO_PLANIL", "NRO_PLANIL")
                    DgvDatos.Columns.Add("FECH_PLANI", "FECH_PLANI")
                    DgvDatos.Columns.Add("ESTADO", "ESTADO")
                    DgvDatos.Columns.Add("CARTERO", "CARTERO")
                    DgvDatos.Columns.Add("TEMA4", "TEMA4")
                    DgvDatos.Columns.Add("FECH4", "FECH4")
                    DgvDatos.Columns.Add("NRO_CART2", "NRO_CART2")
                End If


            Else
                MsgBox("La columna 'Agrup' y 'FECHA_ULT_ESTADO' es obligatoria contiene los datos para el cruzamiento y analisis")
            End If
            Return True

        Catch ex As Exception
            MsgBox("Archivo incompatible detalle de error : " & ex.ToString)
        End Try




    End Function
    Private Function impExcelOtro(ByVal Archivo As String) As Boolean


        txtPath.Text = Archivo
        Dim strconn As String
        strconn = "Provider=Microsoft.Jet.Oledb.4.0; data source= " + Archivo + ";Extended properties=""Excel 8.0;hdr=yes;imex=1"""
        Dim mconn As New OleDbConnection(strconn)
        Dim ad As New OleDbDataAdapter("Select * from [" & "Lexs" & "$]", mconn)
        mconn.Open()
        ad.Fill(dt2)
        mconn.Close()



        If Not dt2.Columns.Contains("CONTRA") Then


            For Each dr As DataRow In dt2.Rows
                dr("Socio CONTRATO") = Retornode7digitos(dr("Socio CONTRATO").ToString)
                dr("Lote ID") = Retornode7digitos(dr("Lote ID").ToString)
            Next

            dt2.Columns.Add("CONTRA")
            dt2.Columns.Add("LOTE")
            dt2.Columns.Add("NRO_CARTA")
            dt2.Columns.Add("REMITENTE")
            dt2.Columns.Add("FECH_TRAB")
            dt2.Columns.Add("APELLIDO")
            dt2.Columns.Add("CALLE")
            dt2.Columns.Add("CP")
            dt2.Columns.Add("PISO_DEPTO")
            dt2.Columns.Add("LOCALIDAD")
            dt2.Columns.Add("PROVINCIA")
            dt2.Columns.Add("FECHA_ENTR")
            dt2.Columns.Add("NRO_PLANIL")
            dt2.Columns.Add("FECH_PLANI")
            dt2.Columns.Add("ESTADO")
            dt2.Columns.Add("CARTERO")
            dt2.Columns.Add("TEMA4")
            dt2.Columns.Add("FECH4")
            dt2.Columns.Add("OBS2")
            dt2.Columns.Add("NRO_CART2")

            For Each dr As DataRow In dt2.Rows
                dr("CONTRA") = Retornode7digitos(dr("Socio CONTRATO").ToString)
                dr("LOTE") = Retornode7digitos(dr("Lote ID").ToString)
            Next
        End If

        If Not dt2.Columns.Contains("ESTADOF") Then
            dt2.Columns.Add("ESTADOF")
            dt2.Columns.Add("MOTIVOF")
            dt2.Columns.Add("FECHAF")
            dt2.Columns.Add("TIPO")
            dt2.Columns.Add("FECHA_TRABAJO")
            dt2.Columns.Add("FECH1")
            dt2.Columns.Add("HISTORICO")
            dt2.Columns.Add("INFORMADO")
        End If





        DgvDatos.DataSource = dt2



    End Function
    Private Sub Btncargar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If Eliminardatostablatemporal() = True Then

            Dim txtsql As String = ""
            Dim cadena As New System.Text.StringBuilder

            For Each drw As DataRow In dtnew.Rows
                txtsql = "(" & "'" & drw("NRO_CARTA").ToString & "' , " _
                & "'" & drw("REMITENTE").ToString & "'" & ", " _
                & "'" & Converfecha(Normalizar(drw("FECH_TRAB").ToString)) & "'" & ", " _
                & "'" & Normalizar(drw("APELLIDO").ToString) & "'" & ", " _
                & "'" & Normalizar(drw("CALLE".ToString)) & "'" & ", " _
                & "'" & Normalizar(drw("CP").ToString) & "'" & ", " _
                & "'" & drw("LOCALIDAD").ToString & "'" & ", " _
                & "'" & drw("PROVINCIA").ToString & "'" & ", " _
                & "'" & Normalizar(drw("FECHA_ENTR").ToString) & "'" & ", " _
                & "'" & drw("NRO_PLANIL").ToString & "'" & ", " _
                & "'" & Normalizar(drw("FECH_PLANI").ToString) & "'" & ", " _
                & "'" & drw("ESTADO").ToString & "'" & ", " _
                & "'" & drw("CARTERO").ToString & "'" & ", " _
                & "'" & drw("TEMA4").ToString & "'" & ", " _
                & "'" & Normalizar(drw("FECH4").ToString) & "'" & ", " _
                & "'" & drw("NRO_CART2").ToString & "'" & ", " _
                & "'" & drw("NRO_CART2").ToString.Substring(0, 15) & "'" & ")" & ", "
                cadena.Append(txtsql)
            Next

            Dim txtarch As String
            txtarch = cadena.ToString

            If Len(txtarch) > 0 Then
                txtarch = Mid(txtarch, 1, Len(txtarch) - 2)
            End If


            If MessageBox.Show("Desea Actualizar", "Actualizar", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                If ConfigCorreo.CN_Correo.InstertarRegistroTRANSITO(txtarch) = True Then
                    MessageBox.Show("Actualizado OK", "Actualizado OK")
                Else
                    MessageBox.Show("Error", "Error")
                End If
            End If

        End If

    End Sub
    Private Shared Function Normalizar2(ByVal Dato As String) As String

        Dato = Dato.Replace("-", "")
        Dato = Dato.Replace("  ", "")
        Dato = Dato.Replace("30/12/1899", "")
        Dato = Dato.Replace("01/01/0001", "")
        Dato = Dato.Replace(" 0:00:00", "")
        Dato = Dato.Replace("'", "")
        Dato = Dato.Replace(",", "")

        Return Dato
    End Function
    Private Shared Function Convertirfecha(ByVal valor As String) As String
        Try
            Dim año As String = valor.Substring(valor.LastIndexOf("/") + 1, 4)
            Dim mes As String = valor.Substring(3, 2)
            Dim dia As String = valor.Substring(0, 2)
            Dim fecha As String = año & "-" & mes & "-" & dia
            Return fecha
        Catch ex As Exception
            Return "0000-00-00"
        End Try

    End Function

    Private Sub BNBUSCAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BNBUSCAR.Click

        'Desactiva el botón mientras se está procesando
        BNBUSCAR.Enabled = False

        'Inicia un nuevo hilo para ejecutar la tarea en segundo plano
        Dim thread As New Thread(AddressOf ProcesarDatos)
        thread.Start()

    End Sub

    Private Sub ProcesarDatos()
        Dim Numero As Integer = 0
        Me.Invoke(Sub()
                      PgbAnalisis.Minimum = 0
                      PgbAnalisis.Maximum = DgvDatos.Rows.Count
                  End Sub)

        Dim resultados = ConfigCorreo.CN_Correo.ObtenerTodosLosDatosUltimos240Dias()

        For Each DRW As DataGridViewRow In DgvDatos.Rows
            Dim contra As String = DRW.Cells("CONTRA").Value.ToString()
            Dim lote As String = DRW.Cells("lote").Value.ToString().TrimStart("0"c)

            For Each result As KeyValuePair(Of String, String) In resultados
                Dim nroCart2 As String = result.Key
                Dim concatenatedData As String = result.Value

                If nroCart2.Contains(contra) AndAlso nroCart2.Contains(lote) Then
                    Dim values() As String = concatenatedData.Split(";")
                    AsignarValoresCeldas(DRW, values)
                    Numero = Numero + 1
                    Me.Invoke(Sub()
                                  PgbAnalisis.Value = Numero
                              End Sub)
                    Exit For ' Salir del bucle interno si se encontró una coincidencia
                End If
            Next
        Next

        Me.Invoke(Sub()
                      PgbAnalisis.Value = 0
                      BNBUSCAR.Enabled = True
                  End Sub)
    End Sub

    Private Sub AsignarValoresCeldas(DRW As DataGridViewRow, values() As String)
        DRW.Cells("Nro_Carta").Value = values(0)
        DRW.Cells("REMITENTE").Value = values(1)
        DRW.Cells("FECH_TRAB").Value = values(2)
        DRW.Cells("APELLIDO").Value = values(3)
        DRW.Cells("CALLE").Value = values(4)
        DRW.Cells("CP").Value = values(5)
        DRW.Cells("PISO_DEPTO").Value = values(6)
        DRW.Cells("LOCALIDAD").Value = values(7)
        DRW.Cells("PROVINCIA").Value = values(8)
        DRW.Cells("ESTADO").Value = values(9)
        DRW.Cells("OBS2").Value = values(10)
        DRW.Cells("CARTERO").Value = ObtenerCarteroDeCorreoProduccion(values(0))
        DRW.Cells("NRO_CART2").Value = values(11)
        DRW.Cells("TEMA4").Value = ObtenerMotivoDevoDeCorreoProduccion(values(0))
        DRW.Cells("FECH4").Value = ObtenerFechaDevoDeCorreoProduccion(values(0))
    End Sub





    'Private Sub ProcesarDatos()
    '    Dim Numero As Integer = 0
    '    Me.Invoke(Sub()
    '                  PgbAnalisis.Minimum = 0
    '                  PgbAnalisis.Maximum = DgvDatos.Rows.Count
    '              End Sub)

    '    Dim result As String
    '    Dim cache As New Dictionary(Of String, String)() ' Crear un caché para almacenar los resultados ya encontrados

    '    For Each DRW As DataGridViewRow In DgvDatos.Rows
    '        Dim contra As String = DRW.Cells("CONTRA").Value.ToString()
    '        Dim lote As String = DRW.Cells("lote").Value.ToString().TrimStart("0"c)

    '        ' Verificar si ya tenemos el resultado en el caché
    '        If cache.ContainsKey(contra & "-" & lote) Then
    '            Dim cachedResult As String = cache(contra & "-" & lote)
    '            If cachedResult <> "" Then
    '                Dim values() As String = cachedResult.Split(";")
    '                AsignarValoresCeldas(DRW, values)
    '                Numero = Numero + 1
    '                Me.Invoke(Sub()
    '                              PgbAnalisis.Value = Numero
    '                          End Sub)
    '            End If
    '        Else
    '            ' Si no está en caché, realizar la búsqueda y almacenar el resultado en caché
    '            result = ConfigCorreo.CN_Correo.ObtenerPorNrocartaCorreoProduccion(contra, lote)
    '            cache(contra & "-" & lote) = result ' Almacenar el resultado en caché

    '            If result <> "" Then
    '                Dim values() As String = result.Split(";")
    '                AsignarValoresCeldas(DRW, values)
    '                Numero = Numero + 1
    '                Me.Invoke(Sub()
    '                              PgbAnalisis.Value = Numero
    '                          End Sub)
    '            End If
    '        End If
    '    Next



    '    Me.Invoke(Sub()
    '                  PgbAnalisis.Value = 0
    '                  BNBUSCAR.Enabled = True
    '              End Sub)
    'End Sub

    'Private Sub AsignarValoresCeldas(DRW As DataGridViewRow, values() As String)
    '    DRW.Cells("Nro_Carta").Value = values(0)
    '    DRW.Cells("REMITENTE").Value = values(1)
    '    DRW.Cells("FECH_TRAB").Value = values(2)
    '    DRW.Cells("APELLIDO").Value = values(3)
    '    DRW.Cells("CALLE").Value = values(4)
    '    DRW.Cells("CP").Value = values(5)
    '    DRW.Cells("PISO_DEPTO").Value = values(6)
    '    DRW.Cells("LOCALIDAD").Value = values(7)
    '    DRW.Cells("PROVINCIA").Value = values(8)
    '    DRW.Cells("ESTADO").Value = values(9)
    '    DRW.Cells("OBS2").Value = values(10)
    '    DRW.Cells("CARTERO").Value = ObtenerCarteroDeCorreoProduccion(values(0))
    '    DRW.Cells("NRO_CART2").Value = values(11)
    '    DRW.Cells("TEMA4").Value = ObtenerMotivoDevoDeCorreoProduccion(values(0))
    '    DRW.Cells("FECH4").Value = ObtenerFechaDevoDeCorreoProduccion(values(0))
    'End Sub

    Private Function BuscarEntregadasPlanilladasvisitadasRecorrido(ByVal Carta As String) As String
        Dim EstadoEnRecorrido As String
        Dim EstadoEnPlanilladas As String
        Dim EstadoEnEntregadas As String
        Dim EstadoEnVisitadas As String
        Dim EstadoEnTransito As String

        EstadoEnRecorrido = ObtenerEstadoenRecorrido(Carta)
        EstadoEnPlanilladas = ObtenerEstadoenPlanilladas(Carta)
        EstadoEnEntregadas = ObtenerEstadoenentregadas(Carta)
        EstadoEnVisitadas = ObtenerEstadoenVisitadas(Carta)
        EstadoEnTransito = ObtenerEstadoenTransito(Carta)

        Return EstadoEnRecorrido & "-" & EstadoEnPlanilladas & "-" & EstadoEnEntregadas & "-" & EstadoEnVisitadas & "-" & EstadoEnTransito


    End Function

    Private Sub BtnEstados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEstados.Click
        FechasEntregadas()

    End Sub

    Private Sub Btnexcel2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnexcel2.Click
        ExportarDataGridViewAExcel(DgvDatos)
    End Sub
    'Private Sub ExportarDataGridViewAExcel(ByVal dgv As DataGridView)
    '    Try
    '        ' Crear una nueva instancia de Excel
    '        Dim exApp As Object = CreateObject("Excel.Application")
    '        exApp.Visible = True

    '        ' Crear un nuevo libro y una nueva hoja
    '        Dim exLibro As Object = exApp.Workbooks.Add()
    '        Dim exHoja As Object = exLibro.Worksheets.Add()

    '        ' Establecer el formato de todas las celdas como texto
    '        exHoja.Cells.NumberFormat = "@"

    '        ' Obtener el número de filas y columnas
    '        Dim NCol As Integer = dgv.ColumnCount
    '        Dim NRow As Integer = dgv.RowCount

    '        ' Copiar los nombres de las columnas al libro
    '        Dim rg As Object = exHoja.Range(exHoja.Cells(1, 1), exHoja.Cells(1, NCol))
    '        rg.Value = dgv.Columns.Cast(Of DataGridViewColumn).Select(Function(c) c.HeaderText).ToArray()

    '        ' Copiar los datos del DataGridView al libro
    '        Dim data(NRow - 1, NCol - 1) As Object
    '        For i As Integer = 0 To NRow - 1
    '            For j As Integer = 0 To NCol - 1
    '                data(i, j) = dgv.Rows(i).Cells(j).Value
    '            Next
    '        Next
    '        rg = exHoja.Range(exHoja.Cells(2, 1), exHoja.Cells(NRow + 1, NCol))
    '        rg.Value = data

    '        ' Ajustar el ancho de las columnas para que se ajusten al contenido
    '        rg = exHoja.Range(exHoja.Cells(1, 1), exHoja.Cells(NRow + 1, NCol))
    '        rg.EntireColumn.AutoFit()


    '        MsgBox("Datos exportados exitosamente a Excel.", MsgBoxStyle.Information, "Exportar a Excel")

    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al exportar a Excel")
    '    End Try
    'End Sub

    Private Sub ExportarDataGridViewAExcel(ByVal dgv As DataGridView)
        Try
            ' Crear una nueva instancia de Excel
            Dim exApp As Object = CreateObject("Excel.Application")
            exApp.Visible = True

            ' Crear un nuevo libro y una nueva hoja
            Dim exLibro As Object = exApp.Workbooks.Add()
            Dim exHoja As Object = exLibro.Worksheets.Add()

            ' Establecer el formato de todas las celdas como texto
            exHoja.Cells.NumberFormat = "@"

            ' Obtener el número de filas y columnas
            Dim NCol As Integer = dgv.ColumnCount
            Dim NRow As Integer = dgv.RowCount

            ' Copiar los nombres de las columnas al libro
            Dim rg As Object = exHoja.Range(exHoja.Cells(1, 1), exHoja.Cells(1, NCol))
            rg.Value = dgv.Columns.Cast(Of DataGridViewColumn).Select(Function(c) c.HeaderText).ToArray()

            ' Copiar los datos del DataGridView al libro
            Dim data(NRow - 1, NCol - 1) As Object
            For i As Integer = 0 To NRow - 1
                For j As Integer = 0 To NCol - 1
                    ' Verificar si el tipo de dato es DateTime (fecha)
                    If TypeOf dgv.Rows(i).Cells(j).Value Is DateTime Then
                        data(i, j) = DirectCast(dgv.Rows(i).Cells(j).Value, DateTime).ToString("dd-MM-yyyy")
                    Else
                        data(i, j) = dgv.Rows(i).Cells(j).Value
                    End If
                Next
            Next

            rg = exHoja.Range(exHoja.Cells(2, 1), exHoja.Cells(NRow + 1, NCol))
            rg.Value = data

            ' Ajustar el ancho de las columnas para que se ajusten al contenido
            rg = exHoja.Range(exHoja.Cells(1, 1), exHoja.Cells(NRow + 1, NCol))
            rg.EntireColumn.AutoFit()

            MsgBox("Datos exportados exitosamente a Excel.", MsgBoxStyle.Information, "Exportar a Excel")

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al exportar a Excel")
        End Try
    End Sub


    Private Sub ExportarDataGridViewAExcel(ByVal dgv As DataGridView, ByVal camposSeleccionados() As String)
        Try
            ' Crear una nueva instancia de Excel
            Dim exApp As Object = CreateObject("Excel.Application")
            exApp.Visible = True

            ' Crear un nuevo libro y una nueva hoja
            Dim exLibro As Object = exApp.Workbooks.Add()
            Dim exHoja As Object = exLibro.Worksheets.Add()

            ' Establecer el formato de todas las celdas como texto
            exHoja.Cells.NumberFormat = "@"

            ' Obtener el número de filas y columnas
            Dim NCol As Integer = camposSeleccionados.Length
            Dim NRow As Integer = dgv.RowCount

            ' Copiar los nombres de las columnas seleccionadas al libro
            Dim rg As Object = exHoja.Range(exHoja.Cells(1, 1), exHoja.Cells(1, NCol))
            For i As Integer = 0 To NCol - 1
                rg.Cells(1, i + 1).Value = camposSeleccionados(i)
            Next

            ' Copiar los datos seleccionados del DataGridView al libro
            Dim data(NRow - 1, NCol - 1) As Object
            For i As Integer = 0 To NRow - 1
                For j As Integer = 0 To NCol - 1
                    data(i, j) = dgv.Rows(i).Cells(camposSeleccionados(j)).Value
                Next
            Next
            rg = exHoja.Range(exHoja.Cells(2, 1), exHoja.Cells(NRow + 1, NCol))
            rg.Value = data

            ' Ajustar el ancho de las columnas para que se ajusten al contenido
            rg = exHoja.Range(exHoja.Cells(1, 1), exHoja.Cells(NRow + 1, NCol))
            rg.EntireColumn.AutoFit()

            ' Guardar el archivo de Excel y cerrar la aplicación de Excel
            'exLibro.SaveAs("C:\temp\Transito.xls")
            'exLibro.Close(True)
            'exApp.Quit()

            MsgBox("Datos exportados exitosamente a Excel.", MsgBoxStyle.Information, "Exportar a Excel")

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al exportar a Excel")
        End Try
    End Sub
    Private Sub FrmTransito_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtPath.Text = path2

    End Sub
    Private Shared Function Normalizar(ByVal Dato As String) As String
        Dato = Dato.Replace("-", "")
        Dato = Dato.Replace("(", "")
        Dato = Dato.Replace(")", "")
        Dato = Dato.Replace("  ", "")
        Dato = Dato.Replace("30/12/1899", "")
        Dato = Dato.Replace("01/01/0001", "")
        Dato = Dato.Replace(" 0:00:00", "")
        Dato = Dato.Replace("'", "")
        Dato = Dato.Replace(",", "")
        Dato = Dato.Replace("12:00:00 a.m.", "")

        Return Dato
    End Function
    Private Sub Estados()

        For Each drw As DataGridViewRow In DgvDatos.Rows
            Dim estado As Object = drw.Cells("ESTADO").Value

            If estado IsNot DBNull.Value AndAlso estado IsNot Nothing Then
                Select Case estado.ToString()
                    Case "DEVO_SUCU", "PARA_DEVOLUCION"
                        drw.Cells("ESTADOF").Value = "EN_DEVOLUCION"
                    Case "ENTRE_SUCU", "ENTREGADA", "PLANILLADA"
                        drw.Cells("ESTADOF").Value = "ENTREGADA"
                    Case "EN_DISTRIBUCION", "PARA_REPROGRAMACION", "ESP_PROG"
                        drw.Cells("ESTADOF").Value = "EN_RENDICION"
                    Case "DEVUELTA"
                        drw.Cells("ESTADOF").Value = "DEVUELTA"
                        drw.Cells("MOTIVOF").Value = drw.Cells("TEMA4").Value
                        drw.Cells("FECHAF").Value = drw.Cells("FECH4").Value
                    Case ""
                        drw.Cells("ESTADOF").Value = "NO_HAY_INGRESO"
                End Select
            Else
                drw.Cells("ESTADOF").Value = "NO_HAY_INGRESO"
            End If
        Next




    End Sub
    Private Sub EntregadasCod13()
        For Each drgw As DataGridViewRow In DgvDatos.Rows
            If drgw.Cells("ESTADOF").Value = "EN_DEVOLUCION" Then
                drgw.Cells("TIPO").Value = BuscarContra(drgw.Cells("CONTRA").Value)
            End If
        Next
    End Sub
    Private Sub FechasEntregadas()
        Try


            ''***************************************VISITADAS**********************************************
            'Dim FechaV As String
            'Dim Fechavisit As Date = Now.ToShortDateString
            'Fechavisit = Fechavisit.ToShortDateString
            'Fechavisit = Fechavisit.AddDays(-40)
            'FechaV = Converfecha(Fechavisit)

            'Dim dtvisitadas As New DataTable
            'dtvisitadas = ObtenerVisit(Converfecha(FechaV))
            'For Each dr As DataRow In dtvisitadas.Rows
            '    For Each drdgw As DataGridViewRow In DgvDatos.Rows
            '        If Not IsDBNull(drdgw.Cells("nro_carta").Value) Then
            '            If drdgw.Cells("nro_carta").Value = dr("nro_carta") Then
            '                drdgw.Cells("fech1").Value = dr("fech1")
            '            End If
            '        End If
            '    Next
            'Next
            '*************************************************************************************


            For Each DRG As DataGridViewRow In DgvDatos.Rows
                '*************************************************************************************
                If DRG.Cells("ESTADOF").Value = "ENTREGADA" Or DRG.Cells("ESTADOF").Value = "ENT_COD13" Then
                    Dim fechaF As Date = Nothing
                    Dim FECHA_ULT_ESTADO As Date = Nothing


                    fechaF = DRG.Cells("FECH_TRAB").Value
                    FECHA_ULT_ESTADO = DRG.Cells("FECHA_ULT_ESTADO").Value

                    fechaF = fechaF.ToShortDateString
                    FECHA_ULT_ESTADO = FECHA_ULT_ESTADO.ToShortDateString


                    Dim FECH1 As Date = Nothing
                    If Not IsDBNull(DRG.Cells("fech1").Value) Then
                        If DRG.Cells("fech1").Value <> "" Then
                            FECH1 = DRG.Cells("fech1").Value
                        End If
                    End If

                    If Not IsDBNull(DRG.Cells("CP").Value) Then
                        '***********ADICIONAL SI TIENE CODIGO POSTAL******************************
                        fechaF = fechaF.AddDays(ObtenerCantDiasCP(DRG.Cells("CP").Value))
                    Else
                        fechaF = fechaF.AddDays(3)
                        '*****FIJO 3 DIAS DESDE FECH_TRAB SI NO TIENE CODIGO POSTAL ****************

                    End If


                    fechaF = fechaF.ToShortDateString
                    fechaF = AgregardiaFeriado(fechaF)
                    '*****AGREGAR FERIADO****
                    If FECH1 <> Nothing Then
                        If fechaF <= FECH1 Then
                            fechaF = FECH1.AddDays(2)
                        End If
                    End If


                    If fechaF <= FECHA_ULT_ESTADO Then
                        '*****AGREGAR DIAS DESDE FECHA ULTIMO ESTADO SWISS
                        fechaF = FECHA_ULT_ESTADO.AddDays(2)
                    End If


                    fechaF = Sabadoydomingo(fechaF)
                    '****SABADO Y DOMINGO 

                    If fechaF > Now.ToShortDateString Then
                        fechaF = Now.ToShortDateString
                    End If

                    Dim entregada As String = ""
                    'entregada = BuscarEntregadapornrodecarta(DRG.Cells("Nro_carta").Value)

                    If entregada <> "" Then
                        DRG.Cells("FECHAF").Value = fechaF.ToShortDateString

                        'MsgBox(entregada & "-" & fechaF.ToShortDateString)
                    Else
                        DRG.Cells("FECHAF").Value = fechaF.ToShortDateString
                    End If


                End If
                '**********************************************************

            Next



        Catch ex As Exception

        End Try




    End Sub
    Private Sub FechasEntregadasReales()

        For Each DRG As DataGridViewRow In DgvDatos.Rows
            Dim fechaF As Date = Nothing
            Dim FECHA_ULT_ESTADO As Date = Nothing

            If DRG.Cells("ESTADOF").Value = "ENTREGADA" Or DRG.Cells("ESTADOF").Value = "ENT_COD13" Then

                If Not IsDBNull(DRG.Cells("FECH_TRAB").Value) Then
                    fechaF = DRG.Cells("FECH_TRAB").Value
                Else
                    fechaF = Now.ToShortDateString
                End If



                FECHA_ULT_ESTADO = DRG.Cells("Fecha Ultimo Estado DESC").Value

                fechaF = fechaF.ToShortDateString
                FECHA_ULT_ESTADO = FECHA_ULT_ESTADO.ToShortDateString


                Dim FECH1 As Date = Nothing
                If Not IsDBNull(DRG.Cells("fech1").Value) Then
                    Try
                        If DRG.Cells("fech1").Value <> "" Then
                            FECH1 = DRG.Cells("fech1").Value
                        End If
                    Catch ex As Exception

                    End Try

                End If

                fechaF = fechaF.ToShortDateString
                fechaF = AgregardiaFeriado(fechaF)

                ''*****AGREGAR FERIADO****
                If FECH1 <> Nothing Then
                    If fechaF <= FECH1 Then
                        fechaF = FECH1.AddDays(2)
                    End If
                End If

                'Dim Fechatransito As Date = VerificarSiFueEntregadaEnTransito(DRG.Cells("contra").Value, DRG.Cells("lote").Value)
                Dim FechaEntregada As Date = VerificarSiFueEntregadaEnDiario(DRG.Cells("contra").Value, DRG.Cells("lote").Value)

                'If Fechatransito <> Nothing Then
                '    If Fechatransito > FECHA_ULT_ESTADO Then
                '        fechaF = Fechatransito
                '        DRG.Cells("INFORMADO").Value = Fechatransito & " EN TRANSITO"
                '    End If
                'End If

                If FechaEntregada > Nothing Then
                    If FechaEntregada > FECHA_ULT_ESTADO Then
                        fechaF = FechaEntregada
                        DRG.Cells("INFORMADO").Value = FechaEntregada & "EN DIARIO"
                    End If
                End If


                If fechaF <= FECHA_ULT_ESTADO Then
                    '*****AGREGAR DIAS DESDE FECHA ULTIMO ESTADO SWISS
                    fechaF = FECHA_ULT_ESTADO.AddDays(2)
                End If


                fechaF = Sabadoydomingo(fechaF)
                '****SABADO Y DOMINGO 

                If fechaF > Now.ToShortDateString Then
                    fechaF = Now.ToShortDateString
                End If
            End If


            DRG.Cells("FECHAF").Value = Normalizar(fechaF.ToShortDateString)


            If DRG.Cells("ESTADOF").Value = "DEVUELTA" Then
                DRG.Cells("MOTIVOF").Value = DRG.Cells("TEMA4").Value
                DRG.Cells("FECHAF").Value = DRG.Cells("FECH4").Value
            End If
        Next



    End Sub
    Private Function DiferenciaFechas(ByVal fecha_swiss As Date, ByVal Fecha_lexs As Date) As String

        If (DateDiff(DateInterval.Day, fecha_swiss, Fecha_lexs)) > 2 Then
            Return "DIF_FECHAS_PARA_ANALIZAR"
        Else
            Return ""
        End If




    End Function
    Private Function DiferenciaFechasSwissLexs(ByVal fecha_swiss As Date, ByVal Fecha_lexs As Date) As Date

        If DateDiff(DateInterval.Day, Fecha_lexs, fecha_swiss) < 1 Then
            fecha_swiss = fecha_swiss.AddDays(1)
            Return fecha_swiss
        Else
            Return Fecha_lexs
        End If



    End Function
    Private Sub BtnAnalisisEstados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAnalisisEstados.Click


        Estados()

        For Each drw As DataGridViewRow In DgvDatos.Rows
            Dim FechaVisitada As String = Normalizar(VerificarSiFueVisitada(drw.Cells("contra").Value, drw.Cells("lote").Value))
            drw.Cells("FECH1").Value = FechaVisitada

            Try
                drw.Cells("INFORMADO").Value = ObtenerEstadoenTransito(drw.Cells("Nro_Carta").Value)

            Catch ex As Exception

            End Try

        Next

    End Sub
    Private Sub BtnConfirmar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnConfirmar.Click

        For Each drw As DataGridViewRow In DgvDatos.Rows
            Try
                If Not IsDBNull(drw.Cells("nro_carta").Value) Then
                    ConfigCorreo.CN_Correo.VerificarEstadoAlerta(drw.Cells("nro_carta").Value, drw.Cells("estadof").Value)
                End If

            Catch ex As Exception

            End Try

        Next

        If Verificar_ING_ARCH(txtPath.Text) = True Then
            MsgBox("El archivo ya existe con ese nombre")
        Else

            Dim CADENASTRIM As System.Text.StringBuilder
            CADENASTRIM = CargarArchivo(txtPath.Text, Now.ToShortDateString)

            Dim txtarch As String
            txtarch = CADENASTRIM.ToString

            If Len(txtarch) > 0 Then
                txtarch = Mid(txtarch, 1, Len(txtarch) - 2)
            End If
            If InstertarRegistroTR_ANALIZADO(txtarch) = True Then
                MsgBox("OK")
            End If

        End If



    End Sub
    Private Function CargarArchivo(ByVal ARCHIVO As String, ByVal FECHAARCHIVO As String) As System.Text.StringBuilder
        Dim txtsql As String = ""
        Dim cadena As New System.Text.StringBuilder

        For Each drw As DataGridViewRow In DgvDatos.Rows
            If Not IsDBNull(drw.Cells("NRO_CARTA").Value) Then


                If Len(drw.Cells("NRO_CARTA").Value) > 0 Then


                    Dim NRO_CARTA As String = ""
                    Dim REMITENTE As String = ""
                    Dim FECH_TRAB As String = ""
                    Dim APELLIDO As String = ""
                    Dim CALLE As String = ""
                    Dim CP As String = ""
                    Dim LOCALIDAD As String = ""
                    Dim PROVINCIA As String = ""
                    Dim FECHA_ENTR As String = ""
                    Dim NRO_PLANIL As String = ""
                    Dim FECH_PLANI As String = ""
                    Dim ESTADO As String = ""
                    Dim CARTERO As String = ""
                    Dim TEMA4 As String = ""
                    Dim FECH4 As String = ""
                    Dim NRO_CART2 As String = ""
                    Dim FECHA_ULT_ESTADO As String = ""
                    Dim DENO_ESTADO As String = ""
                    Dim ESTADOF As String = ""
                    Dim MOTIVOF As String = ""
                    Dim FECHAF As String = ""
                    Dim SOCIO As String = ""

                    If Not IsDBNull(drw.Cells("NRO_CARTA").Value) Then
                        NRO_CARTA = drw.Cells("NRO_CARTA").Value
                    End If

                    If Not IsDBNull(drw.Cells("REMITENTE").Value) Then
                        REMITENTE = drw.Cells("REMITENTE").Value
                    End If
                    If Not IsDBNull(drw.Cells("FECH_TRAB").Value) Then
                        FECH_TRAB = drw.Cells("FECH_TRAB").Value
                    End If
                    If Not IsDBNull(drw.Cells("APELLIDO").Value) Then
                        APELLIDO = drw.Cells("APELLIDO").Value
                    End If
                    If Not IsDBNull(drw.Cells("CALLE").Value) Then
                        CALLE = drw.Cells("CALLE").Value
                    End If
                    If Not IsDBNull(drw.Cells("CP").Value) Then
                        CP = drw.Cells("CP").Value
                    End If
                    If Not IsDBNull(drw.Cells("LOCALIDAD").Value) Then
                        LOCALIDAD = drw.Cells("LOCALIDAD").Value
                    End If
                    If Not IsDBNull(drw.Cells("PROVINCIA").Value) Then
                        PROVINCIA = drw.Cells("PROVINCIA").Value
                    End If
                    If Not IsDBNull(drw.Cells("FECHA_ENTR").Value) Then
                        FECHA_ENTR = drw.Cells("FECHA_ENTR").Value
                    End If
                    If Not IsDBNull(drw.Cells("NRO_PLANIL").Value) Then
                        NRO_PLANIL = drw.Cells("NRO_PLANIL").Value
                    End If
                    If Not IsDBNull(drw.Cells("FECH_PLANI").Value) Then
                        FECH_PLANI = drw.Cells("FECH_PLANI").Value
                    End If
                    If Not IsDBNull(drw.Cells("ESTADO").Value) Then
                        ESTADO = drw.Cells("ESTADO").Value
                    End If
                    If Not IsDBNull(drw.Cells("CARTERO").Value) Then
                        CARTERO = drw.Cells("CARTERO").Value
                    End If
                    If Not IsDBNull(drw.Cells("TEMA4").Value) Then
                        TEMA4 = drw.Cells("TEMA4").Value
                    End If
                    If Not IsDBNull(drw.Cells("FECH4").Value) Then
                        FECH4 = drw.Cells("FECH4").Value
                    End If
                    If Not IsDBNull(drw.Cells("NRO_CART2").Value) Then
                        NRO_CART2 = drw.Cells("NRO_CART2").Value
                    End If

                    If Not IsDBNull(drw.Cells("Fecha Ultimo Estado DESC").Value) Then
                        FECHA_ULT_ESTADO = drw.Cells("Fecha Ultimo Estado DESC").Value
                    End If
                    If Not IsDBNull(drw.Cells("Ultimo Estado Homolog DESC").Value) Then
                        DENO_ESTADO = drw.Cells("Ultimo Estado Homolog DESC").Value
                    End If
                    If Not IsDBNull(drw.Cells("ESTADOF").Value) Then
                        ESTADOF = drw.Cells("ESTADOF").Value
                    End If
                    If Not IsDBNull(drw.Cells("MOTIVOF").Value) Then
                        MOTIVOF = drw.Cells("MOTIVOF").Value
                    End If
                    If Not IsDBNull(drw.Cells("FECHAF").Value) Then
                        FECHAF = drw.Cells("FECHAF").Value
                    End If
                    If Not IsDBNull(drw.Cells("NRO_CARTA").Value) Then
                        SOCIO = drw.Cells("NRO_CART2").Value.ToString.Substring(0, 7)
                    End If


                    txtsql = "(" _
                    & "'" & NRO_CARTA & "' , " _
        & "'" & REMITENTE & "'" & ", " _
        & "'" & Converfecha(FECH_TRAB) & "'" & ", " _
        & "'" & Normalizar(APELLIDO) & "'" & ", " _
        & "'" & Normalizar(CALLE) & "'" & ", " _
        & "'" & CP & "'" & ", " _
        & "'" & Normalizar(LOCALIDAD) & "'" & ", " _
        & "'" & Normalizar(PROVINCIA) & "'" & ", " _
        & "'" & FECHA_ENTR & "'" & ", " _
        & "'" & NRO_PLANIL & "'" & ", " _
        & "'" & FECH_PLANI & "'" & ", " _
        & "'" & ESTADO & "'" & ", " _
        & "'" & CARTERO & "'" & ", " _
        & "'" & TEMA4 & "'" & ", " _
        & "'" & FECH4 & "'" & ", " _
        & "'" & NRO_CART2 & "'" & ", " _
        & "'" & FECHA_ULT_ESTADO & "'" & ", " _
        & "'" & DENO_ESTADO & "'" & ", " _
        & "'" & ESTADOF & "'" & ", " _
        & "'" & MOTIVOF & "'" & ", " _
        & "'" & FECHAF & "' , " _
        & "'" & ARCHIVO & "' , " _
        & "'" & FECHAARCHIVO & "'" _
        & ")" & ", "

                    cadena.Append(txtsql)
                End If
            End If
        Next


        Return cadena


    End Function
    Private Function CargarArchivo2() As System.Text.StringBuilder
        Dim txtsql As String = ""
        Dim cadena As New System.Text.StringBuilder

        Dim NRO_CARTA As String = ""
        Dim REMITENTE As String = ""
        Dim FECH_TRAB As String = ""
        Dim APELLIDO As String = ""
        Dim CALLE As String = ""
        Dim CP As String = ""
        Dim LOCALIDAD As String = ""
        Dim PROVINCIA As String = ""
        Dim FECHA_ENTR As String = ""
        Dim NRO_PLANIL As String = ""
        Dim FECH_PLANI As String = ""
        Dim ESTADO As String = ""
        Dim CARTERO As String = ""
        Dim TEMA4 As String = ""
        Dim FECH4 As String = ""
        Dim NRO_CART2 As String = ""
        Dim Agrup As String = ""
        Dim FECHA_ULT_ESTADO As String = ""
        Dim DENO_ESTADO As String = ""
        Dim ESTADOF As String = ""
        Dim MOTIVOF As String = ""
        Dim FECHAF As String = ""
        Dim NARCHIVO As String = ""
        Dim FECHA_REGISTRO As String = ""

        For Each drw As DataGridViewRow In DgvDatos.Rows

            If Not IsDBNull(drw.Cells("NRO_CARTA").Value) Then
                NRO_CARTA = drw.Cells("NRO_CARTA").Value
            End If

            If Not IsDBNull(drw.Cells("REMITENTE").Value) Then
                REMITENTE = drw.Cells("REMITENTE").Value
            End If
            If Not IsDBNull(drw.Cells("FECH_TRAB").Value) Then
                FECH_TRAB = drw.Cells("FECH_TRAB").Value
            End If
            If Not IsDBNull(drw.Cells("APELLIDO").Value) Then
                APELLIDO = drw.Cells("APELLIDO").Value
            End If
            If Not IsDBNull(drw.Cells("CALLE").Value) Then
                CALLE = drw.Cells("CALLE").Value
            End If
            If Not IsDBNull(drw.Cells("CP").Value) Then
                CP = drw.Cells("CP").Value
            End If
            If Not IsDBNull(drw.Cells("LOCALIDAD").Value) Then
                LOCALIDAD = drw.Cells("LOCALIDAD").Value
            End If
            If Not IsDBNull(drw.Cells("PROVINCIA").Value) Then
                PROVINCIA = drw.Cells("PROVINCIA").Value
            End If
            If Not IsDBNull(drw.Cells("FECHA_ENTR").Value) Then
                FECHA_ENTR = drw.Cells("FECHA_ENTR").Value
            End If
            If Not IsDBNull(drw.Cells("NRO_PLANIL").Value) Then
                NRO_PLANIL = drw.Cells("NRO_PLANIL").Value
            End If
            If Not IsDBNull(drw.Cells("FECH_PLANI").Value) Then
                FECH_PLANI = drw.Cells("FECH_PLANI").Value
            End If
            If Not IsDBNull(drw.Cells("ESTADO").Value) Then
                ESTADO = drw.Cells("ESTADO").Value
            End If
            If Not IsDBNull(drw.Cells("CARTERO").Value) Then
                CARTERO = drw.Cells("CARTERO").Value
            End If
            If Not IsDBNull(drw.Cells("TEMA4").Value) Then
                TEMA4 = drw.Cells("TEMA4").Value
            End If
            If Not IsDBNull(drw.Cells("FECH4").Value) Then
                FECH4 = drw.Cells("FECH4").Value
            End If
            If Not IsDBNull(drw.Cells("NRO_CART2").Value) Then
                NRO_CART2 = drw.Cells("NRO_CART2").Value
            End If

            If Not IsDBNull(drw.Cells("Agrup").Value) Then
                Agrup = drw.Cells("Agrup").Value
            End If
            If Not IsDBNull(drw.Cells("FECHA_ULT_ESTADO").Value) Then
                FECHA_ULT_ESTADO = drw.Cells("FECHA_ULT_ESTADO").Value
            End If
            If Not IsDBNull(drw.Cells("DENO_ESTADO").Value) Then
                DENO_ESTADO = drw.Cells("DENO_ESTADO").Value
            End If
            If Not IsDBNull(drw.Cells("ESTADOF").Value) Then
                ESTADOF = drw.Cells("ESTADOF").Value
            End If
            If Not IsDBNull(drw.Cells("MOTIVOF").Value) Then
                MOTIVOF = drw.Cells("MOTIVOF").Value
            End If
            If Not IsDBNull(drw.Cells("FECHAF").Value) Then
                FECHAF = drw.Cells("FECHAF").Value
            End If
            If Not IsDBNull(drw.Cells("ARCHIVO").Value) Then
                NARCHIVO = drw.Cells("ARCHIVO").Value
            End If
            If Not IsDBNull(drw.Cells("FECHA_REGISTRO").Value) Then
                FECHA_REGISTRO = drw.Cells("FECHA_REGISTRO").Value
            End If

            txtsql = "(" _
            & "'" & NRO_CARTA & "' , " _
& "'" & REMITENTE & "'" & ", " _
& "'" & Converfecha(FECH_TRAB) & "'" & ", " _
& "'" & Normalizar(APELLIDO) & "'" & ", " _
& "'" & Normalizar(CALLE) & "'" & ", " _
& "'" & CP & "'" & ", " _
& "'" & Normalizar(LOCALIDAD) & "'" & ", " _
& "'" & Normalizar(PROVINCIA) & "'" & ", " _
& "'" & FECHA_ENTR & "'" & ", " _
& "'" & NRO_PLANIL & "'" & ", " _
& "'" & FECH_PLANI & "'" & ", " _
& "'" & ESTADO & "'" & ", " _
& "'" & CARTERO & "'" & ", " _
& "'" & TEMA4 & "'" & ", " _
& "'" & FECH4 & "'" & ", " _
& "'" & NRO_CART2 & "'" & ", " _
& "'" & Agrup & "'" & ", " _
& "'" & FECHA_ULT_ESTADO & "'" & ", " _
& "'" & DENO_ESTADO & "'" & ", " _
& "'" & ESTADOF & "'" & ", " _
& "'" & MOTIVOF & "'" & ", " _
& "'" & FECHAF & "' , " _
& "'" & NARCHIVO & "' , " _
& "'" & FECHA_REGISTRO & "'" _
& ")" & ", "

            cadena.Append(txtsql)
        Next


        Return cadena


    End Function
    Private Sub Btncargacompleta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim CADENASTRIM As System.Text.StringBuilder
        CADENASTRIM = CargarArchivo2()

        Dim txtarch As String
        txtarch = CADENASTRIM.ToString

        If Len(txtarch) > 0 Then
            txtarch = Mid(txtarch, 1, Len(txtarch) - 2)
        End If
        If InstertarRegistroTR_ANALIZADO(txtarch) = True Then
            MsgBox("OK")
        End If
    End Sub
    Private Sub BtnAnalizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        EntregadasCod13()
    End Sub
    'Private Sub BtnHistorico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHistorico.Click
    '    For Each DRW As DataGridViewRow In DgvDatos.Rows
    '        If Not IsDBNull(DRW.Cells("CALLE").Value) Then
    '            DRW.Cells("HISTORICO").Value = ObtenerEntrHistorico(DRW.Cells("CONTRA").Value, DRW.Cells("CALLE").Value)
    '        End If

    '    Next
    'End Sub
    Private Sub BtnFechasReales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFechasReales.Click
        FechasEntregadasReales()
    End Sub
    Private Shared Function Actualizarsocio()
        'For i As Integer = 146690 To 572078
        For i As Integer = 486870 To 572078
            'Try
            Dim NroCart2 As String = ObtenerNroCart2ID(i)
            NroCart2 = NroCart2.Substring(0, 7)
            ActualizarNroCart2ID(NroCart2, i)
            'Catch ex As Exception

            'End Try

        Next
        MsgBox("ok")
    End Function
    Private Sub BtnBase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CheckForIllegalCrossThreadCalls = False
        Dim thread As New Threading.Thread(AddressOf Actualizarsocio)
        thread.Start()
    End Sub
    Private Function Retornode7digitos(ByVal Nro As String) As String

        If Len(Nro) = 2 Then
            Nro = "00000" & Nro
        End If
        If Len(Nro) = 3 Then
            Nro = "0000" & Nro
        End If
        If Len(Nro) = 4 Then
            Nro = "000" & Nro
        End If
        If Len(Nro) = 5 Then
            Nro = "00" & Nro
        End If
        If Len(Nro) = 6 Then
            Nro = "0" & Nro
        End If
        If Len(Nro) = 7 Then
            Nro = Nro
        End If
        Return Nro
    End Function
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btntxt.Click

        funciontxt("VISITADA")
        funciontxt("ENTREGADA")
        funciontxt("ENT_COD13")

        Dim camposSeleccionados() As String = {"Lote Contra Inte ID", "Socio DESC", "Socio Prepaga", "Socio CONTRATO", "Socio Integrante", "Lote ID", "Ultimo Estado Homolog DESC", "Fecha Ultimo Estado DESC", "Distribucion Empresa DESC", "Zona Envio Creden ID", "Zona Envio Creden DESC", "Grupos Creden", "CONTRA", "LOTE", "NRO_CARTA", "NRO_CART2", "ESTADOF", "MOTIVOF", "FECHAF"}
        ExportarDataGridViewAExcel(DgvDatos, camposSeleccionados)

    End Sub
    Private Function funciontxt(ByVal tipo As String) As Boolean

        If Len(tipo) > 0 Then
            Dim Estado As String = ""

            If tipo = "VISITADA" Then
                Estado = "6"
            ElseIf tipo = "ENTREGADA" Then
                Estado = "3"
            ElseIf tipo = "ENT_COD13" Then
                Estado = "13"
            End If


            Dim cadena As New System.Text.StringBuilder
            For Each dgw As DataGridViewRow In DgvDatos.Rows
                If dgw.Cells("Estadof").Value = tipo Then



                    Dim Fechaf As Date = dgw.Cells("fechaf").Value.ToString
                    Dim fe As String
                    fe = Fechaf.ToString("dd/MM/yyyy")

                    cadena.AppendLine(dgw.Cells("Socio CONTRATO").Value & ";" & dgw.Cells("Socio INTEGRANTE").Value & ";" & Val(dgw.Cells("Lote ID").Value) & ";" & Estado & ";" & fe)
                End If

            Next
            Dim texto As String
            texto = cadena.ToString
            Dim objEscritor As IO.StreamWriter
            objEscritor = IO.File.AppendText("C:\temp\" & tipo & ".txt")
            objEscritor.Write(texto)
            objEscritor.Close()


        End If



    End Function
    Private Sub Btncsv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btncsv.Click


        Dim headers = (From header As DataGridViewColumn In DgvDatos.Columns.Cast(Of DataGridViewColumn)()
                       Select header.HeaderText).ToArray
        Dim rows = From row As DataGridViewRow In DgvDatos.Rows.Cast(Of DataGridViewRow)()
                   Where Not row.IsNewRow
                   Select Array.ConvertAll(row.Cells.Cast(Of DataGridViewCell).ToArray, Function(c) If(c.Value IsNot Nothing, If(TypeOf c.Value Is Date, CType(c.Value, Date).ToString("yyyy/MM/dd"), c.Value.ToString().PadLeft(2, "0"c)), ""))

        Using sw As New IO.StreamWriter("C:\Temp\archivo.txt", False, System.Text.Encoding.GetEncoding(65001))
            sw.WriteLine(String.Join(";", headers))
            For Each r In rows
                sw.WriteLine(String.Join(";", r))
            Next
        End Using

        Process.Start("C:\Temp\archivo.txt")

    End Sub





    Public Function ExtractStreetAndNumber(address As String) As String
        Dim patterns As String() = {"11 DE SEPTIEMBRE DE 1888 ", "11 DE SEPTIEMBRE ", "25 DE MAYO ", "9 DE JULIO ", "3 DE FEBRERO ", "12 DE OCTUBRE ", "15 DE NOVIEMBRE DE 1889 ", "20 DE SEPTIEMBRE ", "33 ORIENTALES ", "11 de septiembre ", "25 de Mayo ", "3 de Febrero ", "3 de Febrero ", "3 de febrero ", "3 febrero ", "24 DE NOVIEMBRE ", "15 DE NOVIEMBRE 1889 ", "29 DE SEPTIEMBRE ", "1 DE MAYO ", "2 DE MAYO ", "14 DE JULIO ", "24 DE MAYO ", "30 DE SEPTIEMBRE ", "1 DE MARZO ", "15 DE NOVIEMBRE ", "11 DESEPTIEMBRE ", "15 DE NOVIEMBRE ", "2 DE ABRIL ", "20 DE FEBRERO ", "3 FEBRERO "}
        ' Verificar si el dato contiene alguno de los textos en patterns
        For Each pattern As String In patterns
            If address.ToUpper().Contains(pattern.ToUpper()) OrElse address.ToLower().Contains(pattern.ToLower()) Then

                Return CorreccionCalleConNumeroInicial(address)
            End If
        Next

        ' Si no contiene ninguno de los textos, realizar la extracción de calle y número
        Dim components As String() = address.Split(New Char() {" "}, StringSplitOptions.RemoveEmptyEntries)
        Dim street As String = ""
        Dim number As String = ""
        Dim i As Integer = 0
        While i < components.Length
            Dim currentComponent As String = components(i)
            If IsNumeric(currentComponent) Then
                number = currentComponent
                Exit While
            End If
            street += currentComponent + " "
            i += 1
        End While

        Return street.Trim() + ";" + number
    End Function
    Public Function CorreccionCalleConNumeroInicial(calle As String) As String
        Dim patterns As HashSet(Of String) = New HashSet(Of String) From {"11 DE SEPTIEMBRE DE 1888 ", "11 DE SEPTIEMBRE ", "25 DE MAYO ", "9 DE JULIO ", "3 DE FEBRERO ", "12 DE OCTUBRE ", "15 DE NOVIEMBRE DE 1889 ", "20 DE SEPTIEMBRE ", "33 ORIENTALES ", "11 de septiembre ", "25 de Mayo ", "3 de Febrero ", "3 de Febrero ", "3 de febrero ", "3 febrero ", "24 DE NOVIEMBRE ", "15 DE NOVIEMBRE 1889 ", "29 DE SEPTIEMBRE ", "1 DE MAYO ", "2 DE MAYO ", "14 DE JULIO ", "24 DE MAYO ", "30 DE SEPTIEMBRE ", "1 DE MARZO ", "15 DE NOVIEMBRE ", "11 DESEPTIEMBRE ", "15 DE NOVIEMBRE ", "2 DE ABRIL ", "20 DE FEBRERO ", "3 FEBRERO "}

        Dim calleCompleta As String = calle
        Dim callepattern As String = ""

        For Each pattern As String In patterns
            If calle.Contains(pattern) Then
                callepattern = pattern
                Exit For
            End If
        Next

        If Not String.IsNullOrEmpty(callepattern) Then
            calleCompleta = calleCompleta.Replace(callepattern, "")
        End If

        Dim spaceIndex As Integer = calleCompleta.IndexOf(" ")
        If spaceIndex <> -1 Then
            calleCompleta = calleCompleta.Substring(0, spaceIndex)
        End If

        Dim regex As New Regex("^\d+")
        Dim match As Match = regex.Match(calleCompleta)

        If match.Success Then
            calleCompleta = match.Value
        Else
            calleCompleta = ""
        End If

        Return callepattern & ";" & calleCompleta
    End Function



    Private Sub BtnEstadistica_Click(sender As Object, e As EventArgs) Handles BtnEstadistica.Click

        dt2.Columns.Add("callemodificada")
        dt2.Columns.Add("altura")

        Dim palabras As Dictionary(Of String, String) = ConfigCorreo.CN_Correo.ReemplazarPalabras()
        For Each fila As DataGridViewRow In DgvDatos.Rows
            If Not fila.IsNewRow Then
                Dim calle As String = fila.Cells("calle").Value.ToString()
                Dim modificada As String = calle

                For Each kvp As KeyValuePair(Of String, String) In palabras
                    modificada = modificada.Replace(kvp.Key, kvp.Value)
                Next

                modificada = Regex.Replace(modificada, "[^a-zA-Z0-9\s]", "")

                Dim resultado As String = ExtractStreetAndNumber(calle)
                Dim valores As String() = resultado.Split(";"c)

                If valores.Length >= 1 Then
                    fila.Cells("callemodificada").Value = valores(0)
                End If

                If valores.Length >= 2 Then
                    fila.Cells("altura").Value = valores(1)
                End If
            End If
        Next


        Dim direccionesModificadas As List(Of List(Of String)) = AñadirCamposSeparandoCallededireccion(ConfigCorreo.CN_Correo.ObtenerEntregadasTodo)
        PgbAnalisis.Maximum = DgvDatos.Rows.Count ' Establecer el máximo valor de la barra de progreso
        For Each fila As DataGridViewRow In DgvDatos.Rows
            If Not fila.IsNewRow Then ' Omitir la fila de nueva entrada, si existe
                Dim callemodificada As String = fila.Cells("callemodificada").Value.ToString()
                Dim altura As String = fila.Cells("altura").Value

                ' Verificar si existe el dato en la lista utilizando un bucle For Each
                Dim encontrado As Boolean = False
                For Each direccionModificada As List(Of String) In direccionesModificadas
                    Dim calleModificadaDt As String = direccionModificada(0)
                    Dim alturaDt As String = If(direccionModificada.Count > 1, direccionModificada(1), "")

                    If String.Equals(callemodificada, calleModificadaDt, StringComparison.OrdinalIgnoreCase) AndAlso altura = alturaDt Then
                        encontrado = True
                        Exit For ' Salir del bucle si encontramos una coincidencia
                    End If
                Next

                If encontrado Then ' Si se encontró una coincidencia
                    fila.Cells("historico").Value = "entregada_estadistica"
                End If
            End If

            PgbAnalisis.Value = PgbAnalisis.Value + 1
        Next

    End Sub



    Private Function AñadirCamposSeparandoCallededireccion(ByVal dtEstadistica As DataTable) As List(Of List(Of String))
        Dim palabras As Dictionary(Of String, String) = ConfigCorreo.CN_Correo.ReemplazarPalabras()
        Dim direccionesModificadas As New List(Of List(Of String))()

        For Each row As DataRow In dtEstadistica.Rows
            Dim calle As String = row("calle").ToString()
            Dim modificada As String = calle

            For Each kvp As KeyValuePair(Of String, String) In palabras
                modificada = modificada.Replace(kvp.Key, kvp.Value)
            Next

            modificada = Regex.Replace(modificada, "[^a-zA-Z0-9\s]", "")

            Dim resultado As String = ExtractStreetAndNumber(calle)
            Dim valores As String() = resultado.Split(";"c)

            Dim direccionModificada As New List(Of String)()

            If valores.Length >= 2 Then
                direccionModificada.Add(valores(0)) ' Agregar la clave como valores(0)
                direccionModificada.Add(valores(1)) ' Agregar el valor como valores(1)
            End If

            direccionesModificadas.Add(direccionModificada)
        Next

        Return direccionesModificadas
    End Function


End Class
