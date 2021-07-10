Module GeMoModule_0
    Public Mk_001 As New Form
    Public Mk_002 As New Logon
    Public PrSec As New U_S_User
    Public SKR01, SKR02, SKR03, SKR04 As Integer
    Public DocLogFileName As String
    Public Function DocIDNo() As String
        Dim DIN As String
        DIN = "doc" & DateTime.Now.ToString("ddMMyyyyHHmmssfff")
        Return DIN
    End Function
    Public Function DocIDNoRef() As String
        Dim DIN As String
        DIN = "page" & DateTime.Now.ToString("ddMMyyyyHHmmfffss")
        Return DIN
    End Function
End Module
