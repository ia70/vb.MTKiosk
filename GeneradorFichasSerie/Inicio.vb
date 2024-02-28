Imports System.Management

Public Class Inicio
    Private Act As New Activacion_XCORU

    Private Sub btnFecha_CheckedChanged(sender As Object, e As EventArgs) Handles btnFecha.CheckedChanged
        If btnFecha.Checked Then
            Calendario.Enabled = True
        Else
            Calendario.Enabled = False
        End If
    End Sub

    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        Dim Solicitud As String
        Dim Licencia As String
        Dim _Fecha As Integer = 0

        Solicitud = txtSolicitud.Text

        If Solicitud.Length < 10 Or Not Act.Sintaxis_RequestCode(Solicitud) Then
            MsgBox("Código de solicitud incorrecto!", vbExclamation, "Generador de Licencias")
            txtSolicitud.Text = ""
            txtSolicitud.Select()
            Exit Sub
        End If

        If btnLibre.Checked Then
            _Fecha = 20990101
        Else
            _Fecha = Val(Format(Calendario.SelectionStart.Date, "yyyyMMdd"))
        End If


        Licencia = Act.GetLicenceCode(Solicitud, _Fecha)
        MsgBox("Licencia generada correctamente!", vbInformation, "Generador de Licencias")
        txtActivacion.Text = Licencia
    End Sub

    Private Sub Inicio_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Dim Pass As String
        'Dim FechaActual As Integer
        'FechaActual = Val(Format(Today.Date, "yyyyMMdd"))

        'If FechaActual >= 20180701 Then
        'MsgBox("Periodo de prueba terminado!", vbCritical, "www.xcoru.com")
        'End
        'End If

        'Pass = InputBox("Ingresa la contraseña para acceder!", "Login", "")
        'If Not Pass = "12345" Then
        'MsgBox("Contraseña incorrecta!", vbCritical, "Login")
        'End
        'End If
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtSolicitud.Text = ""
        txtActivacion.Text = ""
        Calendario.SetDate(Today)
        btnFecha.Checked = False
        btnLibre.Checked = True
        Calendario.Enabled = False
        txtSolicitud.Select()
    End Sub
End Class
