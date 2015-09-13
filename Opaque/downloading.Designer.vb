<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class downloading
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(downloading))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ProgressBarLabel1 = New System.Windows.Forms.Label()
        Me.ProgressBarLabel2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DownloadURL = New System.Windows.Forms.Label()
        Me.LocalLocation = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Saving to: "
        '
        'ProgressBarLabel1
        '
        Me.ProgressBarLabel1.AutoSize = True
        Me.ProgressBarLabel1.Location = New System.Drawing.Point(8, 64)
        Me.ProgressBarLabel1.Name = "ProgressBarLabel1"
        Me.ProgressBarLabel1.Size = New System.Drawing.Size(51, 13)
        Me.ProgressBarLabel1.TabIndex = 4
        Me.ProgressBarLabel1.Text = "Progress:"
        '
        'ProgressBarLabel2
        '
        Me.ProgressBarLabel2.AutoSize = True
        Me.ProgressBarLabel2.Location = New System.Drawing.Point(57, 65)
        Me.ProgressBarLabel2.Name = "ProgressBarLabel2"
        Me.ProgressBarLabel2.Size = New System.Drawing.Size(33, 13)
        Me.ProgressBarLabel2.TabIndex = 5
        Me.ProgressBarLabel2.Text = "000%"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "URL:"
        '
        'DownloadURL
        '
        Me.DownloadURL.AutoSize = True
        Me.DownloadURL.Location = New System.Drawing.Point(38, 9)
        Me.DownloadURL.Name = "DownloadURL"
        Me.DownloadURL.Size = New System.Drawing.Size(67, 13)
        Me.DownloadURL.TabIndex = 8
        Me.DownloadURL.Text = "Starting up..."
        '
        'LocalLocation
        '
        Me.LocalLocation.AutoSize = True
        Me.LocalLocation.Location = New System.Drawing.Point(63, 33)
        Me.LocalLocation.Name = "LocalLocation"
        Me.LocalLocation.Size = New System.Drawing.Size(67, 13)
        Me.LocalLocation.TabIndex = 9
        Me.LocalLocation.Text = "Starting up..."
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(96, 59)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(376, 23)
        Me.ProgressBar1.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Downloaded: 0 MB / 0 MB"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(397, 148)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Cancel"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(397, 148)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Close"
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'downloading
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 183)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.LocalLocation)
        Me.Controls.Add(Me.DownloadURL)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ProgressBarLabel2)
        Me.Controls.Add(Me.ProgressBarLabel1)
        Me.Controls.Add(Me.Label2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(500, 222)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(500, 222)
        Me.Name = "downloading"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Download"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ProgressBarLabel1 As System.Windows.Forms.Label
    Friend WithEvents ProgressBarLabel2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DownloadURL As System.Windows.Forms.Label
    Friend WithEvents LocalLocation As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
