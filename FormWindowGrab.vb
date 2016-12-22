Public Class FormWindowGrab
    Private Declare Function WindowFromPoint Lib "user32.dll" (ByVal lpPoint As Point) As Integer
    Private Declare Function GetWindowRect Lib "user32.dll" (ByVal hwnd As Int32, ByRef lpRect As Rectangle) As Boolean
    Private rect_capture As Rectangle

    Dim SC As New ScreenShot.ScreenCapture

    Dim ms As New System.IO.MemoryStream(My.Resources.SpyPicker_cur)
    Dim CursorPicker As Cursor = New Cursor(ms)



    Private Sub FormWindowSelect_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If Asc(e.KeyChar) = Keys.Escape Then Me.Close()
    End Sub



    Private Sub PictureBox1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseDown
        Me.Cursor = CursorPicker
        Me.Location = New Point(-5000, -5000)

        FormWindowRectangle.Show()
    End Sub

    Private Sub PictureBox1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Dim window_handle As Long = WindowFromPoint(MousePosition)
            Dim rect As Rectangle
            GetWindowRect(window_handle, rect)

            FormWindowRectangle.Width = rect.Width - rect.Left
            FormWindowRectangle.Height = rect.Height - rect.Top

            FormWindowRectangle.Left = rect.Left
            FormWindowRectangle.Top = rect.Top
            FormWindowRectangle.Show()

            rect_capture.Location = FormWindowRectangle.Location
            rect_capture.Width = FormWindowRectangle.Width
            rect_capture.Height = FormWindowRectangle.Height

        End If
        
    End Sub

    Private Sub PictureBox1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseUp
        Me.Cursor = Cursors.Default
        FormWindowRectangle.Close()

        'Moved to after the capture... seems to make more sense
        'Form1.DoDelay()

        Dim MyBitMap As Bitmap = SC.CaptureDeskTopRectangle(rect_capture, rect_capture.Width, rect_capture.Height)

        Form1.DoDelay()

        Clipboard.SetImage(MyBitMap)

        Form1.PictureBox1.Height = MyBitMap.Height
        Form1.PictureBox1.Width = MyBitMap.Width
        Form1.PictureBox1.Visible = True
        Form1.PictureBox1.Image = MyBitMap
        Form1.PictureBox2.Image = MyBitMap.Clone

        Form1.NotifyIcon1.ShowBalloonTip(5000, "Image copied to clipboard.", _
            "Width:" & vbTab & rect_capture.Width & vbCrLf & "Height:" & vbTab & rect_capture.Height & _
            vbCrLf & vbCrLf & "Click here to view/markup image.", ToolTipIcon.Info)


        Me.Close()

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub
End Class