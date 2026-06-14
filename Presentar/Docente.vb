Public Class Docente
    'Declaracion variable
    Private odt As New DataTable
    Dim indice As BindingManagerBase

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'crear instancia de Docente_insertar
        Dim a As New Docente_Opciones
        'usar la variable tipo del forms
        a.tipo = "Insertar"
        'determinar si la respuesta es si
        If Rb_Profesor.Checked = True Then
            If a.ShowDialog() = Windows.Forms.DialogResult.OK Then
                'cargar los datos principal y mostar en el datagridview
                odt = Logica.Profesor.Profesor_Select
                dgvAsignatura.DataSource = odt
            End If
        End If
        If Rb_Sede.Checked = True Then
            If a.ShowDialog() = Windows.Forms.DialogResult.OK Then
                'cargar los datos principal y mostar en el datagridview
                odt = Logica.Sede.Sede_Select
                dgvAsignatura.DataSource = odt
            End If
        End If




    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'crear instancia de Docente_insertar
        Dim a As New Docente_Opciones
        'usar la variable tipo del forms
        a.tipo = "Editar"
        If Rb_Profesor.Checked = True Then

            a.txt_IdP.Text = dgvAsignatura.CurrentRow.Cells(0).Value
            a.txtCodigoP.Text = dgvAsignatura.CurrentRow.Cells(0).Value
            a.txtNombresP.Text = dgvAsignatura.CurrentRow.Cells(1).Value
            a.txtApellidosP.Text = dgvAsignatura.CurrentRow.Cells(2).Value
            a.txtEmailP.Text = dgvAsignatura.CurrentRow.Cells(3).Value

            'Indicar registtro a editar
            Dim Id As Integer = dgvAsignatura.CurrentRow.Cells(0).Value
            If a.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                'cargar los datos principal y mostar en el datagridview
                odt = Logica.Profesor.Profesor_Select
                dgvAsignatura.DataSource = odt
            End If

            'determinar si la respuesta es si
            If a.ShowDialog() = Windows.Forms.DialogResult.OK Then
                'cargar los datos principal y mostar en el datagridview
                odt = Logica.Profesor.Profesor_Select
                dgvAsignatura.DataSource = odt

                indice = BindingContext(odt)

                For i = 0 To dgvAsignatura.Rows.Count - 1
                    If Id = dgvAsignatura.Rows(i).Cells(0).Value Then
                        dgvAsignatura.CurrentCell = dgvAsignatura.Rows(i).Cells(1)
                        Exit For
                    End If
                Next
            Else
                a.tipo = ""
            End If
            a.Dispose()

        ElseIf Rb_Sede.Checked = True Then
            a.txt_IdSe.Text = dgvAsignatura.CurrentRow.Cells(0).Value
            a.txtCodigoSe.Text = dgvAsignatura.CurrentRow.Cells(0).Value
            a.txtNombreSe.Text = dgvAsignatura.CurrentRow.Cells(1).Value
            a.txtDireccionSe.Text = dgvAsignatura.CurrentRow.Cells(1).Value

            'Indicar registtro a editar
            Dim Id As Integer = dgvAsignatura.CurrentRow.Cells(0).Value
            If a.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                'cargar los datos principal y mostar en el datagridview
                odt = Logica.Sede.Sede_Select
                dgvAsignatura.DataSource = odt
            End If

            'determinar si la respuesta es si
            If a.ShowDialog() = Windows.Forms.DialogResult.OK Then
                'cargar los datos principal y mostar en el datagridview
                odt = Logica.Sede.Sede_Select
                dgvAsignatura.DataSource = odt

                indice = BindingContext(odt)

                For i = 0 To dgvAsignatura.Rows.Count - 1
                    If Id = dgvAsignatura.Rows(i).Cells(0).Value Then
                        dgvAsignatura.CurrentCell = dgvAsignatura.Rows(i).Cells(1)
                        Exit For
                    End If
                Next
            Else
                a.tipo = ""
            End If
            a.Dispose()

        End If

    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim pos As Integer
        pos = indice.Position
        If Rb_Profesor.Checked = True Then
            'Hacenos una condicion si el mensaje de texto es afirmativo que se elimine
            If MsgBox("Desea eliminar el registro?", vbQuestion + vbOKCancel, "AVISO") = vbOK Then
                Dim Id As Integer = dgvAsignatura.CurrentRow.Cells(0).Value
                'Si es verdadero que muestre un mensaje
                If Logica.Profesor.Profesor_Delete(Id) = True Then
                    MsgBox("Registro eliminado correctamente", vbInformation, "AVISO")
                    'Que se actualice y se muestre en la tabla clientes
                    odt = Logica.Profesor.Profesor_Select
                    dgvAsignatura.DataSource = odt
                    'Se actualice la posicion
                    indice = BindingContext(odt)
                    indice.Position = pos - 1
                End If
            End If

        ElseIf Rb_Sede.Checked = True Then
            'Hacenos una condicion si el mensaje de texto es afirmativo que se elimine
            If MsgBox("Desea eliminar el registro?", vbQuestion + vbOKCancel, "AVISO") = vbOK Then
                Dim Id As Integer = dgvAsignatura.CurrentRow.Cells(0).Value
                'Si es verdadero que muestre un mensaje
                If Logica.Sede.Sede_Delete(Id) = True Then
                    MsgBox("Registro eliminado correctamente", vbInformation, "AVISO")
                    'Que se actualice y se muestre en la tabla clientes
                    odt = Logica.Sede.Sede_Select
                    dgvAsignatura.DataSource = odt
                    'Se actualice la posicion
                    indice = BindingContext(odt)
                    indice.Position = pos - 1
                End If
            End If

        End If

    End Sub

    Private Sub Btn_Seleccionar_Click(sender As Object, e As EventArgs) Handles Btn_Seleccionar.Click
        If Rb_Profesor.Checked = True Then
            'pasar a la variable odt pasarle el parametro Profesor select de la clase logica
            odt = Logica.Profesor.Profesor_Select
            'Añadir la variable datagridview a traves del objeto datatable obtener los datos de la bd
            dgvAsignatura.DataSource = odt

            'Delete Option
            'Permitir control de formulario a traves del objeto datatable
            indice = BindingContext(odt)

        ElseIf Rb_Sede.Checked = True Then
            'pasar a la variable odt pasarle el parametro Sede select de la clase logica
            odt = Logica.Sede.Sede_Select
            'Añadir la variable datagridview a traves del objeto datatable obtener los datos de la bd
            dgvAsignatura.DataSource = odt

            'Delete Option
            'Permitir control de formulario a traves del objeto datatable
            indice = BindingContext(odt)
        End If
    End Sub
End Class