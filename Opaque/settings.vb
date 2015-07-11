Imports System.Drawing.Drawing2D

Public Class settings

    Private Sub settings_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If TextBox1.Text = My.Settings.homepage = False Then
            My.Settings.homepage = TextBox1.Text
        Else

        End If
    End Sub

    Private Sub settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = My.Settings.searchname
        TextBox2.Text = My.Settings.CacheLocation
        TextBox1.Text = My.Settings.homepage
        If My.Settings.PrivacyMode = False Then
            PrivacyModeSlider.BackgroundImage = My.Resources.red_slider
        Else
            PrivacyModeSlider.BackgroundImage = My.Resources.green_slider
        End If
    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        My.Settings.search = ("https://duckduckgo.com/?q=")
        Label2.Text = "DuckDuckGo"
        My.Settings.searchname = "DuckDuckGo"
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        My.Settings.search = ("https://www.bing.com/search?q=")
        Label2.Text = "Bing"
        My.Settings.searchname = "Bing"
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        My.Settings.search = ("https://www.google.com/#q=")
        Label2.Text = "Google"
        My.Settings.searchname = "Google"
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        My.Settings.search = ("https://search.yahoo.com/search;?p=")
        Label2.Text = "Yahoo"
        My.Settings.searchname = "Yahoo"
    End Sub

    Private Sub PictureBox20_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        My.Settings.themecolor = "#FFC107"
        My.Settings.Save()
        MsgBox("Opaque needs to be restarted to apply the new theme.")
    End Sub

    Private Sub PictureBox13_Click(sender As Object, e As EventArgs) Handles PictureBox13.Click
        My.Settings.themecolor = "#FF9800"
        My.Settings.Save()
        MsgBox("Opaque needs to be restarted to apply the new theme.")
    End Sub

    Private Sub PictureBox18_Click(sender As Object, e As EventArgs) Handles PictureBox18.Click
        My.Settings.themecolor = "#FF5722"
        My.Settings.Save()
        MsgBox("Opaque needs to be restarted to apply the new theme.")
    End Sub

    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click
        My.Settings.themecolor = "#F44336"
        My.Settings.Save()
        MsgBox("Opaque needs to be restarted to apply the new theme.")
    End Sub

    Private Sub PictureBox17_Click(sender As Object, e As EventArgs) Handles PictureBox17.Click
        My.Settings.themecolor = "#673AB7"
        My.Settings.Save()
        MsgBox("Opaque needs to be restarted to apply the new theme.")
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        My.Settings.themecolor = "#9C27B0"
        My.Settings.Save()
        MsgBox("Opaque needs to be restarted to apply the new theme.")
    End Sub

    Private Sub PictureBox14_Click(sender As Object, e As EventArgs) Handles PictureBox14.Click
        My.Settings.themecolor = "#03A9F4"
        My.Settings.Save()
        MsgBox("Opaque needs to be restarted to apply the new theme.")
    End Sub

    Private Sub PictureBox15_Click(sender As Object, e As EventArgs) Handles PictureBox15.Click
        My.Settings.themecolor = "#3F51B5"
        My.Settings.Save()
        MsgBox("Opaque needs to be restarted to apply the new theme.")
    End Sub

    Private Sub PictureBox19_Click(sender As Object, e As EventArgs) Handles PictureBox19.Click
        My.Settings.themecolor = "#795548"
        My.Settings.Save()
        MsgBox("Opaque needs to be restarted to apply the new theme.")
    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        My.Settings.themecolor = "#E91E63"
        My.Settings.Save()
        MsgBox("Opaque needs to be restarted to apply the new theme.")
    End Sub

    Private Sub PictureBox16_Click(sender As Object, e As EventArgs) Handles PictureBox16.Click
        My.Settings.themecolor = "#4CAF50"
        My.Settings.Save()
        MsgBox("Opaque needs to be restarted to apply the new theme.")
    End Sub

    Private Sub PictureBox22_Click(sender As Object, e As EventArgs) Handles PictureBox22.Click
        My.Settings.themecolor = "#FFEB3B"
        My.Settings.Save()
        MsgBox("Opaque needs to be restarted to apply the new theme.")
    End Sub

    Private Sub PictureBox21_Click(sender As Object, e As EventArgs) Handles PictureBox21.Click
        My.Settings.themecolor = "#F0F0F0"
        My.Settings.Save()
        MsgBox("Opaque needs to be restarted to apply the new theme.")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FolderBrowserDialog1.ShowDialog()
        TextBox2.Text = FolderBrowserDialog1.SelectedPath
        My.Settings.CacheLocation = FolderBrowserDialog1.SelectedPath
        My.Settings.Save()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox2.Text = "DEFAULT"
        My.Settings.CacheLocation = "DEFAULT"
        My.Settings.Save()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MsgBox("The cookies and cache will be cleared next time you launch Opaque.")
        My.Settings.ClearCache = True
        My.Settings.Save()
    End Sub

    Private Sub PrivacyModeSlider_Click(sender As Object, e As EventArgs) Handles PrivacyModeSlider.Click
        If My.Settings.PrivacyMode = False Then
            My.Settings.PrivacyMode = True
            PrivacyModeSlider.BackgroundImage = My.Resources.green_slider
        Else
            If My.Settings.PrivacyMode = True Then
                My.Settings.PrivacyMode = False
                PrivacyModeSlider.BackgroundImage = My.Resources.red_slider
            End If
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        engine.Show()
    End Sub
End Class
Public Class OpaqueSettingsControl1
    Inherits TabControl

    Sub New()
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.ResizeRedraw Or ControlStyles.UserPaint Or ControlStyles.DoubleBuffer, True)
        DoubleBuffered = True
        SizeMode = TabSizeMode.Fixed
        ItemSize = New Size(44, 136)
    End Sub
    Protected Overrides Sub CreateHandle()
        MyBase.CreateHandle()
        Alignment = TabAlignment.Left
    End Sub

    Function ToPen(ByVal color As Color) As Pen
        Return New Pen(color)
    End Function

    Function ToBrush(ByVal color As Color) As Brush
        Return New SolidBrush(color)
    End Function

    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        Dim B As New Bitmap(Width, Height)
        Dim G As Graphics = Graphics.FromImage(B)
        Try : SelectedTab.BackColor = Color.White : Catch : End Try
        G.Clear(Color.White)
        G.FillRectangle(New SolidBrush(Color.FromArgb(246, 248, 252)), New Rectangle(0, 0, ItemSize.Height + 4, Height))
        'G.DrawLine(New Pen(Color.FromArgb(170, 187, 204)), New Point(Width - 1, 0), New Point(Width - 1, Height - 1))    'comment out to get rid of the borders
        'G.DrawLine(New Pen(Color.FromArgb(170, 187, 204)), New Point(ItemSize.Height + 1, 0), New Point(Width - 1, 0))                   'comment out to get rid of the borders
        'G.DrawLine(New Pen(Color.FromArgb(170, 187, 204)), New Point(ItemSize.Height + 3, Height - 1), New Point(Width - 1, Height - 1)) 'comment out to get rid of the borders
        G.DrawLine(New Pen(Color.FromArgb(170, 187, 204)), New Point(ItemSize.Height + 3, 0), New Point(ItemSize.Height + 3, 999))
        For i = 0 To TabCount - 1
            If i = SelectedIndex Then
                Dim x2 As Rectangle = New Rectangle(New Point(GetTabRect(i).Location.X - 2, GetTabRect(i).Location.Y - 2), New Size(GetTabRect(i).Width + 3, GetTabRect(i).Height - 1))
                Dim myBlend As New ColorBlend()
                myBlend.Colors = {Color.FromArgb(232, 232, 240), Color.FromArgb(232, 232, 240), Color.FromArgb(232, 232, 240)}
                myBlend.Positions = {0.0F, 0.5F, 1.0F}
                Dim lgBrush As New LinearGradientBrush(x2, Color.Black, Color.Black, 90.0F)
                lgBrush.InterpolationColors = myBlend
                G.FillRectangle(lgBrush, x2)
                G.DrawRectangle(New Pen(Color.FromArgb(170, 187, 204)), x2)


                G.SmoothingMode = SmoothingMode.HighQuality
                Dim p() As Point = {New Point(ItemSize.Height - 3, GetTabRect(i).Location.Y + 20), New Point(ItemSize.Height + 4, GetTabRect(i).Location.Y + 14), New Point(ItemSize.Height + 4, GetTabRect(i).Location.Y + 27)}
                G.FillPolygon(Brushes.White, p)
                G.DrawPolygon(New Pen(Color.FromArgb(170, 187, 204)), p)

                If ImageList IsNot Nothing Then
                    Try
                        If ImageList.Images(TabPages(i).ImageIndex) IsNot Nothing Then

                            G.DrawImage(ImageList.Images(TabPages(i).ImageIndex), New Point(x2.Location.X + 8, x2.Location.Y + 6))
                            G.DrawString("      " & TabPages(i).Text, Font, Brushes.DimGray, x2, New StringFormat With {.LineAlignment = StringAlignment.Center, .Alignment = StringAlignment.Center})
                        Else
                            G.DrawString(TabPages(i).Text, New Font(Font.FontFamily, Font.Size, FontStyle.Bold), Brushes.DimGray, x2, New StringFormat With {.LineAlignment = StringAlignment.Center, .Alignment = StringAlignment.Center})
                        End If
                    Catch ex As Exception
                        G.DrawString(TabPages(i).Text, New Font(Font.FontFamily, Font.Size, FontStyle.Bold), Brushes.DimGray, x2, New StringFormat With {.LineAlignment = StringAlignment.Center, .Alignment = StringAlignment.Center})
                    End Try
                Else
                    G.DrawString(TabPages(i).Text, New Font(Font.FontFamily, Font.Size, FontStyle.Bold), Brushes.DimGray, x2, New StringFormat With {.LineAlignment = StringAlignment.Center, .Alignment = StringAlignment.Center})
                End If

                G.DrawLine(New Pen(Color.FromArgb(200, 200, 250)), New Point(x2.Location.X - 1, x2.Location.Y - 1), New Point(x2.Location.X, x2.Location.Y))
                G.DrawLine(New Pen(Color.FromArgb(200, 200, 250)), New Point(x2.Location.X - 1, x2.Bottom - 1), New Point(x2.Location.X, x2.Bottom))
            Else
                Dim x2 As Rectangle = New Rectangle(New Point(GetTabRect(i).Location.X - 2, GetTabRect(i).Location.Y - 2), New Size(GetTabRect(i).Width + 3, GetTabRect(i).Height + 1))
                G.FillRectangle(New SolidBrush(Color.FromArgb(246, 248, 252)), x2)
                G.DrawLine(New Pen(Color.FromArgb(170, 187, 204)), New Point(x2.Right, x2.Top), New Point(x2.Right, x2.Bottom))
                If ImageList IsNot Nothing Then
                    Try
                        If ImageList.Images(TabPages(i).ImageIndex) IsNot Nothing Then
                            G.DrawImage(ImageList.Images(TabPages(i).ImageIndex), New Point(x2.Location.X + 8, x2.Location.Y + 6))
                            G.DrawString("      " & TabPages(i).Text, Font, Brushes.DimGray, x2, New StringFormat With {.LineAlignment = StringAlignment.Center, .Alignment = StringAlignment.Center})
                        Else
                            G.DrawString(TabPages(i).Text, Font, Brushes.DimGray, x2, New StringFormat With {.LineAlignment = StringAlignment.Center, .Alignment = StringAlignment.Center})
                        End If
                    Catch ex As Exception
                        G.DrawString(TabPages(i).Text, Font, Brushes.DimGray, x2, New StringFormat With {.LineAlignment = StringAlignment.Center, .Alignment = StringAlignment.Center})
                    End Try
                Else
                    G.DrawString(TabPages(i).Text, Font, Brushes.DimGray, x2, New StringFormat With {.LineAlignment = StringAlignment.Center, .Alignment = StringAlignment.Center})
                End If
            End If
        Next

        e.Graphics.DrawImage(B.Clone, 0, 0)
        G.Dispose() : B.Dispose()
    End Sub
End Class