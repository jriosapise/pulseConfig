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
            .Columns(2).Name = "EVENTO"
            .Columns(3).Name = "MENSAJE"
            .Columns(4).Name = "ARCHIVO / #PARTE / LOTE"


            '.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill 'Esta propiedad autoajusta las columnas dependiendo el ancho del datagrid
            .Columns(0).Visible = False 'Esta opción es para ocultar las columnas

            .Columns(1).Width = 120
            .Columns(2).Width = 70
            .Columns(3).Width = 320
            .Columns(4).Width = 320
            .Columns(3).DefaultCellStyle.WrapMode = DataGridViewTriState.True
            .Columns(4).DefaultCellStyle.WrapMode = DataGridViewTriState.True
            .ColumnHeadersHeight = 30
            .RowTemplate.Height = 35
        End With
    End Sub
    Dim _qry As New Consulta
    Private Sub cargarLog()
        Try
            dgvBitacora.Rows.Clear()

            Dim dts As DataSet

            dts = _qry.SelToGridWhere("EventId,EventDateTime,EventType,Message,FileName",
                                      "a_EventLog",
                                      "EventDateTime  between '" & fecha1.Value & " 00:00' and '" & fecha2.Value & "'")

            '"div_Desc like '%" & txtDivision.Text & "%' AND " & _


            For Each row As DataRow In dts.Tables(0).Rows
                Dim fecha As Date = row("EventDateTime")
                Dim fechas As String = fecha.ToString("dd/MM/yyyy HH:mm.tt")
                dgvBitacora.Rows.Add(row("EventId"), fechas, row("EventType"), row("Message"), row("FileName"))
            Next
            lblTotal.Text = "(" & dts.Tables(0).Rows.Count & ")"
        Catch ex As Exception
            MsgBox("Error al cargar eventos. " & ex.Message)
        End Try
    End Sub

    Private Sub gbFiltrar_Click(sender As Object, e As EventArgs) Handles gbFiltrar.Click
        cargarLog()
    End Sub
End Class