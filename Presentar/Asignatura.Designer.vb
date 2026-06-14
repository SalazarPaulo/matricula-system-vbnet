<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Asignatura
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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Btn_Seleccionar = New System.Windows.Forms.Button()
        Me.Rb_Asignatura = New System.Windows.Forms.RadioButton()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Rb_Grupo = New System.Windows.Forms.RadioButton()
        Me.Rb_SubGrupo_Lab = New System.Windows.Forms.RadioButton()
        Me.Rb_Facultad = New System.Windows.Forms.RadioButton()
        Me.Rb_Carrera = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.dgvAsignatura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvAsignatura
        '
        Me.dgvAsignatura.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvAsignatura.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvAsignatura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAsignatura.Location = New System.Drawing.Point(171, 61)
        Me.dgvAsignatura.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvAsignatura.Name = "dgvAsignatura"
        Me.dgvAsignatura.RowTemplate.Height = 28
        Me.dgvAsignatura.Size = New System.Drawing.Size(315, 210)
        Me.dgvAsignatura.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button1.Location = New System.Drawing.Point(2, 2)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(143, 22)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Insertar Datos"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button2.Location = New System.Drawing.Point(2, 28)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(143, 22)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Editar Datos"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button3.Location = New System.Drawing.Point(2, 54)
        Me.Button3.Margin = New System.Windows.Forms.Padding(2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(143, 24)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Eliminar Datos"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Btn_Seleccionar
        '
        Me.Btn_Seleccionar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Btn_Seleccionar.Location = New System.Drawing.Point(2, 107)
        Me.Btn_Seleccionar.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_Seleccionar.Name = "Btn_Seleccionar"
        Me.Btn_Seleccionar.Size = New System.Drawing.Size(143, 30)
        Me.Btn_Seleccionar.TabIndex = 4
        Me.Btn_Seleccionar.Text = "Visualizar Datos"
        Me.Btn_Seleccionar.UseVisualStyleBackColor = True
        '
        'Rb_Asignatura
        '
        Me.Rb_Asignatura.AutoSize = True
        Me.Rb_Asignatura.Location = New System.Drawing.Point(2, 2)
        Me.Rb_Asignatura.Margin = New System.Windows.Forms.Padding(2)
        Me.Rb_Asignatura.Name = "Rb_Asignatura"
        Me.Rb_Asignatura.Size = New System.Drawing.Size(75, 17)
        Me.Rb_Asignatura.TabIndex = 5
        Me.Rb_Asignatura.TabStop = True
        Me.Rb_Asignatura.Text = "Asignatura"
        Me.Rb_Asignatura.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Rb_Grupo, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Rb_SubGrupo_Lab, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Rb_Facultad, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Btn_Seleccionar, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Rb_Carrera, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Rb_Asignatura, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(18, 61)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(2)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(147, 138)
        Me.TableLayoutPanel1.TabIndex = 6
        '
        'Rb_Grupo
        '
        Me.Rb_Grupo.AutoSize = True
        Me.Rb_Grupo.Location = New System.Drawing.Point(2, 86)
        Me.Rb_Grupo.Margin = New System.Windows.Forms.Padding(2)
        Me.Rb_Grupo.Name = "Rb_Grupo"
        Me.Rb_Grupo.Size = New System.Drawing.Size(54, 17)
        Me.Rb_Grupo.TabIndex = 9
        Me.Rb_Grupo.TabStop = True
        Me.Rb_Grupo.Text = "Grupo"
        Me.Rb_Grupo.UseVisualStyleBackColor = True
        '
        'Rb_SubGrupo_Lab
        '
        Me.Rb_SubGrupo_Lab.AutoSize = True
        Me.Rb_SubGrupo_Lab.Location = New System.Drawing.Point(2, 65)
        Me.Rb_SubGrupo_Lab.Margin = New System.Windows.Forms.Padding(2)
        Me.Rb_SubGrupo_Lab.Name = "Rb_SubGrupo_Lab"
        Me.Rb_SubGrupo_Lab.Size = New System.Drawing.Size(97, 17)
        Me.Rb_SubGrupo_Lab.TabIndex = 8
        Me.Rb_SubGrupo_Lab.TabStop = True
        Me.Rb_SubGrupo_Lab.Text = "SubGrupo_Lab"
        Me.Rb_SubGrupo_Lab.UseVisualStyleBackColor = True
        '
        'Rb_Facultad
        '
        Me.Rb_Facultad.AutoSize = True
        Me.Rb_Facultad.Location = New System.Drawing.Point(2, 44)
        Me.Rb_Facultad.Margin = New System.Windows.Forms.Padding(2)
        Me.Rb_Facultad.Name = "Rb_Facultad"
        Me.Rb_Facultad.Size = New System.Drawing.Size(66, 17)
        Me.Rb_Facultad.TabIndex = 7
        Me.Rb_Facultad.TabStop = True
        Me.Rb_Facultad.Text = "Facultad"
        Me.Rb_Facultad.UseVisualStyleBackColor = True
        '
        'Rb_Carrera
        '
        Me.Rb_Carrera.AutoSize = True
        Me.Rb_Carrera.Location = New System.Drawing.Point(2, 23)
        Me.Rb_Carrera.Margin = New System.Windows.Forms.Padding(2)
        Me.Rb_Carrera.Name = "Rb_Carrera"
        Me.Rb_Carrera.Size = New System.Drawing.Size(59, 17)
        Me.Rb_Carrera.TabIndex = 6
        Me.Rb_Carrera.TabStop = True
        Me.Rb_Carrera.Text = "Carrera"
        Me.Rb_Carrera.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Consolas", 21.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(209, 13)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(335, 34)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "MATRICULA ASIGNATURA"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Button1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Button2, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Button3, 0, 2)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(18, 214)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(2)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 3
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 14.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(147, 80)
        Me.TableLayoutPanel2.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(28, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 19)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Usuario:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(115, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 19)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Label3"
        '
        'Asignatura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(555, 303)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.dgvAsignatura)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Asignatura"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Asignatura"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvAsignatura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvAsignatura As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Btn_Seleccionar As Button
    Friend WithEvents Rb_Asignatura As RadioButton
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Rb_Facultad As RadioButton
    Friend WithEvents Rb_Carrera As RadioButton
    Friend WithEvents Rb_SubGrupo_Lab As RadioButton
    Friend WithEvents Rb_Grupo As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
