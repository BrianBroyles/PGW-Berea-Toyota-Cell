Public Class frmShiftCnts

	Private Sub frmShiftCnts_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Try
			ReadData()
		Catch ex As Exception
			frmMain.ShowVBErrors("frmShiftCnts_Load", ex.Message)
		End Try
	End Sub

	Private Sub ReadData()
		Try
			Dim PLC_ReadAry() As String
			PLC_ReadAry = frmMain.PLC_DriverCLX.Read("HMI_ShiftCounts", 10)
			updnLocBracketCntr.Value = Val(PLC_ReadAry(0))
			updnTapeLocCntr.Value = Val(PLC_ReadAry(1))
			updnBracketPrimeCntr.Value = Val(PLC_ReadAry(2))
			updnBrktScanCntr.Value = Val(PLC_ReadAry(3))
			updnGlassLocCntr.Value = Val(PLC_ReadAry(4))
			updnAMPrimerCntr.Value = Val(PLC_ReadAry(5))
			updnHPrimerCntr.Value = Val(PLC_ReadAry(6))
			updnVerifycntr.Value = Val(PLC_ReadAry(7))
			updnTMCntr.Value = Val(PLC_ReadAry(8))
			Application.DoEvents()
		Catch ex As Exception
			frmMain.ShowVBErrors("frmShift_ReadData()", ex.Message)
		End Try
	End Sub

   Private Sub btnResetCntrs_Click(sender As Object, e As EventArgs) Handles btnResetCntrs.Click
      frmMain.PLC_DriverCLX.Write("HMI_Shift_Reset", 0)
      System.Threading.Thread.Sleep(250)
      frmMain.PLC_DriverCLX.Write("HMI_Shift_Reset", 1)
      ReadData()
   End Sub

   Private Sub updnLocBracketCntr_ValueChanged(sender As Object, e As EventArgs) Handles updnLocBracketCntr.ValueChanged,
																																														updnTapeLocCntr.ValueChanged,
																																														updnBracketPrimeCntr.ValueChanged,
																																														updnBrktScanCntr.ValueChanged,
																																														updnGlassLocCntr.ValueChanged,
																																														updnAMPrimerCntr.ValueChanged,
																																														updnHPrimerCntr.ValueChanged,
																																														updnVerifycntr.ValueChanged,
																																														updnTMCntr.ValueChanged
		Try
			Dim Index As Integer = 0
			Select Case sender.name
				Case "updnLocBracketCntr"
					Index = 0
				Case "updnTapeLocCntr"
					Index = 1
				Case "updnBracketPrimeCntr"
					Index = 2
				Case "updnBrktScanCntr"
					Index = 3
				Case "updnGlassLocCntr"
					Index = 4
				Case "updnAMPrimerCntr"
					Index = 5
				Case "updnHPrimerCntr"
					Index = 6
				Case "updnVerifycntr"
					Index = 7
				Case "updnTMCntr"
					Index = 8
			End Select
			Dim updn As NumericUpDown
			updn = DirectCast(sender, NumericUpDown)
			frmMain.PLC_DriverCLX.Write("HMI_ShiftCounts[" & Index.ToString & "]", updn.Value)
		Catch ex As Exception
		End Try
	End Sub

End Class