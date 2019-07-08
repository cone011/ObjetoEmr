Imports MySql.Data.MySqlClient


Public Class ProductosDAO


Public Function GetAll() As Productos 
	Dim list As List(Of Productos) = New List(Of Productos)
	Dim Obj As Productos = Nothing
	
	Try
		'Dim databaseConnection As MySqlConnection = New MySqlConnection(ConexionMySQL.ConexionString )
		'Dim commandDatabase As MySqlCommand = New MySqlCommand(ProductosQuery.GetAll, databaseConnection)
		'commandDatabase.CommandTimeout = 3600
		'Dim reader As MySqlDataReader
		'databaseConnection.Open()
		'reader = commandDatabase.ExecuteReader()
		
		Dim connString As String =  ConexionMySQL.ConexionMySQL
		Dim sqlQuery As String = ProductosQuery.GetAll
		Using sqlConn As New MySqlConnection(connString)
			Using sqlComm As New MySqlCommand()
				With sqlComm
					.Connection = sqlConn
					.Commandtext = sqlQuery
					.CommandType = CommandType.Text
				End With
				Try
					sqlConn.Open()
					Dim sqlReader As MySqlDataReader = sqlComm.ExecuteReader()
					While sqlReader.Read()
						'Label1.Text = sqlReader("Name").ToString()
						'Label2.Text = sqlReader("Points").ToString()
						Obj.idProductos = sqlReader("idreg")
						Obj.CodigoProductos = sqlReader("codpro")
						Obj.DescripcionProducto = sqlReader("descri").ToString()
						Obj.PrecioUnitario = sqlReader("punit").ToString()
						Obj.PrecioCosto = sqlReader("pcosto").ToString()
						list.Add(Obj)
					End While
					sqlConn.Close()
				Catch ex As MySQLException
					Throw
				End Try
			End Using
		End Using
		
	Catch
	
	End Try
	Return list
End Function

	Public Function GetObjectById(idProductos As Integer) As Productos
		Dim Obj As Productos = Nothing
		Try
		'Dim databaseConnection As MySqlConnection = New MySqlConnection(ConexionMySQL.ConexionString )
		'Dim commandDatabase As MySqlCommand = New MySqlCommand(ProductosQuery.GetAll, databaseConnection)
		'commandDatabase.CommandTimeout = 3600
		'Dim reader As MySqlDataReader
		'databaseConnection.Open()
		'reader = commandDatabase.ExecuteReader()
		ProductosQuery.idProductos = idProductos
		Dim connString As String =  ConexionMySQL.ConexionMySQL
		Dim sqlQuery As String = ProductosQuery.GetObjectById
		Using sqlConn As New MySqlConnection(connString)
			Using sqlComm As New MySqlCommand()
				With sqlComm
					.Connection = sqlConn
					.Commandtext = sqlQuery
					.CommandType = CommandType.Text
				End With
				Try
					sqlConn.Open()
					Dim sqlReader As MySqlDataReader = sqlComm.ExecuteReader()
					While sqlReader.Read()
						'Label1.Text = sqlReader("Name").ToString()
						'Label2.Text = sqlReader("Points").ToString()
						Obj.idProductos = sqlReader("idreg")
						Obj.CodigoProductos = sqlReader("codpro")
						Obj.DescripcionProducto = sqlReader("descri").ToString()
						Obj.PrecioUnitario = sqlReader("punit").ToString()
						Obj.PrecioCosto = sqlReader("pcosto").ToString()
					End While
					sqlConn.Close()
				Catch ex As MySQLException
					Throw
				End Try
			End Using
		End Using
		Catch
			Throw
		End Try
		Return Obj
	End Function

End Class


