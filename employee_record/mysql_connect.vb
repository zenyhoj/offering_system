Imports MySql.Data.MySqlClient

Module mysql_connect
    Public constring As String = "SERVER = localhost; USERID = root; PASSWORD =; DATABASE = church_offering; Convert Zero Datetime=True"
    Public myconn As New MySqlConnection(constring)
End Module
