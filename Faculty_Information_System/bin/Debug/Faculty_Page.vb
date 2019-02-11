Imports Microsoft.VisualBasic
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
        AchievementPanel.Visible = False
        PublicationsPanel.Visible = False
        NewsPanel.Visible = False
        ContactPanel.Visible = False
    End Sub

    Private Sub PublicationsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PublicationsToolStripMenuItem.Click
        HomePanel.Visible = False
        TeachingPanel.Visible = False
        AchievementPanel.Visible = False
        PublicationsPanel.Visible = True
        NewsPanel.Visible = False
        ContactPanel.Visible = False
    End Sub

    Private Sub AchievementToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AchievementToolStripMenuItem.Click
        HomePanel.Visible = False
        TeachingPanel.Visible = False
        AchievementPanel.Visible = True
        PublicationsPanel.Visible = False
        NewsPanel.Visible = False
        ContactPanel.Visible = False
    End Sub

    Private Sub TeachingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TeachingToolStripMenuItem.Click
        HomePanel.Visible = False
        TeachingPanel.Visible = True
        AchievementPanel.Visible = False
        PublicationsPanel.Visible = False
        NewsPanel.Visible = False
        ContactPanel.Visible = False
    End Sub

    Private Sub NewsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewsToolStripMenuItem.Click
        HomePanel.Visible = False
        TeachingPanel.Visible = False
        AchievementPanel.Visible = False
        PublicationsPanel.Visible = False
        NewsPanel.Visible = True
        ContactPanel.Visible = False
    End Sub

    Private Sub ContactDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContactDetailsToolStripMenuItem.Click
        HomePanel.Visible = False
        TeachingPanel.Visible = False
        AchievementPanel.Visible = False
        PublicationsPanel.Visible = False
        NewsPanel.Visible = False
        ContactPanel.Visible = True
    End Sub

   

    Private Sub HomePanel_Paint(sender As Object, e As PaintEventArgs) Handles HomePanel.Paint

        Dim x As Int32 = 0
        Dim y As Int32 = 0
        Dim y_prev As Int32 = 0
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

        Dim degree, subject, institute, textOflabel As String
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
                    textOflabel = count & ". " & degree & "," & subject & "," & institute & "," & passing_year
                    Dim newlabel As Label = New Label()
                    newlabel.Name = degree
                    newlabel.Font = New Font(newlabel.Font.FontFamily, 10)
                    newlabel.Size = New System.Drawing.Size(HomePanel.Width, 50)
                    newlabel.TextAlign = ContentAlignment.MiddleLeft
                    newlabel.Location = New Point(x, y)
                    HomePanel.Controls.Add(newlabel)
                    y += 50
                    newlabel.Text = textOflabel
                End If
            End While
            conn.Close()
        Catch ex As Exception
            'MessageBox.Show(ex.Message, "Warning")
        End Try
        If count = 0 Then
            label_edu.Visible = False
            y = y_prev
        Else
            y_prev = y
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
                    textOflabel = count & ". " & post & "," & institute & "," & dr2("From") & " - " & dr2("To")
                    Dim newlabel As Label = New Label()
                    newlabel.Name = post
                    newlabel.Font = New Font(newlabel.Font.FontFamily, 10)
                    newlabel.Size = New System.Drawing.Size(HomePanel.Width, 50)
                    newlabel.TextAlign = ContentAlignment.MiddleLeft
                    newlabel.Location = New Point(x, y)
                    HomePanel.Controls.Add(newlabel)
                    y += 50
                    newlabel.Text = textOflabel
                End If
            End While
            conn.Close()
        Catch ex As Exception
            'MessageBox.Show(ex.Message, "Warning")
        End Try
        If count = 0 Then
            label_exp.Visible = False
            y = y_prev
        Else
            y_prev = y
        End If

        '-------------------------------------For Research Interest Information--------------------------------------------------------
        Dim label_res As Label = New Label()
        label_res.Text = "Research Interest"
        label_res.AutoSize = False
        label_res.Font = New Font(label_res.Font.FontFamily, 14, FontStyle.Bold)
        label_res.Size = New System.Drawing.Size(HomePanel.Width, 30)
        label_res.TextAlign = ContentAlignment.MiddleLeft
        label_res.Location = New Point(x, y)
        HomePanel.Controls.Add(label_res)
        label_res.Visible = True
        y += 30

        Dim fields As String = ""
        query = "SELECT * FROM Research_Interest "
        conn.Open()
        Dim cmd3 As New OleDbCommand(query, conn)
        dr = cmd3.ExecuteReader()
        count = 0
        Try
            While (dr.Read())
                If dr("Prof_id") = id_number Then
                    count += 1
                    If count = 1 Then
                        fields = dr("Field")
                    Else
                        fields = fields & "," & dr("Field")
                    End If
                End If
            End While
            conn.Close()
        Catch ex As Exception
            'MessageBox.Show(ex.Message, "Warning")
        End Try

        If count = 0 Then
            label_res.Visible = False
            y = y_prev
        Else
            y_prev = y
            Dim newlabel As Label = New Label()
            newlabel.Name = "res" & id_number
            textOflabel = fields
            newlabel.Font = New Font(newlabel.Font.FontFamily, 10)
            newlabel.Size = New System.Drawing.Size(HomePanel.Width, 50)
            newlabel.TextAlign = ContentAlignment.MiddleLeft
            newlabel.Location = New Point(x, y)
            HomePanel.Controls.Add(newlabel)
            y += 50
            newlabel.Text = textOflabel
        End If

    End Sub

    Private Sub PublicationsPanel_Paint(sender As Object, e As PaintEventArgs) Handles PublicationsPanel.Paint
        Dim x As Int32 = 0
        Dim y As Int32 = 0
        Dim y_prev As Int32 = 0
        '-------------------------------------For Publication Information--------------------------------------------------------
        Dim label_pub As Label = New Label()
        label_pub.Text = "Publications"
        label_pub.AutoSize = False
        label_pub.Font = New Font(label_pub.Font.FontFamily, 14, FontStyle.Bold)
        label_pub.Size = New System.Drawing.Size(150, 30)
        label_pub.TextAlign = ContentAlignment.MiddleLeft
        label_pub.Location = New Point(x, y)
        PublicationsPanel.Controls.Add(label_pub)
        label_pub.Visible = True

        y += 30

        Dim topic, textOflabel As String
        Dim pub_year As Int32
        Dim count As Int32 = 0
        Dim query As String = "SELECT * FROM Publications"
        Dim conn = New OleDbConnection(connectionString)
        conn.Open()
        Dim cmd As New OleDbCommand(query, conn)
        Dim dr As OleDbDataReader = cmd.ExecuteReader()
        Try
            While (dr.Read())
                If dr("Prof_id") = id_number Then
                    count += 1
                    topic = dr("Topic")
                    If IsDBNull(dr("Publication_Year")) Then
                        textOflabel = count & ". " & topic
                    Else
                        pub_year = dr("Publication_Year")
                        textOflabel = count & ". " & topic & "  ( " & pub_year & " )"
                    End If

                    Dim newlabel As Label = New Label()
                    newlabel.Name = "pub" & count
                    newlabel.Font = New Font(newlabel.Font.FontFamily, 10)
                    newlabel.Size = New System.Drawing.Size(HomePanel.Width, 50)
                    newlabel.TextAlign = ContentAlignment.MiddleLeft
                    newlabel.Location = New Point(x, y)
                    PublicationsPanel.Controls.Add(newlabel)
                    newlabel.Text = textOflabel
                    y += 50

                    If IsDBNull(dr("Link")) Then

                    Else
                        Dim linklabel1 As LinkLabel = New LinkLabel()
                        linklabel1.Text = "View Details"
                        linklabel1.Size = New System.Drawing.Size(HomePanel.Width, 25)
                        linklabel1.Links.Add(0, Len(linklabel1.Text), dr("Link"))
                        linklabel1.Location = New Point(x, y)
                        AddHandler linklabel1.LinkClicked, AddressOf LinkClicked
                        PublicationsPanel.Controls.Add(linklabel1)
                        y += 25
                    End If


                End If
            End While

        Catch ex As Exception
            'MessageBox.Show(ex.Message, "Warning")
        End Try
        conn.Close()
        If count = 0 Then
            label_pub.Visible = False
            y = y_prev
        Else
            y_prev = y
        End If
    End Sub

    Private Sub LinkClicked(ByVal sender As Object, _
        ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        Try
            System.Diagnostics.Process.Start(CStr(e.Link.LinkData))
        Catch ex As Exception
            MessageBox.Show("Server Down")
        End Try

    End Sub

    Private Sub TeachingPanel_Paint(sender As Object, e As PaintEventArgs) Handles TeachingPanel.Paint
        Dim x As Int32 = 0
        Dim y As Int32 = 0
        Dim y_prev As Int32 = 0
        '-------------------------------------For Current Course Information--------------------------------------------------------
        Dim label_cn As Label = New Label()
        label_cn.Text = "Current Courses"
        label_cn.AutoSize = False
        label_cn.Font = New Font(label_cn.Font.FontFamily, 14, FontStyle.Bold)
        label_cn.Size = New System.Drawing.Size(150, 30)
        label_cn.TextAlign = ContentAlignment.MiddleLeft
        label_cn.Location = New Point(x, y)
        TeachingPanel.Controls.Add(label_cn)
        label_cn.Visible = True

        y += 30

        Dim course_no, title, textOflabel1, textoflabel2 As String
        Dim sem, taught_year As Int32
        Dim count As Int32 = 0
        Dim query As String = "SELECT * FROM Teaching"
        Dim con = New OleDbConnection(connectionString)
        con.Open()
        Dim cmd As New OleDbCommand(query, con)
        Dim dr As OleDbDataReader = cmd.ExecuteReader()
        Try
            While (dr.Read())
                If dr("Prof_id") = id_number And dr("Current") = True Then
                    count += 1
                    course_no = dr("Course_No")
                    title = dr("Course_Title")
                    taught_year = dr("Taught_Year")
                    sem = dr("Semester")

                    textOflabel1 = course_no & " : " & title
                    textoflabel2 = sem & " Semester, " & taught_year

                    Dim newlabel As Label = New Label()
                    newlabel.Name = "1course_new" & count
                    newlabel.Font = New Font(newlabel.Font.FontFamily, 10, FontStyle.Italic)
                    newlabel.Size = New System.Drawing.Size(HomePanel.Width, 25)
                    newlabel.TextAlign = ContentAlignment.MiddleLeft
                    newlabel.Location = New Point(x, y)
                    TeachingPanel.Controls.Add(newlabel)
                    newlabel.Text = textOflabel1
                    y += 25

                    Dim newlabel2 As Label = New Label()
                    newlabel2.Name = "2course_new" & count
                    newlabel2.Font = New Font(newlabel2.Font.FontFamily, 10)
                    newlabel2.Size = New System.Drawing.Size(HomePanel.Width, 25)
                    newlabel2.TextAlign = ContentAlignment.MiddleLeft
                    newlabel2.Location = New Point(x, y)
                    TeachingPanel.Controls.Add(newlabel2)
                    newlabel2.Text = textoflabel2
                    y += 25

                    If IsDBNull(dr("Course_url")) Then

                    Else

                        Dim linklabel1 As LinkLabel = New LinkLabel()
                        linklabel1.Text = "View Details"
                        linklabel1.Size = New System.Drawing.Size(HomePanel.Width, 25)
                        linklabel1.Links.Add(0, Len(linklabel1.Text), dr("Course_url"))
                        linklabel1.Location = New Point(x, y)
                        AddHandler linklabel1.LinkClicked, AddressOf LinkClicked
                        TeachingPanel.Controls.Add(linklabel1)
                        y += 25
                    End If


                End If
            End While

        Catch ex As Exception
            'MessageBox.Show(ex.Message, "Warning")
        End Try
        con.Close()
        If count = 0 Then
            label_cn.Visible = False
            y = y_prev
        Else
            y_prev = y
        End If


        '-------------------------------------For Old Course Information--------------------------------------------------------
        Dim label_old As Label = New Label()
        label_old.Text = "Old Courses"
        label_old.AutoSize = False
        label_old.Font = New Font(label_old.Font.FontFamily, 14, FontStyle.Bold)
        label_old.Size = New System.Drawing.Size(150, 30)
        label_old.TextAlign = ContentAlignment.MiddleLeft
        label_old.Location = New Point(x, y)
        TeachingPanel.Controls.Add(label_old)
        label_old.Visible = True

        y += 30

        count = 0
        query = "SELECT * FROM Teaching"
        Dim conn2 = New OleDbConnection(connectionString)
        conn2.Open()
        Dim cmd2 As New OleDbCommand(query, conn2)
        dr = cmd2.ExecuteReader()
        Try
            While (dr.Read())
                If dr("Prof_id") = id_number And dr("Current") = False Then
                    count += 1
                    course_no = dr("Course_No")
                    title = dr("Course_Title")
                    taught_year = dr("Taught_Year")
                    sem = dr("Semester")

                    textOflabel1 = course_no & " : " & title
                    textoflabel2 = sem & " Semester, " & taught_year

                    Dim newlabel As Label = New Label()
                    newlabel.Name = "1course_old" & count
                    newlabel.Font = New Font(newlabel.Font.FontFamily, 10, FontStyle.Italic)
                    newlabel.Size = New System.Drawing.Size(HomePanel.Width, 25)
                    newlabel.TextAlign = ContentAlignment.MiddleLeft
                    newlabel.Location = New Point(x, y)
                    TeachingPanel.Controls.Add(newlabel)
                    newlabel.Text = textOflabel1
                    y += 25

                    Dim newlabel2 As Label = New Label()
                    newlabel2.Name = "2course_old" & count
                    newlabel2.Font = New Font(newlabel2.Font.FontFamily, 10)
                    newlabel2.Size = New System.Drawing.Size(HomePanel.Width, 25)
                    newlabel2.TextAlign = ContentAlignment.MiddleLeft
                    newlabel2.Location = New Point(x, y)
                    TeachingPanel.Controls.Add(newlabel2)
                    newlabel2.Text = textoflabel2
                    y += 25

                    If IsDBNull(dr("Course_url")) Then

                    Else
                        Dim linklabel1 As LinkLabel = New LinkLabel()
                        linklabel1.Text = "View Details"
                        linklabel1.Size = New System.Drawing.Size(HomePanel.Width, 25)
                        linklabel1.Links.Add(0, Len(linklabel1.Text), dr("Course_url"))
                        linklabel1.Location = New Point(x, y)
                        AddHandler linklabel1.LinkClicked, AddressOf LinkClicked
                        TeachingPanel.Controls.Add(linklabel1)
                        y += 25
                    End If


                End If
            End While

        Catch ex As Exception
            'MessageBox.Show(ex.Message, "Warning")
        End Try
        conn2.Close()
        If count = 0 Then
            label_old.Visible = False
            y = y_prev
        Else
            y_prev = y
        End If
    End Sub
    
    
    Private Sub ContactPanel_Paint(sender As Object, e As PaintEventArgs) Handles ContactPanel.Paint
        Dim name, dept, email, designation, room As String
        Dim phone As Int32
        Dim institute As String = "Indian Institute of Technology, Guwahati"
        Dim address As String = "North Guwahati-781039"
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
                designation = Reader("Designation")
                phone = Reader("Telephone")
                room = Reader("Room")
            End While
            conn.Close()
        Catch ex As Exception
            'MessageBox.Show(ex.Message, "Warning")
        End Try

        Dim x As Int32 = 0
        Dim y As Int32 = 0

        Dim info_box As Label = New Label()
        info_box.AutoSize = False
        info_box.Size = New System.Drawing.Size(HomePanel.Width, 100)
        info_box.Font = New Font(info_box.Font.FontFamily, 10)
        info_box.TextAlign = ContentAlignment.MiddleLeft
        info_box.Location = New Point(x, y)
        ContactPanel.Controls.Add(info_box)
        info_box.Visible = True
        info_box.Text = designation & vbNewLine & "Department of " & dept & vbNewLine & institute & vbNewLine & address & vbNewLine & "INDIA"
        y += 100

        Dim label_email As Label = New Label()
        label_email.Text = "Email :"
        label_email.AutoSize = False
        label_email.Font = New Font(label_email.Font.FontFamily, 10, FontStyle.Bold)
        label_email.Size = New System.Drawing.Size(HomePanel.Width, 30)
        label_email.TextAlign = ContentAlignment.MiddleLeft
        label_email.Location = New Point(x, y)
        ContactPanel.Controls.Add(label_email)
        label_email.Visible = True
        y += 30

        Dim newlabel2 As Label = New Label()
        newlabel2.Name = "email"
        newlabel2.Font = New Font(newlabel2.Font.FontFamily, 10)
        newlabel2.Size = New System.Drawing.Size(HomePanel.Width, 25)
        newlabel2.TextAlign = ContentAlignment.MiddleLeft
        newlabel2.Location = New Point(x, y)
        ContactPanel.Controls.Add(newlabel2)
        newlabel2.Text = email
        y += 25

        Dim label_room As Label = New Label()
        label_room.Text = "Room :"
        label_room.AutoSize = False
        label_room.Font = New Font(label_room.Font.FontFamily, 10, FontStyle.Bold)
        label_room.Size = New System.Drawing.Size(150, 30)
        label_room.TextAlign = ContentAlignment.MiddleLeft
        label_room.Location = New Point(x, y)
        ContactPanel.Controls.Add(label_room)
        label_email.Visible = True
        y += 30

        Dim newlabel3 As Label = New Label()
        newlabel3.Name = "room"
        newlabel3.Font = New Font(newlabel3.Font.FontFamily, 10)
        newlabel3.Size = New System.Drawing.Size(HomePanel.Width, 25)
        newlabel3.TextAlign = ContentAlignment.MiddleLeft
        newlabel3.Location = New Point(x, y)
        ContactPanel.Controls.Add(newlabel3)
        newlabel3.Text = room & " Dept. of " & dept
        newlabel3.Visible = True
        y += 25

        Dim label_tele As Label = New Label()
        label_tele.Text = "Contact No. :"
        label_tele.AutoSize = False
        label_tele.Font = New Font(label_tele.Font.FontFamily, 10, FontStyle.Bold)
        label_tele.Size = New System.Drawing.Size(150, 30)
        label_tele.TextAlign = ContentAlignment.MiddleLeft
        label_tele.Location = New Point(x, y)
        ContactPanel.Controls.Add(label_tele)
        label_tele.Visible = True
        y += 30

        Dim newlabel4 As Label = New Label()
        newlabel4.Name = "tele"
        newlabel4.Font = New Font(newlabel4.Font.FontFamily, 10)
        newlabel4.Size = New System.Drawing.Size(HomePanel.Width, 25)
        newlabel4.TextAlign = ContentAlignment.MiddleLeft
        newlabel4.Location = New Point(x, y)
        ContactPanel.Controls.Add(newlabel4)
        newlabel4.Text = phone.ToString
        newlabel4.Visible = True
        y += 25


    End Sub

    Private Sub NewsPanel_Paint(sender As Object, e As PaintEventArgs) Handles NewsPanel.Paint

    End Sub

   
    Private Sub AchievementPanel_Paint(sender As Object, e As PaintEventArgs) Handles AchievementPanel.Paint
        Dim x As Int32 = 0
        Dim y As Int32 = 0
        Dim y_prev As Int32 = 0
        '-------------------------------------For Acievements Information--------------------------------------------------------
        Dim label_pub As Label = New Label()
        label_pub.Text = "Achievements"
        label_pub.AutoSize = False
        label_pub.Font = New Font(label_pub.Font.FontFamily, 14, FontStyle.Bold)
        label_pub.Size = New System.Drawing.Size(150, 30)
        label_pub.TextAlign = ContentAlignment.MiddleLeft
        label_pub.Location = New Point(x, y)
        AchievementPanel.Controls.Add(label_pub)
        label_pub.Visible = True

        y += 30

        Dim title, issued_by, textOflabel As String
        Dim issued_year As Int32
        Dim count As Int32 = 0
        Dim query As String = "SELECT * FROM Achievements"
        Dim conn = New OleDbConnection(connectionString)
        conn.Open()
        Dim cmd As New OleDbCommand(query, conn)
        Dim dr As OleDbDataReader = cmd.ExecuteReader()
        Try
            While (dr.Read())
                If dr("Prof_id") = id_number Then
                    count += 1
                    title = dr("Title")
                    issued_by = dr("Issued_By")
                    issued_year = dr("Year")

                    textOflabel = count & ". " & title & ", " & issued_by & ", " & issued_year

                    Dim newlabel As Label = New Label()
                    newlabel.Name = "achieve" & count
                    newlabel.Font = New Font(newlabel.Font.FontFamily, 10)
                    newlabel.Size = New System.Drawing.Size(HomePanel.Width, 50)
                    newlabel.TextAlign = ContentAlignment.MiddleLeft
                    newlabel.Location = New Point(x, y)
                    AchievementPanel.Controls.Add(newlabel)
                    newlabel.Text = textOflabel
                    y += 50
                End If
            End While

        Catch ex As Exception
            'MessageBox.Show(ex.Message, "Warning")
        End Try
        conn.Close()
        If count = 0 Then
            label_pub.Visible = False
            y = y_prev
        Else
            y_prev = y
        End If
    End Sub
End Class