

Public Class FacturasDatos

    Protected _idFacturasDatos As Integer 

    Public Property idFacturasDatos() As Integer 
        Get 
            Return _idFacturasDatos
        End Get
        Set(ByVal value As Integer)
            _idFacturasDatos = value
        End Set
    End Property

    Protected _Prefijo1 As Integer

    Public Property Prefijo1() As Integer
        Get 
            Return _Prefijo1
        End Get
        Set(ByVal value As Integer)
            _idFacturasDatos = value
        End Set
    End Property

    Protected _Prefijo2 As Integer

    Public Property Prefijo2() As Integer
        Get
            Return _Prefijo2
        End Get
        Set(ByVal value As Integer)
            _Prefijo2 = value
        End Set
    End Property

    Protected _NumeroDocumento As Integer

    Public Property NumeroDocumento() As Integer
        Get 
            Return _NumeroDocumento
        End Get
        Set(ByVal value As Integer)
            _NumeroDocumento = value
        End Set
    End Property

    Public ReadOnly Property Factura() As String 
        Get
           Dim Resultado As String = String.Empty 
           Try
              Resultado = Prefijo1 + " - " + Prefijo2 + " - " + NumeroDocumento
           Catch 
                Throw
           End Try
           Return Resultado
        End Get
    End Property

End Class