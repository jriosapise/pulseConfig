Imports System.Configuration
Imports System.Reflection
Public Class AppConfig

    Private _config As System.Configuration.Configuration
    Private _settings As AppSettingsSection

    Public Function GetProperty(propertyName As String) As String
        Return _settings.Settings.Item(propertyName).Value
    End Function

    Public Sub SetProperty(propertyName As String, propertyValue As String)
        _settings.Settings.Item(propertyName).Value = propertyValue
    End Sub

    Public Sub New()
        _config = ConfigurationManager.OpenExeConfiguration(Assembly.GetEntryAssembly().Location)
        _settings = _config.AppSettings
    End Sub

    Protected Overrides Sub Finalize()
        Try

        
        MyBase.Finalize()
            _config.Save(ConfigurationSaveMode.Modified)
        Catch ex As Exception

        End Try

    End Sub

End Class
