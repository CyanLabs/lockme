Imports System.Net
Imports System.IO

Public Class lang
    Dim aPath As String = Application.StartupPath()
    Dim filename As String = Path.GetFileName(System.Reflection.Assembly.GetEntryAssembly().Location)
    Dim filename1 As String = filename.Replace(".exe", "")
    Dim inisettings As New ini(aPath & "\" & filename1 & ".ini")
    Dim client As New WebClient()
    Dim server As String = "http://dl.dropbox.com/u/40828259"
    Dim language As String
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ComboBox1.Text = "English" Then
            language = "en.lang"
            Me.Close()
        ElseIf ComboBox1.Text = "Français" Then
            language = "fr.lang"
        ElseIf ComboBox1.Text = "Español" Then
            language = "es.lang"
        ElseIf ComboBox1.Text = "Deutsch" Then
            language = "de.lang"
        ElseIf ComboBox1.Text = "Italiano" Then
            language = "it.lang"
        End If
        If File.Exists(language) Then
            inisettings.WriteString("Settings", "Language", ComboBox1.Text)
        Else
            Try
                client.DownloadFile(server & "/applications/lockme/languages/" + language, language)
            Catch ex As WebException
                If ex.Message.Contains("404") Then
                    MsgBox("Unable To Connect to the Internet" + vbNewLine + "Please confirm you have a active network connection and are connected to the internet")
                ElseIf ex.Message.Contains("407") Then
                    MsgBox("Proxy Authentication Failed" + vbNewLine + "Proxy authentication not supported for language download." + vbNewLine + " please download language pack from forgottencoders.co.uk")
                End If
            End Try
            inisettings.WriteString("Settings", "Language", ComboBox1.Text)
        End If
        Me.Close()
    End Sub
End Class