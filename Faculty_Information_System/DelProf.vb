Imports Microsoft.VisualBasic
Imports System.Data.OleDb
Imports System.Data

Public Class DelProf
    Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Faculty_database.accdb;Jet OLEDB:Database Password=group11"

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If String.IsNullOrEmpty(TextBox1.Text) Then
            MessageBox.Show("email entry must not be empty", "Warning")
            TextBox1.Clear()
            Exit Sub
        End If

        Dim conn = New OleDbConnection(connectionString)
        Dim EmailPass = TextBox1.Text
        Dim query As String = "delete from faculty_info where Email =@sno"
        conn.Open()
        Dim cmd As New OleDbCommand(query, conn)
        cmd.Parameters.AddWithValue("@sno", EmailPass)

        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        conn.Close()
        Admin_form.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Admin_form.Show()
        Me.Close()
    End Sub

    Private Sub DelProf_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class