Public Class Carrera
    'Opcion Select
    Public Shared Function Carrera_Select() As DataTable
        'Devolver la ejecucion del parametro Asignatura select que esta en la clase de la capa datos
        Return Datos.Carrera.Carrera_Select
    End Function

    'Opcion Insert
    Public Shared Function Carrera_Insert(ByVal Cod_Carrera As Integer, ByVal Nombre As String) As Boolean
        'Devolver la ejecucion del parametro Asignatura insert que esta en la clase de la capa datos
        Return Datos.Carrera.Carrera_Insert(Cod_Carrera, Nombre)
    End Function
    'Opcion Update
    Public Shared Function Carrera_Update(ByVal Cod_Carrera As Integer, ByVal Nombre As String, ByVal Id As Integer) As Boolean
        'Devolver la ejecucion del parametro Asignatura update que esta en la clase de la capa datos
        Return Datos.Carrera.Carrera_Update(Cod_Carrera, Nombre, Id)
    End Function

    'Opcion Delete
    Public Shared Function Carrera_Delete(ByVal Id As Integer) As Boolean
        Return Datos.Carrera.Carrera_Delete(Id)
    End Function


End Class
