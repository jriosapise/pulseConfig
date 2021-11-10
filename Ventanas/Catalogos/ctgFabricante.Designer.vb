<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctgFabricante
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ctgFabricante))
        Me.GunaPanel2 = New Guna.UI.WinForms.GunaPanel()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCP = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtEstado = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCiudad = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTel = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDire = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.gbLimpiar = New Guna.UI.WinForms.GunaButton()
        Me.gbFiltrar = New Guna.UI.WinForms.GunaButton()
        Me.txtDesc = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GunaButton4 = New Guna.UI.WinForms.GunaButton()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.dgvCatalogo = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GunaButton1 = New Guna.UI.WinForms.GunaButton()
        Me.txtBusqueda = New System.Windows.Forms.TextBox()
        Me.GunaPanel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dgvCatalogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GunaPanel2
        '
        Me.GunaPanel2.Controls.Add(Me.txtBusqueda)
        Me.GunaPanel2.Controls.Add(Me.GunaButton1)
        Me.GunaPanel2.Controls.Add(Me.txtEmail)
        Me.GunaPanel2.Controls.Add(Me.Label7)
        Me.GunaPanel2.Controls.Add(Me.txtCP)
        Me.GunaPanel2.Controls.Add(Me.Label5)
        Me.GunaPanel2.Controls.Add(Me.txtEstado)
        Me.GunaPanel2.Controls.Add(Me.Label4)
        Me.GunaPanel2.Controls.Add(Me.txtCiudad)
        Me.GunaPanel2.Controls.Add(Me.Label3)
        Me.GunaPanel2.Controls.Add(Me.txtTel)
        Me.GunaPanel2.Controls.Add(Me.Label2)
        Me.GunaPanel2.Controls.Add(Me.txtDire)
        Me.GunaPanel2.Controls.Add(Me.Label1)
        Me.GunaPanel2.Controls.Add(Me.txtId)
        Me.GunaPanel2.Controls.Add(Me.gbLimpiar)
        Me.GunaPanel2.Controls.Add(Me.gbFiltrar)
        Me.GunaPanel2.Controls.Add(Me.txtDesc)
        Me.GunaPanel2.Controls.Add(Me.Label6)
        Me.GunaPanel2.Controls.Add(Me.GunaButton4)
        Me.GunaPanel2.Controls.Add(Me.Label13)
        Me.GunaPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaPanel2.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel2.Name = "GunaPanel2"
        Me.GunaPanel2.Size = New System.Drawing.Size(829, 247)
        Me.GunaPanel2.TabIndex = 42
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtEmail.Location = New System.Drawing.Point(135, 83)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(246, 23)
        Me.txtEmail.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(72, 86)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(57, 17)
        Me.Label7.TabIndex = 57
        Me.Label7.Text = "e-Mail:"
        '
        'txtCP
        '
        Me.txtCP.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtCP.Location = New System.Drawing.Point(492, 114)
        Me.txtCP.Name = "txtCP"
        Me.txtCP.Size = New System.Drawing.Size(135, 23)
        Me.txtCP.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(443, 117)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(43, 17)
        Me.Label5.TabIndex = 55
        Me.Label5.Text = "C.P.:"
        '
        'txtEstado
        '
        Me.txtEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtEstado.Location = New System.Drawing.Point(436, 143)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.Size = New System.Drawing.Size(191, 23)
        Me.txtEstado.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(367, 146)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(63, 17)
        Me.Label4.TabIndex = 53
        Me.Label4.Text = "Estado:"
        '
        'txtCiudad
        '
        Me.txtCiudad.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtCiudad.Location = New System.Drawing.Point(135, 143)
        Me.txtCiudad.Name = "txtCiudad"
        Me.txtCiudad.Size = New System.Drawing.Size(221, 23)
        Me.txtCiudad.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(66, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(63, 17)
        Me.Label3.TabIndex = 51
        Me.Label3.Text = "Ciudad:"
        '
        'txtTel
        '
        Me.txtTel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtTel.Location = New System.Drawing.Point(492, 54)
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(135, 23)
        Me.txtTel.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(450, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(36, 17)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "Tel:"
        '
        'txtDire
        '
        Me.txtDire.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtDire.Location = New System.Drawing.Point(135, 114)
        Me.txtDire.Name = "txtDire"
        Me.txtDire.Size = New System.Drawing.Size(303, 23)
        Me.txtDire.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(48, 117)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(81, 17)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Dirección:"
        '
        'txtId
        '
        Me.txtId.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtId.Location = New System.Drawing.Point(492, 17)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(46, 23)
        Me.txtId.TabIndex = 46
        Me.txtId.Visible = False
        '
        'gbLimpiar
        '
        Me.gbLimpiar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gbLimpiar.AnimationHoverSpeed = 0.07!
        Me.gbLimpiar.AnimationSpeed = 0.03!
        Me.gbLimpiar.BackColor = System.Drawing.Color.Transparent
        Me.gbLimpiar.BaseColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.gbLimpiar.BorderColor = System.Drawing.Color.Black
        Me.gbLimpiar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.gbLimpiar.FocusedColor = System.Drawing.Color.Empty
        Me.gbLimpiar.Font = New System.Drawing.Font("Segoe UI Semibold", 8.0!, System.Drawing.FontStyle.Bold)
        Me.gbLimpiar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.gbLimpiar.Image = Global.GHSA_App.My.Resources.Resources.ic_clean_12px1
        Me.gbLimpiar.ImageSize = New System.Drawing.Size(12, 12)
        Me.gbLimpiar.Location = New System.Drawing.Point(121, 187)
        Me.gbLimpiar.Name = "gbLimpiar"
        Me.gbLimpiar.OnHoverBaseColor = System.Drawing.Color.Black
        Me.gbLimpiar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.gbLimpiar.OnHoverForeColor = System.Drawing.Color.White
        Me.gbLimpiar.OnHoverImage = Nothing
        Me.gbLimpiar.OnPressedColor = System.Drawing.Color.Black
        Me.gbLimpiar.Radius = 3
        Me.gbLimpiar.Size = New System.Drawing.Size(92, 40)
        Me.gbLimpiar.TabIndex = 30
        Me.gbLimpiar.Text = "CANCELAR"
        Me.gbLimpiar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'gbFiltrar
        '
        Me.gbFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gbFiltrar.AnimationHoverSpeed = 0.07!
        Me.gbFiltrar.AnimationSpeed = 0.03!
        Me.gbFiltrar.BackColor = System.Drawing.Color.Transparent
        Me.gbFiltrar.BaseColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.gbFiltrar.BorderColor = System.Drawing.Color.Black
        Me.gbFiltrar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.gbFiltrar.FocusedColor = System.Drawing.Color.Empty
        Me.gbFiltrar.Font = New System.Drawing.Font("Segoe UI Semibold", 8.0!, System.Drawing.FontStyle.Bold)
        Me.gbFiltrar.ForeColor = System.Drawing.Color.White
        Me.gbFiltrar.Image = Global.GHSA_App.My.Resources.Resources.ic_Fabrica
        Me.gbFiltrar.ImageSize = New System.Drawing.Size(12, 12)
        Me.gbFiltrar.Location = New System.Drawing.Point(30, 187)
        Me.gbFiltrar.Name = "gbFiltrar"
        Me.gbFiltrar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.gbFiltrar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.gbFiltrar.OnHoverForeColor = System.Drawing.Color.White
        Me.gbFiltrar.OnHoverImage = Nothing
        Me.gbFiltrar.OnPressedColor = System.Drawing.Color.Black
        Me.gbFiltrar.Radius = 3
        Me.gbFiltrar.Size = New System.Drawing.Size(85, 40)
        Me.gbFiltrar.TabIndex = 20
        Me.gbFiltrar.Text = "GUARDAR"
        Me.gbFiltrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDesc
        '
        Me.txtDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtDesc.Location = New System.Drawing.Point(135, 54)
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(303, 23)
        Me.txtDesc.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(60, 57)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(69, 17)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Nombre:"
        '
        'GunaButton4
        '
        Me.GunaButton4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaButton4.AnimationHoverSpeed = 0.07!
        Me.GunaButton4.AnimationSpeed = 0.03!
        Me.GunaButton4.BackColor = System.Drawing.Color.Transparent
        Me.GunaButton4.BaseColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.GunaButton4.BorderColor = System.Drawing.Color.Black
        Me.GunaButton4.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton4.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton4.Font = New System.Drawing.Font("Segoe UI Semibold", 8.0!, System.Drawing.FontStyle.Bold)
        Me.GunaButton4.ForeColor = System.Drawing.Color.White
        Me.GunaButton4.Image = Global.GHSA_App.My.Resources.Resources.ic_plus_12px
        Me.GunaButton4.ImageSize = New System.Drawing.Size(12, 12)
        Me.GunaButton4.Location = New System.Drawing.Point(717, 187)
        Me.GunaButton4.Name = "GunaButton4"
        Me.GunaButton4.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.GunaButton4.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton4.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton4.OnHoverImage = Nothing
        Me.GunaButton4.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton4.Radius = 3
        Me.GunaButton4.Size = New System.Drawing.Size(82, 40)
        Me.GunaButton4.TabIndex = 40
        Me.GunaButton4.Text = "NUEVO"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(24, 9)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(413, 31)
        Me.Label13.TabIndex = 10
        Me.Label13.Text = "CATALOGO DE FABRICANTE"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.dgvCatalogo)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 247)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(30, 5, 30, 5)
        Me.Panel3.Size = New System.Drawing.Size(829, 255)
        Me.Panel3.TabIndex = 43
        '
        'dgvCatalogo
        '
        Me.dgvCatalogo.AllowUserToAddRows = False
        Me.dgvCatalogo.AllowUserToDeleteRows = False
        Me.dgvCatalogo.BackgroundColor = System.Drawing.Color.White
        Me.dgvCatalogo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvCatalogo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvCatalogo.Location = New System.Drawing.Point(30, 5)
        Me.dgvCatalogo.Name = "dgvCatalogo"
        Me.dgvCatalogo.ReadOnly = True
        Me.dgvCatalogo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCatalogo.Size = New System.Drawing.Size(769, 245)
        Me.dgvCatalogo.TabIndex = 12
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.ProgressBar1)
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 502)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(0, 20, 20, 20)
        Me.Panel2.Size = New System.Drawing.Size(829, 51)
        Me.Panel2.TabIndex = 44
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBar1.Location = New System.Drawing.Point(435, 13)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(164, 21)
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.ProgressBar1.TabIndex = 10
        Me.ProgressBar1.Visible = False
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(610, 7)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(192, 32)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "EXPORTAR A EXCEL"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'GunaButton1
        '
        Me.GunaButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaButton1.AnimationHoverSpeed = 0.07!
        Me.GunaButton1.AnimationSpeed = 0.03!
        Me.GunaButton1.BackColor = System.Drawing.Color.Transparent
        Me.GunaButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.GunaButton1.BorderColor = System.Drawing.Color.Black
        Me.GunaButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton1.Font = New System.Drawing.Font("Segoe UI Semibold", 8.0!, System.Drawing.FontStyle.Bold)
        Me.GunaButton1.ForeColor = System.Drawing.Color.White
        Me.GunaButton1.Image = Global.GHSA_App.My.Resources.Resources.ic_filter_12px
        Me.GunaButton1.ImageSize = New System.Drawing.Size(12, 12)
        Me.GunaButton1.Location = New System.Drawing.Point(633, 187)
        Me.GunaButton1.Name = "GunaButton1"
        Me.GunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.GunaButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton1.OnHoverImage = Nothing
        Me.GunaButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton1.Radius = 3
        Me.GunaButton1.Size = New System.Drawing.Size(78, 40)
        Me.GunaButton1.TabIndex = 60
        Me.GunaButton1.Text = "BUSCAR"
        Me.GunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtBusqueda
        '
        Me.txtBusqueda.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBusqueda.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Bold)
        Me.txtBusqueda.Location = New System.Drawing.Point(286, 191)
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(341, 36)
        Me.txtBusqueda.TabIndex = 59
        Me.txtBusqueda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ctgFabricante
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(829, 553)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.GunaPanel2)
        Me.Controls.Add(Me.Panel2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ctgFabricante"
        Me.Text = "Catalogo de Fabricante"
        Me.GunaPanel2.ResumeLayout(False)
        Me.GunaPanel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.dgvCatalogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GunaPanel2 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents txtDesc As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GunaButton4 As Guna.UI.WinForms.GunaButton
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents dgvCatalogo As System.Windows.Forms.DataGridView
    Friend WithEvents gbLimpiar As Guna.UI.WinForms.GunaButton
    Friend WithEvents gbFiltrar As Guna.UI.WinForms.GunaButton
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents txtDire As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTel As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtEstado As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCiudad As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCP As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents GunaButton1 As Guna.UI.WinForms.GunaButton
    Friend WithEvents txtBusqueda As System.Windows.Forms.TextBox
End Class
