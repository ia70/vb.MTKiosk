Imports System.Management
Imports System.Net.NetworkInformation
Imports System.Security.Cryptography
Imports System.Text

Public Class Activacion_XCORU

#Region "Varibles Generales"

    '---- MOSTRAR ERRORES ----------------------------------------------
    Public MOSTRAR_ERROR As Boolean = False

    '///////////////////////////////////////////////////////////////////
    Private FechaActual As Integer = 20180501

    '-------------------------------------------------------------------
    'Private _Lic_Serie As String = ""
    'Private _Lic_HashPC As String = ""
    Private _Lic_Expiracion As Integer = 20180501

    'Clave de encriptacion
    Private _Password_Encriptation As String = "@.Co2_a*TxT_+XXb?1"

    'Encabezado y pie de Codigo de activación antes de Encriptar
    Private _Lic_Inicio As String = "B/*d+s"
    Private _Lic_Fin As String = "x*SD+_"

    'Encabezado y pie de Codigo de solicitud antes de Encriptar
    Private _Request_Inicio As String = "zD+-d"
    Private _Request_Fin As String = "xf5/_"

#End Region
#Region "Variables secundarias"

    '/////->  DB Licencia  -///////////////////////////////////////////////////
    Private _DB_LicenciaEncode As String = ""

    '/////->  PC Informacion -/////////////////////////////////////////////////
    Private Reg_LicenciaEncode As String
    Private Reg_LicenciaDecode As String
    Private Reg_LicenciaHash As String
    Private Reg_LicenciaExpiracion As Integer

    Private PC_Hash As String

    '---- TEMPORAL LICENCIA LOAD ----
    'Private Temp_Lic_Serie As String = ""
    'Private Temp_Lic_HashPC As String = ""
    'Private Temp_Lic_Expiracion As Integer = 0

    '--- GET LICENCE CODE ------------
    Private SolicitudDecode As String

#End Region
#Region "Propiedades"
    Public Property DB_LicenciaEncode As String
        Get
            Return _DB_LicenciaEncode
        End Get
        Set(value As String)
            _DB_LicenciaEncode = value
        End Set
    End Property


#End Region
#Region "Funciones Publicas"

    ''' <summary>
    '''  ______________
    ''' |GetRequestCode| --> Genera código de solicitud.
    ''' </summary>
    ''' <returns>Código de solicitud encriptado</returns>
    Public Function GetRequestCode() As String
        Dim Codigo As String
        Dim Cadena As String = ""

        Cadena = _Request_Inicio & GetPC_Code() & _Request_Fin
        Codigo = Encriptar(Cadena)

        Return Codigo
    End Function

    ''' <summary>
    '''  ______________
    ''' |GetLicenceCode| --> Devuelve Licencia de activacion en base a un código de solicitud.
    ''' </summary>
    ''' <param name="Solicitud">Código de solicitud</param>
    ''' <returns>Licencia</returns>
    Public Function GetLicenceCode(ByVal Solicitud As String, Optional ByVal Caducidad As Integer = 20990101) As String
        Dim _Licencia As String = ""

        If Sintaxis_RequestCode(Solicitud) Then
            _Licencia = _Lic_Inicio & Caducidad & SolicitudDecode & _Lic_Fin
            SolicitudDecode = Encriptar(_Licencia)
        End If

        Return SolicitudDecode
    End Function

    ''' <summary>
    '''  ___________________
    ''' |Sintaxis_RequesCode| --> Verifica si la sintaxis del REQUESTCODE es correcta.
    ''' </summary>
    ''' <param name="RequestCode"></param>
    ''' <returns></returns>
    Public Function Sintaxis_RequestCode(ByVal RequestCode As String) As Boolean
        Dim Aux As String
        Dim Aux2 As String
        Try
            SolicitudDecode = Desencriptar(RequestCode)

            If SolicitudDecode.Length < (_Request_Inicio.Length + _Request_Fin.Length) Then
                Return False
            End If

            Aux2 = SolicitudDecode.Substring(_Request_Inicio.Length, SolicitudDecode.Length - (_Request_Inicio.Length + _Request_Fin.Length))

            Aux = SolicitudDecode.Substring(0, _Request_Inicio.Length)
            If Not Aux = _Request_Inicio Then
                Return False
            End If

            Aux = SolicitudDecode.Substring(SolicitudDecode.Length - _Request_Fin.Length, _Request_Fin.Length)
            If Not Aux = _Request_Fin Then
                Return False
            End If

            SolicitudDecode = Aux2

            Return True
        Catch ex As Exception
            If MOSTRAR_ERROR Then
                MSG(ex.ToString + "///// ///// ///// /////" + ex.StackTrace, 2, "Sintaxis_RequestCode")
            End If
            Return False
        End Try
    End Function

    ''' <summary>
    '''  ________________
    ''' |Activar_Producto| --> Se encarga de realizar la activación del producto.
    ''' </summary>
    ''' <param name="Licencia"></param>
    ''' <returns></returns>
    Public Function Activar_Prodcuto(ByVal Licencia As String) As Boolean
        Try
            DesifrarLicencia(Licencia)
            _DB_LicenciaEncode = Licencia
            Reg_LicenciaEncode = Licencia

            If Validar_Licencia() Then
                DelLicencia_Registro()
                '_Lic_Serie = Licencia
                SetLicencia_Registro(Licencia)
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            If MOSTRAR_ERROR Then
                MSG(ex.ToString + "///// ///// ///// /////" + ex.StackTrace, 2, "Activar_Prodcuto")
            End If
            Return False
        End Try

    End Function

    ''' <summary>
    '''  ________
    ''' |Vigencia| --> Verifia si la licencia está vigente.
    ''' </summary>
    ''' <returns>True - si Vigente </returns>
    Public Function Vigencia() As Boolean
        Try
            If FechaActual <= Reg_LicenciaExpiracion Then
                Return True
            End If
            Return False
        Catch ex As Exception
            If MOSTRAR_ERROR Then
                MSG(ex.ToString + "///// ///// ///// /////" + ex.StackTrace, 2, "Vigencia")
            End If
            Return False
        End Try
    End Function

    ''' <summary>
    '''  _________________
    ''' |Validar_Licencia| --> Verifica si la sintaxis de la LICENCIA es valida.
    ''' </summary>
    ''' <returns></returns>
    Public Function Validar_Licencia() As Boolean
        Dim Aux As String

        Try
            If Reg_LicenciaEncode.Length > 10 And Not Reg_LicenciaEncode = _DB_LicenciaEncode Then
                MSG("Error de Licencia!", 2)
                Return False
            ElseIf Reg_LicenciaEncode.Length < 10 Then
                Return False
            End If


            Aux = Reg_LicenciaDecode.Substring(0, _Lic_Inicio.Length)
            If Not Aux = _Lic_Inicio Then
                MSG("Licencia No válida!", 2)
                Return False
            End If

            Aux = Reg_LicenciaDecode.Substring(Reg_LicenciaDecode.Length - _Lic_Fin.Length, _Lic_Fin.Length)
            If Not Aux = _Lic_Fin Then
                MSG("Licencia No válida!", 2)
                Return False
            End If

            If Not Reg_LicenciaHash = PC_Hash Then
                MSG("Licencia No válida!", 2)
                Return False
            End If

            If Not Vigencia() Then
                MSG("Licencia Caducada! - Adquiera una nueva licencia.", 2)
                Return False
            End If

            Return True
        Catch ex As Exception
            If MOSTRAR_ERROR Then
                MSG(ex.ToString + "///// ///// ///// /////" + ex.StackTrace, 2, "Validar_Licencia")
            End If
            Return False
        End Try
    End Function


    ''' <summary>
    '''  ___________
    ''' |Inicializar| --> Especifica si debe o no iniciarse el Producto.
    ''' </summary>
    ''' <param name="Licencia">Licencia de la base de datos</param>
    ''' <returns>True - Si la activación es correcta</returns>
    Public Function Inicializar(Optional ByVal Licencia As String = "") As Boolean
        Try
            If Not Licencia = "" Then
                _DB_LicenciaEncode = Licencia
            End If

            PC_Informacion()

            Return Validar_Licencia()
        Catch ex As Exception
            If MOSTRAR_ERROR Then
                MSG(ex.ToString + "///// ///// ///// /////" + ex.StackTrace, 2, "Inicializar")
            End If
            Return False
        End Try
    End Function

#End Region
#Region "Activación"

    ''' <summary>
    '''  ___________________
    ''' |PC_Informacion| --> Se encarga de cargar los datos de la PC.
    ''' </summary>
    Private Sub PC_Informacion()
        Try
            Reg_LicenciaEncode = GetLicencia_Registro()
            If Reg_LicenciaEncode.Length > 10 Then
                DesifrarLicencia(Reg_LicenciaEncode)
            End If
        Catch ex As Exception
            If MOSTRAR_ERROR Then
                MSG(ex.ToString + "///// ///// ///// /////" + ex.StackTrace, 2, "PC_Informacion")
            End If
        End Try

    End Sub

    ''' <summary>
    '''  ________________
    ''' |DesifrarLicencia| --> Desifra información de la licencia.
    ''' </summary>
    ''' <param name="Licencia"></param>
    Private Sub DesifrarLicencia(ByVal Licencia As String)
        Dim Cadena As String = ""
        Dim Inicio As Integer = 0


        If Licencia.Length > 20 Then
            Try
                Cadena = Desencriptar(Licencia)
            Catch ex As Exception
                If MOSTRAR_ERROR Then
                    MSG(ex.ToString + "///// ///// ///// /////" + ex.StackTrace, 2, "DesifrarLicencia")
                End If
            End Try
            'If Sintaxis_Licencia(Licencia) Then
            Inicio = _Lic_Inicio.Length

            Try
                PC_Hash = GetPC_Code()
            Catch ex As Exception
                If MOSTRAR_ERROR Then
                    MSG(ex.ToString + "///// ///// ///// /////" + ex.StackTrace, 2, "DesifrarLicencia")
                End If
            End Try

            Try
                Reg_LicenciaDecode = Cadena
                Reg_LicenciaExpiracion = Convert.ToInt32(Cadena.Substring(Inicio, 8))
                Inicio += 8
            Catch ex As Exception
                If MOSTRAR_ERROR Then
                    MSG(ex.ToString + "///// ///// ///// /////" + ex.StackTrace, 2, "DesifrarLicencia")
                End If
            End Try

            Try
                Reg_LicenciaHash = Cadena.Substring(Inicio, (Cadena.Length - (Inicio + _Lic_Fin.Length)))
            Catch ex As Exception
                If MOSTRAR_ERROR Then
                    MSG(ex.ToString + "///// ///// ///// /////" + ex.StackTrace, 2, "DesifrarLicencia")
                End If
            End Try
            'End If
        End If

    End Sub

    ''' <summary>
    '''  _________________
    ''' |DesifrarSolicitud| --> Desifra información del código de solicitud.
    ''' </summary>
    ''' <param name="Solicitud"></param>
    ''' <returns></returns>
    Private Function DesifrarSolicitud(ByVal Solicitud As String) As String
        Try
            Dim Cadena As String = Desencriptar(Solicitud)
            Dim HashPC As String = ""
            If Sintaxis_RequestCode(Solicitud) Then
                HashPC = Cadena.Substring(_Request_Inicio.Length, (Cadena.Length - (_Request_Inicio.Length + _Request_Fin.Length)))
            End If
            Return HashPC
        Catch ex As Exception
            If MOSTRAR_ERROR Then
                MSG(ex.ToString + "///// ///// ///// /////" + ex.StackTrace, 2, "DesifrarSolicitud")
            End If
            Return ""
        End Try
    End Function
#End Region
#Region "PC_Activacion"

    Private Function GetCPUId() As String
        Try
            Dim cpuInfo As String = String.Empty
            Dim temp As String = String.Empty
            Dim mc As New ManagementClass("Win32_Processor")
            Dim moc As ManagementObjectCollection = mc.GetInstances()

            For Each mo As ManagementObject In moc
                If cpuInfo = String.Empty Then
                    'only return cpuInfo from first CPU 
                    cpuInfo = mo.Properties("ProcessorId").Value.ToString()
                End If
            Next

            Return cpuInfo
        Catch ex As Exception
            If MOSTRAR_ERROR Then
                MSG(ex.ToString + "///// ///// ///// /////" + ex.StackTrace, 2, "GetCPUId")
            End If
            Return ""
        End Try
    End Function
    Private Function GetMotherBoardID() As String
        Try
            Dim Cadena As String = ""

            Dim mbCol As ManagementObjectCollection = New ManagementClass("Win32_BaseBoard").GetInstances()
            'Enumerating the list 
            Dim mbEnum As ManagementObjectCollection.ManagementObjectEnumerator = mbCol.GetEnumerator()
            'Move the cursor to the first element of the list (And most probably the only one) 
            mbEnum.MoveNext()
            'Getting the serial number of that specific motherboard 
            Cadena = mbEnum.Current.GetHashCode

            Return Cadena
        Catch ex As Exception
            If MOSTRAR_ERROR Then
                MSG(ex.ToString + "///// ///// ///// /////" + ex.StackTrace, 2, "GetMotherBoardID")
            End If
            Return ""
        End Try
    End Function
    Private Function GetMacAddress() As String
        Try
            Dim macs As String = ""
            Dim pa As PhysicalAddress
            '// get network interfaces physical addresses 
            Dim interfaces() As NetworkInterface = NetworkInterface.GetAllNetworkInterfaces()
            For Each ni As NetworkInterface In interfaces

                pa = ni.GetPhysicalAddress()
                macs += pa.ToString()
            Next
            Return macs
        Catch ex As Exception
            If MOSTRAR_ERROR Then
                MSG(ex.ToString + "///// ///// ///// /////" + ex.StackTrace, 2, "GetMacAddress")
            End If
            Return ""
        End Try
    End Function
    Private Function GetVolumeSerial() As String
        Try
            Dim strDriveLetter As String = ""
            Dim mc As New ManagementClass("Win32_PhysicalMedia")
            Dim moc As ManagementObjectCollection = mc.GetInstances()
            For Each mo As ManagementObject In moc

                Dim serial As String = mo("SerialNumber")
                If Not String.IsNullOrEmpty(serial) Then
                    strDriveLetter = serial

                    Return strDriveLetter
                End If

            Next

            Return strDriveLetter
        Catch ex As Exception
            If MOSTRAR_ERROR Then
                MSG(ex.ToString + "///// ///// ///// /////" + ex.StackTrace, 2, "GetVolumeSerial")
            End If
        Return ""
        End Try
    End Function

    ''' <summary>
    '''  __________
    ''' |GetPC_Code| --> Crea HASH único para cada PC en base a información de componentes 
    ''' </summary>
    ''' <returns></returns>
    Private Function GetPC_Code() As String
        Dim ID As String
        Dim hmac As New HMACSHA1()

        Dim mother, dd As String

        'cpu = GetCPUId()
        Try
            hmac.Key = Encoding.ASCII.GetBytes(_Password_Encriptation)
            mother = GetMotherBoardID()
        Catch ex As Exception
            mother = ""
            If MOSTRAR_ERROR Then
                MSG(ex.ToString + "///// ///// ///// /////" + ex.StackTrace, 2, "GetPC_Code-01")
            End If
        End Try
        'mac = GetMacAddress()

        Try
            dd = GetVolumeSerial()
        Catch ex As Exception
            dd = ""
            If MOSTRAR_ERROR Then
                MSG(ex.ToString + "///// ///// ///// /////" + ex.StackTrace, 2, "GetPC_Code-02")
            End If
        End Try
        ID = mother + dd

        Try
            hmac.ComputeHash(Encoding.ASCII.GetBytes(ID))
        Catch ex As Exception
            ID = "Z98XC8CV787ZXC0ZX0C99C98XZC98"
            If MOSTRAR_ERROR Then
                MSG(ex.ToString + "///// ///// ///// /////" + ex.StackTrace, 2, "GetPC_Code-03")
            End If
        End Try
        ' convert hash to hex string 
        Dim sb As New StringBuilder()

        Try
            For i = 0 To hmac.Hash.Length - 1
                sb.Append(hmac.Hash(i).ToString("X2"))
            Next

            Return sb.ToString()
        Catch ex As Exception
            If MOSTRAR_ERROR Then
                MSG(ex.ToString + "///// ///// ///// /////" + ex.StackTrace, 2, "GetPC_Code-04")
            End If
            Return ""
        End Try

    End Function

    ''' <summary>
    '''  ___
    ''' |MSG| --> Muestra mensaje en pantalla.
    ''' </summary>
    ''' <param name="Mensaje">Mensaje a Mostrar</param>
    ''' <param name="Icono">0Info -1Exclam -2Crit -3Quest</param>
    Private Sub MSG(ByVal Mensaje As String, Optional ByVal Icono As Integer = 0, Optional ByVal Titulo As String = " ")
        Select Case Icono
            Case 0
                MsgBox(Mensaje, vbInformation, "Activación -> " & Titulo)
            Case 1
                MsgBox(Mensaje, vbExclamation, "Activación -> " & Titulo)
            Case 2
                MsgBox(Mensaje, vbCritical, "Activación -> " & Titulo)
            Case Else
                MsgBox(Mensaje, vbQuestion, "Activación -> " & Titulo)
        End Select
    End Sub

#End Region
#Region "Criptografia"
    Private TripleDes As New TripleDESCryptoServiceProvider

    Public Sub New(Optional ByVal Licencia As String = "")
        Try
            TripleDes.Key = TruncateHash(_Password_Encriptation, TripleDes.KeySize \ 8)
            TripleDes.IV = TruncateHash("", TripleDes.BlockSize \ 8)
            FechaActual = Val(Format(Today.Date, "yyyyMMdd"))

            If Not Licencia = "" Then
                Inicializar(Licencia)
            End If
        Catch ex As Exception
            If MOSTRAR_ERROR Then
                MSG(ex.ToString + "///// ///// ///// /////" + ex.StackTrace, 2, "New")
            End If
        End Try
    End Sub
    Private Function TruncateHash(ByVal key As String, ByVal length As Integer) As Byte()
        Dim sha1 As New SHA1CryptoServiceProvider
        Try
            ' Hash the key.
            Dim keyBytes() As Byte =
            Encoding.Unicode.GetBytes(key)
            Dim hash() As Byte = sha1.ComputeHash(keyBytes)

            ' Truncate or pad the hash.
            ReDim Preserve hash(length - 1)
            Return hash
        Catch ex As Exception
            If MOSTRAR_ERROR Then
                MSG(ex.ToString + "///// ///// ///// /////" + ex.StackTrace, 2, "TruncateHash")
            End If
            Return Nothing
        End Try
    End Function

    ''' <summary>
    '''  _________
    ''' |Encriptar| --> Encripta una cadena.
    ''' </summary>
    ''' <param name="Cadena"></param>
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
            If MOSTRAR_ERROR Then
                MSG(ex.ToString + "///// ///// ///// /////" + ex.StackTrace, 2, "Encriptar")
            End If
            Return ""
        End Try

    End Function

    ''' <summary>
    '''  ____________
    ''' |Desencriptar| --> Desencripta una cadena. 
    ''' </summary>
    ''' <param name="Cadena_Encriptada"></param>
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
            If MOSTRAR_ERROR Then
                MSG(ex.ToString + "///// ///// ///// /////" + ex.StackTrace, 2, "Desencriptar")
            End If
            Return ""
        End Try
    End Function
#End Region
#Region "IO Activación"

    ''' <summary>
    '''  ____________________
    ''' |GetLicencia_Registro| --> Obtiene licencia del registro de Windows.
    ''' </summary>
    ''' <returns>Licencia</returns>
    Private Function GetLicencia_Registro() As String
        Try
            Return My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Xcoru", "App", "")
        Catch ex As Exception
            If MOSTRAR_ERROR Then
                MSG(ex.ToString + "///// ///// ///// /////" + ex.StackTrace, 2, "GetLicencia_Registro")
            End If
            Return ""
        End Try
    End Function

    ''' <summary>
    '''  ____________________
    ''' |SetLicencia_Registro| --> Establece o guarda licencia en el registro de Windows.
    ''' </summary>
    ''' <param name="Licencia"></param>
    Private Sub SetLicencia_Registro(ByVal Licencia As String)
        Try
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Xcoru", "App", Licencia)
        Catch ex As Exception
            If MOSTRAR_ERROR Then
                MSG(ex.ToString + "///// ///// ///// /////" + ex.StackTrace, 2, "SetLicencia_Registro")
            End If
        End Try
    End Sub

    ''' <summary>
    '''  ____________________
    ''' |DelLicencia_Registro| --> Elimina Licencia del registro de Windows.
    ''' </summary>
    Private Sub DelLicencia_Registro()
        Try
            My.Computer.Registry.CurrentUser.DeleteSubKey("HKEY_CURRENT_USER\Software\Xcoru")
        Catch ex As Exception
            If MOSTRAR_ERROR Then
                MSG(ex.ToString + "///// ///// ///// /////" + ex.StackTrace, 2, "DelLicencia_Registro")
            End If
        End Try
    End Sub
#End Region
End Class