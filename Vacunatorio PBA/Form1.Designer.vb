<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbtMasc = New System.Windows.Forms.RadioButton()
        Me.rbtFem = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.btnMostrar = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.txtApellidoNombre = New System.Windows.Forms.TextBox()
        Me.cmbGruPob = New System.Windows.Forms.ComboBox()
        Me.MtxtDNI = New System.Windows.Forms.MaskedTextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DNI"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Apellido y Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Grupo Poblacional"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbtMasc)
        Me.GroupBox1.Controls.Add(Me.rbtFem)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 155)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(181, 49)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sexo que figura en el DNI"
        '
        'rbtMasc
        '
        Me.rbtMasc.AutoSize = True
        Me.rbtMasc.Location = New System.Drawing.Point(102, 26)
        Me.rbtMasc.Name = "rbtMasc"
        Me.rbtMasc.Size = New System.Drawing.Size(73, 17)
        Me.rbtMasc.TabIndex = 1
        Me.rbtMasc.TabStop = True
        Me.rbtMasc.Text = "Masculino"
        Me.rbtMasc.UseVisualStyleBackColor = True
        '
        'rbtFem
        '
        Me.rbtFem.AutoSize = True
        Me.rbtFem.Location = New System.Drawing.Point(6, 26)
        Me.rbtFem.Name = "rbtFem"
        Me.rbtFem.Size = New System.Drawing.Size(71, 17)
        Me.rbtFem.TabIndex = 0
        Me.rbtFem.TabStop = True
        Me.rbtFem.Text = "Femenino"
        Me.rbtFem.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBox6)
        Me.GroupBox2.Controls.Add(Me.TextBox5)
        Me.GroupBox2.Controls.Add(Me.TextBox4)
        Me.GroupBox2.Controls.Add(Me.TextBox3)
        Me.GroupBox2.Controls.Add(Me.TextBox2)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.ListView1)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(24, 233)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(378, 262)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Mostrar Resultados"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(310, 110)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(49, 20)
        Me.TextBox6.TabIndex = 13
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(189, 110)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(49, 20)
        Me.TextBox5.TabIndex = 12
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(77, 110)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(49, 20)
        Me.TextBox4.TabIndex = 11
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(224, 56)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(49, 20)
        Me.TextBox3.TabIndex = 10
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(96, 56)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(49, 20)
        Me.TextBox2.TabIndex = 9
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(15, 139)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(113, 13)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "-Docentes Vacunados"
        '
        'ListView1
        '
        Me.ListView1.Location = New System.Drawing.Point(30, 155)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(274, 97)
        Me.ListView1.TabIndex = 7
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(249, 113)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(55, 13)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Seguridad"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(127, 113)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 13)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Docentes:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(34, 113)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(37, 13)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Salud:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(160, 59)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Masculino:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(34, 59)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Femenino:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 86)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(231, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "-Cantidad de vacunados por Grupo Poblacional"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(168, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "-Cantidad de vacunados por Sexo"
        '
        'btnIngresar
        '
        Me.btnIngresar.BackColor = System.Drawing.SystemColors.Control
        Me.btnIngresar.Location = New System.Drawing.Point(421, 21)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(75, 41)
        Me.btnIngresar.TabIndex = 5
        Me.btnIngresar.Text = "Ingresar"
        Me.btnIngresar.UseVisualStyleBackColor = False
        '
        'btnMostrar
        '
        Me.btnMostrar.Location = New System.Drawing.Point(421, 95)
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(75, 41)
        Me.btnMostrar.TabIndex = 6
        Me.btnMostrar.Text = "Mostrar"
        Me.btnMostrar.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(421, 388)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 40)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "Salir"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'txtApellidoNombre
        '
        Me.txtApellidoNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtApellidoNombre.Location = New System.Drawing.Point(126, 63)
        Me.txtApellidoNombre.MaxLength = 50
        Me.txtApellidoNombre.Name = "txtApellidoNombre"
        Me.txtApellidoNombre.Size = New System.Drawing.Size(202, 20)
        Me.txtApellidoNombre.TabIndex = 2
        '
        'cmbGruPob
        '
        Me.cmbGruPob.FormattingEnabled = True
        Me.cmbGruPob.Items.AddRange(New Object() {"Salud", "Docentes", "Seguridad"})
        Me.cmbGruPob.Location = New System.Drawing.Point(126, 106)
        Me.cmbGruPob.Name = "cmbGruPob"
        Me.cmbGruPob.Size = New System.Drawing.Size(144, 21)
        Me.cmbGruPob.TabIndex = 3
        '
        'MtxtDNI
        '
        Me.MtxtDNI.Location = New System.Drawing.Point(69, 21)
        Me.MtxtDNI.Mask = "99.999.999"
        Me.MtxtDNI.Name = "MtxtDNI"
        Me.MtxtDNI.Size = New System.Drawing.Size(100, 20)
        Me.MtxtDNI.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(515, 499)
        Me.Controls.Add(Me.MtxtDNI)
        Me.Controls.Add(Me.cmbGruPob)
        Me.Controls.Add(Me.txtApellidoNombre)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btnMostrar)
        Me.Controls.Add(Me.btnIngresar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Vacunatorio PBA"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbtMasc As System.Windows.Forms.RadioButton
    Friend WithEvents rbtFem As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnIngresar As System.Windows.Forms.Button
    Friend WithEvents btnMostrar As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents txtApellidoNombre As System.Windows.Forms.TextBox
    Friend WithEvents cmbGruPob As System.Windows.Forms.ComboBox
    Friend WithEvents MtxtDNI As System.Windows.Forms.MaskedTextBox

    '---------------------------------------------------------------------------------------
    'COD PARA PERMITIR SOLO CARACTERES STRING EN APELLIDO Y NOMBRE

    Private Sub txtApellidoNombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtApellidoNombre.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub



End Class

