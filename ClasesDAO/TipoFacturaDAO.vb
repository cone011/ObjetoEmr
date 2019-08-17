Imports System.Collections.Generic
Imports System.Data
Imports Microsoft.VisualBasic
Imports MySql.Data.MySqlClient
Public Class TipoFacturaDAO

    Public TipoFacturaQuery As TipoFacturaQuery = New TipoFacturaQuery

    Public Function GetAll() As List(Of TipoFactura)
        Dim list As List(Of TipoFactura) = New List(Of TipoFactura)
        Dim Obj As TipoFactura = Nothing

        Try
            Dim connString As String = ConexionMySQL.ConexionString
            Dim sqlQuery As String = TipoFacturaQuery.GetAll
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
                            Obj = New TipoFactura
                            Obj.idTipoFactura = sqlReader("tipodoc")
                            Obj.DescripcionTipoFactura = sqlReader("tipodocume").ToString
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

    Public Function GetObjectById(idTipoFactura As Integer) As TipoFactura
        Dim Obj As TipoFactura = New TipoFactura
        Try
            TipoFacturaQuery.idTipoFactura = idTipoFactura
            Dim connString As String = ConexionMySQL.ConexionString
            Dim sqlQuery As String = TipoFacturaQuery.GetObjectById
            Using sqlConn As New MySqlConnection(connString)
                Using sqlComm As New MySqlCommand()
                    With sqlComm
                        .Connection = sqlConn
                        .CommandText = sqlQuery
                        .CommandType = CommandType.Text
                        .Parameters.Add("@idTipoFactura", MySqlDbType.Int16).Value = idTipoFactura
                    End With
                    Try
                        sqlConn.Open()
                        Dim sqlReader As MySqlDataReader = sqlComm.ExecuteReader()
                        While sqlReader.Read()
                            Obj.idTipoFactura = sqlReader("tipodoc")
                            Obj.DescripcionTipoFactura = sqlReader("tipodocume").ToString
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
