Public Class Mode
    Dim rs As New Resizer

    Private Sub Mode_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        rs.FindAllControls(Me)

    End Sub

    Private Sub Mode_Resize(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Resize
        rs.ResizeAllControls(Me)
    End Sub


    Private Sub BtnKasir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnKasir.Click
        LoginForm1.Show()
        Me.Hide()
    End Sub


    Private Sub BtnCounter_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnCounter.Click
        LoginFormCounter.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        LoginFormKasir.Show()
    End Sub


    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        FormCekKoneksi.Show()


    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

  
End Class