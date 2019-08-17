Imports Microsoft.VisualBasic

Public Class Ventas

    Protected _idVentas As Integer

    Public Property idVentas() As Integer
        Get
            Return _idVentas
        End Get
        Set(value As Integer)
            _idVentas = value
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

    Public ReadOnly Property DescripcionNumeroFactura As String
        Get
            Dim resultado As String = String.Empty
            Try
                resultado = Pf1 + " - " + Pf2 + " - " + NumeroDocumento
            Catch ex As Exception
                Throw
            End Try
            Return resultado
        End Get
    End Property

    Protected _Cliente As Clientes

    Public Property Cliente() As Clientes
        Get
            Return _Cliente
        End Get
        Set(value As Clientes)
            _Cliente = value
        End Set
    End Property

    Protected _TipoFactura As TipoFactura

    Public Property TipoFactura() As TipoFactura
        Get
            Return _TipoFactura
        End Get
        Set(value As TipoFactura)
            _TipoFactura = value
        End Set
    End Property

    Protected _FormaPago As FormaPago

    Public Property FormaPago() As FormaPago
        Get
            Return _FormaPago
        End Get
        Set(value As FormaPago)
            _FormaPago = value
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

    Protected _FechaVencimiento As Date

    Public Property FechaVencimiento() As Date
        Get
            Return _FechaVencimiento
        End Get
        Set(value As Date)
            _FechaVencimiento = value
        End Set
    End Property

    Protected _idTipoDocumento As Integer

    Public Property idTipoDocumento() As Integer
        Get
            Return _idTipoDocumento
        End Get
        Set(value As Integer)
            _idTipoDocumento = value
        End Set
    End Property

    Protected _Vale As Integer

    Public Property Vale() As Integer
        Get
            Return _Vale
        End Get
        Set(value As Integer)
            _Vale = value
        End Set
    End Property

    Protected _TotalDocumento As Integer

    Public Property TotalDocumento() As Integer
        Get
            Return _TotalDocumento
        End Get
        Set(value As Integer)
            _TotalDocumento = value
        End Set
    End Property

    Protected _TotalBruto As Integer

    Public Property TotalBruto() As Integer
        Get
            Return _TotalBruto
        End Get
        Set(value As Integer)
            _TotalBruto = value
        End Set
    End Property

    Protected _TotalIva10 As Integer

    Public Property TotalIva10() As Integer
        Get
            Return _TotalIva10
        End Get
        Set(value As Integer)
            _TotalIva10 = value
        End Set
    End Property

    Protected _TotalIva05 As Integer

    Public Property TotalIva05() As Integer
        Get
            Return _TotalIva05
        End Get
        Set(value As Integer)
            _TotalIva05 = value
        End Set
    End Property

    Protected _TotalExcento As Integer

    Public Property TotalExcento() As Integer
        Get
            Return _TotalExcento
        End Get
        Set(value As Integer)
            _TotalExcento = value
        End Set
    End Property

    Protected _TotalVentaIva10 As Integer

    Public Property TotalVentaIva10() As Integer
        Get
            Return _TotalVentaIva10
        End Get
        Set(value As Integer)
            _TotalVentaIva10 = value
        End Set
    End Property

    Protected _TotalVentaIva05 As Integer

    Public Property TotalVentaIva05() As Integer
        Get
            Return _TotalVentaIva05
        End Get
        Set(value As Integer)
            _TotalVentaIva05 = value
        End Set
    End Property


    Protected _TotalVentaExcenta As Integer

    Public Property TotalVentaExcenta() As Integer
        Get
            Return _TotalVentaExcenta
        End Get
        Set(value As Integer)
            _TotalVentaExcenta = value
        End Set
    End Property

    Protected _DetalleVentasList As List(Of VentasDetalle)

    Public Property DetalleVentasList() As List(Of VentasDetalle)
        Get
            Return _DetalleVentasList
        End Get
        Set(value As List(Of VentasDetalle))
            _DetalleVentasList = value
        End Set
    End Property

    Protected _UsuarioFacturacion As String

    Public Property UsuarioFacturacion() As String
        Get
            Return _UsuarioFacturacion
        End Get
        Set(value As String)
            _UsuarioFacturacion = value
        End Set
    End Property

    Protected _UsuarioAbreviado As String

    Public Property UsuarioAbreviado() As String
        Get
            Return _UsuarioAbreviado
        End Get
        Set(value As String)
            _UsuarioAbreviado = value
        End Set
    End Property

End Class

''' <summary>
''' Clase Detalle de la venta JC 2019/08/06
''' </summary>
Public Class VentasDetalle

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
