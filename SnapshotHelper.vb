
Imports System.IO


Public Class SnapshotHelper
	Public Camera As New uEye.Camera
	Public CameraId As Integer
	Private s32MemID As Int32
	Private s32Width As Integer
	Private s32height As Integer
	Public CameraList(4) As uEye.Types.CameraInformation

	Public Function InitCamera() As Boolean
		Try
			Dim statusRet As uEye.Defines.Status
			Dim s32Min, s32max, s32inc As Integer
			'Open Camera
			statusRet = Camera.Init(CameraId)
			Camera.PixelFormat.Set(uEye.Defines.ColorMode.Mono8)
			Camera.Timing.PixelClock.GetRange(s32Min, s32max, s32inc)
			Camera.Timing.PixelClock.Set(s32max)
			If (statusRet <> uEye.Defines.Status.Success) Then
				MessageBox.Show("Camera initializing failed")
				Return False
			End If
			Camera.PixelFormat.Set(uEye.Defines.ColorMode.Mono8)
			'Allocate Memory
			statusRet = Camera.Memory.Allocate(s32MemID, True)
			If (statusRet <> uEye.Defines.Status.Success) Then
				MessageBox.Show("Allocate Memory failed")
				Return False
			End If
			' all good
			Return True
		Catch ex As Exception
			frmMain.ShowVBErrors("Failed to InitCamera " & CameraId & " ", ex.Message)
			Return False
		End Try
	End Function

	Public Sub ExitCamera()
		Camera.Exit()
	End Sub

	Public Function GetNumPixels() As Integer
		Try
			Camera.Memory.GetSize(s32MemID, s32Width, s32height)
			Return s32Width * s32height
		Catch ex As Exception
			frmMain.ShowVBErrors("GetNumPixels", ex.Message)
		End Try
	End Function

	Public Function DetermineRawImageSize() As Integer
		Try
			Dim bytesPerPixel As Integer
			Camera.PixelFormat.GetBytesPerPixel(bytesPerPixel)
			Return bytesPerPixel * GetNumPixels()
		Catch ex As Exception
			frmMain.ShowVBErrors("DetermineRawImageSize", ex.Message)
		End Try
	End Function

	Public Function GetSnapshot(ByRef image As HSCLASSLIBRARYLib.HSImage) As Boolean
		Dim rawImageSize As Integer
		Try
			rawImageSize = DetermineRawImageSize()
			Dim buf(rawImageSize - 1) As Byte
			'Successful initialization of camera
			If Not isOnline() Then Return False
			'Freeze Video
			Camera.Acquisition.Freeze(uEye.Defines.DeviceParameter.Wait)
			'Get memory id number
			Camera.Memory.GetActive(s32MemID)
			'copy data
			Camera.Memory.CopyToArray(s32MemID, buf)
			'Set the Image Size and Width for the Hexsight Import Image process
			image.Width = s32Width
			image.Height = s32height
			image.CopyFromSafeArray(buf, True)
			Return True
		Catch ex As Exception
			frmMain.ShowVBErrors("GetSnapshot. Camera ID =" & CameraId & " ", ex.Message)
			Return False
		End Try
	End Function

	Public Function byteArrayToImage(byteArrayIn As Byte()) As Image
		Dim ms As New MemoryStream(byteArrayIn)
		Dim returnImage As Image = Image.FromStream(ms)
		Return returnImage
	End Function

	Public Function SetSimpleFeature(ByVal featureid As String, ByVal param0 As Single, side As Integer) As Boolean
		Try
			Dim statusRet As uEye.Defines.Status
			featureid = LCase(featureid)
			Select Case featureid
				Case "exposure"
					Camera.Timing.Exposure.Set(param0 / 10)
				Case "gain"
					Camera.Gain.Hardware.Boost.SetEnable(True)
					Camera.Gain.Hardware.Scaled.SetMaster(CInt(param0))
			End Select
			If (statusRet = uEye.Defines.Status.Success) Then
				Return True
			Else
				Return False
			End If
		Catch ex As Exception
			frmMain.ShowVBErrors("Failed to SetSimpleFeature. Camera ID= " & CameraId & " ", ex.Message)
			Return False
		End Try
	End Function

	Public Function GetSimpleFeature(ByVal featureId As String) As Integer
		Try
			Dim info As uEye.Types.ETH.DeviceInformation
			Dim statusRet As uEye.Defines.Status

			Dim FeatureValue As Integer
			Select Case featureId
				Case "Temperature"
					statusRet = Camera.Information.GetDeviceInfo(info)
					FeatureValue = CInt(info.DeviceHeartbeat.Temperature)
					Return FeatureValue
			End Select
		Catch ex As Exception
			frmMain.ShowVBErrors("Failed to GetSimpleFeature. CameraID =" & CameraId & " ", ex.Message)
		End Try
	End Function

	Public Function isOnline() As Boolean
		Dim CamID(4) As Int16
		Dim Connected(4) As Boolean
		Dim Count As Integer
		Dim statusRet As uEye.Defines.Status
		Try
			OnlineMessage = " "
			statusRet = uEye.Info.Camera.GetNumberOfDevices(Count)
			statusRet = uEye.Info.Camera.GetCameraList(CameraList)
			For i As Int16 = 0 To Count - 1
				CamID(i) = CameraList(i).CameraID
			Next
			If Count < 4 AndAlso Count >= 1 Then
				For Sect As Int16 = 0 To Count - 1
					Select Case CamID(Sect)
						Case 1
							Connected(0) = True
						Case 2
							Connected(1) = True
						Case 3
							Connected(2) = True
						Case 4
							Connected(3) = True
						Case 5
							Connected(4) = True
					End Select
				Next
				For i As Int16 = 0 To 4
					Select Case i
						Case 0
							If Not Connected(i) Then OnlineMessage = OnlineMessage & "Bracket "
							frmMain.ImageBracketConveyor.Load(ConfigPath & "NoImage.bmp")
						Case 1
							If Not Connected(i) Then OnlineMessage = OnlineMessage & "Driver "
							frmMain.ImageDriver.Load(ConfigPath & "NoImage.bmp")
						Case 2
							If Not Connected(i) Then OnlineMessage = OnlineMessage & "Center "
							frmMain.ImageLocateGlass.Load(ConfigPath & "NoImage.bmp")
							frmMain.ImageCenter.Load(ConfigPath & "NoImage.bmp")
							frmMain.ImageBracketVerify.Load(ConfigPath & "NoImage.bmp")
						Case 3
							If Not Connected(i) Then OnlineMessage = OnlineMessage & "Passenger "
							frmMain.ImagePassenger.Load(ConfigPath & "NoImage.bmp")
						Case 4
							If Not Connected(i) Then OnlineMessage = OnlineMessage & "Primer/Tape"
							frmMain.ImageBracketPrimer.Load(ConfigPath & "NoImage.bmp")
							frmMain.ImageBracketTape1.Load(ConfigPath & "NoImage.bmp")

					End Select
				Next
				frmShowError.lblErrorMessage.Text = OnlineMessage & " Camera"
				frmShowError.Show()
				Return False
			Else
				If Count = 0 Then
					OnlineMessage = "All Cameras are disconnected"
					frmShowError.lblErrorMessage.Text = OnlineMessage
					frmShowError.Show()
					Return False
				Else
					Return True
				End If
			End If
		Catch ex As Exception
			frmMain.ShowVBErrors("Camera IsOnline, cameraID=" & CameraId & " ", ex.Message)
		End Try
	End Function

End Class
