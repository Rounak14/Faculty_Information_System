<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Search_Form
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
        Me.SearchBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Login_Button = New System.Windows.Forms.Button()
        Me.Button_search = New System.Windows.Forms.Button()
        Me.RadioButton_dept = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox_dept = New System.Windows.Forms.ComboBox()
        Me.RadioButton_Name = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SearchBox
        '
        Me.SearchBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchBox.Location = New System.Drawing.Point(73, 161)
        Me.SearchBox.Margin = New System.Windows.Forms.Padding(4)
        Me.SearchBox.Name = "SearchBox"
        Me.SearchBox.Size = New System.Drawing.Size(593, 30)
        Me.SearchBox.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift Condensed", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(251, 84)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(219, 58)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Faculty Search"
        '
        'Login_Button
        '
        Me.Login_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Login_Button.Location = New System.Drawing.Point(571, 15)
        Me.Login_Button.Margin = New System.Windows.Forms.Padding(4)
        Me.Login_Button.Name = "Login_Button"
        Me.Login_Button.Size = New System.Drawing.Size(160, 42)
        Me.Login_Button.TabIndex = 2
        Me.Login_Button.Text = "Login"
        Me.Login_Button.UseVisualStyleBackColor = True
        '
        'Button_search
        '
        Me.Button_search.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Button_search.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_search.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button_search.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_search.ForeColor = System.Drawing.Color.White
        Me.Button_search.Location = New System.Drawing.Point(280, 331)
        Me.Button_search.Margin = New System.Windows.Forms.Padding(4)
        Me.Button_search.Name = "Button_search"
        Me.Button_search.Size = New System.Drawing.Size(160, 36)
        Me.Button_search.TabIndex = 3
        Me.Button_search.Text = "SEARCH"
        Me.Button_search.UseVisualStyleBackColor = False
        '
        'RadioButton_dept
        '
        Me.RadioButton_dept.AutoSize = True
        Me.RadioButton_dept.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton_dept.Location = New System.Drawing.Point(73, 225)
        Me.RadioButton_dept.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioButton_dept.Name = "RadioButton_dept"
        Me.RadioButton_dept.Size = New System.Drawing.Size(106, 22)
        Me.RadioButton_dept.TabIndex = 4
        Me.RadioButton_dept.TabStop = True
        Me.RadioButton_dept.Text = "Department"
        Me.RadioButton_dept.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(73, 287)
        Me.RadioButton2.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(145, 22)
        Me.RadioButton2.TabIndex = 5
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Research Interest"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(73, 202)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Search By -"
        '
        'ComboBox_dept
        '
        Me.ComboBox_dept.FormattingEnabled = True
        Me.ComboBox_dept.Items.AddRange(New Object() {"Bioscience and Bioengineering", "Chemical Engineering", "Chemistry", "Civil Engineering", "Computer Science and Engineering", "Design", "Electronics and Electrical Engineering", "Humanities and Social Science", "Mathematics", "Mechanical Engineering", "Physics"})
        Me.ComboBox_dept.Location = New System.Drawing.Point(251, 226)
        Me.ComboBox_dept.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox_dept.Name = "ComboBox_dept"
        Me.ComboBox_dept.Size = New System.Drawing.Size(275, 24)
        Me.ComboBox_dept.TabIndex = 7
        Me.ComboBox_dept.Text = "---------------Select Department-------------------"
        '
        'RadioButton_Name
        '
        Me.RadioButton_Name.AutoSize = True
        Me.RadioButton_Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton_Name.Location = New System.Drawing.Point(73, 256)
        Me.RadioButton_Name.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioButton_Name.Name = "RadioButton_Name"
        Me.RadioButton_Name.Size = New System.Drawing.Size(69, 22)
        Me.RadioButton_Name.TabIndex = 8
        Me.RadioButton_Name.TabStop = True
        Me.RadioButton_Name.Text = "Name"
        Me.RadioButton_Name.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(253, 402)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(221, 32)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Search Results"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.LightGray
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.Info
        Me.DataGridView1.Location = New System.Drawing.Point(20, 473)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(743, 44)
        Me.DataGridView1.TabIndex = 10
        '
        'Search_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(775, 517)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.RadioButton_Name)
        Me.Controls.Add(Me.ComboBox_dept)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton_dept)
        Me.Controls.Add(Me.Button_search)
        Me.Controls.Add(Me.Login_Button)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SearchBox)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Search_Form"
        Me.Text = "Search_Form"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SearchBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Login_Button As System.Windows.Forms.Button
    Friend WithEvents Button_search As System.Windows.Forms.Button
    Friend WithEvents RadioButton_dept As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ComboBox_dept As System.Windows.Forms.ComboBox
    Friend WithEvents RadioButton_Name As System.Windows.Forms.RadioButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
End Class
