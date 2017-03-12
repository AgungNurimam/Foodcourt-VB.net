Imports MySql.Data.MySqlClient
Imports System.Data
Public Class Admin
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
            SQL = "Select * from login"

            myCommand.Connection = conn
            myCommand.CommandText = SQL

            myAdapter.SelectCommand = myCommand
            myAdapter.Fill(myData)
            With DataUser
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

    Sub Data_Load2()
        Dim myCommand As New MySqlCommand
        Dim myAdapter As New MySqlDataAdapter
        Dim myData As New DataTable

        conn = New MySqlConnection()
        conn.ConnectionString = "server=localhost;user id=root;" & _
                                "password=;database=foodcourt"
        Try
            If conn.State = ConnectionState.Closed Then conn.Open()
            SQL = "Select * from loginadmin"

            myCommand.Connection = conn
            myCommand.CommandText = SQL

            myAdapter.SelectCommand = myCommand
            myAdapter.Fill(myData)
            With DataAdmin
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



    Private Sub AdminToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdminToolStripMenuItem.Click
        LoginForm1.Show()
        Me.Close()
    End Sub

    Private Sub CounterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CounterToolStripMenuItem.Click
        Counter.Show()
        Me.Close()
    End Sub


    Private Sub CekKoneksiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FormCekKoneksi.Show()
        Me.Close()
    End Sub


    Private Sub InputDataMakananMinumanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InputDataMakananMinumanToolStripMenuItem.Click
        FormInputDataMakanan.Show()
        Me.Close()
    End Sub


    Private Sub InputDataCounterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InputDataCounterToolStripMenuItem.Click
        FormInputDataCounter.Show()
        Me.Close()
    End Sub

    Private Sub KasirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KasirToolStripMenuItem.Click
        Kasir.Show()
        Me.Close()
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KeluarToolStripMenuItem.Click
        Mode.Show()
        Me.Close()
    End Sub

    Private Sub ButtonSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        
    End Sub

    'Admin'
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim myCommand As New MySqlCommand

        conn = New MySqlConnection()
        conn.ConnectionString = "server=localhost;user id=root;" & _
                                "password=;database=foodcourt"
        If TextPassAdmin.Text = TextBoxRePasswordAdmin.Text Then
            Try
                conn.Open()
                SQL = "INSERT INTO loginadmin (Nama,Jabatan,username,password) VALUES " & _
                      "('" & TextNamaAdmin.Text & "','" & TextJabatanAdmin.Text & "','" & TextUsrAdmin.Text & "','" & TextPassAdmin.Text & "')"

                myCommand.Connection = conn
                myCommand.CommandText = SQL
                myCommand.ExecuteNonQuery()

            Catch myerror As MySqlException
                MessageBox.Show("Error: " & myerror.Message)
            Finally
                conn.Dispose()
            End Try

            Try
                conn.Open()
                SQL = "INSERT INTO login (Nama,Jabatan,username,password) VALUES " & _
                      "('" & TextNamaAdmin.Text & "','" & TextJabatanAdmin.Text & "','" & TextUsrAdmin.Text & "','" & TextPassAdmin.Text & "')"

                myCommand.Connection = conn
                myCommand.CommandText = SQL
                myCommand.ExecuteNonQuery()

                MsgBox("Data baru tersimpan")

                TextNamaAdmin.Text = String.Empty
                TextJabatanAdmin.Text = String.Empty
                TextUsrAdmin.Text = String.Empty
                TextPassAdmin.Text = String.Empty
                TextBoxRePasswordAdmin.Text = String.Empty
                conn.Close()
            Catch myerror As MySqlException
                MessageBox.Show("Error: " & myerror.Message)
            Finally
                conn.Dispose()
            End Try
            conn.Close()

        Else
            MsgBox("Password Tidak Sama")
        End If
        Data_Load()
        Data_Load2()

    End Sub


    Private Sub Hapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Hapus.Click
        If MsgBox("Yakin akan menghapus data?", MsgBoxStyle.YesNo, _
             "Konfirmasi") = MsgBoxResult.No Then Exit Sub

        Dim myCommand As New MySqlCommand

        conn = New MySqlConnection()
        conn.ConnectionString = "server=localhost;user id=root;" & _
                                "password=;database=foodcourt"
        Try
            conn.Open()
            SQL = "DELETE FROM login WHERE Nama = " & _
                  "'" & DataUser.CurrentRow.Cells(0).Value & "'"

            myCommand.Connection = conn
            myCommand.CommandText = SQL
            myCommand.ExecuteNonQuery()

            MsgBox("Data terhapus")



            conn.Close()
        Catch myerror As MySqlException
            MessageBox.Show("Error: " & myerror.Message)
        Finally
            conn.Dispose()
        End Try


        Data_Load()
    End Sub

    Private Sub Hapus2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Hapus2.Click
        If MsgBox("Yakin akan menghapus data?", MsgBoxStyle.YesNo, _
             "Konfirmasi") = MsgBoxResult.No Then Exit Sub

        Dim myCommand As New MySqlCommand

        conn = New MySqlConnection()
        conn.ConnectionString = "server=localhost;user id=root;" & _
                                "password=;database=foodcourt"
        Try
            conn.Open()
            SQL = "DELETE FROM loginadmin WHERE Nama = " & _
                  "'" & DataAdmin.CurrentRow.Cells(0).Value & "'"

            myCommand.Connection = conn
            myCommand.CommandText = SQL
            myCommand.ExecuteNonQuery()

           
            conn.Close()
        Catch myerror As MySqlException
            MessageBox.Show("Error: " & myerror.Message)
        Finally
            conn.Dispose()
        End Try
        Data_Load2()

    End Sub

    Private Sub Admin_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Data_Load()
        Data_Load2()
    End Sub

    Private Sub TentangToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TentangToolStripMenuItem.Click
        Tentang.Show()
        Me.Close()
    End Sub

    Private Sub LaporanBulananToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LaporanBulananToolStripMenuItem.Click
        LaporanBulananview.Show()
    End Sub

    Private Sub SemuaLaporanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SemuaLaporanToolStripMenuItem.Click
        Laporan.Show()
    End Sub

    Private Sub LaporanTahunanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LaporanTahunanToolStripMenuItem.Click
        LaporanTahunanview.Show()
    End Sub


    Private Sub LaporanHarianToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LaporanHarianToolStripMenuItem.Click
        laporanharianview.Show()
    End Sub

    Private Sub C01ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C01ToolStripMenuItem.Click
        LaporanCO1.Show()
        Me.Close()
    End Sub

    Private Sub ButtonSimpan_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSimpan.Click
        Dim myCommand As New MySqlCommand

        conn = New MySqlConnection()
        conn.ConnectionString = "server=localhost;user id=root;" & _
                                "password=;database=foodcourt"

        Try
            If TextBoxPassword.Text = TextBoxRePasword.Text Then
                conn.Open()
                SQL = "INSERT INTO login (Nama,Jabatan,username,password) VALUES " & _
                      "('" & TextBoxNama.Text & "','" & TextBoxJabatan.Text & "','" & TextBoxUsername.Text & "','" & TextBoxPassword.Text & "')"

                myCommand.Connection = conn
                myCommand.CommandText = SQL
                myCommand.ExecuteNonQuery()

                MsgBox("Data baru tersimpan")

                TextBoxNama.Text = String.Empty
                TextBoxJabatan.Text = String.Empty
                TextBoxUsername.Text = String.Empty
                TextBoxPassword.Text = String.Empty
                TextBoxRePasword.Text = String.Empty
            Else
                MsgBox("Password Tidak Sama")
            End If
            conn.Close()
        Catch myerror As MySqlException
            MessageBox.Show("Error: " & myerror.Message)
        Finally
            conn.Dispose()
        End Try
        Data_Load()
    End Sub

    Private Sub LaporanBulananToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LaporanBulananToolStripMenuItem1.Click
        BulananGrafik.Show()
    End Sub

    Private Sub LaporanTahunanToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LaporanTahunanToolStripMenuItem1.Click
        TahunanGrafik.Show()
    End Sub

    Private Sub C02ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C02ToolStripMenuItem.Click
        LaporanCO2.Show()
    End Sub
End Class