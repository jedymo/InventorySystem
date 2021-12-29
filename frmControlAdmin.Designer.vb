<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmControlAdmin
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.btnSuppliers = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnItems = New System.Windows.Forms.Button()
        Me.btnCategories = New System.Windows.Forms.Button()
        Me.btnInventoryStock = New System.Windows.Forms.Button()
        Me.btnJob = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnSuppliers
        '
        Me.btnSuppliers.Location = New System.Drawing.Point(272, 260)
        Me.btnSuppliers.Name = "btnSuppliers"
        Me.btnSuppliers.Size = New System.Drawing.Size(141, 105)
        Me.btnSuppliers.TabIndex = 10
        Me.btnSuppliers.Text = "Suppliers"
        Me.btnSuppliers.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(86, 260)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(141, 105)
        Me.Button4.TabIndex = 9
        Me.Button4.Text = "Users"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(457, 95)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(141, 105)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "Employees"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'btnItems
        '
        Me.btnItems.Location = New System.Drawing.Point(86, 95)
        Me.btnItems.Name = "btnItems"
        Me.btnItems.Size = New System.Drawing.Size(141, 105)
        Me.btnItems.TabIndex = 7
        Me.btnItems.Text = "Items"
        Me.btnItems.UseVisualStyleBackColor = True
        '
        'btnCategories
        '
        Me.btnCategories.Location = New System.Drawing.Point(272, 95)
        Me.btnCategories.Name = "btnCategories"
        Me.btnCategories.Size = New System.Drawing.Size(141, 105)
        Me.btnCategories.TabIndex = 6
        Me.btnCategories.Text = "Categories"
        Me.btnCategories.UseVisualStyleBackColor = True
        '
        'btnInventoryStock
        '
        Me.btnInventoryStock.Location = New System.Drawing.Point(457, 260)
        Me.btnInventoryStock.Name = "btnInventoryStock"
        Me.btnInventoryStock.Size = New System.Drawing.Size(141, 105)
        Me.btnInventoryStock.TabIndex = 11
        Me.btnInventoryStock.Text = "Inventory Stock"
        Me.btnInventoryStock.UseVisualStyleBackColor = True
        '
        'btnJob
        '
        Me.btnJob.Location = New System.Drawing.Point(655, 95)
        Me.btnJob.Name = "btnJob"
        Me.btnJob.Size = New System.Drawing.Size(141, 105)
        Me.btnJob.TabIndex = 12
        Me.btnJob.Text = "Job"
        Me.btnJob.UseVisualStyleBackColor = True
        '
        'frmControlAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnJob)
        Me.Controls.Add(Me.btnInventoryStock)
        Me.Controls.Add(Me.btnSuppliers)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btnItems)
        Me.Controls.Add(Me.btnCategories)
        Me.Name = "frmControlAdmin"
        Me.Size = New System.Drawing.Size(866, 453)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSuppliers As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents btnItems As Button
    Friend WithEvents btnCategories As Button
    Friend WithEvents btnInventoryStock As Button
    Friend WithEvents btnJob As Button
End Class
