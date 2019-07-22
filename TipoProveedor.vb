
Public Class TipoProveedor 

	Protected _idTipoProveedor As Integer 
	
	Public Property	idTipoProveedor() As Integer 
		Get
			Return _idTipoProveedor
		End Get
		Set(ByVal value As Integer)
			_idTipoProveedor = value
		End Set
	End Property
	
	Protected _CodigoTipoProveedor As Integer
	
	Public Property CodigoTipoProveedor() As Integer 
		Get
			Return _CodigoTipoProveedor
		End Get
		Set(ByVal value As Integer)
			_CodigoTipoProveedor = value
		End Set
	End Property
	
	Protected _DescripcionTipoProveedor As String 
	
	Public Property DescripcionTipoProveedor() As String 
		Get
			Return _DescripcionTipoProveedor
		End Get
		Set(ByVal value As String)
			_DescripcionTipoProveedor = value
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