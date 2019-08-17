Imports Microsoft.VisualBasic

Public Class PlayeroQuery


    Public Property isNew As Boolean = False

    Public ReadOnly Property GetAll() As String
        Get
            Dim resultado As String = String.Empty
            Try
                resultado = "SELECT idreg,cplayero, nplayero FROM playero"
            Catch ex As Exception
                Throw
            End Try
            Return resultado
        End Get
    End Property

    Public ReadOnly Property GetObjectById() As String
        Get
            Dim resultado As String = String.Empty
            Try
                resultado = "SELECT idreg, cplayero, nplayero FROM playero WHERE idreg = @idPlayero"
            Catch ex As Exception
                Throw
            End Try
            Return resultado
        End Get
    End Property

    Public ReadOnly Property GetPlayeroByCodigoPlayero() As String
        Get
            Dim resultado As String = String.Empty
            Try
                resultado = "SELECT idreg FROM playero WHERE cplayero = @CodigoPlayero LIMIT 1"
            Catch ex As Exception
                Throw
            End Try
            Return resultado
        End Get
    End property

    Public ReadOnly Property SavePlayero() As String
        Get
            Dim resultado As String = String.Empty
            Try
                If isNew Then
                    resultado = "INSERT INTO playero(cplayero, nplayero) VALUES (@CodigoPlayero, @NombrePlayero)"
                Else
                    resultado = "UPDATE playero SET cplayero = @CodigoPlayero, nplayero = NombrePlayero WHERE idreg = @idPlayero"
                End If
            Catch ex As Exception
                Throw
            End Try
            Return resultado
        End Get
    End Property

End Class
