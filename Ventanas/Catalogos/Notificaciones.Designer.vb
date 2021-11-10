<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Notificaciones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Notificaciones))
        Me.GunaPanel2 = New Guna.UI.WinForms.GunaPanel()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.gbLimpiar = New Guna.UI.WinForms.GunaButton()
        Me.gbFiltrar = New Guna.UI.WinForms.GunaButton()
        Me.txtDesc = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCC = New System.Windows.Forms.TextBox()
        Me.lblMensaje = New Guna.UI.WinForms.GunaLabel()
        Me.GunaPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GunaPanel2
        '
        Me.GunaPanel2.Controls.Add(Me.lblMensaje)
        Me.GunaPanel2.Controls.Add(Me.txtCC)
        Me.GunaPanel2.Controls.Add(Me.Label1)
        Me.GunaPanel2.Controls.Add(Me.txtId)
        Me.GunaPanel2.Controls.Add(Me.gbLimpiar)
        Me.GunaPanel2.Controls.Add(Me.gbFiltrar)
        Me.GunaPanel2.Controls.Add(Me.txtDesc)
        Me.GunaPanel2.Controls.Add(Me.Label6)
        Me.GunaPanel2.Controls.Add(Me.Label13)
        Me.GunaPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaPanel2.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel2.Name = "GunaPanel2"
        Me.GunaPanel2.Size = New System.Drawing.Size(829, 245)
        Me.GunaPanel2.TabIndex = 42
        '
        'txtId
        '
        Me.txtId.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtId.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtId.Location = New System.Drawing.Point(537, 42)
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
        Me.gbLimpiar.Location = New System.Drawing.Point(164, 185)
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
        Me.gbFiltrar.Location = New System.Drawing.Point(30, 185)
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
        Me.txtDesc.Location = New System.Drawing.Point(153, 51)
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(274, 23)
        Me.txtDesc.TabIndex = 37
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(59, 54)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(88, 17)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Notificar a:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(24, 9)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(737, 31)
        Me.Label13.TabIndex = 10
        Me.Label13.Text = "NOTIFICACIÓN DE CAMBIOS Y NUEVAS ETIQUETAS"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(60, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(87, 17)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Con Copia:"
        '
        'txtCC
        '
        Me.txtCC.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtCC.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtCC.Location = New System.Drawing.Point(153, 80)
        Me.txtCC.Multiline = True
        Me.txtCC.Name = "txtCC"
        Me.txtCC.Size = New System.Drawing.Size(467, 71)
        Me.txtCC.TabIndex = 48
        '
        'lblMensaje
        '
        Me.lblMensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblMensaje.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblMensaje.Location = New System.Drawing.Point(153, 154)
        Me.lblMensaje.Name = "lblMensaje"
        Me.lblMensaje.Size = New System.Drawing.Size(467, 16)
        Me.lblMensaje.TabIndex = 49
        Me.lblMensaje.Text = "Asegurese que los correos esten separados por comas."
        Me.lblMensaje.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Notificaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(829, 241)
        Me.Controls.Add(Me.GunaPanel2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Notificaciones"
        Me.Text = "Notificaciones"
        Me.GunaPanel2.ResumeLayout(False)
        Me.GunaPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GunaPanel2 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents txtDesc As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents gbLimpiar As Guna.UI.WinForms.GunaButton
    Friend WithEvents gbFiltrar As Guna.UI.WinForms.GunaButton
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents txtCC As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblMensaje As Guna.UI.WinForms.GunaLabel
End Class
