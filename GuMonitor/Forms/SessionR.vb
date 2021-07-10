Public Class SessionR
    Private Sub Chart1_Click(sender As Object, e As EventArgs) Handles Chart1.Click

    End Sub

    Private Sub SessionR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Sr As String = "Movies Session Report" & "   " & Today.ToString
        Call Reprot1(Sr, SKR01, SKR02, SKR03, SKR04)
    End Sub
    Private Sub Reprot1(ReportLable As String, kicks As Int16, punch As Int16, wkick As Int16, wpunch As Int16)
        Dim ke As String = ReportLable
        Me.Text = ke
        Chart1.Text = ke
        Chart1.Series("RightMoves").Points.AddXY("kick", kicks)
        Chart1.Series("WrongMovies").Points.AddXY("wrongkick", wkick)
        Chart1.Series("RightMoves").Points.AddXY("punch", punch)
        Chart1.Series("WrongMovies").Points.AddXY("wrongpunch", wpunch)
    End Sub
End Class