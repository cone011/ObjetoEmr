Imports System.Collections.Generic
Imports System.Data
Imports Microsoft.VisualBasic
Imports MySql.Data.MySqlClient

Public Class UsuarioDAO

    Public UsuariosQuery As UsuariosQuery = New UsuariosQuery

    'Public Function GetAll() As List(Of Usuarios)

    '    Dim list As List(Of Usuarios) = New List(Of Usuarios)

    '    Dim Obj As Usuarios = Nothing

    '    Try

    '        Dim connString As String = ConexionMySQL.ConexionString

    '        Dim sqlQuery As String = UsuariosQuery.GetAll

    '        Using sqlConn As New MySqlConnection(connString)

    '            Using sqlComm As New MySqlCommand()

    '                With sqlComm

    '                    .Connection = sqlConn

    '                    .CommandText = sqlQuery

    '                    .CommandType = CommandType.Text

    '                End With

    '                Try

    '                    sqlConn.Open()

    '                    Dim sqlReader As MySqlDataReader = sqlComm.ExecuteReader()

    '                    While sqlReader.Read()

    '                        Obj = New Usuarios

    '                        Obj.idUsuarios = sqlReader("idreg")

    '                        Obj.CodigoUsuario = sqlReader("userid")

    '                        Obj.NombreUsuario = sqlReader("nombx").ToString()

    '                        Obj.UsuarioAbreviacion = sqlReader("usrab").ToString() ''Revisar Campo luego al realizar la consulta

    '                        list.Add(Obj)

    '                    End While

    '                    sqlConn.Close()

    '                Catch ex As MySqlException

    '                    Throw

    '                End Try

    '            End Using

    '        End Using



    '    Catch

    '    End Try

    '    Return list

    'End Function

    Public Function GetAll() As List(Of Usuarios)
        Dim list As List(Of Usuarios) = New List(Of Usuarios)
        Dim Obj As Usuarios = Nothing

        Try
            Dim connString As String = ConexionMySQL.ConexionString
            Dim sqlQuery As String = UsuariosQuery.GetAll
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
                            Obj = New Usuarios
                            Obj.idUsuarios = sqlReader("idreg")
                            Obj.CodigoUsuario = sqlReader("nivel")
                            Obj.NombreUsuario = sqlReader("nombx").ToString()
                            Obj.ContraseñaUsuario = sqlReader("password").ToString() ''Revisar Campo luego al realizar la consulta
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





    Public Function GetObjectById(idUsuarios As Integer) As Usuarios

        Dim Obj As Usuarios = Nothing

        Try

            UsuariosQuery.idUsuarios = idUsuarios

            Dim connString As String = ConexionMySQL.ConexionString

            Dim sqlQuery As String = UsuariosQuery.GetObjectById

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

                            Obj.idUsuarios = sqlReader("idreg")

                            Obj.CodigoUsuario = sqlReader("userid")

                            Obj.NombreUsuario = sqlReader("nombx").ToString()

                            Obj.UsuarioAbreviacion = sqlReader("usrab").ToString() ''Revisar Campo luego al realizar la consulta


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


    Public Function saveCliente(objetoReferencia As Usuarios) As Boolean
        Dim isSave As Boolean = False

        Try
            UsuariosQuery.ObjetoUsuarios = objetoReferencia
            UsuariosQuery.isNew = True
            Dim connString As String = ConexionMySQL.ConexionString
            Dim sqlQuery As String = UsuariosQuery.SaveClientes


            Using sqlConn As New MySqlConnection(connString)
                Using sqlComm As New MySqlCommand()
                    With sqlComm
                        .Connection = sqlConn
                        .CommandText = sqlQuery
                        .CommandType = CommandType.Text
                        .Parameters.Add("@Usuario", MySqlDbType.String).Value = objetoReferencia.NombreUsuario
                        .Parameters.Add("@Contraseña", MySqlDbType.String).Value = objetoReferencia.ContraseñaUsuario
                        .Parameters.Add("@UsuarioAbreviacion", MySqlDbType.String).Value = objetoReferencia.UsuarioAbreviacion
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
