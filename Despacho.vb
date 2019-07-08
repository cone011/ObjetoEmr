
Public Class Despacho
	
	Protected _idDespacho As Integer 
	
	Public Property idDespacho() As Integer 
		Get
			Return _idDespacho
		End Get
		
		Set(ByVal value As Integer)
			_idDespacho = value
		End Set
	End Property
	
	Protected _NumeroOrden As Integer 
	
	Public Property NumeroOrden() As Integer 
		Get
			Return _NumeroOrden
		End Get
		
		Set(ByVal value As Integer)
			_NumeroOrden = value
		End Set
	End Property
	
	Protected _Fecha As Date 
	
	Public Property Fecha() As Date 
		Get
			Return _Fecha
		End Get
		
		Set(ByVal value As Date)
			_Fecha = value
		End Set
	End Property
	
	Protected _Hora As Integer 
	
	Public Property Hora() As Integer 
		Get
			Return _Hora
		End Get
		
		Set(ByVal value As Integer)
			_Hora = value
		End Set
	End Property
	
	Protected _Surtido As Integer 
	
	Public Property Surtido() As Integer 
		Get
			Return _Surtido
		End Get
		
		Set(ByVal value As Integer)
			_Surtido = value
		End Set
	End Property
	
	Protected _Mangera As Integer 
	
	Public Property Mangera() As Integer 
		Get
			Return _Mangera
		End Get
		
		Set(ByVal value As Integer)
			_Mangera = value
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
	
	Protected _Litros As Decimal 
	
	Public Property Litros() As Decimal 
		Get
			Return _Litros
		End Get
		
		Set(ByVal value As Decimal)
			_Litros = value
		End Set
	End Property
	
	Protected _Ppu As Decimal 
	
	Public Property Ppu() As Decimal 
		Get
			Return _Ppu
		End Get
		
		Set(ByVal value As Decimal)
			_Ppu = value
		End Set
	End Property
	
	Protected _Importe As Decimal 
	
	Public Property Importe() As Decimal 
		Get
			Return _Importe
		End Get
		
		Set(ByVal value As Decimal)
			_Importe = value
		End Set
	End Property
	
	Protected _Procesado As String 
	
	Public Property Procesado() As String 
		Get
			Return _Procesado
		End Get
		
		Set(ByVal value As String)
			_Procesado = value
		End Set
	End Property
	
	Protected _idUsuario As String 
	
	Public Property idUsuario() As String 
		Get
			Return _idUsuario
		End Get
		
		Set(ByVal value As String)
			_idUsuario = value
		End Set
	End Property
	
	Protected _NumeroFactura As String 
	
	Public Property NumeroFactura() As String 
		Get
			Return _NumeroFactura
		End Get
		
		Set(ByVal value As String)
			_NumeroFactura = value
		End Set
	End Property
End Class
