<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_member_offering
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_member_offering))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txt_amount = New System.Windows.Forms.TextBox()
        Me.cbo_offer_id = New System.Windows.Forms.ComboBox()
        Me.DTPicker4 = New System.Windows.Forms.DateTimePicker()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtmid = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtfname = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtlname = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_member_id = New System.Windows.Forms.TextBox()
        Me.ListView2 = New System.Windows.Forms.ListView()
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtlname_search = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Teal
        Me.GroupBox1.Controls.Add(Me.DataGridView2)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.txtmid)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtfname)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtlname)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txt_member_id)
        Me.GroupBox1.Controls.Add(Me.ListView2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtlname_search)
        Me.GroupBox1.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Location = New System.Drawing.Point(15, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(709, 410)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Member Offering Entry"
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AllowUserToResizeColumns = False
        Me.DataGridView2.AllowUserToResizeRows = False
        Me.DataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(248, 16)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.RowHeadersVisible = False
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(439, 177)
        Me.DataGridView2.TabIndex = 40
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(248, 199)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(439, 194)
        Me.DataGridView1.TabIndex = 39
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnUpdate)
        Me.GroupBox2.Controls.Add(Me.btndelete)
        Me.GroupBox2.Controls.Add(Me.txtID)
        Me.GroupBox2.Controls.Add(Me.txt_amount)
        Me.GroupBox2.Controls.Add(Me.cbo_offer_id)
        Me.GroupBox2.Controls.Add(Me.DTPicker4)
        Me.GroupBox2.Controls.Add(Me.btnSave)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(18, 190)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(214, 203)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Offering Entry"
        '
        'btnUpdate
        '
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnUpdate.Location = New System.Drawing.Point(84, 118)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(106, 32)
        Me.btnUpdate.TabIndex = 6
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.Enabled = False
        Me.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndelete.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btndelete.Location = New System.Drawing.Point(84, 156)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(106, 32)
        Me.btndelete.TabIndex = 38
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'txtID
        '
        Me.txtID.BackColor = System.Drawing.Color.LightGray
        Me.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtID.Location = New System.Drawing.Point(6, 19)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(55, 22)
        Me.txtID.TabIndex = 1
        Me.txtID.Visible = False
        '
        'txt_amount
        '
        Me.txt_amount.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_amount.Location = New System.Drawing.Point(134, 21)
        Me.txt_amount.Multiline = True
        Me.txt_amount.Name = "txt_amount"
        Me.txt_amount.Size = New System.Drawing.Size(67, 25)
        Me.txt_amount.TabIndex = 3
        '
        'cbo_offer_id
        '
        Me.cbo_offer_id.FormattingEnabled = True
        Me.cbo_offer_id.Location = New System.Drawing.Point(67, 21)
        Me.cbo_offer_id.Name = "cbo_offer_id"
        Me.cbo_offer_id.Size = New System.Drawing.Size(64, 25)
        Me.cbo_offer_id.TabIndex = 2
        '
        'DTPicker4
        '
        Me.DTPicker4.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPicker4.Location = New System.Drawing.Point(67, 52)
        Me.DTPicker4.Name = "DTPicker4"
        Me.DTPicker4.Size = New System.Drawing.Size(134, 22)
        Me.DTPicker4.TabIndex = 4
        '
        'btnSave
        '
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnSave.Location = New System.Drawing.Point(84, 80)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(106, 32)
        Me.btnSave.TabIndex = 5
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtmid
        '
        Me.txtmid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtmid.Location = New System.Drawing.Point(103, 152)
        Me.txtmid.Multiline = True
        Me.txtmid.Name = "txtmid"
        Me.txtmid.ReadOnly = True
        Me.txtmid.Size = New System.Drawing.Size(130, 25)
        Me.txtmid.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 154)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 16)
        Me.Label8.TabIndex = 35
        Me.Label8.Text = "MiddleName:"
        '
        'txtfname
        '
        Me.txtfname.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtfname.Location = New System.Drawing.Point(103, 118)
        Me.txtfname.Multiline = True
        Me.txtfname.Name = "txtfname"
        Me.txtfname.ReadOnly = True
        Me.txtfname.Size = New System.Drawing.Size(130, 25)
        Me.txtfname.TabIndex = 10
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(31, 87)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 16)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "Lastname:"
        '
        'txtlname
        '
        Me.txtlname.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtlname.Location = New System.Drawing.Point(103, 84)
        Me.txtlname.Multiline = True
        Me.txtlname.Name = "txtlname"
        Me.txtlname.ReadOnly = True
        Me.txtlname.Size = New System.Drawing.Size(130, 25)
        Me.txtlname.TabIndex = 9
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(31, 118)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 16)
        Me.Label10.TabIndex = 30
        Me.Label10.Text = "Firstname:"
        '
        'txt_member_id
        '
        Me.txt_member_id.BackColor = System.Drawing.SystemColors.Control
        Me.txt_member_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_member_id.Location = New System.Drawing.Point(38, 50)
        Me.txt_member_id.Name = "txt_member_id"
        Me.txt_member_id.ReadOnly = True
        Me.txt_member_id.Size = New System.Drawing.Size(57, 22)
        Me.txt_member_id.TabIndex = 7
        '
        'ListView2
        '
        Me.ListView2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListView2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader11, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader8})
        Me.ListView2.FullRowSelect = True
        Me.ListView2.GridLines = True
        Me.ListView2.Location = New System.Drawing.Point(248, 16)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(439, 127)
        Me.ListView2.TabIndex = 22
        Me.ListView2.UseCompatibleStateImageBehavior = False
        Me.ListView2.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "ID"
        Me.ColumnHeader11.Width = 45
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Lastname"
        Me.ColumnHeader3.Width = 136
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Firstname"
        Me.ColumnHeader4.Width = 115
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Middlename"
        Me.ColumnHeader8.Width = 120
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Franklin Gothic Book", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(101, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 15)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Find (Lastname)"
        '
        'txtlname_search
        '
        Me.txtlname_search.BackColor = System.Drawing.Color.LightGray
        Me.txtlname_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtlname_search.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtlname_search.Location = New System.Drawing.Point(102, 50)
        Me.txtlname_search.Name = "txtlname_search"
        Me.txtlname_search.Size = New System.Drawing.Size(132, 22)
        Me.txtlname_search.TabIndex = 8
        '
        'frm_member_offering
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(736, 471)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_member_offering"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "OFFERING ENTRY FORM"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtlname_search As System.Windows.Forms.TextBox
    Friend WithEvents DTPicker4 As System.Windows.Forms.DateTimePicker
    Friend WithEvents ListView2 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txt_member_id As System.Windows.Forms.TextBox
    Friend WithEvents txtmid As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtfname As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtlname As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cbo_offer_id As System.Windows.Forms.ComboBox
    Friend WithEvents txt_amount As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
End Class
