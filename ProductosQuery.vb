Public Class ProductosQuery 
	
	Protected _ObjetoProductos As Productos 
	
	Public Property ObjetoProductos() As Productos
		Get
			Return _ObjetoProductos
		End Get
		
		Set(ByVal value As Productos)
			_ObjetoProductos = value
		End Set
	End Property
	
	Protected _idProductos As Integer 
	
	Public Property idProductos() As Integer
		Get
			Return _idProductos
		End Get
		
		Set(ByVal value As Integer)
			_idProductos = value
		End Set
	End Property

	Public Property isNew As Boolean = Falase
	
	Public ReadOnly Property GetAll() As String 
		Get
			Dim resultado As String = String.Empty
			Try
				resultado = "Select * From producto"
			Catch
				Throw
			End Try
			Return resultado
		End Get
	End Property

	Public ReadOnly Property GetAllFacturacion() As String 
		Get 
			Dim resultado As String = String.Empty
			Try
				resultado = "SELECT codpro, descri, punit FROM producto"
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
				resultado = "SELECT * FROM producto WHERE idreg = @idProducto"   
			Catch
				Throw
			End Try
			Return resultado
		End Get
	End Property

    Public ReadOnly Property SaveProducto() As String 
        Dim resultado As String = String.Empty
        Try
			If isNew Then
				 resultado = "
                            INSERT INTO prodcuto
                                                (
                                                    codpro,
                                                    descri,
                                                    punit,
                                                    pcosto,
                                                    ivaprocent,
                                                    exist1
                                                )
                                         VALUES(
                                                    @CodigoProducto,
                                                    @DescripcionProducto,
                                                    @PrecioUnitario,
                                                    @PrecioCosto,
                                                    @IvaProcentajeProducto,
                                                    @ExistenciaProducto
                                               )
                        "
			Else 
					resultado = "UPDATE producto SET codpro = @CodigoProducto,
													 descri = @DescripcionProducto,
													 punit  = @PrecioUnitario,
													 pcosto = @PrecioCosto,
													 ivaprocent = @IvaProcentajeProducto,
													 exis1 = @ExistenciaProducto
									    where idreg = @idProducto
								
								"
			End if
           
        Catch
            Throw
        End Try
        Return resultado
    End Property
End Class