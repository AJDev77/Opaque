Public Class updateinfo

    Private Sub updateinfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WebBrowser1.Navigate("https://updates.opaquebrowser.com/changelog.txt")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Settings.newpage = "https://opaquebrowser.com/download.html"
        main.InternalNewTab.PerformClick()
        Me.Hide()
    End Sub
End Class