
Public Class UsuariosQuery

    Protected _ObjetoUsuarios As Usuarios 

	

	Public Property ObjetoUsuarios() As Usuarios

		Get

			Return _ObjetoUsuarios

		End Get

		

		Set(ByVal value As Productos)

			_ObjetoUsuarios = value

		End Set

	End Property

	

	Protected _idUsuarios As Integer 

	

	Public Property idUsuarios() As Integer

		Get

			Return _idUsuarios

		End Get

		

		Set(ByVal value As Integer)

			_idUsuarios = value

		End Set

	End Property

	

	Public ReadOnly Property GetAll() As String 

		Get

			Dim resultado As String = String.Empty

			Try

				resultado = "Select * From login"

			Catch

				Throw

			End Try

			Return resultado

		End Get

	End Property

	

	Public ReadOnly Property GetObjectById() As String

		Get

			Dim resultado As String = String.Empty

			Try

				resultado = "SELECT * FROM login WHERE idreg = "+idUsuarios

			Catch

				Throw

			End Try

			Return resultado

		End Get

	End Property

End Class
