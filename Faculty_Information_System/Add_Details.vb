Imports Microsoft.VisualBasic
Imports System.Data.OleDb
Imports System.Data


Public Class Add_Details
    Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Faculty_database.accdb;Jet OLEDB:Database Password=group11"

    Public Property EmailPass As String
    Private Sub Add_Details_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Dim query As String = "SELECT ID FROM faculty_info where Email= '" & EmailPass & "';"
        Dim conn = New OleDbConnection(connectionString)
        conn.Open()
        Dim cmd As New OleDbCommand(query, conn)
        Dim Reader As OleDbDataReader = cmd.ExecuteReader()
        Dim id_number As Integer
        While (Reader.Read())
            id_number = Reader.GetValue(0)
        End While
        Dim cmdUpdate As New OleDbCommand(query, conn)
        cmdUpdate.CommandText = "UPDATE faculty_info SET Room = '" & TextBox1.Text & "' WHERE ID = " & id_number & ";"
        Try
            cmdUpdate.ExecuteNonQuery() 'Executing Update Command
        Catch ex As Exception
            MessageBox.Show(ex.Message) 'Error MEssage
        End Try
        conn.Close()
    End Sub

   
End Class