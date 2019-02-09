Imports Microsoft.VisualBasic
Imports System.Data.OleDb
Imports System.Data

Public Class Faculty_Page
    Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Faculty_database.accdb;Jet OLEDB:Database Password=group11"
    Public Property EmailPass As String

    Private Sub Faculty_Page_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
                name = Reader.GetValue(1)
                dept = Reader.GetValue(2)
                email = Reader.GetValue(3)

<<<<<<< HEAD
                Dim id As String = Reader.GetValue(4)

                PictureBox2.Image = Image.FromFile(Application.StartupPath & "\media\" & id & ".jpeg")
                research = Reader.GetValue(6)


=======
                Dim id As String = Reader.GetValue(0)

                PictureBox2.Image = Image.FromFile(Application.StartupPath & "\media\" & id & ".jpeg")
                research = Reader.GetValue(6)
>>>>>>> 259b6a71829b26fdab265815ca3a04c45e822114
            End While
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning")
        End Try

        Label_Details.Text = name & vbNewLine & dept & vbNewLine & email
    End Sub

    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        HomePanel.Visible = True
        TeachingPanel.Visible = False
        ResearchPanel.Visible = False
        PublicationsPanel.Visible = False


    End Sub

    Private Sub PublicationsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PublicationsToolStripMenuItem.Click
        HomePanel.Visible = False
        TeachingPanel.Visible = False
        ResearchPanel.Visible = False
        PublicationsPanel.Visible = True
    End Sub

    Private Sub ResearchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResearchToolStripMenuItem.Click
        HomePanel.Visible = False
        TeachingPanel.Visible = False
        ResearchPanel.Visible = True
        PublicationsPanel.Visible = False
    End Sub

    Private Sub TeachingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TeachingToolStripMenuItem.Click
        HomePanel.Visible = False
        TeachingPanel.Visible = True
        ResearchPanel.Visible = False
        PublicationsPanel.Visible = False
    End Sub

    
End Class