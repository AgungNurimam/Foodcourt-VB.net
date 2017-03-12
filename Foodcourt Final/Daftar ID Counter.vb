Imports MySql.Data.MySqlClient
Imports MySql.Data
Public Class Daftar_ID_Counter
    Dim conn As MySqlConnection
    Dim SQL As String

    Sub Data_Load()
        Dim myCommand As New MySqlCommand
        Dim myAdapter As New MySqlDataAdapter
        Dim myData As New DataTable

        conn = New MySqlConnection()
        conn.ConnectionString = "server=localhost;user id=root;" & _
                                "password=;database=foodcourt"
        Try
            If conn.State = ConnectionState.Closed Then conn.Open()
            SQL = "select id_counter,Nama from counter order by id_counter"

            myCommand.Connection = conn
            myCommand.CommandText = SQL

            myAdapter.SelectCommand = myCommand
            myAdapter.Fill(myData)
            With DataGridView1
                .DataSource = myData
                .AllowUserToAddRows = False
                .AllowUserToDeleteRows = False
                .ReadOnly = True

            End With

            conn.Close()
        Catch myerror As MySqlException
            MessageBox.Show("Error: " & myerror.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub Daftar_ID_Counter_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Data_Load()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class