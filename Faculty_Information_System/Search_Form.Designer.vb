﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(206, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 26)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Faculty Search"
        '
        'Login_Button
        '
        Me.Login_Button.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Login_Button.Location = New System.Drawing.Point(428, 12)
        Me.Login_Button.Name = "Login_Button"
        Me.Login_Button.Size = New System.Drawing.Size(120, 34)
        Me.Login_Button.TabIndex = 2
        Me.Login_Button.Text = "Login"
        Me.Login_Button.UseVisualStyleBackColor = True
        '
        'Button_search
        '
        Me.Button_search.Location = New System.Drawing.Point(221, 239)
        Me.Button_search.Name = "Button_search"
        Me.Button_search.Size = New System.Drawing.Size(120, 29)
        Me.Button_search.TabIndex = 3
        Me.Button_search.Text = "SEARCH"
        Me.Button_search.UseVisualStyleBackColor = True
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
        Me.RadioButton2.Location = New System.Drawing.Point(160, 183)
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
        Me.Label2.Size = New System.Drawing.Size(88, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Search By -"
        '
        'Search_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(560, 343)
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
End Class