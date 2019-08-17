Imports System.Collections.Generic
Imports System.Data
Imports Microsoft.VisualBasic
Imports MySql.Data.MySqlClient

Public Class ClientesDao

    Public ClientesQuery As ClientesQuery = New ClientesQuery

    Public Function GetAll() As List(Of Clientes)
        Dim list As List(Of Clientes) = New List(Of Clientes)
        Dim Obj As Clientes = Nothing

        Try
            Dim connString As String = ConexionMySQL.ConexionString
            Dim sqlQuery As String = ClientesQuery.GetAll
            Using sqlConn As New MySqlConnection(connString)
                Using sqlComm As New MySqlCommand()
                    With sqlComm
                        .Connection = sqlConn
                        .CommandText = sqlQuery
                        .CommandType = CommandType.Text
                    End With
                    Try
                        sqlConn.Open()
                        Dim sqlReader As MySqlDataReader = sqlComm.ExecuteReader()
                        While sqlReader.Read()
                            Obj = New Clientes
                            Obj.idClientes = sqlReader("idreg")
                            Obj.CodigoCliente = sqlReader("codcli")
                            Obj.DescripcionCliente = sqlReader("nomcli").ToString()
                            Obj.RazonSocial = sqlReader("ruc").ToString()
                            Obj.DireccionCliente = sqlReader("dircom").ToString()
                            Obj.TelefonoCliente = sqlReader("tele1").ToString()
                            list.Add(Obj)
                        End While
                        sqlConn.Close()
                    Catch ex As MySqlException
                        Throw
                    End Try
                End Using
            End Using

        Catch

        End Try
        Return list
    End Function

    Public Function getFacturaClientes() As List(Of Clientes)
        Dim list As List(Of Clientes) = New List(Of Clientes)
        Dim Obj As Clientes = Nothing

        Try
            Dim connString As String = ConexionMySQL.ConexionString
            Dim sqlQuery As String = ClientesQuery.getFacturaClientes
            Using sqlConn As New MySqlConnection(connString)
                Using sqlComm As New MySqlCommand()
                    With sqlComm
                        .Connection = sqlConn
                        .CommandText = sqlQuery
                        .CommandType = CommandType.Text
                    End With
                    Try
                        sqlConn.Open()
                        Dim sqlReader As MySqlDataReader = sqlComm.ExecuteReader()
                        While sqlReader.Read()
                            Obj = New Clientes
                            Obj.DescripcionCliente = sqlReader("nomcli").ToString()
                            Obj.RazonSocial = sqlReader("ruc").ToString()
                            Obj.idClientes = sqlReader("idreg")
                            Obj.CodigoCliente = sqlReader("codcli")
                            list.Add(Obj)
                        End While
                        sqlConn.Close()
                    Catch ex As MySqlException
                        Throw
                    End Try
                End Using
            End Using

        Catch

        End Try
        Return list
    End Function


    Public Function GetObjectById(idClientes As Integer) As Clientes
        Dim Obj As Clientes = New Clientes
        Try
            ClientesQuery.idClientes = idClientes
            Dim connString As String = ConexionMySQL.ConexionString
            ClientesQuery.idClientes = idClientes
            Dim sqlQuery As String = ClientesQuery.GetObjectById
            Using sqlConn As New MySqlConnection(connString)
                Using sqlComm As New MySqlCommand()
                    With sqlComm
                        .Connection = sqlConn
                        .CommandText = sqlQuery
                        .CommandType = CommandType.Text
                        .Parameters.Add("@idCliente", MySqlDbType.Int16).Value = idClientes
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
                    Catch ex As MySqlException
                        Throw
                    End Try
                End Using
            End Using
        Catch
            Throw
        End Try
        Return Obj
    End Function



    Public Function saveCliente(objetoReferencia As Clientes) As Boolean
        Dim isSave As Boolean = False

        Try
            ClientesQuery.ObjetoClientes = objetoReferencia
            ClientesQuery.isNew = True
            Dim connString As String = ConexionMySQL.ConexionString
            Dim sqlQuery As String = ClientesQuery.SaveClientes


            Using sqlConn As New MySqlConnection(connString)
                Using sqlComm As New MySqlCommand()
                    With sqlComm
                        .Connection = sqlConn
                        .CommandText = sqlQuery
                        .CommandType = CommandType.Text
                        .Parameters.Add("@CodigoCliente", MySqlDbType.Int16).Value = objetoReferencia.CodigoCliente
                        .Parameters.Add("@DescripcionCliente", MySqlDbType.String).Value = objetoReferencia.DescripcionCliente
                        .Parameters.Add("@RazonSocial", MySqlDbType.String).Value = objetoReferencia.RazonSocial
                        .Parameters.Add("@DireccionCliente", MySqlDbType.String).Value = "PERSISTENCIA DE DATOS"
                    End With

                    Try
                        sqlConn.Open()
                        Dim sqlReader As MySqlDataReader = sqlComm.ExecuteReader()
                        isSave = True
                        sqlConn.Close()
                    Catch ex As Exception
                        Throw
                    End Try
                End Using
            End Using
        Catch ex As Exception
            Throw
        End Try
        Return isSave
    End Function


End Class
