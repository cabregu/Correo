Imports System.Data.OleDb
Imports System.Windows.Forms
Imports System.IO
Imports ConfigCorreo.CN_Correo

'Imports Microsoft.Office.Interop.Outlook
'Imports Microsoft.Office.Interop
Imports System.Net.Mail
Imports Microsoft.Office.Interop

Public Class FrmPendientes
    Dim dtnew As New DataTable

    Private Shared Function Normalizar(ByVal Dato As String) As String
        Dato = Dato.Replace("-", "")
        Dato = Dato.Replace("  ", "")
        Dato = Dato.Replace("30/12/1899", "")
        Dato = Dato.Replace(" 0:00:00", "")
        Dato = Dato.Replace("'", "")
        Dato = Dato.Replace(",", "")
        Return Dato
    End Function
    Private Sub FrmPendientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim ArrCarteros As New ArrayList
        ArrCarteros = cargarCarterosmail()
        CmbCarteros.Items.Clear()
        For i = 0 To ArrCarteros.Count - 1
            CmbCarteros.Items.Add(ArrCarteros.Item(i).ToString)
        Next


    End Sub


    Private Sub BtnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnConsultar.Click

        DgvDatos.DataSource = Nothing
        DgvDatos.Columns.Clear()

        Lblcartero.Text = "CARTERO"
        Lblcant.Text = "0"


        Dim fechahoy As Date
        fechahoy = Now.ToShortDateString

        Dim DtPendiente As DataTable = Nothing


        If Len(CmbCarteros.Text) > 0 Then
            DtPendiente = ObtenerPendeintesPorCartero(CmbCarteros.Text)

            For i As Integer = DtPendiente.Rows.Count - 1 To 0 Step -1
                If DtPendiente.Rows(i)("Obs2").ToString().Contains("MODO S") Then
                    DtPendiente.Rows.RemoveAt(i)
                End If
            Next

            '************* a partir de aqui eliminar fecha_trabajo y obs2*****************
            '*******************************************************

            DtPendiente.Columns.Remove("fecha_trabajo")
            DtPendiente.Columns.Remove("obs2")

            DtPendiente.Columns("fecha_recorrido").DataType = GetType(Date)
            DtPendiente.DefaultView.Sort = "fecha_recorrido ASC"
            DtPendiente = DtPendiente.DefaultView.ToTable()

            DgvDatos.DataSource = DtPendiente
            DgvDatos.Columns("fecha_recorrido").DefaultCellStyle.Format = "dd/MM/yyyy"

            Lblcartero.Text = CmbCarteros.Text
            Lblcant.Text = DgvDatos.Rows.Count

        End If





    End Sub



    Private Sub Btnxls_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGeneraryenviar.Click

        If Len(CmbCarteros.Text) > 0 And DgvDatos.Rows.Count > 0 And CmbCarteros.Text = Lblcartero.Text Then
            Dim numero As Integer
            numero = ObtenerNroPendiente(CmbCarteros.Text)

            Dim NombreArch As String
            NombreArch = ExcelPendientes(CmbCarteros.Text, numero)

            If MessageBox.Show("Archivo generado correctamente desea enviar mail?", "Enviar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                'enviaCorreo(NombreArch, "Se Adjunta pendientes " & CmbCarteros.Text, CmbCarteros.Text)

                'EnviarCorreoSinOutlook(CmbCarteros.Text, NombreArch)
                ActualizarNroPendiente(CmbCarteros.Text, numero + 1)

            End If


        Else

            MsgBox("Debe realizar la consulta antes de generar y enviar")

        End If
        'End If



    End Sub
    'Private Function ExcelPendientes(ByVal Cartero As String, ByVal Nro As Integer) As String
    '    'Agregar referencia Microsoft.Office.Interop.Excel()
    '    'Creamos las variables

    '    Dim exApp As New Microsoft.Office.Interop.Excel.Application
    '    Dim exLibro As Microsoft.Office.Interop.Excel.Workbook
    '    Dim exHoja As Microsoft.Office.Interop.Excel.Worksheet

    '    'Añadimos el Libro al programa, y la hoja al libro
    '    exLibro = exApp.Workbooks.Add
    '    exHoja = exLibro.Worksheets.Add()
    '    exHoja.Cells.NumberFormat = "@"
    '    ' ¿Cuantas columnas y cuantas filas?
    '    Dim NCol As Integer = DgvDatos.ColumnCount
    '    Dim NRow As Integer = DgvDatos.RowCount


    '    'Aqui recorremos todas las filas, y por cada fila todas las columnas y vamos escribiendo.
    '    For i As Integer = 1 To NCol
    '        exHoja.Cells.Item(1, i) = DgvDatos.Columns(i - 1).Name.ToString
    '        'exHoja.Cells.Item(1, i).HorizontalAlignment = 3
    '    Next

    '    For Fila As Integer = 0 To NRow - 1
    '        For Col As Integer = 0 To NCol - 1
    '            exHoja.Cells.Item(Fila + 2, Col + 1) = DgvDatos.Rows(Fila).Cells(Col).Value
    '        Next
    '    Next
    '    'Titulo en negrita, Alineado al centro y que el tamaño de la columna se
    '    'ajuste al texto


    '    'exHoja.Rows.Item(5).Font.Bold = 1
    '    'exHoja.Rows.Item(5).HorizontalAlignment = 3
    '    exHoja.Columns.AutoFit()


    '    'Aplicación visible
    '    exApp.Application.Visible = False




    '    'Obj.Application.ActiveWorkbook.SaveAs(App.Path & "\nombre.xls")
    '    'Obj.Application.Quit()

    '    exLibro.SaveAs("C:\Temp\Archivo " & Trim(Cartero) & " (" & Nro & ").xls")
    '    exLibro.Close()

    '    Return "C:\Temp\Archivo " & Trim(Cartero) & " (" & Nro & ").xls"

    '    exHoja = Nothing
    '    exLibro = Nothing
    '    exApp = Nothing


    'End Function

    Private Function ExcelPendientes(ByVal Cartero As String, ByVal Nro As Integer) As String
        'Agregar referencia Microsoft.Office.Interop.Excel()
        'Creamos las variables

        Dim exApp As New Microsoft.Office.Interop.Excel.Application
        Dim exLibro As Microsoft.Office.Interop.Excel.Workbook
        Dim exHoja As Microsoft.Office.Interop.Excel.Worksheet

        'Añadimos el Libro al programa, y la hoja al libro
        exLibro = exApp.Workbooks.Add
        exHoja = exLibro.Worksheets.Add()
        exHoja.Cells.NumberFormat = "@"

        ' ¿Cuantas columnas y cuantas filas?
        Dim NCol As Integer = DgvDatos.ColumnCount
        Dim NRow As Integer = DgvDatos.RowCount

        'Aquí recorremos todas las filas, y por cada fila todas las columnas y vamos escribiendo.
        For i As Integer = 1 To NCol
            exHoja.Cells.Item(1, i) = DgvDatos.Columns(i - 1).Name.ToString
            'exHoja.Cells.Item(1, i).HorizontalAlignment = 3
        Next

        For Fila As Integer = 0 To NRow - 1
            For Col As Integer = 0 To NCol - 1
                Dim valorCelda = DgvDatos.Rows(Fila).Cells(Col).Value
                exHoja.Cells.Item(Fila + 2, Col + 1) = valorCelda

                ' Verificar si el valor es una fecha y aplicar formato DD/MM/YYYY
                If TypeOf valorCelda Is Date Then
                    exHoja.Cells.Item(Fila + 2, Col + 1).NumberFormat = "DD/MM/YYYY"
                End If
            Next
        Next

        'Título en negrita, alineado al centro y que el tamaño de la columna se ajuste al texto
        exHoja.Columns.AutoFit()

        'Aplicación visible
        exApp.Application.Visible = False

        'Guardar el archivo
        exLibro.SaveAs("C:\Temp\Archivo " & Trim(Cartero) & " (" & Nro & ").xls")
        exLibro.Close()

        'Liberar recursos
        exHoja = Nothing
        exLibro = Nothing
        exApp = Nothing

        Return "C:\Temp\Archivo " & Trim(Cartero) & " (" & Nro & ").xls"
    End Function


    Public Function EnviarCorreoSinOutlook(ByVal cartero As String, ByVal Archiv As String) As Boolean
        Try
            Dim archivo As New System.Net.Mail.Attachment(Archiv)
            Dim correo As New System.Net.Mail.MailMessage()
            correo.From = New System.Net.Mail.MailAddress("reclamos@lexs.com.ar")
            correo.Subject = "Se adjunta pendiente " & cartero
            correo.To.Add(ObtenerMails(cartero))

            correo.CC.Add("guillermo.a@lexs.com.ar")
            correo.CC.Add("operaciones@lexs.com.ar")
            correo.CC.Add("planificacion@lexs.com.ar")
            correo.CC.Add("seguimiento@lexs.com.ar")
            correo.CC.Add("proveedores@lexs.com.ar")



            correo.Attachments.Add(archivo)
            correo.Body = ObtenerTextoMails(cartero)


            Dim Servidor As New System.Net.Mail.SmtpClient
            Servidor.Credentials = New System.Net.NetworkCredential("reclamos@lexs.com.ar", "lxs159753")
            Servidor.Host = "smtp.lexs.com.ar"
            Servidor.Port = 25
            Servidor.EnableSsl = False
            Servidor.Send(correo)
            MsgBox("Mensaje enviado a " & cartero)
        Catch ex As Exception
            MsgBox("Error compruebe su conexion a internet y reintente.    -  " & ex.ToString)
        End Try



    End Function

    'Private Function enviaCorreo(ByVal Archivo As String, ByVal Asunto As String, ByVal Cartero As String) As Boolean

    '    'Try
    '    Dim oApp As Outlook._Application
    '    oApp = New Outlook.Application()

    '    Dim oMsg As Outlook._MailItem
    '    oMsg = oApp.CreateItem(Outlook.OlItemType.olMailItem)
    '    oMsg.Subject = Asunto
    '    oMsg.Body = ObtenerTextoMails(Cartero)

    '    Dim Destinatarios As String = ""


    '    Dim DtMails As New DataTable
    '    DtMails = ObtenerMailCarteros(Cartero)

    '    For Each dtr As DataRow In DtMails.Rows
    '        Destinatarios = Destinatarios & dtr("mail").ToString & " ;"
    '    Next
    '    Destinatarios = Destinatarios.Substring(0, Len(Destinatarios) - 2)
    '    oMsg.To = Destinatarios
    '    Dim sSource As String = Archivo

    '    Dim sDisplayName As String = "Archivo"

    '    Dim oAttachs As Outlook.Attachments = oMsg.Attachments
    '    Dim oAttach As Outlook.Attachment

    '    oAttach = oAttachs.Add(sSource)
    '    oMsg.Save()


    '    Return True


    '    'Catch ex As Exception
    '    '    Return False

    '    '    MsgBox(ex.ToString)

    '    'End Try

    'End Function

End Class
