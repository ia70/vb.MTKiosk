Public Class Mikrotik
    Private _IP As String = ""
    Private _Usuario As String = ""
    Private _Password As String = ""
    Private _Puerto As Integer = -1
    Private _Conexion As Boolean = False
    Private MK As MikrotikAPI

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

    ''' <summary>
    ''' Estado de la conexión
    ''' </summary>
    ''' <returns></returns>
    Public Property Conexion As Boolean
        Get
            Return _Conexion
        End Get
        Set(value As Boolean)
            _Conexion = value
        End Set
    End Property

#End Region
    ''' <summary>
    ''' Constructor de clase Mikrotik
    ''' </summary>
    ''' <param name="ip_">Establece dirección IP del dispositivo Mikrotik</param>
    ''' <param name="usuario_">Establece Nombre de usuario</param>
    ''' <param name="password_">Establece Contraseña</param>
    Public Sub New(Optional ByVal ip_ As String = "", Optional ByVal usuario_ As String = "", Optional ByVal password_ As String = "", Optional ByVal puerto_ As Integer = 8728)

        If Not ip_ = "" And Not usuario_ = "" And Not password_ = "" Then
            _IP = ip_
            _Usuario = usuario_
            _Password = password_
            If puerto_ = -1 Or puerto_ = 0 Then
                _Puerto = 8728
            Else
                _Puerto = puerto_
            End If
            MK = New MikrotikAPI(_IP, _Usuario, _Password, _Puerto)
            If MK.Open Then
                _Conexion = True
            End If
            On Error Resume Next
            MK.Close()
        End If
    End Sub

    ''' <summary>
    ''' Abre conexion con dispositivo
    ''' </summary>
    ''' <returns>Boolean</returns>
    Public Function Open(Optional ByVal ip_ As String = "", Optional ByVal usuario_ As String = "", Optional ByVal password_ As String = "", Optional ByVal puerto_ As Integer = 8728) As Boolean
        If Not ip_ = "" And Not usuario_ = "" And Not password_ = "" Then
            _IP = ip_
            _Usuario = usuario_
            _Password = password_
        End If

        If puerto_ = -1 Or puerto_ = 0 Then
            _Puerto = 8728
        Else
            _Puerto = puerto_
        End If

        If _IP = "" Or _Usuario = "" Or _Password = "" Then
            _Conexion = False
            Return False
        Else
            MK = New MikrotikAPI(_IP, _Usuario, _Password, _Puerto)
            If MK.Open Then
                On Error Resume Next
                MK.Close()
                _Conexion = True
                Return True
            End If

        End If
        On Error Resume Next
        MK.Close()

        _Conexion = False
        Return False
    End Function

    Public Function Close() As Boolean
        If _Conexion Then
            MK.Close()
            MK = Nothing
            Return True
        End If
        Return False

    End Function

    ''' <summary>
    ''' Ingresar Usuario a Mikrotik
    ''' </summary>
    ''' <param name="Usuario">Nombre de usuario</param>
    ''' <param name="Password">Contraseña</param>
    ''' <param name="Plan">Plan</param>
    ''' <param name="Perfil">Perfil</param>
    ''' <returns>
    ''' True - Si no se generó ningun error
    ''' False - Si se generó algun error
    ''' </returns>
    Public Function Insertar(ByVal Usuario As String, ByVal Password As String, ByVal Plan As String, Perfil As String) As Boolean
        Dim Estado As Boolean

        MK = New MikrotikAPI(_IP, _Usuario, _Password, _Puerto)

        Estado = MK.Open
        If Not Estado Then
            Mensaje("No se pudo crear perfil en dispositivo!", 2)
            Return False
        End If
        Try
            MK.Send("/ip/hotspot/user/add", False)
            MK.Send("=name=" & Usuario, False)
            If Not Password = "" Then
                MK.Send("=password=" & Password, False)
            End If
            'MK.Send("=limit-uptime=" & Pl, False)
            MK.Send("=disabled=no", False)
            MK.Send("=profile=" & Perfil, True)
            ' MsgBox(Perfil.ToString)
            'MK.Send("/ip/hotspot/user/add", False)
            'MK.Close()

            Return True
        Catch ex As Exception
            _Conexion = False
            MK.Close()
            If MostrarError Then
                Mensaje(ex.ToString, 2)
            End If
            Return False
        End Try
    End Function
End Class
