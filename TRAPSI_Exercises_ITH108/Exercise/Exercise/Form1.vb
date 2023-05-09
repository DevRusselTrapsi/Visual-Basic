Public Class Form1
    Dim a As Integer
    Dim b As Integer
    Dim c As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_triangle.Click

        a = Val(txtbox_triangleheight.Text)
        b = Val(txtbox_trianglebase.Text)

        If a = False And b = False Then
            MsgBox("The Text field is  Empty")

        ElseIf txtbox_trianglebase.Text < 0 Then
            MsgBox(vbTab & "ERROR:" & vbCrLf & vbCrLf & "Invalid Negative Value!!")

        ElseIf txtbox_trianglebase.Text < 0 Then
            MsgBox(vbTab & "ERROR:" & vbCrLf & vbCrLf & "Invalid Negative Value!!")

        ElseIf txtbox_trianglebase.Text < 0 And txtbox_triangleheight.Text < 0 Then
            MsgBox(vbTab & "ERROR:" & vbCrLf & vbCrLf & "Invalid Negative Value!!")
        Else
                c = 0.5 * a * b
                MsgBox("The Area of the Triangle is " & c)
            End If


    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtbox_trianglebase.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtbox_triangleheight.TextChanged

    End Sub

    Private Sub Btn_circle_Click(sender As Object, e As EventArgs) Handles btn_circle.Click

        a = Val(txtbox_circleradius.Text)


        If a = False Then
            MsgBox("The Text field is Empty")
        ElseIf txtbox_circleradius.Text < 0 Then
            MsgBox(vbTab & "ERROR:" & vbCrLf & vbCrLf & "Invalid Negative Value!!")
        Else
                b = a * a
                c = 3.14 * b
                MsgBox("The Area of the Circle is " & c)
            End If





    End Sub

    Private Sub Btn_rectangle_Click(sender As Object, e As EventArgs) Handles btn_rectangle.Click

        a = Val(txtbox_rectlength.Text)
        b = Val(txtbox_rectwidth.Text)

        If (a = False) And (b = False) Then
            MsgBox("The Text field is Empty")
        ElseIf txtbox_rectlength.Text < 0 Then
            MsgBox(vbTab & "ERROR:" & vbCrLf & vbCrLf & "Invalid Negative Value!!")

        ElseIf txtbox_rectwidth.Text < 0 Then
            MsgBox(vbTab & "ERROR:" & vbCrLf & vbCrLf & "Invalid Negative Value!!")

        ElseIf txtbox_rectwidth.Text < 0 And txtbox_rectlength.Text < 0 Then
            MsgBox(vbTab & "ERROR:" & vbCrLf & vbCrLf & "Invalid Negative Value!!")
        Else
            c = a * b
                MsgBox("The Area of the Rectangle is " & c)
            End If


    End Sub

    Private Sub Btn_square_Click(sender As Object, e As EventArgs) Handles btn_square.Click

        a = Val(txtbox_squarelenght.Text)

        If a = False Then
            MsgBox("The Text field is Empty!!")

        ElseIf txtbox_squarelenght.Text < 0 Then
            MsgBox(vbTab & "ERROR:" & vbCrLf & vbCrLf & "Invalid Negative Value!!")
        Else
            c = a * a
            MsgBox("The Area of the Triangle is " & c)
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        txtbox_squarelenght.Clear()
        txtbox_rectwidth.Clear()
        txtbox_rectlength.Clear()
        txtbox_trianglebase.Clear()
        txtbox_triangleheight.Clear()
        txtbox_circleradius.Clear()
    End Sub
End Class
