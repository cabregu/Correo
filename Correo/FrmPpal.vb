Imports System.Data.OleDb
Imports ConfigCorreo.CN_Correo



Public Class FrmPpal
    'grupo inferior
   

    'Dim frmImp As FrmImportarPpal
    Dim frmcimpppal As FrmImportarPpal
    Dim frmconfAcu As FrmConfirmacionAcuse
    Dim frmcons As FrmConsultaTR
    Dim frmmasi As FrmEntreSucuDevoSucu
    Dim frminform As FrmEstadistica
    Dim frmtransi As FrmTransito
    Dim frmstock As FrmListadoPiezas
    Dim frmarmad As FrmMotivos
    Dim frmMot As FrmMotivos
    Dim frmentreg As FrmEntregadas
    Dim frmvisit As FrmVisitadas
    Dim frmpendientes As FrmPendientes
    Dim frmRptZon As FrmReporteZonal
    Dim frmTrs As FrmAnalizarBases
    'Dim frMot As FrmMotivos

    'grupo superior
    Dim frmprec As FrmPrecios
    Dim frmcost As FrmConfirmacionAcuse
    Dim frmprov As FrmProveedores
    Dim frmcart As FrmCarteros
    Dim frmzon As FrmZonales
    Dim frmclien As FrmClientes
    Dim frmesta As FrmEstado1
    Dim frmestados As FrmEstados

    Dim frmconfesta As FrmConfEstado
    Dim frmnuevacamp As FrmNuevaCampaña
    Dim frmsegui As FrmSeguimiento
    Dim frmplanif As FrmPlanificacion
    Dim frmdevo As FrmDevolucion
    Dim frmmodifest As FrmImprimirPlanificacion
    Dim frmasigzon As FrmReporteZonal
    Dim frmingreman As FrmIngresoManual
    Dim frmimpr As FrmImprimir
    Dim frmconf As FrmConfiguracion
    Dim FrmEscan As FrmRemitosLexs
    Dim FrmConultXls As FrmConsultasXls
    Dim FrmConfEntreDevoSucu As FrmEntreSucuDevoSucu
    Dim FrmListaPiez As FrmListadoPiezas

    'FrmEntreSucuDevoSucu.vb

    Public Usuario As String = ""
    Public Nivel As String = ""







    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer.Tick
        If LblNro.Text = "1" Then
            BtnTermometro.Image = My.Resources.temperature_2
            LblNro.Text = "2"
        ElseIf LblNro.Text = "2" Then
            BtnTermometro.Image = My.Resources.temperature_3
            LblNro.Text = "3"
        ElseIf LblNro.Text = "3" Then
            BtnTermometro.Image = My.Resources.temperature_4
            LblNro.Text = "4"
        ElseIf LblNro.Text = "4" Then
            BtnTermometro.Image = My.Resources.temperature_4
            LblNro.Text = "5"

        ElseIf LblNro.Text = "5" Then
            BtnTermometro.Image = My.Resources.temperature_5
            LblNro.Text = "1"
        End If



    End Sub
    Private Sub PrmPpal_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        FrmUsuario.Close()
        FrmUsuario.Dispose()
    End Sub
    Private Sub PrmPpal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer.Start()
        Me.Text = "Bienvenido Usuario " & Usuario & " Su Nivel Es : " & Nivel

    End Sub
    Private Sub BtnSalir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub
    Private Sub Btnprecios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmprec = Nothing
        If frmprec Is Nothing Then
            frmprec = New FrmPrecios
            frmprec.Show()
            Me.Visible = False
        ElseIf frmprec.IsDisposed Then
            Me.Visible = True
        End If
    End Sub
    Private Sub Btncostos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmcost = Nothing
        If frmcost Is Nothing Then
            frmcost = New FrmConfirmacionAcuse
            frmcost.Show()
            Me.Visible = False
        ElseIf frmcost.IsDisposed Then
            Me.Visible = True
        End If
    End Sub
    Private Sub Btnproveedores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmprov = Nothing
        If frmprov Is Nothing Then
            frmprov = New FrmProveedores
            frmprov.Show()
            Me.Visible = False
        ElseIf frmprov.IsDisposed Then
            Me.Visible = True
        End If
    End Sub
    Private Sub Btncarteros_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btncarteros.Click
        frmcart = Nothing
        If frmcart Is Nothing Then
            frmcart = New FrmCarteros
            frmcart.Show()
            Me.Visible = False
        ElseIf frmcart.IsDisposed Then
            Me.Visible = True
        End If
    End Sub
    Private Sub Btnzonales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmzon = Nothing
        If frmzon Is Nothing Then
            frmzon = New FrmZonales
            frmzon.Show()
            Me.Visible = False
        ElseIf frmzon.IsDisposed Then
            Me.Visible = True
        End If
    End Sub
    Private Sub Btnclientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmclien = Nothing
        If frmclien Is Nothing Then
            frmclien = New FrmClientes
            frmclien.Show()
            Me.Visible = False
        ElseIf frmclien.IsDisposed Then
            Me.Visible = True
        End If
    End Sub
    Private Sub Btnestados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmesta = Nothing
        If frmesta Is Nothing Then
            frmesta = New FrmEstado1
            frmesta.Show()
            Me.Visible = False
        ElseIf frmesta.IsDisposed Then
            Me.Visible = True
        End If


    End Sub
    Private Sub Btnconfestado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmconfesta = Nothing
        If frmconfesta Is Nothing Then
            frmconfesta = New FrmConfEstado
            frmconfesta.Show()
            Me.Visible = False
        ElseIf frmconfesta.IsDisposed Then
            Me.Visible = True
        End If
    End Sub
    Private Sub Btnnuevacampaña_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmnuevacamp = Nothing
        If frmnuevacamp Is Nothing Then
            frmnuevacamp = New FrmNuevaCampaña
            frmnuevacamp.Show()
            Me.Visible = False
        ElseIf frmnuevacamp.IsDisposed Then
            Me.Visible = True
        End If
    End Sub
    Private Sub BtnSeguimiento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSeguimiento.Click
        frmsegui = Nothing
        If frmsegui Is Nothing Then
            frmsegui = New FrmSeguimiento
            frmsegui.Show()
            Me.Visible = False
        ElseIf frmsegui.IsDisposed Then
            Me.Visible = True
        End If
    End Sub
    Private Sub Btnplanificacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnplanificacion.Click
        frmplanif = Nothing
        If frmplanif Is Nothing Then
            frmplanif = New FrmPlanificacion
            frmplanif.Show()
            Me.Visible = False
        ElseIf frmplanif.IsDisposed Then
            Me.Visible = True
        End If
    End Sub
    Private Sub Btndevolucion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmdevo = Nothing
        If frmdevo Is Nothing Then
            frmdevo = New FrmDevolucion
            frmdevo.Show()
            Me.Visible = False
        ElseIf frmdevo.IsDisposed Then
            Me.Visible = True
        End If
    End Sub


    Private Sub Btnasignarzonal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmasigzon = Nothing
        If frmasigzon Is Nothing Then
            frmasigzon = New FrmReporteZonal
            frmasigzon.Show()
            Me.Visible = False
        ElseIf frmasigzon.IsDisposed Then
            Me.Visible = True
        End If
    End Sub
    Private Sub BtnIngresoM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmingreman = Nothing
        If frmingreman Is Nothing Then
            frmingreman = New FrmIngresoManual
            frmingreman.Show()
            Me.Visible = False
        ElseIf frmingreman.IsDisposed Then
            Me.Visible = True
        End If
    End Sub
    Private Sub Btnimprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'frmimpr = Nothing
        'If frmimpr Is Nothing Then
        '    frmimpr = New FrmImprimir
        '    frmimpr.Show()
        '    Me.Visible = False
        'ElseIf frmimpr.IsDisposed Then
        '    Me.Visible = True
        'End If
    End Sub
    Private Sub Btnconfiguracion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmconf = Nothing
        If frmconf Is Nothing Then
            frmconf = New FrmConfiguracion
            frmconf.Show()
            Me.Visible = False
        ElseIf frmconf.IsDisposed Then
            Me.Visible = True
        End If
    End Sub
    Private Sub Btnconsulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnconsulta.Click
        'frmcons = Nothing
        'If frmcons Is Nothing Then
        '    frmcons = New FrmConsultamdi
        '    frmcons.Show()
        Me.Visible = False
        'ElseIf frmcons.IsDisposed Then
        'Me.Visible = True
        'End If
        FrmConsultamdi.Show()
    End Sub


    Private Sub Btninforme_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frminform = Nothing
        If frminform Is Nothing Then
            frminform = New FrmEstadistica
            frminform.Show()
            Me.Visible = False
        ElseIf frminform.IsDisposed Then
            Me.Visible = True
        End If
    End Sub
    Private Sub Btntransito_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btntransito.Click
        frmtransi = Nothing
        If frmtransi Is Nothing Then
            frmtransi = New FrmTransito
            frmtransi.Show()
            Me.Visible = False
        ElseIf frmtransi.IsDisposed Then
            Me.Visible = True
        End If
    End Sub
    Private Sub Btnstock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmstock = Nothing
        If frmstock Is Nothing Then
            frmstock = New FrmListadoPiezas
            frmstock.Show()
            Me.Visible = False
        ElseIf frmstock.IsDisposed Then
            Me.Visible = True
        End If
    End Sub

    Private Sub Btnpendientesarmado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub Btnentregadas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnentregadas.Click
        frmentreg = Nothing
        If frmentreg Is Nothing Then
            frmentreg = New FrmEntregadas
            frmentreg.Show()
            Me.Visible = False
        ElseIf frmentreg.IsDisposed Then
            Me.Visible = True
        End If
    End Sub
    Private Sub Btnvisitadas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnvisitadas.Click
        frmvisit = Nothing
        If frmvisit Is Nothing Then
            frmvisit = New FrmVisitadas
            frmvisit.Show()
            Me.Visible = False
        ElseIf frmvisit.IsDisposed Then
            Me.Visible = True
        End If
    End Sub
    Private Sub Btnpendientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnpendientes.Click
        frmpendientes = Nothing
        If frmpendientes Is Nothing Then
            frmpendientes = New FrmPendientes
            frmpendientes.Show()
            Me.Visible = False
        ElseIf frmpendientes.IsDisposed Then
            Me.Visible = True
        End If


    End Sub
    Private Sub BtnConsultaTR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnConsultaTR.Click
        frmcons = Nothing
        If frmcons Is Nothing Then
            frmcons = New FrmConsultaTR
            frmcons.Show()
        ElseIf frmcons.IsDisposed Then
            Me.Visible = True
        End If

    End Sub
    'Private Sub BtnActualizarPresis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    '    If MessageBox.Show("Se va a analizar la base de Para Visitadas Entregadas", "Presione Yes y espere", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
    '        ImportarDbf(TxtCant.Text)
    '    End If
    '    If MessageBox.Show("Procesar Base de Escaneo esto puede demorar", "Procesar base de escaneo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

    '        ImportarDbf2()

    '    End If

    'End Sub

    Private Sub BtnEscaneo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEscaneo.Click

        FrmEscan = Nothing
        If FrmEscan Is Nothing Then
            FrmEscan = New FrmRemitosLexs

            FrmEscan.Show()
            Me.Visible = False
        ElseIf FrmEscan.IsDisposed Then
            Me.Visible = True
        End If
    End Sub
    Private Sub BtnConsultasXls_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        FrmConultXls = Nothing
        If FrmConultXls Is Nothing Then
            FrmConultXls = New FrmConsultasXls
            FrmConultXls.Show()
            Me.Visible = False
        ElseIf FrmConultXls.IsDisposed Then
            Me.Visible = True
        End If

    End Sub
    Private Shared Function Normalizar(ByVal Dato As String) As String
        Dato = Dato.Replace("-", "")
        Dato = Dato.Replace("(", "")
        Dato = Dato.Replace(")", "")
        Dato = Dato.Replace("  ", "")
        Dato = Dato.Replace("30/12/1899", "")
        Dato = Dato.Replace(" 0:00:00", "")
        Dato = Dato.Replace("'", "")
        Dato = Dato.Replace(",", "")
        Dato = Dato.Replace("12:00:00 a.m.", "")

        Return Dato
    End Function
    Private Sub ImportarDbf2()
        'Try
        Dim ruta As String
        ruta = ObtenerRutaDBF()
        Dim FechaDesde As Date = Now.ToShortDateString
        FechaDesde = FechaDesde.AddDays(-15)
        Dim dtnew As New DataTable

        'Mode=Share Deny None;
        Dim cnn As New OleDbConnection( _
           "Provider = VFPOLEDB;" & _
           "Data Source=" & ruta & ";" & _
           "Mode=Share Deny None;" & _
           "Mask Password=False;" & _
           "Cache Authentication=False;" & _
           "Encrypt Password=False;" & _
           "Collating Sequence=MACHINE;")
        Using cnn

            '
            Dim sql As String = "SELECT NRO_CARTA, REMITENTE, TRABAJO, FECH_TRAB, APELLIDO, CP, CALLE, NRO, PISO_DEPTO, LOCALIDAD, PROVINCIA, ESTADO, NRO_PLANIL, FECH_PLANI, CARTERO, FECHA_ENTR, FECH1, PLANILLA1, TEMA1, CARTERO1, FECH2, PLANILLA2, TEMA2, CARTERO2, FECH3, PLANILLA3, TEMA3, CARTERO3, TEMA4, FECH4, NRO_CART2, EMPRESA FROM CARTAS.DBF WHERE" & _
            " FECH_TRAB => {^" & ConfigCorreo.CN_Correo.Converfecha(FechaDesde) & "}"
            Dim da As New OleDbDataAdapter(sql, cnn)
            Dim ds As New DataSet
            da.Fill(ds, sql)
            Dim dt As DataTable = ds.Tables(sql)
            dtnew = dt
            Dim numero As Integer = 0
            numero = dt.Rows.Count
            Dim cantidadreg As Integer = 0

            Dim ArrayCartas As New ArrayList
            ArrayCartas = Buscarporfecha()


            If numero > 0 Then

                If MessageBox.Show("Hay Registros para analizar, continuar?", " Registros desea continuar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    Dim txtcad1 As String
                    Dim cadena1 As New System.Text.StringBuilder
                    Dim txtarch1 As String = ""
                    For i As Integer = 0 To dtnew.Rows.Count - 1
                        Dim Nrocart As Integer = dtnew.Rows(i)("NRO_CARTA").ToString
                        If Not ArrayCartas.Contains(Nrocart) Then
                            txtcad1 = "(" & "'" & dtnew.Rows(i)("NRO_CARTA").ToString & "' , " _
                            & "'" & dtnew.Rows(i)("REMITENTE").ToString & "'" & ", " _
                            & "'" & dtnew.Rows(i)("TRABAJO").ToString & "'" & ", " _
                            & "'" & Converfecha(dtnew.Rows(i)("FECH_TRAB").ToString) & "'" & ", " _
                            & "'" & Normalizar(dtnew.Rows(i)("APELLIDO").ToString) & "'" & ", " _
                            & "'" & dtnew.Rows(i)("CP".ToString) & "'" & ", " _
                            & "'" & Normalizar(Trim(dtnew.Rows(i)("CALLE").ToString)) & "'" & ", " _
                            & "'" & dtnew.Rows(i)("NRO").ToString & "'" & ", " _
                            & "'" & dtnew.Rows(i)("PISO_DEPTO").ToString & "'" & ", " _
                            & "'" & Normalizar(dtnew.Rows(i)("LOCALIDAD").ToString) & "'" & ", " _
                            & "'" & Normalizar(dtnew.Rows(i)("PROVINCIA").ToString) & "'" & ", " _
                            & "'" & Trim(dtnew.Rows(i)("ESTADO").ToString) & "'" & ", " _
                            & "'" & dtnew.Rows(i)("NRO_PLANIL").ToString & "'" & ", " _
                            & "'" & Converfecha(dtnew.Rows(i)("FECH_PLANI").ToString) & "'" & ", " _
                            & "'" & dtnew.Rows(i)("CARTERO").ToString & "'" & ", " _
                            & "'" & Converfecha(dtnew.Rows(i)("FECHA_ENTR").ToString) & "'" & ", " _
                            & "'" & Converfecha(dtnew.Rows(i)("FECH1").ToString) & "'" & ", " _
                            & "'" & dtnew.Rows(i)("PLANILLA1").ToString & "'" & ", " _
                            & "'" & dtnew.Rows(i)("TEMA1").ToString & "'" & ", " _
                            & "'" & dtnew.Rows(i)("CARTERO1").ToString & "'" & ", " _
                            & "'" & Converfecha(dtnew.Rows(i)("FECH2").ToString) & "'" & ", " _
                            & "'" & dtnew.Rows(i)("PLANILLA2").ToString & "'" & ", " _
                            & "'" & dtnew.Rows(i)("TEMA2").ToString & "'" & ", " _
                            & "'" & dtnew.Rows(i)("CARTERO2").ToString & "'" & "" & ", " _
                            & "'" & Converfecha(dtnew.Rows(i)("FECH3").ToString) & "'" & ", " _
                            & "'" & dtnew.Rows(i)("PLANILLA3").ToString & "'" & ", " _
                            & "'" & dtnew.Rows(i)("TEMA3").ToString & "'" & ", " _
                            & "'" & dtnew.Rows(i)("CARTERO3").ToString & "'" & "" & ", " _
                            & "'" & dtnew.Rows(i)("TEMA4").ToString & "'" & "" & ", " _
                            & "'" & Converfecha(dtnew.Rows(i)("FECH4").ToString) & "'" & "" & ", " _
                            & "'" & dtnew.Rows(i)("NRO_CART2").ToString & "'" & "" & ", " _
                            & "'" & Normalizar(Trim(dtnew.Rows(i)("EMPRESA").ToString)) & "'" & ")" & ", "
                            cadena1.Append(txtcad1)
                            cantidadreg = cantidadreg + 1
                        End If
                        'lblcartasimpor.Text = cantidadreg
                        'lblcartasimpor.Refresh()

                    Next
                    txtarch1 = cadena1.ToString
                    If Len(txtarch1) > 0 Then
                        txtarch1 = Mid(txtarch1, 1, Len(txtarch1) - 2)
                    End If

                    If MessageBox.Show("Desea Actualizar " & cantidadreg & " registros? ", "Actualizar", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then

                        If Len(txtarch1) > 1 Then
                            If ConfigCorreo.CN_Correo.InstertarRegistroCARTAS(txtarch1) = True Then
                                ActualizarFechaImportCarta(Now.ToShortDateString)
                                MsgBox("Actualizado OK")
                            End If
                        End If

                    End If



                End If


            End If

            ''Btncargar.Text = "CARGAR " & numero & " REGISTROS A BASE TEMP"
            ''Btncargar.Enabled = True

        End Using


        'Catch ex As Exception
        '    MsgBox("Compruebe el archivo " & ex.ToString)
        'End Try


    End Sub
    Private Sub ImportarDbf(ByVal cant As Integer)
        'Try

        Dim ruta As String
        ruta = ObtenerRutaDBF()


        Dim FechaLect As Date
        FechaLect = Now.ToShortDateString
        FechaLect = FechaLect.AddDays(-cant)
        Dim dtnew As New DataTable

        'Mode=Share Deny None;
        Dim cnn As New OleDbConnection( _
           "Provider = VFPOLEDB;" & _
           "Data Source=" & ruta & ";" & _
           "Mode=Share Deny None;" & _
           "Mask Password=False;" & _
           "Cache Authentication=False;" & _
           "Encrypt Password=False;" & _
           "Collating Sequence=MACHINE;")
        Using cnn
            'Try
            ' Construimos una conslta SQL de selección, especificando únicamente()
            ' el nombre del archivo libre de FoxPro, ya que la ruta la hemos
            ' indicado en la cadena de conexión.
            '


            Dim sql As String = "SELECT NRO_CARTA, REMITENTE, FECH_TRAB, APELLIDO, CALLE, CP, LOCALIDAD, PROVINCIA, FECHA_ENTR, NRO_PLANIL, FECH_PLANI, ESTADO, CARTERO, TEMA4, FECH4, NRO_CART2, MOTIVO_ANT, TRAMITE, EMPRESA FROM CARTAS.DBF WHERE REMITENTE<>'TCA' AND REMITENTE<>'ILHSA' AND REMITENTE<>'SWCART' AND REMITENTE<>'SWCPMI' AND REMITENTE<>'SWRRHH' AND REMITENTE<>'SWCAR' AND REMITENTE<>'SWCCON' AND REMITENTE<>'SWASIS' AND REMITENTE<>'SWMARK' AND REMITENTE<>'SWMARA' AND REMITENTE<>'SWCARS' AND REMITENTE<>'ECCOF'" & _
            " AND FECH_TRAB > {^" & ConfigCorreo.CN_Correo.Converfecha(FechaLect) & "}"

            Dim da As New OleDbDataAdapter(sql, cnn)

            Dim ds As New DataSet

            da.Fill(ds, sql)

            Dim dt As DataTable = ds.Tables(sql)
            dtnew = dt

            Dim numero As Integer = 0
            numero = dt.Rows.Count

            If MessageBox.Show("Hay " & numero & " Registros para analizar continuar?", numero & " Registros desea continuar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If Eliminardatostablatemporal() = True Then

                    Dim txtcad1 As String
                    Dim cadena1 As New System.Text.StringBuilder
                    Dim txtarch1 As String = ""

                    Dim txtcad2 As String
                    Dim cadena2 As New System.Text.StringBuilder
                    Dim txtarch2 As String = ""

                    If dtnew.Rows.Count > 40000 Then

                        For i As Integer = 0 To 40000 - 1
                            txtcad1 = "(" & "'" & dtnew.Rows(i)("NRO_CARTA").ToString & "' , " _
                            & "'" & dtnew.Rows(i)("REMITENTE").ToString & "'" & ", " _
                            & "'" & Converfecha(Normalizar(dtnew.Rows(i)("FECH_TRAB").ToString)) & "'" & ", " _
                            & "'" & Normalizar(dtnew.Rows(i)("APELLIDO").ToString) & "'" & ", " _
                            & "'" & Normalizar(dtnew.Rows(i)("CALLE".ToString)) & "'" & ", " _
                            & "'" & Normalizar(dtnew.Rows(i)("CP").ToString) & "'" & ", " _
                            & "'" & Normalizar(dtnew.Rows(i)("LOCALIDAD").ToString) & "'" & ", " _
                            & "'" & Normalizar(dtnew.Rows(i)("PROVINCIA").ToString) & "'" & ", " _
                            & "'" & Normalizar(dtnew.Rows(i)("FECHA_ENTR").ToString) & "'" & ", " _
                            & "'" & dtnew.Rows(i)("NRO_PLANIL").ToString & "'" & ", " _
                            & "'" & Converfecha(Normalizar(dtnew.Rows(i)("FECH_PLANI").ToString)) & "'" & ", " _
                            & "'" & dtnew.Rows(i)("ESTADO").ToString & "'" & ", " _
                            & "'" & dtnew.Rows(i)("CARTERO").ToString & "'" & ", " _
                            & "'" & dtnew.Rows(i)("TEMA4").ToString & "'" & ", " _
                            & "'" & Normalizar(dtnew.Rows(i)("FECH4").ToString) & "'" & ", " _
                            & "'" & dtnew.Rows(i)("NRO_CART2").ToString & "'" & ", " _
                            & "'" & dtnew.Rows(i)("NRO_CART2").ToString.Substring(0, 15) & "'" & ", " _
                            & "'" & dtnew.Rows(i)("MOTIVO_ANT").ToString & "'" & ", " _
                            & "'" & dtnew.Rows(i)("TRAMITE").ToString & "'" & "" & ", " _
                            & "'" & Normalizar(dtnew.Rows(i)("EMPRESA").ToString) & "'" & ")" & ", "
                            cadena1.Append(txtcad1)
                        Next
                        txtarch1 = cadena1.ToString
                        If Len(txtarch1) > 0 Then
                            txtarch1 = Mid(txtarch1, 1, Len(txtarch1) - 2)
                        End If

                        For d As Integer = 40000 To dtnew.Rows.Count - 1
                            txtcad2 = "(" & "'" & dtnew.Rows(d)("NRO_CARTA").ToString & "' , " _
                                  & "'" & dtnew.Rows(d)("REMITENTE").ToString & "'" & ", " _
                                  & "'" & Converfecha(Normalizar(dtnew.Rows(d)("FECH_TRAB").ToString)) & "'" & ", " _
                                  & "'" & Normalizar(dtnew.Rows(d)("APELLIDO").ToString) & "'" & ", " _
                                  & "'" & Normalizar(dtnew.Rows(d)("CALLE".ToString)) & "'" & ", " _
                                  & "'" & Normalizar(dtnew.Rows(d)("CP").ToString) & "'" & ", " _
                                  & "'" & Normalizar(dtnew.Rows(d)("LOCALIDAD").ToString) & "'" & ", " _
                                  & "'" & Normalizar(dtnew.Rows(d)("PROVINCIA").ToString) & "'" & ", " _
                                  & "'" & Normalizar(dtnew.Rows(d)("FECHA_ENTR").ToString) & "'" & ", " _
                                  & "'" & dtnew.Rows(d)("NRO_PLANIL").ToString & "'" & ", " _
                                  & "'" & Converfecha(Normalizar(dtnew.Rows(d)("FECH_PLANI").ToString)) & "'" & ", " _
                                  & "'" & dtnew.Rows(d)("ESTADO").ToString & "'" & ", " _
                                  & "'" & dtnew.Rows(d)("CARTERO").ToString & "'" & ", " _
                                  & "'" & dtnew.Rows(d)("TEMA4").ToString & "'" & ", " _
                                  & "'" & Normalizar(dtnew.Rows(d)("FECH4").ToString) & "'" & ", " _
                                  & "'" & dtnew.Rows(d)("NRO_CART2").ToString & "'" & ", " _
                                  & "'" & dtnew.Rows(d)("NRO_CART2").ToString.Substring(0, 15) & "'" & ", " _
                                  & "'" & dtnew.Rows(d)("MOTIVO_ANT").ToString & "'" & ", " _
                                  & "'" & dtnew.Rows(d)("TRAMITE").ToString & "'" & "" & ", " _
                                  & "'" & Normalizar(dtnew.Rows(d)("EMPRESA").ToString) & "'" & ")" & ", "
                            cadena2.Append(txtcad2)
                        Next

                        txtarch2 = cadena2.ToString
                        If Len(txtarch2) > 0 Then
                            txtarch2 = Mid(txtarch2, 1, Len(txtarch2) - 2)
                        End If
                    Else


                        For i As Integer = 0 To dtnew.Rows.Count - 1

                            txtcad1 = "(" & "'" & dtnew.Rows(i)("NRO_CARTA").ToString & "' , " _
                            & "'" & dtnew.Rows(i)("REMITENTE").ToString & "'" & ", " _
                            & "'" & Converfecha(Normalizar(dtnew.Rows(i)("FECH_TRAB").ToString)) & "'" & ", " _
                            & "'" & Normalizar(dtnew.Rows(i)("APELLIDO").ToString) & "'" & ", " _
                            & "'" & Normalizar(dtnew.Rows(i)("CALLE".ToString)) & "'" & ", " _
                            & "'" & Normalizar(dtnew.Rows(i)("CP").ToString) & "'" & ", " _
                            & "'" & Normalizar(dtnew.Rows(i)("LOCALIDAD").ToString) & "'" & ", " _
                            & "'" & Normalizar(dtnew.Rows(i)("PROVINCIA").ToString) & "'" & ", " _
                            & "'" & Normalizar(dtnew.Rows(i)("FECHA_ENTR").ToString) & "'" & ", " _
                            & "'" & dtnew.Rows(i)("NRO_PLANIL").ToString & "'" & ", " _
                            & "'" & Converfecha(Normalizar(dtnew.Rows(i)("FECH_PLANI").ToString)) & "'" & ", " _
                            & "'" & dtnew.Rows(i)("ESTADO").ToString & "'" & ", " _
                            & "'" & dtnew.Rows(i)("CARTERO").ToString & "'" & ", " _
                            & "'" & dtnew.Rows(i)("TEMA4").ToString & "'" & ", " _
                            & "'" & Normalizar(dtnew.Rows(i)("FECH4").ToString) & "'" & ", " _
                            & "'" & dtnew.Rows(i)("NRO_CART2").ToString & "'" & ", " _
                            & "'" & dtnew.Rows(i)("NRO_CART2").ToString.Substring(0, 15) & "'" & ", " _
                            & "'" & dtnew.Rows(i)("MOTIVO_ANT").ToString & "'" & ", " _
                            & "'" & dtnew.Rows(i)("TRAMITE").ToString & "'" & "" & ", " _
                            & "'" & Normalizar(dtnew.Rows(i)("EMPRESA").ToString) & "'" & ")" & ", "
                            cadena1.Append(txtcad1)
                        Next
                        txtarch1 = cadena1.ToString
                        If Len(txtarch1) > 0 Then
                            txtarch1 = Mid(txtarch1, 1, Len(txtarch1) - 2)
                        End If

                    End If



                    If MessageBox.Show("Desea Actualizar", "Actualizar", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                        If ConfigCorreo.CN_Correo.InstertarRegistroTRANSITO(txtarch1) = True Then

                            If Len(txtarch2) > 1 Then
                                If ConfigCorreo.CN_Correo.InstertarRegistroTRANSITO(txtarch2) = True Then
                                    ActualizarFechaBaseTR(Now.ToShortDateString)
                                    MsgBox("Actualizado OK")
                                End If
                            Else
                                ActualizarFechaBaseTR(Now.ToShortDateString)
                                MsgBox("Actualizado OK")
                            End If

                        Else
                            MessageBox.Show("Error", "Error")
                        End If
                    End If


                End If
            End If







            'Btncargar.Text = "CARGAR " & numero & " REGISTROS A BASE TEMP"
            'Btncargar.Enabled = True

        End Using


        'Catch ex As Exception
        '    MsgBox("Compruebe el archivo " & ex.ToString)
        'End Try


    End Sub
    Private Sub BtnRecred_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        frmestados = Nothing
        If frmestados Is Nothing Then
            frmestados = New FrmEstados
            frmestados.Show()
            Me.Visible = False
        ElseIf frmestados.IsDisposed Then
            Me.Visible = True
        End If
    End Sub
    Private Sub Btnimpresionplanificacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnimpresionplanificacion.Click
        frmmodifest = Nothing
        If frmmodifest Is Nothing Then
            frmmodifest = New FrmImprimirPlanificacion
            frmmodifest.Show()
            Me.Visible = False
        ElseIf frmmodifest.IsDisposed Then
            Me.Visible = True
        End If
    End Sub
    Private Sub FrmDevolucion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FrmDevolucion.Click
        'frmdevo
        frmdevo = Nothing
        If frmdevo Is Nothing Then
            frmdevo = New FrmDevolucion
            frmdevo.Show()
            Me.Visible = False
        ElseIf frmdevo.IsDisposed Then
            Me.Visible = True
        End If

    End Sub


    Private Sub Btnimportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnimportar.Click
        'frmcimpppal
        frmcimpppal = Nothing
        If frmcimpppal Is Nothing Then
            frmcimpppal = New FrmImportarPpal
            frmcimpppal.Show()
            Me.Visible = False
        ElseIf frmcimpppal.IsDisposed Then
            Me.Visible = True
        End If
    End Sub

    Private Sub FrmPLanillaZonales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FrmPLanillaZonales.Click
        frmzon = Nothing
        If frmzon Is Nothing Then
            frmzon = New FrmZonales
            frmzon.Show()
            Me.Visible = False
        ElseIf frmcimpppal.IsDisposed Then
            Me.Visible = True
        End If

        'frmzon
    End Sub

    Private Sub BtnReporteZonales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnReporteZonales.Click

        frmRptZon = Nothing
        If frmRptZon Is Nothing Then
            frmRptZon = New FrmReporteZonal
            frmRptZon.Show()
            Me.Visible = False
        ElseIf frmcimpppal.IsDisposed Then
            Me.Visible = True
        End If


    End Sub

    Private Sub BtnConfEntreDevoSucu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnConfEntreDevoSucu.Click
        'FrmConfEntreDevoSucu
        FrmConfEntreDevoSucu = Nothing
        If FrmConfEntreDevoSucu Is Nothing Then
            FrmConfEntreDevoSucu = New FrmEntreSucuDevoSucu
            FrmConfEntreDevoSucu.Show()
            Me.Visible = False
        ElseIf frmcimpppal.IsDisposed Then
            Me.Visible = True
        End If


    End Sub

    Private Sub BtnConfirmacionAcuse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnConfirmacionAcuse.Click
        frmconfAcu = Nothing
        If frmconfAcu Is Nothing Then
            frmconfAcu = New FrmConfirmacionAcuse
            frmconfAcu.Show()
            Me.Visible = False
        ElseIf frmcimpppal.IsDisposed Then
            Me.Visible = True
        End If

    End Sub

    Private Sub ChkActivarConfig_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ChkActivarConfig.CheckStateChanged
        If ChkActivarConfig.CheckState = CheckState.Checked Then

            PnlConfiguracion.Enabled = True

        End If
    End Sub

    Private Sub BtnTransoft_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTransoft.Click
        frmTrs = Nothing
        If frmTrs Is Nothing Then
            frmTrs = New FrmAnalizarBases
            frmTrs.Show()

            Me.Visible = False
        ElseIf frmcimpppal.IsDisposed Then
            Me.Visible = True
        End If

    End Sub



    Private Sub BtnMotivos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMotivos.Click

        frmMot = Nothing
        If frmMot Is Nothing Then
            frmMot = New FrmMotivos

            frmMot.Show()

            Me.Visible = False
        ElseIf frmcimpppal.IsDisposed Then
            Me.Visible = True
        End If


    End Sub

 
    Private Sub BtnListadoPiezas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnListadoPiezas.Click
        'FrmListaPiez
        FrmListaPiez = Nothing
        If FrmListaPiez Is Nothing Then
            FrmListaPiez = New FrmListadoPiezas

            FrmListaPiez.Show()

            Me.Visible = False
        ElseIf frmcimpppal.IsDisposed Then
            Me.Visible = True
        End If




    End Sub
End Class
