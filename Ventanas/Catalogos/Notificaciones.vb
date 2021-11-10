Imports System.Text.RegularExpressions
Public Class Notificaciones
    Dim _qry As New Consulta
    Dim _etiq As New Etiquetas
    Dim _grid As New DatagridFormat

    Private Sub Notificaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Main
        cargarCorreos()
    End Sub
    Private Sub cargarCorreos()
        Dim dts As DataSet
        dts = _qry.SelToGridWhere("*", "api_Config", "id=1")
        Dim a, b As String
        For Each row As DataRow In dts.Tables(0).Rows
            If Not IsDBNull(row("mail_etiqueta_acciones")) Then
                txtDesc.Text = row("mail_etiqueta_acciones")
            Else
                txtDesc.Text = ""
            End If

            If Not IsDBNull(row("mail_etiqueta_acciones_CC")) Then
                txtCC.Text = row("mail_etiqueta_acciones_CC")
            Else
                txtCC.Text = ""
            End If
        Next
    End Sub
    Public Function validar_Mail(ByVal sMail As String) As Boolean
        ' retorna true o false   
        Return Regex.IsMatch(sMail, "^[_a-z0-9-]+(\.[_a-z0-9-]+)*@[a-z0-9-]+(\.[a-z0-9-]+)*(\.[a-z]{2,4})$")
    End Function

    Private Sub guardarCambios()
        Try
            _qry.ActulizarGral("api_Config", "mail_etiqueta_acciones='" & txtDesc.Text.Replace("'", "''") & "',mail_etiqueta_acciones_CC='" & txtCC.Text.Replace("'", "''") & "'",
                               "id=1")
        Catch ex As Exception
            MsgBox("Error al guardar cambios. " & ex.Message)
        End Try
    End Sub
    Private Sub GunaButton4_Click(sender As Object, e As EventArgs)
        limpiarCajas()
    End Sub

    Private Sub gbFiltrar_Click(sender As Object, e As EventArgs) Handles gbFiltrar.Click
        If txtDesc.Text.Length > 0 Then
            guardarCambios()
            _etiq.NotificacionGuardado()
        Else
            MsgBox("El campo Notificar a no puede quedar vacio")
        End If
    End Sub

    Private Sub gbLimpiar_Click(sender As Object, e As EventArgs) Handles gbLimpiar.Click
        limpiarCajas()
    End Sub
    Private Sub limpiarCajas()
        txtDesc.Text = ""
        txtId.Text = ""
    End Sub

    Private Sub txtCC_TextChanged(sender As Object, e As EventArgs) Handles txtCC.TextChanged
        'If txtCC.Text.Length > 0 Then
        '    If txtCC.Text = 1 Then
        '    Else
        '        lblMensaje.Text = "Formato correcto."

        '        lblMensaje.ForeColor = Color.GreenYellow
        '    End If
        'End If
    End Sub

    Private Sub txtDesc_TextChanged(sender As Object, e As EventArgs) Handles txtDesc.TextChanged
        'If validar_Mail(txtDesc.Text) = False Then
        '    lblMensaje.Text = "Dirección de correo no valida. El correo debe tener formato: nombre@dominio.com"
        'Else
        '    lblMensaje.Text = "Formato correcto."
        'End If
    End Sub
End Class