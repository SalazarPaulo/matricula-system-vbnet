Imports System.Xml

Public Class Asignatura
    'Declaracion variable
    Private odt As New DataTable
    Dim indice As BindingManagerBase
    Private Sub Asignatura_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Colocar el nombre del usuario en el label3
        Label3.Text = Login.TextBox1.Text

    End Sub

    'Insertar opcion
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'crear instancia de asignatura_insertar
        Dim a As New Asignatura_Opciones
        'usar la variable tipo del forms
        a.tipo = "Insertar"
        If Rb_Asignatura.Checked = True Then
            'determinar si la respuesta es si
            If a.ShowDialog() = Windows.Forms.DialogResult.OK Then
                'cargar los datos principal y mostar en el datagridview
                odt = Logica.Asignatura.Asignatura_Select
                dgvAsignatura.DataSource = odt
            End If

        ElseIf Rb_Carrera.Checked = True Then
            'determinar si la respuesta es si
            If a.ShowDialog() = Windows.Forms.DialogResult.OK Then
                'cargar los datos principal y mostar en el datagridview
                odt = Logica.Carrera.Carrera_Select
                dgvAsignatura.DataSource = odt
            End If

        ElseIf Rb_Facultad.Checked Then
            'determinar si la respuesta es si
            If a.ShowDialog() = Windows.Forms.DialogResult.OK Then
                'cargar los datos principal y mostar en el datagridview
                odt = Logica.Facultad.Facultad_Select
                dgvAsignatura.DataSource = odt
            End If

        ElseIf Rb_SubGrupo_Lab.Checked Then
            'determinar si la respuesta es si
            If a.ShowDialog() = Windows.Forms.DialogResult.OK Then
                'cargar los datos principal y mostar en el datagridview
                odt = Logica.SubGrupo_Lab.SubGrupo_Lab_Select
                dgvAsignatura.DataSource = odt
            End If

        ElseIf Rb_Grupo.Checked Then
            'determinar si la respuesta es si
            If a.ShowDialog() = Windows.Forms.DialogResult.OK Then
                'cargar los datos principal y mostar en el datagridview
                odt = Logica.Grupo.Grupo_Select
                dgvAsignatura.DataSource = odt
            End If
        End If

    End Sub

    'Boton editar
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'crear instancia de asignatura_insertar
        Dim a As New Asignatura_Opciones
        'usar la variable tipo del forms
        a.tipo = "Editar"

        If Rb_Asignatura.Checked = True Then
            a.txt_Id.Text = dgvAsignatura.CurrentRow.Cells(0).Value
            a.txtCodigo.Text = dgvAsignatura.CurrentRow.Cells(0).Value
            a.txtNombre.Text = dgvAsignatura.CurrentRow.Cells(1).Value

            'Indicar registro a editar
            Dim Id As Integer = dgvAsignatura.CurrentRow.Cells(0).Value
            If a.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                'cargar los datos principal y mostar en el datagridview
                odt = Logica.Asignatura.Asignatura_Select
                dgvAsignatura.DataSource = odt
            End If

            'determinar si la respuesta es si
            If a.ShowDialog() = Windows.Forms.DialogResult.OK Then
                'cargar los datos principal y mostar en el datagridview
                odt = Logica.Asignatura.Asignatura_Select
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

        ElseIf Rb_Carrera.Checked Then

            a.txt_IdC.Text = dgvAsignatura.CurrentRow.Cells(0).Value
            a.txtCodigoC.Text = dgvAsignatura.CurrentRow.Cells(0).Value
            a.txtNombreC.Text = dgvAsignatura.CurrentRow.Cells(1).Value

            'Indicar registro a editar
            Dim Id As Integer = dgvAsignatura.CurrentRow.Cells(0).Value
            If a.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                'cargar los datos principal y mostar en el datagridview
                odt = Logica.Carrera.Carrera_Select
                dgvAsignatura.DataSource = odt
            End If

            'determinar si la respuesta es si
            If a.ShowDialog() = Windows.Forms.DialogResult.OK Then
                'cargar los datos principal y mostar en el datagridview
                odt = Logica.Carrera.Carrera_Select
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

        ElseIf Rb_Facultad.Checked Then
            a.txt_IdF.Text = dgvAsignatura.CurrentRow.Cells(0).Value
            a.txtCodigoF.Text = dgvAsignatura.CurrentRow.Cells(0).Value
            a.txtNombreF.Text = dgvAsignatura.CurrentRow.Cells(1).Value
            a.txt_CodigoCa.Text = dgvAsignatura.CurrentRow.Cells(2).Value

            'Indicar registro a editar
            Dim Id As Integer = dgvAsignatura.CurrentRow.Cells(0).Value
            If a.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                'cargar los datos principal y mostar en el datagridview
                odt = Logica.Facultad.Facultad_Select
                dgvAsignatura.DataSource = odt
            End If

            'determinar si la respuesta es si
            If a.ShowDialog() = Windows.Forms.DialogResult.OK Then
                'cargar los datos principal y mostar en el datagridview
                odt = Logica.Facultad.Facultad_Select
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


        ElseIf Rb_SubGrupo_Lab.Checked Then
            a.txt_IdS.Text = dgvAsignatura.CurrentRow.Cells(0).Value
            a.txt_IdS.Text = dgvAsignatura.CurrentRow.Cells(0).Value
            a.txtCodigoS.Text = dgvAsignatura.CurrentRow.Cells(1).Value

            'Indicar registro a editar
            Dim Id As Integer = dgvAsignatura.CurrentRow.Cells(0).Value
            If a.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                'cargar los datos principal y mostar en el datagridview
                odt = Logica.SubGrupo_Lab.SubGrupo_Lab_Select
                dgvAsignatura.DataSource = odt
            End If

            'determinar si la respuesta es si
            If a.ShowDialog() = Windows.Forms.DialogResult.OK Then
                'cargar los datos principal y mostar en el datagridview
                odt = Logica.SubGrupo_Lab.SubGrupo_Lab_Select
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


        ElseIf Rb_Grupo.Checked Then
            a.txt_IdG.Text = dgvAsignatura.CurrentRow.Cells(0).Value
            a.txtCodigoG.Text = dgvAsignatura.CurrentRow.Cells(0).Value
            a.txtEstado.Text = dgvAsignatura.CurrentRow.Cells(1).Value
            a.txtCodigoSG.Text = dgvAsignatura.CurrentRow.Cells(1).Value

            'Indicar registro a editar
            Dim Id As Integer = dgvAsignatura.CurrentRow.Cells(0).Value
            If a.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                'cargar los datos principal y mostar en el datagridview
                odt = Logica.Grupo.Grupo_Select
                dgvAsignatura.DataSource = odt
            End If

            'determinar si la respuesta es si
            If a.ShowDialog() = Windows.Forms.DialogResult.OK Then
                'cargar los datos principal y mostar en el datagridview
                odt = Logica.Grupo.Grupo_Select
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
        a.tipo = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim pos As Integer
        pos = indice.Position
        If Rb_Asignatura.Checked = True Then
            'Hacenos una condicion si el mensaje de texto es afirmativo que se elimine
            If MsgBox("Desea eliminar el registro?", vbQuestion + vbOKCancel, "AVISO") = vbOK Then
                Dim Id As Integer = dgvAsignatura.CurrentRow.Cells(0).Value
                'Si es verdadero que muestre un mensaje
                If Logica.Asignatura.Asignatura_Delete(Id) = True Then
                    MsgBox("Registro eliminado correctamente", vbInformation, "AVISO")
                    'Que se actualice y se muestre en la tabla clientes
                    odt = Logica.Asignatura.Asignatura_Select
                    dgvAsignatura.DataSource = odt
                    'Se actualice la posicion
                    indice = BindingContext(odt)
                    indice.Position = pos - 1
                End If
            End If

        ElseIf Rb_Carrera.Checked = True Then
            'Hacenos una condicion si el mensaje de texto es afirmativo que se elimine
            If MsgBox("Desea eliminar el registro?", vbQuestion + vbOKCancel, "AVISO") = vbOK Then
                Dim Id As Integer = dgvAsignatura.CurrentRow.Cells(0).Value
                'Si es verdadero que muestre un mensaje
                If Logica.Carrera.Carrera_Delete(Id) = True Then
                    MsgBox("Registro eliminado correctamente", vbInformation, "AVISO")
                    'Que se actualice y se muestre en la tabla clientes
                    odt = Logica.Carrera.Carrera_Select
                    dgvAsignatura.DataSource = odt
                    'Se actualice la posicion
                    indice = BindingContext(odt)
                    indice.Position = pos - 1
                End If
            End If

        ElseIf Rb_Facultad.Checked = True Then
            'Hacenos una condicion si el mensaje de texto es afirmativo que se elimine
            If MsgBox("Desea eliminar el registro?", vbQuestion + vbOKCancel, "AVISO") = vbOK Then
                Dim Id As Integer = dgvAsignatura.CurrentRow.Cells(0).Value
                'Si es verdadero que muestre un mensaje
                If Logica.Facultad.Facultad_Delete(Id) = True Then
                    MsgBox("Registro eliminado correctamente", vbInformation, "AVISO")
                    'Que se actualice y se muestre en la tabla clientes
                    odt = Logica.Facultad.Facultad_Select
                    dgvAsignatura.DataSource = odt
                    'Se actualice la posicion
                    indice = BindingContext(odt)
                    indice.Position = pos - 1
                End If
            End If
        ElseIf Rb_SubGrupo_Lab.Checked = True Then
            'Hacenos una condicion si el mensaje de texto es afirmativo que se elimine
            If MsgBox("Desea eliminar el registro?", vbQuestion + vbOKCancel, "AVISO") = vbOK Then
                Dim Id As Integer = dgvAsignatura.CurrentRow.Cells(0).Value
                'Si es verdadero que muestre un mensaje
                If Logica.SubGrupo_Lab.SubGrupo_Lab_Delete(Id) = True Then
                    MsgBox("Registro eliminado correctamente", vbInformation, "AVISO")
                    'Que se actualice y se muestre en la tabla clientes
                    odt = Logica.SubGrupo_Lab.SubGrupo_Lab_Select
                    dgvAsignatura.DataSource = odt
                    'Se actualice la posicion
                    indice = BindingContext(odt)
                    indice.Position = pos - 1
                End If
            End If

        ElseIf Rb_Grupo.Checked = True Then
            'Hacenos una condicion si el mensaje de texto es afirmativo que se elimine
            If MsgBox("Desea eliminar el registro?", vbQuestion + vbOKCancel, "AVISO") = vbOK Then
                Dim Id As Integer = dgvAsignatura.CurrentRow.Cells(0).Value
                'Si es verdadero que muestre un mensaje
                If Logica.Grupo.Grupo_Delete(Id) = True Then
                    MsgBox("Registro eliminado correctamente", vbInformation, "AVISO")
                    'Que se actualice y se muestre en la tabla clientes
                    odt = Logica.Grupo.Grupo_Select
                    dgvAsignatura.DataSource = odt
                    'Se actualice la posicion
                    indice = BindingContext(odt)
                    indice.Position = pos - 1
                End If
            End If

        End If

    End Sub

    Private Sub Btn_Seleccionar_Click(sender As Object, e As EventArgs) Handles Btn_Seleccionar.Click
        If Rb_Asignatura.Checked = True Then
            'pasar a la variable odt pasarle el parametro Asignatura select de la clase logica
            odt = Logica.Asignatura.Asignatura_Select
            'Añadir la variable datagridview a traves del objeto datatable obtener los datos de la bd
            dgvAsignatura.DataSource = odt

            'Delete Option
            'Permitir control de formulario a traves del objeto datatable
            indice = BindingContext(odt)

        ElseIf Rb_Carrera.Checked = True Then
            'pasar a la variable odt pasarle el parametro Carrera select de la clase logica
            odt = Logica.Carrera.Carrera_Select
            'Añadir la variable datagridview a traves del objeto datatable obtener los datos de la bd
            dgvAsignatura.DataSource = odt

            'Delete Option
            'Permitir control de formulario a traves del objeto datatable
            indice = BindingContext(odt)

        ElseIf Rb_Facultad.Checked = True Then
            'pasar a la variable odt pasarle el parametro Facultad select de la clase logica
            odt = Logica.Facultad.Facultad_Select
            'Añadir la variable datagridview a traves del objeto datatable obtener los datos de la bd
            dgvAsignatura.DataSource = odt

            'Delete Option
            'Permitir control de formulario a traves del objeto datatable
            indice = BindingContext(odt)

        ElseIf Rb_SubGrupo_Lab.Checked = True Then
            'pasar a la variable odt pasarle el parametro SubGrupo_Lab select de la clase logica
            odt = Logica.SubGrupo_Lab.SubGrupo_Lab_Select
            'Añadir la variable datagridview a traves del objeto datatable obtener los datos de la bd
            dgvAsignatura.DataSource = odt

            'Delete Option
            'Permitir control de formulario a traves del objeto datatable
            indice = BindingContext(odt)

        ElseIf Rb_Grupo.Checked = True Then
            'pasar a la variable odt pasarle el parametro Grupo select de la clase logica
            odt = Logica.Grupo.Grupo_Select
            'Añadir la variable datagridview a traves del objeto datatable obtener los datos de la bd
            dgvAsignatura.DataSource = odt

            'Delete Option
            'Permitir control de formulario a traves del objeto datatable
            indice = BindingContext(odt)
        End If

    End Sub

End Class