<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add_Details
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox_room = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox_tele = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox_edu = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox_Responsibility = New System.Windows.Forms.TextBox()
        Me.ComboBox_desig = New System.Windows.Forms.ComboBox()
        Me.btn_login = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(25, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(237, 28)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Designation :"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(25, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 28)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Room No. :"
        '
        'TextBox_room
        '
        Me.TextBox_room.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_room.Location = New System.Drawing.Point(268, 70)
        Me.TextBox_room.Name = "TextBox_room"
        Me.TextBox_room.Size = New System.Drawing.Size(215, 24)
        Me.TextBox_room.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(25, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 28)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Telephone :"
        '
        'TextBox_tele
        '
        Me.TextBox_tele.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_tele.Location = New System.Drawing.Point(268, 113)
        Me.TextBox_tele.Name = "TextBox_tele"
        Me.TextBox_tele.Size = New System.Drawing.Size(215, 24)
        Me.TextBox_tele.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(25, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 28)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Education :"
        '
        'TextBox_edu
        '
        Me.TextBox_edu.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_edu.Location = New System.Drawing.Point(268, 156)
        Me.TextBox_edu.Name = "TextBox_edu"
        Me.TextBox_edu.Size = New System.Drawing.Size(215, 24)
        Me.TextBox_edu.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(25, 199)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(237, 28)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Additional Responsibility :"
        '
        'TextBox_Responsibility
        '
        Me.TextBox_Responsibility.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Responsibility.Location = New System.Drawing.Point(268, 199)
        Me.TextBox_Responsibility.Name = "TextBox_Responsibility"
        Me.TextBox_Responsibility.Size = New System.Drawing.Size(215, 24)
        Me.TextBox_Responsibility.TabIndex = 16
        '
        'ComboBox_desig
        '
        Me.ComboBox_desig.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_desig.FormattingEnabled = True
        Me.ComboBox_desig.Items.AddRange(New Object() {"Professor", "Assistant Professor", "Associate Professor", "Visiting Faculty"})
        Me.ComboBox_desig.Location = New System.Drawing.Point(268, 24)
        Me.ComboBox_desig.Name = "ComboBox_desig"
        Me.ComboBox_desig.Size = New System.Drawing.Size(215, 26)
        Me.ComboBox_desig.TabIndex = 17
        '
        'btn_login
        '
        Me.btn_login.BackColor = System.Drawing.SystemColors.Control
        Me.btn_login.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_login.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_login.Location = New System.Drawing.Point(182, 270)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(130, 36)
        Me.btn_login.TabIndex = 18
        Me.btn_login.Text = "UPDATE"
        Me.btn_login.UseVisualStyleBackColor = False
        '
        'Add_Details
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(506, 318)
        Me.Controls.Add(Me.btn_login)
        Me.Controls.Add(Me.ComboBox_desig)
        Me.Controls.Add(Me.TextBox_Responsibility)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox_edu)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox_tele)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox_room)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Name = "Add_Details"
        Me.Text = "Add_Details"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox_room As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox_tele As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox_edu As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox_Responsibility As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox_desig As System.Windows.Forms.ComboBox
    Friend WithEvents btn_login As System.Windows.Forms.Button
End Class
