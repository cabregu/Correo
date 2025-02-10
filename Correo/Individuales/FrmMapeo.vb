Imports System.Text.RegularExpressions
Imports System.Net
Imports System.IO
Imports Newtonsoft.Json.Linq
Imports Org.BouncyCastle.Math.EC


Public Class FrmMapeo


    Public dt2 As New DataTable

    Private Sub BtnConsultar_Click(sender As Object, e As EventArgs) Handles BtnConsultar.Click

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


            End If

        Next
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
    End Sub
    Function GeocodeAddress(address As String) As (Double, Double)
        Dim apiKey As String = "5b3ce3597851110001cf624826ff71dbb3bd48e6bae1e785f1b5ce93"
        Dim url As String = $"https://api.openrouteservice.org/geocode/search?api_key={apiKey}&text={Uri.EscapeDataString(address)}"

        Dim request As WebRequest = WebRequest.Create(url)
        Dim response As WebResponse = request.GetResponse()
        Dim dataStream As Stream = response.GetResponseStream()
        Dim reader As New StreamReader(dataStream)
        Dim responseFromServer As String = reader.ReadToEnd()

        Dim json As JObject = JObject.Parse(responseFromServer)
        Dim lat As Double = json("features")(0)("geometry")("coordinates")(1)
        Dim lon As Double = json("features")(0)("geometry")("coordinates")(0)

        Return (lat, lon)
    End Function

    Function GetRoute(startLat As Double, startLon As Double, endLat As Double, endLon As Double) As String
        Dim apiKey As String = "TU_API_KEY"
        Dim url As String = $"https://api.openrouteservice.org/v2/directions/driving-car?api_key={apiKey}"

        Dim postData As String = $"{{""coordinates"":[[{startLon},{startLat}],[{endLon},{endLat}]]}}"
        Dim data As Byte() = System.Text.Encoding.UTF8.GetBytes(postData)

        Dim request As WebRequest = WebRequest.Create(url)
        request.Method = "POST"
        request.ContentType = "application/json"
        request.ContentLength = data.Length

        Using stream As Stream = request.GetRequestStream()
            stream.Write(data, 0, data.Length)
        End Using

        Dim response As WebResponse = request.GetResponse()
        Dim dataStream As Stream = response.GetResponseStream()
        Dim reader As New StreamReader(dataStream)
        Dim responseFromServer As String = reader.ReadToEnd()

        Return responseFromServer
    End Function

    Public Class FrmMapeo
        ' Función para obtener las coordenadas (latitud y longitud) de una dirección
        Function GeocodeAddress(address As String) As (Double, Double)
            Dim apiKey As String = "5b3ce3597851110001cf624826ff71dbb3bd48e6bae1e785f1b5ce93"
            Dim url As String = $"https://api.openrouteservice.org/geocode/search?api_key={apiKey}&text={Uri.EscapeDataString(address)}"

            Dim request As WebRequest = WebRequest.Create(url)
            Dim response As WebResponse = request.GetResponse()
            Dim dataStream As Stream = response.GetResponseStream()
            Dim reader As New StreamReader(dataStream)
            Dim responseFromServer As String = reader.ReadToEnd()

            Dim json As JObject = JObject.Parse(responseFromServer)
            Dim lat As Double = json("features")(0)("geometry")("coordinates")(1)
            Dim lon As Double = json("features")(0)("geometry")("coordinates")(0)

            Return (lat, lon)
        End Function

        ' Función para obtener la ruta entre dos puntos
        Function GetRoute(startLat As Double, startLon As Double, endLat As Double, endLon As Double) As String
            Dim apiKey As String = "5b3ce3597851110001cf624826ff71dbb3bd48e6bae1e785f1b5ce93"
            Dim url As String = $"https://api.openrouteservice.org/v2/directions/driving-car?api_key={apiKey}"

            Dim postData As String = $"{{""coordinates"":[[{startLon},{startLat}],[{endLon},{endLat}]]}}"
            Dim data As Byte() = System.Text.Encoding.UTF8.GetBytes(postData)

            Dim request As WebRequest = WebRequest.Create(url)
            request.Method = "POST"
            request.ContentType = "application/json"
            request.ContentLength = data.Length

            Using stream As Stream = request.GetRequestStream()
                stream.Write(data, 0, data.Length)
            End Using

            Dim response As WebResponse = request.GetResponse()
            Dim dataStream As Stream = response.GetResponseStream()
            Dim reader As New StreamReader(dataStream)
            Dim responseFromServer As String = reader.ReadToEnd()

            Return responseFromServer
        End Function


    End Class

    Private Sub Btnmapeo_Click(sender As Object, e As EventArgs) Handles Btnmapeo.Click
        Try

            Dim startAddress As String = "Calle Falsa 123, Ciudad A"
            Dim endAddress As String = "Avenida Siempre Viva 742, Ciudad B"


            Dim startCoordinates = GeocodeAddress(startAddress)
            Dim endCoordinates = GeocodeAddress(endAddress)

            Dim startLat As Double = startCoordinates.Item1
            Dim startLon As Double = startCoordinates.Item2
            Dim endLat As Double = endCoordinates.Item1
            Dim endLon As Double = endCoordinates.Item2


            Dim routeJson As String = GetRoute(startLat, startLon, endLat, endLon)


            Dim htmlContent As String = $"
            <!DOCTYPE html>
            <html>
            <head>
                <title>Mapa de Ruta</title>
                <script src='https://unpkg.com/leaflet@1.7.1/dist/leaflet.js'></script>
                <link rel='stylesheet' href='https://unpkg.com/leaflet@1.7.1/dist/leaflet.css' />
            </head>
            <body>
                <div id='map' style='width: 100%; height: 100%;'></div>
                <script>
                    var map = L.map('map').setView([{startLat}, {startLon}], 13);
                    L.tileLayer('https://{{s}}.tile.openstreetmap.org/{{z}}/{{x}}/{{y}}.png', {{
                        maxZoom: 19
                    }}).addTo(map);

                    var route = {routeJson};
                    var coordinates = route.features[0].geometry.coordinates.map(function(coord) {{
                        return [coord[1], coord[0]];
                    }});

                    L.polyline(coordinates, {{color: 'blue'}}).addTo(map);
                    L.marker([{startLat}, {startLon}]).addTo(map).bindPopup('Inicio').openPopup();
                    L.marker([{endLat}, {endLon}]).addTo(map).bindPopup('Destino').openPopup();
                </script>
            </body>
            </html>"


            Dim tempFilePath As String = IO.Path.Combine(IO.Path.GetTempPath(), "map.html")
            IO.File.WriteAllText(tempFilePath, htmlContent)


            WebBrowser1.Navigate(tempFilePath)

        Catch ex As Exception
            MessageBox.Show("Ocurrió un error: " & ex.Message)
        End Try
    End Sub


End Class
