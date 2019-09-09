<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPartSettings
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lstBracket = New System.Windows.Forms.ListBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkPrimer = New System.Windows.Forms.CheckBox()
        Me.chkBracket = New System.Windows.Forms.CheckBox()
        Me.txtBracketID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnRemoveItem = New System.Windows.Forms.Button()
        Me.txtPartSettingsCurrentBracketType = New System.Windows.Forms.TextBox()
        Me.btnAddNewBracket = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.lstBracket)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.btnSave)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnRemoveItem)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(368, 376)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'lstBracket
        '
        Me.lstBracket.Font = New System.Drawing.Font("Arial", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstBracket.FormattingEnabled = True
        Me.lstBracket.ItemHeight = 16
        Me.lstBracket.Location = New System.Drawing.Point(7, 35)
        Me.lstBracket.Name = "lstBracket"
        Me.lstBracket.Size = New System.Drawing.Size(356, 116)
        Me.lstBracket.TabIndex = 10
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkPrimer)
        Me.GroupBox2.Controls.Add(Me.chkBracket)
        Me.GroupBox2.Location = New System.Drawing.Point(197, 198)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(161, 172)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Parts Present"
        '
        'chkPrimer
        '
        Me.chkPrimer.AutoSize = True
        Me.chkPrimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.chkPrimer.Location = New System.Drawing.Point(19, 66)
        Me.chkPrimer.Name = "chkPrimer"
        Me.chkPrimer.Size = New System.Drawing.Size(108, 20)
        Me.chkPrimer.TabIndex = 1
        Me.chkPrimer.Text = "Aron Mighty"
        Me.chkPrimer.UseVisualStyleBackColor = True
        '
        'chkBracket
        '
        Me.chkBracket.AutoSize = True
        Me.chkBracket.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.chkBracket.Location = New System.Drawing.Point(18, 34)
        Me.chkBracket.Name = "chkBracket"
        Me.chkBracket.Size = New System.Drawing.Size(137, 20)
        Me.chkBracket.TabIndex = 0
        Me.chkBracket.Text = "Bracket Present"
        Me.chkBracket.UseVisualStyleBackColor = True
        '
        'txtBracketID
        '
        Me.txtBracketID.BackColor = System.Drawing.SystemColors.Control
        Me.txtBracketID.Enabled = False
        Me.txtBracketID.Location = New System.Drawing.Point(70, 96)
        Me.txtBracketID.Name = "txtBracketID"
        Me.txtBracketID.Size = New System.Drawing.Size(34, 20)
        Me.txtBracketID.TabIndex = 9
        Me.txtBracketID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(171, 16)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Robot Program Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(67, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 16)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Name:"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(9, 155)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(77, 24)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(113, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Bracket Selection "
        '
        'btnRemoveItem
        '
        Me.btnRemoveItem.Enabled = False
        Me.btnRemoveItem.Location = New System.Drawing.Point(254, 157)
        Me.btnRemoveItem.Name = "btnRemoveItem"
        Me.btnRemoveItem.Size = New System.Drawing.Size(104, 22)
        Me.btnRemoveItem.TabIndex = 4
        Me.btnRemoveItem.Text = "Remove Bracket"
        Me.btnRemoveItem.UseVisualStyleBackColor = True
        '
        'txtPartSettingsCurrentBracketType
        '
        Me.txtPartSettingsCurrentBracketType.BackColor = System.Drawing.SystemColors.Control
        Me.txtPartSettingsCurrentBracketType.Enabled = False
        Me.txtPartSettingsCurrentBracketType.Location = New System.Drawing.Point(22, 35)
        Me.txtPartSettingsCurrentBracketType.Name = "txtPartSettingsCurrentBracketType"
        Me.txtPartSettingsCurrentBracketType.Size = New System.Drawing.Size(135, 20)
        Me.txtPartSettingsCurrentBracketType.TabIndex = 3
        Me.txtPartSettingsCurrentBracketType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnAddNewBracket
        '
        Me.btnAddNewBracket.Enabled = False
        Me.btnAddNewBracket.Location = New System.Drawing.Point(35, 132)
        Me.btnAddNewBracket.Name = "btnAddNewBracket"
        Me.btnAddNewBracket.Size = New System.Drawing.Size(109, 24)
        Me.btnAddNewBracket.TabIndex = 2
        Me.btnAddNewBracket.Text = "Save New Bracket"
        Me.btnAddNewBracket.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.btnAddNewBracket)
        Me.GroupBox3.Controls.Add(Me.txtPartSettingsCurrentBracketType)
        Me.GroupBox3.Controls.Add(Me.txtBracketID)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 197)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(185, 173)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "New Bracket"
        '
        'frmPartSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(373, 378)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "frmPartSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Part Settings"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtPartSettingsCurrentBracketType As TextBox
    Friend WithEvents btnAddNewBracket As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents chkPrimer As CheckBox
    Friend WithEvents chkBracket As CheckBox
    Friend WithEvents btnRemoveItem As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents txtBracketID As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lstBracket As ListBox
    Friend WithEvents GroupBox3 As GroupBox
End Class
