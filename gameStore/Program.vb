Imports System
Imports gameStore.SqlConnection
Imports gameStore.DbPasswordScreen
Imports MySqlConnector

Module Program

    Dim conn As MySqlConnection
    Sub Main(args As String())

        DbPasswordScreen.ShowScreen(conn)
        SqlConnection.CloseConnection(conn)

    End Sub
End Module
