Imports System.IO
Imports System
Imports System.Configuration
Imports System.Resources

Public Class home
    Private Declare Function GetAsyncKeyState Lib "user32" (ByVal vkey As Long) As Integer 'used for global keybinds
    Dim args = My.Application.CommandLineArgs, aPath As String = Application.StartupPath() 'shortcuts commandlinargs to args
    Dim kill As String = "cmd /c taskkill /im ", forcekill As String = "cmd /c taskkill /f /im ", closable As Boolean = False 'add various variables
    Dim filename As String = Path.GetFileName(System.Reflection.Assembly.GetEntryAssembly().Location) 'gets the filename of the program
    Dim filename1 As String = filename.Replace(".exe", "") 'removes .exe from filename variable above
    Dim inisettings As New ini(aPath & "\" & filename1 & ".ini") 'dims inisettings as new ini reader/writer
    Dim language As New ini(aPath & "\" & inisettings.GetString("Settings", "Language", "en") & ".lang")

    Private Sub home_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label1.Text = "Locked By " + Environment.UserName + " - Lock Me v" + Application.ProductVersion + " - Created by Fma965 and Dheppell © ForgottenCoders.co.uk"

        If File.Exists("lock_me_updater.exe") Then
            Shell("taskkill /f /im lock_me_updater.exe", vbHide)
            IO.File.Delete("lock_me_updater.exe")
        End If

        settings.Close() 'closes settings form if open

        If File.Exists(aPath & "\" & filename1 & ".ini") Then 'checks if ini file exists
            unlockbtn.Text = language.GetString("Language", "Unlock Button Text", "Unlock")
            settingsbtn.Text = language.GetString("Language", "Settings Button Text", "Settings")
            notifyicon1.BalloonTipText = language.GetString("Language", "Tray Icon Message", "Press Ctrl and L or Windows and L to instantly lock computer")
        Else
            inisettings.WriteString("Language Lockscreen", "01", "Unlock")
            inisettings.WriteString("Language Lockscreen", "02", "Settings")
            inisettings.WriteString("Language Lockscreen", "03", "Press Ctrl and L or Windows and L to instantly lock computer")
            inisettings.WriteString("Language Lockscreen", "04", "Settings")
            inisettings.WriteString("Language Settings", "01", "Background Preview")
            inisettings.WriteString("Language Settings", "02", "Change Password")
            inisettings.WriteString("Language Settings", "03", "Check For Updates")
            inisettings.WriteString("Language Settings", "04", "Change BG")
            inisettings.WriteString("Language Settings", "05", "What's New?")
            inisettings.WriteString("Language Settings", "06", "Transparent")
            inisettings.WriteString("Language Settings", "07", "Opaque")
            inisettings.WriteString("Language Settings", "08", "Background Transparency")
            inisettings.WriteString("Language Settings", "09", "Extras")
            inisettings.WriteString("Language Settings", "10", "Close and Restart explorer.exe")
            inisettings.WriteString("Language Settings", "11", "Add to startup")
            Me.TopMost = False 'stop this from being top form
            pass.Show() 'loads pass form
            lang.Show()

        End If

        processkiller.Start() 'runs timer that checks if taskmgr or shutdown.exe are running and if they are closing them
        Time.Start() 'starts the clock ticking
        AxWindowsMediaPlayer1.settings.setMode("loop", True) 'changes mediaplayer to loop mode
        AxWindowsMediaPlayer1.uiMode = "none" 'removes the ui from the media player

        If args.Contains("-startup") Then 'checks for -startup after filename in a shorcut e.g. lock me.exe -startup
            Timer1.Start()
            notifyicon1.ShowBalloonTip(5000)
            processkiller.Stop()
        Else
            Me.WindowState = FormWindowState.Maximized
            notifyicon1.Visible = False
            If inisettings.GetString("Settings", "CloseExplorer", 0) = 1 Then
                Shell(forcekill & "explorer.exe")
            End If
        End If

        Me.Opacity = inisettings.GetString("Settings", "Opacity", 100) / 100 'get the forms opacity from the ini file "filename.ini" if no file uses 100%

        If inisettings.GetBoolean("Settings", "BGUseVideo", False) Then 'checks if you want to use video or not
            AxWindowsMediaPlayer1.Visible = True 'shows video player
            AxWindowsMediaPlayer1.URL = inisettings.GetString("Settings", "BGVideo", "") 'gets location of the video
            bgimage.Visible = False 'hides image
        Else 'you use image instead
            AxWindowsMediaPlayer1.Visible = False 'hide video player
            AxWindowsMediaPlayer1.Ctlcontrols.stop() 'stops the player
            bgimage.Visible = True 'shows image
        End If

        If inisettings.GetString("Settings", "BGImage", "") = "" Then 'checks if setting is blank if so do nothing
        Else
            bgimage.ImageLocation = inisettings.GetString("Settings", "BGImage", "") 'sets background image to location in ini file
        End If

        closable = False ' makes it so its not possible to close form
    End Sub
    Private Sub button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles unlockbtn.Click
        If StringToMD5(TextBox1.Text) = inisettings.GetString("Settings", "Password", "") Then
            closable = True
            If inisettings.GetString("Settings", "CloseExplorer", 0) = 1 Then
                Process.Start("c:\windows\explorer.exe")
            End If
                If args.Contains("-startup") Then
                    processkiller.Stop()
                    Me.Hide()
            Else
                Me.Close()
                End If
            End If
        TextBox1.Clear()
    End Sub
    Private Sub settingsbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles settingsbtn.Click
        If StringToMD5(TextBox1.Text) = inisettings.GetString("Settings", "Password", "") Then
            closable = True
            If inisettings.GetString("Settings", "CloseExplorer", 0) = 1 Then
                Process.Start("c:\windows\explorer.exe")
            End If
            If args.Contains("-startup") Then
                processkiller.Stop()
                Me.Hide()
            Else
                settings.Show()
                Me.Close()
            End If
        End If
        TextBox1.Clear()
    End Sub
    Private Sub CloseLockMeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseLockMeToolStripMenuItem.Click
        closable = True
        Me.Close()
    End Sub

    Private Sub notifyicon1_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles notifyicon1.MouseDoubleClick
        If inisettings.GetString("Settings", "CloseExplorer", 0) = 1 Then
            Shell(forcekill & "explorer.exe")
        End If
        Timer1.Stop()
        Me.Show()
        processkiller.Start()
        Me.WindowState = FormWindowState.Maximized
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.Hide()
        Timer1.Stop()
    End Sub
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        ' the code below basically just hides/shows the ui except the bg image or video by pressing the HOME key
        If keyData = (Keys.Home) Then
            If Panel1.Visible = False Then
                Label1.Visible = True
                TextBox1.Visible = True
                unlockbtn.Visible = True
                Panel1.Visible = True
            Else
                Label1.Visible = False
                TextBox1.Visible = False
                unlockbtn.Visible = False
                Panel1.Visible = False
            End If
            Return True
        End If
        Return False
    End Function
    Protected Overrides Function ProcessDialogKey(ByVal keyData As System.Windows.Forms.Keys) As Boolean
        Select Case (keyData)
            Case Keys.Control
                Return True
            Case Keys.Alt Or Keys.F4
                Return True
            Case Keys.Alt Or Keys.Tab
                Return True
            Case Keys.LWin Or Keys.Tab
                Return True
            Case Keys.ControlKey Or Keys.ShiftKey Or Keys.Escape
                Return True
        End Select
        Return MyBase.ProcessDialogKey(keyData)
    End Function
    Private Sub processkiller_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles processkiller.Tick
        If ProcessesRunning("taskmgr") > 0 Then
            Shell(forcekill + "taskmgr.exe", vbHide)
        End If
        If ProcessesRunning("tm") > 0 Then
            Shell(forcekill + "tm.exe", vbHide)
        End If
        If ProcessesRunning("shutdown") > 0 Then
            Shell("cmd /c shutdown -a", vbHide)
        End If
    End Sub
    Public Function ProcessesRunning(ByVal ProcessName As String) As Integer
        Try
            Return Process.GetProcessesByName(ProcessName).GetUpperBound(0) + 1
        Catch
            Return 0
        End Try
    End Function
    Private Sub home_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If closable = False Then
            e.Cancel = True
        End If
    End Sub
    Sub Timer2Tick(ByVal sender As Object, ByVal e As EventArgs) Handles timer2.Tick
        Dim winkey As Boolean
        Dim l As Boolean
        Dim ctrl As Boolean
        winkey = GetAsyncKeyState(Keys.LWin)
        ctrl = GetAsyncKeyState(Keys.LControlKey)
        l = GetAsyncKeyState(Keys.L)
        If winkey And l = True Then
            If inisettings.GetString("Settings", "CloseExplorer", 0) = 1 Then
                Shell(forcekill & "explorer.exe")
            End If
            processkiller.Start()
            Me.Show()
            Me.WindowState = FormWindowState.Maximized
        Else
        End If
        If ctrl And l = True Then
            If inisettings.GetString("Settings", "CloseExplorer", 0) = 1 Then
                Shell(forcekill & "explorer.exe")
            End If
            processkiller.Start()
            Me.Show()
            Me.WindowState = FormWindowState.Maximized
        End If
    End Sub
End Class
