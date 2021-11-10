Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Data
Imports System.Globalization
Imports System.Configuration


Public Class frmusuarios
    Dim _grid As New DatagridFormat
    Private Sub usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Main
        columnasGrid(GunaDataGridView1)
        CargarDatos()
        _grid.formatto(GunaDataGridView1)
    End Sub
    Sub columnasGrid(grid1 As DataGridView)
        With grid1
            .ColumnCount = 13  'Total de columnas
            .Columns(0).Name = "ID" 'Nombre de columnas
            .Columns(1).Name = "Login"
            .Columns(2).Name = "Nombre"
            .Columns(3).Name = "Apellido"
            .Columns(4).Name = "Telefono"
            .Columns(5).Name = "Número de empleado"
            .Columns(6).Name = "FKPLANTA"
            .Columns(7).Name = "Nombre planta"
            .Columns(8).Name = "FKTIPORESIDUO"
            .Columns(9).Name = "Tipo de residuo"
            .Columns(10).Name = "usr_Foto"
            .Columns(11).Name = "FKRol"
            .Columns(12).Name = "Rol"

            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .Columns(0).Visible = False 'Esta opcion es para ocualtar las columnas '
            .Columns(6).Visible = False
            .Columns(8).Visible = False
            .Columns(10).Visible = False
            .Columns(11).Visible = False

        End With
    End Sub
    Sub CargarDatos()
        GunaDataGridView1.Rows.Clear()

        Try

        
        Dim dts1 As DataSet
        Dim cargar As New Consulta
        'MODIFICAR EL SELTOGRIDWHERE
            dts1 = cargar.SelToGridWhere("usr_Id, usr_login, usr_Name, usr_LastName, usr_MobileNumber, num_empleado, fk_Planta, descripcion, fk_TipoResiduo, res_nombre, usr_Foto,fk_id_Rol,rol_Desc",
                                         "vw_Usuarios", "rol_Desc <> 'Operador' And usr_Name like '%" & txtbuscador.Text & "%' OR rol_Desc <> 'Operador' and num_empleado like '%" & txtbuscador.Text & "%'")
        '"prov_id > 0  AND Nombre like '%" & txtBuscador.Text & "%' OR Permiso LIKE '%" & txtBuscador.Text & "%'")
        ' If dts1.Tables(0).Rows.Count > 0 Then
        For Each row As DataRow In dts1.Tables(0).Rows
            ' MessageBox.Show(row("tra_Nombre"))
            GunaDataGridView1.Rows.Add(row("usr_Id"), row("usr_login"), row("usr_Name"), row("usr_LastName"), row("usr_MobileNumber"), row("num_empleado"), row("fk_Planta"), row("descripcion"), row("fk_TipoResiduo"), row("res_nombre"), row("usr_Foto"), row("fk_id_Rol"), row("rol_Desc"))
        Next
            '  End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub GunaDataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub GunaGradientCircleButton1_Click(sender As Object, e As EventArgs)
        Dim frm As New frmRegistrodeUsuarios
        frm.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim frm As New frmRegistrodeUsuarios
        frm.ShowDialog()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub GunaImageButton1_Click(sender As Object, e As EventArgs)
        CargarDatos()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim frm As New frmRegistrodeUsuarios
        frm.CargarCombos()
        frm.ShowDialog()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        CargarDatos()
    End Sub

    Private Sub txtbuscador_TextChanged(sender As Object, e As EventArgs) Handles txtbuscador.TextChanged

    End Sub

    Private Sub GunaDataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GunaDataGridView1.CellContentClick
        Dim frm As New frmRegistrodeUsuarios
        Dim usr_Id As Integer
        Dim usr_login As String
        Dim usr_Name As String
        Dim usr_LastName As String
        Dim usr_MobileNumber As String
        Dim num_empleado As String
        Dim fk_Planta As Integer
        Dim fk_TipoResiduo As Integer
        Dim fotoGr As String

        Dim fkrol As Integer

        Dim i As Integer
        i = GunaDataGridView1.CurrentRow.Index
        usr_Id = GunaDataGridView1.Item(0, i).Value
        usr_login = GunaDataGridView1.Item(1, i).Value
        usr_Name = GunaDataGridView1.Item(2, i).Value
        usr_LastName = GunaDataGridView1.Item(3, i).Value
        usr_MobileNumber = GunaDataGridView1.Item(4, i).Value
        num_empleado = GunaDataGridView1.Item(5, i).Value
        fk_Planta = GunaDataGridView1.Item(6, i).Value
        fk_TipoResiduo = GunaDataGridView1.Item(8, i).Value
        fkrol = GunaDataGridView1.Item(11, i).Value


        If Not IsDBNull(GunaDataGridView1.Item(10, i).Value) Then
            fotoGr = GunaDataGridView1.Item(10, i).Value
        Else
            fotoGr = ""
        End If

        frm.Datos(usr_Id, usr_login, usr_Name, usr_LastName, usr_MobileNumber, num_empleado, fk_Planta, fk_TipoResiduo, fotoGr, fkrol)
        frm.ShowDialog()
    End Sub

    Private _rutaexportar As New IO.DirectoryInfo(ConfigurationSettings.AppSettings("rutaExportar"))

    Sub exportExcel()
        Try
            'USAR SEGUN APLIQUE
            ProgressBar1.Visible = True
            Dim ex As New exportar_a_Excel
            Dim nombre As String = DateTime.Now.ToString("yyyy.MM.dd")
            nombre = nombre & " - Listado de Usuarios"
            Dim dgv As DataGridView = GunaDataGridView1



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

    'Private _rutaexportar As New IO.DirectoryInfo(ConfigurationSettings.AppSettings("Adjuntos_RutaExportar"))



    Private Sub ReleaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        exportExcel()

    End Sub




End Class