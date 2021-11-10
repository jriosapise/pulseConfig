<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CambiarRuta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CambiarRuta))
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtContr1 = New System.Windows.Forms.TextBox()
        Me.txtUsuar1 = New System.Windows.Forms.TextBox()
        Me.txtNomBase1 = New System.Windows.Forms.TextBox()
        Me.txtServidor1 = New System.Windows.Forms.TextBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(133, 225)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(133, 25)
        Me.Label10.TabIndex = 63
        Me.Label10.Text = "Contraseña"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(172, 176)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(93, 25)
        Me.Label9.TabIndex = 62
        Me.Label9.Text = "Usuario"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(103, 121)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(163, 25)
        Me.Label8.TabIndex = 61
        Me.Label8.Text = "Base de datos"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(168, 61)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 25)
        Me.Label7.TabIndex = 60
        Me.Label7.Text = "Servidor"
        '
        'txtContr1
        '
        Me.txtContr1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContr1.Location = New System.Drawing.Point(272, 223)
        Me.txtContr1.Name = "txtContr1"
        Me.txtContr1.Size = New System.Drawing.Size(220, 31)
        Me.txtContr1.TabIndex = 59
        '
        'txtUsuar1
        '
        Me.txtUsuar1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuar1.Location = New System.Drawing.Point(272, 171)
        Me.txtUsuar1.Name = "txtUsuar1"
        Me.txtUsuar1.Size = New System.Drawing.Size(220, 31)
        Me.txtUsuar1.TabIndex = 58
        '
        'txtNomBase1
        '
        Me.txtNomBase1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomBase1.Location = New System.Drawing.Point(272, 117)
        Me.txtNomBase1.Name = "txtNomBase1"
        Me.txtNomBase1.Size = New System.Drawing.Size(220, 31)
        Me.txtNomBase1.TabIndex = 57
        '
        'txtServidor1
        '
        Me.txtServidor1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtServidor1.Location = New System.Drawing.Point(272, 60)
        Me.txtServidor1.Name = "txtServidor1"
        Me.txtServidor1.Size = New System.Drawing.Size(220, 31)
        Me.txtServidor1.TabIndex = 56
        '
        'btnGuardar
        '
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Location = New System.Drawing.Point(335, 272)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(108, 30)
        Me.btnGuardar.TabIndex = 64
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 28.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(100, 1)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(516, 45)
        Me.Label6.TabIndex = 65
        Me.Label6.Text = "Actualizar ruta de conexión"
        '
        'CambiarRuta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(670, 323)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtContr1)
        Me.Controls.Add(Me.txtUsuar1)
        Me.Controls.Add(Me.txtNomBase1)
        Me.Controls.Add(Me.txtServidor1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CambiarRuta"
        Me.Text = "Actualizar ruta"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtContr1 As System.Windows.Forms.TextBox
    Friend WithEvents txtUsuar1 As System.Windows.Forms.TextBox
    Friend WithEvents txtNomBase1 As System.Windows.Forms.TextBox
    Friend WithEvents txtServidor1 As System.Windows.Forms.TextBox
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
