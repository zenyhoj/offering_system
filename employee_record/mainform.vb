Imports System.IO
Public Class mainform

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        mainfrm.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frm_offering.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frm_member_offering.Show()
    End Sub


    Private Sub mainform_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label2.Text = DateTime.Now.ToString("D")
    End Sub

    Private Sub Timer1_Tick_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label3.Text = DateTime.Now.ToString("T")
    End Sub

    Private Sub Button4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        frm_offering.Show()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        search.Show()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        mainfrm.Show()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        frm_member_offering.Show()

    End Sub

    Private Sub btn_DBBackup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_DBBackup.Click
        'Dim foldername_date As String = "E:\YHOJ\PROGRAMMING\VB.NET\DATABASES\church_offering Backup" & Date.Now.ToString("yyyy-MM-dd hh-mm-ss")
        'btn_DBBackup.Refresh()
        'My.Computer.FileSystem.CreateDirectory(foldername_date)

        ''copys all files to foldername_date
        'My.Computer.FileSystem.CopyDirectory("C:\wamp\bin\mysql\mysql5.5.24\data\church_offering\", (foldername_date), True)
        'MsgBox("Backup Successfully Created", vbOKOnly)
        Dim bckUp As New FolderBrowserDialog
        If bckUp.ShowDialog(Me) = vbOK Then
            Process.Start("C:\wamp\bin\mysql\mysql5.5.24\bin\mysqldump.exe", "-u root church_offering -r""" & bckUp.SelectedPath & "\church_offering" & Date.Now.ToString("yyyy-MM-dd hh-mm-ss") & ".sql")
        End If
        'MsgBox("Backup Successfully Created", vbOKOnly)
    End Sub
End Class