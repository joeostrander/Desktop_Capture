Imports System
Imports System.Runtime.InteropServices
Imports System.Drawing
Imports System.Drawing.Imaging


Namespace ScreenShot
    '/ Provides functions to capture the entire screen, or a particular window, and save it to a file.
    Public Class ScreenCapture
        Declare Function CreateDC Lib "gdi32" Alias "CreateDCA" (ByVal lpDriverName As String, ByVal lpDeviceName As String, ByVal lpOutput As String, ByRef lpInitData As Integer) As IntPtr
        Declare Function StretchBlt Lib "gdi32.dll" (ByVal hdcDest As IntPtr, ByVal nXOriginDest As Integer, ByVal nYOriginDest As Integer, _
            ByVal nWidthDest As Integer, ByVal nHeightDest As Integer, ByVal hdcSrc As IntPtr, ByVal nXOriginSrc As Integer, _
            ByVal nYOriginSrc As Integer, ByVal nWidthSrc As Integer, ByVal nHeightSrc As Integer, ByVal dwRop As TernaryRasterOperations) As Boolean
        Declare Function DeleteDC Lib "gdi32" (ByVal hDC As IntPtr) As IntPtr

        Enum TernaryRasterOperations As Integer
            SRCCOPY = 13369376     'dest = source
            SRCPAINT = 15597702    'dest = source OR dest
            SRCAND = 8913094       'dest = source AND dest
            SRCINVERT = 6684742    'dest = source XOR dest
            SRCERASE = 4457256     'dest = source AND (NOT dest )
            NOTSRCCOPY = 3342344   'dest = (NOT source)
            NOTSRCERASE = 1114278  'dest = (NOT src) AND (NOT dest) 
            MERGECOPY = 12583114   'dest = (source AND pattern)
            MERGEPAINT = 12255782  'dest = (NOT source) OR dest
            PATCOPY = 15728673     'dest = pattern
            PATPAINT = 16452105    'dest = DPSnoo
            PATINVERT = 5898313    'dest = pattern XOR dest
            DSTINVERT = 5570569    'dest = (NOT dest)
            BLACKNESS = 66     'dest = BLACK
            WHITENESS = 16711778   'dest = WHITE
        End Enum


        '/ Creates an Image object containing a screen shot of the entire desktop
        Public Function CaptureScreen() As Image
            Return CaptureWindow(User32.GetDesktopWindow())
        End Function 'CaptureScreen

        Public Function CaptureAllScreens() As Image
            Dim CurrentDir As String
            Dim rcScreen As Rectangle
            Dim screen As Screen
            Dim scrn As Screen
            Dim g As Graphics
            Dim hdcDestination As IntPtr
            Dim hdcSource As IntPtr
            Dim success As Boolean
            Dim finalBitmap As Bitmap = Nothing
            Dim x, y As Integer

            CurrentDir = (Application.StartupPath).ToString
            If CurrentDir = "" Then CurrentDir = "c:\"

            For Each screen In screen.AllScreens
                rcScreen = Rectangle.Union(rcScreen, screen.Bounds)
                finalBitmap = New Bitmap(rcScreen.Width, rcScreen.Height)

                g = Graphics.FromImage(finalBitmap)
                g.CompositingQuality = Drawing2D.CompositingQuality.HighSpeed
                g.FillRectangle(SystemBrushes.Desktop, 0, 0, rcScreen.Width - rcScreen.X, rcScreen.Height - rcScreen.Y)
                hdcDestination = g.GetHdc()
                For Each scrn In screen.AllScreens
                    hdcSource = CreateDC(Nothing, scrn.DeviceName, Nothing, Nothing)
                    x = scrn.Bounds.X - rcScreen.X
                    y = scrn.Bounds.Y - rcScreen.Y

                    success = StretchBlt(hdcDestination, x, y, screen.Bounds.Width, screen.Bounds.Height, hdcSource, 0, 0, screen.Bounds.Width, screen.Bounds.Height, TernaryRasterOperations.SRCCOPY)

                    If Not success Then
                        Dim win32Exception As System.ComponentModel.Win32Exception
                        win32Exception = New System.ComponentModel.Win32Exception
                        System.Diagnostics.Trace.WriteLine(win32Exception)
                    End If

                    DeleteDC(hdcSource)
                Next
                g.ReleaseHdc(hdcDestination)
                g.Dispose()
            Next

            CaptureAllScreens = finalBitmap

        End Function


        '/ Creates an Image object containing a screen shot of a specific window
        Public Function CaptureWindow(ByVal handle As IntPtr) As Image
            Dim SRCCOPY As Integer = &HCC0020
            ' get te hDC of the target window
            Dim hdcSrc As IntPtr = User32.GetWindowDC(handle)
            ' get the size
            Dim windowRect As New User32.RECT
            User32.GetWindowRect(handle, windowRect)
            Dim width As Integer = windowRect.right - windowRect.left
            Dim height As Integer = windowRect.bottom - windowRect.top
            ' create a device context we can copy to
            Dim hdcDest As IntPtr = GDI32.CreateCompatibleDC(hdcSrc)
            ' create a bitmap we can copy it to,
            ' using GetDeviceCaps to get the width/height
            Dim hBitmap As IntPtr = GDI32.CreateCompatibleBitmap(hdcSrc, width, height)
            ' select the bitmap object
            Dim hOld As IntPtr = GDI32.SelectObject(hdcDest, hBitmap)
            ' bitblt over
            GDI32.BitBlt(hdcDest, 0, 0, width, height, hdcSrc, 0, 0, SRCCOPY)
            ' restore selection
            GDI32.SelectObject(hdcDest, hOld)
            ' clean up 
            GDI32.DeleteDC(hdcDest)
            User32.ReleaseDC(handle, hdcSrc)

            ' get a .NET image object for it
            Dim img As Image = Image.FromHbitmap(hBitmap)
            ' free up the Bitmap object
            GDI32.DeleteObject(hBitmap)

            Return img
        End Function 'CaptureWindow
        '/ Captures a screen shot of a specific window, and saves it to a file
        Public Sub CaptureWindowToFile(ByVal handle As IntPtr, ByVal filename As String, ByVal format As ImageFormat)
            Dim img As Image = CaptureWindow(handle)
            img.Save(filename, format)
        End Sub 'CaptureWindowToFile
        '/ Captures a screen shot of the entire desktop, and saves it to a file
        Public Sub CaptureScreenToFile(ByVal filename As String, ByVal format As ImageFormat)
            Dim img As Image = CaptureScreen()
            img.Save(filename, format)
        End Sub 'CaptureScreenToFile
        Public Function CaptureDeskTopRectangle(ByVal CapRect As Rectangle, ByVal CapRectWidth As Integer, ByVal CapRectHeight As Integer) As Bitmap
            '/ Returns BitMap of the region of the desktop, similar to CaptureWindow, but can be used to 
            '/ create a snapshot of the desktop when no handle is present, by passing in a rectangle 
            '/ Grabs snapshot of entire desktop, then crops it using the passed in rectangle's coordinates
            Dim SC As New ScreenShot.ScreenCapture
            'Dim bmpImage As New Bitmap(SC.CaptureScreen)
            Dim bmpImage As New Bitmap(SC.CaptureAllScreens)
            Dim bmpCrop As New Bitmap(CapRectWidth, CapRectHeight, bmpImage.PixelFormat)
            Dim recCrop As New Rectangle(CapRect.X, CapRect.Y, CapRectWidth, CapRectHeight)
            Dim gphCrop As Graphics = Graphics.FromImage(bmpCrop)
            Dim recDest As New Rectangle(0, 0, CapRectWidth, CapRectHeight)
            gphCrop.DrawImage(bmpImage, recDest, recCrop.X, recCrop.Y, recCrop.Width, _
              recCrop.Height, GraphicsUnit.Pixel)
            Return bmpCrop
        End Function
        '/ Helper class containing Gdi32 API functions
        Private Class GDI32
            Public SRCCOPY As Integer = &HCC0020
            ' BitBlt dwRop parameter
            Declare Function BitBlt Lib "gdi32.dll" ( _
                ByVal hDestDC As IntPtr, _
                ByVal x As Int32, _
                ByVal y As Int32, _
                ByVal nWidth As Int32, _
                ByVal nHeight As Int32, _
                ByVal hSrcDC As IntPtr, _
                ByVal xSrc As Int32, _
                ByVal ySrc As Int32, _
                ByVal dwRop As Int32) As Int32

            Declare Function CreateCompatibleBitmap Lib "gdi32.dll" ( _
                ByVal hdc As IntPtr, _
                ByVal nWidth As Int32, _
                ByVal nHeight As Int32) As IntPtr

            Declare Function CreateCompatibleDC Lib "gdi32.dll" ( _
                ByVal hdc As IntPtr) As IntPtr

            Declare Function DeleteDC Lib "gdi32.dll" ( _
                ByVal hdc As IntPtr) As Int32

            Declare Function DeleteObject Lib "gdi32.dll" ( _
                ByVal hObject As IntPtr) As Int32

            Declare Function SelectObject Lib "gdi32.dll" ( _
                ByVal hdc As IntPtr, _
                ByVal hObject As IntPtr) As IntPtr
        End Class 'GDI32
        '/ Helper class containing User32 API functions
        Public Class User32
            <StructLayout(LayoutKind.Sequential)> _
            Public Structure RECT
                Public left As Integer
                Public top As Integer
                Public right As Integer
                Public bottom As Integer
            End Structure 'RECT

            Declare Function GetDesktopWindow Lib "user32.dll" () As IntPtr

            Declare Function GetWindowDC Lib "user32.dll" ( _
                ByVal hwnd As IntPtr) As IntPtr

            Declare Function ReleaseDC Lib "user32.dll" ( _
                ByVal hwnd As IntPtr, _
                ByVal hdc As IntPtr) As Int32

            Declare Function GetWindowRect Lib "user32.dll" ( _
                ByVal hwnd As IntPtr, _
                ByRef lpRect As RECT) As Int32

        End Class 'User32
    End Class 'ScreenCapture 
End Namespace 'ScreenShot
