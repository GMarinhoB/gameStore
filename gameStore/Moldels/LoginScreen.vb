Imports gameStore.Title
Imports System.Threading
Imports gameStore.DoLogin
Imports MySqlConnector
Module LoginScreen

    Sub ShowScreen(conn As MySqlConnection)

        Title.ShowTitle("*****LOGIN*****")
        Console.Write("E-mail:")
        Dim email As String = Console.ReadLine()
        Console.Write("Password:")
        Dim password As String = Console.ReadLine()

        Dim res As Integer = DoLogin.Loggin(email, password, conn)
        Redirection(res, conn)
        Thread.Sleep(1000)

    End Sub

    Sub Redirection(res As Integer, conn As MySqlConnection)

        Select Case res
            Case 2
                Console.Clear()
                Console.WriteLine("Welcome Adm!")
            Case 1
                Console.Clear()
                Console.WriteLine("Welcome User!")
            Case Else
                UserNotFund(conn)
        End Select

    End Sub

    Sub UserNotFund(conn As MySqlConnection)

        Dim key As ConsoleKeyInfo

        Do
            Console.Clear()
            Console.WriteLine("Wrong email or password.")
            Console.WriteLine("Press [B] to go back to the previous screen")
            Console.WriteLine("Press [L] to try login again.")
            Console.WriteLine("Press [E] to exit the System.")
            key = Console.ReadKey()
            Thread.Sleep(1000)
        Loop While Char.ToUpper(key.KeyChar()) <> "B"c AndAlso Char.ToUpper(key.KeyChar()) <> "L"c AndAlso Char.ToUpper(key.KeyChar()) <> "E"c

        Select Case key.Key
            Case ConsoleKey.L
                LoginScreen.ShowScreen(conn)
            Case ConsoleKey.B
                SelectionLoginRegisterScreen.ShowScreen(conn)
            Case ConsoleKey.E
                Program.EndProgram()

        End Select

    End Sub

End Module
