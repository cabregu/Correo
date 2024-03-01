Imports ConfigCorreo
Public Class FrmCargarRemito


    Private Sub FrmCargarRemito_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ArrListCtes As New ArrayList
        ArrListCtes = ConfigCorreo.CN_Correo.CargarClientes
        For i As Integer = 0 To ArrListCtes.Count - 1
            CmbCliente.Items.Add(ArrListCtes.Item(i).ToString)
        Next


    End Sub
    Private Sub CmbCliente_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CmbCliente.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            If Len(CmbCliente.Text) > 1 Then
                CmbRemitente.Focus()
            End If
        End If
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Escape) Then
            Me.Close()
        End If

    End Sub
    Private Sub CmbRemitente_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CmbRemitente.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            If Len(CmbRemitente.Text) > 1 Then
                CmbServicio.Focus()
            End If
        End If
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Escape) Then
            Me.Close()
        End If

    End Sub

    Private Sub CmbServicio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CmbServicio.KeyPress

    End Sub



    Private Sub TxtNroRemito_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNroRemito.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            If Len(TxtNroRemito.Text) > 1 Then
                BtnIngresar.Focus()
            End If
        End If
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Escape) Then
            Me.Close()
        End If
    End Sub

    Private Sub CmbCliente_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbCliente.SelectedIndexChanged
        If CmbCliente.SelectedItem.ToString = "" Then
        Else
            CmbRemitente.Items.Clear()
            Dim ArrayServicios As New ArrayList
            ArrayServicios = CN_Correo.CargarTipoServicio(CmbCliente.Text)
            For i As Integer = 0 To ArrayServicios.Count - 1
                CmbRemitente.Items.Add(ArrayServicios.Item(i).ToString)
            Next
        End If

    End Sub
    Private Sub BtnIngresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnIngresar.Click
        If Len(TxtNroRemito.Text) > 0 Then

            If DGVRemito.Rows.Count = 0 Then
                Dim Fecha_retiro As String = DtpFecha_retiro.Value.ToShortDateString
                Dim Fecha_ingreso As String = Now.ToShortDateString
                Dim cliente As String = CmbCliente.Text
                Dim Servicio As String = CmbRemitente.Text
                Dim Nroremito As String = TxtNroRemito.Text
                DGVRemito.Rows.Add(Fecha_retiro, cliente, Servicio, Nroremito, CmbServicio.Text)
                Fecha_retiro = CN_Correo.Converfecha(Fecha_retiro)
                Fecha_ingreso = CN_Correo.Converfecha(Fecha_ingreso)
                CN_Correo.InsertarRemito(cliente, Servicio, "'" & Fecha_retiro & "'", Nroremito, CmbServicio.Text, "'" & Fecha_ingreso & "'")
                TxtNroRemito.Text = ""
                CmbRemitente.Text = ""
                CmbServicio.Text = ""
                CmbServicio.Enabled = False
                TxtNroRemito.Enabled = False
                CmbCliente.Focus()

            Else

                If CN_Correo.RemitoYaingreso(TxtNroRemito.Text, CmbRemitente.Text) = False Then
                    Dim Fecha_retiro As String = DtpFecha_retiro.Value.ToShortDateString
                    Dim Fecha_ingreso As String = Now.ToShortDateString
                    Dim cliente As String = CmbCliente.Text
                    Dim Servicio As String = CmbRemitente.Text
                    Dim Nroremito As String = TxtNroRemito.Text
                    DGVRemito.Rows.Add(Fecha_retiro, cliente, Servicio, Nroremito, CmbServicio.Text)
                    Fecha_retiro = CN_Correo.Converfecha(Fecha_retiro)
                    Fecha_ingreso = CN_Correo.Converfecha(Fecha_ingreso)
                    CN_Correo.InsertarRemito(cliente, Servicio, "'" & Fecha_retiro & "'", Nroremito, CmbServicio.Text, "'" & Fecha_ingreso & "'")
                    TxtNroRemito.Text = ""
                    CmbRemitente.Text = ""
                    CmbServicio.Text = ""
                    CmbServicio.Enabled = False
                    TxtNroRemito.Enabled = False
                    CmbCliente.Focus()

                Else
                    MessageBox.Show("El Remito ya fue ingresado para el remitente Seleccionado")
                End If
            End If
        Else
            MessageBox.Show("Debe Seleccionar Cliente, Servicio y Remito Obligatoriamente")
        End If

    End Sub
    Private Sub BtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminar.Click
        If DGVRemito.RowCount > 0 Then

            Dim N As String = DGVRemito.SelectedCells(0).RowIndex.ToString
            Dim Remito As String = DGVRemito.Rows(N).Cells("Nro_Remito").Value
            Dim TipoServicio As String = DGVRemito.Rows(N).Cells("Tipo").Value
            If MessageBox.Show("Eliminar " & Remito & " Para El Servicio " & TipoServicio, "Seguro desea Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                DGVRemito.Rows.Remove(DGVRemito.Rows(N))
                CN_Correo.EliminarRemito(Remito, TipoServicio)
            End If
            CmbCliente.Focus()
        End If
    End Sub
    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()
        Me.Dispose()
    End Sub
    Private Sub CmbRemitente_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbRemitente.SelectedIndexChanged
        If CmbCliente.SelectedItem.ToString = "" Then
        Else
            CmbServicio.Items.Clear()
            Dim ArrServ As New ArrayList
            ArrServ = ConfigCorreo.CN_Correo.CargarServicio
            For i As Integer = 0 To ArrServ.Count - 1
                CmbServicio.Items.Add(ArrServ.Item(i).ToString)
            Next
        End If
        CmbServicio.Enabled = True
    End Sub


    Private Sub CmbServicio_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbServicio.SelectedValueChanged
        'If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
        If Len(CmbServicio.Text) > 1 Then
            TxtNroRemito.Enabled = True
            TxtNroRemito.Focus()
        End If
        'End If
        'If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Escape) Then
        '    Me.Close()
        'End If
    End Sub
End Class