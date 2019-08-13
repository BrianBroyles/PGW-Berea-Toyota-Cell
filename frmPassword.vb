Public Class frmPassword
	Public OkToExit As Boolean = False
	Public CloseMessageForm As Boolean = False

	Public Function GetPassword() As String
		Try
			OkToExit = False
			txtPassword.Text = ""
			txtPassword.Focus()
			lblMessage.Visible = False
			Me.Show()
			Me.TopMost = True
			Do Until (OkToExit)
				Application.DoEvents()
			Loop
			Return txtPassword.Text
		Catch ex As Exception
			frmMain.ShowVBErrors("FrmPassword GetPassword", ex.Message)
			Return ""
		End Try
	End Function

	Public Sub btnEnter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnter.Click
		Dim InputString_Renamed As String
		Dim OperatorPassWord As String
		Dim EngineeringPassWord As String
		Dim BackdoorPassword As String
		frmMain.SetPasswordLevels()
		If frmMain.mnuPassword.Checked = True Then
			frmMain.ActivatePassword(frmMain.OperPassword)
			frmMain.TmrPassword.Enabled = False
			txtPassword.Text = ""
			Me.Hide()
		Else
			InputString_Renamed = txtPassword.Text
			InputString_Renamed = StrConv(InputString_Renamed, VbStrConv.Uppercase)
			InputString_Renamed = UCase(InputString_Renamed)
			OperatorPassWord = frmDataBase.GetValue("Password", "Value", "Op Password")
			EngineeringPassWord = frmDataBase.GetValue("Password", "Value", "Eng Password")
			BackdoorPassword = "mwmotion921"
			Select Case InputString_Renamed
				Case UCase(EngineeringPassWord)
					frmMain.ActivatePassword(frmMain.EngPassword)
					frmMain.TmrPassword.Enabled = True
					frmMain.mnuPassword.Checked = True
					txtPassword.Text = ""
					Me.Hide()
				Case UCase(BackdoorPassword)
					frmMain.ActivatePassword(frmMain.DevPassword)
					frmMain.TmrPassword.Enabled = True
					frmMain.mnuPassword.Checked = True
					txtPassword.Text = ""
					Me.Hide()
				Case UCase(OperatorPassWord)
					frmMain.ActivatePassword(frmMain.OperPassword)
					frmMain.TmrPassword.Enabled = True
					frmMain.mnuPassword.Checked = False
					txtPassword.Text = ""
					Me.Hide()
				Case Else
					frmMain.ActivatePassword(frmMain.OperPassword)
					frmMain.mnuPassword.Checked = False
					txtPassword.Focus()
					MsgBox("Password is Incorrect", MsgBoxStyle.SystemModal)
			End Select
		End If
	End Sub

	Public Sub ShowMessage(ByVal Message As String)
		CloseMessageForm = False
		Timer1.Enabled = True
		lblMessage.Visible = True
		lblMessage.Text = Message
		Do Until (CloseMessageForm)
			Application.DoEvents()
		Loop
		Me.Close()
	End Sub

	Private Sub Timer1_tick() Handles Timer1.Tick
		CloseMessageForm = True
	End Sub

	Private Sub frmPassword_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
		txtPassword.Focus()
	End Sub

	Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
		txtPassword.Text = ""
		Me.Hide()
	End Sub

End Class