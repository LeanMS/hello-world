Public Class acceso_a_datos

    Dim cadena_conexion As String = "Data Source=pav2.database.windows.net;Initial Catalog=Prueba;User ID=Administradorpav2;Password=Admin_Pav2"
    Dim nombre_tabla As String = ""
    Dim conexion As New Data.SqlClient.SqlConnection
    Dim cmd As New Data.SqlClient.SqlCommand
    Dim transaccion As New Object

    Enum estado
        ok
        rechazado
    End Enum

    Dim control_transaccion As estado = estado.ok

    Public Property _cadena_conexion As String
        Get
            Return cadena_conexion
        End Get
        Set(value As String)
            cadena_conexion = value
        End Set
    End Property

    Public Property _nombre_tabla As String
        Get
            Return nombre_tabla
        End Get
        Set(value As String)
            nombre_tabla = value
        End Set
    End Property


    Public Function Consulta(ByVal sql As String) As Data.DataTable
        Dim tabla As New Data.DataTable

        conectar()
        cmd.CommandText = sql
        tabla.Load(cmd.ExecuteReader())
        conexion.Close()

        Return tabla
    End Function

    Public Sub conectar()
        conexion.ConnectionString = cadena_conexion
        conexion.Open()
        cmd.Connection = conexion
        cmd.CommandType = CommandType.Text
    End Sub

    Public Function ejecutar(ByVal comando As String) As String

        cmd.CommandText = comando
        Try
            cmd.ExecuteNonQuery()
            Return "ok"

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            control_transaccion = estado.rechazado
            Return ex.Message

        End Try

    End Function

    Public Sub insertar(ByVal txt As String)
        ejecutar(txt)
    End Sub

    Public Sub comenzar_transaccion()

        Me.transaccion = Me.conexion.BeginTransaction()
        Me.cmd.Transaction = Me.transaccion
    End Sub


    Public Sub finalizar_transaccion()

        If control_transaccion = estado.ok Then
            transaccion.Commit()
            MsgBox("Se guardo con exito", MsgBoxStyle.Information, "Importante")
        Else
            transaccion.Rollback()
            MsgBox("No se pudo guardar", MsgBoxStyle.Information, "Importante")
        End If
        conexion.Close()
    End Sub



    Public Sub carga_combo(ByRef combo As ComboBox, ByRef datos As Data.DataTable, ByVal pk As String, ByVal descripcion As String)
        combo.DataSource = datos
        combo.ValueMember = pk
        combo.DisplayMember = descripcion
    End Sub

    Public Function leo_tabla(ByVal nom_tabla As String) As Data.DataTable
        Return Consulta("select * from " & nom_tabla)
    End Function

End Class
