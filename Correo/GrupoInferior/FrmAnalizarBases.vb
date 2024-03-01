Imports ConfigCorreo.CN_Correo
Imports System.IO
Imports System.Data.OleDb


Public Class FrmAnalizarBases


    Private Sub BtnExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExcel.Click
        Seleccionar()

    End Sub
    Public Sub Seleccionar()

        Dim openFD As New OpenFileDialog()
        With openFD
            .Title = "Seleccionar archivos"
            .Filter = "Todos los archivos (*.xls)|*.xls"
            .Multiselect = False
            .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                If impExcel(.FileName) = True Then
                    txtPath.Text = Path.GetFileName(.FileName)
                End If
            Else
                openFD.Dispose()
            End If
        End With

    End Sub
    Private Function impExcel(ByVal Archivo As String) As Boolean

        Dim dt2 As New DataTable
        Dim strconn As String
        strconn = "Provider=Microsoft.Jet.Oledb.4.0; data source= " + Archivo + ";Extended properties=""Excel 8.0;hdr=yes;imex=1"""
        Dim mconn As New OleDbConnection(strconn)
        Dim ad As New OleDbDataAdapter("Select * from [" & "Lexs" & "$]", mconn)
        mconn.Open()
        ad.Fill(dt2)
        mconn.Close()
        DgvDatos.DataSource = dt2

        Return True

    End Function

End Class
