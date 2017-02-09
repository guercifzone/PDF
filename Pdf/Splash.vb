Public Class Splash


    Private Sub Splash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(+1)
        If ProgressBar1.Value = 10 Then
            PictureBox1.Visible = True
            PictureBox2.Visible = False
        ElseIf ProgressBar1.Value = 25 Then
            PictureBox1.Visible = False
            PictureBox2.Visible = True
        ElseIf ProgressBar1.Value = 40 Then
            PictureBox1.Visible = True
            PictureBox2.Visible = False
        ElseIf ProgressBar1.Value = 65 Then
            PictureBox1.Visible = False
            PictureBox2.Visible = True
        ElseIf ProgressBar1.Value = 75 Then
            PictureBox1.Visible = True
            PictureBox2.Visible = False
        ElseIf ProgressBar1.Value = 82 Then
            PictureBox1.Visible = False
            PictureBox2.Visible = False
        ElseIf ProgressBar1.Value = 90 Then
            PictureBox1.Visible = True
            PictureBox2.Visible = True
        ElseIf ProgressBar1.Value = 95 Then
            main.Show()
        ElseIf ProgressBar1.Value = 100 Then
            Timer1.Stop()
            Me.Close()

        End If

    End Sub
End Class