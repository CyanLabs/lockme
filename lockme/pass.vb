Imports System.IO
Public Class pass
    Dim closable As Boolean = False
    Dim aPath As String = Application.StartupPath()
    Dim filename As String = IO.Path.GetFileName(System.Reflection.Assembly.GetEntryAssembly().Location)
    Dim filename1 As String = filename.Replace(".exe", "")
    Dim inisettings As New ini(aPath & "\" & filename1 & ".ini")
    Sub PassFormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
        If closable = False Then
            e.Cancel = True
        End If
    End Sub
    Sub ApplyClick(ByVal sender As Object, ByVal e As EventArgs) Handles apply.Click
        If passwordtxt1.Text = passwordtxt2.Text Then
            inisettings.WriteString("Settings", "Password", StringToMD5(passwordtxt1.Text))
            home.Show()
            closable = True
            Me.Close()
            home.TopMost = True
        Else : MsgBox("The passwords you entered do not match", MsgBoxStyle.Critical, "Passwords Do not Match")
        End If
    End Sub
End Class

