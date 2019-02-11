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
        Me.components = New System.ComponentModel.Container()
        Me.SearchBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Login_Button = New System.Windows.Forms.Button()
        Me.Button_search = New System.Windows.Forms.Button()
        Me.RadioButton_dept = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox_dept = New System.Windows.Forms.ComboBox()
        Me.RadioButton_Name = New System.Windows.Forms.RadioButton()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column5 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SearchBox
        '
        Me.SearchBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchBox.Location = New System.Drawing.Point(100, 179)
        Me.SearchBox.Margin = New System.Windows.Forms.Padding(4)
        Me.SearchBox.Name = "SearchBox"
        Me.SearchBox.Size = New System.Drawing.Size(747, 30)
        Me.SearchBox.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 25.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(313, 83)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(351, 67)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Faculty Search"
        '
        'Login_Button
        '
        Me.Login_Button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Login_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Login_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Login_Button.Location = New System.Drawing.Point(780, 15)
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
        Me.Button_search.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_search.ForeColor = System.Drawing.Color.White
        Me.Button_search.Location = New System.Drawing.Point(389, 367)
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
        Me.RadioButton_dept.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton_dept.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton_dept.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.RadioButton_dept.Location = New System.Drawing.Point(100, 251)
        Me.RadioButton_dept.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioButton_dept.Name = "RadioButton_dept"
        Me.RadioButton_dept.Size = New System.Drawing.Size(128, 28)
        Me.RadioButton_dept.TabIndex = 4
        Me.RadioButton_dept.TabStop = True
        Me.RadioButton_dept.Text = "Department"
        Me.RadioButton_dept.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(96, 223)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 24)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Search By -"
        '
        'ComboBox_dept
        '
        Me.ComboBox_dept.BackColor = System.Drawing.Color.White
        Me.ComboBox_dept.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ComboBox_dept.ForeColor = System.Drawing.Color.Black
        Me.ComboBox_dept.FormattingEnabled = True
        Me.ComboBox_dept.Items.AddRange(New Object() {"Bioscience and Bioengineering", "Chemical Engineering", "Chemistry", "Civil Engineering", "Computer Science and Engineering", "Design", "Electronics and Electrical Engineering", "Humanities and Social Science", "Mathematics", "Mechanical Engineering", "Physics"})
        Me.ComboBox_dept.Location = New System.Drawing.Point(322, 252)
        Me.ComboBox_dept.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox_dept.Name = "ComboBox_dept"
        Me.ComboBox_dept.Size = New System.Drawing.Size(405, 24)
        Me.ComboBox_dept.TabIndex = 7
        Me.ComboBox_dept.Text = "---------------Select Department-------------------"
        '
        'RadioButton_Name
        '
        Me.RadioButton_Name.AutoSize = True
        Me.RadioButton_Name.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton_Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton_Name.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.RadioButton_Name.Location = New System.Drawing.Point(100, 282)
        Me.RadioButton_Name.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioButton_Name.Name = "RadioButton_Name"
        Me.RadioButton_Name.Size = New System.Drawing.Size(82, 28)
        Me.RadioButton_Name.TabIndex = 8
        Me.RadioButton_Name.TabStop = True
        Me.RadioButton_Name.Text = "Name"
        Me.RadioButton_Name.UseVisualStyleBackColor = False
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column5, Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.Info
        Me.DataGridView1.Location = New System.Drawing.Point(15, 450)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(925, 265)
        Me.DataGridView1.TabIndex = 10
        '
        'Column5
        '
        Me.Column5.FillWeight = 63.40084!
        Me.Column5.HeaderText = "Profile Photo"
        Me.Column5.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.FillWeight = 89.23042!
        Me.Column1.HeaderText = "Name"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.FillWeight = 118.6017!
        Me.Column2.HeaderText = "Department"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.FillWeight = 178.0056!
        Me.Column3.HeaderText = "Email"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "Name"
        Me.Column4.FillWeight = 50.76142!
        Me.Column4.HeaderText = "View More"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Text = "Go to Faculty Page"
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.RadioButton2.Location = New System.Drawing.Point(100, 313)
        Me.RadioButton2.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(177, 28)
        Me.RadioButton2.TabIndex = 5
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Research Interest"
        Me.RadioButton2.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.Faculty_Information_System.My.Resources.Resources._220px_User_icon_21
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(813, 179)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(34, 30)
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = Global.Faculty_Information_System.My.Resources.Resources._47949
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(207, 66)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(112, 97)
        Me.PictureBox2.TabIndex = 12
        Me.PictureBox2.TabStop = False
        '
        'Search_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackgroundImage = Global.Faculty_Information_System.My.Resources.Resources.core_2_iitg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(956, 729)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.RadioButton_Name)
        Me.Controls.Add(Me.ComboBox_dept)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton_dept)
        Me.Controls.Add(Me.Button_search)
        Me.Controls.Add(Me.Login_Button)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SearchBox)
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Search_Form"
        Me.Text = "SEARCH"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
End Class
