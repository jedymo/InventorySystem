Public Class frmCategories
    Private Sub frmCategories_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'InventoryDataSet.categories' table. You can move, or remove it, as needed.
        Me.CategoriesTableAdapter.Fill(Me.InventoryDataSet.categories)
        Me.InventoryDataSet.categories.idColumn.AllowDBNull = True

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Dim isUpdated As Boolean = Me.CategoriesTableAdapter.Update(Me.CategoriesBindingSource.DataSource)
        If isUpdated Then
            MessageBox.Show("Categories updated!")
        End If
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        frmCategories_Load(sender, e)
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dgvCategories.RowCount = 1 Then
            Return
        End If
        Dim removedIndex = -1
        For Each cell As DataGridViewCell In dgvCategories.SelectedCells
            If cell.RowIndex = removedIndex Then
                Continue For
            End If
            dgvCategories.Rows.RemoveAt(cell.RowIndex)
            removedIndex = cell.RowIndex
        Next

    End Sub
End Class