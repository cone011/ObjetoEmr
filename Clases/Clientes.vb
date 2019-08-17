Imports Microsoft.VisualBasic

Public Class Clientes

    Protected _idClientes As Integer

    Public Property idClientes() As Integer
        Get
            Return _idClientes
        End Get
        Set(value As Integer)
            _idClientes = value
        End Set
    End Property

    Protected _CodigoCliente As String

    Public Property CodigoCliente() As String
        Get
            Return _CodigoCliente
        End Get
        Set(value As String)
            _CodigoCliente = value
        End Set
    End Property

    Protected _DescripcionCliente As String

    Public Property DescripcionCliente() As String
        Get
            Return _DescripcionCliente
        End Get
        Set(value As String)
            _DescripcionCliente = value
        End Set
    End Property

    Protected _DireccionCliente As String

    Public Property DireccionCliente() As String
        Get
            Return _DireccionCliente
        End Get
        Set(value As String)
            _DireccionCliente = value
        End Set
    End Property

    Protected _TelefonoCliente As String

    Public Property TelefonoCliente() As String
        Get
            Return _TelefonoCliente
        End Get
        Set(value As String)
            _TelefonoCliente = value
        End Set
    End Property

    Protected _RazonSocial As String

    Public Property RazonSocial() As String
        Get
            Return _RazonSocial
        End Get
        Set(value As String)
            _RazonSocial = value
        End Set
    End Property

    Protected _idTipoCliente As Integer

    Public Property idTipoCliente() As Integer
        Get
            Return _idTipoCliente
        End Get
        Set(value As Integer)
            _idTipoCliente = value
        End Set
    End Property

    Protected _FechaAgregado As Date

    Public Property FechaAgregado() As Date
        Get
            Return _FechaAgregado
        End Get
        Set(ByVal value As Date)
            _FechaAgregado = value
        End Set
    End Property

    Protected _UsuarioAgregado As String

    Public Property UsuarioAgregado() As String
        Get
            Return _UsuarioAgregado
        End Get
        Set(ByVal value As String)
            _UsuarioAgregado = value
        End Set
    End Property

    Protected _FechaModificacion As Date

    Public Property FechaModificacion() As Date
        Get
            Return _FechaModificacion
        End Get
        Set(ByVal value As Date)
            _FechaModificacion = value
        End Set
    End Property


    Protected _UsuarioModificacion As String

    Public Property UsuarioModificacion() As String
        Get
            Return _UsuarioModificacion
        End Get
        Set(ByVal value As String)
            _UsuarioModificacion = value
        End Set
    End Property


    Public ReadOnly Property ClienteRazonSocial() As String
        Get
            Dim resultado As String = String.Empty
            Try
                resultado = RazonSocial + " - " + DescripcionCliente
            Catch ex As Exception
                Throw
            End Try
            Return resultado
        End Get
    End Property

End Class
