﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormShowResults
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormShowResults))
        Me.PanelResults = New System.Windows.Forms.Panel()
        Me.DataGridViewResults = New System.Windows.Forms.DataGridView()
        Me.PanelOptions = New System.Windows.Forms.Panel()
        Me.ButtonValidate = New System.Windows.Forms.Button()
        Me.ColumnResultAnswerQuestion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LabelResult = New System.Windows.Forms.Label()
        Me.PanelResults.SuspendLayout()
        CType(Me.DataGridViewResults, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelResults
        '
        Me.PanelResults.Controls.Add(Me.DataGridViewResults)
        Me.PanelResults.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelResults.Location = New System.Drawing.Point(0, 0)
        Me.PanelResults.Name = "PanelResults"
        Me.PanelResults.Size = New System.Drawing.Size(615, 226)
        Me.PanelResults.TabIndex = 0
        '
        'DataGridViewResults
        '
        Me.DataGridViewResults.AllowUserToAddRows = False
        Me.DataGridViewResults.AllowUserToDeleteRows = False
        Me.DataGridViewResults.AllowUserToOrderColumns = True
        Me.DataGridViewResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewResults.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridViewResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewResults.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnResultAnswerQuestion})
        Me.DataGridViewResults.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewResults.Location = New System.Drawing.Point(0, 0)
        Me.DataGridViewResults.Name = "DataGridViewResults"
        Me.DataGridViewResults.ReadOnly = True
        Me.DataGridViewResults.RowTemplate.Height = 24
        Me.DataGridViewResults.Size = New System.Drawing.Size(615, 226)
        Me.DataGridViewResults.TabIndex = 0
        '
        'PanelOptions
        '
        Me.PanelOptions.Controls.Add(Me.LabelResult)
        Me.PanelOptions.Controls.Add(Me.ButtonValidate)
        Me.PanelOptions.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelOptions.Location = New System.Drawing.Point(0, 226)
        Me.PanelOptions.Name = "PanelOptions"
        Me.PanelOptions.Size = New System.Drawing.Size(615, 115)
        Me.PanelOptions.TabIndex = 1
        '
        'ButtonValidate
        '
        Me.ButtonValidate.Location = New System.Drawing.Point(260, 80)
        Me.ButtonValidate.Name = "ButtonValidate"
        Me.ButtonValidate.Size = New System.Drawing.Size(95, 23)
        Me.ButtonValidate.TabIndex = 0
        Me.ButtonValidate.Text = "Continuar"
        Me.ButtonValidate.UseVisualStyleBackColor = True
        '
        'ColumnResultAnswerQuestion
        '
        Me.ColumnResultAnswerQuestion.HeaderText = "Resultados"
        Me.ColumnResultAnswerQuestion.Name = "ColumnResultAnswerQuestion"
        Me.ColumnResultAnswerQuestion.ReadOnly = True
        '
        'LabelResult
        '
        Me.LabelResult.AutoSize = True
        Me.LabelResult.Location = New System.Drawing.Point(282, 30)
        Me.LabelResult.Name = "LabelResult"
        Me.LabelResult.Size = New System.Drawing.Size(72, 17)
        Me.LabelResult.TabIndex = 1
        Me.LabelResult.Text = "Resultado"
        '
        'FormShowResults
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(615, 341)
        Me.Controls.Add(Me.PanelResults)
        Me.Controls.Add(Me.PanelOptions)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormShowResults"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ver resultados"
        Me.PanelResults.ResumeLayout(False)
        CType(Me.DataGridViewResults, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelOptions.ResumeLayout(False)
        Me.PanelOptions.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelResults As Panel
    Friend WithEvents PanelOptions As Panel
    Friend WithEvents DataGridViewResults As DataGridView
    Friend WithEvents ButtonValidate As Button
    Friend WithEvents ColumnResultAnswerQuestion As DataGridViewTextBoxColumn
    Friend WithEvents LabelResult As Label
End Class