Imports Microsoft.VisualBasic
Imports System.Data.OleDb
Imports System.Data

Public Class Prof_Achievements
    Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Faculty_database.accdb;Jet OLEDB:Database Password=group11"
    Public Property EmailPass As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (String.IsNullOrWhiteSpace(TextBox1.Text)) Or (String.IsNullOrWhiteSpace(TextBox2.Text)) Or (String.IsNullOrWhiteSpace(TextBox3.Text)) Then
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

        Dim title_string As String = TextBox1.Text
        Dim issuestring As String = TextBox2.Text
        Dim year As Integer = CInt(TextBox3.Text)

        Dim query2 As String = "INSERT INTO Achievements ([Prof_id],[Title],[Issued_By],[Year]) VALUES (?,?,?,?)"
        Dim cmdAch As OleDbCommand = New OleDbCommand(query2, conn)
        cmdAch.Parameters.Add(New OleDbParameter("Prof_id", CType(id_number, Integer)))
        cmdAch.Parameters.Add(New OleDbParameter("Title", CType(title_string, String)))
        cmdAch.Parameters.Add(New OleDbParameter("Issued_By", CType(issuestring, String)))
        cmdAch.Parameters.Add(New OleDbParameter("Year", CType(year, Integer)))

        Try
            cmdAch.ExecuteNonQuery() 'Executing Update Command
            cmdAch.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message) 'Error Message
        End Try
        conn.Close()
        Me.Close()

    End Sub

    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        If Asc(e.KeyChar) > 57 Or (Asc(e.KeyChar) < 48 And Asc(e.KeyChar) > 8) Or Asc(e.KeyChar) < 8 Then
            MessageBox.Show("Please enter integers only", "Warning")
            TextBox1.Clear()
            Exit Sub
        End If
    End Sub

End Class