<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDashboard
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AccountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogInToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnCategories = New System.Windows.Forms.Button()
        Me.btnItems = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.btnSuppliers = New System.Windows.Forms.Button()
        Me.FrmControlGuest1 = New InventorySystem.frmControlGuest()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AccountToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 33)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AccountToolStripMenuItem
        '
        Me.AccountToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogInToolStripMenuItem, Me.LogOutToolStripMenuItem})
        Me.AccountToolStripMenuItem.Name = "AccountToolStripMenuItem"
        Me.AccountToolStripMenuItem.Size = New System.Drawing.Size(93, 29)
        Me.AccountToolStripMenuItem.Text = "Account"
        '
        'LogInToolStripMenuItem
        '
        Me.LogInToolStripMenuItem.Name = "LogInToolStripMenuItem"
        Me.LogInToolStripMenuItem.Size = New System.Drawing.Size(179, 34)
        Me.LogInToolStripMenuItem.Text = "Log In"
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(179, 34)
        Me.LogOutToolStripMenuItem.Text = "Log Out"
        '
        'btnCategories
        '
        Me.btnCategories.Location = New System.Drawing.Point(231, 99)
        Me.btnCategories.Name = "btnCategories"
        Me.btnCategories.Size = New System.Drawing.Size(141, 105)
        Me.btnCategories.TabIndex = 1
        Me.btnCategories.Text = "Categories"
        Me.btnCategories.UseVisualStyleBackColor = True
        '
        'btnItems
        '
        Me.btnItems.Location = New System.Drawing.Point(45, 99)
        Me.btnItems.Name = "btnItems"
        Me.btnItems.Size = New System.Drawing.Size(141, 105)
        Me.btnItems.TabIndex = 2
        Me.btnItems.Text = "Items"
        Me.btnItems.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(416, 99)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(141, 105)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Employees"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(45, 264)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(141, 105)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "Users"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'btnSuppliers
        '
        Me.btnSuppliers.Location = New System.Drawing.Point(231, 264)
        Me.btnSuppliers.Name = "btnSuppliers"
        Me.btnSuppliers.Size = New System.Drawing.Size(141, 105)
        Me.btnSuppliers.TabIndex = 5
        Me.btnSuppliers.Text = "Suppliers"
        Me.btnSuppliers.UseVisualStyleBackColor = True
        '
        'FrmControlGuest1
        '
        Me.FrmControlGuest1.Location = New System.Drawing.Point(0, 36)
        Me.FrmControlGuest1.Name = "FrmControlGuest1"
        Me.FrmControlGuest1.Size = New System.Drawing.Size(800, 412)
        Me.FrmControlGuest1.TabIndex = 6
        '
        'frmDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.FrmControlGuest1)
        Me.Controls.Add(Me.btnSuppliers)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btnItems)
        Me.Controls.Add(Me.btnCategories)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmDashboard"
        Me.Text = "frmDashboard"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AccountToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogInToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnCategories As Button
    Friend WithEvents btnItems As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents btnSuppliers As Button
    Friend WithEvents FrmControlGuest1 As frmControlGuest
End Class
