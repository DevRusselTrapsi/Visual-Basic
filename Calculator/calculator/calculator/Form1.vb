Public Class Form1
    Dim num1 As Decimal
    Dim num2 As Decimal
    Dim op As Boolean = False
    Dim operators As Integer


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        num1 = TextBox1.Text
        TextBox1.Text = "0"
        op = True
        operators = 1 ' add
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles btn_one.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "1"
        Else
            TextBox1.Text = "1"
        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles btn_two.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "2"
        Else
            TextBox1.Text = "2"
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles btn_three.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "3"
        Else
            TextBox1.Text = "3"
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles btn_four.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "4"
        Else
            TextBox1.Text = "4"
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles btn_five.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "5"
        Else
            TextBox1.Text = "5"
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btn_six.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "6"
        Else
            TextBox1.Text = "6"
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btn_seven.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "7"
        Else
            TextBox1.Text = "7"
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btn_eight.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "8"
        Else
            TextBox1.Text = "8"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_nine.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "9"
        Else
            TextBox1.Text = "9"
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btn_doublezero.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "00"

        End If
    End Sub

    Private Sub btn_sqroot_Click(sender As Object, e As EventArgs) Handles btn_sqroot.Click
        TextBox1.Text = num1
        op = True
        operators = 6
    End Sub

    Private Sub btn_pow_Click(sender As Object, e As EventArgs) Handles btn_pow.Click
        num1 = TextBox1.Text
        op = True
        operators = 5
    End Sub

    Private Sub btn_basepow_Click(sender As Object, e As EventArgs) Handles btn_percent.Click
        num1 = TextBox1.Text

        TextBox1.Text = num1 / 100
    End Sub

    Private Sub clear_Click(sender As Object, e As EventArgs) Handles clear.Click
        TextBox1.Clear()
    End Sub

    Private Sub btn_equal_Click(sender As Object, e As EventArgs) Handles btn_equal.Click
        If op = True Then
            If operators = 5 Then

                TextBox1.Text = num1 * num1

            ElseIf operators = 6 Then

                TextBox1.Text = num1 / 2

            End If
            num2 = TextBox1.Text
            If operators = 1 Then

                TextBox1.Text = num1 + num2

            ElseIf operators = 2 Then

                TextBox1.Text = num1 - num2

            ElseIf operators = 3 Then

                TextBox1.Text = num1 * num2

            ElseIf operators = 4 Then

                If num2 = 0 Then

                    TextBox1.Text = "ERROR!"

                Else

                    TextBox1.Text = num1 / num2

                End If
            End If

            operators = False

        End If
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles btn_zero.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "0"

        End If
    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text <> "." Then
            TextBox1.Text += "."
        End If
    End Sub

    Private Sub btn_subtract_Click(sender As Object, e As EventArgs) Handles btn_subtract.Click
        num1 = TextBox1.Text
        TextBox1.Text = "0"
        op = True
        operators = 2 ' sub
    End Sub

    Private Sub btn_multi_Click(sender As Object, e As EventArgs) Handles btn_multi.Click
        num1 = TextBox1.Text
        TextBox1.Text = "0"
        operators = True
        op = 3 ' mult
    End Sub

    Private Sub btn_divide_Click(sender As Object, e As EventArgs) Handles btn_divide.Click
        num1 = TextBox1.Text
        TextBox1.Text = "0"
        op = True
        operators = 4 ' div
    End Sub
End Class
