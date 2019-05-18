<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLevel1Assessment
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLevel1Assessment))
        Me.PanelQuestions = New System.Windows.Forms.Panel()
        Me.PanelOptions = New System.Windows.Forms.Panel()
        Me.PanelTime = New System.Windows.Forms.Panel()
        Me.TimerFormLevel1Assessment = New System.Windows.Forms.Timer(Me.components)
        Me.LabelTimer = New System.Windows.Forms.Label()
        Me.PanelFirstQuestion = New System.Windows.Forms.Panel()
        Me.LabelFirstQuestion = New System.Windows.Forms.Label()
        Me.GroupBoxFirstQuestion = New System.Windows.Forms.GroupBox()
        Me.RadioButtonOptionAFirstQuestion = New System.Windows.Forms.RadioButton()
        Me.RadioButtonOptionBFirstQuestion = New System.Windows.Forms.RadioButton()
        Me.RadioButtonOptionCFirstQuestion = New System.Windows.Forms.RadioButton()
        Me.RadioButtonOptionDFirstQuestion = New System.Windows.Forms.RadioButton()
        Me.ButtonCompleteEvaluation = New System.Windows.Forms.Button()
        Me.ButtonExit = New System.Windows.Forms.Button()
        Me.LabelQuestionValueFirstQuestion = New System.Windows.Forms.Label()
        Me.PanelSecondQuestion = New System.Windows.Forms.Panel()
        Me.LabelQuestionValueSecondQuestion = New System.Windows.Forms.Label()
        Me.GroupBoxSecondQuestion = New System.Windows.Forms.GroupBox()
        Me.RadioButtonOptionDSecondQuestion = New System.Windows.Forms.RadioButton()
        Me.RadioButtonOptionCSecondQuestion = New System.Windows.Forms.RadioButton()
        Me.RadioButtonOptionBSecondQuestion = New System.Windows.Forms.RadioButton()
        Me.RadioButtonOptionASecondQuestion = New System.Windows.Forms.RadioButton()
        Me.LabelSecondQuestion = New System.Windows.Forms.Label()
        Me.PanelThirdQuestion = New System.Windows.Forms.Panel()
        Me.LabelQuestionValueThirdQuestion = New System.Windows.Forms.Label()
        Me.GroupBoxThirdQuestion = New System.Windows.Forms.GroupBox()
        Me.RadioButtonOptionDThirdQuestion = New System.Windows.Forms.RadioButton()
        Me.RadioButtonOptionCThirdQuestion = New System.Windows.Forms.RadioButton()
        Me.RadioButtonOptionBThirdQuestion = New System.Windows.Forms.RadioButton()
        Me.RadioButtonOptionAThirdQuestion = New System.Windows.Forms.RadioButton()
        Me.LabelThirdQuestion = New System.Windows.Forms.Label()
        Me.PanelQuestions.SuspendLayout()
        Me.PanelOptions.SuspendLayout()
        Me.PanelTime.SuspendLayout()
        Me.PanelFirstQuestion.SuspendLayout()
        Me.GroupBoxFirstQuestion.SuspendLayout()
        Me.PanelSecondQuestion.SuspendLayout()
        Me.GroupBoxSecondQuestion.SuspendLayout()
        Me.PanelThirdQuestion.SuspendLayout()
        Me.GroupBoxThirdQuestion.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelQuestions
        '
        Me.PanelQuestions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelQuestions.Controls.Add(Me.PanelThirdQuestion)
        Me.PanelQuestions.Controls.Add(Me.PanelSecondQuestion)
        Me.PanelQuestions.Controls.Add(Me.PanelFirstQuestion)
        Me.PanelQuestions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelQuestions.Location = New System.Drawing.Point(200, 0)
        Me.PanelQuestions.Name = "PanelQuestions"
        Me.PanelQuestions.Size = New System.Drawing.Size(488, 659)
        Me.PanelQuestions.TabIndex = 0
        '
        'PanelOptions
        '
        Me.PanelOptions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelOptions.Controls.Add(Me.ButtonExit)
        Me.PanelOptions.Controls.Add(Me.ButtonCompleteEvaluation)
        Me.PanelOptions.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelOptions.Location = New System.Drawing.Point(0, 659)
        Me.PanelOptions.Name = "PanelOptions"
        Me.PanelOptions.Size = New System.Drawing.Size(688, 49)
        Me.PanelOptions.TabIndex = 1
        '
        'PanelTime
        '
        Me.PanelTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelTime.Controls.Add(Me.LabelTimer)
        Me.PanelTime.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelTime.Location = New System.Drawing.Point(0, 0)
        Me.PanelTime.Name = "PanelTime"
        Me.PanelTime.Size = New System.Drawing.Size(200, 659)
        Me.PanelTime.TabIndex = 2
        '
        'TimerFormLevel1Assessment
        '
        Me.TimerFormLevel1Assessment.Interval = 1000
        '
        'LabelTimer
        '
        Me.LabelTimer.AutoSize = True
        Me.LabelTimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTimer.ForeColor = System.Drawing.SystemColors.Highlight
        Me.LabelTimer.Location = New System.Drawing.Point(21, 9)
        Me.LabelTimer.Name = "LabelTimer"
        Me.LabelTimer.Size = New System.Drawing.Size(156, 58)
        Me.LabelTimer.TabIndex = 0
        Me.LabelTimer.Text = "03:00"
        '
        'PanelFirstQuestion
        '
        Me.PanelFirstQuestion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelFirstQuestion.Controls.Add(Me.LabelQuestionValueFirstQuestion)
        Me.PanelFirstQuestion.Controls.Add(Me.GroupBoxFirstQuestion)
        Me.PanelFirstQuestion.Controls.Add(Me.LabelFirstQuestion)
        Me.PanelFirstQuestion.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelFirstQuestion.Location = New System.Drawing.Point(0, 0)
        Me.PanelFirstQuestion.Name = "PanelFirstQuestion"
        Me.PanelFirstQuestion.Size = New System.Drawing.Size(486, 189)
        Me.PanelFirstQuestion.TabIndex = 0
        '
        'LabelFirstQuestion
        '
        Me.LabelFirstQuestion.AutoSize = True
        Me.LabelFirstQuestion.Location = New System.Drawing.Point(4, 39)
        Me.LabelFirstQuestion.Name = "LabelFirstQuestion"
        Me.LabelFirstQuestion.Size = New System.Drawing.Size(359, 17)
        Me.LabelFirstQuestion.TabIndex = 0
        Me.LabelFirstQuestion.Text = "1. La estructura de control IF, es un condicional de tipo:"
        '
        'GroupBoxFirstQuestion
        '
        Me.GroupBoxFirstQuestion.Controls.Add(Me.RadioButtonOptionDFirstQuestion)
        Me.GroupBoxFirstQuestion.Controls.Add(Me.RadioButtonOptionCFirstQuestion)
        Me.GroupBoxFirstQuestion.Controls.Add(Me.RadioButtonOptionBFirstQuestion)
        Me.GroupBoxFirstQuestion.Controls.Add(Me.RadioButtonOptionAFirstQuestion)
        Me.GroupBoxFirstQuestion.Location = New System.Drawing.Point(9, 72)
        Me.GroupBoxFirstQuestion.Name = "GroupBoxFirstQuestion"
        Me.GroupBoxFirstQuestion.Size = New System.Drawing.Size(465, 106)
        Me.GroupBoxFirstQuestion.TabIndex = 2
        Me.GroupBoxFirstQuestion.TabStop = False
        Me.GroupBoxFirstQuestion.Text = "Opciones"
        '
        'RadioButtonOptionAFirstQuestion
        '
        Me.RadioButtonOptionAFirstQuestion.AutoSize = True
        Me.RadioButtonOptionAFirstQuestion.Location = New System.Drawing.Point(18, 21)
        Me.RadioButtonOptionAFirstQuestion.Name = "RadioButtonOptionAFirstQuestion"
        Me.RadioButtonOptionAFirstQuestion.Size = New System.Drawing.Size(96, 21)
        Me.RadioButtonOptionAFirstQuestion.TabIndex = 0
        Me.RadioButtonOptionAFirstQuestion.TabStop = True
        Me.RadioButtonOptionAFirstQuestion.Text = "A. Iterativa"
        Me.RadioButtonOptionAFirstQuestion.UseVisualStyleBackColor = True
        '
        'RadioButtonOptionBFirstQuestion
        '
        Me.RadioButtonOptionBFirstQuestion.AutoSize = True
        Me.RadioButtonOptionBFirstQuestion.Location = New System.Drawing.Point(18, 62)
        Me.RadioButtonOptionBFirstQuestion.Name = "RadioButtonOptionBFirstQuestion"
        Me.RadioButtonOptionBFirstQuestion.Size = New System.Drawing.Size(98, 21)
        Me.RadioButtonOptionBFirstQuestion.TabIndex = 1
        Me.RadioButtonOptionBFirstQuestion.TabStop = True
        Me.RadioButtonOptionBFirstQuestion.Text = "B. Proceso"
        Me.RadioButtonOptionBFirstQuestion.UseVisualStyleBackColor = True
        '
        'RadioButtonOptionCFirstQuestion
        '
        Me.RadioButtonOptionCFirstQuestion.AutoSize = True
        Me.RadioButtonOptionCFirstQuestion.Location = New System.Drawing.Point(283, 21)
        Me.RadioButtonOptionCFirstQuestion.Name = "RadioButtonOptionCFirstQuestion"
        Me.RadioButtonOptionCFirstQuestion.Size = New System.Drawing.Size(100, 21)
        Me.RadioButtonOptionCFirstQuestion.TabIndex = 2
        Me.RadioButtonOptionCFirstQuestion.TabStop = True
        Me.RadioButtonOptionCFirstQuestion.Text = "C. Decisión"
        Me.RadioButtonOptionCFirstQuestion.UseVisualStyleBackColor = True
        '
        'RadioButtonOptionDFirstQuestion
        '
        Me.RadioButtonOptionDFirstQuestion.AutoSize = True
        Me.RadioButtonOptionDFirstQuestion.Location = New System.Drawing.Point(283, 62)
        Me.RadioButtonOptionDFirstQuestion.Name = "RadioButtonOptionDFirstQuestion"
        Me.RadioButtonOptionDFirstQuestion.Size = New System.Drawing.Size(77, 21)
        Me.RadioButtonOptionDFirstQuestion.TabIndex = 3
        Me.RadioButtonOptionDFirstQuestion.TabStop = True
        Me.RadioButtonOptionDFirstQuestion.Text = "D. Flujo"
        Me.RadioButtonOptionDFirstQuestion.UseVisualStyleBackColor = True
        '
        'ButtonCompleteEvaluation
        '
        Me.ButtonCompleteEvaluation.Location = New System.Drawing.Point(360, 12)
        Me.ButtonCompleteEvaluation.Name = "ButtonCompleteEvaluation"
        Me.ButtonCompleteEvaluation.Size = New System.Drawing.Size(84, 23)
        Me.ButtonCompleteEvaluation.TabIndex = 0
        Me.ButtonCompleteEvaluation.Text = "Finalizar"
        Me.ButtonCompleteEvaluation.UseVisualStyleBackColor = True
        '
        'ButtonExit
        '
        Me.ButtonExit.Location = New System.Drawing.Point(242, 12)
        Me.ButtonExit.Name = "ButtonExit"
        Me.ButtonExit.Size = New System.Drawing.Size(84, 23)
        Me.ButtonExit.TabIndex = 1
        Me.ButtonExit.Text = "Salir"
        Me.ButtonExit.UseVisualStyleBackColor = True
        '
        'LabelQuestionValueFirstQuestion
        '
        Me.LabelQuestionValueFirstQuestion.AutoSize = True
        Me.LabelQuestionValueFirstQuestion.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelQuestionValueFirstQuestion.Location = New System.Drawing.Point(6, 8)
        Me.LabelQuestionValueFirstQuestion.Name = "LabelQuestionValueFirstQuestion"
        Me.LabelQuestionValueFirstQuestion.Size = New System.Drawing.Size(68, 17)
        Me.LabelQuestionValueFirstQuestion.TabIndex = 3
        Me.LabelQuestionValueFirstQuestion.Text = "Puntos: 1"
        '
        'PanelSecondQuestion
        '
        Me.PanelSecondQuestion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelSecondQuestion.Controls.Add(Me.LabelQuestionValueSecondQuestion)
        Me.PanelSecondQuestion.Controls.Add(Me.GroupBoxSecondQuestion)
        Me.PanelSecondQuestion.Controls.Add(Me.LabelSecondQuestion)
        Me.PanelSecondQuestion.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSecondQuestion.Location = New System.Drawing.Point(0, 189)
        Me.PanelSecondQuestion.Name = "PanelSecondQuestion"
        Me.PanelSecondQuestion.Size = New System.Drawing.Size(486, 189)
        Me.PanelSecondQuestion.TabIndex = 5
        '
        'LabelQuestionValueSecondQuestion
        '
        Me.LabelQuestionValueSecondQuestion.AutoSize = True
        Me.LabelQuestionValueSecondQuestion.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelQuestionValueSecondQuestion.Location = New System.Drawing.Point(6, 8)
        Me.LabelQuestionValueSecondQuestion.Name = "LabelQuestionValueSecondQuestion"
        Me.LabelQuestionValueSecondQuestion.Size = New System.Drawing.Size(68, 17)
        Me.LabelQuestionValueSecondQuestion.TabIndex = 3
        Me.LabelQuestionValueSecondQuestion.Text = "Puntos: 1"
        '
        'GroupBoxSecondQuestion
        '
        Me.GroupBoxSecondQuestion.Controls.Add(Me.RadioButtonOptionDSecondQuestion)
        Me.GroupBoxSecondQuestion.Controls.Add(Me.RadioButtonOptionCSecondQuestion)
        Me.GroupBoxSecondQuestion.Controls.Add(Me.RadioButtonOptionBSecondQuestion)
        Me.GroupBoxSecondQuestion.Controls.Add(Me.RadioButtonOptionASecondQuestion)
        Me.GroupBoxSecondQuestion.Location = New System.Drawing.Point(9, 72)
        Me.GroupBoxSecondQuestion.Name = "GroupBoxSecondQuestion"
        Me.GroupBoxSecondQuestion.Size = New System.Drawing.Size(465, 106)
        Me.GroupBoxSecondQuestion.TabIndex = 2
        Me.GroupBoxSecondQuestion.TabStop = False
        Me.GroupBoxSecondQuestion.Text = "Opciones"
        '
        'RadioButtonOptionDSecondQuestion
        '
        Me.RadioButtonOptionDSecondQuestion.AutoSize = True
        Me.RadioButtonOptionDSecondQuestion.Location = New System.Drawing.Point(283, 62)
        Me.RadioButtonOptionDSecondQuestion.Name = "RadioButtonOptionDSecondQuestion"
        Me.RadioButtonOptionDSecondQuestion.Size = New System.Drawing.Size(79, 21)
        Me.RadioButtonOptionDSecondQuestion.TabIndex = 3
        Me.RadioButtonOptionDSecondQuestion.TabStop = True
        Me.RadioButtonOptionDSecondQuestion.Text = "D. 1992"
        Me.RadioButtonOptionDSecondQuestion.UseVisualStyleBackColor = True
        '
        'RadioButtonOptionCSecondQuestion
        '
        Me.RadioButtonOptionCSecondQuestion.AutoSize = True
        Me.RadioButtonOptionCSecondQuestion.Location = New System.Drawing.Point(283, 21)
        Me.RadioButtonOptionCSecondQuestion.Name = "RadioButtonOptionCSecondQuestion"
        Me.RadioButtonOptionCSecondQuestion.Size = New System.Drawing.Size(78, 21)
        Me.RadioButtonOptionCSecondQuestion.TabIndex = 2
        Me.RadioButtonOptionCSecondQuestion.TabStop = True
        Me.RadioButtonOptionCSecondQuestion.Text = "C. 1980"
        Me.RadioButtonOptionCSecondQuestion.UseVisualStyleBackColor = True
        '
        'RadioButtonOptionBSecondQuestion
        '
        Me.RadioButtonOptionBSecondQuestion.AutoSize = True
        Me.RadioButtonOptionBSecondQuestion.Location = New System.Drawing.Point(18, 62)
        Me.RadioButtonOptionBSecondQuestion.Name = "RadioButtonOptionBSecondQuestion"
        Me.RadioButtonOptionBSecondQuestion.Size = New System.Drawing.Size(78, 21)
        Me.RadioButtonOptionBSecondQuestion.TabIndex = 1
        Me.RadioButtonOptionBSecondQuestion.TabStop = True
        Me.RadioButtonOptionBSecondQuestion.Text = "B. 1991"
        Me.RadioButtonOptionBSecondQuestion.UseVisualStyleBackColor = True
        '
        'RadioButtonOptionASecondQuestion
        '
        Me.RadioButtonOptionASecondQuestion.AutoSize = True
        Me.RadioButtonOptionASecondQuestion.Location = New System.Drawing.Point(18, 21)
        Me.RadioButtonOptionASecondQuestion.Name = "RadioButtonOptionASecondQuestion"
        Me.RadioButtonOptionASecondQuestion.Size = New System.Drawing.Size(78, 21)
        Me.RadioButtonOptionASecondQuestion.TabIndex = 0
        Me.RadioButtonOptionASecondQuestion.TabStop = True
        Me.RadioButtonOptionASecondQuestion.Text = "A. 2000"
        Me.RadioButtonOptionASecondQuestion.UseVisualStyleBackColor = True
        '
        'LabelSecondQuestion
        '
        Me.LabelSecondQuestion.AutoSize = True
        Me.LabelSecondQuestion.Location = New System.Drawing.Point(4, 39)
        Me.LabelSecondQuestion.Name = "LabelSecondQuestion"
        Me.LabelSecondQuestion.Size = New System.Drawing.Size(369, 17)
        Me.LabelSecondQuestion.TabIndex = 0
        Me.LabelSecondQuestion.Text = "2. La primera versión de Visual Basic, aparece en el año:"
        '
        'PanelThirdQuestion
        '
        Me.PanelThirdQuestion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelThirdQuestion.Controls.Add(Me.LabelQuestionValueThirdQuestion)
        Me.PanelThirdQuestion.Controls.Add(Me.GroupBoxThirdQuestion)
        Me.PanelThirdQuestion.Controls.Add(Me.LabelThirdQuestion)
        Me.PanelThirdQuestion.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelThirdQuestion.Location = New System.Drawing.Point(0, 378)
        Me.PanelThirdQuestion.Name = "PanelThirdQuestion"
        Me.PanelThirdQuestion.Size = New System.Drawing.Size(486, 189)
        Me.PanelThirdQuestion.TabIndex = 7
        '
        'LabelQuestionValueThirdQuestion
        '
        Me.LabelQuestionValueThirdQuestion.AutoSize = True
        Me.LabelQuestionValueThirdQuestion.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelQuestionValueThirdQuestion.Location = New System.Drawing.Point(6, 8)
        Me.LabelQuestionValueThirdQuestion.Name = "LabelQuestionValueThirdQuestion"
        Me.LabelQuestionValueThirdQuestion.Size = New System.Drawing.Size(68, 17)
        Me.LabelQuestionValueThirdQuestion.TabIndex = 3
        Me.LabelQuestionValueThirdQuestion.Text = "Puntos: 1"
        '
        'GroupBoxThirdQuestion
        '
        Me.GroupBoxThirdQuestion.Controls.Add(Me.RadioButtonOptionDThirdQuestion)
        Me.GroupBoxThirdQuestion.Controls.Add(Me.RadioButtonOptionCThirdQuestion)
        Me.GroupBoxThirdQuestion.Controls.Add(Me.RadioButtonOptionBThirdQuestion)
        Me.GroupBoxThirdQuestion.Controls.Add(Me.RadioButtonOptionAThirdQuestion)
        Me.GroupBoxThirdQuestion.Location = New System.Drawing.Point(9, 72)
        Me.GroupBoxThirdQuestion.Name = "GroupBoxThirdQuestion"
        Me.GroupBoxThirdQuestion.Size = New System.Drawing.Size(465, 106)
        Me.GroupBoxThirdQuestion.TabIndex = 2
        Me.GroupBoxThirdQuestion.TabStop = False
        Me.GroupBoxThirdQuestion.Text = "Opciones"
        '
        'RadioButtonOptionDThirdQuestion
        '
        Me.RadioButtonOptionDThirdQuestion.AutoSize = True
        Me.RadioButtonOptionDThirdQuestion.Location = New System.Drawing.Point(283, 62)
        Me.RadioButtonOptionDThirdQuestion.Name = "RadioButtonOptionDThirdQuestion"
        Me.RadioButtonOptionDThirdQuestion.Size = New System.Drawing.Size(91, 21)
        Me.RadioButtonOptionDThirdQuestion.TabIndex = 3
        Me.RadioButtonOptionDThirdQuestion.TabStop = True
        Me.RadioButtonOptionDThirdQuestion.Text = "D. $var1; "
        Me.RadioButtonOptionDThirdQuestion.UseVisualStyleBackColor = True
        '
        'RadioButtonOptionCThirdQuestion
        '
        Me.RadioButtonOptionCThirdQuestion.AutoSize = True
        Me.RadioButtonOptionCThirdQuestion.Location = New System.Drawing.Point(283, 21)
        Me.RadioButtonOptionCThirdQuestion.Name = "RadioButtonOptionCThirdQuestion"
        Me.RadioButtonOptionCThirdQuestion.Size = New System.Drawing.Size(170, 21)
        Me.RadioButtonOptionCThirdQuestion.TabIndex = 2
        Me.RadioButtonOptionCThirdQuestion.TabStop = True
        Me.RadioButtonOptionCThirdQuestion.Text = "C. Dim As Integer var1"
        Me.RadioButtonOptionCThirdQuestion.UseVisualStyleBackColor = True
        '
        'RadioButtonOptionBThirdQuestion
        '
        Me.RadioButtonOptionBThirdQuestion.AutoSize = True
        Me.RadioButtonOptionBThirdQuestion.Location = New System.Drawing.Point(18, 62)
        Me.RadioButtonOptionBThirdQuestion.Name = "RadioButtonOptionBThirdQuestion"
        Me.RadioButtonOptionBThirdQuestion.Size = New System.Drawing.Size(97, 21)
        Me.RadioButtonOptionBThirdQuestion.TabIndex = 1
        Me.RadioButtonOptionBThirdQuestion.TabStop = True
        Me.RadioButtonOptionBThirdQuestion.Text = "B. int var1;"
        Me.RadioButtonOptionBThirdQuestion.UseVisualStyleBackColor = True
        '
        'RadioButtonOptionAThirdQuestion
        '
        Me.RadioButtonOptionAThirdQuestion.AutoSize = True
        Me.RadioButtonOptionAThirdQuestion.Location = New System.Drawing.Point(18, 21)
        Me.RadioButtonOptionAThirdQuestion.Name = "RadioButtonOptionAThirdQuestion"
        Me.RadioButtonOptionAThirdQuestion.Size = New System.Drawing.Size(170, 21)
        Me.RadioButtonOptionAThirdQuestion.TabIndex = 0
        Me.RadioButtonOptionAThirdQuestion.TabStop = True
        Me.RadioButtonOptionAThirdQuestion.Text = "A. Dim var1 As Integer"
        Me.RadioButtonOptionAThirdQuestion.UseVisualStyleBackColor = True
        '
        'LabelThirdQuestion
        '
        Me.LabelThirdQuestion.AutoSize = True
        Me.LabelThirdQuestion.Location = New System.Drawing.Point(4, 39)
        Me.LabelThirdQuestion.Name = "LabelThirdQuestion"
        Me.LabelThirdQuestion.Size = New System.Drawing.Size(369, 17)
        Me.LabelThirdQuestion.TabIndex = 0
        Me.LabelThirdQuestion.Text = "3. ¿Cómo se debe declarar una variable en Visual Basic?"
        '
        'FormLevel1Assessment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(688, 708)
        Me.Controls.Add(Me.PanelQuestions)
        Me.Controls.Add(Me.PanelTime)
        Me.Controls.Add(Me.PanelOptions)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormLevel1Assessment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Evaluación Primer Nivel"
        Me.PanelQuestions.ResumeLayout(False)
        Me.PanelOptions.ResumeLayout(False)
        Me.PanelTime.ResumeLayout(False)
        Me.PanelTime.PerformLayout()
        Me.PanelFirstQuestion.ResumeLayout(False)
        Me.PanelFirstQuestion.PerformLayout()
        Me.GroupBoxFirstQuestion.ResumeLayout(False)
        Me.GroupBoxFirstQuestion.PerformLayout()
        Me.PanelSecondQuestion.ResumeLayout(False)
        Me.PanelSecondQuestion.PerformLayout()
        Me.GroupBoxSecondQuestion.ResumeLayout(False)
        Me.GroupBoxSecondQuestion.PerformLayout()
        Me.PanelThirdQuestion.ResumeLayout(False)
        Me.PanelThirdQuestion.PerformLayout()
        Me.GroupBoxThirdQuestion.ResumeLayout(False)
        Me.GroupBoxThirdQuestion.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelQuestions As Panel
    Friend WithEvents PanelOptions As Panel
    Friend WithEvents PanelTime As Panel
    Friend WithEvents TimerFormLevel1Assessment As Timer
    Friend WithEvents LabelTimer As Label
    Friend WithEvents PanelFirstQuestion As Panel
    Friend WithEvents LabelFirstQuestion As Label
    Friend WithEvents GroupBoxFirstQuestion As GroupBox
    Friend WithEvents RadioButtonOptionAFirstQuestion As RadioButton
    Friend WithEvents RadioButtonOptionBFirstQuestion As RadioButton
    Friend WithEvents RadioButtonOptionCFirstQuestion As RadioButton
    Friend WithEvents RadioButtonOptionDFirstQuestion As RadioButton
    Friend WithEvents ButtonCompleteEvaluation As Button
    Friend WithEvents ButtonExit As Button
    Friend WithEvents LabelQuestionValueFirstQuestion As Label
    Friend WithEvents PanelSecondQuestion As Panel
    Friend WithEvents LabelQuestionValueSecondQuestion As Label
    Friend WithEvents GroupBoxSecondQuestion As GroupBox
    Friend WithEvents RadioButtonOptionDSecondQuestion As RadioButton
    Friend WithEvents RadioButtonOptionCSecondQuestion As RadioButton
    Friend WithEvents RadioButtonOptionBSecondQuestion As RadioButton
    Friend WithEvents RadioButtonOptionASecondQuestion As RadioButton
    Friend WithEvents LabelSecondQuestion As Label
    Friend WithEvents PanelThirdQuestion As Panel
    Friend WithEvents LabelQuestionValueThirdQuestion As Label
    Friend WithEvents GroupBoxThirdQuestion As GroupBox
    Friend WithEvents RadioButtonOptionDThirdQuestion As RadioButton
    Friend WithEvents RadioButtonOptionCThirdQuestion As RadioButton
    Friend WithEvents RadioButtonOptionBThirdQuestion As RadioButton
    Friend WithEvents RadioButtonOptionAThirdQuestion As RadioButton
    Friend WithEvents LabelThirdQuestion As Label
End Class
