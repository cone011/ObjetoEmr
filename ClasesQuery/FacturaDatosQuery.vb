Imports Microsoft.VisualBasic

Public Class FacturaDatosQuery

    Public ReadOnly Property GetFacutraActual() As String
        Get
            Dim Resultado As String = String.Empty
            Try
                Resultado = "SELECT pf1,pf2,nrobolsp FROM configur"
            Catch
                Throw
            End Try
            Return Resultado
        End Get
    End Property

    Public ReadOnly Property SaveFacturasDato() As String
        Get
            Dim Resultado As String = String.Empty
            Try
                Resultado = "UPDATE configur SET pf1 = @Prefijo1, pf2 = @Prefijo2, nrobolsp = @NumeroBoletaPlaya"
            Catch
                Throw
            End Try
            Return Resultado
        End Get
    End Property

End Class
