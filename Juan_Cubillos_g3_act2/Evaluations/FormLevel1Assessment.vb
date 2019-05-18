Public Class FormLevel1Assessment

    Private minutes As Integer
    Private seconds As Integer
    Private Const MAX_SECONDS = 59
    Private Const MAX_MINUTES = 2
    Private Const MIN_FORMAT_SECONDS = 10
    Private studentAnswers() As Integer
    Private setColorTime As Boolean


    Private Sub FormLevel1Assessment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        minutes = MAX_MINUTES
        seconds = MAX_SECONDS
        studentAnswers = New Integer(9) {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
        setColorTime = True
        SetTimeLabelTimer()
        TimerFormLevel1Assessment.Start()
    End Sub

    Private Sub TimerFormLevel1Assessment_Tick(sender As Object, e As EventArgs) Handles TimerFormLevel1Assessment.Tick
        seconds -= 1
        SetTimeLabelTimer()
        If (seconds = 0) And (minutes > 0) Then
            minutes -= 1
            seconds = MAX_SECONDS
        End If
        If minutes <= 0 And setColorTime Then
            LabelTimer.ForeColor = Color.Red
            setColorTime = False
        End If
        If minutes = 0 And seconds = 0 Then
            TimerFormLevel1Assessment.Stop()
            MessageBox.Show("Fin por tiempo", "El tiempo para realizar la evaluación se ha terminado.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub SetTimeLabelTimer()
        LabelTimer.Text = String.Format("0" + minutes.ToString() + ":" + If(seconds < MIN_FORMAT_SECONDS, "0" + seconds.ToString(), seconds.ToString()))
    End Sub

    Private Sub SetAnswer(position As Integer, value As Integer)
        studentAnswers(position) = value
    End Sub
End Class