
Public Class Proveedores
	
	Protected _idProveedores As Integer 
	
	Public Property idProveedores() As Integer 
		Get
			Return _idProveedores
		End Get
		Set(ByVal value As Integer)
			_idProveedores = value
		End Set
	End Property
	
	Protected _CodigoProveedores As Integer 
	
	Public Property CodigoProveedores() As Integer
		Get
			Return _CodigoProveedores
		End Get
		Set(ByVal value As Integer)
			_CodigoProveedores = value
		End Set
	End Property
	
	Protected _DescripcionProveedores As String 
	
	Public Property DescripcionProveedores() As String
		Get
			Return _DescripcionProveedores
		End Get
		Set(ByVal value As String)
			_DescripcionProveedores = value
		End Set
	End Property
	
	Protected _RazonSocialProveedores As String 
	
	Public Property RazonSocialProveedores() As String 
		Get
			Return _RazonSocialProveedores
		End Get
		Set(ByVal value As String)
			_RazonSocialProveedores = value
		End Set
	End Property
	
	Protected _idTipoProveedor As Integer 
	
	Public Property idTipoProveedor() As Integer 
		Get
			Return _idProveedores
		End Get
		Set(ByVal value As Integer)
			_idTipoProveedor = value
		End Set
	End Property
	
	Protected _TelefonoProveedores As String 
	
	Public Property TelefonoProveedores() As String 
		Get
			Return _TelefonoProveedores
		End Get
		Set(ByVal value As String)
			_TelefonoProveedores = value
		End Set
	End Property
	
	Protected _CelularProveedores As String 
	
	Public Property CelularProveedores() As String 
		Get
			Return _CelularProveedores
		End Get
		Set(ByVal value As String)
			_TelefonoProveedores = value
		End Set
	End Property
	
	Protected _EmailProveedores As String 
	
	Public Property EmailProveedores() As String 
		Get
			Return _EmailProveedores
		End Get
		Set(ByVal value As String)
			_EmailProveedores = value
		End Set
	End Property
	
	Protected _DireccionProveedor As String 
	
	Public Property DireccionProveedor() As String
		Get
			Return _DireccionProveedor
		End Get
		Set(ByVal value As String)
			_DireccionProveedor = value
		End Set
	End Property
	
	Protected _PagaIva As String 
	
	Public Property PagaIva() As String 
		Get
			Return _PagaIva
		End Get
		Set(ByVal value As String)
			_PagaIva = value
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