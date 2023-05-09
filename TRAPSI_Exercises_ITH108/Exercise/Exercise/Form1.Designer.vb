<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_triangle = New System.Windows.Forms.Button()
        Me.btn_circle = New System.Windows.Forms.Button()
        Me.btn_rectangle = New System.Windows.Forms.Button()
        Me.btn_square = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.txtbox_trianglebase = New System.Windows.Forms.TextBox()
        Me.txtbox_triangleheight = New System.Windows.Forms.TextBox()
        Me.txtbox_rectlength = New System.Windows.Forms.TextBox()
        Me.txtbox_rectwidth = New System.Windows.Forms.TextBox()
        Me.txtbox_circleradius = New System.Windows.Forms.TextBox()
        Me.txtbox_squarelenght = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(84, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(206, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Area of Triangle"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(779, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(178, 32)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Area of Circle"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(84, 280)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(222, 32)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Area of Rectangle"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 14.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(756, 305)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(190, 32)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Area of Square"
        '
        'btn_triangle
        '
        Me.btn_triangle.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn_triangle.FlatAppearance.BorderSize = 2
        Me.btn_triangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_triangle.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_triangle.Location = New System.Drawing.Point(184, 216)
        Me.btn_triangle.Name = "btn_triangle"
        Me.btn_triangle.Size = New System.Drawing.Size(137, 46)
        Me.btn_triangle.TabIndex = 5
        Me.btn_triangle.Text = "Compute"
        Me.btn_triangle.UseVisualStyleBackColor = True
        '
        'btn_circle
        '
        Me.btn_circle.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn_circle.FlatAppearance.BorderSize = 2
        Me.btn_circle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_circle.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_circle.Location = New System.Drawing.Point(760, 152)
        Me.btn_circle.Name = "btn_circle"
        Me.btn_circle.Size = New System.Drawing.Size(130, 50)
        Me.btn_circle.TabIndex = 6
        Me.btn_circle.Text = "Compute"
        Me.btn_circle.UseVisualStyleBackColor = True
        '
        'btn_rectangle
        '
        Me.btn_rectangle.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn_rectangle.FlatAppearance.BorderSize = 2
        Me.btn_rectangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_rectangle.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_rectangle.Location = New System.Drawing.Point(184, 466)
        Me.btn_rectangle.Name = "btn_rectangle"
        Me.btn_rectangle.Size = New System.Drawing.Size(137, 49)
        Me.btn_rectangle.TabIndex = 7
        Me.btn_rectangle.Text = "Compute"
        Me.btn_rectangle.UseVisualStyleBackColor = True
        '
        'btn_square
        '
        Me.btn_square.FlatAppearance.BorderSize = 2
        Me.btn_square.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_square.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_square.Location = New System.Drawing.Point(760, 430)
        Me.btn_square.Name = "btn_square"
        Me.btn_square.Size = New System.Drawing.Size(130, 47)
        Me.btn_square.TabIndex = 8
        Me.btn_square.Text = "Compute"
        Me.btn_square.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button5.FlatAppearance.BorderSize = 2
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Times New Roman", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(454, 12)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(179, 54)
        Me.Button5.TabIndex = 9
        Me.Button5.Text = "CLEAR ALL"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'txtbox_trianglebase
        '
        Me.txtbox_trianglebase.Location = New System.Drawing.Point(184, 98)
        Me.txtbox_trianglebase.Multiline = True
        Me.txtbox_trianglebase.Name = "txtbox_trianglebase"
        Me.txtbox_trianglebase.Size = New System.Drawing.Size(222, 36)
        Me.txtbox_trianglebase.TabIndex = 10
        '
        'txtbox_triangleheight
        '
        Me.txtbox_triangleheight.Location = New System.Drawing.Point(184, 155)
        Me.txtbox_triangleheight.Multiline = True
        Me.txtbox_triangleheight.Name = "txtbox_triangleheight"
        Me.txtbox_triangleheight.Size = New System.Drawing.Size(222, 36)
        Me.txtbox_triangleheight.TabIndex = 11
        '
        'txtbox_rectlength
        '
        Me.txtbox_rectlength.Location = New System.Drawing.Point(184, 340)
        Me.txtbox_rectlength.Multiline = True
        Me.txtbox_rectlength.Name = "txtbox_rectlength"
        Me.txtbox_rectlength.Size = New System.Drawing.Size(222, 36)
        Me.txtbox_rectlength.TabIndex = 12
        '
        'txtbox_rectwidth
        '
        Me.txtbox_rectwidth.Location = New System.Drawing.Point(184, 406)
        Me.txtbox_rectwidth.Multiline = True
        Me.txtbox_rectwidth.Name = "txtbox_rectwidth"
        Me.txtbox_rectwidth.Size = New System.Drawing.Size(222, 36)
        Me.txtbox_rectwidth.TabIndex = 13
        '
        'txtbox_circleradius
        '
        Me.txtbox_circleradius.Location = New System.Drawing.Point(760, 98)
        Me.txtbox_circleradius.Multiline = True
        Me.txtbox_circleradius.Name = "txtbox_circleradius"
        Me.txtbox_circleradius.Size = New System.Drawing.Size(222, 36)
        Me.txtbox_circleradius.TabIndex = 14
        '
        'txtbox_squarelenght
        '
        Me.txtbox_squarelenght.Location = New System.Drawing.Point(760, 369)
        Me.txtbox_squarelenght.Multiline = True
        Me.txtbox_squarelenght.Name = "txtbox_squarelenght"
        Me.txtbox_squarelenght.Size = New System.Drawing.Size(222, 36)
        Me.txtbox_squarelenght.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(50, 105)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 19)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "BASE"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(43, 165)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 19)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "HEIGHT"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(84, 347)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 19)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "LENGHT"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(84, 413)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 19)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "WIDTH"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(659, 107)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 19)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "RADIUS"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(656, 377)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 19)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "LENGHT"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1055, 561)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtbox_squarelenght)
        Me.Controls.Add(Me.txtbox_circleradius)
        Me.Controls.Add(Me.txtbox_rectwidth)
        Me.Controls.Add(Me.txtbox_rectlength)
        Me.Controls.Add(Me.txtbox_triangleheight)
        Me.Controls.Add(Me.txtbox_trianglebase)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.btn_square)
        Me.Controls.Add(Me.btn_rectangle)
        Me.Controls.Add(Me.btn_circle)
        Me.Controls.Add(Me.btn_triangle)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_triangle As Button
    Friend WithEvents btn_circle As Button
    Friend WithEvents btn_rectangle As Button
    Friend WithEvents btn_square As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents txtbox_trianglebase As TextBox
    Friend WithEvents txtbox_triangleheight As TextBox
    Friend WithEvents txtbox_rectlength As TextBox
    Friend WithEvents txtbox_rectwidth As TextBox
    Friend WithEvents txtbox_circleradius As TextBox
    Friend WithEvents txtbox_squarelenght As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
End Class
