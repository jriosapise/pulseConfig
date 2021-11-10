Imports System.Web


Public Class Etiquetas_Carta
    Dim pVacio As String
    Dim pPic1 As String
    Dim pPic2 As String
    Dim pPic3 As String
    Dim pPic4 As String
    Dim pPic5 As String
    Dim pPic6 As String
    Dim pPic7 As String
    Dim pPic8 As String
    Dim pPic9 As String
    Dim pPic10 As String
    Dim pEpp1 As String
    Dim pEpp2 As String
    Dim pEpp3 As String
    Dim pEpp4 As String
    Dim pEpp5 As String
    Dim pEpp6 As String
    Dim pEpp7 As String
    Dim pEpp8 As String
    Dim picto01 As String
    Dim picto02 As String
    Dim picto03 As String
    Dim picto04 As String
    Dim picto05 As String
    Dim picto06 As String
    Dim picto07 As String
    Dim picto08 As String
    Dim picto09 As String
    Dim picto10 As String
    Dim picto11 As String
    Dim picto12 As String
    Dim picto13 As String
    Dim picto14 As String
    Dim picto15 As String
    
    Private Sub Etiquetas_Carta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Main
    End Sub
    Private Sub cargarRutasDeImagenes()
        pVacio = "C:/Apise/GHSA/Gestion/pics/pic_Empty.png"
        pPic1 = "C:/Apise/GHSA/Gestion/pics/pic_SGA_08.png"
        pPic2 = "C:/Apise/GHSA/Gestion/pics/pic_SGA_07.png"
        pPic3 = "C:/Apise/GHSA/Gestion/pics/pic_SGA_05.png"
        pPic4 = "C:/Apise/GHSA/Gestion/pics/pic_SGA_06.png"

        pPic5 = "C:/Apise/GHSA/Gestion/pics/pic_SGA_02.png"

        pPic6 = "C:/Apise/GHSA/Gestion/pics/pic_SGA_03.png"
        pPic7 = "C:/Apise/GHSA/Gestion/pics/pic_SGA_05.png"
        pPic8 = "C:/Apise/GHSA/Gestion/pics/pic_SGA_01.png"
        pPic9 = "C:/Apise/GHSA/Gestion/pics/pic_SGA_04.png"
        pPic10 = "C:/Apise/GHSA/Gestion/pics/pic_SGA_09.png"





        pEpp1 = "C:/Apise/GHSA/Gestion/pics/pic_ppe_01.png"
        pEpp2 = "C:/Apise/GHSA/Gestion/pics/pic_ppe_02.png"
        pEpp3 = "C:/Apise/GHSA/Gestion/pics/pic_ppe_03.png"
        pEpp4 = "C:/Apise/GHSA/Gestion/pics/pic_ppe_04.png"
        pEpp5 = "C:/Apise/GHSA/Gestion/pics/pic_ppe_05.png"
        pEpp6 = "C:/Apise/GHSA/Gestion/pics/pic_ppe_06.png"
        pEpp7 = "C:/Apise/GHSA/Gestion/pics/pic_ppe_07.png"
        pEpp8 = "C:/Apise/GHSA/Gestion/pics/pic_ppe_08.png"

        picto01 = pVacio
        picto02 = pVacio
        picto03 = pVacio
        picto04 = pVacio
        picto05 = pVacio
        picto06 = pVacio
        picto07 = pVacio
        picto08 = pVacio
        picto09 = pVacio
        picto10 = pVacio
        picto11 = pVacio
        picto12 = pVacio
        picto13 = pVacio
        picto14 = pVacio
        picto15 = pVacio
    End Sub
    Public Sub llenarManifiesto()
        Try
            Dim filetoOpen As String = "GHSA_App.Etiquetas_Carta_50_200.rdlc"
            cargarRutasDeImagenes()
            Dim dts As DataSet
            Dim Folio As String
            ReportViewer1.LocalReport.ReportEmbeddedResource = filetoOpen
            Me.ReportViewer1.RefreshReport()
            ReportViewer1.Reset()
            Dim rds1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource

            rds1.Name = "sga_vw_Etiquetas"
            dts = dtsDetalles()

            If dts.Tables(0).Rows.Count > 0 Then

                For Each row As DataRow In dts.Tables(0).Rows
                    Folio = row("lbl_id")
                Next
                rds1.Value = dts.Tables(0)

                Dim rp01 As New Microsoft.Reporting.WinForms.ReportParameter("Picto01", New Uri(picto01).AbsolutePath)
                Dim rp02 As New Microsoft.Reporting.WinForms.ReportParameter("Picto02", New Uri(picto02).AbsolutePath)
                Dim rp03 As New Microsoft.Reporting.WinForms.ReportParameter("Picto03", New Uri(picto03).AbsolutePath)
                Dim rp04 As New Microsoft.Reporting.WinForms.ReportParameter("Picto04", New Uri(picto04).AbsolutePath)
                Dim rp05 As New Microsoft.Reporting.WinForms.ReportParameter("Picto05", New Uri(picto05).AbsolutePath)
                Dim rp06 As New Microsoft.Reporting.WinForms.ReportParameter("Picto06", New Uri(picto06).AbsolutePath)
                Dim rp07 As New Microsoft.Reporting.WinForms.ReportParameter("Picto07", New Uri(picto07).AbsolutePath)
                Dim rp08 As New Microsoft.Reporting.WinForms.ReportParameter("Picto08", New Uri(picto08).AbsolutePath)
                Dim rp09 As New Microsoft.Reporting.WinForms.ReportParameter("Picto09", New Uri(picto09).AbsolutePath)
                Dim rp10 As New Microsoft.Reporting.WinForms.ReportParameter("Picto10", New Uri(picto10).AbsolutePath)
                Dim rp11 As New Microsoft.Reporting.WinForms.ReportParameter("Picto11", New Uri(picto11).AbsolutePath)
                Dim rp12 As New Microsoft.Reporting.WinForms.ReportParameter("Picto12", New Uri(picto12).AbsolutePath)
                Dim rp13 As New Microsoft.Reporting.WinForms.ReportParameter("Picto13", New Uri(picto13).AbsolutePath)
                Dim rp14 As New Microsoft.Reporting.WinForms.ReportParameter("Picto14", New Uri(picto14).AbsolutePath)
                Dim rp15 As New Microsoft.Reporting.WinForms.ReportParameter("Picto15", New Uri(picto15).AbsolutePath)

                ReportViewer1.LocalReport.DataSources.Clear()
                ReportViewer1.LocalReport.DataSources.Add(rds1)

                ReportViewer1.LocalReport.ReportEmbeddedResource = filetoOpen

                ReportViewer1.LocalReport.EnableExternalImages = True

                ReportViewer1.LocalReport.SetParameters(rp01)
                ReportViewer1.LocalReport.SetParameters(rp02)
                ReportViewer1.LocalReport.SetParameters(rp03)
                ReportViewer1.LocalReport.SetParameters(rp04)
                ReportViewer1.LocalReport.SetParameters(rp05)
                ReportViewer1.LocalReport.SetParameters(rp06)
                ReportViewer1.LocalReport.SetParameters(rp07)
                ReportViewer1.LocalReport.SetParameters(rp08)
                ReportViewer1.LocalReport.SetParameters(rp09)
                ReportViewer1.LocalReport.SetParameters(rp10)
                ReportViewer1.LocalReport.SetParameters(rp11)
                ReportViewer1.LocalReport.SetParameters(rp12)
                ReportViewer1.LocalReport.SetParameters(rp13)
                ReportViewer1.LocalReport.SetParameters(rp14)
                ReportViewer1.LocalReport.SetParameters(rp15)
                ReportViewer1.RefreshReport()



            End If
        Catch ex As Exception
            MsgBox("Error al generar vista previa. Asegurarse que al menos haya seleccionado un pictograma." & ex.Message)
        End Try


    End Sub
    Dim campo01, campo02, campo03, campo04, campo05, campo06, campo07, campo08, campo09 As String
    Dim campo10, campo11, campo12, campo13, campo14, campo15, campo16, campo17, campo18 As String
    Function dtsDetalles() As DataSet
        Dim registros As New Consulta

        dtsDetalles = registros.SelToGridWhere("top (1) *",
                         "sga_vw_Etiquetas", "lbl_id=" & add_Labels.txtID.Text)

        If dtsDetalles.Tables(0).Rows.Count > 0 Then
            For Each row As DataRow In dtsDetalles.Tables(0).Rows
                'AZULES
                If Not IsDBNull(row("lbl_PictoSalud_Salud")) Then
                    campo01 = row("lbl_PictoSalud_Salud")
                Else
                    campo01 = False
                End If
                If Not IsDBNull(row("lbl_PictoSalud_Nocivo")) Then
                    campo02 = row("lbl_PictoSalud_Nocivo")
                Else
                    campo02 = False
                End If
                If Not IsDBNull(row("lbl_PictoFisico_Corrosivos")) Then
                    campo03 = row("lbl_PictoFisico_Corrosivos")
                Else
                    campo03 = False
                End If
                If Not IsDBNull(row("lbl_PictoSalud_Toxicidad")) Then
                    campo04 = row("lbl_PictoSalud_Toxicidad")
                Else
                    campo04 = False
                End If


                'SOLO
                If Not IsDBNull(row("lbl_PictoFisico_Inflamable")) Then
                    campo05 = row("lbl_PictoFisico_Inflamable")
                Else
                    campo05 = False
                End If


                'AMARILLOS
                If Not IsDBNull(row("lbl_PictoFisico_Comburente")) Then
                    campo06 = row("lbl_PictoFisico_Comburente")
                Else
                    campo06 = False
                End If
                If Not IsDBNull(row("lbl_PictoFisico_Explosivos")) Then
                    campo07 = row("lbl_PictoFisico_Explosivos")
                Else
                    campo07 = False
                End If
                If Not IsDBNull(row("lbl_PictoFisico_Gases")) Then
                    campo08 = row("lbl_PictoFisico_Gases")
                Else
                    campo08 = False
                End If
                If Not IsDBNull(row("lbl_Picto_Corrosivos2")) Then
                    campo18 = row("lbl_Picto_Corrosivos2")
                Else
                    campo18 = False
                End If
                If Not IsDBNull(row("lbl_PictoEnviro_Ambiente")) Then
                    campo09 = row("lbl_PictoEnviro_Ambiente")
                Else
                    campo09 = False
                End If


                campo10 = row("lbl_PictoEPP_Gafas")
                campo11 = row("lbl_PictoEPP_Googles")
                campo12 = row("lbl_PictoEPP_Cubreboca")
                campo13 = row("lbl_PictoEPP_Careta")
                campo14 = row("lbl_PictoEPP_Guantes")
                campo15 = row("lbl_PictoEPP_Guant_Carnaza")
                campo16 = row("lbl_PictoEPP_cubreboca_Filtro")
                campo17 = row("lbl_PictoEPP_Mandil")


                If campo01 = True Then
                    AgregarRuta_Pictograma_Azules(pPic1)
                End If
                If campo02 = True Then
                    AgregarRuta_Pictograma_Azules(pPic2)
                End If
                If campo03 = True Then
                    AgregarRuta_Pictograma_Azules(pPic3)
                End If
                If campo04 = True Then
                    AgregarRuta_Pictograma_Azules(pPic4)
                End If

                If campo05 = True Then
                    picto05 = pPic5
                End If

              
                If campo06 = True Then
                    AgregarRuta_Pictograma_Amarillos(pPic6)
                End If
                If campo07 = True Then
                    AgregarRuta_Pictograma_Amarillos(pPic7)
                End If
                If campo08 = True Then
                    AgregarRuta_Pictograma_Amarillos(pPic8)
                End If
                If campo18 = True Then
                    AgregarRuta_Pictograma_Amarillos(pPic9)
                End If
                If campo09 = True Then
                    AgregarRuta_Pictograma_Amarillos(pPic10)
                End If

                If campo10 = True Then
                    AgregarRuta_Pictograma_EPP(pEpp1)
                End If
                If campo11 = True Then
                    AgregarRuta_Pictograma_EPP(pEpp2)
                End If
                If campo12 = True Then
                    AgregarRuta_Pictograma_EPP(pEpp3)
                End If
                If campo13 = True Then
                    AgregarRuta_Pictograma_EPP(pEpp4)
                End If
                If campo14 = True Then
                    AgregarRuta_Pictograma_EPP(pEpp5)
                End If
                If campo15 = True Then
                    AgregarRuta_Pictograma_EPP(pEpp6)
                End If
                If campo16 = True Then
                    AgregarRuta_Pictograma_EPP(pEpp7)
                End If
                If campo17 = True Then
                    AgregarRuta_Pictograma_EPP(pEpp8)
                End If

            Next
        End If
        Return dtsDetalles
    End Function
    Private Sub AgregarRuta_Pictograma_Amarillos(Pictograma As String)
        If picto06 = pVacio Then
            picto06 = Pictograma
        Else
            If picto07 = pVacio Then
                picto07 = Pictograma
            Else
                If picto08 = pVacio Then
                    picto08 = Pictograma
                Else
                    If picto14 = pVacio Then
                        picto14 = Pictograma
                    Else
                        If picto15 = pVacio Then
                            picto15 = Pictograma
                        End If
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub AgregarRuta_Pictograma_Azules(Pictograma As String)
        If picto01 = pVacio Then
            picto01 = Pictograma
        Else
            If picto02 = pVacio Then
                picto02 = Pictograma
            Else
                If picto03 = pVacio Then
                    picto03 = Pictograma
                Else
                    If picto04 = pVacio Then
                        picto04 = Pictograma
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub AgregarRuta_Pictograma_EPP(Pictograma As String)
        If picto09 = pVacio Then
            picto09 = Pictograma
        Else
            If picto10 = pVacio Then
                picto10 = Pictograma
            Else
                If picto11 = pVacio Then
                    picto11 = Pictograma
                Else
                    If picto12 = pVacio Then
                        picto12 = Pictograma
                    Else
                        If picto13 = pVacio Then
                            picto13 = Pictograma
                        End If
                    End If
                End If
            End If
        End If
    End Sub
End Class