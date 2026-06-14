<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Docente
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
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Btn_Seleccionar = New System.Windows.Forms.Button()
        Me.Rb_Sede = New System.Windows.Forms.RadioButton()
        Me.Rb_Profesor = New System.Windows.Forms.RadioButton()
        Me.dgvAsignatura = New System.Windows.Forms.DataGridView()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.dgvAsignatura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Button1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Button2, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Button3, 0, 2)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(67, 190)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(2)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 3
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 14.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(147, 80)
        Me.TableLayoutPanel2.TabIndex = 12
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Consolas", 21.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(194, 27)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(351, 34)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "DATOS ADMINISTRATIVOS"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Btn_Seleccionar, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Rb_Sede, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Rb_Profesor, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(67, 103)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(2)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(147, 75)
        Me.TableLayoutPanel1.TabIndex = 10
        '
        'Btn_Seleccionar
        '
        Me.Btn_Seleccionar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Btn_Seleccionar.Location = New System.Drawing.Point(2, 44)
        Me.Btn_Seleccionar.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_Seleccionar.Name = "Btn_Seleccionar"
        Me.Btn_Seleccionar.Size = New System.Drawing.Size(143, 29)
        Me.Btn_Seleccionar.TabIndex = 4
        Me.Btn_Seleccionar.Text = "Visualizar Tabla"
        Me.Btn_Seleccionar.UseVisualStyleBackColor = True
        '
        'Rb_Sede
        '
        Me.Rb_Sede.AutoSize = True
        Me.Rb_Sede.Location = New System.Drawing.Point(2, 23)
        Me.Rb_Sede.Margin = New System.Windows.Forms.Padding(2)
        Me.Rb_Sede.Name = "Rb_Sede"
        Me.Rb_Sede.Size = New System.Drawing.Size(50, 17)
        Me.Rb_Sede.TabIndex = 6
        Me.Rb_Sede.TabStop = True
        Me.Rb_Sede.Text = "Sede"
        Me.Rb_Sede.UseVisualStyleBackColor = True
        '
        'Rb_Profesor
        '
        Me.Rb_Profesor.AutoSize = True
        Me.Rb_Profesor.Location = New System.Drawing.Point(2, 2)
        Me.Rb_Profesor.Margin = New System.Windows.Forms.Padding(2)
        Me.Rb_Profesor.Name = "Rb_Profesor"
        Me.Rb_Profesor.Size = New System.Drawing.Size(64, 17)
        Me.Rb_Profesor.TabIndex = 5
        Me.Rb_Profesor.TabStop = True
        Me.Rb_Profesor.Text = "Profesor"
        Me.Rb_Profesor.UseVisualStyleBackColor = True
        '
        'dgvAsignatura
        '
        Me.dgvAsignatura.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvAsignatura.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvAsignatura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAsignatura.Location = New System.Drawing.Point(218, 63)
        Me.dgvAsignatura.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvAsignatura.Name = "dgvAsignatura"
        Me.dgvAsignatura.RowTemplate.Height = 28
        Me.dgvAsignatura.Size = New System.Drawing.Size(315, 207)
        Me.dgvAsignatura.TabIndex = 9
        '
        'Docente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 308)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.dgvAsignatura)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Docente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Docente"
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.dgvAsignatura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Btn_Seleccionar As Button
    Friend WithEvents Rb_Sede As RadioButton
    Friend WithEvents Rb_Profesor As RadioButton
    Friend WithEvents dgvAsignatura As DataGridView
End Class
