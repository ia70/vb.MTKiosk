Imports System.IO
Imports System.Net.Sockets

Public Class MikrotikAPI2
    Private IP As String = ""                   'Dirección IP del Mikrotik
    Private Puerto As Integer = 0               'Puerto a la escucha
    Private Usuario As String = ""              'Nombre de usuario
    Private Password As String = ""             'Contraseña de usuario
    Private EstadoConexion As Boolean = False   'Estado de la conexiòn True -> Abierta

    Dim TCP_Stream As Stream
    Dim TCP_Con As New TcpClient

    Public Property Estado As Boolean
        Get
            Return EstadoConexion
        End Get
        Set(value As Boolean)
            EstadoConexion = value
        End Set
    End Property



    ''' <summary>
    ''' Establece parámetros conexión con el dispositivo Mikrotik
    ''' </summary>
    ''' <param name="_ip">Dirección IP</param>
    ''' <param name="_usuario">Nombre de Usuario</param>
    ''' <param name="_pass">Contraseña</param>
    ''' <param name="_puerto">Puerto</param>
    Public Sub New(Optional ByVal _ip As String = "", Optional ByVal _usuario As String = "", Optional ByVal _pass As String = "", Optional ByVal _puerto As Integer = 8728)
        If Not _ip = "" And Not _usuario = "" And Not _pass = "" Then
            IP = _ip
            Usuario = _usuario
            Password = _pass
        End If

        If _puerto = -1 Or _puerto = 0 Then
            Puerto = 8728
        Else
            Puerto = _puerto
        End If
    End Sub

    ''' <summary>
    ''' Abre conexión con el dispositivo Mikrotik
    ''' </summary>
    ''' <param name="_ip">Dirección IP</param>
    ''' <param name="_usuario">Nombre de Usuario</param>
    ''' <param name="_pass">Contraseña</param>
    ''' <param name="_puerto">Puerto</param>
    ''' <returns>
    ''' True - Si se realizo la conexión correctamente
    ''' False - Si se generó algun error
    ''' </returns>
    Public Function Open(Optional ByVal _ip As String = "", Optional ByVal _usuario As String = "", Optional ByVal _pass As String = "", Optional ByVal _puerto As Integer = 8728) As Boolean
        If Not _ip = "" And Not _usuario = "" And Not _pass = "" Then
            IP = _ip
            Usuario = _usuario
            Password = _pass
        ElseIf IP = "" Or Usuario = "" Or Password = "" Then
            Return False
        End If

        If _puerto = -1 Or _puerto = 0 Then
            Puerto = 8728
        ElseIf Puerto = 0 Then
            Puerto = _puerto
        End If

        Try
            'Dim ips = Net.Dns.GetHostEntry(IP)
            TCP_Con.Connect(IP, Puerto)
            TCP_Stream = TCP_Con.GetStream()

            Return Login(Usuario, Password)
        Catch ex As Exception
            If MostrarError Then
                Mensaje(ex.ToString, 2)
            End If
            Return False
        End Try

    End Function

    Public Sub Close()
        Try

            TCP_Stream.Close()
            TCP_Con.Close()
        Catch ex As Exception
            If MostrarError Then
                Mensaje(ex.ToString, 2)
            End If
        End Try

    End Sub



    Public Sub New(ByVal ipOrDns As String, Optional ByVal port As Integer = -1)
        Dim ips = Net.Dns.GetHostEntry(ipOrDns)

        TCP_Con.Connect(ips.AddressList(0), If(port = -1, 8728, port))
        TCP_Stream = TCP_Con.GetStream()
    End Sub

    Public Sub New(ByVal endP As System.Net.IPEndPoint)
        TCP_Con.Connect(endP)
        TCP_Stream = TCP_Con.GetStream()
    End Sub

    Public Function Login(ByVal user As String, ByVal pass As String) As Boolean
        Send("/login", True)
        Dim hash = Read()(0).Split(New String() {"ret="}, StringSplitOptions.None)(1)
        Send("/login")
        Send("=name=" + user)
        Send("=response=00" + EncodePassword(pass, hash), True)
        Dim res = Read()

        If (res(0) = "!done") Then
            Return True
        Else
            Return False
        End If
    End Function

    Function EncodePassword(ByVal pass As String, ByVal challange As String) As String
        Dim hash_byte(challange.Length / 2 - 1) As Byte
        For i = 0 To challange.Length - 2 Step 2
            hash_byte(i / 2) = Byte.Parse(challange.Substring(i, 2), Globalization.NumberStyles.HexNumber)
        Next
        Dim response(pass.Length + hash_byte.Length) As Byte
        response(0) = 0
        Text.Encoding.ASCII.GetBytes(pass.ToCharArray()).CopyTo(response, 1)
        hash_byte.CopyTo(response, 1 + pass.Length)


        Dim md5 = New System.Security.Cryptography.MD5CryptoServiceProvider()

        Dim hash = md5.ComputeHash(response)

        Dim hashStr As New Text.StringBuilder()

        For Each h In hash
            hashStr.Append(h.ToString("x2"))
        Next
        Return hashStr.ToString()

    End Function

    Public Sub Send(ByVal command As String, Optional ByVal EndSentence As Boolean = False)
        Dim bytes = System.Text.Encoding.ASCII.GetBytes(command.ToCharArray())
        Dim size = EncodeLength(bytes.Length)

        TCP_Stream.Write(size, 0, size.Length)
        TCP_Stream.Write(bytes, 0, bytes.Length)
        If EndSentence Then TCP_Stream.WriteByte(0)
    End Sub

    Public Function Read() As List(Of String)
        Dim output As New List(Of String)
        Dim o = ""
        Dim tmp(4) As Byte
        Dim count As Long

        While True
            tmp(3) = TCP_Stream.ReadByte()
            Select Case tmp(3)
                Case 0
                    output.Add(o)
                    If o.Substring(0, 5) = "!done" Then
                        Exit While
                    Else
                        o = ""
                        Continue While
                    End If
                Case Is < &H80
                    count = tmp(3)
                Case Is < &HC0
                    count = BitConverter.ToInt32(New Byte() {TCP_Stream.ReadByte(), tmp(3), 0, 0}, 0) ^ &H8000
                Case Is < &HE0
                    tmp(2) = TCP_Stream.ReadByte()
                    count = BitConverter.ToInt32(New Byte() {TCP_Stream.ReadByte(), tmp(2), tmp(3), 0}, 0) ^ &HC00000
                Case Is < &HF0
                    tmp(2) = TCP_Stream.ReadByte()
                    tmp(1) = TCP_Stream.ReadByte()
                    count = BitConverter.ToInt32(New Byte() {TCP_Stream.ReadByte(), tmp(1), tmp(2), tmp(3)}, 0) ^ &HE0000000
                Case &HF0
                    tmp(3) = TCP_Stream.ReadByte()
                    tmp(2) = TCP_Stream.ReadByte()
                    tmp(1) = TCP_Stream.ReadByte()
                    tmp(0) = TCP_Stream.ReadByte()
                    count = BitConverter.ToInt32(tmp, 0)
                Case Else
                    Exit While   'err
            End Select

            For i = 0 To count - 1
                o += ChrW(TCP_Stream.ReadByte())
            Next
        End While
        Return output
    End Function

    Function EncodeLength(ByVal l As Integer) As Byte()
        If l < &H80 Then
            Dim tmp = BitConverter.GetBytes(l)
            Return New Byte() {tmp(0)}
        ElseIf l < &H4000 Then
            Dim tmp = BitConverter.GetBytes(l Or &H8000)
            Return New Byte() {tmp(1), tmp(0)}
        ElseIf l < &H200000 Then
            Dim tmp = BitConverter.GetBytes(l Or &HC00000)
            Return New Byte() {tmp(2), tmp(1), tmp(0)}
        ElseIf l < &H10000000 Then
            Dim tmp = BitConverter.GetBytes(l Or &HE0000000)
            Return New Byte() {tmp(3), tmp(2), tmp(1), tmp(0)}
        Else
            Dim tmp = BitConverter.GetBytes(l)
            Return New Byte() {&HF0, tmp(3), tmp(2), tmp(1), tmp(0)}
        End If
    End Function

End Class