Public Class search

    Private Sub search_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Gets current search engine
        Label3.Text = My.Settings.searchname
    End Sub
    'Sets the search provider to what has been clicked
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        My.Settings.search = ("https://duckduckgo.com/?q=")
        Label3.Text = "DuckDuckGo"
        MsgBox("Search provider set as DuckDuckGo.")
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        My.Settings.search = ("https://www.bing.com/search?q=")
        Label3.Text = "Bing"
        MsgBox("Search provider set as Bing.")
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        My.Settings.search = ("https://www.google.com/#q=")
        Label3.Text = "Google"
        MsgBox("Search provider set as Google.")
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        My.Settings.search = ("https://search.yahoo.com/search;?p=")
        Label3.Text = "Yahoo!"
        MsgBox("Search provider set as Yahoo!.")
    End Sub
End Class