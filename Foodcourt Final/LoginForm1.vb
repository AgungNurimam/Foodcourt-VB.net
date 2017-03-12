Imports MySql.Data.MySqlClient
Public Class LoginForm1
    Dim iFail As Integer

    Private Sub LoginForm1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        iFail = 0
    End Sub

    Function CheckLogin(ByVal Username As String, ByVal Password As String) As Integer
        Dim conn As MySqlConnection
        Dim cmd As New MySqlCommand
        Dim objValue As Object

        conn = New MySqlConnection()
        conn.ConnectionString = "server=localhost;user id=root;" & _
                                    "password=;database=foodcourt"
        Try
            conn.Open()
            cmd.Connection = conn
            cmd.CommandText = "SELECT COUNT(username) AS getin " & _
                              "FROM loginadmin WHERE username = " & _
                              "'" & Username & "' AND " & _
                              "password = '" & Password & "'"

            objValue = cmd.ExecuteScalar()
            conn.Close()
            If objValue Is Nothing Then
                Return 0
            Else
                Return objValue.ToString
            End If
        Catch myerror As MySqlException
            MessageBox.Show("Error: " & myerror.Message)
        Finally
            conn.Dispose()
        End Try
        Return 0
    End Function


    Private Sub OK_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim strUserName As String = UsernameTextBox.Text
        Dim strPassword As String = PasswordTextBox.Text

        If strUserName = String.Empty Then _
           MsgBox("Username belum diisi!") : Exit Sub
        If strPassword = String.Empty Then _
           MsgBox("Password belum diisi!") : Exit Sub


        Try
            If CheckLogin(strUserName, strPassword) > 0 Then
                MsgBox("Welcome " & strUserName & "!")
                'tulis code lainnya setelah login disini'
                Me.Close()
                Admin.Show()
            Else
                iFail = iFail + 1
                If iFail >= 3 Then
                    MsgBox("Gagal login 3 kali." & vbCrLf & _
                           "Aplikasi akan ditutup.")
                    End
                End If
                MsgBox("Username/password Salah." & vbCrLf & _
                       "Silahkan cek lagi!")
            End If
        Catch ex As Exception
            MsgBox("Error Login: " & ex.Message)
        End Try
    


    End Sub


    Private Sub Cancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub PasswordTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasswordTextBox.TextChanged

    End Sub

    Private Sub UsernameTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsernameTextBox.TextChanged

    End Sub
End Class



