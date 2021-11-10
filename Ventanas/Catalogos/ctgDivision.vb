Public Class ctgDivision
    Dim _qry As New Consulta
    Dim _etiq As New Etiquetas
    Dim _grid As New DatagridFormat

    Private Sub ctgDivision_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Main
        gridcolumnas(dgvCatalogo)
        _grid.formatto(dgvCatalogo)
        cargarListado()
    End Sub
    Private Sub gridcolumnas(grid1 As DataGridView)
        With grid1
            .ColumnCount = 2 'Total de Columnas
            .Columns(0).Name = "id" 'Nombre de columnas
            .Columns(1).Name = "DESCRIPCIÓN"


            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill 'Esta propiedad autoajusta las columnas dependiendo el ancho del datagrid
            .Columns(0).Visible = False 'Esta opción es para ocultar las columnas

            .ColumnHeadersHeight = 30
            .RowTemplate.Height = 35
        End With
    End Sub
    Private Sub cargarListado()
        Try
            Dim dts As DataSet
            dgvCatalogo.Rows.Clear()
            dts = _qry.SelToGridWhere("*", "[sga.cat_Division]", "div_id>0")
            If dts.Tables(0).Rows.Count > 0 Then
                For Each row As DataRow In dts.Tables(0).Rows
                    dgvCatalogo.Rows.Add(row("div_id"), row("div_Desc"))
                Next
            End If
        Catch ex As Exception
            MsgBox("Error al cargar Divisiones. " & ex.Message)
        End Try
    End Sub

    Private Sub dgvCatalogo_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCatalogo.CellContentClick
        Dim i As Integer
        Dim id As Integer
        i = dgvCatalogo.CurrentRow.Index
        txtId.Text = dgvCatalogo.Item(0, i).Value
        txtDesc.Text = dgvCatalogo.Item(1, i).Value
    End Sub
    Private Sub guardarCambios()
        Try
            _qry.ActulizarGral("[sga.cat_Division]", "div_Desc='" & txtDesc.Text.Replace("'", "''") & "'", "div_id=" & txtId.Text)
        Catch ex As Exception
            MsgBox("Error al guardar cambios. " & ex.Message)
        End Try
    End Sub
    Private Sub InsertarNuevo()
        Try
            _qry.InsertarDatos("div_Desc", "'" & txtDesc.Text.Replace("'", "''") & "'", "[sga.cat_Division]")
        Catch ex As Exception
            MsgBox("Error al crear nueva División. " & ex.Message)
        End Try
    End Sub

    Private Sub GunaButton4_Click(sender As Object, e As EventArgs) Handles GunaButton4.Click
        limpiarCajas()
    End Sub

    Private Sub gbFiltrar_Click(sender As Object, e As EventArgs) Handles gbFiltrar.Click
        If txtDesc.Text.Length > 0 Then
            If txtId.Text = "" Then
                InsertarNuevo()
            Else
                guardarCambios()
            End If
            _etiq.NotificacionGuardado()
            cargarListado()
        Else
            MsgBox("El campo division no puede quedar vacio")
        End If
    End Sub

    Private Sub gbLimpiar_Click(sender As Object, e As EventArgs) Handles gbLimpiar.Click
        limpiarCajas()
    End Sub
    Private Sub limpiarCajas()
        txtDesc.Text = ""
        txtId.Text = ""
    End Sub
End Class