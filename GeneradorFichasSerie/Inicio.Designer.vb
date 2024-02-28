<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inicio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inicio))
        Me.Panel_Body = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtActivacion = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnFecha = New System.Windows.Forms.RadioButton()
        Me.btnLibre = New System.Windows.Forms.RadioButton()
        Me.Calendario = New System.Windows.Forms.MonthCalendar()
        Me.txtSolicitud = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnGenerar = New System.Windows.Forms.Button()
        Me.Panel_Header = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel_Body.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel_Header.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel_Body
        '
        Me.Panel_Body.BackColor = System.Drawing.Color.AliceBlue
        Me.Panel_Body.Controls.Add(Me.Label4)
        Me.Panel_Body.Controls.Add(Me.Label5)
        Me.Panel_Body.Controls.Add(Me.txtActivacion)
        Me.Panel_Body.Controls.Add(Me.Label3)
        Me.Panel_Body.Controls.Add(Me.GroupBox1)
        Me.Panel_Body.Controls.Add(Me.txtSolicitud)
        Me.Panel_Body.Controls.Add(Me.Label2)
        Me.Panel_Body.Controls.Add(Me.btnLimpiar)
        Me.Panel_Body.Controls.Add(Me.btnGenerar)
        Me.Panel_Body.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Body.Location = New System.Drawing.Point(0, 32)
        Me.Panel_Body.Name = "Panel_Body"
        Me.Panel_Body.Size = New System.Drawing.Size(805, 444)
        Me.Panel_Body.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.PowderBlue
        Me.Label4.Location = New System.Drawing.Point(31, 84)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(349, 29)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Caducidad"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.PowderBlue
        Me.Label5.Location = New System.Drawing.Point(425, 227)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(349, 29)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Código de activación"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtActivacion
        '
        Me.txtActivacion.BackColor = System.Drawing.Color.MintCream
        Me.txtActivacion.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtActivacion.Location = New System.Drawing.Point(425, 259)
        Me.txtActivacion.MaxLength = 500
        Me.txtActivacion.Multiline = True
        Me.txtActivacion.Name = "txtActivacion"
        Me.txtActivacion.ReadOnly = True
        Me.txtActivacion.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtActivacion.Size = New System.Drawing.Size(349, 97)
        Me.txtActivacion.TabIndex = 20
        Me.txtActivacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.PowderBlue
        Me.Label3.Location = New System.Drawing.Point(425, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(349, 29)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Código de solicitud"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox1.Controls.Add(Me.btnFecha)
        Me.GroupBox1.Controls.Add(Me.btnLibre)
        Me.GroupBox1.Controls.Add(Me.Calendario)
        Me.GroupBox1.Location = New System.Drawing.Point(35, 91)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(342, 264)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Caducidad"
        '
        'btnFecha
        '
        Me.btnFecha.AutoSize = True
        Me.btnFecha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnFecha.Location = New System.Drawing.Point(64, 41)
        Me.btnFecha.Name = "btnFecha"
        Me.btnFecha.Size = New System.Drawing.Size(81, 26)
        Me.btnFecha.TabIndex = 2
        Me.btnFecha.Text = "Fecha"
        Me.btnFecha.UseVisualStyleBackColor = True
        '
        'btnLibre
        '
        Me.btnLibre.AutoSize = True
        Me.btnLibre.Checked = True
        Me.btnLibre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnLibre.Location = New System.Drawing.Point(174, 41)
        Me.btnLibre.Name = "btnLibre"
        Me.btnLibre.Size = New System.Drawing.Size(71, 26)
        Me.btnLibre.TabIndex = 1
        Me.btnLibre.TabStop = True
        Me.btnLibre.Text = "Libre"
        Me.btnLibre.UseVisualStyleBackColor = True
        '
        'Calendario
        '
        Me.Calendario.Enabled = False
        Me.Calendario.Location = New System.Drawing.Point(53, 79)
        Me.Calendario.MaxDate = New Date(2100, 1, 1, 0, 0, 0, 0)
        Me.Calendario.MaxSelectionCount = 1
        Me.Calendario.MinDate = New Date(2018, 1, 1, 0, 0, 0, 0)
        Me.Calendario.Name = "Calendario"
        Me.Calendario.TabIndex = 0
        '
        'txtSolicitud
        '
        Me.txtSolicitud.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSolicitud.Location = New System.Drawing.Point(425, 116)
        Me.txtSolicitud.MaxLength = 500
        Me.txtSolicitud.Multiline = True
        Me.txtSolicitud.Name = "txtSolicitud"
        Me.txtSolicitud.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtSolicitud.Size = New System.Drawing.Size(349, 97)
        Me.txtSolicitud.TabIndex = 17
        Me.txtSolicitud.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(150, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(499, 36)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Generador de código de activación"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnLimpiar.Location = New System.Drawing.Point(425, 381)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(103, 45)
        Me.btnLimpiar.TabIndex = 15
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'btnGenerar
        '
        Me.btnGenerar.BackColor = System.Drawing.Color.LightGreen
        Me.btnGenerar.Location = New System.Drawing.Point(563, 381)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(211, 45)
        Me.btnGenerar.TabIndex = 13
        Me.btnGenerar.Text = "Generar activación"
        Me.btnGenerar.UseVisualStyleBackColor = False
        '
        'Panel_Header
        '
        Me.Panel_Header.Controls.Add(Me.Label1)
        Me.Panel_Header.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Header.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Header.Name = "Panel_Header"
        Me.Panel_Header.Size = New System.Drawing.Size(805, 32)
        Me.Panel_Header.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(805, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(805, 476)
        Me.Controls.Add(Me.Panel_Body)
        Me.Controls.Add(Me.Panel_Header)
        Me.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.MaximizeBox = False
        Me.Name = "Inicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Generar Activación"
        Me.Panel_Body.ResumeLayout(False)
        Me.Panel_Body.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel_Header.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel_Body As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnGenerar As Button
    Friend WithEvents Panel_Header As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtSolicitud As TextBox
    Friend WithEvents Calendario As MonthCalendar
    Friend WithEvents btnFecha As RadioButton
    Friend WithEvents btnLibre As RadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents txtActivacion As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
