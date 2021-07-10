Imports System.Data.SqlClient

Public Class U_S_User
    Private sqlConn1 As System.Data.SqlClient.SqlConnection
    Private sqlDA1 As System.Data.SqlClient.SqlDataAdapter
    Private DS1 As New DataSet
    Private SqlCommand As New SqlCommand()
    Public SqlStatmet As String
    Public ConnectionString As String = "Server=.;Database=GuMonitor;User Id=sa;Password=Pass1word; "
    ' Return User Seting flase if the user not exisit
    Structure Se_Security
        Dim IUser_Name As String
        Dim IUser_Login As String
        Dim IUser_Password As String
        Dim IUser_Enabled As Boolean
        Dim User_Type As String
        Dim User_Email As String
    End Structure
    Public User_Data As Se_Security
    Private Sub refreshDATA1(ByVal TableId As String)
        '------------------------------ General Function
        Try
            'clears the previous data in dataset object
            DS1.Clear()

            'whenever we manipulate database we must open the database connection
            sqlConn1.Open()

            'dataadapter.fill method retrives the data from database and fill the dataset object and then dataset store the data in xml format
            sqlDA1.Fill(DS1, TableId)

            'once the database operation completed we close the connection to database
            sqlConn1.Close()

        Catch ex As Exception
            ' if any error occured in operation this catch statement prevent the application termination
            Console.Write(ex.Message)
            'Dim r As Boolean = ErrLog(ex.Message, ex.Source, ex.StackTrace, FName, ModuleName)
        End Try
    End Sub
    Public Function UserInfo(UserLogin As String) As Boolean
        Try
            Dim DataR1 As DataRow
            Dim bn As String
            Dim bk As Boolean
            Dim strConnection As String = ConnectionString
            Dim xc As Integer
            Dim sql As String = "select * from  UserTables " & "  where  ULoginName =" & "'" & UserLogin & "'"

            sqlConn1 = New SqlClient.SqlConnection(strConnection)
            sqlDA1 = New SqlClient.SqlDataAdapter(sql, sqlConn1)
            refreshDATA1("UserTables")
            xc = DS1.Tables("UserTables").Rows.Count
            If xc > 0 Then
                DataR1 = DS1.Tables("UserTables").Rows(0)
                User_Data.IUser_Login = UserLogin
                If Not IsDBNull(DataR1.Field(Of String)("UName")) Then
                    bn = DataR1.Field(Of String)("UName")
                    User_Data.IUser_Name = Trim(bn)
                End If

                If Not IsDBNull(DataR1.Field(Of String)("UPassword")) Then
                    bn = DataR1.Field(Of String)("UPassword")
                    User_Data.IUser_Password = Trim(bn)
                End If

                If Not IsDBNull(DataR1.Field(Of String)("UType")) Then
                    bn = DataR1.Field(Of String)("UType")
                    User_Data.User_Type = Trim(bn)
                End If

                If Not IsDBNull(DataR1.Field(Of Boolean)("UEnabled")) Then
                    bk = DataR1.Field(Of Boolean)("UEnabled")
                    User_Data.IUser_Enabled = bk
                End If
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function
    ' Function Check For User Name  and User Login
    Public Function IsExist(TableName As String, TableMember As String, TableMemberValue As String) As Boolean
        Try

            Dim strConnection As String = ConnectionString
            Dim xc As Integer
            Dim sql As String = "select * from " & TableName & "  where " & TableMember & "='" & TableMemberValue & "'"

            sqlConn1 = New SqlClient.SqlConnection(strConnection)
            sqlDA1 = New SqlClient.SqlDataAdapter(sql, sqlConn1)
            refreshDATA1(TableName)
            xc = DS1.Tables(TableName).Rows.Count
            If xc > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Function UpdateUserPassword(NewPassword As String) As Boolean
        Try

        Catch ex As Exception

        End Try
    End Function
    Public Function DeleteUser(UserLogin As String) As Boolean
        Try

        Catch ex As Exception

        End Try
    End Function
    Private Function ClassIns(id As String) As Boolean
        Dim SqlConnection As New SqlConnection(ConnectionString)
        Try
            'Open the SqlConnection

            SqlConnection.Open()
            SqlCommand.CommandText = id
            SqlCommand.Connection = SqlConnection
            SqlCommand.ExecuteNonQuery()
            'Close the SqlConnection
            SqlConnection.Close()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            SqlConnection.Close()
            Return False
        End Try
    End Function
    Public Function SaveSession(USessionDate As String, ULoginName As String, Sessionid As String, MoveName As String, TotalMoveRight As String, TotalMoveWrong As String) As Integer
        Try
            Dim SQlw As String
            SQlw = SQlw + "INSERT INTO SessionReport (USessionDate,ULoginName,Sessionid,MoveName,TotalMoveRight,TotalMoveWrong)  VALUES "
            SQlw = SQlw + "(" & "'" & USessionDate & "',"
            SQlw = SQlw + "'" & ULoginName & "',"
            SQlw = SQlw + "'" & Sessionid & "',"
            SQlw = SQlw + "'" & MoveName & "',"
            SQlw = SQlw + "'" & TotalMoveRight & "',"
            SQlw = SQlw + "'" & TotalMoveWrong & "')"   ' End Inset Values
            Dim rt As Boolean = ClassIns(SQlw)
            If rt = True Then
                Return 1
            Else
                Return 2
            End If
        Catch ex As Exception
            Return 2
        End Try
    End Function
End Class
