Imports MySql.Data.MySqlClient
Public Class FormCekKoneksi
    Dim conn As MySqlConnection

    Private Sub BtnCekKoneksi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCekKoneksi.Click
        conn = New MySqlConnection()
        conn.ConnectionString = "server=localhost;user id=root;" & _
                                "password=;database=foodcourt"
        Try
            conn.Open()
            MessageBox.Show("Koneksi Berhasil")
            conn.Close()
        Catch myerror As MySqlException
            MessageBox.Show("Error Koneksi: " & myerror.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub BtnKembali_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnKembali.Click
        Mode.Show()
        Me.Close()
    End Sub
End Class