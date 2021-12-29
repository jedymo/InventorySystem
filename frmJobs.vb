Public Class frmJobs
    Private Sub frmJobs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'InventoryDataSet.jobs' table. You can move, or remove it, as needed.
        Me.JobsTableAdapter.Fill(Me.InventoryDataSet.jobs)
        Me.InventoryDataSet.jobs.idColumn.AllowDBNull = True

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dgvJobs.RowCount = 1 Then
            Return
        End If
        Dim removedIndex = -1
        For Each cell As DataGridViewCell In dgvJobs.SelectedCells
            If cell.RowIndex = removedIndex Then
                Continue For
            End If
            dgvJobs.Rows.RemoveAt(cell.RowIndex)
            removedIndex = cell.RowIndex
        Next
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim isUpdated As Boolean = Me.JobsTableAdapter.Update(Me.JobsBindingSource.DataSource)
        If isUpdated Then
            MessageBox.Show("Jobs updated!")
        End If
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        frmJobs_Load(sender, e)
    End Sub
End Class