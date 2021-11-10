Public Class ActualizarContrasena
    Dim _usr As New usuarios
    Private Sub ActualizarContrasena_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    

    Sub ActualizarContras()
        Dim actulizar As New Consulta
        Try
            actulizar.ActulizarGral("tab_SystUsuarios", " usr_password = '" & _usr.stringToMd4(txtpass.Text) & "'",
           "usr_Id = '" & txid.Text & "'")
            MsgBox("se actualizo")
        Catch ex As Exception
            MsgBox("Actualizado correctamente" & ex.Message)
        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ActualizarContras()
        txtpass.Text = ""
        txid.Text = ""
        Me.Close()
    End Sub
End Class