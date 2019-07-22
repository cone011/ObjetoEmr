
Public Class CuentasCorrientesClientes
	
	Protected _idCuentaCorrietenteClientes As Integer 
	
	Public Property idCuentasCorienteClientes() As Integer 
		Get
			Return _idCuentaCorrietenteClientes
		End Get
		Set(ByVal value As Integer)
			_idCuentaCorrietenteClientes = value
		End Set
	End Property
	
	Protected _CodigoCliente As Integer 
	
	Public Property CodigoCliente() As Integer 
		Get
			Return _CodigoCliente
		End Get
		Set(ByVal value As Integer)
			_CodigoCliente = value
		End Set
	End Property
	
	Protected _NumeroDocumento As Integer 
	
	Public Property NumeroDocumento() As Integer 
		Get
			Return _NumeroDocumento
		End Get
		Set(ByVal value As Integer)
			_NumeroDocumento = value
		End Set
	End Property
	
	Protected _TipoDocumento As Integer 
	
	Public Property TipoDocumento() As Integer 
		Get
			Return _TipoDocumento
		End Get
		Set(ByVal value As Integer)
			_TipoDocumento = value
		End Set
	End Property
	
	Protected _FechaDocumento As Date 
	
	Public Property FechaDocumento() As Date 
		Get
			Return _FechaDocumento
		End Get
		Set(ByVal value As Date)
			_FechaDocumento = value
		End Set
	End Property
	
	Protected _FechaVencimiento As Date 
	
	Public Property FechaVencimiento() As Date 
		Get
			Return _FechaVencimiento
		End Get
		Set(ByVal value As Date)
			_FechaVencimiento = value
		End Set
	End Property
	
	Protected _Importe As Integer 
	
	Public Property Importe() As Integer 
		Get
			Return _Importe
		End Get
		Set(ByVal value As Integer)
			_Importe = value
		End Set
	End Property
	
	Protected _ImporteAplicado As Integer 
	
	Public Property ImporteAplicado() As Integer 
		Get
			Return _ImporteAplicado
		End Get
		Set(ByVal value As Integer)
			_ImporteAplicado = value
		End Set
	End Property
	
	Protected _SaldoDocumento As Integer 
	
	Public Property SaldoDocumento() As Integer 
		Get
			Return _SaldoDocumento
		End Get
		Set(ByVal value As Integer)
			_SaldoDocumento = value
		End Set
	End Property
End Class