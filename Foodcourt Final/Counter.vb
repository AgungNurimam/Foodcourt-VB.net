Imports MySql.Data.MySqlClient
Imports System.Data


Public Class Counter
    Dim conn As MySqlConnection
    Dim SQL As String
    Dim Nama As String
    Dim NamaPemesanIns As String
    Dim NamaPemesan As String

    Sub Cek_Nama()
        Dim myCommand As New MySqlCommand
        Dim myAdapter As New MySqlDataAdapter
        Dim myData As New DataTable
        conn = New MySqlConnection()
        conn.ConnectionString = "server=localhost;user id=root;" & _
                                "password=;database=foodcourt"
        Try
            If conn.State = ConnectionState.Closed Then conn.Open()
            SQL = "Select Atas_Nama from pembelian WHERE Atas_Nama=" & _
            "'" & TexAtasNama.Text & " limit 1'"

            myCommand.Connection = conn
            myCommand.CommandText = SQL
            Nama = myCommand.ExecuteScalar()

            myAdapter.SelectCommand = myCommand
            myAdapter.Fill(myData)


            conn.Close()
        Catch myerror As MySqlException
            MessageBox.Show("Error: " & myerror.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub

    Public Sub Nama_Counter()
        Dim myCommand As New MySqlCommand
        Dim myAdapter As New MySqlDataAdapter
        Dim myData As New DataTable

        conn = New MySqlConnection()
        conn.ConnectionString = "server=localhost;user id=root;" & _
                                "password=;database=foodcourt"
        Try
            If conn.State = ConnectionState.Closed Then conn.Open()
            SQL = "select Nama from counter where id_counter= " & _
                "'" & TextCounter.Text & "'"
            myCommand.Connection = conn
            myCommand.Connection = conn
            myCommand.CommandText = SQL


            Dim total As String = myCommand.ExecuteScalar()
            TextBoxNamaCounter.Text = total
            conn.Close()
        Catch myerror As MySqlException
            MessageBox.Show("Error: " & myerror.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCounter.Click
        Dim myCommand As New MySqlCommand
        Dim myAdapter As New MySqlDataAdapter
        Dim myData As New DataTable
        Dim idcounter As String = TextCounter.Text
        conn = New MySqlConnection()
        conn.ConnectionString = "server=localhost;user id=root;" & _
                                "password=;database=foodcourt"

        If idcounter = String.Empty Then _
          MsgBox("Belum Diisi!") : Exit Sub

        Try
            If conn.State = ConnectionState.Closed Then conn.Open()
            SQL = "select id_makananminuman,Nama,Harga,Jenis from makanan_minuman where id_counter=" & _
                  "'" & TextCounter.Text & "'"
            myCommand.Connection = conn
            myCommand.CommandText = SQL

            myAdapter.SelectCommand = myCommand
            myAdapter.Fill(myData)
            With DataGridViewMenuCounter
                .DataSource = myData
                .AllowUserToAddRows = False
                .AllowUserToDeleteRows = False
                .ReadOnly = True

                .Columns(0).HeaderText = "id"
                .Columns(1).HeaderText = "Nama"
                .Columns(2).HeaderText = "Jenis"
                .Columns(3).HeaderText = "Harga"
                .Columns(0).Width = 100
                .Columns(1).Width = 100
                .Columns(2).Width = 100
                .Columns(3).Width = 100

            End With

            conn.Close()
        Catch myerror As MySqlException
            MessageBox.Show("Error: " & myerror.Message)
        Finally
            conn.Dispose()
        End Try
        Nama_Counter()
    End Sub

   
    Private Sub AdminToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdminToolStripMenuItem.Click
        LoginForm1.Show()
        Me.Close()
    End Sub

    Private Sub KasirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KasirToolStripMenuItem.Click
        Kasir.Show()
        Me.Close()
    End Sub

    Public Sub Data_Load()
        Dim myCommand As New MySqlCommand
        Dim myAdapter As New MySqlDataAdapter
        Dim myData As New DataTable

        conn = New MySqlConnection()
        conn.ConnectionString = "server=localhost;user id=root;" & _
                                "password=;database=foodcourt"
        Try
            If conn.State = ConnectionState.Closed Then conn.Open()
            SQL = "select id_makananminuman,Nama,Jenis,Harga,count(id_makananminuman) as Jumlah from transaksi group by id_makananminuman"

            myCommand.Connection = conn
            myCommand.CommandText = SQL

            myAdapter.SelectCommand = myCommand
            myAdapter.Fill(myData)
            With DataGridViewTransaksi
                .DataSource = myData
                .AllowUserToAddRows = False
                .AllowUserToDeleteRows = False
                .ReadOnly = True

                .Columns(0).HeaderText = "Id"
                .Columns(1).HeaderText = "Nama"
                .Columns(2).HeaderText = "Jenis"
                .Columns(3).HeaderText = "Harga"
                .Columns(0).Width = 100
                .Columns(1).Width = 100
                .Columns(2).Width = 100
                .Columns(3).Width = 100
            End With

            conn.Close()
        Catch myerror As MySqlException
            MessageBox.Show("Error: " & myerror.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub BtnPesan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPesan.Click
        Dim myCommand As New MySqlCommand
        Dim myCommand1 As New MySqlCommand
        Dim myCommand2 As New MySqlCommand
        Dim myAdapter As New MySqlDataAdapter
        Dim myData As New DataTable

        conn = New MySqlConnection()
        conn.ConnectionString = "server=localhost;user id=root;" & _
                                "password=;database=foodcourt"
        Try
            If conn.State = ConnectionState.Closed Then conn.Open()
            SQL = "insert into foodcourt.transaksi(id_makananminuman,Nama,Jenis,Harga,id_counter) select id_makananminuman,Nama,Jenis,Harga,id_counter from foodcourt.makanan_minuman where id_makananminuman= " & _
                  "'" & DataGridViewMenuCounter.CurrentRow.Cells(0).Value & "'"
            myCommand.Connection = conn
            myCommand.CommandText = SQL

            myAdapter.SelectCommand = myCommand
            myAdapter.Fill(myData)
            With DataGridViewTransaksi
                .DataSource = myData
                .AllowUserToAddRows = False
                .AllowUserToDeleteRows = False
                .ReadOnly = True

            End With
            Data_Load()
            conn.Close()
        Catch myerror As MySqlException
            MessageBox.Show("Error: " & myerror.Message)
        Finally
            conn.Dispose()
        End Try

        Try
            If conn.State = ConnectionState.Closed Then conn.Open()
            SQL = "select sum(Harga) as Total from transaksi"
            myCommand.Connection = conn
            myCommand.CommandText = SQL

            Dim total As String = myCommand.ExecuteScalar()
            TextTotalHarga.Text = total
            Data_Load()
            conn.Close()
        Catch myerror As MySqlException
            MessageBox.Show("Error: " & myerror.Message)
        Finally
            conn.Dispose()
        End Try

    End Sub

    Private Sub KeluarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KeluarToolStripMenuItem.Click
        Mode.Show()
        Me.Close()
    End Sub


    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonKosongkan.Click
        Data_Load()
    End Sub

    Private Sub ButtonBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonBatal.Click
        Dim myCommand As New MySqlCommand
        Dim myCommand1 As New MySqlCommand
        Dim myCommand2 As New MySqlCommand
        Dim myAdapter As New MySqlDataAdapter
        Dim myData As New DataTable

        conn = New MySqlConnection()
        conn.ConnectionString = "server=localhost;user id=root;" & _
                                "password=;database=foodcourt"
        Try
            If conn.State = ConnectionState.Closed Then conn.Open()
            SQL = "delete from foodcourt.transaksi where id_makananminuman= " & _
                  "'" & DataGridViewMenuCounter.CurrentRow.Cells(0).Value & "'"
            myCommand.Connection = conn
            myCommand.CommandText = SQL

            myAdapter.SelectCommand = myCommand
            myAdapter.Fill(myData)
            With DataGridViewTransaksi
                .DataSource = myData
                .AllowUserToAddRows = False
                .AllowUserToDeleteRows = False
                .ReadOnly = True

            End With
            Data_Load()
            conn.Close()
        Catch myerror As MySqlException
            MessageBox.Show("Error: " & myerror.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub

    
    Private Sub BtnOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOrder.Click
        Cek_Nama()
        NamaPemesanIns = TexAtasNama.Text
        If NamaPemesan = TexAtasNama.Text Then
            MessageBox.Show("Nama sudah ada, harap menggunakan nama lain")
        Else
            Dim myCommand As New MySqlCommand
            Dim myCommand1 As New MySqlCommand
            Dim myCommand2 As New MySqlCommand
            Dim myAdapter As New MySqlDataAdapter
            Dim myData As New DataTable
            Dim conn As MySqlConnection
            Dim cmd As New MySqlCommand

            conn = New MySqlConnection()
            conn.ConnectionString = "server=localhost;user id=root;" & _
                                    "password=;database=foodcourt"



            Try
                If conn.State = ConnectionState.Closed Then conn.Open()
                SQL = "update transaksi set Atas_Nama=" & _
                      "'" & TexAtasNama.Text & "'"
                myCommand.Connection = conn
                myCommand.CommandText = SQL



                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myData)
                conn.Close()
            Catch myerror As MySqlException
                MessageBox.Show("Error: " & myerror.Message)
            Finally
                conn.Dispose()
            End Try

            Try
                If conn.State = ConnectionState.Closed Then conn.Open()
                SQL = "insert into pembelian(id_makananminuman,Nama,Jenis,Harga,id_counter,Atas_Nama) select id_makananminuman,Nama,Jenis,Harga,id_counter,Atas_Nama from transaksi"
                myCommand.Connection = conn
                myCommand.CommandText = SQL

                MsgBox("Pesanan Disimpan")

                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myData)
                conn.Close()
            Catch myerror As MySqlException
                MessageBox.Show("Error: " & myerror.Message)
            Finally
                conn.Dispose()
            End Try

            Try
                If conn.State = ConnectionState.Closed Then conn.Open()
                SQL = "delete from transaksi"
                myCommand.Connection = conn
                myCommand.CommandText = SQL

                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myData)
                conn.Close()
            Catch myerror As MySqlException
                MessageBox.Show("Error: " & myerror.Message)
            Finally
                conn.Dispose()
            End Try
        End If
        NamaPemesan = NamaPemesanIns
    End Sub

    Private Sub BtnLihatID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLihatID.Click
        Daftar_ID_Counter.Show()
    End Sub

    Private Sub EditMenuToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditMenuToolStripMenuItem.Click
        Edit_Menu.Show()
        Me.Hide()
    End Sub

    Private Sub LaporanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LaporanToolStripMenuItem.Click
        laporanharianview.Show()
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim myCommand As New MySqlCommand
        Dim myCommand1 As New MySqlCommand
        Dim myCommand2 As New MySqlCommand
        Dim myAdapter As New MySqlDataAdapter
        Dim myData As New DataTable

        conn = New MySqlConnection()
        conn.ConnectionString = "server=localhost;user id=root;" & _
                                "password=;database=foodcourt"
        Try
            If conn.State = ConnectionState.Closed Then conn.Open()
            SQL = "delete from foodcourt.transaksi"
            myCommand.Connection = conn
            myCommand.CommandText = SQL

            myAdapter.SelectCommand = myCommand
            myAdapter.Fill(myData)
            With DataGridViewTransaksi
                .DataSource = myData
                .AllowUserToAddRows = False
                .AllowUserToDeleteRows = False
                .ReadOnly = True

            End With
            Data_Load()
            conn.Close()
        Catch myerror As MySqlException
            MessageBox.Show("Error: " & myerror.Message)
        Finally
            conn.Dispose()
        End Try
        TextTotalHarga.Text = ""
    End Sub

    Private Sub MenuTerkarisToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuTerkarisToolStripMenuItem.Click
        MenuTerlaris.Show()
    End Sub

    Private Sub CounterTerlarisToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CounterTerlarisToolStripMenuItem.Click
        Counter_Terlaris.Show()
    End Sub

    Private Sub EditPesananToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditPesananToolStripMenuItem.Click
        Edit_Pesanan.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim myCommand As New MySqlCommand
        Dim myCommand1 As New MySqlCommand
        Dim myCommand2 As New MySqlCommand
        Dim myAdapter As New MySqlDataAdapter
        Dim myData As New DataTable
        Dim conn As MySqlConnection
        Dim cmd As New MySqlCommand

        conn = New MySqlConnection()
        conn.ConnectionString = "server=localhost;user id=root;" & _
                                "password=;database=foodcourt"



        Try
            If conn.State = ConnectionState.Closed Then conn.Open()
            SQL = "update transaksi set Atas_Nama=" & _
                  "'" & TexAtasNama.Text & "'"
            myCommand.Connection = conn
            myCommand.CommandText = SQL



            myAdapter.SelectCommand = myCommand
            myAdapter.Fill(myData)
            conn.Close()
        Catch myerror As MySqlException
            MessageBox.Show("Error: " & myerror.Message)
        Finally
            conn.Dispose()
        End Try

        Try
            If conn.State = ConnectionState.Closed Then conn.Open()
            SQL = "insert into pembelian(id_makananminuman,Nama,Jenis,Harga,id_counter,Atas_Nama) select id_makananminuman,Nama,Jenis,Harga,id_counter,Atas_Nama from transaksi"
            myCommand.Connection = conn
            myCommand.CommandText = SQL

            MsgBox("Pesanan Disimpan")

            myAdapter.SelectCommand = myCommand
            myAdapter.Fill(myData)
            conn.Close()
        Catch myerror As MySqlException
            MessageBox.Show("Error: " & myerror.Message)
        Finally
            conn.Dispose()
        End Try

        Try
            If conn.State = ConnectionState.Closed Then conn.Open()
            SQL = "delete from transaksi"
            myCommand.Connection = conn
            myCommand.CommandText = SQL

            myAdapter.SelectCommand = myCommand
            myAdapter.Fill(myData)
            conn.Close()
        Catch myerror As MySqlException
            MessageBox.Show("Error: " & myerror.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub
End Class
