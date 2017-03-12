Imports MySql.Data.MySqlClient
Imports System.Data
Public Class FormInputDataMakanan
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
            SQL = "Select id_makananminuman, Nama, Harga, Jenis, id_counter, Diskon from makanan_minuman"

            myCommand.Connection = conn
            myCommand.CommandText = SQL

            myAdapter.SelectCommand = myCommand
            myAdapter.Fill(myData)
            With DataGridView1
                .DataSource = myData
                .AllowUserToAddRows = False
                .AllowUserToDeleteRows = False
                .ReadOnly = True

                .Columns(0).HeaderText = "ID"
                .Columns(1).HeaderText = "Nama"
                .Columns(2).HeaderText = "Harga"
                .Columns(3).HeaderText = "Jenis"
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


    Private Sub FormInputData_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Data_Load()
    End Sub



    Private Sub BtnSimpan_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnSimpan.Click
        Dim myCommand As New MySqlCommand

        conn = New MySqlConnection()
        conn.ConnectionString = "server=localhost;user id=root;" & _
                                "password=;database=foodcourt"
        Try
            conn.Open()
            SQL = "INSERT INTO makanan_minuman (id_makananminuman,Nama,Harga,Jenis,id_counter,Diskon) VALUES " & _
                  "('" & txtIdmakanan.Text & "','" & txtnamamakanan.Text & "','" & txthargamakanan.Text & "','" & txtjenis.Text & "','" & txtcounter.Text & "','" & txtdiskon.Text & "')"

            myCommand.Connection = conn
            myCommand.CommandText = SQL
            myCommand.ExecuteNonQuery()

            MsgBox("Data baru tersimpan")

            txtIdmakanan.Text = String.Empty
            txtnamamakanan.Text = String.Empty
            txthargamakanan.Text = String.Empty
            txtjenis.Text = String.Empty
            txtcounter.Text = String.Empty
            Data_Load()

            conn.Close()
        Catch myerror As MySqlException
            MessageBox.Show("Error: " & myerror.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub


    Private Sub DataGridView1_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDoubleClick
        txtIdmakanan.Text = DataGridView1.CurrentRow.Cells(0).Value
        txtnamamakanan.Text = DataGridView1.CurrentRow.Cells(1).Value
        txthargamakanan.Text = DataGridView1.CurrentRow.Cells(2).Value
        txtjenis.Text = DataGridView1.CurrentRow.Cells(3).Value
        txtcounter.Text = DataGridView1.CurrentRow.Cells(4).Value
        txtIdmakanan.ReadOnly = True
    End Sub


    Private Sub BtnEdit_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        DataGridView1_CellMouseDoubleClick(Nothing, Nothing)
    End Sub




    Private Sub BtnBatal_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnBatal.Click
        txtIdmakanan.Text = String.Empty
        txtnamamakanan.Text = String.Empty
        txthargamakanan.Text = String.Empty
        txtjenis.Text = String.Empty
        txtcounter.Text = String.Empty
        txtIdmakanan.ReadOnly = False
        Data_Load()
    End Sub

    Private Sub BtnHapus_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnHapus.Click
        If MsgBox("Yakin akan menghapus data?", MsgBoxStyle.YesNo, _
              "Konfirmasi") = MsgBoxResult.No Then Exit Sub

        Dim myCommand As New MySqlCommand

        conn = New MySqlConnection()
        conn.ConnectionString = "server=localhost;user id=root;" & _
                                "password=;database=foodcourt"
        Try
            conn.Open()
            SQL = "DELETE FROM makanan_minuman WHERE id_makananminuman = " & _
                  "'" & DataGridView1.CurrentRow.Cells(0).Value & "'"

            myCommand.Connection = conn
            myCommand.CommandText = SQL
            myCommand.ExecuteNonQuery()

            MsgBox("Data terhapus")

            BtnBatal_Click(Nothing, Nothing)

            conn.Close()
        Catch myerror As MySqlException
            MessageBox.Show("Error: " & myerror.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub


    Private Sub BtnTutup_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnTutup.Click
        Me.Close()
    End Sub

    Private Sub TextBoxCounter_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub KembaliToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KembaliToolStripMenuItem.Click
        Admin.Show()
        Me.Close()
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcounter.SelectedIndexChanged

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class