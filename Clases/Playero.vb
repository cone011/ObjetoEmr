Imports Microsoft.VisualBasic

Public Class Playero

    Protected _idPlayero As Integer

    Public Property idPlayero() As Integer
        Get
            Return _idPlayero
        End Get
        Set(value As Integer)
            _idPlayero = value
        End Set
    End Property

    Protected _CodigoPlayero As Integer

    Public Property CodigoPlayero() As Integer
        Get
            Return _CodigoPlayero
        End Get
        Set(value As Integer)
            _CodigoPlayero = value
        End Set
    End Property

    Protected _DescripcionPlayero As String

    Public Property DescripcionPlayero() As String
        Get
            Return _DescripcionPlayero
        End Get
        Set(value As String)
            _DescripcionPlayero = value
        End Set
    End Property

End Class
