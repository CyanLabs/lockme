Imports System.IO
Imports System.Net
Public Class settings
    Dim aPath As String = Application.StartupPath()
    Dim filename As String = Path.GetFileName(System.Reflection.Assembly.GetEntryAssembly().Location)
    Dim filename1 As String = filename.Replace(".exe", "")
    Dim inisettings As New ini(aPath & "\" & filename1 & ".ini")
    Dim version = Application.ProductVersion.ToString
    Dim client As New WebClient()
    Dim server As String = "http://dl.dropbox.com/u/40828259"
    Dim latestver As String
    Dim changelog As String
    Private Sub settings_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        home.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        openfile.ShowDialog()
    End Sub
    Private Sub openfile_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles openfile.FileOk
        If openfile.FileName.Contains(".png") Or openfile.FileName.Contains(".gif") Or openfile.FileName.Contains(".bmp") Or openfile.FileName.Contains(".jpg") Or openfile.FileName.Contains(".PNG") Or openfile.FileName.Contains(".GIF") Or openfile.FileName.Contains(".JPG") Or openfile.FileName.Contains(".BMP") Then
            home.bgimage.Visible = True
            home.AxWindowsMediaPlayer1.Visible = False
            inisettings.WriteString("Settings", "BGImage", openfile.FileName)
            inisettings.WriteBoolean("Settings", "BGUseVideo", False)
            PictureBox1.ImageLocation = inisettings.GetString("Settings", "BGImage", "")
            PictureBox1.Visible = True
        ElseIf openfile.FileName.Contains(".wm") Or openfile.FileName.Contains(".wmv") Or openfile.FileName.Contains(".asf") Or openfile.FileName.Contains(".m2ts") Or openfile.FileName.Contains(".m2t") Or openfile.FileName.Contains(".mov") Or openfile.FileName.Contains(".qt") Or openfile.FileName.Contains(".avi") Or openfile.FileName.Contains(".wtv") Or openfile.FileName.Contains(".dvr-ms") Or openfile.FileName.Contains(".mp4") Or openfile.FileName.Contains(".m4v") Or openfile.FileName.Contains(".mpeg") Or openfile.FileName.Contains(".mpg") Or openfile.FileName.Contains(".mpe") Or openfile.FileName.Contains(".m1v") Or openfile.FileName.Contains(".mp2") Or openfile.FileName.Contains(".mpv2") Or openfile.FileName.Contains(".mod") Or openfile.FileName.Contains(".vob") Or openfile.FileName.Contains(".WM") Or openfile.FileName.Contains(".WMV") Or openfile.FileName.Contains(".ASF") Or openfile.FileName.Contains(".M2TS") Or openfile.FileName.Contains(".M2T") Or openfile.FileName.Contains(".MOV") Or openfile.FileName.Contains(".QT") Or openfile.FileName.Contains(".AVI") Or openfile.FileName.Contains(".WTV") Or openfile.FileName.Contains(".DVR-MS") Or openfile.FileName.Contains(".MP4") Or openfile.FileName.Contains(".M4V") Or openfile.FileName.Contains(".MPEG") Or openfile.FileName.Contains(".MPG") Or openfile.FileName.Contains(".MPE") Or openfile.FileName.Contains(".M1V") Or openfile.FileName.Contains(".MP2") Or openfile.FileName.Contains(".MPV2") Or openfile.FileName.Contains(".MOD") Or openfile.FileName.Contains(".VOB") Then
            home.bgimage.Visible = False
            home.AxWindowsMediaPlayer1.Visible = True
            inisettings.WriteString("Settings", "BGVideo", openfile.FileName)
            inisettings.WriteBoolean("Settings", "BGUseVideo", True)
            PictureBox1.Invalidate()
            PictureBox1.Visible = False
            AxWindowsMediaPlayer1.URL = inisettings.GetString("Settings", "BGVideo", "")
        End If
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        pass.Show()
    End Sub
    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = False Then
            If My.Computer.FileSystem.FileExists("%Appdata%\Microsoft\Windows\Start Menu\Programs\Startup\Lock Me on Startup.lnk") Then
                My.Computer.FileSystem.DeleteFile("%Appdata%\Microsoft\Windows\Start Menu\Programs\Startup\Lock Me on Startup.lnk")
            End If
        Else
            If My.Computer.FileSystem.FileExists("%Appdata%\Microsoft\Windows\Start Menu\Programs\Startup\Lock Me on Startup.lnk") Then

            Else
                Shell("cmd /c mklink " & Chr(34) & "%Appdata%\Microsoft\Windows\Start Menu\Programs\Startup\Lock Me on Startup.lnk" & Chr(34) & " " & Chr(34) & Application.ExecutablePath() & " -Startup" & Chr(34))
            End If
        End If
    End Sub
    Private Sub settings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = inisettings.GetString("Language", "Settings Window Title", "Settings")
        GroupBox1.Text = inisettings.GetString("Language", "Preview Text", "Background Preview")
        Button3.Text = inisettings.GetString("Language", "Change Password Button Text", "Change Password")
        Button1.Text = inisettings.GetString("Language", "Update Button Text", "Check For Updates")
        Button2.Text = inisettings.GetString("Language", "Change Background/Video Button Text", "Change BG")
        Button4.Text = inisettings.GetString("Language", "What's New Button Text", "What's New?")
        Label4.Text = inisettings.GetString("Language", "Transparent Text", "Transparent")
        Label5.Text = inisettings.GetString("Language", "Opaque Text", "Opaque")
        GroupBox3.Text = inisettings.GetString("Language", "Background Transparency Text", "Background Transparency")
        groupBox5.Text = inisettings.GetString("Language", "Extras Text", "Extras")
        CheckBox1.Text = inisettings.GetString("Language", "Restart Explorer Text", "Close and Restart explorer.exe")
        CheckBox3.Text = inisettings.GetString("Language", "Auto-Start", "Add to startup")

            client.Credentials = CredentialCache.DefaultCredentials
            AxWindowsMediaPlayer1.settings.setMode("loop", True)
            AxWindowsMediaPlayer1.uiMode = "none"
            TrackBar1.Value = inisettings.GetString("Settings", "Opacity", 100)
            CheckBox1.Checked = inisettings.GetString("Settings", "CloseExplorer", 0)
            checkBox2.Checked = inisettings.GetBoolean("Settings", "SaveAuth", False)
            If My.Computer.FileSystem.FileExists("%Appdata%\Microsoft\Windows\Start Menu\Programs\Startup\Lock Me on Startup.lnk") Then
                CheckBox3.Checked = True
            Else
                CheckBox3.Checked = False
            End If
            textBox1.Text = inisettings.GetString("Settings", "ProxyUser", "")
            textBox2.Text = inisettings.GetString("Settings", "ProxyPass", "")
    End Sub

    Private Sub TrackBar1_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar1.Scroll
        Me.Opacity = TrackBar1.Value / 100
        inisettings.WriteString("Settings", "Opacity", TrackBar1.Value)
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            inisettings.WriteString("Settings", "CloseExplorer", 1)
        Else
            inisettings.WriteString("Settings", "CloseExplorer", 0)
        End If
    End Sub   
    Sub Button1Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        client.Proxy.Credentials = New NetworkCredential(textBox1.Text, textBox2.Text)
        Try
            latestver = client.DownloadString(New Uri(server & "/applications/lockme/version.txt"))
            If latestver > version Then
                Dim update = MsgBox("There is a new version avaliable" & vbNewLine & "Download V" & latestver & "?", MsgBoxStyle.Information + MsgBoxStyle.OkCancel, "Update")
                If update = Windows.Forms.DialogResult.OK Then
                    client.DownloadFile(server & "/applications/lockme/lock_me_updater.exe", "lock_me_updater.exe")
                    client.DownloadFile(server & "/applications/lockme/changelog", "changelog.txt")
                    Shell(aPath + "\lock_me_updater.exe", vbHide)
                    Shell("taskkill /f /im " + filename, vbHide)
                End If
            Else
                MsgBox("No new version availiable", MsgBoxStyle.Information, "No New Updates")
            End If
        Catch ex As WebException
            If ex.Message.Contains("404") Then
                MsgBox("Unable To Connect to the Internet" + vbNewLine + "Please confirm you have a active network connection and are connected to the internet")
            ElseIf ex.Message.Contains("407") Then
                MsgBox("Proxy Authentication Failed" + vbNewLine + "Please confirm you have entered the correct credentials on the settings form")
            End If
        End Try
    End Sub
    
    Sub TextBox1TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles textBox1.TextChanged
        inisettings.WriteString("Settings", "ProxyUser", textBox1.Text)
    End Sub

    
    Sub Button5Click(ByVal sender As Object, ByVal e As EventArgs) Handles button5.Click
        inisettings.WriteString("Settings", "ProxyUser", textBox1.Text)

        If inisettings.GetBoolean("Settings", "SaveAuth", False) = True Then
            inisettings.WriteString("Settings", "ProxyPass", textBox2.Text)
        Else : inisettings.WriteString("Settings", "ProxyPass", "")
        End If

    End Sub
    
    Sub CheckBox2CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox2.CheckedChanged
        If checkBox2.Checked = True Then
            inisettings.WriteBoolean("Settings", "SaveAuth", True)
        Else
            inisettings.WriteBoolean("Settings", "SaveAuth", False)
        End If
    End Sub
End Class