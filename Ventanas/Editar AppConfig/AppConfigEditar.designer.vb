<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AppConfigEditar
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AppConfigEditar))
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBascula1 = New System.Windows.Forms.TextBox()
        Me.txtImagenesUser = New System.Windows.Forms.TextBox()
        Me.txtRutaImagenes = New System.Windows.Forms.TextBox()
        Me.txtManiFodler = New System.Windows.Forms.TextBox()
        Me.txtRuta = New System.Windows.Forms.TextBox()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnCambiar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 28.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(157, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(534, 45)
        Me.Label6.TabIndex = 60
        Me.Label6.Text = "Configuración de Aplicación"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(45, 285)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(292, 25)
        Me.Label5.TabIndex = 59
        Me.Label5.Text = "Ruta para exportar a excel"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(17, 238)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(320, 25)
        Me.Label4.TabIndex = 58
        Me.Label4.Text = "Ruta de imagenes de usuario"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(135, 195)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(202, 25)
        Me.Label3.TabIndex = 57
        Me.Label3.Text = "Ruta de imagenes"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(116, 156)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(221, 25)
        Me.Label2.TabIndex = 56
        Me.Label2.Text = "Ruta de manifiestos"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(276, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 25)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "Ruta"
        '
        'txtBascula1
        '
        Me.txtBascula1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBascula1.Location = New System.Drawing.Point(343, 279)
        Me.txtBascula1.Name = "txtBascula1"
        Me.txtBascula1.Size = New System.Drawing.Size(476, 29)
        Me.txtBascula1.TabIndex = 54
        '
        'txtImagenesUser
        '
        Me.txtImagenesUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImagenesUser.Location = New System.Drawing.Point(343, 237)
        Me.txtImagenesUser.Name = "txtImagenesUser"
        Me.txtImagenesUser.Size = New System.Drawing.Size(476, 29)
        Me.txtImagenesUser.TabIndex = 53
        '
        'txtRutaImagenes
        '
        Me.txtRutaImagenes.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRutaImagenes.Location = New System.Drawing.Point(343, 195)
        Me.txtRutaImagenes.Name = "txtRutaImagenes"
        Me.txtRutaImagenes.Size = New System.Drawing.Size(476, 29)
        Me.txtRutaImagenes.TabIndex = 52
        '
        'txtManiFodler
        '
        Me.txtManiFodler.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtManiFodler.Location = New System.Drawing.Point(343, 153)
        Me.txtManiFodler.Name = "txtManiFodler"
        Me.txtManiFodler.Size = New System.Drawing.Size(476, 29)
        Me.txtManiFodler.TabIndex = 51
        '
        'txtRuta
        '
        Me.txtRuta.Enabled = False
        Me.txtRuta.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRuta.Location = New System.Drawing.Point(343, 83)
        Me.txtRuta.Multiline = True
        Me.txtRuta.Name = "txtRuta"
        Me.txtRuta.Size = New System.Drawing.Size(476, 54)
        Me.txtRuta.TabIndex = 50
        '
        'btnCerrar
        '
        Me.btnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.Location = New System.Drawing.Point(44, 334)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(108, 30)
        Me.btnCerrar.TabIndex = 49
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Location = New System.Drawing.Point(754, 334)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(108, 30)
        Me.btnGuardar.TabIndex = 48
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnCambiar
        '
        Me.btnCambiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCambiar.Location = New System.Drawing.Point(835, 79)
        Me.btnCambiar.Name = "btnCambiar"
        Me.btnCambiar.Size = New System.Drawing.Size(108, 73)
        Me.btnCambiar.TabIndex = 61
        Me.btnCambiar.Text = "Cambiar ruta de conexión"
        Me.btnCambiar.UseVisualStyleBackColor = True
        '
        'AppConfigEditar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(955, 390)
        Me.Controls.Add(Me.btnCambiar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtBascula1)
        Me.Controls.Add(Me.txtImagenesUser)
        Me.Controls.Add(Me.txtRutaImagenes)
        Me.Controls.Add(Me.txtManiFodler)
        Me.Controls.Add(Me.txtRuta)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AppConfigEditar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AppConfigEditar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtBascula1 As System.Windows.Forms.TextBox
    Friend WithEvents txtImagenesUser As System.Windows.Forms.TextBox
    Friend WithEvents txtRutaImagenes As System.Windows.Forms.TextBox
    Friend WithEvents txtManiFodler As System.Windows.Forms.TextBox
    Friend WithEvents txtRuta As System.Windows.Forms.TextBox
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnCambiar As System.Windows.Forms.Button
End Class
