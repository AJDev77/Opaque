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
        Me.CustomTabControl1 = New System.Windows.Forms.CustomTabControl()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.InternalNewTab = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CustomTabControl1
        '
        Me.CustomTabControl1.DisplayStyle = System.Windows.Forms.TabStyle.Angled
        '
        '
        '
        Me.CustomTabControl1.DisplayStyleProvider.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.CustomTabControl1.DisplayStyleProvider.BorderColorHot = System.Drawing.SystemColors.ControlDark
        Me.CustomTabControl1.DisplayStyleProvider.BorderColorSelected = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.CustomTabControl1.DisplayStyleProvider.CloserColor = System.Drawing.Color.DarkGray
        Me.CustomTabControl1.DisplayStyleProvider.FocusTrack = False
        Me.CustomTabControl1.DisplayStyleProvider.HotTrack = True
        Me.CustomTabControl1.DisplayStyleProvider.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CustomTabControl1.DisplayStyleProvider.Opacity = 1.0!
        Me.CustomTabControl1.DisplayStyleProvider.Overlap = 10
        Me.CustomTabControl1.DisplayStyleProvider.Padding = New System.Drawing.Point(10, 3)
        Me.CustomTabControl1.DisplayStyleProvider.Radius = 10
        Me.CustomTabControl1.DisplayStyleProvider.ShowTabCloser = True
        Me.CustomTabControl1.DisplayStyleProvider.TextColor = System.Drawing.SystemColors.ControlText
        Me.CustomTabControl1.DisplayStyleProvider.TextColorDisabled = System.Drawing.SystemColors.ControlDark
        Me.CustomTabControl1.DisplayStyleProvider.TextColorSelected = System.Drawing.SystemColors.ControlText
        Me.CustomTabControl1.HotTrack = True
        Me.CustomTabControl1.ItemSize = New System.Drawing.Size(150, 18)
        Me.CustomTabControl1.Location = New System.Drawing.Point(401, 117)
        Me.CustomTabControl1.Margin = New System.Windows.Forms.Padding(0)
        Me.CustomTabControl1.Name = "CustomTabControl1"
        Me.CustomTabControl1.SelectedIndex = 0
        Me.CustomTabControl1.Size = New System.Drawing.Size(223, 198)
        Me.CustomTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.CustomTabControl1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Location = New System.Drawing.Point(152, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(26, 18)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'InternalNewTab
        '
        Me.InternalNewTab.Location = New System.Drawing.Point(12, -15)
        Me.InternalNewTab.Name = "InternalNewTab"
        Me.InternalNewTab.Size = New System.Drawing.Size(1, 1)
        Me.InternalNewTab.TabIndex = 2
        Me.InternalNewTab.Text = "InternalNewTab"
        Me.InternalNewTab.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1041, 655)
        Me.Controls.Add(Me.InternalNewTab)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.CustomTabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(356, 300)
        Me.Name = "main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Opaque"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CustomTabControl1 As System.Windows.Forms.CustomTabControl
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents InternalNewTab As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
