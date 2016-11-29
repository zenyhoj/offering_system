<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class search
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSearchByMemberByDate = New System.Windows.Forms.Button()
        Me.DTPicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DTPicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnSearchByMember = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.DTPicker4 = New System.Windows.Forms.DateTimePicker()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.DTPicker3 = New System.Windows.Forms.DateTimePicker()
        Me.txtSumofTithes = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtLO = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtFP = New System.Windows.Forms.TextBox()
        Me.grpTotals = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.grpTotals.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Teal
        Me.GroupBox1.Controls.Add(Me.btnSearchByMemberByDate)
        Me.GroupBox1.Controls.Add(Me.DTPicker2)
        Me.GroupBox1.Controls.Add(Me.DTPicker1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox1.Location = New System.Drawing.Point(17, 20)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(379, 78)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filter by Member"
        '
        'btnSearchByMemberByDate
        '
        Me.btnSearchByMemberByDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSearchByMemberByDate.Location = New System.Drawing.Point(280, 43)
        Me.btnSearchByMemberByDate.Name = "btnSearchByMemberByDate"
        Me.btnSearchByMemberByDate.Size = New System.Drawing.Size(88, 28)
        Me.btnSearchByMemberByDate.TabIndex = 10
        Me.btnSearchByMemberByDate.Text = "Search"
        Me.btnSearchByMemberByDate.UseVisualStyleBackColor = True
        '
        'DTPicker2
        '
        Me.DTPicker2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPicker2.Location = New System.Drawing.Point(280, 17)
        Me.DTPicker2.Name = "DTPicker2"
        Me.DTPicker2.Size = New System.Drawing.Size(88, 20)
        Me.DTPicker2.TabIndex = 13
        '
        'DTPicker1
        '
        Me.DTPicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPicker1.Location = New System.Drawing.Point(189, 17)
        Me.DTPicker1.Name = "DTPicker1"
        Me.DTPicker1.Size = New System.Drawing.Size(88, 20)
        Me.DTPicker1.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.7!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(14, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(173, 12)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "(Input Member's Firstname or Lastname)"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox1.Font = New System.Drawing.Font("Franklin Gothic Book", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.TextBox1.Location = New System.Drawing.Point(6, 15)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(181, 22)
        Me.TextBox1.TabIndex = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.GridColor = System.Drawing.Color.Teal
        Me.DataGridView1.Location = New System.Drawing.Point(17, 104)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(615, 143)
        Me.DataGridView1.TabIndex = 5
        '
        'btnSearchByMember
        '
        Me.btnSearchByMember.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSearchByMember.Location = New System.Drawing.Point(17, 253)
        Me.btnSearchByMember.Name = "btnSearchByMember"
        Me.btnSearchByMember.Size = New System.Drawing.Size(109, 54)
        Me.btnSearchByMember.TabIndex = 7
        Me.btnSearchByMember.Text = "Print Preview"
        Me.btnSearchByMember.UseVisualStyleBackColor = True
        Me.btnSearchByMember.Visible = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.DTPicker4)
        Me.GroupBox4.Controls.Add(Me.Button5)
        Me.GroupBox4.Controls.Add(Me.DTPicker3)
        Me.GroupBox4.ForeColor = System.Drawing.Color.White
        Me.GroupBox4.Location = New System.Drawing.Point(427, 20)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(205, 78)
        Me.GroupBox4.TabIndex = 10
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Filter by Date"
        '
        'DTPicker4
        '
        Me.DTPicker4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPicker4.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPicker4.Location = New System.Drawing.Point(104, 19)
        Me.DTPicker4.Name = "DTPicker4"
        Me.DTPicker4.Size = New System.Drawing.Size(88, 20)
        Me.DTPicker4.TabIndex = 9
        '
        'Button5
        '
        Me.Button5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button5.Location = New System.Drawing.Point(10, 44)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(88, 28)
        Me.Button5.TabIndex = 8
        Me.Button5.Text = "Search"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'DTPicker3
        '
        Me.DTPicker3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPicker3.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPicker3.Location = New System.Drawing.Point(10, 19)
        Me.DTPicker3.Name = "DTPicker3"
        Me.DTPicker3.Size = New System.Drawing.Size(88, 20)
        Me.DTPicker3.TabIndex = 6
        '
        'txtSumofTithes
        '
        Me.txtSumofTithes.BackColor = System.Drawing.Color.White
        Me.txtSumofTithes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSumofTithes.Font = New System.Drawing.Font("Trebuchet MS", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSumofTithes.ForeColor = System.Drawing.Color.Teal
        Me.txtSumofTithes.Location = New System.Drawing.Point(91, 19)
        Me.txtSumofTithes.Multiline = True
        Me.txtSumofTithes.Name = "txtSumofTithes"
        Me.txtSumofTithes.Size = New System.Drawing.Size(117, 23)
        Me.txtSumofTithes.TabIndex = 40
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.MintCream
        Me.Label2.Location = New System.Drawing.Point(8, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 18)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Tithes"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.MintCream
        Me.Label3.Location = New System.Drawing.Point(8, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 18)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "Love Offering"
        '
        'txtLO
        '
        Me.txtLO.BackColor = System.Drawing.Color.White
        Me.txtLO.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtLO.Font = New System.Drawing.Font("Trebuchet MS", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLO.ForeColor = System.Drawing.Color.Teal
        Me.txtLO.Location = New System.Drawing.Point(91, 45)
        Me.txtLO.Multiline = True
        Me.txtLO.Name = "txtLO"
        Me.txtLO.Size = New System.Drawing.Size(117, 23)
        Me.txtLO.TabIndex = 42
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.MintCream
        Me.Label4.Location = New System.Drawing.Point(8, 71)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 18)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "Faith Promise"
        '
        'txtFP
        '
        Me.txtFP.BackColor = System.Drawing.Color.White
        Me.txtFP.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFP.Font = New System.Drawing.Font("Trebuchet MS", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFP.ForeColor = System.Drawing.Color.Teal
        Me.txtFP.Location = New System.Drawing.Point(91, 71)
        Me.txtFP.Multiline = True
        Me.txtFP.Name = "txtFP"
        Me.txtFP.Size = New System.Drawing.Size(117, 23)
        Me.txtFP.TabIndex = 44
        '
        'grpTotals
        '
        Me.grpTotals.Controls.Add(Me.Label4)
        Me.grpTotals.Controls.Add(Me.txtSumofTithes)
        Me.grpTotals.Controls.Add(Me.txtFP)
        Me.grpTotals.Controls.Add(Me.Label2)
        Me.grpTotals.Controls.Add(Me.Label3)
        Me.grpTotals.Controls.Add(Me.txtLO)
        Me.grpTotals.Location = New System.Drawing.Point(411, 249)
        Me.grpTotals.Name = "grpTotals"
        Me.grpTotals.Size = New System.Drawing.Size(220, 129)
        Me.grpTotals.TabIndex = 46
        Me.grpTotals.TabStop = False
        Me.grpTotals.Visible = False
        '
        'search
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(653, 394)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.btnSearchByMember)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grpTotals)
        Me.ForeColor = System.Drawing.Color.Teal
        Me.Name = "search"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Search/Query Form"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.grpTotals.ResumeLayout(False)
        Me.grpTotals.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnSearchByMember As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents DTPicker4 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents DTPicker3 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSumofTithes As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtLO As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtFP As System.Windows.Forms.TextBox
    Friend WithEvents grpTotals As System.Windows.Forms.GroupBox
    Friend WithEvents DTPicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTPicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnSearchByMemberByDate As System.Windows.Forms.Button
End Class
