
Imports System.IO
Imports System.Configuration

Public Class add_Labels
    Dim _qry As New Consulta
    Public bandera As Boolean
    Dim _etiquetas As New Etiquetas
    Dim _email As New enviarMail
    Dim _numero As Integer
    Protected Sub cargarCombos(dts As DataSet, cmb As ComboBox, cmbId As String, cmbDesc As String)
        Try
            Dim Table1 As New DataTable
            Table1 = New DataTable("Areas")

            Dim column1 As DataColumn = New DataColumn("id")
            column1.DataType = System.Type.GetType("System.Int32")

            Dim column2 As DataColumn = New DataColumn("Desc")
            column2.DataType = System.Type.GetType("System.String")

            Table1.Columns.Add(column1)
            Table1.Columns.Add(column2)


            Dim Row1 As DataRow
            Dim cargador As String


            Row1 = Table1.NewRow()
            Row1("id") = 0
            cargador = "Seleccionar"
            Row1("Desc") = cargador

            Table1.Rows.Add(Row1)


            For Each row As DataRow In dts.Tables(0).Rows
                Row1 = Table1.NewRow()
                Row1("id") = row(cmbId)
                cargador = row(cmbDesc)
                Row1("Desc") = cargador

                Table1.Rows.Add(Row1)
            Next
            Dim dtsConcatenado As New DataSet
            dtsConcatenado.Tables.Add(Table1)

            With cmb
                .DataSource = dtsConcatenado.Tables(0)

                .DisplayMember = dtsConcatenado.Tables(0).Columns(1).Caption.ToString.Trim
                .ValueMember = dtsConcatenado.Tables(0).Columns(0).Caption.ToString.Trim
                .SelectedValue = 0
            End With
            
        Catch ex As Exception
            Throw
        End Try
    End Sub
    Private Sub cargarComboDivision()
        Try
            Dim dts As DataSet
            dts = _qry.SelToGridWhere("div_id ,div_Desc", "[sga.cat_Division]", "div_id > 0 order by div_Desc asc")

            dgv.Rows.Clear()

            For Each row As DataRow In dts.Tables(0).Rows
                dgv.Rows.Add("False", row("div_id"), row("div_Desc"))
            Next
        Catch ex As Exception
            MsgBox("Error al cargar Division. " & ex.Message)
        End Try
    End Sub
    Private Sub cargarComboFabricante()
        Try
            Dim dts As DataSet
            dts = _qry.SelToGridWhere("fab_id,fab_Nombre", "[sga.cat_Fabricante]", "fab_id > 0 order by fab_Nombre asc")
            cargarCombos(dts, cmbFabricante, "fab_id", "fab_Nombre")
        Catch ex As Exception
            MsgBox("Error al cargar Fabricante. " & ex.Message)
        End Try
    End Sub
    Private Sub cargarComboclaseRiesgo()
        Try
            Dim dts As DataSet
            dts = _qry.SelToGridWhere("rie_id,rie_Desc", "[sga.cat_claseRiesgo]", "rie_id > 0 order by rie_Desc asc")
            cargarCombos(dts, cmbClaseRiesgo, "rie_id", "rie_Desc")
        Catch ex As Exception
            MsgBox("Error al cargar Riesgos. " & ex.Message)
        End Try
    End Sub

    Private Sub add_Labels_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Main
        Try

        Catch ex As Exception

        End Try
        cargarComboDivision()
        cargarComboFabricante()
        cargarComboclaseRiesgo()
        Try
            DocsRuta = _etiquetas.RutaFotosInstrucciones
        Catch ex As Exception
            MsgBox("Error al cargar ruta de documentos. " & ex.Message)
        End Try

        'AxAcroPDF1.src = "C:\Users\R105\Documents\Empresa Desarrollos\Desarrollos\Vertiv\Proyecto de Quimicos\03 - Diseño (DB, Flujo, Diagramas, Maquetación)\img\Acidonitrico_0.pdf"
        'AxAcroPDF2.src = "C:\Users\R105\Documents\Empresa Desarrollos\Desarrollos\Vertiv\Proyecto de Quimicos\03 - Diseño (DB, Flujo, Diagramas, Maquetación)\img\0040 - Glicina.pdf"
    End Sub
    Public Sub generarNumControl()
        Try
            Dim dts As DataSet
            Dim fecha As Date
            Dim dia As String
            Dim mes As String
            Dim anio As String
            Dim consec As String
            fecha = Now.Date
            mes = fecha.ToString("MM")
            dia = fecha.ToString("yy")
            anio = fecha.ToString("yyyy")
            dts = _qry.SelToGridWhere("top (1) lbl_consecutivo", "[sga.tab_Etiquetas]", "lbl_id>0 order by lbl_consecutivo desc")
            If dts.Tables(0).Rows.Count > 0 Then
                For Each row As DataRow In dts.Tables(0).Rows
                    If Not IsDBNull(row("lbl_consecutivo")) Then
                        consec = row("lbl_consecutivo")
                    Else
                        consec = 0
                    End If
                Next
            Else
                consec = 0
            End If
            
            _numero = consec
            _numero = _numero + 1
            consec = _numero.ToString("D4")

            consec = dia & mes & "-" & consec

            txtNoControl.Text = consec
        Catch ex As Exception
            MsgBox("Errro al obtener numero de control consecutivo. " & ex.Message)
        End Try
    End Sub
    Private Sub gbFiltrar_Click(sender As Object, e As EventArgs) Handles gbFiltrar.Click
        Try
            If txtNoControl.Text.Length > 0 And txtNombre.Text.Length > 0 And txtParte.Text.Length > 0 And
            cmbFabricante.SelectedValue > 0 And cmbClaseRiesgo.SelectedValue > 0 Then
                seleccionarDivisionParaGuardar()
                If SeleccionDeDivision = "" Then
                    MsgBox("La selección de Division no puede quedar vacia.")
                Else
                    If bandera = True Then
                        'TRUE
                        'EL USUARIO QUIERE CREAR NUEVA ETIQUETA
                        crearNuevo()
                        habilitarBotonesMSDS()
                        _etiquetas.NotificacionGuardado()
                        enviarNotificacion()
                        bandera = False
                    Else
                        'FALSE
                        'EL USUARIO QUIERE EDITAR LA ETIQUETA
                        guardarEtiqueta()
                        _etiquetas.NotificacionGuardado()
                        enviarNotificacion()

                    End If
                    validarPictogramasOn()
                End If
              
                

            Else
                MsgBox("No pueden quedar campos vacios")
            End If
        Catch ex As Exception
            MsgBox("Error al Guardar Registro. " & ex.Message)
        End Try


    End Sub
    Private _FormatoFecha As New IO.DirectoryInfo(ConfigurationSettings.AppSettings("FormatoFecha"))
    Private _FormatoFechaDB As New IO.DirectoryInfo(ConfigurationSettings.AppSettings("FormatoFechaDB"))
    Private Sub enviarNotificacion()
        'ENVIAR CORREO
        Try
            Dim evento As String
            If bandera Then
                evento = "Creada"
            Else
                evento = "Modificada"
            End If
            Dim NumControl As String = txtNoControl.Text.Replace("-", " ")
            Dim asunto As String = "Una Etiqueta ha sido " & evento & ""
            Dim para As String = _qry.SelToGridSingle("mail_etiqueta_acciones", "api_Config")
            Dim display As String = "Notificación Automatica de GHS App"
            Dim cnCopia As String = _qry.SelToGridSingle("mail_etiqueta_acciones_CC", "api_Config")
            Dim fecha As Date = Now
            Dim fechaS As String = fecha.ToString(_FormatoFecha.ToString)
            Dim cuerpo As String = "<h2><img style= display: block; margin-left: auto; margin-right: auto; src=https://www.prensariotila.com/Multimedios/imgs/36291_750.jpg alt=https://www.prensariotila.com/Multimedios/imgs/36291_750.jpg width=250  /></h2>" & _
            "<table align='center' border='0' cellpadding='0' cellspacing='0' width='100%'>" & _
            "<tr><td align='center' valign='top'>" & _
            "<table border='0' cellpadding='0' cellspacing='0' width='100%'>" & _
            "<tr><td valign='top' id='templateBody'>" & _
            "<table border='0' cellpadding='0' cellspacing='0' width='100%' class='mcnTextBlock' style='min-width:100%'>" & _
            "<tbody class='mcnTextBlockOuter'>" & _
            "<tr><td valign='top' class='mcnTextBlockInner' style='padding-top:9px'>" & _
            "<table align='left' border='0' cellpadding='0' cellspacing='0' style='max-width:100%;min-width:100%' width='100%' class='mcnTextContentContainer'>" & _
            "<tbody><tr>" & _
            "<td valign='top' class='mcnTextContent' style='padding-top:0;padding-right:18px;padding-bottom:9px;padding-left:18px'>" & _
            "<h1 style='text-align: center'><img src=https://upload.wikimedia.org/wikipedia/commons/thumb/c/c3/GHS-pictogram-exclam.svg/1200px-GHS-pictogram-exclam.svg.png width=30>" & _
            "Notificación de la App para la Gestión de Etiquetas</h1>" & _
            "<br/>" & _
            "<h2>Núm Control " & txtNoControl.Text & " </h2>" & _
            "<h2>Nombre de Químico " & txtNombre.Text & " </h2>" & _
            "<h2>Evento " & evento & " </h2>" & _
            "<h2>Realizado por " & Main.tUserName.Text & " </h2>" & _
            "<p>Fecha " & fechaS & "</p>" & _
            "<hr>" & _
            "<p style='text-align: center'>Este es un correo automatico de la app Gestión de Etiquetas tipo Globally Harmonized System, favor de no responder</p>" & _
            "</td>" & _
            "</tr>" & _
            "</tbody>" & _
            "</table>" & _
            "</td></tr></tbody></table></td></tr><tr><td valign='top' id='templateFooter'></td></tr></table></td></tr></table>"
            _email.EnviodeEmail(asunto, cuerpo, para, display, cnCopia)
            Popup.ShowDialog(Me)
        Catch ex As Exception
            MsgBox("Error al intentar enviar correo. " & ex.Message)
        End Try
    End Sub
    Private Sub crearNuevo()
        Try
            Dim fecha As Date = Now
            Dim fechaS As String = fecha.ToString(_FormatoFechaDB.ToString)
            _qry.InsertarDatos("lbl_numControl,lbl_numParte,lbl_nomQuimico,fk_id_Division,fk_id_Fabricante," & _
            "fk_id_ClaseRiesgo,lbl_NotasEspeciales,lbl_CodigosH,lbl_CodigosP_General,lbl_TelefonodeEmergencia," & _
            "lbl_numCAS,lbl_Folio,lbl_consecutivo,lbl_Activo,lbl_CreadoPor,lbl_CreadoFecha," & _
            "lbl_PictoFisico_Explosivos,lbl_PictoFisico_Inflamable,lbl_PictoFisico_Comburente,lbl_PictoFisico_Gases," & _
            "lbl_PictoFisico_Corrosivos,lbl_PictoSalud_Toxicidad,lbl_PictoSalud_Nocivo,lbl_PictoSalud_Salud,lbl_PictoEnviro_Ambiente," & _
            "lbl_Picto_Corrosivos2,lbl_PictoEPP_Gafas,lbl_PictoEPP_Googles,lbl_PictoEPP_Cubreboca," & _
            "lbl_PictoEPP_Careta,lbl_PictoEPP_Guantes,lbl_PictoEPP_Guant_Carnaza,lbl_PictoEPP_cubreboca_Filtro,lbl_PictoEPP_Mandil,lbl_Otro",
            "'" & txtNoControl.Text & "','" & txtParte.Text & "','" & txtNombre.Text & "'," & _
            "'" & SeleccionDeDivision & "','" & cmbFabricante.SelectedValue & "','" & cmbClaseRiesgo.SelectedValue & "'," & _
            "'" & txtNotas.Text.Replace("'", "''") & "','" & txtNotasH.Text.Replace("'", "''") & "','" & txtCodigosP.Text.Replace("'", "''") & "'," & _
            "'" & txtEmergencia.Text & "','" & txtcas.Text & "','" & txtFolio.Text & "','" & _numero & "','" & chkActivo.Checked & "','" & Main.tUserName.Text & "','" & fechaS & "'," & _
            "'" & chkSGA01.Checked & "','" & chkSGA02.Checked & "','" & chkSGA03.Checked & "','" & chkSGA04.Checked & "','" & chkSGA05.Checked & "','" & chkSGA06.Checked & "'," & _
            "'" & chkSGA07.Checked & "','" & chkSGA08.Checked & "','" & chkSGA09.Checked & "','" & chkSGA10.Checked & "','" & chkEPP01.Checked & "','" & chkEPP02.Checked & "','" & chkEPP03.Checked & "'," & _
            "'" & chkEPP04.Checked & "','" & chkEPP05.Checked & "','" & chkEPP06.Checked & "','" & chkEPP07.Checked & "','" & chkEPP08.Checked & "','" & txtOtros.Text.Trim & "'",
            "[sga.tab_Etiquetas]")

            txtID.Text = _etiquetas.obtenerUltimoID("TOP 1 lbl_id", "[sga.tab_Etiquetas] ORDER BY lbl_id DESC")
        Catch ex As Exception
            MsgBox("Error al crear nueva etiqueta. " & ex.Message)
        End Try
    End Sub

    Protected Sub guardarEtiqueta()
        Try
            _qry.ActulizarGral("[sga.tab_Etiquetas]", "" & _
    "lbl_numParte='" & txtParte.Text & "',lbl_nomQuimico='" & txtNombre.Text & "',fk_id_Division='" & SeleccionDeDivision & "'," & _
    "fk_id_Fabricante='" & cmbFabricante.SelectedValue & "',fk_id_ClaseRiesgo='" & cmbClaseRiesgo.SelectedValue & "'," & _
    "lbl_NotasEspeciales='" & txtNotas.Text.Replace("'", "''") & "',lbl_CodigosH='" & txtNotasH.Text.Replace("'", "''") & "'," & _
    "lbl_CodigosP_General='" & txtCodigosP.Text.Replace("'", "''") & "',lbl_TelefonodeEmergencia='" & txtEmergencia.Text & "'," & _
    "lbl_numCAS='" & txtcas.Text & "'," & _
    "lbl_PictoFisico_Explosivos='" & chkSGA01.Checked & "',lbl_PictoFisico_Inflamable='" & chkSGA02.Checked & "',lbl_PictoFisico_Comburente='" & chkSGA03.Checked & "'," & _
    "lbl_PictoFisico_Gases='" & chkSGA04.Checked & "',lbl_PictoFisico_Corrosivos='" & chkSGA05.Checked & "',lbl_PictoSalud_Toxicidad='" & chkSGA06.Checked & "',lbl_PictoSalud_Nocivo=" & _
    "'" & chkSGA07.Checked & "',lbl_PictoSalud_Salud='" & chkSGA08.Checked & "',lbl_PictoEnviro_Ambiente='" & chkSGA09.Checked & "',lbl_Picto_Corrosivos2='" & chkSGA10.Checked & "',lbl_PictoEPP_Gafas='" & chkEPP01.Checked & "'," & _
    " lbl_PictoEPP_Googles='" & chkEPP02.Checked & "',lbl_PictoEPP_Cubreboca='" & chkEPP03.Checked & "',lbl_PictoEPP_Careta='" & chkEPP04.Checked & "'," & _
    "lbl_PictoEPP_Guantes='" & chkEPP05.Checked & "',lbl_PictoEPP_Guant_Carnaza='" & chkEPP06.Checked & "',lbl_PictoEPP_cubreboca_Filtro='" & chkEPP07.Checked & "'," & _
    "lbl_PictoEPP_Mandil='" & chkEPP08.Checked & "',lbl_Otro='" & txtOtros.Text.Replace("'", "''") & "',lbl_Activo='" & chkActivo.Checked & "'", "lbl_id=" & txtID.Text)
        Catch ex As Exception
            MsgBox("Error al guardar cambios. " & ex.Message)
        End Try
    End Sub
    Private Sub seleccionarDivision(division As Integer)
        Dim i, nums As Integer
        Dim descripcion As String
        Dim ID As Integer

        Try
            For Each row As DataGridViewRow In dgv.Rows
                row.DefaultCellStyle.BackColor = Color.White
                If i < dgv.Rows.Count Then
                    ID = dgv.Rows(i).Cells("id").Value
                    If ID = division Then
                        dgv.Rows(i).Cells("chk").Value() = True
                    End If
                End If
                i = i + 1
            Next
        Catch ex As Exception

        End Try
    End Sub
    Dim SeleccionDeDivision As String
    Private Sub seleccionarDivisionParaGuardar()
        Dim i, nums As Integer
        Dim descripcion As String
        Dim ID As Integer
        Dim bandera As Boolean = False
        SeleccionDeDivision = ""
        Try
            For Each row As DataGridViewRow In dgv.Rows
                row.DefaultCellStyle.BackColor = Color.White

                If i < dgv.Rows.Count Then
                    ID = dgv.Rows(i).Cells("id").Value
                    bandera = dgv.Rows(i).Cells("chk").Value()

                    If bandera = True Then
                        If SeleccionDeDivision = "" Then
                            SeleccionDeDivision = ID
                        Else
                            SeleccionDeDivision = SeleccionDeDivision & "," & ID
                        End If
                    End If
                End If
                i = i + 1
            Next
        Catch ex As Exception
            MsgBox("Error al identificar divisiones seleccionadas. " & ex.Message)
        End Try
    End Sub
    Public Sub cargarDatosEtiqueta()
        Try
            Dim dts As DataSet
            dts = _qry.SelToGridWhere("*", "[sga.tab_Etiquetas]", "lbl_id=" & txtID.Text)
            If dts.Tables(0).Rows.Count > 0 Then
                For Each row As DataRow In dts.Tables(0).Rows
                    txtNoControl.Text = row("lbl_numControl")
                    txtParte.Text = row("lbl_numParte")
                    txtNombre.Text = row("lbl_nomQuimico")

                    'cmbDivision.SelectedValue =
                    cmbFabricante.SelectedValue = row("fk_id_Fabricante")
                    cmbClaseRiesgo.SelectedValue = row("fk_id_ClaseRiesgo")
                    txtNotas.Text = row("lbl_NotasEspeciales")
                    txtNotasH.Text = row("lbl_CodigosH")
                    txtCodigosP.Text = row("lbl_CodigosP_General")
                    txtEmergencia.Text = row("lbl_TelefonodeEmergencia")
                    txtcas.Text = row("lbl_numCAS")
                    txtFolio.Text = row("lbl_Folio")
                    chkActivo.Checked = row("lbl_Activo")
                    txtCreadoPor.Text = row("lbl_CreadoPor")
                    Dim fecha As Date = row("lbl_CreadoFecha")
                    Dim fechaS As String = fecha.ToString(_FormatoFecha.ToString)
                    panelCreadoPor.Visible = True
                    txtCreadoDia.Text = fechaS
                    Dim division As String = row("fk_id_Division")
                    Dim divisiones As String() = division.Split(New Char() {","c})
                    For Each valor In divisiones
                        valor = valor.Trim
                        seleccionarDivision(valor)
                    Next


                    If Not IsDBNull(row("lbl_PictoFisico_Explosivos")) Then
                        chkSGA01.Checked = row("lbl_PictoFisico_Explosivos")
                    Else
                        chkSGA01.Checked = False
                    End If
                    If Not IsDBNull(row("lbl_PictoFisico_Inflamable")) Then
                        chkSGA02.Checked = row("lbl_PictoFisico_Inflamable")
                    Else
                        chkSGA02.Checked = False
                    End If
                    If Not IsDBNull(row("lbl_PictoFisico_Comburente")) Then
                        chkSGA03.Checked = row("lbl_PictoFisico_Comburente")
                    Else
                        chkSGA03.Checked = False
                    End If
                    If Not IsDBNull(row("lbl_PictoFisico_Gases")) Then
                        chkSGA04.Checked = row("lbl_PictoFisico_Gases")
                    Else
                        chkSGA04.Checked = False
                    End If
                    If Not IsDBNull(row("lbl_PictoFisico_Corrosivos")) Then
                        chkSGA05.Checked = row("lbl_PictoFisico_Corrosivos")
                    Else
                        chkSGA05.Checked = False
                    End If
                    If Not IsDBNull(row("lbl_PictoSalud_Toxicidad")) Then
                        chkSGA06.Checked = row("lbl_PictoSalud_Toxicidad")
                    Else
                        chkSGA06.Checked = False
                    End If
                    If Not IsDBNull(row("lbl_PictoSalud_Nocivo")) Then
                        chkSGA07.Checked = row("lbl_PictoSalud_Nocivo")
                    Else
                        chkSGA07.Checked = False
                    End If
                    If Not IsDBNull(row("lbl_PictoSalud_Salud")) Then
                        chkSGA08.Checked = row("lbl_PictoSalud_Salud")
                    Else
                        chkSGA08.Checked = False
                    End If
                    If Not IsDBNull(row("lbl_PictoEnviro_Ambiente")) Then
                        chkSGA09.Checked = row("lbl_PictoEnviro_Ambiente")
                    Else
                        chkSGA09.Checked = False
                    End If
                    If Not IsDBNull(row("lbl_Picto_Corrosivos2")) Then
                        chkSGA10.Checked = row("lbl_Picto_Corrosivos2")
                    Else
                        chkSGA10.Checked = False
                    End If
                    If Not IsDBNull(row("lbl_PictoEPP_Gafas")) Then
                        chkEPP01.Checked = row("lbl_PictoEPP_Gafas")
                    Else
                        chkEPP01.Checked = False
                    End If
                    If Not IsDBNull(row("lbl_PictoEPP_Googles")) Then
                        chkEPP02.Checked = row("lbl_PictoEPP_Googles")
                    Else
                        chkEPP02.Checked = False
                    End If
                    If Not IsDBNull(row("lbl_PictoEPP_Cubreboca")) Then
                        chkEPP03.Checked = row("lbl_PictoEPP_Cubreboca")
                    Else
                        chkEPP03.Checked = False
                    End If
                    If Not IsDBNull(row("lbl_PictoEPP_Careta")) Then
                        chkEPP04.Checked = row("lbl_PictoEPP_Careta")
                    Else
                        chkEPP04.Checked = False
                    End If
                    If Not IsDBNull(row("lbl_PictoEPP_Guantes")) Then
                        chkEPP05.Checked = row("lbl_PictoEPP_Guantes")
                    Else
                        chkEPP05.Checked = False
                    End If
                    If Not IsDBNull(row("lbl_PictoEPP_Guant_Carnaza")) Then
                        chkEPP06.Checked = row("lbl_PictoEPP_Guant_Carnaza")
                    Else
                        chkEPP06.Checked = False
                    End If
                    If Not IsDBNull(row("lbl_PictoEPP_cubreboca_Filtro")) Then
                        chkEPP07.Checked = row("lbl_PictoEPP_cubreboca_Filtro")
                    Else
                        chkEPP07.Checked = False
                    End If
                    If Not IsDBNull(row("lbl_PictoEPP_Mandil")) Then
                        chkEPP08.Checked = row("lbl_PictoEPP_Mandil")
                    Else
                        chkEPP08.Checked = False
                    End If
                    If Not IsDBNull(row("lbl_Otro")) Then
                        txtOtros.Text = row("lbl_Otro")
                    Else
                        txtOtros.Text = ""
                    End If
                    If Not IsDBNull(row("lbl_consecutivo")) Then
                        _numero = row("lbl_consecutivo")
                    Else
                        _numero = 1
                    End If

                    If Not IsDBNull(row("lbl_MSDSEs_Ruta")) Then
                        AxAcroPDF1.src = DocsRuta & "\" & row("lbl_MSDSEs_Ruta")
                    Else
                        AxAcroPDF1.src = ""
                    End If
                    If Not IsDBNull(row("lbl_MSDSEn_Ruta")) Then
                        AxAcroPDF2.src = DocsRuta & "\" & row("lbl_MSDSEn_Ruta")
                    Else
                        AxAcroPDF2.src = ""
                    End If
                Next
            End If
        Catch ex As Exception
            MsgBox("Error al cargar datos de la etiqueta. " & ex.Message)
        End Try
    End Sub

    Private Sub GunaButton2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        generarNumControl()
        'OpenFileDialog1.FileName = String.Empty
        'OpenFileDialog1.ShowDialog()
        ''Me.AxAcroPDF1.LoadFile(OpenFileDialog1.FileName)
        'AxAcroPDF1.src = OpenFileDialog1.FileName
    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        If chkEPP01.Checked = True Or chkEPP02.Checked = True Or chkEPP03.Checked = True Or chkEPP04.Checked = True Or chkEPP05.Checked = True Or chkEPP06.Checked = True Or chkEPP07.Checked = True Or chkEPP08.Checked = True Or
            chkSGA01.Checked = True Or chkSGA02.Checked = True Or chkSGA03.Checked = True Or chkSGA04.Checked = True Or chkSGA05.Checked = True Or chkSGA06.Checked = True Or chkSGA07.Checked = True Or chkSGA08.Checked = True Or chkSGA09.Checked = True Or chkSGA10.Checked = True Then
            Etiquetas_Carta.llenarManifiesto()
            Etiquetas_Carta.Show()
        Else
            MsgBox("Los pictogramas no pueden quedar vacios. Favor de seleccionar al menos uno y posteriormente guardar.")
        End If
        
    End Sub

    Private Sub cmbDivision_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDivision.SelectedIndexChanged
        Try
            If cmbDivision.SelectedValue > 0 Then
                txtFolio.Text = txtNoControl.Text & cmbDivision.Text
            End If
        Catch ex As Exception

        End Try
    End Sub
    Dim DocsRuta As String
    Private Sub btnEditFoto1_Click(sender As Object, e As EventArgs) Handles btnEditFoto1.Click
        DialogoDeArchivos("lbl_MSDSEs_Ruta")
    End Sub
    Private Sub DialogoDeArchivos(campo As String)

        'filtra solo imagenes 
        'fdImageDialog.Filter = "Image Files (*.jpg)|*.jpg"
        OpenFileDialog1.Filter = "Image Files(*.PDF;)|*.PDF;"


        Dim res As DialogResult = OpenFileDialog1.ShowDialog()

     

        If res <> Windows.Forms.DialogResult.Cancel Then
            Try
                'ELIMINA EL ARCHIVO EXISTENTE PARA LA FOTO SELECCIONADA
                'DETERMINE NO ELIMINAR EL ARCHIVO, EN CASO DE QUE UNA OT LO ESTE USANDO EN MODO HISTORICO
                '2021.01.14 -JUAN RIOS 
                'System.IO.File.Delete(ruta_actual)
                'Remueve la IMAGEN DE la Foto seleccionada para poner la nueva.
                _qry.ActulizarGral("[sga.tab_Etiquetas]", campo & "=''", "lbl_id=" & txtID.Text)
            Catch ex As Exception
                MsgBox("Error al remover archivo existente: Error " & ex.Message.ToString)

            End Try

            'FORMULARIO ORIGEN
            ' Dim frm As Form = My.Application.OpenForms(formularioaregresar)
            'Se crea el ID para el Nombre del Archivo
            Dim control As String = txtNoControl.Text.Trim
            Dim carpetaProducto As String = control

            'una vez que seleciono el archivo obtiene su informacion
            Dim nombre As String = Path.GetRandomFileName()
            nombre = nombre.Replace(".", "")
            'una vez que seleciono el archivo obtiene su informacion
            Dim selectedfile2 As New IO.FileInfo(OpenFileDialog1.FileName)
            nombre = nombre & selectedfile2.Extension

            'crea la ruta donde se van a guardar las imagenes
            Dim newpathofimage As String = DocsRuta & "\" & carpetaProducto & "\" & nombre

            Try
                'si el directorio default no existe lo crea
                If Not IO.Directory.Exists(DocsRuta & "\" & carpetaProducto) Then
                    IO.Directory.CreateDirectory(DocsRuta & "\" & carpetaProducto)
                End If





                If System.IO.File.Exists(newpathofimage) = False Then
                    IO.File.Copy(OpenFileDialog1.FileName, newpathofimage)
                End If


            Catch ex As Exception
                MsgBox("Error al copiar archivo a la ruta. " & ex.Message.ToString)
            End Try

            Try
                _qry.ActulizarGral("[sga.tab_Etiquetas]", campo & "='" & carpetaProducto & "\" & nombre & "'", "lbl_id=" & txtID.Text)
            Catch ex As Exception
                MsgBox("Error al guardar foto en base de datos. " & ex.Message)
            End Try



            AxAcroPDF1.src = newpathofimage
            _etiquetas.NotificacionGuardado()
        End If
      

    End Sub

    Private Sub btnLimpiarFoto1_Click(sender As Object, e As EventArgs) Handles btnLimpiarFoto1.Click
        eliminarFOto("lbl_MSDSEs_Ruta")
    End Sub
    Private Sub eliminarFOto(campo As String)
        Dim rutaSinFile As String = AxAcroPDF1.src
        If rutaSinFile = "nombre.pdf" Or rutaSinFile = "file://C:\jlrc\Vertiv\MSDS\" Then
            MsgBox("No se encontro ningun archivo.")
        Else
            rutaSinFile = rutaSinFile.Replace("file://", "")

            Dim ruta_actual As String = rutaSinFile
            Dim fotoAdjunta As Boolean

            If ruta_actual <> "" Then
                fotoAdjunta = True
            Else
                fotoAdjunta = False
            End If


            If fotoAdjunta Then
                Try
                    'ELIMINA EL ARCHIVO EXISTENTE PARA LA FOTO SELECCIONADA
                    System.IO.File.Delete(rutaSinFile)
                    'Remueve la IMAGEN DE la Foto seleccionada para poner la nueva.
                    _qry.ActulizarGral("[sga.tab_Etiquetas]", campo & "=''", "lbl_id=" & txtID.Text)


                    AxAcroPDF1.LoadFile("nombre.pdf")

                    _etiquetas.NotificacionGuardado()

                Catch ex As Exception
                    MsgBox("Error al remover archivo existente: Error " & ex.Message.ToString)

                End Try

            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        DialogoDeArchivosIngles("lbl_MSDSEn_Ruta")
    End Sub
    Private Sub DialogoDeArchivosIngles(campo As String)
        DocsRuta = _etiquetas.RutaFotosInstrucciones
        'filtra solo imagenes 
        'fdImageDialog.Filter = "Image Files (*.jpg)|*.jpg"
        OpenFileDialog1.Filter = "Image Files(*.PDF;)|*.PDF"


        Dim res As DialogResult = OpenFileDialog1.ShowDialog()
        If res <> Windows.Forms.DialogResult.Cancel Then
            Try
                'ELIMINA EL ARCHIVO EXISTENTE PARA LA FOTO SELECCIONADA
                'DETERMINE NO ELIMINAR EL ARCHIVO, EN CASO DE QUE UNA OT LO ESTE USANDO EN MODO HISTORICO
                '2021.01.14 -JUAN RIOS 
                'System.IO.File.Delete(ruta_actual)
                'Remueve la IMAGEN DE la Foto seleccionada para poner la nueva.
                _qry.ActulizarGral("[sga.tab_Etiquetas]", campo & "=''", "lbl_id=" & txtID.Text)
            Catch ex As Exception
                MsgBox("Error al remover archivo existente: Error " & ex.Message.ToString)

            End Try

            'FORMULARIO ORIGEN
            ' Dim frm As Form = My.Application.OpenForms(formularioaregresar)
            'Se crea el ID para el Nombre del Archivo
            Dim control As String = txtNoControl.Text.Trim
            Dim carpetaProducto As String = control

            'una vez que seleciono el archivo obtiene su informacion
            Dim nombre As String = Path.GetRandomFileName()
            nombre = nombre.Replace(".", "")
            'una vez que seleciono el archivo obtiene su informacion
            Dim selectedfile2 As New IO.FileInfo(OpenFileDialog1.FileName)
            nombre = nombre & selectedfile2.Extension

            'crea la ruta donde se van a guardar las imagenes
            Dim newpathofimage As String = DocsRuta & "\" & carpetaProducto & "\" & nombre

            Try
                'si el directorio default no existe lo crea
                If Not IO.Directory.Exists(DocsRuta & "\" & carpetaProducto) Then
                    IO.Directory.CreateDirectory(DocsRuta & "\" & carpetaProducto)
                End If





                If System.IO.File.Exists(newpathofimage) = False Then
                    IO.File.Copy(OpenFileDialog1.FileName, newpathofimage)
                End If


            Catch ex As Exception
                MsgBox("Error al copiar archivo a la ruta. " & ex.Message.ToString)
            End Try

            Try
                _qry.ActulizarGral("[sga.tab_Etiquetas]", campo & "='" & carpetaProducto & "\" & nombre & "'", "lbl_id=" & txtID.Text)
            Catch ex As Exception
                MsgBox("Error al guardar foto en base de datos. " & ex.Message)
            End Try



            AxAcroPDF2.src = newpathofimage
            _etiquetas.NotificacionGuardado()
        End If

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        eliminarArchivoIngles("lbl_MSDSEn_Ruta")
    End Sub
    Private Sub eliminarArchivoIngles(campo As String)
        Dim rutaSinFile As String = AxAcroPDF2.src
        If rutaSinFile = "nombre.pdf" Or rutaSinFile = "file://C:\jlrc\Vertiv\MSDS\" Then
            MsgBox("No se encontro ningun archivo.")
        Else
            rutaSinFile = rutaSinFile.Replace("file://", "")

            Dim ruta_actual As String = rutaSinFile
            Dim fotoAdjunta As Boolean

            If ruta_actual <> "" Then
                fotoAdjunta = True
            Else
                fotoAdjunta = False
            End If

            If fotoAdjunta Then
                Try
                    'ELIMINA EL ARCHIVO EXISTENTE PARA LA FOTO SELECCIONADA
                    System.IO.File.Delete(rutaSinFile)
                    'Remueve la IMAGEN DE la Foto seleccionada para poner la nueva.
                    _qry.ActulizarGral("[sga.tab_Etiquetas]", campo & "=''", "lbl_id=" & txtID.Text)


                    AxAcroPDF2.LoadFile("nombre.pdf")

                    _etiquetas.NotificacionGuardado()

                Catch ex As Exception
                    MsgBox("Error al remover archivo existente: Error " & ex.Message.ToString)

                End Try

            End If
        End If
       
    End Sub

    Private Sub gbLimpiar_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub gbLimpiar_Click_1(sender As Object, e As EventArgs) Handles gbLimpiar.Click
        Me.Close()
    End Sub

    Public Sub deshabilitarBotonesMSDS()
        Button1.Enabled = False
        Button2.Enabled = False
        btnEditFoto1.Enabled = False
        btnLimpiarFoto1.Enabled = False
        GunaButton1.Enabled = False
    End Sub
    Public Sub habilitarBotonesMSDS()
        Button1.Enabled = True
        Button2.Enabled = True
        btnEditFoto1.Enabled = True
        btnLimpiarFoto1.Enabled = True
    End Sub

    Public Sub validarPictogramasOn()
        Try
            If chkEPP01.Checked = True Or chkEPP02.Checked = True Or chkEPP03.Checked = True Or chkEPP04.Checked = True Or chkEPP05.Checked = True Or chkEPP06.Checked = True Or chkEPP07.Checked = True Or chkEPP08.Checked = True Or
            chkSGA01.Checked = True Or chkSGA02.Checked = True Or chkSGA03.Checked = True Or chkSGA04.Checked = True Or chkSGA05.Checked = True Or chkSGA06.Checked = True Or chkSGA07.Checked = True Or chkSGA08.Checked = True Or chkSGA09.Checked = True Or chkSGA10.Checked = True Then
                GunaButton1.Enabled = True
            Else
                GunaButton1.Enabled = False
            End If
        Catch ex As Exception
            MsgBox("Error al habilitar pictogramas. " & ex.Message)
        End Try
    End Sub
End Class