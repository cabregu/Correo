Imports ConfigCorreo.CN_Correo

Public Class FrmSeguimiento

    Dim ArrMotiv As New ArrayList
    Dim Listatemportal As New ArrayList


    Private Sub FrmSeguimiento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ChkEntregada.CheckState = CheckState.Checked

    End Sub
    Private Sub ChkEntregada_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkEntregada.CheckedChanged
        If ChkEntregada.Checked = True Then
            GpbEntregadas.Enabled = True
            ChkNoEntregada.CheckState = CheckState.Unchecked
            TxtNroCartaEntregada.Focus()
        Else
            GpbEntregadas.Enabled = False
            TxtNroCartaEntregada.Text = ""
            TxtNroCartaEntregada.Focus()
        End If
    End Sub
    Private Sub ChkNoEntregada_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkNoEntregada.CheckedChanged
        If ChkNoEntregada.Checked = True Then
            GpbNoEntregadas.Enabled = True
            TxtNroCartaNoEntregada.Focus()
            ChkEntregada.CheckState = CheckState.Unchecked
            Dim ArrMotiv As New ArrayList
            Dim ListaItems As New List(Of String)
            ListaItems.Clear()
            ArrMotiv = ConfigCorreo.CN_Correo.CargarMotivos
            For i As Integer = 0 To ArrMotiv.Count - 1
                ListaItems.Add(ArrMotiv.Item(i).ToString)
            Next

            CmbNoEntregada.DataSource = ListaItems
            CmbNoEntregada.AutoCompleteMode = AutoCompleteMode.Suggest
            CmbNoEntregada.AutoCompleteSource = AutoCompleteSource.ListItems

            CmbNoEntregada.Show()
            CmbNoEntregada.Text = ""


        Else
            GpbNoEntregadas.Enabled = False
        End If

   


    End Sub

    Private Sub CmbNoEntregada_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbNoEntregada.KeyDown
    If e.KeyCode = Keys.Return Then
            e.Handled = True

            If Len(CmbNoEntregada.Text) > 0 Then
                BtnOkNoentregada.Focus()
            End If
        End If
    End Sub

 
    Private Function Buscarcarta(ByVal carta1 As Integer, ByVal Estado1 As String, ByVal Motivo1 As String, ByVal fecha1 As String) As Boolean




        Dim DT As New DataTable
        DT = BuscarRecorridopornrodecarta(carta1)

        If Not Listatemportal.Contains(carta1) Then
            For Each dr As DataRow In DT.Rows

                DgvRecorrido.Rows.Add(carta1, dr.Item("PLANILLA_RECORRIDO"), dr.Item("CARTERO"), fecha1, Estado1, Motivo1, dr.Item("NRO_CARTA2"), dr.Item("IDENTIFICADOR"), dr.Item("ID"))

                Listatemportal.Add(carta1)
            Next
        End If
        TxtNroCartaEntregada.Text = ""
        TxtNroCartaNoEntregada.Text = ""
        CmbNoEntregada.Text = ""




    End Function
    Private Sub TxtNroCartaEntregada_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNroCartaEntregada.KeyPress
        Try
            If Asc(e.KeyChar) = Keys.Enter Then
                e.Handled = True 'quita sonido 

                Dim EstadoTR As String = ""
                EstadoTR = BuscarEnTransitoPorNroCartaParaDevuelta(TxtNroCartaEntregada.Text)
                If EstadoTR.Contains("DEV") Then
                    MsgBox("La pieza esta para devolver estado " & EstadoTR)
                Else
                    Buscarcarta(TxtNroCartaEntregada.Text, "ENTREGADA", "", DtpFechaEntrega.Value.ToShortDateString)
                End If


                TxtTotal.Text = DgvRecorrido.RowCount
            End If
        Catch ex As Exception

        End Try

    End Sub
    Private Sub TxtNroCartaNoEntregada_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNroCartaNoEntregada.KeyPress

        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True 'quita sonido 

            If Len(TxtNroCartaNoEntregada.Text) > 0 Then

                Dim EstadoTR As String = ""
                EstadoTR = BuscarEnTransitoPorNroCartaParaDevuelta(TxtNroCartaNoEntregada.Text)
                If EstadoTR.Contains("ENT") Then
                    MsgBox("La Pieza no debe salir a recorrido  estado " & EstadoTR)
                Else
                    CmbNoEntregada.Focus()
                End If
            End If
        End If
     
    End Sub

    Private Sub BtnConfirmar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnConfirmar.Click
        For Each drg As DataGridViewRow In DgvRecorrido.Rows

            Dim Fechaf As Date = drg.Cells("FECHA").Value
            Dim Fechaftx As String
            Fechaftx = Fechaf.ToShortDateString
            If ActualizarEstadoRecorrido(drg.Cells("nro_carta").Value, drg.Cells("ESTADO").Value, drg.Cells("MOTIVO").Value, Converfecha(Fechaftx)) = True Then
                ConfigCorreo.CN_Correo.ActualizarAlertas(drg.Cells("nro_carta").Value, drg.Cells("ESTADO").Value)
                ConfigCorreo.CN_Correo.VerificarEstadoAlerta(drg.Cells("nro_carta").Value, drg.Cells("ESTADO").Value)

                '************SI es ARM actuliza en armdetalle arm planilla y cartas***********
                If ConfigCorreo.CN_Correo.VerificarSiEsArm(drg.Cells("nro_carta").Value) = True Then
                    ConfigCorreo.CN_Correo.ActualizarEstadoArm(drg.Cells("nro_carta").Value, drg.Cells("ESTADO").Value)
                End If

            End If


        Next

        DgvRecorrido.Rows.Clear()
    End Sub


  

    Private Sub BtnOkNoentregada_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOkNoentregada.Click
        If Len(CmbNoEntregada.Text) > 0 And Len(TxtNroCartaNoEntregada.Text) > 0 Then
            Dim PrimerosDigitos As String = ""
            PrimerosDigitos = CmbNoEntregada.Text.Substring(0, 2)


            If VerificarParaReprogramacion(PrimerosDigitos) = "NO" Then
                Buscarcarta(TxtNroCartaNoEntregada.Text, "PARA_DEVOLUCION", CmbNoEntregada.Text, DtpFechaEntrega.Value.ToShortDateString)
                CmbNoEntregada.Text = ""
                TxtNroCartaNoEntregada.Focus()
                TxtTotal.Text = DgvRecorrido.RowCount
            Else
                Buscarcarta(TxtNroCartaNoEntregada.Text, "PARA_REPROGRAMACION", CmbNoEntregada.Text, DtpFechaEntrega.Value.ToShortDateString)
                CmbNoEntregada.Text = ""
                TxtNroCartaNoEntregada.Focus()
                TxtTotal.Text = DgvRecorrido.RowCount

            End If

        End If

    End Sub

  
End Class
