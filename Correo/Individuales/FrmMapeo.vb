Imports System.Text.RegularExpressions
Imports System.Net
Imports System.IO
Imports Newtonsoft.Json.Linq
Imports Org.BouncyCastle.Math.EC
Imports Newtonsoft.Json


Public Class FrmMapeo



    Public dt2 As New DataTable

    Private Sub BtnConsultar_Click(sender As Object, e As EventArgs) Handles BtnConsultar.Click
        Dim palabras As Dictionary(Of String, String) = ConfigCorreo.CN_Correo.ReemplazarPalabras()
        Dim ultimaLatitud As Double = 0
        Dim ultimaLongitud As Double = 0

        ' Asegurar que la carpeta existe
        If Not Directory.Exists("C:\temp") Then
            Directory.CreateDirectory("C:\temp")
        End If

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

                Dim calleFinal As String = fila.Cells("callemodificada").Value.ToString()
                Dim alturaFinal As String = fila.Cells("altura").Value.ToString()
                Dim direccionCompleta As String = $"{calleFinal} {alturaFinal}, Ciudad Autonoma de Buenos Aires, {fila.Cells("cp").Value.ToString()}"

                Dim coordenadas As (lat As Double, lon As Double, jsonResponse As String) = (0, 0, "")
                Dim intentos As Integer = 0

                ' Intentar hasta 2 veces si la latitud y longitud son iguales a la fila anterior
                Do
                    coordenadas = GeocodeAddress(direccionCompleta)
                    intentos += 1
                Loop While intentos < 2 AndAlso coordenadas.lat = ultimaLatitud AndAlso coordenadas.lon = ultimaLongitud

                ' Si después de los intentos sigue devolviendo lo mismo, dejarlo en 0
                If coordenadas.lat = ultimaLatitud AndAlso coordenadas.lon = ultimaLongitud Then
                    coordenadas = (0, 0, "")
                End If

                fila.Cells("latitud").Value = coordenadas.lat
                fila.Cells("longitud").Value = coordenadas.lon

                ultimaLatitud = coordenadas.lat
                ultimaLongitud = coordenadas.lon

                DgvDatos.Refresh()
            End If
        Next
    End Sub

    Function GeocodeAddress(address As String) As (lat As Double, lon As Double, jsonResponse As String)
        Dim apiKey As String = "5b3ce3597851110001cf624826ff71dbb3bd48e6bae1e785f1b5ce93"
        Dim url As String = $"https://api.openrouteservice.org/geocode/search?api_key={apiKey}&text={Uri.EscapeDataString(address)}"

        Dim request As WebRequest = WebRequest.Create(url)
        Dim response As WebResponse = request.GetResponse()
        Dim dataStream As Stream = response.GetResponseStream()
        Dim reader As New StreamReader(dataStream)
        Dim responseFromServer As String = reader.ReadToEnd()

        Console.WriteLine("Response: " & responseFromServer)

        ' Guardar la respuesta en un archivo JSON
        GuardarJsonConsulta(responseFromServer)

        Dim json As JObject = JObject.Parse(responseFromServer)

        If json("features") IsNot Nothing AndAlso json("features").Count > 0 Then
            Dim lat As Double = json("features")(0)("geometry")("coordinates")(1)
            Dim lon As Double = json("features")(0)("geometry")("coordinates")(0)

            Console.WriteLine("Latitud: " & lat)
            Console.WriteLine("Longitud: " & lon)

            Return (lat, lon, responseFromServer)
        Else
            Console.WriteLine("No coordinates found for: " & address)
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




End Class
