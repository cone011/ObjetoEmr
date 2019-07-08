Imports MySql.Data.MySqlClient

Public Class ClientesDao

		Public Function GetAll() As Clientes 
		Dim list As List(Of Clientes) = New List(Of Clientes)
		Dim Obj As Clientes = Nothing
		
		Try
			Dim connString As String =  ConexionMySQL.ConexionMySQL
			Dim sqlQuery As String = ClientesQuery.GetAll
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
							Obj.idClientes = sqlReader("idreg")
							Obj.CodigoCliente = sqlReader("codcli")
							Obj.DescripcionCliente = sqlReader("nomcli").ToString()
							Obj.RazonSocial = sqlReader("ruc").ToString()
							Obj.DireccionCliente = sqlReader("dircom").ToString()
							Obj.TelefonoCliente = sqlReader("tele1").ToString()
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
	
	
	Public Function GetObjectById(idClientes As Integer) As Clientes
		Dim Obj As Clientes = Nothing
		Try
		ClientesQuery.idClientes = idClientes
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
						Obj.idClientes = sqlReader("idreg")
							Obj.CodigoCliente = sqlReader("codcli")
							Obj.DescripcionCliente = sqlReader("nomcli").ToString()
							Obj.RazonSocial = sqlReader("ruc").ToString()
							Obj.DireccionCliente = sqlReader("dircom").ToString()
							Obj.TelefonoCliente = sqlReader("tele1").ToString()
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