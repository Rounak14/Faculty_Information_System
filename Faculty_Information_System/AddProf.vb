Imports Microsoft.VisualBasic
Imports System.Data.OleDb
Imports System.Data

Public Class AddProf
    Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Faculty_database.accdb;Jet OLEDB:Database Password=group11"

    'Private Sub Update_button_Click(sender As Object, e As EventArgs)

    'Dim conn = New OleDbConnection(connectionString)
    'Using conn As New OleDbConnection(connectionString)
    '    conn.Open()
    '    If String.IsNullOrEmpty(TextBox1.Text) Or String.IsNullOrEmpty(TextBox2.Text) Or String.IsNullOrEmpty(TextBox3.Text) Or String.IsNullOrEmpty(TextBox4.Text) Then
    '        MessageBox.Show("First Fill all the required entries")
    '        Exit Sub
    '    End If
    '    Dim namestring As String = TextBox1.Text
    '    Dim emailstring As String = TextBox2.Text
    '    Dim departmentstring As String = TextBox3.Text
    '    Dim passwordstring As String = TextBox4.Text
    '    Dim cmd As New OleDbCommand
    '    cmd.CommandText = "INSERT INTO faculty_info (Name,Department,Email,Password) VALUES ('" & namestring & "','" & departmentstring & "','" & emailstring & "','" & passwordstring & "')"
    '    Try
    '        cmd.ExecuteNonQuery() 'Executing Update Command
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message) 'Error MEssage
    '    End Try
    '    conn.Close()
    'End Using
    'End Sub

    Private Sub Faculty_infoBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Faculty_infoBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Faculty_infoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Faculty_databaseDataSet)

    End Sub

    Private Sub AddProf_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Faculty_databaseDataSet.faculty_info' table. You can move, or remove it, as needed.
        Me.Faculty_infoTableAdapter.Fill(Me.Faculty_databaseDataSet.faculty_info)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Faculty_infoBindingSource.EndEdit()
            TableAdapterManager.UpdateAll(Faculty_databaseDataSet)
            MessageBox.Show("Success")
        Catch ex As Exception
            MessageBox.Show("Failed")
        End Try
    End Sub
End Class