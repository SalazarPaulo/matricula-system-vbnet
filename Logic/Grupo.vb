Public Class Grupo
    'Opcion Select
    Public Shared Function Grupo_Select() As DataTable
        'Devolver la ejecucion del parametro Asignatura select que esta en la clase de la capa datos
        Return Datos.Grupo.Grupo_Select
    End Function

    'Opcion Insert
    Public Shared Function Grupo_Insert(ByVal Cod_Grupo As Integer, ByVal Estado As String, ByVal SubGrupo As Integer) As Boolean
        'Devolver la ejecucion del parametro Asignatura insert que esta en la clase de la capa datos
        Return Datos.Grupo.Grupo_Insert(Cod_Grupo, Estado, SubGrupo)
    End Function
    'Opcion Update
    Public Shared Function Grupo_Update(ByVal Cod_Grupo As Integer, ByVal Estado As String, ByVal SubGrupo As String, ByVal Id As Integer) As Boolean
        'Devolver la ejecucion del parametro Asignatura update que esta en la clase de la capa datos
        Return Datos.Grupo.Grupo_Update(Cod_Grupo, Estado, SubGrupo, Id)
    End Function

    'Opcion Delete
    Public Shared Function Grupo_Delete(ByVal Id As Integer) As Boolean
        Return Datos.Grupo.Grupo_Delete(Id)
    End Function
End Class
