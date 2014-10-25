Public Class autologingoogle

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
                TextBox3.Text = TextBox3.Text.Replace("1", TextBox1.Text)
                TextBox3.Text = TextBox3.Text.Replace("2", TextBox2.Text)
                My.Settings.ALgoogleFIN = TextBox3.Text
                My.Settings.Save()
    End Sub
End Class