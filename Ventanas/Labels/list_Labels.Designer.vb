<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class list_Labels
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GunaPanel2 = New Guna.UI.WinForms.GunaPanel()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.chk = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Division = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gbCrear = New Guna.UI.WinForms.GunaButton()
        Me.gbFiltrar = New Guna.UI.WinForms.GunaButton()
        Me.gbLimpiar = New Guna.UI.WinForms.GunaButton()
        Me.txtFabricante = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtQuimico = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtFolio = New System.Windows.Forms.TextBox()
        Me.txtControl = New System.Windows.Forms.TextBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.dgvBitacora = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GunaPanel1.SuspendLayout()
        Me.GunaPanel2.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.dgvBitacora, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GunaPanel1
        '
        Me.GunaPanel1.Controls.Add(Me.Label1)
        Me.GunaPanel1.Controls.Add(Me.GunaPanel2)
        Me.GunaPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(814, 255)
        Me.GunaPanel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(24, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(358, 31)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "LISTADO DE ETIQUETAS"
        '
        'GunaPanel2
        '
        Me.GunaPanel2.Controls.Add(Me.dgv)
        Me.GunaPanel2.Controls.Add(Me.gbCrear)
        Me.GunaPanel2.Controls.Add(Me.gbFiltrar)
        Me.GunaPanel2.Controls.Add(Me.gbLimpiar)
        Me.GunaPanel2.Controls.Add(Me.txtFabricante)
        Me.GunaPanel2.Controls.Add(Me.Label5)
        Me.GunaPanel2.Controls.Add(Me.txtQuimico)
        Me.GunaPanel2.Controls.Add(Me.Label6)
        Me.GunaPanel2.Controls.Add(Me.Label9)
        Me.GunaPanel2.Controls.Add(Me.txtFolio)
        Me.GunaPanel2.Controls.Add(Me.txtControl)
        Me.GunaPanel2.Controls.Add(Me.lblTotal)
        Me.GunaPanel2.Controls.Add(Me.Label11)
        Me.GunaPanel2.Controls.Add(Me.Label13)
        Me.GunaPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaPanel2.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel2.Name = "GunaPanel2"
        Me.GunaPanel2.Size = New System.Drawing.Size(814, 253)
        Me.GunaPanel2.TabIndex = 41
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.AllowUserToOrderColumns = True
        Me.dgv.BackgroundColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.chk, Me.id, Me.Division})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv.Location = New System.Drawing.Point(533, 57)
        Me.dgv.Name = "dgv"
        Me.dgv.RowHeadersVisible = False
        Me.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv.Size = New System.Drawing.Size(254, 110)
        Me.dgv.TabIndex = 191
        '
        'chk
        '
        Me.chk.HeaderText = "Sel"
        Me.chk.Name = "chk"
        Me.chk.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.chk.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.chk.Width = 50
        '
        'id
        '
        Me.id.HeaderText = "Folio OT"
        Me.id.Name = "id"
        Me.id.Visible = False
        '
        'Division
        '
        Me.Division.HeaderText = "Division"
        Me.Division.Name = "Division"
        Me.Division.Width = 200
        '
        'gbCrear
        '
        Me.gbCrear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbCrear.AnimationHoverSpeed = 0.07!
        Me.gbCrear.AnimationSpeed = 0.03!
        Me.gbCrear.BackColor = System.Drawing.Color.Transparent
        Me.gbCrear.BaseColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.gbCrear.BorderColor = System.Drawing.Color.Black
        Me.gbCrear.DialogResult = System.Windows.Forms.DialogResult.None
        Me.gbCrear.FocusedColor = System.Drawing.Color.Empty
        Me.gbCrear.Font = New System.Drawing.Font("Segoe UI Semibold", 8.0!, System.Drawing.FontStyle.Bold)
        Me.gbCrear.ForeColor = System.Drawing.Color.White
        Me.gbCrear.Image = Global.GHSA_App.My.Resources.Resources.ic_plus_12px
        Me.gbCrear.ImageSize = New System.Drawing.Size(12, 12)
        Me.gbCrear.Location = New System.Drawing.Point(656, 193)
        Me.gbCrear.Name = "gbCrear"
        Me.gbCrear.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.gbCrear.OnHoverBorderColor = System.Drawing.Color.Black
        Me.gbCrear.OnHoverForeColor = System.Drawing.Color.White
        Me.gbCrear.OnHoverImage = Nothing
        Me.gbCrear.OnPressedColor = System.Drawing.Color.Black
        Me.gbCrear.Radius = 3
        Me.gbCrear.Size = New System.Drawing.Size(128, 40)
        Me.gbCrear.TabIndex = 11
        Me.gbCrear.Text = "CREAR ETIQUETA"
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
        Me.gbFiltrar.Image = Global.GHSA_App.My.Resources.Resources.ic_filter_12px
        Me.gbFiltrar.ImageSize = New System.Drawing.Size(12, 12)
        Me.gbFiltrar.Location = New System.Drawing.Point(30, 193)
        Me.gbFiltrar.Name = "gbFiltrar"
        Me.gbFiltrar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.gbFiltrar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.gbFiltrar.OnHoverForeColor = System.Drawing.Color.White
        Me.gbFiltrar.OnHoverImage = Nothing
        Me.gbFiltrar.OnPressedColor = System.Drawing.Color.Black
        Me.gbFiltrar.Radius = 3
        Me.gbFiltrar.Size = New System.Drawing.Size(128, 40)
        Me.gbFiltrar.TabIndex = 40
        Me.gbFiltrar.Text = "FILTRAR"
        Me.gbFiltrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.gbLimpiar.Location = New System.Drawing.Point(164, 193)
        Me.gbLimpiar.Name = "gbLimpiar"
        Me.gbLimpiar.OnHoverBaseColor = System.Drawing.Color.Black
        Me.gbLimpiar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.gbLimpiar.OnHoverForeColor = System.Drawing.Color.White
        Me.gbLimpiar.OnHoverImage = Nothing
        Me.gbLimpiar.OnPressedColor = System.Drawing.Color.Black
        Me.gbLimpiar.Radius = 3
        Me.gbLimpiar.Size = New System.Drawing.Size(128, 40)
        Me.gbLimpiar.TabIndex = 41
        Me.gbLimpiar.Text = "LIMPIAR"
        Me.gbLimpiar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtFabricante
        '
        Me.txtFabricante.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtFabricante.Location = New System.Drawing.Point(129, 115)
        Me.txtFabricante.Name = "txtFabricante"
        Me.txtFabricante.Size = New System.Drawing.Size(191, 23)
        Me.txtFabricante.TabIndex = 40
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(33, 118)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(90, 17)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Fabricante:"
        '
        'txtQuimico
        '
        Me.txtQuimico.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtQuimico.Location = New System.Drawing.Point(129, 86)
        Me.txtQuimico.Name = "txtQuimico"
        Me.txtQuimico.Size = New System.Drawing.Size(373, 23)
        Me.txtQuimico.TabIndex = 50
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(52, 89)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(71, 17)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Quimico:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.Location = New System.Drawing.Point(33, 147)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(89, 17)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "# de Parte:"
        '
        'txtFolio
        '
        Me.txtFolio.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtFolio.Location = New System.Drawing.Point(129, 144)
        Me.txtFolio.Name = "txtFolio"
        Me.txtFolio.Size = New System.Drawing.Size(98, 23)
        Me.txtFolio.TabIndex = 10
        '
        'txtControl
        '
        Me.txtControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtControl.Location = New System.Drawing.Point(129, 57)
        Me.txtControl.Name = "txtControl"
        Me.txtControl.Size = New System.Drawing.Size(134, 23)
        Me.txtControl.TabIndex = 20
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblTotal.Location = New System.Drawing.Point(373, 9)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(50, 31)
        Me.lblTotal.TabIndex = 12
        Me.lblTotal.Text = "(0)"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label11.Location = New System.Drawing.Point(44, 60)
        Me.Label11.Name = "Label11"
        Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label11.Size = New System.Drawing.Size(79, 17)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "# Control:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(24, 9)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(358, 31)
        Me.Label13.TabIndex = 10
        Me.Label13.Text = "LISTADO DE ETIQUETAS"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.dgvBitacora)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 255)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(30, 5, 30, 5)
        Me.Panel3.Size = New System.Drawing.Size(814, 265)
        Me.Panel3.TabIndex = 17
        '
        'dgvBitacora
        '
        Me.dgvBitacora.AllowUserToAddRows = False
        Me.dgvBitacora.AllowUserToDeleteRows = False
        Me.dgvBitacora.BackgroundColor = System.Drawing.Color.White
        Me.dgvBitacora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvBitacora.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvBitacora.Location = New System.Drawing.Point(30, 5)
        Me.dgvBitacora.Name = "dgvBitacora"
        Me.dgvBitacora.ReadOnly = True
        Me.dgvBitacora.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBitacora.Size = New System.Drawing.Size(754, 255)
        Me.dgvBitacora.TabIndex = 12
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.ProgressBar1)
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 520)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(0, 20, 20, 20)
        Me.Panel2.Size = New System.Drawing.Size(814, 51)
        Me.Panel2.TabIndex = 18
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBar1.Location = New System.Drawing.Point(420, 13)
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
        Me.Button3.Location = New System.Drawing.Point(595, 7)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(192, 32)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "EXPORTAR A EXCEL"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'list_Labels
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(814, 571)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.GunaPanel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "list_Labels"
        Me.Text = "Listado de Etiquetas"
        Me.GunaPanel1.ResumeLayout(False)
        Me.GunaPanel1.PerformLayout()
        Me.GunaPanel2.ResumeLayout(False)
        Me.GunaPanel2.PerformLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        CType(Me.dgvBitacora, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents dgvBitacora As System.Windows.Forms.DataGridView
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents gbCrear As Guna.UI.WinForms.GunaButton
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents gbFiltrar As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaPanel2 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents txtFabricante As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtQuimico As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtFolio As System.Windows.Forms.TextBox
    Friend WithEvents txtControl As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents gbLimpiar As Guna.UI.WinForms.GunaButton
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents chk As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Division As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
