<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class lblScore
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(lblScore))
        Me.TimerShoot = New System.Windows.Forms.Timer(Me.components)
        Me.LabelScore = New System.Windows.Forms.Label()
        Me.pbBullet = New System.Windows.Forms.PictureBox()
        Me.pbFalcon = New System.Windows.Forms.PictureBox()
        Me.pbDeathStar = New System.Windows.Forms.PictureBox()
        Me.TieF1 = New System.Windows.Forms.PictureBox()
        Me.Tie2 = New System.Windows.Forms.PictureBox()
        Me.Tie4 = New System.Windows.Forms.PictureBox()
        Me.Tie3 = New System.Windows.Forms.PictureBox()
        Me.Tie5 = New System.Windows.Forms.PictureBox()
        Me.Tie10 = New System.Windows.Forms.PictureBox()
        Me.Tie9 = New System.Windows.Forms.PictureBox()
        Me.Tie8 = New System.Windows.Forms.PictureBox()
        Me.Tie7 = New System.Windows.Forms.PictureBox()
        Me.TimerEnemy = New System.Windows.Forms.Timer(Me.components)
        Me.Tie6 = New System.Windows.Forms.PictureBox()
        CType(Me.pbBullet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbFalcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbDeathStar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TieF1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tie2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tie4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tie3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tie5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tie10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tie9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tie8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tie7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tie6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TimerShoot
        '
        Me.TimerShoot.Interval = 10
        '
        'LabelScore
        '
        Me.LabelScore.AutoSize = True
        Me.LabelScore.BackColor = System.Drawing.Color.Transparent
        Me.LabelScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelScore.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LabelScore.Location = New System.Drawing.Point(12, 612)
        Me.LabelScore.Name = "LabelScore"
        Me.LabelScore.Size = New System.Drawing.Size(147, 37)
        Me.LabelScore.TabIndex = 5
        Me.LabelScore.Text = "SCORE: "
        '
        'pbBullet
        '
        Me.pbBullet.BackColor = System.Drawing.Color.Transparent
        Me.pbBullet.BackgroundImage = CType(resources.GetObject("pbBullet.BackgroundImage"), System.Drawing.Image)
        Me.pbBullet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbBullet.Location = New System.Drawing.Point(19, 578)
        Me.pbBullet.Name = "pbBullet"
        Me.pbBullet.Size = New System.Drawing.Size(10, 31)
        Me.pbBullet.TabIndex = 2
        Me.pbBullet.TabStop = False
        Me.pbBullet.Visible = False
        '
        'pbFalcon
        '
        Me.pbFalcon.BackColor = System.Drawing.Color.Transparent
        Me.pbFalcon.BackgroundImage = Global.SpaceInvaders.My.Resources.Resources.Falcon
        Me.pbFalcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbFalcon.Location = New System.Drawing.Point(410, 596)
        Me.pbFalcon.Name = "pbFalcon"
        Me.pbFalcon.Size = New System.Drawing.Size(49, 53)
        Me.pbFalcon.TabIndex = 1
        Me.pbFalcon.TabStop = False
        '
        'pbDeathStar
        '
        Me.pbDeathStar.BackColor = System.Drawing.Color.Transparent
        Me.pbDeathStar.BackgroundImage = Global.SpaceInvaders.My.Resources.Resources.DeathStar
        Me.pbDeathStar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbDeathStar.Location = New System.Drawing.Point(831, -4)
        Me.pbDeathStar.Name = "pbDeathStar"
        Me.pbDeathStar.Size = New System.Drawing.Size(88, 89)
        Me.pbDeathStar.TabIndex = 0
        Me.pbDeathStar.TabStop = False
        '
        'TieF1
        '
        Me.TieF1.BackColor = System.Drawing.Color.Transparent
        Me.TieF1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.TieF1.Image = Global.SpaceInvaders.My.Resources.Resources.TieFighter
        Me.TieF1.Location = New System.Drawing.Point(203, 97)
        Me.TieF1.Name = "TieF1"
        Me.TieF1.Size = New System.Drawing.Size(53, 49)
        Me.TieF1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.TieF1.TabIndex = 6
        Me.TieF1.TabStop = False
        '
        'Tie2
        '
        Me.Tie2.BackColor = System.Drawing.Color.Transparent
        Me.Tie2.BackgroundImage = CType(resources.GetObject("Tie2.BackgroundImage"), System.Drawing.Image)
        Me.Tie2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Tie2.Location = New System.Drawing.Point(316, 97)
        Me.Tie2.Name = "Tie2"
        Me.Tie2.Size = New System.Drawing.Size(53, 49)
        Me.Tie2.TabIndex = 7
        Me.Tie2.TabStop = False
        '
        'Tie4
        '
        Me.Tie4.BackColor = System.Drawing.Color.Transparent
        Me.Tie4.BackgroundImage = CType(resources.GetObject("Tie4.BackgroundImage"), System.Drawing.Image)
        Me.Tie4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Tie4.Location = New System.Drawing.Point(545, 97)
        Me.Tie4.Name = "Tie4"
        Me.Tie4.Size = New System.Drawing.Size(53, 49)
        Me.Tie4.TabIndex = 9
        Me.Tie4.TabStop = False
        '
        'Tie3
        '
        Me.Tie3.BackColor = System.Drawing.Color.Transparent
        Me.Tie3.BackgroundImage = CType(resources.GetObject("Tie3.BackgroundImage"), System.Drawing.Image)
        Me.Tie3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Tie3.Location = New System.Drawing.Point(432, 97)
        Me.Tie3.Name = "Tie3"
        Me.Tie3.Size = New System.Drawing.Size(53, 49)
        Me.Tie3.TabIndex = 8
        Me.Tie3.TabStop = False
        '
        'Tie5
        '
        Me.Tie5.BackColor = System.Drawing.Color.Transparent
        Me.Tie5.BackgroundImage = CType(resources.GetObject("Tie5.BackgroundImage"), System.Drawing.Image)
        Me.Tie5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Tie5.Location = New System.Drawing.Point(659, 97)
        Me.Tie5.Name = "Tie5"
        Me.Tie5.Size = New System.Drawing.Size(53, 49)
        Me.Tie5.TabIndex = 10
        Me.Tie5.TabStop = False
        '
        'Tie10
        '
        Me.Tie10.BackColor = System.Drawing.Color.Transparent
        Me.Tie10.BackgroundImage = CType(resources.GetObject("Tie10.BackgroundImage"), System.Drawing.Image)
        Me.Tie10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Tie10.Location = New System.Drawing.Point(545, 188)
        Me.Tie10.Name = "Tie10"
        Me.Tie10.Size = New System.Drawing.Size(53, 49)
        Me.Tie10.TabIndex = 15
        Me.Tie10.TabStop = False
        '
        'Tie9
        '
        Me.Tie9.BackColor = System.Drawing.Color.Transparent
        Me.Tie9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Tie9.Image = Global.SpaceInvaders.My.Resources.Resources.TieFighter
        Me.Tie9.Location = New System.Drawing.Point(432, 188)
        Me.Tie9.Name = "Tie9"
        Me.Tie9.Size = New System.Drawing.Size(53, 49)
        Me.Tie9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Tie9.TabIndex = 14
        Me.Tie9.TabStop = False
        '
        'Tie8
        '
        Me.Tie8.BackColor = System.Drawing.Color.Transparent
        Me.Tie8.BackgroundImage = CType(resources.GetObject("Tie8.BackgroundImage"), System.Drawing.Image)
        Me.Tie8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Tie8.Location = New System.Drawing.Point(316, 188)
        Me.Tie8.Name = "Tie8"
        Me.Tie8.Size = New System.Drawing.Size(53, 49)
        Me.Tie8.TabIndex = 13
        Me.Tie8.TabStop = False
        '
        'Tie7
        '
        Me.Tie7.BackColor = System.Drawing.Color.Transparent
        Me.Tie7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Tie7.Image = Global.SpaceInvaders.My.Resources.Resources.TieFighter
        Me.Tie7.Location = New System.Drawing.Point(203, 188)
        Me.Tie7.Name = "Tie7"
        Me.Tie7.Size = New System.Drawing.Size(53, 49)
        Me.Tie7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Tie7.TabIndex = 12
        Me.Tie7.TabStop = False
        '
        'TimerEnemy
        '
        '
        'Tie6
        '
        Me.Tie6.BackColor = System.Drawing.Color.Transparent
        Me.Tie6.BackgroundImage = CType(resources.GetObject("Tie6.BackgroundImage"), System.Drawing.Image)
        Me.Tie6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Tie6.Location = New System.Drawing.Point(659, 188)
        Me.Tie6.Name = "Tie6"
        Me.Tie6.Size = New System.Drawing.Size(53, 49)
        Me.Tie6.TabIndex = 11
        Me.Tie6.TabStop = False
        '
        'lblScore
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SpaceInvaders.My.Resources.Resources.Space
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(984, 661)
        Me.Controls.Add(Me.Tie10)
        Me.Controls.Add(Me.Tie9)
        Me.Controls.Add(Me.Tie8)
        Me.Controls.Add(Me.Tie7)
        Me.Controls.Add(Me.Tie6)
        Me.Controls.Add(Me.Tie5)
        Me.Controls.Add(Me.Tie4)
        Me.Controls.Add(Me.Tie3)
        Me.Controls.Add(Me.Tie2)
        Me.Controls.Add(Me.TieF1)
        Me.Controls.Add(Me.LabelScore)
        Me.Controls.Add(Me.pbBullet)
        Me.Controls.Add(Me.pbFalcon)
        Me.Controls.Add(Me.pbDeathStar)
        Me.DoubleBuffered = True
        Me.Name = "lblScore"
        Me.Text = "Form1"
        CType(Me.pbBullet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbFalcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbDeathStar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TieF1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tie2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tie4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tie3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tie5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tie10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tie9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tie8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tie7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tie6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pbDeathStar As System.Windows.Forms.PictureBox
    Friend WithEvents pbFalcon As System.Windows.Forms.PictureBox
    Friend WithEvents pbBullet As System.Windows.Forms.PictureBox
    Friend WithEvents TimerShoot As System.Windows.Forms.Timer
    Friend WithEvents LabelScore As System.Windows.Forms.Label
    Friend WithEvents TieF1 As System.Windows.Forms.PictureBox
    Friend WithEvents Tie2 As System.Windows.Forms.PictureBox
    Friend WithEvents Tie4 As System.Windows.Forms.PictureBox
    Friend WithEvents Tie3 As System.Windows.Forms.PictureBox
    Friend WithEvents Tie5 As System.Windows.Forms.PictureBox
    Friend WithEvents Tie10 As System.Windows.Forms.PictureBox
    Friend WithEvents Tie9 As System.Windows.Forms.PictureBox
    Friend WithEvents Tie8 As System.Windows.Forms.PictureBox
    Friend WithEvents Tie7 As System.Windows.Forms.PictureBox
    Friend WithEvents TimerEnemy As System.Windows.Forms.Timer
    Friend WithEvents Tie6 As System.Windows.Forms.PictureBox

End Class
