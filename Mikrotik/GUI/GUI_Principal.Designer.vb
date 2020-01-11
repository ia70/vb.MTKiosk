<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GUI_Principal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GUI_Principal))
        Me.P_Header = New System.Windows.Forms.Panel()
        Me.picLogotipo = New System.Windows.Forms.PictureBox()
        Me.txtNombreEmpresa = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Creditos = New System.Windows.Forms.Label()
        Me.Botones = New System.Windows.Forms.Panel()
        Me.txtPrecio4 = New System.Windows.Forms.Label()
        Me.txtPrecio3 = New System.Windows.Forms.Label()
        Me.txtPrecio2 = New System.Windows.Forms.Label()
        Me.txtPrecio1 = New System.Windows.Forms.Label()
        Me.Boton4 = New System.Windows.Forms.Label()
        Me.Boton3 = New System.Windows.Forms.Label()
        Me.Boton2 = New System.Windows.Forms.Label()
        Me.Boton1 = New System.Windows.Forms.Label()
        Me.Datos = New System.Windows.Forms.Panel()
        Me.txtConteo = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.Label()
        Me.txtUsuario = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.Cerrar = New System.Windows.Forms.PictureBox()
        Me.Fecha = New System.Windows.Forms.Timer(Me.components)
        Me.Desconectado = New System.Windows.Forms.PictureBox()
        Me.TiempoVisualizacion = New System.Windows.Forms.Timer(Me.components)
        Me.MarcadeAgua = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.LinkLabel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Joystick = New System.Windows.Forms.Timer(Me.components)
        Me.P_Header.SuspendLayout()
        CType(Me.picLogotipo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Botones.SuspendLayout()
        Me.Datos.SuspendLayout()
        CType(Me.Cerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Desconectado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MarcadeAgua.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'P_Header
        '
        Me.P_Header.BackgroundImage = Global.Mikrotik.My.Resources.Resources.Fondo
        Me.P_Header.Controls.Add(Me.picLogotipo)
        Me.P_Header.Controls.Add(Me.txtNombreEmpresa)
        Me.P_Header.Controls.Add(Me.Label7)
        Me.P_Header.Controls.Add(Me.Panel2)
        Me.P_Header.Dock = System.Windows.Forms.DockStyle.Top
        Me.P_Header.Location = New System.Drawing.Point(0, 0)
        Me.P_Header.Name = "P_Header"
        Me.P_Header.Size = New System.Drawing.Size(1200, 124)
        Me.P_Header.TabIndex = 9
        '
        'picLogotipo
        '
        Me.picLogotipo.BackColor = System.Drawing.Color.Transparent
        Me.picLogotipo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picLogotipo.Dock = System.Windows.Forms.DockStyle.Left
        Me.picLogotipo.Location = New System.Drawing.Point(261, 0)
        Me.picLogotipo.Name = "picLogotipo"
        Me.picLogotipo.Size = New System.Drawing.Size(183, 124)
        Me.picLogotipo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picLogotipo.TabIndex = 3
        Me.picLogotipo.TabStop = False
        '
        'txtNombreEmpresa
        '
        Me.txtNombreEmpresa.BackColor = System.Drawing.Color.Transparent
        Me.txtNombreEmpresa.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtNombreEmpresa.Font = New System.Drawing.Font("Arial", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreEmpresa.ForeColor = System.Drawing.Color.White
        Me.txtNombreEmpresa.Location = New System.Drawing.Point(261, 0)
        Me.txtNombreEmpresa.Name = "txtNombreEmpresa"
        Me.txtNombreEmpresa.Size = New System.Drawing.Size(711, 124)
        Me.txtNombreEmpresa.TabIndex = 2
        Me.txtNombreEmpresa.Text = "Bienvenido"
        Me.txtNombreEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label7.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(972, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(228, 124)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "."
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Creditos)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(261, 124)
        Me.Panel2.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Lime
        Me.Label6.Location = New System.Drawing.Point(0, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(257, 34)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "CREDITOS"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Creditos
        '
        Me.Creditos.BackColor = System.Drawing.Color.Transparent
        Me.Creditos.Font = New System.Drawing.Font("Agency FB", 68.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Creditos.ForeColor = System.Drawing.Color.Red
        Me.Creditos.Location = New System.Drawing.Point(0, 21)
        Me.Creditos.Name = "Creditos"
        Me.Creditos.Size = New System.Drawing.Size(253, 103)
        Me.Creditos.TabIndex = 1
        Me.Creditos.Text = "0000"
        Me.Creditos.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Botones
        '
        Me.Botones.BackColor = System.Drawing.Color.Transparent
        Me.Botones.Controls.Add(Me.txtPrecio4)
        Me.Botones.Controls.Add(Me.txtPrecio3)
        Me.Botones.Controls.Add(Me.txtPrecio2)
        Me.Botones.Controls.Add(Me.txtPrecio1)
        Me.Botones.Controls.Add(Me.Boton4)
        Me.Botones.Controls.Add(Me.Boton3)
        Me.Botones.Controls.Add(Me.Boton2)
        Me.Botones.Controls.Add(Me.Boton1)
        Me.Botones.Location = New System.Drawing.Point(96, 533)
        Me.Botones.Name = "Botones"
        Me.Botones.Size = New System.Drawing.Size(974, 280)
        Me.Botones.TabIndex = 10
        '
        'txtPrecio4
        '
        Me.txtPrecio4.BackColor = System.Drawing.Color.DimGray
        Me.txtPrecio4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtPrecio4.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecio4.ForeColor = System.Drawing.Color.White
        Me.txtPrecio4.Location = New System.Drawing.Point(759, 227)
        Me.txtPrecio4.Name = "txtPrecio4"
        Me.txtPrecio4.Size = New System.Drawing.Size(215, 53)
        Me.txtPrecio4.TabIndex = 18
        Me.txtPrecio4.Text = "$00.00"
        Me.txtPrecio4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtPrecio3
        '
        Me.txtPrecio3.BackColor = System.Drawing.Color.DimGray
        Me.txtPrecio3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtPrecio3.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecio3.ForeColor = System.Drawing.Color.White
        Me.txtPrecio3.Location = New System.Drawing.Point(508, 227)
        Me.txtPrecio3.Name = "txtPrecio3"
        Me.txtPrecio3.Size = New System.Drawing.Size(215, 53)
        Me.txtPrecio3.TabIndex = 17
        Me.txtPrecio3.Text = "$00.00"
        Me.txtPrecio3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtPrecio2
        '
        Me.txtPrecio2.BackColor = System.Drawing.Color.DimGray
        Me.txtPrecio2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtPrecio2.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecio2.ForeColor = System.Drawing.Color.White
        Me.txtPrecio2.Location = New System.Drawing.Point(254, 227)
        Me.txtPrecio2.Name = "txtPrecio2"
        Me.txtPrecio2.Size = New System.Drawing.Size(215, 53)
        Me.txtPrecio2.TabIndex = 16
        Me.txtPrecio2.Text = "$00.00"
        Me.txtPrecio2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtPrecio1
        '
        Me.txtPrecio1.BackColor = System.Drawing.Color.DimGray
        Me.txtPrecio1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtPrecio1.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecio1.ForeColor = System.Drawing.Color.White
        Me.txtPrecio1.Location = New System.Drawing.Point(3, 227)
        Me.txtPrecio1.Name = "txtPrecio1"
        Me.txtPrecio1.Size = New System.Drawing.Size(215, 53)
        Me.txtPrecio1.TabIndex = 15
        Me.txtPrecio1.Text = "$00.00"
        Me.txtPrecio1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Boton4
        '
        Me.Boton4.BackColor = System.Drawing.Color.Transparent
        Me.Boton4.Font = New System.Drawing.Font("Arial", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Boton4.ForeColor = System.Drawing.Color.Black
        Me.Boton4.Image = Global.Mikrotik.My.Resources.Resources.Morado
        Me.Boton4.Location = New System.Drawing.Point(759, 2)
        Me.Boton4.Name = "Boton4"
        Me.Boton4.Size = New System.Drawing.Size(215, 215)
        Me.Boton4.TabIndex = 14
        Me.Boton4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Boton3
        '
        Me.Boton3.BackColor = System.Drawing.Color.Transparent
        Me.Boton3.Font = New System.Drawing.Font("Arial", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Boton3.ForeColor = System.Drawing.Color.Black
        Me.Boton3.Image = Global.Mikrotik.My.Resources.Resources.Amarillo
        Me.Boton3.Location = New System.Drawing.Point(508, 2)
        Me.Boton3.Name = "Boton3"
        Me.Boton3.Size = New System.Drawing.Size(215, 215)
        Me.Boton3.TabIndex = 13
        Me.Boton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Boton2
        '
        Me.Boton2.BackColor = System.Drawing.Color.Transparent
        Me.Boton2.Font = New System.Drawing.Font("Arial", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Boton2.ForeColor = System.Drawing.Color.Black
        Me.Boton2.Image = Global.Mikrotik.My.Resources.Resources.Rojo
        Me.Boton2.Location = New System.Drawing.Point(254, 2)
        Me.Boton2.Name = "Boton2"
        Me.Boton2.Size = New System.Drawing.Size(215, 215)
        Me.Boton2.TabIndex = 12
        Me.Boton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Boton1
        '
        Me.Boton1.BackColor = System.Drawing.Color.Transparent
        Me.Boton1.Font = New System.Drawing.Font("Arial", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Boton1.ForeColor = System.Drawing.Color.Black
        Me.Boton1.Image = Global.Mikrotik.My.Resources.Resources.Azul
        Me.Boton1.Location = New System.Drawing.Point(3, 2)
        Me.Boton1.Name = "Boton1"
        Me.Boton1.Size = New System.Drawing.Size(215, 215)
        Me.Boton1.TabIndex = 11
        Me.Boton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Datos
        '
        Me.Datos.Controls.Add(Me.txtConteo)
        Me.Datos.Controls.Add(Me.txtPassword)
        Me.Datos.Controls.Add(Me.txtUsuario)
        Me.Datos.Controls.Add(Me.lblPassword)
        Me.Datos.Controls.Add(Me.lblUsuario)
        Me.Datos.Location = New System.Drawing.Point(297, 272)
        Me.Datos.Name = "Datos"
        Me.Datos.Size = New System.Drawing.Size(560, 181)
        Me.Datos.TabIndex = 11
        Me.Datos.Visible = False
        '
        'txtConteo
        '
        Me.txtConteo.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConteo.ForeColor = System.Drawing.Color.DodgerBlue
        Me.txtConteo.Location = New System.Drawing.Point(3, 0)
        Me.txtConteo.Name = "txtConteo"
        Me.txtConteo.Size = New System.Drawing.Size(57, 44)
        Me.txtConteo.TabIndex = 8
        Me.txtConteo.Text = "0"
        Me.txtConteo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.txtConteo.Visible = False
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.White
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtPassword.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.ForeColor = System.Drawing.Color.Blue
        Me.txtPassword.Location = New System.Drawing.Point(225, 96)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(297, 51)
        Me.txtPassword.TabIndex = 7
        Me.txtPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtUsuario
        '
        Me.txtUsuario.BackColor = System.Drawing.Color.White
        Me.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtUsuario.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuario.ForeColor = System.Drawing.Color.Blue
        Me.txtUsuario.Location = New System.Drawing.Point(225, 29)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(297, 49)
        Me.txtUsuario.TabIndex = 6
        Me.txtUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.Location = New System.Drawing.Point(23, 103)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(196, 36)
        Me.lblPassword.TabIndex = 5
        Me.lblPassword.Text = "Contraseña: "
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuario.Location = New System.Drawing.Point(77, 35)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(142, 36)
        Me.lblUsuario.TabIndex = 4
        Me.lblUsuario.Text = "Usuario: "
        '
        'Cerrar
        '
        Me.Cerrar.BackColor = System.Drawing.Color.Transparent
        Me.Cerrar.Image = Global.Mikrotik.My.Resources.Resources.Cerrar
        Me.Cerrar.Location = New System.Drawing.Point(1109, 130)
        Me.Cerrar.Name = "Cerrar"
        Me.Cerrar.Size = New System.Drawing.Size(50, 50)
        Me.Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Cerrar.TabIndex = 12
        Me.Cerrar.TabStop = False
        '
        'Fecha
        '
        Me.Fecha.Enabled = True
        Me.Fecha.Interval = 1000
        '
        'Desconectado
        '
        Me.Desconectado.BackColor = System.Drawing.Color.Transparent
        Me.Desconectado.Image = Global.Mikrotik.My.Resources.Resources.Desconectado
        Me.Desconectado.Location = New System.Drawing.Point(15, 138)
        Me.Desconectado.Name = "Desconectado"
        Me.Desconectado.Size = New System.Drawing.Size(100, 100)
        Me.Desconectado.TabIndex = 13
        Me.Desconectado.TabStop = False
        Me.Desconectado.Visible = False
        '
        'TiempoVisualizacion
        '
        Me.TiempoVisualizacion.Interval = 1000
        '
        'MarcadeAgua
        '
        Me.MarcadeAgua.BackColor = System.Drawing.Color.Transparent
        Me.MarcadeAgua.Controls.Add(Me.Label1)
        Me.MarcadeAgua.Controls.Add(Me.Label4)
        Me.MarcadeAgua.Controls.Add(Me.PictureBox1)
        Me.MarcadeAgua.Location = New System.Drawing.Point(247, 142)
        Me.MarcadeAgua.Name = "MarcadeAgua"
        Me.MarcadeAgua.Size = New System.Drawing.Size(199, 50)
        Me.MarcadeAgua.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.LinkColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(49, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 18)
        Me.Label1.TabIndex = 4
        Me.Label1.TabStop = True
        Me.Label1.Text = "www.xcoru.com"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(45, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(152, 19)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "facebook.com/xcoru"
        Me.Label4.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Mikrotik.My.Resources.Resources.LOGO_100x100_No_Fondo
        Me.PictureBox1.Location = New System.Drawing.Point(5, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(37, 39)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Joystick
        '
        Me.Joystick.Enabled = True
        Me.Joystick.Interval = 10
        '
        'GUI_Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Mikrotik.My.Resources.Resources.Fondo_principal
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1200, 855)
        Me.Controls.Add(Me.MarcadeAgua)
        Me.Controls.Add(Me.Desconectado)
        Me.Controls.Add(Me.Cerrar)
        Me.Controls.Add(Me.Datos)
        Me.Controls.Add(Me.Botones)
        Me.Controls.Add(Me.P_Header)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "GUI_Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Monedero"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.P_Header.ResumeLayout(False)
        CType(Me.picLogotipo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Botones.ResumeLayout(False)
        Me.Datos.ResumeLayout(False)
        Me.Datos.PerformLayout()
        CType(Me.Cerrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Desconectado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MarcadeAgua.ResumeLayout(False)
        Me.MarcadeAgua.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents P_Header As Panel
    Friend WithEvents txtNombreEmpresa As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Creditos As Label
    Friend WithEvents Botones As Panel
    Friend WithEvents txtPrecio4 As Label
    Friend WithEvents txtPrecio3 As Label
    Friend WithEvents txtPrecio2 As Label
    Friend WithEvents txtPrecio1 As Label
    Friend WithEvents Boton4 As Label
    Friend WithEvents Boton3 As Label
    Friend WithEvents Boton2 As Label
    Friend WithEvents Boton1 As Label
    Friend WithEvents Datos As Panel
    Friend WithEvents txtPassword As Label
    Friend WithEvents txtUsuario As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblUsuario As Label
    Friend WithEvents Cerrar As PictureBox
    Friend WithEvents Fecha As Timer
    Friend WithEvents Desconectado As PictureBox
    Friend WithEvents TiempoVisualizacion As Timer
    Friend WithEvents txtConteo As Label
    Friend WithEvents MarcadeAgua As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Joystick As Timer
    Friend WithEvents Label4 As Label
    Friend WithEvents picLogotipo As PictureBox
    Friend WithEvents Label1 As LinkLabel
End Class
