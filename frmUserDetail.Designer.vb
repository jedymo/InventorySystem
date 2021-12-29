<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUserDetail
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtPhoneNumber = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbRole = New System.Windows.Forms.ComboBox()
        Me.InventoryDataSet = New InventorySystem.inventoryDataSet()
        Me.RolesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RolesTableAdapter = New InventorySystem.inventoryDataSetTableAdapters.rolesTableAdapter()
        Me.gbStatus = New System.Windows.Forms.GroupBox()
        Me.rbActive = New System.Windows.Forms.RadioButton()
        Me.rbInavtive = New System.Windows.Forms.RadioButton()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.UsersTableAdapter1 = New InventorySystem.inventoryDataSetTableAdapters.usersTableAdapter()
        CType(Me.InventoryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RolesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbStatus.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(205, 122)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username"
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(414, 116)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(168, 26)
        Me.txtUsername.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(205, 170)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Password"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(414, 170)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(168, 26)
        Me.txtPassword.TabIndex = 3
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.Location = New System.Drawing.Point(414, 222)
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.Size = New System.Drawing.Size(168, 26)
        Me.txtPhoneNumber.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(205, 222)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Phone Number"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(205, 291)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Role"
        '
        'cmbRole
        '
        Me.cmbRole.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.RolesBindingSource, "id", True))
        Me.cmbRole.DataSource = Me.RolesBindingSource
        Me.cmbRole.DisplayMember = "name"
        Me.cmbRole.FormattingEnabled = True
        Me.cmbRole.Location = New System.Drawing.Point(414, 283)
        Me.cmbRole.Name = "cmbRole"
        Me.cmbRole.Size = New System.Drawing.Size(173, 28)
        Me.cmbRole.TabIndex = 7
        Me.cmbRole.ValueMember = "id"
        '
        'InventoryDataSet
        '
        Me.InventoryDataSet.DataSetName = "inventoryDataSet"
        Me.InventoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RolesBindingSource
        '
        Me.RolesBindingSource.DataMember = "roles"
        Me.RolesBindingSource.DataSource = Me.InventoryDataSet
        '
        'RolesTableAdapter
        '
        Me.RolesTableAdapter.ClearBeforeFill = True
        '
        'gbStatus
        '
        Me.gbStatus.Controls.Add(Me.rbInavtive)
        Me.gbStatus.Controls.Add(Me.rbActive)
        Me.gbStatus.Location = New System.Drawing.Point(209, 337)
        Me.gbStatus.Name = "gbStatus"
        Me.gbStatus.Size = New System.Drawing.Size(378, 77)
        Me.gbStatus.TabIndex = 8
        Me.gbStatus.TabStop = False
        Me.gbStatus.Text = "Status"
        '
        'rbActive
        '
        Me.rbActive.AutoSize = True
        Me.rbActive.Checked = True
        Me.rbActive.Location = New System.Drawing.Point(72, 34)
        Me.rbActive.Name = "rbActive"
        Me.rbActive.Size = New System.Drawing.Size(77, 24)
        Me.rbActive.TabIndex = 0
        Me.rbActive.TabStop = True
        Me.rbActive.Text = "Active"
        Me.rbActive.UseVisualStyleBackColor = True
        '
        'rbInavtive
        '
        Me.rbInavtive.AutoSize = True
        Me.rbInavtive.Location = New System.Drawing.Point(205, 34)
        Me.rbInavtive.Name = "rbInavtive"
        Me.rbInavtive.Size = New System.Drawing.Size(89, 24)
        Me.rbInavtive.TabIndex = 1
        Me.rbInavtive.Text = "Inactive"
        Me.rbInavtive.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(367, 437)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(91, 32)
        Me.btnSave.TabIndex = 9
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'UsersTableAdapter1
        '
        Me.UsersTableAdapter1.ClearBeforeFill = True
        '
        'frmUserDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 502)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.gbStatus)
        Me.Controls.Add(Me.cmbRole)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtPhoneNumber)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmUserDetail"
        Me.Text = "frmUserDetail"
        CType(Me.InventoryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RolesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbStatus.ResumeLayout(False)
        Me.gbStatus.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtPhoneNumber As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbRole As ComboBox
    Friend WithEvents InventoryDataSet As inventoryDataSet
    Friend WithEvents RolesBindingSource As BindingSource
    Friend WithEvents RolesTableAdapter As inventoryDataSetTableAdapters.rolesTableAdapter
    Friend WithEvents gbStatus As GroupBox
    Friend WithEvents rbInavtive As RadioButton
    Friend WithEvents rbActive As RadioButton
    Friend WithEvents btnSave As Button
    Friend WithEvents UsersTableAdapter1 As inventoryDataSetTableAdapters.usersTableAdapter
End Class
