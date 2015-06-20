Public Class downloading

    Private Sub downloading_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim percentcomplete As Integer = My.Settings.downloadpercent * 5
        Me.PictureBox1.Size = New Size(percentcomplete, 25)

        Dim RecMB As String = My.Settings.DownloadReB / 1024 / 1024
        Dim TotMB As String = My.Settings.DownloadTotB / 1024 / 1024
        'Dim SpeedMB As String = My.Settings.DownloadSpeed / 0.001

        'Dim RecBy As String
        'RecBy = RecMB
        'Dim answer As String
        'answer = RecBy.Substring(0, 1)

        'Dim TotBy As String
        'TotBy = TotMB
        'Dim answer2 As String
        'answer2 = TotBy.Substring(0, 1)

        Label3.Text = RecMB
        Label4.Text = TotMB
        ' Label6.Text = SpeedMB
    End Sub
End Class