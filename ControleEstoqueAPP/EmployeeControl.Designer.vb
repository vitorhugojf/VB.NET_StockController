<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EmployeeControl
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EmployeeControl))
        Me.TextBoxFindById = New System.Windows.Forms.TextBox()
        Me.TextBoxFindByNameOrUsername = New System.Windows.Forms.TextBox()
        Me.EmployeeData = New System.Windows.Forms.DataGridView()
        Me.FindById = New System.Windows.Forms.Label()
        Me.FindByName = New System.Windows.Forms.Label()
        Me.ButtonStock = New System.Windows.Forms.Button()
        Me.ButtonCashFlow = New System.Windows.Forms.Button()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.ButtonCreate = New System.Windows.Forms.Button()
        Me.ButtonUpdate = New System.Windows.Forms.Button()
        Me.NameEmployee = New System.Windows.Forms.Label()
        Me.TextBoxUsername = New System.Windows.Forms.TextBox()
        Me.TextBoxName = New System.Windows.Forms.TextBox()
        Me.Username = New System.Windows.Forms.Label()
        Me.TextBoxPassword = New System.Windows.Forms.TextBox()
        Me.Password = New System.Windows.Forms.Label()
        Me.LastActive = New System.Windows.Forms.Label()
        Me.TextBoxLastActive = New System.Windows.Forms.TextBox()
        Me.JobRole = New System.Windows.Forms.Label()
        Me.ComboBoxJobRole = New System.Windows.Forms.ComboBox()
        CType(Me.EmployeeData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBoxFindById
        '
        Me.TextBoxFindById.Location = New System.Drawing.Point(8, 268)
        Me.TextBoxFindById.Name = "TextBoxFindById"
        Me.TextBoxFindById.Size = New System.Drawing.Size(131, 20)
        Me.TextBoxFindById.TabIndex = 21
        '
        'TextBoxFindByNameOrUsername
        '
        Me.TextBoxFindByNameOrUsername.Location = New System.Drawing.Point(145, 268)
        Me.TextBoxFindByNameOrUsername.Name = "TextBoxFindByNameOrUsername"
        Me.TextBoxFindByNameOrUsername.Size = New System.Drawing.Size(380, 20)
        Me.TextBoxFindByNameOrUsername.TabIndex = 20
        '
        'EmployeeData
        '
        Me.EmployeeData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.EmployeeData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders
        Me.EmployeeData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EmployeeData.GridColor = System.Drawing.SystemColors.AppWorkspace
        Me.EmployeeData.Location = New System.Drawing.Point(8, 294)
        Me.EmployeeData.Name = "EmployeeData"
        Me.EmployeeData.Size = New System.Drawing.Size(516, 221)
        Me.EmployeeData.TabIndex = 19
        '
        'FindById
        '
        Me.FindById.AutoSize = True
        Me.FindById.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.FindById.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.FindById.Location = New System.Drawing.Point(9, 249)
        Me.FindById.Name = "FindById"
        Me.FindById.Size = New System.Drawing.Size(74, 16)
        Me.FindById.TabIndex = 23
        Me.FindById.Text = "Find By Id"
        '
        'FindByName
        '
        Me.FindByName.AutoSize = True
        Me.FindByName.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.FindByName.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.FindByName.Location = New System.Drawing.Point(142, 246)
        Me.FindByName.Name = "FindByName"
        Me.FindByName.Size = New System.Drawing.Size(184, 16)
        Me.FindByName.TabIndex = 22
        Me.FindByName.Text = "Find By Name or Username"
        '
        'ButtonStock
        '
        Me.ButtonStock.BackColor = System.Drawing.SystemColors.Desktop
        Me.ButtonStock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ButtonStock.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonStock.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.ButtonStock.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ButtonStock.Location = New System.Drawing.Point(90, 8)
        Me.ButtonStock.Name = "ButtonStock"
        Me.ButtonStock.Size = New System.Drawing.Size(75, 23)
        Me.ButtonStock.TabIndex = 36
        Me.ButtonStock.Text = "Stock"
        Me.ButtonStock.UseVisualStyleBackColor = False
        '
        'ButtonCashFlow
        '
        Me.ButtonCashFlow.BackColor = System.Drawing.SystemColors.Desktop
        Me.ButtonCashFlow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ButtonCashFlow.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonCashFlow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCashFlow.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.ButtonCashFlow.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ButtonCashFlow.Location = New System.Drawing.Point(8, 8)
        Me.ButtonCashFlow.Name = "ButtonCashFlow"
        Me.ButtonCashFlow.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCashFlow.TabIndex = 35
        Me.ButtonCashFlow.Text = "Cash Flow"
        Me.ButtonCashFlow.UseVisualStyleBackColor = False
        '
        'ButtonDelete
        '
        Me.ButtonDelete.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ButtonDelete.Location = New System.Drawing.Point(412, 232)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(113, 30)
        Me.ButtonDelete.TabIndex = 33
        Me.ButtonDelete.Text = "Delete"
        Me.ButtonDelete.UseVisualStyleBackColor = True
        '
        'ButtonCreate
        '
        Me.ButtonCreate.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ButtonCreate.Location = New System.Drawing.Point(8, 188)
        Me.ButtonCreate.Name = "ButtonCreate"
        Me.ButtonCreate.Size = New System.Drawing.Size(113, 31)
        Me.ButtonCreate.TabIndex = 32
        Me.ButtonCreate.Text = "Create"
        Me.ButtonCreate.UseVisualStyleBackColor = True
        '
        'ButtonUpdate
        '
        Me.ButtonUpdate.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ButtonUpdate.Location = New System.Drawing.Point(127, 188)
        Me.ButtonUpdate.Name = "ButtonUpdate"
        Me.ButtonUpdate.Size = New System.Drawing.Size(113, 31)
        Me.ButtonUpdate.TabIndex = 31
        Me.ButtonUpdate.Text = "Update"
        Me.ButtonUpdate.UseVisualStyleBackColor = True
        '
        'NameEmployee
        '
        Me.NameEmployee.AutoSize = True
        Me.NameEmployee.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.NameEmployee.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.NameEmployee.Location = New System.Drawing.Point(6, 34)
        Me.NameEmployee.Name = "NameEmployee"
        Me.NameEmployee.Size = New System.Drawing.Size(44, 16)
        Me.NameEmployee.TabIndex = 28
        Me.NameEmployee.Text = "Name"
        '
        'TextBoxUsername
        '
        Me.TextBoxUsername.Location = New System.Drawing.Point(9, 105)
        Me.TextBoxUsername.Name = "TextBoxUsername"
        Me.TextBoxUsername.Size = New System.Drawing.Size(250, 20)
        Me.TextBoxUsername.TabIndex = 25
        '
        'TextBoxName
        '
        Me.TextBoxName.Location = New System.Drawing.Point(9, 53)
        Me.TextBoxName.Name = "TextBoxName"
        Me.TextBoxName.Size = New System.Drawing.Size(516, 20)
        Me.TextBoxName.TabIndex = 24
        '
        'Username
        '
        Me.Username.AutoSize = True
        Me.Username.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Username.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Username.Location = New System.Drawing.Point(6, 86)
        Me.Username.Name = "Username"
        Me.Username.Size = New System.Drawing.Size(72, 16)
        Me.Username.TabIndex = 38
        Me.Username.Text = "Username"
        '
        'TextBoxPassword
        '
        Me.TextBoxPassword.Location = New System.Drawing.Point(275, 105)
        Me.TextBoxPassword.Name = "TextBoxPassword"
        Me.TextBoxPassword.Size = New System.Drawing.Size(250, 20)
        Me.TextBoxPassword.TabIndex = 39
        '
        'Password
        '
        Me.Password.AutoSize = True
        Me.Password.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Password.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Password.Location = New System.Drawing.Point(272, 86)
        Me.Password.Name = "Password"
        Me.Password.Size = New System.Drawing.Size(70, 16)
        Me.Password.TabIndex = 40
        Me.Password.Text = "Password"
        '
        'LastActive
        '
        Me.LastActive.AutoSize = True
        Me.LastActive.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.LastActive.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LastActive.Location = New System.Drawing.Point(271, 141)
        Me.LastActive.Name = "LastActive"
        Me.LastActive.Size = New System.Drawing.Size(83, 16)
        Me.LastActive.TabIndex = 44
        Me.LastActive.Text = "Last Active"
        '
        'TextBoxLastActive
        '
        Me.TextBoxLastActive.Location = New System.Drawing.Point(274, 160)
        Me.TextBoxLastActive.Name = "TextBoxLastActive"
        Me.TextBoxLastActive.ReadOnly = True
        Me.TextBoxLastActive.Size = New System.Drawing.Size(250, 20)
        Me.TextBoxLastActive.TabIndex = 43
        '
        'JobRole
        '
        Me.JobRole.AutoSize = True
        Me.JobRole.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.JobRole.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.JobRole.Location = New System.Drawing.Point(5, 141)
        Me.JobRole.Name = "JobRole"
        Me.JobRole.Size = New System.Drawing.Size(62, 16)
        Me.JobRole.TabIndex = 42
        Me.JobRole.Text = "Job Role"
        '
        'ComboBoxJobRole
        '
        Me.ComboBoxJobRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxJobRole.FormattingEnabled = True
        Me.ComboBoxJobRole.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ComboBoxJobRole.Items.AddRange(New Object() {"Admin", "Caixa"})
        Me.ComboBoxJobRole.Location = New System.Drawing.Point(9, 159)
        Me.ComboBoxJobRole.Name = "ComboBoxJobRole"
        Me.ComboBoxJobRole.Size = New System.Drawing.Size(250, 21)
        Me.ComboBoxJobRole.TabIndex = 45
        '
        'EmployeeControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(537, 527)
        Me.Controls.Add(Me.ComboBoxJobRole)
        Me.Controls.Add(Me.LastActive)
        Me.Controls.Add(Me.TextBoxLastActive)
        Me.Controls.Add(Me.JobRole)
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.TextBoxPassword)
        Me.Controls.Add(Me.Username)
        Me.Controls.Add(Me.ButtonStock)
        Me.Controls.Add(Me.ButtonCashFlow)
        Me.Controls.Add(Me.ButtonDelete)
        Me.Controls.Add(Me.ButtonCreate)
        Me.Controls.Add(Me.ButtonUpdate)
        Me.Controls.Add(Me.NameEmployee)
        Me.Controls.Add(Me.TextBoxUsername)
        Me.Controls.Add(Me.TextBoxName)
        Me.Controls.Add(Me.FindById)
        Me.Controls.Add(Me.FindByName)
        Me.Controls.Add(Me.TextBoxFindById)
        Me.Controls.Add(Me.TextBoxFindByNameOrUsername)
        Me.Controls.Add(Me.EmployeeData)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "EmployeeControl"
        Me.Text = "EmployeeControl"
        CType(Me.EmployeeData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxFindById As TextBox
    Friend WithEvents TextBoxFindByNameOrUsername As TextBox
    Friend WithEvents EmployeeData As DataGridView
    Friend WithEvents FindById As Label
    Friend WithEvents FindByName As Label
    Friend WithEvents ButtonStock As Button
    Friend WithEvents ButtonCashFlow As Button
    Friend WithEvents ButtonDelete As Button
    Friend WithEvents ButtonCreate As Button
    Friend WithEvents ButtonUpdate As Button
    Friend WithEvents NameEmployee As Label
    Friend WithEvents TextBoxUsername As TextBox
    Friend WithEvents TextBoxName As TextBox
    Friend WithEvents Username As Label
    Friend WithEvents TextBoxPassword As TextBox
    Friend WithEvents Password As Label
    Friend WithEvents LastActive As Label
    Friend WithEvents TextBoxLastActive As TextBox
    Friend WithEvents JobRole As Label
    Friend WithEvents ComboBoxJobRole As ComboBox
End Class
