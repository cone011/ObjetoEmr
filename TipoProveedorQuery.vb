

Public Class TipoProveedorQuery 
	
	Public ReadOnly Property GetAll() As String 
		Get
			Dim resultado As String = String.Empty
			Try
				resultado = "SELECT * FROM TipoProveedor"
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
				resultado = "SELECT * FROM TipoProveedor WHERE idTipoProveedor = @idTipoProveedor"
			Catch
				Throw
			End Try
			Return resultado
		End Get
	End Property
End Class