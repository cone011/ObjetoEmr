Imports System.Collections.Generic
Imports System.Data
Imports Microsoft.VisualBasic
Imports MySql.Data.MySqlClient

Public Class FacturaDatosDAO

    Public FacturasDatosQuery As FacturaDatosQuery = New FacturaDatosQuery

    Public Function GetObjectByIdFactura() As FacturasDatos
        Dim Obj As FacturasDatos = New FacturasDatos
        Try
            Dim connString As String = ConexionMySQL.ConexionString
            Dim sqlQuery As String = FacturasDatosQuery.GetFacutraActual
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
                            Obj.Prefijo1 = sqlReader("pf1")
                            Obj.Prefijo2 = sqlReader("pf2")
                            Obj.NumeroDocumento = sqlReader("nrobolsp")
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
