Public Class AppConfigEditar
    Dim appconfig As New GHSA_App.configuration.extras.AppConfigFileSettings

    Private Sub AppConfigEditar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarParametros()

    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Protected Sub cargarParametros()
        Try
            Dim val As String()
            'val = connectionstring.Split(";")
            Dim path As String
            'path = val(1).Substring(12, val(1).Length - 12)
            txtRuta.Text = System.Configuration.ConfigurationSettings.AppSettings("Ruta")
            txtManiFodler.Text = System.Configuration.ConfigurationSettings.AppSettings("maniFolder")
            txtRutaImagenes.Text = System.Configuration.ConfigurationSettings.AppSettings("rutaImagenes")
            txtImagenesUser.Text = System.Configuration.ConfigurationSettings.AppSettings("imagenesUser")
            txtBascula1.Text = System.Configuration.ConfigurationSettings.AppSettings("rutaExportar")

            'txtventana.Text = _appConfig.GetProperty("ventana") 'System.Configuration.ConfigurationSettings.AppSettings("ventana")
        Catch ex As Exception
            MsgBox("Error obteniendo configuración: " & ex.Message)
        End Try
    End Sub

    Dim _appConfig As New AppConfig
    Protected Sub guardarCambios()
        Try
            '_appConfig.SetProperty("Ruta", txtRuta.Text)
            'appconfig.UpdateAppSettings("Bascula2", txtBascula2.Text)
            _appConfig.SetProperty("maniFolder", txtManiFodler.Text)
            'appconfig.UpdateAppSettings("Boton2", txtBoton2.Text)
            _appConfig.SetProperty("rutaImagenes", txtRutaImagenes.Text)
            'appconfig.UpdateAppSettings("delay", txtdelay.Text)
            _appConfig.SetProperty("imagenesUser", txtImagenesUser.Text)
            'appconfig.UpdateAppSettings("stop", txtstop.Text)
            _appConfig.SetProperty("rutaExportar", txtBascula1.Text)
            'appconfig.UpdateAppSettings("ventana", txtventana.Text)

            MsgBox("Configuración ha sido actualizada satisfactoriamente. La aplicación sera reiniciada para aplicar los cambios")

            Application.Restart()
        Catch ex As Exception
            MsgBox("Error guardando cambios: " & ex.Message)
        End Try
    End Sub


    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        guardarCambios()

    End Sub

    Private Sub btnCambiar_Click(sender As Object, e As EventArgs) Handles btnCambiar.Click
        CambiarRuta.ShowDialog()

    End Sub
End Class