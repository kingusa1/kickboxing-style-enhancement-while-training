Imports System.Windows.Forms.DataVisualization.Charting
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid


Public Class Reports
    Dim Ek001 As String
    Dim Re001 As String
    Dim colReceived As GridColumn
    Dim colSessionR As GridColumn
    Dim SaRowIndex As Integer
    Dim rowHandle As Integer
    Dim TotalR As Integer
    Dim TotalW As Integer
    Dim MoveType As String
    Private Sub Reports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GuMonitorDataSet5.SessionReport' table. You can move, or remove it, as needed.
        If PrSec.User_Data.IUser_Login <> "Admin" Then
            Me.SessionReportTableAdapter.Fill(Me.GuMonitorDataSet5.SessionReport, PrSec.User_Data.IUser_Login)
            colReceived = GridView1.Columns("USessionDate")
            colSessionR = GridView1.Columns("Sessionid")
            GridView1.BeginSort()
            Try
                GridView1.ClearGrouping()
                colReceived.GroupIndex = 0
                colSessionR.GroupIndex = 1
                GridView1.EndSort()
            Catch ex As Exception

            End Try
        End If
        Me.TopMost = False
        'TODO: This line of code loads data into the 'GuMonitorDataSet3.UserTables' table. You can move, or remove it, as needed.
        Me.UserTablesTableAdapter.Fill(Me.GuMonitorDataSet3.UserTables)
        LabelControl1.Text = ""

        If PrSec.User_Data.User_Type = "1" Then
            ListBoxControl1.Enabled = True
            LabelControl6.Visible = False
        Else
            LabelControl6.Text = PrSec.User_Data.IUser_Name
            ListBoxControl1.Enabled = False
            ListBoxControl1.Visible = False
        End If

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        ' Call Report 1
        Dim ke As String = "Movies report for specific day" & "  " & Re001
        Call Reprot1(ke, TotalR, TotalW)
    End Sub
    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Me.Dispose()
    End Sub

    Private Sub ListBoxControl2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxControl2.SelectedIndexChanged
        Ek001 = ListBoxControl2.Text
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
    End Sub

    Private Sub Reprot1(ReportLable As String, WRight As Int16, TWorng As Int16)
        Dim ke As String = ReportLable
        LabelControl1.Text = ke
        Chart1.Text = ke
        'Chart1.Series.Clear()
        Chart1.Series("RightMoves").Points.AddXY(MoveType, WRight)
        Chart1.Series("WrongMovies").Points.AddXY(MoveType, TWorng)
    End Sub

    Private Sub GridView1_RowClick(sender As Object, e As RowClickEventArgs) Handles GridView1.RowClick
        Try
            SaRowIndex = GridView1.GetDataSourceRowIndex(GridView1.FocusedRowHandle)
            rowHandle = GridView1.GetRowHandle(SaRowIndex)
            Dim ss As String = GridView1.GetRowCellValue(rowHandle, "Sessionid").ToString
            TotalR = CInt(GridView1.GetRowCellValue(rowHandle, "TotalMoveRight").ToString)
            TotalW = CInt(GridView1.GetRowCellValue(rowHandle, "TotalMoveWrong").ToString)
            MoveType = GridView1.GetRowCellValue(rowHandle, "MoveName").ToString
            If ss <> "" Then
                DocLogFileName = ss
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        Try
            If DocLogFileName <> "" Then
                Dim rt As New ViewLogReport
                rt.Show()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ListBoxControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxControl1.SelectedIndexChanged
        Dim fg As String = ListBoxControl1.SelectedValue ' Trim(ListBoxControl1.Text)
        If fg <> "" Then
            Me.SessionReportTableAdapter.Fill(Me.GuMonitorDataSet5.SessionReport, fg)
            colReceived = GridView1.Columns("USessionDate")
            colSessionR = GridView1.Columns("Sessionid")
            GridView1.BeginSort()
            Try
                GridView1.ClearGrouping()
                colReceived.GroupIndex = 0
                colSessionR.GroupIndex = 1
                GridView1.EndSort()
            Catch ex As Exception

            End Try
        End If
    End Sub
End Class