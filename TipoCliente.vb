
''' <summary>
''' Clase de Tipo Cliente JC 2019/07/06
''' </summary>
Public Class TipoCliente

    Protected _idTipoCliente As Integer

    Public Property idTipoCliente() As Integer
        Get
            Return _idTipoCliente
        End Get
        Set(ByVal value As Integer)
            _idTipoCliente = value
        End Set
    End Property

    Protected _CodigoTipoCliente As String

    Public Property CodigoTipoCliente() As String
        Get
            Return _CodigoTipoCliente
        End Get
        Set(value As String)
            _CodigoTipoCliente = value
        End Set
    End Property

    Protected _DescripcionTipoCliente As String

    Public Property DescripcionTipoCliente() As String
        Get
            Return _DescripcionTipoCliente
        End Get
        Set(ByVal value As String)
            _DescripcionTipoCliente = value
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

End Class
