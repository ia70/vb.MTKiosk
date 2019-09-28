Imports System.Runtime.InteropServices
Public Class GUI_Principal
    'JOYSTIC
    Declare Function joyGetPosEx Lib "winmm.dll" (ByVal uJoyID As Integer, ByRef pji As JOYINFOEX) As Integer

    <StructLayout(LayoutKind.Sequential)>
    Public Structure JOYINFOEX
        Public dwSize As Integer 'Size, in bytes, of this structure.
        Public dwFlags As Integer 'Flags indicating the valid information returned in this structure. Members that do not contain valid information are set to zero. The following flags are defined:VER PAGINA WEB
        Public dwXpos As Integer 'Current X-coordinate.
        Public dwYpos As Integer 'Current Y-coordinate.
        Public dwZpos As Integer 'Current Z-coordinate.
        Public dwRpos As Integer 'Current position of the rudder or fourth joystick axis.
        Public dwUpos As Integer 'Current fifth axis position.
        Public dwVpos As Integer 'Current sixth axis position.
        Public dwButtons As Integer 'Current state of the 32 joystick buttons. The value of this member can be set to any combination of JOY_BUTTONn flags, where n is a value in the range of 1 through 32 corresponding to the button that is pressed.
        Public dwButtonNumber As Integer 'Current button number that is pressed.
        Public dwPOV As Integer 'Current position of the point-of-view control. Values for this member are in the range 0 through 35,900. These values represent the angle, in degrees, of each view multiplied by 100.
        Public dwReserved1 As Integer 'Reserved; do not use.
        Public dwReserved2 As Integer 'Reserved; do not use.
    End Structure

    Dim myjoyEX As JOYINFOEX

    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DispositivoCargarDatos()

        'JOYSTICK ***************************
        myjoyEX.dwSize = 64
        myjoyEX.dwFlags = &HFF
        '************************************
    End Sub

    Private Sub Localizacion(Optional ByVal num As Integer = 0)
        Botones.Location = New Point((Me.Width - 974) / 2, Me.Height - (280 + num))
        Datos.Location = New Point((Me.Width - 560) / 2, (Me.Height - (300 + num)) / 2)
        Cerrar.Location = New Point(Me.Width - 60, 134)
        MarcadeAgua.Location = New Point(2, Me.Height - MarcadeAgua.Height)
    End Sub

    Private Sub Principal_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        Localizacion(40)
        Me.Select()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Fecha.Tick
        Label7.Text = DateString + vbCrLf + Format(TimeOfDay, "hh:mm:ss tt")
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles Cerrar.Click
        End
    End Sub

    Private Sub Principal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = ChrW(G_Tecla) Then
            'If Not C_Cadena_Credito = "" Then
            'C_NewCredito = CInt(C_Cadena_Credito)
            'C_Credito += C_NewCredito
            'C_NewCredito = 0
            'C_Cadena_Credito = ""
            'Creditos.Text = Format(C_Credito, "0000")
            'End If
            'ElseIf IsNumeric(e.KeyChar) Then
            'C_Cadena_Credito = C_Cadena_Credito & e.KeyChar
            C_Credito += C_ValorCredito
            Creditos.Text = Format(C_Credito, "0000")
        Else
            Select Case UCase(e.KeyChar)
                Case "A"
                    Operacion(0, Boton1.Text)
                Case "B"
                    Operacion(1, Boton2.Text)
                Case "C"
                    Operacion(2, Boton3.Text)
                Case "D"
                    Operacion(3, Boton4.Text)
                Case "Q"
                    'Me.Hide()
                    GUI_Config.Show()
            End Select
        End If
    End Sub

    Private Sub Tiempo_Tick(sender As Object, e As EventArgs) Handles TiempoVisualizacion.Tick
        Static Contador As Integer = 20

        If Contador = 0 Then
            Contador = 20
            txtUsuario.Text = ""
            txtPassword.Text = ""
            txtConteo.Visible = False
            TiempoVisualizacion.Enabled = False
        ElseIf Contador = 20 Then
            txtConteo.Visible = True
            txtConteo.Text = 20
            Contador -= 1
        Else
            txtConteo.Text = Val(txtConteo.Text) - 1
            Contador = Val(txtConteo.Text)
        End If

    End Sub

    Private Sub Joystick_Tick(sender As Object, e As EventArgs) Handles Joystick.Tick
        Static Boton As Integer = 0
        Static Aux1 As Integer = 0

        joyGetPosEx(0, myjoyEX)
        Boton = myjoyEX.dwButtons
        If Boton = 0 Then
            Aux1 = 0
            Exit Sub
        End If
        If Not Aux1 = 0 Then
            Exit Sub
        Else
            Aux1 = 1
        End If

        If Boton = 16 Then
            C_Credito += C_ValorCredito
            Creditos.Text = Format(C_Credito, "0000")
            'Mensaje("Credito")
        ElseIf Boton = 1 Then
            Operacion(0, Boton1.Text)
            'Mensaje("1")
        ElseIf Boton = 2 Then
            Operacion(1, Boton2.Text)
            'Mensaje("2")
        ElseIf Boton = 4 Then
            Operacion(2, Boton3.Text)
            'Mensaje("4")
        ElseIf Boton = 8 Then
            Operacion(3, Boton4.Text)
            'Mensaje("8")
        End If

        'txtUsuario.Text = Boton
        'TextBox7.Text = myjoyEX.dwButtons.ToString
        'TextBox8.Text = myjoyEX.dwButtonNumber.ToString
    End Sub

    Private Sub Label1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Label1.LinkClicked
        Process.Start("http://www.xcoru.com")
    End Sub

    Private Sub Label1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Label1.KeyPress
        Call Principal_KeyPress(sender, e)
    End Sub
End Class
