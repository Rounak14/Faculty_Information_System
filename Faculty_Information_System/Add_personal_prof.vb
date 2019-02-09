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

        While (Reader.Read())
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
        'Dim bytImage() As Byte
        'Try
        '    Dim ms As New System.IO.MemoryStream
        '    Dim bmpImage As New Bitmap(PictureBox1.Image)
        '    bmpImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
        '    bytImage = ms.ToArray()
        '    ms.Close()
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
        conn.Open()

        Dim query As String = "SELECT * FROM faculty_info where Email= '" & EmailPass & "';"
        Dim cmd As New OleDbCommand(query, conn)
        Dim Reader As OleDbDataReader = cmd.ExecuteReader()

        If ComboBox_desig.Text <> "" Then
            Designation = ComboBox_desig.Text.ToString
        End If

        While (Reader.Read())
            id_number = Reader("ID")
        End While

        Room = TextBox_room.Text
        Telephone = TextBox_tele.Text
        Responsibility = TextBox_Responsibility.Text
        homepage = TextBox_homepage.Text

        Dim cmdUpdate As New OleDbCommand(query, conn)
        cmdUpdate.CommandText = "UPDATE faculty_info SET Designation = '" & Designation & "' , Room = '" & Room & "' , Telephone = '" & Telephone & "' , Additional_Responsibilty = '" & Responsibility & "' , Personal_Homepage = '" & homepage & "'   WHERE ID = " & id_number & ";"
        Try
            cmdUpdate.ExecuteNonQuery() 'Executing Update Command
        Catch ex As Exception
            MessageBox.Show(ex.Message) 'Error Message
        End Try

        'Dim path As String = Application.StartupPath & "\media\" & id_number & ".jpeg"
        'Try
        '    My.Computer.FileSystem.DeleteFile(path)
        '    MessageBox.Show("jsdk")
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try
        conn.Close()
        Try
            'PictureBox1.Image.Save(Application.StartupPath & "\media\" & id_number & ".jpeg")
            Using img As Image = PictureBox1.Image
                img.Save(Application.StartupPath & "\media\" & id_number & ".jpeg")
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        'Dim cmdUpdate2 As New OleDbCommand(query, conn)
        'cmdUpdate2.CommandText = "INSERT INTO `faculty_info` [Image] VALUES (@image)"
        'cmdUpdate2.Parameters.AddWithValue("@image", bytImage)
        'Try
        '    cmdUpdate.ExecuteNonQuery() 'Executing Update Command
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message) 'Error Message
        'End Try
        'conn.Close()
        'Faculty_Page.Show()
        'Me.Close()
    End Sub

End Class