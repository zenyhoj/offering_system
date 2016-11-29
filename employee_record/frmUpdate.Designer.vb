<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpdate
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim GroupBox1 As System.Windows.Forms.GroupBox
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DTPicker3 = New System.Windows.Forms.DateTimePicker()
        Me.DTPicker2 = New System.Windows.Forms.DateTimePicker()
        Me.txtother_details = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtsponsor = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtadd = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtgender = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DTPicker1 = New System.Windows.Forms.DateTimePicker()
        Me.btnUpdateRecord = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtmid = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtfname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtlname = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        GroupBox1 = New System.Windows.Forms.GroupBox()
        GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        GroupBox1.BackColor = System.Drawing.Color.Teal
        GroupBox1.Controls.Add(Me.txtid)
        GroupBox1.Controls.Add(Me.Label11)
        GroupBox1.Controls.Add(Me.DTPicker3)
        GroupBox1.Controls.Add(Me.DTPicker2)
        GroupBox1.Controls.Add(Me.txtother_details)
        GroupBox1.Controls.Add(Me.Label10)
        GroupBox1.Controls.Add(Me.txtsponsor)
        GroupBox1.Controls.Add(Me.Label6)
        GroupBox1.Controls.Add(Me.Label7)
        GroupBox1.Controls.Add(Me.Label8)
        GroupBox1.Controls.Add(Me.txtadd)
        GroupBox1.Controls.Add(Me.Label9)
        GroupBox1.Controls.Add(Me.txtgender)
        GroupBox1.Controls.Add(Me.Label1)
        GroupBox1.Controls.Add(Me.DTPicker1)
        GroupBox1.Controls.Add(Me.btnUpdateRecord)
        GroupBox1.Controls.Add(Me.Label5)
        GroupBox1.Controls.Add(Me.txtmid)
        GroupBox1.Controls.Add(Me.Label4)
        GroupBox1.Controls.Add(Me.txtfname)
        GroupBox1.Controls.Add(Me.Label3)
        GroupBox1.Controls.Add(Me.txtlname)
        GroupBox1.Controls.Add(Me.Label2)
        GroupBox1.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GroupBox1.ForeColor = System.Drawing.Color.White
        GroupBox1.ImeMode = System.Windows.Forms.ImeMode.Off
        GroupBox1.Location = New System.Drawing.Point(13, 13)
        GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New System.Drawing.Size(597, 262)
        GroupBox1.TabIndex = 15
        GroupBox1.TabStop = False
        GroupBox1.Text = "Member Information"
        '
        'txtid
        '
        Me.txtid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtid.Enabled = False
        Me.txtid.Location = New System.Drawing.Point(43, 218)
        Me.txtid.Multiline = True
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(48, 28)
        Me.txtid.TabIndex = 27
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Franklin Gothic Book", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(18, 221)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(19, 16)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "ID"
        '
        'DTPicker3
        '
        Me.DTPicker3.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPicker3.Location = New System.Drawing.Point(409, 97)
        Me.DTPicker3.Name = "DTPicker3"
        Me.DTPicker3.Size = New System.Drawing.Size(169, 22)
        Me.DTPicker3.TabIndex = 11
        '
        'DTPicker2
        '
        Me.DTPicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPicker2.Location = New System.Drawing.Point(409, 67)
        Me.DTPicker2.Name = "DTPicker2"
        Me.DTPicker2.Size = New System.Drawing.Size(169, 22)
        Me.DTPicker2.TabIndex = 10
        '
        'txtother_details
        '
        Me.txtother_details.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtother_details.Location = New System.Drawing.Point(409, 163)
        Me.txtother_details.Multiline = True
        Me.txtother_details.Name = "txtother_details"
        Me.txtother_details.Size = New System.Drawing.Size(175, 28)
        Me.txtother_details.TabIndex = 13
        '
        'Label10
        '
        Me.Label10.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(321, 166)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(82, 17)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Other Details:"
        '
        'txtsponsor
        '
        Me.txtsponsor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtsponsor.Location = New System.Drawing.Point(409, 127)
        Me.txtsponsor.Multiline = True
        Me.txtsponsor.Name = "txtsponsor"
        Me.txtsponsor.Size = New System.Drawing.Size(175, 28)
        Me.txtsponsor.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(344, 131)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 17)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Sponsor:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(305, 101)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 17)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "DateOfBaptism:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(300, 67)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 17)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "DateOfSalvation:"
        '
        'txtadd
        '
        Me.txtadd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtadd.Location = New System.Drawing.Point(409, 31)
        Me.txtadd.Multiline = True
        Me.txtadd.Name = "txtadd"
        Me.txtadd.Size = New System.Drawing.Size(123, 28)
        Me.txtadd.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(345, 33)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 17)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Address:"
        '
        'txtgender
        '
        Me.txtgender.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtgender.Location = New System.Drawing.Point(95, 131)
        Me.txtgender.Multiline = True
        Me.txtgender.Name = "txtgender"
        Me.txtgender.Size = New System.Drawing.Size(175, 28)
        Me.txtgender.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 133)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 17)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Gender:"
        '
        'DTPicker1
        '
        Me.DTPicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPicker1.Location = New System.Drawing.Point(95, 165)
        Me.DTPicker1.Name = "DTPicker1"
        Me.DTPicker1.Size = New System.Drawing.Size(169, 22)
        Me.DTPicker1.TabIndex = 8
        '
        'btnUpdateRecord
        '
        Me.btnUpdateRecord.ForeColor = System.Drawing.Color.Black
        Me.btnUpdateRecord.Location = New System.Drawing.Point(239, 202)
        Me.btnUpdateRecord.Name = "btnUpdateRecord"
        Me.btnUpdateRecord.Size = New System.Drawing.Size(153, 45)
        Me.btnUpdateRecord.TabIndex = 13
        Me.btnUpdateRecord.Text = "Update Record"
        Me.btnUpdateRecord.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 170)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 17)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "DateOfBirth:"
        '
        'txtmid
        '
        Me.txtmid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtmid.Location = New System.Drawing.Point(95, 97)
        Me.txtmid.Multiline = True
        Me.txtmid.Name = "txtmid"
        Me.txtmid.Size = New System.Drawing.Size(175, 28)
        Me.txtmid.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "MiddleName:"
        '
        'txtfname
        '
        Me.txtfname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtfname.Location = New System.Drawing.Point(95, 63)
        Me.txtfname.Multiline = True
        Me.txtfname.Name = "txtfname"
        Me.txtfname.Size = New System.Drawing.Size(125, 28)
        Me.txtfname.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Firstname:"
        '
        'txtlname
        '
        Me.txtlname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtlname.Location = New System.Drawing.Point(95, 29)
        Me.txtlname.Multiline = True
        Me.txtlname.Name = "txtlname"
        Me.txtlname.Size = New System.Drawing.Size(123, 28)
        Me.txtlname.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Franklin Gothic Book", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(29, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Lastname:"
        '
        'frmUpdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(619, 287)
        Me.Controls.Add(GroupBox1)
        Me.Name = "frmUpdate"
        Me.Text = "frmUpdate"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DTPicker3 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTPicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtother_details As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtsponsor As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtadd As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtgender As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DTPicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnUpdateRecord As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtmid As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtfname As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtlname As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtid As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
End Class
