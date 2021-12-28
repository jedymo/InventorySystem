

Public Enum AuthState
    SignedIn
    SignedOut
End Enum

Public Class Auth
    Property State As AuthState = AuthState.SignedOut


    Private Function GetSalt(username As String) As String
        Dim ad As New inventoryDataSetTableAdapters.prc_select_saltTableAdapter
        Dim dt As New inventoryDataSet.prc_select_saltDataTable

        ad.Fill(dt, username)
        If dt.Rows.Count = 0 Then
            Return ""
        End If
        Return dt.Rows(0).ItemArray(0)

    End Function

    Sub SignIn(username As String, password As String)
        Dim hashedPassword = Encryption.HashString(password)
        Dim salt = GetSalt(username)
        Dim hashedAndSaltedPassword = Encryption.HashString($"{hashedPassword}{salt}")

        If salt = "" Then
            Return
        End If
        Dim ad As New inventoryDataSetTableAdapters.prc_authenticateTableAdapter
        Dim dt As New inventoryDataSet.prc_authenticateDataTable

        ad.Fill(dt, username, hashedAndSaltedPassword)

        Dim isAuthenticated As Boolean = dt.Rows(0).ItemArray(0)

        State = If(isAuthenticated, AuthState.SignedIn, AuthState.SignedOut)

    End Sub

    Sub SignOut()
        State = AuthState.SignedOut
    End Sub

End Class

