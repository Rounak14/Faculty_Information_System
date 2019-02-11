' image upload karke ke baad, ya fir in general info update karne ke liye logout karna pad rha hai

Imports Microsoft.VisualBasic
Imports System.Data.OleDb
Imports System.Data


Public Class Form1
    Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Faculty_database.accdb;Jet OLEDB:Database Password=group11"
    Dim img As Image
    Dim Imagepresent As Int32 = 1
    Public Property EmailPass As String

    Function Loader()

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
            'img.Dispose()
        Catch ex As Exception
            Imagepresent = 0
        End Try
        Label_Details.Text = name & vbNewLine & dept & vbNewLine & email
    End Function
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Loader()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.BackColor = Color.Aqua
        AboutMe_Button.BackColor = Color.Turquoise
        Button_preview.BackColor = Color.Turquoise
        Button2.BackColor = Color.Turquoise
        Button3.BackColor = Color.Turquoise
        Button4.BackColor = Color.Turquoise
        Button5.BackColor = Color.Turquoise
        Button6.BackColor = Color.Turquoise
        Button7.BackColor = Color.Turquoise
        Dim SecondForm As New Search_Form
        SecondForm.Show()
        startup.Hide()
        Me.Close()
    End Sub

    Private Sub AboutMe_Button_Click(sender As Object, e As EventArgs) Handles AboutMe_Button.Click
        Button1.BackColor = Color.Turquoise
        AboutMe_Button.BackColor = Color.Aqua
        Button_preview.BackColor = Color.Turquoise
        Button2.BackColor = Color.Turquoise
        Button3.BackColor = Color.Turquoise
        Button4.BackColor = Color.Turquoise
        Button5.BackColor = Color.Turquoise
        Button6.BackColor = Color.Turquoise
        Button7.BackColor = Color.Turquoise
        Panel2.Controls.Clear()
        Dim OBJ As New Add_personal_prof
        OBJ.EmailPass = EmailPass
        If Imagepresent = 1 Then
            img.Dispose()
        End If
        OBJ.TopLevel = False
        Panel2.Controls.Add(OBJ)
        OBJ.Show()
    End Sub

    Private Sub Button_preview_Click(sender As Object, e As EventArgs) Handles Button_preview.Click
        Button1.BackColor = Color.Turquoise
        AboutMe_Button.BackColor = Color.Turquoise
        Button_preview.BackColor = Color.Aqua
        Button2.BackColor = Color.Turquoise
        Button3.BackColor = Color.Turquoise
        Button4.BackColor = Color.Turquoise
        Button5.BackColor = Color.Turquoise
        Button6.BackColor = Color.Turquoise
        Button7.BackColor = Color.Turquoise
        Dim OBJ As New Faculty_Page
        OBJ.EmailPass = EmailPass
        OBJ.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Button1.BackColor = Color.Turquoise
        AboutMe_Button.BackColor = Color.Turquoise
        Button_preview.BackColor = Color.Turquoise
        Button2.BackColor = Color.Aqua
        Button3.BackColor = Color.Turquoise
        Button4.BackColor = Color.Turquoise
        Button5.BackColor = Color.Turquoise
        Button6.BackColor = Color.Turquoise
        Button7.BackColor = Color.Turquoise
        Panel2.Controls.Clear()
        Dim OBJ As New password_reset
        OBJ.EmailPass = EmailPass
        OBJ.TopLevel = False
        OBJ.Size = Panel2.Size
        Panel2.Controls.Add(OBJ)
        OBJ.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Button1.BackColor = Color.Turquoise
        AboutMe_Button.BackColor = Color.Turquoise
        Button_preview.BackColor = Color.Turquoise
        Button2.BackColor = Color.Turquoise
        Button3.BackColor = Color.Aqua
        Button4.BackColor = Color.Turquoise
        Button5.BackColor = Color.Turquoise
        Button6.BackColor = Color.Turquoise
        Button7.BackColor = Color.Turquoise
        Panel2.Controls.Clear()
        Dim OBJ As New Prof_Edu
        OBJ.EmailPass = EmailPass
        OBJ.TopLevel = False
        Panel2.Controls.Add(OBJ)
        OBJ.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Button1.BackColor = Color.Turquoise
        AboutMe_Button.BackColor = Color.Turquoise
        Button_preview.BackColor = Color.Turquoise
        Button2.BackColor = Color.Turquoise
        Button3.BackColor = Color.Turquoise
        Button4.BackColor = Color.Aqua
        Button5.BackColor = Color.Turquoise
        Button6.BackColor = Color.Turquoise
        Button7.BackColor = Color.Turquoise
        Panel2.Controls.Clear()
        Dim OBJ As New Prof_Courses
        OBJ.EmailPass = EmailPass
        OBJ.TopLevel = False
        OBJ.Size = Panel2.Size
        Panel2.Controls.Add(OBJ)
        OBJ.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Button1.BackColor = Color.Turquoise
        AboutMe_Button.BackColor = Color.Turquoise
        Button_preview.BackColor = Color.Turquoise
        Button2.BackColor = Color.Turquoise
        Button3.BackColor = Color.Turquoise
        Button4.BackColor = Color.Turquoise
        Button5.BackColor = Color.Aqua
        Button6.BackColor = Color.Turquoise
        Button7.BackColor = Color.Turquoise
        Panel2.Controls.Clear()
        Dim OBJ As New Prof_Publication
        OBJ.EmailPass = EmailPass
        OBJ.TopLevel = False
        OBJ.Size = Panel2.Size
        Panel2.Controls.Add(OBJ)
        OBJ.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Button1.BackColor = Color.Turquoise
        AboutMe_Button.BackColor = Color.Turquoise
        Button_preview.BackColor = Color.Turquoise
        Button2.BackColor = Color.Turquoise
        Button3.BackColor = Color.Turquoise
        Button4.BackColor = Color.Turquoise
        Button5.BackColor = Color.Turquoise
        Button6.BackColor = Color.Aqua
        Button7.BackColor = Color.Turquoise
        Panel2.Controls.Clear()
        Dim OBJ As New Prof_Experience
        OBJ.EmailPass = EmailPass
        OBJ.TopLevel = False
        OBJ.Size = Panel2.Size
        Panel2.Controls.Add(OBJ)
        OBJ.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Button1.BackColor = Color.Turquoise
        AboutMe_Button.BackColor = Color.Turquoise
        Button_preview.BackColor = Color.Turquoise
        Button2.BackColor = Color.Turquoise
        Button3.BackColor = Color.Turquoise
        Button4.BackColor = Color.Turquoise
        Button5.BackColor = Color.Turquoise
        Button6.BackColor = Color.Turquoise
        Button7.BackColor = Color.Aqua
        Panel2.Controls.Clear()
        Dim OBJ As New Prof_Achievements
        OBJ.EmailPass = EmailPass
        OBJ.TopLevel = False
        OBJ.Size = Panel2.Size
        Panel2.Controls.Add(OBJ)
        OBJ.Show()
    End Sub

   
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    
End Class