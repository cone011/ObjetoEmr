
Public Class ProveedoresQuery
	
	Public ReadOnly Property GetAll() As String 
		Get
			Dim resultado As String = String.Empty
			Try
				resultado = "SELECT * FROM proveed"
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
				resultado = "SELECT * FROM proveed WHERE ireg = @idProveedor"
			Catch
				Throw
			End Try
			Return resultado
		End Get
	End Property
	
	Public ReadOnly Property GetObjectByCodigoProveedor() As String 
		Get
			Dim resultado As String = String.Empty 
			Try
				resultado = "SELECT  * FROM proveed WHERE codpro = @CodigoProveedor"
			Catch
				Throw
			End Try
		End Get
	End Property
End Class
