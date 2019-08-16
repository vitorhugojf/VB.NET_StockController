<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.TextBoxUsername = New System.Windows.Forms.TextBox()
        Me.TextBoxPassword = New System.Windows.Forms.TextBox()
        Me.Username = New System.Windows.Forms.Label()
        Me.Password = New System.Windows.Forms.Label()
        Me.ButtonLogin = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBoxUsername
        '
        Me.TextBoxUsername.Location = New System.Drawing.Point(40, 58)
        Me.TextBoxUsername.Name = "TextBoxUsername"
        Me.TextBoxUsername.Size = New System.Drawing.Size(405, 20)
        Me.TextBoxUsername.TabIndex = 15
        '
        'TextBoxPassword
        '
        Me.TextBoxPassword.Location = New System.Drawing.Point(40, 110)
        Me.TextBoxPassword.Name = "TextBoxPassword"
        Me.TextBoxPassword.Size = New System.Drawing.Size(405, 20)
        Me.TextBoxPassword.TabIndex = 17
        Me.TextBoxPassword.UseSystemPasswordChar = True
        '
        'Username
        '
        Me.Username.AutoSize = True
        Me.Username.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Username.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Username.Location = New System.Drawing.Point(37, 39)
        Me.Username.Name = "Username"
        Me.Username.Size = New System.Drawing.Size(72, 16)
        Me.Username.TabIndex = 18
        Me.Username.Text = "Username"
        '
        'Password
        '
        Me.Password.AutoSize = True
        Me.Password.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Password.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Password.Location = New System.Drawing.Point(37, 91)
        Me.Password.Name = "Password"
        Me.Password.Size = New System.Drawing.Size(70, 16)
        Me.Password.TabIndex = 19
        Me.Password.Text = "Password"
        '
        'ButtonLogin
        '
        Me.ButtonLogin.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ButtonLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ButtonLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.ButtonLogin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ButtonLogin.Location = New System.Drawing.Point(199, 164)
        Me.ButtonLogin.Name = "ButtonLogin"
        Me.ButtonLogin.Size = New System.Drawing.Size(96, 59)
        Me.ButtonLogin.TabIndex = 20
        Me.ButtonLogin.Text = "Login"
        Me.ButtonLogin.UseVisualStyleBackColor = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(481, 367)
        Me.Controls.Add(Me.ButtonLogin)
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.Username)
        Me.Controls.Add(Me.TextBoxPassword)
        Me.Controls.Add(Me.TextBoxUsername)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Login"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBoxUsername As TextBox
    Friend WithEvents TextBoxPassword As TextBox
    Friend WithEvents Username As Label
    Friend WithEvents Password As Label
    Friend WithEvents ButtonLogin As Button
End Class
