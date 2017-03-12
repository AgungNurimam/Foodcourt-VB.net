Imports MySql.Data.MySqlClient
Imports System.Data
Public Class FormInputDataCounter
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
            SQL = "Select id_counter, Nama, Nama_Pemilik, No_Telp from counter"

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
                .Columns(2).HeaderText = "Nama Pemilik"
                .Columns(3).HeaderText = "No Telp"
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
                SQL = "INSERT INTO counter (id_counter,Nama,Nama_Pemilik,No_Telp) VALUES " & _
                      "('" & TextBoxID.Text & "','" & TextBoxNama.Text & "','" & TextBoxNamaPemilik.Text & "','" & TextBoxNoTelp.Text & "')"

                myCommand.Connection = conn
                myCommand.CommandText = SQL
                myCommand.ExecuteNonQuery()

                If BtnUpdate.Enabled = True Then
                    MsgBox("Data baru tersimpan")
                Else
                    MsgBox("Perubahan tersimpan")
                End If
                BtnBatal_Click(Nothing, Nothing)


                conn.Close()
                Data_Load()
        Catch myerror As MySqlException
            MessageBox.Show("Error: " & myerror.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub


    Private Sub DataGridView1_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDoubleClick
        TextBoxID.Text = DataGridView1.CurrentRow.Cells(0).Value
        TextBoxNama.Text = DataGridView1.CurrentRow.Cells(1).Value
        TextBoxNamaPemilik.Text = DataGridView1.CurrentRow.Cells(2).Value
        TextBoxNoTelp.Text = DataGridView1.CurrentRow.Cells(3).Value
        TextBoxID.ReadOnly = True
    End Sub


    Private Sub BtnEdit_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        DataGridView1_CellMouseDoubleClick(Nothing, Nothing)
    End Sub




    Private Sub BtnBatal_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnBatal.Click
        TextBoxID.Text = String.Empty
        TextBoxNama.Text = String.Empty
        TextBoxNamaPemilik.Text = String.Empty
        TextBoxNoTelp.Text = String.Empty
        TextBoxID.ReadOnly = False
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
            SQL = "DELETE FROM counter WHERE id_counter = " & _
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

    Private Sub StripSimpan_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnSimpan.Click
        Dim myCommand As New MySqlCommand

        conn = New MySqlConnection()
        conn.ConnectionString = "server=localhost;user id=root;" & _
                                "password=;database=foodcourt"
        Try
            conn.Open()
            SQL = "INSERT INTO counter(id_counter, Nama, Nama_Pemilik, No_Telp) VALUES " & _
                  "('" & TextBoxID.Text & "', '" & TextBoxNama.Text & "','" & TextBoxNamaPemilik.Text & "','" & TextBoxNoTelp.Text & "')"

            myCommand.Connection = conn
            myCommand.CommandText = SQL
            myCommand.ExecuteNonQuery()

            MsgBox("Data baru tersimpan")

            TextBoxID.Text = String.Empty
            TextBoxNama.Text = String.Empty
            TextBoxNamaPemilik.Text = String.Empty
            TextBoxNoTelp.Text = String.Empty
            Data_Load()

            conn.Close()
        Catch myerror As MySqlException
            MessageBox.Show("Error: " & myerror.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KeluarToolStripMenuItem.Click
        Admin.Show()
        Me.Close()
    End Sub

    Private Sub CounterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CounterToolStripMenuItem.Click
        Counter.Show()
        Me.Close()
    End Sub

    Private Sub KasirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KasirToolStripMenuItem.Click
        Kasir.Show()
        Me.Close()
    End Sub

    Private Sub AdminToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdminToolStripMenuItem.Click
        LoginForm1.Show()
        Me.Close()
        Admin.Show()
        LoginForm1.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        TextBoxID.Text = DataGridView1.CurrentRow.Cells(0).Value
        TextBoxNama.Text = DataGridView1.CurrentRow.Cells(1).Value
        TextBoxNamaPemilik.Text = DataGridView1.CurrentRow.Cells(2).Value
        TextBoxNoTelp.Text = DataGridView1.CurrentRow.Cells(3).Value
        BtnUpdate.Enabled = False
        TextBoxID.ReadOnly = True
    End Sub

    Private Sub BtnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpdate.Click
        Dim myCommand As New MySqlCommand
        conn = New MySqlConnection()
        conn.ConnectionString = "server=localhost;user id=root;" & _
                                "password=;database=foodcourt"
        Try
            conn.Open()
            SQL = "UPDATE counter SET Nama = '" & TextBoxNama.Text & "',Nama_Pemilik = '" & TextBoxNamaPemilik.Text & "',No_Telp = '" & TextBoxNoTelp.Text & "' " & _
                  "WHERE id_counter = '" & TextBoxID.Text & "'"


            myCommand.Connection = conn
            myCommand.CommandText = SQL
            myCommand.ExecuteNonQuery()

            If BtnUpdate.Enabled = True Then
                MsgBox("Data baru tersimpan")
            Else
                MsgBox("Perubahan tersimpan")
            End If
            BtnBatal_Click(Nothing, Nothing)


            conn.Close()

        Catch myerror As MySqlException
            MessageBox.Show("Error: " & myerror.Message)
        Finally
            conn.Dispose()
        End Try
        Data_Load()
    End Sub
End Class