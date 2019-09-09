<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCalculateAngle
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
		Me.btnCalculate = New System.Windows.Forms.Button()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.txtAngle2 = New System.Windows.Forms.TextBox()
		Me.lblangel2 = New System.Windows.Forms.Label()
		Me.txtAngle3 = New System.Windows.Forms.TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.txtSide2 = New System.Windows.Forms.TextBox()
		Me.txtSide3 = New System.Windows.Forms.TextBox()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.txtSide1 = New System.Windows.Forms.TextBox()
		Me.lblDistance = New System.Windows.Forms.Label()
		Me.lblDistanceRight = New System.Windows.Forms.Label()
		Me.lblDistanceRightValue = New System.Windows.Forms.Label()
		Me.lblDistanceBottomValue = New System.Windows.Forms.Label()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'btnCalculate
		'
		Me.btnCalculate.Location = New System.Drawing.Point(350, 385)
		Me.btnCalculate.Name = "btnCalculate"
		Me.btnCalculate.Size = New System.Drawing.Size(81, 25)
		Me.btnCalculate.TabIndex = 0
		Me.btnCalculate.Text = "Calculate"
		Me.btnCalculate.UseVisualStyleBackColor = True
		'
		'PictureBox1
		'
		Me.PictureBox1.Image = Global.RobotSquare.My.Resources.Resources.tri
		Me.PictureBox1.Location = New System.Drawing.Point(27, 14)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(403, 361)
		Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.PictureBox1.TabIndex = 1
		Me.PictureBox1.TabStop = False
		'
		'txtAngle2
		'
		Me.txtAngle2.Location = New System.Drawing.Point(61, 84)
		Me.txtAngle2.Name = "txtAngle2"
		Me.txtAngle2.Size = New System.Drawing.Size(50, 20)
		Me.txtAngle2.TabIndex = 2
		'
		'lblangel2
		'
		Me.lblangel2.AutoSize = True
		Me.lblangel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblangel2.ForeColor = System.Drawing.Color.Red
		Me.lblangel2.Location = New System.Drawing.Point(61, 68)
		Me.lblangel2.Name = "lblangel2"
		Me.lblangel2.Size = New System.Drawing.Size(50, 13)
		Me.lblangel2.TabIndex = 3
		Me.lblangel2.Text = "Angle 2"
		'
		'txtAngle3
		'
		Me.txtAngle3.Location = New System.Drawing.Point(342, 319)
		Me.txtAngle3.Name = "txtAngle3"
		Me.txtAngle3.Size = New System.Drawing.Size(55, 20)
		Me.txtAngle3.TabIndex = 4
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.Color.Red
		Me.Label1.Location = New System.Drawing.Point(339, 303)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(50, 13)
		Me.Label1.TabIndex = 5
		Me.Label1.Text = "Angle 3"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.ForeColor = System.Drawing.Color.Red
		Me.Label2.Location = New System.Drawing.Point(254, 149)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(43, 13)
		Me.Label2.TabIndex = 6
		Me.Label2.Text = "Side 2"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.ForeColor = System.Drawing.Color.Red
		Me.Label3.Location = New System.Drawing.Point(72, 319)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(21, 13)
		Me.Label3.TabIndex = 7
		Me.Label3.Text = "90"
		'
		'txtSide2
		'
		Me.txtSide2.Location = New System.Drawing.Point(242, 165)
		Me.txtSide2.Name = "txtSide2"
		Me.txtSide2.Size = New System.Drawing.Size(55, 20)
		Me.txtSide2.TabIndex = 8
		'
		'txtSide3
		'
		Me.txtSide3.Location = New System.Drawing.Point(211, 335)
		Me.txtSide3.Name = "txtSide3"
		Me.txtSide3.Size = New System.Drawing.Size(49, 20)
		Me.txtSide3.TabIndex = 9
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.ForeColor = System.Drawing.Color.Red
		Me.Label4.Location = New System.Drawing.Point(208, 319)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(43, 13)
		Me.Label4.TabIndex = 10
		Me.Label4.Text = "Side 3"
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.ForeColor = System.Drawing.Color.Red
		Me.Label5.Location = New System.Drawing.Point(61, 189)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(43, 13)
		Me.Label5.TabIndex = 11
		Me.Label5.Text = "Side 1"
		'
		'txtSide1
		'
		Me.txtSide1.Location = New System.Drawing.Point(61, 205)
		Me.txtSide1.Name = "txtSide1"
		Me.txtSide1.Size = New System.Drawing.Size(50, 20)
		Me.txtSide1.TabIndex = 12
		'
		'lblDistance
		'
		Me.lblDistance.AutoSize = True
		Me.lblDistance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDistance.Location = New System.Drawing.Point(190, 30)
		Me.lblDistance.Name = "lblDistance"
		Me.lblDistance.Size = New System.Drawing.Size(125, 16)
		Me.lblDistance.TabIndex = 13
		Me.lblDistance.Text = "Distance Bottom:"
		'
		'lblDistanceRight
		'
		Me.lblDistanceRight.AutoSize = True
		Me.lblDistanceRight.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDistanceRight.Location = New System.Drawing.Point(202, 65)
		Me.lblDistanceRight.Name = "lblDistanceRight"
		Me.lblDistanceRight.Size = New System.Drawing.Size(113, 16)
		Me.lblDistanceRight.TabIndex = 14
		Me.lblDistanceRight.Text = "Distance Right:"
		'
		'lblDistanceRightValue
		'
		Me.lblDistanceRightValue.AutoSize = True
		Me.lblDistanceRightValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
		Me.lblDistanceRightValue.Location = New System.Drawing.Point(315, 65)
		Me.lblDistanceRightValue.Name = "lblDistanceRightValue"
		Me.lblDistanceRightValue.Size = New System.Drawing.Size(62, 16)
		Me.lblDistanceRightValue.TabIndex = 15
		Me.lblDistanceRightValue.Text = "XXXXXX"
		'
		'lblDistanceBottomValue
		'
		Me.lblDistanceBottomValue.AutoSize = True
		Me.lblDistanceBottomValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
		Me.lblDistanceBottomValue.Location = New System.Drawing.Point(315, 30)
		Me.lblDistanceBottomValue.Name = "lblDistanceBottomValue"
		Me.lblDistanceBottomValue.Size = New System.Drawing.Size(62, 16)
		Me.lblDistanceBottomValue.TabIndex = 16
		Me.lblDistanceBottomValue.Text = "XXXXXX"
		'
		'frmCalculateAngle
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.White
		Me.ClientSize = New System.Drawing.Size(468, 433)
		Me.Controls.Add(Me.lblDistanceBottomValue)
		Me.Controls.Add(Me.lblDistanceRightValue)
		Me.Controls.Add(Me.lblDistanceRight)
		Me.Controls.Add(Me.lblDistance)
		Me.Controls.Add(Me.txtSide1)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.txtSide3)
		Me.Controls.Add(Me.txtSide2)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.txtAngle3)
		Me.Controls.Add(Me.lblangel2)
		Me.Controls.Add(Me.txtAngle2)
		Me.Controls.Add(Me.PictureBox1)
		Me.Controls.Add(Me.btnCalculate)
		Me.Name = "frmCalculateAngle"
		Me.Text = "Calculate Angle"
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

    Friend WithEvents btnCalculate As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtAngle2 As TextBox
    Friend WithEvents lblangel2 As Label
    Friend WithEvents txtAngle3 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtSide2 As TextBox
    Friend WithEvents txtSide3 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtSide1 As TextBox
    Friend WithEvents lblDistance As Label
    Friend WithEvents lblDistanceRight As Label
    Friend WithEvents lblDistanceRightValue As Label
    Friend WithEvents lblDistanceBottomValue As Label
End Class
