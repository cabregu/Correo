Public Class FrmAvisoDeVisita
    Public Idstr As String

    Private Sub FrmAvisoDeVisita_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargar(Idstr)
    End Sub

    Private Sub cargar(ByVal ident As String)
        Dim Dt As New DataTable
        Dt = ConfigCorreo.CN_Correo.ConsultarUndato(ident)

        For Each dr As DataRow In Dt.Rows
            FECH_TRABTextBox.Text = dr("FECH_TRAB").ToString()
            NRO_CARTATextBox.Text = dr("NRO_CARTA").ToString()
            REMITENTETextBox.Text = dr("REMITENTE").ToString()
            TRABAJOTextBox.Text = dr("TRABAJO").ToString()
            NRO_CART2TextBox.Text = dr("NRO_CART2").ToString()
            NOMBRE_APELLIDOTextBox.Text = dr("APELLIDO").ToString()
            SERVICIOTextBox.Text = ConfigCorreo.CN_Correo.ObtenerServicio(dr("TRABAJO").ToString())
            CALLETextBox.Text = dr("CALLE").ToString()
            CPTextBox.Text = dr("CP").ToString()
            LOCALIDADTextBox.Text = dr("LOCALIDAD").ToString()
            PROVINCIATextBox.Text = dr("PROVINCIA").ToString()
            EMPRESATextBox.Text = dr("EMPRESA").ToString()
            ESTADOTextBox.Text = dr("ESTADO").ToString()
            SOCIOTextBox.Text = dr("SOCIO").ToString()
            DgvAvisos.DataSource = ConfigCorreo.CN_Correo.ObtenerAvisoDeVisita(dr("NRO_CARTA").ToString())
        
        Next

        If DgvAvisos.RowCount > 0 Then
            BtnAvisoDeVisita.Enabled = False
        End If



    End Sub

    Private Sub BtnAvisoDeVisita_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAvisoDeVisita.Click

        If NRO_CARTATextBox.Text <> "" Then
           
            Dim fechaingreso As Date
            fechaingreso = Now
            If ConfigCorreo.CN_Correo.InsertarAvisoDeVisita(CALLETextBox.Text, CPTextBox.Text, LOCALIDADTextBox.Text, PROVINCIATextBox.Text, OBSTextBox.Text, NRO_CARTATextBox.Text, fechaingreso) = True Then
                Me.Close()
            End If

        End If

    End Sub


End Class
