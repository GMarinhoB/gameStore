Imports System.Threading
Imports gameStore.Title
Imports gameStore.LoginScreen
Imports gameStore.RegisterScreen
Module SelectionLoginRegisterScreen
    Sub ShowScreen()

        Dim key As ConsoleKeyInfo

        Do
            Title.ShowTitle("Welcome to the game store system!")
            Console.WriteLine("Press [R] to register a user.")
            Console.WriteLine("Press [L] to login.")
            Console.WriteLine("Press [E] to exit the System.")
            key = Console.ReadKey()
            Thread.Sleep(1000)
        Loop While Char.ToUpper(key.KeyChar()) <> "R"c AndAlso Char.ToUpper(key.KeyChar()) <> "L"c AndAlso Char.ToUpper(key.KeyChar()) <> "E"c

        Select Case key.Key
            Case ConsoleKey.L
                LoginScreen.ShowScreen()
            Case ConsoleKey.R
                RegisterScreen.ShowScreen()
            Case ConsoleKey.E
                Program.EndProgram()

        End Select
    End Sub

End Module
