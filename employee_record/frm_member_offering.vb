Imports MySql.Data.MySqlClient
Public Class frm_member_offering

    Public constring As String = "SERVER = localhost; USERID = root; PASSWORD =; DATABASE = church_offering"
    Public conn As New MySqlConnection(constring)

    Private Sub cbo_offering()

        Dim strSQL As String = "SELECT * FROM tbl_offerings"
        conn.Open()
        Dim da As New MySqlDataAdapter(strSQL, conn)
        Dim dt As New DataTable
        Dim ds As New DataSet
        da.Fill(ds, "tbl_offerings")
        With cbo_offer_id
            .DataSource = ds.Tables(0)
            .DisplayMember = "offer_id"
            .ValueMember = "offer_type"
            .SelectedIndex = 0
        End With

        conn.Close()

        'ds.Dispose()
    End Sub
    Private Sub frm_member_offering_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'SumOfOfferingPerID()
        cbo_offering()
        txt_member_id.Visible = False
        'btndelete.Visible = False
        btnUpdate.Enabled = False
        'txtID.Visible = False
        'member_list1()
        'member_offering_list()
        pop_datagridview()
        dvg_member_list()
        If conn.State = ConnectionState.Closed Then

            Try
                conn.Open()
            Catch ex As Exception
                MsgBox("Database Not Found", vbOKCancel)
            Finally
                conn.Close()
            End Try
        End If

    End Sub


    Public Sub pop_datagridview()
        Dim strQuery As String = "SELECT id AS ID, member_id AS MemberID, offer_id AS OfferingID, amount AS Amount, date_given AS Date FROM tbl_member_offer"
        With DataGridView1
            .DataSource = GetTable(strQuery)
            .ForeColor = Color.Black
            .Columns("id").Width = 40
            .Columns("Amount").Width = 100
            .Columns("MemberID").Width = 80
        End With
        
    End Sub

    Public Sub dvg_member_list()
        Dim strQuery As String = "SELECT member_id AS ID, member_lname AS LastName, member_fname AS FirstName, member_midname AS MidName FROM tbl_members WHERE member_lname like '%" & txtlname_search.Text & "%' "
        With DataGridView2
            .DataSource = GetTable(strQuery)
            .ForeColor = Color.Black
            .Columns("ID").Width = 60
            .Columns("LastName").Width = 160
            .Columns("FirstName").Width = 116
        End With
    End Sub
   
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim query As String = "INSERT INTO tbl_member_offer (offer_id, member_id, amount, date_given) VALUES ('" & cbo_offer_id.Text & "','" & txt_member_id.Text & "',  '" & txt_amount.Text & "', '" & (CStr(DateAndTime.Year(CDate(DTPicker4.Value))) & "/" & DateAndTime.Month(CDate(DTPicker4.Value))) & "/" & DateAndTime.Day(CDate(DTPicker4.Value)) & "')"
       

        Try
            If txt_amount.Text = "" OrElse
              txtfname.Text = "" OrElse
              txtlname.Text = "" Then
                MsgBox("Nothing to save!", vbOK)
                txtlname_search.Focus()
                Exit Sub
            Else
                If txt_amount.Text = "" Then
                    MsgBox("Please fill in amount box!", vbOKOnly)
                    txt_amount.Focus()
                    Return

                End If

                If txtlname.Text = "" Then
                    MsgBox("Please search/select member from the list!", vbOKOnly)
                    txtlname_search.Focus()
                    Return

                End If

                Dim query1 As String = "SELECT * FROM tbl_member_offer WHERE member_id = '" & txt_member_id.Text & "' AND offer_id = '" & cbo_offer_id.Text & "' AND date_given = '" & (CStr(DateAndTime.Year(CDate(DTPicker4.Value))) & "/" & DateAndTime.Month(CDate(DTPicker4.Value))) & "/" & DateAndTime.Day(CDate(DTPicker4.Value)) & "'"
                Dim tbl As New DataTable
                tbl = GetTable(query1)
                If tbl.Rows.Count > 0 Then
                    MsgBox("Duplicate Entry! ", vbOKOnly)
                Else
                    InsUpdateDel(query)
                    'MsgBox("Successfully added a record! ", vbOKOnly)
                    txt_amount.Text = " "
                    'SumOfOfferingPerID()
                End If

            End If

        Catch ex As Exception
            MsgBox("Error adding record! " & vbCrLf & ex.Message)

        End Try
        pop_datagridview()
        cbo_offer_id.Focus()
        'SumOfOfferingPerID()
    End Sub

    Private Sub txt_amount_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_amount.GotFocus
        txt_amount.Text = ""
    End Sub

    'Sums of offer_id 

    ''Private Sub SumOfOfferingPerID()
    ''    Dim SumOfTI As Decimal
    ''    For x = 0 To DataGridView1.Rows.Count - 1 Step 1
    ''        If DataGridView1.Rows(x).Cells("OfferingID").Value = "TI" Then
    ''            SumOfTI += DataGridView1.Rows(x).Cells("Amount").Value
    ''        End If
    ''    Next
    ''    txtSumofTithes.Text = SumOfTI.ToString("##,##.00")
    ''End Sub

    
    'Accept only numeric and '.' character
    Private Sub txt_amount_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_amount.KeyPress

        OnlyNumeric(e, sender)

    End Sub


    Public Sub OnlyNumeric(ByVal CharValue As System.Windows.Forms.KeyPressEventArgs, ByVal ControlName As Control)

        If Char.IsControl(CharValue.KeyChar) = False Then
            If Char.IsDigit(CharValue.KeyChar) Or CharValue.KeyChar = "." Then
                If ControlName.Text.Contains(".") Then
                    If ControlName.Text.Split(".")(1).Length < 2 Then
                        If Char.IsDigit(CharValue.KeyChar) = False Then
                            CharValue.Handled = True
                        End If
                    Else
                        CharValue.Handled = True
                    End If
                Else
                End If
            Else
                CharValue.Handled = True
            End If
        End If

    End Sub

    Public Function GetTable(ByVal QueryString As String) As DataTable

        Dim conn As New MySqlConnection(constring)

        Try
            Dim cmd As New MySqlCommand(QueryString, conn)
            Dim myAdapter As New MySqlDataAdapter
            Dim myTable As New DataTable

            conn.Open()

            myAdapter.SelectCommand = cmd

            myAdapter.Fill(myTable)

            Return myTable

        Catch ex As Exception
            Return Nothing
        Finally
            conn.Close()
            conn.Dispose()
        End Try
    End Function

    Private Sub txtlname_search_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtlname_search.TextChanged
        dvg_member_list()
    End Sub

    Private Sub ListView2_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView2.DoubleClick
        If ListView2.Items.Count > 0 Then
            Me.txt_member_id.Text = ListView2.SelectedItems(0).Text
            Me.txtlname.Text = ListView2.SelectedItems(0).SubItems(1).Text
            Me.txtfname.Text = ListView2.SelectedItems(0).SubItems(2).Text
            Me.txtmid.Text = ListView2.SelectedItems(0).SubItems(3).Text
        End If
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click

        Dim query As String = "UPDATE tbl_member_offer SET " & _
           " id = '" & txtID.Text & "'," & _
            " offer_id = '" & cbo_offer_id.Text & "'," & _
            " member_id = '" & txt_member_id.Text & "'," & _
            " amount = '" & txt_amount.Text & "'," & _
           " date_given = '" & (CStr(DateAndTime.Year(CDate(DTPicker4.Value))) & "/" & DateAndTime.Month(CDate(DTPicker4.Value))) & "/" & DateAndTime.Day(CDate(DTPicker4.Value)) & "' " & _
           " WHERE id = '" & txtID.Text & "'"
        If DataGridView1.Rows.Count = Nothing Then
            MsgBox("Nothing to update! ", vbOKOnly)
            Exit Sub
        End If
        InsUpdateDel(query)
        MsgBox("Successfully updated a record! ", vbOKOnly)
        btnSave.Enabled = True
        btnUpdate.Enabled = False
        btndelete.Enabled = False
        txt_amount.Text = " "
        cbo_offer_id.Focus()
        pop_datagridview()

    End Sub
  
  
    Private Sub DataGridView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.Click
        If DataGridView1.Rows.Count > 0 Then
            Me.txt_amount.Text = DataGridView1.CurrentRow.Cells(3).Value
            Me.cbo_offer_id.Text = DataGridView1.CurrentRow.Cells(2).Value
            Me.txt_member_id.Text = DataGridView1.CurrentRow.Cells(1).Value
            Me.txtID.Text = DataGridView1.CurrentRow.Cells(0).Value
            Me.DTPicker4.Text = DataGridView1.CurrentRow.Cells(4).Value
            btnSave.Enabled = False
            btnUpdate.Enabled = True
            btndelete.Enabled = True
        End If
    End Sub

    Private Sub DataGridView1_DataSourceChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.DataSourceChanged
        DataGridView1.Columns("amount").DefaultCellStyle.Format = "##,##.00"
    End Sub

   
       Private Sub DataGridView2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView2.Click
        If DataGridView2.Rows.Count > 0 Then
            Me.txt_member_id.Text = DataGridView2.CurrentRow.Cells(0).Value
            Me.txtlname.Text = DataGridView2.CurrentRow.Cells(1).Value
            Me.txtfname.Text = DataGridView2.CurrentRow.Cells(2).Value
            Me.txtmid.Text = DataGridView2.CurrentRow.Cells(3).Value

        End If
    End Sub


    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        Dim strQuery As String = "DELETE FROM tbl_member_offer WHERE id = '" & txtID.Text & "' "
        If DataGridView1.Rows.Count = Nothing Then
            MsgBox("Nothing to delete! ", vbOKOnly)
            Exit Sub
        End If
        If MsgBox("Delete Record? ", vbYesNo) = MsgBoxResult.Yes Then
            If DataGridView1.Rows.Count > 0 Then
                InsUpdateDel(strQuery)
                txtID.Text = ""
                cbo_offer_id.Text = ""
                txt_amount.Text = ""
                DTPicker4.Text = ""
                pop_datagridview()
                btndelete.Enabled = False
                btnSave.Enabled = True
                btnUpdate.Enabled = False
            Else
                MsgBox("Nothing to delete! ", vbOKOnly)
            End If
        End If
       
    End Sub

    
End Class