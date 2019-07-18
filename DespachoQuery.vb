

Public Class DespachoQuery

    Protected _ObjetoProductos As Productos 
	
	Public Property ObjetoProductos() As Productos
		Get
			Return _ObjetoProductos
		End Get
		
		Set(ByVal value As Productos)
			_ObjetoProductos = value
		End Set
	End Property    

    Protected _ObjetoDespacho As Despacho 
	
	Public Property ObjetoDespacho() As Despacho
		Get
			Return _ObjetoDespacho
		End Get
		
		Set(ByVal value As Despacho)
			_ObjetoDespacho = value
		End Set
	End Property

    Public Property CaminoDBF As String

    Public ReadOnly Property GetAllDespachoDBF() As String 
		Get
			Dim resultado As String = String.Empty
			Try
				resultado = "SELECT * FROM " & CaminoDBF
			Catch
				Throw
			End Try
			Return resultado
		End Get
	End Property

End Class