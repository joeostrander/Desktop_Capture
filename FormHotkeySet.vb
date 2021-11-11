Public Class FormHotkeySet

    Public letter As Integer
    Public modifiers As Integer

    Private Const MOD_CONTROL As Integer = &H2 'Control key
    Private Const MOD_SHIFT As Integer = &H4 'Shift key
    Public Const MOD_ALT As Integer = &H1
    Public Const MOD_WIN As Integer = &H8

    Private Sub FormHotkeySet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = Application.ProductName & " - Set Hotkey"
        For i As Integer = Keys.A To Keys.Z
            ComboBoxLetter.Items.Add(Chr(i))
        Next
        ComboBoxLetter.SelectedItem = Chr(letter)

        If modifiers And MOD_CONTROL Then
            CheckBoxControl.Checked = True
        End If

        If modifiers And MOD_SHIFT Then
            CheckBoxShift.Checked = True
        End If

        If modifiers And MOD_ALT Then
            CheckBoxAlt.Checked = True
        End If

    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub ButtonOK_Click(sender As Object, e As EventArgs) Handles ButtonOK.Click
        letter = Asc(ComboBoxLetter.SelectedItem)
        modifiers = 0
        If CheckBoxControl.Checked Then
            modifiers += MOD_CONTROL
        End If

        If CheckBoxShift.Checked Then
            modifiers += MOD_SHIFT
        End If

        If CheckBoxAlt.Checked Then
            modifiers += MOD_ALT
        End If

        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub
End Class