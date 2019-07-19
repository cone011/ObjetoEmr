

Public Class TipoFactura 

    Protected _idTipoFactura As Integer 

    Public Property idTipoFactura() As Integer
        Get
            Return _idTipoFactura
        End Get 
        Set(ByVal As Integer)
            _idTipoFactura = value  
        End Set
    End Property

    Protected _CodigoTipoFactura As String 
    
    Public Property CodigoTipoFactura() As String
        Get
            Return _CodigoTipoFactura
        End Get
        Set(ByVal value As String)
           _CodigoTipoFactura = value
        End Set
    End Property

    Protected _DescripcionTipoFactura As String 

    Public Property DescripcionTipoFactura() As String 
        Get 
            Return _DescripcionTipoFactura
        End Get
        Set(ByVal value As String)
            _DescripcionTipoFactura = value
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