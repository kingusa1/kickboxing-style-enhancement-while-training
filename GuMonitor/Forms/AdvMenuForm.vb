Public Class AdvMenuForm
    Dim builder As New System.Text.StringBuilder
    Dim Set001 As Int32
    Dim Set002 As Int32
    Dim Set003 As Int32
    Dim Set004 As Int32
    Declare Auto Function SetParent Lib "user32.dll" (ByVal hWndChild As IntPtr, ByVal hWndNewParent As IntPtr) As Integer
    Declare Auto Function SendMessage Lib "user32.dll" (ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    Private Const WM_SYSCOMMAND As Integer = 274
    Private Const SC_MAXIMIZE As Integer = 61488
    Dim proc As Process
    Dim UR_User As String
    Private Sub RibbonControl_Click(sender As Object, e As EventArgs) Handles RibbonControl.Click

    End Sub
    Private Sub SK()
        proc = Process.Start("C:\ModyProject\DiscreteGestureBasics-WPF\bin\x64\Debug\DiscreteGestureBasics-WPF.exe")
        ' proc = Process.Start("Notepad")
        proc.WaitForInputIdle()
        proc.WaitForExit(1000)
        SetParent(proc.MainWindowHandle, Me.PanelControl1.Handle)
        SendMessage(proc.MainWindowHandle, WM_SYSCOMMAND, SC_MAXIMIZE, 0)
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        ' User Managment
        Dim ml As New AAdmin
        ml.Show()
    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        ' Reports
        Dim Mr As New Reports
        Mr.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim sd As String
        Try
            If Clipboard.ContainsText Then
                sd = Clipboard.GetText
            End If
            Timer1.Enabled = False


            Dim timeStamp As DateTime = DateTime.Now
            Select Case sd
                Case "seatedImage"
                    LabelControl1.Text = "seatedImage"

                    builder.Append("Seated Detected  " & timeStamp & " " & vbCrLf)
                    PictureBox1.Image = My.Resources.Seated
                Case "NoDetectMove"
                    LabelControl1.Text = "NoDetectMove"
                    PictureBox1.Image = My.Resources.NotSeated

                    builder.Append("NoDetectMove  " & timeStamp & " " & vbCrLf)
                Case "notTrackedImage"
                    builder.Append("notTrackedImage  " & timeStamp & " " & vbCrLf)
                    PictureBox1.Image = My.Resources.NotTracked
                Case "Seated"
                    LabelControl1.Text = "seatedImage"
                    builder.Append(sd & " " & timeStamp & " " & vbCrLf)
                    PictureBox1.Image = My.Resources.Seated
                Case "kick"
                    Set001 = Set001 + 1
                    builder.Append(sd & " " & timeStamp & " " & vbCrLf)
                    MemoEdit2.Text = ""
                    PictureBox1.Image = My.Resources.kick
                Case "punch"
                    Set002 = Set002 + 1
                    builder.Append(sd & " " & timeStamp & " " & vbCrLf)
                    MemoEdit2.Text = ""
                    PictureBox1.Image = My.Resources.punch
                Case "wrongkick1"
                    Set003 = Set003 + 1
                    builder.Append(sd & " " & timeStamp & " " & Set003 & vbCrLf)
                    MemoEdit2.Text = "wrongpunch1: please don't push you hands above your head, position your  arm infront of your face to defend your self."
                    PictureBox1.Image = My.Resources.wrongkick1
                Case "wrongpunch1"
                    Set004 = Set004 + 1
                    builder.Append(sd & " " & timeStamp & " " & Set004 & vbCrLf)
                    MemoEdit2.Text = "wrongpunch : please don't lower your left hand, position your left arm infront of your face to defend your self."
                    PictureBox1.Image = My.Resources.wrongpunch1
            End Select
            Clipboard.Clear()
            Timer1.Enabled = True
            BarStaticItem1.Caption = "Runing  "
            BarStaticItem2.Caption = "Move Detected  " & (Set003 + Set004).ToString
            MemoEdit1.Text = builder.ToString
            MemoEdit1.SelectionStart = MemoEdit1.Text.Length
            MemoEdit1.ScrollToCaret()
        Catch ex As Exception
            Debug.Print("")
        End Try
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        ' Start Tracking
        Dim timeStamp As DateTime = DateTime.Now
        Set001 = 0
        Set002 = 0
        Set003 = 0
        Set004 = 0
        Timer1.Enabled = True
        Clipboard.Clear()
        builder.Append("Tracking Start At " & timeStamp & " " & vbCrLf)
        MemoEdit1.Text = builder.ToString
        MemoEdit1.SelectionStart = MemoEdit1.Text.Length
        MemoEdit1.ScrollToCaret()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        'End tracking
        Dim timeStamp As DateTime = DateTime.Now
        Timer1.Enabled = False
        Clipboard.Clear()
        builder.Append("Tracking End At " & timeStamp & " " & vbCrLf)
        MemoEdit1.Text = builder.ToString
        MemoEdit1.SelectionStart = MemoEdit1.Text.Length
        MemoEdit1.ScrollToCaret()
        SKR01 = Set001
        SKR02 = Set002
        SKR03 = Set003
        SKR04 = Set004
        Set001 = 0
        Set002 = 0
        Set003 = 0
        Set004 = 0
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        ' Clear Log
        MemoEdit1.Text = ""
        builder.Clear()
    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        ' Save Log
        Dim Sessionid As String = DocIDNo()
        Dim LogR As String = "C:\LogDir\" & Sessionid & ".txt"
        System.IO.File.WriteAllText(LogR, builder.ToString())
        MsgBox("Log File Save to" & LogR)
        ' Save Log to database 
        ' Move #1 each move as single line under one session id
        ' SKr01 total right kick
        ' SKR03 total wrong Kick
        ' SKR02 total Right punch
        ' SKR04 total wrong punch
        Dim r0 As Integer = PrSec.SaveSession(Today.ToString, PrSec.User_Data.IUser_Login, Sessionid, "kick", SKR01.ToString, SKR03.ToString)
        Dim r1 As Integer = PrSec.SaveSession(Today.ToString, PrSec.User_Data.IUser_Login, Sessionid, "punch", SKR02.ToString, SKR04.ToString)
        If r0 = 1 And r1 = 1 Then
            MsgBox("Session Log File Save to DataBase ")
        End If


    End Sub

    Private Sub SimpleButton5_Click(sender As Object, e As EventArgs) Handles SimpleButton5.Click
        Mk_002.Show()
        Me.Dispose()
    End Sub

    Private Sub AdvMenuForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LabelControl1.Text = ""
        BarStaticItem3.Caption = PrSec.User_Data.IUser_Name
        UR_User = PrSec.User_Data.User_Type
        Me.Text = "MSA Project kickboxing style enhancement (Mohamed Hisham Ismail)"
        Timer1.Interval = 1000
        PictureBox1.Image = My.Resources.NotTracked
        LabelControl1.Text = "System Ready."
        BarStaticItem1.Caption = "Runing  "
        BarStaticItem2.Caption = "Move Detected  " & "0"
        If UR_User <> "1" Then
            BarButtonItem1.Enabled = False ' User Managment
            BarButtonItem2.Enabled = True  ' User Reports 
        Else
            BarButtonItem1.Enabled = True
            BarButtonItem2.Enabled = True
        End If
        ' SK()
    End Sub

    Private Sub BarButtonItem3_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        SK()
    End Sub

    Private Sub BarButtonItem4_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        Shell("C:\Program Files\Microsoft SDKs\Kinect\v2.0_1409\Tools\KinectStudio\KStudio.exe", AppWinStyle.NormalFocus, True)
    End Sub

    Private Sub BarButtonItem5_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        Shell("C:\Program Files\Microsoft SDKs\Kinect\v2.0_1409\Tools\KinectStudio\VisualGestureBuilder.exe", AppWinStyle.NormalFocus, True)
    End Sub

    Private Sub BarButtonItem6_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem6.ItemClick
        Dim ser As New SessionR
        SKR01 = Set001 'Kick
        SKR02 = Set003 'wkick
        SKR03 = Set002 'punch
        SKR04 = Set004 'wpunch
        ser.Show()
    End Sub
End Class