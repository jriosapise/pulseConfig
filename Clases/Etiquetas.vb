Imports VB = Microsoft.VisualBasic
Imports System.Configuration
Public Class Etiquetas
    Dim _qry As New Consulta
    Public Function obtenerUltimoID(campo As String, tabla As String) As Integer
        Try
            Dim valor As String

            valor = _qry.SelToGridSingle(campo, tabla)

            Return valor
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Sub Delay(valor As Decimal)
        Static start As Single
        start = VB.Timer()
        Do While VB.Timer() < start + valor
            System.Windows.Forms.Application.DoEvents()
        Loop
    End Sub
    Public Sub NotificacionGuardado()
        'ICONO GUARDADO
        Main.iconSave.Visible = True
        Delay(0.3)
        'ICONO OCULTO
        Main.iconSave.Visible = False

        Main.iconSave2.Visible = True
        Delay(0.3)
        'ICONO OCULTO
        Main.iconSave2.Visible = False

        Main.iconSave3.Visible = True
        Delay(0.3)
        'ICONO OCULTO
        Main.iconSave3.Visible = False
    End Sub

    Private MPFotos As New IO.DirectoryInfo(ConfigurationSettings.AppSettings("MSDS"))
    Public Function RutaFotosInstrucciones() As String
        Try
            Dim foto As String
            'foto = _qry.SelToGridWhereSingle("conf_RutaFotos_WI", "tbl_Sistema_Config", "conf_id=1")

            foto = MPFotos.ToString
            Return foto
        Catch ex As Exception
            Throw
        End Try
    End Function
End Class
