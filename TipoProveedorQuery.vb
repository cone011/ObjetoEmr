

Public Class TipoProveedorQuery 
	
	Public Property isNew As Boolean = False
	
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
	
	Public ReadOnly Property SaveTipoProveedor() As String 
		Get
			Dim resultado As String = String.Empty
			Try
				If isNew Then 
					resultado = "INSERT INTO TipoProveedor(CodigoTipoProveedor, DescripcionTipoProveedor, FechaCreacion, UsuarioCreacion) VALUES (@CodigoTipoProveedor, @DescripcionTipoProveedor, CURDATE(), @UsuarioCreacion)"
				Else 
					resultado = "UPDATE TipoProveedor SET CodigoTipoProveedor = @CodigoTipoProveedor, DescripcionTipoProveedor = @DescripcionTipoProveedor, UsuarioModificacion = @UsuarioModificacion, FechaModificacion = CURDATE()"
				End If
			Catch
				Throw
			End Try
			Return resultado
		End Get
	End Property
End Class