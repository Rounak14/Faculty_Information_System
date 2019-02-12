Imports Microsoft.VisualBasic
Imports System.Data.OleDb
Imports System.Data

Public Class Calender

    Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Faculty_database.accdb;Jet OLEDB:Database Password=group11"
    Dim dr, df As System.Data.OleDb.OleDbDataReader
    Public Property EmailPass As String
    Dim id As Int32

    Function display(input As Date)
        Dim conn = New OleDbConnection(connectionString)
        Dim sel_month As Int32 = input.Month
        Dim sel_date As Int32 = input.Day
        Dim from_date, to_date As Date
        Dim start_ind As Int32
        Dim st As Boolean = False
        Select Case input.Month
            Case 1
                st = True
            Case 2
                st = False
            Case 3
                st = True
            Case 4
                st = False
            Case 5
                st = True
            Case 6
                st = False
            Case 7
                st = True
            Case 8
                st = True
            Case 9
                st = False
            Case 10
                st = True
            Case 11
                st = False
            Case 12
                st = True
        End Select
        Select Case input.DayOfWeek
            Case DayOfWeek.Monday
                start_ind = 1
            Case DayOfWeek.Tuesday
                start_ind = 2
            Case DayOfWeek.Wednesday
                start_ind = 3
            Case DayOfWeek.Thursday
                start_ind = 4
            Case DayOfWeek.Friday
                start_ind = 5
            Case DayOfWeek.Saturday
                start_ind = 6
            Case DayOfWeek.Sunday
                start_ind = 7
        End Select
        Dim plan As String
        DataGridView1.Rows.Add("", "", "", "", "", "", "", "")
        DataGridView1.Rows.Add("8AM - 9AM", "", "", "", "", "", "", "")
        DataGridView1.Rows.Add("9AM - 10AM", "", "", "", "", "", "", "")
        DataGridView1.Rows.Add("10AM - 11AM", "", "", "", "", "", "", "")
        DataGridView1.Rows.Add("11AM - 12AM", "", "", "", "", "", "", "")
        DataGridView1.Rows.Add("12PM - 1PM", "", "", "", "", "", "", "")
        DataGridView1.Rows.Add("1PM - 2PM", "", "", "", "", "", "", "")
        DataGridView1.Rows.Add("2PM - 3PM", "", "", "", "", "", "", "")
        DataGridView1.Rows.Add("3PM - 4PM", "", "", "", "", "", "", "")
        DataGridView1.Rows.Add("4PM - 5PM", "", "", "", "", "", "", "")

        For index As Integer = start_ind To 7
            DataGridView1.Rows(0).Cells(index).Value = sel_date.ToString & "/" & sel_month.ToString
            sel_date += 1
            If sel_month = 2 Then
                sel_date = sel_date Mod 28
            ElseIf st = False Then
                sel_date = sel_date Mod 30
            ElseIf st = True Then
                sel_date = sel_date Mod 31
            End If
        Next
        For index As Integer = 1 To start_ind
            DataGridView1.Rows(0).Cells(index).Value = sel_date.ToString & "/" & sel_month.ToString
            sel_date += 1
            If sel_month = 2 Then
                sel_date = sel_date Mod 28
            ElseIf st = False Then
                sel_date = sel_date Mod 30
            ElseIf st = True Then
                sel_date = sel_date Mod 31
            End If
        Next
        conn = New OleDbConnection(connectionString)
        Dim cn As Int32 = 0
        Try
            conn.Open()
            Dim query As String = "Select * From Planner"
            Dim cmd2 As New OleDbCommand(query, conn)
            dr = cmd2.ExecuteReader()
            While dr.Read()
                If dr("Prof_id") = id Then
                    plan = dr("Plan")
                    from_date = dr("Start_Time")
                    to_date = dr("End_Time")

                    Select Case from_date.TimeOfDay.ToString
                        Case "08:00:00"
                            cn = 1
                        Case "09:00:00"
                            cn = 2
                        Case "10:00:00"
                            cn = 3
                        Case "11:00:00"
                            cn = 4
                        Case "12:00:00"
                            cn = 5
                        Case "13:00:00"
                            cn = 6
                        Case "14:00:00"
                            cn = 7
                        Case "15:00:00"
                            cn = 8
                        Case "16:00:00"
                            cn = 9
                    End Select
                    Dim time_span As String = from_date.TimeOfDay.ToString & "-" & to_date.TimeOfDay.ToString
                    Dim check As String = from_date.Day.ToString & "/" & from_date.Month
                    If from_date.DayOfWeek = DayOfWeek.Monday Then
                        If DataGridView1.Rows(0).Cells(1).Value = check Then
                            Select Case cn
                                Case 1
                                    DataGridView1.Rows(1).Cells(1).Value = plan
                                Case 2
                                    DataGridView1.Rows(2).Cells(1).Value = plan
                                Case 3
                                    DataGridView1.Rows(3).Cells(1).Value = plan
                                Case 4
                                    DataGridView1.Rows(4).Cells(1).Value = plan
                                Case 5
                                    DataGridView1.Rows(5).Cells(1).Value = plan
                                Case 6
                                    DataGridView1.Rows(6).Cells(1).Value = plan
                                Case 7
                                    DataGridView1.Rows(7).Cells(1).Value = plan
                                Case 8
                                    DataGridView1.Rows(8).Cells(1).Value = plan
                                Case 9
                                    DataGridView1.Rows(9).Cells(1).Value = plan
                            End Select
                        End If

                    ElseIf from_date.DayOfWeek = DayOfWeek.Tuesday Then
                        If DataGridView1.Rows(0).Cells(2).Value = check Then
                            Select Case cn
                                Case 1
                                    DataGridView1.Rows(1).Cells(2).Value = plan
                                Case 2
                                    DataGridView1.Rows(2).Cells(2).Value = plan
                                Case 3
                                    DataGridView1.Rows(3).Cells(2).Value = plan
                                Case 4
                                    DataGridView1.Rows(4).Cells(2).Value = plan
                                Case 5
                                    DataGridView1.Rows(5).Cells(2).Value = plan
                                Case 6
                                    DataGridView1.Rows(6).Cells(2).Value = plan
                                Case 7
                                    DataGridView1.Rows(7).Cells(2).Value = plan
                                Case 8
                                    DataGridView1.Rows(8).Cells(2).Value = plan
                                Case 9
                                    DataGridView1.Rows(9).Cells(2).Value = plan
                            End Select
                        End If
                    ElseIf from_date.DayOfWeek = DayOfWeek.Wednesday Then
                        If DataGridView1.Rows(0).Cells(3).Value = check Then
                            Select Case cn
                                Case 1
                                    DataGridView1.Rows(1).Cells(3).Value = plan
                                Case 2
                                    DataGridView1.Rows(2).Cells(3).Value = plan
                                Case 3
                                    DataGridView1.Rows(3).Cells(3).Value = plan
                                Case 4
                                    DataGridView1.Rows(4).Cells(3).Value = plan
                                Case 5
                                    DataGridView1.Rows(5).Cells(3).Value = plan
                                Case 6
                                    DataGridView1.Rows(6).Cells(3).Value = plan
                                Case 7
                                    DataGridView1.Rows(7).Cells(3).Value = plan
                                Case 8
                                    DataGridView1.Rows(8).Cells(3).Value = plan
                                Case 9
                                    DataGridView1.Rows(9).Cells(3).Value = plan
                            End Select
                        End If
                    ElseIf from_date.DayOfWeek = DayOfWeek.Thursday Then
                        If DataGridView1.Rows(0).Cells(4).Value = check Then
                            Select Case cn
                                Case 1
                                    DataGridView1.Rows(1).Cells(4).Value = plan
                                Case 2
                                    DataGridView1.Rows(2).Cells(4).Value = plan
                                Case 3
                                    DataGridView1.Rows(3).Cells(4).Value = plan
                                Case 4
                                    DataGridView1.Rows(4).Cells(4).Value = plan
                                Case 5
                                    DataGridView1.Rows(5).Cells(4).Value = plan
                                Case 6
                                    DataGridView1.Rows(6).Cells(4).Value = plan
                                Case 7
                                    DataGridView1.Rows(7).Cells(4).Value = plan
                                Case 8
                                    DataGridView1.Rows(8).Cells(4).Value = plan
                                Case 9
                                    DataGridView1.Rows(9).Cells(4).Value = plan
                            End Select
                        End If
                    ElseIf from_date.DayOfWeek = DayOfWeek.Friday Then
                        If DataGridView1.Rows(0).Cells(5).Value = check Then
                            Select Case cn
                                Case 1
                                    DataGridView1.Rows(1).Cells(5).Value = plan
                                Case 2
                                    DataGridView1.Rows(2).Cells(5).Value = plan
                                Case 3
                                    DataGridView1.Rows(3).Cells(5).Value = plan
                                Case 4
                                    DataGridView1.Rows(4).Cells(5).Value = plan
                                Case 5
                                    DataGridView1.Rows(5).Cells(5).Value = plan
                                Case 6
                                    DataGridView1.Rows(6).Cells(5).Value = plan
                                Case 7
                                    DataGridView1.Rows(7).Cells(5).Value = plan
                                Case 8
                                    DataGridView1.Rows(8).Cells(5).Value = plan
                                Case 9
                                    DataGridView1.Rows(9).Cells(5).Value = plan
                            End Select
                        End If
                    ElseIf from_date.DayOfWeek = DayOfWeek.Saturday Then
                        If DataGridView1.Rows(0).Cells(6).Value = check Then
                            Select Case cn
                                Case 1
                                    DataGridView1.Rows(1).Cells(6).Value = plan
                                Case 2
                                    DataGridView1.Rows(2).Cells(6).Value = plan
                                Case 3
                                    DataGridView1.Rows(3).Cells(6).Value = plan
                                Case 4
                                    DataGridView1.Rows(4).Cells(6).Value = plan
                                Case 5
                                    DataGridView1.Rows(5).Cells(6).Value = plan
                                Case 6
                                    DataGridView1.Rows(6).Cells(6).Value = plan
                                Case 7
                                    DataGridView1.Rows(7).Cells(6).Value = plan
                                Case 8
                                    DataGridView1.Rows(8).Cells(6).Value = plan
                                Case 9
                                    DataGridView1.Rows(9).Cells(6).Value = plan
                            End Select
                            'End If
                        Else
                            If DataGridView1.Rows(0).Cells(7).Value = check Then
                                Select Case cn
                                    Case 1
                                        DataGridView1.Rows(1).Cells(7).Value = plan
                                    Case 2
                                        DataGridView1.Rows(2).Cells(7).Value = plan
                                    Case 3
                                        DataGridView1.Rows(3).Cells(7).Value = plan
                                    Case 4
                                        DataGridView1.Rows(4).Cells(7).Value = plan
                                    Case 5
                                        DataGridView1.Rows(5).Cells(7).Value = plan
                                    Case 6
                                        DataGridView1.Rows(6).Cells(7).Value = plan
                                    Case 7
                                        DataGridView1.Rows(7).Cells(7).Value = plan
                                    Case 8
                                        DataGridView1.Rows(8).Cells(7).Value = plan
                                    Case 9
                                        DataGridView1.Rows(9).Cells(7).Value = plan
                                End Select
                            End If
                        End If
                    End If
                End If

            End While
            conn.Close()
            dr.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Function

    Private Sub Calender_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim query As String = "SELECT * FROM faculty_info where Email= '" & EmailPass & "';"
        Dim conn = New OleDbConnection(connectionString)
        conn.Open()
        Dim cmd As New OleDbCommand(query, conn)
        Dim Reader As OleDbDataReader = cmd.ExecuteReader()
        Try

            While (Reader.Read())
                id = Reader("ID")
                Label2.Text = Reader("Name")
            End While
            conn.Close()
        Catch ex As Exception
            'MessageBox.Show(ex.Message, "Warning")
        End Try

        display(DateAndTime.Today)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DataGridView1.Rows.Clear()
        display(DateTimePicker1.Value)
    End Sub

End Class