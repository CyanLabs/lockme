<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pass
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pass))
        Me.passwordtxt1 = New System.Windows.Forms.TextBox()
        Me.passwordtxt2 = New System.Windows.Forms.TextBox()
        Me.apply = New System.Windows.Forms.Button()
        Me.Passwordinfo1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'passwordtxt1
        '
        Me.passwordtxt1.Location = New System.Drawing.Point(12, 31)
        Me.passwordtxt1.Name = "passwordtxt1"
        Me.passwordtxt1.Size = New System.Drawing.Size(233, 20)
        Me.passwordtxt1.TabIndex = 0
        Me.passwordtxt1.UseSystemPasswordChar = True
        '
        'passwordtxt2
        '
        Me.passwordtxt2.Location = New System.Drawing.Point(12, 57)
        Me.passwordtxt2.Name = "passwordtxt2"
        Me.passwordtxt2.Size = New System.Drawing.Size(233, 20)
        Me.passwordtxt2.TabIndex = 1
        Me.passwordtxt2.UseSystemPasswordChar = True
        '
        'apply
        '
        Me.apply.Location = New System.Drawing.Point(170, 83)
        Me.apply.Name = "apply"
        Me.apply.Size = New System.Drawing.Size(75, 23)
        Me.apply.TabIndex = 2
        Me.apply.Text = "Apply"
        Me.apply.UseVisualStyleBackColor = True
        '
        'Passwordinfo1
        '
        Me.Passwordinfo1.AutoSize = True
        Me.Passwordinfo1.Location = New System.Drawing.Point(6, 2)
        Me.Passwordinfo1.Name = "Passwordinfo1"
        Me.Passwordinfo1.Size = New System.Drawing.Size(247, 26)
        Me.Passwordinfo1.TabIndex = 3
        Me.Passwordinfo1.Text = "Please enter your password below and press apply" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "to change your password to your" & _
            " chosen password"
        '
        'pass
        '
        Me.AcceptButton = Me.apply
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(257, 111)
        Me.Controls.Add(Me.Passwordinfo1)
        Me.Controls.Add(Me.apply)
        Me.Controls.Add(Me.passwordtxt2)
        Me.Controls.Add(Me.passwordtxt1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "pass"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Change Password"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents passwordtxt1 As System.Windows.Forms.TextBox
    Friend WithEvents passwordtxt2 As System.Windows.Forms.TextBox
    Friend WithEvents apply As System.Windows.Forms.Button
    Friend WithEvents Passwordinfo1 As System.Windows.Forms.Label

End Class
