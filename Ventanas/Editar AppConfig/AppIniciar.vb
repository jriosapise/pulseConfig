Public Class AppIniciar

    Private Sub AppIniciar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Sub validar()
        If txtPass.Text = "MantenimientoAp1s3" Then
            AppConfigEditar.ShowDialog()
        Else
            MsgBox("Contraseña incorrecta, intente nuevamente")
            txtPass.Text = ""

        End If

    End Sub

    Private Sub btnIniciar_Click(sender As Object, e As EventArgs) Handles btnIniciar.Click
        validar()

    End Sub


    Private Sub txtPass_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPass.KeyDown
        If e.KeyCode = Keys.Enter Then
            validar()
        End If
    End Sub
End Class