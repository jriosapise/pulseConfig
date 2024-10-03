Imports System.Configuration

Public Class Main
    Private _imagefolder As New IO.DirectoryInfo(ConfigurationSettings.AppSettings("imagenesUser"))
    Private _imgDefID As New IO.DirectoryInfo(ConfigurationSettings.AppSettings("imgDefault"))
    Dim cerrarSesion As Boolean = False
    Dim _sist As New LogsdeSistema

    Private Sub Main_FormClossing(sender As Object, e As FormClosingEventArgs) _
     Handles Me.FormClosing
        'If cerrarSesion = False Then
        '    If e.CloseReason = CloseReason.UserClosing Then
        '        e.Cancel = True
        '        _sist.eliminarSesion(tUserId.Text)
        '        Login.Close()
        '        'Me.Hide()
        '    End If
        'End If
    End Sub
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles Me.Load
        Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)
        Guna.UI.Lib.GraphicsHelper.DrawLineShadow(GunaPanel5, Color.Black, 20, 5, Guna.UI.WinForms.VerHorAlign.HoriziontalTop)

    End Sub


    Private Sub GunaAdvenceButton1_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton1.Click
        Tolerancias.Show()
    End Sub





    Private Sub GunaAdvenceButton5_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton5.Click
        'Me.Close()
        _sist.eliminarSesion(tUserId.Text)
        Me.Close()
        Login.Show()
    End Sub
    Public Sub cargarFoto()


        If Not tFoto.Text = "" Then

            cpic_UserPicture.Image = Image.FromFile(_imagefolder.FullName & "\" & tFoto.Text)

        Else
            cpic_UserPicture.Image = Image.FromFile(_imagefolder.FullName & "\" & _imgDefID.ToString)
        End If
    End Sub

    Private Sub GunaAdvenceButton7_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton7.Click
        ListasDistribucion.Show()
    End Sub

    Private Sub GunaAdvenceButton6_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton6.Click
        PrintOut_Log.Show()
    End Sub
End Class
