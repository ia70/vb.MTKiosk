<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PRUEBAS_API
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
        Me.btnTerminarConexion = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnTest = New System.Windows.Forms.Button()
        Me.btnEnviar = New System.Windows.Forms.Button()
        Me.txtComando = New System.Windows.Forms.TextBox()
        Me.txtLog = New System.Windows.Forms.TextBox()
        Me.btnIniciar = New System.Windows.Forms.Button()
        Me.txtIP = New System.Windows.Forms.TextBox()
        Me.txtPuerto = New System.Windows.Forms.TextBox()
        Me.IPfdgdf = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnTerminarConexion
        '
        Me.btnTerminarConexion.Location = New System.Drawing.Point(18, 78)
        Me.btnTerminarConexion.Name = "btnTerminarConexion"
        Me.btnTerminarConexion.Size = New System.Drawing.Size(112, 29)
        Me.btnTerminarConexion.TabIndex = 13
        Me.btnTerminarConexion.Text = "Terminar Conexión"
        Me.btnTerminarConexion.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(683, 34)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(100, 29)
        Me.btnLimpiar.TabIndex = 12
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnTest
        '
        Me.btnTest.Location = New System.Drawing.Point(352, 34)
        Me.btnTest.Name = "btnTest"
        Me.btnTest.Size = New System.Drawing.Size(100, 29)
        Me.btnTest.TabIndex = 11
        Me.btnTest.Text = "Test"
        Me.btnTest.UseVisualStyleBackColor = True
        '
        'btnEnviar
        '
        Me.btnEnviar.Location = New System.Drawing.Point(246, 34)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(100, 29)
        Me.btnEnviar.TabIndex = 10
        Me.btnEnviar.Text = "Enviar"
        Me.btnEnviar.UseVisualStyleBackColor = True
        '
        'txtComando
        '
        Me.txtComando.Location = New System.Drawing.Point(246, 69)
        Me.txtComando.Multiline = True
        Me.txtComando.Name = "txtComando"
        Me.txtComando.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtComando.Size = New System.Drawing.Size(537, 70)
        Me.txtComando.TabIndex = 9
        '
        'txtLog
        '
        Me.txtLog.Location = New System.Drawing.Point(246, 154)
        Me.txtLog.Multiline = True
        Me.txtLog.Name = "txtLog"
        Me.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtLog.Size = New System.Drawing.Size(537, 263)
        Me.txtLog.TabIndex = 8
        '
        'btnIniciar
        '
        Me.btnIniciar.Location = New System.Drawing.Point(18, 43)
        Me.btnIniciar.Name = "btnIniciar"
        Me.btnIniciar.Size = New System.Drawing.Size(112, 29)
        Me.btnIniciar.TabIndex = 7
        Me.btnIniciar.Text = "Iniciar conexion"
        Me.btnIniciar.UseVisualStyleBackColor = True
        '
        'txtIP
        '
        Me.txtIP.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIP.Location = New System.Drawing.Point(34, 166)
        Me.txtIP.Name = "txtIP"
        Me.txtIP.Size = New System.Drawing.Size(148, 29)
        Me.txtIP.TabIndex = 14
        Me.txtIP.Text = "192.168.1.119"
        Me.txtIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPuerto
        '
        Me.txtPuerto.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPuerto.Location = New System.Drawing.Point(34, 239)
        Me.txtPuerto.Name = "txtPuerto"
        Me.txtPuerto.Size = New System.Drawing.Size(148, 29)
        Me.txtPuerto.TabIndex = 15
        Me.txtPuerto.Text = "22"
        Me.txtPuerto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'IPfdgdf
        '
        Me.IPfdgdf.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.IPfdgdf.Font = New System.Drawing.Font("Arial Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IPfdgdf.ForeColor = System.Drawing.Color.White
        Me.IPfdgdf.Location = New System.Drawing.Point(34, 139)
        Me.IPfdgdf.Name = "IPfdgdf"
        Me.IPfdgdf.Size = New System.Drawing.Size(148, 24)
        Me.IPfdgdf.TabIndex = 16
        Me.IPfdgdf.Text = "IP"
        Me.IPfdgdf.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(34, 212)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 24)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Puerto"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PRUEBAS_API
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.IPfdgdf)
        Me.Controls.Add(Me.txtPuerto)
        Me.Controls.Add(Me.txtIP)
        Me.Controls.Add(Me.btnTerminarConexion)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnTest)
        Me.Controls.Add(Me.btnEnviar)
        Me.Controls.Add(Me.txtComando)
        Me.Controls.Add(Me.txtLog)
        Me.Controls.Add(Me.btnIniciar)
        Me.Name = "PRUEBAS_API"
        Me.Text = "PRUEBAS_API"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnTerminarConexion As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnTest As Button
    Friend WithEvents btnEnviar As Button
    Friend WithEvents txtComando As TextBox
    Friend WithEvents txtLog As TextBox
    Friend WithEvents btnIniciar As Button
    Friend WithEvents txtIP As TextBox
    Friend WithEvents txtPuerto As TextBox
    Friend WithEvents IPfdgdf As Label
    Friend WithEvents Label1 As Label
End Class
