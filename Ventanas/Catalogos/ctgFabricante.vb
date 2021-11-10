Imports System.Configuration

Public Class ctgFabricante
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
            .ColumnCount = 8 'Total de Columnas
            .Columns(0).Name = "id" 'Nombre de columnas
            .Columns(1).Name = "DESCRIPCIÓN"
            .Columns(2).Name = "TEL"
            .Columns(3).Name = "EMAIL"
            .Columns(4).Name = "DIRECCION"
            .Columns(5).Name = "CP"
            .Columns(6).Name = "CIUDAD"
            .Columns(7).Name = "ESTADO"


            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill 'Esta propiedad autoajusta las columnas dependiendo el ancho del datagrid
            .Columns(0).Visible = False 'Esta opción es para ocultar las columnas
            .Columns(4).Visible = False
            .ColumnHeadersHeight = 30
            .RowTemplate.Height = 35
        End With
    End Sub
    Private Sub cargarListado()
        Try
            Dim dts As DataSet
            dgvCatalogo.Rows.Clear()
            dts = _qry.SelToGridWhere("*", "[sga.cat_Fabricante]", "fab_Nombre LIKE '%" & txtBusqueda.Text.Trim & "%'")
            If dts.Tables(0).Rows.Count > 0 Then
                For Each row As DataRow In dts.Tables(0).Rows
                    dgvCatalogo.Rows.Add(row("fab_id"), row("fab_Nombre"), row("fab_Telefono"), row("fab_email"), row("fab_Dirección"), row("fab_Cp"), row("fab_Ciudad"), row("fab_Estado"))
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
        txtId.Text = dgvCatalogo.Item(0, i).Value
        txtDesc.Text = dgvCatalogo.Item(1, i).Value
        If Not IsDBNull(dgvCatalogo.Item(2, i).Value) Then
            txtTel.Text = dgvCatalogo.Item(2, i).Value
        Else
            txtTel.Text = ""
        End If

        txtEmail.Text = dgvCatalogo.Item(3, i).Value
        txtCP.Text = dgvCatalogo.Item(5, i).Value
        txtDire.Text = dgvCatalogo.Item(4, i).Value
        txtCiudad.Text = dgvCatalogo.Item(6, i).Value
        txtEstado.Text = dgvCatalogo.Item(7, i).Value
    End Sub
    Private Sub guardarCambios()
        Try
            _qry.ActulizarGral("[sga.cat_Fabricante]", "fab_Nombre='" & txtDesc.Text.Replace("'", "''") & "', fab_Telefono='" & txtTel.Text & "', fab_Dirección='" & txtDire.Text & "', fab_Ciudad='" & txtCiudad.Text & "', fab_Estado='" & txtEstado.Text & "', fab_Cp='" & txtCP.Text & "', fab_email='" & txtEmail.Text & "'", "fab_id=" & txtId.Text)
        Catch ex As Exception
            MsgBox("Error al guardar cambios. " & ex.Message)
        End Try
    End Sub
    Private Sub InsertarNuevo()
        Try
            Dim dts As DataSet
            dts = _qry.SelToGridWhere("fab_Nombre", "[sga.cat_Fabricante]", "fab_Nombre='" & txtDesc.Text.Trim & "'")
            If dts.Tables(0).Rows.Count > 0 Then
                MsgBox("El fabricante ya existe.")
            Else

                _qry.InsertarDatos("fab_Nombre,fab_Telefono,fab_Dirección,fab_Ciudad,fab_Estado,fab_Cp,fab_email",
        "'" & txtDesc.Text.Replace("'", "''") & "','" & txtTel.Text & "','" & txtDire.Text & "','" & txtCiudad.Text & "'," & _
        "'" & txtEstado.Text & "','" & txtCP.Text & "','" & txtEmail.Text & "'", "[sga.cat_Fabricante]")
            End If

            
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
            MsgBox("Nombre de fabricante no puede quedar vacio.")
        End If

    End Sub

    Private Sub gbLimpiar_Click(sender As Object, e As EventArgs) Handles gbLimpiar.Click
        limpiarCajas()
    End Sub
    Private Sub limpiarCajas()
        txtDesc.Text = ""
        txtId.Text = ""
        txtTel.Text = ""
        txtDire.Text = ""
        txtCiudad.Text = ""
        txtEstado.Text = ""
        txtCP.Text = ""
        txtEmail.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        exportExcel()
    End Sub
    Private _rutaexportar As New IO.DirectoryInfo(ConfigurationSettings.AppSettings("rutaExportar"))
    Sub exportExcel()
        Try
            'USAR SEGUN APLIQUE
            ProgressBar1.Visible = True
            Dim ex As New exportar_a_Excel
            Dim nombre As String = DateTime.Now.ToString("yyyy.MM.dd")
            nombre = nombre & " - Listado de Fabricantes"
            Dim dgv As DataGridView = dgvCatalogo



            'NO MODIFICAR
            ex.export(dgv, _rutaexportar.ToString, nombre)
            Dim result As DialogResult = MessageBox.Show("Puede encontrar el archivo en " & _rutaexportar.ToString & nombre & ".xlsx.  " & "¿Deseas abrirlo?", _
                             "Exportar " & nombre, _
                              MessageBoxButtons.YesNo)


            If result = DialogResult.Yes Then
                Process.Start(_rutaexportar.ToString & nombre & ".xlsx")
            End If

            ProgressBar1.Visible = False
        Catch ex As Exception
            MsgBox("Error al exportar: " & ex.Message)
        End Try
    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        cargarListado()
    End Sub

    Private Sub txtBusqueda_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBusqueda.KeyDown
        If e.KeyCode = Keys.Enter Then
            cargarListado()
        End If
    End Sub

End Class