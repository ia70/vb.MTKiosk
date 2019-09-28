Module Config

    ''' <summary>
    ''' Mensaje
    ''' </summary>
    ''' <param name="Mensaje">Cadena de texto</param>
    ''' <param name="Tipo">
    ''' Informacion - 0; 
    ''' Exclamación - 1; 
    ''' Critico - 2; 
    ''' Pregunta - 3
    ''' </param>
    Public Sub MSG(ByVal Mensaje As String, Optional ByVal Tipo As Integer = 0)
        Dim Empresa As String = "Activación"

        Select Case Tipo
            Case 0
                MsgBox(Mensaje, vbInformation, Empresa)
            Case 1
                MsgBox(Mensaje, vbExclamation, Empresa)
            Case 2
                MsgBox(Mensaje, vbCritical, Empresa)
            Case 3
                MsgBox(Mensaje, vbQuestion, Empresa)
            Case Else
                MsgBox(Mensaje, vbInformation, Empresa)
        End Select

    End Sub

    Public _IniciarAPP As Boolean = False
    Public _Salir As Boolean = False
End Module
