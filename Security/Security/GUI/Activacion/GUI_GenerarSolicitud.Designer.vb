<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GUI_GenerarSolicitud
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GUI_GenerarSolicitud))
        Me.Panel_Body = New System.Windows.Forms.Panel()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnGenerar = New System.Windows.Forms.Button()
        Me.txtSolicitud = New System.Windows.Forms.TextBox()
        Me.Panel_Header = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel_Body.SuspendLayout()
        Me.Panel_Header.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel_Body
        '
        Me.Panel_Body.BackColor = System.Drawing.Color.AliceBlue
        Me.Panel_Body.Controls.Add(Me.btnAtras)
        Me.Panel_Body.Controls.Add(Me.btnLimpiar)
        Me.Panel_Body.Controls.Add(Me.btnGenerar)
        Me.Panel_Body.Controls.Add(Me.txtSolicitud)
        Me.Panel_Body.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Body.Location = New System.Drawing.Point(0, 61)
        Me.Panel_Body.Name = "Panel_Body"
        Me.Panel_Body.Size = New System.Drawing.Size(435, 245)
        Me.Panel_Body.TabIndex = 9
        '
        'btnAtras
        '
        Me.btnAtras.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAtras.Location = New System.Drawing.Point(44, 178)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(114, 45)
        Me.btnAtras.TabIndex = 16
        Me.btnAtras.Text = "Atras"
        Me.btnAtras.UseVisualStyleBackColor = False
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnLimpiar.Location = New System.Drawing.Point(163, 178)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(114, 45)
        Me.btnLimpiar.TabIndex = 15
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'btnGenerar
        '
        Me.btnGenerar.BackColor = System.Drawing.Color.LightGreen
        Me.btnGenerar.Location = New System.Drawing.Point(281, 178)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(112, 45)
        Me.btnGenerar.TabIndex = 13
        Me.btnGenerar.Text = "Generar"
        Me.btnGenerar.UseVisualStyleBackColor = False
        '
        'txtSolicitud
        '
        Me.txtSolicitud.Enabled = False
        Me.txtSolicitud.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSolicitud.Location = New System.Drawing.Point(20, 25)
        Me.txtSolicitud.MaxLength = 500
        Me.txtSolicitud.Multiline = True
        Me.txtSolicitud.Name = "txtSolicitud"
        Me.txtSolicitud.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtSolicitud.Size = New System.Drawing.Size(394, 135)
        Me.txtSolicitud.TabIndex = 4
        Me.txtSolicitud.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel_Header
        '
        Me.Panel_Header.Controls.Add(Me.Label1)
        Me.Panel_Header.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Header.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Header.Name = "Panel_Header"
        Me.Panel_Header.Size = New System.Drawing.Size(435, 61)
        Me.Panel_Header.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.SteelBlue
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(435, 61)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Generar solicitud"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GUI_GenerarSolicitud
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(435, 306)
        Me.Controls.Add(Me.Panel_Body)
        Me.Controls.Add(Me.Panel_Header)
        Me.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "GUI_GenerarSolicitud"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Activar producto"
        Me.Panel_Body.ResumeLayout(False)
        Me.Panel_Body.PerformLayout()
        Me.Panel_Header.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel_Body As Windows.Forms.Panel
    Friend WithEvents btnAtras As Windows.Forms.Button
    Friend WithEvents btnLimpiar As Windows.Forms.Button
    Friend WithEvents btnGenerar As Windows.Forms.Button
    Friend WithEvents txtSolicitud As Windows.Forms.TextBox
    Friend WithEvents Panel_Header As Windows.Forms.Panel
    Friend WithEvents Label1 As Windows.Forms.Label
End Class
