
''' <summary>
''' Clase de Productos JC 2019/07/06
''' </summary>
Public Class Productos

    Protected _idProductos As Integer

    Public Property idProductos() As Integer
        Get
            Return _idProductos
        End Get
        Set(value As Integer)
            _idProductos = value
        End Set
    End Property

    Protected _CodigoProductos As Integer

    Public Property CodigoProductos() As Integer
        Get
            Return _CodigoProductos
        End Get
        Set(value As Integer)
            _CodigoProductos = value
        End Set
    End Property

    Protected _DescripcionProducto As String

    Public Property DescripcionProducto() As String
        Get
            Return _DescripcionProducto
        End Get
        Set(ByVal value As String)
            _DescripcionProducto = value
        End Set
    End Property

    Protected _PrecioUnitario As Integer

    Public Property PrecioUnitario() As Integer
        Get
            Return _PrecioUnitario
        End Get
        Set(value As Integer)
            _PrecioUnitario = value
        End Set
    End Property

    Protected _PrecioCosto As Integer

    Public Property PrecioCosto() As Integer
        Get
            Return _PrecioCosto
        End Get
        Set(value As Integer)
            _PrecioCosto = value
        End Set
    End Property



End Class
