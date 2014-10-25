Public Class locks

    Private Sub locks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.locked = True Then
            Label3.Text = "Enabled"
            Label4.Visible = True
            Button1.Visible = True
            TextBox1.Visible = True
            Label5.Visible = False
            TextBox3.Visible = False
            TextBox2.Visible = False
            Button2.Visible = False
        Else
            Label3.Text = "Disabled"
            Label5.Visible = True
            TextBox3.Visible = True
            TextBox2.Visible = True
            Button2.Visible = True
            Label4.Visible = False
            Button1.Visible = False
            TextBox1.Visible = False
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs)
        Label2.Text = DateTime.Now
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = My.Settings.password = True Then
            Label5.Visible = True
            TextBox3.Visible = True
            TextBox2.Visible = True
            Button2.Visible = True
            Label4.Visible = False
            Button1.Visible = False
            TextBox1.Visible = False
        Else
            MsgBox("Wrong password, please try again.")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox2.Text = TextBox3.Text = True Then
            My.Settings.password = TextBox2.Text
            My.Settings.locked = True
            Label3.Text = "Enabled"
            MsgBox("Password Set!")
        Else
            MsgBox("Passwords do not match, please try again.")
        End If
    End Sub
End Class