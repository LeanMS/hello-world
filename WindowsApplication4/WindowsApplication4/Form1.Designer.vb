<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.txt_nomUsuario = New System.Windows.Forms.TextBox()
        Me.lbl_usuario = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_apellido = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmb_Provincia = New System.Windows.Forms.ComboBox()
        Me.cargar_usuario = New System.Windows.Forms.Button()
        Me.txt_idUsuario = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmb_dni = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_idProvincia = New System.Windows.Forms.TextBox()
        Me.txt_nombreProvincia = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txt_nomUsuario
        '
        Me.txt_nomUsuario.Location = New System.Drawing.Point(62, 12)
        Me.txt_nomUsuario.Name = "txt_nomUsuario"
        Me.txt_nomUsuario.Size = New System.Drawing.Size(153, 20)
        Me.txt_nomUsuario.TabIndex = 0
        '
        'lbl_usuario
        '
        Me.lbl_usuario.AutoSize = True
        Me.lbl_usuario.Location = New System.Drawing.Point(12, 15)
        Me.lbl_usuario.Name = "lbl_usuario"
        Me.lbl_usuario.Size = New System.Drawing.Size(44, 13)
        Me.lbl_usuario.TabIndex = 1
        Me.lbl_usuario.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Apellido"
        '
        'txt_apellido
        '
        Me.txt_apellido.Location = New System.Drawing.Point(62, 38)
        Me.txt_apellido.Name = "txt_apellido"
        Me.txt_apellido.Size = New System.Drawing.Size(153, 20)
        Me.txt_apellido.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(221, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Provincia"
        '
        'cmb_Provincia
        '
        Me.cmb_Provincia.FormattingEnabled = True
        Me.cmb_Provincia.Location = New System.Drawing.Point(277, 11)
        Me.cmb_Provincia.Name = "cmb_Provincia"
        Me.cmb_Provincia.Size = New System.Drawing.Size(153, 21)
        Me.cmb_Provincia.TabIndex = 9
        '
        'cargar_usuario
        '
        Me.cargar_usuario.Location = New System.Drawing.Point(277, 109)
        Me.cargar_usuario.Name = "cargar_usuario"
        Me.cargar_usuario.Size = New System.Drawing.Size(75, 23)
        Me.cargar_usuario.TabIndex = 10
        Me.cargar_usuario.Text = "Cargar Usuario"
        Me.cargar_usuario.UseVisualStyleBackColor = True
        '
        'txt_idUsuario
        '
        Me.txt_idUsuario.Location = New System.Drawing.Point(277, 38)
        Me.txt_idUsuario.Name = "txt_idUsuario"
        Me.txt_idUsuario.Size = New System.Drawing.Size(100, 20)
        Me.txt_idUsuario.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(221, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Id Usuario"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "DNI"
        '
        'cmb_dni
        '
        Me.cmb_dni.FormattingEnabled = True
        Me.cmb_dni.Location = New System.Drawing.Point(62, 69)
        Me.cmb_dni.Name = "cmb_dni"
        Me.cmb_dni.Size = New System.Drawing.Size(121, 21)
        Me.cmb_dni.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(221, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Provincia"
        '
        'txt_idProvincia
        '
        Me.txt_idProvincia.Location = New System.Drawing.Point(277, 65)
        Me.txt_idProvincia.Name = "txt_idProvincia"
        Me.txt_idProvincia.Size = New System.Drawing.Size(24, 20)
        Me.txt_idProvincia.TabIndex = 16
        '
        'txt_nombreProvincia
        '
        Me.txt_nombreProvincia.Location = New System.Drawing.Point(307, 65)
        Me.txt_nombreProvincia.Name = "txt_nombreProvincia"
        Me.txt_nombreProvincia.Size = New System.Drawing.Size(100, 20)
        Me.txt_nombreProvincia.TabIndex = 17
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(437, 167)
        Me.Controls.Add(Me.txt_nombreProvincia)
        Me.Controls.Add(Me.txt_idProvincia)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmb_dni)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_idUsuario)
        Me.Controls.Add(Me.cargar_usuario)
        Me.Controls.Add(Me.cmb_Provincia)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_apellido)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_usuario)
        Me.Controls.Add(Me.txt_nomUsuario)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_nomUsuario As TextBox
    Friend WithEvents lbl_usuario As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_apellido As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmb_Provincia As ComboBox
    Friend WithEvents cargar_usuario As Button
    Friend WithEvents txt_idUsuario As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cmb_dni As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_idProvincia As TextBox
    Friend WithEvents txt_nombreProvincia As TextBox
End Class
