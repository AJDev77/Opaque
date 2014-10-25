Public Class theme

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        main.Show()
        main.ChromeWebBrowser1.OpenUrl("http://themes.mysurf.tk/")
    End Sub
End Class