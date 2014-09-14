Public Class homepage

    Private Sub homepage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Gets the current home page to display
        TextBox1.Text = My.Settings.home
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Sets the home page to what is in Textbox1
        My.Settings.home = TextBox1.Text
        MsgBox("Homepage set!")
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Gets the current URL from Chromium
        TextBox1.Text = main.ChromeWebBrowser1.Url.ToString
    End Sub
End Class