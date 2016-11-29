Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms


Public Class search

    Declare Function GetAsyncKeyState Lib "user32" (ByVal vKey As Integer) As Short
    Private Sub search_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DataGridView1.Visible = False
        'frm_member_offering.member_offering_list()
        


        member_offering_list()
    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            ' member_offering_list()
            'DataGridView1.Visible = True

        End If
    End Sub

    Private Sub TextBox1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.LostFocus
        btnSearchByMember.Tag = " "
    End Sub


    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        'OfferingListByMember_ByDate()
        member_offering_list()
        DataGridView1.Visible = True
        btnSearchByMember.Visible = True


    End Sub
    'SEARCH RECORD BY MEMBER BY RANGE OF DATE
    Public Sub OfferingListByMember_ByDate()
        Dim strQueryMember = "SELECT tbl_members.member_id AS MemberID, tbl_members.member_lname AS Lastname, tbl_members.member_fname AS Firstname, " & _
                        " tbl_members.member_midname AS MidName, tbl_member_offer.offer_id AS OfferingID, tbl_member_offer.amount AS Amount, tbl_member_offer.date_given AS Date" & _
                        " FROM tbl_members, tbl_member_offer " & _
                        " WHERE tbl_members.member_id = tbl_member_offer.member_id" & _
                        " AND CONCAT(tbl_members.member_lname, ', ' , tbl_members.member_fname) like '" & TextBox1.Text & "%'" & _
                        " AND date_given BETWEEN '" & Format(DTPicker1.Value.ToString("yyyy/MM/dd")) & "'" & _
                        "AND '" & Format(DTPicker2.Value.ToString("yyyy/MM/dd")) & "'" & _
                        " ORDER BY DATE DESC"
        Dim tblmember As New DataTable
        Try
            Dim cmd As New MySqlCommand(strQueryMember, myconn)
            Dim myAdapter As New MySqlDataAdapter
            myconn.Open()
            myAdapter.SelectCommand = cmd
            myAdapter.Fill(tblmember)
        Catch ex As Exception
            MsgBox("Error", ex.Message)
        Finally
            myconn.Close()
            myconn.Dispose()
        End Try
        DataGridView1.DataSource = tblmember

    End Sub





    'SEARCH RECORD BY MEMBER
    Public Sub member_offering_list()

        'Dim strQuery = "SELECT tbl_members.member_id AS MemberID, tbl_members.member_lname AS Lastname, tbl_members.member_fname AS Firstname, " & _
        '                " tbl_members.member_midname AS MidName, tbl_member_offer.offer_id AS OfferingID, tbl_member_offer.amount AS Amount, tbl_member_offer.date_given AS Date" & _
        '                " FROM tbl_members, tbl_member_offer " & _
        '                " WHERE tbl_members.member_id = tbl_member_offer.member_id" & _
        '                " AND CONCAT(tbl_members.member_lname, ' ', tbl_members.member_fname) like '" & TextBox1.Text & "%'" & _
        '                " ORDER BY DATE DESC"

        Dim strQuery = "SELECT tbl_members.member_id AS MemberID, tbl_members.member_lname AS Lastname, tbl_members.member_fname AS Firstname, " & _
                        " tbl_members.member_midname AS MidName, tbl_member_offer.offer_id AS OfferingID, tbl_member_offer.amount AS Amount, tbl_member_offer.date_given AS Date" & _
                        " FROM tbl_members, tbl_member_offer " & _
                        " WHERE tbl_members.member_id = tbl_member_offer.member_id" & _
                        " AND CONCAT(tbl_members.member_lname, ' ', tbl_members.member_fname) like '" & TextBox1.Text & "%'" & _
                        " ORDER BY DATE DESC"


        'Dim conn As New MySqlConnection(myconn)
        Dim myTable As New DataTable
        Try
            Dim cmd As New MySqlCommand(strQuery, myconn)
            Dim myAdapter As New MySqlDataAdapter

            myconn.Open()

            myAdapter.SelectCommand = cmd

            myAdapter.Fill(myTable)

        Catch ex As Exception
            ' If ex.Message = "Unable to connect to any of the specified MySQL hosts." Then
            'MsgBox("Unable to connect to any of the specified Server.", vbOKOnly & vbCritical)
            MsgBox("Error", ex.Message)
            'End If
        Finally
            myconn.Close()
            myconn.Dispose()
        End Try

        DataGridView1.DataSource = myTable




    End Sub

    'Private Sub byOfferingType()

    '    Dim strQuery1 = "SELECT tbl_members.member_id AS MemberID, tbl_members.member_lname AS Lastname, tbl_members.member_fname AS Firstname," & _
    '                    "tbl_members.member_midname AS Midname," & _
    '                    "tbl_member_offer.offer_id AS OfferingID, tbl_member_offer.amount AS Amount," & _
    '                    "tbl_member_offer.date_given AS Date FROM tbl_member_offer," & _
    '                    " tbl_members WHERE tbl_members.member_id = tbl_member_offer.member_id" & _
    '                    " AND offer_id = '" & ComboBox1.Text & "' ORDER BY date_given DESC"


    '    Dim mytable1 As New DataTable
    '    Dim myAdapter1 As New MySqlDataAdapter

    '    Try
    '        Dim cmd As New MySqlCommand(strQuery1, myconn)


    '        myconn.Open()

    '        myAdapter1.SelectCommand = cmd

    '        myAdapter1.Fill(mytable1)

    '    Catch ex As Exception
    '        MsgBox("Error", ex.Message)

    '    Finally
    '        myconn.Close()
    '        myconn.Dispose()
    '    End Try
    '    DataGridView1.DataSource = mytable1
    'End Sub


    'Private Sub SummationByOfferIdConsolodated()
    '    Dim mytable2 As New DataTable
    '    Dim myAdapter2 As New MySqlDataAdapter
    '    Dim strQuery2 = "SELECT offer_id AS OfferID, SUM(amount) as TOTAL FROM tbl_member_offer WHERE date_given BETWEEN '" & Format(DTPicker1.Value.ToString("yyyy/MM/dd")) & "'" & _
    '                    "AND '" & Format(DTPicker2.Value.ToString("yyyy/MM/dd")) & "' GROUP BY offer_id"

    '    Try
    '        Dim cmd As New MySqlCommand(strQuery2, myconn)


    '        myconn.Open()

    '        myAdapter2.SelectCommand = cmd

    '        myAdapter2.Fill(mytable2)

    '    Catch ex As Exception
    '        MsgBox("Error", ex.Message)

    '    Finally
    '        myconn.Close()
    '        myconn.Dispose()
    '    End Try

    '    DataGridView1.DataSource = mytable2

    'End Sub
    Private Sub AllRecordsByDate()
        Dim mytable3 As New DataTable
        Dim myAdapter3 As New MySqlDataAdapter

        'Dim strQuery3 = "SELECT member_id AS MemberID, offer_id AS OfferID,  amount as Amount, date_given as Date FROM tbl_member_offer WHERE date_given BETWEEN '" & Format(DTPicker3.Value.ToString("yyyy/MM/dd")) & "'" & _
        '               "AND '" & Format(DTPicker4.Value.ToString("yyyy/MM/dd")) & "' ORDER BY date_given"


        Dim strQuery3 = "SELECT tbl_members.member_id AS MemberID, tbl_members.member_lname AS Lastname, tbl_members.member_fname AS Firstname, " & _
                       " tbl_members.member_midname AS MidName, tbl_member_offer.offer_id AS OfferingID, tbl_member_offer.amount AS Amount, tbl_member_offer.date_given AS Date" & _
                       " FROM tbl_members, tbl_member_offer " & _
                       " WHERE tbl_members.member_id = tbl_member_offer.member_id" & _
                       " AND date_given BETWEEN '" & Format(DTPicker3.Value.ToString("yyyy/MM/dd")) & "'" & _
                        "AND '" & Format(DTPicker4.Value.ToString("yyyy/MM/dd")) & "' ORDER BY date_given DESC"

        Try
            Dim cmd As New MySqlCommand(strQuery3, myconn)

            myconn.Open()

            myAdapter3.SelectCommand = cmd

            myAdapter3.Fill(mytable3)

        Catch ex As Exception
            MsgBox("Error", ex.Message)

        Finally
            myconn.Close()
            myconn.Dispose()
        End Try

        DataGridView1.DataSource = mytable3

    End Sub


    'Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    byOfferingType()
    '    DataGridView1.Visible = True
    'End Sub

    'Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    SummationByOfferIdConsolodated()
    '    DataGridView1.Visible = True
    '    btnSearchByMember.Tag = "FilterbyDate_OfferIDSum"
    'End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        AllRecordsByDate()
        SumOfOfferingPerID()
        Button5.Visible = True
        DataGridView1.Visible = True
        btnSearchByMember.Visible = True
        'grpTotals.Visible = True
        btnSearchByMember.Tag = "FilterByDate"
        DataGridView1.Columns("MemberID").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.Columns("MemberID").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.Columns("MemberID").Width = 60
        DataGridView1.Columns("MidName").Width = 60

        'DataGridView1.GridColor = Color.Black
    End Sub

    Private Sub SumOfOfferingPerID()
        Dim SumOfTI, SumOfLO, SumOfFP As Decimal
        For x = 0 To DataGridView1.Rows.Count - 1 Step 1

            If DataGridView1.Rows(x).Cells("OfferingID").Value = "TI" Then
                SumOfTI += DataGridView1.Rows(x).Cells("Amount").Value
            End If

            If DataGridView1.Rows(x).Cells("OfferingID").Value = "LO" Then
                SumOfLO += DataGridView1.Rows(x).Cells("Amount").Value
            End If

            If DataGridView1.Rows(x).Cells("OfferingID").Value = "FP" Then
                SumOfFP += DataGridView1.Rows(x).Cells("Amount").Value
            End If

        Next
        txtSumofTithes.Text = SumOfTI.ToString("##,##.00")
        txtLO.Text = SumOfLO.ToString("##,##.00")
        txtFP.Text = SumOfFP.ToString("##,##.00")
    End Sub
    'Print Preview Button
    Private Sub btnSearchByMember_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchByMember.Click
        frm_viewRecordByMember.Show()
        Dim dt As DataTable = Nothing
        Dim adapter As New DataSet1TableAdapters.DataTable1TableAdapter

        With frm_viewRecordByMember
            dt = frm_viewRecordByMember.DataSet1.DataTable1

            Select Case btnSearchByMember.Tag
                Case " "
                    adapter.FillBy(dt, DataGridView1.CurrentRow.Cells(1).Value, DataGridView1.CurrentRow.Cells(2).Value)
                Case "FilterByDate"
                    adapter.FillByDate(dt, Format(DTPicker3.Value.ToString("yyyy/MM/dd")), Format(DTPicker4.Value.ToString("yyyy/MM/dd")))
                Case "FilterMemberByDate"
                    adapter.FillByMemberByDate(dt, DataGridView1.CurrentRow.Cells("Lastname").Value, DataGridView1.CurrentRow.Cells("Firstname").Value, (DTPicker1.Value.ToString("yyyy/MM/dd")), Format(DTPicker2.Value.ToString("yyyy/MM/dd")))
                    'Case "FilterbyDate_OfferIDSum"
                    '   adapter.FillByOfferingTypeSummary(dt, Format(DTPicker1.Value.ToString("yyyy/MM/dd")), Format(DTPicker2.Value.ToString("yyyy/MM/dd")))
            End Select


            Dim NewDataSource As New ReportDataSource("DataSet1", dt)

            .ReportViewer1.LocalReport.DataSources.Add(NewDataSource)
            .ReportViewer1.LocalReport.Refresh()
            .ReportViewer1.RefreshReport()


        End With
    End Sub



    Private Sub DataGridView1_DataSourceChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.DataSourceChanged
        DataGridView1.Columns("amount").DefaultCellStyle.Format = "##,##.00"
    End Sub


    Private Sub btnSearchByMemberByDate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchByMemberByDate.Click
        If TextBox1.Text = " " Then
            btnSearchByMember.Tag = ""
        Else
            btnSearchByMember.Tag = "FilterMemberByDate"
        End If

        OfferingListByMember_ByDate()
        DataGridView1.Visible = True
    End Sub
End Class