Imports gameStore.SqlConnection
Imports MySqlConnector
Module DbPasswordScreen
    Sub ShowScreen(ByRef conn As MySqlConnection)

        Dim password As String
        Do
            Console.Clear()
            Title()
            Console.Write("Insert the DataBase password:")
            password = Console.ReadLine()

        Loop While SqlConnection.Connect(password, conn) = 1
    End Sub

    Sub Title()
        Console.WriteLine("=================================")
        Console.WriteLine("Welcome to the game store system!")
        Console.WriteLine("=================================")
        Console.WriteLine($"{vbCrLf}")
    End Sub
End Module
