Imports System.Collections.Generic
Imports System.Data
Imports Microsoft.VisualBasic
Imports MySql.Data.MySqlClient

Public Class PlayeroDAO

    Public PlayeroQuery As PlayeroQuery = New PlayeroQuery

    Public Function GetAll() As List(Of Playero)
        Dim list As List(Of Playero) = New List(Of Playero)
        Dim Obj As Playero = Nothing

        Try
            Dim connString As String = ConexionMySQL.ConexionString
            Dim sqlQuery As String = PlayeroQuery.GetAll
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
                            Obj = New Playero
                            Obj.idPlayero = sqlReader("idreg")
                            Obj.CodigoPlayero = sqlReader("cplayero")
                            Obj.DescripcionPlayero = sqlReader("nplayero")
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

    Public Function GetObjectById(idPlayero As Integer) As Playero
        Dim Obj As Playero = New Playero
        Try
            Dim connString As String = ConexionMySQL.ConexionString
            Dim sqlQuery As String = PlayeroQuery.GetObjectById
            Using sqlConn As New MySqlConnection(connString)
                Using sqlComm As New MySqlCommand()
                    With sqlComm
                        .Connection = sqlConn
                        .CommandText = sqlQuery
                        .CommandType = CommandType.Text
                        .Parameters.Add("@idPlayero", MySqlDbType.Int16).Value = idPlayero
                    End With
                    Try
                        sqlConn.Open()
                        Dim sqlReader As MySqlDataReader = sqlComm.ExecuteReader()
                        While sqlReader.Read()
                            Obj.idPlayero = sqlReader("idreg")
                            Obj.CodigoPlayero = sqlReader("cplayero")
                            Obj.DescripcionPlayero = sqlReader("nplayero")
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

    Public Function GetPlayeroByCodigoPlayero(CodigoPlayero As Integer) As Boolean
        Dim Obj As Playero = New Playero
        Dim isExist As Boolean = False
        Try
            Dim connString As String = ConexionMySQL.ConexionString
            Dim sqlQuery As String = PlayeroQuery.GetPlayeroByCodigoPlayero
            Using sqlConn As New MySqlConnection(connString)
                Using sqlComm As New MySqlCommand()
                    With sqlComm
                        .Connection = sqlConn
                        .CommandText = sqlQuery
                        .CommandType = CommandType.Text
                        .Parameters.Add("@CodigoPlayero", MySqlDbType.Int16).Value = CodigoPlayero
                    End With
                    Try
                        sqlConn.Open()
                        Dim sqlReader As MySqlDataReader = sqlComm.ExecuteReader()
                        While sqlReader.Read()
                            Obj.idPlayero = sqlReader("idreg")
                            If Obj.idPlayero > 0 OrElse Obj IsNot Nothing Then
                                isExist = True
                            End If
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
        Return isExist
    End Function


End Class
