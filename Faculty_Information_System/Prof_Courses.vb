Imports Microsoft.VisualBasic
Imports System.Data.OleDb
Imports System.Data

Public Class Prof_Courses
    Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Faculty_database.accdb;Jet OLEDB:Database Password=group11"
    Public Property EmailPass As String


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (String.IsNullOrWhiteSpace(TextBox4.Text)) Or (String.IsNullOrWhiteSpace(TextBox1.Text)) Or (String.IsNullOrWhiteSpace(TextBox2.Text)) Or (String.IsNullOrWhiteSpace(TextBox5.Text)) Then
            MessageBox.Show("First fill all the required entries", "Warning")
            Exit Sub
        End If
        If RadioButton1.Checked = False And RadioButton2.Checked = False Then
            MessageBox.Show("Check whether it's a old course or a new course", "Warning")
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

        Dim course_url As String = ""

        If Not TextBox3.Text = "" Then
            course_url = TextBox3.Text
        End If

        Dim course_code As String = TextBox1.Text
        Dim course_name As String = TextBox2.Text
        Dim sem As Integer = TextBox4.Text
        Dim teach_year As Integer = TextBox5.Text

        Dim peep As Boolean
        If RadioButton1.Checked = True Then
            peep = True
        Else
            peep = False
        End If

        Dim query2 As String = "INSERT INTO Teaching ([Prof_id],[Course_no],[Course_Title],[Taught_Year],[Semester],[Current],[Course_url]) VALUES (?,?,?,?,?,?,?)"
        Dim cmdTeach As OleDbCommand = New OleDbCommand(query2, conn)
        cmdTeach.Parameters.Add(New OleDbParameter("Prof_id", CType(id_number, Integer)))
        cmdTeach.Parameters.Add(New OleDbParameter("Course_no", CType(course_code, String)))
        cmdTeach.Parameters.Add(New OleDbParameter("Course_Title", CType(course_name, String)))
        cmdTeach.Parameters.Add(New OleDbParameter("Taught_Year", CType(teach_year, Integer)))
        cmdTeach.Parameters.Add(New OleDbParameter("Semester", CType(sem, Integer)))
        cmdTeach.Parameters.Add(New OleDbParameter("Current", CType(peep, Boolean)))
        cmdTeach.Parameters.Add(New OleDbParameter("Course_url", CType(course_url, String)))

        Try
            cmdTeach.ExecuteNonQuery() 'Executing Update Command
            cmdTeach.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message) 'Error Message
        End Try
        conn.Close()
        Me.Close()
    End Sub

    Private Sub TextBox4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox4.KeyPress
        If Asc(e.KeyChar) > 57 Or (Asc(e.KeyChar) < 48 And Asc(e.KeyChar) > 8) Or Asc(e.KeyChar) < 8 Then
            MessageBox.Show("Please enter integers only", "Warning")
            TextBox1.Clear()
            Exit Sub
        End If
    End Sub

    Private Sub TextBox5_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox5.KeyPress
        If Asc(e.KeyChar) > 57 Or (Asc(e.KeyChar) < 48 And Asc(e.KeyChar) > 8) Or Asc(e.KeyChar) < 8 Then
            MessageBox.Show("Please enter integers only", "Warning")
            TextBox1.Clear()
            Exit Sub
        End If
    End Sub

End Class