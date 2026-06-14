Imports System.Data.SqlClient
Public Class Horario
    Public Shared Function Horario_Docente_Select(ByVal ID_Docente As Integer, ByVal Nombre As Integer, ByVal Nombre_Carrera As Integer, ByVal Cod_Sede As Integer, ByVal Cod_Grupo As Integer, ByVal Cod_Facultad As Integer)
        'Declarar variable como nuevo objeto de conexion
        Dim oconex As New SqlConnection(My.Settings.cadena)
        oconex.Open()
        'Crear variable como sqlcommand Seleccionar Procedimiento
        Dim ocomand As New SqlCommand
        'Pasarle la conexion a la variable
        ocomand.Connection = oconex
        'Añadir el tipo de mando
        ocomand.CommandType = CommandType.StoredProcedure

        'Asignar procedimiento almacenado a realizar
        ocomand.CommandText = "pa_SELECT_HORARIO_DOCENTE"
        'Variable para determinar si los registros fueroan afectados
        Dim rpta As Boolean = False 'variable respuesta
        Dim filasAfectadas As Int16

        'Añadir los parametros por cada campo de la tabla añadiendo una copia por cada copia de la tabla
        ocomand.Parameters.AddWithValue("@ID_Docente", ID_Docente)
        ocomand.Parameters.AddWithValue("@Codigo", Nombre)
        ocomand.Parameters.AddWithValue("@Nombre_Carrera", Nombre_Carrera)
        ocomand.Parameters.AddWithValue("@Cod_Sede", Cod_Sede)
        ocomand.Parameters.AddWithValue("@Cod_Grupo", Cod_Grupo)
        ocomand.Parameters.AddWithValue("@Cod_Facultad", Cod_Facultad)

        'Declarar variable de IDataReader y pasarle la variable sql commando
        Dim oidr As IDataReader
        oidr = ocomand.ExecuteReader
        'Declarar variable datable y cargar los datos a traves de la variable datareader
        Dim odt As New DataTable
        odt.Load(oidr)
        Return odt
        'Cerrar conexion
    End Function
End Class
