Imports MySql.Data.MySqlClient
Imports System.Data
Public Class MenuTerlaris
    Dim conn As MySqlConnection
    Dim SQL As String

    Public Sub Data_Load()
        Dim myCommand As New MySqlCommand
        Dim myAdapter As New MySqlDataAdapter
        Dim myData As New DataTable

        conn = New MySqlConnection()
        conn.ConnectionString = "server=localhost;user id=root;" & _
                                "password=;database=foodcourt"
        Try
            If conn.State = ConnectionState.Closed Then conn.Open()
            SQL = "select Nama,id_counter,count(id_makananminuman) as Jumlah_Pembelian from laporan group by id_makananminuman order by Jumlah_Pembelian desc"

            myCommand.Connection = conn
            myCommand.CommandText = SQL

            myAdapter.SelectCommand = myCommand
            myAdapter.Fill(myData)
            With GridMenuTerlaris
                .DataSource = myData
                .AllowUserToAddRows = False
                .AllowUserToDeleteRows = False
                .ReadOnly = True

                .Columns(0).HeaderText = "Nama"
                .Columns(1).HeaderText = "Counter"
                .Columns(2).HeaderText = "Jumlah Pembelian"
                .Columns(0).Width = 100
                .Columns(1).Width = 100
                .Columns(2).Width = 100
            End With

            conn.Close()
        Catch myerror As MySqlException
            MessageBox.Show("Error: " & myerror.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub



    Private Sub MenuTerlaris_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Data_Load()
    End Sub
End Class