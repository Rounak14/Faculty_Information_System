Imports Microsoft.VisualBasic
Imports System.Data.OleDb
Imports System.Data


Public Class Search_Form
    Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Faculty_database.accdb;Jet OLEDB:Database Password=group11"
    Dim filter As String = ""
    Dim ad As System.Data.OleDb.OleDbDataAdapter
    Dim cm As System.Data.OleDb.OleDbCommand
    Dim co As System.Data.OleDb.OleDbConnection
    Dim dr As System.Data.OleDb.OleDbDataReader
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
                'Dim newLabel As New Label
                'newLabel.Name = "TextBox" + reader.GetValue(0).ToString
                'newLabel.Text = reader.GetString(1)
                'Me.Controls.Add(newLabel)
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
        Button_search.Enabled = False
        If filter = "" Then
            MessageBox.Show("Select one Search by option")
        ElseIf SearchBox.Text = "" Then
            MessageBox.Show("Enter some query string")
        End If
        co = New System.Data.OleDb.OleDbConnection
        co.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Faculty_database.accdb;Jet OLEDB:Database Password=group11"
        If RadioButton_dept.Checked Then
            DataGridView1.Show()
            Try
                co.Open()
                Dim cd As String
                cd = "SELECT * FROM faculty_info Where Department='" & SearchBox.Text & "'"
                cm = New OleDb.OleDbCommand(cd, co)
                dr = cm.ExecuteReader()
                While dr.Read()
                    Dim n, email, dept As String
                    Dim more As System.Windows.Forms.Button
                    n = dr("Name").ToString
                    email = dr("Email").ToString
                    dept = dr("Department").ToString
                    tb.Rows.Add(n.ToString, email.ToString, dept.ToString, more)
                    DataGridView1.DataSource = tb
                End While
                co.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
        If RadioButton_Name.Checked Then
            DataGridView1.Show()
            Try
                co.Open()
                Dim cd As String
                cd = "SELECT * FROM faculty_info Where Name='" & SearchBox.Text & "'"
                cm = New OleDb.OleDbCommand(cd, co)
                dr = cm.ExecuteReader()
                While dr.Read()
                    Dim n, email, dept As String
                    Dim more As System.Windows.Forms.Button
                    n = dr("Name").ToString
                    email = dr("Email").ToString
                    dept = dr("Department").ToString
                    tb.Rows.Add(n.ToString, email.ToString, dept.ToString, more)
                    DataGridView1.DataSource = tb
                End While
                co.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
        If RadioButton2.Checked Then
            DataGridView1.Show()
            Try
                co.Open()
                Dim cd As String
                cd = "SELECT * FROM faculty_info Where ResearchInterest='" & SearchBox.Text & "'"
                cm = New OleDb.OleDbCommand(cd, co)
                dr = cm.ExecuteReader()
                While dr.Read()
                    Dim n, email, dept As String
                    Dim more As System.Windows.Forms.Button
                    n = dr("Name").ToString
                    email = dr("Email").ToString
                    dept = dr("Department").ToString
                    tb.Rows.Add(n.ToString, email.ToString, dept.ToString, more)
                    DataGridView1.DataSource = tb
                End While
                co.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Search_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox_dept.Hide()
        DataGridView1.Hide()
        tb.Columns.Add("Name", Type.GetType("System.String"))
        tb.Columns.Add("Email", Type.GetType("System.String"))
        tb.Columns.Add("Department", Type.GetType("System.String"))
        tb.Columns.Add("View More")
        DataGridView1.DataSource = tb
    End Sub

    Private Sub ComboBox_dept_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_dept.SelectedIndexChanged
        SearchBox.Text = ComboBox_dept.Text
    End Sub


    Private Sub reset_Click(sender As Object, e As EventArgs) Handles reset.Click
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
