Imports Microsoft.VisualBasic
Imports System.Data.OleDb
Imports System.Data

Public Class Prof_Experience
    Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Faculty_database.accdb;Jet OLEDB:Database Password=group11"
    Public Property EmailPass As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (String.IsNullOrWhiteSpace(TextBox1.Text)) Or (String.IsNullOrWhiteSpace(TextBox2.Text)) Then
            MessageBox.Show("First fill all the required entries", "Warning")
            Exit Sub
        End If

        Dim query As String = "SELECT * FROM faculty_info where Email= '" & EmailPass & "';"
        Dim conn = New OleDbConnection(connectionString)
        conn.Open()
        Dim cmd As New OleDbCommand(query, conn)
        Dim Reader As OleDbDataReader = cmd.ExecuteReader()

        Dim id_number As Integer
        Try
            While (Reader.Read())
                id_number = Reader("ID")
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Reader.Close()

        Dim time_start As String = ""
        If Not TextBox3.Text = "" Then
            time_start = TextBox3.Text
        End If
        Dim time_end As String = ""
        If Not TextBox4.Text = "" Then
            time_end = TextBox4.Text
        End If
        Dim postring As String = TextBox1.Text
        Dim instistring As String = TextBox2.Text

        Dim query2 As String = "INSERT INTO Experience ([Prof_id],[Post],[Institute],[From],[To]) VALUES (?,?,?,?,?)"
        Dim cmdExp As OleDbCommand = New OleDbCommand(query2, conn)
        cmdExp.Parameters.Add(New OleDbParameter("Prof_id", CType(id_number, Integer)))
        cmdExp.Parameters.Add(New OleDbParameter("Post", CType(postring, String)))
        cmdExp.Parameters.Add(New OleDbParameter("Institute", CType(instistring, String)))
        cmdExp.Parameters.Add(New OleDbParameter("From", CType(time_start, String)))
        cmdExp.Parameters.Add(New OleDbParameter("To", CType(time_end, String)))

        Try
            cmdExp.ExecuteNonQuery() 'Executing Update Command
            cmdExp.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message) 'Error Message
        End Try
        conn.Close()
        Me.Close()
    End Sub
End Class