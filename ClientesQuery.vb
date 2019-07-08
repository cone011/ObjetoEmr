

Public Class ClientesQuery


	Protected _isNew As Boolean 
	
	Public Property isNew() As Boolean 
		Get
			Return _isNew
		End Get
		
		Set(ByVal value As Boolean)
			_isNew = value
		End Set
	End Property
	
	Protected _ObjetoClientes As Clientes 
	
	Public Property ObjetoClientes() As Clientes
		Get
			Return _ObjetoClientes
		End Get
		
		Set(ByVal value As Clientes)
			_ObjetoClientes = value
		End Set
	End Property
	
	Public ReadOnly Property GetAll() As String 
		Get
			Dim resultado As String = String.Empty
			Try
				resultado = "Select * From Cliente"
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
				resultado = "Select * From Cliente WHERE idreg" + ObjetoClientes.idClientes
			Catch
				Throw
			End Try
			Return resultado
		End Get
	End Property
	
	Public ReadOnly Property SaveClientes() As String
		Get
			Dim resultado As String = String.Empty
			Try
				If isNew Then
					resultado = "INSERT INTO Cliente(codcli,nomcli,ruc,dircom,tele1) VALUES ("+
								ObjetoClientes.CodigoCliente+","+ObjetoClientes.DescripcionCliente+","+
								ObjetoClientes.RazonSocial+","+ObjetoClientes.DireccionCliente+","+ObjetoClientes.TelefonoCliente+")"
				Else 
					resultado = "UPDATE Cliente SET codcli = "+ObjetoClientes.CodigoCliente+","+
												    "nomcli = "+ObjetoClientes.DescripcionCliente+","+
													"ruc = "+ObjetoClientes.RazonSocial+","+
													"dircom = "+ObjetoClientes.DireccionCliente+","+
													"tele1 = "+ObjetoClientes.TelefonoCliente+
													"WHERE idreg = "+ObjetoClientes.idClientes
				End if
			Catch
				Throw
			End Try
			Return resultado
		End Get
	End Property
	
End Class