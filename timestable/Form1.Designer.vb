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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.generatedNumberOne = New System.Windows.Forms.Label()
        Me.checkAnswerBtn = New System.Windows.Forms.Button()
        Me.genQuestionBtn = New System.Windows.Forms.Button()
        Me.answerBox = New System.Windows.Forms.TextBox()
        Me.generatedNumberTwo = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.answerRightPanel = New System.Windows.Forms.Panel()
        Me.backbuttonRightPanel = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.FalsePanel = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.backbuttonFalseLabel = New System.Windows.Forms.Button()
        Me.falseLabel = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.HelpLabel1 = New System.Windows.Forms.Label()
        Me.HelpLabel2 = New System.Windows.Forms.Label()
        Me.HelpLabel3 = New System.Windows.Forms.Label()
        Me.HelpLabel4 = New System.Windows.Forms.Label()
        Me.answerRightPanel.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FalsePanel.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'generatedNumberOne
        '
        Me.generatedNumberOne.AutoSize = True
        Me.generatedNumberOne.BackColor = System.Drawing.Color.White
        Me.generatedNumberOne.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.generatedNumberOne.Location = New System.Drawing.Point(22, 9)
        Me.generatedNumberOne.Name = "generatedNumberOne"
        Me.generatedNumberOne.Size = New System.Drawing.Size(17, 17)
        Me.generatedNumberOne.TabIndex = 0
        Me.generatedNumberOne.Text = "?"
        '
        'checkAnswerBtn
        '
        Me.checkAnswerBtn.Location = New System.Drawing.Point(239, 88)
        Me.checkAnswerBtn.Name = "checkAnswerBtn"
        Me.checkAnswerBtn.Size = New System.Drawing.Size(143, 23)
        Me.checkAnswerBtn.TabIndex = 1
        Me.checkAnswerBtn.Text = "Check Answer"
        Me.checkAnswerBtn.UseVisualStyleBackColor = True
        '
        'genQuestionBtn
        '
        Me.genQuestionBtn.Location = New System.Drawing.Point(239, 117)
        Me.genQuestionBtn.Name = "genQuestionBtn"
        Me.genQuestionBtn.Size = New System.Drawing.Size(143, 23)
        Me.genQuestionBtn.TabIndex = 2
        Me.genQuestionBtn.Text = "Generate Question"
        Me.genQuestionBtn.UseVisualStyleBackColor = True
        '
        'answerBox
        '
        Me.answerBox.Location = New System.Drawing.Point(239, 62)
        Me.answerBox.Name = "answerBox"
        Me.answerBox.Size = New System.Drawing.Size(143, 20)
        Me.answerBox.TabIndex = 3
        '
        'generatedNumberTwo
        '
        Me.generatedNumberTwo.AutoSize = True
        Me.generatedNumberTwo.BackColor = System.Drawing.Color.White
        Me.generatedNumberTwo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.generatedNumberTwo.Location = New System.Drawing.Point(89, 9)
        Me.generatedNumberTwo.Name = "generatedNumberTwo"
        Me.generatedNumberTwo.Size = New System.Drawing.Size(17, 17)
        Me.generatedNumberTwo.TabIndex = 4
        Me.generatedNumberTwo.Text = "?"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(57, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(15, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "x"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(121, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(17, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "="
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Location = New System.Drawing.Point(12, 142)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(177, 168)
        Me.Panel1.TabIndex = 7
        '
        'answerRightPanel
        '
        Me.answerRightPanel.BackColor = System.Drawing.Color.White
        Me.answerRightPanel.Controls.Add(Me.backbuttonRightPanel)
        Me.answerRightPanel.Controls.Add(Me.Label1)
        Me.answerRightPanel.Controls.Add(Me.PictureBox1)
        Me.answerRightPanel.Location = New System.Drawing.Point(411, 6)
        Me.answerRightPanel.Name = "answerRightPanel"
        Me.answerRightPanel.Size = New System.Drawing.Size(232, 141)
        Me.answerRightPanel.TabIndex = 8
        Me.answerRightPanel.Visible = False
        '
        'backbuttonRightPanel
        '
        Me.backbuttonRightPanel.Location = New System.Drawing.Point(6, 106)
        Me.backbuttonRightPanel.Name = "backbuttonRightPanel"
        Me.backbuttonRightPanel.Size = New System.Drawing.Size(75, 23)
        Me.backbuttonRightPanel.TabIndex = 3
        Me.backbuttonRightPanel.Text = "Back"
        Me.backbuttonRightPanel.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoEllipsis = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 42)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Your answer is right, well done!"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(84, -7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(167, 149)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'FalsePanel
        '
        Me.FalsePanel.BackColor = System.Drawing.Color.White
        Me.FalsePanel.Controls.Add(Me.PictureBox2)
        Me.FalsePanel.Controls.Add(Me.backbuttonFalseLabel)
        Me.FalsePanel.Controls.Add(Me.falseLabel)
        Me.FalsePanel.Location = New System.Drawing.Point(411, 153)
        Me.FalsePanel.Name = "FalsePanel"
        Me.FalsePanel.Size = New System.Drawing.Size(232, 140)
        Me.FalsePanel.TabIndex = 9
        Me.FalsePanel.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(105, 70)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(115, 65)
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'backbuttonFalseLabel
        '
        Me.backbuttonFalseLabel.Location = New System.Drawing.Point(15, 113)
        Me.backbuttonFalseLabel.Name = "backbuttonFalseLabel"
        Me.backbuttonFalseLabel.Size = New System.Drawing.Size(75, 22)
        Me.backbuttonFalseLabel.TabIndex = 4
        Me.backbuttonFalseLabel.Text = "Back"
        Me.backbuttonFalseLabel.UseVisualStyleBackColor = True
        '
        'falseLabel
        '
        Me.falseLabel.AllowDrop = True
        Me.falseLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.falseLabel.Location = New System.Drawing.Point(12, 10)
        Me.falseLabel.Name = "falseLabel"
        Me.falseLabel.Size = New System.Drawing.Size(190, 99)
        Me.falseLabel.TabIndex = 0
        Me.falseLabel.Text = "Sorry that was not the right answer, the right answer is : "
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.generatedNumberOne)
        Me.Panel2.Controls.Add(Me.generatedNumberTwo)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(239, 19)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(143, 37)
        Me.Panel2.TabIndex = 9
        '
        'HelpLabel1
        '
        Me.HelpLabel1.AutoSize = True
        Me.HelpLabel1.Location = New System.Drawing.Point(70, 25)
        Me.HelpLabel1.Name = "HelpLabel1"
        Me.HelpLabel1.Size = New System.Drawing.Size(156, 26)
        Me.HelpLabel1.TabIndex = 10
        Me.HelpLabel1.Text = "These are the two numbers you" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "need to times together"
        '
        'HelpLabel2
        '
        Me.HelpLabel2.AutoSize = True
        Me.HelpLabel2.Location = New System.Drawing.Point(51, 65)
        Me.HelpLabel2.Name = "HelpLabel2"
        Me.HelpLabel2.Size = New System.Drawing.Size(175, 13)
        Me.HelpLabel2.TabIndex = 11
        Me.HelpLabel2.Text = "Click this box to type your answer in"
        '
        'HelpLabel3
        '
        Me.HelpLabel3.AutoSize = True
        Me.HelpLabel3.Location = New System.Drawing.Point(39, 93)
        Me.HelpLabel3.Name = "HelpLabel3"
        Me.HelpLabel3.Size = New System.Drawing.Size(187, 13)
        Me.HelpLabel3.TabIndex = 12
        Me.HelpLabel3.Text = "Click this button to check your answer"
        '
        'HelpLabel4
        '
        Me.HelpLabel4.AutoSize = True
        Me.HelpLabel4.Location = New System.Drawing.Point(12, 121)
        Me.HelpLabel4.Name = "HelpLabel4"
        Me.HelpLabel4.Size = New System.Drawing.Size(214, 13)
        Me.HelpLabel4.TabIndex = 13
        Me.HelpLabel4.Text = "Click this button to generate a new question"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(655, 296)
        Me.Controls.Add(Me.HelpLabel4)
        Me.Controls.Add(Me.HelpLabel3)
        Me.Controls.Add(Me.HelpLabel2)
        Me.Controls.Add(Me.HelpLabel1)
        Me.Controls.Add(Me.answerRightPanel)
        Me.Controls.Add(Me.FalsePanel)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.answerBox)
        Me.Controls.Add(Me.genQuestionBtn)
        Me.Controls.Add(Me.checkAnswerBtn)
        Me.Name = "Form1"
        Me.Text = "Times Table"
        Me.answerRightPanel.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FalsePanel.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents generatedNumberOne As Label
    Friend WithEvents checkAnswerBtn As Button
    Friend WithEvents genQuestionBtn As Button
    Friend WithEvents answerBox As TextBox
    Friend WithEvents generatedNumberTwo As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents answerRightPanel As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents backbuttonRightPanel As Button
    Friend WithEvents FalsePanel As Panel
    Friend WithEvents backbuttonFalseLabel As Button
    Friend WithEvents falseLabel As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents HelpLabel1 As Label
    Friend WithEvents HelpLabel2 As Label
    Friend WithEvents HelpLabel3 As Label
    Friend WithEvents HelpLabel4 As Label
End Class
