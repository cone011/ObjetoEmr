Imports System.Collections.Generic
Imports System.Data
Imports Microsoft.VisualBasic
Imports MySql.Data.MySqlClient

Public Class ProductosDAO

    Public ProductosQuery As ProductosQuery = New ProductosQuery

    Public Function GetAll() As List(Of Productos)
        Dim list As List(Of Productos) = New List(Of Productos)
        Dim Obj As Productos = Nothing

        Try
            Dim connString As String = ConexionMySQL.ConexionString
            Dim sqlQuery As String = ProductosQuery.GetAll
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
                            Obj = New Productos
                            Obj.idProductos = sqlReader("idreg")
                            Obj.CodigoProductos = sqlReader("codpro")
                            Obj.DescripcionProducto = sqlReader("descri").ToString()
                            Obj.PrecioUnitario = sqlReader("punit")
                            Obj.PrecioCosto = sqlReader("pcosto")
                            list.Add(Obj)
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
        Return list
    End Function

    Public Function GetAllFacturacion() As List(Of Productos)
        Dim list As List(Of Productos) = New List(Of Productos)
        Dim Obj As Productos = Nothing

        Try
            Dim connString As String = ConexionMySQL.ConexionString
            Dim sqlQuery As String = ProductosQuery.GetAllFacturacion
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
                            Obj = New Productos
                            Obj.idProductos = sqlReader("idreg")
                            Obj.CodigoProductos = sqlReader("codpro").ToString()
                            Obj.DescripcionProducto = sqlReader("descri").ToString()
                            Obj.PrecioUnitario = sqlReader("punit")
                            Obj.PrecioCosto = sqlReader("pcosto")
                            list.Add(Obj)
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
        Return list
    End Function

    Public Function GetObjectById(idProductos As Integer) As Productos
        Dim Obj As Productos = New Productos
        Try
            Dim connString As String = ConexionMySQL.ConexionString
            Dim sqlQuery As String = ProductosQuery.GetObjectById
            Using sqlConn As New MySqlConnection(connString)
                Using sqlComm As New MySqlCommand()
                    With sqlComm
                        .Connection = sqlConn
                        .CommandText = sqlQuery
                        .CommandType = CommandType.Text
                        .Parameters.Add("@idProducto", MySqlDbType.Int16).Value = idProductos
                    End With
                    Try
                        sqlConn.Open()
                        Dim sqlReader As MySqlDataReader = sqlComm.ExecuteReader()
                        While sqlReader.Read()
                            Obj.idProductos = sqlReader("idreg")
                            Obj.CodigoProductos = sqlReader("codpro")
                            Obj.DescripcionProducto = sqlReader("descri").ToString()
                            Obj.PrecioUnitario = sqlReader("punit")
                            Obj.PrecioCosto = sqlReader("pcosto")
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

End Class
