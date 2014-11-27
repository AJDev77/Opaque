Imports System.IO
Imports Sashulin
Imports System.Threading
Imports System.Net
Imports System.Text.RegularExpressions


Public Class main
    Private Sub main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim appPath As String = Application.StartupPath
        Try
                'Sets AutoLogin Script
                My.Settings.ALgoogleFIN = "document.getElementById('Email').value='1';document.getElementById('Passwd').value='2'"
                My.Settings.ALmicrosoftFIN = "document.getElementById('i0116').value='9';document.getElementById('i0118').value='5'"
                'Gets OS version for User Agent
                Dim osversion As String
                osversion = My.Computer.Info.OSFullName.ToString
                'Gets application startup path for cache
                'New Chromium settings
                Dim settings As New CSharpBrowserSettings
                settings.UserAgent = ("Mozilla/5.0 (" & osversion & "; AppleWebKit/537.36 (KHTML, like Gecko) MySurf/3.0")
                settings.CachePath = (appPath + "/MySurf Cache/")
                'Initialize Chromium
                ChromeWebBrowser1.Initialize(settings)
                'Goes to homepage on startup
                ChromeWebBrowser1.OpenUrl(My.Settings.home)
                'Get everything out of bookmarks
                ListBox1.Items.Clear()
                'Get bookmarks from My.Settings.favlist
                Dim strings(My.Settings.favlist.Count - 1) As String
                My.Settings.favlist.CopyTo(strings, 0)
                'Add bookmarks to listbox
                ListBox1.Items.AddRange(strings)

        Catch ex As Exception
            MsgBox("There was an error initializing Chromium. Please reinstall MySurf. Error details will come up next.")
            MsgBox(ex.Message)
        End Try
        Try
            'Get note data
            TextBox3.Text = My.Settings.quicknote
        Catch ex As Exception
            MsgBox("Unable to open note. Note data seems damaged.")
        End Try
        Try
            autologingoogle.TestDecoding()
            My.Settings.ALgoogleFIN = My.Settings.ALgoogleFIN.Replace("1", My.Settings.ALgoogleUN)
            My.Settings.ALgoogleFIN = My.Settings.ALgoogleFIN.Replace("2", My.Settings.ALgooglePASS)
            autologingoogle.TextBox3.Text = TextBox3.Text.Replace("1", TextBox1.Text)
            My.Settings.Save()
        Catch ex As Exception

        End Try
        Try
            autologinmicrosoft.TestDecoding()
            My.Settings.ALmicrosoftFIN = My.Settings.ALmicrosoftFIN.Replace("9", My.Settings.ALmicrosoftUN)
            My.Settings.ALmicrosoftFIN = My.Settings.ALmicrosoftFIN.Replace("5", My.Settings.ALmicrosoftPASS)
            autologinmicrosoft.TextBox3.Text = TextBox3.Text.Replace("9", TextBox1.Text)
            My.Settings.Save()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Try
            If My.Settings.crash = False Then
                My.Settings.restore = My.Settings.crashURL
                crashrestore.Show()

            Else
                My.Settings.crash = False
                My.Settings.Save()
            End If
        Catch ex As Exception
            MsgBox("It seems that someone has tampered with MySurfs data file.")
        End Try
    End Sub

    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        'Goes back one page
        ChromeWebBrowser1.GoBack()
        ChromeWebBrowser1.Focus()
    End Sub

    Private Sub forward_Click(sender As Object, e As EventArgs) Handles forward.Click
        'Goes forward one page
        ChromeWebBrowser1.GoForward()
        ChromeWebBrowser1.Focus()
    End Sub

    Private Sub home_Click(sender As Object, e As EventArgs) Handles home.Click
        'Goes to set homepage
        ChromeWebBrowser1.OpenUrl(My.Settings.home)
        ChromeWebBrowser1.Focus()
    End Sub

    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles TextBox1.Click
        'Selects all text in URL bar for easy access to type in new URL
        TextBox1.SelectAll()
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        'The user has pressed the enter key, time to navigate
        If e.KeyCode = Keys.Enter Then
            go.PerformClick()
            e.SuppressKeyPress = True
            ChromeWebBrowser1.Focus()
        Else

        End If
    End Sub
    Private Sub go_Click(sender As Object, e As EventArgs) Handles go.Click
        'Check if text is a URL or search term
        'This is really too complicated...
        If TextBox1.Text.Contains("http://") = True Then
            ChromeWebBrowser1.OpenUrl(TextBox1.Text)
        Else
            If TextBox1.Text.Contains("https://") = True Then
                ChromeWebBrowser1.OpenUrl(TextBox1.Text)
            Else
                If TextBox1.Text.Contains(" ") = True Then
                    TextBox1.Text = TextBox1.Text.Replace(" ", "+")
                    ChromeWebBrowser1.OpenUrl(My.Settings.search.ToString & TextBox1.Text)
                Else
                    If TextBox1.Text.Contains(" ") = False Then
                        If TextBox1.Text.Contains(".") Then
                            ChromeWebBrowser1.OpenUrl("http://" & TextBox1.Text)
                        Else
                            TextBox1.Text = TextBox1.Text.Replace(" ", "+")
                            ChromeWebBrowser1.OpenUrl(My.Settings.search.ToString & TextBox1.Text)
                        End If
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub quickbar_Click(sender As Object, e As EventArgs) Handles quickbar.Click
        'To display the QuickAction box
        If qsb.Visible = False Then
            qsb.Visible = True
            TabControl1.Visible = False
        Else
            If qsb.Visible = True Then
                qsb.Visible = False
            Else
                MsgBox("There was an internal error in MySurf. Please download and reinstall MySurf again to resolve the issue.")
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Hides QuickActions when button is pushed
        about.Show()
        qsb.Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Hides QuickActions when button is pushed
        settings.Show()
        qsb.Visible = False
    End Sub

    Private Sub refreshbtn_Click(sender As Object, e As EventArgs) Handles refreshbtn.Click
        'Refresh the page
        ChromeWebBrowser1.Reload(True)
    End Sub

    Private Sub fav_Click(sender As Object, e As EventArgs) Handles fav.Click
        If TabControl1.Visible = True Then
            TabControl1.Visible = False
            ChromeWebBrowser1.Focus()
            Label3.Visible = False
        Else
            If TabControl1.Visible = False Then
                TabControl1.Visible = True
                qsb.Visible = False
                ChromeWebBrowser1.Focus()
                Label3.Visible = False
            Else
                MsgBox("There was an internal error in MySurf. Please download and reinstall MySurf.")
            End If
        End If
        Dim strings(ListBox1.Items.Count - 1) As String
        ListBox1.Items.CopyTo(strings, 0)
        My.Settings.favlist.Clear()
        My.Settings.favlist.AddRange(strings)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ListBox1.Items.Add(TextBox2.Text.ToString)
        TextBox2.Text = "http://"
        Label3.Visible = True
        Dim strings(ListBox1.Items.Count - 1) As String
        ListBox1.Items.CopyTo(strings, 0)
        My.Settings.favlist.Clear()
        My.Settings.favlist.AddRange(strings)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox2.Text = (ChromeWebBrowser1.Url.ToString)
    End Sub
    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        My.Settings.clearcache = True
        MsgBox("MySurf will now restart to clear the cache.")
        Application.Restart()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ChromeWebBrowser1.DeleteAllCookies()
        MsgBox("All cookies have been deleted.")
    End Sub

    Private Sub ChromeWebBrowser1_BrowserDocumentCompleted(sender As Object, e As EventArgs) Handles ChromeWebBrowser1.BrowserDocumentCompleted
        If My.Settings.ALgoogleENA = True Then
            Try
                If ChromeWebBrowser1.Url.Contains("https://accounts.google.com/ServiceLogin") = True Then
                    ChromeWebBrowser1.ExecuteScript(My.Settings.ALgoogleFIN)

                End If
            Catch ex As Exception
            End Try
        Else

        End If
        If My.Settings.ALmicrosoftENA = True Then
            Try
                If ChromeWebBrowser1.Url.Contains("https://login.live.com/login.srf") = True Then
                    ChromeWebBrowser1.ExecuteScript(My.Settings.ALmicrosoftFIN)

                End If
            Catch ex As Exception
            End Try
        Else

        End If
        Dim url As New Uri(ChromeWebBrowser1.Url.ToString)
        Dim websitename As String
        websitename = ChromeWebBrowser1.Title.ToString
        Me.Invoke(DirectCast(Sub() Me.Text = (websitename & " | MySurf"), MethodInvoker))
        Try
            If url.HostNameType = UriHostNameType.Dns Then
                Dim favicon As String = "http://" & url.Host & "/favicon.ico"
                Dim req As WebRequest = HttpWebRequest.Create(favicon)
                Using res As HttpWebResponse = CType(req.GetResponse(), HttpWebResponse)
                    Dim stream As Stream = res.GetResponseStream
                    Dim fav As Image = Image.FromStream(stream)

                    Me.PictureBox1.Image = fav
                End Using
            End If

        Catch ex As Exception

        End Try
        If TextBox1.Text.Contains("mysurf://settings") = True Then
            ChromeWebBrowser1.GoBack()
            settings.Show()
        End If
        If TextBox1.Text.Contains("mysurf://crash") = True Then
            Environment.FailFast("MySurf Crash due to mysurf://crash being called.")
        End If
        If TextBox1.Text.Contains("mysurf://restore") = True Then
            crashrestore.show()
        End If
        My.Settings.crashURL = ChromeWebBrowser1.Url.ToString
        My.Settings.Save()

    End Sub
    Private Sub ChromeWebBrowser1_BrowserUrlChange(sender As Object, e As Sashulin.UrlChangeEventArgs) Handles ChromeWebBrowser1.BrowserUrlChange
        Me.Invoke(DirectCast(Sub() TextBox1.Text = ChromeWebBrowser1.Url.ToString, MethodInvoker))
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ChromeWebBrowser1.canGoForward = True Then
            forward.BackgroundImage = My.Resources.arrow_next_3_icon
        Else
            forward.BackgroundImage = My.Resources.arrow_next_3_icon_faded
        End If
        If ChromeWebBrowser1.canGoBack = True Then
            back.BackgroundImage = My.Resources.arrow_back_icon
        Else
            back.BackgroundImage = My.Resources.arrow_back_icon_faded
        End If
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        ListBox1.Items.Remove(ListBox1.SelectedItem)
        Dim strings(ListBox1.Items.Count - 1) As String
        ListBox1.Items.CopyTo(strings, 0)
        My.Settings.favlist.Clear()
        My.Settings.favlist.AddRange(strings)
    End Sub
    Private Sub ListBox1_DoubleClick(sender As Object, e As EventArgs) Handles ListBox1.DoubleClick
        If ListBox1.SelectedItem = "" Then

        Else
            My.Settings.openbookmark = ListBox1.SelectedItem()
            ChromeWebBrowser1.OpenUrl(My.Settings.openbookmark)
            TabControl1.Visible = False
        End If

    End Sub
    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        My.Settings.quicknote = TextBox3.Text
        My.Settings.Save()
    End Sub
    Private Sub main_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        My.Settings.ALgoogleFIN = ""
        My.Settings.ALgooglePASS = ""
        My.Settings.ALmicrosoftFIN = ""
        My.Settings.ALmicrosoftPASS = ""
        My.Settings.quicknote = TextBox3.Text
        My.Settings.crash = True
        My.Settings.Save()
    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        ChromeWebBrowser1.ShowDevTool()
    End Sub
    Private Sub BackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackToolStripMenuItem.Click
        back.PerformClick()
    End Sub

    Private Sub ForwardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ForwardToolStripMenuItem.Click
        forward.PerformClick()
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        refreshbtn.PerformClick()
    End Sub

    Private Sub BookmarkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BookmarkToolStripMenuItem.Click
        fav.PerformClick()
        Button3.PerformClick()
    End Sub
    Private Sub ViewSourceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewSourceToolStripMenuItem.Click
        ChromeWebBrowser1.ViewSource()
    End Sub

    Private Sub main_MaximumSizeChanged(sender As Object, e As EventArgs) Handles Me.MaximumSizeChanged

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
