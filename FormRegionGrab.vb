Public Class FormRegionGrab


    Dim SC As New ScreenShot.ScreenCapture

    Dim StartPoint As Point
    Dim EndPoint As Point

    Private boolDrawing As Boolean = False

    Private Sub FormRegionGrab_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If Asc(e.KeyChar) = Keys.Escape Then Me.Close()
    End Sub

    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown

        StartPoint = e.Location
        boolDrawing = True
    End Sub


    Private Sub FormRegionGrab_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove

        If boolDrawing = False Then Exit Sub

        ' Erase the previous rectangle
        Me.Refresh()

        Dim RectCapture As Rectangle
        If e.X < StartPoint.X Then
            RectCapture.X = e.X
        Else
            RectCapture.X = StartPoint.X
        End If
        If e.Y < StartPoint.Y Then
            RectCapture.Y = e.Y
        Else
            RectCapture.Y = StartPoint.Y
        End If

        RectCapture.Width = Math.Abs(e.X - StartPoint.X)
        RectCapture.Height = Math.Abs(e.Y - StartPoint.Y)

        CreateGraphics.DrawRectangle(Pens.Blue, RectCapture)
        CreateGraphics.FillRectangle(Brushes.Blue, RectCapture)

        Dim myFont As New Font("Verdana", 8)
        Dim myBrush As Brush

        If e.X < StartPoint.X And e.Y < StartPoint.Y Then
            myBrush = Brushes.White
        Else
            myBrush = Brushes.Black
        End If
        CreateGraphics.DrawString(RectCapture.Width & "," & RectCapture.Height, myFont, myBrush, e.X + 5, e.Y + 5)


    End Sub

    Private Sub Form1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp

        ' Erase the drawing
        Me.Refresh()
        Me.Opacity = 0

        EndPoint.X = MousePosition.X
        EndPoint.Y = MousePosition.Y
        Cursor = Cursors.Arrow

        Dim rectangle1 As Rectangle
        If StartPoint.X < EndPoint.X Then
            rectangle1.X = StartPoint.X
        Else
            rectangle1.X = EndPoint.X
        End If

        If StartPoint.Y < EndPoint.Y Then
            rectangle1.Y = StartPoint.Y
        Else
            rectangle1.Y = EndPoint.Y
        End If


        rectangle1.Width = Math.Abs(EndPoint.X - StartPoint.X)
        rectangle1.Height = Math.Abs(EndPoint.Y - StartPoint.Y)

        If rectangle1.Width < 1 Or rectangle1.Height < 1 Then
            boolDrawing = False
            Me.Close()
            Exit Sub
        End If

        Form1.DoDelay()

        Dim MyBitMap As Bitmap = SC.CaptureDeskTopRectangle(rectangle1, rectangle1.Width, rectangle1.Height)

        Clipboard.SetImage(MyBitMap)



        Form1.PictureBox1.Height = MyBitMap.Height
        Form1.PictureBox1.Width = MyBitMap.Width
        Form1.PictureBox1.Visible = True
        Form1.PictureBox1.Image = MyBitMap
        Form1.PictureBox2.Image = MyBitMap.Clone

        Me.Close()

        Form1.NotifyIcon1.ShowBalloonTip(5000, "Image copied to clipboard.", _
            "Width:" & vbTab & rectangle1.Width & vbCrLf & "Height:" & vbTab & rectangle1.Height & _
            vbCrLf & vbCrLf & "Click here to view/markup image.", ToolTipIcon.Info)

    End Sub


    Private Sub FormRegionGrab_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Dim rcScreen As Rectangle

        For Each scrn As Screen In Screen.AllScreens
            rcScreen = Rectangle.Union(rcScreen, scrn.Bounds)
        Next

        Me.Height = rcScreen.Height
        Me.Width = rcScreen.Width

        Me.Location = New Point(0, 0)

    End Sub


End Class