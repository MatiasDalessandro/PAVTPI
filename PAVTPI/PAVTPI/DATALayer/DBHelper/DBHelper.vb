Imports System.Data.SqlClient
'Imports System.Data.SQLite

Public Class DBHelper
    ' La clase BDHelper permite quitar del código del formulario todo lo relacionado con el acceso a bd.
    ' Permite ejecutar comandos sql y retornar resultados a la capa de datos.
    ' Implementa el patrón SINGLETON, que garantiza tener solo una instancia de esta clase.

    Private string_conexion As String
    Private Shared instance As DBHelper 'Unica instancia de la clase

    Public deDondeViene As Integer
    Private Sub New()

        'IMPORTANTE
        'CUANDO TRABAJEMOS CON EL STRING DE CONEXION,
        'COMENTAR EL DE LA OTRA PERSONA Y DESCOMENTAR EL PROPIO
        'ASI NO NOS COMEMOS EL VIAJE DE ESTARLO PONIENDO SIEMPRE.



        string_conexion = "Data Source=" & My.Computer.Name.ToString & ";Initial Catalog=prueba2;Integrated Security=True"
        'string_conexion = "Data Source=basedato.db"
    End Sub

    Public Shared Function getDBHelper() As DBHelper
        If IsNothing(instance) Then
            instance = New DBHelper()
        End If
        Return instance
    End Function

    Public Function EjecutarSQL(ByVal strSql As String) As Integer
        ' Se utiliza para sentencias SQL del tipo “Insert/Update/Delete”
        Dim number As Integer = 0
        Dim conexion As New SqlConnection
        Dim cmd As New SqlCommand
        'Dim conexion As New SQLiteConnection
        'Dim cmd As New SQLiteCommand


        'Try Catch Finally
        'Trata de ejecutar el código contenido dentro del bloque Try - Catch
        'Si hay error lo capta a través de una excepción
        'Si no hubo error
        Try
            ' Establece que conexión usar
            conexion.ConnectionString = string_conexion
            ' Abre la conexión
            conexion.Open()

            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text
            ' Establece la instrucción a ejecutar
            cmd.CommandText = strSql
            ' Retorna el resultado de ejecutar el comando
            number = cmd.ExecuteNonQuery()
        Catch ex As Exception
            'Throw ex
            MsgBox(ex.ToString)
        Finally
            ' Cierra la conexión
            conexion.Close()
            conexion.Dispose()
        End Try
        Return number
    End Function

    Public Function ConsultaSQL(ByVal strSql As String) As Data.DataTable
        ' Se utiliza para sentencias SQL del tipo “Select”
        ' La función recibe por valor una sentencia sql como string, devuelve un objeto de tipo DataTable
        Dim conexion As New SqlConnection
        Dim cmd As New SqlCommand
        Dim tabla As New DataTable
        Try
            conexion.ConnectionString = string_conexion
            conexion.Open()
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text
            cmd.CommandText = strSql
            ' El datatable se carga con el resultado de ejecutar la sentencia en el motor de base de datos
            tabla.Load(cmd.ExecuteReader)
            ' La función retorna el objeto datatable con 0, 1 o mas registros
            Return tabla
        Catch ex As Exception
            MsgBox(ex.ToString)
            Throw ex
        Finally
            conexion.Close()
            conexion.Dispose()
        End Try
    End Function
End Class
