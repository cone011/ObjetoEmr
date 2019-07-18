
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
                resultado = "INSERT INTO ventas 
                                        (
                                          pf1
                                        , pf2  
                                        , nrodoc
                                        , codclien
                                        , fecfact
                                        , fecvfac
                                        , fecpro
                                        , salede
                                        , tipodoc
                                        , totdoc
                                        , totbruto
                                        , iva10
                                        , iva05
                                        , vtaiva10
                                        , vtaiva05
                                        , excento)
                                VALUES(
                                        @Prefijo1,
                                        @Prefijo2,
                                        @NumeroDocumento,
                                        @CodigoCliente,
                                        @FechaFacturacion,
                                        @FechaVencimientoFacturacion,
                                        @FechaProcesado,
                                        @SaleDe,
                                        @TipoDocumento,
                                        @TotalDocumento,
                                        @TotalBruto,
                                        @Iva10,
                                        @Iva05,
                                        @VentaIva10,
                                        @VentaIva05,
                                        @Excento
                                      )"
           Catch
                Throw
           End Try
           return resultado
        End Get
    End Property


End Class