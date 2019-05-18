Public Class FormMain
    Private Sub EvaluationStep2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EvaluationStep2ToolStripMenuItem.Click
        Dim selection As DialogResult
        selection = MessageBox.Show("Buen día respetado estudiante." + vbCr + vbCr + "Al iniciar el examen solo contara con 3 minutos, por cada nivel." + "¿Desea continuar?", "Confirmar inicio evaluación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If selection = vbYes Then
            Dim formLevel1Assessment = New FormLevel1Assessment
            formLevel1Assessment.ShowDialog()
        Else
            MessageBox.Show("Usted ha cancelado el inicio de la evaluación.")
        End If
    End Sub
End Class