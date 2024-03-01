Imports System.Transactions

Public Class FrmCambiarEstado

    Public nombreremitente As String
    Public nroremito As String
    Public Cant As Integer


    Private Sub BtnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOk.Click

        Try
            Using tx As New TransactionScope
           
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Close()
    End Sub

    Private Sub FrmCambiarEstado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Desea cambiar estado del remitente " & nombreremitente & " remito " & nroremito & "?"
    End Sub


End Class