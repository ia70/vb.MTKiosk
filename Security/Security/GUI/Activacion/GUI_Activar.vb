Imports System.ComponentModel

Public Class GUI_Activar

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtRespuesta.Text = ""
        txtRespuesta.Select()
    End Sub

    Private Sub btnActivar_Click(sender As Object, e As EventArgs) Handles btnActivar.Click
        Dim Obj As New Activacion

        If Obj.Activar_Prodcuto(txtRespuesta.Text) Then
            MSG("Se ha activado el producto correctamente!")
            txtRespuesta.Text = ""
            _IniciarAPP = True
            _Salir = True
            Close()
        Else
            MSG("Lincencia incorrecta!", 1)
            txtRespuesta.Text = ""
            txtRespuesta.Select()
            _IniciarAPP = False
        End If
    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        GUI_NoActivado.Show()
        Close()
    End Sub

End Class