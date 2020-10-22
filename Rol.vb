
Public Class Rol
        'Variables que va a contener la clase
        'Por defecto, la variable es Private
        Private IdUsu As Integer
        Private Usuario As String
        Private Password As String

        'Getters y setters
        Public Property pIdUsu() As Integer
            Get
                Return IdUsu
            End Get
            Set(value As Integer)
                IdUsu = value
            End Set
        End Property

        Public Property pUsuario() As String
            Get
                Return Usuario
            End Get
            Set(value As String)
                Usuario = value
            End Set
        End Property

        Public Property pPassword() As String
            Get
                Return Password
            End Get
            Set(value As String)
                Password = value
            End Set
        End Property

        'Métodos

        Public Sub Login(ByVal usu As String, ByVal pass As String)
            If usu = "Bibliotecario" And pass = "Bib2020" Then
                pIdUsu = 1
            ElseIf usu = "Secretario" And pass = "Sec2020" Then
                pIdUsu = 2
            ElseIf usu = "Socio" And pass = "Soc2020" Then
                pIdUsu = 3
            Else
                'Si no se cumple ninguna de las anteriores
                MsgBox("Usuario y/o password incorrectos. Consulte con su administrador del sistema")
            End If
        End Sub

    End Class


