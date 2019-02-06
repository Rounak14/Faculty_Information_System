Imports Microsoft.VisualBasic
Imports System.Data.OleDb
Imports System.Data

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
                    MessageBox.Show("Login success")
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
End Class