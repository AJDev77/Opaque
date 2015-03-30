Imports CefSharp

Public Class downloading

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim percentcomplete As Integer = My.Settings.downloadpercent * 5
        Me.PictureBox1.Size = New Size(percentcomplete, 25)
    End Sub

    Private Sub downloading_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
End Class