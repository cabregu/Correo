Imports MySql.Data.MySqlClient
Imports PdfSharp.Drawing
Imports PdfSharp.Pdf
Imports System.Globalization
Imports System.IO

Public Class FrmRemitosLexs

    Dim NroRemito As Integer = 0
    Dim empresa As String = ""
    Dim direccion As String = ""
    Dim sector As String = ""
    Private Sub PbRemito_Click(sender As Object, e As EventArgs) Handles PbRemito.Click
        ' Obtén las coordenadas del mouse en relación con el formulario
        Dim mousePosition As Point = PbRemito.PointToClient(Control.MousePosition)
        Dim mouseX As Integer = mousePosition.X
        Dim mouseY As Integer = mousePosition.Y

        ' Muestra las coordenadas del mouse en un cuadro de mensaje
        MessageBox.Show("Ubicación del mouse: X=" & mouseX & ", Y=" & mouseY)
    End Sub
    Private Sub FrmRemitosLexs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim imagenPrincipal As Image = New Bitmap(My.Resources.RemitoLexs)
        PbRemito.Image = imagenPrincipal
        PbRemito.SizeMode = PictureBoxSizeMode.AutoSize

        cargarremitos()


        Dim contextMenuStrip As New ContextMenuStrip()
        Dim marcarMenuItem As New ToolStripMenuItem("No se Importa")
        AddHandler marcarMenuItem.Click, AddressOf MarcarMenuItem_Click
        contextMenuStrip.Items.Add(marcarMenuItem)
        DgvRemitos.ContextMenuStrip = contextMenuStrip
    End Sub

    Public Sub cargarremitos()

        Dim Dt As New DataTable
        Dt = ConfigCorreo.CN_Correo.ObtenerRemitosLexs
        DgvRemitos.DataSource = Nothing
        DgvRemitos.DataSource = Dt

        For Each row As DataGridViewRow In DgvRemitos.Rows
            If Not row.IsNewRow Then ' Para evitar la fila de nuevos datos (si existe)
                Dim remito As String = row.Cells("NroRemito").Value.ToString()
                Dim existeEnBD As Boolean = ConfigCorreo.CN_Correo.VerificarSiEstaIngresadoEnCartas(remito)
                If existeEnBD Then
                    row.DefaultCellStyle.BackColor = Color.GreenYellow
                Else
                    If ConfigCorreo.CN_Correo.VerificarSiEstaMarcadoParaNoIngresarRemito(remito) = True Then
                        row.DefaultCellStyle.BackColor = Color.GreenYellow
                    End If

                End If
            End If
        Next
    End Sub

    Private Sub DgvRemitos_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DgvRemitos.CellMouseDown
        If e.Button = MouseButtons.Right AndAlso e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            DgvRemitos.ClearSelection()
            DgvRemitos.Rows(e.RowIndex).Cells(e.ColumnIndex).Selected = True
            Dim mousePosition As Point = DgvRemitos.PointToClient(Cursor.Position)
            DgvRemitos.ContextMenuStrip.Show(DgvRemitos, mousePosition)
        End If
    End Sub

    Private Sub MarcarMenuItem_Click(sender As Object, e As EventArgs)
        If DgvRemitos.SelectedCells.Count > 0 Then
            Dim numeroSeleccionado As String = DgvRemitos.SelectedCells(0).Value.ToString()

            ConfigCorreo.CN_Correo.ActualizarEstadoPorRemito(numeroSeleccionado)
            cargarremitos()

        End If
    End Sub

    Private Sub BtnDibujar_Click(sender As Object, e As EventArgs) Handles BtnConfirmar.Click

        If CmbRemitente.Text.ToString = "SWISSC" Then
            empresa = "SWISS MEDICAL"
            direccion = "ARMADO Y DISTRIBUCION"
            sector = "SECTOR CREDENCIALES AT:ROMINA ARRIETA"

        ElseIf CmbRemitente.Text.ToString = "SWCPFM" Then

            empresa = "SWISS MEDICAL S.A."
            direccion = "SAN MARTIN 323"
            sector = "SECTOR FACTURACIÓN"

        End If
        DibujarEnImagen(empresa, direccion, sector)
        BtnPegar.Enabled = True
        BtnConfirmar.Enabled = False

    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click

        NroRemito = ConfigCorreo.CN_Correo.ObtenerNroPlanillaOrdenDeRetiro
        TxtRemito.Text = NroRemito
        CmbRemitente.Enabled = True

        CheckForIllegalCrossThreadCalls = False
        Dim Servicios As New ArrayList
        Servicios = ConfigCorreo.CN_Correo.CargarTodoslosServicios
        CmbRemitente.Items.Clear()
        For i As Integer = 0 To Servicios.Count - 1
            CmbRemitente.Items.Add(Servicios.Item(i).ToString)
        Next

    End Sub

    Private Sub DibujarEnImagen(ByVal empre As String, ByVal dire As String, ByVal sect As String)
        ' Obtén los valores del TextBox y otras variables
        Dim numero As String = TxtRemito.Text
        Dim fecha As Date = DtpDesde.Value
        Dim empresa As String = empre
        Dim direccion As String = dire
        Dim sector As String = sect

        ' Configura la fuente y el color del texto
        Dim fuente As New Font("Arial", 12, FontStyle.Bold)
        Dim colorTexto As Color = Color.Black

        ' Crea una imagen con el tamaño actual del PictureBox
        Dim bmp As New Bitmap(PbRemito.Width, PbRemito.Height)

        ' Dibuja el texto en la posición deseada
        Using g As Graphics = Graphics.FromImage(bmp)
            g.DrawImage(PbRemito.Image, Point.Empty) ' Copia la imagen original al nuevo Bitmap

            ' Dibujar el número en la posición deseada
            Dim numeroPosicion As New PointF(545, 57)
            g.DrawString("0001-" & numero, fuente, New SolidBrush(colorTexto), numeroPosicion)

            ' Dibujar el texto adicional en ubicaciones diferentes
            Dim textoPosicion As New PointF(201, 142)
            g.DrawString(empresa, fuente, New SolidBrush(colorTexto), textoPosicion)

            ' Otros elementos de texto y ubicaciones
            textoPosicion = New PointF(201, 160)
            g.DrawString(direccion, fuente, New SolidBrush(colorTexto), textoPosicion)

            textoPosicion = New PointF(218, 198)
            g.DrawString(sector, fuente, New SolidBrush(colorTexto), textoPosicion)

            ' Dibujar la fecha en la posición deseada
            Dim fechaPosicion As New PointF(546, 106)
            g.DrawString(fecha.ToShortDateString(), fuente, New SolidBrush(colorTexto), fechaPosicion)
        End Using

        PbRemito.Image = bmp
    End Sub
    Private Sub PegarImagenDesdePortapapeles()
        ' Verificar si hay una imagen en el portapapeles
        If Clipboard.ContainsImage() Then
            ' Obtener la imagen del portapapeles
            Dim imagen As Image = Clipboard.GetImage()

            ' Redimensionar la imagen al tamaño deseado
            imagen = New Bitmap(imagen, New Size(603, 161))

            ' Crear una imagen con el tamaño actual del PictureBox
            Dim bmp As New Bitmap(PbRemito.Width, PbRemito.Height)

            ' Dibujar la imagen original en el nuevo Bitmap
            Using g As Graphics = Graphics.FromImage(bmp)
                g.DrawImage(PbRemito.Image, Point.Empty)

                ' Dibujar la imagen redimensionada del portapapeles en la ubicación deseada (92X314)
                g.DrawImage(imagen, New Rectangle(88, 251, imagen.Width, imagen.Height))
            End Using

            ' Asignar el nuevo Bitmap al PictureBox
            PbRemito.Image = bmp
            PbRemito.SizeMode = PictureBoxSizeMode.AutoSize

            BtnGuardar.Enabled = True

        Else
            ' No se encontró una imagen en el portapapeles
            MessageBox.Show("No hay una imagen válida en el portapapeles.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            BtnPegar.Enabled = True


        End If
    End Sub

    Private Sub BtnCofirmar_Click(sender As Object, e As EventArgs)

        If NroRemito <> 0 Then
            ConfigCorreo.CN_Correo.ActualizarNroPlanillaDevolucion(NroRemito + 1)
        End If


    End Sub

    Private Sub BtnPegar_Click(sender As Object, e As EventArgs) Handles BtnPegar.Click

        BtnPegar.Enabled = False

        PegarImagenDesdePortapapeles()



    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click


        GuardarPictureBoxComoPDF(PbRemito, "C:\temp\OrdenDeRetiro_" & TxtRemito.Text & "_" & DtpDesde.Value.ToShortDateString.Replace("/", "-") & ".pdf", TxtRemito.Text, CmbRemitente.Text, DtpDesde.Value.ToShortDateString)
        ConfigCorreo.CN_Correo.ActualizarNroRemitoConfig(NroRemito + 1)
        Me.Close()

    End Sub
    Private Sub CmbRemitente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbRemitente.SelectedIndexChanged

        DtpDesde.Enabled = True
        BtnConfirmar.Enabled = True


    End Sub

    Private Sub GuardarPictureBoxComoPDF(pictureBox As PictureBox, rutaArchivo As String, nroRemito As String, remitente As String, fecha As String)
        Dim document As New PdfDocument()
        Dim page As PdfPage = document.AddPage()
        Dim pageSize As Size = New Size(CInt(page.Width.Value), CInt(page.Height.Value))
        Dim gfx As XGraphics = XGraphics.FromPdfPage(page)
        Dim imagen As Image = pictureBox.Image
        Dim imageStream As New MemoryStream()
        imagen.Save(imageStream, System.Drawing.Imaging.ImageFormat.Png)
        imageStream.Position = 0
        Dim xImage As XImage = XImage.FromStream(imageStream)
        Dim adjustedSize As Size = CalculateProportionalSize(imagen.Size, pageSize)
        Dim position As New XPoint(10, 10)
        gfx.DrawImage(xImage, position.X, position.Y, adjustedSize.Width, adjustedSize.Height)
        document.Save(rutaArchivo)
        document.Close()

        Dim archivoBytes As Byte() = File.ReadAllBytes(rutaArchivo)

        Dim formatosFecha() As String = {"dd/MM/yyyy", "d/M/yyyy", "dd/M/yyyy", "d/MM/yyyy"} ' Lista de posibles formatos de fecha
        Dim fechaObjeto As DateTime
        For Each formato As String In formatosFecha
            If DateTime.TryParseExact(fecha, formato, CultureInfo.InvariantCulture, DateTimeStyles.None, fechaObjeto) Then
                Exit For ' Si se pudo analizar la fecha en el formato actual, salir del bucle
            End If
        Next
        Dim fechaFormateada As String = fechaObjeto.ToString("yyyy-MM-dd")
        ConfigCorreo.CN_Correo.InsertarRemitoLexs(nroRemito, remitente, fechaFormateada, archivoBytes, "Ingresado")
    End Sub


    Private Function CalculateProportionalSize(originalSize As Size, maxSize As Size) As Size
        Dim widthRatio As Double = maxSize.Width / originalSize.Width
        Dim heightRatio As Double = maxSize.Height / originalSize.Height
        Dim ratio As Double = Math.Min(widthRatio, heightRatio)
        Dim width As Integer = CInt(originalSize.Width * ratio)
        Dim height As Integer = CInt(originalSize.Height * ratio)
        Return New Size(width, height)
    End Function


    Private Sub VerArchivo(ByVal numeroRemito As String)

        Dim archivos As List(Of Byte()) = ConfigCorreo.CN_Correo.ObtenerArchivosPorNroRemito(numeroRemito)

        If archivos.Count > 0 Then

            Using memoryStream As New MemoryStream(archivos(0))

                Dim tempFilePath As String = Path.ChangeExtension(Path.GetTempFileName(), ".pdf")
                File.WriteAllBytes(tempFilePath, memoryStream.ToArray())

                Process.Start(New ProcessStartInfo With {
                .FileName = tempFilePath,
                .UseShellExecute = True
            })
            End Using
        Else
            MsgBox("No se encontraron archivos para el número de remito especificado.")
        End If
    End Sub

    Private Sub DgvRemitos_DoubleClick(sender As Object, e As EventArgs) Handles DgvRemitos.DoubleClick

        Dim N As String = DgvRemitos.SelectedCells(0).RowIndex.ToString
        Dim Remito As String = DgvRemitos.Rows(N).Cells("Nroremito").Value
        VerArchivo(Remito)

    End Sub



    Private Sub BtnGuardarArchivos_Click(sender As Object, e As EventArgs) Handles BtnRemitos.Click
        ' Obtiene los valores de los TextBox
        Dim remitoDesde As Integer
        Dim remitoHasta As Integer

        ' Validación de entrada para asegurarse de que los valores son números
        If Not Integer.TryParse(TxtRemitoDesde.Text, remitoDesde) OrElse Not Integer.TryParse(TxtRemitoHasta.Text, remitoHasta) Then
            MsgBox("Por favor, ingrese números válidos en los campos.")
            Return
        End If

        ' Asegurarse de que el rango sea correcto
        If remitoDesde > remitoHasta Then
            MsgBox("El número de remito 'Desde' no puede ser mayor que 'Hasta'.")
            Return
        End If

        ' Iterar desde el número de remito 'Desde' hasta 'Hasta'
        For i As Integer = remitoDesde To remitoHasta
            GuardarArchivoPorRemito(i.ToString())
        Next

        MsgBox("Archivos guardados correctamente en C:\temp.")
    End Sub

    Private Sub GuardarArchivoPorRemito(ByVal numeroRemito As String)
        ' Obtener los archivos para el número de remito proporcionado
        Dim archivos As List(Of Byte()) = ConfigCorreo.CN_Correo.ObtenerArchivosPorNroRemito(numeroRemito)

        If archivos.Count > 0 Then
            ' Asegurar que la carpeta de destino siempre sea C:\temp
            Dim carpetaDestino As String = "C:\temp"
            If Not Directory.Exists(carpetaDestino) Then
                Directory.CreateDirectory(carpetaDestino)
            End If

            For Each archivoBytes As Byte() In archivos
                ' Crear un MemoryStream a partir del archivo
                Using memoryStream As New MemoryStream(archivoBytes)
                    ' Crear un nombre de archivo basado en el número de remito
                    Dim nombreArchivo As String = Path.Combine(carpetaDestino, $"Remito_{numeroRemito}.pdf")

                    ' Guardar el archivo en la carpeta especificada
                    File.WriteAllBytes(nombreArchivo, memoryStream.ToArray())
                End Using
            Next
        Else
            MsgBox($"No se encontraron archivos para el número de remito: {numeroRemito}.")
        End If
    End Sub




End Class
