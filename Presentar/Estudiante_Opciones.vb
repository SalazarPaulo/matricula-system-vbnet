Public Class Estudiante_Opciones
    Private _tipo As String
    Public Property tipo As String
        Get
            Return _tipo
        End Get
        Set(value As String)
            _tipo = value
        End Set
    End Property

    Private Sub Btn_Cancelar_Click(sender As Object, e As EventArgs) Handles Btn_Cancelar.Click
        Me.Close()
    End Sub

    Private Sub Btn_Guardar_Click(sender As Object, e As EventArgs) Handles Btn_Guardar.Click
        'Declar variable
        Dim rpta As Boolean = False
        'consultar si es de tipo inster
        If _tipo = "Insertar" Then
            rpta = Logica.Estudiante.Estudiante_Insert(txtCodigo.Text, txtNombre.Text, txtApellidos.Text)
            _tipo = ""
            'Si es verdadero que se muestre que los datos fueron registrados correctamente
            If rpta = True Then
                MsgBox("Datos registrados correctamente", vbInformation + vbOK, "Aviso")
            End If
        End If

        'Opcion Editar
        'Verificar si la opcion es editar
        If _tipo = "Editar" Then
            rpta = Logica.Estudiante.Estudiante_Update(txtCodigo.Text, txtNombre.Text, txtApellidos.Text, txt_Id.Text)
            'resetear la variable para que no se vuelva a abrir el formulario
            _tipo = ""
            'Si es verdadero que se muestre que los datos fueron registrados correctamente
            If rpta = True Then
                MsgBox("Datos registrados correctamente", vbInformation + vbOK, "Aviso")
            End If
        End If
    End Sub

End Class