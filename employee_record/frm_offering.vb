Imports MySql.Data.MySqlClient
Public Class frm_offering

    Private Sub frm_offering_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        offering_list()

        If myconn.State = ConnectionState.Closed Then

            Try
                myconn.Open()
                'MsgBox("Database Successfully Connected!")
            Catch ex As Exception
                MsgBox("Error Connecting to Database" & vbCrLf & ex.Message)
            Finally
                myconn.Close()

            End Try

        End If


    End Sub

    'Populate database table into list

    Public Sub offering_list()
        Dim strQuery = "SELECT * FROM tbl_offerings"
        myconn.Open()
        Dim cmd As New MySqlCommand(strQuery, myconn)

        Dim dr As MySqlDataReader

        dr = cmd.ExecuteReader
        ListView1.Items.Clear()

        Do While dr.Read()
            Dim b, c, d
            b = (dr.Item("offer_id").ToString)
            c = (dr.Item("offer_type").ToString)
            d = (dr.Item("other_details").ToString)

            Dim lv As ListViewItem = ListView1.Items.Add(b)
            lv.SubItems.Add(c)
            lv.SubItems.Add(d)

        Loop
        dr.Close()
        cmd.Dispose()
        myconn.Close()
    End Sub

    'Add Record Button
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim query As String = "INSERT INTO tbl_offerings (offer_id, offer_type,other_details) VALUES ('" & txtoffer_id.Text & "','" & txtoffer_type.Text & "','" & txtother_details.Text & "')"
        'Dim con As New MySqlConnection(constring)
        Dim cmd As New MySqlCommand(query, myconn)

        Try
            myconn.Open()
            cmd.ExecuteNonQuery()
            MsgBox("Successfully added a record! ", vbOKOnly)


        Catch ex As Exception
            MsgBox("Error adding record! " & vbCrLf & ex.Message)
        End Try

        'update datagridview after inserting a record

        myconn.Close()
        offering_list()

        txtoffer_id.Text = ""
        txtoffer_type.Text = ""
        txtother_details.Text = ""
        txtoffer_id.Focus()

    End Sub


    'Delete Record
    'Set listbox checkboxes property = true
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        If ListView1.Items.Count > 0 Then

            For i = ListView1.Items.Count - 1 To 0 Step -1
                If ListView1.Items(i).Checked = True Then

                    Dim strQuery = "DELETE FROM tbl_offerings WHERE offer_id = '" & ListView1.Items(i).Text & "' "
                    Dim da As New MySqlDataAdapter(strQuery, myconn)
                    Dim ds As New DataSet
                    MsgBox("Successfully deleted a record")
                    da.Fill(ds)

                End If
            Next
        End If

        offering_list()

    End Sub

  
   
End Class