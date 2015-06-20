Imports CefSharp

Public Class tabs

    Dim WithEvents browser As CefSharp.WinForms.ChromiumWebBrowser

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
    End Sub

    Private Sub share_Click(sender As Object, e As EventArgs) Handles share.Click
        My.Settings.sharepage = browser.Address.ToString
        sharepage.Show()
        qabbox.Visible = False

    End Sub

    Private Sub stopbtn_Click(sender As Object, e As EventArgs) Handles stopbtn.Click
        browser.Stop()
        browser.Focus()
    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click
        browser.Print()
        qabbox.Visible = False
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
