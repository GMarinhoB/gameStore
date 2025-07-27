Imports System.Threading
Imports MySqlConnector

Module SqlConnection

    Function Connect(password As String, ByRef conn As MySqlConnection) As Integer

        Dim connStr As String = $"server=localhost;user=root;password={password};database=gamestore;"
        conn = New MySqlConnection(connStr)

        Try

            conn.Open()
            Console.WriteLine("Sucessfuly connected!")
            Thread.Sleep(1500)
            Return 0

        Catch ex As Exception

            If (ex.Message = "Access denied for user 'root'@'localhost' (using password: YES)") Then

                Console.WriteLine("Error: Wrong password!")
                Thread.Sleep(2000)

            Else

                Console.WriteLine("Error: " & ex.Message)
                Thread.Sleep(2000)

            End If
            Return 1
        End Try

    End Function

End Module
