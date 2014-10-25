Imports System.Net

Public Class updatedio

    Private Sub update_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WebBrowser1.Navigate("http://mysurf.tk/downloads/update-details.txt")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        main.ChromeWebBrowser1.OpenUrl("http://mysurf.tk/download/")
    End Sub
End Class