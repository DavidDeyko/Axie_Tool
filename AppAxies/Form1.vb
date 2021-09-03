Public Class Form1
    Dim Energy% = 3
    Dim Carts% = 6
    Dim Round% = 1
    Dim Win% = 0
    Dim Lose% = 0
    Dim Draw% = 0
    Dim VarSLP% = 0

    Private Sub Gana_Energia_Click(sender As Object, e As EventArgs) Handles Gana_Energia.Click
        Energy += 1
        If Energy > 10 Then
            Energy = 10
        End If
        Label1.Text = Energy.ToString()
    End Sub

    Private Sub Pierde_Energia_Click(sender As Object, e As EventArgs) Handles Pierde_Energia.Click
        Energy -= 1
        If Energy < 0 Then
            Energy = 0
        End If
        Label1.Text = Energy.ToString()
    End Sub

    Private Sub Next_Round_Click(sender As Object, e As EventArgs) Handles Next_Round.Click
        Energy += 2
        Carts += 3
        Round += 1

        If Energy > 10 Then
            Energy = 10
        End If

        If Carts > 12 Then
            Carts = 12
        End If
        If Round > 20 Then
            Round = 20
        End If
        Label1.Text = Energy.ToString()
        Label2.Text = Carts.ToString()
        Label4.Text = Round.ToString()
    End Sub


    Private Sub Gana_Cartas_Click(sender As Object, e As EventArgs) Handles Gana_Cartas.Click
        Carts += 1
        If Carts > 12 Then
            Carts = 12
        End If
        Label2.Text = Carts.ToString()
    End Sub

    Private Sub Pierde_Cartas_Click(sender As Object, e As EventArgs) Handles Pierde_Cartas.Click
        Carts -= 1
        If Carts < 0 Then
            Carts = 0
        End If
        Label2.Text = Carts.ToString()
    End Sub

    Private Sub Reset_Click(sender As Object, e As EventArgs) Handles Reset.Click
        Energy = 3
        Carts = 6
        Round = 1
        Label1.Text = Energy.ToString()
        Label2.Text = Carts.ToString()
        Label4.Text = Round.ToString()
    End Sub

    Private Sub Button_Win_Click(sender As Object, e As EventArgs) Handles Button_Win.Click
        Win += 1
        'If ComboBox_varSLP.SelectedIndex > -1 Then
        'Dim index1%
        'index1 = ComboBox_varSLP.SelectedItem
        'VarSLP += index1.ToString()
        'End If
        If TextBox_SLP.Text = "" Then
            VarSLP += 0
        Else

            Dim index1%
            index1 = TextBox_SLP.Text
            VarSLP += index1.ToString()
        End If

        Label_Win.Text = Win.ToString()
        Label5.Text = VarSLP.ToString()
    End Sub

    Private Sub Button_Lose_Click(sender As Object, e As EventArgs) Handles Button_Lose.Click
        Lose += 1
        Label_Lose.Text = Lose.ToString()
    End Sub

    Private Sub Button_Draw_Click(sender As Object, e As EventArgs) Handles Button_Draw.Click
        Draw += 1
        If TextBox_SLP.Text = "" Then
            VarSLP += 0
        Else

            Dim index1%
            index1 = TextBox_SLP.Text
            VarSLP += index1.ToString()
        End If

        Label_Draw.Text = Draw.ToString()
        Label5.Text = VarSLP.ToString()
    End Sub

    Private Sub Button_Game_Click(sender As Object, e As EventArgs) Handles Button_Game.Click
        Win = 0
        Lose = 0
        Draw = 0
        VarSLP = 0
        Label_Win.Text = Win.ToString()
        Label_Lose.Text = Lose.ToString()
        Label_Draw.Text = Draw.ToString()
        Label5.Text = VarSLP.ToString()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button_next_page.Click
        If TextBox_SLP.Text = "" Then
            TextBox_SLP.Text = 0
        End If
        'no visible buttons
        Next_Round.Visible = False
        Gana_Energia.Visible = False
        Pierde_Energia.Visible = False
        Gana_Cartas.Visible = False
        Pierde_Cartas.Visible = False
        Reset.Visible = False
        Button_next_page.Visible = False
        '--------------------------------
        PictureBox_Energy.Visible = False
        PictureBox_Carts.Visible = False
        Label1.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        Label4.Visible = False

        'visible buttons
        Button_back_page.Visible = True
        Button_Win.Visible = True
        Button_Lose.Visible = True
        Button_Draw.Visible = True
        Button_Game.Visible = True
        Label_Win.Visible = True
        Label_Lose.Visible = True
        Label_Draw.Visible = True
        '--------------------------------
        PictureBox_SLP.Visible = True
        PictureBox_miniSLP.Visible = True
        'ComboBox_varSLP.Visible = True   'location 507;294
        TextBox_SLP.Visible = True
        Label5.Visible = True
        Label6.Visible = True
        Label7.Visible = True

        CheckBox_Record.Visible = True

        'Move items
        PictureBox_SLP.Left -= 300
        Label5.Left -= 300
        Label6.Left -= 300
        PictureBox_miniSLP.Left -= 325
        Label7.Left -= 325
        'ComboBox_varSLP.Left -= 325
        TextBox_SLP.Left -= 325

        Button_Win.Left -= 335
        Button_Lose.Left -= 335
        Button_Draw.Left -= 335
        Button_Game.Left -= 335
        Label_Win.Left -= 335
        Label_Lose.Left -= 335
        Label_Draw.Left -= 335

        CheckBox_Record.Left -= 335

        '-----------------------------





    End Sub

    Private Sub Button_back_page_Click(sender As Object, e As EventArgs) Handles Button_back_page.Click
        'visible buttons
        Next_Round.Visible = True
        Gana_Energia.Visible = True
        Pierde_Energia.Visible = True
        Gana_Cartas.Visible = True
        Pierde_Cartas.Visible = True
        Reset.Visible = True
        Button_next_page.Visible = True
        '--------------------------------
        PictureBox_Energy.Visible = True
        PictureBox_Carts.Visible = True
        Label1.Visible = True
        Label2.Visible = True
        Label3.Visible = True
        Label4.Visible = True

        ' no visible buttons
        Button_back_page.Visible = False
        Button_Win.Visible = False
        Button_Lose.Visible = False
        Button_Draw.Visible = False
        Button_Game.Visible = False
        Label_Win.Visible = False
        Label_Lose.Visible = False
        Label_Draw.Visible = False
        '--------------------------------
        PictureBox_SLP.Visible = False
        PictureBox_miniSLP.Visible = False
        'ComboBox_varSLP.Visible = False
        TextBox_SLP.Visible = False
        Label5.Visible = False
        Label6.Visible = False
        Label7.Visible = False

        CheckBox_Record.Visible = False


        'Move items
        PictureBox_SLP.Left += 300
        Label5.Left += 300
        Label6.Left += 300
        PictureBox_miniSLP.Left += 325
        Label7.Left += 325
        'ComboBox_varSLP.Left += 325
        TextBox_SLP.Left += 325

        Button_Win.Left += 335
        Button_Lose.Left += 335
        Button_Draw.Left += 335
        Button_Game.Left += 335
        Label_Win.Left += 335
        Label_Lose.Left += 335
        Label_Draw.Left += 335

        CheckBox_Record.Left += 335
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label5.Text = My.Settings.SLP
        Label_Win.Text = My.Settings.Win
        Label_Lose.Text = My.Settings.Lose
        Label_Draw.Text = My.Settings.Draw
        'Label5.Text = My.Settings.SLP 
        VarSLP = My.Settings.SLP
        Win = My.Settings.Win
        Lose = My.Settings.Lose
        Draw = My.Settings.Draw
        TextBox_SLP.Text = My.Settings.nSLP
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If CheckBox_Record.Checked = True Then
            My.Settings.SLP = Label5.Text
            My.Settings.Win = Label_Win.Text
            My.Settings.Lose = Label_Lose.Text
            My.Settings.Draw = Label_Draw.Text
            'My.Settings.SLP = Label5.Text
            My.Settings.nSLP = TextBox_SLP.Text
            My.Settings.Save()
            My.Settings.Reload()

        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Process.Start("https://github.com/DavidDeyko")
    End Sub
End Class
