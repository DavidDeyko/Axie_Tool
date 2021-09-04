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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button_Game = New System.Windows.Forms.Button()
        Me.Label_Draw = New System.Windows.Forms.Label()
        Me.Label_Lose = New System.Windows.Forms.Label()
        Me.Label_Win = New System.Windows.Forms.Label()
        Me.Button_Draw = New System.Windows.Forms.Button()
        Me.Button_Lose = New System.Windows.Forms.Button()
        Me.Button_Win = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Reset = New System.Windows.Forms.Button()
        Me.Pierde_Energia = New System.Windows.Forms.Button()
        Me.Gana_Energia = New System.Windows.Forms.Button()
        Me.Pierde_Cartas = New System.Windows.Forms.Button()
        Me.Gana_Cartas = New System.Windows.Forms.Button()
        Me.Next_Round = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button_next_page = New System.Windows.Forms.Button()
        Me.Button_back_page = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ComboBox_varSLP = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox_SLP = New System.Windows.Forms.TextBox()
        Me.CheckBox_Record = New System.Windows.Forms.CheckBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox_miniSLP = New System.Windows.Forms.PictureBox()
        Me.PictureBox_SLP = New System.Windows.Forms.PictureBox()
        Me.PictureBox_Carts = New System.Windows.Forms.PictureBox()
        Me.PictureBox_Energy = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_miniSLP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_SLP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_Carts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_Energy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button_Game
        '
        Me.Button_Game.BackColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Button_Game.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.Button_Game.FlatAppearance.BorderSize = 2
        Me.Button_Game.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Game.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Button_Game.ForeColor = System.Drawing.Color.White
        Me.Button_Game.Location = New System.Drawing.Point(463, 460)
        Me.Button_Game.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Button_Game.Name = "Button_Game"
        Me.Button_Game.Size = New System.Drawing.Size(110, 39)
        Me.Button_Game.TabIndex = 45
        Me.Button_Game.Text = "Reset"
        Me.Button_Game.UseVisualStyleBackColor = False
        Me.Button_Game.Visible = False
        '
        'Label_Draw
        '
        Me.Label_Draw.AutoSize = True
        Me.Label_Draw.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.Label_Draw.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label_Draw.ForeColor = System.Drawing.Color.White
        Me.Label_Draw.Location = New System.Drawing.Point(592, 353)
        Me.Label_Draw.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label_Draw.Name = "Label_Draw"
        Me.Label_Draw.Size = New System.Drawing.Size(25, 28)
        Me.Label_Draw.TabIndex = 43
        Me.Label_Draw.Text = "0"
        Me.Label_Draw.Visible = False
        '
        'Label_Lose
        '
        Me.Label_Lose.AutoSize = True
        Me.Label_Lose.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.Label_Lose.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label_Lose.ForeColor = System.Drawing.Color.White
        Me.Label_Lose.Location = New System.Drawing.Point(504, 353)
        Me.Label_Lose.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label_Lose.Name = "Label_Lose"
        Me.Label_Lose.Size = New System.Drawing.Size(25, 28)
        Me.Label_Lose.TabIndex = 42
        Me.Label_Lose.Text = "0"
        Me.Label_Lose.Visible = False
        '
        'Label_Win
        '
        Me.Label_Win.AutoSize = True
        Me.Label_Win.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.Label_Win.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Win.ForeColor = System.Drawing.Color.White
        Me.Label_Win.Location = New System.Drawing.Point(418, 353)
        Me.Label_Win.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label_Win.Name = "Label_Win"
        Me.Label_Win.Size = New System.Drawing.Size(25, 28)
        Me.Label_Win.TabIndex = 41
        Me.Label_Win.Text = "0"
        Me.Label_Win.Visible = False
        '
        'Button_Draw
        '
        Me.Button_Draw.BackColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Button_Draw.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.Button_Draw.FlatAppearance.BorderSize = 2
        Me.Button_Draw.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Draw.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Button_Draw.ForeColor = System.Drawing.Color.White
        Me.Button_Draw.Location = New System.Drawing.Point(573, 398)
        Me.Button_Draw.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Button_Draw.Name = "Button_Draw"
        Me.Button_Draw.Size = New System.Drawing.Size(65, 39)
        Me.Button_Draw.TabIndex = 40
        Me.Button_Draw.Text = "Draw"
        Me.Button_Draw.UseVisualStyleBackColor = False
        Me.Button_Draw.Visible = False
        '
        'Button_Lose
        '
        Me.Button_Lose.BackColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Button_Lose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.Button_Lose.FlatAppearance.BorderSize = 2
        Me.Button_Lose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Lose.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Button_Lose.ForeColor = System.Drawing.Color.White
        Me.Button_Lose.Location = New System.Drawing.Point(485, 398)
        Me.Button_Lose.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Button_Lose.Name = "Button_Lose"
        Me.Button_Lose.Size = New System.Drawing.Size(65, 39)
        Me.Button_Lose.TabIndex = 39
        Me.Button_Lose.Text = "Lose"
        Me.Button_Lose.UseVisualStyleBackColor = False
        Me.Button_Lose.Visible = False
        '
        'Button_Win
        '
        Me.Button_Win.BackColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Button_Win.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.Button_Win.FlatAppearance.BorderSize = 2
        Me.Button_Win.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Win.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Button_Win.ForeColor = System.Drawing.Color.White
        Me.Button_Win.Location = New System.Drawing.Point(397, 398)
        Me.Button_Win.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Button_Win.Name = "Button_Win"
        Me.Button_Win.Size = New System.Drawing.Size(65, 39)
        Me.Button_Win.TabIndex = 38
        Me.Button_Win.Text = "Win"
        Me.Button_Win.UseVisualStyleBackColor = False
        Me.Button_Win.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Consolas", 21.75!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(169, 196)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 34)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Consolas", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(134, 151)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 34)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Round"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(249, 210)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 28)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "6"
        '
        'Reset
        '
        Me.Reset.BackColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Reset.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.Reset.FlatAppearance.BorderSize = 2
        Me.Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Reset.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Reset.ForeColor = System.Drawing.Color.White
        Me.Reset.Location = New System.Drawing.Point(126, 475)
        Me.Reset.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Reset.Name = "Reset"
        Me.Reset.Size = New System.Drawing.Size(110, 39)
        Me.Reset.TabIndex = 31
        Me.Reset.Text = "Reset"
        Me.Reset.UseVisualStyleBackColor = False
        '
        'Pierde_Energia
        '
        Me.Pierde_Energia.BackColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Pierde_Energia.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.Pierde_Energia.FlatAppearance.BorderSize = 2
        Me.Pierde_Energia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Pierde_Energia.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Pierde_Energia.ForeColor = System.Drawing.Color.White
        Me.Pierde_Energia.Location = New System.Drawing.Point(61, 416)
        Me.Pierde_Energia.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Pierde_Energia.Name = "Pierde_Energia"
        Me.Pierde_Energia.Size = New System.Drawing.Size(90, 39)
        Me.Pierde_Energia.TabIndex = 30
        Me.Pierde_Energia.Text = "- Energy "
        Me.Pierde_Energia.UseVisualStyleBackColor = False
        '
        'Gana_Energia
        '
        Me.Gana_Energia.BackColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Gana_Energia.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.Gana_Energia.FlatAppearance.BorderSize = 2
        Me.Gana_Energia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Gana_Energia.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Gana_Energia.ForeColor = System.Drawing.Color.White
        Me.Gana_Energia.Location = New System.Drawing.Point(61, 352)
        Me.Gana_Energia.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Gana_Energia.Name = "Gana_Energia"
        Me.Gana_Energia.Size = New System.Drawing.Size(90, 39)
        Me.Gana_Energia.TabIndex = 29
        Me.Gana_Energia.Text = "+ Energy"
        Me.Gana_Energia.UseVisualStyleBackColor = False
        '
        'Pierde_Cartas
        '
        Me.Pierde_Cartas.BackColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Pierde_Cartas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.Pierde_Cartas.FlatAppearance.BorderSize = 2
        Me.Pierde_Cartas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Pierde_Cartas.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Pierde_Cartas.ForeColor = System.Drawing.Color.White
        Me.Pierde_Cartas.Location = New System.Drawing.Point(212, 416)
        Me.Pierde_Cartas.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Pierde_Cartas.Name = "Pierde_Cartas"
        Me.Pierde_Cartas.Size = New System.Drawing.Size(90, 39)
        Me.Pierde_Cartas.TabIndex = 28
        Me.Pierde_Cartas.Text = "- Carts"
        Me.Pierde_Cartas.UseVisualStyleBackColor = False
        '
        'Gana_Cartas
        '
        Me.Gana_Cartas.BackColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Gana_Cartas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.Gana_Cartas.FlatAppearance.BorderSize = 2
        Me.Gana_Cartas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Gana_Cartas.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Gana_Cartas.ForeColor = System.Drawing.Color.White
        Me.Gana_Cartas.Location = New System.Drawing.Point(212, 352)
        Me.Gana_Cartas.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Gana_Cartas.Name = "Gana_Cartas"
        Me.Gana_Cartas.Size = New System.Drawing.Size(90, 39)
        Me.Gana_Cartas.TabIndex = 27
        Me.Gana_Cartas.Text = "+ Carts "
        Me.Gana_Cartas.UseVisualStyleBackColor = False
        '
        'Next_Round
        '
        Me.Next_Round.BackColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Next_Round.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.Next_Round.FlatAppearance.BorderSize = 2
        Me.Next_Round.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Next_Round.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Next_Round.ForeColor = System.Drawing.Color.White
        Me.Next_Round.Location = New System.Drawing.Point(126, 294)
        Me.Next_Round.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Next_Round.Name = "Next_Round"
        Me.Next_Round.Size = New System.Drawing.Size(110, 39)
        Me.Next_Round.TabIndex = 26
        Me.Next_Round.Text = "Next Round"
        Me.Next_Round.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.DarkRed
        Me.Label1.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(66, 167)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 28)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "3"
        '
        'Button_next_page
        '
        Me.Button_next_page.BackColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Button_next_page.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.Button_next_page.FlatAppearance.BorderSize = 2
        Me.Button_next_page.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_next_page.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Button_next_page.ForeColor = System.Drawing.Color.White
        Me.Button_next_page.Location = New System.Drawing.Point(212, 573)
        Me.Button_next_page.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Button_next_page.Name = "Button_next_page"
        Me.Button_next_page.Size = New System.Drawing.Size(90, 39)
        Me.Button_next_page.TabIndex = 47
        Me.Button_next_page.Text = "Next"
        Me.Button_next_page.UseVisualStyleBackColor = False
        '
        'Button_back_page
        '
        Me.Button_back_page.BackColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Button_back_page.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.Button_back_page.FlatAppearance.BorderSize = 2
        Me.Button_back_page.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_back_page.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Button_back_page.ForeColor = System.Drawing.Color.White
        Me.Button_back_page.Location = New System.Drawing.Point(61, 573)
        Me.Button_back_page.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Button_back_page.Name = "Button_back_page"
        Me.Button_back_page.Size = New System.Drawing.Size(90, 39)
        Me.Button_back_page.TabIndex = 48
        Me.Button_back_page.Text = "Back"
        Me.Button_back_page.UseVisualStyleBackColor = False
        Me.Button_back_page.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Consolas", 21.75!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(519, 184)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 34)
        Me.Label5.TabIndex = 50
        Me.Label5.Text = "0"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label5.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Consolas", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(449, 184)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 34)
        Me.Label6.TabIndex = 51
        Me.Label6.Text = "SLP"
        Me.Label6.Visible = False
        '
        'ComboBox_varSLP
        '
        Me.ComboBox_varSLP.BackColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.ComboBox_varSLP.Font = New System.Drawing.Font("Consolas", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_varSLP.ForeColor = System.Drawing.Color.White
        Me.ComboBox_varSLP.FormattingEnabled = True
        Me.ComboBox_varSLP.Items.AddRange(New Object() {"0", "1", "3", "6", "9", "12", "15", "18", "21"})
        Me.ComboBox_varSLP.Location = New System.Drawing.Point(583, 294)
        Me.ComboBox_varSLP.Name = "ComboBox_varSLP"
        Me.ComboBox_varSLP.Size = New System.Drawing.Size(69, 40)
        Me.ComboBox_varSLP.TabIndex = 52
        Me.ComboBox_varSLP.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Consolas", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(474, 296)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 34)
        Me.Label7.TabIndex = 54
        Me.Label7.Text = "x"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label7.Visible = False
        '
        'TextBox_SLP
        '
        Me.TextBox_SLP.BackColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.TextBox_SLP.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_SLP.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TextBox_SLP.Font = New System.Drawing.Font("Consolas", 21.75!, System.Drawing.FontStyle.Bold)
        Me.TextBox_SLP.ForeColor = System.Drawing.Color.White
        Me.TextBox_SLP.Location = New System.Drawing.Point(506, 296)
        Me.TextBox_SLP.Name = "TextBox_SLP"
        Me.TextBox_SLP.Size = New System.Drawing.Size(67, 34)
        Me.TextBox_SLP.TabIndex = 55
        Me.TextBox_SLP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TextBox_SLP.Visible = False
        '
        'CheckBox_Record
        '
        Me.CheckBox_Record.AutoSize = True
        Me.CheckBox_Record.BackColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.CheckBox_Record.FlatAppearance.BorderSize = 5
        Me.CheckBox_Record.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox_Record.ForeColor = System.Drawing.Color.White
        Me.CheckBox_Record.Location = New System.Drawing.Point(492, 505)
        Me.CheckBox_Record.Name = "CheckBox_Record"
        Me.CheckBox_Record.Size = New System.Drawing.Size(54, 19)
        Me.CheckBox_Record.TabIndex = 56
        Me.CheckBox_Record.Text = "Save"
        Me.CheckBox_Record.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CheckBox_Record.UseVisualStyleBackColor = False
        Me.CheckBox_Record.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.PictureBox1.Image = Global.AppAxies.My.Resources.Resources.GitHub_Logo
        Me.PictureBox1.Location = New System.Drawing.Point(151, 531)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(61, 35)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 57
        Me.PictureBox1.TabStop = False
        '
        'PictureBox_miniSLP
        '
        Me.PictureBox_miniSLP.BackColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.PictureBox_miniSLP.Image = Global.AppAxies.My.Resources.Resources.SLP
        Me.PictureBox_miniSLP.Location = New System.Drawing.Point(440, 296)
        Me.PictureBox_miniSLP.Name = "PictureBox_miniSLP"
        Me.PictureBox_miniSLP.Size = New System.Drawing.Size(34, 34)
        Me.PictureBox_miniSLP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_miniSLP.TabIndex = 53
        Me.PictureBox_miniSLP.TabStop = False
        Me.PictureBox_miniSLP.Visible = False
        '
        'PictureBox_SLP
        '
        Me.PictureBox_SLP.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.PictureBox_SLP.Image = Global.AppAxies.My.Resources.Resources.SLP
        Me.PictureBox_SLP.Location = New System.Drawing.Point(384, 167)
        Me.PictureBox_SLP.Name = "PictureBox_SLP"
        Me.PictureBox_SLP.Size = New System.Drawing.Size(60, 60)
        Me.PictureBox_SLP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_SLP.TabIndex = 49
        Me.PictureBox_SLP.TabStop = False
        Me.PictureBox_SLP.Visible = False
        '
        'PictureBox_Carts
        '
        Me.PictureBox_Carts.Image = Global.AppAxies.My.Resources.Resources.Cart2
        Me.PictureBox_Carts.Location = New System.Drawing.Point(240, 168)
        Me.PictureBox_Carts.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictureBox_Carts.Name = "PictureBox_Carts"
        Me.PictureBox_Carts.Size = New System.Drawing.Size(53, 53)
        Me.PictureBox_Carts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_Carts.TabIndex = 33
        Me.PictureBox_Carts.TabStop = False
        '
        'PictureBox_Energy
        '
        Me.PictureBox_Energy.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox_Energy.Image = Global.AppAxies.My.Resources.Resources.Energ
        Me.PictureBox_Energy.Location = New System.Drawing.Point(74, 174)
        Me.PictureBox_Energy.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictureBox_Energy.Name = "PictureBox_Energy"
        Me.PictureBox_Energy.Size = New System.Drawing.Size(53, 53)
        Me.PictureBox_Energy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_Energy.TabIndex = 32
        Me.PictureBox_Energy.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(8, 8)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(347, 625)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 25
        Me.PictureBox4.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(361, 641)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.CheckBox_Record)
        Me.Controls.Add(Me.TextBox_SLP)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PictureBox_miniSLP)
        Me.Controls.Add(Me.ComboBox_varSLP)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PictureBox_SLP)
        Me.Controls.Add(Me.Button_back_page)
        Me.Controls.Add(Me.Button_next_page)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button_Win)
        Me.Controls.Add(Me.Button_Game)
        Me.Controls.Add(Me.Button_Lose)
        Me.Controls.Add(Me.Button_Draw)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label_Draw)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label_Win)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label_Lose)
        Me.Controls.Add(Me.PictureBox_Carts)
        Me.Controls.Add(Me.PictureBox_Energy)
        Me.Controls.Add(Me.Reset)
        Me.Controls.Add(Me.Pierde_Energia)
        Me.Controls.Add(Me.Gana_Energia)
        Me.Controls.Add(Me.Pierde_Cartas)
        Me.Controls.Add(Me.Gana_Cartas)
        Me.Controls.Add(Me.Next_Round)
        Me.Controls.Add(Me.PictureBox4)
        Me.Font = New System.Drawing.Font("Adobe Heiti Std R", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Axie_Energy_Carts"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_miniSLP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_SLP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_Carts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_Energy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Button_Game As Button
    Friend WithEvents Label_Draw As Label
    Friend WithEvents Label_Lose As Label
    Friend WithEvents Label_Win As Label
    Friend WithEvents Button_Draw As Button
    Friend WithEvents Button_Lose As Button
    Friend WithEvents Button_Win As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox_Carts As PictureBox
    Friend WithEvents PictureBox_Energy As PictureBox
    Friend WithEvents Reset As Button
    Friend WithEvents Pierde_Energia As Button
    Friend WithEvents Gana_Energia As Button
    Friend WithEvents Pierde_Cartas As Button
    Friend WithEvents Gana_Cartas As Button
    Friend WithEvents Next_Round As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button_next_page As Button
    Friend WithEvents Button_back_page As Button
    Friend WithEvents PictureBox_SLP As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ComboBox_varSLP As ComboBox
    Friend WithEvents PictureBox_miniSLP As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox_SLP As TextBox
    Friend WithEvents CheckBox_Record As CheckBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
