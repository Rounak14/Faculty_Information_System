<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label_Details = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.AboutMe_Button = New System.Windows.Forms.Button()
        Me.addNews_Button = New System.Windows.Forms.Button()
        Me.Button_preview = New System.Windows.Forms.Button()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(168, 11)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(281, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Welcome To Dashboard!!!!!"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Image = Global.Faculty_Information_System.My.Resources.Resources._220px_User_icon_2_svg
        Me.PictureBox2.Location = New System.Drawing.Point(11, 11)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(115, 108)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 13
        Me.PictureBox2.TabStop = False
        '
        'Label_Details
        '
        Me.Label_Details.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Details.Location = New System.Drawing.Point(142, 44)
        Me.Label_Details.Name = "Label_Details"
        Me.Label_Details.Size = New System.Drawing.Size(350, 105)
        Me.Label_Details.TabIndex = 15
        Me.Label_Details.Text = "User Details"
        Me.Label_Details.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(191, 226)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(136, 41)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Logout"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'AboutMe_Button
        '
        Me.AboutMe_Button.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AboutMe_Button.Location = New System.Drawing.Point(16, 149)
        Me.AboutMe_Button.Name = "AboutMe_Button"
        Me.AboutMe_Button.Size = New System.Drawing.Size(136, 38)
        Me.AboutMe_Button.TabIndex = 17
        Me.AboutMe_Button.Text = "Add Details"
        Me.AboutMe_Button.UseVisualStyleBackColor = True
        '
        'addNews_Button
        '
        Me.addNews_Button.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addNews_Button.Location = New System.Drawing.Point(191, 152)
        Me.addNews_Button.Name = "addNews_Button"
        Me.addNews_Button.Size = New System.Drawing.Size(136, 38)
        Me.addNews_Button.TabIndex = 18
        Me.addNews_Button.Text = "Add News"
        Me.addNews_Button.UseVisualStyleBackColor = True
        '
        'Button_preview
        '
        Me.Button_preview.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_preview.Location = New System.Drawing.Point(356, 152)
        Me.Button_preview.Name = "Button_preview"
        Me.Button_preview.Size = New System.Drawing.Size(136, 38)
        Me.Button_preview.TabIndex = 19
        Me.Button_preview.Text = "View Page"
        Me.Button_preview.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(510, 292)
        Me.Controls.Add(Me.Button_preview)
        Me.Controls.Add(Me.addNews_Button)
        Me.Controls.Add(Me.AboutMe_Button)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label_Details)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.Text = "Dashboard"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label_Details As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents AboutMe_Button As System.Windows.Forms.Button
    Friend WithEvents addNews_Button As System.Windows.Forms.Button
    Friend WithEvents Button_preview As System.Windows.Forms.Button
End Class
