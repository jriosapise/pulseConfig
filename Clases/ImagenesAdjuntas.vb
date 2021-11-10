Public Class ImagenesAdjuntas
    Public Function regresarUltimoImagenId() As Integer
        Try
            Dim dts As DataSet

            Dim qry As New Consulta



            Dim ultimoId As String = qry.SelToGridSingle("MAX(ctg_id) AS ultimo", "cat_materiales")

            Return ultimoId

        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function regresarImagenIdExitente(producto As Integer, ruta As String) As Integer
        Try
            Dim dts As DataSet

            Dim qry As New Consulta



            Dim idExistente As String = qry.SelToGridWhereSingle("ctg_id", "cat_materiales", "Fotografia'" & ruta & "'")

            Return idExistente

        Catch ex As Exception
            Throw
        End Try
    End Function
End Class
