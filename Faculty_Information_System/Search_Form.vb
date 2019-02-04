Imports Microsoft.VisualBasic
Imports System.Data.OleDb
Imports System.Data

Public Class Search_Form
    Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Faculty_database.accdb;Jet OLEDB:Database Password=group11"
    Dim filter As String = ""


    Function SearchByDepartment(input As String) As String
        Dim conn = New OleDbConnection(connectionString)
        Try
            conn.Open()
            Dim query As String = "Select Name From faculty_info where Department= '" & input & "';"
            Dim cmd As New OleDbCommand(query, conn)
            Dim reader As OleDbDataReader = cmd.ExecuteReader()
            While (reader.Read())
                MessageBox.Show(reader.GetString(0))
            End While
            reader.Close()
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Function

    Function SearchByName(input As String) As String
        Dim conn = New OleDbConnection(connectionString)
        Try
            conn.Open()
            Dim query As String = "Select Name From faculty_info where Name is like '%" & input & "';"
            Dim cmd As New OleDbCommand(query, conn)
            Dim reader As OleDbDataReader = cmd.ExecuteReader()
            While (reader.Read())
                MessageBox.Show(reader.GetString(0))
            End While
            reader.Close()
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Function

    'Function SearchByResearchInterest(input As String) As String
    'MysqlConn = New MySqlConnection
    'MysqlConn.ConnectionString = "server=localhost;userid=root;password=Password11;database=faculty"
    'Dim READER As MySqlDataReader
    'Try
    '    MysqlConn.Open()
    '    Dim Query As String
    '    Query = "select * from faculty_info where Name='" & input & "' "
    '    COMMAND = New MySqlCommand(Query, MysqlConn)
    '    READER = COMMAND.ExecuteReader()

    '    Dim count As Integer
    '    count = 0
    '    While READER.Read
    '        count = count + 1
    '        MessageBox.Show(READER.GetValue(1))
    '    End While

    '    MysqlConn.Close()

    'Catch ex As MySqlException
    '    MessageBox.Show(ex.Message)
    'Finally
    '    MysqlConn.Dispose()

    'End Function


    Private Sub Login_Button_Click(sender As Object, e As EventArgs) Handles Login_Button.Click
        Form2.Show()
    End Sub


    Private Sub RadioButton_dept_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_dept.CheckedChanged
        filter = "Department"
        ComboBox_dept.Show()

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        filter = "Research Interest"
        ComboBox_dept.ResetText()
        ComboBox_dept.Hide()
        SearchBox.Text = ""
    End Sub

    Private Sub RadioButton_Name_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_Name.CheckedChanged
        filter = "Name"
        ComboBox_dept.ResetText()
        ComboBox_dept.Hide()
        SearchBox.Text = ""
    End Sub

    Private Sub Button_search_Click(sender As Object, e As EventArgs) Handles Button_search.Click
        If filter = "" Then
            MessageBox.Show("Select one Search by option")
        ElseIf SearchBox.Text = "" Then
            MessageBox.Show("Enter some query string")
        ElseIf filter = "Department" Then
            SearchByDepartment(SearchBox.Text.ToString)
        ElseIf filter = "Research Interest" Then
            'SearchByResearchInterest(SearchBox.Text.ToString)
        ElseIf filter = "Name" Then
            'SearchByName(SearchBox.Text.ToString)
        End If

    End Sub

    Private Sub Search_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox_dept.Hide()
    End Sub

    Private Sub ComboBox_dept_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_dept.SelectedIndexChanged
        SearchBox.Text = ComboBox_dept.Text
    End Sub


End Class
