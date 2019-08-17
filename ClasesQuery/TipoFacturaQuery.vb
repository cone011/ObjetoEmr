Imports Microsoft.VisualBasic

Public Class TipoFacturaQuery

    Protected _ObjetoTipoFactura As TipoFactura

    Public Property ObjetoTipoFactura() As TipoFactura
        Get
            Return _ObjetoTipoFactura
        End Get
        Set(ByVal value As TipoFactura)
            _ObjetoTipoFactura = value
        End Set
    End Property

    Public Property idTipoFactura As Integer

    Public Property isNew As Boolean = False

    Public ReadOnly Property GetAll() As String
        Get
            Dim Resultado As String = String.Empty
            Try
                Resultado = "SELECT * FROM tipoboleta"
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
                Resultado = "SELECT * FROM tipoboleta WHERE tipodoc = @idTipoFactura"
            Catch
                Throw
            End Try
            Return Resultado
        End Get
    End Property

    'Public ReadOnly Property SaveTipoFactura() As String
    '    Get
    '        Dim Resultado As String = String.Empty
    '        Try
    '            If isNew Then
    '                Resultado = "INSERT INTO TipoFactura(CodigoTipoFactura,DescripcionTipoFactura, UsuarioCreacion,FechaCreacion) VALUES(
    '                                                        @CodigoTipoFactura,
    '                                                        @DescripcionTipoFactura,
    '                                                        @UsuarioCreacion,
    '                                                        CURDATE()
    '                                                    )
    '                            "
    '            Else
    '                Resultado = "UPDATE TipoFactura SET CodigoTipoFactura = @CodigoTipoFactura,
    '                                                    DescripcionTipoFactura = @DescripcionTipoFactura,
    '                                                    UsuarioModificacion = @UsuarioModificacion,
    '                                                    FechaModificacion = CURDATE()
    '                                            WHERE idTipoFactura = @idTipoFactura  
    '                            "
    '            End If
    '        Catch
    '            Throw
    '        End Try
    '        Return Resultado
    '    End Get
    'End Property

End Class
