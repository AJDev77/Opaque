Imports System.Net

Public Class updatedio

    Private Sub update_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WebBrowser1.Navigate("http://mysurf.tk/downloads/update-details.txt")
    End Sub
End Class