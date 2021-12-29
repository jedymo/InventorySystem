Public Class frmControlAdmin

    Private Sub btnCategories_Click(sender As Object, e As EventArgs) Handles btnCategories.Click
        frmCategories.ShowDialog()
    End Sub

    Private Sub btnItems_Click(sender As Object, e As EventArgs) Handles btnItems.Click
        frmItems.ShowDialog()
    End Sub

    Private Sub btnSuppliers_Click(sender As Object, e As EventArgs) Handles btnSuppliers.Click
        frmSuppliers.ShowDialog()
    End Sub

    Private Sub btnJob_Click(sender As Object, e As EventArgs) Handles btnJob.Click
        frmJobs.ShowDialog()
    End Sub
End Class
