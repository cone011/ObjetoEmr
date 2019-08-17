Imports Microsoft.VisualBasic

Public Class UsuariosQuery


    Protected _isNew As Boolean

    Public Property isNew() As Boolean
        Get
            Return _isNew
        End Get

        Set(ByVal value As Boolean)
            _isNew = value
        End Set
    End Property


    Protected _ObjetoUsuarios As Usuarios



    Public Property ObjetoUsuarios() As Usuarios

        Get

            Return _ObjetoUsuarios

        End Get



        Set(ByVal value As Usuarios)

            _ObjetoUsuarios = value

        End Set

    End Property



    Protected _idUsuarios As Integer



    Public Property idUsuarios() As Integer

        Get

            Return _idUsuarios

        End Get



        Set(ByVal value As Integer)

            _idUsuarios = value

        End Set

    End Property



    Public ReadOnly Property GetAll() As String
        Get
            Dim resultado As String = String.Empty
            Try
                resultado = "Select * From login"
            Catch
                Throw
            End Try
            Return resultado
        End Get
    End Property


    Public ReadOnly Property GetObjectById() As String
        Get
            Dim resultado As String = String.Empty
            Try
                resultado = "Select * From login WHERE idreg = " + idUsuarios
            Catch
                Throw
            End Try
            Return resultado
        End Get
    End Property

    Public ReadOnly Property SaveClientes() As String
        Get
            Dim resultado As String = String.Empty
            Try
                If isNew Then

                    resultado = "INSERT INTO login(userid,password,usrabr) VALUES(@Usuario, @Contraseña, @UsuarioAbreviacion)"
                Else
                    'resultado = "UPDATE Cliente SET codcli = " + ObjetoClientes.CodigoCliente + "," +
                    '                                "nomcli = " + ObjetoClientes.DescripcionCliente + "," +
                    '                                "ruc = " + ObjetoClientes.RazonSocial + "," +
                    '                                "dircom = " + ObjetoClientes.DireccionCliente + "," +
                    '                                "tele1 = " + ObjetoClientes.TelefonoCliente +
                    '                                "WHERE idreg = " + ObjetoClientes.idClientes
                End If
            Catch
                Throw
            End Try
            Return resultado
        End Get
    End Property

End Class
