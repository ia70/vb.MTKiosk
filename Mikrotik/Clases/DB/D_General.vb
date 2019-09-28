Imports System.Data.OleDb

Public Class D_General
    Private Tabla As String = "info_general"
    Private DB As New DataBase

    Public Function Guardar(ByVal NombreEmpresa As String, ByVal LogoEmpresa As String, ByVal ValorCredito As Integer, ByVal NombreImpresora As String, ByVal Tecla As Integer, ByVal Modo As Integer) As Boolean
        Dim fecha As String = Format(Date.Today, "yyyyMMdd")
        Dim Respuesta As Boolean = False
        Dim Comando As New OleDbCommand()
        Dim Conexion As OleDbConnection = DB.getConexion

        Try
            Comando.CommandText = "UPDATE " & Tabla & " SET nombre_empresa='" & NombreEmpresa & "', logo_empresa='" & LogoEmpresa & "', valor_credito=" & ValorCredito & ", impresora='" & NombreImpresora & "', tecla=" & Tecla & ", modo=" & Modo & " WHERE identificador=1"
            Comando.Connection = Conexion
            Conexion.Open()
            Respuesta = Comando.ExecuteNonQuery()
            Conexion.Close()
            Return Respuesta
        Catch ex As Exception
            If MostrarError Then
                Mensaje(ex.ToString, 2)
            End If
            Return False
        End Try
    End Function

    Public Function Consultar() As String()
        Dim x As Integer = 0
        Dim Cadena(6) As String
        Dim Adaptador As New OleDbDataAdapter()
        Dim Registro As New DataTable
        Dim Conexion As OleDbConnection = DB.getConexion

        Adaptador = New OleDbDataAdapter("SELECT * FROM " & Tabla & " WHERE identificador=1", Conexion)
        Adaptador.Fill(Registro)

        'Id(0); NombreEmpresa(1); LogoEmpresa(2); ValorCredito(3); Impresora(4); Tecla(5); ModoMikrotik(6)
        On Error Resume Next
        Cadena(x) = Registro(0).Item(x)
        x += 1
        On Error Resume Next
        Cadena(x) = Registro(0).Item(x)
        x += 1
        On Error Resume Next
        Cadena(x) = Registro(0).Item(x)
        x += 1
        On Error Resume Next
        Cadena(x) = Registro(0).Item(x)
        x += 1
        On Error Resume Next
        Cadena(x) = Registro(0).Item(x)
        x += 1
        On Error Resume Next
        Cadena(x) = Registro(0).Item(x)
        x += 1
        On Error Resume Next
        Cadena(x) = Registro(0).Item(x)

        Return Cadena
    End Function
End Class
