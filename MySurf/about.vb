Imports System.Net

Public Class about

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Try
        'Check for updates
            Label3.Text = "Checking for updates..."
            Label3.Refresh()
        Dim web As New WebClient
            Dim update As String = web.DownloadString("http://mysurf.tk/downloads/update.txt")
            If update.Contains("3.0 Beta 1") Then
                'There is no update
                Label3.Text = "You have the latest version."
            Else
                'There is an update
                updatedio.Show()
                Me.Hide()
            End If
        Catch ex As Exception
            MsgBox("The update server seems to be down right now. Please try again later.", MsgBoxStyle.OkOnly, "Error")

        End Try
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        'To show build version
        If Label1.Visible = True Then
            Label1.Visible = False
        Else
            If Label1.Visible = False Then
                Label1.Visible = True
            Else
                MsgBox("Something broke, please reinstall MySurf.")
            End If
        End If
    End Sub

    Private Sub about_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class