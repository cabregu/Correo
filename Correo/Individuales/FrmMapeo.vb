Imports System.Text.RegularExpressions
Imports System.Net
Imports System.IO
Imports Newtonsoft.Json.Linq
Imports Org.BouncyCastle.Math.EC
Imports Newtonsoft.Json
Imports Microsoft.Office.Interop
Imports System.Data.OleDb


Public Class FrmMapeo



    Public dt2 As New DataTable

    Private Sub BtnConsultar_Click(sender As Object, e As EventArgs) Handles BtnConsultar.Click

        If Not DgvDatos.Columns.Contains("direccionCompleta") Then
            Dim colDireccionCompleta As New DataGridViewTextBoxColumn()
            colDireccionCompleta.Name = "direccionCompleta"
            colDireccionCompleta.HeaderText = "Dirección Completa"
            DgvDatos.Columns.Add(colDireccionCompleta)
        End If

        ProcesarDirecciones()




    End Sub


    Private Sub ProcesarDirecciones()
        Dim palabras As Dictionary(Of String, String) = ConfigCorreo.CN_Correo.ReemplazarPalabras()

        For Each fila As DataGridViewRow In DgvDatos.Rows
            If Not fila.IsNewRow Then
                Dim calle As String = fila.Cells("calle").Value.ToString()
                Dim modificada As String = calle

                ' Eliminar caracteres no alfanuméricos
                modificada = Regex.Replace(modificada, "[^a-zA-Z0-9\s]", "")

                ' Reemplazar palabras según el diccionario
                For Each kvp As KeyValuePair(Of String, String) In palabras
                    modificada = modificada.Replace(kvp.Key, kvp.Value)
                Next

                ' Usar la función optimizada para extraer calle y número
                Dim resultado As String = ExtractStreetAndNumber(modificada)
                Dim valores As String() = resultado.Split(";"c)

                ' Asignar los valores extraídos a las celdas correspondientes
                If valores.Length >= 1 Then
                    fila.Cells("callemodificada").Value = valores(0)
                End If
                If valores.Length >= 2 Then
                    fila.Cells("altura").Value = valores(1)
                End If

                Dim calleFinal As String = fila.Cells("callemodificada").Value.ToString()
                Dim alturaFinal As String = fila.Cells("altura").Value.ToString()

                ' Obtener el código postal y verificar si está en el rango de Capital Federal
                Dim codigoPostal As Integer
                If Integer.TryParse(fila.Cells("cp").Value.ToString(), codigoPostal) Then
                    Dim esCapitalFederal As Boolean = (codigoPostal >= 1000 AndAlso codigoPostal <= 1440)

                    ' Construir la dirección completa
                    Dim direccionCompleta As String
                    If esCapitalFederal Then
                        direccionCompleta = $"{calleFinal} {alturaFinal}, {fila.Cells("localidad").Value.ToString()}, {fila.Cells("cp").Value.ToString()}, Capital Federal"
                    Else
                        direccionCompleta = $"{calleFinal} {alturaFinal}, {fila.Cells("localidad").Value.ToString()}, {fila.Cells("cp").Value.ToString()}"
                    End If

                    ' Guardar la dirección completa en la columna "direccionCompleta"
                    fila.Cells("direccionCompleta").Value = direccionCompleta
                Else
                    ' Si el código postal no es válido, manejar el caso (opcional)
                    fila.Cells("direccionCompleta").Value = "Código postal inválido"
                End If
            End If
        Next
    End Sub

    Private Sub ObtenerCoordenadas()
        Dim ultimaLatitud As Double = 0
        Dim ultimaLongitud As Double = 0

        For Each fila As DataGridViewRow In DgvDatos.Rows
            If Not fila.IsNewRow Then
                Dim direccionCompleta As String = fila.Cells("direccionCompleta").Value.ToString()

                Dim coordenadas As (lat As Double, lon As Double, jsonResponse As String) = (0, 0, "")
                Dim intentos As Integer = 0

                ' Intentar hasta 2 veces si la latitud y longitud son iguales a la fila anterior
                Do
                    coordenadas = GeocodeAddressOpenCage(direccionCompleta)
                    intentos += 1
                Loop While intentos < 2 AndAlso coordenadas.lat = ultimaLatitud AndAlso coordenadas.lon = ultimaLongitud

                ' Si después de los intentos sigue devolviendo lo mismo, dejarlo en 0
                If coordenadas.lat = ultimaLatitud AndAlso coordenadas.lon = ultimaLongitud Then
                    coordenadas = (0, 0, "")
                End If

                ' Asignar las coordenadas a las celdas correspondientes
                fila.Cells("latitud").Value = coordenadas.lat
                fila.Cells("longitud").Value = coordenadas.lon

                ultimaLatitud = coordenadas.lat
                ultimaLongitud = coordenadas.lon

                DgvDatos.Refresh()
            End If
        Next
    End Sub


    Public Function ExtractStreetAndNumber(address As String) As String

        Dim patterns As String() = {"11 DE SEPTIEMBRE DE 1888 ", "11 DE SEPTIEMBRE ", "25 DE MAYO ", "9 DE JULIO ", "3 DE FEBRERO ", "12 DE OCTUBRE ", "15 DE NOVIEMBRE DE 1889 ", "20 DE SEPTIEMBRE ", "33 ORIENTALES ", "24 DE NOVIEMBRE ", "29 DE SEPTIEMBRE ", "1 DE MAYO ", "2 DE MAYO ", "14 DE JULIO ", "24 DE MAYO ", "30 DE SEPTIEMBRE ", "1 DE MARZO ", "15 DE NOVIEMBRE ", "2 DE ABRIL ", "20 DE FEBRERO "}

        For Each pattern As String In patterns
            If address.ToUpper().Contains(pattern.ToUpper()) Then
                Dim calleSinPatron As String = address.Replace(pattern, "").Trim()
                Dim numero As String = Regex.Match(calleSinPatron, "^\d+").Value
                Return pattern.Trim() & ";" & numero
            End If
        Next

        Dim components As String() = address.Split(New Char() {" "}, StringSplitOptions.RemoveEmptyEntries)
        Dim street As String = ""
        Dim number As String = ""
        For Each component As String In components
            If IsNumeric(component) Then
                number = component
                Exit For
            End If
            street += component + " "
        Next

        Return street.Trim() & ";" & number
    End Function


    Function GeocodeAddressOpenCage(address As String) As (lat As Double, lon As Double, jsonResponse As String)
        Dim apiKey As String = "06294befae2748c9aaa477185cf7bf7c"
        Dim url As String = $"https://api.opencagedata.com/geocode/v1/json?q={Uri.EscapeDataString(address)}&key={apiKey}"

        Dim request As WebRequest = WebRequest.Create(url)
        Dim response As WebResponse = request.GetResponse()
        Dim dataStream As Stream = response.GetResponseStream()
        Dim reader As New StreamReader(dataStream)
        Dim responseFromServer As String = reader.ReadToEnd()


        ' Guardar la respuesta en un archivo JSON (opcional)
        GuardarJsonConsulta(responseFromServer)


        Dim json As JObject = JObject.Parse(responseFromServer)


        If json("results") IsNot Nothing AndAlso json("results").Count > 0 Then

            Dim lat As Double = json("results")(0)("geometry")("lat")
            Dim lon As Double = json("results")(0)("geometry")("lng")
            Console.WriteLine("Latitud: " & lat)
            Console.WriteLine("Longitud: " & lon)

            Return (lat, lon, responseFromServer)
        Else
            Return (0, 0, responseFromServer)
        End If

    End Function


    Sub GuardarJsonConsulta(jsonResponse As String)
        Try
            Dim timestamp As String = DateTime.Now.ToString("dd-MM-yyyy-HH-mm-ss-fff")
            Dim fileName As String = $"C:\temp\consulta_{timestamp}.json"

            File.WriteAllText(fileName, jsonResponse)
        Catch ex As Exception
            Console.WriteLine("Error al guardar el JSON: " & ex.Message)
        End Try
    End Sub



    Private Sub FrmMapeo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DgvDatos.DataSource = dt2

        dt2.Columns.Add("callemodificada")
        dt2.Columns.Add("altura")
        dt2.Columns.Add("latitud")
        dt2.Columns.Add("longitud")

    End Sub


    Private Sub Btnmapeo_Click(sender As Object, e As EventArgs) Handles Btnmapeo.Click
        Try
            ' Crear lista para almacenar los puntos
            Dim puntos As New List(Of Dictionary(Of String, String))()

            ' Recorrer los datos de la tabla
            For Each row As DataRow In dt2.Rows
                ' Asegurarse de que latitud y longitud tengan valor
                Dim latitud As String = If(row("latitud") IsNot DBNull.Value, row("latitud").ToString(), "")
                Dim longitud As String = If(row("longitud") IsNot DBNull.Value, row("longitud").ToString(), "")
                Dim nro_carta As String = row("nro_carta").ToString()
                Dim calle As String = row("callemodificada").ToString()

                ' Solo agregar el punto si tiene latitud y longitud
                If Not String.IsNullOrEmpty(latitud) AndAlso Not String.IsNullOrEmpty(longitud) Then
                    Dim punto As New Dictionary(Of String, String) From {
                        {"calle", calle},
                        {"altura", row("altura").ToString()},
                        {"localidad", row("localidad").ToString()},
                        {"cp", row("cp").ToString()},
                        {"latitud", latitud},
                        {"longitud", longitud},
                        {"nro_carta", nro_carta},
                        {"callemodificada", calle}
                    }
                    puntos.Add(punto)
                End If
            Next

            ' Serializar a JSON
            Dim json As String = JsonConvert.SerializeObject(puntos)

            ' Enviar JSON al PHP
            Dim url As String = "https://www.lexs.com.ar/map_data.php"
            Dim request As HttpWebRequest = CType(WebRequest.Create(url), HttpWebRequest)
            request.Method = "POST"
            request.ContentType = "application/json"

            Using streamWriter As New StreamWriter(request.GetRequestStream())
                streamWriter.Write(json)
                streamWriter.Flush()
                streamWriter.Close()
            End Using

            ' Recibir respuesta del servidor
            Dim response As HttpWebResponse = CType(request.GetResponse(), HttpWebResponse)
            Using streamReader As New StreamReader(response.GetResponseStream())
                Dim result As String = streamReader.ReadToEnd()
                MessageBox.Show("Datos enviados correctamente")
            End Using

            ' Esperar 1 segundo para asegurar que los datos se guardaron antes de abrir el mapa
            System.Threading.Thread.Sleep(1000)

            ' Abrir el mapa en el navegador predeterminado
            Process.Start(New ProcessStartInfo With {
                .FileName = "https://www.lexs.com.ar/map_data.php",
                .UseShellExecute = True
            })

        Catch ex As Exception
            MessageBox.Show("Ocurrió un error: " & ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ObtenerCoordenadas()
    End Sub



    Private Sub BtnOpen_Click(sender As Object, e As EventArgs) Handles BtnOpen.Click
        Seleccionar()
    End Sub

    Private Sub Seleccionar()
        Dim openFD As New OpenFileDialog()
        With openFD
            .Title = "Seleccionar archivo de Excel"
            .Filter = "Archivos de Excel (*.xls;*.xlsx)|*.xls;*.xlsx"
            .Multiselect = False
            .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
            If .ShowDialog = Windows.Forms.DialogResult.OK Then

                Dim dt As DataTable = CargarDatosDesdeExcel(.FileName)

                DgvDatos.DataSource = dt
            End If
        End With
    End Sub



    Private Function CargarDatosDesdeExcel(ByVal ruta As String) As DataTable
        Dim dt As New DataTable()

        Try
            ' Obtener el nombre de la primera hoja


            ' Cadena de conexión para archivos Excel
            Dim strConn As String
            If ruta.EndsWith(".xls") Then
                ' Para archivos Excel 97-2003
                strConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & ruta & ";Extended Properties=""Excel 8.0;HDR=Yes;IMEX=1"""
            ElseIf ruta.EndsWith(".xlsx") Then
                ' Para archivos Excel 2007 o superior
                strConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & ruta & ";Extended Properties=""Excel 12.0 Xml;HDR=Yes;IMEX=1"""
            Else
                Throw New Exception("Formato de archivo no soportado.")
            End If

            ' Conexión y consulta
            Using conn As New OleDbConnection(strConn)
                Dim query As String = "SELECT * FROM [" & "libro" & "$]"
                Dim adapter As New OleDbDataAdapter(query, conn)
                conn.Open()
                adapter.Fill(dt)
            End Using

        Catch ex As Exception
            MessageBox.Show("Error al cargar los datos desde Excel: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return dt
    End Function





End Class
