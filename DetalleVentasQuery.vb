

Public Class DetalleVentaseQuery

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
                resultado = "  
                                INSERT INTO ventasdet
                                                     (
                                                         nrodoc
                                                       , codpro
                                                       , canvta
                                                       , preunit
                                                       , totpro
                                                       , excento
                                                       , vta10p
                                                       , vta05p
                                                       , prelist
                                                       , costot
                                                     )
                                              VALUES(
                                                        @NumeroDocumento
                                                      , @CodigoProducto
                                                      , @CantidadVendida
                                                      , @PrecioUnitario
                                                      , @TotalProducto
                                                      , @VentaProductoExcento
                                                      , @VentaProdcutoIva10
                                                      , @VentaProductoIva05
                                                      , @PrecioLista
                                                      , @Costo
                                                    )
                            "
            Catch
                Throw
            End Try
            Return resultado
        End Get
    End Property



End Class

