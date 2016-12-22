

Public Class FormWindowRectangle
    Private Sub FormWindowRectangle_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.SizeChanged
        Panel1.Width = Me.Width - 10
        Panel1.Height = Me.Height - 10
        Panel1.Top = 5
        Panel1.Left = 5
    End Sub

End Class