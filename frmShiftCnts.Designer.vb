<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmShiftCnts
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
      Me.lblPhone = New System.Windows.Forms.Label()
      Me.lblLocatorTimeBracketTape = New System.Windows.Forms.Label()
      Me.Label1 = New System.Windows.Forms.Label()
      Me.Label3 = New System.Windows.Forms.Label()
      Me.Label5 = New System.Windows.Forms.Label()
      Me.Label6 = New System.Windows.Forms.Label()
      Me.Label7 = New System.Windows.Forms.Label()
      Me.Label4 = New System.Windows.Forms.Label()
      Me.updnLocBracketCntr = New System.Windows.Forms.NumericUpDown()
      Me.updnTapeLocCntr = New System.Windows.Forms.NumericUpDown()
      Me.updnBracketPrimeCntr = New System.Windows.Forms.NumericUpDown()
      Me.updnGlassLocCntr = New System.Windows.Forms.NumericUpDown()
      Me.updnHPrimerCntr = New System.Windows.Forms.NumericUpDown()
      Me.updnAMPrimerCntr = New System.Windows.Forms.NumericUpDown()
      Me.updnBrktScanCntr = New System.Windows.Forms.NumericUpDown()
      Me.Label2 = New System.Windows.Forms.Label()
      Me.updnTMCntr = New System.Windows.Forms.NumericUpDown()
      Me.GroupBox1 = New System.Windows.Forms.GroupBox()
      Me.GroupBox2 = New System.Windows.Forms.GroupBox()
      Me.updnVerifycntr = New System.Windows.Forms.NumericUpDown()
      Me.Label8 = New System.Windows.Forms.Label()
      Me.btnResetCntrs = New System.Windows.Forms.Button()
      CType(Me.updnLocBracketCntr, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.updnTapeLocCntr, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.updnBracketPrimeCntr, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.updnGlassLocCntr, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.updnHPrimerCntr, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.updnAMPrimerCntr, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.updnBrktScanCntr, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.updnTMCntr, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.GroupBox1.SuspendLayout()
      Me.GroupBox2.SuspendLayout()
      CType(Me.updnVerifycntr, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      '
      'lblPhone
      '
      Me.lblPhone.AutoSize = True
      Me.lblPhone.Font = New System.Drawing.Font("Arial Black", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblPhone.ForeColor = System.Drawing.Color.White
      Me.lblPhone.Location = New System.Drawing.Point(197, 16)
      Me.lblPhone.Name = "lblPhone"
      Me.lblPhone.Size = New System.Drawing.Size(309, 45)
      Me.lblPhone.TabIndex = 170
      Me.lblPhone.Text = "Failure Counters"
      '
      'lblLocatorTimeBracketTape
      '
      Me.lblLocatorTimeBracketTape.AutoSize = True
      Me.lblLocatorTimeBracketTape.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblLocatorTimeBracketTape.ForeColor = System.Drawing.Color.Yellow
      Me.lblLocatorTimeBracketTape.Location = New System.Drawing.Point(20, 33)
      Me.lblLocatorTimeBracketTape.Name = "lblLocatorTimeBracketTape"
      Me.lblLocatorTimeBracketTape.Size = New System.Drawing.Size(185, 23)
      Me.lblLocatorTimeBracketTape.TabIndex = 172
      Me.lblLocatorTimeBracketTape.Text = "Small Conv Locate :"
      Me.lblLocatorTimeBracketTape.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'Label1
      '
      Me.Label1.AutoSize = True
      Me.Label1.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label1.ForeColor = System.Drawing.Color.Yellow
      Me.Label1.Location = New System.Drawing.Point(69, 22)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(136, 23)
      Me.Label1.TabIndex = 173
      Me.Label1.Text = "Glass Locate :"
      '
      'Label3
      '
      Me.Label3.AutoSize = True
      Me.Label3.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label3.ForeColor = System.Drawing.Color.Yellow
      Me.Label3.Location = New System.Drawing.Point(74, 69)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(131, 23)
      Me.Label3.TabIndex = 175
      Me.Label3.Text = "Tape Locate :"
      Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'Label5
      '
      Me.Label5.AutoSize = True
      Me.Label5.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label5.ForeColor = System.Drawing.Color.Yellow
      Me.Label5.Location = New System.Drawing.Point(53, 103)
      Me.Label5.Name = "Label5"
      Me.Label5.Size = New System.Drawing.Size(152, 23)
      Me.Label5.TabIndex = 178
      Me.Label5.Text = "Bracket Primer :"
      Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'Label6
      '
      Me.Label6.AutoSize = True
      Me.Label6.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label6.ForeColor = System.Drawing.Color.Yellow
      Me.Label6.Location = New System.Drawing.Point(54, 91)
      Me.Label6.Name = "Label6"
      Me.Label6.Size = New System.Drawing.Size(150, 23)
      Me.Label6.TabIndex = 180
      Me.Label6.Text = "Glass H Primer :"
      '
      'Label7
      '
      Me.Label7.AutoSize = True
      Me.Label7.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label7.ForeColor = System.Drawing.Color.Yellow
      Me.Label7.Location = New System.Drawing.Point(26, 57)
      Me.Label7.Name = "Label7"
      Me.Label7.Size = New System.Drawing.Size(179, 23)
      Me.Label7.TabIndex = 182
      Me.Label7.Text = "Glass Aron Mighty :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
      Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'Label4
      '
      Me.Label4.AutoSize = True
      Me.Label4.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label4.ForeColor = System.Drawing.Color.Yellow
      Me.Label4.Location = New System.Drawing.Point(110, 137)
      Me.Label4.Name = "Label4"
      Me.Label4.Size = New System.Drawing.Size(95, 23)
      Me.Label4.TabIndex = 186
      Me.Label4.Text = "PU Scan :"
      Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'updnLocBracketCntr
      '
      Me.updnLocBracketCntr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.updnLocBracketCntr.Location = New System.Drawing.Point(202, 34)
      Me.updnLocBracketCntr.Maximum = New Decimal(New Integer() {1500, 0, 0, 0})
      Me.updnLocBracketCntr.Name = "updnLocBracketCntr"
      Me.updnLocBracketCntr.Size = New System.Drawing.Size(70, 22)
      Me.updnLocBracketCntr.TabIndex = 206
      Me.updnLocBracketCntr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
      Me.updnLocBracketCntr.Value = New Decimal(New Integer() {1, 0, 0, 0})
      '
      'updnTapeLocCntr
      '
      Me.updnTapeLocCntr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.updnTapeLocCntr.Location = New System.Drawing.Point(202, 71)
      Me.updnTapeLocCntr.Maximum = New Decimal(New Integer() {1500, 0, 0, 0})
      Me.updnTapeLocCntr.Name = "updnTapeLocCntr"
      Me.updnTapeLocCntr.Size = New System.Drawing.Size(70, 22)
      Me.updnTapeLocCntr.TabIndex = 207
      Me.updnTapeLocCntr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
      Me.updnTapeLocCntr.Value = New Decimal(New Integer() {1, 0, 0, 0})
      '
      'updnBracketPrimeCntr
      '
      Me.updnBracketPrimeCntr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.updnBracketPrimeCntr.Location = New System.Drawing.Point(202, 105)
      Me.updnBracketPrimeCntr.Maximum = New Decimal(New Integer() {1500, 0, 0, 0})
      Me.updnBracketPrimeCntr.Name = "updnBracketPrimeCntr"
      Me.updnBracketPrimeCntr.Size = New System.Drawing.Size(70, 22)
      Me.updnBracketPrimeCntr.TabIndex = 208
      Me.updnBracketPrimeCntr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
      Me.updnBracketPrimeCntr.Value = New Decimal(New Integer() {1, 0, 0, 0})
      '
      'updnGlassLocCntr
      '
      Me.updnGlassLocCntr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.updnGlassLocCntr.Location = New System.Drawing.Point(202, 24)
      Me.updnGlassLocCntr.Maximum = New Decimal(New Integer() {1500, 0, 0, 0})
      Me.updnGlassLocCntr.Name = "updnGlassLocCntr"
      Me.updnGlassLocCntr.Size = New System.Drawing.Size(70, 22)
      Me.updnGlassLocCntr.TabIndex = 209
      Me.updnGlassLocCntr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
      Me.updnGlassLocCntr.Value = New Decimal(New Integer() {1, 0, 0, 0})
      '
      'updnHPrimerCntr
      '
      Me.updnHPrimerCntr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.updnHPrimerCntr.Location = New System.Drawing.Point(201, 93)
      Me.updnHPrimerCntr.Maximum = New Decimal(New Integer() {1500, 0, 0, 0})
      Me.updnHPrimerCntr.Name = "updnHPrimerCntr"
      Me.updnHPrimerCntr.Size = New System.Drawing.Size(70, 22)
      Me.updnHPrimerCntr.TabIndex = 210
      Me.updnHPrimerCntr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
      Me.updnHPrimerCntr.Value = New Decimal(New Integer() {1, 0, 0, 0})
      '
      'updnAMPrimerCntr
      '
      Me.updnAMPrimerCntr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.updnAMPrimerCntr.Location = New System.Drawing.Point(202, 59)
      Me.updnAMPrimerCntr.Maximum = New Decimal(New Integer() {1500, 0, 0, 0})
      Me.updnAMPrimerCntr.Name = "updnAMPrimerCntr"
      Me.updnAMPrimerCntr.Size = New System.Drawing.Size(70, 22)
      Me.updnAMPrimerCntr.TabIndex = 211
      Me.updnAMPrimerCntr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
      Me.updnAMPrimerCntr.Value = New Decimal(New Integer() {1, 0, 0, 0})
      '
      'updnBrktScanCntr
      '
      Me.updnBrktScanCntr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.updnBrktScanCntr.Location = New System.Drawing.Point(202, 139)
      Me.updnBrktScanCntr.Maximum = New Decimal(New Integer() {1500, 0, 0, 0})
      Me.updnBrktScanCntr.Name = "updnBrktScanCntr"
      Me.updnBrktScanCntr.Size = New System.Drawing.Size(70, 22)
      Me.updnBrktScanCntr.TabIndex = 212
      Me.updnBrktScanCntr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
      Me.updnBrktScanCntr.Value = New Decimal(New Integer() {1, 0, 0, 0})
      '
      'Label2
      '
      Me.Label2.AutoSize = True
      Me.Label2.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label2.ForeColor = System.Drawing.Color.Yellow
      Me.Label2.Location = New System.Drawing.Point(88, 152)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(117, 23)
      Me.Label2.TabIndex = 213
      Me.Label2.Text = "Trademark :"
      Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'updnTMCntr
      '
      Me.updnTMCntr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.updnTMCntr.Location = New System.Drawing.Point(202, 154)
      Me.updnTMCntr.Maximum = New Decimal(New Integer() {1500, 0, 0, 0})
      Me.updnTMCntr.Name = "updnTMCntr"
      Me.updnTMCntr.Size = New System.Drawing.Size(70, 22)
      Me.updnTMCntr.TabIndex = 214
      Me.updnTMCntr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
      Me.updnTMCntr.Value = New Decimal(New Integer() {1, 0, 0, 0})
      '
      'GroupBox1
      '
      Me.GroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.None
      Me.GroupBox1.Controls.Add(Me.updnBracketPrimeCntr)
      Me.GroupBox1.Controls.Add(Me.lblLocatorTimeBracketTape)
      Me.GroupBox1.Controls.Add(Me.Label3)
      Me.GroupBox1.Controls.Add(Me.updnBrktScanCntr)
      Me.GroupBox1.Controls.Add(Me.Label5)
      Me.GroupBox1.Controls.Add(Me.updnLocBracketCntr)
      Me.GroupBox1.Controls.Add(Me.updnTapeLocCntr)
      Me.GroupBox1.Controls.Add(Me.Label4)
      Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Window
      Me.GroupBox1.Location = New System.Drawing.Point(39, 64)
      Me.GroupBox1.Name = "GroupBox1"
      Me.GroupBox1.Size = New System.Drawing.Size(292, 189)
      Me.GroupBox1.TabIndex = 215
      Me.GroupBox1.TabStop = False
      Me.GroupBox1.Text = "Bracket"
      '
      'GroupBox2
      '
      Me.GroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.None
      Me.GroupBox2.Controls.Add(Me.updnVerifycntr)
      Me.GroupBox2.Controls.Add(Me.updnTMCntr)
      Me.GroupBox2.Controls.Add(Me.Label8)
      Me.GroupBox2.Controls.Add(Me.Label1)
      Me.GroupBox2.Controls.Add(Me.Label6)
      Me.GroupBox2.Controls.Add(Me.updnHPrimerCntr)
      Me.GroupBox2.Controls.Add(Me.Label2)
      Me.GroupBox2.Controls.Add(Me.Label7)
      Me.GroupBox2.Controls.Add(Me.updnAMPrimerCntr)
      Me.GroupBox2.Controls.Add(Me.updnGlassLocCntr)
      Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.GroupBox2.ForeColor = System.Drawing.SystemColors.Window
      Me.GroupBox2.Location = New System.Drawing.Point(374, 64)
      Me.GroupBox2.Name = "GroupBox2"
      Me.GroupBox2.Size = New System.Drawing.Size(292, 189)
      Me.GroupBox2.TabIndex = 216
      Me.GroupBox2.TabStop = False
      Me.GroupBox2.Text = "Glass"
      '
      'updnVerifycntr
      '
      Me.updnVerifycntr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.updnVerifycntr.Location = New System.Drawing.Point(202, 124)
      Me.updnVerifycntr.Maximum = New Decimal(New Integer() {1500, 0, 0, 0})
      Me.updnVerifycntr.Name = "updnVerifycntr"
      Me.updnVerifycntr.Size = New System.Drawing.Size(70, 22)
      Me.updnVerifycntr.TabIndex = 216
      Me.updnVerifycntr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
      Me.updnVerifycntr.Value = New Decimal(New Integer() {1, 0, 0, 0})
      '
      'Label8
      '
      Me.Label8.AutoSize = True
      Me.Label8.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label8.ForeColor = System.Drawing.Color.Yellow
      Me.Label8.Location = New System.Drawing.Point(26, 123)
      Me.Label8.Name = "Label8"
      Me.Label8.Size = New System.Drawing.Size(170, 23)
      Me.Label8.TabIndex = 215
      Me.Label8.Text = "Verify Placement :"
      Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'btnResetCntrs
      '
      Me.btnResetCntrs.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnResetCntrs.Location = New System.Drawing.Point(299, 280)
      Me.btnResetCntrs.Name = "btnResetCntrs"
      Me.btnResetCntrs.Size = New System.Drawing.Size(118, 35)
      Me.btnResetCntrs.TabIndex = 263
      Me.btnResetCntrs.Text = "Clear Counts"
      Me.btnResetCntrs.UseVisualStyleBackColor = True
      '
      'frmShiftCnts
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.BackColor = System.Drawing.Color.MidnightBlue
      Me.ClientSize = New System.Drawing.Size(709, 334)
      Me.Controls.Add(Me.btnResetCntrs)
      Me.Controls.Add(Me.GroupBox2)
      Me.Controls.Add(Me.GroupBox1)
      Me.Controls.Add(Me.lblPhone)
      Me.Name = "frmShiftCnts"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Shift Counters"
      CType(Me.updnLocBracketCntr, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.updnTapeLocCntr, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.updnBracketPrimeCntr, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.updnGlassLocCntr, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.updnHPrimerCntr, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.updnAMPrimerCntr, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.updnBrktScanCntr, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.updnTMCntr, System.ComponentModel.ISupportInitialize).EndInit()
      Me.GroupBox1.ResumeLayout(False)
      Me.GroupBox1.PerformLayout()
      Me.GroupBox2.ResumeLayout(False)
      Me.GroupBox2.PerformLayout()
      CType(Me.updnVerifycntr, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub

   Friend WithEvents lblPhone As Label
   Friend WithEvents lblLocatorTimeBracketTape As Label
   Friend WithEvents Label1 As Label
   Friend WithEvents Label3 As Label
   Friend WithEvents Label5 As Label
   Friend WithEvents Label6 As Label
   Friend WithEvents Label7 As Label
   Friend WithEvents Label4 As Label
   Friend WithEvents updnLocBracketCntr As NumericUpDown
   Friend WithEvents updnTapeLocCntr As NumericUpDown
   Friend WithEvents updnBracketPrimeCntr As NumericUpDown
   Friend WithEvents updnGlassLocCntr As NumericUpDown
   Friend WithEvents updnHPrimerCntr As NumericUpDown
   Friend WithEvents updnAMPrimerCntr As NumericUpDown
   Friend WithEvents updnBrktScanCntr As NumericUpDown
   Friend WithEvents Label2 As Label
   Friend WithEvents updnTMCntr As NumericUpDown
   Friend WithEvents GroupBox1 As GroupBox
   Friend WithEvents GroupBox2 As GroupBox
   Friend WithEvents btnResetCntrs As Button
   Friend WithEvents updnVerifycntr As NumericUpDown
   Friend WithEvents Label8 As Label
End Class
