Imports System.Globalization

Public Class LogsdeSistema
    Public Sub LogdeWO(fecha As Date, userId As Integer, modulo As String, accion As String, codigo As String, detalle As String)
        Dim insertar As New Consulta 'variable para hacer el query a la database
        Try
            insertar.InsertarDatos("log_Date,log_User,log_Module,log_Action,log_Code,log_Detail", "" & _
            "'" & fecha & "'," & userId & ",'" & modulo & "','" & accion & "','" & codigo & "','" & detalle.Replace("'", "''") & "'", "sist_Log")
        Catch ex As Exception
            Throw
        End Try
    End Sub
    Public Sub LogdeSistema(fecha As Date, usuario As Integer, modulo As String, accion As String, codigo As String, detalle As String)
        Dim insertar As New Consulta 'variable para hacer el query a la database
        Try
            insertar.InsertarDatos("log_Date,log_User,log_Module,log_Action,log_Code,log_Detail", "" & _
            "'" & fecha & "'," & usuario & ",'" & modulo & "','" & accion & "','" & codigo & "','" & detalle.Replace("'", "''") & "'", "sist_Log")
        Catch ex As Exception

        End Try
    End Sub
    Public Sub crearSesion(usrId As Integer, usrName As String)
        Try
            Dim hoy As Date = Format(Now.ToString("f", _
                CultureInfo.CreateSpecificCulture("en-US")))
            Dim _qry As New Consulta

            _qry.InsertarDatos("sesion_creada,sesion_usuario,fk_id_usuario", "'" & hoy & "','" & usrName & "','" & usrId & "'", "tab_SystSesiones")
        Catch ex As Exception
            Throw
        End Try
    End Sub
    Public Sub eliminarSesion(usrId As Integer)
        Try
            Dim _qry As New Consulta
            _qry.EliminarDatos("tab_SystSesiones", "fk_id_usuario=" & usrId)
        Catch ex As Exception
            Throw
        End Try
    End Sub
End Class
