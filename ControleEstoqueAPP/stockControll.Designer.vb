<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StockControll
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StockControll))
        Me.ProductData = New System.Windows.Forms.DataGridView()
        Me.TextBoxName = New System.Windows.Forms.TextBox()
        Me.TextBoxDescription = New System.Windows.Forms.TextBox()
        Me.TextBoxValue = New System.Windows.Forms.TextBox()
        Me.TextBoxAmount = New System.Windows.Forms.TextBox()
        Me.Name = New System.Windows.Forms.Label()
        Me.Description = New System.Windows.Forms.Label()
        Me.Amount = New System.Windows.Forms.Label()
        Me.ButtonUpdate = New System.Windows.Forms.Button()
        Me.ButtonCreate = New System.Windows.Forms.Button()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.TextBoxFindByName = New System.Windows.Forms.TextBox()
        Me.FindByName = New System.Windows.Forms.Label()
        Me.TextBoxFindById = New System.Windows.Forms.TextBox()
        Me.FindById = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.ProductData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProductData
        '
        Me.ProductData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ProductData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders
        Me.ProductData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProductData.GridColor = System.Drawing.SystemColors.AppWorkspace
        resources.ApplyResources(Me.ProductData, "ProductData")
        Me.ProductData.Name = "ProductData"
        '
        'TextBoxName
        '
        resources.ApplyResources(Me.TextBoxName, "TextBoxName")
        Me.TextBoxName.Name = "TextBoxName"
        '
        'TextBoxDescription
        '
        resources.ApplyResources(Me.TextBoxDescription, "TextBoxDescription")
        Me.TextBoxDescription.Name = "TextBoxDescription"
        '
        'TextBoxValue
        '
        resources.ApplyResources(Me.TextBoxValue, "TextBoxValue")
        Me.TextBoxValue.Name = "TextBoxValue"
        '
        'TextBoxAmount
        '
        resources.ApplyResources(Me.TextBoxAmount, "TextBoxAmount")
        Me.TextBoxAmount.Name = "TextBoxAmount"
        '
        'Name
        '
        resources.ApplyResources(Me.Name, "Name")
        Me.Name.Name = "Name"
        '
        'Description
        '
        resources.ApplyResources(Me.Description, "Description")
        Me.Description.Name = "Description"
        '
        'Amount
        '
        resources.ApplyResources(Me.Amount, "Amount")
        Me.Amount.Name = "Amount"
        '
        'ButtonUpdate
        '
        resources.ApplyResources(Me.ButtonUpdate, "ButtonUpdate")
        Me.ButtonUpdate.Name = "ButtonUpdate"
        Me.ButtonUpdate.UseVisualStyleBackColor = True
        '
        'ButtonCreate
        '
        resources.ApplyResources(Me.ButtonCreate, "ButtonCreate")
        Me.ButtonCreate.Name = "ButtonCreate"
        Me.ButtonCreate.UseVisualStyleBackColor = True
        '
        'ButtonDelete
        '
        resources.ApplyResources(Me.ButtonDelete, "ButtonDelete")
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.UseVisualStyleBackColor = True
        '
        'TextBoxFindByName
        '
        resources.ApplyResources(Me.TextBoxFindByName, "TextBoxFindByName")
        Me.TextBoxFindByName.Name = "TextBoxFindByName"
        '
        'FindByName
        '
        resources.ApplyResources(Me.FindByName, "FindByName")
        Me.FindByName.Name = "FindByName"
        '
        'TextBoxFindById
        '
        resources.ApplyResources(Me.TextBoxFindById, "TextBoxFindById")
        Me.TextBoxFindById.Name = "TextBoxFindById"
        '
        'FindById
        '
        resources.ApplyResources(Me.FindById, "FindById")
        Me.FindById.Name = "FindById"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'StockControll
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.FindById)
        Me.Controls.Add(Me.TextBoxFindById)
        Me.Controls.Add(Me.FindByName)
        Me.Controls.Add(Me.TextBoxFindByName)
        Me.Controls.Add(Me.ButtonDelete)
        Me.Controls.Add(Me.ButtonCreate)
        Me.Controls.Add(Me.ButtonUpdate)
        Me.Controls.Add(Me.Amount)
        Me.Controls.Add(Me.Description)
        Me.Controls.Add(Me.Name)
        Me.Controls.Add(Me.TextBoxAmount)
        Me.Controls.Add(Me.TextBoxValue)
        Me.Controls.Add(Me.TextBoxDescription)
        Me.Controls.Add(Me.TextBoxName)
        Me.Controls.Add(Me.ProductData)
        CType(Me.ProductData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ProductData As DataGridView
    Friend WithEvents TextBoxName As TextBox
    Friend WithEvents TextBoxDescription As TextBox
    Friend WithEvents TextBoxValue As TextBox
    Friend WithEvents TextBoxAmount As TextBox
    Friend WithEvents Name As Label
    Friend WithEvents Description As Label
    Friend WithEvents Amount As Label
    Friend WithEvents ButtonUpdate As Button
    Friend WithEvents ButtonCreate As Button
    Friend WithEvents ButtonDelete As Button
    Friend WithEvents TextBoxFindByName As TextBox
    Friend WithEvents FindByName As Label
    Friend WithEvents TextBoxFindById As TextBox
    Friend WithEvents FindById As Label
    Friend WithEvents Label1 As Label
End Class
