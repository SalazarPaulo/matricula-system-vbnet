Public Class Estudiante
    'Opcion Select
    Public Shared Function Estudiante_Select() As DataTable
        'Devolver la ejecucion del parametro Asignatura select que esta en la clase de la capa datos
        Return Datos.Estudiante.Estudiante_Select
    End Function

    'Opcion Insert
    Public Shared Function Estudiante_Insert(ByVal ID_Alumno As Integer, ByVal Nombres As String, ByVal Apellidos As String) As Boolean
        'Devolver la ejecucion del parametro Asignatura insert que esta en la clase de la capa datos
        Return Datos.Estudiante.Estudiante_Insert(ID_Alumno, Nombres, Apellidos)
    End Function
    'Opcion Update
    Public Shared Function Estudiante_Update(ByVal ID_Alumno As Integer, ByVal Nombres As String, ByVal Apellidos As String, ByVal Id As Integer) As Boolean
        'Devolver la ejecucion del parametro Asignatura update que esta en la clase de la capa datos
        Return Datos.Estudiante.Estudiante_Update(ID_Alumno, Nombres, Apellidos, Id)
    End Function

    'Opcion Delete
    Public Shared Function Estudiante_Delete(ByVal Id As Integer) As Boolean
        Return Datos.Estudiante.Estudiante_Delete(Id)
    End Function
    'Opcion Verify
    Public Shared Function Estudiante_Verify(ByVal ID_Alumno As Integer, ByVal Nombres As String) As Boolean
        'Devolver la ejecucion del parametro Asignatura insert que esta en la clase de la capa datos
        Return Datos.Estudiante.Estudiante_Verify(ID_Alumno, Nombres)
    End Function

End Class
