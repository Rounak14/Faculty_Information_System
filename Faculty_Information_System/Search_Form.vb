Imports Microsoft.VisualBasic
Imports System.Data.OleDb
Imports System.Data

Public Class Search_Form
    Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Faculty_database.accdb;Jet OLEDB:Database Password=group11"
    Dim filter As String = ""


    Function SearchByDepartment(input As String) As String
        Dim conn = New OleDbConnection(connectionString)
        Try
            conn.Open()
            Dim query As String = "Select * From faculty_info where Department= '" & input & "';"
            Dim cmd As New OleDbCommand(query, conn)
            Dim reader As OleDbDataReader = cmd.ExecuteReader()
            Dim count As Integer = 0
            While (reader.Read())
                'Dim newLabel As New Label
                'newLabel.Name = "TextBox" + reader.GetValue(0).ToString
                'newLabel.Text = reader.GetString(1)
                'newLabel.Location = New Point(100, 40)
                'Me.Controls.Add(newLabel)
                count = count + 1
                MessageBox.Show(reader.GetString(1))
            End While
            reader.Close()
            Dim MyLabel1(count) As Label
            Dim MyLabel2(count) As Label
            reader = cmd.ExecuteReader()
            Dim i As Integer = 1
            While (reader.Read())
                MyLabel1(i) = New Label()
                With MyLabel1(i)
                    .Name = "Lable" + i.ToString
                    .Text = reader.GetString(1)
                    .Visible = True
                    .Top = 60 + (30 * i)
                    .Width = 100
                End With
                MyLabel2(i) = New Label()
                With MyLabel2(i)
                    .Name = "Lable" + i.ToString
                    .Text = reader.GetString(1)
                    .Visible = True
                    .Top = 60 + (30 * i)
                    .Width = 200
                End With
            End While
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Function

    Function SearchByName(input As String) As String
        Dim conn = New OleDbConnection(connectionString)
        Try
            conn.Open()
            Dim query As String = "Select * From faculty_info where Name like '%" & input & "%'"
            Dim cmd As New OleDbCommand(query, conn)
            Dim reader As OleDbDataReader = cmd.ExecuteReader()
            While (reader.Read())
                MessageBox.Show(reader.GetString(1))
            End While
            reader.Close()
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Function

    Function SearchByResearchInterest(input As String) As String
        Dim conn = New OleDbConnection(connectionString)
        Try
            conn.Open()
            Dim query As String = "Select * From faculty_info where ResearchInterest like '%" & input & "%'"
            Dim cmd As New OleDbCommand(query, conn)
            Dim reader As OleDbDataReader = cmd.ExecuteReader()
            While (reader.Read())
                MessageBox.Show(reader.GetString(1))
            End While
            reader.Close()
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Function


    Private Sub Login_Button_Click(sender As Object, e As EventArgs) Handles Login_Button.Click
        Dim Secondform As New Form2
        Secondform.Show()
        Me.Hide()

    End Sub


    Private Sub RadioButton_dept_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_dept.CheckedChanged
        filter = "Department"
        ComboBox_dept.Show()

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        filter = "Research Interest"
        ComboBox_dept.ResetText()
        ComboBox_dept.Hide()
        SearchBox.Text = ""
    End Sub

    Private Sub RadioButton_Name_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_Name.CheckedChanged
        filter = "Name"
        ComboBox_dept.ResetText()
        ComboBox_dept.Hide()
        SearchBox.Text = ""
    End Sub

    Private Sub Button_search_Click(sender As Object, e As EventArgs) Handles Button_search.Click
        If filter = "" Then
            MessageBox.Show("Select one Search by option")
        ElseIf SearchBox.Text = "" Then
            MessageBox.Show("Enter some query string")
        ElseIf filter = "Department" Then
            SearchByDepartment(SearchBox.Text.ToString)
        ElseIf filter = "Research Interest" Then
            SearchByResearchInterest(SearchBox.Text.ToString)
        ElseIf filter = "Name" Then
            SearchByName(SearchBox.Text.ToString)
        End If

    End Sub

    Private Sub Search_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox_dept.Hide()
    End Sub

    Private Sub ComboBox_dept_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_dept.SelectedIndexChanged
        SearchBox.Text = ComboBox_dept.Text
    End Sub


End Class
