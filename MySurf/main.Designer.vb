Imports System.ComponentModel

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(main))
        Me.placeholder = New System.Windows.Forms.PictureBox()
        Me.backbtn = New System.Windows.Forms.Button()
        Me.homebtn = New System.Windows.Forms.Button()
        Me.forwardbtn = New System.Windows.Forms.Button()
        Me.addressbar = New System.Windows.Forms.TextBox()
        Me.bookmarksbtn = New System.Windows.Forms.Button()
        Me.refreshbtn = New System.Windows.Forms.Button()
        Me.quicksettingsbtn = New System.Windows.Forms.Button()
        Me.favicon = New System.Windows.Forms.PictureBox()
        Me.go = New System.Windows.Forms.Button()
        CType(Me.placeholder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.favicon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'placeholder
        '
        Me.placeholder.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.placeholder.BackgroundImage = CType(resources.GetObject("placeholder.BackgroundImage"), System.Drawing.Image)
        Me.placeholder.Location = New System.Drawing.Point(0, 37)
        Me.placeholder.Name = "placeholder"
        Me.placeholder.Size = New System.Drawing.Size(1041, 620)
        Me.placeholder.TabIndex = 0
        Me.placeholder.TabStop = False
        Me.placeholder.Visible = False
        '
        'backbtn
        '
        Me.backbtn.BackgroundImage = CType(resources.GetObject("backbtn.BackgroundImage"), System.Drawing.Image)
        Me.backbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.backbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.backbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 1.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.backbtn.ForeColor = System.Drawing.SystemColors.Control
        Me.backbtn.Location = New System.Drawing.Point(0, 0)
        Me.backbtn.Name = "backbtn"
        Me.backbtn.Size = New System.Drawing.Size(38, 37)
        Me.backbtn.TabIndex = 1
        Me.backbtn.UseVisualStyleBackColor = True
        '
        'homebtn
        '
        Me.homebtn.BackgroundImage = CType(resources.GetObject("homebtn.BackgroundImage"), System.Drawing.Image)
        Me.homebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.homebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.homebtn.ForeColor = System.Drawing.SystemColors.Control
        Me.homebtn.Location = New System.Drawing.Point(38, 0)
        Me.homebtn.Name = "homebtn"
        Me.homebtn.Size = New System.Drawing.Size(38, 37)
        Me.homebtn.TabIndex = 2
        Me.homebtn.UseVisualStyleBackColor = True
        '
        'forwardbtn
        '
        Me.forwardbtn.BackgroundImage = CType(resources.GetObject("forwardbtn.BackgroundImage"), System.Drawing.Image)
        Me.forwardbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.forwardbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.forwardbtn.ForeColor = System.Drawing.SystemColors.Control
        Me.forwardbtn.Location = New System.Drawing.Point(76, 0)
        Me.forwardbtn.Name = "forwardbtn"
        Me.forwardbtn.Size = New System.Drawing.Size(38, 37)
        Me.forwardbtn.TabIndex = 3
        Me.forwardbtn.UseVisualStyleBackColor = True
        '
        'addressbar
        '
        Me.addressbar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.addressbar.Location = New System.Drawing.Point(137, 9)
        Me.addressbar.Name = "addressbar"
        Me.addressbar.Size = New System.Drawing.Size(780, 20)
        Me.addressbar.TabIndex = 4
        '
        'bookmarksbtn
        '
        Me.bookmarksbtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bookmarksbtn.BackgroundImage = CType(resources.GetObject("bookmarksbtn.BackgroundImage"), System.Drawing.Image)
        Me.bookmarksbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.bookmarksbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bookmarksbtn.ForeColor = System.Drawing.SystemColors.Control
        Me.bookmarksbtn.Location = New System.Drawing.Point(923, 0)
        Me.bookmarksbtn.Name = "bookmarksbtn"
        Me.bookmarksbtn.Size = New System.Drawing.Size(38, 37)
        Me.bookmarksbtn.TabIndex = 5
        Me.bookmarksbtn.UseVisualStyleBackColor = True
        '
        'refreshbtn
        '
        Me.refreshbtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.refreshbtn.BackgroundImage = CType(resources.GetObject("refreshbtn.BackgroundImage"), System.Drawing.Image)
        Me.refreshbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.refreshbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.refreshbtn.ForeColor = System.Drawing.SystemColors.Control
        Me.refreshbtn.Location = New System.Drawing.Point(962, 0)
        Me.refreshbtn.Name = "refreshbtn"
        Me.refreshbtn.Size = New System.Drawing.Size(38, 37)
        Me.refreshbtn.TabIndex = 6
        Me.refreshbtn.UseVisualStyleBackColor = True
        '
        'quicksettingsbtn
        '
        Me.quicksettingsbtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.quicksettingsbtn.BackgroundImage = CType(resources.GetObject("quicksettingsbtn.BackgroundImage"), System.Drawing.Image)
        Me.quicksettingsbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.quicksettingsbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.quicksettingsbtn.ForeColor = System.Drawing.SystemColors.Control
        Me.quicksettingsbtn.Location = New System.Drawing.Point(1001, 0)
        Me.quicksettingsbtn.Name = "quicksettingsbtn"
        Me.quicksettingsbtn.Size = New System.Drawing.Size(38, 37)
        Me.quicksettingsbtn.TabIndex = 7
        Me.quicksettingsbtn.UseVisualStyleBackColor = True
        '
        'favicon
        '
        Me.favicon.Location = New System.Drawing.Point(117, 9)
        Me.favicon.Name = "favicon"
        Me.favicon.Size = New System.Drawing.Size(20, 20)
        Me.favicon.TabIndex = 14
        Me.favicon.TabStop = False
        '
        'go
        '
        Me.go.Location = New System.Drawing.Point(410, -4)
        Me.go.Name = "go"
        Me.go.Size = New System.Drawing.Size(0, 0)
        Me.go.TabIndex = 15
        Me.go.Text = "Go"
        Me.go.UseVisualStyleBackColor = True
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1041, 655)
        Me.Controls.Add(Me.go)
        Me.Controls.Add(Me.favicon)
        Me.Controls.Add(Me.quicksettingsbtn)
        Me.Controls.Add(Me.refreshbtn)
        Me.Controls.Add(Me.bookmarksbtn)
        Me.Controls.Add(Me.addressbar)
        Me.Controls.Add(Me.forwardbtn)
        Me.Controls.Add(Me.homebtn)
        Me.Controls.Add(Me.backbtn)
        Me.Controls.Add(Me.placeholder)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(356, 300)
        Me.Name = "main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MySurf"
        CType(Me.placeholder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.favicon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private m_IsInDesignMode As Boolean = True
    Public Sub New()
        'Initializing CEF
        InitializeComponent()
        'Required to construct browsing engine
        m_IsInDesignMode = (LicenseManager.UsageMode = LicenseUsageMode.Designtime)
        'Get OS Name
        Dim osversion As String
        osversion = My.Computer.Info.OSFullName.ToString
        'Configure MySurf's Engine
        '
        '
        'Give users more control of their browser here!
        '
        '
        Dim cefsettings As New CefSharp.CefSettings
        cefsettings.UserAgent = ("Mozilla/5.0 (" & osversion & "; AppleWebKit/537.36 (KHTML, like Gecko) MySurf/3.0 (Stable)")
        cefsettings.IgnoreCertificateErrors = False
        cefsettings.LogSeverity = CefSharp.LogSeverity.Disable


        'Configure more of MySurf's engine
        Dim brsettings As New CefSharp.BrowserSettings

        'Constructs the engine
        CefSharp.Cef.Initialize(cefsettings)

        Try
            Me.browser = New CefSharp.WinForms.ChromiumWebBrowser(My.Settings.homepage)
            browser.BrowserSettings = brsettings
            Me.browser.Size = New System.Drawing.Size(1041, 620)
            Me.browser.Location = New System.Drawing.Point(0, 37)
            Me.browser.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Controls.Add(Me.browser)
        Catch ex As Exception
            MsgBox("There was an error initializing MySurf. Please reinstall MySurf. Error details will come up next.")
            MsgBox(ex.Message)
        End Try
    End Sub
    Friend WithEvents placeholder As System.Windows.Forms.PictureBox
    Friend WithEvents backbtn As System.Windows.Forms.Button
    Friend WithEvents homebtn As System.Windows.Forms.Button
    Friend WithEvents forwardbtn As System.Windows.Forms.Button
    Friend WithEvents addressbar As System.Windows.Forms.TextBox
    Friend WithEvents bookmarksbtn As System.Windows.Forms.Button
    Friend WithEvents refreshbtn As System.Windows.Forms.Button
    Friend WithEvents quicksettingsbtn As System.Windows.Forms.Button
    Friend WithEvents favicon As System.Windows.Forms.PictureBox
    Friend WithEvents go As System.Windows.Forms.Button

End Class
