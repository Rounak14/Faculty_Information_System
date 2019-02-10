' Check all the paths, whether they all close

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
                Dim id, n, email, dept As String
                Dim Img As Image
                n = dr("Name").ToString
                email = dr("Email").ToString
                dept = dr("Department").ToString
                id = dr("ID").ToString
                Try
                    Img = Image.FromFile(Application.StartupPath & "\media\" & id & ".jpeg")
                Catch ex As Exception
                    Img = Image.FromFile(Application.StartupPath & "\media\default.jpg")
                End Try

                DataGridView1.RowTemplate.Height = 60
                DataGridView1.Rows.Add(Img, n.ToString, dept.ToString, email.ToString)

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
                Dim id, n, email, dept As String
                Dim Img As Image
                n = dr("Name").ToString
                email = dr("Email").ToString
                dept = dr("Department").ToString
                id = dr("ID").ToString
                Try
                    Img = Image.FromFile(Application.StartupPath & "\media\" & id & ".jpeg")
                Catch ex As Exception
                    Img = Image.FromFile(Application.StartupPath & "\media\default.jpg")
                End Try

                DataGridView1.RowTemplate.Height = 60
                DataGridView1.Rows.Add(Img, n.ToString, dept.ToString, email.ToString)

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
                        Dim id_n, n, email, dept As String
                        Dim Img As Image
                        n = dr("Name").ToString
                        email = dr("Email").ToString
                        dept = dr("Department").ToString
                        id_n = dr("ID").ToString
                        Try
                            Img = Image.FromFile(Application.StartupPath & "\media\" & id_n & ".jpeg")
                        Catch ex As Exception
                            Img = Image.FromFile(Application.StartupPath & "\media\default.jpg")
                        End Try

                        DataGridView1.RowTemplate.Height = 60
                        DataGridView1.Rows.Add(Img, n.ToString, dept.ToString, email.ToString)

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
        DataGridView1.Rows.Clear()
        ComboBox_dept.Show()
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        filter = "Research Interest"
        DataGridView1.Rows.Clear()
        SearchBox.Text = ""
        ComboBox_dept.ResetText()
        ComboBox_dept.Hide()
        'SearchBox.Text = ""
    End Sub

    Private Sub RadioButton_Name_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_Name.CheckedChanged
        filter = "Name"
        DataGridView1.Rows.Clear()
        SearchBox.Text = ""
        ComboBox_dept.ResetText()
        ComboBox_dept.Hide()
        'SearchBox.Text = ""
    End Sub

    Private Sub Button_search_Click(sender As Object, e As EventArgs) Handles Button_search.Click
        DataGridView1.Hide()
        DataGridView1.Rows.Clear()
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
    End Sub

    Private Sub ComboBox_dept_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_dept.SelectedIndexChanged
        SearchBox.Text = ComboBox_dept.Text
    End Sub


    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.ColumnIndex <> 4 Then
            Exit Sub
        End If
        Dim OBJ As New Faculty_Page
        OBJ.EmailPass = DataGridView1.Rows(e.RowIndex).Cells(3).Value
        OBJ.Show()
    End Sub
End Class