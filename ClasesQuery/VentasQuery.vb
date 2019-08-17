Imports Microsoft.VisualBasic

Public Class VentasQuery

    Protected _ObjetoVentas As Ventas

    Public Property ObjetoVentas() As Ventas
        Get
            Return _ObjetoVentas
        End Get

        Set(ByVal value As Ventas)
            _ObjetoVentas = value
        End Set
    End Property

    Public ReadOnly Property GetAll() As String
        Get
            Dim resultado As String = String.Empty
            Try
                resultado = "Select * From ventas"
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
                resultado = "SELECT * FROM ventas WHERE idreg = @idVenta"
            Catch
                Throw
            End Try
            Return resultado
        End Get
    End Property

    Public ReadOnly Property InsertarVentaCabecera() As String
        Get
            Dim resultado As String = String.Empty

            Try
                resultado = "INSERT INTO ventas(pf1, pf2, nrodoc, codclien, fecfac, fecvfac, fecpro, salede, tipdoc, totdoc, totbruto , iva10, iva05, vtaiva10, vtaiva05, excento)VALUES(@Prefijo1, @Prefijo2, @NumeroDocumento, @CodigoCliente, @FechaFacturacion, @FechaVencimientoFacturacion, @FechaProcesado, @SaleDe, @TipoDocumento, @TotalDocumento, @TotalBruto, @Iva10, @Iva05, @VentaIva10, @VentaIva05, @Excento)"
            Catch
                Throw
            End Try
            Return resultado
        End Get
    End Property

End Class

''' <summary>
''' Clase DetalleVentasQuery JC 2019/08/06
''' </summary>
Public Class DetalleVentasQuery

    Protected _ObjetoDetalleVentas As DetalleVentas

    Public Property ObjetoDetalleVentas() As DetalleVentas
        Get
            Return _ObjetoDetalleVentas
        End Get

        Set(ByVal value As DetalleVentas)
            _ObjetoDetalleVentas = value
        End Set
    End Property

    Public ReadOnly Property GetAll() As String
        Get
            Dim resultado As String = String.Empty
            Try
                resultado = "Select * From ventasdet"
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
                resultado = "SELECT * FROM ventasdet WHERE pf1 = @pf1 AND pf2 = @pf2 AND nrodoc = @NumeroDocumento"
            Catch
                Throw
            End Try
            Return resultado
        End Get
    End Property

    Public ReadOnly Property SaveDetalleVentas() As String
        Get
            Dim resultado As String = String.Empty
            Try
                resultado = "INSERT INTO ventasdet(pf1 ,pf2, nrodoc, codpro, canvta, preunit, totpro, excento, vta10p, vta05p, prelist, costot)VALUES(@Prefijo1, @Prefijo2, @NumeroDocumento, @CodigoProducto, @CantidadVendida, @PrecioUnitario, @TotalProducto, @VentaProductoExcento, @VentaProdcutoIva10, @VentaProductoIva05, @PrecioLista, @Costo)"
            Catch
                Throw
            End Try
            Return resultado
        End Get
    End Property

End Class