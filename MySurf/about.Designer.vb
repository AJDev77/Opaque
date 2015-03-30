<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class about
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(about))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.title = New System.Windows.Forms.PictureBox()
        Me.version = New System.Windows.Forms.Label()
        Me.updatetxt = New System.Windows.Forms.Label()
        Me.info = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.title, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(-2, -2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(339, 256)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'title
        '
        Me.title.BackgroundImage = CType(resources.GetObject("title.BackgroundImage"), System.Drawing.Image)
        Me.title.Location = New System.Drawing.Point(348, 54)
        Me.title.Name = "title"
        Me.title.Size = New System.Drawing.Size(155, 50)
        Me.title.TabIndex = 3
        Me.title.TabStop = False
        '
        'version
        '
        Me.version.AutoSize = True
        Me.version.Location = New System.Drawing.Point(345, 107)
        Me.version.Name = "version"
        Me.version.Size = New System.Drawing.Size(99, 13)
        Me.version.TabIndex = 4
        Me.version.Text = "Version 3.0 (Stable)"
        '
        'updatetxt
        '
        Me.updatetxt.AutoSize = True
        Me.updatetxt.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.updatetxt.Location = New System.Drawing.Point(345, 140)
        Me.updatetxt.Name = "updatetxt"
        Me.updatetxt.Size = New System.Drawing.Size(158, 13)
        Me.updatetxt.TabIndex = 8
        Me.updatetxt.Text = "Click here to check for updates."
        '
        'info
        '
        Me.info.AutoSize = True
        Me.info.Location = New System.Drawing.Point(345, 184)
        Me.info.Name = "info"
        Me.info.Size = New System.Drawing.Size(261, 13)
        Me.info.TabIndex = 9
        Me.info.Text = "MySurf is designed and coded by AJDev at Emposoft."
        '
        'about
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(611, 252)
        Me.Controls.Add(Me.info)
        Me.Controls.Add(Me.updatetxt)
        Me.Controls.Add(Me.version)
        Me.Controls.Add(Me.title)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(627, 291)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(627, 291)
        Me.Name = "about"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "About MySurf"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.title, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents title As System.Windows.Forms.PictureBox
    Friend WithEvents version As System.Windows.Forms.Label
    Friend WithEvents updatetxt As System.Windows.Forms.Label
    Friend WithEvents info As System.Windows.Forms.Label
End Class
