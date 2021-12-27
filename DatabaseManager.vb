Imports MySql.Data.MySqlClient
Imports System.Configuration


Module DatabaseManager

    Private ReadOnly Conn As New MySqlConnection() With {
        .ConnectionString = GetConnectionString()
    }

    Public UserAuth As New Auth


    Public Cmd As New MySqlCommand() With {
        .Connection = GetConnection()
    }

    Public Function GetConnection() As MySqlConnection
        If Conn.State = ConnectionState.Closed Then
            'Conn = New MySqlConnection(GetConnectionString)
            Conn.Open()
        End If
        Return Conn
    End Function

    Public Function GetConnectionString() As String
        Return ConfigurationManager.
            ConnectionStrings("InventorySystem.My.MySettings.inventoryConnectionString").
            ConnectionString
    End Function



End Module
