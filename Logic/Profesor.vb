Public Class Profesor
    'Opcion Select
    Public Shared Function Profesor_Select() As DataTable
        'Devolver la ejecucion del parametro Asignatura select que esta en la clase de la capa datos
        Return Datos.Profesor.Profesor_Select
    End Function

    'Opcion Insert
    Public Shared Function Profesor_Insert(ByVal ID_Docente As Integer, ByVal Nombres As String, ByVal Apellidos As String, ByVal Email As String, ByVal Fecha_Nac As Date) As Boolean
        'Devolver la ejecucion del parametro Asignatura insert que esta en la clase de la capa datos
        Return Datos.Profesor.Profesor_Insert(ID_Docente, Nombres, Apellidos, Email, Fecha_Nac)
    End Function
    'Opcion Update
    Public Shared Function Profesor_Update(ByVal ID_Docente As Integer, ByVal Nombres As String, ByVal Apellidos As String, ByVal Email As String, ByVal Fecha_Nac As Date, ByVal Id As Integer) As Boolean
        'Devolver la ejecucion del parametro Asignatura update que esta en la clase de la capa datos
        Return Datos.Profesor.Profesor_Update(ID_Docente, Nombres, Apellidos, Email, Fecha_Nac, Id)
    End Function

    'Opcion Delete
    Public Shared Function Profesor_Delete(ByVal Id As Integer) As Boolean
        Return Datos.Profesor.Profesor_Delete(Id)
    End Function
End Class
