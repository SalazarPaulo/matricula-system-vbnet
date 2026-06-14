Public Class Docente_Opciones

    Private _tipo As String
    Public Property tipo As String
        Get
            Return _tipo
        End Get
        Set(value As String)
            _tipo = value
        End Set
    End Property

    Private Sub Btn_Guardar_Click(sender As Object, e As EventArgs) Handles Btn_Guardar.Click

        If Cb_Sede.Checked Then
            'Declar variable
            Dim rpta As Boolean = False
            'consultar si es de tipo inster
            If _tipo = "Insertar" Then
                rpta = Logica.Sede.Sede_Insert(txtCodigoSe.Text, txtNombreSe.Text, txtDireccionSe.Text)
                _tipo = ""
                'Si es verdadero que se muestre que los datos fueron registrados correctamente
                If rpta = True Then
                    MsgBox("Datos registrados correctamente", vbInformation + vbOK, "Aviso")
                End If
            End If

            'Opcion Editar
            'Verificar si la opcion es editar
            If _tipo = "Editar" Then
                rpta = Logica.Sede.Sede_Update(txtCodigoSe.Text, txtNombreSe.Text, txtDireccionSe.Text, txt_IdSe.Text)
                'resetear la variable para que no se vuelva a abrir el formulario
                _tipo = ""
                'Si es verdadero que se muestre que los datos fueron registrados correctamente
                If rpta = True Then
                    MsgBox("Datos registrados correctamente", vbInformation + vbOK, "Aviso")
                End If
            End If
        End If


        If Cb_Profesor.Checked Then
            ' Obtener el rango de fechas seleccionadas
            Dim rangoSeleccionado As SelectionRange = MonthCalendar1.SelectionRange
            ' Obtener la fecha de inicio y la fecha de fin del rango
            Dim fechaInicio As DateTime = rangoSeleccionado.Start
            ' Utiliza las fechas seleccionadas como desees
            'MsgBox("Fecha de inicio: " & fechaInicio.ToShortDateString())

            'Declar variable
            Dim rpta As Boolean = False
            'consultar si es de tipo inster
            If _tipo = "Insertar" Then
                rpta = Logica.Profesor.Profesor_Insert(txtCodigoP.Text, txtNombresP.Text, txtApellidosP.Text, txtEmailP.Text, fechaInicio.ToShortDateString())
                _tipo = ""
                'Si es verdadero que se muestre que los datos fueron registrados correctamente
                If rpta = True Then
                    MsgBox("Datos registrados correctamente", vbInformation + vbOK, "Aviso")
                End If
            End If

            'Opcion Editar
            'Verificar si la opcion es editar
            If _tipo = "Editar" Then
                rpta = Logica.Profesor.Profesor_Update(txtCodigoP.Text, txtNombresP.Text, txtApellidosP.Text, txtEmailP.Text, fechaInicio.ToShortDateString(), txt_IdP.Text)
                'resetear la variable para que no se vuelva a abrir el formulario
                _tipo = ""
                'Si es verdadero que se muestre que los datos fueron registrados correctamente
                If rpta = True Then
                    MsgBox("Datos registrados correctamente", vbInformation + vbOK, "Aviso")
                End If
            End If

        End If

    End Sub

    Private Sub Btn_Cancelar_Click(sender As Object, e As EventArgs) Handles Btn_Cancelar.Click
        Me.Close()
    End Sub
End Class