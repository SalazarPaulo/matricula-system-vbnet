Public Class Horario
    Public Shared Function Horario_Docente_Select(ByVal ID_Docente As Integer, ByVal Nombre As Integer, ByVal Nombre_Carrera As Integer, ByVal Cod_Sede As Integer, ByVal Cod_Grupo As Integer, ByVal Cod_Facultad As Integer)
        Return Datos.Horario.Horario_Docente_Select(ID_Docente, Nombre, Nombre_Carrera, Cod_Sede, Cod_Grupo, Cod_Facultad)
    End Function
End Class
