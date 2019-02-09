Imports Microsoft.VisualBasic
Imports System.Data.OleDb
Imports System.Data

Public Class Form1
    Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Faculty_database.accdb;Jet OLEDB:Database Password=group11"
    Dim img As Image
    Public Property EmailPass As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim name As String
        Dim dept As String
        Dim email As String
        Dim research As String
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

                Dim id As String = Reader.GetValue(0)


                img = Image.FromFile(Application.StartupPath & "\media\" & id & ".jpeg")
                PictureBox2.Image = img
                research = Reader.GetValue(6)

            End While
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning")
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
        img.Dispose()
        OBJ.Show()
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
End Class