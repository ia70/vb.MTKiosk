Public Class GUI_Config
    Private Sub btnPrueba_Click(sender As Object, e As EventArgs) Handles btnPrueba.Click
        Dim MK As New Mikrotik()
        Try
            If txtPuerto.Text.Length = 0 Or Val(txtPuerto.Text) = 0 Or Val(txtPuerto.Text) = -1 Then
                txtPuerto.Text = 8728
            End If

            If MK.Open(txtIP.Text, txtUsuario.Text, txtPassword.Text, Val(txtPuerto.Text)) Then
                Mensaje("¡Conexión establecida correctamente!")
                MK.Close()
                Mikrotik_Cargar_Perfiles(txtIP.Text, Val(txtPuerto.Text), txtUsuario.Text, txtPassword.Text)
            Else
                Mensaje("¡Error de conexión!", 2)
            End If
        Catch ex As Exception
            MK.Close()
            If MostrarError Then
                Mensaje(ex.ToString, 2)
            End If
        End Try
    End Sub

    Private Sub Config_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim y As Integer = 0

        '(0)Id - (1)IP - (2)Usuario - (3)Password - (4)Puerto
        '(0)No - (1)Plan_1h - (2)Precio - (3)Perfil - (4)Valor - (5)Tipo - (6)Indice
        On Error Resume Next
        'DispositivoCargarDatos()
        txtModo.SelectedIndex = 0
        txtIP.Text = DatosMikrotik(1)
        txtUsuario.Text = DatosMikrotik(2)
        txtPassword.Text = DatosMikrotik(3)
        txtPuerto.Text = DatosMikrotik(4)

        '------------------------------------------------------------------------------------------
        If Val(Plan(4, 1)) < 1 Then
            txtCreditos.Value = 1
        Else
            txtCreditos.Value = Convert.ToInt32(Val(Plan(4, 1)))
        End If
        '------------------------------------------------------------------------------------------

        If Mikrotik_Perfiles.Count <= 0 Then
            On Error Resume Next
            Cargar_Perfiles()
        End If

        On Error Resume Next
        txtPlan0.SelectedItem = Plan(y, 2)
        txtPrecio0.Text = Format(Val(Plan(y, 3)), "##0.00")
        y += 1

        On Error Resume Next
        txtPlan1.SelectedItem = Plan(y, 2)
        txtPrecio1.Text = Format(Val(Plan(y, 3)), "##0.00")
        y += 1

        On Error Resume Next
        txtPlan2.SelectedItem = Plan(y, 2)
        txtPrecio2.Text = Format(Val(Plan(y, 3)), "##0.00")
        y += 1

        On Error Resume Next
        txtPlan3.SelectedItem = Plan(y, 2)
        txtPrecio3.Text = Format(Val(Plan(y, 3)), "##0.00")

        PerfilesVerificar()

        'GENERAL ------------------------------------------
        txtNombreEmpresa.Text = G_NombreEmpresa
        txtLogotipo.Text = G_LogotipoEmpresa
        txtNombreImpresora.Text = G_Impresora
        txtCreditos.Value = C_ValorCredito
        txtTecla.Text = ChrW(G_Tecla)
        On Error Resume Next
        txtModo.SelectedIndex = G_Modo
        On Error Resume Next
        picLogotipo.Image = Image.FromFile(G_LogotipoEmpresa)
    End Sub

    Private Sub btnResetMikrotik_Click(sender As Object, e As EventArgs) Handles btnResetMikrotik.Click
        txtIP.Text = ""
        txtPuerto.Text = "8728"
        txtUsuario.Text = ""
        txtPassword.Text = ""
        txtIP.Select()
    End Sub

    Private Sub btnResetPlanes_Click(sender As Object, e As EventArgs) Handles btnResetPlanes.Click
        Dim y As Integer = 0
        txtPrecio0.Text = ""
        txtPrecio1.Text = ""
        txtPrecio2.Text = ""
        txtPrecio3.Text = ""

        If Mikrotik_Perfiles.Count <= 2 Then
            Cargar_Perfiles()
        End If

        On Error Resume Next
        txtPlan0.SelectedItem = Plan(y, 2)
        txtPrecio0.Text = Format(Val(Plan(y, 3)), "##0.00")
        y += 1

        On Error Resume Next
        txtPlan1.SelectedItem = Plan(y, 2)
        txtPrecio1.Text = Format(Val(Plan(y, 3)), "##0.00")
        y += 1

        On Error Resume Next
        txtPlan2.SelectedItem = Plan(y, 2)
        txtPrecio2.Text = Format(Val(Plan(y, 3)), "##0.00")
        y += 1

        On Error Resume Next
        txtPlan3.SelectedItem = Plan(y, 2)
        txtPrecio3.Text = Format(Val(Plan(y, 3)), "##0.00")


    End Sub

    Private Sub btnGuardarMikrotik_Click(sender As Object, e As EventArgs) Handles btnGuardarMikrotik.Click
        Dim DB As New DataBase()
        Dim Resultado As Boolean = False
        Try
            Resultado = DB.EditarDispositivo(txtIP.Text, txtUsuario.Text, txtPassword.Text, Val(txtPuerto.Text))

            If Resultado Then
                DispositivoCargarDatos()
                Mensaje("¡Datos actualizados correctamente!")
                If Mikrotik_Perfiles.Count <= 2 Then
                    Cargar_Perfiles()
                    PerfilesVerificar()
                End If
            Else
                Mensaje("¡Error al actualizar configuración del Mikrotik!", 2)
            End If
        Catch ex As Exception
            If MostrarError Then
                Mensaje(ex.ToString, 2)
            End If
        End Try
    End Sub

    Private Sub btnGuardarPlanes_Click(sender As Object, e As EventArgs) Handles btnGuardarPlanes.Click
        Dim DB As New DataBase()

        Dim _Costo(4) As Integer
        Dim _Plan_nombre(4) As String
        Dim _Plan(4) As String

        Dim x As Integer = 0
        Dim y As Integer

        If txtPlan0.Items.Count < 2 Then
            Exit Sub
        End If

        Try
            _Plan_nombre(x) = txtPlan0.SelectedItem
            _Plan(x) = _Plan_nombre(x)
            _Plan_nombre(x) = _Plan_nombre(x).Replace("_", " ")
            _Costo(x) = Val(txtPrecio0.Text)

            x += 1
            _Plan_nombre(x) = txtPlan1.SelectedItem
            _Plan(x) = _Plan_nombre(x)
            _Plan_nombre(x) = _Plan_nombre(x).Replace("_", " ")
            _Costo(x) = Val(txtPrecio1.Text)

            x += 1
            _Plan_nombre(x) = txtPlan2.SelectedItem
            _Plan(x) = _Plan_nombre(x)
            _Plan_nombre(x) = _Plan_nombre(x).Replace("_", " ")
            _Costo(x) = Val(txtPrecio2.Text)

            x += 1
            _Plan_nombre(x) = txtPlan3.SelectedItem
            _Plan(x) = _Plan_nombre(x)
            _Plan_nombre(x) = _Plan_nombre(x).Replace("_", " ")
            _Costo(x) = Val(txtPrecio3.Text)

            x += 1
            '_Plan_nombre(x) = txtCreditos.Value
            _Plan(x) = ""
            _Costo(x) = 0



            For y = 0 To 3
                DB.EditarPlan(y, _Plan_nombre(y), _Plan(y), _Costo(y))
            Next
            Mensaje("¡Planes actualizados correctamente!")
            DispositivoCargarDatos()
        Catch ex As Exception
            Mensaje("¡Error al intentar guardar planes!", 2)
            If MostrarError Then
                Mensaje(ex.ToString, 2)
            End If
            Exit Sub
        End Try

    End Sub

    Private Sub Cargar_Perfiles()

        Try
            If Mikrotik_Perfiles.Count <= 0 Then
                Mikrotik_Cargar_Perfiles()
            End If
            If Mikrotik_Perfiles.Count > 0 Then
                txtPlan0.Items.Clear()
                txtPlan1.Items.Clear()
                txtPlan2.Items.Clear()
                txtPlan3.Items.Clear()

                For Each row As String In Mikrotik_Perfiles
                    txtPlan0.Items.Add(row)
                    txtPlan1.Items.Add(row)
                    txtPlan2.Items.Add(row)
                    txtPlan3.Items.Add(row)
                Next
            End If

        Catch ex As Exception
            Mikrotik_Perfiles.Clear()
        End Try
    End Sub

    Private Sub PerfilesVerificar()
        If txtPlan0.SelectedIndex = -1 Then
            On Error Resume Next
            txtPlan0.SelectedIndex = 0
        End If

        If txtPlan1.SelectedIndex = -1 Then
            On Error Resume Next
            txtPlan1.SelectedIndex = 0
        End If

        If txtPlan2.SelectedIndex = -1 Then
            On Error Resume Next
            txtPlan2.SelectedIndex = 0
        End If

        If txtPlan3.SelectedIndex = -1 Then
            On Error Resume Next
            txtPlan3.SelectedIndex = 0
        End If
    End Sub

    Private Sub btnImpresora_Click(sender As Object, e As EventArgs) Handles btnImpresora.Click
        Impresoras.ShowDialog()
        txtNombreImpresora.Text = Impresoras.PrinterSettings.PrinterName
    End Sub

    Private Sub btnResetGeneral_Click(sender As Object, e As EventArgs) Handles btnResetGeneral.Click
        txtNombreEmpresa.Text = ""
        txtLogotipo.Text = ""
        txtNombreImpresora.Text = ""
        txtCreditos.Value = 1
        txtModo.SelectedIndex = 1
        txtTecla.Text = ""
    End Sub

    Private Sub RefrescarFondo()

        If txtLogotipo.TextLength > 1 Then
            On Error Resume Next
            picLogotipo.Image = Image.FromFile(txtLogotipo.Text)
        Else
            On Error Resume Next
            picLogotipo.Image = Nothing
        End If

    End Sub

    Private Sub btnLogotipo_Click(sender As Object, e As EventArgs) Handles btnLogotipo.Click
        If Logotipo.ShowDialog() <> DialogResult.Cancel Then
            txtLogotipo.Text = Logotipo.FileName
            RefrescarFondo()
        End If
    End Sub

    Private Sub btnGuardarGeneral_Click(sender As Object, e As EventArgs) Handles btnGuardarGeneral.Click
        Dim DB As New D_General
        Dim _Tecla As Integer

        If Len(txtTecla.Text) = 1 Then
            _Tecla = Asc(txtTecla.Text)
        Else
            If txtTecla.Text = Nothing Then
                Mensaje("El campo Tecla no pueda estar vacio!", 2)
                Exit Sub
            ElseIf val(txtTecla.text) < 1 Or Val(txtTecla.text) > 255 Then
                Exit Sub
            End If
            _Tecla = Val(txtTecla.Text)
        End If

        If DB.Guardar(txtNombreEmpresa.Text, txtLogotipo.Text, txtCreditos.Value, txtNombreImpresora.Text, _Tecla, txtModo.SelectedIndex) Then
            Mensaje("Información guardada!")
            DispositivoCargarDatos()
        Else
            Mensaje("Error: Información no guardada!", 2)
        End If
    End Sub
End Class