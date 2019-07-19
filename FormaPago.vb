

Public Class FormaPago

    Protected _idFormaPago As Integer 

    Public Property idFormaPago() As Integer
        Get 
            Return _idFormaPago
        End Get
        Set(ByVal value As Integer)
            _idFormaPago = value
        End Set
    End Property

    Protected _CodigoFormaPago As String 

    Public Property CodigoFormaPago() As String 
        Get 
            Return _CodigoFormaPago
        End Get 
        Set(ByVal value As String)
            _CodigoFormaPago = value
        End Set
    End Property

    Protected _DescripcionFormaPago As String

    Public Property DescripcionFormaPago() As String
        Get
            Return _DescripcionFormaPago
        End Get
        Set(ByVal value As String)
            _DescripcionFormaPago = value
        End Set
    End Property
    
    Protected _UsuarioCreacion As String 

    Public Property UsuarioCreacion() As String 
        Get
            Return _UsuarioCreacion
        End Get
        Set(ByVal value As String)
            _UsuarioCreacion = value
        End Set
    End Property

    Protected _FechaCreacion As Date 

    Public Property FechaCreacion() As Date 
        Get
            Return _FechaCreacion
        End Get
        Set(ByVal value As Date)
            _FechaCreacion = value
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

    Protected _FechaModificacion As Date 

    Public Property FechaModificacion() As Date 
        Get
            Return _FechaModificacion
        End Get
        Set(ByVal value As Date)
            _FechaModificacion = value
        End Set
    End Property

End Class