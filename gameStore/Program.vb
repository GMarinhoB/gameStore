Imports System
Imports gameStore.SqlConnection
Imports gameStore.DbPasswordScreen
Imports MySqlConnector
Imports System.Threading

Module Program

    Dim conn As MySqlConnection
    Sub Main(args As String())


        DbPasswordScreen.ShowScreen(conn)
        LoginScreen.ShowScreen()
        EndProgram()
        'SqlConnection.CloseConnection(conn)

    End Sub

    Sub EndProgram()
        Console.Clear()
        conn.Close()
        Console.WriteLine("Sucessfuly disconnected!")
        Thread.Sleep(1000)
        Environment.Exit(0)
    End Sub
End Module
