<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnBat = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblPH = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblEH = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblEN = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblCoins = New System.Windows.Forms.Label()
        Me.batTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAttack = New System.Windows.Forms.Button()
        Me.btnPotion = New System.Windows.Forms.Button()
        Me.btnFireball = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnNextRaven = New System.Windows.Forms.Button()
        Me.btnNextBoss = New System.Windows.Forms.Button()
        Me.btnRaven = New System.Windows.Forms.Button()
        Me.ravenTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblPlayerAttack = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.enemyDamage = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnBoss = New System.Windows.Forms.Button()
        Me.bossTimer = New System.Windows.Forms.Timer(Me.components)
        Me.lblNotEnoughCoins = New System.Windows.Forms.Label()
        Me.notEnoughCoinsTimer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnBat
        '
        Me.btnBat.BackColor = System.Drawing.Color.Transparent
        Me.btnBat.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnBat.FlatAppearance.BorderSize = 0
        Me.btnBat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnBat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnBat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBat.Image = CType(resources.GetObject("btnBat.Image"), System.Drawing.Image)
        Me.btnBat.Location = New System.Drawing.Point(381, 159)
        Me.btnBat.Name = "btnBat"
        Me.btnBat.Size = New System.Drawing.Size(136, 118)
        Me.btnBat.TabIndex = 2
        Me.btnBat.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(50, 117)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(166, 238)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Showcard Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(3, 379)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(208, 33)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Your Health:"
        '
        'lblPH
        '
        Me.lblPH.AutoSize = True
        Me.lblPH.BackColor = System.Drawing.Color.Transparent
        Me.lblPH.Font = New System.Drawing.Font("Showcard Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblPH.ForeColor = System.Drawing.Color.Red
        Me.lblPH.Location = New System.Drawing.Point(226, 379)
        Me.lblPH.Name = "lblPH"
        Me.lblPH.Size = New System.Drawing.Size(58, 33)
        Me.lblPH.TabIndex = 19
        Me.lblPH.Text = "100"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Showcard Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(326, 322)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(223, 33)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Enemy Health:"
        '
        'lblEH
        '
        Me.lblEH.AutoSize = True
        Me.lblEH.BackColor = System.Drawing.Color.Transparent
        Me.lblEH.Font = New System.Drawing.Font("Showcard Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblEH.ForeColor = System.Drawing.Color.Red
        Me.lblEH.Location = New System.Drawing.Point(555, 322)
        Me.lblEH.Name = "lblEH"
        Me.lblEH.Size = New System.Drawing.Size(42, 33)
        Me.lblEH.TabIndex = 15
        Me.lblEH.Text = "10"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Showcard Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(96, 74)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 40)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "You"
        '
        'lblEN
        '
        Me.lblEN.AutoSize = True
        Me.lblEN.BackColor = System.Drawing.Color.Transparent
        Me.lblEN.Font = New System.Drawing.Font("Showcard Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblEN.ForeColor = System.Drawing.Color.DarkRed
        Me.lblEN.Location = New System.Drawing.Point(381, 83)
        Me.lblEN.Name = "lblEN"
        Me.lblEN.Size = New System.Drawing.Size(78, 40)
        Me.lblEN.TabIndex = 5
        Me.lblEN.Text = "Bat"
        Me.lblEN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Showcard Gothic", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(150, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(509, 60)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Rod's Clicker Game"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Showcard Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(12, 614)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(102, 33)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Coins:"
        '
        'lblCoins
        '
        Me.lblCoins.AutoSize = True
        Me.lblCoins.BackColor = System.Drawing.Color.Transparent
        Me.lblCoins.Font = New System.Drawing.Font("Showcard Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblCoins.ForeColor = System.Drawing.Color.Yellow
        Me.lblCoins.Location = New System.Drawing.Point(114, 614)
        Me.lblCoins.Name = "lblCoins"
        Me.lblCoins.Size = New System.Drawing.Size(31, 33)
        Me.lblCoins.TabIndex = 22
        Me.lblCoins.Text = "0"
        '
        'batTimer
        '
        Me.batTimer.Interval = 1000
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Showcard Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(703, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 30)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Shop"
        '
        'btnAttack
        '
        Me.btnAttack.BackColor = System.Drawing.Color.Transparent
        Me.btnAttack.FlatAppearance.BorderSize = 0
        Me.btnAttack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnAttack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnAttack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAttack.Font = New System.Drawing.Font("Showcard Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnAttack.Image = CType(resources.GetObject("btnAttack.Image"), System.Drawing.Image)
        Me.btnAttack.Location = New System.Drawing.Point(643, 168)
        Me.btnAttack.Name = "btnAttack"
        Me.btnAttack.Size = New System.Drawing.Size(156, 55)
        Me.btnAttack.TabIndex = 6
        Me.btnAttack.Text = "Attack"
        Me.btnAttack.UseVisualStyleBackColor = False
        '
        'btnPotion
        '
        Me.btnPotion.BackColor = System.Drawing.Color.Transparent
        Me.btnPotion.FlatAppearance.BorderSize = 0
        Me.btnPotion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnPotion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnPotion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPotion.Font = New System.Drawing.Font("Showcard Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnPotion.Image = CType(resources.GetObject("btnPotion.Image"), System.Drawing.Image)
        Me.btnPotion.Location = New System.Drawing.Point(643, 229)
        Me.btnPotion.Name = "btnPotion"
        Me.btnPotion.Size = New System.Drawing.Size(156, 48)
        Me.btnPotion.TabIndex = 7
        Me.btnPotion.Text = "Health"
        Me.btnPotion.UseVisualStyleBackColor = False
        '
        'btnFireball
        '
        Me.btnFireball.BackColor = System.Drawing.Color.Transparent
        Me.btnFireball.FlatAppearance.BorderSize = 0
        Me.btnFireball.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnFireball.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnFireball.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFireball.Font = New System.Drawing.Font("Showcard Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnFireball.Image = CType(resources.GetObject("btnFireball.Image"), System.Drawing.Image)
        Me.btnFireball.Location = New System.Drawing.Point(645, 281)
        Me.btnFireball.Name = "btnFireball"
        Me.btnFireball.Size = New System.Drawing.Size(156, 47)
        Me.btnFireball.TabIndex = 8
        Me.btnFireball.Text = "Fireball"
        Me.btnFireball.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Showcard Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.Yellow
        Me.Label4.Location = New System.Drawing.Point(805, 184)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 20)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "5 Coins"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Showcard Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.Color.Yellow
        Me.Label6.Location = New System.Drawing.Point(805, 244)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 20)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "5 Coins"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Showcard Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label9.ForeColor = System.Drawing.Color.Yellow
        Me.Label9.Location = New System.Drawing.Point(807, 295)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(77, 20)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "50 Coins"
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.Transparent
        Me.btnNext.FlatAppearance.BorderSize = 0
        Me.btnNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNext.Font = New System.Drawing.Font("Showcard Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnNext.Image = CType(resources.GetObject("btnNext.Image"), System.Drawing.Image)
        Me.btnNext.Location = New System.Drawing.Point(297, 394)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(323, 86)
        Me.btnNext.TabIndex = 25
        Me.btnNext.Text = "Next Bat"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'btnNextRaven
        '
        Me.btnNextRaven.BackColor = System.Drawing.Color.Transparent
        Me.btnNextRaven.FlatAppearance.BorderSize = 0
        Me.btnNextRaven.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnNextRaven.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnNextRaven.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNextRaven.Font = New System.Drawing.Font("Showcard Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnNextRaven.Image = CType(resources.GetObject("btnNextRaven.Image"), System.Drawing.Image)
        Me.btnNextRaven.Location = New System.Drawing.Point(297, 486)
        Me.btnNextRaven.Name = "btnNextRaven"
        Me.btnNextRaven.Size = New System.Drawing.Size(323, 86)
        Me.btnNextRaven.TabIndex = 24
        Me.btnNextRaven.Text = "Next Raven"
        Me.btnNextRaven.UseVisualStyleBackColor = False
        '
        'btnNextBoss
        '
        Me.btnNextBoss.BackColor = System.Drawing.Color.Transparent
        Me.btnNextBoss.FlatAppearance.BorderSize = 0
        Me.btnNextBoss.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnNextBoss.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnNextBoss.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNextBoss.Font = New System.Drawing.Font("Showcard Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnNextBoss.Image = CType(resources.GetObject("btnNextBoss.Image"), System.Drawing.Image)
        Me.btnNextBoss.Location = New System.Drawing.Point(297, 578)
        Me.btnNextBoss.Name = "btnNextBoss"
        Me.btnNextBoss.Size = New System.Drawing.Size(323, 86)
        Me.btnNextBoss.TabIndex = 23
        Me.btnNextBoss.Text = "Boss"
        Me.btnNextBoss.UseVisualStyleBackColor = False
        '
        'btnRaven
        '
        Me.btnRaven.BackColor = System.Drawing.Color.Transparent
        Me.btnRaven.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnRaven.FlatAppearance.BorderSize = 0
        Me.btnRaven.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnRaven.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnRaven.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRaven.Image = CType(resources.GetObject("btnRaven.Image"), System.Drawing.Image)
        Me.btnRaven.Location = New System.Drawing.Point(381, 157)
        Me.btnRaven.Name = "btnRaven"
        Me.btnRaven.Size = New System.Drawing.Size(136, 118)
        Me.btnRaven.TabIndex = 4
        Me.btnRaven.UseVisualStyleBackColor = False
        '
        'ravenTimer
        '
        Me.ravenTimer.Interval = 1000
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Showcard Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(3, 437)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(241, 33)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "Attack Damage:"
        '
        'lblPlayerAttack
        '
        Me.lblPlayerAttack.AutoSize = True
        Me.lblPlayerAttack.BackColor = System.Drawing.Color.Transparent
        Me.lblPlayerAttack.Font = New System.Drawing.Font("Showcard Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblPlayerAttack.ForeColor = System.Drawing.Color.Red
        Me.lblPlayerAttack.Location = New System.Drawing.Point(250, 437)
        Me.lblPlayerAttack.Name = "lblPlayerAttack"
        Me.lblPlayerAttack.Size = New System.Drawing.Size(26, 33)
        Me.lblPlayerAttack.TabIndex = 20
        Me.lblPlayerAttack.Text = "1"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Showcard Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(326, 355)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(241, 33)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Attack Damage:"
        '
        'enemyDamage
        '
        Me.enemyDamage.AutoSize = True
        Me.enemyDamage.BackColor = System.Drawing.Color.Transparent
        Me.enemyDamage.Font = New System.Drawing.Font("Showcard Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.enemyDamage.ForeColor = System.Drawing.Color.Red
        Me.enemyDamage.Location = New System.Drawing.Point(555, 355)
        Me.enemyDamage.Name = "enemyDamage"
        Me.enemyDamage.Size = New System.Drawing.Size(26, 33)
        Me.enemyDamage.TabIndex = 16
        Me.enemyDamage.Text = "1"
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.Transparent
        Me.btnReset.FlatAppearance.BorderSize = 0
        Me.btnReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReset.Font = New System.Drawing.Font("Showcard Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnReset.Image = CType(resources.GetObject("btnReset.Image"), System.Drawing.Image)
        Me.btnReset.Location = New System.Drawing.Point(645, 434)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(157, 46)
        Me.btnReset.TabIndex = 26
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Transparent
        Me.btnExit.FlatAppearance.BorderSize = 0
        Me.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Showcard Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.Location = New System.Drawing.Point(645, 486)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(157, 48)
        Me.btnExit.TabIndex = 27
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnBoss
        '
        Me.btnBoss.BackColor = System.Drawing.Color.Transparent
        Me.btnBoss.FlatAppearance.BorderSize = 0
        Me.btnBoss.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnBoss.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnBoss.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBoss.Image = CType(resources.GetObject("btnBoss.Image"), System.Drawing.Image)
        Me.btnBoss.Location = New System.Drawing.Point(393, 159)
        Me.btnBoss.Name = "btnBoss"
        Me.btnBoss.Size = New System.Drawing.Size(124, 140)
        Me.btnBoss.TabIndex = 3
        Me.btnBoss.UseVisualStyleBackColor = False
        Me.btnBoss.Visible = False
        '
        'bossTimer
        '
        Me.bossTimer.Interval = 1000
        '
        'lblNotEnoughCoins
        '
        Me.lblNotEnoughCoins.AutoSize = True
        Me.lblNotEnoughCoins.BackColor = System.Drawing.Color.Transparent
        Me.lblNotEnoughCoins.Font = New System.Drawing.Font("Showcard Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblNotEnoughCoins.ForeColor = System.Drawing.Color.White
        Me.lblNotEnoughCoins.Location = New System.Drawing.Point(639, 355)
        Me.lblNotEnoughCoins.Name = "lblNotEnoughCoins"
        Me.lblNotEnoughCoins.Size = New System.Drawing.Size(244, 30)
        Me.lblNotEnoughCoins.TabIndex = 28
        Me.lblNotEnoughCoins.Text = "Not Enough Coins!"
        Me.lblNotEnoughCoins.Visible = False
        '
        'notEnoughCoinsTimer
        '
        Me.notEnoughCoinsTimer.Interval = 1000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(906, 676)
        Me.Controls.Add(Me.lblNotEnoughCoins)
        Me.Controls.Add(Me.btnBoss)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnNextBoss)
        Me.Controls.Add(Me.btnNextRaven)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnFireball)
        Me.Controls.Add(Me.btnPotion)
        Me.Controls.Add(Me.btnAttack)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblCoins)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblEN)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.enemyDamage)
        Me.Controls.Add(Me.lblEH)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblPlayerAttack)
        Me.Controls.Add(Me.lblPH)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnRaven)
        Me.Controls.Add(Me.btnBat)
        Me.DoubleBuffered = True
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBat As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblPH As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblEH As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblEN As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblCoins As Label
    Friend WithEvents batTimer As Timer
    Friend WithEvents Label2 As Label
    Friend WithEvents btnAttack As Button
    Friend WithEvents btnPotion As Button
    Friend WithEvents btnFireball As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btnNext As Button
    Friend WithEvents btnNextRaven As Button
    Friend WithEvents btnNextBoss As Button
    Friend WithEvents btnRaven As Button
    Friend WithEvents ravenTimer As Timer
    Friend WithEvents Label12 As Label
    Friend WithEvents lblPlayerAttack As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents enemyDamage As Label
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnBoss As Button
    Friend WithEvents bossTimer As Timer
    Friend WithEvents lblNotEnoughCoins As Label
    Friend WithEvents notEnoughCoinsTimer As Timer
End Class
