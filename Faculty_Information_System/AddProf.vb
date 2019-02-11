' multiple same email hatane hain
' form close dekhna hai

Imports Microsoft.VisualBasic
Imports System.Data.OleDb
Imports System.Data
Imports System.Net.Mail
Imports System.Text

Public Class AddProf
    Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Faculty_database.accdb;Jet OLEDB:Database Password=group11"
    Dim random_password As String
    Dim peep As Integer

    Private Sub Update_Click(sender As Object, e As EventArgs) Handles Update.Click
        Dim conn = New OleDbConnection(connectionString)
        conn.Open()
        If String.IsNullOrEmpty(TextBox1.Text) Or String.IsNullOrEmpty(ComboBox1.Text) Or String.IsNullOrEmpty(TextBox3.Text) Then
            MessageBox.Show("First Fill all the required entries")
            Exit Sub
        End If
        If peep = 0 Then
            MessageBox.Show("First you need to send mail to professor about his/her password", "Warning")
            Exit Sub
        End If

        Dim checker As Integer = 0
        Dim email_text As String = TextBox3.Text

        Dim query_check = "Select * from faculty_info"
        Dim cmdCheck As New OleDbCommand(query_check, conn)
        Dim Reader As OleDbDataReader = cmdCheck.ExecuteReader()
        While (Reader.Read())
            If email_text = Reader("Email") Then
                MessageBox.Show("Email already exists", "Warning")
                TextBox3.Clear()
                Exit Sub
            End If
        End While

        Try
            Dim Smtp_server As New SmtpClient
            Dim e_mail As New MailMessage
            Smtp_server.UseDefaultCredentials = False
            Smtp_server.Credentials = New Net.NetworkCredential("haharihi@gmail.com", "takemehome123")
            Smtp_server.Port = 587
            Smtp_server.EnableSsl = True
            Smtp_server.Host = "smtp.gmail.com"
            e_mail = New MailMessage()
            e_mail.From = New MailAddress("haharihi@gmail.com")
            e_mail.To.Add(email_text)
            e_mail.Subject = "NEW PASSWORD"
            e_mail.IsBodyHtml = False
            e_mail.Body = "Your password for logging into Faculty Information System is " + random_password & Environment.NewLine + "It is advisable to change your password after logging in"
            Smtp_server.Send(e_mail)
            MessageBox.Show("Mail Sent, Thank You!")
        Catch ex As Exception
            Dim sop As String = ex.Message & Environment.NewLine + "Try removing proxy next time!!"
            MessageBox.Show(sop)
            MessageBox.Show("")
            checker = 1
            Exit Sub
        End Try

        If checker = 0 Then
            Dim namestring As String = TextBox1.Text
            Dim emailstring As String = TextBox3.Text
            Dim departmentstring As String = ComboBox1.Text
            Dim query As String
            query = "INSERT INTO faculty_info ([Name],[Department],[Email],[Password]) VALUES (?,?,?,?)"
            Dim cmd As OleDbCommand = New OleDbCommand(query, conn)
            cmd.Parameters.Add(New OleDbParameter("Name", CType(namestring, String)))
            cmd.Parameters.Add(New OleDbParameter("Department", CType(departmentstring, String)))
            cmd.Parameters.Add(New OleDbParameter("Email", CType(emailstring, String)))
            cmd.Parameters.Add(New OleDbParameter("Password", CType(random_password, String)))

            Try
                cmd.ExecuteNonQuery() 'Executing Update Command
                cmd.Dispose()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error")
            End Try
        End If

        Me.Hide()
        Admin_form.Show()
        conn.Close()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Admin_form.Show()
        Me.Close()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        MessageBox.Show("Make sure proxy connection is disabled", "Warning")
        Dim s As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789abcdefghijklmnopqrstuvwxyz"
        Dim r As New Random
        Dim sb As New System.Text.StringBuilder()
        For i As Integer = 1 To 8
            Dim idx As Integer = r.Next(0, 61)
            sb.Append(s.Substring(idx, 1))
        Next
        random_password = sb.ToString()
        peep = 1
    End Sub
End Class