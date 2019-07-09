Imports System.Data
Imports MySql.Data.MySqlClient

Public Sub retriveDataToDataGrid()
        Try
            Dim result As String
            Dim conn As MySqlConnection
            conn = New MySqlConnection()
            conn.ConnectionString = "server=localhost; user id=root; password=xxxx; database=main"
            Try
                conn.Open()
            Catch myerror As MySqlException
                MsgBox("Connection to the Database Failed")
                GoTo a
            End Try
            Dim myAdapter As New MySqlDataAdapter
            Dim sqlquery = "SELECT * FROM personal"
            Dim myCommand As New MySqlCommand()
            myCommand.Connection = conn
            myCommand.CommandText = sqlquery
            myAdapter.SelectCommand = myCommand
            Dim myData As MySqlDataReader
            myData = myCommand.ExecuteReader()
            If myData.HasRows Then
                While myData.Read()
                    For i As Integer = 0 To 1
                        result = myData(i).ToString
                        MsgBox(result)
                    Next
                End While
            End If
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
End Sub

''------------------------------------------------------------------------------------------
Dim querySelectOr As String = "SELECT id_or FROM ord WHERE nombre_or = @nombreor LIMIT 1"
                Using cmd As New MySqlCommand(querySelectOr, cn)
                    cmd.Transaction = myTrans
                    cmd.Parameters.AddWithValue("@nombreor", txtOr.Text)
                    'AQUI HAY QUE SABER QUE DEVUELVE EL QUERY SI EL QUERY DEVUELVE ID ENTONCES USA EL ID QUE DEVUELVE
                    Dim reader As MySqlDataReader
                    reader = cmd.ExecuteReader()
 
                    While reader.Read()
                        id_ord = reader.GetInt32(0)
                    End While
                    reader.Close()
                End Using
                id_ord2 = id_ord.ToString()
                'Comparamos si ID_ORD2 esta vació, es nulo o es igual a 0 por el motivo que cuando se hace la consulta
                ' y nombre_or no es igual a txtor, lo que devuelve es 0, entonces se colocan 2 condiciones. 
 
                If String.IsNullOrEmpty(id_ord2) Or id_ord2 = 0 Then
                    Dim queryOr As String = "INSERT INTO ord (nombre_or) " & _
                                      "VALUES (@nombreor)" & _
                                      ";SELECT LAST_INSERT_ID();"
 
                    id_ord = 0
                    Using cmd As New MySqlCommand(queryOr, cn)
                        cmd.Transaction = myTrans
                        cmd.Parameters.AddWithValue("@nombreor", txtOr.Text)
                        id_ord = Convert.ToInt32(cmd.ExecuteScalar())
                    End Using
 
 
                End If
				
''------------------------------------------------------------------------------------------
 Dim con As MySqlConnection = New MySqlConnection("Data Source=localhost;Database=test;User ID=root;Password=mysql;")
        Dim sql As MySqlCommand = New MySqlCommand("SELECT * FROM userreg", con)

        Dim ds As DataSet = New DataSet()

        Dim DataAdapter1 As MySqlDataAdapter = New MySqlDataAdapter()

        con.Open()

        DataAdapter1.SelectCommand = sql

        DataAdapter1.Fill(ds, "Product")

        DataGridView1.DataSource = ds

        DataGridView1.DataMember = "Product"

        con.Close()

''---------------------------------------------------------------------------------------------------
Private Sub BindGrid()
    Dim conString As String = "Data Source=localhost;port=3306;Initial Catalog=AjaxSamples;User Id=mudassar;password=pass@123"
    Using con As New MySqlConnection(conString)
        Using cmd As New MySqlCommand("SELECT * FROM Customers", con)
            cmd.CommandType = CommandType.Text
            Using sda As New MySqlDataAdapter(cmd)
                Using dt As New DataTable()
                    sda.Fill(dt)
                    dataGridView1.DataSource = dt
                End Using
            End Using
        End Using
    End Using
End Sub

''--------------------------------------------------------------------------------------------------------
 Dim MysqlConn As MySqlConnection

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
       "server=localhost;userid=root;password=root;database=database"

        Try
            MysqlConn.Open()
            MessageBox.Show("Connection Successful")
            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()

        End Try

    End Sub
''-----------------------------------------------------------------------------------------------------------

Imports MySql.Data.MySqlClient
Imports System
Imports System.IO
Public Class Form1
    Public dbconn As New MySqlConnection
    Public sqlQuery As String
    Public SQLcmd As MySqlCommand
    Public sqlQuery2 As String
    Public dbconn2 As New MySqlConnection
    Public SQLcmd2 As MySqlCommand
    Public dbread As MySqlDataReader
    Dim Ext As String
    Dim CostAssing As Integer

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        dbconn = New MySqlConnection("Data Source=localhost ; user id=root ; password=mysq1passw0rd ; database=calls")
        dbconn2 = New MySqlConnection("Data Source=localhost ; user id=root ; password=mysq1passw0rd ; database=calls")
        Try
            dbconn.Open()
            dbconn2.Open()
	    'First Query for getting the Extension and CostAssing
            sqlQuery = "SELECT Ext,CostAssing,CostAct FROM estruc "
            SQLcmd = New MySqlCommand(sqlQuery, dbconn)
            dbread = SQLcmd.ExecuteReader
            While dbread.Read()
                Ext = dbread.Item("Ext")
                CostAssing = dbread.Item("CostAssing")
		'Second Query Update CostAct with CostAssing Value
                sqlQuery2 = "UPDATE estruc SET CostAct = '" & CostAssing & "'  WHERE Ext = '" & Ext & "'"
                SQLcmd2 = New MySqlCommand(sqlQuery2, dbconn2)
                SQLcmd2.ExecuteNonQuery()
            End While
        Catch ex As Exception
            MsgBox("Error 1 is :" & ex.Message)
        End Try
        dbread.Close()
        dbconn.Close()
        dbconn2.Close()
    End Sub

End Class 