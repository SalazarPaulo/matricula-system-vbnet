<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Horario
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
        Me.dgvAsignatura = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Grupo = New System.Windows.Forms.CheckBox()
        Me.Profesor = New System.Windows.Forms.CheckBox()
        Me.Sede = New System.Windows.Forms.CheckBox()
        Me.Carrera = New System.Windows.Forms.CheckBox()
        Me.Asignatura = New System.Windows.Forms.CheckBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Facultad = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.dgvAsignatura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvAsignatura
        '
        Me.dgvAsignatura.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvAsignatura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAsignatura.Location = New System.Drawing.Point(323, 61)
        Me.dgvAsignatura.Name = "dgvAsignatura"
        Me.dgvAsignatura.ReadOnly = True
        Me.dgvAsignatura.Size = New System.Drawing.Size(416, 226)
        Me.dgvAsignatura.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(51, 253)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(121, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Visualizar Datos"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Consolas", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(34, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 37)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Sección:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Consolas", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(219, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 37)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Label2"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(-15, -15)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox1.TabIndex = 5
        Me.CheckBox1.Text = "CheckBox1"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Grupo
        '
        Me.Grupo.AutoSize = True
        Me.Grupo.Location = New System.Drawing.Point(26, 101)
        Me.Grupo.Name = "Grupo"
        Me.Grupo.Size = New System.Drawing.Size(55, 17)
        Me.Grupo.TabIndex = 6
        Me.Grupo.Text = "Grupo"
        Me.Grupo.UseVisualStyleBackColor = True
        '
        'Profesor
        '
        Me.Profesor.AutoSize = True
        Me.Profesor.Location = New System.Drawing.Point(26, 127)
        Me.Profesor.Name = "Profesor"
        Me.Profesor.Size = New System.Drawing.Size(65, 17)
        Me.Profesor.TabIndex = 7
        Me.Profesor.Text = "Profesor"
        Me.Profesor.UseVisualStyleBackColor = True
        '
        'Sede
        '
        Me.Sede.AutoSize = True
        Me.Sede.Location = New System.Drawing.Point(26, 178)
        Me.Sede.Name = "Sede"
        Me.Sede.Size = New System.Drawing.Size(51, 17)
        Me.Sede.TabIndex = 8
        Me.Sede.Text = "Sede"
        Me.Sede.UseVisualStyleBackColor = True
        '
        'Carrera
        '
        Me.Carrera.AutoSize = True
        Me.Carrera.Location = New System.Drawing.Point(26, 153)
        Me.Carrera.Name = "Carrera"
        Me.Carrera.Size = New System.Drawing.Size(60, 17)
        Me.Carrera.TabIndex = 9
        Me.Carrera.Text = "Carrera"
        Me.Carrera.UseVisualStyleBackColor = True
        '
        'Asignatura
        '
        Me.Asignatura.AutoSize = True
        Me.Asignatura.Location = New System.Drawing.Point(26, 204)
        Me.Asignatura.Name = "Asignatura"
        Me.Asignatura.Size = New System.Drawing.Size(76, 17)
        Me.Asignatura.TabIndex = 10
        Me.Asignatura.Text = "Asignatura"
        Me.Asignatura.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(112, 121)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 11
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(112, 201)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 12
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(112, 150)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 13
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(112, 176)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 20)
        Me.TextBox4.TabIndex = 14
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(112, 95)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(100, 20)
        Me.TextBox5.TabIndex = 15
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(112, 228)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(100, 20)
        Me.TextBox6.TabIndex = 17
        '
        'Facultad
        '
        Me.Facultad.AutoSize = True
        Me.Facultad.Location = New System.Drawing.Point(26, 230)
        Me.Facultad.Name = "Facultad"
        Me.Facultad.Size = New System.Drawing.Size(67, 17)
        Me.Facultad.TabIndex = 16
        Me.Facultad.Text = "Facultad"
        Me.Facultad.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(223, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "ID_Docente"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(223, 234)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Codigo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(223, 183)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "ID_Docente"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(223, 157)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 13)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Codigo_Carrera"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(223, 102)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 13)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "ID Grupo"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(223, 208)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(93, 13)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Codigo Asignatura"
        '
        'Horario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(775, 359)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.Facultad)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Asignatura)
        Me.Controls.Add(Me.Carrera)
        Me.Controls.Add(Me.Sede)
        Me.Controls.Add(Me.Profesor)
        Me.Controls.Add(Me.Grupo)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dgvAsignatura)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Horario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Horario"
        CType(Me.dgvAsignatura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvAsignatura As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Grupo As CheckBox
    Friend WithEvents Profesor As CheckBox
    Friend WithEvents Sede As CheckBox
    Friend WithEvents Carrera As CheckBox
    Friend WithEvents Asignatura As CheckBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Facultad As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
End Class
