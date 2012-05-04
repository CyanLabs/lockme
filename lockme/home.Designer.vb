<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class home
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(home))
        Me.processkiller = New System.Windows.Forms.Timer(Me.components)
        Me.bgimage = New System.Windows.Forms.PictureBox()
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.settingsbtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.unlockbtn = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Time = New System.Windows.Forms.Timer(Me.components)
        Me.changemessage = New System.Windows.Forms.Timer(Me.components)
        Me.notifyicon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CloseLockMeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.timer2 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.bgimage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'processkiller
        '
        Me.processkiller.Enabled = True
        '
        'bgimage
        '
        Me.bgimage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.bgimage.Image = CType(resources.GetObject("bgimage.Image"), System.Drawing.Image)
        Me.bgimage.Location = New System.Drawing.Point(0, 25)
        Me.bgimage.Name = "bgimage"
        Me.bgimage.Size = New System.Drawing.Size(968, 0)
        Me.bgimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.bgimage.TabIndex = 14
        Me.bgimage.TabStop = False
        '
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(0, 0)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(968, 24)
        Me.AxWindowsMediaPlayer1.TabIndex = 19
        Me.AxWindowsMediaPlayer1.TabStop = False
        Me.AxWindowsMediaPlayer1.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkGray
        Me.Panel1.Controls.Add(Me.settingsbtn)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.unlockbtn)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(968, 25)
        Me.Panel1.TabIndex = 21
        '
        'settingsbtn
        '
        Me.settingsbtn.BackColor = System.Drawing.Color.Black
        Me.settingsbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.settingsbtn.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.settingsbtn.Location = New System.Drawing.Point(367, 0)
        Me.settingsbtn.Name = "settingsbtn"
        Me.settingsbtn.Size = New System.Drawing.Size(81, 25)
        Me.settingsbtn.TabIndex = 15
        Me.settingsbtn.Text = "Settings"
        Me.settingsbtn.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(767, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(0, 6, 3, 0)
        Me.Label1.Size = New System.Drawing.Size(201, 19)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Created By ForgottenCoders        "
        '
        'unlockbtn
        '
        Me.unlockbtn.BackColor = System.Drawing.Color.Black
        Me.unlockbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.unlockbtn.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.unlockbtn.Location = New System.Drawing.Point(280, 0)
        Me.unlockbtn.Name = "unlockbtn"
        Me.unlockbtn.Size = New System.Drawing.Size(81, 25)
        Me.unlockbtn.TabIndex = 5
        Me.unlockbtn.Text = "Unlock!"
        Me.unlockbtn.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Black
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.TextBox1.Location = New System.Drawing.Point(7, 2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(267, 20)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.UseSystemPasswordChar = True
        '
        'Time
        '
        Me.Time.Enabled = True
        Me.Time.Interval = 1000
        '
        'changemessage
        '
        Me.changemessage.Enabled = True
        Me.changemessage.Interval = 8000
        '
        'notifyicon1
        '
        Me.notifyicon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.notifyicon1.BalloonTipText = "Press ""Ctrl"" or ""Windows"" and ""L"" to instantly lock computer"
        Me.notifyicon1.BalloonTipTitle = "Lock Me"
        Me.notifyicon1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.notifyicon1.Icon = CType(resources.GetObject("notifyicon1.Icon"), System.Drawing.Icon)
        Me.notifyicon1.Text = "Lock Me"
        Me.notifyicon1.Visible = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloseLockMeToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(152, 26)
        '
        'CloseLockMeToolStripMenuItem
        '
        Me.CloseLockMeToolStripMenuItem.Name = "CloseLockMeToolStripMenuItem"
        Me.CloseLockMeToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.CloseLockMeToolStripMenuItem.Text = "Close Lock Me"
        '
        'Timer1
        '
        '
        'timer2
        '
        Me.timer2.Enabled = True
        Me.timer2.Interval = 1
        '
        'home
        '
        Me.AcceptButton = Me.unlockbtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(968, 24)
        Me.Controls.Add(Me.bgimage)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "home"
        Me.Opacity = 0.8R
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "Lock Me"
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.Color.DarkViolet
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        CType(Me.bgimage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents processkiller As System.Windows.Forms.Timer
    Friend WithEvents bgimage As System.Windows.Forms.PictureBox
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents unlockbtn As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Time As System.Windows.Forms.Timer
    Friend WithEvents changemessage As System.Windows.Forms.Timer

    Sub NotifyIcon1MouseDoubleClick(ByVal sender As Object, ByVal e As MouseEventArgs)
        Me.show()
    End Sub
    Friend WithEvents notifyicon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents timer2 As System.Windows.Forms.Timer
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CloseLockMeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents settingsbtn As System.Windows.Forms.Button
End Class
