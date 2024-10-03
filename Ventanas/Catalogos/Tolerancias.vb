Imports System.Configuration
Public Class Tolerancias
    Dim _qry As New Consulta
    Dim _etiq As New Etiquetas
    Dim _grid As New DatagridFormat

    Private Sub Tolerancias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Main
        gridcolumnas(dgvCatalogo)
        _grid.formatto(dgvCatalogo)
        cargarListado()
    End Sub
    Private Sub gridcolumnas(grid1 As DataGridView)
        With grid1
            .ColumnCount = 3 'Total de Columnas
            .Columns(0).Name = "DESCRIPCIÓN"
            .Columns(1).Name = "MIN"
            .Columns(2).Name = "MAX"


            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill 'Esta propiedad autoajusta las columnas dependiendo el ancho del datagrid

            .ColumnHeadersHeight = 30
            .RowTemplate.Height = 35
        End With
    End Sub
    Private Sub cargarListado()
        Try
            Dim dts As DataSet
            dgvCatalogo.Rows.Clear()
            dts = _qry.SelToGridWhere("*", "[a_CatalogoPartes]", "NumeroDeParte LIKE '%" & txtBusqueda.Text.Trim & "%'")
            If dts.Tables(0).Rows.Count > 0 Then
                For Each row As DataRow In dts.Tables(0).Rows
                    dgvCatalogo.Rows.Add(row("NumeroDeParte"), row("Minimo"), row("Maximo"))
                Next
            End If
        Catch ex As Exception
            MsgBox("Error al cargar Fabricantes. " & ex.Message)
        End Try
    End Sub

    Private Sub dgvCatalogo_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCatalogo.CellContentClick
        Dim i As Integer
        Dim id As Integer
        i = dgvCatalogo.CurrentRow.Index
        txtDesc.Text = dgvCatalogo.Item(0, i).Value
        nuMin.Value = dgvCatalogo.Item(1, i).Value
        nuMax.Value = dgvCatalogo.Item(2, i).Value
    End Sub
    Private Sub guardarCambios()
        Try
            _qry.ActulizarGral("[a_CatalogoPartes]", "Minimo=" & nuMin.Value & ", Maximo=" & nuMax.Value & "", "NumeroDeParte='" & txtDesc.Text & "'")
        Catch ex As Exception
            MsgBox("Error al guardar cambios. " & ex.Message)
        End Try
    End Sub

    Private Sub InsertarNuevo()
        Try
            Dim dts As DataSet
            dts = _qry.SelToGridWhere("NumeroDeParte", "[a_CatalogoPartes]", "NumeroDeParte='" & txtDesc.Text.Trim & "'")
            If dts.Tables(0).Rows.Count > 0 Then
                MsgBox("El fabricante ya existe.")
            Else

                _qry.InsertarDatos("NumeroDeParte,Minimo,Maximo",
        "'" & txtDesc.Text.Replace("'", "''") & "'," & nuMin.Value & "," & nuMax.Value & "", "[a_CatalogoPartes]")
            End If


        Catch ex As Exception
            MsgBox("Error al crear nuevo # de Parte. " & ex.Message)
        End Try
    End Sub

    Private Sub gbLimpiar_Click(sender As Object, e As EventArgs) Handles gbLimpiar.Click
        limpiarCajas()
    End Sub
    Private Sub gbFiltrar_Click(sender As Object, e As EventArgs) Handles gbFiltrar.Click
        If txtDesc.Text.Length > 0 Then
            Dim dts As DataSet
            dts = _qry.SelToGridWhere("NumeroDeParte", "[a_CatalogoPartes]", "NumeroDeParte='" & txtDesc.Text.Trim & "'")
            If dts.Tables(0).Rows.Count > 0 Then
                guardarCambios()
            Else
                InsertarNuevo()
            End If

            cargarListado()
        Else
            MsgBox("Número de parte no puede quedar vacio.")
        End If

    End Sub
    Private Sub limpiarCajas()
        txtDesc.Text = ""
        nuMax.Value = 0
        nuMin.Value = 0
    End Sub

    Private Sub GunaButton4_Click(sender As Object, e As EventArgs) Handles GunaButton4.Click
        limpiarCajas()
    End Sub
End Class