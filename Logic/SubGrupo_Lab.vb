Public Class SubGrupo_Lab
    'Opcion Select
    Public Shared Function SubGrupo_Lab_Select() As DataTable
        'Devolver la ejecucion del parametro Asignatura select que esta en la clase de la capa datos
        Return Datos.SubGrupo_Lab.SubGrupo_Lab_Select
    End Function

    'Opcion Insert
    Public Shared Function SubGrupo_Lab_Insert(ByVal SubGrupo As Integer) As Boolean
        'Devolver la ejecucion del parametro Asignatura insert que esta en la clase de la capa datos
        Return Datos.SubGrupo_Lab.SubGrupo_Lab_Insert(SubGrupo)
    End Function
    'Opcion Update
    Public Shared Function SubGrupo_Lab_Update(ByVal SubGrupo As Integer, ByVal Id As Integer) As Boolean
        'Devolver la ejecucion del parametro Asignatura update que esta en la clase de la capa datos
        Return Datos.SubGrupo_Lab.SubGrupo_Lab_Update(SubGrupo, Id)
    End Function

    'Opcion Delete
    Public Shared Function SubGrupo_Lab_Delete(ByVal Id As Integer) As Boolean
        Return Datos.SubGrupo_Lab.SubGrupo_Lab_Delete(Id)
    End Function
End Class
