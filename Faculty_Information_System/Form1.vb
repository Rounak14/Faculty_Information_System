' image upload karke ke baad, ya fir in general info update karne ke liye logout karna pad rha hai

Imports Microsoft.VisualBasic
Imports System.Data.OleDb
Imports System.Data

Public Class Form1
    Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Faculty_database.accdb;Jet OLEDB:Database Password=group11"
    Dim img As Image
    Dim Imagepresent As Int32 = 1
    Public Property EmailPass As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim name As String
        Dim dept As String
        Dim email As String
        Dim id As String
        Dim query As String = "SELECT * FROM faculty_info where Email= '" & EmailPass & "';"
        Dim conn = New OleDbConnection(connectionString)
        conn.Open()
        Dim cmd As New OleDbCommand(query, conn)
        Dim Reader As OleDbDataReader = cmd.ExecuteReader()
        Try

            While (Reader.Read())
                name = Reader("Name")
                dept = Reader("Department")
                email = Reader("Email")
                id = Reader("ID")
            End While
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning")
        End Try

        Try
            img = Image.FromFile(Application.StartupPath & "\media\" & id & ".jpeg")
            PictureBox2.Image = img
        Catch ex As Exception
            Imagepresent = 0
        End Try
        Label_Details.Text = name & vbNewLine & dept & vbNewLine & email

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim SecondForm As New Search_Form
        SecondForm.Show()
        Me.Hide()
    End Sub

    Private Sub AboutMe_Button_Click(sender As Object, e As EventArgs) Handles AboutMe_Button.Click
        Dim OBJ As New Add_personal_prof
        OBJ.EmailPass = EmailPass
        If Imagepresent = 1 Then
            img.Dispose()
        End If
        OBJ.Show()
        Me.Close()
    End Sub

    Private Sub Button_preview_Click(sender As Object, e As EventArgs) Handles Button_preview.Click
        Dim OBJ As New Faculty_Page
        OBJ.EmailPass = EmailPass
        OBJ.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim OBJ As New password_reset
        OBJ.EmailPass = EmailPass
        OBJ.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim OBJ As New Prof_Edu
        OBJ.EmailPass = EmailPass
        OBJ.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim OBJ As New Prof_Courses
        OBJ.EmailPass = EmailPass
        OBJ.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim OBJ As New Prof_Publication
        OBJ.EmailPass = EmailPass
        OBJ.Show()
    End Sub
End Class