Imports Microsoft.VisualBasic
Imports System.Data.OleDb
Imports System.Data


Public Class Add_personal_prof
    Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Faculty_database.accdb;Jet OLEDB:Database Password=group11"
    Public Property EmailPass As String

    Private Sub Add_personal_prof_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim query As String = "SELECT * FROM faculty_info where Email= '" & EmailPass & "';"
        Dim conn = New OleDbConnection(connectionString)
        conn.Open()
        Dim cmd As New OleDbCommand(query, conn)
        Dim Reader As OleDbDataReader = cmd.ExecuteReader()

        Dim id_number As Integer
        TextBox1.Text = ""

        While (Reader.Read())
            id_number = Reader("ID")
            If IsDBNull(Reader("Designation")) Then
                ComboBox_desig.Text = ""
            Else
                ComboBox_desig.Text = Reader("Designation")
            End If

            If IsDBNull(Reader("Room")) Then
                TextBox_room.Text = ""
            Else
                TextBox_room.Text = Reader("Room")
            End If

            If IsDBNull(Reader("Telephone")) Then
                TextBox_tele.Text = ""
            Else
                TextBox_tele.Text = Reader("Telephone")
            End If

            If IsDBNull(Reader("Additional_Responsibilty")) Then
                TextBox_Responsibility.Text = ""
            Else
                TextBox_Responsibility.Text = Reader("Additional_Responsibilty")
            End If

            If IsDBNull(Reader("Personal_Homepage")) Then
                TextBox_homepage.Text = ""
            Else
                TextBox_homepage.Text = Reader("Personal_Homepage")
            End If
        End While

        Dim query2 As String = "SELECT * FROM Research_Interest"
        Dim cmdResearch As New OleDbCommand(query2, conn)
        Dim dr As OleDbDataReader = cmdResearch.ExecuteReader()

        Try
            While (dr.Read())
                If dr("Prof_id") = id_number Then
                    TextBox1.AppendText(dr("Field"))
                    TextBox1.AppendText(Environment.NewLine)
                End If
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning")
        End Try
        conn.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dialog As New OpenFileDialog()
        dialog.Title = "Browse Picture"
        dialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG"
        If dialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(dialog.FileName)
        End If
        dialog.Dispose()
    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Dim id_number As Integer
        Dim Designation As String = ""
        Dim Room As String = ""
        Dim Telephone As String = ""
        Dim Education As String = ""
        Dim Responsibility As String = ""
        Dim homepage As String = ""

        Dim conn = New OleDbConnection(connectionString)
        conn.Open()

        Dim query As String = "SELECT * FROM faculty_info where Email= '" & EmailPass & "';"
        Dim cmd As New OleDbCommand(query, conn)
        Dim Reader As OleDbDataReader = cmd.ExecuteReader()

        Designation = ComboBox_desig.Text.ToString

        While (Reader.Read())
            id_number = Reader("ID")
        End While

        Dim query2 As String = "delete from Research_Interest where Prof_id =@sno"
        Dim cmdResearch As New OleDbCommand(query2, conn)
        cmdResearch.Parameters.AddWithValue("@sno", id_number)
        Try
            cmdResearch.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Room = TextBox_room.Text
        Telephone = TextBox_tele.Text
        Responsibility = TextBox_Responsibility.Text
        homepage = TextBox_homepage.Text

        Dim cmdUpdate As New OleDbCommand(query, conn)
        cmdUpdate.CommandText = "UPDATE faculty_info SET Designation = '" & Designation & "' , Room = '" & Room & "' , Telephone = '" & Telephone & "' , Additional_Responsibilty = '" & Responsibility & "' , Personal_Homepage = '" & homepage & "'WHERE ID = " & id_number & ";"
        Try
            cmdUpdate.ExecuteNonQuery() 'Executing Update Command
        Catch ex As Exception
            MessageBox.Show(ex.Message) 'Error Message
        End Try

        Dim query3 As String = "INSERT INTO Research_Interest ([Prof_id],[Field]) VALUES (?,?)"

        Dim Ar() As String = Split(TextBox1.Text, Environment.NewLine)
        For Each s As String In Ar
            Dim cmdResearchAdd As OleDbCommand = New OleDbCommand(query3, conn)
            cmdResearchAdd.Parameters.Add(New OleDbParameter("Prof_id", CType(id_number, Integer)))
            cmdResearchAdd.Parameters.Add(New OleDbParameter("Field", CType(s, String)))
            Try
                cmdResearchAdd.ExecuteNonQuery() 'Executing Update Command
                cmdResearchAdd.Dispose()
            Catch ex As Exception
                MessageBox.Show(ex.Message) 'Error Message
            End Try
        Next

        conn.Close()
        If Not PictureBox1.Image Is Nothing Then
            Try
                Using img As Image = PictureBox1.Image
                    img.Save(Application.StartupPath & "\media\" & id_number & ".jpeg")
                End Using
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
        Me.Close()
        Dim OBJ As New Form1
        OBJ.EmailPass = EmailPass
        OBJ.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PictureBox1.Image = Nothing
    End Sub
End Class