Public Class crashrestore

    Private Sub crashrestore_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = My.Settings.restore
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        main.ChromeWebBrowser1.OpenUrl(My.Settings.restore)
        Me.Close()
    End Sub
End Class