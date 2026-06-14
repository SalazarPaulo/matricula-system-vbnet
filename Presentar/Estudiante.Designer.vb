<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Estudiante
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
        Me.dgvEstudiante = New System.Windows.Forms.DataGridView()
        Me.Btn_Insertar = New System.Windows.Forms.Button()
        Me.Btn_Eliminar = New System.Windows.Forms.Button()
        Me.Btn_Editar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgvEstudiante, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvEstudiante
        '
        Me.dgvEstudiante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEstudiante.Location = New System.Drawing.Point(95, 78)
        Me.dgvEstudiante.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvEstudiante.Name = "dgvEstudiante"
        Me.dgvEstudiante.Size = New System.Drawing.Size(333, 123)
        Me.dgvEstudiante.TabIndex = 0
        '
        'Btn_Insertar
        '
        Me.Btn_Insertar.Location = New System.Drawing.Point(23, 78)
        Me.Btn_Insertar.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_Insertar.Name = "Btn_Insertar"
        Me.Btn_Insertar.Size = New System.Drawing.Size(56, 25)
        Me.Btn_Insertar.TabIndex = 2
        Me.Btn_Insertar.Text = "Insertar"
        Me.Btn_Insertar.UseVisualStyleBackColor = True
        '
        'Btn_Eliminar
        '
        Me.Btn_Eliminar.Location = New System.Drawing.Point(23, 176)
        Me.Btn_Eliminar.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_Eliminar.Name = "Btn_Eliminar"
        Me.Btn_Eliminar.Size = New System.Drawing.Size(56, 25)
        Me.Btn_Eliminar.TabIndex = 5
        Me.Btn_Eliminar.Text = "Eliminar"
        Me.Btn_Eliminar.UseVisualStyleBackColor = True
        '
        'Btn_Editar
        '
        Me.Btn_Editar.Location = New System.Drawing.Point(23, 124)
        Me.Btn_Editar.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_Editar.Name = "Btn_Editar"
        Me.Btn_Editar.Size = New System.Drawing.Size(56, 25)
        Me.Btn_Editar.TabIndex = 4
        Me.Btn_Editar.Text = "Editar"
        Me.Btn_Editar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Consolas", 21.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(89, 33)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(351, 34)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "DATOS ADMINISTRATIVOS"
        '
        'Estudiante
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 276)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Btn_Eliminar)
        Me.Controls.Add(Me.Btn_Editar)
        Me.Controls.Add(Me.Btn_Insertar)
        Me.Controls.Add(Me.dgvEstudiante)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Estudiante"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Estudiante"
        CType(Me.dgvEstudiante, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvEstudiante As DataGridView
    Friend WithEvents Btn_Insertar As Button
    Friend WithEvents Btn_Eliminar As Button
    Friend WithEvents Btn_Editar As Button
    Friend WithEvents Label1 As Label
End Class
