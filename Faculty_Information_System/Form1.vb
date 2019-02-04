Imports Microsoft.VisualBasic
Imports System.Data.OleDb
Imports System.Data

Public Class Form1
    Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Faculty_database.accdb;Jet OLEDB:Database Password=group11"

    Public Property EmailPass As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim query As String = "Select Name From faculty_info where Email= '" & EmailPass & "';"
        Dim conn = New OleDbConnection(connectionString)
        Dim cmd As New OleDbCommand(query, conn)
        Try
            conn.Open()
            Dim name As String = cmd.ExecuteScalar().ToString
            Label_Details.Text = name
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning")
        End Try





    End Sub

   
End Class