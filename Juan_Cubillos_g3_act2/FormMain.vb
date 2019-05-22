Public Class FormMain

#Region "Declaración de variables y constantes Globales al formulario"

    Private Const MESSAGE_COPYRIGHT = "Derechos de autor © 2019 por Juan Sebastián Cubillos Gonzalez. Todos los derechos reservados"

#End Region


#Region "Métodos y eventos para controlar el funcionamiento de la evaluación"

    ' Boton menu examenes del formulario principal, JSCG, UNAD, 20190518
    Private Sub EvaluationStep2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EvaluationStep2ToolStripMenuItem.Click
        Dim selection As DialogResult
        selection = MessageBox.Show("Buen día respetado estudiante." + vbCr + vbCr + "Al iniciar el examen solo contara con 3 minutos, por cada nivel." + "¿Desea continuar?", "Confirmar inicio evaluación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If selection = vbYes Then
            Me.Hide()
            'Dim formLevel1Assessment = New FormLevel2Assessment
            Dim formLevel1Assessment = New FormLevel1Assessment
            formLevel1Assessment.ShowDialog()
        Else
            MessageBox.Show("Usted ha cancelado el inicio de la evaluación.")
        End If
    End Sub

    ' Método principal del formulario, JSCG, UNAD, 20190521
    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LinkLabelCopyright.Text = MESSAGE_COPYRIGHT
    End Sub

    ' Método para controlar los derechos de autor, JSCG, UNAD, 20190521
    Private Sub LinkLabelCopyright_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelCopyright.LinkClicked
        MessageBox.Show("Las imagenes usadas, en este sistema, son diseñadas por terceros y estan protegidas por derechos de autor, para más detalles lo invitamos ir a: https://www.freepikcompany.com/copyright", "Derechos de autor terceros")
        Process.Start("https://www.freepikcompany.com/copyright")
    End Sub

#End Region

End Class