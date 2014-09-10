﻿Public Class Form29
    Dim contagem As Double
    Dim particula As String
    Dim termino As String

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frase As String
        FileOpen(1, "frases_particula.jp", OpenMode.Input)
        Do Until contagem = 0
            Input(1, frase)
            Label1.Text = frase
            contagem = contagem - 1
        Loop
        FileClose(1)
    End Sub

    Private Sub Form29_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        formu29 = False
    End Sub

    Private Sub Form29_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        formu29 = True
        contagem = 1
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedItem = 1 Then
            contagem = ComboBox1.SelectedItem
        ElseIf ComboBox1.SelectedItem = 2 Then
            contagem = ComboBox1.SelectedItem + 2
        ElseIf ComboBox1.SelectedItem = 3 Then
            contagem = 7
        ElseIf ComboBox1.SelectedItem > 3 Then
            contagem = ComboBox1.SelectedItem * 3 - 2
        End If

        Button1.Enabled = True

        Dim frase As String
        FileOpen(1, "arquivos_jp\frases_particula.jp", OpenMode.Input)
        Do Until contagem = 0
            Input(1, frase)
            Label1.Text = frase
            contagem = contagem - 1
        Loop
        Input(1, termino)
        Input(1, particula)
        FileClose(1)
        Label1.Text = Label1.Text & vbCrLf & termino
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Label1.Text = "" Then
            MsgBox("Primeiro escolha alguma frase!", MsgBoxStyle.OkOnly, "JapaneseWay")
        Else
            If LCase(TextBox1.Text) = particula Then
                MsgBox("Parabéns! Sua resposta está correta.", MsgBoxStyle.OkOnly, "JapaneseWay")
                Label2.Text = Label2.Text + 1
                Label8.Text = Label8.Text + 1
                Button1.Enabled = False
            ElseIf TextBox1.Text = "" Then
                MsgBox("Primeiro escreva uma sílaba em escrita romanizada.", MsgBoxStyle.OkOnly, "JapaneseWay")
            Else
                MsgBox("Sua resposta está errada. Tente outra vez.", MsgBoxStyle.Critical, "JapaneseWay")
                Label3.Text = Label3.Text + 1
                Label8.Text = Label8.Text + 1
                Button1.Enabled = False
            End If
        End If
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If particula = "" Then
            MsgBox("Primeiro escolha uma frase!", MsgBoxStyle.OkOnly, "JapaneseWay")
        Else
            MsgBox("A partícula é: " & particula & ".", MsgBoxStyle.OkOnly, "JapaneseWay")
        End If
    End Sub

    Private Sub topmost_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Form10.Visible = True Then
            BringToFront()
        End If
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            Button1_Click(AcceptButton, AcceptButton)
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Form29_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

   
    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim rand As New Random()
        Dim number = rand.Next(0, 29)
        ComboBox1.SelectedIndex = number
    End Sub
End Class