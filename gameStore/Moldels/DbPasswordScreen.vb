Imports gameStore.SqlConnection
Module DbPasswordScreen
    Sub ShowScreen()

        Dim password As String
        Do
            Console.Clear()
            Title()
            Console.Write("Insert the DataBase password:")
            password = Console.ReadLine()

        Loop While SqlConnection.Connect(password) = 1
    End Sub

    Sub Title()
        Console.WriteLine("=================================")
        Console.WriteLine("Welcome to the game store system!")
        Console.WriteLine("=================================")
        Console.WriteLine($"{vbCrLf}")
    End Sub
End Module
