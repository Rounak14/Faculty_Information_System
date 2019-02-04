Imports Microsoft.VisualBasic
Imports System.Data.OleDb
Imports System.Data

Public Class Form1
    

    Public Property QueryPass As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
<<<<<<< HEAD
        ' MysqlConn = New MySqlConnection
        ' MysqlConn.ConnectionString =
        '"server=localhost;userid=root;password=<your password>;database=faculty"
=======
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
       "server=localhost;userid=root;password=Password11;database=faculty"
>>>>>>> b0a5384e0c9a2ca1826c2d586e299a5f9d5d8227

        ' Dim READER As MySqlDataReader
        ' Try
        '     MysqlConn.Open()
        '     'MessageBox.Show("Connection Successful")
        '     COMMAND = New MySqlCommand(QueryPass, MysqlConn)
        '     READER = COMMAND.ExecuteReader()
        '     While READER.Read
        '         Label2.Text = READER.GetValue(1)
        '     End While
        '     MysqlConn.Close()
        ' Catch ex As Exception
        '     MessageBox.Show(ex.Message)
        ' End Try

        
    End Sub
End Class