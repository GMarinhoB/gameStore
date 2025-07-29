Imports gameStore.Title
Imports System.Threading
Module LoginScreen

    Sub ShowScreen()

        Title.ShowTitle("*****LOGIN*****")
        Console.Write("E-mail:")
        Dim email As String = Console.ReadLine()
        Console.Write("Password:")
        Dim password As String = Console.ReadLine()
        Thread.Sleep(1000)

    End Sub

End Module
