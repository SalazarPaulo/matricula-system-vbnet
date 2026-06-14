Public Class Facultad
    'Opcion Select
    Public Shared Function Facultad_Select() As DataTable
        'Devolver la ejecucion del parametro Asignatura select que esta en la clase de la capa datos
        Return Datos.Facultad.Facultad_Select
    End Function

    'Opcion Insert
    Public Shared Function Facultad_Insert(ByVal Cod_Facultad As Integer, ByVal Nombre As String, ByVal Cod_Carrera As Integer) As Boolean
        'Devolver la ejecucion del parametro Asignatura insert que esta en la clase de la capa datos
        Return Datos.Facultad.Facultad_Insert(Cod_Facultad, Nombre, Cod_Carrera)
    End Function
    'Opcion Update
    Public Shared Function Facultad_Update(ByVal Cod_Facultad As Integer, ByVal Nombre As String, ByVal Cod_Carrera As Integer, ByVal Id As Integer) As Boolean
        'Devolver la ejecucion del parametro Asignatura update que esta en la clase de la capa datos
        Return Datos.Facultad.Facultad_Update(Cod_Facultad, Nombre, Cod_Carrera, Id)
    End Function

    'Opcion Delete
    Public Shared Function Facultad_Delete(ByVal Id As Integer) As Boolean
        Return Datos.Facultad.Facultad_Delete(Id)
    End Function
End Class
