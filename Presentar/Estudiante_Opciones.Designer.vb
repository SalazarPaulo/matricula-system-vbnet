<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Estudiante_Opciones
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
        Label3 = New Label()
        txt_Id = New TextBox()
        Btn_Guardar = New Button()
        Btn_Cancelar = New Button()
        txtNombres = New Label()
        txtID_Alumno = New Label()
        txtNombre = New TextBox()
        txtCodigo = New TextBox()
        Label1 = New Label()
        txtApellidos = New TextBox()
        SuspendLayout()
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(31, 21)
        Label3.Name = "Label3"
        Label3.Size = New Size(21, 19)
        Label3.TabIndex = 15
        Label3.Text = "Id"
        ' 
        ' txt_Id
        ' 
        txt_Id.Location = New Point(132, 14)
        txt_Id.Name = "txt_Id"
        txt_Id.ReadOnly = True
        txt_Id.Size = New Size(100, 26)
        txt_Id.TabIndex = 14
        ' 
        ' Btn_Guardar
        ' 
        Btn_Guardar.DialogResult = DialogResult.OK
        Btn_Guardar.Location = New Point(157, 155)
        Btn_Guardar.Name = "Btn_Guardar"
        Btn_Guardar.Size = New Size(75, 23)
        Btn_Guardar.TabIndex = 13
        Btn_Guardar.Text = "Guardar"
        Btn_Guardar.UseVisualStyleBackColor = True
        ' 
        ' Btn_Cancelar
        ' 
        Btn_Cancelar.Location = New Point(54, 155)
        Btn_Cancelar.Name = "Btn_Cancelar"
        Btn_Cancelar.Size = New Size(75, 23)
        Btn_Cancelar.TabIndex = 12
        Btn_Cancelar.Text = "Cancelar"
        Btn_Cancelar.UseVisualStyleBackColor = True
        ' 
        ' txtNombres
        ' 
        txtNombres.AutoSize = True
        txtNombres.Location = New Point(31, 85)
        txtNombres.Name = "txtNombres"
        txtNombres.Size = New Size(65, 19)
        txtNombres.TabIndex = 11
        txtNombres.Text = "Nombres"
        ' 
        ' txtID_Alumno
        ' 
        txtID_Alumno.AutoSize = True
        txtID_Alumno.Location = New Point(31, 53)
        txtID_Alumno.Name = "txtID_Alumno"
        txtID_Alumno.Size = New Size(77, 19)
        txtID_Alumno.TabIndex = 10
        txtID_Alumno.Text = "ID_Alumno"
        ' 
        ' txtNombre
        ' 
        txtNombre.Location = New Point(132, 78)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(100, 26)
        txtNombre.TabIndex = 9
        ' 
        ' txtCodigo
        ' 
        txtCodigo.Location = New Point(132, 46)
        txtCodigo.Name = "txtCodigo"
        txtCodigo.Size = New Size(100, 26)
        txtCodigo.TabIndex = 8
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(32, 115)
        Label1.Name = "Label1"
        Label1.Size = New Size(64, 19)
        Label1.TabIndex = 17
        Label1.Text = "Apellidos"
        ' 
        ' txtApellidos
        ' 
        txtApellidos.Location = New Point(133, 108)
        txtApellidos.Name = "txtApellidos"
        txtApellidos.Size = New Size(100, 26)
        txtApellidos.TabIndex = 16
        ' 
        ' Estudiante_Opciones
        ' 
        AutoScaleDimensions = New SizeF(8F, 19F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(273, 220)
        Controls.Add(Label1)
        Controls.Add(txtApellidos)
        Controls.Add(Label3)
        Controls.Add(txt_Id)
        Controls.Add(Btn_Guardar)
        Controls.Add(Btn_Cancelar)
        Controls.Add(txtNombres)
        Controls.Add(txtID_Alumno)
        Controls.Add(txtNombre)
        Controls.Add(txtCodigo)
        Name = "Estudiante_Opciones"
        Text = "Estudiante_Opciones"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents txt_Id As TextBox
    Friend WithEvents Btn_Guardar As Button
    Friend WithEvents Btn_Cancelar As Button
    Friend WithEvents txtNombres As Label
    Friend WithEvents txtID_Alumno As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtApellidos As TextBox
End Class
