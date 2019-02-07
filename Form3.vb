Imports Microsoft.VisualBasic
Imports System.Data.OleDb
Imports System.Data


Public Class DelProf

    Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Faculty_database.accdb;Jet OLEDB:Database Password=group11"

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Delete.Click

        Try
            Dim con = New OleDbConnection(connectionString)
            con.Open()
            Dim namestring As String = TextBoxdel_user.Text
            Dim emailstring As String = TextBoxdel_email.Text
            Dim query As String
            query = "DELETE FROM faculty_info where Name = '" & TextBoxdel_user.Text & "' and Email = '" & TextBoxdel_email.Text & "' "
            Dim cmd As OleDbCommand = New OleDbCommand(query, con)
            cmd.ExecuteNonQuery()
            If MessageBox.Show("Do you really want to Delete this Record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then

                MsgBox("Operation Cancelled")

                Exit Sub

            End If
            con.Close()
            Admin_form.Show()

        Catch ex As Exception
            MessageBox.Show("Error while deleting record on table..." & ex.Message, "Delete Records")

        End Try
    End Sub
End Class