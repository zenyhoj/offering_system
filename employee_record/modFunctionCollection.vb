Imports MySql.Data.MySqlClient
Module modFunctionCollection

    Public Function InsUpdateDel(ByVal QueryString As String) As Boolean
        Try
            myconn.Open()
            Dim cmd As New MySqlCommand(QueryString, myconn)
            cmd.ExecuteNonQuery()
            Return True
            myconn.Close()
        Catch ex As Exception
            Throw
        Finally
            myconn.Close()
        End Try

    End Function

End Module
