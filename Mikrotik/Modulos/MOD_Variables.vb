Module MOD_Variables
#Region "General"
    Public G_NombreEmpresa As String = ""
    Public G_LogotipoEmpresa As String = ""
    Public G_Impresora As String = ""
    Public G_Tecla As Integer = 13
    Public G_Modo As Integer = 1
    Public G_QR As Boolean = False
    Public G_TiempoVisualizacionFicha As Integer = 5
    Public G_Fondo As String = ""

    Public MostrarError As Boolean = False
#End Region
#Region "Base de datos"
    Public DB_Nombre As String = "ApTdxd.mdb"
    Public DB_Password As String = "xcoru12345"

#End Region
#Region "Marca"
    '************ XCORU.COM *********************
    Public MostrarContacto As Boolean
    Public Info_Pagina As String = "www.ia70.com"
    Public Info_Cel As String = "+52 9935457192"
    Public Info_Correo As String = "contacto@ia70.com"

#End Region
#Region "Mikrotik"
    'Lista de perfiles
    Public Mikrotik_Perfiles As New List(Of String)

    '(0)Id - (1)IP - (2)Usuario - (3)Password - (4)Puerto
    Public DatosMikrotik(4) As String

    '(0)No - (1)Plan_nombre - (2)Plan - (3)costo
    Public Plan(4, 3) As String
    Public Teclas(4) As Char

#End Region
#Region "Creditos"
    Public C_Credito As Integer = 0         'Credito general disponible
    Public C_NewCredito As Integer = 0      'Credito que se acaba de insertar
    Public C_Cadena_Credito As String = ""  'Almacena numero'
    Public C_ValorCredito As Integer        'Valor por cada credito
#End Region

End Module
