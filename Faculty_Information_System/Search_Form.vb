Imports Microsoft.VisualBasic
Imports System.Data.OleDb
Imports System.Data


Public Class Search_Form
    Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Faculty_database.accdb;Jet OLEDB:Database Password=group11"
    Dim filter As String = ""

    Dim dr, df As System.Data.OleDb.OleDbDataReader
    Dim tb As New DataTable("faculty_info")

    Function SearchByDepartment(input As String) As String
        Dim conn = New OleDbConnection(connectionString)
        Try
            conn.Open()
            Dim query As String = "Select * From faculty_info where Department= '" & input & "';"
            Dim cmd As New OleDbCommand(query, conn)
            Dim reader As OleDbDataReader = cmd.ExecuteReader()
            Dim count As Integer = 0
            While (reader.Read())
                count += 1
            End While
            If count = 0 Then
                MessageBox.Show("No Records!")
            Else
                DataGridView1.Show()
            End If
            reader.Close()
            dr = cmd.ExecuteReader()
            While dr.Read()
                Dim n, email, dept As String
                n = dr("Name").ToString
                email = dr("Email").ToString
                dept = dr("Department").ToString
                tb.Rows.Add(n.ToString, email.ToString, dept.ToString)
                DataGridView1.DataSource = tb
            End While
            conn.Close()
            dr.Close()
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
            Dim count As Integer = 0
            While (reader.Read())
                count += 1
            End While
            If count = 0 Then
                MessageBox.Show("No Records!")
            Else
                DataGridView1.Show()
            End If
            reader.Close()
            dr = cmd.ExecuteReader()
            While dr.Read()
                Dim n, email, dept As String
                n = dr("Name").ToString
                email = dr("Email").ToString
                dept = dr("Department").ToString
                tb.Rows.Add(n.ToString, email.ToString, dept.ToString)
                DataGridView1.DataSource = tb
            End While
            conn.Close()
            dr.Close()
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
            Dim id As Int32
            Dim query As String = "Select * From Research_Interest where Field like '%" & input & "%'"
            Dim cmd As New OleDbCommand(query, conn)
            Dim reader As OleDbDataReader = cmd.ExecuteReader()
            Dim count As Integer = 0
            While (reader.Read())
                count += 1
                id = reader("Prof_id")
                Dim query2 As String = "Select * From faculty_info "
                Dim cmd2 As New OleDbCommand(query2, conn)
                dr = cmd2.ExecuteReader()
                While dr.Read()
                    If dr("ID") = id Then
                        Dim n, email, dept As String
                        n = dr("Name").ToString
                        email = dr("Email").ToString
                        dept = dr("Department").ToString
                        tb.Rows.Add(n.ToString, email.ToString, dept.ToString)
                        DataGridView1.DataSource = tb
                    End If
                   
                End While
                dr.Close()
            End While
            If count = 0 Then
                MessageBox.Show("No Records!")
            Else
                DataGridView1.Show()
            End If
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
        'SearchBox.Text = ""
    End Sub

    Private Sub RadioButton_Name_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_Name.CheckedChanged
        filter = "Name"
        ComboBox_dept.ResetText()
        ComboBox_dept.Hide()
        'SearchBox.Text = ""
    End Sub

    Private Sub Button_search_Click(sender As Object, e As EventArgs) Handles Button_search.Click
        Button_search.Enabled = False
        DataGridView1.Hide()
        If filter = "" Then
            MessageBox.Show("Select one Search by option", "Warning")
        ElseIf SearchBox.Text = "" Then
            MessageBox.Show("Enter some query string", "Warning")
        End If

        If RadioButton_dept.Checked Then
            SearchByDepartment(SearchBox.Text)
        End If
        If RadioButton_Name.Checked Then
            SearchByName(SearchBox.Text)
        End If
        If RadioButton2.Checked Then
            SearchByResearchInterest(SearchBox.Text)
        End If
    End Sub

    Private Sub Search_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox_dept.Hide()
        DataGridView1.Hide()
        tb.Columns.Add("Name", Type.GetType("System.String"))
        tb.Columns.Add("Email", Type.GetType("System.String"))
        tb.Columns.Add("Department", Type.GetType("System.String"))
        tb.Columns.Add("View More")
    End Sub

    Private Sub ComboBox_dept_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_dept.SelectedIndexChanged
        SearchBox.Text = ComboBox_dept.Text
    End Sub

    Private Sub reset_Click(sender As Object, e As EventArgs) Handles Reset.Click
        SearchBox.Text = ""
        RadioButton_dept.Checked = False
        RadioButton_Name.Checked = False
        RadioButton2.Checked = False
        ComboBox_dept.ResetText()
        ComboBox_dept.Hide()
        DataGridView1.DataSource = Nothing
        tb.Rows.Clear()
        DataGridView1.Hide()
        Button_search.Enabled = True
    End Sub

End Class
