Public Class Estudiante
    'Declaracion variable
    Private odt As New DataTable
    Dim indice As BindingManagerBase
    Private Sub Estudiante_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'pasar a la variable odt pasarle el parametro Estudiante select de la clase logica
        odt = Logica.Estudiante.Estudiante_Select
        'Añadir la variable datagridview a traves del objeto datatable obtener los datos de la bd
        dgvEstudiante.DataSource = odt

        'Delete Option
        'Permitir control de formulario a traves del objeto datatable
        indice = BindingContext(odt)
    End Sub

    Private Sub Btn_Insertar_Click(sender As Object, e As EventArgs) Handles Btn_Insertar.Click
        'crear instancia de asignatura_insertar
        Dim a As New Estudiante_Opciones
        'usar la variable tipo del forms
        a.tipo = "Insertar"
        'determinar si la respuesta es si
        If a.ShowDialog() = Windows.Forms.DialogResult.OK Then
            'cargar los datos principal y mostar en el datagridview
            odt = Logica.Estudiante.Estudiante_Select
            dgvEstudiante.DataSource = odt
        End If
    End Sub

    'Boton editar
    Private Sub Btn_Editar_Click(sender As Object, e As EventArgs) Handles Btn_Editar.Click
        'crear instancia de estudiante_insertar
        Dim a As New Estudiante_Opciones
        'usar la variable tipo del forms
        a.tipo = "Editar"

        a.txt_Id.Text = dgvEstudiante.CurrentRow.Cells(0).Value
        a.txtCodigo.Text = dgvEstudiante.CurrentRow.Cells(0).Value
        a.txtNombre.Text = dgvEstudiante.CurrentRow.Cells(1).Value
        a.txtApellidos.Text = dgvEstudiante.CurrentRow.Cells(2).Value

        'Indicar registtro a editar
        Dim Id As Integer = dgvEstudiante.CurrentRow.Cells(0).Value
        If a.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            'cargar los datos principal y mostar en el datagridview
            odt = Logica.Estudiante.Estudiante_Select
            dgvEstudiante.DataSource = odt
        End If

        'determinar si la respuesta es si
        If a.ShowDialog() = Windows.Forms.DialogResult.OK Then
            'cargar los datos principal y mostar en el datagridview
            odt = Logica.Estudiante.Estudiante_Select
            dgvEstudiante.DataSource = odt

            indice = BindingContext(odt)

            For i = 0 To dgvEstudiante.Rows.Count - 1
                If Id = dgvEstudiante.Rows(i).Cells(0).Value Then
                    dgvEstudiante.CurrentCell = dgvEstudiante.Rows(i).Cells(1)
                    Exit For
                End If
            Next
        Else
            a.tipo = ""
        End If
        a.Dispose()
    End Sub

    'Boton Eliminar
    Private Sub Btn_Eliminar_Click(sender As Object, e As EventArgs) Handles Btn_Eliminar.Click
        Dim pos As Integer
        pos = indice.Position
        'Hacenos una condicion si el mensaje de texto es afirmativo que se elimine
        If MsgBox("Desea eliminar el registro?", vbQuestion + vbOKCancel, "AVISO") = vbOK Then
            Dim Id As Integer = dgvEstudiante.CurrentRow.Cells(0).Value
            'Si es verdadero que muestre un mensaje
            If Logica.Estudiante.Estudiante_Delete(Id) = True Then
                MsgBox("Registro eliminado correctamente", vbInformation, "AVISO")
                'Que se actualice y se muestre en la tabla clientes
                odt = Logica.Estudiante.Estudiante_Select
                dgvEstudiante.DataSource = odt
                'Se actualice la posicion
                indice = BindingContext(odt)
                indice.Position = pos - 1
            End If
        End If
    End Sub
End Class