Imports Microsoft.VisualBasic

Public Class Usuarios

    Protected _idUsuarios As Integer



    Public Property idUsuarios() As Integer

        Get

            Return _idUsuarios

        End Get

        Set(value As Integer)

            _idUsuarios = value

        End Set

    End Property



    Protected _CodigoUsuario As Integer



    Public Property CodigoUsuario() As String

        Get

            Return _CodigoUsuario

        End Get

        Set(value As String)

            _CodigoUsuario = value

        End Set

    End Property



    Protected _NombreUsuario As String



    Public Property NombreUsuario() As String

        Get

            Return _NombreUsuario

        End Get

        Set(value As String)

            _NombreUsuario = value

        End Set

    End Property

    Protected _ContraseñaUsuario As String



    Public Property ContraseñaUsuario() As String

        Get

            Return _ContraseñaUsuario

        End Get

        Set(value As String)

            _ContraseñaUsuario = value

        End Set

    End Property



    Protected _UsuarioAbreviacion As String



    Public Property UsuarioAbreviacion() As String

        Get

            Return _UsuarioAbreviacion

        End Get

        Set(value As String)

            _UsuarioAbreviacion = value

        End Set

    End Property


End Class
