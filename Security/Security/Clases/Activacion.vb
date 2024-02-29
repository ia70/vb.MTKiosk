Imports System.Management
Imports System.Net.NetworkInformation
Imports System.Security.Cryptography
Imports System.Text

Public Class Activacion
#Region "Configuración"
    'Clave de encriptacion
    Private _Password_Encriptation As String = "@.Co2_a*TxT_+XXb?1"

    'Encabezado y pie de Codigo de activación antes de Encriptar
    Private _Lic_Inicio As String = "B/*d+s"
    Private _Lic_Fin As String = "x*SD+_"

    'Encabezado y pie de Codigo de solicitud antes de Encriptar
    Private _Request_Inicio As String = "zD+-d"
    Private _Request_Fin As String = "xf5/_"

#Region "Variables Internas"
    Private FechaActual As Integer = Convert.ToInt32(Format(Today.Date, "yyyyMMdd"))
    Private TripleDes As New TripleDESCryptoServiceProvider
    '-------------------------------------------------------------------

    Private PC_Licencia As String
    Private PC_Licencia_Expiracion As Integer = 20180501
    Private PC_Licencia_Hash As String
    Private PC_Hash_Real As String

    '---- TEMPORAL LICENCIA LOAD ----
    Private Temp_Lic_Serie As String = ""
    Private Temp_Lic_HashPC As String = ""
    Private Temp_Lic_Expiracion As Integer = 0

    Private _MostrarErrores As Boolean = False
#End Region
#End Region
#Region "Funciones Públicas"

    ''' <summary>
    '''  ______________
    ''' |GetRequestCode| --> Genera código de solicitud.
    ''' </summary>
    ''' <returns>Código de solicitud encriptado</returns>
    Public Function GetRequestCode() As String
        Dim Solicitud As String
        Solicitud = Encriptar(_Request_Inicio & GetPC_Code() & _Request_Fin)
        Return Solicitud
    End Function

    ''' <summary>
    '''  ______________
    ''' |GetLicenceCode| --> Devuelve Licencia de activacion en base a un código de solicitud.
    ''' </summary>
    ''' <param name="Solicitud">Código de solicitud</param>
    ''' <returns>Licencia</returns>
    Public Function GetLicenceCode(ByVal Solicitud As String, Optional ByVal Caducidad As Integer = 20990101) As String
        Dim Licencia As String = ""
        Dim Info(3) As String

        Info = VerificarSolicitud(Solicitud)

        If Info(0) = _Request_Inicio And Info(2) = _Request_Fin Then
            Licencia = Encriptar(_Lic_Inicio & Caducidad.ToString & Info(1) & _Lic_Fin)
            Return Licencia
        Else
            Return ""
        End If
    End Function

    ''' <summary>
    '''  ________________
    ''' |Activar_Producto| --> Se encarga de realizar la activación del producto.
    ''' </summary>
    ''' <param name="Licencia"></param>
    ''' <returns></returns>
    Public Function Activar_Prodcuto(ByVal Licencia As String) As Boolean
        Dim Info(4) As String

        Info = VerificarLicencia(Licencia)

        If Not Info(0) = _Lic_Inicio Then
            Return False
        End If
        If Convert.ToInt32(Info(1)) < FechaActual Then
            Return False
        End If
        If Not Info(2) = GetPC_Code() Then
            Return False
        End If
        If Not Info(3) = _Lic_Fin Then
            Return False
        End If

        On Error Resume Next
        My.Computer.Registry.CurrentUser.DeleteSubKey("HKEY_CURRENT_USER\Software\Xcoru")
        On Error Resume Next
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Xcoru", "App", Licencia)

        If Not Len(My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Xcoru", "App", "")) > 10 Then
            Return False
        Else
            Return True
        End If

    End Function

    ''' <summary>
    '''  ___________
    ''' |IniciarAPP| --> Se encarga de iniciar verificación de licencia en el equipo
    ''' </summary>
    ''' <returns></returns>
    Public Function IniciarAPP() As Boolean
        Dim Licencia As String = ""
        Dim Info(4) As String

        Try
            Licencia = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Xcoru", "App", "")
            Info = VerificarLicencia(Licencia)

            If Info(0) = _Lic_Inicio Then
                If Convert.ToInt32(Info(1)) >= FechaActual Then
                    If Info(2) = GetPC_Code() Then
                        If Info(3) = _Lic_Fin Then
                            Return True
                        End If
                    End If
                End If
            End If

            Dim Obj As New GUI_NoActivado
            Obj.ShowDialog()

            Return _IniciarAPP
        Catch ex As Exception
            Return False
        End Try

    End Function

    ''' <summary>
    ''' Contructor de clase
    ''' </summary>
    Public Sub New()
        'Inicializando algoritmo de encriptación --------------------------------------
        TripleDes.Key = TruncateHash(_Password_Encriptation, TripleDes.KeySize \ 8)
        TripleDes.IV = TruncateHash("", TripleDes.BlockSize \ 8)
        '------------------------------------------------------------------------------
    End Sub
#End Region
#Region "Funciones Privadas"
#Region "Obtener Información PC"

    ''' <summary>
    ''' Obtiene el ID del CPU
    ''' </summary>
    ''' <returns></returns>
    Private Function GetCPUId() As String
        Dim cpuInfo As String = ""
        Dim temp As String = String.Empty
        Dim mc As New ManagementClass("Win32_Processor")
        Dim moc As ManagementObjectCollection = mc.GetInstances()

        For Each mo As ManagementObject In moc
            If Not mo.Properties("ProcessorId").Value.ToString() = "" Then
                cpuInfo = mo.Properties("ProcessorId").Value.ToString()
                Exit For
            End If
        Next

        Return cpuInfo
    End Function

    ''' <summary>
    ''' Obtiene ID de la tarjeta madre
    ''' </summary>
    ''' <returns></returns>
    Private Function GetMotherBoardID() As String
        Dim Cadena As String = ""

        Dim mbCol As ManagementObjectCollection = New ManagementClass("Win32_BaseBoard").GetInstances()
        'Enumerating the list 
        Dim mbEnum As ManagementObjectCollection.ManagementObjectEnumerator = mbCol.GetEnumerator()
        'Move the cursor to the first element of the list (And most probably the only one) 
        mbEnum.MoveNext()
        'Getting the serial number of that specific motherboard 
        Cadena = mbEnum.Current.GetHashCode

        Return Cadena
    End Function

    ''' <summary>
    ''' Obtiene Dierección MAC de la primera tarjeta de red valida
    ''' </summary>
    ''' <returns></returns>
    Private Function GetMacAddress() As String
        Dim mac As String = ""
        Dim interfaces() As NetworkInterface = NetworkInterface.GetAllNetworkInterfaces()

        For Each ni As NetworkInterface In interfaces
            If Not Len(ni.GetPhysicalAddress().ToString) < 5 Then
                mac = ni.GetPhysicalAddress().ToString
                Exit For
            End If
        Next

        Return mac
    End Function

    ''' <summary>
    ''' Obtiene Numero de serie del disco duro
    ''' </summary>
    ''' <returns></returns>
    Private Function GetVolumeSerial() As String
        Dim strDriveLetter As String = ""

        Dim mc As New ManagementClass("Win32_PhysicalMedia")
        Dim moc As ManagementObjectCollection = mc.GetInstances()
        Dim serial As String

        For Each mo As ManagementObject In moc
            serial = mo("SerialNumber")

            If Not String.IsNullOrEmpty(serial) Then
                strDriveLetter = serial
                Exit For
            End If
        Next

        Return strDriveLetter
    End Function

    ''' <summary>
    '''  __________
    ''' |GetPC_Code| --> Crea HASH único para cada PC en base a información de componentes 
    ''' </summary>
    ''' <returns></returns>
    Private Function GetPC_Code() As String
        Dim ID As String = ""
        Dim hmac As New HMACSHA1()
        Dim sb As New StringBuilder()

        Dim CPUid As String = ""
        Dim MotherBoardID As String = ""
        Dim MAC As String = ""
        Dim SerieDD As String = ""

        CPUid = GetCPUId()
        MotherBoardID = GetMotherBoardID()
        MAC = GetMacAddress()
        SerieDD = GetVolumeSerial()

        ID = CPUid & MotherBoardID & MAC & SerieDD

        hmac.Key = Encoding.ASCII.GetBytes(_Password_Encriptation)
        hmac.ComputeHash(Encoding.ASCII.GetBytes(ID))

        ' convert hash to hex string 
        For i = 0 To hmac.Hash.Length - 1
            sb.Append(hmac.Hash(i).ToString("X2"))
        Next

        Return sb.ToString()
    End Function
#End Region
#Region "Encriptación"

    ''' <summary>
    '''  _________
    ''' |Encriptar| --> Encripta una cadena.
    ''' </summary>
    ''' <param name="Cadena">Cadena a Encriptar</param>
    ''' <returns></returns>
    Private Function Encriptar(ByVal Cadena As String) As String
        Try
            ' Convert the plaintext string to a byte array.
            Dim plaintextBytes() As Byte =
                Encoding.Unicode.GetBytes(Cadena)

            ' Create the stream.
            Dim ms As New IO.MemoryStream
            ' Create the encoder to write to the stream.
            Dim encStream As New CryptoStream(ms,
                TripleDes.CreateEncryptor(),
                CryptoStreamMode.Write)

            ' Use the crypto stream to write the byte array to the stream.
            encStream.Write(plaintextBytes, 0, plaintextBytes.Length)
            encStream.FlushFinalBlock()

            ' Convert the encrypted stream to a printable string.
            Return Convert.ToBase64String(ms.ToArray)
        Catch ex As Exception
            Return ""
        End Try

    End Function

    ''' <summary>
    '''  ____________
    ''' |Desencriptar| --> Desencripta una cadena. 
    ''' </summary>
    ''' <param name="Cadena_Encriptada">Cadena a Desencriptar</param>
    ''' <returns></returns>
    Private Function Desencriptar(ByVal Cadena_Encriptada As String) As String
        Try
            ' Convert the encrypted text string to a byte array.
            Dim encryptedBytes() As Byte = Convert.FromBase64String(Cadena_Encriptada)

            ' Create the stream.
            Dim ms As New IO.MemoryStream
            ' Create the decoder to write to the stream.
            Dim decStream As New CryptoStream(ms,
                TripleDes.CreateDecryptor(),
                CryptoStreamMode.Write)

            ' Use the crypto stream to write the byte array to the stream.
            decStream.Write(encryptedBytes, 0, encryptedBytes.Length)
            decStream.FlushFinalBlock()

            ' Convert the plaintext stream to a string.
            Return Encoding.Unicode.GetString(ms.ToArray)
        Catch ex As Exception
            Return ""
        End Try
    End Function

    ''' <summary>
    ''' Algoritmo de encriptación
    ''' </summary>
    ''' <param name="key"></param>
    ''' <param name="length"></param>
    ''' <returns></returns>
    Private Function TruncateHash(ByVal key As String, ByVal length As Integer) As Byte()
        Dim sha1 As New SHA1CryptoServiceProvider

        ' Hash the key.
        Dim keyBytes() As Byte =
            Encoding.Unicode.GetBytes(key)
        Dim hash() As Byte = sha1.ComputeHash(keyBytes)

        ' Truncate or pad the hash.
        ReDim Preserve hash(length - 1)
        Return hash
    End Function

#End Region
#Region "Funciones Generales"

    ''' <summary>
    ''' Verificar solicitud
    ''' </summary>
    ''' <param name="Cadena">Código de solicitud</param>
    ''' <returns></returns>
    Private Function VerificarSolicitud(ByVal Cadena As String) As String()
        Dim Aux As String
        Dim Info(3) As String

        Try
            If Cadena.Length < 10 Then
                Return {"", "", ""}
            End If

            Aux = Desencriptar(Cadena)

            Info(0) = Aux.Substring(0, _Request_Inicio.Length)
            Info(1) = Aux.Substring(_Request_Inicio.Length, Aux.Length - (_Request_Fin.Length + _Request_Inicio.Length))
            Info(2) = Aux.Substring(Aux.Length - _Request_Fin.Length, _Request_Fin.Length)

            Return Info
        Catch ex As Exception
            Return {"", "", ""}
        End Try

    End Function

    ''' <summary>
    ''' Verificar Licencia
    ''' </summary>
    ''' <param name="Cadena">Código de Licencia</param>
    ''' <returns></returns>
    Private Function VerificarLicencia(ByVal Cadena As String) As String()
        Dim Aux As String
        Dim Info(4) As String

        Try
            If IsNothing(Cadena) OrElse Cadena.Length < 10 Then
                Return {"", "", "", ""}
            End If

            Aux = Desencriptar(Cadena)

            Info(0) = Aux.Substring(0, _Lic_Inicio.Length)
            Info(1) = Aux.Substring(_Lic_Inicio.Length, 8)
            Info(2) = Aux.Substring(_Lic_Inicio.Length + 8, Aux.Length - (_Lic_Fin.Length + _Lic_Inicio.Length + 8))
            Info(3) = Aux.Substring(Aux.Length - _Lic_Fin.Length, _Lic_Fin.Length)

            Return Info
        Catch ex As Exception
            Return {"", "", "", ""}
        End Try
    End Function


#End Region
#End Region
End Class