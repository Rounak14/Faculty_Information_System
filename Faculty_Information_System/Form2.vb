Imports Microsoft.VisualBasic
Imports System.Data.OleDb
Imports System.Data
Imports System.Net.Mail
Imports System.Text

Public Class Form2
    Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Faculty_database.accdb;Jet OLEDB:Database Password=group11"
    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click

        Dim email_id As String = ""
        Dim password As String
        Dim username As String = ""
        Dim pass As String
       
        email_id = TextBox_email.Text
        password = TextBox_Pass.Text
        Dim query As String = "Select Password From faculty_info where Email= '" & email_id & "';"
        'Dim dbsource As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\siddh\Documents\Database2.accdb"
        Dim conn = New OleDbConnection(connectionString)
        Dim cmd As New OleDbCommand(query, conn)
        Try
            conn.Open()
            pass = cmd.ExecuteScalar().ToString
            If (password = pass) Then
                If (email_id = "admin@iitg.ac.in") Then
                    MessageBox.Show("Login Success")
                    Admin_form.Show()
                    Me.Hide()
                Else
                    Dim OBJ As New Form1
                    OBJ.EmailPass = email_id
                    OBJ.Show()
                    Me.Close()
                End If
            Else
                MessageBox.Show("login Failed")
            End If
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning")
        End Try
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Search_Form.Show()
        Me.Close()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        MessageBox.Show("An email will be sent to your outlook ID containing the password, it is advisable that you reset your password after logging in immediatley")
        If TextBox_email.Text = "" Then
            MessageBox.Show("Enter your email first to reset the passowrd", "Warning")
            Exit Sub
        End If

        Dim email_text As String = TextBox_email.Text

        Dim query As String = "Select * From faculty_info"
        Dim conn = New OleDbConnection(connectionString)
        conn.Open()
        Dim cmd As New OleDbCommand(query, conn)
        Dim Reader As OleDbDataReader = cmd.ExecuteReader()
        Dim id_number As Integer
        Dim count As Integer = 0
        While (Reader.Read())
            id_number = Reader("ID")
            If email_text = Reader("Email") Then
                count = count + 1
            End If
        End While
        conn.Close()

        If count = 0 Then
            MessageBox.Show("You have entered wrong email ID", "Warning")
            Exit Sub
        End If

        Dim s As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"
        Dim r As New Random
        Dim sb As New System.Text.StringBuilder()
        For i As Integer = 1 To 8
            Dim idx As Integer = r.Next(0, 35)
            sb.Append(s.Substring(idx, 1))
        Next
        Dim password_string = sb.ToString()

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
            e_mail.Body = "Your new password is " + password_string & Environment.NewLine + "It is advisable to change your password after logging in"
            Smtp_server.Send(e_mail)
            MessageBox.Show("Mail Sent, Thank You!")
        Catch ex As Exception
            Dim sop As String = ex.Message & Environment.NewLine + "Try removing proxy!!"
            MessageBox.Show(sop)
            Exit Sub
        End Try

        Dim query2 As String = "SELECT * FROM faculty_info where Email= '" & email_text & "';"
        conn.Open()
        Dim cmdUpdate As New OleDbCommand(query2, conn)
        cmdUpdate.CommandText = "UPDATE faculty_info SET [Password] = '" + password_string + "' WHERE ID = " & id_number & ";"
        Try
            cmdUpdate.ExecuteNonQuery() 'Executing Update Command
        Catch ex As Exception
            MessageBox.Show(ex.Message) 'Error Message
        End Try
        conn.Close()

    End Sub
End Class