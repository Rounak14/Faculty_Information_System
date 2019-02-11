Public Class Admin_form

    Private Sub DelButton_Click(sender As Object, e As EventArgs) Handles DelButton.Click
        DelProf.Show()
        Me.Close()
    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        AddProf.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim obj As New Search_Form
        obj.Show()
        Me.Close()
    End Sub
    
End Class