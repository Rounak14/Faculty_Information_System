<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddProf
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
        Dim NameLabel As System.Windows.Forms.Label
        Dim DepartmentLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim PasswordLabel As System.Windows.Forms.Label
        Me.Faculty_databaseDataSet = New Faculty_Information_System.Faculty_databaseDataSet()
        Me.Faculty_infoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Faculty_infoTableAdapter = New Faculty_Information_System.Faculty_databaseDataSetTableAdapters.faculty_infoTableAdapter()
        Me.TableAdapterManager = New Faculty_Information_System.Faculty_databaseDataSetTableAdapters.TableAdapterManager()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Update = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        NameLabel = New System.Windows.Forms.Label()
        DepartmentLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        PasswordLabel = New System.Windows.Forms.Label()
        CType(Me.Faculty_databaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Faculty_infoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Location = New System.Drawing.Point(44, 42)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(49, 17)
        NameLabel.TabIndex = 1
        NameLabel.Text = "Name:"
        '
        'DepartmentLabel
        '
        DepartmentLabel.AutoSize = True
        DepartmentLabel.Location = New System.Drawing.Point(44, 89)
        DepartmentLabel.Name = "DepartmentLabel"
        DepartmentLabel.Size = New System.Drawing.Size(86, 17)
        DepartmentLabel.TabIndex = 3
        DepartmentLabel.Text = "Department:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(44, 138)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(46, 17)
        EmailLabel.TabIndex = 5
        EmailLabel.Text = "Email:"
        '
        'PasswordLabel
        '
        PasswordLabel.AutoSize = True
        PasswordLabel.Location = New System.Drawing.Point(44, 190)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New System.Drawing.Size(73, 17)
        PasswordLabel.TabIndex = 7
        PasswordLabel.Text = "Password:"
        '
        'Faculty_databaseDataSet
        '
        Me.Faculty_databaseDataSet.DataSetName = "Faculty_databaseDataSet"
        Me.Faculty_databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Faculty_infoBindingSource
        '
        Me.Faculty_infoBindingSource.DataMember = "faculty_info"
        Me.Faculty_infoBindingSource.DataSource = Me.Faculty_databaseDataSet
        '
        'Faculty_infoTableAdapter
        '
        Me.Faculty_infoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AchievementsTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.EducationTableAdapter = Nothing
        Me.TableAdapterManager.ExperienceTableAdapter = Nothing
        Me.TableAdapterManager.faculty_infoTableAdapter = Me.Faculty_infoTableAdapter
        Me.TableAdapterManager.NewsTableAdapter = Nothing
        Me.TableAdapterManager.PublicationsTableAdapter = Nothing
        Me.TableAdapterManager.Research_InterestTableAdapter = Nothing
        Me.TableAdapterManager.TeachingTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Faculty_Information_System.Faculty_databaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Faculty_infoBindingSource, "Name", True))
        Me.TextBox1.Location = New System.Drawing.Point(168, 42)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(143, 22)
        Me.TextBox1.TabIndex = 2
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Faculty_infoBindingSource, "Email", True))
        Me.TextBox3.Location = New System.Drawing.Point(168, 138)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(143, 22)
        Me.TextBox3.TabIndex = 6
        '
        'TextBox4
        '
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Faculty_infoBindingSource, "Password", True))
        Me.TextBox4.Location = New System.Drawing.Point(168, 190)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox4.Size = New System.Drawing.Size(143, 22)
        Me.TextBox4.TabIndex = 8
        '
        'Update
        '
        Me.Update.Location = New System.Drawing.Point(185, 278)
        Me.Update.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Update.Name = "Update"
        Me.Update.Size = New System.Drawing.Size(112, 32)
        Me.Update.TabIndex = 9
        Me.Update.Text = "Update"
        Me.Update.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(41, 236)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 18)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Confirm Password"
        '
        'TextBox5
        '
        Me.TextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Faculty_infoBindingSource, "Password", True))
        Me.TextBox5.Location = New System.Drawing.Point(168, 233)
        Me.TextBox5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox5.Size = New System.Drawing.Size(143, 22)
        Me.TextBox5.TabIndex = 11
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(357, 278)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 32)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Bioscience and Bioengineering", "Chemical Engineering", "Chemistry", "Civil Engineering", "Computer Science and Engineering", "Design", "Electronics and Electrical Engineering", "Humanities and Social Science", "Mathematics", "Mechanical Engineering", "Physics"})
        Me.ComboBox1.Location = New System.Drawing.Point(168, 89)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(143, 24)
        Me.ComboBox1.TabIndex = 13
        '
        'AddProf
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(589, 352)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Update)
        Me.Controls.Add(PasswordLabel)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(DepartmentLabel)
        Me.Controls.Add(NameLabel)
        Me.Controls.Add(Me.TextBox1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "AddProf"
        Me.Text = "7"
        CType(Me.Faculty_databaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Faculty_infoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Faculty_databaseDataSet As Faculty_Information_System.Faculty_databaseDataSet
    Friend WithEvents Faculty_infoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Faculty_infoTableAdapter As Faculty_Information_System.Faculty_databaseDataSetTableAdapters.faculty_infoTableAdapter
    Friend WithEvents TableAdapterManager As Faculty_Information_System.Faculty_databaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Update As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
End Class
