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
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label_Details = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.HomePanel = New System.Windows.Forms.Panel()
        Me.ParentPanel = New System.Windows.Forms.Panel()
        Me.TeachingPanel = New System.Windows.Forms.Panel()
        Me.PublicationsPanel = New System.Windows.Forms.Panel()
        Me.ResearchPanel = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PublicationsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TeachingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ParentPanel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Image = Global.Faculty_Information_System.My.Resources.Resources._220px_User_icon_2_svg
        Me.PictureBox2.Location = New System.Drawing.Point(541, 4)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(115, 108)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 12
        Me.PictureBox2.TabStop = False
        '
        'Label_Details
        '
        Me.Label_Details.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Details.Location = New System.Drawing.Point(123, 4)
        Me.Label_Details.Name = "Label_Details"
        Me.Label_Details.Size = New System.Drawing.Size(413, 108)
        Me.Label_Details.TabIndex = 14
        Me.Label_Details.Text = "User Details"
        Me.Label_Details.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Image = Global.Faculty_Information_System.My.Resources.Resources.IIT_Guwahati_Logo_svg
        Me.PictureBox3.Location = New System.Drawing.Point(3, 4)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(115, 108)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 13
        Me.PictureBox3.TabStop = False
        '
        'HomePanel
        '
        Me.HomePanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HomePanel.Location = New System.Drawing.Point(0, 0)
        Me.HomePanel.Name = "HomePanel"
        Me.HomePanel.Size = New System.Drawing.Size(533, 384)
        Me.HomePanel.TabIndex = 16
        '
        'ParentPanel
        '
        Me.ParentPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ParentPanel.Controls.Add(Me.TeachingPanel)
        Me.ParentPanel.Controls.Add(Me.PublicationsPanel)
        Me.ParentPanel.Controls.Add(Me.ResearchPanel)
        Me.ParentPanel.Controls.Add(Me.HomePanel)
        Me.ParentPanel.Location = New System.Drawing.Point(121, 117)
        Me.ParentPanel.Name = "ParentPanel"
        Me.ParentPanel.Size = New System.Drawing.Size(535, 386)
        Me.ParentPanel.TabIndex = 19
        '
        'TeachingPanel
        '
        Me.TeachingPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TeachingPanel.Location = New System.Drawing.Point(0, 0)
        Me.TeachingPanel.Name = "TeachingPanel"
        Me.TeachingPanel.Size = New System.Drawing.Size(533, 384)
        Me.TeachingPanel.TabIndex = 20
        Me.TeachingPanel.Visible = False
        '
        'PublicationsPanel
        '
        Me.PublicationsPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PublicationsPanel.Location = New System.Drawing.Point(0, 0)
        Me.PublicationsPanel.Name = "PublicationsPanel"
        Me.PublicationsPanel.Size = New System.Drawing.Size(533, 384)
        Me.PublicationsPanel.TabIndex = 19
        Me.PublicationsPanel.Visible = False
        '
        'ResearchPanel
        '
        Me.ResearchPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ResearchPanel.Location = New System.Drawing.Point(0, 0)
        Me.ResearchPanel.Name = "ResearchPanel"
        Me.ResearchPanel.Size = New System.Drawing.Size(533, 384)
        Me.ResearchPanel.TabIndex = 18
        Me.ResearchPanel.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.MenuStrip1)
        Me.Panel1.Location = New System.Drawing.Point(3, 117)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(112, 386)
        Me.Panel1.TabIndex = 20
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeToolStripMenuItem, Me.PublicationsToolStripMenuItem, Me.ResearchToolStripMenuItem, Me.TeachingToolStripMenuItem, Me.NewsToolStripMenuItem})
        Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(115, 386)
        Me.MenuStrip1.TabIndex = 16
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HomeToolStripMenuItem
        '
        Me.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        Me.HomeToolStripMenuItem.Size = New System.Drawing.Size(108, 19)
        Me.HomeToolStripMenuItem.Text = "Home"
        '
        'PublicationsToolStripMenuItem
        '
        Me.PublicationsToolStripMenuItem.Name = "PublicationsToolStripMenuItem"
        Me.PublicationsToolStripMenuItem.Size = New System.Drawing.Size(108, 19)
        Me.PublicationsToolStripMenuItem.Text = "Publications"
        '
        'ResearchToolStripMenuItem
        '
        Me.ResearchToolStripMenuItem.Name = "ResearchToolStripMenuItem"
        Me.ResearchToolStripMenuItem.Size = New System.Drawing.Size(108, 19)
        Me.ResearchToolStripMenuItem.Text = "Research"
        '
        'TeachingToolStripMenuItem
        '
        Me.TeachingToolStripMenuItem.Name = "TeachingToolStripMenuItem"
        Me.TeachingToolStripMenuItem.Size = New System.Drawing.Size(108, 19)
        Me.TeachingToolStripMenuItem.Text = "Teaching"
        '
        'NewsToolStripMenuItem
        '
        Me.NewsToolStripMenuItem.Name = "NewsToolStripMenuItem"
        Me.NewsToolStripMenuItem.Size = New System.Drawing.Size(108, 19)
        Me.NewsToolStripMenuItem.Text = "News"
        '
        'Faculty_Page
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(660, 506)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ParentPanel)
        Me.Controls.Add(Me.Label_Details)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Name = "Faculty_Page"
        Me.Text = "Faculty_Page"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ParentPanel.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label_Details As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents HomePanel As System.Windows.Forms.Panel
    Friend WithEvents ParentPanel As System.Windows.Forms.Panel
    Friend WithEvents TeachingPanel As System.Windows.Forms.Panel
    Friend WithEvents PublicationsPanel As System.Windows.Forms.Panel
    Friend WithEvents ResearchPanel As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents HomeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PublicationsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ResearchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TeachingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
