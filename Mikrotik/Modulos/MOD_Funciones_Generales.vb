Imports System.IO
Module MOD_Funciones_Generales

    'Carga toda la información inicial
    ''' <summary>
    ''' 'Carga toda la información inicial
    ''' </summary>
    ''' <returns></returns>
    Public Function DispositivoCargarDatos() As Boolean
        Dim DB As New DataBase
        Dim General As New D_General
        Dim Cadena(9) As String

        Dim x, y As Integer
        Try
            Teclas(0) = "A"
            Teclas(1) = "B"
            Teclas(2) = "C"
            Teclas(3) = "D"
            Teclas(4) = "1" 'Valor del credito

            x = 0

            DatosMikrotik = DB.CargarDispositivo()
            Plan = DB.CargarPlanes()

            'Teclas(4) = Plan(4, 1)

            y = 0
            GUI_Principal.Boton1.Text = Plan(y, 1)
            y += 1
            GUI_Principal.Boton2.Text = Plan(y, 1)
            y += 1
            GUI_Principal.Boton3.Text = Plan(y, 1)
            y += 1
            GUI_Principal.Boton4.Text = Plan(y, 1)

            y = 0
            GUI_Principal.txtPrecio1.Text = Format(Val(Plan(y, 3)), "$##0.00")
            y += 1
            GUI_Principal.txtPrecio2.Text = Format(Val(Plan(y, 3)), "$##0.00")
            y += 1
            GUI_Principal.txtPrecio3.Text = Format(Val(Plan(y, 3)), "$##0.00")
            y += 1
            GUI_Principal.txtPrecio4.Text = Format(Val(Plan(y, 3)), "$##0.00")


            'GENERAL ------------------------------------------------------------------------
            Cadena = General.Consultar

            If Cadena(1) = "" Then
                Cadena(1) = "Bienvenido"
            End If

            If Val(Cadena(3)) < 1 Then
                Cadena(3) = 1
            End If

            G_NombreEmpresa = Cadena(1)
            G_LogotipoEmpresa = Cadena(2)
            C_ValorCredito = Val(Cadena(3))
            G_Impresora = Cadena(4)
            G_Tecla = Cadena(5)
            G_Modo = Cadena(6)
            G_QR = Convert.ToBoolean(Cadena(7))
            G_TiempoVisualizacionFicha = Convert.ToInt32(Cadena(8))
            G_Fondo = Cadena(9)

            CargarModo() ' Carga el modo mIKROTIK 

            GUI_Principal.txtNombreEmpresa.Text = G_NombreEmpresa


            If Not G_LogotipoEmpresa = "" And Not G_LogotipoEmpresa = Nothing Then
                GUI_Principal.picLogotipo.Image = Image.FromFile(G_LogotipoEmpresa)
            End If

            Return True
        Catch ex As Exception
            If MostrarError Then
                Mensaje(ex.ToString, 2)
            End If
            Return False
        End Try
    End Function

    Private Sub CargarModo()

        Select Case (G_Modo)
            Case 0
                With GUI_Principal
                    .Datos.Height = 96
                    .lblUsuario.Text = "PIN:"
                End With
            Case 1
                With GUI_Principal
                    .Datos.Height = 180
                    .lblUsuario.Text = "Usuario:"
                End With
        End Select
    End Sub


    'Carga los perfiles existentes del Mikrotik
    ''' <summary>
    ''' 'Carga los perfiles existentes del Mikrotik
    ''' </summary>
    Public Sub Mikrotik_Cargar_Perfiles(Optional ByVal _ip As String = Nothing, Optional ByVal _puerto As Integer = Nothing, Optional ByVal _usuario As String = Nothing, Optional ByVal _pass As String = Nothing)
        Dim MK As New MikrotikAPI
        Dim Estado As Boolean
        Dim Respuesta As New List(Of String)

        On Error Resume Next

        If Not _ip Is Nothing Then
            Estado = MK.Open(_ip, _usuario, _pass, _puerto)
        Else
            Estado = MK.Open(DatosMikrotik(1), DatosMikrotik(2), DatosMikrotik(3), DatosMikrotik(4))
        End If



        If Estado Then
            MK.Send("/ip/hotspot/user/profile/print", False)
            MK.Send("=.proplist=name", True)
            Respuesta = MK.Read()


            Mikrotik_Perfiles.Clear()

            For Each Row As String In Respuesta
                On Error Resume Next
                Mikrotik_Perfiles.Add(Row.Substring(9, Row.Length - 9))
            Next
        Else
            If MostrarError Then
                Mensaje("No se pueden cargar los perfiles!", 2)
            End If
        End If
    End Sub


    'Analiza la operación seleccionada
    ''' <summary>
    ''' Analiza la operación seleccionada
    ''' </summary>
    ''' <param name="Valor">Operación seleccionada</param>
    Public Sub Operacion(ByVal Valor As Integer, Optional ByVal _plan As String = "")
        Dim _QR As New QRCode
        '(0)No - (1)Plan_1h - (2)Precio - (3)Perfil - (4)Valor - (5)Tipo - (6)Indice
        Dim DB As New DataBase
        Dim Datos(1) As String
        Dim PlanesNom(3) As String '**************************
        Dim Respuesta As Boolean = False

        If Not C_Credito >= Val(Plan(Valor, 3)) Or Not Val(Plan(Valor, 3)) > 0 Then
            Exit Sub
        End If

        Dim MK As New Mikrotik()
        Dim Ticket As New XCORU.cImpresoraTickets

        Respuesta = MK.Open(DatosMikrotik(1), DatosMikrotik(2), DatosMikrotik(3), DatosMikrotik(4))

        Try
            If Not Respuesta Then
                Mensaje("¡No hay conexión con el dispositivo!", 2)
                Exit Sub
            End If

            If Val(Plan(Valor, 3)) <= C_Credito Then

                Datos = GenerarUsuario(5)
                If G_Modo = 0 Then
                    Datos(1) = ""
                End If

                MK.Insertar(Datos(0), Datos(1), "", Plan(Valor, 2)) '************************
                DB.HistorialInsertar(Datos(0), Datos(1), Plan(Valor, 2))

                MK.Close()
                GUI_Principal.txtUsuario.Text = Datos(0)
                GUI_Principal.txtPassword.Text = Datos(1)

                C_Credito = C_Credito - Val(Plan(Valor, 3))
                GUI_Principal.Creditos.Text = Format(C_Credito, "0000")

                Ticket.Previsualizar = False
                Ticket.Empresa = G_NombreEmpresa
                Ticket.Plan = _plan

                If G_Impresora = "" Or G_Impresora = Nothing Then
                    Mensaje("Impresora inválida", 2)
                    Ticket.Impresora = ""
                Else
                    Ticket.Impresora = G_Impresora
                End If


                If G_QR Then
                    Ticket.QR = _QR.GenerarQR("http://" & DatosMikrotik(1) & "/acceso.html?usr=" & Datos(0) & "&pwd=" & Datos(1))
                End If

                Ticket.Usuario = Datos(0)
                    Ticket.Password = Datos(1)


                    If File.Exists(G_LogotipoEmpresa) Then
                        Ticket.Logotipo = Image.FromFile(G_LogotipoEmpresa)
                    End If


                    Ticket.ImprimirTicket()
                    GUI_Principal.TiempoVisualizacion.Enabled = True
                End If
        Catch ex As Exception
            Mensaje("Error al intentar imprimir!", 2)
            If MostrarError Then
                Mensaje(ex.ToString, 2)
            End If
        End Try
    End Sub

    'Genera usuario y contraseña
    ''' <summary>
    ''' Genera un array con un usuario y una contraseña
    ''' </summary>
    ''' <param name="Longitud_"></param>
    ''' <returns>Array</returns>
    Public Function GenerarUsuario(ByVal Longitud_ As Integer) As String()
        Dim DB As New DataBase
        Dim i As Integer
        Dim Datos(1) As String

        Dim obj As New Random()
        Dim posibles As String = "1234567890" '"abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890"
        Dim longitud As Integer = posibles.Length
        Dim letra As Char

        Dim usuario_ As String = ""
        Dim password_ As String = ""

        Do
            For i = 0 To Longitud_ - 1
                letra = posibles(obj.[Next](longitud))
                usuario_ += letra.ToString()
            Next

        Loop While DB.VerificarUsuario(usuario_)

        For i = 0 To Longitud_ - 1
            letra = posibles(obj.[Next](longitud))
            password_ += letra.ToString()
        Next

        Datos(0) = usuario_
        Datos(1) = password_


        Return Datos
    End Function
    'Muestra Mensaje
    ''' <summary>
    ''' Envia cuadro de mensaje
    ''' </summary>
    ''' <param name="Mensaje">Texto</param>
    ''' <param name="Icono">0, 1, 2</param>
    Public Sub Mensaje(ByVal Mensaje As String, Optional ByVal Icono As Integer = 0)
        Dim Ico As Integer = 0

        Select Case Icono
            Case 0
                Ico = vbInformation
            Case 1
                Ico = vbExclamation
            Case 2
                Ico = vbCritical
        End Select

        MsgBox(Mensaje, vbOKOnly + Ico, G_NombreEmpresa)
    End Sub
    'Limpia los valores de credito
    ''' <summary>
    ''' Limpia los valores de credito
    ''' </summary>
    Public Sub Limpiar()
        C_Credito = 0
        C_NewCredito = 0
        C_Cadena_Credito = ""
        GUI_Principal.Creditos.Text = "0000"
    End Sub
End Module
