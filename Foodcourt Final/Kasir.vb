Imports MySql.Data.MySqlClient
Imports System.Data
Public Class Kasir
    Dim conn As MySqlConnection
    Dim SQL As String

    Public Sub Data_Load()
        Dim myCommand As New MySqlCommand
        Dim myAdapter As New MySqlDataAdapter
        Dim myData As New DataTable

        conn = New MySqlConnection()
        conn.ConnectionString = "server=localhost;user id=root;" & _
                                "password=;database=foodcourt"
       
    End Sub

    Private Sub AdminToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdminToolStripMenuItem.Click
        LoginForm1.Show()
    End Sub

    Private Sub CounterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CounterToolStripMenuItem.Click
        Counter.Show()
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KeluarToolStripMenuItem.Click
        Mode.Show()
        Me.Close()
    End Sub

    Private Sub ButtonLihat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim myCommand As New MySqlCommand
        Dim myAdapter As New MySqlDataAdapter
        Dim myData As New DataTable

        conn = New MySqlConnection()
        conn.ConnectionString = "server=localhost;user id=root;" & _
                                "password=;database=foodcourt"


    End Sub


    Private Sub ButtonHitung_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonHitung.Click
        Dim totalbayar As Integer = 0
        Dim totalharga As Integer = 0
        Dim hasil As Integer = 0

        totalharga = TextBoxTotal.Text
        totalbayar = TextTotalBayar.Text
        hasil = totalbayar - totalharga
        TextBoxKembalian.Text = hasil
    End Sub


    Private Sub TextBoxMeja_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TextBoxKembalian.Text = String.Empty
        TextBoxTotal.Text = String.Empty
        TextTotalBayar.Text = String.Empty
    End Sub


    Private Sub BtnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOK.Click
        Dim myCommand As New MySqlCommand
        Dim myAdapter As New MySqlDataAdapter
        Dim myData As New DataTable
        Dim strAtasNama As String = TextAtasNama.Text
        conn = New MySqlConnection()
        conn.ConnectionString = "server=localhost;user id=root;" & _
                                "password=;database=foodcourt"
        If strAtasNama = String.Empty Then _
            MsgBox("Belum Diisi!") : Exit Sub

            Try
                If conn.State = ConnectionState.Closed Then conn.Open()
                SQL = "select * from pembelian where Atas_Nama=" & _
                      "'" & TextAtasNama.Text & "'"
                myCommand.Connection = conn
                myCommand.CommandText = SQL

                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myData)
                With DataGridRincian
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

                SQL = "select sum(Harga) from pembelian where Atas_Nama=" & _
                      "'" & TextAtasNama.Text & "'"
                myCommand.Connection = conn
                myCommand.CommandText = SQL


                Dim total As String = myCommand.ExecuteScalar()
                Dim ambil As String = myCommand.ExecuteScalar()
                total = total + (total * 10 / 100)
                TextBoxTotal.Text = total
                conn.Close()
            Catch myerror As MySqlException
                MessageBox.Show("Error: " & myerror.Message)
            Finally
                conn.Dispose()
            End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim myCommand As New MySqlCommand
        Dim myAdapter As New MySqlDataAdapter
        Dim myData As New DataTable
        conn = New MySqlConnection()
        conn.ConnectionString = "server=localhost;user id=root;" & _
                                "password=;database=foodcourt"

        Try
            conn.Open()
            If conn.State = ConnectionState.Closed Then conn.Open()
            SQL = "select * from pembelian where Atas_Nama=" & _
                  "'" & TextAtasNama.Text & "'"
            myCommand.Connection = conn
            myCommand.CommandText = SQL


            Dim total As String = myCommand.ExecuteScalar()
            myAdapter.SelectCommand = myCommand
            myAdapter.Fill(myData)
            With DataGridRincian
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
            conn.Open()
            SQL = "insert into laporan(id_makananminuman,id_counter,Nama,Jenis,Harga,Tanggal,Bulan,Tahun) select id_makananminuman,id_counter,Nama,Jenis,Harga,date (now()),month (now()),year (now()) from pembelian where Atas_Nama=" & _
                  "'" & TextAtasNama.Text & "'"

            myCommand.Connection = conn
            myCommand.CommandText = SQL
            myCommand.ExecuteNonQuery()

            MsgBox("Data tersimpan")
            conn.Close()
        Catch myerror As MySqlException
            MessageBox.Show("Error: " & myerror.Message)
        Finally
            conn.Dispose()
        End Try

        Try
            conn.Open()
            SQL = "insert into riwayat(id_makananminuman,id_counter,Nama,Jenis,Harga,Atas_Nama,Tanggal,Bulan,Tahun) select id_makananminuman,id_counter,Nama,Jenis,Harga,Atas_Nama,date (now()),month (now()),year (now()) from pembelian where Atas_Nama=" & _
                  "'" & TextAtasNama.Text & "'"

            myCommand.Connection = conn
            myCommand.CommandText = SQL
            myCommand.ExecuteNonQuery()

            MsgBox("Data tersimpan")
            conn.Close()
        Catch myerror As MySqlException
            MessageBox.Show("Error: " & myerror.Message)
        Finally
            conn.Dispose()
        End Try

        Try
            conn.Open()
            SQL = "delete from pembelian where Atas_Nama=" & _
                  "'" & TextAtasNama.Text & "'"

            myCommand.Connection = conn
            myCommand.CommandText = SQL
            Dim Tabel As String = myCommand.ExecuteScalar()
            myCommand.ExecuteNonQuery()


            conn.Close()
        Catch myerror As MySqlException
            MessageBox.Show("Error: " & myerror.Message)
        Finally
            conn.Dispose()
        End Try

    End Sub
    
    Private Sub RiwayatTransaksiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RiwayatTransaksiToolStripMenuItem.Click
        Riwayat_Transaksi.Show()
    End Sub
End Class