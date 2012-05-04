Module md5
    'complicated md5 hashing code, basically hashs passwords
    Public Function StringToMD5(ByVal Content As String) As String
        Dim M5 As New Security.Cryptography.MD5CryptoServiceProvider
        Dim ByteString() As Byte = System.Text.Encoding.ASCII.GetBytes(Content)
        ByteString = M5.ComputeHash(ByteString)
        Dim FinalString As String = Nothing
        For Each bt As Byte In ByteString
            FinalString &= bt.ToString("x2") 'x2 is just a string format
        Next
        Return FinalString
    End Function
    Public Function ProcessesRunning(ByVal ProcessName As String) As Integer
        Try
            Return Process.GetProcessesByName(ProcessName).GetUpperBound(0) + 1
        Catch
            Return 0
        End Try
    End Function
End Module
