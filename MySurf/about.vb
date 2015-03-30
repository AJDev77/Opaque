Imports System.Net

Public Class about


    Private Sub updatetxt_Click(sender As Object, e As EventArgs) Handles updatetxt.Click
        Try
            'Check for updates
            updatetxt.Text = "test"
            updatetxt.Refresh()
            Dim web As New WebClient
            Dim update As String = web.DownloadString("http://mysurf.tk/downloads/update.txt")
            If update.Contains("3.0.0") Then
                'There is no update
                updatetxt.Text = "You have the latest version."
            Else
                'There is an update
                'updatedinfo.Show()
                Me.Hide()
            End If
        Catch ex As Exception
            MsgBox("The update server seems to be down right now. Please try again later.", MsgBoxStyle.OkOnly, "Error")

        End Try
    End Sub
End Class