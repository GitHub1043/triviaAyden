Public Class Form1
    Dim intQuestion As Integer = 1
    Dim intScore As Integer = 0
    Dim intTimer As Integer
    Const TIMELIMIT As Integer = 100

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblQuestion.Text = "1) What is the capital city of Canada?"
        btnAnswer1.Text = "Cheddar"
        btnAnswer2.Text = "Toronto"
        btnAnswer3.Text = "Ottawa"
        btnAnswer4.Text = "Calgary"
        intTimer = TIMELIMIT
        Timer1.Start()
    End Sub

    Private Sub btnAnswer1_Click(sender As Object, e As EventArgs) Handles btnAnswer1.Click
        Timer1.Stop()
        If intQuestion = 1 Then
            MessageBox.Show("Wrong!")
            intScore = intScore + 0
            intQuestion = 2
            lblQuestion.Text = "2) What year was the iPhone X released?"
            btnAnswer1.Text = "2015"
            btnAnswer2.Text = "2017"
            btnAnswer3.Text = "2016"
            btnAnswer4.Text = "2018"

        ElseIf intQuestion = 2 Then
            MessageBox.Show("Wrong!")
            intScore = intScore + 0
            intQuestion = 3
            lblQuestion.Text = "3) What is the 9th month?"
            btnAnswer1.Text = "July"
            btnAnswer2.Text = "October"
            btnAnswer3.Text = "September"
            btnAnswer4.Text = "August"

        ElseIf intQuestion = 3 Then
            MessageBox.Show("Correct!")
            intScore = intScore + intTimer
            intQuestion = 4
            lblQuestion.Text = "4) When did Apollo 11 land on the moon?"
            btnAnswer1.Text = "July 20, 1969"
            btnAnswer2.Text = "July 24, 1969"
            btnAnswer3.Text = "July 26, 1969"
            btnAnswer4.Text = "July 18, 1969"

        ElseIf intQuestion = 4 Then
            MessageBox.Show("Correct!")
            intScore = intScore + intTimer
            intQuestion = 5
            lblQuestion.Text = "5) What is the first letter of the word when unscrambled: palpe?"
            btnAnswer1.Text = "P"
            btnAnswer2.Text = "A"
            btnAnswer3.Text = "L"
            btnAnswer4.Text = "E"

        ElseIf intQuestion = 5 Then
            MessageBox.Show("Wrong!")
            intScore = intScore + 0
            intQuestion = 6
            lblQuestion.Text = "6) In Ancient Greece who is the messenger of the gods?"
            btnAnswer1.Text = "Zeus"
            btnAnswer2.Text = "Hephaestus"
            btnAnswer3.Text = "Hermes"
            btnAnswer4.Text = "Apollo"

        ElseIf intQuestion = 6 Then
            MessageBox.Show("Wrong!")
            intScore = intScore + 0
            intQuestion = 7
            lblQuestion.Text = "7) Who is the CEO of Microsoft?"
            btnAnswer1.Text = "Satya Nadella"
            btnAnswer2.Text = "Bill Gates"
            btnAnswer3.Text = "Steve Ballmer"
            btnAnswer4.Text = "Sundar Pichai"

        ElseIf intQuestion = 7 Then
            MessageBox.Show("Correct!")
            intScore = intScore + intTimer
            intQuestion = 8
            lblQuestion.Text = "8) What year was Apple founded?"
            btnAnswer1.Text = "1976"
            btnAnswer2.Text = "1989"
            btnAnswer3.Text = "1965"
            btnAnswer4.Text = "1997"

        ElseIf intQuestion = 8 Then
            MessageBox.Show("Correct!")
            intScore = intScore + intTimer
            intQuestion = 9
            lblQuestion.Text = "9) Who was one of the founders of Google?"
            btnAnswer1.Text = "Stephen Cleveland"
            btnAnswer2.Text = "Tim Cook"
            btnAnswer3.Text = "Steve Ballmer"
            btnAnswer4.Text = "Larry Page"

        ElseIf intQuestion = 9 Then
            MessageBox.Show("Wrong!")
            intScore = intScore + 0
            intQuestion = 10
            lblQuestion.Text = "10) What letter did question 6 start with?"
            btnAnswer1.Text = "W"
            btnAnswer2.Text = "A"
            btnAnswer3.Text = "I"
            btnAnswer4.Text = "E"

        ElseIf intQuestion = 10 Then
            MessageBox.Show("Wrong!")
            intScore = intScore + 0

        End If
        lblScore.Text = "Score: " & intScore
        intTimer = TIMELIMIT
        Timer1.Start()
    End Sub

    Private Sub btnAnswer2_Click(sender As Object, e As EventArgs) Handles btnAnswer2.Click
        Timer1.Stop()
        If intQuestion = 1 Then
            MessageBox.Show("Wrong!")
            intScore = intScore + 0
            intQuestion = 2
            lblQuestion.Text = "2) What year was the iPhone X released?"
            btnAnswer1.Text = "2015"
            btnAnswer2.Text = "2017"
            btnAnswer3.Text = "2016"
            btnAnswer4.Text = "2018"

        ElseIf intQuestion = 2 Then
            MessageBox.Show("Correct!")
            intScore = intScore + intTimer
            intQuestion = 3
            lblQuestion.Text = "3) What is the 9th month?"
            btnAnswer1.Text = "July"
            btnAnswer2.Text = "October"
            btnAnswer3.Text = "September"
            btnAnswer4.Text = "August"

        ElseIf intQuestion = 3 Then
            MessageBox.Show("Wrong!")
            intScore = intScore + 0
            intQuestion = 4
            lblQuestion.Text = "4) When did Apollo 11 land on the moon?"
            btnAnswer1.Text = "July 20, 1969"
            btnAnswer2.Text = "July 24, 1969"
            btnAnswer3.Text = "July 26, 1969"
            btnAnswer4.Text = "July 18, 1969"

        ElseIf intQuestion = 4 Then
            MessageBox.Show("Wrong!")
            intScore = intScore + 0
            intQuestion = 5
            lblQuestion.Text = "5) What is the first letter of the word when unscrambled: palpe?"
            btnAnswer1.Text = "P"
            btnAnswer2.Text = "A"
            btnAnswer3.Text = "L"
            btnAnswer4.Text = "E"

        ElseIf intQuestion = 5 Then
            MessageBox.Show("Correct!")
            intScore = intScore + intTimer
            intQuestion = 6
            lblQuestion.Text = "6) In Ancient Greece who is the messenger of the gods?"
            btnAnswer1.Text = "Zeus"
            btnAnswer2.Text = "Hephaestus"
            btnAnswer3.Text = "Hermes"
            btnAnswer4.Text = "Apollo"

        ElseIf intQuestion = 6 Then
            MessageBox.Show("Wrong!")
            intScore = intScore + 0
            intQuestion = 7
            lblQuestion.Text = "7) Who is the CEO of Microsoft?"
            btnAnswer1.Text = "Satya Nadella"
            btnAnswer2.Text = "Bill Gates"
            btnAnswer3.Text = "Steve Ballmer"
            btnAnswer4.Text = "Sundar Pichai"

        ElseIf intQuestion = 7 Then
            MessageBox.Show("Wrong!")
            intScore = intScore + 0
            intQuestion = 8
            lblQuestion.Text = "8) What year was Apple founded?"
            btnAnswer1.Text = "1976"
            btnAnswer2.Text = "1989"
            btnAnswer3.Text = "1965"
            btnAnswer4.Text = "1997"

        ElseIf intQuestion = 8 Then
            MessageBox.Show("Wrong!")
            intScore = intScore + 0
            intQuestion = 9
            lblQuestion.Text = "9) Who was one of the founders of Google?"
            btnAnswer1.Text = "Stephen Cleveland"
            btnAnswer2.Text = "Tim Cook"
            btnAnswer3.Text = "Steve Ballmer"
            btnAnswer4.Text = "Larry Page"

        ElseIf intQuestion = 9 Then
            MessageBox.Show("Wrong!")
            intScore = intScore + 0
            intQuestion = 10
            lblQuestion.Text = "10) What letter did question 6 start with?"
            btnAnswer1.Text = "W"
            btnAnswer2.Text = "A"
            btnAnswer3.Text = "I"
            btnAnswer4.Text = "E"

        ElseIf intQuestion = 10 Then
            MessageBox.Show("Wrong!")
            intScore = intScore + 0

        End If
        intTimer = TIMELIMIT
        Timer1.Start()
    End Sub

    Private Sub btnAnswer3_Click(sender As Object, e As EventArgs) Handles btnAnswer3.Click
        Timer1.Stop()
        If intQuestion = 1 Then
            MessageBox.Show("Correct!")
            intScore = intScore + intTimer
            intQuestion = 2
            lblQuestion.Text = "2) What year was the iPhone X released?"
            btnAnswer1.Text = "2015"
            btnAnswer2.Text = "2017"
            btnAnswer3.Text = "2016"
            btnAnswer4.Text = "2018"

        ElseIf intQuestion = 2 Then
            MessageBox.Show("Wrong!")
            intScore = intScore + 0
            intQuestion = 3
            lblQuestion.Text = "3) What is the 9th month?"
            btnAnswer1.Text = "July"
            btnAnswer2.Text = "October"
            btnAnswer3.Text = "September"
            btnAnswer4.Text = "August"

        ElseIf intQuestion = 3 Then
            MessageBox.Show("Wrong!")
            intScore = intScore + 0
            intQuestion = 4
            lblQuestion.Text = "4) When did Apollo 11 land on the moon?"
            btnAnswer1.Text = "July 20, 1969"
            btnAnswer2.Text = "July 24, 1969"
            btnAnswer3.Text = "July 26, 1969"
            btnAnswer4.Text = "July 18, 1969"

        ElseIf intQuestion = 4 Then
            MessageBox.Show("Wrong!")
            intScore = intScore + 0
            intQuestion = 5
            lblQuestion.Text = "5) What is the first letter of the word when unscrambled: palpe?"
            btnAnswer1.Text = "P"
            btnAnswer2.Text = "A"
            btnAnswer3.Text = "L"
            btnAnswer4.Text = "E"

        ElseIf intQuestion = 5 Then
            MessageBox.Show("Wrong!")
            intScore = intScore + 0
            intQuestion = 6
            lblQuestion.Text = "6) In Ancient Greece who is the messenger of the gods?"
            btnAnswer1.Text = "Zeus"
            btnAnswer2.Text = "Hephaestus"
            btnAnswer3.Text = "Hermes"
            btnAnswer4.Text = "Apollo"

        ElseIf intQuestion = 6 Then
            MessageBox.Show("Correct!")
            intScore = intScore + intTimer
            intQuestion = 7
            lblQuestion.Text = "7) Who is the CEO of Microsoft?"
            btnAnswer1.Text = "Satya Nadella"
            btnAnswer2.Text = "Bill Gates"
            btnAnswer3.Text = "Steve Ballmer"
            btnAnswer4.Text = "Sundar Pichai"

        ElseIf intQuestion = 7 Then
            MessageBox.Show("Wrong!")
            intScore = intScore + 0
            intQuestion = 8
            lblQuestion.Text = "8) What year was Apple founded?"
            btnAnswer1.Text = "1976"
            btnAnswer2.Text = "1989"
            btnAnswer3.Text = "1965"
            btnAnswer4.Text = "1997"

        ElseIf intQuestion = 8 Then
            MessageBox.Show("Wrong!")
            intScore = intScore + 0
            intQuestion = 9
            lblQuestion.Text = "9) Who was one of the founders of Google?"
            btnAnswer1.Text = "Stephen Cleveland"
            btnAnswer2.Text = "Tim Cook"
            btnAnswer3.Text = "Steve Ballmer"
            btnAnswer4.Text = "Larry Page"

        ElseIf intQuestion = 9 Then
            MessageBox.Show("Wrong!")
            intScore = intScore + 0
            intQuestion = 10
            lblQuestion.Text = "10) What letter did question 6 start with?"
            btnAnswer1.Text = "W"
            btnAnswer2.Text = "A"
            btnAnswer3.Text = "I"
            btnAnswer4.Text = "E"

        ElseIf intQuestion = 10 Then
            MessageBox.Show("Correct!")
            intScore = intScore + intTimer

        End If
        intTimer = TIMELIMIT
        Timer1.Start()
    End Sub

    Private Sub btnAnswer4_Click(sender As Object, e As EventArgs) Handles btnAnswer4.Click
        Timer1.Stop()
        If intQuestion = 1 Then
            MessageBox.Show("Wrong!")
            intScore = intScore + 0
            intQuestion = 2
            lblQuestion.Text = "2) What year was the iPhone X released?"
            btnAnswer1.Text = "2015"
            btnAnswer2.Text = "2017"
            btnAnswer3.Text = "2016"
            btnAnswer4.Text = "2018"

        ElseIf intQuestion = 2 Then
            MessageBox.Show("Wrong!")
            intScore = intScore + 0
            intQuestion = 3
            lblQuestion.Text = "3) What is the 9th month?"
            btnAnswer1.Text = "July"
            btnAnswer2.Text = "October"
            btnAnswer3.Text = "September"
            btnAnswer4.Text = "August"

        ElseIf intQuestion = 3 Then
            MessageBox.Show("Wrong!")
            intScore = intScore + 0
            intQuestion = 4
            lblQuestion.Text = "4) When did Apollo 11 land on the moon?"
            btnAnswer1.Text = "July 20, 1969"
            btnAnswer2.Text = "July 24, 1969"
            btnAnswer3.Text = "July 26, 1969"
            btnAnswer4.Text = "July 18, 1969"

        ElseIf intQuestion = 4 Then
            MessageBox.Show("Wrong!")
            intScore = intScore + 0
            intQuestion = 5
            lblQuestion.Text = "5) What is the first letter of the word when unscrambled: palpe?"
            btnAnswer1.Text = "P"
            btnAnswer2.Text = "A"
            btnAnswer3.Text = "L"
            btnAnswer4.Text = "E"

        ElseIf intQuestion = 5 Then
            MessageBox.Show("Wrong!")
            intScore = intScore + 0
            intQuestion = 6
            lblQuestion.Text = "6) In Ancient Greece who is the messenger of the gods?"
            btnAnswer1.Text = "Zeus"
            btnAnswer2.Text = "Hephaestus"
            btnAnswer3.Text = "Hermes"
            btnAnswer4.Text = "Apollo"

        ElseIf intQuestion = 6 Then
            MessageBox.Show("Wrong!")
            intScore = intScore + 0
            intQuestion = 7
            lblQuestion.Text = "7) Who is the CEO of Microsoft?"
            btnAnswer1.Text = "Satya Nadella"
            btnAnswer2.Text = "Bill Gates"
            btnAnswer3.Text = "Steve Ballmer"
            btnAnswer4.Text = "Sundar Pichai"

        ElseIf intQuestion = 7 Then
            MessageBox.Show("Wrong!")
            intScore = intScore + 0
            intQuestion = 8
            lblQuestion.Text = "8) What year was Apple founded?"
            btnAnswer1.Text = "1976"
            btnAnswer2.Text = "1989"
            btnAnswer3.Text = "1965"
            btnAnswer4.Text = "1997"

        ElseIf intQuestion = 8 Then
            MessageBox.Show("Wrong!")
            intScore = intScore + 0
            intQuestion = 9
            lblQuestion.Text = "9) Who was one of the founders of Google?"
            btnAnswer1.Text = "Stephen Cleveland"
            btnAnswer2.Text = "Tim Cook"
            btnAnswer3.Text = "Steve Ballmer"
            btnAnswer4.Text = "Larry Page"

        ElseIf intQuestion = 9 Then
            MessageBox.Show("Correct!")
            intScore = intScore + intTimer
            intQuestion = 10
            lblQuestion.Text = "10) What letter did question 6 start with?"
            btnAnswer1.Text = "W"
            btnAnswer2.Text = "A"
            btnAnswer3.Text = "I"
            btnAnswer4.Text = "E"

        ElseIf intQuestion = 10 Then
            MessageBox.Show("Wrong!")
            intScore = intScore + 0

        End If
        intTimer = TIMELIMIT
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        intTimer = intTimer - 1
        lblTimer.Text = "Timer: " & intTimer

        If intTimer = 0 Then
            Timer1.Stop()
            MessageBox.Show("Out Of Time!")
            If intQuestion = 1 Then
                MessageBox.Show("Wrong!")
                intScore = intScore + 0
                intQuestion = 2
                lblQuestion.Text = "2) What year was the iPhone X released?"
                btnAnswer1.Text = "2015"
                btnAnswer2.Text = "2017"
                btnAnswer3.Text = "2016"
                btnAnswer4.Text = "2018"

            ElseIf intQuestion = 2 Then
                MessageBox.Show("Wrong!")
                intScore = intScore + 0
                intQuestion = 3
                lblQuestion.Text = "3) What is the 9th month?"
                btnAnswer1.Text = "July"
                btnAnswer2.Text = "October"
                btnAnswer3.Text = "September"
                btnAnswer4.Text = "August"

            ElseIf intQuestion = 3 Then
                MessageBox.Show("Correct!")
                intScore = intScore + intTimer
                intQuestion = 4
                lblQuestion.Text = "4) When did Apollo 11 land on the moon?"
                btnAnswer1.Text = "July 20, 1969"
                btnAnswer2.Text = "July 24, 1969"
                btnAnswer3.Text = "July 26, 1969"
                btnAnswer4.Text = "July 18, 1969"

            ElseIf intQuestion = 4 Then
                MessageBox.Show("Correct!")
                intScore = intScore + intTimer
                intQuestion = 5
                lblQuestion.Text = "5) What is the first letter of the word when unscrambled: palpe?"
                btnAnswer1.Text = "P"
                btnAnswer2.Text = "A"
                btnAnswer3.Text = "L"
                btnAnswer4.Text = "E"

            ElseIf intQuestion = 5 Then
                MessageBox.Show("Wrong!")
                intScore = intScore + 0
                intQuestion = 6
                lblQuestion.Text = "6) In Ancient Greece who is the messenger of the gods?"
                btnAnswer1.Text = "Zeus"
                btnAnswer2.Text = "Hephaestus"
                btnAnswer3.Text = "Hermes"
                btnAnswer4.Text = "Apollo"

            ElseIf intQuestion = 6 Then
                MessageBox.Show("Wrong!")
                intScore = intScore + 0
                intQuestion = 7
                lblQuestion.Text = "7) Who is the CEO of Microsoft?"
                btnAnswer1.Text = "Satya Nadella"
                btnAnswer2.Text = "Bill Gates"
                btnAnswer3.Text = "Steve Ballmer"
                btnAnswer4.Text = "Sundar Pichai"

            ElseIf intQuestion = 7 Then
                MessageBox.Show("Correct!")
                intScore = intScore + intTimer
                intQuestion = 8
                lblQuestion.Text = "8) What year was Apple founded?"
                btnAnswer1.Text = "1976"
                btnAnswer2.Text = "1989"
                btnAnswer3.Text = "1965"
                btnAnswer4.Text = "1997"

            ElseIf intQuestion = 8 Then
                MessageBox.Show("Correct!")
                intScore = intScore + intTimer
                intQuestion = 9
                lblQuestion.Text = "9) Who was one of the founders of Google?"
                btnAnswer1.Text = "Stephen Cleveland"
                btnAnswer2.Text = "Tim Cook"
                btnAnswer3.Text = "Steve Ballmer"
                btnAnswer4.Text = "Larry Page"

            ElseIf intQuestion = 9 Then
                MessageBox.Show("Wrong!")
                intScore = intScore + 0
                intQuestion = 10
                lblQuestion.Text = "10) What letter did question 6 start with?"
                btnAnswer1.Text = "W"
                btnAnswer2.Text = "A"
                btnAnswer3.Text = "I"
                btnAnswer4.Text = "E"

            ElseIf intQuestion = 10 Then
                MessageBox.Show("Wrong!")
                intScore = intScore + 0
            End If
        End If
        intTimer = TIMELIMIT
        Timer1.Start()

    End Sub
End Class
