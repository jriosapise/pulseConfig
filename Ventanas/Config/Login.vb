Imports System.Globalization
Imports System.Configuration

Public Class Login

    Dim _usr As New usuarios
    Private _FormatoFecha As New IO.DirectoryInfo(ConfigurationSettings.AppSettings("FormatoFecha"))
    Private _FormatoFechaDB As New IO.DirectoryInfo(ConfigurationSettings.AppSettings("FormatoFechaDB"))
    Public usrId As String

    Dim pass, rol, name, area, apellido, foto As String
    Dim _sist As New LogsdeSistema
    Public Sub obtenerUsuarioInfo()
        Dim _hoy As String = Format(Now.ToString(_FormatoFechaDB.ToString))
        Dim mensaje, codigo As String
        Dim ErrorCode As String = "4001"

        Dim dts As DataSet
        Dim qry As New Consulta



        Dim OK As Boolean = False
        pass = tPassword.Text
        'tPassword.Text Then
        Try
            dts = qry.SelToGridWhere("usr_Id,usr_password,usr_Name,fk_id_Rol,usr_LastName,usr_Foto", "a_SystUsuarios", "usr_login='" & tUserName.Text & "' and usr_Active='TRUE'")
            If dts.Tables(0).Rows.Count > 0 Then
                For Each row As DataRow In dts.Tables(0).Rows
                    pass = row("usr_password")
                    If pass = _usr.stringToMd4(tPassword.Text) Then
                        'tPassword.Text Then

                        OK = True
                        usrId = row("usr_Id")
                        rol = row("fk_id_Rol")
                        name = row("usr_Name")
                        apellido = row("usr_LastName")
                        If Not IsDBNull(row("usr_Foto")) Then
                            foto = row("usr_Foto")
                        End If
                    End If
                Next
            End If
            If OK Then

                _sist.crearSesion(usrId, name)

                If rol <= 4 Then 'ROL 3 ES OPERADOR

                    Main.tUserId.Text = usrId
                    Main.tUserName.Text = name & " " & apellido
                    Main.GunaNombre.Text = name & " " & apellido
                    Main.tFoto.Text = foto
                    If rol = 1 Then
                        Main.tUserRol.Text = "Gerente"
                    ElseIf rol = 2 Then
                        Main.tUserRol.Text = "Supervisor"
                    ElseIf rol = 4 Then
                        Main.tUserRol.Text = "Administrador"
                    End If
                    Main.Show()
                    Main.cargarFoto()




                    Me.Visible = False

                    Try
                        '_sistema.iniciarSesion(usrId)
                    Catch ex As Exception
                        MsgBox("Error al crear log del Inicio de Sesion. Detalle: " & ex.Message)
                    End Try


                    tUserName.Text = ""
                    tPassword.Text = ""

                Else
                    MsgBox("Este usuario no tiene privilegios para usar esta aplicación.")
                    tUserName.Text = ""
                    tPassword.Text = ""
                End If

               
            Else
                MsgBox("Usuario o contraseña incorrecta.")
                tUserName.Text = ""
                tPassword.Text = ""
                tPassword.Focus()
            End If

        Catch ex As Exception
            mensaje = "Error al obtener detalles de usuario!. " & ex.Message & " ErrorNo: " & ErrorCode
            MsgBox(mensaje, MsgBoxStyle.Critical)
            crearLog(_hoy, Me.Text, "Error", ErrorCode, mensaje) 'Se crea registro en log del sistema
        End Try

    End Sub

    Public Sub crearLog(fecha As Date, modulo As String, accion As String, codigo As String, detalle As String)
        Dim insertar As New Consulta 'variable para hacer el query a la database
        Try
            insertar.InsertarDatos("log_Date,log_User,log_Module,log_Action,log_Code,log_Detail", "" &
            "'" & fecha & "','LOGIN','" & modulo & "','" & accion & "','" & codigo & "','" & detalle.Replace("'", "''") & "'", "sist_Log")
        Catch ex As Exception

        End Try
    End Sub

    Public Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Len(tUserName.Text) > 0 And Len(tPassword.Text) > 0 Then
            obtenerUsuarioInfo()
        Else
            MsgBox("UserName or Password cannot be empty")
            tPassword.Text = ""
            tUserName.Text = ""
            tUserName.Focus()

        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Public Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub tPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles tPassword.KeyDown
        If e.KeyCode = Keys.Enter Then

            If Len(tUserName.Text) > 0 And Len(tPassword.Text) > 0 Then
                obtenerUsuarioInfo()

            Else
                MsgBox("UserName or Password cannot be empty")
                tPassword.Text = ""
                tUserName.Text = ""
                tUserName.Focus()

            End If


        End If

    End Sub

    Private Sub Login_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Alt And e.KeyCode = Keys.M Then
            AppIniciar.ShowDialog()

        End If
    End Sub

End Class