Public Class Asignatura
    Public Shared Function Asignatura_Select() As DataTable
        'Devolver la ejecucion del parametro Asignatura select que esta en la clase de la capa datos
        Return Datos.Asignatura.Asignatura_Select
    End Function

    Public Shared Function Asignatura_Insert(ByVal Codigo As Integer, ByVal Nombre As String) As Boolean
        'Devolver la ejecucion del parametro Asignatura insert que esta en la clase de la capa datos
        Return Datos.Asignatura.Asignatura_Insert(Codigo, Nombre)
    End Function

    'Opcion Update
    Public Shared Function Asignatura_Update(ByVal Codigo As Integer, ByVal Nombre As String, ByVal Id As Integer) As Boolean
        'Devolver la ejecucion del parametro Asignatura update que esta en la clase de la capa datos
        Return Datos.Asignatura.Asignatura_Update(Codigo, Nombre, Id)
    End Function

    'Opcion Delete
    Public Shared Function Asignatura_Delete(ByVal Id As Integer) As Boolean
        Return Datos.Asignatura.Asignatura_Delete(Id)
    End Function
End Class
