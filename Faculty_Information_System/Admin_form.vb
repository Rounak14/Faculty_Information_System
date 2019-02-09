Public Class Admin_form

    Private Sub Admin_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub DelButton_Click(sender As Object, e As EventArgs) Handles DelButton.Click

    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        AddProf.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Search_Form.Show()
        Me.Close()
    End Sub
End Class