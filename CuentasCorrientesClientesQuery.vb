
Public Class CuentasCorrientesClientes
	
	Public Property OpcionFiltroFecha As Integer
	
	Public ReadOnly Property GetRangoFechaCuentaCorrienteCliente() As String 
		Get
			Dim resultado As String = String.Empty
			Try
				resultado = "SELECT CT.codcli, C.nomcli, C.ruc, CT.nrodoc, CT.fedoc, CT.fecvta, CT.importe, CT.saldodoc, CT.nroctacte FROM ctacte CT JOIN cliente C "
				Select Case OpcionFiltroFecha
					Case 1 
						resultado = resultado + "WHERE MONTH(CT.fecvta) = MONTH(CURDATE()) "
					Case 2 
						resultado = resultado + "WHERE YEAR(CT.fecvta) = YEAR(CURDATE()) "
					Case 3 
						resultado = resultado + "WHERE fecvta BEETWEN @FechaDesde AND @FechaHasta "
			Catch
				Throw
			End Try
			Return resultado
		End Get
	End Property
	
End Class
