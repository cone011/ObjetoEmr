
Imports System.Collections.Generic
Imports System.Data
Imports Microsoft.VisualBasic
Imports MySql.Data.MySqlClient

Public Class VentasDAO

    Public VentasQuery As VentasQuery = New VentasQuery

    Public VentasDetalleDAO As VentasDetalleDAO = New VentasDetalleDAO

    Public Function GetAll() As List(Of Ventas)
        Dim list As List(Of Ventas) = New List(Of Ventas)
        Dim Obj As Ventas = Nothing

        Try
            Dim connString As String = ConexionMySQL.ConexionString
            Dim sqlQuery As String = VentasQuery.GetAll
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
                            Obj = New Ventas
                            Obj.idVentas = sqlReader("idVentas")
                            Obj.Pf1 = sqlReader("Pf1")
                            Obj.Pf2 = sqlReader("Pf2")
                            Obj.NumeroDocumento = sqlReader("NumeroDocumento")
                            Obj.Cliente.idClientes = sqlReader("idClientes")
                            Obj.FechaFacturacion = sqlReader("FechaFacturacion")
                            Obj.FechaVencimiento = sqlReader("FechaVencimiento")
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

    Public Function GetObjectById(idVenta As Integer) As Ventas
        Dim Obj As Ventas = New Ventas
        Try
            Dim connString As String = ConexionMySQL.ConexionString
            Dim sqlQuery As String = VentasQuery.GetObjectById
            Using sqlConn As New MySqlConnection(connString)
                Using sqlComm As New MySqlCommand()
                    With sqlComm
                        .Connection = sqlConn
                        .CommandText = sqlQuery
                        .CommandType = CommandType.Text
                        ' .Parameters.Add("@idFormaPago", MySqlDbType.Int16).Value = idFormaPago
                    End With
                    Try
                        sqlConn.Open()
                        Dim sqlReader As MySqlDataReader = sqlComm.ExecuteReader()
                        While sqlReader.Read()
                            'Obj.CodigoFormaPago = sqlReader("CodigoFormaPago").ToString
                            'Obj.DescripcionFormaPago = sqlReader("DescripcionFormaPago").ToString
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


    Public Function saveVentas(objetoReferencia As Ventas) As Boolean
        Dim isSave As Boolean = False

        Try
            VentasQuery.ObjetoVentas = objetoReferencia
            Dim connString As String = ConexionMySQL.ConexionString
            Dim sqlQuery As String = VentasQuery.InsertarVentaCabecera


            Using sqlConn As New MySqlConnection(connString)
                Using sqlComm As New MySqlCommand()
                    With sqlComm
                        .Connection = sqlConn
                        .CommandText = sqlQuery
                        .CommandType = CommandType.Text
                        .Parameters.Add("@Prefijo1", MySqlDbType.Int16).Value = objetoReferencia.Pf1
                        .Parameters.Add("@Prefijo2", MySqlDbType.Int16).Value = objetoReferencia.Pf2
                        .Parameters.Add("@NumeroDocumento", MySqlDbType.Int16).Value = objetoReferencia.NumeroDocumento
                        .Parameters.Add("@CodigoCliente", MySqlDbType.Int16).Value = objetoReferencia.Cliente.idClientes
                        .Parameters.Add("@FechaFacturacion", MySqlDbType.Date).Value = objetoReferencia.FechaFacturacion
                        .Parameters.Add("@FechaVencimientoFacturacion", MySqlDbType.Date).Value = objetoReferencia.FechaVencimiento
                        .Parameters.Add("@FechaProcesado", MySqlDbType.Date).Value = Date.Now
                        .Parameters.Add("@SaleDe", MySqlDbType.Int16).Value = objetoReferencia.Vale
                        .Parameters.Add("@TipoDocumento", MySqlDbType.Int16).Value = objetoReferencia.TipoFactura.idTipoFactura
                        .Parameters.Add("@TotalDocumento", MySqlDbType.Int16).Value = objetoReferencia.TotalDocumento
                        .Parameters.Add("@TotalBruto", MySqlDbType.Int16).Value = objetoReferencia.TotalBruto
                        .Parameters.Add("@Iva10", MySqlDbType.Int16).Value = objetoReferencia.TotalIva10
                        .Parameters.Add("@Iva05", MySqlDbType.Int16).Value = objetoReferencia.TotalIva05
                        .Parameters.Add("@VentaIva10", MySqlDbType.Int16).Value = objetoReferencia.TotalVentaIva10
                        .Parameters.Add("@VentaIva05", MySqlDbType.Int16).Value = objetoReferencia.TotalVentaIva05
                        .Parameters.Add("@Excento", MySqlDbType.Int16).Value = objetoReferencia.TotalExcento
                    End With

                    Try
                        sqlConn.Open()
                        Dim sqlReader As MySqlDataReader = sqlComm.ExecuteReader()

                        For Each det As VentasDetalle In objetoReferencia.DetalleVentasList

                            If VentasDetalleDAO.saveVentasDetalle(det) = False Then
                                Return False
                                Exit Function
                            End If
                        Next

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

Public Class VentasDetalleDAO


    Public VentasDetalleDAO As VentasDetalleDAO = New VentasDetalleDAO

    Public DetalleVentasQuery As DetalleVentasQuery = New DetalleVentasQuery

    Public Function saveVentasDetalle(objetoReferencia As VentasDetalle) As Boolean
        Dim isSave As Boolean = False

        Try
            Dim connString As String = ConexionMySQL.ConexionString
            Dim sqlQuery As String = DetalleVentasQuery.SaveDetalleVentas


            Using sqlConn As New MySqlConnection(connString)
                Using sqlComm As New MySqlCommand()
                    With sqlComm
                        .Connection = sqlConn
                        .CommandText = sqlQuery
                        .CommandType = CommandType.Text
                        .Parameters.Add("@Prefijo1", MySqlDbType.Int16).Value = objetoReferencia.Pf1
                        .Parameters.Add("@Prefijo2", MySqlDbType.Int16).Value = objetoReferencia.Pf2
                        .Parameters.Add("@NumeroDocumento", MySqlDbType.Int16).Value = objetoReferencia.NumeroDocumento
                        .Parameters.Add("@CodigoProducto", MySqlDbType.Int16).Value = objetoReferencia.CodigoArticulo
                        .Parameters.Add("@CantidadVendida", MySqlDbType.Int16).Value = objetoReferencia.CantidadVendida
                        .Parameters.Add("@PrecioUnitario", MySqlDbType.Int16).Value = objetoReferencia.PrecioUnitario
                        .Parameters.Add("@TotalProducto", MySqlDbType.Int16).Value = objetoReferencia.TotalBruto
                        .Parameters.Add("@VentaProductoExcento", MySqlDbType.Int16).Value = objetoReferencia.VentaExcento
                        .Parameters.Add("@VentaProdcutoIva10", MySqlDbType.Int16).Value = objetoReferencia.VentaIva10
                        .Parameters.Add("@VentaProductoIva05", MySqlDbType.Int16).Value = objetoReferencia.VentaIva5
                        .Parameters.Add("@PrecioLista", MySqlDbType.Int16).Value = objetoReferencia.PrecioLista
                        .Parameters.Add("@Costo", MySqlDbType.Int16).Value = objetoReferencia.NumeroOrden
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