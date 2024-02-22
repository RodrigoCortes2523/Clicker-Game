
Public Class Form1
    Dim EH As Integer = 10
    Dim EH2 As Integer = 50
    Dim Coins As Integer = 0
    Dim PH As Integer = 100
    Dim Pattack As Integer = 1
    Dim fireballDamage As Integer = 25
    Dim ravenDamage As Integer = 10
    Dim batDamage As Integer = 1
    Dim bossHealth As Integer = 500
    Dim bossDamage As Integer = 25

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnBat.Click
        EH -= Pattack
        lblEH.Text = EH

        Batdead()
        Batreset()
    End Sub
    Private Sub btnRaven_Click(sender As Object, e As EventArgs) Handles btnRaven.Click
        EH2 -= Pattack
        lblEH.Text = EH2

        Ravendead()
        Ravenreset()


    End Sub
    Private Sub Batdead()
        If (EH <= 0) Then
            batTimer.Enabled = False
            Coins += 1
            lblCoins.Text = Coins
            btnBat.Visible = False
        End If
    End Sub
    Private Sub Batreset()
        If (EH <= 0) Then
            EH = 0
            lblEH.Text = EH

        End If
    End Sub

    Private Sub batTimer_Tick(sender As Object, e As EventArgs) Handles batTimer.Tick
        PH -= batDamage
        lblPH.Text = PH
        If (PH <= 0) Then
            ravenTimer.Enabled = False
            MessageBox.Show("Game Over")
            btnNextRaven.Enabled = False
            btnNext.Enabled = False
            btnBat.Enabled = False
            btnRaven.Enabled = False
            PictureBox1.Enabled = False
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        batTimer.Enabled = True
        btnRaven.Visible = False
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If (btnBat.Visible = False And btnRaven.Visible = False And btnBoss.Visible = False) Then
            EH += 10
            lblEH.Text = EH
            batTimer.Enabled = True
            btnBat.Visible = True
            enemyDamage.Text = batDamage
        End If
    End Sub

    Private Sub btnAttack_Click(sender As Object, e As EventArgs) Handles btnAttack.Click
        If (Coins >= 5) Then
            Pattack += 1
            Coins -= 5
            lblCoins.Text = Coins
            lblPlayerAttack.Text = Pattack
        Else
            lblNotEnoughCoins.Visible = True
            notEnoughCoinsTimer.Enabled = True
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnNextRaven.Click
        If (btnBat.Visible = False And btnRaven.Visible = False And btnBoss.Visible = False) Then
            EH2 = 25
            lblEH.Text = EH2
            btnRaven.Visible = True
            ravenTimer.Enabled = True
            enemyDamage.Text = ravenDamage
            lblEN.Text = "Raven"
        End If
    End Sub
    Private Sub Ravendead()
        If (EH2 <= 0) Then
            ravenTimer.Enabled = False
            Coins += 5
            lblCoins.Text = Coins
            btnRaven.Visible = False
        End If
    End Sub
    Private Sub Ravenreset()
        If (EH2 <= 0) Then
            EH2 = 0
            lblEH.Text = EH

        End If
    End Sub

    Private Sub ravenTimer_Tick(sender As Object, e As EventArgs) Handles ravenTimer.Tick
        PH -= ravenDamage
        lblPH.Text = PH
        If (PH <= 0) Then
            ravenTimer.Enabled = False
            MessageBox.Show("Game Over")
            btnNextRaven.Enabled = False
            btnNext.Enabled = False
            btnBat.Enabled = False
            btnRaven.Enabled = False
            PictureBox1.Visible = False
        End If
    End Sub

    Private Sub btnPotion_Click(sender As Object, e As EventArgs) Handles btnPotion.Click
        If (Coins >= 5) Then
            PH += 5
            Coins -= 5
            lblCoins.Text = Coins
            lblPH.Text = PH
        Else
            lblNotEnoughCoins.Visible = True
            notEnoughCoinsTimer.Enabled = True

        End If
    End Sub

    Private Sub btnFireball_Click(sender As Object, e As EventArgs) Handles btnFireball.Click
        If (Coins >= 50 And btnRaven.Visible = True) Then
            EH2 -= fireballDamage
            Coins -= 50
            lblCoins.Text = Coins
            lblEH.Text = EH2
        Else
            lblNotEnoughCoins.Visible = True
            notEnoughCoinsTimer.Enabled = True
        End If
        If (EH2 <= 0 And btnRaven.Visible = True) Then
            EH2 = 0
            lblEH.Text = EH2
            btnRaven.Visible = False
            Coins += 5
            lblCoins.Text = Coins
            ravenTimer.Enabled = False
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnNextBoss_Click(sender As Object, e As EventArgs) Handles btnNextBoss.Click
        If (btnBat.Visible = False And btnRaven.Visible = False) Then
            batTimer.Enabled = False
            ravenTimer.Enabled = False
            lblEH.Text = bossHealth
            enemyDamage.Text = bossDamage
            lblEN.Text = "Big Boss"
            btnBoss.Visible = True
            bossTimer.Enabled = True
        End If
    End Sub

    Private Sub bossTimer_Tick(sender As Object, e As EventArgs) Handles bossTimer.Tick
        PH -= bossDamage
        lblPH.Text = PH
        If (PH <= 0) Then
            bossTimer.Enabled = False
            MessageBox.Show("Game Over")
            btnNextRaven.Enabled = False
            btnNext.Enabled = False
            btnNextBoss.Enabled = False
            btnBat.Enabled = False
            btnRaven.Enabled = False
            btnBoss.Enabled = False
            PictureBox1.Visible = False
        End If
    End Sub

    Private Sub btnBoss_Click(sender As Object, e As EventArgs) Handles btnBoss.Click
        bossHealth -= Pattack
        lblEH.Text = bossHealth
        bossDead()
    End Sub
    Private Sub bossDead()
        If (bossHealth <= 0) Then
            bossTimer.Enabled = False
            btnBoss.Visible = False
            MessageBox.Show("You WIn")
            btnNext.Enabled = False
            btnNextRaven.Enabled = False
            btnNextBoss.Enabled = False
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        btnBat.Visible = False
        btnRaven.Visible = False
        btnBoss.Visible = False
        batTimer.Enabled = False
        ravenTimer.Enabled = False
        bossTimer.Enabled = False
        btnNext.Enabled = True
        btnNextRaven.Enabled = True
        btnNextBoss.Enabled = True
        PictureBox1.Visible = True
        btnBat.Enabled = True
        btnRaven.Enabled = True
        btnBoss.Enabled = True
        PH = 100
        lblPH.Text = PH
        Coins = 0
        lblCoins.Text = 0
        lblEN.Text = ""
        Pattack = 1
        lblPlayerAttack.Text = Pattack
        lblEH.Text = ""
        enemyDamage.Text = ""
    End Sub

    Private Sub notEnoughCoinsTimer_Tick(sender As Object, e As EventArgs) Handles notEnoughCoinsTimer.Tick
        lblNotEnoughCoins.Visible = False
        notEnoughCoinsTimer.Enabled = False
    End Sub
End Class
