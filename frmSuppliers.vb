Public Class frmSuppliers

    Private Sub frmSuppliers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'InventoryDataSet.suppliers' table. You can move, or remove it, as needed.
        Me.SuppliersTableAdapter.Fill(Me.InventoryDataSet.suppliers)
        Me.InventoryDataSet.suppliers.idColumn.AllowDBNull = True
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim isUpdated As Boolean = Me.SuppliersTableAdapter.Update(Me.SuppliersBindingSource.DataSource)
        If isUpdated Then
            MessageBox.Show("Suppliers updated!")
        End If
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        frmSuppliers_Load(sender, e)
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dvgSuppliers.RowCount = 1 Then
            Return
        End If

        Dim removedIndex = -1
        For Each cell As DataGridViewCell In dvgSuppliers.SelectedCells
            If cell.RowIndex = removedIndex Then
                Continue For
            End If
            dvgSuppliers.Rows.RemoveAt(cell.RowIndex)
            removedIndex = cell.RowIndex
        Next
    End Sub

End Class