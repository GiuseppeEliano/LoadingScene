Public Class Form1
    Private Sub wait(ByVal interval As Integer)
        Dim sw As New Stopwatch
        sw.Start()
        Do While sw.ElapsedMilliseconds < interval
            Application.DoEvents()
        Loop
        sw.Stop()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        RectangleShape2.Width = 0

        ' If you want to load some contents in background, here is a good place to do
        '

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        RectangleShape2.Width = RectangleShape2.Width + 1
        If RectangleShape2.Width >= 608 Then
            Timer1.Enabled = False

            ' This wait function will only embellish the content =)
            wait(1000)
            '


            Me.Visible = False
            ' Here you will be able to add your own code, like opening a new windows, ou playing a sound like this
            System.Media.SystemSounds.Exclamation.Play()
            '

        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class
