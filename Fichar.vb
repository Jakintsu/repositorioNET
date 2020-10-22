Public Class Fichar
    'Hola. Primer comentario

    Private Sub BtnRol_Click(sender As Object, e As EventArgs) Handles BtnRol.Click
        'Crear un objeto de la clase que hemos creado
        Dim Rol1 As Rol = New Rol()

        'Llamar al método login, dentro de la clase Rol
        Rol1.Login(TxtRol.Text, TxtPassword.Text)
    End Sub
End Class
