
Public Class ProveedoresQuery
	
	Public Property isNew As Boolean = False
	
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
	
	Public ReadOnly Property SaveProveedor() As String
		Get
			Dim resultado As String = String.Empty
			Try
				If isNew Then 
					resultado = "INSERT INTO proveed(codpro, nompro, ruc, tele1) VALUES (@CodigoProveedor, @NombreProveedor, @RazonSocialProveedor, @TelefonoProveedor)"
				Else 
					resultado = "UPDATE proveed SET codpro = @CodigoProveedor, nompro = @NombreProveedor, ruc = @RazonSocialProveedor, tel1 = @TelefonoProveedor"
				End If
			Catch
				Throw
			End Try
			Return resultado
		End Get
	End Property
End Class
