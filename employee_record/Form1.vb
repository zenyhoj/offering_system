'---Add reference if it is not present 
'--locate in program files\mysq\MySQL Connector Net 6.6.6\Assemblies\v2.0\MySql.Data.dll

Imports MySql.Data.MySqlClient

Public Class mainfrm

    '--Initialize mysql connection
    Public constring As String = "SERVER = localhost; USERID = root; PASSWORD =; DATABASE = church_offering; Convert Zero Datetime=True"
    'Dim myconn As MySqlConnection
    ' Dim strQuery As String = ""
    Public myconn As New MySqlConnection(constring)
    'Dim cmd As MySqlCommand
    'Dim DR As MySqlDataReader
    'Dim da As DataTable


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' myconn = New MySqlConnection("SERVER = localhost; USERID = root; PASSWORD =; DATABASE = church_offering")
        txtid.Visible = False
        'btnUpdate.Visible = False
        member_list()

        If myconn.State = ConnectionState.Closed Then

            Try
                myconn.Open()
                'MsgBox("Database Successfully Connected!")
            Catch ex As Exception
                MsgBox("Database Not Found", vbOKCancel)
            Finally
                myconn.Close()
            End Try

        End If
        'display_dvg_data()

    End Sub

    Public Sub member_list()
        Dim strQuery = "SELECT * FROM tbl_members"
        myconn.Open()
        Dim cmd As New MySqlCommand(strQuery, myconn)

        Dim dr As MySqlDataReader

        dr = cmd.ExecuteReader
        ListView1.Items.Clear()

        Do While dr.Read()
            Dim a, b, c, d, e, f, g, h, i, j, k
            a = (dr.Item("member_id").ToString)
            b = (dr.Item("member_lname").ToString())
            c = (dr.Item("member_fname").ToString)
            d = (dr.Item("member_midname").ToString)
            e = (dr.Item("member_gender").ToString)
            'convert to short date
            f = Convert.ToDateTime(dr.Item("member_dob").ToString)
            g = (dr.Item("member_address").ToString)
            h = Convert.ToDateTime(dr.Item("member_salvation_date").ToString)
            i = Convert.ToDateTime(dr.Item("member_baptism_date").ToString)
            j = (dr.Item("member_sponsor").ToString)
            k = (dr.Item("other_details").ToString)

            Dim lv As ListViewItem = ListView1.Items.Add(a)
            lv.SubItems.Add(b)
            lv.SubItems.Add(c)
            lv.SubItems.Add(d)
            lv.SubItems.Add(e)
            lv.SubItems.Add(f)
            lv.SubItems.Add(g)
            lv.SubItems.Add(h)
            lv.SubItems.Add(i)
            lv.SubItems.Add(j)
            lv.SubItems.Add(k)

        Loop
        dr.Close()
        cmd.Dispose()
        myconn.Close()


    End Sub
   
    Private Sub clear_data()
        txtlname.Text = ""
        txtfname.Text = ""
        txtgender.Text = ""
        txtmid.Text = ""
        txtgender.Text = ""
        DTPicker1.Text = ""
        txtadd.Text = ""
        DTPicker2.Text = ""
        DTPicker3.Text = ""
        txtsponsor.Text = ""
        txtother_details.Text = ""
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddRecord.Click
        Dim query As String = "INSERT INTO tbl_members (member_lname, member_fname, member_midname, member_gender, member_dob, member_address, member_salvation_date, member_baptism_date, member_sponsor, other_details) VALUES ('" & txtlname.Text & "', '" & txtfname.Text & "', '" & txtmid.Text & "', '" & txtgender.Text & "','" & (CStr(DateAndTime.Year(CDate(DTPicker1.Value))) & "/" & DateAndTime.Month(CDate(DTPicker1.Value))) & "/" & DateAndTime.Day(CDate(DTPicker1.Value)) & "', '" & txtadd.Text & "', '" & (CStr(DateAndTime.Year(CDate(DTPicker2.Value))) & "/" & DateAndTime.Month(CDate(DTPicker2.Value))) & "/" & DateAndTime.Day(CDate(DTPicker2.Value)) & "', '" & (CStr(DateAndTime.Year(CDate(DTPicker3.Value))) & "/" & DateAndTime.Month(CDate(DTPicker3.Value))) & "/" & DateAndTime.Day(CDate(DTPicker3.Value)) & "', '" & txtsponsor.Text & "', '" & txtother_details.Text & "' )"
        Dim con As New MySqlConnection(constring)
        Dim cmd As New MySqlCommand(query, con)

        Try
            con.Open()

            'Dim query1 As String = "SELECT * FROM tbl_members WHERE member_lname = '" & txtlname.Text & "' AND member_fname = '" & txtfname.Text & "' AND member_midname = '" & txtmid.Text & "' AND member_dob = '" & (CStr(DateAndTime.Year(CDate(DTPicker1.Value))) & "/" & DateAndTime.Month(CDate(DTPicker1.Value))) & "/" & DateAndTime.Day(CDate(DTPicker1.Value)) & "'"
            Dim query1 As String = "SELECT * FROM tbl_members WHERE member_lname = '" & txtlname.Text & "' AND member_fname = '" & txtfname.Text & "' "
            Dim tbl1 As New DataTable
            tbl1 = frm_member_offering.GetTable(query1)

            If tbl1.Rows.Count > 0 Then
                MsgBox("Duplicate Entry Found! ", vbOKOnly)
            Else
                cmd.ExecuteNonQuery()
                MsgBox("Successfully added a record! ", vbOKOnly)
            End If
        Catch ex As Exception
            MsgBox("Error adding record! " & vbCrLf & ex.Message)
        End Try

        'update datagridview after inserting a record
        member_list()
        con.Close()
        clear_data()
        btnAddRecord.Enabled = False
        'btnAddRecord.Enabled = False

    End Sub

    Private Sub txtlname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtlname.TextChanged
        btnAddRecord.Enabled = True
    End Sub

    Private Sub ListView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.DoubleClick
        If ListView1.Items.Count > 0 Then
            Me.txtid.Text = ListView1.SelectedItems(0).Text
            Me.txtlname.Text = ListView1.SelectedItems(0).SubItems(1).Text
            Me.txtfname.Text = ListView1.SelectedItems(0).SubItems(2).Text
            Me.txtmid.Text = ListView1.SelectedItems(0).SubItems(3).Text
            Me.txtgender.Text = ListView1.SelectedItems(0).SubItems(4).Text
            Me.DTPicker1.Text = ListView1.SelectedItems(0).SubItems(5).Text
            Me.txtadd.Text = ListView1.SelectedItems(0).SubItems(6).Text
            Me.DTPicker2.Text = ListView1.SelectedItems(0).SubItems(7).Text
            Me.DTPicker3.Text = ListView1.SelectedItems(0).SubItems(8).Text
            Me.txtsponsor.Text = ListView1.SelectedItems(0).SubItems(9).Text
            Me.txtother_details.Text = ListView1.SelectedItems(0).SubItems(10).Text

        End If
        txtid.Visible = True
        btnUpdate.Enabled = True
        btnAddRecord.Enabled = False

    End Sub

 
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

        Dim strQuery = "SELECT * from tbl_members where member_lname like '%" & TextBox1.Text & "%'   "
        myconn.Open()

        Dim cmd As New MySqlCommand(strQuery, myconn)

        Dim dr As MySqlDataReader

        dr = cmd.ExecuteReader
        ListView1.Items.Clear()

        Do While dr.Read()

            Dim a, b, c, d, q, f, g, h, i, j, k
            a = (dr.Item("member_id").ToString)
            b = (dr.Item("member_lname").ToString())
            c = (dr.Item("member_fname").ToString)
            d = (dr.Item("member_midname").ToString)
            q = (dr.Item("member_gender").ToString)
            f = Convert.ToDateTime(dr.Item("member_dob").ToString)
            g = (dr.Item("member_address").ToString)
            h = Convert.ToDateTime(dr.Item("member_salvation_date").ToString)
            i = Convert.ToDateTime(dr.Item("member_baptism_date").ToString)
            j = (dr.Item("member_sponsor").ToString)
            k = (dr.Item("other_details").ToString)

            Dim lv As ListViewItem = ListView1.Items.Add(a)
            lv.SubItems.Add(b)
            lv.SubItems.Add(c)
            lv.SubItems.Add(d)
            lv.SubItems.Add(q)
            lv.SubItems.Add(f)
            lv.SubItems.Add(g)
            lv.SubItems.Add(h)
            lv.SubItems.Add(i)
            lv.SubItems.Add(j)
            lv.SubItems.Add(k)

        Loop
        dr.Close()
        cmd.Dispose()
        myconn.Close()


    End Sub


    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Dim query As String = "UPDATE tbl_members SET " & _
            " member_lname = '" & txtlname.Text & "'," & _
            " member_fname = '" & txtfname.Text & "'," & _
            " member_midname = '" & txtmid.Text & "'," & _
            " member_gender = '" & txtgender.Text & "', " & _
            " member_dob = '" & (CStr(DateAndTime.Year(CDate(DTPicker1.Value))) & "/" & DateAndTime.Month(CDate(DTPicker1.Value))) & "/" & DateAndTime.Day(CDate(DTPicker1.Value)) & "', " & _
            " member_address = '" & txtadd.Text & "'," & _
            " member_salvation_date = '" & (CStr(DateAndTime.Year(CDate(DTPicker2.Value))) & "/" & DateAndTime.Month(CDate(DTPicker2.Value))) & "/" & DateAndTime.Day(CDate(DTPicker2.Value)) & "', " & _
            " member_baptism_date = '" & (CStr(DateAndTime.Year(CDate(DTPicker3.Value))) & "/" & DateAndTime.Month(CDate(DTPicker3.Value))) & "/" & DateAndTime.Day(CDate(DTPicker3.Value)) & "', " & _
            " member_sponsor = '" & txtsponsor.Text & "'," & _
            " other_details = '" & txtother_details.Text & "'" & _
            " WHERE member_id = '" & txtid.Text & "'"

        Dim con As New MySqlConnection(constring)
        Dim cmd As New MySqlCommand(query, con)

        Try
            con.Open()
            cmd.ExecuteNonQuery()
            MsgBox("Successfully updated a record! ", vbOKOnly)

        Catch ex As Exception
            MsgBox("Error updating record! " & vbCrLf & ex.Message)
        End Try

        'update datagridview after inserting a record
        'display_dvg_data()

        member_list()
        con.Close()
        'clear_data()
        'btnAddRecord.Enabled = False

    End Sub


    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        clear_data()
        btnAddRecord.Visible = True
        txtid.Visible = False
    End Sub

    
    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If ListView1.Items.Count > 0 Then
            btnDelete.Enabled = True
            For i = ListView1.Items.Count - 1 To 0 Step -1
                If ListView1.Items(i).Checked = True Then

                    Dim strQuery = "DELETE FROM tbl_members WHERE member_id = '" & ListView1.Items(i).Text & "' "
                    Dim da As New MySqlDataAdapter(strQuery, myconn)
                    Dim ds As New DataSet
                    MsgBox("Successfully deleted a record")
                    da.Fill(ds)

                End If
            Next
        End If

        member_list()

    End Sub


    
    
End Class
