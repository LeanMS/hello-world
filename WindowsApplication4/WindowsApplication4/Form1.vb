Public Class Form1

    Dim acceso As New acceso_a_datos With {._nombre_tabla = "dbo.Provincia"}



    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lbl_usuario.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txt_nomUsuario.TextChanged

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        acceso.carga_combo(cmb_Provincia, acceso.leo_tabla("Dbo.Provincia"), "id_Provincia", "Nombre")
        acceso.carga_combo(cmb_dni, acceso.leo_tabla("dbo.DNI"), "Id_tipo_DNI", "Descripcion")
    End Sub

    Private Sub grabar_usuario()
        Dim txt As String = ""
        txt = "INSERT INTO " & " dbo.Usuario " & " (Cod_usuario,Nombre,Apellido,Id_tipo_DNI) " & " VALUES " & " (  " & txt_idUsuario.Text & ", ' " & txt_nomUsuario.Text & " ' ," & " ' " & txt_apellido.Text & " ' ," & cmb_dni.SelectedValue & " )"
        acceso.insertar(txt)
    End Sub

    Private Sub grabar_provincia()
        Dim txt As String = ""
        txt = "INSERT INTO dbo.Provincia (id_provincia,Nombre) VALUES " & "(" & txt_idProvincia.Text & ", " & "' " & txt_nombreProvincia.Text & "')"
        acceso.insertar(txt)

    End Sub

    Private Sub cargar_usuario_Click(sender As Object, e As EventArgs) Handles cargar_usuario.Click
        acceso.conectar()
        acceso.comenzar_transaccion()
        grabar_usuario()
        grabar_provincia()
        acceso.finalizar_transaccion()
    End Sub

    Private Sub tipoDNI_CheckedChanged(sender As Object, e As EventArgs)

    End Sub
End Class
