Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO

Public Class FrmArm

    Public DtppalDatos As New DataTable
    Dim Dtdatosdetalle As New DataTable
    Dim nrointernoarm As Integer

    Private Sub FrmArm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim ArrayRemitentes As New ArrayList()
            ArrayRemitentes = ConfigCorreo.CN_Correo.CargarTodoslosremitente()

            If ArrayRemitentes IsNot Nothing Then
                CmbRemitente.Items.Clear()

                For i As Integer = 0 To ArrayRemitentes.Count - 1
                    CmbRemitente.Items.Add(ArrayRemitentes.Item(i).ToString())
                Next
            End If
        Catch ex As Exception
            ' Manejar la excepción aquí
        End Try

    End Sub
    Private Sub CmbRemitente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbRemitente.SelectedIndexChanged
        Dim ArrServiciosremitoslexs As New ArrayList
        ArrServiciosremitoslexs = ConfigCorreo.CN_Correo.RemitosdeCteremitosLexsImportado(CmbRemitente.Text)

        For i As Integer = 0 To ArrServiciosremitoslexs.Count - 1

            '***VERIFICAR SI YA TIENE INGRESO EN ARM ***
            If ConfigCorreo.CN_Correo.VerificarSiExisteArm(ArrServiciosremitoslexs.Item(i).ToString) = False Then
                CmbRemitoPendiente.Items.Add(ArrServiciosremitoslexs.Item(i).ToString)
            End If

        Next

        CmbRemitente.Enabled = False
        CmbRemitoPendiente.Enabled = True

    End Sub
    Private Sub CmbRemitoPendiente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbRemitoPendiente.SelectedIndexChanged
        If Len(CmbRemitente.Text) > 0 Then
            CmbRemitoPendiente.Enabled = False

            nrointernoarm = ConfigCorreo.CN_Correo.ObtenerNroPlanillaArm

            DtppalDatos = ConfigCorreo.CN_Correo.LlenarDatatableImprimirArm(CmbRemitoPendiente.Text)

            If Not DtppalDatos.Columns.Contains("NumeroArm") Then
                Dim planillaColumn As New DataColumn("NumeroArm", GetType(Integer))
                DtppalDatos.Columns.Add(planillaColumn)
            End If

            For Each row As DataRow In DtppalDatos.Rows
                row("NumeroArm") = nrointernoarm
                nrointernoarm += 1
            Next

            DgvSeleccion.DataSource = DtppalDatos

            For Each col As DataGridViewColumn In DgvSeleccion.Columns
                col.SortMode = DataGridViewColumnSortMode.NotSortable
            Next

            LblCant.Text = DgvSeleccion.RowCount
        End If
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
    Private Sub BtnXls_Click(sender As Object, e As EventArgs)
        ExportarDataGridViewAExcel(DgvSeleccion)
    End Sub

    Private Sub BtnPdf_Click(sender As Object, e As EventArgs) Handles BtnPdf.Click
        CrearArchivos()
        Combinar()
        AbrirArchivoFinal("C:\temp\archivo_final.pdf")
        BtnPdf.Enabled = False

    End Sub

    Public Sub AgregarDatosAPDF(ByVal dataTabledetalles As DataTable, ByVal Planilla As String)

        Dim archivoPdfBytes As Byte() = ConfigCorreo.CN_Correo.ObtenerArchivoPdf()
        Dim reader As New PdfReader(archivoPdfBytes)

        Dim pageCount As Integer = reader.NumberOfPages
        Using outputStream As New FileStream("C:\temp\Archivo_" & Planilla & ".pdf", FileMode.Create)
            Dim document As New Document()
            Dim writer As PdfWriter = PdfWriter.GetInstance(document, outputStream)
            document.Open()

            For page As Integer = 1 To pageCount
                document.NewPage()

                Dim importedPage As PdfImportedPage = writer.GetImportedPage(reader, page)
                Dim contentByte As PdfContentByte = writer.DirectContent
                '**************************************************************************
                Dim datosIzquierda As List(Of String) = ObtenerDatosIzquierda(dataTabledetalles)
                contentByte.BeginText()
                contentByte.SetFontAndSize(BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1250, BaseFont.NOT_EMBEDDED), 10)
                Dim posX As Single = 50
                Dim posY As Single = document.PageSize.Height - 50

                For Each dato As String In datosIzquierda
                    contentByte.SetTextMatrix(posX, posY)
                    contentByte.ShowText(dato)
                    posY -= 20
                Next
                contentByte.EndText()
                '********************************************
                Dim numeroPlanilla As String = Planilla
                Dim rutaFuenteCodigoBarras As String = ConfigCorreo.CN_Correo.ObtenerRutaFuenteTemporal() ' Obtiene la ruta temporal de la fuente
                Dim fuentePlanilla As BaseFont = BaseFont.CreateFont(rutaFuenteCodigoBarras, BaseFont.IDENTITY_H, BaseFont.EMBEDDED)
                Dim tamanoFuentePlanilla As Integer = 20
                Dim posicionXPlanilla As Single = document.PageSize.Width / 2
                Dim posicionYPlanilla As Single = document.PageSize.Height - 28



                If page = 1 Then ' Solo se agrega en la primera página
                    contentByte.BeginText()
                    contentByte.SetFontAndSize(fuentePlanilla, tamanoFuentePlanilla)
                    Dim anchoTextoPlanilla As Single = fuentePlanilla.GetWidthPoint(numeroPlanilla, tamanoFuentePlanilla)
                    Dim posXPlanilla As Single = posicionXPlanilla - anchoTextoPlanilla / 2

                    ' Dibujar asteriscos a los lados del número de planilla
                    Dim planillaConAsteriscos As String = "*" & numeroPlanilla & "*"

                    contentByte.SetTextMatrix(posXPlanilla, posicionYPlanilla)
                    contentByte.ShowText(planillaConAsteriscos)
                    contentByte.EndText()

                    ' Crear y dibujar la segunda variable planillaConAsteriscos2 con otra fuente
                    Dim fuentePlanilla2 As BaseFont = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1250, BaseFont.NOT_EMBEDDED)
                    Dim tamanoFuentePlanilla2 As Integer = 10
                    Dim posXPlanilla2 As Single = posicionXPlanilla - anchoTextoPlanilla / 2 + 20
                    Dim posYPlanilla2 As Single = posicionYPlanilla - 10 ' Colocar la segunda variable 30 puntos por debajo de la primera

                    Dim planillaConAsteriscos2 As String = "*" & numeroPlanilla & "*"
                    contentByte.BeginText()
                    contentByte.SetFontAndSize(fuentePlanilla2, tamanoFuentePlanilla2)
                    contentByte.SetTextMatrix(posXPlanilla2, posYPlanilla2)
                    contentByte.ShowText(planillaConAsteriscos2)
                    contentByte.EndText()

                End If
                '**********************************************

                Dim datosDerecha As List(Of String) = ObtenerDatosDerecha(dataTabledetalles)
                contentByte.BeginText()
                contentByte.SetFontAndSize(BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1250, BaseFont.NOT_EMBEDDED), 8)
                Dim posXDerecha As Single = document.PageSize.Width - 280 ' Posición derecha superior
                posY = document.PageSize.Height - 50

                For i As Integer = 0 To datosDerecha.Count - 1
                    Dim dato As String = datosDerecha(i)
                    contentByte.SetTextMatrix(posXDerecha, posY)
                    contentByte.ShowText(dato)
                    posY -= 8
                    If (i + 1) Mod 37 = 0 Then
                        posY = document.PageSize.Height - 50
                        posXDerecha -= -100
                    End If
                Next
                contentByte.EndText()
                contentByte.AddTemplate(importedPage, 0, 0)
                '****************************de nuevo********************************************

                datosIzquierda = ObtenerDatosIzquierda(dataTabledetalles)

                contentByte.BeginText()
                contentByte.SetFontAndSize(BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1250, BaseFont.NOT_EMBEDDED), 10)
                posX = 50
                posY = document.PageSize.Height - 500

                For Each dato As String In datosIzquierda
                    contentByte.SetTextMatrix(posX, posY)
                    contentByte.ShowText(dato)
                    posY -= 20
                Next
                contentByte.EndText()

                datosDerecha = ObtenerDatosDerecha(dataTabledetalles)
                contentByte.BeginText()
                contentByte.SetFontAndSize(BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1250, BaseFont.NOT_EMBEDDED), 8)
                posXDerecha = document.PageSize.Width - 280 ' Posición derecha superior
                posY = document.PageSize.Height - 500

                For i As Integer = 0 To datosDerecha.Count - 1
                    Dim dato As String = datosDerecha(i)
                    contentByte.SetTextMatrix(posXDerecha, posY)
                    contentByte.ShowText(dato)
                    posY -= 8
                    If (i + 1) Mod 37 = 0 Then
                        posY = document.PageSize.Height - 500
                        posXDerecha -= -100
                    End If
                Next
                contentByte.EndText()
                contentByte.AddTemplate(importedPage, 0, 0)

            Next
            document.Close()
        End Using

        reader.Close()
    End Sub

    Private Function ObtenerDatosIzquierda(ByVal dataTable As DataTable) As List(Of String)
        Dim datosIzquierda As New List(Of String)

        ' Obtener datos únicos para el lado izquierdo
        datosIzquierda.Add(dataTable.Rows(0)("empresa").ToString())
        datosIzquierda.Add(dataTable.Rows(0)("calle").ToString())
        datosIzquierda.Add(dataTable.Rows(0)("cp").ToString())
        datosIzquierda.Add(dataTable.Rows(0)("localidad").ToString())
        datosIzquierda.Add(dataTable.Rows(0)("provincia").ToString())

        Return datosIzquierda
    End Function
    Private Function ObtenerDatosDerecha(ByVal dataTable As DataTable) As List(Of String)
        Dim datosDerecha As New List(Of String)

        ' Obtener datos para el lado derecho
        For Each row As DataRow In dataTable.Rows
            datosDerecha.Add(row("nro_cart2").ToString())
        Next

        Return datosDerecha
    End Function

    Public Function CrearArchivos()

        ConfigCorreo.CN_Correo.InsertarEnArmPlanilla(DtppalDatos)

        For Each row As DataRow In DtppalDatos.Rows
            Dim EMPRESA As String = row("EMPRESA").ToString()
            Dim CALLE As String = row("CALLE").ToString()
            Dim TRABAJO As String = row("TRABAJO").ToString()
            Dim NROARM As String = row("NUMEROARM").ToString()

            Dim Dtdatosdetalle As New DataTable()
            Dtdatosdetalle = ConfigCorreo.CN_Correo.LlenarDatatableImprimirArmPorEmpresaYCalle(EMPRESA, CALLE, TRABAJO)

            ConfigCorreo.CN_Correo.InsertarEnArmDetalle(Dtdatosdetalle, NROARM)

            AgregarDatosAPDF(Dtdatosdetalle, NROARM)



        Next

        ConfigCorreo.CN_Correo.ActualizarNroPlanillaArm(nrointernoarm)

    End Function

    Public Function Combinar()
        Dim rutaCarpeta As String = "C:\temp"
        Dim archivoFinal As String = Path.Combine(rutaCarpeta, "archivo_final.pdf")

        Dim listaRutasArchivos As New List(Of String)()
        If File.Exists(archivoFinal) Then
            Try
                File.Delete(archivoFinal)
            Catch ex As Exception
            End Try
        End If

        CombinarPDFsEnCarpeta(rutaCarpeta, archivoFinal, listaRutasArchivos)
        MsgBox("Ok. Archivos combinados en 'archivo_final.pdf'.")
        EliminarArchivosEspecificos(listaRutasArchivos)
    End Function


    Sub CombinarPDFsEnCarpeta(rutaCarpeta As String, archivoFinal As String, ByRef listaRutasArchivos As List(Of String))
        Dim archivosPDF As String() = Directory.GetFiles(rutaCarpeta, "*.pdf")
        Dim documento As New Document()

        Try
            Dim copiaPDF As New PdfCopy(documento, New FileStream(archivoFinal, FileMode.Create))
            documento.Open()

            For Each archivo As String In archivosPDF
                Dim lectorPDF As New PdfReader(archivo)
                copiaPDF.AddDocument(lectorPDF)
                lectorPDF.Close()

                listaRutasArchivos.Add(archivo) ' Agregar la ruta del archivo a la lista
            Next

            documento.Close()
        Catch ex As Exception

        End Try
    End Sub

    Sub EliminarArchivosEspecificos(listaRutasArchivos As List(Of String))
        Try
            For Each rutaArchivo As String In listaRutasArchivos
                File.Delete(rutaArchivo)

            Next
        Catch ex As Exception

        End Try
    End Sub

    Sub AbrirArchivoFinal(archivoFinal As String)
        Try
            Process.Start(archivoFinal)
        Catch ex As Exception
            Console.WriteLine("Error al abrir el archivo: " & ex.Message)
        End Try
    End Sub


End Class
