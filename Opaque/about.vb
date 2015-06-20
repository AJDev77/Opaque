Imports System.Net

Public Class about

    Private Sub about_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Try
            'Check for updates
            Label2.Text = "Checking for updates..."
            Label2.Refresh()
            Dim web As New WebClient
            Dim update As String = web.DownloadString("http://updates.opaquebrowser.com/version.txt")
            If update.Contains("1.0.0") Then
                'There is no update
                Label2.Text = "You have the latest version."
            Else
                'There is an update
                updateinfo.Show()
                Me.Hide()
                Label2.Text = "Click here to check for updates"
            End If
        Catch ex As Exception
            MsgBox("The update server seems to be down right now. Please try again later.", MsgBoxStyle.OkOnly, "Error")

        End Try
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        If Label3.Visible = False Then
            Label3.Visible = True
        Else
            Label3.Visible = False
        End If
    End Sub
End Class