
Public Class GUI_NoActivado
    Public Salir As Boolean = False

    Private Sub btnGenerarSolicitud_Click(sender As Object, e As EventArgs) Handles btnGenerarSolicitud.Click
        'Hide()
        GUI_GenerarSolicitud.ShowDialog()
    End Sub

    Private Sub btnActivar_Click(sender As Object, e As EventArgs) Handles btnActivar.Click
        GUI_Activar.ShowDialog()
        If _Salir Then
            Close()
        End If
    End Sub
End Class