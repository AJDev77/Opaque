Imports System.Net

Public Class downloading
    Public WithEvents download As WebClient
    Private Sub downloading_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            download = New WebClient
            download.DownloadFileAsync(New Uri(My.Settings.DownloadURL), My.Settings.DownloadLocalFilePath & ".opaquedownload")
            DownloadURL.Text = My.Settings.DownloadURL
            LocalLocation.Text = My.Settings.DownloadLocalFilePath
            Button2.Visible = False
        Catch ex As Exception
            MsgBox("File could not be downloaded." & ex.Message)
        End Try
    End Sub

    Private Sub download_DownloadFileCompleted(sender As Object, e As System.ComponentModel.AsyncCompletedEventArgs) Handles download.DownloadFileCompleted
        If e.Cancelled = True Then
            My.Computer.FileSystem.DeleteFile(My.Settings.DownloadLocalFilePath & ".opaquedownload")
            MsgBox("Download had been cancelled.")
            Me.Close()

        Else
            Dim filename As String = System.IO.Path.GetFileName(My.Settings.DownloadLocalFilePath)
            System.IO.File.Move(My.Settings.DownloadLocalFilePath & ".opaquedownload", My.Settings.DownloadLocalFilePath)
            Button2.Visible = True
            Button1.Visible = False
            MsgBox("Download has completed.")

        End If


    End Sub
    Private Sub download_DownloadProgressChanged(ByVal sender As System.Object, ByVal e As System.Net.DownloadProgressChangedEventArgs) Handles download.DownloadProgressChanged
        Try
            Label3.Text = "Downloaded: " & e.BytesReceived / 1000000 & "MB / " & e.TotalBytesToReceive / 1000000 & "MB"
            ProgressBar1.Value = e.ProgressPercentage
            ProgressBarLabel2.Text = ProgressBar1.Value.ToString & "%"

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        download.CancelAsync()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class