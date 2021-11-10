Public Class DatagridFormat
    Public Sub formatto(grid As DataGridView)
        With grid
            ' Set the selection background color for all the cells.
            .DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#ACB6C0")
            .DefaultCellStyle.SelectionForeColor = Color.Black  'Convertir Hex a tipo Color

            ' Set RowHeadersDefaultCellStyle.SelectionBackColor so that its default
            ' value won't override DataGridView.DefaultCellStyle.SelectionBackColor.

            ' Set the background color for all rows and for alternating rows. 
            ' The value for alternating rows overrides the value for all rows. 
            .RowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#DDEBF7")
            .RowsDefaultCellStyle.Font = New Font("Tahoma", 9.0F, FontStyle.Regular)
            .AlternatingRowsDefaultCellStyle.BackColor = Color.White

            ' Set the row and column header styles.
            .ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            .ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#5B9BD5")
            .ColumnHeadersDefaultCellStyle.Font = New Font("Tahoma", 9.0F, FontStyle.Bold)
            '.RowHeadersDefaultCellStyle.BackColor = Color.Black
            .EnableHeadersVisualStyles = False
            .GridColor = ColorTranslator.FromHtml("#9BC2E6")

            .RowHeadersVisible = False
        End With
    End Sub

    Public Sub formattoGrande(grid As DataGridView)
        With grid
            ' Set the selection background color for all the cells.
            .DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#ACB6C0")
            .DefaultCellStyle.SelectionForeColor = Color.Black  'Convertir Hex a tipo Color

            ' Set RowHeadersDefaultCellStyle.SelectionBackColor so that its default
            ' value won't override DataGridView.DefaultCellStyle.SelectionBackColor.

            ' Set the background color for all rows and for alternating rows. 
            ' The value for alternating rows overrides the value for all rows. 
            .RowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#DDEBF7")
            .RowsDefaultCellStyle.Font = New Font("Tahoma", 12.0F, FontStyle.Regular)
            .AlternatingRowsDefaultCellStyle.BackColor = Color.White

            ' Set the row and column header styles.
            .ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            .ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#5B9BD5")
            .ColumnHeadersDefaultCellStyle.Font = New Font("Tahoma", 12.0F, FontStyle.Bold)
            '.RowHeadersDefaultCellStyle.BackColor = Color.Black
            .EnableHeadersVisualStyles = False
            .GridColor = ColorTranslator.FromHtml("#9BC2E6")

            .RowHeadersVisible = False
        End With
    End Sub

    Public Sub Indicadorformatto(grid As DataGridView)
        With grid
            ' Set the selection background color for all the cells.
            .DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#5C85A5")
            .DefaultCellStyle.SelectionForeColor = Color.White   'Convertir Hex a tipo Color
            ' Set RowHeadersDefaultCellStyle.SelectionBackColor so that its default
            ' value won't override DataGridView.DefaultCellStyle.SelectionBackColor.

            ' Set the background color for all rows and for alternating rows. 
            ' The value for alternating rows overrides the value for all rows. 
            .RowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#FFFFFF")
            .RowsDefaultCellStyle.Font = New Font("Arial", 9.0F, FontStyle.Bold)
            '.AlternatingRowsDefaultCellStyle.BackColor = Color.White




            ' Set the row and column header styles.
            .ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            .ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#1D1F34")
            .ColumnHeadersDefaultCellStyle.Font = New Font("Arial", 10.0F, FontStyle.Bold)
            '.RowHeadersDefaultCellStyle.BackColor = Color.Black
            .EnableHeadersVisualStyles = False
            .GridColor = ColorTranslator.FromHtml("#E6E9EB")

            .RowHeadersVisible = False
        End With
    End Sub

    Public Sub alarma(grid As DataGridView)
        With grid
            ' Set the selection background color for all the cells.
            .DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#FF4000")
            .DefaultCellStyle.SelectionForeColor = Color.Black  'Convertir Hex a tipo Color

            ' Set RowHeadersDefaultCellStyle.SelectionBackColor so that its default
            ' value won't override DataGridView.DefaultCellStyle.SelectionBackColor.

            ' Set the background color for all rows and for alternating rows. 
            ' The value for alternating rows overrides the value for all rows. 
            .RowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#FF4000")
            .RowsDefaultCellStyle.Font = New Font("Tahoma", 9.0F, FontStyle.Regular)
            .AlternatingRowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#FF4000")

            ' Set the row and column header styles.
            .ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            .ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#000000")
            .ColumnHeadersDefaultCellStyle.Font = New Font("Tahoma", 9.0F, FontStyle.Bold)
            '.RowHeadersDefaultCellStyle.BackColor = Color.Black
            .EnableHeadersVisualStyles = False
            .GridColor = ColorTranslator.FromHtml("#9BC2E6")

            .RowHeadersVisible = False
        End With
    End Sub

    Public Sub BLKGrande(grid As DataGridView)
        With grid
            ' Set the selection background color for all the cells.
            .DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#52A8E3")
            .DefaultCellStyle.SelectionForeColor = Color.Black  'Convertir Hex a tipo Color

            ' Set RowHeadersDefaultCellStyle.SelectionBackColor so that its default
            ' value won't override DataGridView.DefaultCellStyle.SelectionBackColor.

            ' Set the background color for all rows and for alternating rows. 
            ' The value for alternating rows overrides the value for all rows. 
            .RowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#CCCCCC")
            .RowsDefaultCellStyle.Font = New Font("Tahoma", 12.0F, FontStyle.Regular)
            .AlternatingRowsDefaultCellStyle.BackColor = Color.White

            ' Set the row and column header styles.
            .ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            .ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#39373A")
            .ColumnHeadersDefaultCellStyle.Font = New Font("Tahoma", 12.0F, FontStyle.Bold)
            '.RowHeadersDefaultCellStyle.BackColor = Color.Black
            .EnableHeadersVisualStyles = False
            .GridColor = ColorTranslator.FromHtml("#ffffff")

            .RowHeadersVisible = False
        End With
    End Sub

    Public Sub SearchMaterial(grid As DataGridView)
        With grid
            ' Set the selection background color for all the cells.
            .DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#52A8E3")
            .DefaultCellStyle.SelectionForeColor = Color.Black  'Convertir Hex a tipo Color

            ' Set RowHeadersDefaultCellStyle.SelectionBackColor so that its default
            ' value won't override DataGridView.DefaultCellStyle.SelectionBackColor.

            ' Set the background color for all rows and for alternating rows. 
            ' The value for alternating rows overrides the value for all rows. 
            .RowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#CCCCCC")
            .RowsDefaultCellStyle.Font = New Font("Arial", 16.0F, FontStyle.Bold)
            .AlternatingRowsDefaultCellStyle.BackColor = Color.White
            .RowsDefaultCellStyle.ForeColor = Color.White

            ' Set the row and column header styles.
            .ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            .ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#39373A")
            .ColumnHeadersDefaultCellStyle.Font = New Font("Arial", 12.0F, FontStyle.Bold)
            '.RowHeadersDefaultCellStyle.BackColor = Color.Black
            .EnableHeadersVisualStyles = False
            .GridColor = ColorTranslator.FromHtml("#ffffff")

            .RowHeadersVisible = False
        End With
    End Sub
End Class
