Imports System.Data.OleDb
Imports Microsoft.Office.Interop
Imports System.IO
Imports System.Threading

Public Class FrmAPruebaBackup
    Public DtHojaExcel As New DataTable
    Public Archivo As String = ""


    Private Sub BtnSeleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSeleccionar.Click
        Dim Ofd As New OpenFileDialog
        Ofd.Filter = "Xls File|*.xls"
        If Ofd.ShowDialog() = DialogResult.OK Then
            Dim source As String = Ofd.FileName
            Dim destFileName As String = "C:\Correo\Archivos_Temp\Archivo.xls"
            File.Copy(source, destFileName, 1)
            Dim aplicacion As New Excel.Application
            aplicacion.Visible = False
            DgvHoja.Rows.Clear()
            For Each ws As Excel.Worksheet In aplicacion.Workbooks.Open(Ofd.FileName).Sheets
                DgvHoja.Rows.Add(ws.Name.ToString)
            Next
            aplicacion.Quit()
        End If
        BtnSeleccionar.Enabled = False
        BtnProcesar.Enabled = True
    End Sub
    Private Sub BtnProcesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnProcesar.Click

        Dim N As String = DgvHoja.SelectedCells(0).RowIndex.ToString
        Dim STR As String = DgvHoja.Rows(N).Cells("NombreHoja").Value
        dgvDatos.DataSource = Nothing
        Dim Dt As New DataTable
        DtHojaExcel.Columns.Add("Orden")
        DtHojaExcel.Columns.Add("Prepaga")
        DtHojaExcel.Columns.Add("Grupos")
        DtHojaExcel.Columns.Add("Integrantes")
        DtHojaExcel.Columns.Add("Estado")
        DtHojaExcel.Columns.Add("NRO_CARTA")
        DtHojaExcel.Columns.Add("REMITENTE")
        DtHojaExcel.Columns.Add("TRABAJO")
        DtHojaExcel.Columns.Add("FECH_TRAB")
        DtHojaExcel.Columns.Add("NOMBRE")
        DtHojaExcel.Columns.Add("APELLIDO")
        DtHojaExcel.Columns.Add("CALLE")
        DtHojaExcel.Columns.Add("CP")
        DtHojaExcel.Columns.Add("PISO_DEPTO")
        DtHojaExcel.Columns.Add("LOCALIDAD")
        DtHojaExcel.Columns.Add("ESTADO")
        DtHojaExcel.Columns.Add("FECHA_ENTR")
        DtHojaExcel.Columns.Add("CARTERO")
        DtHojaExcel.Columns.Add("NRO_PLANIL")
        DtHojaExcel.Columns.Add("FECH_PLANI")
        DtHojaExcel.Columns.Add("FECH1")
        DtHojaExcel.Columns.Add("TEMA1")
        DtHojaExcel.Columns.Add("FECH2")
        DtHojaExcel.Columns.Add("TEMA2")
        DtHojaExcel.Columns.Add("FECH3")
        DtHojaExcel.Columns.Add("TEMA3")
        DtHojaExcel.Columns.Add("FECH4")
        DtHojaExcel.Columns.Add("TEMA4")
        DtHojaExcel.Columns.Add("FECH_DEVO")
        DtHojaExcel.Columns.Add("DEVO_PLANI")
        DtHojaExcel.Columns.Add("EMPRESA")
        DtHojaExcel.Columns.Add("NRO_CART2")
        DtHojaExcel.Columns.Add("MOTIVO_ANT")
        DtHojaExcel.Columns.Add("VINCULO")
        DtHojaExcel.Columns.Add("TRAMITE")


        Dt = ConfigCorreo.CN_Correo.CrearDTdeExcel("C:\Correo\Archivos_Temp\Archivo.xls", STR)
        Dim cont As Integer = 1

        For Each drs As DataRow In Dt.Rows
            DtHojaExcel.Rows.Add(cont, drs(0), drs(1), drs(2), drs(3))
            cont = cont + 1
        Next


        dgvDatos.DataSource = DtHojaExcel

    End Sub
    Private Sub BtnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnActualizar.Click
        Dim Ofd2 As New OpenFileDialog
        Ofd2.Filter = "Txt File|*.txt"
        If Ofd2.ShowDialog() = DialogResult.OK Then
            DgvBaseCartas.DataSource = Nothing
            Archivo = Ofd2.FileName

            Dim mThreadFic As Thread
            mThreadFic = New Thread(New ThreadStart(AddressOf BaseDatos))
            mThreadFic.Start()
        End If
    End Sub
    Private Sub BaseDatos()




        Dim sr As New StreamReader(Archivo)
        sr.ReadLine()
        Dim dteInicio As Date = Nothing
        Dim dteFinal As Date = Nothing
        Dim lngTiempoTranscurrido As Long = 0
        dteInicio = DateTime.Now

        Dim Wr As New StreamWriter("C:\loop.txt")

        While Not sr.EndOfStream
            Dim lineas() As String = Split(sr.ReadLine.ToString, "\")
            If lineas(1).ToString = "SWISSC" Or lineas(1).ToString = "SWISSK" Then

                Dim FECH_TRAB As String = lineas(3).ToString
                Dim FECHA_ENTR As String = lineas(18).ToString
                Dim FECH_PLANI As String = lineas(15).ToString
                Dim FECH1 As String = lineas(22).ToString
                Dim FECH2 As String = lineas(27).ToString
                Dim FECH3 As String = lineas(32).ToString
                Dim FECH4 As String = lineas(34).ToString
                Dim FECH_DEVO As String = lineas(42).ToString

                If Len(FECH_TRAB) > 1 Then
                    FECH_TRAB = ConfigCorreo.CN_Correo.Converfecha(FECH_TRAB)
                Else
                    FECH_TRAB = "0000-00-00"
                End If

                If Len(FECHA_ENTR) > 1 Then
                    FECHA_ENTR = ConfigCorreo.CN_Correo.Converfecha(FECHA_ENTR)
                Else
                    FECHA_ENTR = "0000-00-00"
                End If

                If Len(FECH_PLANI) > 1 Then
                    FECH_PLANI = ConfigCorreo.CN_Correo.Converfecha(FECH_PLANI)
                Else
                    FECH_PLANI = "0000-00-00"
                End If
                If Len(FECH1) > 1 Then
                    FECH1 = ConfigCorreo.CN_Correo.Converfecha(FECH1)
                Else
                    FECH1 = "0000-00-00"
                End If

                If Len(FECH2) > 1 Then
                    FECH2 = ConfigCorreo.CN_Correo.Converfecha(FECH2)
                Else
                    FECH2 = "0000-00-00"
                End If

                If Len(FECH3) > 1 Then
                    FECH3 = ConfigCorreo.CN_Correo.Converfecha(FECH3)
                Else
                    FECH3 = "0000-00-00"
                End If

                If Len(FECH4) > 1 Then
                    FECH4 = ConfigCorreo.CN_Correo.Converfecha(FECH4)
                Else
                    FECH4 = "0000-00-00"
                End If

                If Len(FECH_DEVO) > 1 Then
                    FECH_DEVO = ConfigCorreo.CN_Correo.Converfecha(FECH_DEVO)
                Else
                    FECH_DEVO = "0000-00-00"
                End If


                Wr.WriteLine(lineas(0).ToString & ";" & lineas(1).ToString & ";" & lineas(2).ToString & ";" & FECH_TRAB & ";" & lineas(4).ToString & ";" & lineas(5).ToString & ";" & lineas(7).ToString & ";" & lineas(6).ToString & ";" & lineas(9).ToString & ";" & lineas(10).ToString & ";" & lineas(12).ToString & ";" & FECHA_ENTR & ";" & lineas(16).ToString & ";" & lineas(14).ToString & ";" & FECH_PLANI & ";" & FECH1 & ";" & lineas(24).ToString & ";" & FECH2 & ";" & lineas(29).ToString & ";" & FECH3 & ";" & FECH4 & ";" & lineas(38).ToString & ";" & lineas(37).ToString & ";" & FECH_DEVO & ";" & lineas(43).ToString & ";" & lineas(53).ToString & ";" & lineas(55).ToString & ";" & lineas(74).ToString & ";" & lineas(75).ToString & ";" & lineas(81).ToString)

            End If
        End While

        Wr.Close()

        dteFinal = DateTime.Now
        lngTiempoTranscurrido = DateDiff(DateInterval.Second, dteInicio, dteFinal)

        MessageBox.Show("Proceso Finalizado en " & lngTiempoTranscurrido & " segundos")

    End Sub

    Private Sub FrmAPruebaBackup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Control.CheckForIllegalCrossThreadCalls = False
    End Sub
    Private Sub Cambiarimagen(ByVal nro As Integer)

        If nro = 100 Then
            PBANALIZAR.Image = My.Resources.R1
        End If
        If nro = 200 Then
            PBANALIZAR.Image = My.Resources.R2
        End If
        If nro = 300 Then
            PBANALIZAR.Image = My.Resources.R3
        End If
        If nro = 400 Then
            PBANALIZAR.Image = My.Resources.R4
        End If
        If nro = 500 Then
            PBANALIZAR.Image = My.Resources.R5
        End If
        If nro = 600 Then
            PBANALIZAR.Image = My.Resources.R6
        End If
        If nro = 700 Then
            PBANALIZAR.Image = My.Resources.R7
        End If
        If nro = 800 Then
            PBANALIZAR.Image = My.Resources.R8
        End If

    End Sub
    Private Sub Excel()


        Dim exApp As New Microsoft.Office.Interop.Excel.Application
        Dim exLibro As Microsoft.Office.Interop.Excel.Workbook
        Dim exHoja As Microsoft.Office.Interop.Excel.Worksheet

        'Agregar referencia Microsoft.Office.Interop.Excel()
        'Creamos las variables
        Try
            'Añadimos el Libro al programa, y la hoja al libro
            exLibro = exApp.Workbooks.Add
            exHoja = exLibro.Worksheets.Add()
            exHoja.Cells.NumberFormat = "@"
            ' ¿Cuantas columnas y cuantas filas?
            Dim NCol As Integer = DgvBaseCartas.ColumnCount
            Dim NRow As Integer = DgvBaseCartas.RowCount


            'Aqui recorremos todas las filas, y por cada fila todas las columnas y vamos escribiendo.
            For i As Integer = 1 To NCol
                exHoja.Cells.Item(1, i) = DgvBaseCartas.Columns(i - 1).Name.ToString
                'exHoja.Cells.Item(1, i).HorizontalAlignment = 3
            Next

            For Fila As Integer = 0 To NRow - 1
                For Col As Integer = 0 To NCol - 1
                    exHoja.Cells.Item(Fila + 2, Col + 1) = DgvBaseCartas.Rows(Fila).Cells(Col).Value
                Next
            Next
            'Titulo en negrita, Alineado al centro y que el tamaño de la columna se
            'ajuste al texto

            'exHoja.Rows.Item(5).Font.Bold = 1
            'exHoja.Rows.Item(5).HorizontalAlignment = 3
            'exHoja.Columns.AutoFit()



            'Aplicación visible
            exApp.Application.Visible = False


            If File.Exists("C:\ARCHIVOS_DJAI\" & Archivo & ".xls") Then
            Else
                exLibro.SaveAs("C:\Correo\Archivos_Temp\" & ConfigCorreo.CN_Correo.Converfecha(Now.ToShortDateString))

                exLibro.Close()
            End If



            exHoja = Nothing
            exLibro = Nothing
            exApp = Nothing


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al exportar a Excel")
        End Try
    End Sub
    Private Sub BtnExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExcel.Click
        Excel()

    End Sub
    Private Sub BtnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscar.Click
        For Each dr As DataRow In DtHojaExcel.Rows

            If Len(dr("Grupos")) > 14 Then
                If dr("Grupos").ToString.Contains("-") Then
                    Dim NroDeXLS() As String = Split(dr("Grupos").ToString, "-")


                End If
            End If

        Next
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ConfigCorreo.CN_Correo.Loaddatainfile("C:\loop.txt")


    End Sub
End Class