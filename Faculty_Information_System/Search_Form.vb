Imports Microsoft.VisualBasic
Imports MySql.Data.MySqlClient

Public Class Search_Form
    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand

    Dim filter As String = ""

   
    Function SearchByDepartment(input As String) As String
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=Password11;database=faculty"
        Dim READER As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "select * from faculty_info where Department='" & input & "' "
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader()

            Dim count As Integer
            count = 0
            While READER.Read
                count = count + 1
                MessageBox.Show(READER.GetValue(1))
            End While

            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()

        End Try
    End Function

    Function SearchByName(input As String) As String
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=Password11;database=faculty"
        Dim READER As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "select * from faculty_info where Name='" & input & "' "
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader()

            Dim count As Integer
            count = 0
            While READER.Read
                count = count + 1
                MessageBox.Show(READER.GetValue(1))
            End While

            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()

        End Try
    End Function


    Private Sub Login_Button_Click(sender As Object, e As EventArgs) Handles Login_Button.Click
        Form2.Show()
    End Sub


    Private Sub RadioButton_dept_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_dept.CheckedChanged
        filter = "Department"
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        filter = "Research Interest"
    End Sub

    Private Sub Button_search_Click(sender As Object, e As EventArgs) Handles Button_search.Click
        If filter = "" Then
            MessageBox.Show("Select one Search by option")
        ElseIf SearchBox.Text = "" Then
            MessageBox.Show("Enter some query string")
        ElseIf filter = "Department" Then
            SearchByDepartment(SearchBox.Text.ToString)
        ElseIf filter = "Research Interest" Then
            MessageBox.Show("Fiter not available as of now. Will get back to you soon!!!!!")
            'SearchByName(SearchBox.Text.ToString)
        End If

    End Sub
End Class