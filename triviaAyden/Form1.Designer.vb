<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lblQuestion = New System.Windows.Forms.Label()
        Me.btnAnswer1 = New System.Windows.Forms.Button()
        Me.btnAnswer2 = New System.Windows.Forms.Button()
        Me.btnAnswer3 = New System.Windows.Forms.Button()
        Me.btnAnswer4 = New System.Windows.Forms.Button()
        Me.lblTimer = New System.Windows.Forms.Label()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'lblQuestion
        '
        Me.lblQuestion.AutoSize = True
        Me.lblQuestion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuestion.Location = New System.Drawing.Point(12, 49)
        Me.lblQuestion.Name = "lblQuestion"
        Me.lblQuestion.Size = New System.Drawing.Size(49, 16)
        Me.lblQuestion.TabIndex = 0
        Me.lblQuestion.Text = "Label1"
        '
        'btnAnswer1
        '
        Me.btnAnswer1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnswer1.Location = New System.Drawing.Point(12, 119)
        Me.btnAnswer1.Name = "btnAnswer1"
        Me.btnAnswer1.Size = New System.Drawing.Size(202, 48)
        Me.btnAnswer1.TabIndex = 1
        Me.btnAnswer1.Text = "Button1"
        Me.btnAnswer1.UseVisualStyleBackColor = True
        '
        'btnAnswer2
        '
        Me.btnAnswer2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnswer2.Location = New System.Drawing.Point(220, 119)
        Me.btnAnswer2.Name = "btnAnswer2"
        Me.btnAnswer2.Size = New System.Drawing.Size(202, 48)
        Me.btnAnswer2.TabIndex = 2
        Me.btnAnswer2.Text = "Button2"
        Me.btnAnswer2.UseVisualStyleBackColor = True
        '
        'btnAnswer3
        '
        Me.btnAnswer3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnswer3.Location = New System.Drawing.Point(12, 193)
        Me.btnAnswer3.Name = "btnAnswer3"
        Me.btnAnswer3.Size = New System.Drawing.Size(202, 48)
        Me.btnAnswer3.TabIndex = 3
        Me.btnAnswer3.Text = "Button3"
        Me.btnAnswer3.UseVisualStyleBackColor = True
        '
        'btnAnswer4
        '
        Me.btnAnswer4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnswer4.Location = New System.Drawing.Point(220, 193)
        Me.btnAnswer4.Name = "btnAnswer4"
        Me.btnAnswer4.Size = New System.Drawing.Size(202, 48)
        Me.btnAnswer4.TabIndex = 4
        Me.btnAnswer4.Text = "Button4"
        Me.btnAnswer4.UseVisualStyleBackColor = True
        '
        'lblTimer
        '
        Me.lblTimer.AutoSize = True
        Me.lblTimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimer.Location = New System.Drawing.Point(9, 357)
        Me.lblTimer.Name = "lblTimer"
        Me.lblTimer.Size = New System.Drawing.Size(46, 16)
        Me.lblTimer.TabIndex = 5
        Me.lblTimer.Text = "Timer:"
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.Location = New System.Drawing.Point(217, 357)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(57, 16)
        Me.lblScore.TabIndex = 6
        Me.lblScore.Text = "Score: 0"
        '
        'Timer1
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(449, 448)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.lblTimer)
        Me.Controls.Add(Me.btnAnswer4)
        Me.Controls.Add(Me.btnAnswer3)
        Me.Controls.Add(Me.btnAnswer2)
        Me.Controls.Add(Me.btnAnswer1)
        Me.Controls.Add(Me.lblQuestion)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblQuestion As System.Windows.Forms.Label
    Friend WithEvents btnAnswer1 As System.Windows.Forms.Button
    Friend WithEvents btnAnswer2 As System.Windows.Forms.Button
    Friend WithEvents btnAnswer3 As System.Windows.Forms.Button
    Friend WithEvents btnAnswer4 As System.Windows.Forms.Button
    Friend WithEvents lblTimer As System.Windows.Forms.Label
    Friend WithEvents lblScore As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
