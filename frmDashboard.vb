Public Class frmDashboard

    Private Sub LogInToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogInToolStripMenuItem.Click
        frmLogin.ShowDialog()
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

    End Sub
End Class