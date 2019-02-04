Imports Microsoft.VisualBasic
Imports System.Data.OleDb
Imports System.Data

Public Class Form2
    Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Faculty_database.accdb;Jet OLEDB:Database Password=group11"
    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
<<<<<<< HEAD
        Dim email_id As String = ""
        Dim password As String
        Dim username As String = ""
        Dim pass As String
=======
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=Password11;database=faculty"

>>>>>>> b0a5384e0c9a2ca1826c2d586e299a5f9d5d8227
        Try
            
        Catch ex As Exception

        End Try
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
                MessageBox.Show("Login success")
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
End Class