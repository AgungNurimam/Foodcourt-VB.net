Imports MySql.Data.MySqlClient
Imports System.Data

Public Class Edit_Menu
    Dim conn As MySqlConnection
    Dim SQL As String

    Private Sub Edit_Menu_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim myCommand As New MySqlCommand
        Dim myAdapter As New MySqlDataAdapter
        Dim myData As New DataTable

        conn = New MySqlConnection()
        conn.ConnectionString = "server=localhost;user id=root;" & _
                                "password=;database=foodcourt"
        Try
            If conn.State = ConnectionState.Closed Then conn.Open()
            SQL = "select id_makananminuman,Nama,Jenis,Harga,Diskon from makanan_minuman where id_counter= " & _
                "'" & Counter.TextCounter.Text & "'"
            myCommand.Connection = conn
            myCommand.CommandText = SQL


            myAdapter.SelectCommand = myCommand
            myAdapter.Fill(myData)
            With DataGridEdit
                .DataSource = myData
                .AllowUserToAddRows = False
                .AllowUserToDeleteRows = False
                .ReadOnly = True

                .Columns(0).HeaderText = "ID Counter"
                .Columns(1).HeaderText = "Nama"
                .Columns(2).HeaderText = "Jenis"
                .Columns(3).HeaderText = "Harga"
                .Columns(4).HeaderText = "Diskon"

                .Columns(0).Width = 100
                .Columns(1).Width = 100
                .Columns(2).Width = 100
                .Columns(3).Width = 100
                .Columns(4).Width = 100
            End With
            conn.Close()
        Catch myerror As MySqlException
            MessageBox.Show("Error: " & myerror.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub KembaliToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KembaliToolStripMenuItem.Click
        Counter.Show()
        Me.Close()
    End Sub
End Class