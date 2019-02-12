Imports Microsoft.VisualBasic
Imports System.Data.OleDb
Imports System.Data

Public Class Prof_Planner
    Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Faculty_database.accdb;Jet OLEDB:Database Password=group11"
    Public Property EmailPass As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or ComboBox1.Text = "" Then
            MessageBox.Show("Plan field or time field must not be empty", "Warning")
            Exit Sub
        End If

        Dim start_time As Date
        Dim end_time As Date

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

        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "MM/dd/yyyy"

        Dim select_date = DateTimePicker1.Text
        If ComboBox1.Text = "8 AM - 9 AM" Then
            start_time = "8:00:00 AM"
            end_time = "9:00:00 AM"
        ElseIf ComboBox1.Text = "9 AM - 10 AM" Then
            start_time = "9:00:00 AM"
            end_time = "10:00:00 AM"
        ElseIf ComboBox1.Text = "10 AM - 11 AM" Then
            start_time = "10:00:00 AM"
            end_time = "11:00:00 AM"
        ElseIf ComboBox1.Text = "11 AM - 12 Noon" Then
            start_time = "11:00:00 AM"
            end_time = "12:00:00 PM"
        ElseIf ComboBox1.Text = "12 Noon - 1 PM" Then
            start_time = "12:00:00 PM"
            end_time = "1:00:00 PM"
        ElseIf ComboBox1.Text = "1 PM - 2 PM" Then
            start_time = "1:00:00 PM"
            end_time = "2:00:00 PM"
        ElseIf ComboBox1.Text = "2 PM - 3 PM" Then
            start_time = "2:00:00 PM"
            end_time = "3:00:00 PM"
        ElseIf ComboBox1.Text = "3 PM - 4 PM" Then
            start_time = "3:00:00 PM"
            end_time = "4:00:00 PM"
        ElseIf ComboBox1.Text = "4 PM - 5 PM" Then
            start_time = "4:00:00 PM"
            end_time = "5:00:00 PM"
        End If

        Dim from_date As Date
        Dim to_date As Date
        from_date = select_date + " " + start_time
        to_date = select_date + " " + end_time
        Dim plan_string As String = TextBox1.Text

        Dim query2 As String = "INSERT INTO Planner ([Prof_id],[Plan],[Start_Time],[End_Time]) VALUES (?,?,?,?)"
        Dim cmdPlan As OleDbCommand = New OleDbCommand(query2, conn)
        cmdPlan.Parameters.Add(New OleDbParameter("Prof_id", CType(id_number, Integer)))
        cmdPlan.Parameters.Add(New OleDbParameter("Plan", CType(plan_string, String)))
        cmdPlan.Parameters.Add(New OleDbParameter("Start_Time", CType(from_date, Date)))
        cmdPlan.Parameters.Add(New OleDbParameter("End_Time", CType(to_date, Date)))

        Try
            cmdPlan.ExecuteNonQuery() 'Executing Update Command
            cmdPlan.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
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

        If TextBox1.Text = "" Then
            MessageBox.Show("Plan field must not be empty")
            Exit Sub
        End If
        Dim plan_string As String = TextBox1.Text
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "MM/dd/yyyy"

        Dim select_date = DateTimePicker1.Text

        Dim query2 As String = "INSERT INTO Planner ([Prof_id],[Plan],[Start_Time],[End_Time]) VALUES (?,?,?,?)"
        Dim cmdPlan As OleDbCommand = New OleDbCommand(query2, conn)

        Dim from_date As Date
        Dim to_date As Date
        from_date = select_date + " " + "8:00:00 AM"
        to_date = select_date + " " + "9:00:00 AM"

        cmdPlan.Parameters.Add(New OleDbParameter("Prof_id", CType(id_number, Integer)))
        cmdPlan.Parameters.Add(New OleDbParameter("Plan", CType(plan_string, String)))
        cmdPlan.Parameters.Add(New OleDbParameter("Start_Time", CType(from_date, Date)))
        cmdPlan.Parameters.Add(New OleDbParameter("End_Time", CType(to_date, Date)))

        Try
            cmdPlan.ExecuteNonQuery() 'Executing Update Command
            cmdPlan.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try

        Dim cmdPlan2 As OleDbCommand = New OleDbCommand(query2, conn)
        from_date = select_date + " " + "9:00:00 AM"
        to_date = select_date + " " + "10:00:00 AM"

        cmdPlan2.Parameters.Add(New OleDbParameter("Prof_id", CType(id_number, Integer)))
        cmdPlan2.Parameters.Add(New OleDbParameter("Plan", CType(plan_string, String)))
        cmdPlan2.Parameters.Add(New OleDbParameter("Start_Time", CType(from_date, Date)))
        cmdPlan2.Parameters.Add(New OleDbParameter("End_Time", CType(to_date, Date)))

        Try
            cmdPlan2.ExecuteNonQuery() 'Executing Update Command
            cmdPlan2.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try

        Dim cmdPlan3 As OleDbCommand = New OleDbCommand(query2, conn)
        from_date = select_date + " " + "10:00:00 AM"
        to_date = select_date + " " + "11:00:00 AM"

        cmdPlan3.Parameters.Add(New OleDbParameter("Prof_id", CType(id_number, Integer)))
        cmdPlan3.Parameters.Add(New OleDbParameter("Plan", CType(plan_string, String)))
        cmdPlan3.Parameters.Add(New OleDbParameter("Start_Time", CType(from_date, Date)))
        cmdPlan3.Parameters.Add(New OleDbParameter("End_Time", CType(to_date, Date)))

        Try
            cmdPlan3.ExecuteNonQuery() 'Executing Update Command
            cmdPlan3.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try

        Dim cmdPlan4 As OleDbCommand = New OleDbCommand(query2, conn)
        from_date = select_date + " " + "11:00:00 AM"
        to_date = select_date + " " + "12:00:00 PM"

        cmdPlan4.Parameters.Add(New OleDbParameter("Prof_id", CType(id_number, Integer)))
        cmdPlan4.Parameters.Add(New OleDbParameter("Plan", CType(plan_string, String)))
        cmdPlan4.Parameters.Add(New OleDbParameter("Start_Time", CType(from_date, Date)))
        cmdPlan4.Parameters.Add(New OleDbParameter("End_Time", CType(to_date, Date)))

        Try
            cmdPlan4.ExecuteNonQuery() 'Executing Update Command
            cmdPlan4.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try

        Dim cmdPlan5 As OleDbCommand = New OleDbCommand(query2, conn)
        from_date = select_date + " " + "12:00:00 PM"
        to_date = select_date + " " + "1:00:00 PM"

        cmdPlan5.Parameters.Add(New OleDbParameter("Prof_id", CType(id_number, Integer)))
        cmdPlan5.Parameters.Add(New OleDbParameter("Plan", CType(plan_string, String)))
        cmdPlan5.Parameters.Add(New OleDbParameter("Start_Time", CType(from_date, Date)))
        cmdPlan5.Parameters.Add(New OleDbParameter("End_Time", CType(to_date, Date)))

        Try
            cmdPlan5.ExecuteNonQuery() 'Executing Update Command
            cmdPlan5.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try

        Dim cmdPlan6 As OleDbCommand = New OleDbCommand(query2, conn)
        from_date = select_date + " " + "1:00:00 PM"
        to_date = select_date + " " + "2:00:00 PM"

        cmdPlan6.Parameters.Add(New OleDbParameter("Prof_id", CType(id_number, Integer)))
        cmdPlan6.Parameters.Add(New OleDbParameter("Plan", CType(plan_string, String)))
        cmdPlan6.Parameters.Add(New OleDbParameter("Start_Time", CType(from_date, Date)))
        cmdPlan6.Parameters.Add(New OleDbParameter("End_Time", CType(to_date, Date)))

        Try
            cmdPlan6.ExecuteNonQuery() 'Executing Update Command
            cmdPlan6.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try

        Dim cmdPlan7 As OleDbCommand = New OleDbCommand(query2, conn)
        from_date = select_date + " " + "2:00:00 PM"
        to_date = select_date + " " + "3:00:00 PM"

        cmdPlan7.Parameters.Add(New OleDbParameter("Prof_id", CType(id_number, Integer)))
        cmdPlan7.Parameters.Add(New OleDbParameter("Plan", CType(plan_string, String)))
        cmdPlan7.Parameters.Add(New OleDbParameter("Start_Time", CType(from_date, Date)))
        cmdPlan7.Parameters.Add(New OleDbParameter("End_Time", CType(to_date, Date)))

        Try
            cmdPlan7.ExecuteNonQuery() 'Executing Update Command
            cmdPlan7.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try

        Dim cmdPlan8 As OleDbCommand = New OleDbCommand(query2, conn)
        from_date = select_date + " " + "3:00:00 PM"
        to_date = select_date + " " + "4:00:00 PM"

        cmdPlan8.Parameters.Add(New OleDbParameter("Prof_id", CType(id_number, Integer)))
        cmdPlan8.Parameters.Add(New OleDbParameter("Plan", CType(plan_string, String)))
        cmdPlan8.Parameters.Add(New OleDbParameter("Start_Time", CType(from_date, Date)))
        cmdPlan8.Parameters.Add(New OleDbParameter("End_Time", CType(to_date, Date)))

        Try
            cmdPlan8.ExecuteNonQuery() 'Executing Update Command
            cmdPlan8.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try

        Dim cmdPlan9 As OleDbCommand = New OleDbCommand(query2, conn)
        from_date = select_date + " " + "4:00:00 PM"
        to_date = select_date + " " + "5:00:00 PM"

        cmdPlan9.Parameters.Add(New OleDbParameter("Prof_id", CType(id_number, Integer)))
        cmdPlan9.Parameters.Add(New OleDbParameter("Plan", CType(plan_string, String)))
        cmdPlan9.Parameters.Add(New OleDbParameter("Start_Time", CType(from_date, Date)))
        cmdPlan9.Parameters.Add(New OleDbParameter("End_Time", CType(to_date, Date)))

        Try
            cmdPlan9.ExecuteNonQuery() 'Executing Update Command
            cmdPlan9.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try
        conn.Close()
        Me.Close()
    End Sub
End Class