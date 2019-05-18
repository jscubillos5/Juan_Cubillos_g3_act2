<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMain
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
        Me.MenuStripFormPrincipal = New System.Windows.Forms.MenuStrip()
        Me.EvaluationStep2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStripFormPrincipal.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStripFormPrincipal
        '
        Me.MenuStripFormPrincipal.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStripFormPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EvaluationStep2ToolStripMenuItem})
        Me.MenuStripFormPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.MenuStripFormPrincipal.Name = "MenuStripFormPrincipal"
        Me.MenuStripFormPrincipal.Size = New System.Drawing.Size(800, 28)
        Me.MenuStripFormPrincipal.TabIndex = 0
        Me.MenuStripFormPrincipal.Text = "MenuStripFormMain"
        '
        'EvaluationStep2ToolStripMenuItem
        '
        Me.EvaluationStep2ToolStripMenuItem.Name = "EvaluationStep2ToolStripMenuItem"
        Me.EvaluationStep2ToolStripMenuItem.Size = New System.Drawing.Size(130, 24)
        Me.EvaluationStep2ToolStripMenuItem.Text = "Evalución Paso 2"
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStripFormPrincipal)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStripFormPrincipal
        Me.Name = "FormMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Evaluación Paso 2: Diseño de módulos"
        Me.MenuStripFormPrincipal.ResumeLayout(False)
        Me.MenuStripFormPrincipal.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStripFormPrincipal As MenuStrip
    Friend WithEvents EvaluationStep2ToolStripMenuItem As ToolStripMenuItem
End Class
