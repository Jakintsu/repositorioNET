<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fichar
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
        Me.LblRol = New System.Windows.Forms.Label()
        Me.TxtRol = New System.Windows.Forms.TextBox()
        Me.BtnRol = New System.Windows.Forms.Button()
        Me.LblPassword = New System.Windows.Forms.Label()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'LblRol
        '
        Me.LblRol.AutoSize = True
        Me.LblRol.Font = New System.Drawing.Font("Microsoft PhagsPa", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRol.Location = New System.Drawing.Point(150, 83)
        Me.LblRol.Name = "LblRol"
        Me.LblRol.Size = New System.Drawing.Size(36, 21)
        Me.LblRol.TabIndex = 0
        Me.LblRol.Text = "Rol:"
        '
        'TxtRol
        '
        Me.TxtRol.Location = New System.Drawing.Point(198, 83)
        Me.TxtRol.Name = "TxtRol"
        Me.TxtRol.Size = New System.Drawing.Size(342, 20)
        Me.TxtRol.TabIndex = 1
        '
        'BtnRol
        '
        Me.BtnRol.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnRol.Location = New System.Drawing.Point(198, 186)
        Me.BtnRol.Name = "BtnRol"
        Me.BtnRol.Size = New System.Drawing.Size(211, 69)
        Me.BtnRol.TabIndex = 2
        Me.BtnRol.Text = "Entrar"
        Me.BtnRol.UseVisualStyleBackColor = True
        '
        'LblPassword
        '
        Me.LblPassword.AutoSize = True
        Me.LblPassword.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPassword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LblPassword.Location = New System.Drawing.Point(114, 120)
        Me.LblPassword.Name = "LblPassword"
        Me.LblPassword.Size = New System.Drawing.Size(83, 20)
        Me.LblPassword.TabIndex = 3
        Me.LblPassword.Text = "Password"
        '
        'TxtPassword
        '
        Me.TxtPassword.Location = New System.Drawing.Point(198, 120)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.Size = New System.Drawing.Size(342, 20)
        Me.TxtPassword.TabIndex = 4
        '
        'Fichar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TxtPassword)
        Me.Controls.Add(Me.LblPassword)
        Me.Controls.Add(Me.BtnRol)
        Me.Controls.Add(Me.TxtRol)
        Me.Controls.Add(Me.LblRol)
        Me.Name = "Fichar"
        Me.Text = "Sistema de Fichado"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblRol As Label
    Friend WithEvents TxtRol As TextBox
    Friend WithEvents BtnRol As Button
    Friend WithEvents LblPassword As Label
    Friend WithEvents TxtPassword As TextBox
End Class
