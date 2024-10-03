Imports System.Net.Mail
Imports System.Text.RegularExpressions

Public Class ListasDistribucion
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub ListasDistribucion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Main
        cargarListas()
    End Sub
    Public Sub cargarListas()
        Try
            Dim dts As DataSet
            Dim cargar As New Consulta

            dts = cargar.SelToGridWhere("disM_id, disM_Desc", "a_DistribucionMaster", "disM_Activo='True'")
            cmbLista.DataSource = dts.Tables(0)
            cmbLista.DisplayMember = dts.Tables(0).Columns(1).Caption.ToString
            cmbLista.ValueMember = dts.Tables(0).Columns(0).Caption.ToString
        Catch ex As Exception
            MsgBox("Error al cargar listado. " & ex.Message)
        End Try
    End Sub
    Private Sub cmbLista_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbLista.SelectedIndexChanged
        Try
            If cmbLista.SelectedValue > 0 Then
                cargarDetalles()
            End If
        Catch ex As Exception

        End Try
    End Sub
    Protected Sub cargarDetalles()
        Try
            Dim dts As DataSet
            Dim detalle As String
            Dim cargar As New Consulta
            emailList.Items.Clear()
            dts = cargar.SelToGridWhere("disM_Activo,disM_Detalles", "a_DistribucionMaster", "disM_id=" & cmbLista.SelectedValue & " and  disM_Activo='True'")
            If dts.Tables(0).Rows.Count > 0 Then
                For Each row As DataRow In dts.Tables(0).Rows
                    chkActivo.Checked = row("disM_Activo")
                    If Not IsDBNull(row("disM_Detalles")) Then
                        Dim correos As String = row("disM_Detalles")
                        Dim cuentas As String() = correos.Split(New Char() {","c})
                        For Each correo As String In cuentas
                            emailList.Items.Add(correo)
                        Next
                    Else
                        emailList.Items.Clear()
                    End If

                Next
            Else
                emailList.Items.Clear()
            End If

        Catch ex As Exception
            MsgBox("Error al cargar detalles. " & ex.Message)
        End Try
    End Sub




    Protected Sub guardarCambio()
        Try
            Dim qry As New Consulta
            qry.ActulizarGral("a_DistribucionMaster", "disM_Activo='" & chkActivo.Checked & "',disM_Detalles='" & txtCorreos.Text & "'", "disM_id=" & cmbLista.SelectedValue)

            MsgBox("Guardado exitosamente")

        Catch ex As Exception
            MsgBox("Error al guardar. " & ex.Message)
        End Try
    End Sub
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If emailList.Items.Count > 0 Then
            For Each item As String In emailList.Items
                If txtCorreos.Text <> "" Then
                    txtCorreos.Text = txtCorreos.Text & "," & item
                Else
                    txtCorreos.Text = item
                End If
            Next
            guardarCambio()
            txtCorreos.Text = ""
        Else
            MsgBox("La lista de correos no puede quedar vacia.")
        End If
    End Sub

    Public Function ValidateEmail(ByVal strCheck As String) As Boolean
        Try
            Dim vEmailAddress As New System.Net.Mail.MailAddress(strCheck)
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function
    Function IsValidEmailFormat(ByVal s As String) As Boolean
        Return Regex.IsMatch(s, "^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$")
    End Function
    Private Sub removeEmail()
        Try
            emailList.Items.Remove(emailList.SelectedItem)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        removeEmail()
    End Sub


    Private Sub GunaButton4_Click(sender As Object, e As EventArgs) Handles GunaButton4.Click
        ListasDistribucion_Nueva.ShowDialog(Me)
    End Sub

    Private Sub gbFiltrar_Click(sender As Object, e As EventArgs) Handles gbFiltrar.Click
        ListasDistribucion_Editar.txtNuevo.Text = cmbLista.Text
        ListasDistribucion_Editar.ShowDialog(Me)
    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        If IsValidEmailFormat(txtNuevo.Text) Then
            If Not emailList.Items.Contains(txtNuevo.Text) Then
                emailList.Items.Add(txtNuevo.Text)
                txtNuevo.Text = ""
            Else
                MsgBox("La cuenta de correo ya esta agregada al listado.")
            End If
        Else
            MsgBox("Formato de correo no valido.")
        End If
    End Sub
End Class