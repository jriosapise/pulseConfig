<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Popup
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
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.gbFiltrar = New Guna.UI.WinForms.GunaButton()
        Me.GunaPictureBox1 = New Guna.UI.WinForms.GunaPictureBox()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaLabel1
        '
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GunaLabel1.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel1.Location = New System.Drawing.Point(171, 32)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(432, 62)
        Me.GunaLabel1.TabIndex = 44
        Me.GunaLabel1.Text = "Se ha enviado correo electrónico notificando de los cambios a la etiqueta."
        '
        'gbFiltrar
        '
        Me.gbFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbFiltrar.AnimationHoverSpeed = 0.07!
        Me.gbFiltrar.AnimationSpeed = 0.03!
        Me.gbFiltrar.BackColor = System.Drawing.Color.Transparent
        Me.gbFiltrar.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.gbFiltrar.BorderColor = System.Drawing.Color.Black
        Me.gbFiltrar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.gbFiltrar.FocusedColor = System.Drawing.Color.Empty
        Me.gbFiltrar.Font = New System.Drawing.Font("Segoe UI Semibold", 8.0!, System.Drawing.FontStyle.Bold)
        Me.gbFiltrar.ForeColor = System.Drawing.Color.White
        Me.gbFiltrar.Image = Global.GHSA_App.My.Resources.Resources.ic_Check
        Me.gbFiltrar.ImageSize = New System.Drawing.Size(12, 12)
        Me.gbFiltrar.Location = New System.Drawing.Point(475, 103)
        Me.gbFiltrar.Name = "gbFiltrar"
        Me.gbFiltrar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.gbFiltrar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.gbFiltrar.OnHoverForeColor = System.Drawing.Color.White
        Me.gbFiltrar.OnHoverImage = Nothing
        Me.gbFiltrar.OnPressedColor = System.Drawing.Color.Black
        Me.gbFiltrar.Radius = 3
        Me.gbFiltrar.Size = New System.Drawing.Size(128, 40)
        Me.gbFiltrar.TabIndex = 43
        Me.gbFiltrar.Text = "ACEPTAR"
        Me.gbFiltrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaPictureBox1
        '
        Me.GunaPictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox1.Image = Global.GHSA_App.My.Resources.Resources.Email_1_02_512
        Me.GunaPictureBox1.Location = New System.Drawing.Point(36, 24)
        Me.GunaPictureBox1.Name = "GunaPictureBox1"
        Me.GunaPictureBox1.Size = New System.Drawing.Size(102, 70)
        Me.GunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.GunaPictureBox1.TabIndex = 0
        Me.GunaPictureBox1.TabStop = False
        '
        'Popup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(649, 155)
        Me.Controls.Add(Me.GunaLabel1)
        Me.Controls.Add(Me.gbFiltrar)
        Me.Controls.Add(Me.GunaPictureBox1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "Popup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alerta"
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GunaPictureBox1 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents gbFiltrar As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
End Class
