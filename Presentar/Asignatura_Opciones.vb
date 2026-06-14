Public Class Asignatura_Opciones

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
        'Opcion Asignatura
        If Cb_Asignatura.Checked Then
            'Declar variable
            Dim rpta As Boolean = False
            'consultar si es de tipo inster
            If _tipo = "Insertar" Then
                rpta = Logica.Asignatura.Asignatura_Insert(txtCodigo.Text, txtNombre.Text)
                _tipo = ""
                'Si es verdadero que se muestre que los datos fueron registrados correctamente
                If rpta = True Then
                    MsgBox("Datos registrados correctamente", vbInformation + vbOK, "Aviso")
                End If
            End If

            'Opcion Editar
            'Verificar si la opcion es editar
            If _tipo = "Editar" Then
                rpta = Logica.Asignatura.Asignatura_Update(txtCodigo.Text, txtNombre.Text, txt_Id.Text)
                'resetear la variable para que no se vuelva a abrir el formulario
                _tipo = ""
                'Si es verdadero que se muestre que los datos fueron registrados correctamente
                If rpta = True Then
                    MsgBox("Datos registrados correctamente", vbInformation + vbOK, "Aviso")
                End If
            End If
        End If

        If Cb_Carrera.Checked Then
            'Declar variable
            Dim rpta As Boolean = False
            'consultar si es de tipo inster
            If _tipo = "Insertar" Then
                rpta = Logica.Carrera.Carrera_Insert(txtCodigoC.Text, txtNombreC.Text)
                _tipo = ""
                'Si es verdadero que se muestre que los datos fueron registrados correctamente
                If rpta = True Then
                    MsgBox("Datos registrados correctamente", vbInformation + vbOK, "Aviso")
                End If
            End If


            'Opcion Editar
            'Verificar si la opcion es editar
            If _tipo = "Editar" Then
                rpta = Logica.Carrera.Carrera_Update(txtCodigoC.Text, txtNombreC.Text, txt_IdC.Text)
                'resetear la variable para que no se vuelva a abrir el formulario
                _tipo = ""
                'Si es verdadero que se muestre que los datos fueron registrados correctamente
                If rpta = True Then
                    MsgBox("Datos registrados correctamente", vbInformation + vbOK, "Aviso")
                End If
            End If
        End If

        If Cb_Facultad.Checked Then
            'Declar variable
            Dim rpta As Boolean = False
            'consultar si es de tipo inster
            If _tipo = "Insertar" Then
                rpta = Logica.Facultad.Facultad_Insert(txtCodigoF.Text, txtNombreF.Text, txt_CodigoCa.Text)
                _tipo = ""
                'Si es verdadero que se muestre que los datos fueron registrados correctamente
                If rpta = True Then
                    MsgBox("Datos registrados correctamente", vbInformation + vbOK, "Aviso")
                End If
            End If


            'Opcion Editar
            'Verificar si la opcion es editar
            If _tipo = "Editar" Then
                rpta = Logica.Facultad.Facultad_Update(txtCodigoF.Text, txtNombreF.Text, txt_CodigoCa.Text, txt_IdF.Text)
                'resetear la variable para que no se vuelva a abrir el formulario
                _tipo = ""
                'Si es verdadero que se muestre que los datos fueron registrados correctamente
                If rpta = True Then
                    MsgBox("Datos registrados correctamente", vbInformation + vbOK, "Aviso")
                End If
            End If
        End If

        If Cb_SubGrupo_Lab.Checked Then
            'Declar variable
            Dim rpta As Boolean = False
            'consultar si es de tipo inster
            If _tipo = "Insertar" Then
                rpta = Logica.SubGrupo_Lab.SubGrupo_Lab_Insert(txtCodigoS.Text)
                _tipo = ""
                'Si es verdadero que se muestre que los datos fueron registrados correctamente
                If rpta = True Then
                    MsgBox("Datos registrados correctamente", vbInformation + vbOK, "Aviso")
                End If
            End If


            'Opcion Editar
            'Verificar si la opcion es editar
            If _tipo = "Editar" Then
                rpta = Logica.SubGrupo_Lab.SubGrupo_Lab_Update(txtCodigoS.Text, txt_IdS.Text)
                'resetear la variable para que no se vuelva a abrir el formulario
                _tipo = ""
                'Si es verdadero que se muestre que los datos fueron registrados correctamente
                If rpta = True Then
                    MsgBox("Datos registrados correctamente", vbInformation + vbOK, "Aviso")
                End If
            End If
        End If

        If Cb_Grupo.Checked Then
            'Declar variable
            Dim rpta As Boolean = False
            'consultar si es de tipo inster
            If _tipo = "Insertar" Then
                rpta = Logica.Grupo.Grupo_Insert(txtCodigoG.Text, txtEstado.Text, txtCodigoSG.Text)
                _tipo = ""
                'Si es verdadero que se muestre que los datos fueron registrados correctamente
                If rpta = True Then
                    MsgBox("Datos registrados correctamente", vbInformation + vbOK, "Aviso")
                End If
            End If


            'Opcion Editar
            'Verificar si la opcion es editar
            If _tipo = "Editar" Then
                rpta = Logica.Grupo.Grupo_Update(txtCodigoG.Text, txtEstado.Text, txtCodigoSG.Text, txt_IdG.Text)
                'resetear la variable para que no se vuelva a abrir el formulario
                _tipo = ""
                'Si es verdadero que se muestre que los datos fueron registrados correctamente
                If rpta = True Then
                    MsgBox("Datos registrados correctamente", vbInformation + vbOK, "Aviso")
                End If
            End If
        End If

        'Limpiar Celdas
        txtCodigo.Text = ""
        txtNombre.Text = ""
        txt_Id.Text = ""

        'Bloquear Celdas
        txtCodigo.ReadOnly = True
        txtNombre.ReadOnly = True
        txt_Id.ReadOnly = True
        _tipo = ""

    End Sub

    Private Sub Asignatura_Opciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If _tipo = "Editar" Then
            Label17.Text = "EDITAR DATOS"
        End If
    End Sub
End Class