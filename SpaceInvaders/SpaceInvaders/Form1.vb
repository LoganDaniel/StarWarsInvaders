Public Class lblScore
    Dim Enemy(9) As PictureBox
    Dim MoveEnemy As Integer = 3
    Dim Score As Integer = 0
    Dim WhichShip As Integer
    Dim Faster As Integer

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Left Then
            pbFalcon.Location = New Point(pbFalcon.Location.X - 10, pbFalcon.Location.Y)
        End If
        If e.KeyCode = Keys.Right Then
            pbFalcon.Location = New Point(pbFalcon.Location.X + 10, pbFalcon.Location.Y)
        End If

        If e.KeyCode = Keys.Space And pbBullet.Visible = False Then
            pbBullet.Location = New Point(pbFalcon.Location.X + 20, pbFalcon.Location.Y)
            pbBullet.Visible = True
            TimerShoot.Start()
        End If

    End Sub
    Private Sub TimerShoot_Tick(sender As Object, e As EventArgs) Handles TimerShoot.Tick
        If pbBullet.Visible = True Then
            pbBullet.Top = pbBullet.Top - 25
        End If

        If pbBullet.Top + pbBullet.Height < Me.ClientRectangle.Top Then
            pbBullet.Visible = False
        End If

        For i = 0 To 9
            If pbBullet.Bounds.IntersectsWith(Enemy(i).Bounds) Then
                pbBullet.Visible = False
                WhichShip = i
                Enemy(WhichShip).Top = Enemy(WhichShip).Top + 10000
                Enemy(WhichShip).Dispose()
                pbBullet.Location = New Point(pbBullet.Location.X + 1000, pbBullet.Location.Y)
                Score = Score + 10
                LabelScore.Text = ("SCORE: " & Score)
                TimerEnemy.Interval = TimerEnemy.Interval - 7
            End If
        Next

    End Sub

    Private Sub TimerEnemy_Tick(sender As Object, e As EventArgs) Handles TimerEnemy.Tick
        Enemy(0) = TieF1
        Enemy(1) = Tie2
        Enemy(2) = Tie3
        Enemy(3) = Tie4
        Enemy(4) = Tie5
        Enemy(5) = Tie6
        Enemy(6) = Tie7
        Enemy(7) = Tie8
        Enemy(8) = Tie9
        Enemy(9) = Tie10
        For l = 0 To 9
            MoveTieFighters()
        Next

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TimerEnemy.Start()
    End Sub

    Private Sub MoveTieFighters()

        For i = 0 To 9
            Enemy(i).Left = Enemy(i).Left + MoveEnemy

            If Enemy(i).Left + Enemy(i).Width > 1000 Then
                MoveEnemy = MoveEnemy * -1
                Enemy(0).Top = Enemy(0).Top + 25
                Enemy(1).Top = Enemy(1).Top + 25
                Enemy(2).Top = Enemy(2).Top + 25
                Enemy(3).Top = Enemy(3).Top + 25
                Enemy(4).Top = Enemy(4).Top + 25
                Enemy(5).Top = Enemy(5).Top + 25
                Enemy(6).Top = Enemy(6).Top + 25
                Enemy(7).Top = Enemy(7).Top + 25
                Enemy(8).Top = Enemy(8).Top + 25
                Enemy(9).Top = Enemy(9).Top + 25
            ElseIf Enemy(i).Left < 0 Then
                MoveEnemy = MoveEnemy * -1
                Enemy(0).Top = Enemy(0).Top + 25
                Enemy(1).Top = Enemy(1).Top + 25
                Enemy(2).Top = Enemy(2).Top + 25
                Enemy(3).Top = Enemy(3).Top + 25
                Enemy(4).Top = Enemy(4).Top + 25
                Enemy(5).Top = Enemy(5).Top + 25
                Enemy(6).Top = Enemy(6).Top + 25
                Enemy(7).Top = Enemy(7).Top + 25
                Enemy(8).Top = Enemy(8).Top + 25
                Enemy(9).Top = Enemy(9).Top + 25

            End If
        Next

        'For i = 0 To 9
        '    Enemy(i).Left = Enemy(i).Left + MoveEnemy

        'Next

        'If Tie6.Left > 1000 Then
        '    MoveEnemy = MoveEnemy * -1
        '    For i = 0 To 9
        '        Enemy(i).Top = Enemy(i).Top + 25
        '    Next
        'End If

        'If TieF1.Left < 0 Then
        '    MoveEnemy = MoveEnemy * -1
        '    For i = 0 To 9
        '        Enemy(i).Top = Enemy(i).Top + 25
        '    Next
        'End If

    End Sub

End Class
