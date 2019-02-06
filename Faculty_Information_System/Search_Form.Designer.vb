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
        Me.SuspendLayout()
        '
        'SearchBox
        '
        Me.SearchBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchBox.Location = New System.Drawing.Point(55, 131)
        Me.SearchBox.Name = "SearchBox"
        Me.SearchBox.Size = New System.Drawing.Size(446, 26)
        Me.SearchBox.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(188, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(216, 47)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Faculty Search"
        '
        'Login_Button
        '
        Me.Login_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Login_Button.Location = New System.Drawing.Point(428, 12)
        Me.Login_Button.Name = "Login_Button"
        Me.Login_Button.Size = New System.Drawing.Size(120, 34)
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
        Me.Button_search.Location = New System.Drawing.Point(210, 269)
        Me.Button_search.Name = "Button_search"
        Me.Button_search.Size = New System.Drawing.Size(120, 29)
        Me.Button_search.TabIndex = 3
        Me.Button_search.Text = "SEARCH"
        Me.Button_search.UseVisualStyleBackColor = False
        '
        'RadioButton_dept
        '
        Me.RadioButton_dept.AutoSize = True
        Me.RadioButton_dept.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton_dept.Location = New System.Drawing.Point(55, 183)
        Me.RadioButton_dept.Name = "RadioButton_dept"
        Me.RadioButton_dept.Size = New System.Drawing.Size(90, 19)
        Me.RadioButton_dept.TabIndex = 4
        Me.RadioButton_dept.TabStop = True
        Me.RadioButton_dept.Text = "Department"
        Me.RadioButton_dept.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(55, 233)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(121, 19)
        Me.RadioButton2.TabIndex = 5
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Research Interest"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(55, 164)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Search By -"
        '
        'ComboBox_dept
        '
        Me.ComboBox_dept.FormattingEnabled = True
        Me.ComboBox_dept.Items.AddRange(New Object() {"Bioscience and Bioengineering", "Chemical Engineering", "Chemistry", "Civil Engineering", "Computer Science and Engineering", "Design", "Electronics and Electrical Engineering", "Humanities and Social Science", "Mathematics", "Mechanical Engineering", "Physics"})
        Me.ComboBox_dept.Location = New System.Drawing.Point(188, 184)
        Me.ComboBox_dept.Name = "ComboBox_dept"
        Me.ComboBox_dept.Size = New System.Drawing.Size(207, 21)
        Me.ComboBox_dept.TabIndex = 7
        Me.ComboBox_dept.Text = "---------------Select Department-------------------"
        '
        'RadioButton_Name
        '
        Me.RadioButton_Name.AutoSize = True
        Me.RadioButton_Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton_Name.Location = New System.Drawing.Point(55, 208)
        Me.RadioButton_Name.Name = "RadioButton_Name"
        Me.RadioButton_Name.Size = New System.Drawing.Size(59, 19)
        Me.RadioButton_Name.TabIndex = 8
        Me.RadioButton_Name.TabStop = True
        Me.RadioButton_Name.Text = "Name"
        Me.RadioButton_Name.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(190, 327)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(174, 26)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Search Results"
        '
        'Search_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(572, 317)
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
        Me.Name = "Search_Form"
        Me.Text = "Search_Form"
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
End Class
