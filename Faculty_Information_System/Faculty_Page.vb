﻿Imports Microsoft.VisualBasic
Imports System.Data.OleDb
Imports System.Data

Public Class Faculty_Page
    Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Faculty_database.accdb;Jet OLEDB:Database Password=group11"
    Public Property EmailPass As String
    Dim id_number As Int32

    Private Sub Faculty_Page_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim name As String
        Dim dept As String
        Dim email As String
        Dim designation As String
        Dim institute As String = "Indian Institute of Technology, Guwahati"
        Dim query As String = "SELECT * FROM faculty_info where Email= '" & EmailPass & "';"
        Dim conn = New OleDbConnection(connectionString)
        conn.Open()
        Dim cmd As New OleDbCommand(query, conn)
        Dim Reader As OleDbDataReader = cmd.ExecuteReader()
        Try

            While (Reader.Read())
                name = Reader("Name")
                dept = Reader("Department")
                email = Reader("Email")
                id_number = Reader("ID")
                designation = Reader("Designation")
                PictureBox2.Image = Image.FromFile(Application.StartupPath & "\media\" & id_number & ".jpeg")
            End While
            conn.Close()
        Catch ex As Exception
            'MessageBox.Show(ex.Message, "Warning")
        End Try

        Label_Details.Text = name & vbNewLine & designation & vbNewLine & dept & vbNewLine & institute & vbNewLine & email
    End Sub

    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        HomePanel.Visible = True
        TeachingPanel.Visible = False
        ResearchPanel.Visible = False
        PublicationsPanel.Visible = False
    End Sub

    Private Sub PublicationsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PublicationsToolStripMenuItem.Click
        HomePanel.Visible = False
        TeachingPanel.Visible = False
        ResearchPanel.Visible = False
        PublicationsPanel.Visible = True
    End Sub

    Private Sub ResearchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResearchToolStripMenuItem.Click
        HomePanel.Visible = False
        TeachingPanel.Visible = False
        ResearchPanel.Visible = True
        PublicationsPanel.Visible = False
    End Sub

    Private Sub TeachingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TeachingToolStripMenuItem.Click
        HomePanel.Visible = False
        TeachingPanel.Visible = True
        ResearchPanel.Visible = False
        PublicationsPanel.Visible = False
    End Sub

    
    
    Private Sub TeachingPanel_Paint(sender As Object, e As PaintEventArgs) Handles TeachingPanel.Paint

    End Sub

    Private Sub HomePanel_Paint(sender As Object, e As PaintEventArgs) Handles HomePanel.Paint

        Dim x As Int32 = 0
        Dim y As Int32 = 0

        '-------------------------------------For Education Information--------------------------------------------------------
        Dim label_edu As Label = New Label()
        label_edu.Text = "Eduation"
        label_edu.AutoSize = False
        label_edu.Font = New Font(label_edu.Font.FontFamily, 14, FontStyle.Bold)
        label_edu.Size = New System.Drawing.Size(150, 30)
        label_edu.TextAlign = ContentAlignment.MiddleLeft
        label_edu.Location = New Point(x, y)
        HomePanel.Controls.Add(label_edu)
        label_edu.Visible = True

        y += 30

        Dim degree, subject, institute As String
        Dim passing_year As Int32
        Dim count As Int32 = 0
        Dim query As String = "SELECT * FROM Education"
        Dim conn = New OleDbConnection(connectionString)
        conn.Open()
        Dim cmd As New OleDbCommand(query, conn)
        Dim dr As OleDbDataReader = cmd.ExecuteReader()
        Try
            While (dr.Read())
                If dr("Prof_id") = id_number Then
                    count += 1
                    degree = dr("Degree")
                    subject = dr("Subject")
                    institute = dr("Institute")
                    passing_year = dr("Passing_Year")
                    Dim newlabel As Label = New Label()
                    newlabel.Name = degree
                    newlabel.Size = New System.Drawing.Size(HomePanel.Width, 25)
                    newlabel.TextAlign = ContentAlignment.MiddleLeft
                    newlabel.Location = New Point(x, y)
                    HomePanel.Controls.Add(newlabel)
                    y += 25
                    newlabel.Text = count & ". " & degree & "," & subject & "," & institute & "," & passing_year
                End If
            End While
            conn.Close()
        Catch ex As Exception
            'MessageBox.Show(ex.Message, "Warning")
        End Try
        If count = 0 Then
            label_edu.Visible = False
            y = 0
        End If

        '-------------------------------------For Experience Information--------------------------------------------------------
        Dim label_exp As Label = New Label()
        label_exp.Text = "Experience"
        label_exp.AutoSize = False
        label_exp.Font = New Font(label_exp.Font.FontFamily, 14, FontStyle.Bold)
        label_exp.Size = New System.Drawing.Size(150, 30)
        label_exp.TextAlign = ContentAlignment.MiddleLeft
        label_exp.Location = New Point(x, y)
        HomePanel.Controls.Add(label_exp)
        label_exp.Visible = True
        y += 30

        Dim post As String
        query = "SELECT * FROM Experience"
        conn.Open()
        Dim cmd2 As New OleDbCommand(query, conn)
        Dim dr2 As OleDbDataReader = cmd2.ExecuteReader()
        count = 0
        Try
            While (dr2.Read())
                If dr2("Prof_id") = id_number Then
                    count += 1
                    post = dr2("Post")
                    institute = dr2("Institute")
                    Dim newlabel As Label = New Label()
                    newlabel.Name = post
                    newlabel.Size = New System.Drawing.Size(HomePanel.Width, 25)
                    newlabel.TextAlign = ContentAlignment.MiddleLeft
                    newlabel.Location = New Point(x, y)
                    HomePanel.Controls.Add(newlabel)
                    y += 25
                    MessageBox.Show(count & ". " & post & "," & institute)
                    newlabel.Text = count & ". " & post & "," & institute
                End If
            End While
            conn.Close()
        Catch ex As Exception
            'MessageBox.Show(ex.Message, "Warning")
        End Try
        If count = 0 Then
            label_exp.Visible = False
            y = 0
        End If
    End Sub

    Private Sub ResearchPanel_Paint(sender As Object, e As PaintEventArgs) Handles ResearchPanel.Paint

    End Sub

    Private Sub PublicationsPanel_Paint(sender As Object, e As PaintEventArgs) Handles PublicationsPanel.Paint

    End Sub

End Class