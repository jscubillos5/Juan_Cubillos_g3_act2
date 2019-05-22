Public Class FormShowResults

#Region "Declaración de variables y constantes Globales al formulario"

    Private totalCorrectAnswersEstudent As Integer
    Private messageStudent As String = "Respetado estudiante, usted ha superado el primer nivel, por ende, sera enviado al segundo."
    Private Const MIN_CORRECT_ANSWERS_NEXT_LEVEL = 6

#End Region

#Region "Métodos y eventos para controlar el funcionamiento de la pantalla de resultados"

    ' Método, que permite recibir variables; desde otros formularios, JSCG, UNAD, 20190521
    Public Sub New(ByVal resultsAssesment As String(), ByVal totalCorrectAnswers As Integer)
        InitializeComponent()
        totalCorrectAnswersEstudent = totalCorrectAnswers
        DataGridViewResults.Rows.Clear()
        For resultAnswer As Integer = 0 To resultsAssesment.Length - 1
            DataGridViewResults.Rows.Add(resultsAssesment(resultAnswer))
        Next
        If totalCorrectAnswersEstudent >= MIN_CORRECT_ANSWERS_NEXT_LEVEL Then
            LabelResult.Text = messageStudent
            LabelResult.ForeColor = Color.Green
        Else
            LabelResult.Text = "Respetado estudiante, usted no ha superado el primer nivel."
            LabelResult.ForeColor = Color.Red
        End If
    End Sub

    ' Evento, de pre-cierre del formulario, JSCG, UNAD, 20190521
    Private Sub FormShowResults_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If totalCorrectAnswersEstudent >= MIN_CORRECT_ANSWERS_NEXT_LEVEL Then
            Dim selection As DialogResult
            selection = MessageBox.Show(messageStudent + vbCr + vbCr + "Al iniciar el examen solo contara con 3 minutos, por cada nivel." + "¿Desea continuar?", "Confirmar inicio evaluación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If selection = vbYes Then
                Hide()
                Dim formLevel2Assessment = New FormLevel2Assessment
                formLevel2Assessment.ShowDialog()
            Else
                MessageBox.Show("Usted ha cancelado el inicio de la evaluación.")
                e.Cancel = True
            End If
        Else
            FormMain.Show()
        End If
    End Sub

    ' Boton, continuar, se envia al método close(), ya que este contiene la validación del segundo examen, JSCG, UNAD, 20190521
    Private Sub ButtonValidate_Click(sender As Object, e As EventArgs) Handles ButtonValidate.Click
        Close()
    End Sub

#End Region

End Class