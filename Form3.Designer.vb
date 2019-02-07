<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DelProf
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
        Me.Delete = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBoxdel_dep = New System.Windows.Forms.ComboBox()
        Me.TextBoxdel_email = New System.Windows.Forms.TextBox()
        Me.TextBoxdel_user = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Delete
        '
        Me.Delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Delete.Location = New System.Drawing.Point(260, 276)
        Me.Delete.Name = "Delete"
        Me.Delete.Size = New System.Drawing.Size(198, 44)
        Me.Delete.TabIndex = 27
        Me.Delete.Text = "Delete Member"
        Me.Delete.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(104, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(512, 33)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Please Fill in the Following entries :"
        '
        'ComboBoxdel_dep
        '
        Me.ComboBoxdel_dep.AutoCompleteCustomSource.AddRange(New String() {"Computer Science and Engineering"})
        Me.ComboBoxdel_dep.FormattingEnabled = True
        Me.ComboBoxdel_dep.Location = New System.Drawing.Point(260, 215)
        Me.ComboBoxdel_dep.Name = "ComboBoxdel_dep"
        Me.ComboBoxdel_dep.Size = New System.Drawing.Size(356, 21)
        Me.ComboBoxdel_dep.TabIndex = 25
        Me.ComboBoxdel_dep.Text = "                               ---------------Select Department------------------" &
    "-"
        '
        'TextBoxdel_email
        '
        Me.TextBoxdel_email.Location = New System.Drawing.Point(260, 161)
        Me.TextBoxdel_email.Name = "TextBoxdel_email"
        Me.TextBoxdel_email.Size = New System.Drawing.Size(356, 20)
        Me.TextBoxdel_email.TabIndex = 24
        '
        'TextBoxdel_user
        '
        Me.TextBoxdel_user.Location = New System.Drawing.Point(260, 114)
        Me.TextBoxdel_user.Name = "TextBoxdel_user"
        Me.TextBoxdel_user.Size = New System.Drawing.Size(356, 20)
        Me.TextBoxdel_user.TabIndex = 23
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(107, 213)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 24)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Department :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(107, 161)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 24)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Email ID :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(107, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 24)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Username :"
        '
        'DelProf
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(720, 360)
        Me.Controls.Add(Me.Delete)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBoxdel_dep)
        Me.Controls.Add(Me.TextBoxdel_email)
        Me.Controls.Add(Me.TextBoxdel_user)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Name = "DelProf"
        Me.Text = "Delete"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Delete As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBoxdel_dep As ComboBox
    Friend WithEvents TextBoxdel_email As TextBox
    Friend WithEvents TextBoxdel_user As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class
