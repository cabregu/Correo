Imports ConfigCorreo.CN_Correo

Public Class FrmPlanificacion
    Dim Listatemporal As New ArrayList
    Dim OrdenAsc As Integer = 0


    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click
        Dim NroRecorrido As Integer
        NroRecorrido = ConfigCorreo.CN_Correo.ObtenerNroPlanillarecorrido
        TxtPlanillaRecorrido.Text = NroRecorrido


        Dim ArrayCarteros As New ArrayList
        ArrayCarteros = ConfigCorreo.CN_Correo.CargarCarteros
        CmbCarteroEmpresa.Items.Clear()
        CmbCarteroEmpresa.Enabled = True
        For i As Integer = 0 To ArrayCarteros.Count - 1
            CmbCarteroEmpresa.Items.Add(ArrayCarteros.Item(i).ToString)
        Next

        CmbCarteroEmpresa.Text = ""
        TxtCantidad.Text = ""
        DgvCartaPlanif.Rows.Clear()

        ActualizarNroPlanillarecorrido(NroRecorrido)

    End Sub
    Private Sub TxtCartas_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCartas.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True 'quita sonido 

            If IsNumeric(TxtCartas.Text) Then
                If CmbServicio.Text <> "" Then
                    Buscarcarta(TxtCartas.Text)
                    TxtCartas.Text = ""
                    TxtCantidad.Text = ""
                    TxtCantidad.Text = DgvCartaPlanif.Rows.Count
                End If


            End If
        End If
    End Sub
    Private Function Buscarcarta(ByVal carta As Integer) As Boolean
        'Try
        Dim DT As New DataTable
            Dim TxEstado As String = ""
            TxEstado = VerificarEstadoCarta(carta)
            If TxEstado = "ENTREGADA" Or TxEstado = "PARA_DEVOLUCION" Or TxEstado = "DEVUELTA" Then
                MsgBox("El estado de la carta es un estado Finalizado debe cambiar el estado " & TxEstado & " A alguno programable")
            Else
                '**********Devuelve planilla Si fue leida antes y aun esta en distribucion*****
                Dim PlanillaAnt As String
                PlanillaAnt = ConfigCorreo.CN_Correo.VerificarRecorridoPorCarta(carta)

                If Len(PlanillaAnt) > 0 Then
                    EliminarCartaDeRecorridoPorCartaYPlanilla(carta, PlanillaAnt)
                    ActualizarEstadoCartaPorCartaEnEsperaDeRecorrido(carta)
                End If

                '***************
                DT = Buscarpornrodecarta(carta)
                If DT.Rows.Count = 0 Then
                    PlayBackgroundSoundFile()
                End If

                If Not Listatemporal.Contains(carta) Then
                    For Each dr As DataRow In DT.Rows
                        Dim fechtrab As Date = dr.Item("FECH_TRAB")
                        DgvCartaPlanif.Rows.Add(carta, dr.Item("REMITENTE"), dr.Item("TRABAJO"), fechtrab.ToShortDateString, dr.Item("APELLIDO"), dr.Item("CP"), dr.Item("CALLE"), dr.Item("LOCALIDAD"), dr.Item("PROVINCIA"), dr.Item("EMPRESA"), dr.Item("NRO_CART2"), OrdenAsc + 1, dr.Item("ID"))
                        OrdenAsc = OrdenAsc + 1
                        Listatemporal.Add(carta)
                    Next
                End If

                '************ARM***
                Dim dtarm As New DataTable

                dtarm = Buscarpornrodearm(carta)
                If dtarm.Rows.Count = 0 Then
                    PlayBackgroundSoundFile()
                End If

                If Not Listatemporal.Contains(carta) Then
                    For Each dr As DataRow In dtarm.Rows
                        Dim fechtrab As Date = dr.Item("FECH_TRAB")
                    DgvCartaPlanif.Rows.Add(carta, dr.Item("REMITENTE"), dr.Item("TRABAJO"), fechtrab.ToShortDateString, dr.Item("APELLIDO"), dr.Item("CP"), dr.Item("CALLE"), dr.Item("LOCALIDAD"), dr.Item("PROVINCIA"), dr.Item("EMPRESA"), dr.Item("NRO_CART2"), OrdenAsc + 1, dr.Item("ARM"))
                    OrdenAsc = OrdenAsc + 1
                        Listatemporal.Add(carta)
                    Next
                End If



            End If


        'Catch ex As Exception
        '    Return False
        'End Try



    End Function
    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub


    Private Sub CmbCarteroEmpresa_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbCarteroEmpresa.SelectedIndexChanged
        If Len(CmbCarteroEmpresa.Text) Then
            CmbServicio.Enabled = True
            TxtCartas.Enabled = True
            TxtZona.Enabled = True
            CmbServicio.Focus()
        End If
    End Sub
    Private Sub CmbServicio_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbServicio.SelectedIndexChanged
        If Len(CmbServicio.Text) > 0 Then

            TxtZona.Focus()
        End If

    End Sub
    Private Sub TxtZona_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtZona.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True 'quita sonido
            TxtCartas.Focus()
        End If

    End Sub
    Private Sub BtnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click

        If Len(CmbServicio.Text) > 0 Then
            If DgvCartaPlanif.RowCount > 0 Then
                For Each drgv As DataGridViewRow In DgvCartaPlanif.Rows
                    IngresarNuevoRecorrido(drgv.Cells("Nro_carta").Value, TxtPlanillaRecorrido.Text, DtpFecha.Value.ToShortDateString, CmbCarteroEmpresa.Text, TxtZona.Text, drgv.Cells("REMITENTE").Value, _
                    drgv.Cells("TRABAJO").Value, drgv.Cells("FECH_TRAB").Value, drgv.Cells("NOMBRE_APELLIDO").Value, drgv.Cells("CP").Value, drgv.Cells("CALLE").Value, drgv.Cells("LOCALIDAD").Value, _
                    drgv.Cells("PROVINCIA").Value, drgv.Cells("EMPRESA").Value, drgv.Cells("NRO_CARTA2").Value, drgv.Cells("OrdenLectura").Value, drgv.Cells("id").Value)
                    ActualizarCartas(drgv.Cells("id").Value)
                Next
                InsertarRecorridosplanillas(DtpFecha.Value.ToShortDateString, TxtPlanillaRecorrido.Text, TxtZona.Text, TxtCantidad.Text, CmbCarteroEmpresa.Text, CmbServicio.Text)
                DgvCartaPlanif.Rows.Clear()
                TxtPlanillaRecorrido.Text = ""
                TxtCantidad.Text = 0
                CmbCarteroEmpresa.Text = ""
                TxtZona.Text = ""
                Me.Visible = False
                FrmImprimirPlanificacion.Show()
            End If
        Else
            MsgBox("El Servicio es obligatorio")
        End If


    End Sub
    Private Sub BtnImpimirPlanificaion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnImpimirPlanificaion.Click
        Me.Visible = False
        FrmImprimirPlanificacion.Show()
    End Sub

    Private Sub Btneliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btneliminar.Click
        If Not IsDBNull(DgvCartaPlanif.SelectedCells(0).RowIndex.ToString) Then
            Dim N As String = DgvCartaPlanif.SelectedCells(0).RowIndex.ToString
            Dim STR As String = DgvCartaPlanif.Rows(N).Cells("Nro_Carta").Value
            If MessageBox.Show("Eliminar carta " & STR & " ?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                DgvCartaPlanif.Rows.Remove(DgvCartaPlanif.Rows(N))
                Listatemporal.Remove(STR)
                TxtCantidad.Text = DgvCartaPlanif.Rows.Count
            End If

        End If

    End Sub

    Private Sub FrmPlanificacion_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If DgvCartaPlanif.RowCount > 0 Then
            For Each drw As DataGridViewRow In DgvCartaPlanif.Rows
                If BuscaCartaPorCartaEnEsperaDeRecorrido(drw.Cells("NRO_CARTA").Value) = True Then
                    MsgBox("La Carta " & drw.Cells("NRO_CARTA").Value & " espera un recorrido")
                End If
            Next
        End If
    End Sub

    Sub PlayBackgroundSoundFile()
        Try
            My.Computer.Audio.Play("C:\errorpp.wav", AudioPlayMode.WaitToComplete)
        Catch ex As System.Exception

        End Try

    End Sub




    Private Sub BtnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnActualizar.Click
        Dim DT As New DataTable
        DT = CargarRecorridosplanillaparaaveriguarZona()

        dgv11.DataSource = DT

        For Each drw As DataGridViewRow In dgv11.Rows
            If drw.Cells("zona").Value.ToString.Contains("simple") Or drw.Cells("zona").Value.ToString.Contains("SIMPLE") Then
                ActualizarServicioSimpleyconacuse(drw.Cells("nroplanilla").Value, "SIMPLE")

            Else

                ActualizarServicioSimpleyconacuse(drw.Cells("nroplanilla").Value, "CON ACUSE")

            End If

        Next

    End Sub

    Private Sub BtnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscar.Click
        BtnNuevo.Enabled = False
        TxtPlanillaRecorrido.Enabled = True
        CmbCarteroEmpresa.Enabled = False
        CmbServicio.Enabled = False
        DtpFecha.Enabled = False
        TxtCantidad.Enabled = False
        TxtZona.Enabled = False
        TxtCartas.Enabled = True

    End Sub

    Private Sub TxtPlanillaRecorrido_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPlanillaRecorrido.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True 'quita sonido 
            If IsNumeric(TxtCartas.Text) Then
                '***consultar

                Dim DTRecorrido As New DataTable
                DTRecorrido = ConsultarRecorridosParaReleer(TxtPlanillaRecorrido.Text)

                For Each drw As DataRow In DTRecorrido.Rows
                    DgvCartaPlanif.Rows.Add(drw("Nro_carta"), drw("Remitente"), drw("Trabajo"), drw("fech_trab"), drw("nombre_apellido"), drw("cp"), drw("calle"), drw("localidad"), drw("provincia"), drw("empresa"), drw("nro_carta2"), drw("orden_lect"), drw("Id"))
                Next

            Else
                MsgBox("No se reconoce el numero")
            End If
        End If
    End Sub

End Class
