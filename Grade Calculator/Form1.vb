Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtQuestions.TextChanged, txtGrade.TextChanged, txtAnswers.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Questions As Integer
        Dim Answers As Integer
        Dim Grade As Double
        Dim tmrSage As New Timer

        Try
            Questions = CInt(txtQuestions.Text)
            Answers = CInt(txtAnswers.Text)
        Catch ex As Exception
            MessageBox.Show("Please enter valid numbers")
            Exit Sub
        End Try

        Grade = CDbl(Answers / Questions) * 100
        txtGrade.Text = Grade.ToString
        tmrSage.Enabled = True
        SendKeys.Send(txtName.Text)
        SendKeys.Send(txtGrade.Text)
        SendKeys.Send("{enter}")
        tmrSage.Enabled = False

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtGrade.Text = ""
        txtQuestions.Text = ""
        txtAnswers.Text = ""
        txtName.Text = ""

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class
