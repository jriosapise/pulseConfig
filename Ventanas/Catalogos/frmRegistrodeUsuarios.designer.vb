<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegistrodeUsuarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRegistrodeUsuarios))
        Me.GunaElipsePanel1 = New Guna.UI.WinForms.GunaElipsePanel()
        Me.GunaLabel10 = New Guna.UI.WinForms.GunaLabel()
        Me.cbRoles = New System.Windows.Forms.ComboBox()
        Me.btnImg = New System.Windows.Forms.Button()
        Me.lblimageid = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnCambiarcontra = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.cmbArea = New System.Windows.Forms.ComboBox()
        Me.cmbPlanta = New System.Windows.Forms.ComboBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.txtTel = New System.Windows.Forms.TextBox()
        Me.txtNumeroEmpleado = New System.Windows.Forms.TextBox()
        Me.txtrango = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.GunaLabel9 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel8 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel7 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel6 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.fdImageDialog = New System.Windows.Forms.OpenFileDialog()
        Me.GunaElipsePanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaElipsePanel1
        '
        Me.GunaElipsePanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.GunaElipsePanel1.BaseColor = System.Drawing.Color.Empty
        Me.GunaElipsePanel1.Controls.Add(Me.GunaLabel10)
        Me.GunaElipsePanel1.Controls.Add(Me.cbRoles)
        Me.GunaElipsePanel1.Controls.Add(Me.btnImg)
        Me.GunaElipsePanel1.Controls.Add(Me.lblimageid)
        Me.GunaElipsePanel1.Controls.Add(Me.PictureBox1)
        Me.GunaElipsePanel1.Controls.Add(Me.btnCambiarcontra)
        Me.GunaElipsePanel1.Controls.Add(Me.btnGuardar)
        Me.GunaElipsePanel1.Controls.Add(Me.btnEliminar)
        Me.GunaElipsePanel1.Controls.Add(Me.cmbArea)
        Me.GunaElipsePanel1.Controls.Add(Me.cmbPlanta)
        Me.GunaElipsePanel1.Controls.Add(Me.txtApellido)
        Me.GunaElipsePanel1.Controls.Add(Me.txtTel)
        Me.GunaElipsePanel1.Controls.Add(Me.txtNumeroEmpleado)
        Me.GunaElipsePanel1.Controls.Add(Me.txtrango)
        Me.GunaElipsePanel1.Controls.Add(Me.txtNombre)
        Me.GunaElipsePanel1.Controls.Add(Me.txtpassword)
        Me.GunaElipsePanel1.Controls.Add(Me.GunaLabel9)
        Me.GunaElipsePanel1.Controls.Add(Me.GunaLabel8)
        Me.GunaElipsePanel1.Controls.Add(Me.GunaLabel7)
        Me.GunaElipsePanel1.Controls.Add(Me.GunaLabel6)
        Me.GunaElipsePanel1.Controls.Add(Me.GunaLabel5)
        Me.GunaElipsePanel1.Controls.Add(Me.GunaLabel4)
        Me.GunaElipsePanel1.Controls.Add(Me.GunaLabel3)
        Me.GunaElipsePanel1.Controls.Add(Me.GunaLabel2)
        Me.GunaElipsePanel1.Controls.Add(Me.txtId)
        Me.GunaElipsePanel1.Controls.Add(Me.GunaLabel1)
        Me.GunaElipsePanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GunaElipsePanel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaElipsePanel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GunaElipsePanel1.Location = New System.Drawing.Point(0, 0)
        Me.GunaElipsePanel1.Name = "GunaElipsePanel1"
        Me.GunaElipsePanel1.Size = New System.Drawing.Size(860, 558)
        Me.GunaElipsePanel1.TabIndex = 0
        '
        'GunaLabel10
        '
        Me.GunaLabel10.AutoSize = True
        Me.GunaLabel10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel10.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GunaLabel10.Location = New System.Drawing.Point(308, 394)
        Me.GunaLabel10.Name = "GunaLabel10"
        Me.GunaLabel10.Size = New System.Drawing.Size(153, 25)
        Me.GunaLabel10.TabIndex = 82
        Me.GunaLabel10.Text = "Tipo Usuario:"
        '
        'cbRoles
        '
        Me.cbRoles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbRoles.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbRoles.FormattingEnabled = True
        Me.cbRoles.Location = New System.Drawing.Point(462, 391)
        Me.cbRoles.Name = "cbRoles"
        Me.cbRoles.Size = New System.Drawing.Size(217, 33)
        Me.cbRoles.TabIndex = 62
        '
        'btnImg
        '
        Me.btnImg.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnImg.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        Me.btnImg.ForeColor = System.Drawing.Color.White
        Me.btnImg.Location = New System.Drawing.Point(70, 301)
        Me.btnImg.Name = "btnImg"
        Me.btnImg.Size = New System.Drawing.Size(174, 42)
        Me.btnImg.TabIndex = 65
        Me.btnImg.Text = "IMAGEN"
        Me.btnImg.UseVisualStyleBackColor = False
        '
        'lblimageid
        '
        Me.lblimageid.AutoSize = True
        Me.lblimageid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblimageid.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblimageid.Location = New System.Drawing.Point(708, 50)
        Me.lblimageid.Name = "lblimageid"
        Me.lblimageid.Size = New System.Drawing.Size(63, 16)
        Me.lblimageid.TabIndex = 40
        Me.lblimageid.Text = "Label13"
        Me.lblimageid.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(40, 91)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(234, 204)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 39
        Me.PictureBox1.TabStop = False
        '
        'btnCambiarcontra
        '
        Me.btnCambiarcontra.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.btnCambiarcontra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCambiarcontra.ForeColor = System.Drawing.Color.White
        Me.btnCambiarcontra.Location = New System.Drawing.Point(462, 239)
        Me.btnCambiarcontra.Name = "btnCambiarcontra"
        Me.btnCambiarcontra.Size = New System.Drawing.Size(122, 33)
        Me.btnCambiarcontra.TabIndex = 38
        Me.btnCambiarcontra.Text = "CONTRASEÑA"
        Me.btnCambiarcontra.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        Me.btnGuardar.ForeColor = System.Drawing.Color.White
        Me.btnGuardar.Location = New System.Drawing.Point(380, 449)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(174, 42)
        Me.btnGuardar.TabIndex = 70
        Me.btnGuardar.Text = "GUARDAR"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        Me.btnEliminar.ForeColor = System.Drawing.Color.White
        Me.btnEliminar.Location = New System.Drawing.Point(581, 449)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(174, 42)
        Me.btnEliminar.TabIndex = 80
        Me.btnEliminar.Text = "ELIMINAR"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'cmbArea
        '
        Me.cmbArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbArea.FormattingEnabled = True
        Me.cmbArea.Location = New System.Drawing.Point(462, 352)
        Me.cmbArea.Name = "cmbArea"
        Me.cmbArea.Size = New System.Drawing.Size(217, 33)
        Me.cmbArea.TabIndex = 60
        '
        'cmbPlanta
        '
        Me.cmbPlanta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPlanta.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPlanta.FormattingEnabled = True
        Me.cmbPlanta.Location = New System.Drawing.Point(462, 313)
        Me.cmbPlanta.Name = "cmbPlanta"
        Me.cmbPlanta.Size = New System.Drawing.Size(217, 33)
        Me.cmbPlanta.TabIndex = 50
        '
        'txtApellido
        '
        Me.txtApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellido.Location = New System.Drawing.Point(462, 202)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(290, 31)
        Me.txtApellido.TabIndex = 22
        '
        'txtTel
        '
        Me.txtTel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTel.Location = New System.Drawing.Point(462, 276)
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(217, 31)
        Me.txtTel.TabIndex = 40
        '
        'txtNumeroEmpleado
        '
        Me.txtNumeroEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumeroEmpleado.Location = New System.Drawing.Point(462, 128)
        Me.txtNumeroEmpleado.Name = "txtNumeroEmpleado"
        Me.txtNumeroEmpleado.Size = New System.Drawing.Size(217, 31)
        Me.txtNumeroEmpleado.TabIndex = 10
        '
        'txtrango
        '
        Me.txtrango.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrango.Location = New System.Drawing.Point(462, 91)
        Me.txtrango.Name = "txtrango"
        Me.txtrango.Size = New System.Drawing.Size(217, 31)
        Me.txtrango.TabIndex = 1
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(462, 165)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(290, 31)
        Me.txtNombre.TabIndex = 20
        '
        'txtpassword
        '
        Me.txtpassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpassword.Location = New System.Drawing.Point(462, 239)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Size = New System.Drawing.Size(217, 31)
        Me.txtpassword.TabIndex = 30
        '
        'GunaLabel9
        '
        Me.GunaLabel9.AutoSize = True
        Me.GunaLabel9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel9.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GunaLabel9.Location = New System.Drawing.Point(356, 355)
        Me.GunaLabel9.Name = "GunaLabel9"
        Me.GunaLabel9.Size = New System.Drawing.Size(103, 25)
        Me.GunaLabel9.TabIndex = 18
        Me.GunaLabel9.Text = "División:"
        '
        'GunaLabel8
        '
        Me.GunaLabel8.AutoSize = True
        Me.GunaLabel8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GunaLabel8.Location = New System.Drawing.Point(375, 316)
        Me.GunaLabel8.Name = "GunaLabel8"
        Me.GunaLabel8.Size = New System.Drawing.Size(86, 25)
        Me.GunaLabel8.TabIndex = 16
        Me.GunaLabel8.Text = "Planta:"
        '
        'GunaLabel7
        '
        Me.GunaLabel7.AutoSize = True
        Me.GunaLabel7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GunaLabel7.Location = New System.Drawing.Point(285, 131)
        Me.GunaLabel7.Name = "GunaLabel7"
        Me.GunaLabel7.Size = New System.Drawing.Size(176, 25)
        Me.GunaLabel7.TabIndex = 8
        Me.GunaLabel7.Text = "# de Empleado:"
        '
        'GunaLabel6
        '
        Me.GunaLabel6.AutoSize = True
        Me.GunaLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GunaLabel6.Location = New System.Drawing.Point(350, 279)
        Me.GunaLabel6.Name = "GunaLabel6"
        Me.GunaLabel6.Size = New System.Drawing.Size(111, 25)
        Me.GunaLabel6.TabIndex = 7
        Me.GunaLabel6.Text = "Telefono:"
        '
        'GunaLabel5
        '
        Me.GunaLabel5.AutoSize = True
        Me.GunaLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GunaLabel5.Location = New System.Drawing.Point(357, 205)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(104, 25)
        Me.GunaLabel5.TabIndex = 6
        Me.GunaLabel5.Text = "Apellido:"
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GunaLabel4.Location = New System.Drawing.Point(361, 168)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(100, 25)
        Me.GunaLabel4.TabIndex = 5
        Me.GunaLabel4.Text = "Nombre:"
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GunaLabel3.Location = New System.Drawing.Point(321, 239)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(140, 25)
        Me.GunaLabel3.TabIndex = 4
        Me.GunaLabel3.Text = "Contraseña:"
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GunaLabel2.Location = New System.Drawing.Point(361, 94)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(100, 25)
        Me.GunaLabel2.TabIndex = 3
        Me.GunaLabel2.Text = "Usuario:"
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(802, 460)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(46, 31)
        Me.txtId.TabIndex = 2
        Me.txtId.Visible = False
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GunaLabel1.Location = New System.Drawing.Point(24, 23)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(372, 31)
        Me.GunaLabel1.TabIndex = 1
        Me.GunaLabel1.Text = "REGISTRO DE USUARIOS"
        '
        'fdImageDialog
        '
        Me.fdImageDialog.FileName = "OpenFileDialog1"
        '
        'frmRegistrodeUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(860, 558)
        Me.Controls.Add(Me.GunaElipsePanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmRegistrodeUsuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Registro de Usuarios"
        Me.GunaElipsePanel1.ResumeLayout(False)
        Me.GunaElipsePanel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GunaElipsePanel1 As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents GunaLabel7 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel6 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel9 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel8 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents cmbArea As System.Windows.Forms.ComboBox
    Friend WithEvents cmbPlanta As System.Windows.Forms.ComboBox
    Friend WithEvents txtApellido As System.Windows.Forms.TextBox
    Friend WithEvents txtTel As System.Windows.Forms.TextBox
    Friend WithEvents txtNumeroEmpleado As System.Windows.Forms.TextBox
    Friend WithEvents txtrango As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtpassword As System.Windows.Forms.TextBox
    Friend WithEvents btnCambiarcontra As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents fdImageDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents lblimageid As System.Windows.Forms.Label
    Friend WithEvents btnImg As System.Windows.Forms.Button
    Friend WithEvents cbRoles As System.Windows.Forms.ComboBox
    Friend WithEvents GunaLabel10 As Guna.UI.WinForms.GunaLabel
End Class
