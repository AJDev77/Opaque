Imports System.Net

Public Class about

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        'Check for updates
        Label3.Text = "Checking for updates..."
        Dim web As New WebClient
        Dim update As String = web.DownloadString("http://mysurf.tk/downloads/update.txt")
        If update.Contains("3.0 Alpha 1") Then
            'There is no update
            Label3.Text = "You have the latest version."
        Else
            'There is an update
            updatedio.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        'To show build version
        If Label4.Visible = True Then
            Label4.Visible = False
        Else
            If Label4.Visible = False Then
                Label4.Visible = True
            Else
                MsgBox("Something broke, please reinstall MySurf.")
            End If
        End If
    End Sub

    Private Sub about_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class