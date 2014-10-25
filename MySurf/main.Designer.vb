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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(main))
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.qsb = New System.Windows.Forms.GroupBox()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.go = New System.Windows.Forms.Button()
        Me.url = New System.Windows.Forms.Timer(Me.components)
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ChromeWebBrowser1 = New Sashulin.ChromeWebBrowser()
        Me.home = New System.Windows.Forms.Button()
        Me.forward = New System.Windows.Forms.Button()
        Me.back = New System.Windows.Forms.Button()
        Me.fav = New System.Windows.Forms.Button()
        Me.quickbar = New System.Windows.Forms.Button()
        Me.refreshbtn = New System.Windows.Forms.Button()
        Me.ALgoogle = New System.Windows.Forms.Timer(Me.components)
        Me.qsb.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Location = New System.Drawing.Point(137, 11)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(780, 20)
        Me.TextBox1.TabIndex = 4
        Me.TextBox1.Text = "http://"
        '
        'qsb
        '
        Me.qsb.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.qsb.Controls.Add(Me.Button8)
        Me.qsb.Controls.Add(Me.TextBox3)
        Me.qsb.Controls.Add(Me.Button5)
        Me.qsb.Controls.Add(Me.Button6)
        Me.qsb.Controls.Add(Me.Button2)
        Me.qsb.Controls.Add(Me.Button1)
        Me.qsb.Location = New System.Drawing.Point(796, 46)
        Me.qsb.Name = "qsb"
        Me.qsb.Size = New System.Drawing.Size(245, 339)
        Me.qsb.TabIndex = 7
        Me.qsb.TabStop = False
        Me.qsb.Text = "Quick Actions"
        Me.qsb.Visible = False
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(87, 310)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(66, 23)
        Me.Button8.TabIndex = 12
        Me.Button8.Text = "Dev Tool"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(6, 144)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(233, 160)
        Me.TextBox3.TabIndex = 11
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(6, 310)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(77, 23)
        Me.Button5.TabIndex = 10
        Me.Button5.Text = "Clear Cache"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(157, 310)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(82, 23)
        Me.Button6.TabIndex = 9
        Me.Button6.Text = "Clear Cookies"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.SystemColors.Control
        Me.Button2.Location = New System.Drawing.Point(128, 19)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(109, 131)
        Me.Button2.TabIndex = 7
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.SystemColors.Control
        Me.Button1.Location = New System.Drawing.Point(9, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(109, 131)
        Me.Button1.TabIndex = 6
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(706, 46)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(245, 333)
        Me.TabControl1.TabIndex = 11
        Me.TabControl1.Visible = False
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.TextBox2)
        Me.TabPage1.Controls.Add(Me.Button4)
        Me.TabPage1.Controls.Add(Me.Button3)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(237, 307)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Add Bookmark"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Added!"
        Me.Label3.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "URL:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(0, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(207, 39)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "To add a bookmark, enter the URL below," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "or click current page to get the current" & _
    "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "page address."
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(6, 75)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(225, 20)
        Me.TextBox2.TabIndex = 2
        Me.TextBox2.Text = "http://"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(144, 142)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(87, 23)
        Me.Button4.TabIndex = 1
        Me.Button4.Text = "Add bookmark"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(6, 142)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(82, 23)
        Me.Button3.TabIndex = 0
        Me.Button3.Text = "Current Page"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Button7)
        Me.TabPage2.Controls.Add(Me.ListBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(237, 307)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Bookmarks"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(189, 278)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(46, 23)
        Me.Button7.TabIndex = 1
        Me.Button7.Text = "Delete"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(-2, 0)
        Me.ListBox1.MultiColumn = True
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(243, 303)
        Me.ListBox1.TabIndex = 0
        '
        'go
        '
        Me.go.Location = New System.Drawing.Point(141, -21)
        Me.go.Name = "go"
        Me.go.Size = New System.Drawing.Size(10, 10)
        Me.go.TabIndex = 8
        Me.go.Text = "Go"
        Me.go.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(117, 11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'ChromeWebBrowser1
        '
        Me.ChromeWebBrowser1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChromeWebBrowser1.BackColor = System.Drawing.Color.White
        Me.ChromeWebBrowser1.BackgroundImage = CType(resources.GetObject("ChromeWebBrowser1.BackgroundImage"), System.Drawing.Image)
        Me.ChromeWebBrowser1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ChromeWebBrowser1.Location = New System.Drawing.Point(0, 37)
        Me.ChromeWebBrowser1.Name = "ChromeWebBrowser1"
        Me.ChromeWebBrowser1.Size = New System.Drawing.Size(1041, 620)
        Me.ChromeWebBrowser1.TabIndex = 12
        '
        'home
        '
        Me.home.BackColor = System.Drawing.Color.Transparent
        Me.home.BackgroundImage = CType(resources.GetObject("home.BackgroundImage"), System.Drawing.Image)
        Me.home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.home.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.home.ForeColor = System.Drawing.SystemColors.Control
        Me.home.Location = New System.Drawing.Point(38, 1)
        Me.home.Name = "home"
        Me.home.Size = New System.Drawing.Size(38, 37)
        Me.home.TabIndex = 3
        Me.home.UseVisualStyleBackColor = False
        '
        'forward
        '
        Me.forward.BackColor = System.Drawing.Color.Transparent
        Me.forward.BackgroundImage = CType(resources.GetObject("forward.BackgroundImage"), System.Drawing.Image)
        Me.forward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.forward.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.forward.ForeColor = System.Drawing.SystemColors.Control
        Me.forward.Location = New System.Drawing.Point(76, 1)
        Me.forward.Name = "forward"
        Me.forward.Size = New System.Drawing.Size(38, 37)
        Me.forward.TabIndex = 2
        Me.forward.UseVisualStyleBackColor = False
        '
        'back
        '
        Me.back.BackColor = System.Drawing.Color.Transparent
        Me.back.BackgroundImage = CType(resources.GetObject("back.BackgroundImage"), System.Drawing.Image)
        Me.back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.back.ForeColor = System.Drawing.SystemColors.Control
        Me.back.Location = New System.Drawing.Point(0, 1)
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(38, 37)
        Me.back.TabIndex = 1
        Me.back.UseVisualStyleBackColor = False
        '
        'fav
        '
        Me.fav.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fav.BackColor = System.Drawing.Color.Transparent
        Me.fav.BackgroundImage = CType(resources.GetObject("fav.BackgroundImage"), System.Drawing.Image)
        Me.fav.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.fav.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.fav.ForeColor = System.Drawing.SystemColors.Control
        Me.fav.Location = New System.Drawing.Point(923, 1)
        Me.fav.Name = "fav"
        Me.fav.Size = New System.Drawing.Size(38, 38)
        Me.fav.TabIndex = 9
        Me.fav.UseVisualStyleBackColor = False
        '
        'quickbar
        '
        Me.quickbar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.quickbar.BackColor = System.Drawing.Color.Transparent
        Me.quickbar.BackgroundImage = CType(resources.GetObject("quickbar.BackgroundImage"), System.Drawing.Image)
        Me.quickbar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.quickbar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.quickbar.ForeColor = System.Drawing.SystemColors.Control
        Me.quickbar.Location = New System.Drawing.Point(1001, 1)
        Me.quickbar.Name = "quickbar"
        Me.quickbar.Size = New System.Drawing.Size(38, 38)
        Me.quickbar.TabIndex = 6
        Me.quickbar.UseVisualStyleBackColor = False
        '
        'refreshbtn
        '
        Me.refreshbtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.refreshbtn.BackColor = System.Drawing.Color.Transparent
        Me.refreshbtn.BackgroundImage = CType(resources.GetObject("refreshbtn.BackgroundImage"), System.Drawing.Image)
        Me.refreshbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.refreshbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.refreshbtn.ForeColor = System.Drawing.SystemColors.Control
        Me.refreshbtn.Location = New System.Drawing.Point(962, 1)
        Me.refreshbtn.Name = "refreshbtn"
        Me.refreshbtn.Size = New System.Drawing.Size(38, 38)
        Me.refreshbtn.TabIndex = 5
        Me.refreshbtn.UseVisualStyleBackColor = False
        '
        'ALgoogle
        '
        Me.ALgoogle.Enabled = True
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1041, 655)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.qsb)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.go)
        Me.Controls.Add(Me.ChromeWebBrowser1)
        Me.Controls.Add(Me.home)
        Me.Controls.Add(Me.forward)
        Me.Controls.Add(Me.back)
        Me.Controls.Add(Me.fav)
        Me.Controls.Add(Me.quickbar)
        Me.Controls.Add(Me.refreshbtn)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(356, 300)
        Me.Name = "main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MySurf 3.0 (Alpha 3)"
        Me.qsb.ResumeLayout(False)
        Me.qsb.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout

End Sub
    Friend WithEvents back As System.Windows.Forms.Button
    Friend WithEvents forward As System.Windows.Forms.Button
    Friend WithEvents home As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents refreshbtn As System.Windows.Forms.Button
    Friend WithEvents quickbar As System.Windows.Forms.Button
    Friend WithEvents qsb As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents go As System.Windows.Forms.Button
    Friend WithEvents url As System.Windows.Forms.Timer
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents fav As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents ChromeWebBrowser1 As Sashulin.ChromeWebBrowser
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents ALgoogle As System.Windows.Forms.Timer

End Class
