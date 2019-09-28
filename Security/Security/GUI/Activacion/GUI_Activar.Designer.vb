<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GUI_Activar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GUI_Activar))
        Me.Panel_Body = New System.Windows.Forms.Panel()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnActivar = New System.Windows.Forms.Button()
        Me.txtRespuesta = New System.Windows.Forms.TextBox()
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
        Me.Panel_Body.Controls.Add(Me.btnActivar)
        Me.Panel_Body.Controls.Add(Me.txtRespuesta)
        Me.Panel_Body.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Body.Location = New System.Drawing.Point(0, 61)
        Me.Panel_Body.Name = "Panel_Body"
        Me.Panel_Body.Size = New System.Drawing.Size(451, 252)
        Me.Panel_Body.TabIndex = 9
        '
        'btnAtras
        '
        Me.btnAtras.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAtras.Location = New System.Drawing.Point(48, 187)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(114, 45)
        Me.btnAtras.TabIndex = 17
        Me.btnAtras.Text = "Atras"
        Me.btnAtras.UseVisualStyleBackColor = False
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnLimpiar.Location = New System.Drawing.Point(167, 187)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(114, 45)
        Me.btnLimpiar.TabIndex = 15
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'btnActivar
        '
        Me.btnActivar.BackColor = System.Drawing.Color.LightGreen
        Me.btnActivar.Location = New System.Drawing.Point(286, 187)
        Me.btnActivar.Name = "btnActivar"
        Me.btnActivar.Size = New System.Drawing.Size(114, 45)
        Me.btnActivar.TabIndex = 13
        Me.btnActivar.Text = "Activar"
        Me.btnActivar.UseVisualStyleBackColor = False
        '
        'txtRespuesta
        '
        Me.txtRespuesta.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRespuesta.Location = New System.Drawing.Point(20, 25)
        Me.txtRespuesta.MaxLength = 500
        Me.txtRespuesta.Multiline = True
        Me.txtRespuesta.Name = "txtRespuesta"
        Me.txtRespuesta.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtRespuesta.Size = New System.Drawing.Size(411, 142)
        Me.txtRespuesta.TabIndex = 4
        Me.txtRespuesta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel_Header
        '
        Me.Panel_Header.Controls.Add(Me.Label1)
        Me.Panel_Header.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Header.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Header.Name = "Panel_Header"
        Me.Panel_Header.Size = New System.Drawing.Size(451, 61)
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
        Me.Label1.Size = New System.Drawing.Size(451, 61)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Activación"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GUI_Activar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(451, 313)
        Me.Controls.Add(Me.Panel_Body)
        Me.Controls.Add(Me.Panel_Header)
        Me.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "GUI_Activar"
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
    Friend WithEvents btnActivar As Windows.Forms.Button
    Friend WithEvents txtRespuesta As Windows.Forms.TextBox
    Friend WithEvents Panel_Header As Windows.Forms.Panel
    Friend WithEvents Label1 As Windows.Forms.Label
End Class
