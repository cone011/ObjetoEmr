
''' <summary>
''' Clase de DetalleVentas JC 2019/07/06
''' </summary>
Public Class DetalleVentas


    Protected _idDetalleVentas As Integer

    Public Property idDetalleVentas() As Integer
        Get
            Return _idDetalleVentas
        End Get
        Set(value As Integer)
            _idDetalleVentas = value
        End Set
    End Property

    Protected _Pf1 As Integer

    Public Property Pf1() As Integer
        Get
            Return _Pf1
        End Get
        Set(value As Integer)
            _Pf1 = value
        End Set
    End Property

    Protected _Pf2 As Integer

    Public Property Pf2() As Integer
        Get
            Return _Pf2
        End Get
        Set(value As Integer)
            _Pf2 = value
        End Set
    End Property

    Protected _NumeroDocumento As Integer

    Public Property NumeroDocumento() As Integer
        Get
            Return _NumeroDocumento
        End Get
        Set(value As Integer)
            _NumeroDocumento = value
        End Set
    End Property

    Protected _FechaFacturacion As Date

    Public Property FechaFacturacion() As Date
        Get
            Return _FechaFacturacion
        End Get
        Set(value As Date)
            _FechaFacturacion = value
        End Set
    End Property

    Protected _CodigoArticulo As Integer

    Public Property CodigoArticulo() As Integer
        Get
            Return _CodigoArticulo
        End Get
        Set(value As Integer)
            _CodigoArticulo = value
        End Set
    End Property

    Protected _CantidadVendida As Decimal

    Public Property CantidadVendida() As Decimal
        Get
            Return _CantidadVendida
        End Get
        Set(value As Decimal)
            _CantidadVendida = value
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

    Protected _PrecioLista As Integer

    Public Property PrecioLista() As Integer
        Get
            Return _PrecioLista
        End Get
        Set(value As Integer)
            _PrecioLista = value
        End Set
    End Property

    Public ReadOnly Property TotalBruto As Decimal
        Get
            Dim Resultado As Decimal
            Try
                Resultado = CantidadVendida * PrecioLista
            Catch ex As Exception
                Throw
            End Try
            Return Resultado
        End Get
    End Property

    Protected _VentaIva10 As Integer

    Public Property VentaIva10() As Integer
        Get
            Return _VentaIva10
        End Get
        Set(value As Integer)
            _VentaIva10 = value
        End Set
    End Property

    Protected _VentaIva05 As Integer

    Public Property VentaIva5() As Integer
        Get
            Return _VentaIva05
        End Get
        Set(value As Integer)
            _VentaIva05 = value
        End Set
    End Property

    Protected _VentaExcento As Integer

    Public Property VentaExcento() As Integer
        Get
            Return _VentaExcento
        End Get
        Set(value As Integer)
            _VentaExcento = value
        End Set
    End Property

    Protected _ExistenciaAnterior As Integer

    Public Property ExistenciaAnterior() As Integer
        Get
            Return _ExistenciaAnterior
        End Get
        Set(value As Integer)
            _ExistenciaAnterior = value
        End Set
    End Property

    Protected _ExistenciaActual As Integer

    Public Property ExistenciaActual() As Integer
        Get
            Return _ExistenciaActual
        End Get
        Set(value As Integer)
            _ExistenciaActual = value
        End Set
    End Property

    Protected _NumeroOrden As Integer

    Public Property NumeroOrden() As Integer
        Get
            Return _NumeroOrden
        End Get
        Set(value As Integer)
            _NumeroOrden = value
        End Set
    End Property

End Class
