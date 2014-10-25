Public Class locked

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = My.Settings.password = True Then
            Timer1.Stop()
            Me.Hide()
            My.Settings.locked = False
            main.Show()
            My.Settings.locked = True
        Else
            MsgBox("Wrong Password.")
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        main.Hide()
    End Sub
End Class