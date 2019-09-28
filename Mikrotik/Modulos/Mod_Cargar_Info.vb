Module Mod_Cargar_Info

    Public Function VerificaRequerimientos() As Boolean
        Dim Respuesta As Boolean = True

        If Not Verifica_Access() Then
            Mensaje("Se requiere Microsoft Access 2003 o superior para funcionar!", 2)
            Respuesta = False
        End If

        Return Respuesta
    End Function

    Private Function Verifica_Access() As Boolean
        Try
            Dim Objeto As Object
            ' -- Crear una referencia al objeto  
            Objeto = CreateObject("Access.Application")
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

End Module
