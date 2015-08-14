Imports System.ComponentModel
Imports CefSharp
Imports Opaque.RequestHandler

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tabs
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(tabs))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.favicon = New System.Windows.Forms.PictureBox()
        Me.stopbtn = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.qab = New System.Windows.Forms.PictureBox()
        Me.brrefresh = New System.Windows.Forms.PictureBox()
        Me.forward = New System.Windows.Forms.PictureBox()
        Me.home = New System.Windows.Forms.PictureBox()
        Me.back = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.qabbox = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.share = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.QuickNote = New System.Windows.Forms.TextBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.BFControl = New System.Windows.Forms.Timer(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.BackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ForwardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1.SuspendLayout()
        CType(Me.favicon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.stopbtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.qab, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.brrefresh, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.forward, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.home, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.back, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.qabbox.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.share, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.favicon)
        Me.Panel1.Controls.Add(Me.stopbtn)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.qab)
        Me.Panel1.Controls.Add(Me.brrefresh)
        Me.Panel1.Controls.Add(Me.forward)
        Me.Panel1.Controls.Add(Me.home)
        Me.Panel1.Controls.Add(Me.back)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1057, 47)
        Me.Panel1.TabIndex = 0
        '
        'favicon
        '
        Me.favicon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.favicon.Location = New System.Drawing.Point(131, 10)
        Me.favicon.Name = "favicon"
        Me.favicon.Size = New System.Drawing.Size(28, 28)
        Me.favicon.TabIndex = 6
        Me.favicon.TabStop = False
        '
        'stopbtn
        '
        Me.stopbtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.stopbtn.BackgroundImage = CType(resources.GetObject("stopbtn.BackgroundImage"), System.Drawing.Image)
        Me.stopbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.stopbtn.Location = New System.Drawing.Point(972, 3)
        Me.stopbtn.Name = "stopbtn"
        Me.stopbtn.Size = New System.Drawing.Size(40, 40)
        Me.stopbtn.TabIndex = 5
        Me.stopbtn.TabStop = False
        Me.stopbtn.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(932, -8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(1, 1)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "GO"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Location = New System.Drawing.Point(164, 14)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(802, 20)
        Me.TextBox1.TabIndex = 1
        '
        'qab
        '
        Me.qab.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.qab.BackgroundImage = CType(resources.GetObject("qab.BackgroundImage"), System.Drawing.Image)
        Me.qab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.qab.Location = New System.Drawing.Point(1014, 3)
        Me.qab.Name = "qab"
        Me.qab.Size = New System.Drawing.Size(40, 40)
        Me.qab.TabIndex = 4
        Me.qab.TabStop = False
        '
        'brrefresh
        '
        Me.brrefresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.brrefresh.BackgroundImage = CType(resources.GetObject("brrefresh.BackgroundImage"), System.Drawing.Image)
        Me.brrefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.brrefresh.Location = New System.Drawing.Point(972, 3)
        Me.brrefresh.Name = "brrefresh"
        Me.brrefresh.Size = New System.Drawing.Size(40, 40)
        Me.brrefresh.TabIndex = 3
        Me.brrefresh.TabStop = False
        '
        'forward
        '
        Me.forward.BackgroundImage = CType(resources.GetObject("forward.BackgroundImage"), System.Drawing.Image)
        Me.forward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.forward.Location = New System.Drawing.Point(87, 3)
        Me.forward.Name = "forward"
        Me.forward.Size = New System.Drawing.Size(40, 40)
        Me.forward.TabIndex = 2
        Me.forward.TabStop = False
        '
        'home
        '
        Me.home.BackgroundImage = CType(resources.GetObject("home.BackgroundImage"), System.Drawing.Image)
        Me.home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.home.Location = New System.Drawing.Point(45, 3)
        Me.home.Name = "home"
        Me.home.Size = New System.Drawing.Size(40, 40)
        Me.home.TabIndex = 1
        Me.home.TabStop = False
        '
        'back
        '
        Me.back.BackgroundImage = CType(resources.GetObject("back.BackgroundImage"), System.Drawing.Image)
        Me.back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.back.Location = New System.Drawing.Point(3, 3)
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(40, 40)
        Me.back.TabIndex = 0
        Me.back.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.qabbox)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 47)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1057, 647)
        Me.Panel2.TabIndex = 1
        '
        'qabbox
        '
        Me.qabbox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.qabbox.BackColor = System.Drawing.Color.White
        Me.qabbox.Controls.Add(Me.GroupBox1)
        Me.qabbox.Controls.Add(Me.PictureBox2)
        Me.qabbox.Controls.Add(Me.share)
        Me.qabbox.Controls.Add(Me.GroupBox2)
        Me.qabbox.Controls.Add(Me.PictureBox7)
        Me.qabbox.Controls.Add(Me.PictureBox6)
        Me.qabbox.Location = New System.Drawing.Point(767, 0)
        Me.qabbox.Name = "qabbox"
        Me.qabbox.Size = New System.Drawing.Size(290, 364)
        Me.qabbox.TabIndex = 0
        Me.qabbox.TabStop = False
        Me.qabbox.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.PictureBox3)
        Me.GroupBox1.Controls.Add(Me.PictureBox4)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 363)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(281, 141)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Share"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(211, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Print"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(186, 40)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(79, 79)
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(44, 14)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(224, 20)
        Me.TextBox2.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(113, 121)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Copy URL"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Twitter"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "URL:"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox3.Location = New System.Drawing.Point(16, 40)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(79, 79)
        Me.PictureBox3.TabIndex = 12
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackgroundImage = CType(resources.GetObject("PictureBox4.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox4.Location = New System.Drawing.Point(101, 40)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(79, 79)
        Me.PictureBox4.TabIndex = 13
        Me.PictureBox4.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Location = New System.Drawing.Point(4, 305)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(52, 52)
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'share
        '
        Me.share.BackgroundImage = CType(resources.GetObject("share.BackgroundImage"), System.Drawing.Image)
        Me.share.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.share.Location = New System.Drawing.Point(235, 306)
        Me.share.Name = "share"
        Me.share.Size = New System.Drawing.Size(52, 52)
        Me.share.TabIndex = 3
        Me.share.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.QuickNote)
        Me.GroupBox2.Location = New System.Drawing.Point(0, 140)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(290, 159)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "QuickNote"
        '
        'QuickNote
        '
        Me.QuickNote.Location = New System.Drawing.Point(6, 15)
        Me.QuickNote.Multiline = True
        Me.QuickNote.Name = "QuickNote"
        Me.QuickNote.Size = New System.Drawing.Size(278, 138)
        Me.QuickNote.TabIndex = 0
        '
        'PictureBox7
        '
        Me.PictureBox7.BackgroundImage = CType(resources.GetObject("PictureBox7.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox7.Location = New System.Drawing.Point(148, 6)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(136, 131)
        Me.PictureBox7.TabIndex = 1
        Me.PictureBox7.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackgroundImage = CType(resources.GetObject("PictureBox6.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox6.Location = New System.Drawing.Point(6, 6)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(136, 131)
        Me.PictureBox6.TabIndex = 0
        Me.PictureBox6.TabStop = False
        '
        'BFControl
        '
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BackToolStripMenuItem, Me.HomeToolStripMenuItem, Me.ForwardToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(118, 70)
        '
        'BackToolStripMenuItem
        '
        Me.BackToolStripMenuItem.Name = "BackToolStripMenuItem"
        Me.BackToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.BackToolStripMenuItem.Text = "Back"
        '
        'HomeToolStripMenuItem
        '
        Me.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        Me.HomeToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.HomeToolStripMenuItem.Text = "Home"
        '
        'ForwardToolStripMenuItem
        '
        Me.ForwardToolStripMenuItem.Name = "ForwardToolStripMenuItem"
        Me.ForwardToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.ForwardToolStripMenuItem.Text = "Forward"
        '
        'tabs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1057, 694)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "tabs"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "tab"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.favicon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.stopbtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.qab, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.brrefresh, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.forward, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.home, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.back, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.qabbox.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.share, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Private m_IsInDesignMode As Boolean = True
    Public Sub New()
        'Initializing CEF
        InitializeComponent()
        'Required to construct browsing engine
        m_IsInDesignMode = (LicenseManager.UsageMode = LicenseUsageMode.Designtime)
        Try
            If My.Settings.ClearCache = True Then
                If My.Settings.CacheLocation = "DEFAULT" Then
                    My.Settings.ClearCache = False
                    My.Settings.Save()
                    Dim appcachepath As String = Application.StartupPath & "/cache/"
                    System.IO.Directory.Delete(appcachepath, True)
                Else
                    My.Settings.ClearCache = False
                    Dim appcachepath As String = My.Settings.CacheLocation
                    System.IO.Directory.Delete(appcachepath, True)
                End If
            End If
        Catch ex As Exception
            MsgBox("The cache could not be completely cleared.")
        End Try

        'Load browser settings
        Dim brsettings As New CefSharp.BrowserSettings
        If My.Settings.LoadImages = True Then
            brsettings.ImageLoadingDisabled = False
        Else
            If My.Settings.LoadImages = False Then
                brsettings.ImageLoadingDisabled = True
            End If
        End If
        If My.Settings.UniversalAccFileURLs = True Then
            brsettings.UniversalAccessFromFileUrlsAllowed = True
        Else
            If My.Settings.UniversalAccFileURLs = False Then
                brsettings.UniversalAccessFromFileUrlsAllowed = False
            End If
        End If
        If My.Settings.FileAccURLs = True Then
            brsettings.FileAccessFromFileUrlsAllowed = True
        Else
            If My.Settings.FileAccURLs = False Then
                brsettings.FileAccessFromFileUrlsAllowed = False
            End If
        End If
        If My.Settings.Java = True Then
            brsettings.JavaDisabled = False
        Else
            If My.Settings.Java = False Then
                brsettings.JavaDisabled = True
            End If
        End If
        If My.Settings.Javascript = True Then
            brsettings.JavascriptDisabled = False
        Else
            If My.Settings.Javascript = False Then
                brsettings.JavascriptDisabled = True
            End If
        End If
        If My.Settings.JSDomPaste = True Then
            brsettings.JavascriptDomPasteDisabled = False
        Else
            If My.Settings.JSDomPaste = False Then
                brsettings.JavascriptDomPasteDisabled = True
            End If
        End If
        If My.Settings.JSOpenWindows = True Then
            brsettings.JavaScriptOpenWindowsDisabled = False
        Else
            If My.Settings.JSOpenWindows = False Then
                brsettings.JavaScriptOpenWindowsDisabled = True
            End If
        End If
        If My.Settings.JSCloseWindows = True Then
            brsettings.JavaScriptCloseWindowsDisabled = False
        Else
            If My.Settings.JSCloseWindows = False Then
                brsettings.JavaScriptCloseWindowsDisabled = True
            End If
        End If
        If My.Settings.JSAccClipboard = True Then
            brsettings.JavaScriptAccessClipboardDisabled = False
        Else
            If My.Settings.JSAccClipboard = False Then
                brsettings.JavaScriptAccessClipboardDisabled = True
            End If
        End If
        If My.Settings.WebGL = True Then
            brsettings.WebGlDisabled = False
        Else
            If My.Settings.WebGL = False Then
                brsettings.WebGlDisabled = True
            End If
        End If
        If My.Settings.LocalStorage = True Then
            brsettings.LocalStorageDisabled = False
        Else
            If My.Settings.LocalStorage = False Then
                brsettings.LocalStorageDisabled = True
            End If
        End If
        If My.Settings.Plugins = True Then
            brsettings.PluginsDisabled = False
        Else
            If My.Settings.Plugins = False Then
                brsettings.PluginsDisabled = True
            End If
        End If
        If My.Settings.Cache = True Then
            brsettings.ApplicationCacheDisabled = False
        Else
            If My.Settings.Cache = False Then
                brsettings.ApplicationCacheDisabled = True
            End If
        End If
        If My.Settings.LoadRemoteFonts = True Then
            brsettings.RemoteFontsDisabled = False
        Else
            If My.Settings.LoadRemoteFonts = False Then
                brsettings.RemoteFontsDisabled = True
            End If
        End If


        Dim osversion As String = My.Computer.Info.OSVersion.ToString
        Dim answer As String = osversion.Substring(0, 3)
        Dim cefsettings As New CefSharp.CefSettings
        cefsettings.UserAgent = ("Mozilla/5.0 (Windows NT " & answer & ") AppleWebKit/537.36 (KHTML, like Gecko) Opaque/1.0.1 Chrome/41.0.2272.104 Safari/537.36")
        cefsettings.IgnoreCertificateErrors = False
        cefsettings.LogSeverity = CefSharp.LogSeverity.Disable
        'cefsettings.RegisterScheme(New CefCustomScheme() With { _
        '.SchemeName = LocalSchemeHandlerFactory.SchemeName, _
        '.SchemeHandlerFactory = New LocalSchemeHandlerFactory() _
        '})
        If My.Settings.CacheLocation = "DEFAULT" Then
            Dim appcachepath As String = Application.StartupPath & "/cache/"
            cefsettings.CachePath = appcachepath
        Else
            cefsettings.CachePath = My.Settings.CacheLocation
        End If
        CefSharp.Cef.Initialize(cefsettings)

        Try
            Me.browser = New CefSharp.WinForms.ChromiumWebBrowser(My.Settings.newpage)
            Me.browser.Size = New System.Drawing.Size(1041, 620)
            Me.browser.Location = New System.Drawing.Point(0, 0)
            Me.browser.BrowserSettings = brsettings
            Me.browser.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Panel2.Controls.Add(Me.browser)
            Me.browser.Dock = DockStyle.Fill
            Me.browser.Focus()
            browser.DownloadHandler = New DownloadHandler
            browser.LifeSpanHandler = New LifeSpanHandler
            'browser.RequestHandler = New RequestHandler
            'browser.MenuHandler = New MenuHandler
            'Me.browser.FocusHandler = vbNull.

        Catch ex As Exception
            MsgBox("There was an error initializing Opaque. Please reinstall Opaque. Error details will come up next.")
            MsgBox(ex.Message)
        End Try
    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents qab As System.Windows.Forms.PictureBox
    Friend WithEvents brrefresh As System.Windows.Forms.PictureBox
    Friend WithEvents forward As System.Windows.Forms.PictureBox
    Friend WithEvents home As System.Windows.Forms.PictureBox
    Friend WithEvents back As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents qabbox As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents QuickNote As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents BFControl As System.Windows.Forms.Timer
    Friend WithEvents share As System.Windows.Forms.PictureBox
    Friend WithEvents stopbtn As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents BackToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HomeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ForwardToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents favicon As System.Windows.Forms.PictureBox
End Class
