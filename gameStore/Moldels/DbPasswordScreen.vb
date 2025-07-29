Imports gameStore.SqlConnection
Imports MySqlConnector
Imports gameStore.Title
Module DbPasswordScreen
    Sub ShowScreen(ByRef conn As MySqlConnection)

        Dim password As String
        Do
            Console.Clear()
            Title.ShowTitle("Welcome to the game store system!")
            Console.Write("Insert the DataBase password:")
            password = Console.ReadLine()

        Loop While SqlConnection.Connect(password, conn) = 1
    End Sub

End Module
