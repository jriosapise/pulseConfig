<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrintOut_Log
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
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GunaPanel2 = New Guna.UI.WinForms.GunaPanel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.gbFiltrar = New Guna.UI.WinForms.GunaButton()
        Me.gbLimpiar = New Guna.UI.WinForms.GunaButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.dgvBitacora = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.fecha1 = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.fecha2 = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.GunaPanel1.SuspendLayout()
        Me.GunaPanel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dgvBitacora, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaPanel1
        '
        Me.GunaPanel1.Controls.Add(Me.Label1)
        Me.GunaPanel1.Controls.Add(Me.GunaPanel2)
        Me.GunaPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(877, 109)
        Me.GunaPanel1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(24, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(383, 31)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "REGISTRO DE IMPRESIÓN"
        '
        'GunaPanel2
        '
        Me.GunaPanel2.Controls.Add(Me.fecha2)
        Me.GunaPanel2.Controls.Add(Me.fecha1)
        Me.GunaPanel2.Controls.Add(Me.gbFiltrar)
        Me.GunaPanel2.Controls.Add(Me.gbLimpiar)
        Me.GunaPanel2.Controls.Add(Me.Label6)
        Me.GunaPanel2.Controls.Add(Me.lblTotal)
        Me.GunaPanel2.Controls.Add(Me.Label11)
        Me.GunaPanel2.Controls.Add(Me.Label13)
        Me.GunaPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaPanel2.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel2.Name = "GunaPanel2"
        Me.GunaPanel2.Size = New System.Drawing.Size(877, 107)
        Me.GunaPanel2.TabIndex = 41
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(239, 60)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(53, 17)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "hasta:"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblTotal.Location = New System.Drawing.Point(403, 9)
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
        Me.Label11.Size = New System.Drawing.Size(59, 17)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "Desde:"
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
        'gbFiltrar
        '
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
        Me.gbFiltrar.Location = New System.Drawing.Point(451, 54)
        Me.gbFiltrar.Name = "gbFiltrar"
        Me.gbFiltrar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.gbFiltrar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.gbFiltrar.OnHoverForeColor = System.Drawing.Color.White
        Me.gbFiltrar.OnHoverImage = Nothing
        Me.gbFiltrar.OnPressedColor = System.Drawing.Color.Black
        Me.gbFiltrar.Radius = 3
        Me.gbFiltrar.Size = New System.Drawing.Size(128, 32)
        Me.gbFiltrar.TabIndex = 40
        Me.gbFiltrar.Text = "FILTRAR"
        Me.gbFiltrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'gbLimpiar
        '
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
        Me.gbLimpiar.Location = New System.Drawing.Point(585, 54)
        Me.gbLimpiar.Name = "gbLimpiar"
        Me.gbLimpiar.OnHoverBaseColor = System.Drawing.Color.Black
        Me.gbLimpiar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.gbLimpiar.OnHoverForeColor = System.Drawing.Color.White
        Me.gbLimpiar.OnHoverImage = Nothing
        Me.gbLimpiar.OnPressedColor = System.Drawing.Color.Black
        Me.gbLimpiar.Radius = 3
        Me.gbLimpiar.Size = New System.Drawing.Size(128, 32)
        Me.gbLimpiar.TabIndex = 41
        Me.gbLimpiar.Text = "LIMPIAR"
        Me.gbLimpiar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.dgvBitacora)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 109)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(30, 5, 30, 5)
        Me.Panel3.Size = New System.Drawing.Size(877, 346)
        Me.Panel3.TabIndex = 18
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
        Me.dgvBitacora.Size = New System.Drawing.Size(817, 336)
        Me.dgvBitacora.TabIndex = 12
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 419)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(0, 20, 20, 20)
        Me.Panel2.Size = New System.Drawing.Size(877, 36)
        Me.Panel2.TabIndex = 19
        '
        'fecha1
        '
        Me.fecha1.BaseColor = System.Drawing.Color.White
        Me.fecha1.BorderColor = System.Drawing.Color.Silver
        Me.fecha1.CustomFormat = Nothing
        Me.fecha1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.fecha1.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.fecha1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.fecha1.ForeColor = System.Drawing.Color.Black
        Me.fecha1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecha1.Location = New System.Drawing.Point(109, 54)
        Me.fecha1.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.fecha1.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.fecha1.Name = "fecha1"
        Me.fecha1.OnHoverBaseColor = System.Drawing.Color.White
        Me.fecha1.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.fecha1.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.fecha1.OnPressedColor = System.Drawing.Color.Black
        Me.fecha1.Size = New System.Drawing.Size(118, 32)
        Me.fecha1.TabIndex = 42
        Me.fecha1.Text = "1/1/2021"
        Me.fecha1.Value = New Date(2021, 1, 1, 0, 0, 0, 0)
        '
        'fecha2
        '
        Me.fecha2.BaseColor = System.Drawing.Color.White
        Me.fecha2.BorderColor = System.Drawing.Color.Silver
        Me.fecha2.CustomFormat = Nothing
        Me.fecha2.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.fecha2.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.fecha2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.fecha2.ForeColor = System.Drawing.Color.Black
        Me.fecha2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecha2.Location = New System.Drawing.Point(298, 54)
        Me.fecha2.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.fecha2.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.fecha2.Name = "fecha2"
        Me.fecha2.OnHoverBaseColor = System.Drawing.Color.White
        Me.fecha2.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.fecha2.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.fecha2.OnPressedColor = System.Drawing.Color.Black
        Me.fecha2.Size = New System.Drawing.Size(118, 32)
        Me.fecha2.TabIndex = 43
        Me.fecha2.Text = "3/26/2021"
        Me.fecha2.Value = New Date(2021, 3, 26, 2, 22, 44, 424)
        '
        'PrintOut_Log
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(877, 455)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.GunaPanel1)
        Me.Name = "PrintOut_Log"
        Me.Text = "PrintOut_Log"
        Me.GunaPanel1.ResumeLayout(False)
        Me.GunaPanel1.PerformLayout()
        Me.GunaPanel2.ResumeLayout(False)
        Me.GunaPanel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.dgvBitacora, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GunaPanel2 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents gbFiltrar As Guna.UI.WinForms.GunaButton
    Friend WithEvents gbLimpiar As Guna.UI.WinForms.GunaButton
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents dgvBitacora As System.Windows.Forms.DataGridView
    Friend WithEvents fecha2 As Guna.UI.WinForms.GunaDateTimePicker
    Friend WithEvents fecha1 As Guna.UI.WinForms.GunaDateTimePicker
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
End Class
