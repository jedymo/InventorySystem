﻿Public Class Encryption

    Public Shared Function HashString(str As String) As String
        Return EncryptString(str)
    End Function

    Public Shared Function GenerateSalt() As String
        Using cryptoServiceProvider As New Security.Cryptography.RNGCryptoServiceProvider
            Dim sb As New Text.StringBuilder
            Dim data As Byte() = New Byte(4) {}
            For i = 0 To 6
                cryptoServiceProvider.GetBytes(data)
                Dim value As String = BitConverter.ToString(data, 0)
                sb.Append(value)
            Next
            Return EncryptString(sb.ToString)
        End Using
    End Function

    Private Shared Function EncryptString(str As String) As String
        Dim bytes As Byte() = Text.Encoding.ASCII.GetBytes(str)
        Dim hashed = Security.Cryptography.SHA256.Create.ComputeHash(bytes)
        Return Convert.ToBase64String(hashed)
    End Function

End Class