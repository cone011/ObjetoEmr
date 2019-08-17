Imports Microsoft.VisualBasic

Public Class FormaPagoQuery
    Protected _ObjetoFormaPago As FormaPago

    Public Property ObjetoFormaPago() As FormaPago
        Get
            Return _ObjetoFormaPago
        End Get
        Set(ByVal value As FormaPago)
            _ObjetoFormaPago = value
        End Set
    End Property

    Public Property isNew As Boolean = False

    Public ReadOnly Property GetAll() As String
        Get
            Dim Resultado As String = String.Empty
            Try
                Resultado = "SELECT * FROM formapagofacturas"
            Catch
                Throw
            End Try
            Return Resultado
        End Get
    End Property

    Public ReadOnly Property GetObjectById() As String
        Get
            Dim Resultado As String = String.Empty
            Try
                Resultado = "SELECT * FROM formapagofacturas WHERE idFormaPago = @idFormaPago"
            Catch
                Throw
            End Try
            Return Resultado
        End Get
    End Property

    Public ReadOnly Property SaveFormaPago() As String
        Get
            Dim Resultado As String = String.Empty
            Try
                If isNew Then
                    Resultado = "INSERT INTO formapagofacturas(CodigoFormaPago, DescripcionFormaPago,UsuarioCreacion,FechaCreacion) VALUES (@CodigoFormaPago,@DescripcionFormaPago,@UsuarioCreacion,CURDATE())"
                Else
                    Resultado = "UPDATE formapagofacturas SET CodigoFormaPago = @CodigoFormaPago,DescripcionFormaPago = @DescripcionFormaPago,UsuarioModificacion = @UsuarioModificacion,FechaModificacion = CURDATE() WHERE idFormaPago = @idFormaPago"
                End If
            Catch
                Throw
            End Try
            Return Resultado
        End Get
    End Property
End Class
