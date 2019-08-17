Imports System.Collections.Generic
Imports System.Data
Imports Microsoft.VisualBasic
Imports MySql.Data.MySqlClient

Public Class FormaPagoDAO

    Public FormaPagoQuery As FormaPagoQuery = New FormaPagoQuery

    Public Function GetAll() As List(Of FormaPago)
        Dim list As List(Of FormaPago) = New List(Of FormaPago)
        Dim Obj As FormaPago = Nothing

        Try
            Dim connString As String = ConexionMySQL.ConexionString
            Dim sqlQuery As String = FormaPagoQuery.GetAll
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
                            Obj = New FormaPago
                            Obj.CodigoFormaPago = sqlReader("CodigoFormaPago").ToString
                            Obj.DescripcionFormaPago = sqlReader("DescripcionFormaPago").ToString
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

    Public Function GetObjectById(idFormaPago As Integer) As FormaPago
        Dim Obj As FormaPago = New FormaPago
        Try
            Dim connString As String = ConexionMySQL.ConexionString
            Dim sqlQuery As String = FormaPagoQuery.GetObjectById
            Using sqlConn As New MySqlConnection(connString)
                Using sqlComm As New MySqlCommand()
                    With sqlComm
                        .Connection = sqlConn
                        .CommandText = sqlQuery
                        .CommandType = CommandType.Text
                        .Parameters.Add("@idFormaPago", MySqlDbType.Int16).Value = idFormaPago
                    End With
                    Try
                        sqlConn.Open()
                        Dim sqlReader As MySqlDataReader = sqlComm.ExecuteReader()
                        While sqlReader.Read()
                            Obj.CodigoFormaPago = sqlReader("CodigoFormaPago").ToString
                            Obj.DescripcionFormaPago = sqlReader("DescripcionFormaPago").ToString
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
