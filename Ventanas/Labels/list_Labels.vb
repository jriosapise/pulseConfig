Imports System.Configuration

Public Class list_Labels
    Private _FormatoFecha As New IO.DirectoryInfo(ConfigurationSettings.AppSettings("FormatoFecha"))
    Private _FormatoFechaDB As New IO.DirectoryInfo(ConfigurationSettings.AppSettings("FormatoFechaDB"))
    Dim _qry As New Consulta
    Dim _grid As New DatagridFormat
    Private Sub list_Labels_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Main
        cargarComboDivision()
        _grid.formatto(dgvBitacora)

        gridcolumnas(dgvBitacora)

        cargarEtiquetas()
    End Sub
    Private Sub cargarComboDivision()
        Try
            Dim dts As DataSet
            dts = _qry.SelToGridWhere("div_id ,div_Desc", "[sga.cat_Division]", "div_id > 0 order by div_Desc asc")

            dgv.Rows.Clear()

            For Each row As DataRow In dts.Tables(0).Rows
                dgv.Rows.Add("False", row("div_id"), row("div_Desc"))
            Next
        Catch ex As Exception
            MsgBox("Error al cargar Division. " & ex.Message)
        End Try
    End Sub
    Private Sub gridcolumnas(grid1 As DataGridView)
        Dim dts As DataSet
        dts = _qry.SelToGrid("*", "[sga.cat_Division] order by div_id asc")
        Dim qty As Integer = dts.Tables(0).Rows.Count
        Dim cols As Integer = 9 + qty
        Dim i As Integer = 1
        Dim j As Integer = 9
        With grid1

            .ColumnCount = cols 'Total de Columnas
            .Columns(0).Name = "id" 'Nombre de columnas
            .Columns(1).Name = "FOLIO"
            .Columns(2).Name = "# CONTROL"
            .Columns(3).Name = "# DE PARTE"
            .Columns(4).Name = "NOMBRE DE QUIMICO"
            .Columns(5).Name = "DIVISION"
            .Columns(6).Name = "FABRICANTE"
            .Columns(7).Name = "MSDS SP"
            .Columns(8).Name = "MSDS EN"

            For Each row As DataRow In dts.Tables(0).Rows
                If i <= qty Then
                    Dim a As String = row("div_desc")
                    .Columns(j).Name = a
                    .Columns(j).Width = 55
                End If
                j = j + 1
                i = i + 1
            Next

            '.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill 'Esta propiedad autoajusta las columnas dependiendo el ancho del datagrid
            .Columns(0).Visible = False 'Esta opción es para ocultar las columnas
            .Columns(1).Visible = False
            .Columns(5).Visible = False 'Esta opción es para ocultar las columnas
            .Columns(7).Visible = False
            .Columns(8).Visible = False
            .Columns(1).Width = 80
            .Columns(2).Width = 100
            .Columns(5).Width = 150
            .Columns(6).Width = 150
            .Columns(4).Width = 320
            .ColumnHeadersHeight = 30
            .RowTemplate.Height = 35
        End With
    End Sub
    Dim SeleccionDeDivision As String
    Private Sub seleccionarDivision()
        Dim i, nums As Integer
        Dim descripcion As String
        Dim ID As Integer
        Dim bandera As Boolean = False
        SeleccionDeDivision = ""
        Try
            For Each row As DataGridViewRow In dgv.Rows
                row.DefaultCellStyle.BackColor = Color.White

                If i < dgv.Rows.Count Then
                    ID = dgv.Rows(i).Cells("id").Value
                    bandera = dgv.Rows(i).Cells("chk").Value()

                    If bandera = True Then
                        If SeleccionDeDivision = "" Then
                            SeleccionDeDivision = "fk_id_Division like '%" & ID & "%'"
                        Else
                            SeleccionDeDivision = SeleccionDeDivision & " OR fk_id_Division like '%" & ID & "%'"
                        End If
                    End If
                End If
                i = i + 1
            Next
        Catch ex As Exception
            MsgBox("Error al identificar divisiones seleccionadas. " & ex.Message)
        End Try
    End Sub
    Protected Sub cargarEtiquetas()
        Try
            dgvBitacora.Rows.Clear()
            seleccionarDivision()
            SeleccionDeDivision = SeleccionDeDivision

            Dim dts As DataSet
            Dim where As String
            If SeleccionDeDivision = "" Then
                where = "lbl_numParte like '%" & txtFolio.Text & "%' AND " & _
                                      "lbl_numControl like '%" & txtControl.Text & "%' AND " & _
                                      "lbl_nomQuimico like '%" & txtQuimico.Text & "%' AND " & _
                                      "fab_Nombre like '%" & txtFabricante.Text & "%'" & _
                                      ""
            Else
                where = "lbl_numParte like '%" & txtFolio.Text & "%' AND " & _
                                      "lbl_numControl like '%" & txtControl.Text & "%' AND " & _
                                      "lbl_nomQuimico like '%" & txtQuimico.Text & "%' AND " & _
                                      "fab_Nombre like '%" & txtFabricante.Text & "%' AND " & _
                                      "(" & SeleccionDeDivision & ")"
            End If
            dts = _qry.SelToGridWhere("lbl_Folio,lbl_id,lbl_numControl,lbl_numParte,lbl_nomQuimico,fab_Cp,fab_Nombre,rie_Desc,lbl_MSDSEN,lbl_MsdsSp,fk_id_Division",
                                      "vw_Etiquetas_Full",
                                      where)

            '"div_Desc like '%" & txtDivision.Text & "%' AND " & _

            Dim UNO, DOS, TRES, CUATRO, CINCO, SEIS, SIETE, OCHO, NUEVE, DIEZ, ONCE, DOCE, TRECE, CATORCE As String
          
            For Each row As DataRow In dts.Tables(0).Rows
                'Se agregan variables para manejar hasta 14 divisiones agregadas por el usuario final.
                'Actualmente el cliente solo maneja 4-2021.03.25
                UNO = ""
                DOS = ""
                TRES = ""
                CUATRO = ""
                CINCO = ""
                SEIS = ""
                SIETE = ""
                OCHO = ""
                NUEVE = ""
                DIEZ = ""
                ONCE = ""
                DOCE = ""
                TRECE = ""
                CATORCE = ""

                Dim division As String = row("fk_id_Division")
                Dim divisiones As String() = division.Split(New Char() {","c})
                For Each valor In divisiones
                    valor = valor.Trim
                    Select Case valor
                        Case 1
                            UNO = "X"
                        Case 2
                            DOS = "X"
                        Case 3
                            TRES = "X"
                        Case 4
                            CUATRO = "X"
                        Case 5
                            CINCO = "X"
                        Case 6
                            SEIS = "X"
                        Case 7
                            SIETE = "X"
                        Case 8
                            OCHO = "X"
                        Case 9
                            NUEVE = "X"
                        Case 10
                            DIEZ = "X"
                        Case 11
                            ONCE = "X"
                        Case 12
                            DOCE = "X"
                        Case 13
                            TRECE = "X"
                        Case 14
                            CATORCE = "X"
                        Case 15

                    End Select
                Next

                dgvBitacora.Rows.Add(row("lbl_id"), row("lbl_Folio"), row("lbl_numControl"), row("lbl_numParte"), row("lbl_nomQuimico"), row("fk_id_Division"), row("fab_Nombre"), row("lbl_MsdsSp"), row("lbl_MSDSEN"), UNO, DOS, TRES, CUATRO, CINCO, SEIS, SIETE, OCHO, NUEVE, DIEZ, ONCE, DOCE, TRECE, CATORCE)
            Next
            lblTotal.Text = "(" & dts.Tables(0).Rows.Count & ")"
        Catch ex As Exception
            MsgBox("Error al cargar etiquetas. " & ex.Message)
        End Try
    End Sub

    Private Sub gbFiltrar_Click(sender As Object, e As EventArgs) Handles gbFiltrar.Click
        cargarEtiquetas()
    End Sub

    Private Sub dgvBitacora_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBitacora.CellContentClick
        Dim i As Integer
        Dim id As Integer
        i = dgvBitacora.CurrentRow.Index
        id = dgvBitacora.Item(0, i).Value
        add_Labels.Show()
        add_Labels.txtID.Text = id
        add_Labels.bandera = False
        add_Labels.panelCreadoPor.Visible = True

        add_Labels.cargarDatosEtiqueta()
        add_Labels.validarPictogramasOn()
    End Sub

    Private Sub gbCrear_Click(sender As Object, e As EventArgs) Handles gbCrear.Click
        add_Labels.Close()
        add_Labels.bandera = True
        add_Labels.panelCreadoPor.Visible = False
        add_Labels.deshabilitarBotonesMSDS()

        add_Labels.Show()
        add_Labels.generarNumControl()
    End Sub

    Private Sub gbLimpiar_Click(sender As Object, e As EventArgs) Handles gbLimpiar.Click
        txtFolio.Text = ""
        txtControl.Text = ""
        txtFabricante.Text = ""
        txtQuimico.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        exportExcel()
    End Sub
    Private _rutaexportar As New IO.DirectoryInfo(ConfigurationSettings.AppSettings("rutaExportar"))
    Sub exportExcel()
        Try
            'USAR SEGUN APLIQUE
            ProgressBar1.Visible = True
            Dim ex As New exportar_a_Excel
            Dim nombre As String = DateTime.Now.ToString("yyyy.MM.dd")
            nombre = nombre & " - Listado de Quimicos"
            Dim dgv As DataGridView = dgvBitacora



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
End Class