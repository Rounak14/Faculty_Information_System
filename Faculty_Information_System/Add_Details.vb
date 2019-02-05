Imports Microsoft.VisualBasic
Imports System.Data.OleDb
Imports System.Data


Public Class Add_Details
    Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Faculty_database.accdb;Jet OLEDB:Database Password=group11"

    Public Property EmailPass As String
    Private Sub Add_Details_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class