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
        Me.txtQuestions = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAnswers = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtGrade = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtQuestions
        '
        Me.txtQuestions.Location = New System.Drawing.Point(116, 89)
        Me.txtQuestions.Name = "txtQuestions"
        Me.txtQuestions.Size = New System.Drawing.Size(40, 20)
        Me.txtQuestions.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(12, 248)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(103, 36)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Grade"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Number of Questions"
        '
        'txtAnswers
        '
        Me.txtAnswers.Location = New System.Drawing.Point(116, 132)
        Me.txtAnswers.Name = "txtAnswers"
        Me.txtAnswers.Size = New System.Drawing.Size(40, 20)
        Me.txtAnswers.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(213, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Number of Correct Answers"
        '
        'txtGrade
        '
        Me.txtGrade.Location = New System.Drawing.Point(116, 175)
        Me.txtGrade.Name = "txtGrade"
        Me.txtGrade.ReadOnly = True
        Me.txtGrade.Size = New System.Drawing.Size(40, 20)
        Me.txtGrade.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 155)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(143, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Grade Percentage"
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(153, 248)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(103, 36)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Reset"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(99, 290)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 31)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Close"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(162, 22)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Name of Student"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(16, 34)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(144, 20)
        Me.txtName.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(280, 333)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtGrade)
        Me.Controls.Add(Me.txtAnswers)
        Me.Controls.Add(Me.txtQuestions)
        Me.Name = "Form1"
        Me.Text = "Grade Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtQuestions As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtAnswers As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtGrade As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtName As TextBox
End Class
