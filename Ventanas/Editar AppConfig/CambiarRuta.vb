Public Class CambiarRuta

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        guarCamb()

    End Sub
    Dim _appConfig As New AppConfig

    Protected Sub guarCamb()
        Try
            Dim cadenaNueva As String = "Data Source=" & txtServidor1.Text & "; Initial Catalog=" & txtNomBase1.Text & ";User ID=" & txtUsuar1.Text & ";Password=" & txtContr1.Text

            AppConfigEditar.txtRuta.Text = cadenaNueva

            _appConfig.SetProperty("Ruta", AppConfigEditar.txtRuta.Text)

            MsgBox("Configuración ha sido actualizada satisfactoriamente. La aplicación sera reiniciada para aplicar los cambios")

            Application.Restart()
        Catch ex As Exception
            MsgBox("Error guardando cambios: " & ex.Message)
        End Try


    End Sub
End Class