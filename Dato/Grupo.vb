Imports System.Data.SqlClient
Public Class Grupo
    'Opcion select
    Public Shared Function Grupo_Select() As DataTable
        'Declarar variable como nuevo objeto de conexion
        Dim oconex As New SqlConnection(My.Settings.cadena)
        'Abrir Conexion'
        oconex.Open()
        'Crear variable como sqlcommand Seleccionar Procedimiento
        Dim ocomand As New SqlCommand
        'Pasarle la conexion a la variable
        ocomand.Connection = oconex
        'Añadir el tipo de mando
        ocomand.CommandType = CommandType.StoredProcedure
        'Asignar procedimiento almacenado a realizar
        ocomand.CommandText = "pa_SELECT_GRUPO"
        'Declarar variable de IDataReader y pasarle la variable sql commando
        Dim oidr As IDataReader
        oidr = ocomand.ExecuteReader
        'Declarar variable datable y cargar los datos a traves de la variable datareader
        Dim odt As New DataTable
        odt.Load(oidr)
        Return odt
        'Cerrar conexion
        oconex.Close()
    End Function

    Public Shared Function Grupo_Insert(ByVal Cod_Grupo As Integer, ByVal Estado As String, ByVal SubGrupo As String) As Boolean
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
        ocomand.CommandText = "pa_INSERT_GRUPO"
        'Variable para determinar si los registros fueroan afectados
        Dim rpta As Boolean = False 'variable respuesta
        Dim filasAfectadas As Int16

        'Añadir los parametros por cada campo de la tabla añadiendo una copia por cada copia de la tabla
        ocomand.Parameters.AddWithValue("@Cod_Grupo", Cod_Grupo)
        ocomand.Parameters.AddWithValue("@Estado", Estado)
        ocomand.Parameters.AddWithValue("@SubGrupo", SubGrupo)

        'Ejectuar la consulta
        filasAfectadas = ocomand.ExecuteNonQuery
        'Cerrar la conexion
        oconex.Close()

        If filasAfectadas > 0 Then
            rpta = True
        End If
        Return rpta

    End Function


    'Opcion Update
    Public Shared Function Grupo_Update(ByVal Cod_Grupo As Integer, ByVal Estado As String, ByVal SubGrupo As String, ByVal Id As Integer) As Boolean
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
        ocomand.CommandText = "pa_UPDATE_GRUPO"

        'Variable para determinar si los registros fueroan afectados
        Dim rpta As Boolean = False 'variable respuesta
        Dim filasAfectadas As Int16

        'Añadir los parametros por cada campo de la tabla añadiendo una copia por cada copia de la tabla
        ocomand.Parameters.AddWithValue("@Cod_Grupo", Cod_Grupo)
        ocomand.Parameters.AddWithValue("@Estado", Estado)
        ocomand.Parameters.AddWithValue("@SubGrupo", SubGrupo)
        ocomand.Parameters.AddWithValue("@Id", Id)

        'Ejectuar la consulta
        filasAfectadas = ocomand.ExecuteNonQuery
        'Cerrar la conexion
        oconex.Close()

        If filasAfectadas > 0 Then
            rpta = True
        End If
        Return rpta

    End Function

    'Opcion Delete
    Public Shared Function Grupo_Delete(ByVal Id As Integer) As Boolean
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
        ocomand.CommandText = "pa_DELETE_GRUPO"

        'Variable para determinar si los registros fueroan afectados
        Dim rpta As Boolean = False 'variable respuesta
        Dim filasAfectadas As Int16

        'Añadir los parametros por cada campo de la tabla añadiendo una copia por cada copia de la tabla
        ocomand.Parameters.AddWithValue("@Id", Id)

        'Ver si el registro es afectado
        'Ejectuar la consulta
        filasAfectadas = ocomand.ExecuteNonQuery
        'Cerrar la conexion
        oconex.Close()

        If filasAfectadas > 0 Then
            rpta = True
        End If
        Return rpta

    End Function
End Class
