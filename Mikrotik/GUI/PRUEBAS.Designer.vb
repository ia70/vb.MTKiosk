<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PRUEBAS
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
        Me.btnIniciar = New System.Windows.Forms.Button()
        Me.txtLog = New System.Windows.Forms.TextBox()
        Me.txtComando = New System.Windows.Forms.TextBox()
        Me.btnEnviar = New System.Windows.Forms.Button()
        Me.btnTerminarComando = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnTerminarConexion = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnIniciar
        '
        Me.btnIniciar.Location = New System.Drawing.Point(38, 28)
        Me.btnIniciar.Name = "btnIniciar"
        Me.btnIniciar.Size = New System.Drawing.Size(112, 29)
        Me.btnIniciar.TabIndex = 0
        Me.btnIniciar.Text = "Iniciar conexion"
        Me.btnIniciar.UseVisualStyleBackColor = True
        '
        'txtLog
        '
        Me.txtLog.Location = New System.Drawing.Point(266, 139)
        Me.txtLog.Multiline = True
        Me.txtLog.Name = "txtLog"
        Me.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtLog.Size = New System.Drawing.Size(537, 263)
        Me.txtLog.TabIndex = 1
        '
        'txtComando
        '
        Me.txtComando.Location = New System.Drawing.Point(266, 54)
        Me.txtComando.Multiline = True
        Me.txtComando.Name = "txtComando"
        Me.txtComando.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtComando.Size = New System.Drawing.Size(537, 70)
        Me.txtComando.TabIndex = 2
        '
        'btnEnviar
        '
        Me.btnEnviar.Location = New System.Drawing.Point(266, 19)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(100, 29)
        Me.btnEnviar.TabIndex = 3
        Me.btnEnviar.Text = "Enviar"
        Me.btnEnviar.UseVisualStyleBackColor = True
        '
        'btnTerminarComando
        '
        Me.btnTerminarComando.Location = New System.Drawing.Point(372, 19)
        Me.btnTerminarComando.Name = "btnTerminarComando"
        Me.btnTerminarComando.Size = New System.Drawing.Size(100, 29)
        Me.btnTerminarComando.TabIndex = 4
        Me.btnTerminarComando.Text = "Terminar"
        Me.btnTerminarComando.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(703, 19)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(100, 29)
        Me.btnLimpiar.TabIndex = 5
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnTerminarConexion
        '
        Me.btnTerminarConexion.Location = New System.Drawing.Point(38, 63)
        Me.btnTerminarConexion.Name = "btnTerminarConexion"
        Me.btnTerminarConexion.Size = New System.Drawing.Size(112, 29)
        Me.btnTerminarConexion.TabIndex = 6
        Me.btnTerminarConexion.Text = "Terminar Conexión"
        Me.btnTerminarConexion.UseVisualStyleBackColor = True
        '
        'PRUEBAS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(833, 423)
        Me.Controls.Add(Me.btnTerminarConexion)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnTerminarComando)
        Me.Controls.Add(Me.btnEnviar)
        Me.Controls.Add(Me.txtComando)
        Me.Controls.Add(Me.txtLog)
        Me.Controls.Add(Me.btnIniciar)
        Me.Name = "PRUEBAS"
        Me.Text = "PRUEBAS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnIniciar As Button
    Friend WithEvents txtLog As TextBox
    Friend WithEvents txtComando As TextBox
    Friend WithEvents btnEnviar As Button
    Friend WithEvents btnTerminarComando As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnTerminarConexion As Button
End Class
