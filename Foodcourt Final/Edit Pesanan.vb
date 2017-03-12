Imports MySql.Data.MySqlClient
Imports System.Data
Public Class Edit_Pesanan
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
            SQL = "Select Nama,Atas_Nama,count(id_makananminuman) as Jumlah from pembelian WHERE Atas_Nama=" & _
            "'" & TextBoxAtasNama.Text & "' group by id_makananminuman"

            myCommand.Connection = conn
            myCommand.CommandText = SQL

            myAdapter.SelectCommand = myCommand
            myAdapter.Fill(myData)
            With DataGridPesanan
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


    Private Sub DataGridPesanan_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridPesanan.CellMouseDoubleClick
        TextBoxAtasNama.Text = DataGridPesanan.CurrentRow.Cells(1).Value
    End Sub


    Private Sub BtnEdit_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        DataGridPesanan_CellMouseDoubleClick(Nothing, Nothing)
    End Sub




    Private Sub BtnBatal_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnBatal.Click
        TextBoxAtasNama.Text = String.Empty
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
            SQL = "DELETE FROM pembelian WHERE id_counter = " & _
                  "'" & DataGridPesanan.CurrentRow.Cells(0).Value & "'"

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



    Private Sub DataGridPesanan_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridPesanan.CellContentClick
        TextBoxAtasNama.Text = DataGridPesanan.CurrentRow.Cells(1).Value
    End Sub

    Private Sub BtnCari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCari.Click
        Data_Load()
    End Sub

    Private Sub Edit_Pesanan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

End Class