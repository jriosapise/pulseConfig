Imports System.IO
Imports System.Security.Cryptography
Public Class usuarios
    Public Function stringToMd4(Content As String) As String
        Dim M5 As New MD5CryptoServiceProvider
        Dim ByteString() As Byte = System.Text.Encoding.ASCII.GetBytes(Content)
        ByteString = M5.ComputeHash(ByteString)
        Dim finalString As String = Nothing

        For Each bt As Byte In ByteString
            finalString &= bt.ToString("x2")
        Next

        Return finalString.ToUpper
    End Function
End Class
