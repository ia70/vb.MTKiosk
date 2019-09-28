Imports Renci.SshNet

Public Class PRUEBAS
    Private mk As MK
    Private estado As Boolean = False
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnIniciar.Click
        Dim user As String = "admin"
        Dim pass As String = "82497EEW"
        Dim ip As String = "192.168.1.1"
        Dim comando As String = "ip hotspot user profile print"
        Dim res As String

        Try
            Dim ssh As New SshClient(ip, user, pass)

            ssh.Connect()
            res = ssh.RunCommand(comando).Result
            txtLog.Text = res

            ssh.Disconnect()
        Catch ex As Exception

        End Try


    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtLog.Text = ""
        txtComando.Text = ""
    End Sub

    Private Sub BtnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        If estado Then
            mk.Send(txtComando.Text, False)
        End If
    End Sub

    Private Sub Leer()
        Try
            For Each row In mk.Read()
                If Not row Is Nothing Then
                    txtLog.Text = txtLog.Text + vbCrLf + row
                End If
            Next
        Catch ex As Exception

        End Try

    End Sub

    Private Sub BtnTerminarComando_Click(sender As Object, e As EventArgs) Handles btnTerminarComando.Click
        If estado Then
            mk.Send(txtComando.Text, True)
            Leer()
        End If
    End Sub

    Private Sub BtnTerminarConexion_Click(sender As Object, e As EventArgs) Handles btnTerminarConexion.Click
        Try
            estado = False
            mk.Close()
            MsgBox("Desconectado!")
        Catch ex As Exception

        End Try


    End Sub
End Class