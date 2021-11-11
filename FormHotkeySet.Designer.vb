<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormHotkeySet
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CheckBoxControl = New System.Windows.Forms.CheckBox()
        Me.CheckBoxShift = New System.Windows.Forms.CheckBox()
        Me.CheckBoxAlt = New System.Windows.Forms.CheckBox()
        Me.ComboBoxLetter = New System.Windows.Forms.ComboBox()
        Me.ButtonOK = New System.Windows.Forms.Button()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Hotkey:"
        '
        'CheckBoxControl
        '
        Me.CheckBoxControl.AutoSize = True
        Me.CheckBoxControl.Location = New System.Drawing.Point(90, 44)
        Me.CheckBoxControl.Name = "CheckBoxControl"
        Me.CheckBoxControl.Size = New System.Drawing.Size(59, 17)
        Me.CheckBoxControl.TabIndex = 1
        Me.CheckBoxControl.Text = "Control"
        Me.CheckBoxControl.UseVisualStyleBackColor = True
        '
        'CheckBoxShift
        '
        Me.CheckBoxShift.AutoSize = True
        Me.CheckBoxShift.Location = New System.Drawing.Point(164, 44)
        Me.CheckBoxShift.Name = "CheckBoxShift"
        Me.CheckBoxShift.Size = New System.Drawing.Size(47, 17)
        Me.CheckBoxShift.TabIndex = 2
        Me.CheckBoxShift.Text = "Shift"
        Me.CheckBoxShift.UseVisualStyleBackColor = True
        '
        'CheckBoxAlt
        '
        Me.CheckBoxAlt.AutoSize = True
        Me.CheckBoxAlt.Location = New System.Drawing.Point(229, 44)
        Me.CheckBoxAlt.Name = "CheckBoxAlt"
        Me.CheckBoxAlt.Size = New System.Drawing.Size(38, 17)
        Me.CheckBoxAlt.TabIndex = 3
        Me.CheckBoxAlt.Text = "Alt"
        Me.CheckBoxAlt.UseVisualStyleBackColor = True
        '
        'ComboBoxLetter
        '
        Me.ComboBoxLetter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxLetter.FormattingEnabled = True
        Me.ComboBoxLetter.Location = New System.Drawing.Point(299, 42)
        Me.ComboBoxLetter.Name = "ComboBoxLetter"
        Me.ComboBoxLetter.Size = New System.Drawing.Size(49, 21)
        Me.ComboBoxLetter.TabIndex = 4
        '
        'ButtonOK
        '
        Me.ButtonOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonOK.Location = New System.Drawing.Point(195, 100)
        Me.ButtonOK.Name = "ButtonOK"
        Me.ButtonOK.Size = New System.Drawing.Size(75, 23)
        Me.ButtonOK.TabIndex = 5
        Me.ButtonOK.Text = "OK"
        Me.ButtonOK.UseVisualStyleBackColor = True
        '
        'ButtonCancel
        '
        Me.ButtonCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonCancel.Location = New System.Drawing.Point(276, 100)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCancel.TabIndex = 6
        Me.ButtonCancel.Text = "Cancel"
        Me.ButtonCancel.UseVisualStyleBackColor = True
        '
        'FormHotkeySet
        '
        Me.AcceptButton = Me.ButtonOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ButtonCancel
        Me.ClientSize = New System.Drawing.Size(363, 135)
        Me.Controls.Add(Me.ButtonCancel)
        Me.Controls.Add(Me.ButtonOK)
        Me.Controls.Add(Me.ComboBoxLetter)
        Me.Controls.Add(Me.CheckBoxAlt)
        Me.Controls.Add(Me.CheckBoxShift)
        Me.Controls.Add(Me.CheckBoxControl)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormHotkeySet"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormHotkeySet"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents CheckBoxControl As CheckBox
    Friend WithEvents CheckBoxShift As CheckBox
    Friend WithEvents CheckBoxAlt As CheckBox
    Friend WithEvents ComboBoxLetter As ComboBox
    Friend WithEvents ButtonOK As Button
    Friend WithEvents ButtonCancel As Button
End Class
