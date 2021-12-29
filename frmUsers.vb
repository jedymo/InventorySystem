Public Class frmUsers
    Private Sub frmUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'InventoryDataSet.view_detailed_users' table. You can move, or remove it, as needed.
        Me.View_detailed_usersTableAdapter.Fill(Me.InventoryDataSet.view_detailed_users)

    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        frmUserDetail.ShowDialog()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        frmUserDetail.ShowDialog()
    End Sub
End Class