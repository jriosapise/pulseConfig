Imports System.Configuration

Public Class PrintOut_Log

    Private Sub PrintOut_Log_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Main
        gridcolumnas(dgvBitacora)
        fecha2.Value = Now
    End Sub
    Private Sub gridcolumnas(grid1 As DataGridView)

        With grid1

            .ColumnCount = 5 'Total de Columnas
            .Columns(0).Name = "id" 'Nombre de columnas
            .Columns(1).Name = "FECHA"
            .Columns(2).Name = "EMPLEADO"
            .Columns(3).Name = "# CONTROL"
            .Columns(4).Name = "NOMBRE DE QUIMICO"


            '.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill 'Esta propiedad autoajusta las columnas dependiendo el ancho del datagrid
            .Columns(0).Visible = False 'Esta opción es para ocultar las columnas

            .Columns(1).Width = 120
            .Columns(2).Width = 200
            .Columns(4).Width = 320
            .ColumnHeadersHeight = 30
            .RowTemplate.Height = 35
        End With
    End Sub
    Dim _qry As New Consulta
    Private Sub cargarLog()
        Try
            dgvBitacora.Rows.Clear()

            Dim dts As DataSet

            dts = _qry.SelToGridWhere("imp_id,fk_etiqueta_id,imp_fecha,lbl_numControl,lbl_nomQuimico,usr_Name,num_empleado",
                                      "sga_vw_impresion_log",
                                      "imp_fecha  between '" & fecha1.Value & "' and '" & fecha2.Value & "'")

            '"div_Desc like '%" & txtDivision.Text & "%' AND " & _


            For Each row As DataRow In dts.Tables(0).Rows
                Dim fecha As Date = row("imp_fecha")
                Dim fechas As String = fecha.ToString("dd/MM/yyyy HH:mm.tt")
                dgvBitacora.Rows.Add(row("imp_id"), fechas, row("usr_Name"), row("lbl_numControl"), row("lbl_nomQuimico"))
            Next
            lblTotal.Text = "(" & dts.Tables(0).Rows.Count & ")"
        Catch ex As Exception
            MsgBox("Error al cargar etiquetas. " & ex.Message)
        End Try
    End Sub

    Private Sub gbFiltrar_Click(sender As Object, e As EventArgs) Handles gbFiltrar.Click
        cargarLog()
    End Sub
End Class