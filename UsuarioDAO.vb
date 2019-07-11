
Imports MySql.Data.MySqlClient

Public Class UsuarioDAO


    Public Function GetAll() As List(Of Usuarios) 

		Dim list As List(Of Usuarios) = New List(Of Usuarios)

		Dim Obj As Usuarios = Nothing

		Try

			Dim connString As String =  ConexionMySQL.ConexionMySQL

			Dim sqlQuery As String = UsuariosQuery.GetAll

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

							Obj.idUsuarios = sqlReader("idreg")

							Obj.CodigoUsuario = sqlReader("userid")

							Obj.NombreUsuario = sqlReader("nombx").ToString()

							Obj.UsuarioAbreviacion = sqlReader("usrab").ToString() ''Revisar Campo luego al realizar la consulta

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

	

	

	Public Function GetObjectById(idUsuarios As Integer) As Usuarios

		Dim Obj As Usuarios = Nothing

		Try

		UsuariosQuery.idUsuarios = idUsuarios

		Dim connString As String =  ConexionMySQL.ConexionMySQL

		Dim sqlQuery As String = UsuariosQuery.GetObjectById

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

						Obj.idUsuarios = sqlReader("idreg")

						Obj.CodigoUsuario = sqlReader("userid")

						Obj.NombreUsuario = sqlReader("nombx").ToString()

						Obj.UsuarioAbreviacion = sqlReader("usrab").ToString() ''Revisar Campo luego al realizar la consulta


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