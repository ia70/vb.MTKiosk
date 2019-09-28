Imports System.Data.OleDb

''' <summary>
''' Clase de conexión a a Base de Datos Access 2010 .mdb
''' </summary>
Public Class DataBase
    Private Conexion As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & DB_Nombre & ";Jet OLEDB:Database Password=" & DB_Password & ";")
    Private Comando As New OleDbCommand()

    ''' <summary>
    ''' Verifica conexíon con la Base de Datos
    ''' </summary>
    ''' <returns>
    ''' True - Si conexión correcta
    ''' False - Si conexión incorrecta
    ''' </returns>
    Public Function Estado() As Boolean
        Try
            Conexion.Open()
            Conexion.Close()
            Return True
        Catch ex As Exception
            If MostrarError Then
                Mensaje(ex.ToString, 2)
            End If
            Return False
        End Try
    End Function

    Public Function getConexion() As OleDbConnection
        Return Conexion
    End Function


    ''' <summary>
    ''' Inserta registro al historial en la Base de Datos
    ''' </summary>
    ''' <param name="usuario_">Nombre de usuario</param>
    ''' <param name="password_">Contraseña</param>
    ''' <param name="plan_">Número de plan</param>
    ''' <returns></returns>
    Public Function HistorialInsertar(ByVal usuario_ As String, ByVal password_ As String, ByVal plan_ As String) As Boolean
        Dim fecha As String = Format(Date.Today, "yyyyMMdd")
        Dim Respuesta As Boolean = False
        Try
            Comando.CommandText = "INSERT INTO historial VALUES(" & Indice() & ", '" & usuario_ & "', '" & password_ & "', '" & plan_ & "', " & fecha & ")"
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

    ''' <summary>
    ''' Carga información del disposito Mikrotik
    ''' </summary>
    ''' <returns>Cadena()</returns>
    Public Function CargarDispositivo() As String()
        Dim x As Integer = 0
        Dim Cadena(4) As String
        Dim Adaptador As New OleDbDataAdapter()
        Dim Registro As New DataTable

        Try
            Adaptador = New OleDbDataAdapter("SELECT * FROM mikrotik WHERE dispositivo=1", Conexion)
            Adaptador.Fill(Registro)

            'dispositivo(0); ip(1); usuario(2); password(3); puerto(4)
            Cadena(x) = Registro(0).Item(x)
            x += 1
            Cadena(x) = Registro(0).Item(x)
            x += 1
            Cadena(x) = Registro(0).Item(x)
            x += 1
            Cadena(x) = Registro(0).Item(x)
            x += 1
            Cadena(x) = Registro(0).Item(x)
            Conexion.Close()
            Return Cadena
        Catch ex As Exception
            Conexion.Close()
            If MostrarError Then
                Mensaje(ex.ToString, 2)
            End If
        End Try
        Return Cadena
    End Function

    ''' <summary>
    ''' Carga los planes
    ''' </summary>
    ''' <returns>Cadena(,)</returns>
    Public Function CargarPlanes() As String(,)

        Dim x, y As Integer
        Dim Cadena(4, 3) As String
        Dim Adaptador As New OleDbDataAdapter()
        Dim Registro As New DataTable

        x = 0
        y = 0
        Adaptador = New OleDbDataAdapter("SELECT * FROM planes ORDER BY planid ASC", Conexion)
        Adaptador.Fill(Registro)

        Try
            'planid(int); nombre(string); plan(string); costo(moneda) \creditos
            Cadena(y, x) = Registro(y).Item(x)
            x += 1
            Cadena(y, x) = Registro(y).Item(x)
            x += 1
            Cadena(y, x) = Registro(y).Item(x)
            x += 1
            Cadena(y, x) = Registro(y).Item(x)

            y += 1
            x = 0

            Cadena(y, x) = Registro(y).Item(x)
            x += 1
            Cadena(y, x) = Registro(y).Item(x)
            x += 1
            Cadena(y, x) = Registro(y).Item(x)
            x += 1
            Cadena(y, x) = Registro(y).Item(x)

            y += 1
            x = 0

            Cadena(y, x) = Registro(y).Item(x)
            x += 1
            Cadena(y, x) = Registro(y).Item(x)
            x += 1
            Cadena(y, x) = Registro(y).Item(x)
            x += 1
            Cadena(y, x) = Registro(y).Item(x)

            y += 1
            x = 0

            Cadena(y, x) = Registro(y).Item(x)
            x += 1
            Cadena(y, x) = Registro(y).Item(x)
            x += 1
            Cadena(y, x) = Registro(y).Item(x)
            x += 1
            Cadena(y, x) = Registro(y).Item(x)
            Conexion.Close()
            Return Cadena


        Catch ex As Exception
            Conexion.Close()
            If MostrarError Then
                Mensaje(ex.ToString, 2)
            End If
            Return Cadena
        End Try
    End Function

    ''' <summary>
    ''' Edita Configuración de dispositivo
    ''' </summary>
    ''' <param name="ip_">IP del dispositivo Mikrotik</param>
    ''' <param name="usuario_">Nombre de usuario</param>
    ''' <param name="pass_">Contraseña</param>
    ''' <param name="puerto_">Puerto</param>
    ''' <returns></returns>
    Public Function EditarDispositivo(ByVal ip_ As String, ByVal usuario_ As String, ByVal pass_ As String, Optional ByVal puerto_ As Integer = 8728) As Boolean
        Dim Respuesta As Boolean = False

        Try
            Comando.CommandText = "UPDATE mikrotik SET ip='" & ip_ & "', usuario='" & usuario_ & "', pass='" & pass_ & "', puerto=" & puerto_ & " WHERE dispositivo=1"
            Comando.Connection = Conexion
            Conexion.Open()
            Respuesta = Comando.ExecuteNonQuery()
            Conexion.Close()
            Return Respuesta
        Catch ex As Exception
            Conexion.Close()
            If MostrarError Then
                Mensaje(ex.ToString, 2)
            End If
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Modifica un plan
    ''' </summary>
    ''' <param name="No">Número de plan a modificar</param>
    ''' <returns></returns>
    Public Function EditarPlan(ByVal No As Integer, ByVal _Nombre As String, ByVal _Plan As String, ByVal _Costo As Integer) As Boolean
        Dim Respuesta As Boolean = False
        Try
            Comando.CommandText = "UPDATE planes SET nombre='" & _Nombre & "', plan='" & _Plan & "', costo=" & _Costo & " WHERE planid=" & No
            Comando.Connection = Conexion
            Conexion.Open()
            Respuesta = Comando.ExecuteNonQuery()
            Conexion.Close()
            Return Respuesta
        Catch ex As Exception
            Conexion.Close()
            If MostrarError Then
                Mensaje(ex.ToString, 2)
            End If
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Verifica si existe un ususrio
    ''' </summary>
    ''' <param name="usuario_">Nombre de usuario a verificar</param>
    ''' <returns>
    ''' True - Si existe
    ''' False - Si no existe
    ''' </returns>
    Public Function VerificarUsuario(ByVal usuario_ As String) As Boolean
        Dim Valores As Integer

        Dim Adaptador As New OleDbDataAdapter()
        Dim Registro As New DataTable

        Try
            Adaptador = New OleDbDataAdapter("Select * FROM historial WHERE usuario ='" & usuario_ & "'", Conexion)
            Adaptador.Fill(Registro)

            Valores = Registro.Rows.Count
            If Valores > 0 Then
                Conexion.Close()
                Return True
            Else
                Conexion.Close()
                Return False
            End If
        Catch ex As Exception
            Conexion.Close()

            If MostrarError Then
                Mensaje(ex.ToString, 2)
            End If
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Elimina los registros de mas de un determinado tiempo de antiguedad
    ''' </summary>
    ''' <param name="Meses">Antiguedad de registros</param>
    ''' <returns>
    ''' True - Si elimino algun registro
    ''' False - Si no eliminó ningun registro
    ''' </returns>
    Public Function EliminarAntiguos(Optional ByVal Meses As Integer = 3) As Boolean
        Dim Auxiliar As Integer = Meses
        Dim Respuesta As Boolean = False

        Dim Ano As Integer = Today.Date.Year
        Dim Mes As Integer = Today.Date.Month
        Dim Dia As Integer = Today.Date.Day
        Dim fecha As Date

        If Mes = Meses Then
            Ano -= 1
            Mes = 12
        ElseIf Mes < Meses Then
            Ano -= 1
            Auxiliar -= Mes
            Mes = 12 - Auxiliar
        Else
            Mes -= Meses
        End If

        fecha = New Date(Ano, Mes, Dia)
        Try
            Respuesta = Comando.CommandText = "DELETE FROM historial WHERE fecha <= " & fecha.ToString("yyyyMMdd") & " ;"
            Comando.Connection = Conexion
            Conexion.Open()
            Respuesta = Comando.ExecuteNonQuery
            MsgBox(Respuesta.ToString)
            Conexion.Close()
        Catch ex As Exception
            If MostrarError Then
                Mensaje(ex.ToString, 2)
            End If
        End Try
        Return Respuesta
    End Function

    Private Function Indice() As Integer
        Dim Adaptador As New OleDbDataAdapter()
        Dim Registro As New DataTable
        Dim Numero As String

        Try
            Adaptador = New OleDbDataAdapter("SELECT MAX(Id) FROM historial", Conexion)
            Adaptador.Fill(Registro)

            Numero = Registro(0).Item(0)
            Conexion.Close()
            Return Numero + 1
        Catch ex As Exception
            Conexion.Close()
            If MostrarError Then
                Mensaje(ex.ToString, 2)
            End If
            Return 0
        End Try

    End Function
End Class
