<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Areas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Areas))
        Me.GunaPanel2 = New Guna.UI.WinForms.GunaPanel()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.gbLimpiar = New Guna.UI.WinForms.GunaButton()
        Me.gbFiltrar = New Guna.UI.WinForms.GunaButton()
        Me.txtDesc = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GunaButton4 = New Guna.UI.WinForms.GunaButton()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.dgvCatalogo = New System.Windows.Forms.DataGridView()
        Me.GunaPanel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dgvCatalogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaPanel2
        '
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
        Me.GunaPanel2.Size = New System.Drawing.Size(829, 184)
        Me.GunaPanel2.TabIndex = 42
        '
        'txtId
        '
        Me.txtId.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtId.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtId.Location = New System.Drawing.Point(410, 17)
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
        Me.gbLimpiar.Location = New System.Drawing.Point(164, 124)
        Me.gbLimpiar.Name = "gbLimpiar"
        Me.gbLimpiar.OnHoverBaseColor = System.Drawing.Color.Black
        Me.gbLimpiar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.gbLimpiar.OnHoverForeColor = System.Drawing.Color.White
        Me.gbLimpiar.OnHoverImage = Nothing
        Me.gbLimpiar.OnPressedColor = System.Drawing.Color.Black
        Me.gbLimpiar.Radius = 3
        Me.gbLimpiar.Size = New System.Drawing.Size(128, 40)
        Me.gbLimpiar.TabIndex = 45
        Me.gbLimpiar.Text = "CANCELAR"
        Me.gbLimpiar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.gbFiltrar.Location = New System.Drawing.Point(30, 124)
        Me.gbFiltrar.Name = "gbFiltrar"
        Me.gbFiltrar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.gbFiltrar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.gbFiltrar.OnHoverForeColor = System.Drawing.Color.White
        Me.gbFiltrar.OnHoverImage = Nothing
        Me.gbFiltrar.OnPressedColor = System.Drawing.Color.Black
        Me.gbFiltrar.Radius = 3
        Me.gbFiltrar.Size = New System.Drawing.Size(128, 40)
        Me.gbFiltrar.TabIndex = 44
        Me.gbFiltrar.Text = "GUARDAR"
        Me.gbFiltrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDesc
        '
        Me.txtDesc.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtDesc.Location = New System.Drawing.Point(164, 54)
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(274, 23)
        Me.txtDesc.TabIndex = 37
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(60, 57)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(98, 17)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Descripción:"
        '
        'GunaButton4
        '
        Me.GunaButton4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.GunaButton4.Location = New System.Drawing.Point(709, 124)
        Me.GunaButton4.Name = "GunaButton4"
        Me.GunaButton4.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.GunaButton4.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton4.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton4.OnHoverImage = Nothing
        Me.GunaButton4.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton4.Radius = 3
        Me.GunaButton4.Size = New System.Drawing.Size(90, 40)
        Me.GunaButton4.TabIndex = 11
        Me.GunaButton4.Text = "NUEVO"
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
        Me.Label13.Text = "CATALOGO DE DIVISIÓN"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.dgvCatalogo)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 184)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(30, 5, 30, 5)
        Me.Panel3.Size = New System.Drawing.Size(829, 369)
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
        Me.dgvCatalogo.Size = New System.Drawing.Size(769, 359)
        Me.dgvCatalogo.TabIndex = 12
        '
        'ctgDivision
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(829, 553)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.GunaPanel2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ctgDivision"
        Me.Text = "Catalogo de Division"
        Me.GunaPanel2.ResumeLayout(False)
        Me.GunaPanel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.dgvCatalogo, System.ComponentModel.ISupportInitialize).EndInit()
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
End Class
