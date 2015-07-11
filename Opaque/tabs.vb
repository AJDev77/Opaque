Imports CefSharp
Imports System.IO

Public Class tabs

    Dim WithEvents browser As CefSharp.WinForms.ChromiumWebBrowser

    Private Sub tabs_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing


    End Sub

    Private Sub tab_Load(sender As Object, e As EventArgs) Handles Me.Load
        QuickNote.Text = My.Settings.QuickNote
        BFControl.Start()
        Panel1.BackColor = ColorTranslator.FromHtml(My.Settings.themecolor)
        main.BackColor = ColorTranslator.FromHtml(My.Settings.themecolor)
        Dim CommandLineArgs As System.Collections.ObjectModel.ReadOnlyCollection(Of String) = My.Application.CommandLineArgs
        For i As Integer = 0 To CommandLineArgs.Count - 1
            My.Settings.newpage = CommandLineArgs(i)
            My.Settings.LifeSpanNewPage = True
        Next
    End Sub

    Private Sub browser_LoadEnd(sender As Object, e As EventArgs) Handles browser.FrameLoadEnd
        Try
            Dim websitename As String = browser.Title.ToString
            Me.Invoke(DirectCast(Sub() Parent.Text = (websitename), MethodInvoker))
        Catch ex As Exception
            'Don't need to warn the user that the title did not show up. Error mostly happens when user closes browser while getting the name.
        End Try
        Try
            Me.Invoke(Sub()
                          brrefresh.Visible = True
                          stopbtn.Visible = False
                      End Sub)
        Catch ex As Exception
            'Been noticing some crashing going on, so I put this in a Try.
        End Try
    End Sub
    Private Sub browser_Testing(sender As Object, e As EventArgs) Handles browser.FrameLoadStart
        ' cef()
    End Sub
    Private Sub browser_AddressChanged(sender As Object, e As EventArgs) Handles browser.AddressChanged
        Me.Invoke(Sub()
                      If TextBox1.Focused = True Then
                          'Don't bother user
                      Else
                          TextBox1.Text = browser.Address.ToString
                      End If
                  End Sub)
    End Sub
    Private Sub browser_FrameLoadStart(sender As Object, e As EventArgs) Handles browser.FrameLoadStart
        Try
            Me.Invoke(Sub()
                          stopbtn.Visible = True
                          brrefresh.Visible = False
                      End Sub)
        Catch ex As Exception
            'Been noticing some crashing going on, so I put this in a Try.
        End Try
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles back.Click
        browser.Back()
        browser.Focus()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles forward.Click
        browser.Forward()
        browser.Focus()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles brrefresh.Click
        browser.Reload(ignoreCache:=True)
        browser.Focus()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        about.Show()
    End Sub

    Private Sub QuickNote_TextChanged(sender As Object, e As EventArgs) Handles QuickNote.TextChanged
        My.Settings.QuickNote = QuickNote.Text
        My.Settings.Save()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles qab.Click
        If qabbox.Visible = True Then
            qabbox.Visible = False
        Else
            If qabbox.Visible = False Then
                qabbox.Visible = True
                Dim closed As New System.Drawing.Size(290, 364)
                qabbox.Size = closed
            End If
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        'Check if text is a URL or search term
        'This is really too complicated...
        If TextBox1.Text.Contains("http://") = True Then
            browser.Load(TextBox1.Text)
        Else
            If TextBox1.Text.Contains("https://") = True Then
                browser.Load(TextBox1.Text)
            Else
                If TextBox1.Text.Contains("local://") = True Then
                    browser.Load(TextBox1.Text)
            Else
                If TextBox1.Text.Contains(" ") = True Then
                    TextBox1.Text = TextBox1.Text.Replace(" ", "+")
                    browser.Load(My.Settings.search.ToString & TextBox1.Text)
                Else
                    If TextBox1.Text.Contains(" ") = False Then
                        If TextBox1.Text.Contains(".") Then
                            browser.Load("http://" & TextBox1.Text)
                        Else
                            TextBox1.Text = TextBox1.Text.Replace(" ", "+")
                            browser.Load(My.Settings.search.ToString & TextBox1.Text)
                        End If
                    End If
                End If
                End If
            End If
        End If
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button1.PerformClick()
            e.SuppressKeyPress = True
            browser.Focus()
        Else

        End If
    End Sub
    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles TextBox1.Click
        TextBox1.SelectAll()
    End Sub

    Private Sub TextBox1_DoubleClick(sender As Object, e As EventArgs) Handles TextBox1.DoubleClick
        TextBox1.SelectionLength = 0
    End Sub
    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        about.Show()
        qabbox.Visible = False
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        settings.Show()
        qabbox.Visible = False
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles home.Click
        browser.Load(My.Settings.homepage)
        browser.Focus()
    End Sub

    Private Sub BFControl_Tick(sender As Object, e As EventArgs) Handles BFControl.Tick
        Try
            If browser.CanGoBack = True Then
                back.BackgroundImage = My.Resources.back
            Else
                back.BackgroundImage = My.Resources.no_back
            End If
            If browser.CanGoForward = True Then
                forward.BackgroundImage = My.Resources.forward
            Else
                forward.BackgroundImage = My.Resources.no_forward
            End If
        Catch ex As Exception
            'Error happens when timer starts but browser not ready
        End Try

    End Sub

    Private Sub share_Click(sender As Object, e As EventArgs) Handles share.Click
        My.Settings.sharepage = browser.Address.ToString
        TextBox2.Text = My.Settings.sharepage
        My.Settings.Save()
        Label5.Text = "Copy URL"
        Dim open As New System.Drawing.Size(290, 508)
        Dim closed As New System.Drawing.Size(290, 364)
        If qabbox.Size = open Then
            qabbox.Size = closed
        Else
            qabbox.Size = open
        End If

    End Sub

    Private Sub stopbtn_Click(sender As Object, e As EventArgs) Handles stopbtn.Click
        browser.Stop()
        browser.Focus()
    End Sub

    Private Sub PictureBox2_Click_1(sender As Object, e As EventArgs) Handles PictureBox2.Click
        browser.ShowDevTools()
        qabbox.Visible = False
    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click
        browser.Print()
        Dim closed As New System.Drawing.Size(290, 364)
        qabbox.Size = closed
        qabbox.Visible = False
    End Sub

    Private Sub PictureBox4_Click_1(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Clipboard.SetText(My.Settings.sharepage)
        Label5.Text = "  Copied!"
    End Sub

    Private Sub PictureBox3_Click_1(sender As Object, e As EventArgs) Handles PictureBox3.Click
        My.Settings.tweetpage = "https://twitter.com/intent/tweet?text=I%20found%20this%20awesome%20website%20using%20Opaque%20by%20Emposoft!%20" & My.Settings.sharepage
        My.Settings.newpage = My.Settings.tweetpage
        Dim closed As New System.Drawing.Size(290, 364)
        qabbox.Size = closed
        main.InternalNewTab.PerformClick()
        qabbox.Visible = False
    End Sub
    Private Sub browser_LoadError(sender As Object, e As EventArgs) Handles browser.LoadError
        If My.Computer.Network.IsAvailable = False Then
            Dim errorpage As String = "<!DOCTYPE html><html><head><meta content='en-us' http-equiv='Content-Language'><meta content='text/html; charset=utf-8' http-equiv='Content-Type'><title>Error</title><style type='text/css'>.auto-style1 {	font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;	font-size: 50pt;	text-align: center;}.auto-style3 {	font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;	font-size: 25pt;	text-align: center;}.auto-style4 {	font-size: medium;}.auto-style5 {	font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;	text-align: center;}</style></head><body><p class='auto-style1'>:(<span class='auto-style2'>&nbsp;&nbsp; </span></p><p class='auto-style3'>Seems like you are not connected to the Internet.<br><span class='auto-style4'><br></span></p><p class='auto-style5'><strong></strong></p><p class='auto-style5'></p><p class='auto-style5'></p><p class='auto-style5'></p></body></html>"
            browser.LoadHtml(errorpage, "http://OpaqueNoInternet/")
        End If
    End Sub
End Class
Public Class LifeSpanHandler
    Implements ILifeSpanHandler
    Public Event PopupRequest As Action(Of String)
    Public Function OnBeforePopup(browser As IWebBrowser, sourceUrl As String, targetUrl As String, ByRef x As Integer, ByRef y As Integer, ByRef width As Integer, ByRef height As Integer) As Boolean Implements ILifeSpanHandler.OnBeforePopup
        RaiseEvent PopupRequest(targetUrl)
        My.Settings.newpage = targetUrl
        'Not the best way to open a new tab, so we need to work on this.
        'My.Settings.LifeSpanNewPage = True
        'Dim mainFrm = New main()
        'mainFrm.IntNewTabIn()
        frmMain.Invoke(DirectCast(Sub() My.Settings.LifeSpanNewPage = True, MethodInvoker))
        'frmMain.Invoke(DirectCast(Sub() frmMain.Timer1.Start(), MethodInvoker))
        Return True
    End Function
    Public Sub OnBeforeClose(browser As IWebBrowser) Implements ILifeSpanHandler.OnBeforeClose

    End Sub
End Class
Public Class DownloadHandler
    Implements IDownloadHandler
    Public Function OnBeforeDownload(downloadItem As DownloadItem, ByRef downloadPath As String, ByRef showDialog As Boolean) As Boolean Implements IDownloadHandler.OnBeforeDownload
        downloadPath = downloadItem.SuggestedFileName
        downloading.Show()
        showDialog = True

        Return True
    End Function

    Public Function OnDownloadUpdated1(downloadItem As DownloadItem) As Boolean Implements IDownloadHandler.OnDownloadUpdated
        My.Settings.DownloadPercent = downloadItem.PercentComplete.ToString
        Dim percentcomplete As Integer = My.Settings.DownloadPercent * 5
        My.Settings.DownloadReB = downloadItem.ReceivedBytes
        My.Settings.DownloadTotB = downloadItem.TotalBytes
        My.Settings.DownloadSpeed = downloadItem.CurrentSpeed
        Return False
    End Function
End Class
Public Class RequestHandler
    Implements IRequestHandler
    Private Function IRequestHandler_OnBeforeBrowse(browser As IWebBrowser, request As IRequest, isRedirect As Boolean, isMainFrame As Boolean) As Boolean Implements IRequestHandler.OnBeforeBrowse

        Return False
    End Function

    Private Function IRequestHandler_OnCertificateError(browser As IWebBrowser, errorCode As CefErrorCode, requestUrl As String) As Boolean Implements IRequestHandler.OnCertificateError
        Return False
    End Function

    Private Sub IRequestHandler_OnPluginCrashed(browser As IWebBrowser, pluginPath As String) Implements IRequestHandler.OnPluginCrashed
        ' TODO: Add your own code here for handling scenarios where a plugin crashed, for one reason or another.

    End Sub

    Private Function IRequestHandler_OnBeforeResourceLoad(browser As IWebBrowser, request As IRequest, isMainFrame As Boolean) As CefReturnValue Implements IRequestHandler.OnBeforeResourceLoad
        Dim headers = request.Headers
        headers("DNT") = "1"
        request.Headers = headers
        Return False
    End Function

    Private Function IRequestHandler_GetAuthCredentials(browser As IWebBrowser, isProxy As Boolean, host As String, port As Integer, realm As String, scheme As String, _
        ByRef username As String, ByRef password As String) As Boolean Implements IRequestHandler.GetAuthCredentials
        Return False
    End Function

    Private Function IRequestHandler_OnBeforePluginLoad(browser As IWebBrowser, url As String, policyUrl As String, info As WebPluginInfo) As Boolean Implements IRequestHandler.OnBeforePluginLoad
        Dim blockPluginLoad As Boolean = False

        ' Enable next line to demo: Block any plugin with "flash" in its name
        ' try it out with e.g. http://www.youtube.com/watch?v=0uBOtQOO70Y
        'blockPluginLoad = info.Name.ToLower().Contains("flash");
        Return False
    End Function

    Private Sub IRequestHandler_OnRenderProcessTerminated(browser As IWebBrowser, status As CefTerminationStatus) Implements IRequestHandler.OnRenderProcessTerminated
        'MsgBox("Render Terminated")
    End Sub
    Public Class LocalSchemeHandler
        Implements ISchemeHandler
        Public Function ProcessRequestAsync(request As IRequest, response As ISchemeHandlerResponse, requestCompletedCallback As OnRequestCompletedHandler) As Boolean Implements ISchemeHandler.ProcessRequestAsync
            Dim u As New Uri(request.Url)
            Dim file__1 As [String] = u.Authority + u.AbsolutePath

            If File.Exists(file__1) Then
                Dim bytes As [Byte]() = File.ReadAllBytes(file__1)
                response.ResponseStream = New MemoryStream(bytes)
                Select Case Path.GetExtension(file__1)
                    Case ".html"
                        response.MimeType = "text/html"
                        Exit Select
                    Case ".js"
                        response.MimeType = "text/javascript"
                        Exit Select
                    Case ".png"
                        response.MimeType = "image/png"
                        Exit Select
                    Case ".appcache", ".manifest"
                        response.MimeType = "text/cache-manifest"
                        Exit Select
                    Case Else
                        response.MimeType = "application/octet-stream"
                        Exit Select
                End Select
                requestCompletedCallback()
                Return True
            End If
            Return False
        End Function
    End Class
    Public Class LocalSchemeHandlerFactory
        Implements ISchemeHandlerFactory
        Public Function Create() As ISchemeHandler Implements ISchemeHandlerFactory.Create
            Return New LocalSchemeHandler()
        End Function

        Public Shared ReadOnly Property SchemeName() As String
            Get
                Return "local"
            End Get
        End Property
    End Class
End Class
