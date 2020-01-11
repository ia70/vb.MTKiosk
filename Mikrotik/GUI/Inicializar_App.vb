Imports Security

Public Class Inicializar_App
    Private Sub Inicializar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If VerificaRequerimientos() Then
            'GUI_Principal.Show()
            Dim Obj As New Activacion
            If Obj.IniciarAPP Then
                GUI_Principal.Show()
            End If
            Close()
            Else
                End
        End If
    End Sub
End Class