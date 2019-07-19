

Public Class TipoClienteQuery 

    Protected _ObjetoTipoCliente As TipoCliente

    Public Property ObjetoTipoCliente() As TipoCliente
        Get 
            Return _ObjetoTipoCliente
        End Get
        Set(ByVal value As TipoCliente)
            _ObjetoTipoCliente = value
        End Set
    End Property

    Public Property idTipoCliente As Integer 

    Public Property isNew As Boolean = False 

    Public ReadOnly Property GetAll() As String 
        Get
            Dim Resultado As String = String.Empty 
            Try
                Resultado = "SELECT * FROM TipoCliente"
            Catch 
                Throw 
            End Try
            Return Resultado
        End Get
    End Property

    Public ReadOnly Property GetObjectById() As String 
        Get
            Dim Resultado As String =  String.Empty
            Try
                Resultado = "SELECT * FROM TipoCliente WHERE idTipoCliente = @idTipoCliente"
            Catch
                 Throw
            End Try
            Return Resultado
        End Get
    End Property

    Public ReadOnly Property SaveTipoCliente() As String 
        Get
            Dim Resultado As String = String.Empty 
            Try
                If isNew Then 
                    Resultado = "
                                    INSERT INTO TipoCliente(
                                                               CodigoTipoCliente,
                                                               DescripcionTipoCliente,
                                                               UsuarioAgregado,
                                                               FechaAgregado
                                                           )
                                                     VALUES(
                                                                @CodigoTipoCliente,
                                                                @DescripcionTipoCliente,
                                                                @UsuarioAgregado,
                                                                CURDATE() 
                                                           )
                                "
                Else 
                    Resultado = "UPDATE TipoCliente SET CodigoTipoCliente = @CodigoTipoCliente,
                                                        DescripcionTipoCliente = @DescripcionTipoCliente,
                                                        UsuarioModificacion = @UsuarioModificacion,
                                                        FechaModificacion = @FechaModificacion
                                            WHERE idTipoCiente = @idTipoCiente
                    "
                End If      
            Catch
                 Throw
            End Try
            Return Resultado
        End Get
    End Property

End Class