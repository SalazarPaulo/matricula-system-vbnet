Imports System.Data.SqlClient
Public Class Profesor
    'Opcion select
    Public Shared Function Profesor_Select() As DataTable
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
        ocomand.CommandText = "pa_SELECT_PROFESOR"
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

    Public Shared Function Profesor_Insert(ByVal ID_Docente As Integer, ByVal Nombres As String, ByVal Apellidos As String, ByVal Email As String, ByVal Fecha_Nac As Date) As Boolean
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
        ocomand.CommandText = "pa_INSERT_PROFESOR"
        'Variable para determinar si los registros fueroan afectados
        Dim rpta As Boolean = False 'variable respuesta
        Dim filasAfectadas As Int16

        'Añadir los parametros por cada campo de la tabla añadiendo una copia por cada copia de la tabla
        ocomand.Parameters.AddWithValue("@ID_Docente", ID_Docente)
        ocomand.Parameters.AddWithValue("@Nombres", Nombres)
        ocomand.Parameters.AddWithValue("@Apellidos", Apellidos)
        ocomand.Parameters.AddWithValue("@Email", Email)
        ocomand.Parameters.AddWithValue("@Fecha_Nac", Fecha_Nac)

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
    Public Shared Function Profesor_Update(ByVal ID_Docente As Integer, ByVal Nombres As String, ByVal Apellidos As String, ByVal Email As String, ByVal Fecha_Nac As Date, ByVal Id As Integer) As Boolean
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
        ocomand.CommandText = "pa_UPDATE_PROFESOR"

        'Variable para determinar si los registros fueroan afectados
        Dim rpta As Boolean = False 'variable respuesta
        Dim filasAfectadas As Int16

        'Añadir los parametros por cada campo de la tabla añadiendo una copia por cada copia de la tabla
        ocomand.Parameters.AddWithValue("@ID_Docente", ID_Docente)
        ocomand.Parameters.AddWithValue("@Nombres", Nombres)
        ocomand.Parameters.AddWithValue("@Apellidos", Apellidos)
        ocomand.Parameters.AddWithValue("@Email", Email)
        ocomand.Parameters.AddWithValue("@Fecha_Nac", Fecha_Nac)

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
    Public Shared Function Profesor_Delete(ByVal Id As Integer) As Boolean
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
        ocomand.CommandText = "pa_DELETE_PROFESOR"

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
