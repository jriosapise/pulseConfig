Public Class ListasDistribucion_Nueva

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            If existe() = False Then
                'ES UNICO
                Dim _qry As New Consulta
                _qry.InsertarDatos("disM_Desc,disM_Activo", "'" & txtNuevo.Text & "','TRUE'", "a_DistribucionMaster")
                MsgBox("Nueva lista creada.")
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