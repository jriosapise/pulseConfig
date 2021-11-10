Imports System.IO
Imports System.Reflection
Imports ClosedXML.Excel
Imports System.Data
Public Class exportar_a_Excel
    Public Function export(dgv As DataGridView, ruta As String, nombre As String) As Boolean

        Try
            'Creating DataTable
            Dim dt As New DataTable()
            'Adding the Columns

            For Each column As DataGridViewColumn In dgv.Columns
                dt.Columns.Add(column.HeaderText)
            Next

            'Adding the Rows
            For Each row As DataGridViewRow In dgv.Rows
                dt.Rows.Add()
                For Each cell As DataGridViewCell In row.Cells
                    dt.Rows(dt.Rows.Count - 1)(cell.ColumnIndex) = cell.Value.ToString()
                Next
            Next

            'Exporting to Excel
            Dim folderPath As String = ruta & "\"
            If Not Directory.Exists(folderPath) Then
                Directory.CreateDirectory(folderPath)
            End If
            Using wb As New XLWorkbook
                wb.Worksheets.Add(dt, "Customers")
                wb.SaveAs(folderPath & Convert.ToString(nombre & ".xlsx"))
            End Using
            Return True 
        Catch ex As Exception
            Throw
        End Try

    End Function
End Class
