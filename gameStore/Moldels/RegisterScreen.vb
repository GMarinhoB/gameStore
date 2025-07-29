Imports gameStore.Title
Imports System.Threading
Module RegisterScreen

    Sub ShowScreen()

        Title.ShowTitle("*****REGISTER*****")
        Console.Write("Name:")
        Dim name As String = Console.ReadLine()
        Console.Write("CPF:")
        Dim cpf As String = Console.ReadLine()
        Console.Write("E-mail:")
        Dim email As String = Console.ReadLine()
        Console.Write("Password:")
        Dim password As String = Console.ReadLine()
        Console.Write("Birth Date:")
        Dim birthdate As String = Console.ReadLine()
        Console.Write("Defaut Card Number:")
        Dim card As String = Console.ReadLine()
        Console.Write("Defaut Address:")
        Dim address As String = Console.ReadLine()
        Thread.Sleep(1000)

    End Sub

End Module
