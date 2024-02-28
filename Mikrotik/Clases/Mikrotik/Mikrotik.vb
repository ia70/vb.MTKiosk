Imports IA70.Mikrotik.Library

Public Class Mikrotik
    Private _IP As String = ""
    Private _Usuario As String = ""
    Private _Password As String = ""
    Private _Puerto As Integer = -1

    Private MK As SSH_Core

#Region "Propiedades"
    ''' <summary>
    ''' Obtiene - Establece -> Dirección IP del Dispositivo Mikrotik
    ''' </summary>
    ''' <returns>IP Mikrotik</returns>
    Public Property IP As String
        Get
            Return Me._IP
        End Get
        Set(value As String)
            Me._IP = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene - Establece -> Nombre de Usuario
    ''' </summary>
    ''' <returns>Nombre de Usuario</returns>
    Public Property Usuario As String
        Get
            Return Me._Usuario
        End Get
        Set(value As String)
            Me._Usuario = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene - Establece -> Contraseña de inicio de sesión
    ''' </summary>
    ''' <returns>Contraseña</returns>
    Public Property Password As String
        Get
            Return Me._Password
        End Get
        Set(value As String)
            Me._Password = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene - Establece -> Puerto del dispositivo Mikrotik
    ''' </summary>
    ''' <returns>Puerto del dispositivo Mikrotik</returns>
    Public Property Puerto As Integer
        Get
            Return Me._Puerto
        End Get
        Set(value As Integer)
            Me._Puerto = value
        End Set
    End Property

#End Region

    ''' <summary>
    ''' Constructor
    ''' </summary>
    Public Sub New()
    End Sub

    ''' <summary>
    ''' Construtor de case
    ''' </summary>
    ''' <param name="ip">IP Mikrotik</param>
    ''' <param name="puerto">Puerto</param>
    ''' <param name="usuario">Usuario</param>
    ''' <param name="password">Passwrd</param>
    Public Sub New(ip As String, puerto As Integer, usuario As String, password As String)
        _IP = ip
        _Usuario = usuario
        _Password = password
        _Puerto = puerto

        MK = Nothing
    End Sub

    Public Function Test() As Boolean
        Return Test(IP, Puerto, Usuario, Password)
    End Function

    ''' <summary>
    ''' Realiza prueba de conexión
    ''' </summary>
    ''' <param name="ip">IP Mikrotik</param>
    ''' <param name="puerto">Puerto</param>
    ''' <param name="usuario">Usuario</param>
    ''' <param name="password">Password</param>
    ''' <returns></returns>
    Public Function Test(ip As String, puerto As Integer, usuario As String, password As String) As Boolean
        Dim cMK As New SSH_Core
        Return cMK.TestConnection(ip, puerto, usuario, password)
    End Function

    ''' <summary>
    ''' Envia comando a Mikrotik y cierra conexión
    ''' </summary>
    ''' <param name="comando">Comando a enviar</param>
    ''' <returns></returns>
    Public Function Send(ByVal comando As String) As String
        Dim cMK As New SSH_Core(_IP, _Puerto, _Usuario, _Password)
        Return cMK.Send(comando)
    End Function

    ''' <summary>
    ''' Envia comando a Mikrotik y persiste la conexión
    ''' </summary>
    ''' <param name="comando"></param>
    ''' <returns></returns>
    Public Function SendPart(ByVal comando As String) As String
        If IsNothing(MK) Then
            MK = New SSH_Core(_IP, _Puerto, _Usuario, _Password)
        End If
        Return MK.SendPart(comando)
    End Function

    ''' <summary>
    ''' Cierra cnexión persistente a Mikrotik
    ''' </summary>
    Public Sub Close()
        If Not IsNothing(MK) Then
            MK.Close()
            MK = Nothing
        End If
    End Sub

    ''' <summary>
    ''' Obtiene lista de perfiles Mikrotik
    ''' </summary>
    ''' <returns></returns>
    Public Function ObtenerPerfiles() As List(Of String)
        Dim perfiles As New List(Of String)
        Dim result As String
        Dim ind As Integer
        Dim aux As String

        result = Send("/ip hotspot user profile print proplist=name terse where !disabled")
        If result.Substring(0, 5) = "ERROR" Then
            Return perfiles
        End If

        While result.Length > 0
            aux = obtenerCadena(result, "name=", vbCrLf)
            perfiles.Add(aux)
            ind = result.IndexOf(aux)
            If ind >= 0 Then
                result = result.Substring(ind + aux.Length)
            End If
            If result.Replace(vbCrLf, "").Trim().Length <= 1 Then
                result = ""
            End If
        End While

        Return perfiles
    End Function

    Private Function obtenerCadena(ByVal cadena As String, ByVal ini As String, ByVal fin As String) As String
        Dim _cadenaAux As String = cadena
        Dim n_ini As Integer
        Dim n_fin As Integer

        Try
            n_ini = _cadenaAux.IndexOf(ini)
            If n_ini >= 0 Then
                n_ini += ini.Length
                _cadenaAux = _cadenaAux.Substring(n_ini)
                n_fin = _cadenaAux.IndexOf(fin)
                If n_fin > 0 Then
                    Return _cadenaAux.Substring(0, n_fin)
                End If
            End If
        Catch ex As Exception
            Console.Error.WriteLine(ex.Message)
        End Try

        Return ""
    End Function

    ''' <summary>
    ''' Crea un nuevo usuaro Hostpot
    ''' </summary>
    ''' <param name="perfil">Nombre del perfil a aignar</param>
    ''' <param name="usuario">Nombre de usuario</param>
    ''' <param name="password">Password</param>
    ''' <returns></returns>
    Public Function CrearUsuarioHostpot(ByVal perfil As String, ByVal usuario As String, Optional ByVal password As String = "") As String
        If password = "" Then
            Return Send("/ip hotspot user add name=" + usuario + " profile=" + perfil)
        Else
            Return Send("/ip hotspot user add name=" + usuario + " password=" + password + " profile=" + perfil)
        End If
    End Function

End Class
