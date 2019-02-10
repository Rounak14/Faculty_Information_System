Imports Microsoft.VisualBasic
Imports System.Data.OleDb
Imports System.Data

Public Class password_reset

    Public Property EmailPass As String
    Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Faculty_database.accdb;Jet OLEDB:Database Password=group11"

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim conn = New OleDbConnection(connectionString)
        Dim query As String = "SELECT * FROM faculty_info where Email= '" & EmailPass & "';"
        conn.Open()
        Dim cmd As New OleDbCommand(query, conn)
        Dim Reader As OleDbDataReader = cmd.ExecuteReader()

        Dim old_pass As String
        Dim id_number As Integer
        Try
            While (Reader.Read())
                old_pass = Reader("Password")
                id_number = Reader("ID")
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Reader.Close()
        conn.Close()
        If String.IsNullOrEmpty(TextBox1.Text) Or String.IsNullOrEmpty(TextBox2.Text) Or String.IsNullOrEmpty(TextBox3.Text) Then
            MessageBox.Show("Fill all the three boxes", "Warning")
            Exit Sub
        End If

        If Not (old_pass = TextBox1.Text) Then
            MessageBox.Show("You have entered the wrong old password", "Warning")
            TextBox1.Clear()
            Exit Sub
        End If

        Dim new_pass As String = TextBox2.Text
        Dim new_pass_confirm As String = TextBox3.Text

        If Not new_pass = new_pass_confirm Then
            MessageBox.Show("Please enter new matching passwords", "Warning")
            TextBox2.Clear()
            TextBox3.Clear()
            Exit Sub
        End If
        conn.Open()
        Dim cmdUpdate As New OleDbCommand(query, conn)
        cmdUpdate.CommandText = "UPDATE faculty_info SET [Password] = '" + new_pass + "' WHERE ID = " & id_number & ";"
        Try
            cmdUpdate.ExecuteNonQuery() 'Executing Update Command
        Catch ex As Exception
            MessageBox.Show(ex.Message) 'Error Message
        End Try
        conn.Close()
        Me.Close()
    End Sub

    Private Sub password_reset_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class