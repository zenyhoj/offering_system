Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms
Public Class frm_viewRecordByMember

    Private Sub frm_viewRecordByMember_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.DataTable1' table. You can move, or remove it, as needed.
        Me.DataTable1TableAdapter.Fill(Me.DataSet1.DataTable1)
        Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.ReportViewer1.RefreshReport()
    End Sub

End Class