Public Class settings

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        MsgBox("MySurf Lock is not working yet due to compatibility issues.")
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        homepage.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        search.Show()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs)
        theme.Show()
    End Sub
    Private Sub settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        autologin.Show()
    End Sub
End Class