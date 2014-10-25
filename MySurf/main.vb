Imports System.IO
Imports Sashulin
Imports System.Threading
Imports System.Net


Public Class main
    Private Sub main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'Gets OS version for User Agent
            Dim osversion As String
            osversion = My.Computer.Info.OSFullName.ToString
            'Gets application startup path for cache
            Dim appPath As String = Application.StartupPath
            'New Chromium settings
            Dim settings As New CSharpBrowserSettings
            settings.UserAgent = ("MySurf 3.0 (Alpha 3) - Mozilla/5.0 (" & osversion & "; AppleWebKit/537.36 (KHTML, like Gecko) Chrome/31.0.1650.57 Safari/537.36")
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
            'Configure Dynamic UI; MySurf Themes
            'Dim appPathDynamic As String
            'appPathDynamic = Application.StartupPath
            'back.BackgroundImage = System.Drawing.Image.FromFile(appPathDynamic & "\themes\current\backtest.png")
            'Not needed for now.
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

    Private Sub ListBox1_Click(sender As Object, e As EventArgs) Handles ListBox1.Click

    End Sub

    Private Sub fav_Click(sender As Object, e As EventArgs) Handles fav.Click
        If TabControl1.Visible = True Then
            TabControl1.Visible = False
            ChromeWebBrowser1.Focus()
            Label3.Visible = False
        Else
            If TabControl1.Visible = False Then
                TabControl1.Visible = True
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
    Private Sub Button5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ChromeWebBrowser1.DeleteAllCookies()
    End Sub

    Private Sub ChromeWebBrowser1_BrowserDocumentCompleted(sender As Object, e As EventArgs) Handles ChromeWebBrowser1.BrowserDocumentCompleted
        Try
            If ChromeWebBrowser1.Url.Contains("https://accounts.google.com/ServiceLogin") = True Then
                ChromeWebBrowser1.ExecuteScript(My.Settings.ALgoogleFIN)
            End If
        Catch ex As Exception
        End Try
        Dim url As New Uri(ChromeWebBrowser1.Url.ToString)
        Dim websitename As String
        websitename = ChromeWebBrowser1.Title.ToString
        Me.Invoke(DirectCast(Sub() Me.Text = (websitename & " | MySurf 3.0 Alpha 3"), MethodInvoker))
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
        End If

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        My.Settings.quicknote = TextBox3.Text
        My.Settings.Save()
    End Sub

    Private Sub main_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        My.Settings.quicknote = TextBox3.Text
        My.Settings.Save()
    End Sub

    Private Sub ChromeWebBrowser1_Load(sender As Object, e As EventArgs) Handles ChromeWebBrowser1.Load

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        ChromeWebBrowser1.ShowDevTool()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ALgoogle_Tick(sender As Object, e As EventArgs) Handles ALgoogle.Tick
       
    End Sub

    Private Sub Button9_Click_1(sender As Object, e As EventArgs)


    End Sub
End Class
