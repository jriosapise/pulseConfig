Public Class ListasDistribucion_Editar

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            If existe() = False Then
                'ES UNICO
                Dim _qry As New Consulta
                _qry.ActulizarGral("a_DistribucionMaster", "disM_Desc='" & txtNuevo.Text & "'", "disM_id=" & ListasDistribucion.cmbLista.SelectedValue)
                MsgBox("Nombre de Lista fue actualizado.")
                ListasDistribucion.cargarListas()
                Me.Close()
            Else
                'YA EXISTE
                MsgBox("El nombre que eligio ya existe. Favor de ingresar otro.")
                txtNuevo.Text = ""
            End If
        Catch ex As Exception
            MsgBox("Error al crear nuevo. " & ex.Message)
        End Try
    End Sub
    Function existe() As Boolean
        Try
            Dim dts As DataSet
            Dim _qry As New Consulta
            dts = _qry.SelToGridWhere("disM_id", "a_DistribucionMaster", "disM_Desc='" & txtNuevo.Text & "'")
            If dts.Tables(0).Rows.Count > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function
End Class