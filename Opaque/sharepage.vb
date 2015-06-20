Public Class sharepage

    Private Sub sharepage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = My.Settings.sharepage
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Clipboard.SetText(My.Settings.sharepage)
        Label5.Text = "  Copied!"
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        My.Settings.tweetpage = "https://twitter.com/intent/tweet?text=I%20found%20this%20awesome%20page%20using%20Opaque%20by%20Emposoft!%20" & My.Settings.sharepage
        My.Settings.newpage = My.Settings.tweetpage
        main.InternalNewTab.PerformClick()
        Me.Hide()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)

    End Sub
End Class