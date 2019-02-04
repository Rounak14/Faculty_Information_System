Partial Class Faculty_databaseDataSet
    Partial Class faculty_infoDataTable

        Private Sub faculty_infoDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.PasswordColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

End Class

Namespace Faculty_databaseDataSetTableAdapters
    
    Partial Public Class faculty_infoTableAdapter
    End Class
End Namespace
