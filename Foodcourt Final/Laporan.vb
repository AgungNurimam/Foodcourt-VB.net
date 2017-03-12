Imports System.Data
Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient

Public Class Laporan
    Dim conn As MySqlConnection
    Dim SQL As String

    Private Sub KembaliToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KembaliToolStripMenuItem.Click
        Admin.Show()
        Me.Close()
    End Sub

    Private Sub BtnBulan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBulan.Click
        Dim myCommand As New MySqlCommand
        Dim myAdapter As New MySqlDataAdapter
        Dim myData As New DataTable

        conn = New MySqlConnection()
        conn.ConnectionString = "server=localhost;user id=root;" & _
                                "password=;database=foodcourt"


        Try
            If conn.State = ConnectionState.Closed Then conn.Open()
            SQL = "select id_counter,id_makananminuman,Nama,Jenis,Harga,Tanggal,Bulan,Tahun,count(id_makananminuman) as Jumlah from laporan where Bulan=" & TextBulan.Text & _
                " group by id_makananminuman"
            myCommand.Connection = conn
            myCommand.CommandText = SQL

            myAdapter.SelectCommand = myCommand
            myAdapter.Fill(myData)
            With DataGridLaporan
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

        Try
            If conn.State = ConnectionState.Closed Then conn.Open()
            SQL = "select sum(Harga) as Total from laporan where Bulan=" & _
                  "'" & TextBulan.Text & "'"
            myCommand.Connection = conn
            myCommand.CommandText = SQL

            Dim total As String = myCommand.ExecuteScalar()
            TextTotalMasukBulan.Text = total
            conn.Close()
        Catch myerror As MySqlException
            MessageBox.Show("Error: " & myerror.Message)
        Finally
            conn.Dispose()
        End Try

    End Sub

    Private Sub BtnTahun_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTahun.Click
        Dim myCommand As New MySqlCommand
        Dim myAdapter As New MySqlDataAdapter
        Dim myData As New DataTable

        conn = New MySqlConnection()
        conn.ConnectionString = "server=localhost;user id=root;" & _
                                "password=;database=foodcourt"


        Try
            If conn.State = ConnectionState.Closed Then conn.Open()
            SQL = "select id_counter,id_makananminuman,Nama,Jenis,Harga,Tanggal,Bulan,Tahun,count(id_makananminuman) as Jumlah from laporan where Tahun=" & TextTahun.Text & _
                " group by id_makananminuman"
            myCommand.Connection = conn
            myCommand.CommandText = SQL

            myAdapter.SelectCommand = myCommand
            myAdapter.Fill(myData)
            With DataGridLaporan
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

        Try
            If conn.State = ConnectionState.Closed Then conn.Open()
            SQL = "select sum(Harga) as Total from laporan where Tahun=" & _
                  "'" & TextTahun.Text & "'"
            myCommand.Connection = conn
            myCommand.CommandText = SQL

            Dim total As String = myCommand.ExecuteScalar()
            TextTotalMasukTahun.Text = total
            conn.Close()
        Catch myerror As MySqlException
            MessageBox.Show("Error: " & myerror.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub ButtonBersihkan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonBersihkan.Click
        Dim myCommand As New MySqlCommand
        Dim myAdapter As New MySqlDataAdapter
        Dim myData As New DataTable

        conn = New MySqlConnection()
        conn.ConnectionString = "server=localhost;user id=root;" & _
                                "password=;database=foodcourt"


        Try
            If conn.State = ConnectionState.Closed Then conn.Open()
            SQL = "delete from laporan"
            myCommand.Connection = conn
            myCommand.CommandText = SQL

            myAdapter.SelectCommand = myCommand
            myAdapter.Fill(myData)
            With DataGridLaporan
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
   
    Private Sub BtnLapCounter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLapCounter.Click
        Dim myCommand As New MySqlCommand
        Dim myAdapter As New MySqlDataAdapter
        Dim myData As New DataTable

        conn = New MySqlConnection()
        conn.ConnectionString = "server=localhost;user id=root;" & _
                                "password=;database=foodcourt"


        Try
            If conn.State = ConnectionState.Closed Then conn.Open()
            SQL = "select id_counter,id_makananminuman,Nama,Jenis,Harga,Tanggal,Bulan,Tahun,count(id_makananminuman) as Jumlah from laporan where id_counter=" & _
               "'" & Textidcounter.Text & "' group by id_makananminuman"
            myCommand.Connection = conn
            myCommand.CommandText = SQL

            myAdapter.SelectCommand = myCommand
            myAdapter.Fill(myData)
            With DataGridLaporan
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

        Try
            If conn.State = ConnectionState.Closed Then conn.Open()
            SQL = "select sum(Harga) as Total from laporan where id_counter=" & _
                  "'" & Textidcounter.Text & "'"
            myCommand.Connection = conn
            myCommand.CommandText = SQL

            Dim total As String = myCommand.ExecuteScalar()
            TextTotalCounter.Text = total
            conn.Close()
        Catch myerror As MySqlException
            MessageBox.Show("Error: " & myerror.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub TextBulan_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBulan.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles andok.Click
        Dim myCommand As New MySqlCommand
        Dim myAdapter As New MySqlDataAdapter
        Dim myData As New DataTable

        conn = New MySqlConnection()
        conn.ConnectionString = "server=localhost;user id=root;" & _
                                "password=;database=foodcourt"
        Try
            If conn.State = ConnectionState.Closed Then conn.Open()
            SQL = "select * from laporan where Bulan=" & _
                  "'" & andbulan.Text & "' and Tahun=" & _
                  "'" & andtahun.Text & "' and id_counter=" & _
                  "'" & andcounter.Text & "'"
            myCommand.Connection = conn
            myCommand.CommandText = SQL

            myAdapter.SelectCommand = myCommand
            myAdapter.Fill(myData)
            With DataGridLaporan
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

        Try
            If conn.State = ConnectionState.Closed Then conn.Open()
            SQL = "select sum(Harga) as Total from laporan where Bulan=" & _
                  "'" & andbulan.Text & "' and Tahun=" & _
                  "'" & andtahun.Text & "' and id_counter=" & _
                  "'" & andcounter.Text & "'"
            myCommand.Connection = conn
            myCommand.CommandText = SQL

            Dim total As String = myCommand.ExecuteScalar()
            andtotal.Text = total
            conn.Close()
        Catch myerror As MySqlException
            MessageBox.Show("Error: " & myerror.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Function TextAtasNama() As Object
        Throw New NotImplementedException
    End Function

    Private Sub Laporan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class