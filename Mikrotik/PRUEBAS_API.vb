

Public Class PRUEBAS_API
    Implements IDisposable

    'Private ssh As SshClient

    Private Sub btnIniciar_Click(sender As Object, e As EventArgs) Handles btnIniciar.Click
        Try
            'ssh = New SshClient(txtIP.Text, "sshuser", "82497")
            'ssh.Connect()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnTerminarConexion_Click(sender As Object, e As EventArgs) Handles btnTerminarConexion.Click
        'ssh.Disconnect()
    End Sub

    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        'txtLog.Text += vbCrLf + ssh.RunCommand(txtComando.Text).Result
        txtComando.Text = ""
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtComando.Text = ""
        txtLog.Text = ""
    End Sub
End Class