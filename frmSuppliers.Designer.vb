<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSuppliers
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
        Me.dvgSuppliers = New System.Windows.Forms.DataGridView()
        Me.InventoryDataSet = New InventorySystem.inventoryDataSet()
        Me.SuppliersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SuppliersTableAdapter = New InventorySystem.inventoryDataSetTableAdapters.suppliersTableAdapter()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CompanynameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhonenumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        CType(Me.dvgSuppliers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventoryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SuppliersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dvgSuppliers
        '
        Me.dvgSuppliers.AutoGenerateColumns = False
        Me.dvgSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvgSuppliers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.CompanynameDataGridViewTextBoxColumn, Me.PhonenumberDataGridViewTextBoxColumn})
        Me.dvgSuppliers.DataSource = Me.SuppliersBindingSource
        Me.dvgSuppliers.Location = New System.Drawing.Point(12, 133)
        Me.dvgSuppliers.Name = "dvgSuppliers"
        Me.dvgSuppliers.RowHeadersWidth = 62
        Me.dvgSuppliers.RowTemplate.Height = 28
        Me.dvgSuppliers.Size = New System.Drawing.Size(776, 305)
        Me.dvgSuppliers.TabIndex = 0
        '
        'InventoryDataSet
        '
        Me.InventoryDataSet.DataSetName = "inventoryDataSet"
        Me.InventoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SuppliersBindingSource
        '
        Me.SuppliersBindingSource.DataMember = "suppliers"
        Me.SuppliersBindingSource.DataSource = Me.InventoryDataSet
        '
        'SuppliersTableAdapter
        '
        Me.SuppliersTableAdapter.ClearBeforeFill = True
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "id"
        Me.IdDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.Visible = False
        Me.IdDataGridViewTextBoxColumn.Width = 150
        '
        'CompanynameDataGridViewTextBoxColumn
        '
        Me.CompanynameDataGridViewTextBoxColumn.DataPropertyName = "company_name"
        Me.CompanynameDataGridViewTextBoxColumn.HeaderText = "Company Name"
        Me.CompanynameDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.CompanynameDataGridViewTextBoxColumn.Name = "CompanynameDataGridViewTextBoxColumn"
        Me.CompanynameDataGridViewTextBoxColumn.Width = 150
        '
        'PhonenumberDataGridViewTextBoxColumn
        '
        Me.PhonenumberDataGridViewTextBoxColumn.DataPropertyName = "phone_number"
        Me.PhonenumberDataGridViewTextBoxColumn.HeaderText = "Phone Number"
        Me.PhonenumberDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.PhonenumberDataGridViewTextBoxColumn.Name = "PhonenumberDataGridViewTextBoxColumn"
        Me.PhonenumberDataGridViewTextBoxColumn.Width = 150
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(636, 93)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(152, 34)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "Save Changes"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(372, 90)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(79, 37)
        Me.btnRefresh.TabIndex = 6
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(466, 90)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(153, 37)
        Me.btnDelete.TabIndex = 5
        Me.btnDelete.Text = "Delete Seletected"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'frmSuppliers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.dvgSuppliers)
        Me.Name = "frmSuppliers"
        Me.Text = "frmSuppliers"
        CType(Me.dvgSuppliers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventoryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SuppliersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dvgSuppliers As DataGridView
    Friend WithEvents InventoryDataSet As inventoryDataSet
    Friend WithEvents SuppliersBindingSource As BindingSource
    Friend WithEvents SuppliersTableAdapter As inventoryDataSetTableAdapters.suppliersTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CompanynameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PhonenumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnSave As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnDelete As Button
End Class
