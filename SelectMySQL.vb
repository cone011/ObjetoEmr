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