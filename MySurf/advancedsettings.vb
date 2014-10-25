Public Class advancedsettings
    Private Sub CheckBox7_Click(sender As Object, e As EventArgs) Handles CheckBox7.Click
        MsgBox("Emposoft/MySurf strongly recommends that you DO NOT disable WebSecurity. WebSecurity helps to protect your computers from hackers and viruses.")
        CheckBox8.Show()
    End Sub
End Class