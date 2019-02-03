Imports Microsoft.VisualBasic
Imports MySql.Data.MySqlClient

Public Class Form1
    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand

    Public Property QueryPass As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
       "server=localhost;userid=root;password=<your password>;database=faculty"

        Dim READER As MySqlDataReader
        Try
            MysqlConn.Open()
            'MessageBox.Show("Connection Successful")
            COMMAND = New MySqlCommand(QueryPass, MysqlConn)
            READER = COMMAND.ExecuteReader()
            While READER.Read
                Label2.Text = READER.GetValue(1)
            End While
            MysqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        
    End Sub
End Class