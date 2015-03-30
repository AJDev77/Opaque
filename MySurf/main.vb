Imports CefSharp

Public Class main

    Dim WithEvents browser As CefSharp.WinForms.ChromiumWebBrowser
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Things loaded in designer:
        'CEF Settings, Browser Settings, Homepage
        browser.DownloadHandler = New DownloadHandler
    End Sub

    Private Sub backbtn_Click(sender As Object, e As EventArgs) Handles backbtn.Click
        browser.Back()
        browser.Focus()
    End Sub

    Private Sub forwardbtn_Click(sender As Object, e As EventArgs) Handles forwardbtn.Click
        browser.Forward()
        browser.Focus()
    End Sub

    Private Sub refreshbtn_Click(sender As Object, e As EventArgs) Handles refreshbtn.Click
        browser.Reload(True)
        browser.Focus()
    End Sub

    Private Sub homebtn_Click(sender As Object, e As EventArgs) Handles homebtn.Click
        browser.Load(My.Settings.homepage)
        browser.Focus()
    End Sub

    Private Sub addressbar_Click(sender As Object, e As EventArgs) Handles addressbar.Click
        addressbar.SelectAll()
    End Sub

    Private Sub addressbar_KeyDown(sender As Object, e As KeyEventArgs) Handles addressbar.KeyDown
        'The user has pressed the enter key, time to navigate
        If e.KeyCode = Keys.Enter Then
            go.PerformClick()
            e.SuppressKeyPress = True
            browser.Focus()
        Else

        End If
    End Sub
    Private Sub go_Click(sender As Object, e As EventArgs) Handles go.Click
        'Check if text is a URL or search term
        If addressbar.Text.Contains("http://") = True Then
            browser.Load(addressbar.Text)
        Else
            If addressbar.Text.Contains("https://") = True Then
                browser.Load(addressbar.Text)
            Else
                If addressbar.Text.Contains("chrome://") = True Then
                    browser.Load(addressbar.Text)
                Else
                    If addressbar.Text.Contains(" ") = True Then
                        addressbar.Text = addressbar.Text.Replace(" ", "+")
                        browser.Load(My.Settings.search.ToString & addressbar.Text)
                    Else
                        If addressbar.Text.Contains(" ") = False Then
                            If addressbar.Text.Contains(".") Then
                                browser.Load("http://" & addressbar.Text)
                            Else
                                addressbar.Text = addressbar.Text.Replace(" ", "+")
                                browser.Load(My.Settings.search.ToString & addressbar.Text)
                            End If
                        End If
                    End If
                End If
            End If
        End If

    End Sub
    Private Sub browser_LoadError(sender As Object, e As EventArgs) Handles browser.LoadError
        If My.Computer.Network.IsAvailable = False Then
            Dim errorpage As String = "<!DOCTYPE html><html><head><meta content='en-us' http-equiv='Content-Language'><meta content='text/html; charset=utf-8' http-equiv='Content-Type'><title>Error</title><style type='text/css'>.auto-style1 {	font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;	font-size: 50pt;	text-align: center;}.auto-style3 {	font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;	font-size: 25pt;	text-align: center;}.auto-style4 {	font-size: medium;}.auto-style5 {	font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;	text-align: center;}</style></head><body><p class='auto-style1'>:(<span class='auto-style2'>&nbsp;&nbsp; </span></p><p class='auto-style3'>Seems like you are not connected to the Internet.<br><span class='auto-style4'><br></span></p><p class='auto-style5'><strong>MySurf can't access the Internet. Make sure your computer is connected to the Internet.</strong></p><p class='auto-style5'></p><p class='auto-style5'></p><p class='auto-style5'></p></body></html>"
            browser.LoadHtml(errorpage, "http://rendering/")
        Else
            Dim errorpage As String = "<!DOCTYPE html><html><head><meta content='en-us' http-equiv='Content-Language'><meta content='text/html; charset=utf-8' http-equiv='Content-Type'><title>Error</title><style type='text/css'>.auto-style1 {	font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;	font-size: 50pt;	text-align: center;}.auto-style3 {	font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;	font-size: 25pt;	text-align: center;}.auto-style4 {	font-size: medium;}.auto-style5 {	font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;	text-align: center;}</style></head><body><p class='auto-style1'>:(<span class='auto-style2'>&nbsp;&nbsp; </span></p><p class='auto-style3'>Seems like the Vogons destroyed us.<br><span class='auto-style4'><br></span></p><p class='auto-style5'><strong>MySurf cannot open the webpage you specified.</strong></p><p class='auto-style5'></p><p class='auto-style5'></p><p class='auto-style5'></p></body></html>"
            browser.LoadHtml(errorpage, "http://rendering/")
        End If
    End Sub
    Private Sub browser_urlchange(sender As Object, e As EventArgs) Handles browser.AddressChanged
        Me.Invoke(Sub()
                      If addressbar.Focused = True Then
                          'Don't bother user
                      Else
                          addressbar.Text = browser.Address.ToString
                      End If
                  End Sub)
    End Sub
    Private Sub main_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.browser.Stop()

    End Sub
End Class
Public Class DownloadHandler
    Implements IDownloadHandler
    Public Function OnBeforeDownload(downloadItem As DownloadItem, ByRef downloadPath As String, ByRef showDialog As Boolean) As Boolean Implements IDownloadHandler.OnBeforeDownload
        downloadPath = downloadItem.SuggestedFileName
        showDialog = True
        downloading.Show()

        Return True
    End Function

    Public Function OnDownloadUpdated1(downloadItem As DownloadItem) As Boolean Implements IDownloadHandler.OnDownloadUpdated
        My.Settings.downloadpercent = downloadItem.PercentComplete.ToString
        Dim percentcomplete As Integer = My.Settings.downloadpercent * 5

        Return False
    End Function
End Class
