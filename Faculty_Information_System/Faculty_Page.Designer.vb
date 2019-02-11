<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Faculty_Page
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
        Me.Label_Details = New System.Windows.Forms.Label()
        Me.HomePanel = New System.Windows.Forms.Panel()
        Me.ParentPanel = New System.Windows.Forms.Panel()
        Me.ContactPanel = New System.Windows.Forms.Panel()
        Me.NewsPanel = New System.Windows.Forms.Panel()
        Me.TeachingPanel = New System.Windows.Forms.Panel()
        Me.PublicationsPanel = New System.Windows.Forms.Panel()
        Me.AchievementPanel = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PublicationsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AchievementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TeachingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContactDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.ParentPanel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label_Details
        '
        Me.Label_Details.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Details.Location = New System.Drawing.Point(164, 6)
        Me.Label_Details.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_Details.Name = "Label_Details"
        Me.Label_Details.Size = New System.Drawing.Size(619, 133)
        Me.Label_Details.TabIndex = 14
        Me.Label_Details.Text = "User Details"
        Me.Label_Details.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'HomePanel
        '
        Me.HomePanel.AutoScroll = True
        Me.HomePanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HomePanel.Location = New System.Drawing.Point(0, 0)
        Me.HomePanel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.HomePanel.Name = "HomePanel"
        Me.HomePanel.Size = New System.Drawing.Size(748, 518)
        Me.HomePanel.TabIndex = 16
        '
        'ParentPanel
        '
        Me.ParentPanel.AutoScroll = True
        Me.ParentPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ParentPanel.Controls.Add(Me.ContactPanel)
        Me.ParentPanel.Controls.Add(Me.NewsPanel)
        Me.ParentPanel.Controls.Add(Me.TeachingPanel)
        Me.ParentPanel.Controls.Add(Me.PublicationsPanel)
        Me.ParentPanel.Controls.Add(Me.AchievementPanel)
        Me.ParentPanel.Controls.Add(Me.HomePanel)
        Me.ParentPanel.Location = New System.Drawing.Point(192, 144)
        Me.ParentPanel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ParentPanel.Name = "ParentPanel"
        Me.ParentPanel.Size = New System.Drawing.Size(750, 520)
        Me.ParentPanel.TabIndex = 19
        '
        'ContactPanel
        '
        Me.ContactPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ContactPanel.Location = New System.Drawing.Point(0, 0)
        Me.ContactPanel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ContactPanel.Name = "ContactPanel"
        Me.ContactPanel.Size = New System.Drawing.Size(748, 518)
        Me.ContactPanel.TabIndex = 22
        Me.ContactPanel.Visible = False
        '
        'NewsPanel
        '
        Me.NewsPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NewsPanel.Location = New System.Drawing.Point(0, 0)
        Me.NewsPanel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.NewsPanel.Name = "NewsPanel"
        Me.NewsPanel.Size = New System.Drawing.Size(748, 518)
        Me.NewsPanel.TabIndex = 21
        Me.NewsPanel.Visible = False
        '
        'TeachingPanel
        '
        Me.TeachingPanel.AutoScroll = True
        Me.TeachingPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TeachingPanel.Location = New System.Drawing.Point(0, 0)
        Me.TeachingPanel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TeachingPanel.Name = "TeachingPanel"
        Me.TeachingPanel.Size = New System.Drawing.Size(748, 518)
        Me.TeachingPanel.TabIndex = 20
        Me.TeachingPanel.Visible = False
        '
        'PublicationsPanel
        '
        Me.PublicationsPanel.AutoScroll = True
        Me.PublicationsPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PublicationsPanel.Location = New System.Drawing.Point(0, 0)
        Me.PublicationsPanel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PublicationsPanel.Name = "PublicationsPanel"
        Me.PublicationsPanel.Size = New System.Drawing.Size(748, 518)
        Me.PublicationsPanel.TabIndex = 19
        Me.PublicationsPanel.Visible = False
        '
        'AchievementPanel
        '
        Me.AchievementPanel.AutoScroll = True
        Me.AchievementPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AchievementPanel.Location = New System.Drawing.Point(0, 0)
        Me.AchievementPanel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.AchievementPanel.Name = "AchievementPanel"
        Me.AchievementPanel.Size = New System.Drawing.Size(748, 518)
        Me.AchievementPanel.TabIndex = 18
        Me.AchievementPanel.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.MenuStrip1)
        Me.Panel1.Location = New System.Drawing.Point(4, 144)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(180, 519)
        Me.Panel1.TabIndex = 20
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeToolStripMenuItem, Me.PublicationsToolStripMenuItem, Me.AchievementToolStripMenuItem, Me.TeachingToolStripMenuItem, Me.NewsToolStripMenuItem, Me.ContactDetailsToolStripMenuItem})
        Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(180, 519)
        Me.MenuStrip1.TabIndex = 16
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HomeToolStripMenuItem
        '
        Me.HomeToolStripMenuItem.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        Me.HomeToolStripMenuItem.Size = New System.Drawing.Size(171, 24)
        Me.HomeToolStripMenuItem.Text = "Home"
        Me.HomeToolStripMenuItem.ToolTipText = "Home"
        '
        'PublicationsToolStripMenuItem
        '
        Me.PublicationsToolStripMenuItem.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.PublicationsToolStripMenuItem.Name = "PublicationsToolStripMenuItem"
        Me.PublicationsToolStripMenuItem.Size = New System.Drawing.Size(126, 24)
        Me.PublicationsToolStripMenuItem.Text = "Publications"
        Me.PublicationsToolStripMenuItem.ToolTipText = "Publications"
        '
        'AchievementToolStripMenuItem
        '
        Me.AchievementToolStripMenuItem.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.AchievementToolStripMenuItem.Name = "AchievementToolStripMenuItem"
        Me.AchievementToolStripMenuItem.Size = New System.Drawing.Size(126, 24)
        Me.AchievementToolStripMenuItem.Text = "Achievements"
        Me.AchievementToolStripMenuItem.ToolTipText = "Achievements"
        '
        'TeachingToolStripMenuItem
        '
        Me.TeachingToolStripMenuItem.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.TeachingToolStripMenuItem.Name = "TeachingToolStripMenuItem"
        Me.TeachingToolStripMenuItem.Size = New System.Drawing.Size(126, 24)
        Me.TeachingToolStripMenuItem.Text = "Teaching"
        Me.TeachingToolStripMenuItem.ToolTipText = "Teaching"
        '
        'NewsToolStripMenuItem
        '
        Me.NewsToolStripMenuItem.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.NewsToolStripMenuItem.Name = "NewsToolStripMenuItem"
        Me.NewsToolStripMenuItem.Size = New System.Drawing.Size(126, 24)
        Me.NewsToolStripMenuItem.Text = "News"
        Me.NewsToolStripMenuItem.ToolTipText = "News"
        '
        'ContactDetailsToolStripMenuItem
        '
        Me.ContactDetailsToolStripMenuItem.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ContactDetailsToolStripMenuItem.Name = "ContactDetailsToolStripMenuItem"
        Me.ContactDetailsToolStripMenuItem.Size = New System.Drawing.Size(126, 24)
        Me.ContactDetailsToolStripMenuItem.Text = "Contact Details"
        Me.ContactDetailsToolStripMenuItem.ToolTipText = "Contact Details"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Image = Global.Faculty_Information_System.My.Resources.Resources.IIT_Guwahati_Logo_svg
        Me.PictureBox3.Location = New System.Drawing.Point(4, 6)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(153, 133)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 13
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = Global.Faculty_Information_System.My.Resources.Resources.manager_512
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Image = Global.Faculty_Information_System.My.Resources.Resources._220px_User_icon_2_svg
        Me.PictureBox2.Location = New System.Drawing.Point(790, 6)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(153, 133)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 12
        Me.PictureBox2.TabStop = False
        '
        'Faculty_Page
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(955, 677)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ParentPanel)
        Me.Controls.Add(Me.Label_Details)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Faculty_Page"
        Me.Text = "Faculty_Page"
        Me.ParentPanel.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label_Details As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents HomePanel As System.Windows.Forms.Panel
    Friend WithEvents ParentPanel As System.Windows.Forms.Panel
    Friend WithEvents TeachingPanel As System.Windows.Forms.Panel
    Friend WithEvents PublicationsPanel As System.Windows.Forms.Panel
    Friend WithEvents AchievementPanel As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents HomeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PublicationsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AchievementToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TeachingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContactDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContactPanel As System.Windows.Forms.Panel
    Friend WithEvents NewsPanel As System.Windows.Forms.Panel
End Class
