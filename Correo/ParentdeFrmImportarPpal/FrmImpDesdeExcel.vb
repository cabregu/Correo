Imports ConfigCorreo.CN_Correo
Imports System.Data.OleDb
Imports System.Threading
Imports Microsoft.Office.Interop
Imports System.IO
Imports System

Public Class FrmImpDesdeExcel
    Public dt As New DataTable
    Public Usuario As String = FrmPpal.Usuario
    Public IMP2 = New Thread(AddressOf PasarDatos)

    Public NroCart As String
    Dim DtNew As New DataTable



    Private Sub FrmImpDesdeExcel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        CheckForIllegalCrossThreadCalls = False
        Dim Servicios As New ArrayList
        Servicios = ConfigCorreo.CN_Correo.CargarTodoslosServicios
        CmbCodigo.Items.Clear()
        For i As Integer = 0 To Servicios.Count - 1
            CmbCodigo.Items.Add(Servicios.Item(i).ToString)
        Next

        Dim fechaTexto As String = DtpFecha.Value.ToString("dd-MM")
        TxtNro.Text = "D-" & fechaTexto



    End Sub
    Private Sub CmbCodigo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbCodigo.SelectedIndexChanged

        CmbRemito.Items.Clear()
        Dim ArrServiciosremitoslexs As New ArrayList
        ArrServiciosremitoslexs = ConfigCorreo.CN_Correo.RemitosdeCteremitosLexsIngresado(CmbCodigo.Text)
        For i As Integer = 0 To ArrServiciosremitoslexs.Count - 1
            CmbRemito.Items.Add(ArrServiciosremitoslexs.Item(i).ToString)
        Next
        CmbRemito.Enabled = True
        CmbCodigo.Enabled = False





    End Sub
    Private Sub CmbRemito_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbRemito.SelectedIndexChanged
        If Len(CmbRemito.Text) > 1 Then

            Dim CodServ As String = ConfigCorreo.CN_Correo.ObtenerServicio(CmbRemito.Text, CmbCodigo.Text)
            Dim Cantdias As Integer = ConfigCorreo.CN_Correo.ObtenerDiasServicio(CodServ)
            Dim dias As Date = Now.ToShortDateString


            BtnSeleccionDirecta.Enabled = True
            BtnAchivoComun.Enabled = True

            CmbRemito.Enabled = False

        End If

    End Sub


    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()

    End Sub
    Private Sub BtnImportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnImportar.Click

        PasarDatos()

    End Sub
    Private Sub PasarDatos()
        Dim cadena As New System.Text.StringBuilder
        Dim txtsql As String = ""

        For Each drw As DataGridViewRow In Dgvimportar.Rows

            Dim OBS As String = ""
            Dim OBS2 As String = ""
            Dim OBS3 As String = ""
            Dim OBS4 As String = ""
            Dim APELLIDO As String = ""
            Dim NRO As String = ""
            Dim PISO_DEPTO As String = ""
            Dim EMPRESA As String = ""

            If Not IsDBNull(drw.Cells("OBS").Value) Then
                OBS = drw.Cells("OBS").Value
            End If
            If Not IsDBNull(drw.Cells("OBS2").Value) Then
                OBS2 = drw.Cells("OBS2").Value
            End If
            If Not IsDBNull(drw.Cells("OBS3").Value) Then
                OBS3 = drw.Cells("OBS3").Value
            End If
            If Not IsDBNull(drw.Cells("OBS4").Value) Then
                OBS4 = drw.Cells("OBS4").Value
            End If

            If Not IsDBNull(drw.Cells("APELLIDO").Value) Then
                APELLIDO = drw.Cells("APELLIDO").Value
            End If
            If Not IsDBNull(drw.Cells("NRO").Value) Then
                NRO = drw.Cells("NRO").Value
            End If
            If Not IsDBNull(drw.Cells("PISO_DEPTO").Value) Then
                PISO_DEPTO = drw.Cells("PISO_DEPTO").Value
            End If
            If Not IsDBNull(drw.Cells("EMPRESA").Value) Then
                EMPRESA = drw.Cells("EMPRESA").Value
            End If





            txtsql = "(" & "'" & drw.Cells("NRO_CARTA").Value & "' , " _
            & "'" & drw.Cells("REMITENTE").Value & "'" & ", " _
            & "'" & drw.Cells("TRABAJO").Value & "'" & ", " _
            & "'" & Converfecha(drw.Cells("FECH_TRAB").Value) & "'" & ", " _
            & "'" & Normalizar(APELLIDO) & "'" & ", " _
            & "'" & drw.Cells("CP").Value & "'" & ", " _
            & "'" & Normalizar(Trim(drw.Cells("CALLE").Value)) & "'" & ", " _
            & "'" & Normalizar(NRO) & "', " _
            & "'" & Normalizar(PISO_DEPTO) & "', " _
            & "'" & drw.Cells("LOCALIDAD").Value & "'" & ", " _
            & "'" & drw.Cells("PROVINCIA").Value & "'" & ", " _
            & "'" & "PEND_IMPR" & "'" & ", " _
            & "'" & drw.Cells("NRO_CART2").Value & "'" & ", " _
            & "'" & Normalizar(EMPRESA) & "'" & ", " _
            & "'" & drw.Cells("SOCIO").Value & "'" & ", " _
            & "" & ObtenerAño(Now.ToShortDateString) & "" & ", " _
            & "'" & Normalizar(OBS) & "'" & ", " _
            & "'" & Normalizar(OBS2) & "'" & ", " _
            & "'" & Normalizar(OBS3) & "'" & ", " _
            & "'" & Normalizar(OBS4) & "'" & ")" & ", "
            'MsgBox(txtsql)
            cadena.Append(txtsql)
        Next
        Dim Archtxt3 As String

        Archtxt3 = cadena.ToString
        If Len(Archtxt3) > 0 Then
            Archtxt3 = Mid(Archtxt3, 1, Len(Archtxt3) - 2)
        End If

        If ConfigCorreo.CN_Correo.InstertarCARTAS(Archtxt3) = True Then
            ActualizarNroCarta(NroCart + 1)

            CambiarEstadoRemitosLexs(CmbRemito.Text, "Importado")

            'ActualizarRemito(CmbRemito.Text, CmbCodigo.Text, "PEND_IMPR", LblCant.Text)
            If MessageBox.Show(LblCantidad.Text & " Registros Cargados", LblCantidad.Text & " Registros Cargados", MessageBoxButtons.OK, MessageBoxIcon.Information) = Windows.Forms.DialogResult.OK Then
                Me.Close()
            End If

        End If

        NroCart = 0


    End Sub


    Public Shared Function ObtenerAño(ByVal Fecha As Date) As Integer

        Dim thisDate As Date
        Dim thisYear As Integer
        thisDate = Fecha
        thisYear = Year(thisDate)
        Return thisYear

    End Function

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Not IMP2.isalive Then
            FrmProgreso.Close()
            Me.Close()
        End If

    End Sub
    Private Sub DgvNoUtilizado_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub
    'Private Sub BtnArchivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    'Dgvimportar.DataSource = Nothing
    '    'DgvNoUtilizado.Rows.Clear()
    '    System.Diagnostics.Process.Start(txtPath.Text)
    '    Me.Dispose()

    '    'txtPath.Text = ""
    '    'CmbCodigo.Enabled = True

    'End Sub
    Private Shared Function Normalizar(ByVal Dato As String) As String

        If Dato <> Nothing Then
            Dato = Dato.Replace("'", "")
            Dato = Dato.Replace(",", "")
        End If

        Return Dato
    End Function



    Private Sub DataGridView1_ColumnAdded(
      ByVal sender As Object, ByVal e As DataGridViewColumnEventArgs) _
      Handles Dgvimportar.ColumnAdded

        ' Se está añadiendo una columna al control DataGridView. Indicamos
        ' que la columna sólo podrá ser ordenada mediante programación,
        ' pero a diferencia del valor Programatic, el encabezado de columna
        ' no incluirá el espacio para un glifo de ordenación.
        '
        e.Column.SortMode = DataGridViewColumnSortMode.NotSortable

    End Sub

    Private Sub BtnLista_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Try
        Dim exApp As New Microsoft.Office.Interop.Excel.Application
        Dim exLibro As Microsoft.Office.Interop.Excel.Workbook
        Dim exHoja As Microsoft.Office.Interop.Excel.Worksheet

        exLibro = exApp.Workbooks.Add
        exHoja = exLibro.Worksheets.Add()
        exHoja.Cells.NumberFormat = "@"
        exHoja.Cells.Item(1, 1) = "APELLIDO"
        exHoja.Cells.Item(1, 2) = "CALLE"
        exHoja.Cells.Item(1, 2) = "NRO"
        exHoja.Cells.Item(1, 2) = "PISO_DEPTO"
        exHoja.Cells.Item(1, 3) = "CP"
        exHoja.Cells.Item(1, 4) = "LOCALIDAD"
        exHoja.Cells.Item(1, 5) = "PROVINCIA"
        exHoja.Cells.Item(1, 6) = "EMPRESA"
        exHoja.Cells.Item(1, 7) = "NRO_CART2"
        exHoja.Cells.Item(1, 8) = "SOCIO"
        exHoja.Cells.Item(1, 9) = "OBS"
        exHoja.Cells.Item(1, 10) = "OBS2"
        exHoja.Cells.Item(1, 11) = "OBS3"
        exHoja.Cells.Item(1, 12) = "OBS4"

        exApp.Application.Visible = True





        ' ''exLibro.Close()
        ' ''exHoja = Nothing
        ' ''exLibro = Nothing
        ' ''exApp = Nothing
    End Sub



    'Private Sub BtnNormalizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    SeleccionarNormalizar()
    'End Sub
    'Public Sub SeleccionarNormalizar()

    '    Dim openFD As New OpenFileDialog()
    '    With openFD
    '        .Title = "Seleccionar archivos"
    '        .Filter = "Todos los archivos (*.xls)|*.xls"
    '        .Multiselect = False
    '        .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
    '        If .ShowDialog = Windows.Forms.DialogResult.OK Then
    '            If impExcelNormalizar(.FileName) = True Then
    '                txtPath.Text = Path.GetFileName(.FileName)
    '            End If
    '        Else
    '            openFD.Dispose()
    '        End If
    '    End With

    'End Sub
    Private Function impExcelNormalizar(ByVal Archivo As String) As Boolean
        Dim NombreHoja As String = ObtenerNombrePrimeraHoja(Archivo)

        Dim dt2 As New DataTable
        Dim strconn As String
        strconn = "Provider=Microsoft.Jet.Oledb.4.0; data source= " + Archivo + ";Extended properties=""Excel 8.0;hdr=yes;imex=1"""
        Dim mconn As New OleDbConnection(strconn)
        Dim ad As New OleDbDataAdapter("Select * from [" & NombreHoja & "$]", mconn)
        mconn.Open()
        ad.Fill(dt2)
        mconn.Close()


        '*********
        Dgvimportar.DataSource = dt2



        Return True

    End Function
    Private Function ObtenerNombrePrimeraHoja(ByVal rutaLibro As String) As String
        Dim app As Excel.Application = Nothing
        Try
            app = New Excel.Application()
            Dim wb As Excel.Workbook = app.Workbooks.Open(rutaLibro)
            Dim ws As Excel.Worksheet = CType(wb.Worksheets.Item(1), Excel.Worksheet)
            Dim name As String = ws.Name
            ws = Nothing
            wb.Close()
            wb = Nothing
            Return name
        Catch ex As Exception
            Throw

        Finally
            If (Not app Is Nothing) Then _
                app.Quit()
            Runtime.InteropServices.Marshal.ReleaseComObject(app)
            app = Nothing
        End Try
    End Function

    Private Function ImportarExcelDeswiss()

        Dim openFD As New OpenFileDialog()
        With openFD
            .Title = "Seleccionar archivos"
            .Filter = "Todos los archivos (*.xls)|*.xls"
            .Multiselect = False
            .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
            If .ShowDialog = Windows.Forms.DialogResult.OK Then

                DtNew = LeerExcelComoDataTable(.FileName)

                If Not IsNothing(DtNew) Then
                    InsertarDesdeDataTable(DtNew, DtpFecha.Value)
                End If


            Else
                openFD.Dispose()
            End If

        End With

    End Function





    Public Function LeerExcelComoDataTable(ByVal rutaArchivo As String) As DataTable
        Dim NombreHoja As String = ObtenerNombrePrimeraHoja(rutaArchivo)

        Dim dt2 As New DataTable
        Dim strconn As String
        strconn = "Provider=Microsoft.Jet.Oledb.4.0; data source= " + rutaArchivo + ";Extended properties=""Excel 8.0;hdr=yes;imex=1"""
        Dim mconn As New OleDbConnection(strconn)
        Dim ad As New OleDbDataAdapter("Select * from [" & NombreHoja & "$]", mconn)
        mconn.Open()
        ad.Fill(dt2)
        mconn.Close()

        ' Eliminar espacios en los nombres de los campos
        For Each column As DataColumn In dt2.Columns
            column.ColumnName = column.ColumnName.Replace(" ", "")
        Next


        If VerificarCampos(dt2) Then





            ' Agregar columna "APELLIDO"
            dt2.Columns.Add("APELLIDO", GetType(String))
            dt2.Columns.Add("NRO_CART2", GetType(String))
            dt2.Columns.Add("PISO_DEPTO", GetType(String))
            dt2.Columns.Add("NRO", GetType(String))
            dt2.Columns.Add("OBS", GetType(String))
            dt2.Columns.Add("OBS2", GetType(String))
            dt2.Columns.Add("OBS4", GetType(String))



            ' Establecer valor de la columna "APELLIDO"
            For Each row As DataRow In dt2.Rows

                'Juntar Apellido y nombre en uns sola columna ya creada llamada apellido
                Dim apellidoTitular As String = row("APELLIDO_TITULAR").ToString().TrimEnd()
                Dim nombreTitular As String = row("NOMBRE_TITULAR").ToString().TrimEnd()
                Dim calle As String = row("DOMI_ENT").ToString().TrimEnd()
                calle = calle.Replace("PISO", "").Replace("DEPTO", "").Replace("OF", "")
                Dim contra As String = row("CONTRA").ToString().TrimEnd()
                Dim creden As String = row("CREDEN").ToString().TrimEnd()
                Dim integ As String = row("INTEGRANTES").ToString().TrimEnd()
                contra = contra.PadLeft(7, "0")
                creden = creden.PadLeft(7, "0")
                Dim NroCart2 As String = contra & "-" & creden & "-" & integ
                Dim locali As String = row("LOCA_DENO_ENT").ToString().TrimEnd().ToUpper()
                Dim provin As String = row("PROV_DENO_ENT").ToString().TrimEnd().ToUpper()
                locali = locali.Replace("CIUDAD AUTONOMA BUENOS AIRES", "CAPITAL FEDERAL")

                Dim cp As String = row("POST").ToString().TrimEnd()

                If Not IsNumeric(cp) Then
                    cp = "0000"
                End If


                Dim empres As String = row("RAZON").ToString().TrimEnd()
                Dim tele As String = row("TELE").ToString().TrimEnd()
                Dim planilla As String = row("PLANTILLA").ToString().TrimEnd()
                Dim correo As String = row("EMPRESA_ENTREGA").ToString().TrimEnd()


                '        

                row("APELLIDO") = apellidoTitular & " " & nombreTitular
                row("DOMI_ENT") = calle
                row("CREDEN") = creden
                row("NRO_CART2") = NroCart2.Replace("/", "-")
                row("LOCA_DENO_ENT") = locali
                row("PROV_DENO_ENT") = provin
                row("POST") = cp
                row("RAZON") = empres
                row("TELE") = tele
                row("PLANTILLA") = planilla
                row("EMPRESA_ENTREGA") = correo



                If row("EMPRESA_ENTREGA") = "SEPRIT" Or row("EMPRESA_ENTREGA") = "CA" Then
                    row("OBS2") = ConsultaAsignacionSeprit(cp)

                End If
                If row("EMPRESA_ENTREGA") = "DEVOLVER A SWISS" Then
                    row("OBS2") = "DEV A SWISS"
                End If
                If row("EMPRESA_ENTREGA") = "SWISS" Then
                    row("OBS2") = "SWISS"
                End If
                If row("PLANTILLA").ToString.Contains("Y2") Then
                    row("OBS4") = "Y2"
                End If

                If row("ARMADO").ToString.Contains("ALTA") Then
                    row("OBS") = "ALTAS"
                Else
                    row("OBS") = "NOVEDADES"
                End If

                'row("OBS2") = ConsultaAsignacionSeprit(cp)



            Next

            dt2.Columns("DOMI_ENT").ColumnName = "CALLE"
            dt2.Columns("LOCA_DENO_ENT").ColumnName = "LOCALIDAD"
            dt2.Columns("PROV_DENO_ENT").ColumnName = "PROVINCIA"
            dt2.Columns("POST").ColumnName = "CP"
            dt2.Columns("RAZON").ColumnName = "EMPRESA"
            dt2.Columns("TELE").ColumnName = "SOCIO"
            dt2.Columns("PLANTILLA").ColumnName = "OBS3"



            dt2.Columns.Remove("APELLIDO_TITULAR")
            dt2.Columns.Remove("NOMBRE_TITULAR")

            ' Establecer posición de la columna "APELLIDO"
            dt2.Columns("APELLIDO").SetOrdinal(1)
            dt2.Columns("NRO_CART2").SetOrdinal(2)
            dt2.Columns("LOCALIDAD").SetOrdinal(4)
            dt2.Columns("PROVINCIA").SetOrdinal(5)


            '++++++++++++++++++++Arm+++++++++++++++++++++++++++
            Dim conteoEmpresas As New Dictionary(Of String, Integer)

            For Each row As DataRow In dt2.Rows
                Dim domicilio As String = row("CALLE").ToString().TrimEnd()
                Dim empresa As String = row("EMPRESA").ToString().TrimEnd()

                If Not String.IsNullOrEmpty(empresa) Then
                    Dim clave As String = domicilio & "-" & empresa
                    If conteoEmpresas.ContainsKey(clave) Then
                        conteoEmpresas(clave) += 1
                    Else
                        conteoEmpresas.Add(clave, 1)
                    End If
                End If
            Next

            For Each row As DataRow In dt2.Rows
                Dim domicilio As String = row("CALLE").ToString().TrimEnd()
                Dim empresa As String = row("EMPRESA").ToString().TrimEnd()
                Dim clave As String = domicilio & "-" & empresa


                If String.IsNullOrEmpty(row("OBS2").ToString().Trim()) AndAlso Not String.IsNullOrEmpty(empresa) AndAlso conteoEmpresas.ContainsKey(clave) AndAlso conteoEmpresas(clave) > 1 AndAlso IsNumeric(row("CP")) AndAlso CInt(row("CP")) >= 1400 AndAlso CInt(row("CP")) <= 9999 Then
                    row("OBS2") = "ARM"
                End If

                If String.IsNullOrEmpty(row("OBS2").ToString().Trim()) AndAlso Not String.IsNullOrEmpty(empresa) AndAlso conteoEmpresas.ContainsKey(clave) AndAlso conteoEmpresas(clave) > 1 AndAlso IsNumeric(row("CP")) AndAlso CInt(row("CP")) >= 1000 AndAlso CInt(row("CP")) <= 1399 Then

                    row("OBS2") = "ARM"

                End If



            Next


            '**********************AsignacionZonal********************


            For Each fila As DataRow In dt2.Rows
                If fila("obs2").ToString = "" Or fila("obs2").ToString = "ARM" Then
                    fila("piso_depto") = ConsultaZonalesParaImportacionyAsignacion(fila("cp").ToString())
                End If
            Next

            '***********************NuevaVarificacion oca******************************


            For Each fila As DataRow In dt2.Rows
                If Not IsDBNull(fila("obs2")) AndAlso fila("obs2").ToString = "" Then
                    fila("OBS2") = ConsultaAsignacionSeprit(fila("CP"))
                End If
            Next



            '*****************************modo simple*************************************
            Dim contador As New Dictionary(Of String, Integer)

            For Each fila As DataRow In dt2.Rows
                Dim piso_depto As String = fila("piso_depto").ToString()

                If piso_depto <> "" Then

                    If Not contador.ContainsKey(piso_depto) Then
                        contador(piso_depto) = 1
                    Else
                        contador(piso_depto) += 1
                    End If

                End If
            Next

            Dim lista As New List(Of String) From {
             "TB ROSARIO",
             "TB SF RESTO",
             "SDI CORDOBA",
             "TB PERGAMINO",
             "TB MISIONES",
             "LV TUCUMAN",
             "LV SALTA",
             "LV JUJUY",
             "MEX SJ",
             "MEX M",
             "MEX SL",
             "TB NEUQUEN"}



            For Each kvp As KeyValuePair(Of String, Integer) In contador
                Dim nroFinal As Integer = kvp.Value
                Dim nroInicial As Integer = 1

                For Each fila As DataRow In dt2.Rows

                    Dim obs2 As String = fila("obs2").ToString()
                    Dim obs3 As String = fila("obs3").ToString()

                    If String.IsNullOrEmpty(obs2) Then 'Elcampo OBS2 esta vacio arranca

                        Dim zonal As String = fila("piso_depto").ToString()
                        If kvp.Key = zonal AndAlso nroInicial <= nroFinal Then

                            If nroInicial Mod 2 <> 0 Then

                                If zonal.ToString.Contains("COOR") Then
                                    If Convert.ToInt32(fila("cp")) > 1400 Then

                                        If Not obs3.ToString.Contains("Q") Then
                                            fila("obs2") = "REFEREN"
                                        End If

                                    End If
                                Else



                                End If
                            Else


                            End If

                            nroInicial += 1
                        End If


                    End If

                Next
            Next


            Return dt2

        End If


    End Function





    Private Function VerificarCampos(ByVal tabla As DataTable) As Boolean
        Dim camposRequeridos As String() = {"CONTRA", "APELLIDO_TITULAR", "NOMBRE_TITULAR", "DOMI_ENT", "LOCA_DENO_ENT", "PROV_DENO_ENT", "POST", "PLAN_CODI", "CREDEN", "INTEGRANTES", "CUENTA", "RAZON", "SUBC", "SUBCTA_DENO", "ARMADO", "PROV_DENO_PAR", "LOCA_DENO_PAR", "CARTI_DENO", "EMPRESA_ENTREGA", "C", "TELE", "PLANTILLA", "FILA", "FILAS", "CAN"}

        For Each campo As String In camposRequeridos
            If Not tabla.Columns.Contains(campo) Then
                MsgBox("El campo " & campo & " No se encuentra en el archivo y puede que haya mas campos que no esten verifique el archivo")
                Return False
            End If
        Next
        Return True
    End Function

    Private Sub BtnSeleccionDirecta_Click(sender As Object, e As EventArgs) Handles BtnSeleccionDirecta.Click
        ImportarExcelDeswiss()
        BtnImportar.Enabled = True
        LblCantidad.Text = Dgvimportar.RowCount

    End Sub

    Private Sub InsertarDesdeDataTable(ByVal dt As DataTable, ByVal FechaImportacion As Date)

        Dim ArrCampos As New ArrayList
        ArrCampos.Add("APELLIDO")
        ArrCampos.Add("CALLE")
        ArrCampos.Add("NRO")
        ArrCampos.Add("PISO_DEPTO")
        ArrCampos.Add("CP")
        ArrCampos.Add("LOCALIDAD")
        ArrCampos.Add("PROVINCIA")
        ArrCampos.Add("EMPRESA")
        ArrCampos.Add("NRO_CART2")
        ArrCampos.Add("SOCIO")
        ArrCampos.Add("OBS")
        ArrCampos.Add("OBS2")
        ArrCampos.Add("OBS3")
        ArrCampos.Add("OBS4")

        dt.Columns("APELLIDO").SetOrdinal(1)
        dt.Columns("CALLE").SetOrdinal(2)
        dt.Columns("NRO").SetOrdinal(3)
        dt.Columns("PISO_DEPTO").SetOrdinal(4)
        dt.Columns("CP").SetOrdinal(5)
        dt.Columns("LOCALIDAD").SetOrdinal(6)
        dt.Columns("PROVINCIA").SetOrdinal(7)
        dt.Columns("EMPRESA").SetOrdinal(8)
        dt.Columns("NRO_CART2").SetOrdinal(9)
        dt.Columns("SOCIO").SetOrdinal(10)
        dt.Columns("OBS").SetOrdinal(11)
        dt.Columns("OBS2").SetOrdinal(12)
        dt.Columns("OBS3").SetOrdinal(13)
        dt.Columns("OBS4").SetOrdinal(14)

        'Agregamos las columnas al DataGridView
        Dgvimportar.Columns.Clear()
        Dgvimportar.Columns.Add("NRO_CARTA", "NRO_CARTA")
        Dgvimportar.Columns.Add("REMITENTE", "REMITENTE")
        Dgvimportar.Columns.Add("TRABAJO", "TRABAJO")
        Dgvimportar.Columns.Add("FECH_TRAB", "FECH_TRAB")
        For Each col As DataColumn In dt.Columns
            If ArrCampos.Contains(col.ColumnName) Then
                Dgvimportar.Columns.Add(col.ColumnName, col.ColumnName)
            End If
        Next


        'Agregamos los datos al DataGridView
        Dgvimportar.Rows.Clear()
        Dim NroCarta As Integer = ObtenerNroCarta()

        For Each drw As DataRow In dt.Rows
            Dim row As New DataGridViewRow()
            row.CreateCells(Dgvimportar)
            row.Cells(0).Value = NroCarta
            row.Cells(1).Value = CmbCodigo.Text
            row.Cells(2).Value = CmbRemito.Text
            row.Cells(3).Value = FechaImportacion.ToShortDateString
            For i As Integer = 0 To dt.Columns.Count - 1
                If ArrCampos.Contains(dt.Columns(i).ColumnName) Then
                    row.Cells(Dgvimportar.Columns(dt.Columns(i).ColumnName).Index).Value = drw.Item(i)
                End If
            Next


            Dgvimportar.Rows.Add(row)
            NroCarta = NroCarta + 1
        Next





        For Each drw As DataGridViewRow In Dgvimportar.Rows
            drw.Cells("NRO").Value = TxtNro.Text
            NroCart = drw.Cells("NRO_CARTA").Value
            drw.Cells("NRO_CARTA").Value = NroCart
            drw.Cells("REMITENTE").Value = CmbCodigo.Text
            drw.Cells("TRABAJO").Value = CmbRemito.Text
            drw.Cells("FECH_TRAB").Value = FechaImportacion.ToShortDateString

            drw.Cells("NRO_CARTA").Style.ForeColor = Color.Red
            drw.Cells("REMITENTE").Style.ForeColor = Color.Red
            drw.Cells("TRABAJO").Style.ForeColor = Color.Red
            drw.Cells("FECH_TRAB").Style.ForeColor = Color.Red

        Next




        'Actualizamos la cantidad de filas en el DataGridView
        LblCantidad.Text = Dgvimportar.Rows.Count.ToString()


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

    Private Sub BtnExcel_Click(sender As Object, e As EventArgs) Handles BtnExcel.Click
        ExportarDataGridViewAExcel(Dgvimportar)
    End Sub

    Private Sub BtnAchivoComun_Click(sender As Object, e As EventArgs) Handles BtnAchivoComun.Click
        Seleccionar()
        LblCantidad.Text = Dgvimportar.RowCount
        BtnImportar.Enabled = True

    End Sub



    Private Sub Seleccionar()

        Dim openFD As New OpenFileDialog()
        With openFD
            .Title = "Seleccionar archivos"
            .Filter = "Todos los archivos (*.xls)|*.xls"
            .Multiselect = False
            .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
            If .ShowDialog = Windows.Forms.DialogResult.OK Then

                Insertardesdexls(DtpFecha.Value.ToShortDateString, .FileName)

            Else
                openFD.Dispose()
            End If

        End With

    End Sub
    Private Sub Insertardesdexls(ByVal FechaImportacion As Date, ByVal ruta As String)
        Try



            Dim ArrCampos As New ArrayList
            ArrCampos.Add("APELLIDO")
            ArrCampos.Add("CALLE")
            ArrCampos.Add("NRO")
            ArrCampos.Add("PISO_DEPTO")
            ArrCampos.Add("CP")
            ArrCampos.Add("LOCALIDAD")
            ArrCampos.Add("PROVINCIA")
            ArrCampos.Add("EMPRESA")
            ArrCampos.Add("NRO_CART2")
            ArrCampos.Add("SOCIO")
            ArrCampos.Add("OBS")
            ArrCampos.Add("OBS2")
            ArrCampos.Add("OBS3")
            ArrCampos.Add("OBS4")

            Dim NombreHoja As String = ""
            NombreHoja = ObtenerNombrePrimeraHoja(ruta)

            Dim strconn As String
            strconn = "Provider=Microsoft.Jet.Oledb.4.0; data source= " + ruta + ";Extended properties=""Excel 8.0;hdr=yes;imex=1"""
            Dim mconn As New OleDbConnection(strconn)
            Dim ad As New OleDbDataAdapter("Select * from [" & NombreHoja & "$]", mconn)
            mconn.Open()
            ad.Fill(dt)
            mconn.Close()

            Dgvimportar.Columns.Add("NRO_CARTA", "NRO_CARTA")
            Dgvimportar.Columns.Add("REMITENTE", "REMITENTE")
            Dgvimportar.Columns.Add("TRABAJO", "TRABAJO")
            Dgvimportar.Columns.Add("FECH_TRAB", "FECH_TRAB")

            ' Verificar campos faltantes y agregar columnas vacías
            Dim camposFaltantes As New ArrayList

            For Each campo As String In ArrCampos
                If Not dt.Columns.Contains(campo) Then
                    camposFaltantes.Add(campo)
                    dt.Columns.Add(campo)
                End If
            Next


            'eliminar espacios de mas en todos los campos 
            For Each fila As DataRow In dt.Rows
                For Each columna As DataColumn In dt.Columns
                    If TypeOf fila(columna) Is String Then
                        fila(columna) = fila(columna).ToString().TrimStart()
                    End If
                Next
            Next



            Dgvimportar.DataSource = dt
            NroCart = ObtenerNroCarta()

            For Each drw As DataGridViewRow In Dgvimportar.Rows
                drw.Cells("NRO_CARTA").Value = NroCart
                drw.Cells("REMITENTE").Value = CmbCodigo.Text
                drw.Cells("TRABAJO").Value = CmbRemito.Text
                drw.Cells("FECH_TRAB").Value = FechaImportacion.ToShortDateString

                drw.Cells("NRO_CARTA").Style.ForeColor = Color.Green
                drw.Cells("REMITENTE").Style.ForeColor = Color.Green
                drw.Cells("TRABAJO").Style.ForeColor = Color.Green
                drw.Cells("FECH_TRAB").Style.ForeColor = Color.Green
                NroCart = NroCart + 1
            Next

            ' Mostrar mensaje de campos faltantes
            If camposFaltantes.Count > 0 Then
                Dim mensaje As String = "Los siguientes campos no existen en el archivo de Excel:" & Environment.NewLine
                For Each campo As String In camposFaltantes
                    mensaje += campo & Environment.NewLine
                Next
                MessageBox.Show(mensaje, "Campos faltantes", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If


            Dim columnasIgnoradas As List(Of String) = New List(Of String) From {"NRO_CARTA", "REMITENTE", "TRABAJO", "FECH_TRAB"}
            For Each columna As DataGridViewColumn In Dgvimportar.Columns
                Dim nombreColumna As String = columna.HeaderText
                If Not ArrCampos.Contains(nombreColumna) AndAlso Not columnasIgnoradas.Contains(nombreColumna) Then
                    columna.DefaultCellStyle.BackColor = Color.Red
                End If
            Next


        Catch ex As Exception

            MsgBox("Error de proceso verifique esto " & ex.ToString)
        End Try

    End Sub


End Class