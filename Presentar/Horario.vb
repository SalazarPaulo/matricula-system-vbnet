Public Class Horario
    'Declaracion variable
    Private odt As New DataTable
    Dim indice As BindingManagerBase

    Private Sub Horario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = Login.TextBox1.Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Grupo.Checked And Profesor.Checked = False And Sede.Checked = False And Asignatura.Checked = False And Carrera.Checked = False And Facultad.Checked = False Then
            'pasar a la variable odt pasarle el parametro Grupo select de la clase logica
            odt = Logica.Grupo.Grupo_Select
            'Añadir la variable datagridview a traves del objeto datatable obtener los datos de la bd
            dgvAsignatura.DataSource = odt

            'Delete Option
            'Permitir control de formulario a traves del objeto datatable
            indice = BindingContext(odt)
        ElseIf Profesor.Checked And Grupo.Checked = False And Sede.Checked = False And Asignatura.Checked = False And Carrera.Checked = False And Facultad.Checked = False Then
            'pasar a la variable odt pasarle el parametro Profesor select de la clase logica
            odt = Logica.Profesor.Profesor_Select
            'Añadir la variable datagridview a traves del objeto datatable obtener los datos de la bd
            dgvAsignatura.DataSource = odt

            'Delete Option
            'Permitir control de formulario a traves del objeto datatable
            indice = BindingContext(odt)
        ElseIf Carrera.Checked And Profesor.Checked = False And Sede.Checked = False And Asignatura.Checked = False And Grupo.Checked = False And Facultad.Checked = False Then
            'pasar a la variable odt pasarle el parametro SubGrupo select de la clase logica
            odt = Logica.Carrera.Carrera_Select
            'Añadir la variable datagridview a traves del objeto datatable obtener los datos de la bd
            dgvAsignatura.DataSource = odt

            'Delete Option
            'Permitir control de formulario a traves del objeto datatable
            indice = BindingContext(odt)
        ElseIf Sede.Checked And Profesor.Checked = False And Grupo.Checked = False And Asignatura.Checked = False And Carrera.Checked = False And Facultad.Checked = False Then
            'pasar a la variable odt pasarle el parametro Sede select de la clase logica
            odt = Logica.Sede.Sede_Select
            'Añadir la variable datagridview a traves del objeto datatable obtener los datos de la bd
            dgvAsignatura.DataSource = odt

            'Delete Option
            'Permitir control de formulario a traves del objeto datatable
            indice = BindingContext(odt)
        ElseIf Asignatura.Checked And Profesor.Checked = False And Sede.Checked = False And Grupo.Checked = False And Carrera.Checked = False And Facultad.Checked = False Then
            'pasar a la variable odt pasarle el parametro Asignatura select de la clase logica
            odt = Logica.Asignatura.Asignatura_Select
            'Añadir la variable datagridview a traves del objeto datatable obtener los datos de la bd
            dgvAsignatura.DataSource = odt
            'Delete Option
            'Permitir control de formulario a traves del objeto datatable
            indice = BindingContext(odt)
        ElseIf Facultad.Checked And Profesor.Checked = False And Sede.Checked = False And Asignatura.Checked = False And Carrera.Checked = False And Grupo.Checked = False Then
            'pasar a la variable odt pasarle el parametro Facultad select de la clase logica
            odt = Logica.Facultad.Facultad_Select
            'Añadir la variable datagridview a traves del objeto datatable obtener los datos de la bd
            dgvAsignatura.DataSource = odt
            'Delete Option
            'Permitir control de formulario a traves del objeto datatable
        ElseIf Grupo.Checked And Profesor.Checked And Sede.Checked And Asignatura.Checked And Carrera.Checked And Facultad.Checked Then
            'pasar a la variable odt pasarle el parametro Sede select de la clase logica
            odt = Logica.Horario.Horario_Docente_Select(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text, TextBox6.Text)
            'Añadir la variable datagridview a traves del objeto datatable obtener los datos de la bd
            dgvAsignatura.DataSource = odt

            'Delete Option
            'Permitir control de formulario a traves del objeto datatable
            indice = BindingContext(odt)
        End If
    End Sub
End Class