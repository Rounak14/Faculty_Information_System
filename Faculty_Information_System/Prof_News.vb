Imports Microsoft.VisualBasic
Imports System.Data.OleDb
Imports System.Data

Public Class Prof_News
    Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Faculty_database.accdb;Jet OLEDB:Database Password=group11"
    Public Property EmailPass As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MessageBox.Show("Fill the news first")
            Exit Sub
        End If

        Dim query As String = "SELECT * FROM faculty_info where Email= '" & EmailPass & "';"
        Dim conn = New OleDbConnection(connectionString)
        conn.Open()
        Dim cmd As New OleDbCommand(query, conn)
        Dim Reader As OleDbDataReader = cmd.ExecuteReader()

        Dim id_number As Integer
        Try
            While (Reader.Read())
                id_number = Reader("ID")
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Reader.Close()

        Dim news_add As String = Trim(TextBox1.Text)
        
        Dim checker As Boolean

        If RadioButton1.Checked = False And RadioButton2.Checked = False Then
            MessageBox.Show("Select one radio button before adding news", "Warning")
            Exit Sub
        End If

        If RadioButton1.Checked Then
            checker = True
        ElseIf RadioButton2.Checked Then
            checker = False
        End If

        Dim query2 As String = "INSERT INTO News ([Prof_id],[News],[Important]) VALUES (?,?,?)"
        Dim cmdNews As OleDbCommand = New OleDbCommand(query2, conn)
        cmdNews.Parameters.Add(New OleDbParameter("Prof_id", CType(id_number, Integer)))
        cmdNews.Parameters.Add(New OleDbParameter("News", CType(news_add, String)))
        cmdNews.Parameters.Add(New OleDbParameter("Important", CType(checker, Boolean)))

        Try
            cmdNews.ExecuteNonQuery() 'Executing Update Command
            cmdNews.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message) 'Error Message
        End Try
        conn.Close()
        Me.Close()

    End Sub

    Private Sub Prof_News_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim query As String = "SELECT * FROM faculty_info where Email= '" & EmailPass & "';"
        Dim conn = New OleDbConnection(connectionString)
        conn.Open()
        Dim cmd As New OleDbCommand(query, conn)
        Dim Reader As OleDbDataReader = cmd.ExecuteReader()

        Dim id_number As Integer
        Try
            While (Reader.Read())
                id_number = Reader("ID")
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Reader.Close()
        cmd.Dispose()

        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        Dim query2 As String = "SELECT * FROM News"
        Dim cmdNewsShow As New OleDbCommand(query2, conn)
        Dim ReaderNews As OleDbDataReader = cmdNewsShow.ExecuteReader()

        Try
            While (ReaderNews.Read())
                If id_number = ReaderNews("Prof_id") Then
                    TextBox2.AppendText(ReaderNews("ID") & vbNewLine)
                    TextBox3.AppendText(ReaderNews("News") & vbNewLine)
                End If
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning")
        End Try

        ReaderNews.Close()
        conn.Close()
    End Sub

    Private Sub TextBox4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox4.KeyPress
        If Asc(e.KeyChar) > 57 Or (Asc(e.KeyChar) < 48 And Asc(e.KeyChar) > 8) Or Asc(e.KeyChar) < 8 Then
            MessageBox.Show("Please enter integers only", "Warning")
            TextBox1.Clear()
            Exit Sub
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox4.Text = "" Then
            MessageBox.Show("First enter the news ID to delete", "Warning")
            Exit Sub
        End If

        Dim id_num As Integer = CInt(TextBox4.Text)

        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Dim conn = New OleDbConnection(connectionString)
        conn.Open()
        Dim query2 As String = "delete from News where ID =@sno"
        Dim cmdDel As New OleDbCommand(query2, conn)
        cmdDel.Parameters.AddWithValue("@sno", id_num)

        Try
            cmdDel.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cmdDel.Dispose()
        End Try
        conn.Close()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim query As String = "SELECT * FROM faculty_info where Email= '" & EmailPass & "';"
        Dim conn = New OleDbConnection(connectionString)
        conn.Open()
        Dim cmd As New OleDbCommand(query, conn)
        Dim Reader As OleDbDataReader = cmd.ExecuteReader()

        Dim id_number As Integer
        Try
            While (Reader.Read())
                id_number = Reader("ID")
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Reader.Close()

        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        Dim top_string As String = Trim(TextBox4.Text)
        Dim top_change As String = Trim(TextBox5.Text)
        If top_string = "" Or top_change = "" Then
            MessageBox.Show("Before updating news, tell us the news ID and the new updated news")
        End If

        Dim id_num As Integer = CInt(TextBox4.Text)

        Dim query2 As String = "delete from News where ID =@sno"
        Dim cmdDel As New OleDbCommand(query2, conn)
        cmdDel.Parameters.AddWithValue("@sno", id_num)
        Try
            cmdDel.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        cmdDel.Dispose()

        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Dim checker As Boolean

        If RadioButton3.Checked = False And RadioButton4.Checked = False Then
            MessageBox.Show("Select one radio button before updating news", "Warning")
            Exit Sub
        End If

        If RadioButton3.Checked Then
            checker = True
        ElseIf RadioButton4.Checked Then
            checker = False
        End If

        Dim query3 As String = "INSERT INTO News ([Prof_id],[News],[Important]) VALUES (?,?,?)"
        Dim cmdNews As OleDbCommand = New OleDbCommand(query3, conn)
        cmdNews.Parameters.Add(New OleDbParameter("Prof_id", CType(id_number, Integer)))
        cmdNews.Parameters.Add(New OleDbParameter("News", CType(top_change, String)))
        cmdNews.Parameters.Add(New OleDbParameter("Important", CType(checker, Boolean)))

        Try
            cmdNews.ExecuteNonQuery() 'Executing Update Command
            cmdNews.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message) 'Error Message
        End Try
        conn.Close()
        Me.Close()

    End Sub
End Class