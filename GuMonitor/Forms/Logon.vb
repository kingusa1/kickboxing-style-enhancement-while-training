Public Class Logon
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        ' Logon 
        If E_Security() = 1 Then
            Mk_001 = AdvMenuForm
            TextEdit1.Text = ""
            TextEdit2.Text = ""
            Me.Hide()
            Mk_001.Show()
        Else
            MsgBox("UnAuthorized login")
        End If
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        ' Cancel
        Application.Exit()
    End Sub

    Private Sub Logon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "MSA Sport Traning System"
    End Sub
    Private Function E_Security() As Integer
        Try
            Dim SR0 As String = Trim(TextEdit1.Text)
            Dim SR1 As String = Trim(TextEdit2.Text)
            If SR0 = "Admin" And SR1 = "Admin" Then
                PrSec.User_Data.IUser_Login = "Admin"
                PrSec.User_Data.IUser_Name = "Admin"
                PrSec.User_Data.IUser_Password = "Admin"
                PrSec.User_Data.User_Type = "1" ' Admin or Coach
                Return 1
            Else
                If PrSec.UserInfo(SR0) Then
                    If PrSec.User_Data.IUser_Password = SR1 Then Return 1
                    If PrSec.User_Data.User_Type = "Coach" Then PrSec.User_Data.User_Type = "1"
                    If PrSec.User_Data.User_Type = "User" Then PrSec.User_Data.User_Type = "2"
                Else
                    Return 0
                End If
            End If
        Catch ex As Exception
            Return 2
        End Try
    End Function
End Class