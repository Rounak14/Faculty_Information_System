Imports Microsoft.VisualBasic
Imports System.Data.OleDb
Imports System.Data

Public Class AddProf
    Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Faculty_database.accdb;Jet OLEDB:Database Password=group11"

    Private Sub Update_Click(sender As Object, e As EventArgs) Handles Update.Click
        Dim conn = New OleDbConnection(connectionString)
        conn.Open()
        If String.IsNullOrEmpty(TextBox1.Text) Or String.IsNullOrEmpty(TextBox2.Text) Or String.IsNullOrEmpty(TextBox3.Text) Or String.IsNullOrEmpty(TextBox4.Text) Then
            MessageBox.Show("First Fill all the required entries")
            Exit Sub
        End If
        Dim namestring As String = TextBox1.Text
        Dim emailstring As String = TextBox2.Text
        Dim departmentstring As String = TextBox3.Text
        Dim passwordstring As String = TextBox4.Text
        Dim confirmpasswordstring As String = TextBox5.Text
        If Not (passwordstring = confirmpasswordstring) Then
            MessageBox.Show("Please enter matching passwords")
            TextBox5.Clear()
            TextBox4.Clear()
            Exit Sub
        End If
        Dim query As String
        query = "INSERT INTO faculty_info ([Name],[Department],[Email],[Password]) VALUES (?,?,?,?)"
        Dim cmd As OleDbCommand = New OleDbCommand(query, conn)
        cmd.Parameters.Add(New OleDbParameter("Name", CType(namestring, String)))
        cmd.Parameters.Add(New OleDbParameter("Email", CType(emailstring, String)))
        cmd.Parameters.Add(New OleDbParameter("Department", CType(departmentstring, String)))
        cmd.Parameters.Add(New OleDbParameter("Password", CType(passwordstring, String)))

        Try
            cmd.ExecuteNonQuery() 'Executing Update Command
            cmd.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message) 'Error Message
        End Try
        Me.Hide()
        Admin_form.Show()
        conn.Close()
    End Sub

End Class