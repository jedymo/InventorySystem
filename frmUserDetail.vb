Public Class frmUserDetail
    Property id As Integer = -1

    Private Sub frmUserDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'InventoryDataSet.roles' table. You can move, or remove it, as needed.
        Me.RolesTableAdapter.Fill(Me.InventoryDataSet.roles)

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Dim username = txtUsername.Text
            Dim password = txtPassword.Text
            Dim phoneNumber = txtPhoneNumber.Text
            Dim isActive = rbActive.Checked
            Dim roleId = cmbRole.SelectedValue

            If id = -1 Then
                Dim hashedPassword = Encryption.GenerateSalt(password)
                Dim salt = Encryption.GenerateSalt
                Dim hashedAndSalted = Encryption.HashString($"{hashedPassword}{salt}")
                Me.UsersTableAdapter1.Insert(username, hashedPassword, salt, phoneNumber, isActive, roleId)
            Else
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class