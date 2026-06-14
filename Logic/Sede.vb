Public Class Sede
    'Opcion Select
    Public Shared Function Sede_Select() As DataTable
        'Devolver la ejecucion del parametro Asignatura select que esta en la clase de la capa datos
        Return Datos.Sede.Sede_Select
    End Function

    'Opcion Insert
    Public Shared Function Sede_Insert(ByVal Cod_Sede As Integer, ByVal Nombre As String, ByVal Direccion As String) As Boolean
        'Devolver la ejecucion del parametro Asignatura insert que esta en la clase de la capa datos
        Return Datos.Sede.Sede_Insert(Cod_Sede, Nombre, Direccion)
    End Function
    'Opcion Update
    Public Shared Function Sede_Update(ByVal Cod_Sede As Integer, ByVal Nombre As String, ByVal Direccion As String, ByVal Id As Integer) As Boolean
        'Devolver la ejecucion del parametro Asignatura update que esta en la clase de la capa datos
        Return Datos.Sede.Sede_Update(Cod_Sede, Nombre, Direccion, Id)
    End Function

    'Opcion Delete
    Public Shared Function Sede_Delete(ByVal Id As Integer) As Boolean
        Return Datos.Sede.Sede_Delete(Id)
    End Function
End Class
