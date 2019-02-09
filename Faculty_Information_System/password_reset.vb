Imports Microsoft.VisualBasic
Imports System.Data.OleDb
Imports System.Data

Public Class password_reset

    Public Property EmailPass As String
    Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Faculty_database.accdb;Jet OLEDB:Database Password=group11"
    Private Sub password_reset_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conn = New OleDbConnection(connectionString)
        Dim query As String = "SELECT * FROM faculty_info where Email= '" & EmailPass & "';"
        Dim cmdUpdate As New OleDbCommand(query, conn)
        Dim Reader As OleDbDataReader = cmdUpdate.ExecuteReader()

        conn.Open()

        Dim old_pass As String
        Dim id As String
        Try
            While (Reader.Read())
                old_pass = Reader("Password")
                id = Reader("ID")
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

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

        cmdUpdate.CommandText = "UPDATE faculty_info SET Password = '" & new_pass & "' WHERE ID = " & id & ";"
        Try
            cmdUpdate.ExecuteNonQuery() 'Executing Update Command
        Catch ex As Exception
            MessageBox.Show(ex.Message) 'Error Message
        End Try
        conn.Close()
    End Sub
End Class