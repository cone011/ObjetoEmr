

Public Class FacturaDatosQuery 


    Public ReadOnly Property GetFacutraActul() As String 
        Get 
            Dim Resultado As String = String.Empty 
            Try
                Resultado = "SELECT * FROM " ''No me acuerdo el nombre de la tabla poner cuando mire en casa
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
                Resultado = "UPDATE FALTA TABLA SET nrodoc " ''Falta el campo y tabla para el update
            Catch
                 Throw
            End Try
            Return Resultado
        End Get
    End Property

End Class