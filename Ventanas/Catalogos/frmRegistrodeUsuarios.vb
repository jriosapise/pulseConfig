Imports System.Configuration

Public Class frmRegistrodeUsuarios

    Private _imagefolder As New IO.DirectoryInfo(ConfigurationSettings.AppSettings("imagenesUser"))
    Private _imgDefID As New IO.DirectoryInfo(ConfigurationSettings.AppSettings("imgDefault"))
    Dim _eti As New Etiquetas


    Dim _usr As New usuarios

    Private Sub CrearUsuario()
        Dim insertar As New Consulta
        Try
            insertar.InsertarDatos("usr_login, usr_password, usr_Name, usr_LastName, usr_MobileNumber, usr_Active, fk_id_Rol, num_empleado, fk_Planta, fk_TipoResiduo",
  "'" & txtrango.Text & "','" & _usr.stringToMd4(txtpassword.Text) & "','" & txtNombre.Text & "', " & _
  "'" & txtApellido.Text & "','" & txtTel.Text & "','" & 1 & "', '" & cbRoles.SelectedValue & "','" & txtNumeroEmpleado.Text & "'," & _
  "'" & cmbPlanta.SelectedValue & "','" & cmbArea.SelectedValue & "'", "tab_SystUsuarios")
            'MsgBox("SE CREO USUARIO CORRECTAMENTE")
            _eti.NotificacionGuardado()
            txtId.Text=getLastId 
        Catch ex As Exception
            MsgBox("Error al guardar: ", ex.Message)
        End Try
    End Sub

    Dim _qry As New Consulta


    Function getLastId() As Integer

        'Dim _qry As New Consulta
        Dim valor As String
        Dim id As Integer
       
        Try
            valor = _qry.SelToGridWhereSingle("top 1 usr_Id", "tab_SystUsuarios", "usr_Id>0 order by usr_Id desc")
            id = valor
            Return id
           
        Catch ex As Exception
            MsgBox("Error al traer ultimo Id: " & ex.Message)
        End Try
    End Function
    Sub Datos(usr_Id As Integer, usr_login As String, usr_Name As String, usr_LastName As String, usr_MobileNumber As String,
        num_empleado As String, fk_Planta As Integer, fk_TipoResiduo As Integer, fotoGr As String, fkrol As Integer)

        CargarCombos()

        txtId.Text = usr_Id
        txtrango.Text = usr_login
        GunaLabel3.Visible = False
        txtpassword.Enabled = False
        txtpassword.Visible = False
        txtNombre.Text = usr_Name
        txtApellido.Text = usr_LastName
        txtTel.Text = usr_MobileNumber
        txtNumeroEmpleado.Text = num_empleado
        cmbPlanta.SelectedValue = fk_Planta
        cmbArea.SelectedValue = fk_TipoResiduo
        cbRoles.SelectedValue = fkrol

        If Not fotoGr = "" Then
            PictureBox1.ImageLocation = _imagefolder.FullName & "\" & fotoGr
        Else
            PictureBox1.ImageLocation = _imagefolder.FullName & "\" & _imgDefID.ToString
        End If

    End Sub
    Sub Guardar()
        Dim actulizar As New Consulta
        Try
            actulizar.ActulizarGral("tab_SystUsuarios", "usr_login= '" & txtrango.Text & "" & _
            "',usr_Name = '" & txtNombre.Text & "',usr_LastName = '" & txtApellido.Text & "' ,usr_MobileNumber = '" & txtTel.Text & "' ,fk_Planta = '" & cmbPlanta.SelectedValue & "' ,fk_TipoResiduo = '" & cmbArea.SelectedValue & "',fk_id_Rol = '" & cbRoles.SelectedValue & "'", "usr_Id =" & txtId.Text)
            CargarCombos()

            _eti.NotificacionGuardado()
            'MsgBox("Actualizado exitosamente")
        Catch ex As Exception
            MsgBox("Error al guardar: ", ex.Message)
        End Try
    End Sub

    Private Sub frmRegistrodeUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.MdiParent = MainMenu
        If txtId.Text.Length > 0 Then
            btnImg.Visible = True
            PictureBox1.Visible = True
            btnCambiarcontra.Visible = True
            ActualizarContrasena.txid.Text = txtId.Text
            txtpassword.Visible = False
            'CargarCombos()

        Else
            btnCambiarcontra.Visible = False
            btnImg.Visible = False
            PictureBox1.Visible = False
        End If
    End Sub
    Sub ActualizarContras()
        Dim actulizar As New Consulta
        Try
            actulizar.ActulizarGral("tab_SystUsuarios", " usr_password = '" & _usr.stringToMd4(txtpassword.Text) & "'",
           "usr_Id =" & txtId.Text)
            CargarCombos()
            MsgBox("Actualizado exitosamente")
        Catch ex As Exception
            MsgBox("Error al actualizar: ", ex.Message)
        End Try
    End Sub
    'Private Sub Cambiarcontra_Click(sender As Object, e As EventArgs)
    '    ActualizarContrasena.Show()
    'End Sub
    Sub Eliminar()
        Dim eliminar As New Consulta
        Try
            eliminar.EliminarDatos("tab_SystUsuarios", "usr_Id =" & txtId.Text)
            MsgBox("se elimino correctamente")
        Catch ex As Exception
            MsgBox("no se elimino correctamente" & ex.Message)
        End Try
    End Sub
    'Private Sub Button1_Click(sender As Object, e As EventArgs)
    '    Eliminar()
    '    frmusuarios.CargarDatos()
    '    Me.Close()
    'End Sub


    Sub CargarCombos()

        Try
            Dim dts As DataSet
            Dim cargar As New Consulta
            'Dim i As Integer
            'i = frmusuarios.GunaDataGridView1.CurrentRow.Index
            dts = cargar.SelToGridWhere("id, descripcion", "tab_planta", "id > 0")
            cmbPlanta.DataSource = dts.Tables(0)
            cmbPlanta.DisplayMember = dts.Tables(0).Columns(1).Caption.ToString
            cmbPlanta.ValueMember = dts.Tables(0).Columns(0).Caption.ToString

      


            'cmbPlanta.SelectedValue = frmusuarios.GunaDataGridView1.Item(6, i).Value

            dts = cargar.SelToGridWhere("res_id, res_nombre", "tab_tiporesiduo", "res_id > 0")
            cmbArea.DataSource = dts.Tables(0)
            cmbArea.DisplayMember = dts.Tables(0).Columns(1).Caption.ToString
            cmbArea.ValueMember = dts.Tables(0).Columns(0).Caption.ToString

            'cmbArea.SelectedValue = frmusuarios.GunaDataGridView1.Item(8, i).Value





            dts = cargar.SelToGridWhere("rol_Id, rol_Desc", "tab_SystRolesUsuario", "rol_Id =2 or rol_Id =5")
            cbRoles.DataSource = dts.Tables(0)
            cbRoles.DisplayMember = dts.Tables(0).Columns(1).Caption.ToString
            cbRoles.ValueMember = dts.Tables(0).Columns(0).Caption.ToString

            'cbRoles.SelectedValue = frmusuarios.GunaDataGridView1.Item(11, i).Value
        Catch ex As Exception
            MsgBox("Error al cargar combo box: " & ex.Message)
        End Try


    End Sub


    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles txtrango.TextChanged

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtId.Text.Length > 0 Then
            Guardar()
            frmusuarios.CargarDatos()

            'Me.Close()
        Else
            CrearUsuario()
            frmusuarios.CargarDatos()
            'Me.Close()
        End If

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Eliminar()
        frmusuarios.CargarDatos()
        Me.Close()
    End Sub

    Private Sub btnCambiarcontra_Click(sender As Object, e As EventArgs) Handles btnCambiarcontra.Click
        ActualizarContrasena.Show()

    End Sub


    Dim _imagenes As New ImagenesAdjuntas
    Public formularioaregresar As String
    Private _AlmacenCls As New AlmacenCls
    Dim foto As String
    Sub cambiarFoto()
        Dim ruta_actual As String = PictureBox1.ImageLocation
        Dim fotoAdjunta As Boolean
        Dim _qry As New Consulta
        If ruta_actual <> "" Then
            fotoAdjunta = True
        Else
            fotoAdjunta = False
        End If

        fdImageDialog.Filter = "Image Files (*.jpg)|*.jpg"

        Dim res As DialogResult = fdImageDialog.ShowDialog()

        If res <> Windows.Forms.DialogResult.Cancel Then
            If fotoAdjunta Then
                Try

                    If ruta_actual <> _imagefolder.ToString & "\" & _imgDefID.ToString Then
                        'Dim a As String = MainMenu.txtUserIdMenu.Text
                        'If txtId.Text = MainMenu.txtUserIdMenu.Text Then
                        '    MainMenu.tFoto.Text = _imgDefID.ToString
                        '    MainMenu.cargarFoto()
                        'Else
                        '    System.IO.File.Delete(ruta_actual)
                        'End If
                    End If


                Catch ex As Exception
                    MsgBox("Error al eliminar imagen de usuario existente: Error " & ex.Message.ToString)

                End Try



                Try
                    'Se crea el ID para el Nombre del Archivo
                    Dim eqId As Integer = txtId.Text
                    Dim carpetaProducto As String = eqId.ToString("D4")

                    'una vez que seleciono el archivo obtiene su informacion
                    Dim selectedfile As New IO.FileInfo(fdImageDialog.FileName)



                    'si el directorio default no existe lo crea
                    If Not IO.Directory.Exists(_imagefolder.FullName) Then
                        IO.Directory.CreateDirectory(_imagefolder.FullName)
                    End If

                    'crea la ruta donde se van a guardar las imagenes
                    Dim nuevoNombre As String = carpetaProducto & "-" & selectedfile.Name
                    Dim newpathofimage As String = _imagefolder.FullName & "\" & nuevoNombre



                    Try
                        If System.IO.File.Exists(newpathofimage) = True Then

                            PictureBox1.ImageLocation = newpathofimage

                            'lblimageid.Text = _imagenes.regresarImagenIdExitente(txtId.Text, selectedfile.Name)
                        Else
                            IO.File.Copy(fdImageDialog.FileName, newpathofimage)
                        End If


                        Dim qry As New Consulta

                        qry.ActulizarGral("tab_SystUsuarios", "usr_Foto='" & nuevoNombre & "'", "usr_Id=" & txtId.Text)


                        foto = nuevoNombre


                    Catch ex As Exception
                        MsgBox("Error al guardar la imagen en base de datos , Error " & ex.Message.ToString)
                    End Try

                    Try
                        'muestra la foto en el recuadro
                        PictureBox1.ImageLocation = newpathofimage

                    Catch ex As Exception
                        MsgBox("Error al mostrar imagen, Error " & ex.Message.ToString)
                    End Try

                    PictureBox1.ImageLocation = newpathofimage


                Catch ex As Exception
                    MsgBox("Error al agregar imagen. " & ex.Message.ToString)
                End Try
            End If

        End If
    End Sub


    Private Sub btnImg_Click(sender As Object, e As EventArgs) Handles btnImg.Click
        If txtId.Text.Length >= 0 Then
            cambiarFoto()
            'If txtId.Text = MainMenu.txtUserIdMenu.Text Then
            '    MainMenu.tFoto.Text = foto
            '    MainMenu.cargarFoto()
            'End If
        End If
    End Sub
End Class