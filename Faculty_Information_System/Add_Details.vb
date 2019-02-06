Imports Microsoft.VisualBasic
Imports System.Data.OleDb
Imports System.Data


Public Class Add_Details
    Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Faculty_database.accdb;Jet OLEDB:Database Password=group11"

    Public Property EmailPass As String
    Private Sub Add_Details_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click

        Dim id_number As Integer
        Dim Position As String = ""
        Dim Room As String = ""
        Dim Telephone As String = ""
        Dim Education As String = ""
        Dim Responsibility As String = ""

        Dim query As String = "SELECT * FROM faculty_info where Email= '" & EmailPass & "';"
        Dim conn = New OleDbConnection(connectionString)
        conn.Open()
        Dim cmd As New OleDbCommand(query, conn)
        Dim Reader As OleDbDataReader = cmd.ExecuteReader()

        While (Reader.Read())
            id_number = Reader.GetValue(0)
            If IsDBNull(Reader.GetValue(8)) Then
                Position = ""
            Else
                Position = Reader.GetValue(8)
            End If

            If IsDBNull(Reader.GetValue(9)) Then
                Room = ""
            Else
                Room = Reader.GetValue(9)
            End If

            If IsDBNull(Reader.GetValue(10)) Then
                Telephone = ""
            Else
                Telephone = Reader.GetValue(10)
            End If

            If IsDBNull(Reader.GetValue(7)) Then
                Education = ""
            Else
                Education = Reader.GetValue(7)
            End If

            If IsDBNull(Reader.GetValue(13)) Then
                Responsibility = ""
            Else
                Responsibility = Reader.GetValue(13)
            End If

        End While

        If ComboBox_desig.Text <> "" Then
            Position = ComboBox_desig.Text.ToString
        End If

        If TextBox_room.Text <> "" Then
            Room = TextBox_room.Text
        End If

        If TextBox_tele.Text <> "" Then
            Telephone = TextBox_tele.Text
        End If

        If Education <> "" Then
            Education = Education & "," & TextBox_edu.Text
        Else
            Education = TextBox_edu.Text
        End If

        If Responsibility <> "" Then
            Responsibility = Responsibility & "," & TextBox_edu.Text
        Else
            Responsibility = TextBox_Responsibility.Text
        End If


        Dim cmdUpdate As New OleDbCommand(query, conn)
        cmdUpdate.CommandText = "UPDATE faculty_info SET  Position = '" & Position & "' , Room = '" & Room & "' , Telephone = '" & CInt(Telephone) & "' , Education = '" & Education & "' , Additional_Responsibilty = '" & Responsibility & "'    WHERE ID = " & id_number & ";"
        Try
            cmdUpdate.ExecuteNonQuery() 'Executing Update Command
        Catch ex As Exception
            MessageBox.Show(ex.Message) 'Error MEssage
        End Try
        conn.Close()
    End Sub

   
End Class