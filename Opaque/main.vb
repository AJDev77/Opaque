Module Program
    Friend frmMain As main
End Module
Public Class main

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Settings.newpage = My.Settings.homepage
        CustomTabControl1.Dock = DockStyle.Fill
        Dim tab As New TabPage
        Dim newtab As New tabs
        newtab.Show()
        newtab.Dock = DockStyle.Fill
        newtab.TopLevel = False
        tab.Controls.Add(newtab)
        CustomTabControl1.TabPages.Add(tab)

        frmMain = Me
    End Sub

    Private Sub CustomTabControl1_TabClosing(sender As Object, e As TabControlCancelEventArgs) Handles CustomTabControl1.TabClosing
        If Me.CustomTabControl1.TabCount = 1 Then
            Me.CustomTabControl1.SelectedTab.Dispose()
            Me.Close()
        End If
        Me.PictureBox1.Location = New System.Drawing.Point(PictureBox1.Location.X - 150, 3)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        My.Settings.newpage = My.Settings.homepage
        Dim tab As New TabPage
        Dim newtab As New tabs
        newtab.Show()
        newtab.Dock = DockStyle.Fill
        newtab.TopLevel = False
        tab.Controls.Add(newtab)
        CustomTabControl1.TabPages.Add(tab)
        Me.PictureBox1.Location = New System.Drawing.Point(PictureBox1.Location.X + 150, 3)
        CustomTabControl1.SelectedTab = tab
    End Sub
    Private Sub InternalNewTab_Click(sender As Object, e As EventArgs) Handles InternalNewTab.Click
        Dim tab As New TabPage
        Dim newtab As New tabs
        newtab.Show()
        newtab.Dock = DockStyle.Fill
        newtab.TopLevel = False
        tab.Controls.Add(newtab)
        CustomTabControl1.TabPages.Add(tab)
        Me.PictureBox1.Location = New System.Drawing.Point(PictureBox1.Location.X + 150, 3)
        My.Settings.newpage = My.Settings.homepage
        CustomTabControl1.SelectedTab = tab
    End Sub
    Public Sub IntNewTab()
        Dim tab As New TabPage
        Dim newtab As New tabs
        newtab.Show()
        newtab.Dock = DockStyle.Fill
        newtab.TopLevel = False
        tab.Controls.Add(newtab)
        Me.CustomTabControl1.TabPages.Add(tab)
        Me.PictureBox1.Location = New System.Drawing.Point(PictureBox1.Location.X + 150, 3)
        My.Settings.newpage = My.Settings.homepage
        Me.CustomTabControl1.SelectedTab = tab

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If My.Settings.LifeSpanNewPage = True Then

            InternalNewTab.PerformClick()
            My.Settings.LifeSpanNewPage = False

        Else
            ' MsgBox("NO CLICK")
        End If
    End Sub
End Class
