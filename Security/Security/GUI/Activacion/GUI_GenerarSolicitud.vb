Public Class GUI_GenerarSolicitud
    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        Dim Obj As New Activacion

        txtSolicitud.Text = Obj.GetRequestCode
        txtSolicitud.Enabled = True
        MSG("Solicitud generada exitosamente!")

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtSolicitud.Text = ""
        txtSolicitud.Enabled = False
    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        Close()
    End Sub
End Class