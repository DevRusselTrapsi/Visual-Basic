Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Txtbox_Tbase_TextChanged(sender As Object, e As EventArgs) Handles txtbox_Tbase.TextChanged

    End Sub

    Private Sub Txtbox_Theight_TextChanged(sender As Object, e As EventArgs) Handles txtbox_Theight.TextChanged

    End Sub

    Private Sub Btn_AOT_Click(sender As Object, e As EventArgs) Handles btn_AOT.Click

        'triangle
        Dim res, c As Double
        c = txtbox_Tbase.Text * 0.5

        res = c * txtbox_Theight.Text
        MessageBox.Show("The Area of the Triangle is " & res)


    End Sub

    Private Sub Txtbox_Cradius_TextChanged(sender As Object, e As EventArgs) Handles txtbox_Cradius.TextChanged




    End Sub

    Private Sub Btn_AOC_Click(sender As Object, e As EventArgs) Handles btn_AOC.Click
        'circle

        Dim res, c As Integer

        c = txtbox_Cradius.Text
        res = (c * c) * 3.14

        MessageBox.Show("The Area of the Circle is " & res)



    End Sub

    Private Sub Btn_AOS_Click(sender As Object, e As EventArgs) Handles btn_AOS.Click

        'square
        Dim res, c As Double

        c = txtbox_Slenght.Text
        res = c * c

        MessageBox.Show("The Area of the Square is " & res)
    End Sub

    Private Sub Btn_AOR_Click(sender As Object, e As EventArgs) Handles btn_AOR.Click
        'Rectangle

        Dim res As Double

        res = txtbox_Rlenght.Text * txtbox_Rwidth.Text

        MessageBox.Show("The Area of the Rectangle is " & res)

    End Sub

    Private Sub Txtbox_Rradius_TextChanged(sender As Object, e As EventArgs) Handles txtbox_Rlenght.TextChanged

    End Sub

    Private Sub Btn_clear_all_Click(sender As Object, e As EventArgs) Handles btn_clear_all.Click
        'Rectangle
        txtbox_Rwidth.Clear()
        txtbox_Rlenght.Clear()
        'circle
        txtbox_Cradius.Clear()
        'triangle
        txtbox_Tbase.Clear()
        txtbox_Theight.Clear()
        'square
        txtbox_Slenght.Clear()

    End Sub
End Class
