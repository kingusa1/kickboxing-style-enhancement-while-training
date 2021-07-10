Public Class AAdmin
    Private Sub AAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GuMonitorDataSet1.User_Cat' table. You can move, or remove it, as needed.
        Me.User_CatTableAdapter.Fill(Me.GuMonitorDataSet1.User_Cat)
        'TODO: This line of code loads data into the 'GuMonitorDataSet.UserTables' table. You can move, or remove it, as needed.
        Me.UserTablesTableAdapter.Fill(Me.GuMonitorDataSet.UserTables)

    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs)
        Me.Dispose()
    End Sub

    Private Sub GridView1_RowUpdated(sender As Object, e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles GridView1.RowUpdated
        Me.UserTablesTableAdapter.Update((Me.GuMonitorDataSet.UserTables))
    End Sub

    Private Sub GridView1_RowDeleted(sender As Object, e As DevExpress.Data.RowDeletedEventArgs) Handles GridView1.RowDeleted
        ' Delete Row
        Me.UserTablesTableAdapter.Update((Me.GuMonitorDataSet.UserTables))
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Me.UserTablesTableAdapter.Update((Me.GuMonitorDataSet.UserTables))
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Me.Dispose()
    End Sub
End Class
