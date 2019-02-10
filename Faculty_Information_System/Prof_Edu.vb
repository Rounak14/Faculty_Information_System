Imports Microsoft.VisualBasic
Imports System.Data.OleDb
Imports System.Data

Public Class Prof_Edu
    Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Faculty_database.accdb;Jet OLEDB:Database Password=group11"
    Public Property EmailPass As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (String.IsNullOrWhiteSpace(ComboBox1.Text)) Or (String.IsNullOrWhiteSpace(TextBox1.Text)) Or (String.IsNullOrWhiteSpace(TextBox2.Text)) Or (String.IsNullOrWhiteSpace(TextBox3.Text)) Then
            MessageBox.Show("First fill all the required entries", "Warning")
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

        Dim degree As String = ComboBox1.Text
        Dim passingyear As Integer = CInt(TextBox1.Text)
        Dim insti As String = TextBox2.Text
        Dim subject As String = TextBox3.Text

        Dim query2 As String = "INSERT INTO Education ([Prof_id],[Degree],[Institute],[Subject],[Passing_Year]) VALUES (?,?,?,?,?)"
        Dim cmdEdu As OleDbCommand = New OleDbCommand(query2, conn)
        cmdEdu.Parameters.Add(New OleDbParameter("Prof_id", CType(id_number, Integer)))
        cmdEdu.Parameters.Add(New OleDbParameter("Degree", CType(degree, String)))
        cmdEdu.Parameters.Add(New OleDbParameter("Institute", CType(insti, String)))
        cmdEdu.Parameters.Add(New OleDbParameter("Subject", CType(subject, String)))
        cmdEdu.Parameters.Add(New OleDbParameter("Passing_Year", CType(passingyear, Integer)))

        Try
            cmdEdu.ExecuteNonQuery() 'Executing Update Command
            cmdEdu.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message) 'Error Message
        End Try
        conn.Close()
        Me.Close()
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If Asc(e.KeyChar) > 57 Or (Asc(e.KeyChar) < 48 And Asc(e.KeyChar) > 8) Or Asc(e.KeyChar) < 8 Then
            MessageBox.Show("Please enter integers only", "Warning")
            TextBox1.Clear()
            Exit Sub
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim OBJ As New Faculty_Page
        OBJ.EmailPass = EmailPass
        OBJ.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class