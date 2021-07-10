Public Class ViewLogReport


    Private Sub ViewLogReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim fileReader As String
            fileReader = My.Computer.FileSystem.ReadAllText("C:\LogDir\" & DocLogFileName & ".txt")
            MemoEdit1.Text = fileReader
        Catch ex As Exception
            Me.Dispose()
        End Try
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Me.Dispose()
    End Sub
End Class