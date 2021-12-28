Public Class frmDashboard

    Private Sub LogInToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogInToolStripMenuItem.Click
        frmLogin.ShowDialog()
        If UserAuth.State = AuthState.SignedIn Then
            FrmControlGuest1.Hide()
        Else
            FrmControlGuest1.Show()
        End If
    End Sub

    Private Sub AccountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AccountToolStripMenuItem.Click
        If UserAuth.State = AuthState.SignedIn Then
            LogInToolStripMenuItem.Enabled = False
            LogOutToolStripMenuItem.Enabled = True
        ElseIf UserAuth.State = AuthState.SignedOut Then
            LogOutToolStripMenuItem.Enabled = False
            LogInToolStripMenuItem.Enabled = True
        End If
    End Sub


    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        UserAuth.SignOut()
        FrmControlGuest1.Show()
    End Sub

    Private Sub btnCategories_Click(sender As Object, e As EventArgs) Handles btnCategories.Click
        frmCategories.Show()
    End Sub

    Private Sub btnItems_Click(sender As Object, e As EventArgs) Handles btnItems.Click
        frmProducts.Show()
    End Sub

    Private Sub btnSuppliers_Click(sender As Object, e As EventArgs) Handles btnSuppliers.Click
        frmSuppliers.Show()
    End Sub


End Class