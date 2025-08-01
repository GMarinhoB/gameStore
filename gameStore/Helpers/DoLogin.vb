Imports System.Net.Http.Headers
Imports System.Threading
Imports gameStore.SqlConnection
Imports MySqlConnector
Module DoLogin

    Function Loggin(email As String, password As String, conn As MySqlConnection) As Integer

        Dim query As String = $"SELECT LoginUser(@email, @password)"

        Using command As New MySqlCommand(query, conn)

            'Note: Better passing the parameters this way to secure that SQL will read then as a String
            command.Parameters.AddWithValue("@email", email)
            command.Parameters.AddWithValue("@password", password)
            Dim obj = command.ExecuteScalar()
            Return Integer.Parse(obj.ToString())

        End Using

    End Function

End Module
