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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn_AOC = New System.Windows.Forms.Button()
        Me.btn_AOS = New System.Windows.Forms.Button()
        Me.btn_AOR = New System.Windows.Forms.Button()
        Me.btn_clear_all = New System.Windows.Forms.Button()
        Me.txtbox_Tbase = New System.Windows.Forms.TextBox()
        Me.txtbox_Theight = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtbox_Cradius = New System.Windows.Forms.TextBox()
        Me.txtbox_Rlenght = New System.Windows.Forms.TextBox()
        Me.txtbox_Slenght = New System.Windows.Forms.TextBox()
        Me.txtbox_Rwidth = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btn_AOT = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(53, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(301, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mathematical Area"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(93, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(167, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Area of Triangle"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(636, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Area of Circle"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(93, 371)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(158, 25)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Area of Square"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(636, 371)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(184, 25)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Area of Rectangle"
        '
        'btn_AOC
        '
        Me.btn_AOC.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_AOC.Location = New System.Drawing.Point(805, 263)
        Me.btn_AOC.Name = "btn_AOC"
        Me.btn_AOC.Padding = New System.Windows.Forms.Padding(2)
        Me.btn_AOC.Size = New System.Drawing.Size(91, 36)
        Me.btn_AOC.TabIndex = 6
        Me.btn_AOC.Text = "Compute"
        Me.btn_AOC.UseVisualStyleBackColor = False
        '
        'btn_AOS
        '
        Me.btn_AOS.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_AOS.Location = New System.Drawing.Point(344, 492)
        Me.btn_AOS.Name = "btn_AOS"
        Me.btn_AOS.Padding = New System.Windows.Forms.Padding(2)
        Me.btn_AOS.Size = New System.Drawing.Size(91, 36)
        Me.btn_AOS.TabIndex = 7
        Me.btn_AOS.Text = "Compute"
        Me.btn_AOS.UseVisualStyleBackColor = False
        '
        'btn_AOR
        '
        Me.btn_AOR.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_AOR.Location = New System.Drawing.Point(800, 538)
        Me.btn_AOR.Name = "btn_AOR"
        Me.btn_AOR.Size = New System.Drawing.Size(91, 36)
        Me.btn_AOR.TabIndex = 8
        Me.btn_AOR.Text = "Compute"
        Me.btn_AOR.UseVisualStyleBackColor = False
        '
        'btn_clear_all
        '
        Me.btn_clear_all.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_clear_all.Location = New System.Drawing.Point(800, 34)
        Me.btn_clear_all.Name = "btn_clear_all"
        Me.btn_clear_all.Size = New System.Drawing.Size(163, 45)
        Me.btn_clear_all.TabIndex = 9
        Me.btn_clear_all.Text = "CLEAR ALL"
        Me.btn_clear_all.UseVisualStyleBackColor = False
        '
        'txtbox_Tbase
        '
        Me.txtbox_Tbase.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbox_Tbase.Location = New System.Drawing.Point(180, 165)
        Me.txtbox_Tbase.Multiline = True
        Me.txtbox_Tbase.Name = "txtbox_Tbase"
        Me.txtbox_Tbase.Size = New System.Drawing.Size(255, 37)
        Me.txtbox_Tbase.TabIndex = 10
        '
        'txtbox_Theight
        '
        Me.txtbox_Theight.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbox_Theight.Location = New System.Drawing.Point(180, 225)
        Me.txtbox_Theight.Multiline = True
        Me.txtbox_Theight.Name = "txtbox_Theight"
        Me.txtbox_Theight.Size = New System.Drawing.Size(255, 37)
        Me.txtbox_Theight.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(94, 172)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 20)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Base:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(94, 232)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 20)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Height:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(560, 188)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 20)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Radius:"
        '
        'txtbox_Cradius
        '
        Me.txtbox_Cradius.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbox_Cradius.Location = New System.Drawing.Point(641, 181)
        Me.txtbox_Cradius.Multiline = True
        Me.txtbox_Cradius.Name = "txtbox_Cradius"
        Me.txtbox_Cradius.Size = New System.Drawing.Size(255, 37)
        Me.txtbox_Cradius.TabIndex = 15
        '
        'txtbox_Rlenght
        '
        Me.txtbox_Rlenght.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbox_Rlenght.Location = New System.Drawing.Point(641, 415)
        Me.txtbox_Rlenght.Multiline = True
        Me.txtbox_Rlenght.Name = "txtbox_Rlenght"
        Me.txtbox_Rlenght.Size = New System.Drawing.Size(255, 37)
        Me.txtbox_Rlenght.TabIndex = 16
        '
        'txtbox_Slenght
        '
        Me.txtbox_Slenght.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbox_Slenght.Location = New System.Drawing.Point(180, 432)
        Me.txtbox_Slenght.Multiline = True
        Me.txtbox_Slenght.Name = "txtbox_Slenght"
        Me.txtbox_Slenght.Size = New System.Drawing.Size(255, 37)
        Me.txtbox_Slenght.TabIndex = 17
        '
        'txtbox_Rwidth
        '
        Me.txtbox_Rwidth.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbox_Rwidth.Location = New System.Drawing.Point(641, 475)
        Me.txtbox_Rwidth.Multiline = True
        Me.txtbox_Rwidth.Name = "txtbox_Rwidth"
        Me.txtbox_Rwidth.Size = New System.Drawing.Size(255, 37)
        Me.txtbox_Rwidth.TabIndex = 18
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(81, 439)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 20)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Lenght:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(560, 492)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(54, 20)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Width:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(560, 422)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(63, 20)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Length:"
        '
        'btn_AOT
        '
        Me.btn_AOT.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_AOT.Location = New System.Drawing.Point(344, 292)
        Me.btn_AOT.Name = "btn_AOT"
        Me.btn_AOT.Padding = New System.Windows.Forms.Padding(2)
        Me.btn_AOT.Size = New System.Drawing.Size(91, 36)
        Me.btn_AOT.TabIndex = 5
        Me.btn_AOT.Text = "Compute"
        Me.btn_AOT.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1022, 635)
        Me.Controls.Add(Me.btn_AOT)
        Me.Controls.Add(Me.btn_AOR)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtbox_Rwidth)
        Me.Controls.Add(Me.txtbox_Slenght)
        Me.Controls.Add(Me.txtbox_Rlenght)
        Me.Controls.Add(Me.txtbox_Cradius)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtbox_Theight)
        Me.Controls.Add(Me.txtbox_Tbase)
        Me.Controls.Add(Me.btn_clear_all)
        Me.Controls.Add(Me.btn_AOS)
        Me.Controls.Add(Me.btn_AOC)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btn_AOC As Button
    Friend WithEvents btn_AOS As Button
    Friend WithEvents btn_AOR As Button
    Friend WithEvents btn_clear_all As Button
    Friend WithEvents txtbox_Tbase As TextBox
    Friend WithEvents txtbox_Theight As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtbox_Cradius As TextBox
    Friend WithEvents txtbox_Rlenght As TextBox
    Friend WithEvents txtbox_Slenght As TextBox
    Friend WithEvents txtbox_Rwidth As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents btn_AOT As Button
End Class
