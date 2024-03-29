Public Class frmLogin

    ' TODO: Insert code to perform custom authentication using the provided username and password
    ' (See https://go.microsoft.com/fwlink/?LinkId=35339).
    ' The custom principal can then be attached to the current thread's principal as follows:
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication.
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click

        Try
            UserAuth.SignIn(UsernameTextBox.Text.Trim, PasswordTextBox.Text.Trim)
            If UserAuth.State = AuthState.SignedIn Then
                MessageBox.Show("Signed in!")
                Me.Dispose()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Dispose()
    End Sub

End Class