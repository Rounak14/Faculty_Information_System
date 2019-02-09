<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin_form
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
        Me.AddButton = New System.Windows.Forms.Button()
        Me.DelButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(318, 55)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(304, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ADMIN DASHBOARD"
        '
        'AddButton
        '
        Me.AddButton.BackColor = System.Drawing.Color.Tomato
        Me.AddButton.Location = New System.Drawing.Point(201, 139)
        Me.AddButton.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(532, 92)
        Me.AddButton.TabIndex = 1
        Me.AddButton.Text = "Add a new Professor"
        Me.AddButton.UseVisualStyleBackColor = False
        '
        'DelButton
        '
        Me.DelButton.BackColor = System.Drawing.Color.Blue
        Me.DelButton.Location = New System.Drawing.Point(201, 276)
        Me.DelButton.Name = "DelButton"
        Me.DelButton.Size = New System.Drawing.Size(532, 85)
        Me.DelButton.TabIndex = 2
        Me.DelButton.Text = "Delete a Professor"
        Me.DelButton.UseVisualStyleBackColor = False
        '
        'Admin_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Faculty_Information_System.My.Resources.Resources.admin_login_background_images_8
        Me.ClientSize = New System.Drawing.Size(982, 410)
        Me.Controls.Add(Me.DelButton)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "Admin_form"
        Me.Text = "Admin_form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents AddButton As Button
    Friend WithEvents DelButton As Button
End Class
