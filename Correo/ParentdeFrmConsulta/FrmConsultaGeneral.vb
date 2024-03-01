Imports System.IO
Imports System
Imports System.Threading


Public Class FrmConsultaGeneral

    Dim DTresultado As New DataTable
    Dim DtRecorridos As New DataTable
    Dim DTresultadoFiltrado As New DataTable

    Dim ArrayCartas As New ArrayList

    Private Sub Btnsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnsalir.Click
        Me.Close()
    End Sub
    Private Sub BtnConsulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnConsulta.Click

        If NRO_CARTATextdesdeBoxHASTA.Text = "" Then
            NRO_CARTATextdesdeBoxHASTA.Text = NRO_CARTATextdesdeBoxDESDE.Text
        End If

        If MKFECH_TRABDESDE.Text <> "" And MKFECH_TRABHASTA.Text = "" Then
            MKFECH_TRABHASTA.Text = MKFECH_TRABDESDE.Text

            NRO_CARTATextdesdeBoxDESDE.Text = ""
            NRO_CARTATextdesdeBoxHASTA.Text = ""
            EMPRESATextBox.Text = ""
            CALLETextBox.Text = ""
            NOMBRE_APELLIDOTextBox.Text = ""
            NRO_CARTA2TextBox.Text = ""
            CPTextBoxDESDE.Text = ""
            CPTextBoxHASTA.Text = ""
            OBS2TextBox.Text = ""
            OBS3TextBox.Text = ""
            OBS4TextBox.Text = ""
            OBSTextBox.Text = ""
            'MKFECHA_ENTREGADESDE.Text = ""
            'MKFECHA_ENTREGAHASTA.Text = ""

        End If
        Ejecutar()

    End Sub
    Private Sub Ejecutar()
        Dim SqlTxt As String = "Select NRO_CARTA, REMITENTE, TRABAJO, FECH_TRAB, APELLIDO, CP, CALLE, NRO, PISO_DEPTO, LOCALIDAD, PROVINCIA, ESTADO, NRO_CART2, EMPRESA, SOCIO, OBS, OBS2, OBS3, OBS4, ID from cartas "

        '
        Dim Unir As String = ""
        Dim ArraSql As New ArrayList

        Dim Fech_trabdes As String = ""
        Dim Fech_trabhas As String = ""
        '


        ArraSql = ConfigCorreo.CN_Correo.Creararraydeconsultas(NRO_CARTATextdesdeBoxDESDE.Text, NRO_CARTATextdesdeBoxHASTA.Text, NOMBRE_APELLIDOTextBox.Text, CALLETextBox.Text, EMPRESATextBox.Text, NRO_CARTA2TextBox.Text, OBSTextBox.Text, OBS2TextBox.Text, OBS3TextBox.Text, OBS4TextBox.Text, CPTextBoxDESDE.Text, CPTextBoxHASTA.Text)

        If ArraSql.Count - 1 < 0 Then

            If Len(Trim(MKFECH_TRABDESDE.Text)) > 5 Then
                If Len(Trim(MKFECH_TRABHASTA.Text)) > 5 Then
                    Fech_trabdes = ConfigCorreo.CN_Correo.Converfecha(MKFECH_TRABDESDE.Text)
                    Fech_trabhas = ConfigCorreo.CN_Correo.Converfecha(MKFECH_TRABHASTA.Text)
                Else
                    Fech_trabdes = ConfigCorreo.CN_Correo.Converfecha(MKFECH_TRABDESDE.Text)
                    Fech_trabhas = ConfigCorreo.CN_Correo.Converfecha(MKFECH_TRABDESDE.Text)
                End If
                '2222
                SqlTxt = "Select NRO_CARTA, REMITENTE, TRABAJO, FECH_TRAB, APELLIDO, CP, CALLE, NRO, PISO_DEPTO, LOCALIDAD, PROVINCIA, ESTADO, NRO_CART2, EMPRESA, SOCIO, OBS, OBS2, OBS3, OBS4, ID from cartas "
                DTresultado = ConfigCorreo.CN_Correo.ConsultaCompleja(SqlTxt & "where fech_trab between '" & Fech_trabdes & "' and '" & Fech_trabhas & "'")
                Dgvdatos.DataSource = DTresultado



            End If

        Else


            SqlTxt = SqlTxt & "Where "
            For i As Integer = 0 To ArraSql.Count - 1
                Unir = Unir & ArraSql.Item(i).ToString & " And "
            Next
            Unir = Unir.Substring(0, Len(Unir) - 4)

            DTresultado = ConfigCorreo.CN_Correo.ConsultaCompleja(SqlTxt & Unir)
            Dgvdatos.DataSource = DTresultado
        End If

        LblCuenta.Text = Dgvdatos.RowCount


        If LblCuenta.Text < 5001 Then
            Btnxls.Enabled = True
            BtnCsv.Enabled = True

        Else
            BtnCsv.Enabled = True
            Btnxls.Enabled = False
        End If

        Dgvdatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize



    End Sub
    

    Private Sub Exportartxt()

        Dim Op As New SaveFileDialog
        Op.Filter = "csv files (*.csv)|*.csv"
        Op.ShowDialog()


        Dim sFile As String = Op.FileName
        Dim Line As String = Nothing
        Try
            If File.Exists(sFile) = True Then 'Si el archivo existe, lo elimina antes
                My.Computer.FileSystem.DeleteFile(sFile, FileIO.UIOption.OnlyErrorDialogs, _
                                                  FileIO.RecycleOption.DeletePermanently, FileIO.UICancelOption.DoNothing)
            End If

            Dim swFile As StreamWriter = New StreamWriter(sFile)
            With Dgvdatos
                Line = "NRO_CARTA;REMITENTE;TRABAJO;FECH_TRAB;CP;CALLE;LOCALIDAD;PROVINCIA;ESTDO;NRO_PLANILLA;FECHA_PLANILLA;CARTERO;FECHA_ENTREGA;ACUSE;FECHA1;PLANILLA1;TEMA1;CARTERO1;FECHA2;PLANILLA2;TEMA2;CARTERO2;FECHA3;PLANILLA3;TEMA3;CARTERO3;MOTIVO;FECHA_DEVOLUCION;PLANILLA_DEVOLUCION;DEVOLUCION_ACUSE;NRO_ORDEN;REMINOM;RECIBIO;TIPO_DOC;DOCUMENTO;D_ENTRY;ZONA;EMPRESA;NRO_CARTA2;SERVICIO;PRECIO;F_LIMITE;SOCIO;AUDITORIA;PLANILLA_AUDITORIA;ARTICULO;VALOR;COBRAR;LAT_IZQ;LAT_DER;MOTIVO_ANT;FECHA_MOT_ANT;OBS2;OBS3;OBS4;LAT_IZQ;LAT_DER"
                swFile.WriteLine(Line)

                For i = 0 To .RowCount - 1
                    Line = .Rows(i).Cells("NRO_CARTA").Value & ";" & _
                            .Rows(i).Cells("REMITENTE").Value & ";" & _
                            .Rows(i).Cells("TRABAJO").Value & ";" & _
                            .Rows(i).Cells("FECH_TRAB").Value & ";" & _
                            .Rows(i).Cells("CP").Value & ";" & _
                            .Rows(i).Cells("CALLE").Value & ";" & _
                            .Rows(i).Cells("LOCALIDAD").Value & ";" & _
                            .Rows(i).Cells("PROVINCIA").Value & ";" & _
                            .Rows(i).Cells("ESTADO").Value & ";" & _
                            .Rows(i).Cells("NRO_PLANILLA").Value & ";" & _
                            .Rows(i).Cells("FECHA_PLANILLA").Value & ";" & _
                            .Rows(i).Cells("CARTERO").Value & ";" & _
                            .Rows(i).Cells("FECHA_ENTREGA").Value & ";" & _
                            .Rows(i).Cells("ACUSE").Value & ";" & _
                            .Rows(i).Cells("FECHA1").Value & ";" & _
                            .Rows(i).Cells("PLANILLA1").Value & ";" & _
                            .Rows(i).Cells("TEMA1").Value & ";" & _
                            .Rows(i).Cells("CARTERO1").Value & ";" & _
                            .Rows(i).Cells("FECHA2").Value & ";" & _
                            .Rows(i).Cells("PLANILLA2").Value & ";" & _
                            .Rows(i).Cells("TEMA2").Value & ";" & _
                            .Rows(i).Cells("CARTERO2").Value & ";" & _
                            .Rows(i).Cells("FECHA3").Value & ";" & _
                            .Rows(i).Cells("PLANILLA3").Value & ";" & _
                            .Rows(i).Cells("TEMA3").Value & ";" & _
                            .Rows(i).Cells("CARTERO3").Value & ";" & _
                            .Rows(i).Cells("MOTIVO").Value & ";" & _
                            .Rows(i).Cells("FECHA_DEVOLUCION").Value & ";" & _
                            .Rows(i).Cells("PLANILLA_DEVOLUCION").Value & ";" & _
                            .Rows(i).Cells("DEVOLUCION_ACUSE").Value & ";" & _
                            .Rows(i).Cells("NRO_ORDEN").Value & ";" & _
                            .Rows(i).Cells("REMINOM").Value & ";" & _
                            .Rows(i).Cells("RECIBIO").Value & ";" & _
                            .Rows(i).Cells("TIPO_DOC").Value & ";" & _
                            .Rows(i).Cells("DOCUMENTO").Value & ";" & _
                            .Rows(i).Cells("D_ENTRY").Value & ";" & _
                            .Rows(i).Cells("ZONA").Value & ";" & _
                            .Rows(i).Cells("EMPRESA").Value & ";" & _
                            .Rows(i).Cells("NRO_CARTA2").Value & ";" & _
                            .Rows(i).Cells("SERVICIO").Value & ";" & _
                            .Rows(i).Cells("PRECIO").Value & ";" & _
                            .Rows(i).Cells("F_LIMITE").Value & ";" & _
                            .Rows(i).Cells("SOCIO").Value & ";" & _
                            .Rows(i).Cells("AUDITORIA").Value & ";" & _
                            .Rows(i).Cells("PLANILLA_AUDITORIA").Value & ";" & _
                            .Rows(i).Cells("ARTICULO").Value & ";" & _
                            .Rows(i).Cells("VALOR").Value & ";" & _
                            .Rows(i).Cells("COBRAR").Value & ";" & _
                            .Rows(i).Cells("LAT_IZQ").Value & ";" & _
                            .Rows(i).Cells("LAT_DER").Value & ";" & _
                            .Rows(i).Cells("MOTIVO_ANT").Value & ";" & _
                            .Rows(i).Cells("FECHA_MOT_ANT").Value & ";" & _
                            .Rows(i).Cells("OBS2").Value & ";" & _
                            .Rows(i).Cells("OBS3").Value & ";" & _
                            .Rows(i).Cells("OBS4").Value & ";" & _
                            .Rows(i).Cells("LAT_IZQ").Value & ";" & _
                            .Rows(i).Cells("LAT_DER").Value

                    swFile.WriteLine(Line)
                Next
            End With
            swFile.Close()
        Catch ex As Exception

        End Try

    End Sub
    Private Sub Dgvdatos_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Dgvdatos.DoubleClick
        Dim N As String = Dgvdatos.SelectedCells(0).RowIndex.ToString
        Dim STR As String = Dgvdatos.Rows(N).Cells("ID").Value

        Dim frmc As New FrmConsultaUndato
        frmc.Idstr = STR
        frmc.MdiParent = FrmConsultamdi
        frmc.Show()

    End Sub
    Private Sub Btnxls_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnxls.Click

        ExportarDataGridViewAExcel(Dgvdatos)

    End Sub

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
                    data(i, j) = dgv.Rows(i).Cells(j).Value
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



    Private Sub Excel()
        'Creamos las variables
        Try
            Dim exApp As New Microsoft.Office.Interop.Excel.Application
            Dim exLibro As Microsoft.Office.Interop.Excel.Workbook
            Dim exHoja As Microsoft.Office.Interop.Excel.Worksheet


            'Añadimos el Libro al programa, y la hoja al libro
            exLibro = exApp.Workbooks.Add
            exHoja = exLibro.Worksheets.Add()
            exHoja.Cells.NumberFormat = "@"
            ' ¿Cuantas columnas y cuantas filas?
            Dim NCol As Integer = Dgvdatos.ColumnCount
            Dim NRow As Integer = Dgvdatos.RowCount


            'Aqui recorremos todas las filas, y por cada fila todas las columnas y vamos escribiendo.
            For i As Integer = 1 To NCol
                exHoja.Cells.Item(1, i) = Dgvdatos.Columns(i - 1).Name.ToString
                'exHoja.Cells.Item(1, i).HorizontalAlignment = 3
            Next

            For Fila As Integer = 0 To NRow - 1
                For Col As Integer = 0 To NCol - 1
                    exHoja.Cells.Item(Fila + 2, Col + 1) = Dgvdatos.Rows(Fila).Cells(Col).Value
                Next
            Next
            'Titulo en negrita, Alineado al centro y que el tamaño de la columna se
            'ajuste al texto

            'exHoja.Rows.Item(5).Font.Bold = 1
            'exHoja.Rows.Item(5).HorizontalAlignment = 3
            exHoja.Columns.AutoFit()



            'Aplicación visible
            exApp.Application.Visible = True

            exHoja = Nothing
            exLibro = Nothing
            exApp = Nothing

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al exportar a Excel")

        End Try

    End Sub
    Private Sub BtnCsv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCsv.Click

        Dim headers = (From header As DataGridViewColumn In Dgvdatos.Columns.Cast(Of DataGridViewColumn)() _
                       Select header.HeaderText).ToArray
        Dim rows = From row As DataGridViewRow In Dgvdatos.Rows.Cast(Of DataGridViewRow)() _
                   Where Not row.IsNewRow _
                   Select Array.ConvertAll(row.Cells.Cast(Of DataGridViewCell).ToArray, Function(c) If(c.Value IsNot Nothing, c.Value.ToString, ""))

        Using sw As New IO.StreamWriter("C:\Temp\archivo.csv", False, System.Text.Encoding.GetEncoding(65001))

            sw.WriteLine(String.Join(";", headers))
            For Each r In rows
                sw.WriteLine(String.Join(";", r))
            Next
        End Using

        Process.Start("C:\Temp\archivo.csv")



    End Sub
    Private Sub subExportDGVToCSV(ByVal strExportFileName As String, ByVal DataGridView As DataGridView, Optional ByVal blnWriteColumnHeaderNames As Boolean = False, Optional ByVal strDelimiterType As String = "")

        Dim sr As StreamWriter = File.CreateText(strExportFileName)
        Dim strDelimiter As String = strDelimiterType
        Dim intColumnCount As Integer = DataGridView.Columns.Count - 1
        Dim strRowData As String = ""

        If blnWriteColumnHeaderNames Then
            For intX As Integer = 0 To intColumnCount
                strRowData += Replace(DataGridView.Columns(intX).Name, strDelimiter, "") & IIf(intX < intColumnCount, strDelimiter, "")
            Next intX
            sr.WriteLine(strRowData)
        End If

        For intX As Integer = 0 To DataGridView.Rows.Count - 1
            strRowData = ""
            For intRowData As Integer = 0 To intColumnCount
                strRowData += Replace(DataGridView.Rows(intX).Cells(intRowData).Value, strDelimiter, "") & IIf(intRowData < intColumnCount, strDelimiter, "") '''''''''highlights this row
            Next intRowData
            sr.WriteLine(strRowData)
        Next intX
        sr.Close()

    End Sub
 
    Private Sub BtnBuscarRecorridos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscarRecorridos.Click
        CargarCarteros()
    End Sub


    Private Function CargarCarteros()


        Dim SqlTxt As String = ""
        Dim Fech_trabdes As String = ""
        Dim Fech_trabhas As String = ""


        If Len(Trim(MKFECH_TRABDESDE.Text)) > 5 Then
            If Len(Trim(MKFECH_TRABHASTA.Text)) > 5 Then
                Fech_trabdes = ConfigCorreo.CN_Correo.Converfecha(MKFECH_TRABDESDE.Text)
                Fech_trabhas = ConfigCorreo.CN_Correo.Converfecha(MKFECH_TRABHASTA.Text)
            Else
                Fech_trabdes = ConfigCorreo.CN_Correo.Converfecha(MKFECH_TRABDESDE.Text)
                Fech_trabhas = ConfigCorreo.CN_Correo.Converfecha(MKFECH_TRABDESDE.Text)
            End If

            SqlTxt = "Select NRO_CARTA, PLANILLA_RECORRIDO, FECHA_RECORRIDO, CARTERO, RECORRIDO, FECHAF, ESTADO, MOTIVO from recorridos "
            DtRecorridos = ConfigCorreo.CN_Correo.ConsultaCompleja(SqlTxt & "where fecha_trabajo between '" & Fech_trabdes & "' and '" & Fech_trabhas & "'")
        End If


        For Each drw As DataRow In DtRecorridos.Rows
            If Not ArrayCartas.Contains(drw("NRO_CARTA")) Then
                DTresultadoFiltrado.Rows.Add(drw("NRO_CARTA"), drw("PLANILLA_RECORRIDO"), drw("FECHA_RECORRIDO"), drw("CARTERO"), drw("RECORRIDO"), drw("FECHAF"), drw("ESTADO"), drw("MOTIVO"))
            Else
                DTresultadoFiltrado.Rows.RemoveAt(DTresultadoFiltrado.Rows.Count - 1)

                DTresultadoFiltrado.Rows.Add(drw("NRO_CARTA"), drw("PLANILLA_RECORRIDO"), drw("FECHA_RECORRIDO"), drw("CARTERO"), drw("RECORRIDO"), drw("FECHAF"), drw("ESTADO"), drw("MOTIVO"))

            End If
            ArrayCartas.Add(drw("NRO_CARTA"))
        Next

        ArrayCartas.Clear()


        CruzarTablas(DTresultadoFiltrado)


    End Function

     
    Public Function CruzarTablas(ByVal DtTablas As DataTable) As DataTable

        DTresultado.Columns.Add("PLANILLA_RECORRIDO")
        DTresultado.Columns.Add("FECHA_RECORRIDO")
        DTresultado.Columns.Add("CARTERO")
        DTresultado.Columns.Add("RECORRIDO")
        DTresultado.Columns.Add("FECHAF")
        DTresultado.Columns.Add("ESTADO1")
        DTresultado.Columns.Add("MOTIVO")


        Dim Contador As Integer = 0
        Pgbavance.Maximum = DtTablas.Rows.Count
        Pgbavance.Minimum = Contador

        For Each drw As DataRow In DTresultado.Rows
            For Each drwr As DataRow In DtTablas.Rows

                If drw("NRO_CARTA") = drwr("NRO_CARTA") Then
                    drw("PLANILLA_RECORRIDO") = drwr("PLANILLA_RECORRIDO")
                    drw("FECHA_RECORRIDO") = drwr("FECHA_RECORRIDO")
                    drw("CARTERO") = drwr("CARTERO")
                    drw("RECORRIDO") = drwr("RECORRIDO")
                    drw("FECHAF") = drwr("FECHAF")
                    drw("ESTADO1") = drwr("ESTADO")
                    drw("MOTIVO") = drwr("MOTIVO")
                    Contador += 1
                End If
            Next

        Next


     
        Dgvdatos.DataSource = Nothing
        Dgvdatos.DataSource = DTresultado

    End Function

    Private Sub FrmConsultaGeneral_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DTresultadoFiltrado.Columns.Add("NRO_CARTA")
        DTresultadoFiltrado.Columns.Add("PLANILLA_RECORRIDO")
        DTresultadoFiltrado.Columns.Add("FECHA_RECORRIDO")
        DTresultadoFiltrado.Columns.Add("CARTERO")
        DTresultadoFiltrado.Columns.Add("RECORRIDO")
        DTresultadoFiltrado.Columns.Add("FECHAF")
        DTresultadoFiltrado.Columns.Add("ESTADO")
        DTresultadoFiltrado.Columns.Add("MOTIVO")

        'NRO_CARTA, PLANILLA_RECORRIDO, FECHA_RECORRIDO, CARTERO, RECORRIDO, FECHAF, ESTADO, MOTIVO 
    End Sub
End Class