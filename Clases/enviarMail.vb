Public Class enviarMail
    Public Function EnviodeEmail(asunto As String, bodyHTML As String, para As String, displayName As String, ccmail As String) As Boolean
        Try


            Dim smtp As New System.Net.Mail.SmtpClient
            Dim correo As New System.Net.Mail.MailMessage

            Dim adjunto As System.Net.Mail.Attachment

            Dim cargar As New Consulta

            Dim usermail As String = cargar.SelToGridSingle("mail_user", "api_Config")
            Dim password As String = cargar.SelToGridSingle("mail_password", "api_Config")
            Dim Tomail As String = para
            Dim display As String = displayName

            With smtp
                .Port = cargar.SelToGridSingle("mail_port", "api_Config")
                .Host = cargar.SelToGridSingle("mail_host", "api_Config")
                .Credentials = New System.Net.NetworkCredential(usermail, password)
                .EnableSsl = cargar.SelToGridSingle("mail_ssl", "api_config")
            End With
            '     adjunto = New System.Net.Mail.Attachment(_manifiestoFolder.ToString & "\Manifiesto.pdf")
            With correo

                '   Dim reader As New StreamReader(_rutaHtml.ToString & "\email.html")


                .From = New System.Net.Mail.MailAddress(usermail, display)
                .To.Add(Tomail)
                ccmail = ccmail.Trim
                If ccmail <> "" Then
                    .CC.Add(ccmail)
                End If

                .Subject = asunto
                '.Body = "<html><body><table> <tr>"
                ' .Body = .Body & "<td>el folio es : " & mangenfolio & "</td>"
                '<!-- #######  YAY, I AM THE SOURCE EDITOR! #########-->
                .Body = bodyHTML
                .IsBodyHtml = True
                .Priority = System.Net.Mail.MailPriority.Normal
                '  .Attachments.Add(adjunto)
            End With

            smtp.Send(correo)
            Return True
        Catch ex As Exception
            Throw
        End Try

    End Function
End Class
