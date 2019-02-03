Imports Microsoft.VisualBasic
Imports MySql.Data.MySqlClient

Public Class Form2
    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand


    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
       "server=localhost;userid=root;password=Password11;database=faculty"

        Try
            MysqlConn.Open()
            'MessageBox.Show("Connection Successful")
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        End Try

        Dim READER As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "select * from faculty_info where email_id='" & TextBox_email.Text & "' and password='" & TextBox_Pass.Text & "' "
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader()

            Dim count As Integer
            count = 0
            While READER.Read
                count = count + 1
                MessageBox.Show(READER.GetValue(1))
            End While

            If count = 1 Then
                MessageBox.Show("Username and password are correct", "Message")
                Form1.Show()
                Me.Hide()
                Search_Form.Hide()
            ElseIf count > 1 Then
                MessageBox.Show("Username and password are Duplicate")
            Else
                MessageBox.Show("Username and password are not correct")

            End If


            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()

        End Try
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
End Class