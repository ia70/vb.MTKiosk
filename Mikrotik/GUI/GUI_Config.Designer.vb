<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GUI_Config
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GUI_Config))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnResetPlanes = New System.Windows.Forms.Button()
        Me.txtPlan3 = New System.Windows.Forms.ComboBox()
        Me.txtPlan2 = New System.Windows.Forms.ComboBox()
        Me.txtPlan1 = New System.Windows.Forms.ComboBox()
        Me.btnGuardarPlanes = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtPrecio3 = New System.Windows.Forms.TextBox()
        Me.txtPrecio2 = New System.Windows.Forms.TextBox()
        Me.txtPrecio1 = New System.Windows.Forms.TextBox()
        Me.txtPrecio0 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtPlan0 = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCreditos = New System.Windows.Forms.NumericUpDown()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtPuerto = New System.Windows.Forms.TextBox()
        Me.btnResetMikrotik = New System.Windows.Forms.Button()
        Me.btnGuardarMikrotik = New System.Windows.Forms.Button()
        Me.btnPrueba = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtIP = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtTiempoFicha = New System.Windows.Forms.NumericUpDown()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtQR = New System.Windows.Forms.CheckBox()
        Me.btnFondo = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtFondo = New System.Windows.Forms.TextBox()
        Me.txtModo = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtTecla = New System.Windows.Forms.TextBox()
        Me.picLogotipo = New System.Windows.Forms.PictureBox()
        Me.btnLogotipo = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtLogotipo = New System.Windows.Forms.TextBox()
        Me.btnImpresora = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtNombreImpresora = New System.Windows.Forms.TextBox()
        Me.btnResetGeneral = New System.Windows.Forms.Button()
        Me.btnGuardarGeneral = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtNombreEmpresa = New System.Windows.Forms.TextBox()
        Me.Impresoras = New System.Windows.Forms.PrintDialog()
        Me.Logotipo = New System.Windows.Forms.OpenFileDialog()
        Me.dgFondo = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox2.SuspendLayout()
        CType(Me.txtCreditos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.txtTiempoFicha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLogotipo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.btnResetPlanes)
        Me.GroupBox2.Controls.Add(Me.txtPlan3)
        Me.GroupBox2.Controls.Add(Me.txtPlan2)
        Me.GroupBox2.Controls.Add(Me.txtPlan1)
        Me.GroupBox2.Controls.Add(Me.btnGuardarPlanes)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txtPrecio3)
        Me.GroupBox2.Controls.Add(Me.txtPrecio2)
        Me.GroupBox2.Controls.Add(Me.txtPrecio1)
        Me.GroupBox2.Controls.Add(Me.txtPrecio0)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtPlan0)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(2, 314)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(586, 149)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Planes"
        '
        'btnResetPlanes
        '
        Me.btnResetPlanes.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnResetPlanes.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResetPlanes.ForeColor = System.Drawing.Color.Gray
        Me.btnResetPlanes.Location = New System.Drawing.Point(493, 87)
        Me.btnResetPlanes.Name = "btnResetPlanes"
        Me.btnResetPlanes.Size = New System.Drawing.Size(89, 28)
        Me.btnResetPlanes.TabIndex = 28
        Me.btnResetPlanes.Text = "Reset"
        Me.btnResetPlanes.UseVisualStyleBackColor = False
        '
        'txtPlan3
        '
        Me.txtPlan3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtPlan3.FormattingEnabled = True
        Me.txtPlan3.Location = New System.Drawing.Point(135, 118)
        Me.txtPlan3.Name = "txtPlan3"
        Me.txtPlan3.Size = New System.Drawing.Size(251, 26)
        Me.txtPlan3.TabIndex = 27
        '
        'txtPlan2
        '
        Me.txtPlan2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtPlan2.FormattingEnabled = True
        Me.txtPlan2.Location = New System.Drawing.Point(135, 89)
        Me.txtPlan2.Name = "txtPlan2"
        Me.txtPlan2.Size = New System.Drawing.Size(251, 26)
        Me.txtPlan2.TabIndex = 26
        '
        'txtPlan1
        '
        Me.txtPlan1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtPlan1.FormattingEnabled = True
        Me.txtPlan1.Location = New System.Drawing.Point(135, 60)
        Me.txtPlan1.Name = "txtPlan1"
        Me.txtPlan1.Size = New System.Drawing.Size(251, 26)
        Me.txtPlan1.TabIndex = 25
        '
        'btnGuardarPlanes
        '
        Me.btnGuardarPlanes.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnGuardarPlanes.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardarPlanes.Location = New System.Drawing.Point(493, 116)
        Me.btnGuardarPlanes.Name = "btnGuardarPlanes"
        Me.btnGuardarPlanes.Size = New System.Drawing.Size(89, 28)
        Me.btnGuardarPlanes.TabIndex = 24
        Me.btnGuardarPlanes.Text = "Guardar"
        Me.btnGuardarPlanes.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Blue
        Me.Label10.Location = New System.Drawing.Point(390, 12)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(97, 19)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Precio:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtPrecio3
        '
        Me.txtPrecio3.Location = New System.Drawing.Point(398, 118)
        Me.txtPrecio3.MaxLength = 6
        Me.txtPrecio3.Name = "txtPrecio3"
        Me.txtPrecio3.Size = New System.Drawing.Size(89, 26)
        Me.txtPrecio3.TabIndex = 22
        Me.txtPrecio3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPrecio2
        '
        Me.txtPrecio2.Location = New System.Drawing.Point(398, 89)
        Me.txtPrecio2.MaxLength = 6
        Me.txtPrecio2.Name = "txtPrecio2"
        Me.txtPrecio2.Size = New System.Drawing.Size(89, 26)
        Me.txtPrecio2.TabIndex = 21
        Me.txtPrecio2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPrecio1
        '
        Me.txtPrecio1.Location = New System.Drawing.Point(398, 60)
        Me.txtPrecio1.MaxLength = 6
        Me.txtPrecio1.Name = "txtPrecio1"
        Me.txtPrecio1.Size = New System.Drawing.Size(89, 26)
        Me.txtPrecio1.TabIndex = 20
        Me.txtPrecio1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPrecio0
        '
        Me.txtPrecio0.Location = New System.Drawing.Point(398, 31)
        Me.txtPrecio0.MaxLength = 6
        Me.txtPrecio0.Name = "txtPrecio0"
        Me.txtPrecio0.Size = New System.Drawing.Size(89, 26)
        Me.txtPrecio0.TabIndex = 19
        Me.txtPrecio0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Blue
        Me.Label9.Location = New System.Drawing.Point(209, 12)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(97, 19)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Perfil:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtPlan0
        '
        Me.txtPlan0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtPlan0.FormattingEnabled = True
        Me.txtPlan0.Location = New System.Drawing.Point(135, 31)
        Me.txtPlan0.Name = "txtPlan0"
        Me.txtPlan0.Size = New System.Drawing.Size(251, 26)
        Me.txtPlan0.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(-7, 117)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(140, 26)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Boton Rosa:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(-7, 88)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(140, 26)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Boton Amarillo:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(-7, 59)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(140, 26)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Boton Rojo:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(-7, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(140, 26)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Boton Azul:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCreditos
        '
        Me.txtCreditos.Location = New System.Drawing.Point(172, 133)
        Me.txtCreditos.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtCreditos.Name = "txtCreditos"
        Me.txtCreditos.Size = New System.Drawing.Size(61, 26)
        Me.txtCreditos.TabIndex = 32
        Me.txtCreditos.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(235, 136)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(75, 19)
        Me.Label13.TabIndex = 31
        Me.Label13.Text = "creditos."
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(76, 136)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(100, 19)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "1 Moneda = "
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtPuerto)
        Me.GroupBox1.Controls.Add(Me.btnResetMikrotik)
        Me.GroupBox1.Controls.Add(Me.btnGuardarMikrotik)
        Me.GroupBox1.Controls.Add(Me.btnPrueba)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtPassword)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtUsuario)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtIP)
        Me.GroupBox1.Location = New System.Drawing.Point(2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(586, 80)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mikrotik"
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(188, 20)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(71, 26)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "Puerto:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPuerto
        '
        Me.txtPuerto.BackColor = System.Drawing.Color.White
        Me.txtPuerto.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPuerto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtPuerto.Location = New System.Drawing.Point(265, 20)
        Me.txtPuerto.MaxLength = 4
        Me.txtPuerto.Name = "txtPuerto"
        Me.txtPuerto.Size = New System.Drawing.Size(97, 26)
        Me.txtPuerto.TabIndex = 28
        Me.txtPuerto.Text = "8728"
        Me.txtPuerto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnResetMikrotik
        '
        Me.btnResetMikrotik.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnResetMikrotik.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResetMikrotik.ForeColor = System.Drawing.Color.Gray
        Me.btnResetMikrotik.Location = New System.Drawing.Point(491, 17)
        Me.btnResetMikrotik.Name = "btnResetMikrotik"
        Me.btnResetMikrotik.Size = New System.Drawing.Size(89, 28)
        Me.btnResetMikrotik.TabIndex = 27
        Me.btnResetMikrotik.Text = "Reset"
        Me.btnResetMikrotik.UseVisualStyleBackColor = False
        '
        'btnGuardarMikrotik
        '
        Me.btnGuardarMikrotik.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnGuardarMikrotik.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardarMikrotik.Location = New System.Drawing.Point(491, 47)
        Me.btnGuardarMikrotik.Name = "btnGuardarMikrotik"
        Me.btnGuardarMikrotik.Size = New System.Drawing.Size(89, 28)
        Me.btnGuardarMikrotik.TabIndex = 26
        Me.btnGuardarMikrotik.Text = "Guardar"
        Me.btnGuardarMikrotik.UseVisualStyleBackColor = False
        '
        'btnPrueba
        '
        Me.btnPrueba.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnPrueba.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrueba.ForeColor = System.Drawing.Color.Gray
        Me.btnPrueba.Location = New System.Drawing.Point(386, 20)
        Me.btnPrueba.Name = "btnPrueba"
        Me.btnPrueba.Size = New System.Drawing.Size(89, 28)
        Me.btnPrueba.TabIndex = 25
        Me.btnPrueba.Text = "Test"
        Me.btnPrueba.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(258, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 26)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Pass"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(315, 49)
        Me.txtPassword.MaxLength = 20
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(158, 26)
        Me.txtPassword.TabIndex = 6
        Me.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 26)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Usuario:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(81, 49)
        Me.txtUsuario.MaxLength = 20
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(152, 26)
        Me.txtUsuario.TabIndex = 4
        Me.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 26)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "IP:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtIP
        '
        Me.txtIP.Location = New System.Drawing.Point(43, 19)
        Me.txtIP.MaxLength = 15
        Me.txtIP.Name = "txtIP"
        Me.txtIP.Size = New System.Drawing.Size(139, 26)
        Me.txtIP.TabIndex = 2
        Me.txtIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.txtTiempoFicha)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.txtQR)
        Me.GroupBox3.Controls.Add(Me.btnFondo)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.txtFondo)
        Me.GroupBox3.Controls.Add(Me.txtModo)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.txtTecla)
        Me.GroupBox3.Controls.Add(Me.picLogotipo)
        Me.GroupBox3.Controls.Add(Me.btnLogotipo)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.txtLogotipo)
        Me.GroupBox3.Controls.Add(Me.txtCreditos)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.btnImpresora)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.txtNombreImpresora)
        Me.GroupBox3.Controls.Add(Me.btnResetGeneral)
        Me.GroupBox3.Controls.Add(Me.btnGuardarGeneral)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.txtNombreEmpresa)
        Me.GroupBox3.Location = New System.Drawing.Point(2, 85)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(586, 226)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "General"
        '
        'txtTiempoFicha
        '
        Me.txtTiempoFicha.Location = New System.Drawing.Point(493, 165)
        Me.txtTiempoFicha.Maximum = New Decimal(New Integer() {30, 0, 0, 0})
        Me.txtTiempoFicha.Minimum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.txtTiempoFicha.Name = "txtTiempoFicha"
        Me.txtTiempoFicha.Size = New System.Drawing.Size(79, 26)
        Me.txtTiempoFicha.TabIndex = 51
        Me.txtTiempoFicha.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(239, 164)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(248, 26)
        Me.Label19.TabIndex = 50
        Me.Label19.Text = "Tiempo ficha (segundos):"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtQR
        '
        Me.txtQR.AutoSize = True
        Me.txtQR.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQR.Location = New System.Drawing.Point(334, 135)
        Me.txtQR.Name = "txtQR"
        Me.txtQR.Size = New System.Drawing.Size(52, 23)
        Me.txtQR.TabIndex = 48
        Me.txtQR.Text = "QR"
        Me.txtQR.UseVisualStyleBackColor = True
        '
        'btnFondo
        '
        Me.btnFondo.BackgroundImage = Global.Mikrotik.My.Resources.Resources.lupa
        Me.btnFondo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnFondo.Location = New System.Drawing.Point(382, 75)
        Me.btnFondo.Name = "btnFondo"
        Me.btnFondo.Size = New System.Drawing.Size(30, 30)
        Me.btnFondo.TabIndex = 47
        Me.btnFondo.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(26, 77)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(140, 26)
        Me.Label18.TabIndex = 46
        Me.Label18.Text = "Fondo:"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtFondo
        '
        Me.txtFondo.BackColor = System.Drawing.Color.White
        Me.txtFondo.Enabled = False
        Me.txtFondo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFondo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtFondo.Location = New System.Drawing.Point(172, 77)
        Me.txtFondo.MaxLength = 3000
        Me.txtFondo.Name = "txtFondo"
        Me.txtFondo.ReadOnly = True
        Me.txtFondo.Size = New System.Drawing.Size(204, 26)
        Me.txtFondo.TabIndex = 45
        Me.txtFondo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtModo
        '
        Me.txtModo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtModo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtModo.ForeColor = System.Drawing.Color.Black
        Me.txtModo.FormattingEnabled = True
        Me.txtModo.Items.AddRange(New Object() {"PIN", "Normal"})
        Me.txtModo.Location = New System.Drawing.Point(477, 132)
        Me.txtModo.Name = "txtModo"
        Me.txtModo.Size = New System.Drawing.Size(95, 27)
        Me.txtModo.TabIndex = 44
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label17.Location = New System.Drawing.Point(421, 131)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(52, 26)
        Me.Label17.TabIndex = 43
        Me.Label17.Text = "Modo"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(26, 163)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(140, 26)
        Me.Label15.TabIndex = 42
        Me.Label15.Text = "Tecla de Credito:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTecla
        '
        Me.txtTecla.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTecla.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTecla.ForeColor = System.Drawing.Color.Red
        Me.txtTecla.Location = New System.Drawing.Point(172, 161)
        Me.txtTecla.MaxLength = 3
        Me.txtTecla.Name = "txtTecla"
        Me.txtTecla.Size = New System.Drawing.Size(47, 29)
        Me.txtTecla.TabIndex = 41
        Me.txtTecla.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'picLogotipo
        '
        Me.picLogotipo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picLogotipo.Location = New System.Drawing.Point(428, 21)
        Me.picLogotipo.Name = "picLogotipo"
        Me.picLogotipo.Size = New System.Drawing.Size(144, 91)
        Me.picLogotipo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picLogotipo.TabIndex = 40
        Me.picLogotipo.TabStop = False
        '
        'btnLogotipo
        '
        Me.btnLogotipo.BackgroundImage = Global.Mikrotik.My.Resources.Resources.lupa
        Me.btnLogotipo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLogotipo.Location = New System.Drawing.Point(382, 47)
        Me.btnLogotipo.Name = "btnLogotipo"
        Me.btnLogotipo.Size = New System.Drawing.Size(30, 30)
        Me.btnLogotipo.TabIndex = 39
        Me.btnLogotipo.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(26, 49)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(140, 26)
        Me.Label14.TabIndex = 38
        Me.Label14.Text = "Logotipo:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtLogotipo
        '
        Me.txtLogotipo.BackColor = System.Drawing.Color.White
        Me.txtLogotipo.Enabled = False
        Me.txtLogotipo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLogotipo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtLogotipo.Location = New System.Drawing.Point(172, 49)
        Me.txtLogotipo.MaxLength = 3000
        Me.txtLogotipo.Name = "txtLogotipo"
        Me.txtLogotipo.ReadOnly = True
        Me.txtLogotipo.Size = New System.Drawing.Size(204, 26)
        Me.txtLogotipo.TabIndex = 37
        Me.txtLogotipo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnImpresora
        '
        Me.btnImpresora.BackgroundImage = Global.Mikrotik.My.Resources.Resources.lupa
        Me.btnImpresora.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnImpresora.Location = New System.Drawing.Point(382, 103)
        Me.btnImpresora.Name = "btnImpresora"
        Me.btnImpresora.Size = New System.Drawing.Size(30, 30)
        Me.btnImpresora.TabIndex = 36
        Me.btnImpresora.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(26, 105)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(140, 26)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "Impresora:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNombreImpresora
        '
        Me.txtNombreImpresora.BackColor = System.Drawing.Color.White
        Me.txtNombreImpresora.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreImpresora.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtNombreImpresora.Location = New System.Drawing.Point(172, 105)
        Me.txtNombreImpresora.MaxLength = 50
        Me.txtNombreImpresora.Name = "txtNombreImpresora"
        Me.txtNombreImpresora.ReadOnly = True
        Me.txtNombreImpresora.Size = New System.Drawing.Size(204, 26)
        Me.txtNombreImpresora.TabIndex = 28
        Me.txtNombreImpresora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnResetGeneral
        '
        Me.btnResetGeneral.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnResetGeneral.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResetGeneral.ForeColor = System.Drawing.Color.Gray
        Me.btnResetGeneral.Location = New System.Drawing.Point(389, 193)
        Me.btnResetGeneral.Name = "btnResetGeneral"
        Me.btnResetGeneral.Size = New System.Drawing.Size(89, 28)
        Me.btnResetGeneral.TabIndex = 27
        Me.btnResetGeneral.Text = "Reset"
        Me.btnResetGeneral.UseVisualStyleBackColor = False
        '
        'btnGuardarGeneral
        '
        Me.btnGuardarGeneral.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnGuardarGeneral.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardarGeneral.Location = New System.Drawing.Point(484, 193)
        Me.btnGuardarGeneral.Name = "btnGuardarGeneral"
        Me.btnGuardarGeneral.Size = New System.Drawing.Size(89, 28)
        Me.btnGuardarGeneral.TabIndex = 26
        Me.btnGuardarGeneral.Text = "Guardar"
        Me.btnGuardarGeneral.UseVisualStyleBackColor = False
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(10, 21)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(156, 26)
        Me.Label16.TabIndex = 3
        Me.Label16.Text = "Nombre Empresa:"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNombreEmpresa
        '
        Me.txtNombreEmpresa.Location = New System.Drawing.Point(172, 21)
        Me.txtNombreEmpresa.MaxLength = 15
        Me.txtNombreEmpresa.Name = "txtNombreEmpresa"
        Me.txtNombreEmpresa.Size = New System.Drawing.Size(240, 26)
        Me.txtNombreEmpresa.TabIndex = 2
        Me.txtNombreEmpresa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Impresoras
        '
        Me.Impresoras.AllowPrintToFile = False
        Me.Impresoras.ShowNetwork = False
        '
        'Logotipo
        '
        Me.Logotipo.Filter = "Imágenes: |*.jpg;*.bmp;*.png"
        Me.Logotipo.Title = "Buscar Logotipo"
        '
        'dgFondo
        '
        Me.dgFondo.Filter = "Imágenes: |*.jpg;*.bmp;*.png"
        Me.dgFondo.Title = "Buscar Imagen de Fondo"
        '
        'GUI_Config
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(591, 465)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "GUI_Config"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configuración - V2.0"
        Me.TopMost = True
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.txtCreditos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.txtTiempoFicha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLogotipo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnGuardarPlanes As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents txtPrecio3 As TextBox
    Friend WithEvents txtPrecio2 As TextBox
    Friend WithEvents txtPrecio1 As TextBox
    Friend WithEvents txtPrecio0 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtPlan0 As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnGuardarMikrotik As Button
    Friend WithEvents btnPrueba As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtIP As TextBox
    Friend WithEvents txtPlan3 As ComboBox
    Friend WithEvents txtPlan2 As ComboBox
    Friend WithEvents txtPlan1 As ComboBox
    Friend WithEvents btnResetPlanes As Button
    Friend WithEvents btnResetMikrotik As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents txtPuerto As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtCreditos As NumericUpDown
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnImpresora As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents txtNombreImpresora As TextBox
    Friend WithEvents btnResetGeneral As Button
    Friend WithEvents btnGuardarGeneral As Button
    Friend WithEvents Label16 As Label
    Friend WithEvents txtNombreEmpresa As TextBox
    Friend WithEvents Impresoras As PrintDialog
    Friend WithEvents btnLogotipo As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents txtLogotipo As TextBox
    Friend WithEvents Logotipo As OpenFileDialog
    Friend WithEvents picLogotipo As PictureBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtTecla As TextBox
    Friend WithEvents txtModo As ComboBox
    Friend WithEvents Label17 As Label
    Friend WithEvents btnFondo As Button
    Friend WithEvents Label18 As Label
    Friend WithEvents txtFondo As TextBox
    Friend WithEvents txtQR As CheckBox
    Friend WithEvents Label19 As Label
    Friend WithEvents txtTiempoFicha As NumericUpDown
    Friend WithEvents dgFondo As OpenFileDialog
End Class
