Public Class Form1
    Private Sub checkAnswerBtn_Click(sender As Object, e As EventArgs) Handles checkAnswerBtn.Click
        If IsNumeric(answerBox.Text) Then
            Dim answer As Integer = answerBox.Text
            Dim right_answer As Integer = generatedNumberOne.Text * generatedNumberTwo.Text
            If answer = right_answer Then
                answerRightPanel.Visible = True
                numgenerator()
            Else
                falseLabel.Text = falseLabel.Text + Convert.ToString(right_answer)
                FalsePanel.Visible = True
                numgenerator()
            End If
        Else
            MsgBox(“Please enter your answer.”)
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        numgenerator()
    End Sub

    Private Sub genQuestionBtn_Click(sender As Object, e As EventArgs) Handles genQuestionBtn.Click
        numgenerator()
    End Sub

    Public Function numgenerator()
        Randomize()
        generatedNumberOne.Text = CInt(Int((12 * Rnd()) + 0))
        generatedNumberTwo.Text = CInt(Int((12 * Rnd()) + 0))
    End Function

    Private Sub backbuttonRightPanel_Click(sender As Object, e As EventArgs) Handles backbuttonRightPanel.Click
        answerRightPanel.Visible = False
    End Sub

    Private Sub backbuttonFalseLabel_Click(sender As Object, e As EventArgs) Handles backbuttonFalseLabel.Click
        FalsePanel.Visible = False
    End Sub
End Class
