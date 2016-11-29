<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainfrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mainfrm))
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.txtid = New System.Windows.Forms.TextBox()
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
        Me.btnAddRecord = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtmid = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtfname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtlname = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        GroupBox1 = New System.Windows.Forms.GroupBox()
        GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        GroupBox1.BackColor = System.Drawing.Color.Teal
        GroupBox1.Controls.Add(Me.btnCancel)
        GroupBox1.Controls.Add(Me.btnUpdate)
        GroupBox1.Controls.Add(Me.txtid)
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
        GroupBox1.Controls.Add(Me.btnAddRecord)
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
        GroupBox1.Location = New System.Drawing.Point(12, 5)
        GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New System.Drawing.Size(597, 219)
        GroupBox1.TabIndex = 14
        GroupBox1.TabStop = False
        GroupBox1.Text = "Member Information"
        '
        'btnCancel
        '
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(311, 165)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(92, 36)
        Me.btnCancel.TabIndex = 31
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Enabled = False
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(203, 165)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(102, 36)
        Me.btnUpdate.TabIndex = 30
        Me.btnUpdate.Text = "Update Record"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'txtid
        '
        Me.txtid.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtid.Enabled = False
        Me.txtid.Location = New System.Drawing.Point(220, 29)
        Me.txtid.Multiline = True
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(48, 25)
        Me.txtid.TabIndex = 29
        '
        'DTPicker3
        '
        Me.DTPicker3.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPicker3.Location = New System.Drawing.Point(409, 80)
        Me.DTPicker3.Name = "DTPicker3"
        Me.DTPicker3.Size = New System.Drawing.Size(123, 22)
        Me.DTPicker3.TabIndex = 11
        '
        'DTPicker2
        '
        Me.DTPicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPicker2.Location = New System.Drawing.Point(409, 56)
        Me.DTPicker2.Name = "DTPicker2"
        Me.DTPicker2.Size = New System.Drawing.Size(123, 22)
        Me.DTPicker2.TabIndex = 10
        '
        'txtother_details
        '
        Me.txtother_details.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtother_details.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtother_details.Location = New System.Drawing.Point(409, 131)
        Me.txtother_details.Multiline = True
        Me.txtother_details.Name = "txtother_details"
        Me.txtother_details.Size = New System.Drawing.Size(175, 25)
        Me.txtother_details.TabIndex = 13
        '
        'Label10
        '
        Me.Label10.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(327, 132)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(82, 17)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Other Details:"
        '
        'txtsponsor
        '
        Me.txtsponsor.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtsponsor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtsponsor.Location = New System.Drawing.Point(409, 104)
        Me.txtsponsor.Multiline = True
        Me.txtsponsor.Name = "txtsponsor"
        Me.txtsponsor.Size = New System.Drawing.Size(175, 25)
        Me.txtsponsor.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(350, 107)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 17)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Sponsor:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(311, 82)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 17)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "DateOfBaptism:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(306, 57)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 17)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "DateOfSalvation:"
        '
        'txtadd
        '
        Me.txtadd.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtadd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtadd.Location = New System.Drawing.Point(409, 29)
        Me.txtadd.Multiline = True
        Me.txtadd.Name = "txtadd"
        Me.txtadd.Size = New System.Drawing.Size(123, 25)
        Me.txtadd.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(351, 33)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 17)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Address:"
        '
        'txtgender
        '
        Me.txtgender.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtgender.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtgender.Location = New System.Drawing.Point(91, 110)
        Me.txtgender.Multiline = True
        Me.txtgender.Name = "txtgender"
        Me.txtgender.Size = New System.Drawing.Size(175, 25)
        Me.txtgender.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 17)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Gender:"
        '
        'DTPicker1
        '
        Me.DTPicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPicker1.Location = New System.Drawing.Point(91, 137)
        Me.DTPicker1.Name = "DTPicker1"
        Me.DTPicker1.Size = New System.Drawing.Size(123, 22)
        Me.DTPicker1.TabIndex = 8
        '
        'btnAddRecord
        '
        Me.btnAddRecord.Enabled = False
        Me.btnAddRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddRecord.ForeColor = System.Drawing.Color.White
        Me.btnAddRecord.Location = New System.Drawing.Point(91, 165)
        Me.btnAddRecord.Name = "btnAddRecord"
        Me.btnAddRecord.Size = New System.Drawing.Size(106, 36)
        Me.btnAddRecord.TabIndex = 13
        Me.btnAddRecord.Text = "Insert Record"
        Me.btnAddRecord.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 140)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 17)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "DateOfBirth:"
        '
        'txtmid
        '
        Me.txtmid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtmid.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtmid.Location = New System.Drawing.Point(91, 83)
        Me.txtmid.Multiline = True
        Me.txtmid.Name = "txtmid"
        Me.txtmid.Size = New System.Drawing.Size(175, 25)
        Me.txtmid.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "MiddleName:"
        '
        'txtfname
        '
        Me.txtfname.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtfname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtfname.Location = New System.Drawing.Point(91, 56)
        Me.txtfname.Multiline = True
        Me.txtfname.Name = "txtfname"
        Me.txtfname.Size = New System.Drawing.Size(125, 25)
        Me.txtfname.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Firstname:"
        '
        'txtlname
        '
        Me.txtlname.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtlname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtlname.Location = New System.Drawing.Point(91, 29)
        Me.txtlname.Multiline = True
        Me.txtlname.Name = "txtlname"
        Me.txtlname.Size = New System.Drawing.Size(125, 25)
        Me.txtlname.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(29, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Lastname:"
        '
        'ListView1
        '
        Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListView1.CheckBoxes = True
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader11, Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(12, 231)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(597, 199)
        Me.ListView1.TabIndex = 16
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "ID"
        Me.ColumnHeader11.Width = 44
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Lastname"
        Me.ColumnHeader1.Width = 85
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Firstname"
        Me.ColumnHeader2.Width = 85
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Middle Initial"
        Me.ColumnHeader3.Width = 85
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Gender"
        Me.ColumnHeader4.Width = 50
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Birth Date"
        Me.ColumnHeader5.Width = 85
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Address"
        Me.ColumnHeader6.Width = 130
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Salvation Date"
        Me.ColumnHeader7.Width = 70
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Baptism Date"
        Me.ColumnHeader8.Width = 70
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Sponsor"
        Me.ColumnHeader9.Width = 85
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Other Details"
        Me.ColumnHeader10.Width = 100
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.LightGray
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox1.Location = New System.Drawing.Point(103, 436)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(175, 20)
        Me.TextBox1.TabIndex = 30
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label12.Location = New System.Drawing.Point(12, 436)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(91, 17)
        Me.Label12.TabIndex = 30
        Me.Label12.Text = "Search Record:"
        '
        'btnDelete
        '
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Location = New System.Drawing.Point(514, 436)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(92, 29)
        Me.btnDelete.TabIndex = 32
        Me.btnDelete.Text = "Delete Record"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'mainfrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(618, 477)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "mainfrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MEMBER ENTRY FORM"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtlname As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtfname As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtmid As System.Windows.Forms.TextBox
    Friend WithEvents btnAddRecord As System.Windows.Forms.Button
    Friend WithEvents DTPicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtgender As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtother_details As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtsponsor As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtadd As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents DTPicker3 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTPicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtid As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button

End Class
