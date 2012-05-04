
Public Class Form1
	Public Sub New()
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub
	
	Sub Form1Load(sender As Object, e As EventArgs)
		Dim changelogreader As New system.IO.StreamReader("changelog.txt")
		textbox1.Text = changelogreader.ReadToEnd
	End Sub
End Class
