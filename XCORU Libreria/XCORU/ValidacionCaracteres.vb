
Public Class ValidacionCaracteres
    Private _Permitidos As String   'Caracteres permitidos en la validación
    Private _Prohibidos As String   'Caracteres prohibidos en la validación
    Private _TipoValidacion As Byte 'Tipo de validación seleccionada


#Region "Propiedades"

    ''' <summary>
    ''' Establece o consulta la lista de caracteres permitidos
    ''' </summary>
    ''' <value>Cadena sin separadores</value>
    ''' <returns>Cadena tipo Strings</returns>
    ''' <remarks></remarks>
    Public Property Permitidos() As String
        Get
            Return _Permitidos
        End Get
        Set(ByVal Caracteres As String)
            _Permitidos = Caracteres
        End Set
    End Property

    ''' <summary>
    ''' Establece o consulta la lista de caracteres prohibidos
    ''' </summary>
    ''' <param name="Caracteres">Cadena de caracteres prohibidos</param>
    ''' <value>Cadena sin separadores</value>
    ''' <returns>Cadena tipo Strings</returns>
    ''' <remarks></remarks>
    Public Property Prohibidos(ByVal Caracteres As String)
        Get
            Return _Prohibidos
        End Get
        Set(value)
            _Prohibidos = Caracteres
        End Set
    End Property

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    Public Property TipoValidacion() As Byte
        Get
            Return _TipoValidacion
        End Get
        Set(ByVal Valor As Byte)
            _TipoValidacion = Valor
        End Set
    End Property

#End Region

    ''' <summary>
    ''' Inicialización de la clase ValidacionCaracteres
    ''' </summary>
    ''' <param name="TipoValidacion">Valores posibles:
    ''' <list type="bullet">
    ''' <item><description>1- Letras y números</description></item>
    ''' <item><description>2- Solo letras</description></item>
    ''' <item><description>3- Solo números</description></item>
    ''' <item><description>4- Caracteres Permitidos</description></item>
    ''' <item><description>5- Caracteres Prohibidos</description></item>
    ''' </list>
    ''' </param>
    ''' <param name="Permitidos">Cadena de caracteres permitidos (Opcional)</param>
    ''' <remarks>
    ''' Ejemplo:
    ''' <code>
    ''' Imports Libersoft.ValidacionCaracteres
    ''' Public Class MiClase
    ''' 
    '''     Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    '''         Dim Validacion As New Libersoft.ValidacionCaracteres(4, "abcd1234")
    '''     End Sub
    ''' 
    ''' End Class
    ''' </code>
    ''' </remarks>
    Public Sub New(Optional ByVal TipoValidacion As Byte = 1, Optional ByVal Permitidos As String = "")
        _TipoValidacion = TipoValidacion
        _Permitidos = Permitidos
    End Sub

    ''' <summary>
    ''' Verificar
    ''' </summary>
    ''' <param name="Cadena">Caracter ó cadena a verificar</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Verificar(ByVal Cadena As String) As String

        Return ""
    End Function
End Class
