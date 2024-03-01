Imports System.Data.OleDb
Imports System.Data.SQLite
Imports System.Text.RegularExpressions


Public Class FrmModoS

    Dim dttabla As New DataTable
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        impExcel()

    End Sub

    Private Function impExcel() As Boolean

        Dim dt2 As New DataTable
        dt2 = ConfigCorreo.CN_Correo.ObtenerEntregadasTodo


        Dim palabras As Dictionary(Of String, String) = ConfigCorreo.CN_Correo.ReemplazarPalabras()


        For Each row As DataRow In dt2.Rows
            Dim calle As String = row("calle").ToString()
            Dim modificada As String = calle

            For Each kvp As KeyValuePair(Of String, String) In palabras
                modificada = modificada.Replace(kvp.Key, kvp.Value)
            Next

            modificada = Regex.Replace(modificada, "[^a-zA-Z0-9\s]", "")

            row("calle") = modificada.ToUpper()
        Next

        dt2.Columns.Add("CalleModificada", GetType(String))
        dt2.Columns.Add("altura", GetType(String))

        For Each row As DataRow In dt2.Rows
            Dim calle As String = row("calle").ToString()
            Dim resultado As String = ExtractStreetAndNumber(calle)
            Dim valores As String() = resultado.Split(";"c)

            If valores.Length >= 1 Then
                row("CalleModificada") = valores(0)
            End If

            If valores.Length >= 2 Then
                row("altura") = valores(1)
            End If

        Next

        Dgvresultado.DataSource = dt2


        Return True
    End Function
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




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ExportarDataGridViewAExcel(Dgvresultado)
    End Sub
    Private Sub ExportarDataGridViewAExcel(ByVal dgv As DataGridView)
        Try
            ' Crear una nueva instancia de Excel
            Dim exApp As Object = CreateObject("Excel.Application")


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

            exApp.Visible = True


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al exportar a Excel")
        End Try
    End Sub

    Private Sub FrmModoS_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'dttabla = ConfigCorreo.CN_Correo.Obtenerfitrocaba
        'dgvtabla.DataSource = dttabla

    End Sub


End Class



