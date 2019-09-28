<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GUI_NoActivado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GUI_NoActivado))
        Me.Panel_Body = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnGenerarSolicitud = New System.Windows.Forms.Button()
        Me.btnActivar = New System.Windows.Forms.Button()
        Me.Panel_Header = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel_Body.SuspendLayout()
        Me.Panel_Header.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel_Body
        '
        Me.Panel_Body.BackColor = System.Drawing.Color.AliceBlue
        Me.Panel_Body.Controls.Add(Me.Label3)
        Me.Panel_Body.Controls.Add(Me.Label2)
        Me.Panel_Body.Controls.Add(Me.btnGenerarSolicitud)
        Me.Panel_Body.Controls.Add(Me.btnActivar)
        Me.Panel_Body.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Body.Location = New System.Drawing.Point(0, 32)
        Me.Panel_Body.Name = "Panel_Body"
        Me.Panel_Body.Size = New System.Drawing.Size(493, 325)
        Me.Panel_Body.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(35, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(442, 122)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = resources.GetString("Label3.Text")
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(110, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(245, 27)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Producto no activado."
        '
        'btnGenerarSolicitud
        '
        Me.btnGenerarSolicitud.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnGenerarSolicitud.Location = New System.Drawing.Point(71, 257)
        Me.btnGenerarSolicitud.Name = "btnGenerarSolicitud"
        Me.btnGenerarSolicitud.Size = New System.Drawing.Size(198, 45)
        Me.btnGenerarSolicitud.TabIndex = 15
        Me.btnGenerarSolicitud.Text = "Generar solicitud"
        Me.btnGenerarSolicitud.UseVisualStyleBackColor = False
        '
        'btnActivar
        '
        Me.btnActivar.BackColor = System.Drawing.Color.LightGreen
        Me.btnActivar.Location = New System.Drawing.Point(299, 257)
        Me.btnActivar.Name = "btnActivar"
        Me.btnActivar.Size = New System.Drawing.Size(114, 45)
        Me.btnActivar.TabIndex = 13
        Me.btnActivar.Text = "Activar"
        Me.btnActivar.UseVisualStyleBackColor = False
        '
        'Panel_Header
        '
        Me.Panel_Header.Controls.Add(Me.Label1)
        Me.Panel_Header.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Header.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Header.Name = "Panel_Header"
        Me.Panel_Header.Size = New System.Drawing.Size(493, 32)
        Me.Panel_Header.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.SteelBlue
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(493, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GUI_NoActivado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(493, 357)
        Me.Controls.Add(Me.Panel_Body)
        Me.Controls.Add(Me.Panel_Header)
        Me.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "GUI_NoActivado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Activación"
        Me.Panel_Body.ResumeLayout(False)
        Me.Panel_Body.PerformLayout()
        Me.Panel_Header.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel_Body As Windows.Forms.Panel
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents btnGenerarSolicitud As Windows.Forms.Button
    Friend WithEvents btnActivar As Windows.Forms.Button
    Friend WithEvents Panel_Header As Windows.Forms.Panel
    Friend WithEvents Label1 As Windows.Forms.Label
End Class
