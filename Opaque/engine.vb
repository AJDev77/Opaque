Public Class engine
    Private Sub engine_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If GroupBox1.Visible = True Then
            If e.KeyCode = Keys.W Then
                PictureBox1.BackgroundImage = My.Resources.w_green()
                My.Settings.wpressed = True
            Else

                If e.KeyCode = Keys.E Then
                    PictureBox2.BackgroundImage = My.Resources.e_green()
                    My.Settings.epressed = True
                Else

                    If e.KeyCode = Keys.B Then
                        PictureBox3.BackgroundImage = My.Resources.b_green()
                        My.Settings.bpressed = True
                    Else

                    End If
                End If
            End If
        End If
    End Sub
    Private Sub engine_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Settings.epressed = False
        My.Settings.bpressed = False
        My.Settings.wpressed = False
        PictureBox1.BackgroundImage = My.Resources.w_light
        PictureBox2.BackgroundImage = My.Resources.e_light
        PictureBox3.BackgroundImage = My.Resources.b_light
        If My.Settings.UniversalAccFileURLs = True Then
            UniversalAccFileURLs.BackgroundImage = My.Resources.green_slider
            UniversalAccFileURLs.Tag = "ON"
        Else
            UniversalAccFileURLs.BackgroundImage = My.Resources.red_slider
            UniversalAccFileURLs.Tag = "OFF"
        End If
        If My.Settings.FileAccURLs = True Then
            FileAccURLs.BackgroundImage = My.Resources.green_slider
            FileAccURLs.Tag = "ON"
        Else
            FileAccURLs.BackgroundImage = My.Resources.red_slider
            FileAccURLs.Tag = "OFF"
        End If
        If My.Settings.Java = True Then
            Java.BackgroundImage = My.Resources.green_slider
            Java.Tag = "ON"
        Else
            Java.BackgroundImage = My.Resources.red_slider
            Java.Tag = "OFF"
        End If
        If My.Settings.Javascript = True Then
            JavaScript.BackgroundImage = My.Resources.green_slider
            JavaScript.Tag = "ON"
        Else
            JavaScript.BackgroundImage = My.Resources.red_slider
            JavaScript.Tag = "OFF"
        End If
        If My.Settings.JSDomPaste = True Then
            JSDomPaste.BackgroundImage = My.Resources.green_slider
            JSDomPaste.Tag = "ON"
        Else
            JSDomPaste.BackgroundImage = My.Resources.red_slider
            JSDomPaste.Tag = "OFF"
        End If
        If My.Settings.JSOpenWindows = True Then
            JSOpenWindows.BackgroundImage = My.Resources.green_slider
            JSOpenWindows.Tag = "ON"
        Else
            JSOpenWindows.BackgroundImage = My.Resources.red_slider
            JSOpenWindows.Tag = "OFF"
        End If
        If My.Settings.JSCloseWindows = True Then
            JSCloseWindows.BackgroundImage = My.Resources.green_slider
            JSCloseWindows.Tag = "ON"
        Else
            JSCloseWindows.BackgroundImage = My.Resources.red_slider
            JSCloseWindows.Tag = "OFF"
        End If
        If My.Settings.JSAccClipboard = True Then
            JSAccClipboard.BackgroundImage = My.Resources.green_slider
            JSAccClipboard.Tag = "ON"
        Else
            JSAccClipboard.BackgroundImage = My.Resources.red_slider
            JSAccClipboard.Tag = "OFF"
        End If
        If My.Settings.WebGL = True Then
            WebGL.BackgroundImage = My.Resources.green_slider
            WebGL.Tag = "ON"
        Else
            WebGL.BackgroundImage = My.Resources.red_slider
            WebGL.Tag = "OFF"
        End If
        If My.Settings.LocalStorage = True Then
            LocalStorage.BackgroundImage = My.Resources.green_slider
            LocalStorage.Tag = "ON"
        Else
            LocalStorage.BackgroundImage = My.Resources.red_slider
            LocalStorage.Tag = "OFF"
        End If
        If My.Settings.LoadImages = True Then
            LoadImages.BackgroundImage = My.Resources.green_slider
            LoadImages.Tag = "ON"
        Else
            LoadImages.BackgroundImage = My.Resources.red_slider
            LoadImages.Tag = "OFF"
        End If
        If My.Settings.Plugins = True Then
            Plugins.BackgroundImage = My.Resources.green_slider
            Plugins.Tag = "ON"
        Else
            Plugins.BackgroundImage = My.Resources.red_slider
            Plugins.Tag = "OFF"
        End If
        If My.Settings.Cache = True Then
            Cache.BackgroundImage = My.Resources.green_slider
            Cache.Tag = "ON"
        Else
            Cache.BackgroundImage = My.Resources.red_slider
            Cache.Tag = "OFF"
        End If
        If My.Settings.LoadRemoteFonts = True Then
            LoadRemoteFonts.BackgroundImage = My.Resources.green_slider
            LoadRemoteFonts.Tag = "ON"
        Else
            LoadRemoteFonts.BackgroundImage = My.Resources.red_slider
            LoadRemoteFonts.Tag = "OFF"
        End If
        If My.Settings.WebSecurity = True Then
            WebSecurity.BackgroundImage = My.Resources.green_slider
            WebSecurity.Tag = "ON"
        Else
            WebSecurity.BackgroundImage = My.Resources.red_slider
            WebSecurity.Tag = "OFF"
        End If
    End Sub
    Private Sub WebSecurity_Click(sender As Object, e As EventArgs) Handles WebSecurity.Click
        If WebSecurity.Tag = "ON" Then
            GroupBox1.Visible = True
            Timer1.Start()
        Else
            If WebSecurity.Tag = "OFF" Then
                My.Settings.WebSecurity = True
                WebSecurity.BackgroundImage = My.Resources.green_slider
                WebSecurity.Tag = "ON"
            End If
        End If
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If My.Settings.epressed = True And My.Settings.wpressed = True And My.Settings.bpressed = True Then
            Me.Timer1.Stop()
            My.Settings.WebSecurity = False
            GroupBox1.Visible = False
            WebSecurity.Tag = "OFF"
            WebSecurity.BackgroundImage = My.Resources.red_slider
            My.Settings.epressed = False
            My.Settings.wpressed = False
            My.Settings.bpressed = False
            PictureBox1.BackgroundImage = My.Resources.w_light
            PictureBox2.BackgroundImage = My.Resources.e_light
            PictureBox3.BackgroundImage = My.Resources.b_light
        End If
    End Sub

    Private Sub UniversalAccFileURLs_Click(sender As Object, e As EventArgs) Handles UniversalAccFileURLs.Click
        If UniversalAccFileURLs.Tag = "ON" Then
            My.Settings.UniversalAccFileURLs = False
            UniversalAccFileURLs.BackgroundImage = My.Resources.red_slider
            UniversalAccFileURLs.Tag = "OFF"
            My.Settings.Save()
        Else
            If UniversalAccFileURLs.Tag = "OFF" Then
                My.Settings.UniversalAccFileURLs = True
                UniversalAccFileURLs.BackgroundImage = My.Resources.green_slider
                UniversalAccFileURLs.Tag = "ON"
                My.Settings.Save()
            End If
        End If
    End Sub

    Private Sub FileAccURLs_Click(sender As Object, e As EventArgs) Handles FileAccURLs.Click
        If FileAccURLs.Tag = "ON" Then
            My.Settings.FileAccURLs = False
            FileAccURLs.BackgroundImage = My.Resources.red_slider
            FileAccURLs.Tag = "OFF"
            My.Settings.Save()
        Else
            If FileAccURLs.Tag = "OFF" Then
                My.Settings.FileAccURLs = True
                FileAccURLs.BackgroundImage = My.Resources.green_slider
                FileAccURLs.Tag = "ON"
                My.Settings.Save()
            End If
        End If
    End Sub

    Private Sub Java_Click(sender As Object, e As EventArgs) Handles Java.Click
        If Java.Tag = "ON" Then
            My.Settings.Java = False
            Java.BackgroundImage = My.Resources.red_slider
            Java.Tag = "OFF"
            My.Settings.Save()
        Else
            If Java.Tag = "OFF" Then
                My.Settings.Java = True
                Java.BackgroundImage = My.Resources.green_slider
                Java.Tag = "ON"
                My.Settings.Save()
            End If
        End If
    End Sub

    Private Sub JavaScript_Click(sender As Object, e As EventArgs) Handles JavaScript.Click
        If JavaScript.Tag = "ON" Then
            My.Settings.JavaScript = False
            JavaScript.BackgroundImage = My.Resources.red_slider
            JavaScript.Tag = "OFF"
            My.Settings.Save()
        Else
            If JavaScript.Tag = "OFF" Then
                My.Settings.JavaScript = True
                JavaScript.BackgroundImage = My.Resources.green_slider
                JavaScript.Tag = "ON"
                My.Settings.Save()
            End If
        End If
    End Sub

    Private Sub JSDomPaste_Click(sender As Object, e As EventArgs) Handles JSDomPaste.Click
        If JSDomPaste.Tag = "ON" Then
            My.Settings.JSDomPaste = False
            JSDomPaste.BackgroundImage = My.Resources.red_slider
            JSDomPaste.Tag = "OFF"
            My.Settings.Save()
        Else
            If JSDomPaste.Tag = "OFF" Then
                My.Settings.JSDomPaste = True
                JSDomPaste.BackgroundImage = My.Resources.green_slider
                JSDomPaste.Tag = "ON"
                My.Settings.Save()
            End If
        End If
    End Sub

    Private Sub JSOpenWindows_Click(sender As Object, e As EventArgs) Handles JSOpenWindows.Click
        If JSOpenWindows.Tag = "ON" Then
            My.Settings.JSOpenWindows = False
            JSOpenWindows.BackgroundImage = My.Resources.red_slider
            JSOpenWindows.Tag = "OFF"
            My.Settings.Save()
        Else
            If JSOpenWindows.Tag = "OFF" Then
                My.Settings.JSOpenWindows = True
                JSOpenWindows.BackgroundImage = My.Resources.green_slider
                JSOpenWindows.Tag = "ON"
                My.Settings.Save()
            End If
        End If
    End Sub

    Private Sub JSCloseWindows_Click(sender As Object, e As EventArgs) Handles JSCloseWindows.Click
        If JSCloseWindows.Tag = "ON" Then
            JSCloseWindows.Tag = "OFF"
            My.Settings.JSCloseWindows = False
            JSCloseWindows.BackgroundImage = My.Resources.red_slider
            My.Settings.Save()
        Else
            If JSCloseWindows.Tag = "OFF" Then
                JSCloseWindows.Tag = "ON"
                My.Settings.JSCloseWindows = True
                JSCloseWindows.BackgroundImage = My.Resources.green_slider
                My.Settings.Save()
            End If
        End If
    End Sub

    Private Sub JSAccClipboard_Click(sender As Object, e As EventArgs) Handles JSAccClipboard.Click
        If JSAccClipboard.Tag = "ON" Then
            My.Settings.JSAccClipboard = False
            JSAccClipboard.BackgroundImage = My.Resources.red_slider
            JSAccClipboard.Tag = "OFF"
            My.Settings.Save()
        Else
            If JSAccClipboard.Tag = "OFF" Then
                My.Settings.JSAccClipboard = True
                JSAccClipboard.BackgroundImage = My.Resources.green_slider
                JSAccClipboard.Tag = "ON"
                My.Settings.Save()
            End If
        End If
    End Sub

    Private Sub WebGL_Click(sender As Object, e As EventArgs) Handles WebGL.Click
        If WebGL.Tag = "ON" Then
            My.Settings.WebGL = False
            WebGL.BackgroundImage = My.Resources.red_slider
            WebGL.Tag = "OFF"
            My.Settings.Save()
        Else
            If WebGL.Tag = "OFF" Then
                My.Settings.WebGL = True
                WebGL.BackgroundImage = My.Resources.green_slider
                WebGL.Tag = "ON"
                My.Settings.Save()
            End If
        End If
    End Sub

    Private Sub LocalStorage_Click(sender As Object, e As EventArgs) Handles LocalStorage.Click
        If LocalStorage.Tag = "ON" Then
            My.Settings.LocalStorage = False
            LocalStorage.BackgroundImage = My.Resources.red_slider
            LocalStorage.Tag = "OFF"
            My.Settings.Save()
        Else
            If LocalStorage.Tag = "OFF" Then
                My.Settings.LocalStorage = True
                LocalStorage.BackgroundImage = My.Resources.green_slider
                LocalStorage.Tag = "ON"
                My.Settings.Save()
            End If
        End If
    End Sub

    Private Sub LoadImages_Click(sender As Object, e As EventArgs) Handles LoadImages.Click
        If LoadImages.Tag = "ON" Then
            My.Settings.LoadImages = False
            LoadImages.BackgroundImage = My.Resources.red_slider
            LoadImages.Tag = "OFF"
            My.Settings.Save()
        Else
            If LoadImages.Tag = "OFF" Then
                My.Settings.LoadImages = True
                LoadImages.BackgroundImage = My.Resources.green_slider
                LoadImages.Tag = "ON"
                My.Settings.Save()
            End If
        End If
    End Sub

    Private Sub Plugins_Click(sender As Object, e As EventArgs) Handles Plugins.Click
        If Plugins.Tag = "ON" Then
            My.Settings.Plugins = False
            Plugins.BackgroundImage = My.Resources.red_slider
            Plugins.Tag = "OFF"
            My.Settings.Save()
        Else
            If Plugins.Tag = "OFF" Then
                My.Settings.Plugins = True
                Plugins.BackgroundImage = My.Resources.green_slider
                Plugins.Tag = "ON"
                My.Settings.Save()
            End If
        End If
    End Sub

    Private Sub Cache_Click(sender As Object, e As EventArgs) Handles Cache.Click
        If Cache.Tag = "ON" Then
            My.Settings.Cache = False
            Cache.BackgroundImage = My.Resources.red_slider
            Cache.Tag = "OFF"
            My.Settings.Save()
        Else
            If Cache.Tag = "OFF" Then
                My.Settings.Cache = True
                Cache.BackgroundImage = My.Resources.green_slider
                Cache.Tag = "ON"
                My.Settings.Save()
            End If
        End If
    End Sub

    Private Sub LoadRemoteFonts_Click(sender As Object, e As EventArgs) Handles LoadRemoteFonts.Click
        If LoadRemoteFonts.Tag = "ON" Then
            My.Settings.LoadRemoteFonts = False
            LoadRemoteFonts.BackgroundImage = My.Resources.red_slider
            LoadRemoteFonts.Tag = "OFF"
            My.Settings.Save()
        Else
            If LoadRemoteFonts.Tag = "OFF" Then
                My.Settings.LoadRemoteFonts = True
                LoadRemoteFonts.BackgroundImage = My.Resources.green_slider
                LoadRemoteFonts.Tag = "ON"
                My.Settings.Save()
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        GroupBox1.Visible = False

    End Sub
End Class