Public Class Form1
    Dim counter As Integer = 0
    Dim choice As Integer
    Dim choice2 As Integer
    Dim Switchdoor As Boolean
    Dim WIN As Integer
    Dim switchWIN As Integer
    Dim loss As Integer
    Dim switchloss As Integer
    Dim rand As New Random
    Dim random2 As Integer = rand.Next(1, 4)
    Dim random As Integer = rand.Next(1, 4)
    Dim switchtotal As Integer
    Dim total As Integer = 1
    Dim switches As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnDoor1.Click

        If counter < 1 Then
            choice = 1
            While random2 = choice OrElse random2 = random
                random2 = rand.Next(1, 4)
            End While
            If random2 = choice OrElse random2 = random Then
                random2 = rand.Next(1, 4)
            Else
                If random2 = 2 Then
                    PictureBox2.Visible = False
                ElseIf random2 = 3 Then
                    PictureBox3.Visible = False
                End If
            End If
        ElseIf counter = 1 Then
            choice2 = 1
        End If
        doors(choice, choice2)
        counter += 1
        If counter = 2 Then
            PictureBox1.Visible = False
            PictureBox2.Visible = False
            PictureBox3.Visible = False
        End If

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnDoor2.Click
        If counter < 1 Then
            choice = 2
            While random2 = choice OrElse random2 = random
                random2 = rand.Next(1, 4)
            End While
            If random2 = choice OrElse random2 = random Then
                random2 = rand.Next(1, 4)
            Else
                If random2 = 1 Then
                    PictureBox1.Visible = False
                ElseIf random2 = 3 Then
                    PictureBox3.Visible = False
                End If
            End If
        ElseIf counter = 1 Then
            choice2 = 2
        End If
        doors(choice, choice2)
        counter += 1
        If counter = 2 Then
            PictureBox1.Visible = False
            PictureBox2.Visible = False
            PictureBox3.Visible = False
        End If
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnDoor3.Click
        If counter < 1 Then
            choice = 3
            While random2 = choice OrElse random2 = random
                random2 = rand.Next(1, 4)
            End While
            If random2 = choice OrElse random2 = random Then
                random2 = rand.Next(1, 4)
            Else
                If random2 = 1 Then
                    PictureBox1.Visible = False
                ElseIf random2 = 2 Then
                    PictureBox2.Visible = False
                End If
            End If
        ElseIf counter = 1 Then
            choice2 = 3
        End If
        doors(choice, choice2)
        counter += 1
        If counter = 2 Then
            PictureBox1.Visible = False
            PictureBox2.Visible = False
            PictureBox3.Visible = False
        End If
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Random = 1 Then
            PictureBox4.Image = My.Resources.th__1_
            PictureBox5.Image = My.Resources.GOAT
            PictureBox6.Image = My.Resources.GOAT
        ElseIf Random = 2 Then
            PictureBox4.Image = My.Resources.GOAT
            PictureBox5.Image = My.Resources.th__1_
            PictureBox6.Image = My.Resources.GOAT
        ElseIf Random = 3 Then
            PictureBox4.Image = My.Resources.GOAT
            PictureBox5.Image = My.Resources.GOAT
            PictureBox6.Image = My.Resources.th__1_
        End If
        If choice2 = random AndAlso Switchdoor = False Then
            WIN += 1
        ElseIf choice2 = random AndAlso Switchdoor = True Then
            WIN += 1
            switches += 1
        ElseIf choice2 <> random AndAlso Switchdoor = False Then
            loss += 1
        ElseIf choice2 <> random AndAlso Switchdoor = True Then
            loss += 1
            switches += 1
        End If
        winscount.Text = WIN
        switchcount.Text = switches
        totalgames.Text = total
    End Sub
    Sub doors(Choice As Integer, Choice2 As Integer)
        If Choice = 3 AndAlso Choice2 = 3 Then
            PictureBox3.Visible = False
            Switchdoor = False
        ElseIf Choice = 3 AndAlso Choice2 = 2 Then
            PictureBox2.Visible = False
            Switchdoor = True
        ElseIf Choice = 3 AndAlso Choice2 = 1 Then
            PictureBox1.Visible = False
            Switchdoor = True
        ElseIf choice = 2 AndAlso choice2 = 2 Then
            PictureBox2.Visible = False
            Switchdoor = False
        ElseIf choice = 2 AndAlso choice2 = 3 Then
            PictureBox3.Visible = False
            Switchdoor = True
        ElseIf choice = 2 AndAlso choice2 = 1 Then
            PictureBox1.Visible = False
            Switchdoor = True
        ElseIf choice = 1 AndAlso choice2 = 1 Then
            PictureBox1.Visible = False
            Switchdoor = False
        ElseIf choice = 1 AndAlso choice2 = 2 Then
            PictureBox2.Visible = False
            Switchdoor = True
        ElseIf choice = 1 AndAlso choice2 = 3 Then
            PictureBox3.Visible = False
            Switchdoor = True
        End If
    End Sub

    Private Sub Reset_Click(sender As Object, e As EventArgs) Handles Reset.Click
        counter = 0
        PictureBox1.Visible = True
        PictureBox2.Visible = True
        PictureBox3.Visible = True
        random = rand.Next(1, 4)
        random2 = rand.Next(1, 4)
        If random2 = random Then
            random2 = rand.Next(1, 4)
        End If
        Switchdoor = False
        choice = 0
        choice2 = 0
        If random = 1 Then
            PictureBox4.Image = My.Resources.th__1_
            PictureBox5.Image = My.Resources.GOAT
            PictureBox6.Image = My.Resources.GOAT
        ElseIf random = 2 Then
            PictureBox4.Image = My.Resources.GOAT
            PictureBox5.Image = My.Resources.th__1_
            PictureBox6.Image = My.Resources.GOAT
        ElseIf random = 3 Then
            PictureBox4.Image = My.Resources.GOAT
            PictureBox5.Image = My.Resources.GOAT
            PictureBox6.Image = My.Resources.th__1_
        End If
        If random = choice2 AndAlso Switchdoor = False Then
            WIN += 1
        ElseIf random = choice2 AndAlso Switchdoor = True Then
            switchWIN += 1
        ElseIf random <> choice2 AndAlso Switchdoor = False Then
            loss += 1
        ElseIf random <> choice2 AndAlso Switchdoor = True Then
            switchloss += 1
        End If
        total += 1
        winscount.Text = WIN
        switchcount.Text = switches
        totalgames.Text = total
    End Sub
End Class
