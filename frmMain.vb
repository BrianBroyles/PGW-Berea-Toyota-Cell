Option Strict Off
Option Explicit On
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.IO
Imports VB = Microsoft.VisualBasic
Imports HSDISPLAYLib
Imports System.Data.SqlServerCe

Public Class frmMain
    Inherits Windows.Forms.Form

#Region "Declarations"
    '
    'General module level variables
    Public CurrentFilePath As String 'PartsPath + PartName
    Public VisionDatabasePath As String = Application.StartupPath + "\..\..\Config Data\Vision.cfg" 'App.Path + "\..\Config Data\Vision.cfg"
    Public CalibrationPath As String = Application.StartupPath + "\..\..\Config Data\"
    Public UpdatingPartData As Boolean = False
    Private Calibrating As Boolean
    Public Loading As Boolean
    Public Side As Int16
    '
    'Vision system module variables
    Private HSApp As AxHSAPPLICATIONLib.AxHSApplication
    Private HSAcq As HSACQUISITIONDEVICELib.HSAcquisitionDevice
    Public HSDb As HSCLASSLIBRARYLib.HSDatabase
    Private HSLoc(12) As HSLOCATORLib.HSLocator
    Public HSBlob As HSBLOBANALYZERLib.HSBlobAnalyzer
    Private Calibrate As HSACQUISITIONDEVICELib.HSCalibrationDistortionInterface

    Public ImageLocateGlass As New HSCLASSLIBRARYLib.HSImage
    Public ImageBracketConveyor As New HSCLASSLIBRARYLib.HSImage
    Public ImageBracketPrimer As New HSCLASSLIBRARYLib.HSImage
    Public ImageBracketTape As New HSCLASSLIBRARYLib.HSImage
    Public ImageBracketTape1 As New HSCLASSLIBRARYLib.HSImage
    Public ImageBracketTape2 As New HSCLASSLIBRARYLib.HSImage
    Public ImageBracketTape3 As New HSCLASSLIBRARYLib.HSImage
    Public ImageBracketTape4 As New HSCLASSLIBRARYLib.HSImage
    Public ImageDriver As New HSCLASSLIBRARYLib.HSImage
    Public ImageCenter As New HSCLASSLIBRARYLib.HSImage
    Public ImagePassenger As New HSCLASSLIBRARYLib.HSImage
    Public ImageGocator As New HSCLASSLIBRARYLib.HSImage
    Public ImageBracketBlob As New HSCLASSLIBRARYLib.HSImage
    Public ImageDriverBlob As New HSCLASSLIBRARYLib.HSImage
    Public ImageCenterBlob As New HSCLASSLIBRARYLib.HSImage
    Public ImagePassengerBlob As New HSCLASSLIBRARYLib.HSImage
    Public ImageBracketVerify As New HSCLASSLIBRARYLib.HSImage

    Public HelperCamBracket As New SnapshotHelper
    Public HelperCamDriver As New SnapshotHelper
    Public HelperCamCenter As New SnapshotHelper
    Public HelperCamPassenger As New SnapshotHelper

    Private VisionSuccess As Boolean
    Public SaveImagePath As String
    'Menu Handling
    Public WithEvents loadABC, loadDEF, loadGHI, loadJKL, loadMNO, loadPQR, loadSTU, loadVWX, loadYZ, loadOther As New Windows.Forms.ToolStripMenuItem
    Public WithEvents deleteABC, deleteDEF, deleteGHI, deleteJKL, deleteMNO, deletePQR, deleteSTU, deleteVWX, deleteYZ, deleteOther As New Windows.Forms.ToolStripMenuItem
    '
    Public CalledFromRobot As Boolean = False
    Public OldOffsetstring As String
    Public OffsetString As String
    Public CheckString As String
    Private OriginalRectX, OriginalRectY, OriginalRectR As Single
    '
    'PLC
    Public WithEvents PLC_Bworker As New BackgroundWorker
    '
    Public PLC_DriverCLX As New ClxDriver.EthernetIPforCLX
    '
    Private WithEvents IOTimer As New Timer
    Private WithEvents PLCTimer As New Timer
    '
    Public OperPassword As _Password
    Public EngPassword As _Password
    Public DevPassword As _Password

    Public Structure _Password
        Dim NewPart As Boolean
        Dim DeletePart As Boolean
        Dim PartsDB As Boolean
        Dim PLCDB As Boolean
        Dim Run As Boolean
        Dim General As Boolean
        Dim Gocator As Boolean
        Dim Close As Boolean
        Dim Calibrate As Boolean
        Dim TrainNew As Boolean
        Dim TrainExsisting As Boolean
        Dim SearchSettings As Boolean
        Dim CameraSettings As Boolean
        Dim ModelScoreLimit As Boolean
        Dim ModifyPart As Boolean
        Dim PasswordTimeout As Int16
        Dim Level As String
    End Structure

#End Region

#Region "Form Load/Unload"

    Private Sub frmMain_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        tabVisionRobot.Appearance = TabAppearance.FlatButtons : tabVisionRobot.ItemSize = New Size(0, 1) : tabVisionRobot.SizeMode = TabSizeMode.Fixed
        '    Dim Status As String
        Dim Success As Boolean
        Dim I As Integer = 0
        Try
            Loading = True
            InitializingForm = True
            My.Application.Log.WriteEntry(My.Application.Info.DirectoryPath & "SquareLog.txt", 0)
            NumCams = 5
            frmSplash.Show()
            SetPasswordLevels()
            frmSplash.lblStatus.Text = "Loading General Settings"
            DelayTimer(250)
            GetSettings()
            frmSplash.lblStatus.Text = "Starting PLC Communication"
            UpdatePLCTags()
            DelayTimer(250)
            frmSplash.lblStatus.Text = "Initializing Cameras"
            Application.DoEvents()
            Success = InitCameras()
            frmSplash.lblStatus.Text = "Initializing Vision Tools"
            Success = InitVision()
            Application.DoEvents()
            frmSplash.lblStatus.Text = "Loading Bracket Data"
            LoadBracket()
            Application.DoEvents()
            frmSplash.lblStatus.Text = "Loading Part File"

            Upgrade(ConfigPath & "Bracket.sdf", "")
            Upgrade(ConfigPath & "Password.sdf", "")
            Upgrade(ConfigPath & "Settings.sdf", "")

            LoadPart(PartName)
            Application.DoEvents()
            DelayTimer(250) 'Needed to allow the adjustments to be applied to the next frame
            Me.Show()
            Application.DoEvents()
            Me.Height = SystemInformation.PrimaryMonitorSize.Height - 40
            Me.Width = SystemInformation.PrimaryMonitorSize.Width
            Me.Show()
            Application.DoEvents()
            ActivatePassword(OperPassword)
            UpdatingPartData = True
            UpdateUpDownControls()
            UpdatingPartData = False
            InitializingForm = False
            ToolTip1.AutoPopDelay = Integer.MaxValue
            frmSplash.Hide()
            Application.DoEvents()
            tmrDisplayUpdate.Interval = 2000
            tmrDisplayUpdate.Enabled = True
            TabControlsMain.SelectedTab = tabPageBracketLocate
            frmSplash.lblStatus.Text = "Snapping Images"
            Application.DoEvents()
            'TODO Uncomment Snaps
            'Snap some pictures
            'Snap(Camera.LocateGlass)
            Snap(Camera.BracketAtDialTable)
            'Snap(Camera.BracketTape)
            'Snap(Camera.BracketVerify)
            'Snap(Camera.BracketPrimer)
            'Snap(Camera.Driver)
            'Snap(Camera.Center)
            'Snap(Camera.Passenger)
            'Start the timer to poll the PLC
            TabControlsMain.TabPages.Remove(tabPagePosition)
            '''''''''''''''''''''''''''''''''''''''
            'Start the timer to connect vision and PLC
            IOTimer.Interval = 100
            IOTimer.Start()
            IOTimer.Enabled = True
            Loading = False
            frmSplash.lblStatus.Text = "Finished"
            Application.DoEvents()
            DelayTimer(250)
            mnuSaveVerification.Checked = True
        Catch ex As Exception
            ShowVBErrors("Form_Load ", Err.Description)
        End Try
    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Try
            lblmessagedesc.Text = "Shutting Down"
            PLC_Bworker.CancelAsync()
            IOTimer.Enabled = False
            DelayTimer(IOTimer.Interval + 100)
            HSAcq = Nothing
            HSApp = Nothing
            For i As Int16 = 0 To 3
                HSLoc(i) = Nothing
            Next i
            HelperCamBracket.ExitCamera()
            HelperCamBracket = Nothing
            HelperCamCenter = Nothing
            HelperCamDriver = Nothing
            HelperCamPassenger = Nothing
            System.Environment.Exit(-1)
            End
        Catch ex As Exception
            If Me.Text <> "Loading" Then
                MsgBox("Errors were encountered While quitting", MsgBoxStyle.SystemModal)
            End If
            ShowVBErrors("frmMain_FormClosed", ex.Message)
        End Try
    End Sub
#End Region

#Region "Tabs"
    Public Sub SwitchTab(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControlsMain.Selected
        Dim Tab As New TabControl
        Tab = DirectCast(sender, TabControl)
        Select Case Tab.SelectedTab.Name
            'Case tabPageGocator.Name
            '	TabControlsMain.Size = New Point(1554, 958)
            '	CurrentVisionTab = Camera.GoCator
            '	Try
            '		Dim myProcess As New System.Diagnostics.Process()
            '		myProcess.StartInfo = New System.Diagnostics.ProcessStartInfo("iexplore", "http://192.168.1.10")
            '		myProcess.Start()
            '	Catch ex As Exception
            '		ShowVBErrors("Starting Gocator-", ex.Message)
            '	End Try
            '	TabControlsMain.SelectedTab = tabPageBracketLocate
            Case tabPageBracketLocate.Name
                TabControlsMain.Size = New Point(1554, 958)
                CurrentVisionTab = Camera.LocateGlass
            Case tabPageDriverCam.Name
                TabControlsMain.Size = New Point(1554, 958)
                CurrentVisionTab = Camera.Driver
            Case tabPageCenterCam.Name
                TabControlsMain.Size = New Point(1554, 958)
                CurrentVisionTab = Camera.Center
            Case tabPagePassCam.Name
                TabControlsMain.Size = New Point(1554, 958)
                CurrentVisionTab = Camera.Passenger
            Case tabPageBracketLocateTape.Name
                TabControlsMain.Size = New Point(1554, 958)
                CurrentVisionTab = 6
            Case tabpageBracketLocateAtConveyor.Name
                TabControlsMain.Size = New Point(1554, 958)
                CurrentVisionTab = Camera.BracketAtDialTable
            Case tabPageCenterBracketVerify.Name
                TabControlsMain.Size = New Point(1554, 958)
                CurrentVisionTab = Camera.BracketVerify
        End Select
    End Sub
#End Region

#Region "Application"

    Public Sub CheckAppRunning()
        Try
            If Process.GetProcessesByName(Process.GetCurrentProcess.ProcessName).Length > 1 Then
                MessageBox.Show("Another Instance Of this process Is already running", "Multiple Instances Forbidden", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Application.Exit()
                Me.Close()
                End
            End If
        Catch ex As Exception
            ShowVBErrors("CheckAppRunning", ex.Message)
        End Try

    End Sub

    Public Sub SetPasswordLevels()
        'Engineering Password
        With EngPassword
            .Calibrate = False
            .CameraSettings = True
            .Close = True
            .DeletePart = True
            .ModelScoreLimit = True
            .ModifyPart = True
            .NewPart = True
            .Gocator = True
            .PasswordTimeout = 5
            .PartsDB = True
            .PLCDB = True
            .Run = True
            .SearchSettings = True
            .TrainExsisting = True
            .TrainNew = True
            .General = True
            .Level = "Current Password Level: Engineer"
        End With
        '
        'Developer Passowrd
        With DevPassword
            .Calibrate = True
            .CameraSettings = True
            .Close = True
            .DeletePart = True
            .ModelScoreLimit = True
            .ModifyPart = True
            .NewPart = True
            .Gocator = True
            .PasswordTimeout = 30
            .PartsDB = True
            .PLCDB = True
            .Run = True
            .SearchSettings = True
            .TrainExsisting = True
            .TrainNew = True
            .General = True
            .Level = "Current Password Level: Midwest Motion"
        End With
        '
        'Operator Password
        With OperPassword
            .Calibrate = False
            .CameraSettings = False
            .Close = False
            .DeletePart = False
            .ModelScoreLimit = False
            .ModifyPart = False
            .NewPart = False
            .Gocator = False
            .PasswordTimeout = 5
            .PartsDB = False
            .PLCDB = False
            .Run = True
            .SearchSettings = False
            .TrainExsisting = False
            .TrainNew = False
            .General = False
            .Level = "Current Password Level: Operator"
        End With
    End Sub

    Public Sub ActivatePassword(ByVal Password As _Password)
        Try
            '
            'Timerout
            TmrPassword.Interval = ((1000 * 60) * Password.PasswordTimeout)
            lblCurrentUser.Text = Password.Level
            '
            'Menus
            mnuConfig.Enabled = Password.PartsDB
            mnuGeneralDatabaseSettings.Enabled = Password.PartsDB
            mnuCalibration.Enabled = Password.Calibrate
            mnuPositionalSettings.Enabled = Password.General
            mnuDeletePart.Enabled = Password.DeletePart
            mnuNew.Enabled = Password.NewPart
            mnuPartSettings.Enabled = Password.PartsDB
            grpGlassLocate.Visible = Password.General
            '
            'labels
            lblExposure.Enabled = Password.General
            lblContrast.Enabled = Password.General
            '
            'train new  '
            btnTrainNewLocateGlass.Enabled = Password.TrainNew
            btnTrainNewBracketconveyor.Enabled = Password.TrainNew
            btnTrainNewBracketPrimer.Enabled = Password.TrainNew
            btnTrainNewBracketTape.Enabled = Password.TrainNew
            btnTrainNewCenter.Enabled = Password.TrainNew
            btnTrainNewCenterVerify.Enabled = Password.TrainNew
            btnTrainNewDriver.Enabled = Password.TrainNew
            btnTrainNewPassenger.Enabled = Password.TrainNew
            btnPassengerTrainBlob.Enabled = Password.TrainNew
            btnCenterTrainBlob.Enabled = Password.TrainNew
            btnDriverTrainBlob.Enabled = Password.TrainNew
            btnTrainBracketPrimer1.Enabled = Password.TrainNew
            btnTrainBracketPrimer2.Enabled = Password.TrainNew
            btnTrainBracketPrimer3.Enabled = Password.TrainNew
            btnTrainBracketPrimer4.Enabled = Password.TrainNew
            btnTrainBracketPrimer5.Enabled = Password.TrainNew
            btnTrainBracketPrimerReference.Enabled = Password.TrainNew
            '
            'train existing
            btnTrainExistingLocateGlass.Enabled = Password.TrainExsisting
            btnTrainExistingBracketConveyor.Enabled = Password.TrainExsisting
            btnTrainExistingBracketPrimer.Enabled = Password.TrainExsisting
            btnTrainExistingBracketTape.Enabled = Password.TrainExsisting
            btnTrainExistingCenter.Enabled = Password.TrainExsisting
            btnTrainExistingCenterVerify.Enabled = Password.TrainExsisting
            btnTrainExistingDriver.Enabled = Password.TrainExsisting
            btnTrainExistingPassenger.Enabled = Password.TrainExsisting
            btnSaveVerifyDifference.Enabled = Password.TrainExsisting
            '
            'search settings
            btnSearchSettingsLocateGlass.Enabled = Password.SearchSettings
            btnSearchSettingsBracketConveyor.Enabled = Password.SearchSettings
            btnSearchSettingsBracketPrimer.Enabled = Password.SearchSettings
            btnSearchSettingsBracketTape.Enabled = Password.SearchSettings
            btnSearchSettingsCenter.Enabled = Password.SearchSettings
            btnSearchSettingsCenterVerify.Enabled = Password.SearchSettings
            btnSearchSettingsDriver.Enabled = Password.SearchSettings
            btnSearchSettingsPassenger.Enabled = Password.SearchSettings
            '
            'run inspections
            btnMainRunGlassInspection.Enabled = Password.Run
            btnMainRunBracketVerify.Enabled = Password.Run
            btnMainRunDriverInspec.Enabled = Password.Run
            btnMainRunBracketInspectionPrimer.Enabled = Password.Run
            btnMainRunCenterInspec.Enabled = Password.Run
            btnMainRunPassengerInspec.Enabled = Password.Run
            btnMainRunBracketInspectionConveyor.Enabled = Password.Run
            btnMainRunBracketInspectionTape.Enabled = Password.Run
            btnOverheadLight.Enabled = Password.Run
            btnBacklight.Enabled = Password.Run
            '
            'camera settings
            updnExposureLocateGlass.Enabled = Password.CameraSettings
            updnExposureBracketConveyor.Enabled = Password.CameraSettings
            updnExposureBracketTape.Enabled = Password.CameraSettings
            updnExposureBracketPrimer.Enabled = Password.CameraSettings
            updnExposureCenter.Enabled = Password.CameraSettings
            updnExposureCenterVerify.Enabled = Password.CameraSettings
            updnExposureDriver.Enabled = Password.CameraSettings
            updnExposurePassenger.Enabled = Password.CameraSettings
            updnContrastLocateGlass.Enabled = Password.CameraSettings
            updnContrastBracketConveyor.Enabled = Password.CameraSettings
            updnContrastBracketTape.Enabled = Password.CameraSettings
            updnContrastBracketPrimer.Enabled = Password.CameraSettings
            updnContrastCenter.Enabled = Password.CameraSettings
            updnContrastCenterVerify.Enabled = Password.CameraSettings
            updnContrastDriver.Enabled = Password.CameraSettings
            updnContrastPassenger.Enabled = Password.CameraSettings
            '
            'Thresholds etc.
            updnBracketPrimer1Deviation.Enabled = Password.TrainNew
            updnBracketPrimer2Deviation.Enabled = Password.TrainNew
            updnBracketPrimer3Deviation.Enabled = Password.TrainNew
            updnBracketPrimer4Deviation.Enabled = Password.TrainNew
            updnBracketPrimer5Deviation.Enabled = Password.TrainNew
            updnPassengerBlobThresholdMin.Enabled = Password.TrainNew
            updnPassengerBlobThresholdMax.Enabled = Password.TrainNew
            updnCenterBlobThresholdMin.Enabled = Password.TrainNew
            updnCenterBlobThresholdMax.Enabled = Password.TrainNew
            updnDriverBlobThresholdMin.Enabled = Password.TrainNew
            updnDriverBlobThresholdMax.Enabled = Password.TrainNew
            updnBottomLeftVerifyVariance.Enabled = Password.TrainNew
            updnBottomRightVerifyVariance.Enabled = Password.TrainNew
            updnTopRightVerifyVariance.Enabled = Password.TrainNew
            '
            'Score Limit
            updnScoreLimit.Enabled = Password.ModelScoreLimit
            updnScoreLimitBracketPrimer.Enabled = Password.ModelScoreLimit
            updnScoreLimitBracketconveyor.Enabled = Password.ModelScoreLimit
            updnScoreLimitTapeBracketLocator.Enabled = Password.ModelScoreLimit
            updnScoreLimitCenter.Enabled = Password.ModelScoreLimit
            updnScoreLimitCenterVerify.Enabled = Password.ModelScoreLimit
            updnScoreLimitDriver.Enabled = Password.ModelScoreLimit
            updnScoreLimitPassenger.Enabled = Password.ModelScoreLimit
            '
            'Tape
            updnTapeMinAreaBottomLeft.Enabled = Password.ModelScoreLimit
            updnTapeMinAreaBottomRight.Enabled = Password.ModelScoreLimit
            updnTapeMinAreaTopLeft.Enabled = Password.ModelScoreLimit
            updnTapeMinAreaTopRight.Enabled = Password.ModelScoreLimit
            updnTapeBlobMinTopLeft.Enabled = Password.ModelScoreLimit
            updnTapeBlobMaxTopLeft.Enabled = Password.ModelScoreLimit
            updnTapeBlobMinTopRight.Enabled = Password.ModelScoreLimit
            updnTapeBlobMaxTopRight.Enabled = Password.ModelScoreLimit
            updnTapeBlobMinBottomLeft.Enabled = Password.ModelScoreLimit
            updnTapeBlobMaxBottomLeft.Enabled = Password.ModelScoreLimit
            updnTapeBlobMinBottomRight.Enabled = Password.ModelScoreLimit
            updnTapeBlobMaxBottomRight.Enabled = Password.ModelScoreLimit
            btnTrainTapeArea.Enabled = Password.General
            btnSaveTapeArea.Enabled = Password.General
            'Tape Cover
            updnCoverBlobMinBottomLeft.Enabled = Password.ModelScoreLimit
            updnCoverBlobMinBottomRight.Enabled = Password.ModelScoreLimit
            updnCoverBlobMinTopLeft.Enabled = Password.ModelScoreLimit
            updnCoverBlobMinTopRight.Enabled = Password.ModelScoreLimit
            updnCoverMaxAreaBottomLeft.Enabled = Password.ModelScoreLimit
            updnCoverMaxAreaBottomRight.Enabled = Password.ModelScoreLimit
            updnCoverMaxAreaTopLeft.Enabled = Password.ModelScoreLimit
            updnCoverMaxAreaTopRight.Enabled = Password.ModelScoreLimit
            btnTrainCoverArea.Enabled = Password.General
            btnSaveCoverArea.Enabled = Password.General
            '
            'Verify
            txtVerifySavedDiffBottomLeft.Enabled = Password.General
            txtVerifySavedDiffBottomRight.Enabled = Password.General
            txtVerifySavedDiffTopRight.Enabled = Password.General
            '
            'Deposit
            btnDepositAdjYMinus.Enabled = Password.General
            btnDepositAdjRMinus.Enabled = Password.General
            btnDepositAdjRPlus.Enabled = Password.General
            btnDepositAdjXMinus.Enabled = Password.General
            btnDepositAdjXPlus.Enabled = Password.General
            btnDepositAdjYPlus.Enabled = Password.General
            updnLocationX.Enabled = Password.General
            updnLocationY.Enabled = Password.General
            updnLocationR.Enabled = Password.General
            btnLocationAdjOK.Enabled = Password.General
            btnLocationAdjCancel.Enabled = Password.General
            ''
            ''Gocator
            'TabControlsMain.TabPages.Remove(tabPageGocator)
            'If Password.Gocator Then
            '	TabControlsMain.TabPages.Add(tabPageGocator)
            'End If
        Catch ex As Exception
            ShowVBErrors("ActivatePassword", ex.Message)
        End Try
    End Sub

    Public Sub ShowVBErrors(ByRef SubRoutine As String, ByRef Description As String)
        Dim TimeStamp As Date
        Try
            TimeStamp = Now()
            lstVBError.Items.Insert(0, TimeStamp & " [" & SubRoutine & "] " & Description)
            If lstVBError.Items.Count > 100 Then
                lstVBError.Items.RemoveAt(99)
            End If
            Exit Sub
        Catch ex As Exception
            ShowVBErrors("CheckAppRunning", ex.Message)
        End Try
    End Sub

    Private Sub lstVBError_DoubleClick(sender As Object, e As EventArgs) Handles lstVBError.DoubleClick
        Try
            lstVBError.Items.Clear()
        Catch ex As Exception
            ShowVBErrors("lstVBError_DoubleClick", ex.Message)
        End Try
    End Sub

#End Region

#Region "Camera"

    Private Sub SetCameraSettings()
        Dim Success As Boolean = False
        Try
            For i As Int16 = 1 To NumCams
                Select Case i
                    Case 1
                        Success = HelperCamBracket.SetSimpleFeature("exposure", CSng(updnExposureBracketConveyor.Value), i)
                        If Not Success Then ShowVBErrors("InitCameraSettings", "Unable To Set Camera Exposure " & Err.Description)
                        Success = HelperCamBracket.SetSimpleFeature("gain", CSng(updnContrastBracketConveyor.Value), i)
                        If Not Success Then ShowVBErrors("InitCameraSettings", "Unable To Set Camera Contrast " & Err.Description)
                    Case 2
                        Success = HelperCamDriver.SetSimpleFeature("exposure", CSng(updnExposureDriver.Value), i)
                        If Not Success Then ShowVBErrors("InitCameraSettings", "Unable To Set Camera Exposure " & Err.Description)
                        Success = HelperCamDriver.SetSimpleFeature("gain", CSng(updnContrastDriver.Value), i)
                        If Not Success Then ShowVBErrors("InitCameraSettings", "Unable To Set Camera Contrast " & Err.Description)
                    Case 3
                        Success = HelperCamCenter.SetSimpleFeature("exposure", CSng(updnExposureCenter.Value), i)
                        If Not Success Then ShowVBErrors("InitCameraSettings", "Unable To Set Camera Exposure " & Err.Description)
                        Success = HelperCamCenter.SetSimpleFeature("gain", CSng(updnContrastCenter.Value), i)
                        If Not Success Then ShowVBErrors("InitCameraSettings", "Unable To Set Camera Contrast " & Err.Description)
                    Case 4
                        Success = HelperCamPassenger.SetSimpleFeature("exposure", CSng(updnExposurePassenger.Value), i)
                        If Not Success Then ShowVBErrors("InitCameraSettings", "Unable To Set Camera Exposure " & Err.Description)
                        Success = HelperCamPassenger.SetSimpleFeature("gain", CSng(updnContrastPassenger.Value), i)
                        If Not Success Then ShowVBErrors("InitCameraSettings", "Unable To Set Camera Contrast " & Err.Description)
                End Select
            Next i
        Catch ex As Exception
            ShowVBErrors("SetCameraSettings", ex.Message)
        End Try
    End Sub

    Private Function InitCameras() As Boolean
        Dim CamIDBracket, CamIDDriver, CamIDCenter, CamIDPassenger As Integer
        CamIDBracket = CInt(frmDataBase.GetValue("Settings", "Value", "Camera Bracket"))
        CamIDDriver = CInt(frmDataBase.GetValue("Settings", "Value", "Camera Driver"))
        CamIDCenter = CInt(frmDataBase.GetValue("Settings", "Value", "Camera Center"))
        CamIDPassenger = CInt(frmDataBase.GetValue("Settings", "Value", "Camera Passenger"))
        HelperCamBracket.CameraId = CamIDBracket
        HelperCamDriver.CameraId = CamIDDriver
        HelperCamCenter.CameraId = CamIDCenter
        HelperCamPassenger.CameraId = CamIDPassenger
        Dim InitFail As Boolean = False
        Try
            For i As Int16 = 1 To NumCams
                Select Case i
                    Case 1
                        Application.DoEvents()
                        frmSplash.lblStatus.Text = "Initializing Bracket Camera"
                        If HelperCamBracket.InitCamera() Then
                            InitSuccessBracket = True
                            Application.DoEvents()
                            frmSplash.lblStatus.Text = "Bracket Camera Initialized"
                        Else
                            InitFail = True
                            'TODO  Uncomment msgbox
                            'MsgBox("Could Not Initialize the Bracket Camera ", MsgBoxStyle.Critical, "Camera Assignment Error")
                        End If
                    Case 2
                        Application.DoEvents()
                        frmSplash.lblStatus.Text = "Initializing Driver Camera"
                        If HelperCamDriver.InitCamera() Then
                            InitSuccessDriver = True
                            Application.DoEvents()
                            frmSplash.lblStatus.Text = "Driver Camera Initialized"
                        Else
                            InitFail = True
                            'TODO  Uncomment msgbox
                            'MsgBox("Could Not Initialize the Driver Camera ", MsgBoxStyle.Critical, "Camera Assignment Error")
                        End If
                    Case 3
                        Application.DoEvents()
                        frmSplash.lblStatus.Text = "Initializing Center Camera"
                        If HelperCamCenter.InitCamera() Then
                            InitSuccessCenter = True
                            Application.DoEvents()
                            frmSplash.lblStatus.Text = "Center Camera Initialized"
                        Else
                            InitFail = True
                            'TODO  Uncomment msgbox
                            'MsgBox("Could Not Initialize the Center Camera ", MsgBoxStyle.Critical, "Camera Assignment Error")
                        End If
                    Case 4
                        Application.DoEvents()
                        frmSplash.lblStatus.Text = "Initializing Passenger Camera"
                        If HelperCamPassenger.InitCamera() Then
                            InitSuccessPassenger = True
                            Application.DoEvents()
                            frmSplash.lblStatus.Text = "Passenger Camera Initialized"
                        Else
                            InitFail = True
                            'TODO Uncomment msgbox
                            'MsgBox("Could Not Initialize the Passenger Camera ", MsgBoxStyle.Critical, "Camera Assignment Error")
                        End If
                    Case Else
                        Return False
                End Select
            Next
            If Not InitFail Then
                Return True
            End If
            Return False
        Catch ex As Exception
            ShowVBErrors("InitCameras", ex.Message)
            Return False
        End Try
    End Function

    Private Function GetCameraImage(ByVal Side As Integer) As Boolean
        Dim Success As Boolean = False
        Try
            Select Case Side
                Case Camera.LocateGlass
                    Success = HelperCamCenter.GetSnapshot(ImageLocateGlass)
                Case Camera.Driver
                    Success = HelperCamDriver.GetSnapshot(ImageDriver)
                Case Camera.Center
                    Success = HelperCamCenter.GetSnapshot(ImageCenter)
                Case Camera.Passenger
                    Success = HelperCamPassenger.GetSnapshot(ImagePassenger)
                Case Camera.BracketAtDialTable
                    Success = HelperCamBracket.GetSnapshot(ImageBracketConveyor)
                Case Camera.BracketVerify
                    Success = HelperCamCenter.GetSnapshot(ImageBracketVerify)
            End Select
            If Not Success Then AcquisitionError(Side)
        Catch ex As Exception
            ShowVBErrors("GetCameraImage", ex.Message)
            Success = False
            AcquisitionError(Side)
        Finally
            Cursor.Current = Cursors.Default
        End Try
        Return Success

    End Function

    Private Sub AcquisitionError(ByVal Side As Int16)
        Try
            Select Case Side
                Case Camera.LocateGlass
                    ImageLocateGlass.Load(ConfigPath & "NoImage.bmp")
                Case Camera.Driver
                    ImageDriver.Load(ConfigPath & "NoImage.bmp")
                Case Camera.Center
                    ImageCenter.Load(ConfigPath & "NoImage.bmp")
                Case Camera.Passenger
                    ImagePassenger.Load(ConfigPath & "NoImage.bmp")
                Case Camera.BracketAtDialTable
                    ImagePassenger.Load(ConfigPath & "NoImage.bmp")
                Case Camera.BracketVerify
                    ImagePassenger.Load(ConfigPath & "NoImage.bmp")
            End Select
        Catch ex As Exception
            ShowVBErrors("AcquisitionError", ex.Message)
        End Try

    End Sub

    Private Sub GetTemperature(ByVal helper As Object, ByVal tempLabel As Label)
        Dim Temperature As Single

        Try
            Temperature = helper.GetSimpleFeature("Temperature")
            Temperature /= 16
            Temperature = ((9 / 5) * Temperature) + 32
            tempLabel.Text = Temperature.ToString("N1") & " " & "°F"
            If Temperature < 110 Then
                tempLabel.BackColor = Color.AliceBlue
            ElseIf Temperature >= 110 And Temperature <= 130 Then
                tempLabel.BackColor = Color.Yellow
            ElseIf Temperature > 130 Then
                tempLabel.BackColor = Color.Red
            End If
        Catch ex As Exception
            ShowVBErrors("GetTemperature", ex.Message)
        End Try
    End Sub

#End Region

#Region "Vision Controls"

    Private Sub btnTrainNew_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnTrainNewLocateGlass.Click, btnTrainNewBracketconveyor.Click,
                    btnTrainNewBracketTape.Click, btnTrainNewCenter.Click, btnTrainNewCenterVerify.Click, btnTrainNewDriver.Click, btnTrainNewPassenger.Click,
                    btnTrainNewBracketPrimer.Click
        Dim Result As Short
        Dim HSModel1 As HSLOCATORLib.HSModelEditorInterface
        Dim RefPick As Point
        Dim Side As Int16
        Dim TextString As String = ""
        Dim btn As Button
        btn = DirectCast(eventSender, Button)
        If INRoutine Then Exit Sub
        InTraining = True
        If chkSnapRepeatLocateGlass.Checked = True Then chkSnapRepeatLocateGlass.Checked = False
        INRoutine = True

        Try
            Select Case btn.Name
                Case btnTrainNewLocateGlass.Name
                    TextString = "Glass Location model"
                    Side = Camera.LocateGlass
                Case btnTrainNewBracketconveyor.Name
                    TextString = "Bracket At Conveyor model"
                    Side = Camera.BracketAtDialTable
                Case btnTrainNewCenter.Name
                    TextString = "Center glass model"
                    Side = Camera.Center
                    'center
                Case btnTrainNewCenterVerify.Name
                    TextString = "Center Bracket Verify"
                    Side = Camera.BracketVerify
                Case btnTrainNewDriver.Name
                    TextString = "Driver glass model"
                    Side = Camera.Driver
                    'drive
                Case btnTrainNewPassenger.Name
                    TextString = "Passenger glass model"
                    Side = Camera.Passenger
                    'passenger
            End Select

            Snap(Side)
            Result = MsgBox("Are you sure you want To DELETE the " & TextString & vbCr &
                            "And create a New one In it's place?",
                            MsgBoxStyle.OkCancel Or MsgBoxStyle.SystemModal, "Are you Sure?")
            If Result = MsgBoxResult.Ok Then
                BtnTrain(False)
                HSLoc(Side).NewModelDatabase()
                HSLoc(Side).AddModel(CamLocation(Side))
                HSModel1 = HSLoc(Side).ShowModelEditor(False, CamLocation(Side))
                With HSModel1
                    .FeatureSelection = HSLOCATORLib.hsModelFeatureSelection.hsFeatureSelectionNone
                    .ContrastThresholdMode = HSLOCATORLib.hsContrastThresholdMode.hsContrastThresholdAdaptiveNormalSensitivity
                    .AutomaticLevels = True
                    RefPick.X = 0 : RefPick.Y = 0
                    .AddReferencePoint(RefPick.X, RefPick.Y)
                    .OriginPositionX = 0
                    .OriginPositionY = 0
                    .OriginRotation = 0
                    '  .DetailLevel = 2
                    .DisplayCalibrationMode = HSLOCATORLib.hsDisplayCalibrationMode.hsDisplayCalibrated
                    .BuildModel()
                    Me.Hide()
                    .ShowModal()
                    Me.Show()
                End With
                Select Case btn.Name
                    Case btnTrainNewBracketconveyor.Name
                        HSLoc(Side).SaveModelDatabase(ConfigPath & CamLocation(Side) & ".hdb")
                    Case btnTrainNewBracketTape.Name
                        HSLoc(Side).SaveModelDatabase(ConfigPath & CamLocation(Side) & ".hdb")
                    Case btnTrainNewBracketPrimer.Name
                        HSLoc(Side).SaveModelDatabase(ConfigPath & CamLocation(Side) & ".hdb")
                    Case btnTrainNewLocateGlass.Name
                        HSLoc(Side).SaveModelDatabase(CurrentFilePath & CamLocation(Side) & ".hdb")
                    Case btnTrainNewCenter.Name
                        HSLoc(Side).SaveModelDatabase(CurrentFilePath & CamLocation(Side) & ".hdb")
                    Case btnTrainNewCenterVerify.Name
                        HSLoc(Side).SaveModelDatabase(CurrentFilePath & CamLocation(Side) & ".hdb")
                    Case btnTrainNewDriver.Name
                        HSLoc(Side).SaveModelDatabase(CurrentFilePath & CamLocation(Side) & ".hdb")
                    Case btnTrainNewPassenger.Name
                        HSLoc(Side).SaveModelDatabase(CurrentFilePath & CamLocation(Side) & ".hdb")
                End Select
                HSLoc(Side).CompactMemory()
                HSModel1.Hide()
                Find(Side)
            End If
            INRoutine = False
            InTraining = False
            Exit Sub
        Catch ex As Exception
            MsgBox("Problem creating the model file" & vbCr & "You may need need to create the model" & vbCr & "through the Hexsight Interface" & vbCr &
                                    Err.Description, MsgBoxStyle.Critical Or MsgBoxStyle.SystemModal)
            INRoutine = False
            InTraining = False
        End Try
    End Sub
    Private Sub btnTrainExisting_Click(ByVal Sender As Object, ByVal eventArgs As System.EventArgs) Handles btnTrainExistingLocateGlass.Click, btnTrainExistingBracketConveyor.Click,
                    btnTrainExistingBracketTape.Click, btnTrainExistingCenter.Click, btnTrainExistingCenterVerify.Click, btnTrainExistingDriver.Click,
                    btnTrainExistingPassenger.Click, btnTrainExistingBracketPrimer.Click
        Dim btn As Button
        btn = DirectCast(Sender, Button)
        Dim HSModel As HSLOCATORLib.HSModelEditorInterface
        Dim Side As Int16
        Try
            InTraining = True
            Side = CurrentVisionTab
            Select Case btn.Name
                Case btnTrainExistingLocateGlass.Name
                    Side = Camera.LocateGlass
                Case btnTrainExistingBracketConveyor.Name
                    Side = Camera.BracketAtDialTable
                Case btnTrainExistingCenter.Name
                    Side = Camera.Center
                Case btnTrainExistingCenterVerify.Name
                    Side = Camera.BracketVerify
                Case btnTrainExistingDriver.Name
                    Side = Camera.Driver
                Case btnTrainExistingPassenger.Name
                    Side = Camera.Passenger
            End Select
            HSModel = HSLoc(Side).ShowModelEditor(False, CamLocation(Side))
            With HSModel
                .AutomaticLevels = False
                .DisplayCalibrationMode = HSLOCATORLib.hsDisplayCalibrationMode.hsDisplayCalibrated
                'Show the Model Editor
                .ShowModal()
            End With
            Select Case btn.Name
                Case btnTrainExistingBracketConveyor.Name
                    HSLoc(Side).SaveModelDatabase(ConfigPath & CamLocation(Side) & ".hdb")
                Case btnTrainExistingBracketTape.Name
                    HSLoc(Side).SaveModelDatabase(ConfigPath & CamLocation(Side) & ".hdb")
                Case btnTrainExistingBracketPrimer.Name
                    HSLoc(Side).SaveModelDatabase(ConfigPath & CamLocation(Side) & ".hdb")
                Case btnTrainExistingLocateGlass.Name
                    HSLoc(Side).SaveModelDatabase(CurrentFilePath & CamLocation(Side) & ".hdb")
                Case btnTrainExistingCenter.Name
                    HSLoc(Side).SaveModelDatabase(CurrentFilePath & CamLocation(Side) & ".hdb")
                Case btnTrainExistingCenterVerify.Name
                    HSLoc(Side).SaveModelDatabase(CurrentFilePath & CamLocation(Side) & ".hdb")
                Case btnTrainExistingDriver.Name
                    HSLoc(Side).SaveModelDatabase(CurrentFilePath & CamLocation(Side) & ".hdb")
                Case btnTrainExistingPassenger.Name
                    HSLoc(Side).SaveModelDatabase(CurrentFilePath & CamLocation(Side) & ".hdb")
            End Select
            HSModel.Hide()
            DelayTimer(100)
            Find(Side)
            InTraining = False
            Exit Sub
        Catch ex As Exception
            MsgBox("Problem accessing the model file" & vbCr & "You may need need to access the model" & vbCr &
                                                                                                "through the Hexsight Interface", MsgBoxStyle.Critical Or MsgBoxStyle.SystemModal)
            InTraining = False
        End Try
    End Sub
    Private Sub btnSnap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSnapLocateGlass.Click, btnSnapBracketConveyor.Click, btnSnapBracketTape.Click,
                    btnSnapCenter.Click, btnSnapCenterVerify.Click, btnSnapDriver.Click, btnSnapPassenger.Click
        Dim btn As Button
        btn = DirectCast(sender, Button)
        Try
            Select Case btn.Name
                Case btnSnapLocateGlass.Name
                    Do
                        Application.DoEvents()
                        Snap(Camera.LocateGlass)
                        Application.DoEvents()
                        If chkSnapRepeatLocateGlass.Checked Then DelayTimer(200)
                    Loop While chkSnapRepeatLocateGlass.Checked
                Case btnSnapCenterVerify.Name
                    HelperCamBracket.SetSimpleFeature("exposure", updnExposureCenterVerify.Value, Camera.BracketVerify)
                    HelperCamBracket.SetSimpleFeature("gain", updnContrastCenterVerify.Value, Camera.BracketVerify)
                    Snap(Camera.BracketVerify)
                    Do
                        Application.DoEvents()
                        Snap(Camera.BracketVerify)
                        Application.DoEvents()
                        If chkSnapRepeatBrackeyVerify.Checked Then DelayTimer(200)
                    Loop While chkSnapRepeatBrackeyVerify.Checked
                Case btnSnapBracketConveyor.Name
                    HelperCamBracket.SetSimpleFeature("exposure", updnExposureBracketConveyor.Value, Camera.BracketAtDialTable)
                    HelperCamBracket.SetSimpleFeature("gain", updnContrastBracketConveyor.Value, Camera.BracketAtDialTable)
                    Snap(Camera.BracketAtDialTable)
                    Do
                        Application.DoEvents()
                        Snap(Camera.BracketAtDialTable)
                        Application.DoEvents()
                        If chkSnapRepeatBracketconveyor.Checked Then DelayTimer(200)
                    Loop While chkSnapRepeatBracketconveyor.Checked
                Case btnSnapDriver.Name
                    Do
                        Application.DoEvents()
                        Snap(Camera.Driver)
                        Application.DoEvents()
                        If chkSnapRepeatDriver.Checked Then DelayTimer(200)
                    Loop While chkSnapRepeatDriver.Checked
                Case btnSnapCenter.Name
                    Do
                        Application.DoEvents()
                        Snap(Camera.Center)
                        Application.DoEvents()
                        If chkSnapRepeatCenter.Checked Then DelayTimer(200)
                    Loop While chkSnapRepeatCenter.Checked
                Case btnSnapPassenger.Name
                    Do
                        Application.DoEvents()
                        Snap(Camera.Passenger)
                        Application.DoEvents()
                        If chkSnapRepeatPassenger.Checked Then DelayTimer(200)
                    Loop While chkSnapRepeatPassenger.Checked
            End Select
        Catch ex As Exception
            ShowVBErrors("btnSnap_Click", ex.Message)
        End Try

    End Sub

    Private Sub GetReferencePoints()
        Dim HSModel As HSLOCATORLib.HSModelEditorInterface
        Select Case Side
            Case Camera.LocateGlass
                Try
                    HSModel = HSLoc(Camera.LocateGlass).ShowModelEditor(False, "Glass Locate")
                    HSModel.EndDialog(HSLOCATORLib.hsModelDialogResult.hsResultOK)
                Catch ex As Exception
                    MsgBox("Problem modifying the model file reference point" & vbCr & "You may need need to modify the model" & vbCr &
                                        "through the Hexsight Interface" & vbCr & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.SystemModal)
                End Try
            Case Camera.Driver
                Try
                    HSModel = HSLoc(Camera.Driver).ShowModelEditor(False, "Driver")
                    HSModel.EndDialog(HSLOCATORLib.hsModelDialogResult.hsResultOK)
                Catch ex As Exception
                    MsgBox("Problem modifying the model file reference point" & vbCr & "You may need need to modify the model" & vbCr &
                                        "through the Hexsight Interface" & vbCr & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.SystemModal)
                End Try
            Case Camera.Center
                Try
                    HSModel = HSLoc(Camera.Center).ShowModelEditor(False, "Center")
                    HSModel.EndDialog(HSLOCATORLib.hsModelDialogResult.hsResultOK)
                Catch ex As Exception
                    MsgBox("Problem modifying the model file reference point" & vbCr & "You may need need to modify the model" & vbCr &
                                        "through the Hexsight Interface" & vbCr & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.SystemModal)
                End Try
            Case Camera.Passenger
                Try
                    HSModel = HSLoc(Camera.Passenger).ShowModelEditor(False, "Passenger")
                    HSModel.EndDialog(HSLOCATORLib.hsModelDialogResult.hsResultOK)
                Catch ex As Exception
                    MsgBox("Problem modifying the model file reference point" & vbCr & "You may need need to modify the model" & vbCr &
                                        "through the Hexsight Interface" & vbCr & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.SystemModal)
                End Try
        End Select
    End Sub

    Public Sub btnMainRun(sender As Object, e As EventArgs) Handles btnMainRunGlassInspection.Click, btnMainRunDriverInspec.Click,
                        btnMainRunCenterInspec.Click, btnMainRunPassengerInspec.Click, btnMainRunBracketInspectionConveyor.Click, btnMainRunBracketInspectionTape.Click,
                        btnMainRunBracketVerify.Click, btnMainRunBracketInspectionPrimer.Click, btnMainRunTrademark.Click
        Try
            Dim button As Button
            button = DirectCast(sender, Button)
            Select Case button.Name
                Case btnMainRunBracketInspectionConveyor.Name
                    PLC_Bracket_DialTable_Location()
                Case btnMainRunGlassInspection.Name
                    PLC_Glass_Location()
                Case btnMainRunBracketVerify.Name
                    PLC_Glass_Location()
                    PLC_Vision_Camera_Verify()
                Case btnMainRunDriverInspec.Name
                    PLC_Check_Glass_Primer(button.Name)
                Case btnMainRunCenterInspec.Name
                    PLC_Check_H_Primer()
                Case btnMainRunPassengerInspec.Name
                    PLC_Check_Glass_Primer(button.Name)
                Case btnMainRunTrademark.Name
                    PLC_DriverCLX.Write("Vis_Cam_TM.Start", 1)
            End Select
        Catch ex As Exception
            ShowVBErrors("Main Run", ex.Message)
        End Try

    End Sub

    Private Sub SetReferencePoints()
        Dim HSModel As HSLOCATORLib.HSModelEditorInterface
        Select Case Side
            Case Camera.LocateGlass
                Try
                    HSModel = HSLoc(Camera.LocateGlass).ShowModelEditor(False, "Glass Locate")

                    With HSModel
                        Try
                            .ReferencePointPositionX(0) = 0
                            .ReferencePointPositionY(0) = 0
                        Catch
                        End Try
                    End With
                    HSModel.Apply()
                    HSModel.EndDialog(HSLOCATORLib.hsModelDialogResult.hsResultOK)
                    'Save Model Database
                    HSLoc(Camera.LocateGlass).SaveModelDatabase(CurrentFilePath & "Glass Locate.hdb")
                    HSLoc(Camera.LocateGlass).CompactMemory()
                    '
                Catch ex As Exception
                    MsgBox("Problem modifying the model file reference point" & vbCr &
                                                            "You may need need to modify the model" & vbCr &
                                                            "through the Hexsight Interface" & vbCr &
                                                            ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.SystemModal)
                End Try
            Case Camera.Driver
                Try
                    HSModel = HSLoc(Camera.Driver).ShowModelEditor(False, "Driver Locate")
                    With HSModel
                        Try
                            .ReferencePointPositionX(0) = 0
                            .ReferencePointPositionY(0) = 0
                        Catch
                        End Try
                    End With
                    HSModel.Apply()
                    HSModel.EndDialog(HSLOCATORLib.hsModelDialogResult.hsResultOK)
                    'Save Model Database
                    HSLoc(Camera.Driver).SaveModelDatabase(CurrentFilePath & "Driver Locate.hdb")
                    HSLoc(Camera.Driver).CompactMemory()
                    '
                Catch ex As Exception
                    MsgBox("Problem modifying the model file reference point" & vbCr &
                                                            "You may need need to modify the model" & vbCr &
                                                            "through the Hexsight Interface" & vbCr &
                                                            ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.SystemModal)
                End Try
            Case Camera.Center
                Try
                    HSModel = HSLoc(Camera.Center).ShowModelEditor(False, "Center Locate")
                    With HSModel
                        Try
                            .ReferencePointPositionX(0) = 0
                            .ReferencePointPositionY(0) = 0
                        Catch
                        End Try
                    End With
                    HSModel.Apply()
                    HSModel.EndDialog(HSLOCATORLib.hsModelDialogResult.hsResultOK)
                    'Save Model Database
                    HSLoc(Camera.Center).SaveModelDatabase(CurrentFilePath & "Center Locate.hdb")
                    HSLoc(Camera.Center).CompactMemory()
                    '
                Catch ex As Exception
                    MsgBox("Problem modifying the model file reference point" & vbCr &
                                                            "You may need need to modify the model" & vbCr &
                                                            "through the Hexsight Interface" & vbCr &
                                                            ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.SystemModal)
                End Try
            Case Camera.Passenger
                Try
                    HSModel = HSLoc(Camera.Passenger).ShowModelEditor(False, "Passenger Locate")
                    With HSModel
                        Try
                            .ReferencePointPositionX(0) = 0
                            .ReferencePointPositionY(0) = 0
                        Catch
                        End Try
                    End With
                    HSModel.Apply()
                    HSModel.EndDialog(HSLOCATORLib.hsModelDialogResult.hsResultOK)
                    'Save Model Database
                    HSLoc(Camera.Passenger).SaveModelDatabase(CurrentFilePath & "Passenger Locate.hdb")
                    HSLoc(Camera.Passenger).CompactMemory()
                    '
                Catch ex As Exception
                    MsgBox("Problem modifying the model file reference point" & vbCr &
                                                            "You may need need to modify the model" & vbCr &
                                                            "through the Hexsight Interface" & vbCr &
                                                            ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.SystemModal)
                End Try
            Case Camera.BracketAtDialTable
                Try
                    HSModel = HSLoc(Camera.BracketAtDialTable).ShowModelEditor(False, "Bracket Conveyor Locate")
                    With HSModel
                        Try
                            .ReferencePointPositionX(0) = 0
                            .ReferencePointPositionY(0) = 0
                        Catch
                        End Try
                    End With
                    HSModel.Apply()
                    HSModel.EndDialog(HSLOCATORLib.hsModelDialogResult.hsResultOK)
                    'Save Model Database
                    HSLoc(Camera.BracketAtDialTable).SaveModelDatabase(ConfigPath & "Bracket Conveyor Locate.hdb")
                    HSLoc(Camera.BracketAtDialTable).CompactMemory()
                    '
                Catch ex As Exception
                    MsgBox("Problem modifying the model file reference point" & vbCr &
                                                            "You may need need to modify the model" & vbCr &
                                                            "through the Hexsight Interface" & vbCr &
                                                            ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.SystemModal)
                End Try


        End Select
    End Sub

    Private Sub btnDetails_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnDetailsBracket.Click, btnDetailsDriver.Click,
                        btnDetailsCenter.Click, btnDetailsPassenger.Click, btnDetailsBracketConveyor.Click, btnDetailsBracketVerify.Click
        Dim MessageID As Short
        Dim Description As String = ""
        Try
            Select Case CurrentVisionTab
                Case Camera.LocateGlass
                    For MessageID = 0 To HSLoc(Camera.LocateGlass).MessageCount - 1
                        Description = Description & HSLoc(Camera.LocateGlass).MessageDescription(MessageID) & vbCr
                    Next MessageID
                    MsgBox(Description, MsgBoxStyle.OkOnly Or MsgBoxStyle.SystemModal)
                Case Camera.BracketAtDialTable
                    For MessageID = 0 To HSLoc(Camera.BracketAtDialTable).MessageCount - 1
                        Description = Description & HSLoc(Camera.BracketAtDialTable).MessageDescription(MessageID) & vbCr
                    Next MessageID
                    MsgBox(Description, MsgBoxStyle.OkOnly Or MsgBoxStyle.SystemModal)
                Case Camera.Driver
                    For MessageID = 0 To HSLoc(Camera.Driver).MessageCount - 1
                        Description = Description & HSLoc(Camera.Driver).MessageDescription(MessageID) & vbCr
                    Next MessageID
                    MsgBox(Description, MsgBoxStyle.OkOnly Or MsgBoxStyle.SystemModal)
                Case Camera.Center
                    For MessageID = 0 To HSLoc(Camera.Center).MessageCount - 1
                        Description = Description & HSLoc(Camera.Center).MessageDescription(MessageID) & vbCr
                    Next MessageID
                    MsgBox(Description, MsgBoxStyle.OkOnly Or MsgBoxStyle.SystemModal)
                Case Camera.Passenger
                    For MessageID = 0 To HSLoc(Camera.Passenger).MessageCount - 1
                        Description = Description & HSLoc(Camera.Passenger).MessageDescription(MessageID) & vbCr
                    Next MessageID
                    MsgBox(Description, MsgBoxStyle.OkOnly Or MsgBoxStyle.SystemModal)
                Case Camera.BracketVerify
                    For MessageID = 0 To HSLoc(Camera.BracketVerify).MessageCount - 1
                        Description = Description & HSLoc(Camera.BracketVerify).MessageDescription(MessageID) & vbCr
                    Next MessageID
                    MsgBox(Description, MsgBoxStyle.OkOnly Or MsgBoxStyle.SystemModal)
            End Select
        Catch ex As Exception
            ShowVBErrors("btnDetails", ex.Message)
        End Try
    End Sub
    Private Sub btnSearch_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnSearchSettingsLocateGlass.Click, btnSearchSettingsBracketConveyor.Click,
                        btnSearchSettingsBracketTape.Click, btnSearchSettingsCenter.Click, btnSearchSettingsCenterVerify.Click, btnSearchSettingsDriver.Click,
                        btnSearchSettingsPassenger.Click, btnSearchSettingsBracketPrimer.Click
        Dim btn As Button
        Side = CurrentVisionTab
        btn = DirectCast(eventSender, Button)
        Select Case btn.Name
            Case btnSearchSettingsLocateGlass.Name
                HSLoc(Camera.LocateGlass).ShowProperties(True, , 1 + 4 + 8 + 16)
            Case btnSearchSettingsBracketConveyor.Name
                HSLoc(Camera.BracketAtDialTable).ShowProperties(True, , 1 + 4 + 8 + 16)
            Case btnSearchSettingsCenter.Name
                HSLoc(Camera.Center).ShowProperties(True, , 1 + 4 + 8 + 16)
            Case btnSearchSettingsCenterVerify.Name
                HSLoc(Camera.BracketVerify).ShowProperties(True, , 1 + 4 + 8 + 16)
            Case btnSearchSettingsDriver.Name
                HSLoc(Camera.Driver).ShowProperties(True, , 1 + 4 + 8 + 16)
            Case btnSearchSettingsPassenger.Name
                HSLoc(Camera.Passenger).ShowProperties(True, , 1 + 4 + 8 + 16)
        End Select
        Try
            SaveHexsight()
        Catch ex As Exception
            ShowVBErrors("btnSearch", ex.Message)
        End Try
    End Sub
#End Region

#Region "Vision Routines"
    Private Function InitVision() As Boolean
        Dim Success As Boolean
        '  Dim SuccessGocator As Boolean

        Try
            'Load the vision database
            HSApp = frmSetupVision.ApplicationControl
            Success = HSApp.ProcessManager.LoadConfiguration(0, VisionDatabasePath)
            If Not Success Then
                MsgBox("Could Not locate the Vision Database:   " & vbCr & VisionDatabasePath & vbCr &
                                                                            "You need to locate this database yourself in the next dialog",
                                                                                    MsgBoxStyle.Critical, "Vision Database Load Error")
                HSApp.ProcessManager.LoadConfiguration(0, "")
            End If
            HSDb = HSApp.Database
            HSDb.AddView("Acquisition")
            'Glass Bracket Location
            ImageLocateGlass = HSDb.AddImage("Acquisition", "Image Locate Glass", HSCLASSLIBRARYLib.hsImageType.hsImage8bppGreyScale)
            ImageBracketVerify = HSDb.AddImage("Acquisition", "Image Bracket Verify", HSCLASSLIBRARYLib.hsImageType.hsImage8bppGreyScale)
            'Brack Conveyor 
            ImageBracketConveyor = HSDb.AddImage("Acquisition", "Image Bracket Conveyor", HSCLASSLIBRARYLib.hsImageType.hsImage8bppGreyScale)
            ImageBracketPrimer = HSDb.AddImage("Acquisition", "Image Bracket Primer", HSCLASSLIBRARYLib.hsImageType.hsImage8bppGreyScale)

            ImageBracketTape = HSDb.AddImage("Acquisition", "Image Bracket Tape", HSCLASSLIBRARYLib.hsImageType.hsImage8bppGreyScale)

            'Blob Locator Images
            ImageDriver = HSDb.AddImage("Acquisition", "Image Driver", HSCLASSLIBRARYLib.hsImageType.hsImage8bppGreyScale)
            ImageCenter = HSDb.AddImage("Acquisition", "Image Center", HSCLASSLIBRARYLib.hsImageType.hsImage8bppGreyScale)
            ImagePassenger = HSDb.AddImage("Acquisition", "Image Passenger", HSCLASSLIBRARYLib.hsImageType.hsImage8bppGreyScale)
            '
            CamLocation(Camera.LocateGlass) = "Glass Locate"
            CamLocation(Camera.Driver) = "Driver Locate"
            CamLocation(Camera.Center) = "Center Locate"
            CamLocation(Camera.Passenger) = "Passenger Locate"
            CamLocation(Camera.BracketAtDialTable) = "Bracket Conveyor Locate"
            CamLocation(Camera.BracketVerify) = "Bracket Verify"

            '
            ConfigName(Camera.LocateGlass) = "Locate Glass Config"
            ConfigName(Camera.Driver) = "Driver Side Blob Config"
            ConfigName(Camera.Center) = "Center Side Blob Config"
            ConfigName(Camera.Passenger) = "Passenger Side Blob Config"
            ConfigName(Camera.BracketAtDialTable) = "Bracket Conveyor Locate"
            ConfigName(Camera.BracketVerify) = "Center Bracket Verification"
            '
            'Assign Controls
            HSAcq = HSApp.ProcessManager.Process("Acquisition")
            HSLoc(Camera.LocateGlass) = HSApp.ProcessManager.Process("Glass Locate")
            HSLoc(Camera.BracketVerify) = HSApp.ProcessManager.Process("Bracket Verify")
            HSLoc(Camera.Driver) = HSApp.ProcessManager.Process("Driver Locate")
            HSLoc(Camera.Center) = HSApp.ProcessManager.Process("Center Locate")
            HSLoc(Camera.Passenger) = HSApp.ProcessManager.Process("Passenger Locate")
            HSLoc(Camera.BracketAtDialTable) = HSApp.ProcessManager.Process("Bracket Conveyor Locate")
            '
            Success = InitVisionDisplay()
            '
            Return Success
            Exit Function
        Catch ex As Exception
            MsgBox(Err.Description)
            ShowVBErrors("Init_Vision_Tools", Err.Description)
            Return False
        End Try
    End Function

    Public Function InitVisionDisplay() As Boolean
        Try
            With HSDisplayLocateGlass
                .Parent = grpHSDisplayGlassLocation
                .set_ImageName(0, ImageLocateGlass.Name)
                .set_SceneViewName(0, HSLoc(Camera.LocateGlass).OutputDetailSceneView)
                .set_SceneViewName(1, HSLoc(Camera.LocateGlass).OutputInstanceSceneView)
                .set_SceneName(2, "Instance Scene")
                .set_ScenePenWidth(0, HSDISPLAYLib.hsPenWidth.hsPenWidthThin)
                .set_ScenePenWidth(1, HSDISPLAYLib.hsPenWidth.hsPenWidthThin)
                .Left = 0
                .Top = 0
                .Width = grpHSDisplayGlassLocation.Width
                .Height = grpHSDisplayGlassLocation.Height
                .CalibratedUnitsEnabled = True
            End With
            With HSDisplayBracketConveyor
                .Parent = grpHSDisplayBracketConveyor
                .set_ImageName(0, ImageBracketConveyor.Name)
                .set_SceneViewName(0, HSLoc(Camera.BracketAtDialTable).OutputDetailSceneView)
                .set_SceneViewName(1, HSLoc(Camera.BracketAtDialTable).OutputInstanceSceneView)
                .set_SceneName(2, "Instance Scene")
                .set_ScenePenWidth(0, HSDISPLAYLib.hsPenWidth.hsPenWidthThin)
                .set_ScenePenWidth(1, HSDISPLAYLib.hsPenWidth.hsPenWidthThin)
                .Left = 0
                .Top = 0
                .Width = grpHSDisplayBracketConveyor.Width
                .Height = grpHSDisplayBracketConveyor.Height
                .CalibratedUnitsEnabled = True
            End With
            With HSDisplayCenterBracketVerify
                .Parent = grpHSDisplayBracketVerify
                .set_ImageName(0, ImageBracketVerify.Name)
                .set_SceneViewName(0, HSLoc(Camera.BracketVerify).OutputDetailSceneView)
                .set_SceneViewName(1, HSLoc(Camera.BracketVerify).OutputInstanceSceneView)
                .set_SceneName(2, "Instance Scene")
                .set_ScenePenWidth(0, HSDISPLAYLib.hsPenWidth.hsPenWidthThin)
                .set_ScenePenWidth(1, HSDISPLAYLib.hsPenWidth.hsPenWidthThin)
                .Left = 0
                .Top = 0
                .Width = grpHSDisplayBracketVerify.Width
                .Height = grpHSDisplayBracketVerify.Height
                .CalibratedUnitsEnabled = True
            End With
            With HSDisplayDriver
                .Parent = grpHSDisplayDriver
                .set_ImageName(0, ImageDriver.Name)
                .set_ScenePenWidth(0, HSDISPLAYLib.hsPenWidth.hsPenWidthThin)
                .Left = 0
                .Top = 0
                .Width = grpHSDisplayDriver.Width
                .Height = grpHSDisplayDriver.Height
                .CalibratedUnitsEnabled = True
            End With
            With HSDisplayCenter
                .Parent = grpHSDisplayCenter
                .set_ImageName(0, ImageCenter.Name)
                .set_SceneViewName(0, HSLoc(Camera.Center).OutputDetailSceneView)
                .set_SceneViewName(0, HSLoc(Camera.Center).OutputInstanceSceneView)
                '   .set_SceneName(2, "Instance Scene")
                .set_ScenePenWidth(0, HSDISPLAYLib.hsPenWidth.hsPenWidthThin)
                .Left = 0
                .Top = 0
                .Width = grpHSDisplayCenter.Width
                .Height = grpHSDisplayCenter.Height
                .CalibratedUnitsEnabled = True
            End With
            With HSDisplayPassenger
                .Parent = grpHSDisplayPassenger
                .set_ImageName(0, ImagePassenger.Name)
                .set_SceneViewName(0, HSLoc(Camera.Passenger).OutputDetailSceneView)
                .set_SceneViewName(0, HSLoc(Camera.Passenger).OutputInstanceSceneView)
                .set_SceneName(2, "Instance Scene")
                .set_ScenePenWidth(0, HSDISPLAYLib.hsPenWidth.hsPenWidthThin)
                .set_ScenePenWidth(1, HSDISPLAYLib.hsPenWidth.hsPenWidthThin)
                .Left = 0
                .Top = 0
                .Width = grpHSDisplayPassenger.Width
                .Height = grpHSDisplayPassenger.Height
                .CalibratedUnitsEnabled = True
            End With
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Sub SaveHexsight()
        Try
            Dim Status As Boolean
            Status = HSApp.ProcessManager.SaveConfiguration(0, VisionDatabasePath)
        Catch ex As Exception
            ShowVBErrors("SaveHexsight", ex.Message)
        End Try
    End Sub

    Private Sub CalibrateCam(ByRef Side As Short)
        Dim Yes As Short
        Try
            'Setup the calibration
            Yes = MsgBox("Please enusure a few items are set up before starting the camera calibration." & vbCr & vbCr &
                                                                "1.  Write down the existing exposure setting" & vbCr & "2.  Set the exposure slider so that the image Is crisp And white," & vbCr & vbCr &
                                                                "If you have already performed these steps then hit OK to continue, otherwise" & vbCr & "Hit Cancel to perform these few steps.",
                                                                MsgBoxStyle.OkCancel & MsgBoxStyle.SystemModal, "Setup the Calibration")
            If Yes <> MsgBoxResult.Ok Then
                Calibrating = False
                Exit Sub
            End If
            'Start the calibration
            Yes = MsgBox("The Calibration dialog will now appear after you close this dialog box," & vbCr & vbCr &
                                                                "The green directional pointer should be on the dot surrounded by dashed circle." & vbCr &
                                                                "The X And Y arrows should be pointing in the same direction as the X And Y arrows on calibration grid" & vbCr & vbCr &
                                                                "To verify the calibration" & vbCr &
                                                                "Copy the X And Y values in the (Axis Origin) boxes to the (World vs Image)World boxes And click on the right arrow." & vbCr &
                                                                "The test point should move to the center of hole with a black circle around it" & vbCr & vbCr &
                                                                "Hit OK Or Cancel to continue", MsgBoxStyle.OkCancel & MsgBoxStyle.SystemModal, "Calibration Starting")
            If Yes <> MsgBoxResult.Ok Then
                Calibrating = False
                Exit Sub
            End If
            '
            Select Case Side
                Case Camera.BracketAtDialTable
                    Calibrate = HSAcq.ShowCalibDistortionModelDialog(True, ConfigName(Camera.BracketAtDialTable))
                    With Calibrate
                        .DotPitch = 20
                        .WorldCoordinateSystemType = HSACQUISITIONDEVICELib.hsCoordinateSystemType.hsRightHanded
                        .MaximumDotRadius = 30
                        .MinimumDotRadius = 10
                        .UnitsLength = HSACQUISITIONDEVICELib.hsUnitsLength.hsMillimeter
                        .DotConformity = 0.7
                        .Show()
                    End With
                    Yes = MsgBox("Do you wish to save this calibration to disk?", MsgBoxStyle.YesNo)
                    If Yes = MsgBoxResult.Yes Then
                        HSAcq.SaveCalibration(ConfigName(Camera.BracketAtDialTable), CalibrationPath & "Bracket.Cal")
                        SaveHexsight()
                        MsgBox("Database Updated", MsgBoxStyle.SystemModal)
                    Else
                        MsgBox("Database Update Cancelled", MsgBoxStyle.SystemModal)
                    End If
                    Calibrating = False
                    Exit Sub
                Case Camera.LocateGlass
                    Calibrate = HSAcq.ShowCalibDistortionModelDialog(True, ConfigName(Camera.LocateGlass))
                    With Calibrate
                        .DotPitch = 20
                        .WorldCoordinateSystemType = HSACQUISITIONDEVICELib.hsCoordinateSystemType.hsRightHanded
                        .MaximumDotRadius = 30
                        .MinimumDotRadius = 10
                        .UnitsLength = HSACQUISITIONDEVICELib.hsUnitsLength.hsMillimeter
                        .DotConformity = 0.7
                        .Show()
                    End With
                    Yes = MsgBox("Do you wish to save this calibration to disk?", MsgBoxStyle.YesNo)
                    If Yes = MsgBoxResult.Yes Then
                        HSAcq.SaveCalibration(ConfigName(Camera.LocateGlass), CalibrationPath & "locate glass.Cal")
                        HSAcq.LoadCalibration(ConfigName(Camera.Center), CalibrationPath & "locate glass.cal") 'load into second display
                        HSAcq.LoadCalibration(ConfigName(Camera.BracketVerify), CalibrationPath & "locate glass.cal") 'load into second display
                        SaveHexsight()
                        MsgBox("Database Updated", MsgBoxStyle.SystemModal)
                    Else
                        MsgBox("Database Update Cancelled", MsgBoxStyle.SystemModal)
                    End If

                Case Camera.Driver
                    Calibrate = HSAcq.ShowCalibDistortionModelDialog(True, ConfigName(Camera.Driver))
                    With Calibrate
                        .DotPitch = 20
                        .WorldCoordinateSystemType = HSACQUISITIONDEVICELib.hsCoordinateSystemType.hsRightHanded
                        .MaximumDotRadius = 30
                        .MinimumDotRadius = 10
                        .UnitsLength = HSACQUISITIONDEVICELib.hsUnitsLength.hsMillimeter
                        .DotConformity = 0.7
                        .Show()
                    End With
                    Yes = MsgBox("Do you wish to save this calibration to disk?", MsgBoxStyle.YesNo)
                    If Yes = MsgBoxResult.Yes Then
                        HSAcq.SaveCalibration(ConfigName(Camera.Driver), CalibrationPath & "DriverCam.Cal")
                        SaveHexsight()
                        MsgBox("Database Updated", MsgBoxStyle.SystemModal)
                    Else
                        MsgBox("Database Update Cancelled", MsgBoxStyle.SystemModal)
                    End If

                Case Camera.Passenger
                    Calibrate = HSAcq.ShowCalibDistortionModelDialog(True, ConfigName(Camera.Passenger))
                    With Calibrate
                        .DotPitch = 20
                        .WorldCoordinateSystemType = HSACQUISITIONDEVICELib.hsCoordinateSystemType.hsRightHanded
                        .MaximumDotRadius = 30
                        .MinimumDotRadius = 10
                        .UnitsLength = HSACQUISITIONDEVICELib.hsUnitsLength.hsMillimeter
                        .DotConformity = 0.7
                        .Show()
                    End With
                    Yes = MsgBox("Do you wish to save this calibration to disk?", MsgBoxStyle.YesNo)
                    If Yes = MsgBoxResult.Yes Then
                        HSAcq.SaveCalibration(ConfigName(Camera.Passenger), CalibrationPath & "PassCam.Cal")
                        SaveHexsight()
                        MsgBox("Database Updated", MsgBoxStyle.SystemModal)
                    Else
                        MsgBox("Database Update Cancelled", MsgBoxStyle.SystemModal)
                    End If
            End Select
            Calibrating = False
            System.Windows.Forms.Application.DoEvents()
        Catch ex As Exception
            ShowVBErrors("CalibrateCam", ex.Message)
        End Try
    End Sub

    Public Sub btnLocate_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnLocateLocateGlass.Click, btnLocateOnlyLocateGlass.Click,
        btnLocateBracketConveyor.Click, btnLocateBracketTape.Click, btnLocateBracketVerify.Click, btnLocateCenter.Click, btnLocateDriver.Click,
        btnLocatePassenger.Click, btnLocateOnlyDriver.Click, btnLocateOnlyCenter.Click, btnLocateOnlyPassenger.Click, btnLocateOnlyBracketConveyor.Click,
        btnLocateOnlyBracketTape.Click, btnLocateOnlyBracketVerify.Click, btnLocateBracketPrimer.Click, btnLocateOnlyBracketPrimer.Click
        Dim btn As Button
        btn = DirectCast(eventSender, Button)
        Try
            'Locate With Snap button clicked
            Select Case btn.Name
                Case btnLocateLocateGlass.Name
                    Do
                        Locate(Camera.LocateGlass, True)
                        If chkLocateRepeatLocateGlass.Checked Then DelayTimer(1000)
                    Loop While chkLocateRepeatLocateGlass.Checked
                Case btnLocateDriver.Name
                    Do
                        Locate(Camera.Driver, True, True)
                        If chkLocateDriver.Checked Then DelayTimer(1000)
                    Loop While chkLocateDriver.Checked
                Case btnLocateCenter.Name
                    Do
                        Locate(Camera.Center, True, True)
                        If chkLocateCenter.Checked Then DelayTimer(1000)
                    Loop While chkLocateCenter.Checked
                Case btnLocatePassenger.Name
                    Do
                        Locate(Camera.Passenger, True, True)
                        If chkLocatePassenger.Checked Then DelayTimer(1000)
                    Loop While chkLocatePassenger.Checked
                Case btnLocateBracketConveyor.Name
                    Do
                        Locate(Camera.BracketAtDialTable, True)
                        If chkLocateBracketConveyor.Checked Then DelayTimer(1000)
                    Loop While chkLocateBracketConveyor.Checked
                Case btnLocateBracketVerify.Name
                    Do
                        Locate(Camera.BracketVerify, True)
                        If chkLocateGlassVerify.Checked Then DelayTimer(1000)
                    Loop While chkLocateGlassVerify.Checked
                Case btnLocateOnlyLocateGlass.Name
                    Do
                        Locate(Camera.LocateGlass, False)
                        If chkLocateRepeatLocateGlass.Checked Then DelayTimer(1000)
                    Loop While chkLocateRepeatLocateGlass.Checked
                Case btnLocateOnlyDriver.Name
                    Do
                        Locate(Camera.Driver, False)
                        If chkLocateDriver.Checked Then DelayTimer(1000)
                    Loop While chkLocateDriver.Checked
                Case btnLocateOnlyCenter.Name
                    Do
                        Locate(Camera.Center, False)
                        If chkLocateDriver.Checked Then DelayTimer(1000)
                    Loop While chkLocateDriver.Checked
                Case btnLocateOnlyBracketConveyor.Name
                    Do
                        Locate(Camera.BracketAtDialTable, False)
                        If chkLocateBracketConveyor.Checked Then DelayTimer(1000)
                    Loop While chkLocateBracketConveyor.Checked
                Case btnLocateOnlyBracketTape.Name
                    Do
                        Locate(Side, False)
                        If chkLocateBracketTape.Checked Then DelayTimer(1000)
                    Loop While chkLocateBracketTape.Checked
                Case btnLocateOnlyBracketVerify.Name
                    Do
                        Locate(Camera.BracketVerify, False)
                        If chkLocateGlassVerify.Checked Then DelayTimer(1000)
                    Loop While chkLocateGlassVerify.Checked
            End Select
        Catch ex As Exception
            ShowVBErrors("btnLocate", ex.Message)
        End Try
    End Sub

    Public Function Locate(ByVal Side As Int16, ByVal NewPicture As Boolean, Optional ByVal CheckBlob As Boolean = False) As Boolean
        Dim StartTimer As Single 'timer
        Dim InRoutine As Boolean 'in the current routine
        Dim BlobValu As String = "BlobValu" ' Blob Value
        Try
            If InRoutine Then
                Return False
                Exit Function
            End If
            InRoutine = True
            Locate = False
            Select Case Side
                '
                'Locate Glass for Placement
                Case Camera.LocateGlass
                    ClearPositionData(0)
                    btnLocateLocateGlass.Enabled = False
                    btnLocateOnlyLocateGlass.Enabled = False
                    If NewPicture Then Snap(Camera.LocateGlass)
                    StartTimer = VB.Timer
                    Find(Side)
                    btnLocateLocateGlass.Enabled = True
                    btnLocateOnlyLocateGlass.Enabled = True
                    HSDisplayLocateGlass.Refresh()
                    lblVisionPoseTimeBracket.Text = (VB.Timer - StartTimer).ToString("N2") & " Secs."
                    '
                    'Locate Arron Mighty on Driver
                Case Camera.Driver
                    If NewPicture Then Snap(Camera.Driver)
                    StartTimer = VB.Timer
                    Find(Side)
                    If CheckBlob Then
                        DriverBlobArea = Blob(Camera.Driver, "Driver Blob", "Driver Locate")
                        If DriverBlobArea > 0 Then
                            If (DriverBlobArea > DriverBlobVariance) Then
                                lblDriverInspection.BackColor = Color.YellowGreen
                            Else
                                lblDriverInspection.BackColor = Color.Red
                                lblVisionMessageDriver.Text = "Primer Area Below Threshold levels"
                                lblVisionMessageDriver.BackColor = Color.Red
                                Return False
                            End If
                        Else
                            lblVisionMessageDriver.BackColor = Color.Red
                            Return False
                        End If
                    End If
                    btnLocateDriver.Enabled = True
                    btnLocateOnlyDriver.Enabled = True
                    HSDisplayDriver.Refresh()
                    lblVisionPoseTimeDriver.Text = (VB.Timer - StartTimer).ToString("N2") & " Secs."
                    '
                    'Locate Center H Primer
                Case Camera.Center
                    If NewPicture Then Snap(Camera.Center)
                    StartTimer = VB.Timer
                    Find(Side)
                    If CheckBlob Then '
                        CenterBlobArea = Blob(Camera.Center, "Center Blob", "Center Locate")
                        DrawBlobRectangles("Center Blob")
                        If CenterBlobArea > 0 Then
                            ' CenterBlobVariance = SavedCenterBlobArea * (0.01 * trkCenterBlob.Value)
                            If (CenterBlobArea > CenterBlobVariance) Then
                                lblCenterInspection.BackColor = Color.YellowGreen
                            Else
                                lblCenterInspection.BackColor = Color.Red
                                lblVisionMessageCenter.Text = "Primer Area Below Threshold levels"
                                lblVisionMessageCenter.BackColor = Color.Red
                                Return False
                            End If
                        Else
                            lblCenterInspection.BackColor = Color.Red
                            Return False
                        End If
                    End If
                    btnLocateCenter.Enabled = True
                    btnLocateOnlyCenter.Enabled = True
                    HSDisplayCenter.Refresh()
                    lblVisionPoseTimeCenter.Text = (VB.Timer - StartTimer).ToString("N2") & " Secs."
                    '
                    'Locate Passenger Arron Mighty
                Case Camera.Passenger
                    If NewPicture Then Snap(Camera.Passenger)
                    StartTimer = VB.Timer
                    Find(Side)
                    If CheckBlob Then
                        PassengerBlobArea = Blob(Camera.Passenger, "Passenger Blob", "Passenger Locate")
                        DrawBlobRectangles("Passenger Blob")
                        If PassengerBlobArea > 0 Then
                            ' PassengerBlobVariance = SavedPassengerBlobArea * (0.01 * trkPassengerBlob.Value)
                            If (PassengerBlobArea >= (PassengerBlobVariance)) Then
                                lblPassengerInspection.BackColor = Color.YellowGreen
                            Else
                                lblPassengerInspection.BackColor = Color.Red
                                lblVisionMessagePassenger.Text = "Primer Area Below Threshold levels"
                                lblVisionMessagePassenger.BackColor = Color.Red
                                Return False
                            End If
                        Else
                            lblPassengerInspection.BackColor = Color.Red
                            Return False
                        End If
                    End If
                    btnLocatePassenger.Enabled = True
                    btnLocateOnlyPassenger.Enabled = True
                    HSDisplayPassenger.Refresh()
                    lblVisionPoseTimePassenger.Text = (VB.Timer - StartTimer).ToString("N2") & " Secs."
                    '
                    'Locate Bracket at Dial Table
                Case Camera.BracketAtDialTable
                    ClearPositionData(1)
                    btnLocateBracketConveyor.Enabled = False
                    btnLocateOnlyBracketConveyor.Enabled = False
                    If NewPicture Then Snap(Camera.BracketAtDialTable)
                    StartTimer = VB.Timer
                    Find(Side)
                    btnLocateBracketConveyor.Enabled = True
                    btnLocateOnlyBracketConveyor.Enabled = True
                    HSDisplayBracketConveyor.Refresh()
                    lblVisionPoseTimeBracketConveyor.Text = (VB.Timer - StartTimer).ToString("N2") & " Secs."
                    '
                    'Verify Bracket Location on Glass
                Case Camera.BracketVerify
                    lblVisionMessageBracketVerify.BackColor = SystemColors.Control
                    lblVisionMessageBracketVerify.Text = ""
                    btnLocateBracketVerify.Enabled = False
                    btnLocateOnlyBracketVerify.Enabled = False
                    If NewPicture Then Snap(Camera.BracketVerify)
                    StartTimer = VB.Timer
                    Find(Side)
                    lblVerifyBottomLeft.Text = FormatNumber(RefVerify0.Y - RefLocate0.Y, 1)
                    lblVerifyBottomRight.Text = FormatNumber(RefVerify1.Y - RefLocate1.Y, 1)
                    lblVerifyTopRight.Text = FormatNumber(RefLocate2.X - RefVerify2.X, 1)
                    Dim BottomLeftDiff As Single = (RefVerify0.Y - RefLocate0.Y) - CDec(txtVerifySavedDiffBottomLeft.Text)
                    lblBottomLeftDifference.Text = FormatNumber(BottomLeftDiff, 1)
                    Dim BottomRightDiff As Single = (RefVerify1.Y - RefLocate1.Y) - CSng(txtVerifySavedDiffBottomRight.Text)
                    lblBottomRightDifference.Text = FormatNumber(BottomRightDiff, 1)
                    Dim TopRightDiff As Single = (RefLocate2.X - RefVerify2.X) - CSng(txtVerifySavedDiffTopRight.Text)
                    lblTopRighttDifference.Text = FormatNumber(TopRightDiff, 1)
                    Try
                        If mnuSaveVerification.Checked Then
                            'TODO clean up or replace this HTML code. we dont need multiple colors and font sizes.
                            If File.Exists("E:\Reports\Verification.htm") Then
                                Dim FileText As String
                                FileText = "<tr><center><font color=black><b><td><center>" & Date.Now & "</td></center><center><td>" & PartName & "</center></td>" & "<td><center>" & FormatNumber(RefVerify0.Y - RefLocate0.Y, 2) & "</center></td>" & "<td><center>" & FormatNumber(RefVerify1.Y - RefLocate1.Y, 2) & "</center></td>" & "<td><center>" & FormatNumber(RefLocate2.X - RefVerify2.X, 2) & "</center></td><b></font></tr>"
                                File.AppendAllText("E:\Reports\Verification.htm", FileText & vbCrLf)
                            Else
                                Dim FileText As String
                                FileText = "<html><body bgcolor=palegoldenrod>" & vbCrLf & "<table style=width:100%><center><font size=8><b><i><font color=red>Midwest Motion</i></b></font></font></center><br></br><center><font size=4>921 Park Street</font></center><br></br><center><font size = 4>Evansville,IN 47710</font></center><br></br><center><font size = 4>888-774-5306</font></center><br></br>"
                                File.AppendAllText("E:\Reports\Verification.htm", FileText & vbCrLf)
                                FileText = "<center><font color=black><b><tr>" & "<th>Time</th>" & "<th>Part Name</th>" & "<th>Bottom Left Difference</th>" & "<th>Bottom Right Difference</th>" & "<th>Top Right Difference</th></tr>" & "</center><b></font><br></br><br></br>"
                                File.AppendAllText("E:\Reports\Verification.htm", FileText & vbCrLf)
                                FileText = "<center><font color=black><b><td><center>" & Date.Now & "</td></center><center><td>" & PartName & "</center></td>" & "<td><center>" & FormatNumber(RefVerify0.Y - RefLocate0.Y, 2) & "</center></td>" & "<td><center>" & FormatNumber(RefVerify1.Y - RefLocate1.Y, 2) & "</center></td>" & "<td><center>" & FormatNumber(RefLocate2.X - RefVerify2.X, 2) & "</center></td><b></font><br></br>" & vbCrLf & " "
                                File.AppendAllText("E:\Reports\Verification.htm", FileText & vbCrLf)
                            End If
                        End If
                    Catch ex As Exception
                        ShowVBErrors("Log File Is open unable To write", ex.Message)
                    End Try
                    Dim Passed(2) As Boolean
                    If Math.Abs(BottomLeftDiff) < updnBottomLeftVerifyVariance.Value Then
                        lblBottomLeftDifference.BackColor = SystemColors.Control
                        Passed(0) = True
                    Else
                        lblBottomLeftDifference.BackColor = Color.Red
                        Passed(0) = False
                    End If
                    If Math.Abs(BottomRightDiff) < updnBottomRightVerifyVariance.Value Then
                        lblBottomRightDifference.BackColor = SystemColors.Control
                        Passed(1) = True
                    Else
                        lblBottomRightDifference.BackColor = Color.Red
                        Passed(1) = False
                    End If
                    If Math.Abs(TopRightDiff) < updnTopRightVerifyVariance.Value Then
                        lblTopRighttDifference.BackColor = SystemColors.Control
                        Passed(2) = True
                    Else
                        lblTopRighttDifference.BackColor = Color.Red
                        Passed(2) = False
                    End If
                    For i As Int16 = 0 To 2
                        Dim BracketName(2) As String
                        BracketName(0) = "Bottom Left"
                        BracketName(1) = "Bottom Right"
                        BracketName(2) = "Top Right"
                        If Passed(i) = False Then
                            lblVisionMessageBracketVerify.BackColor = Color.Red
                            lblVisionMessageBracketVerify.Text = BracketName(i) & " Placement was out Of bounds"
                            btnLocateBracketVerify.Enabled = True
                            btnLocateOnlyBracketVerify.Enabled = True
                            HSDisplayCenterBracketVerify.Refresh()
                            lblVisionPoseTimeBracketVerify.Text = (VB.Timer - StartTimer).ToString("N2") & " Secs."
                            Return False
                        End If
                    Next
                    btnLocateBracketVerify.Enabled = True
                    btnLocateOnlyBracketVerify.Enabled = True
                    HSDisplayCenterBracketVerify.Refresh()
                    lblVisionPoseTimeBracketVerify.Text = (VB.Timer - StartTimer).ToString("N2") & " Secs."
            End Select
            If LocatorResults(Side).Status = 1 Then
                Return True
            Else
                Return False
            End If
            ' Return True
            InRoutine = False
        Catch ex As Exception
            ShowVBErrors("Locate", ex.Message)
            InRoutine = False
            Return False
        End Try
    End Function

    Public Sub Snap(ByVal Side As Int16)
        'snaps a picture of the glass
        Dim StartTimer As Single
        Dim InRoutine As Boolean
        Dim Display As Object
        If InRoutine Then Exit Sub
        Dim TempString As String = ""
        Try
            InRoutine = True
            '
            'Measure the process time
            StartTimer = VB.Timer()
            '
            'Setup the Display and the Camera to use
            HSAcq.ConfigurationDefault = ConfigName(Side)
            '
            Select Case Side
                Case Camera.LocateGlass
                    Display = HSDisplayLocateGlass
                    Display.RefreshDisplay()
                    ImageLocateGlass.BackgroundColor = 60
                    ImageLocateGlass.Render()
                    btnSnapLocateGlass.Enabled = False
                    'Snap the picture, try 2nd time if unsuccessful
                    If Not GetCameraImage(Side) Then GetCameraImage(Side)
                    HSDisplayLocateGlass.RefreshDisplay()
                    btnSnapLocateGlass.Enabled = True
                    lblCameraTime.Text = (VB.Timer - StartTimer).ToString("N2") & " Secs."
                Case Camera.Driver
                    Display = HSDisplayDriver
                    Display.RefreshDisplay()
                    btnSnapDriver.Enabled = False
                    'Snap the picture, try 2nd time if unsuccessful
                    If Not GetCameraImage(Side) Then GetCameraImage(Side)
                    HSDisplayDriver.RefreshDisplay()
                    HSDisplayDriver.RefreshDisplay()
                    HSDisplayDriver.RefreshDisplay()
                    btnSnapDriver.Enabled = True
                    lblCameraTimeDriver.Text = (VB.Timer - StartTimer).ToString("N2") & " Secs."
                Case Camera.Center
                    Display = HSDisplayCenter
                    Display.RefreshDisplay()
                    btnSnapCenter.Enabled = False
                    'Snap the picture, try 2nd time if unsuccessful
                    If Not GetCameraImage(Side) Then GetCameraImage(Side)
                    HSDisplayDriver.RefreshDisplay()
                    btnSnapCenter.Enabled = True
                    lblCameraTimeCenter.Text = (VB.Timer - StartTimer).ToString("N2") & " Secs."
                Case Camera.Passenger
                    Display = HSDisplayPassenger
                    Display.RefreshDisplay()
                    btnSnapPassenger.Enabled = False
                    'Snap the picture, try 2nd time if unsuccessful
                    If Not GetCameraImage(Side) Then GetCameraImage(Side)
                    HSDisplayDriver.RefreshDisplay()
                    btnSnapPassenger.Enabled = True
                    lblCameraTimePassenger.Text = (VB.Timer - StartTimer).ToString("N2") & " Secs."
                Case Camera.BracketAtDialTable
                    Display = HSDisplayBracketConveyor
                    '  Display.RefreshDisplay()
                    '  HSDisplayBracketConveyor.Refresh()
                    btnSnapBracketConveyor.Enabled = False
                    'Snap the picture, try 2nd time if unsuccessful
                    If Not GetCameraImage(Side) Then GetCameraImage(Side)
                    HSDisplayBracketConveyor.RefreshDisplay()
                    btnSnapBracketConveyor.Enabled = True
                    lblCameraTimeBracketConveyor.Text = (VB.Timer - StartTimer).ToString("N2") & " Secs."
                Case Camera.BracketVerify
                    Display = HSDisplayCenterBracketVerify
                    Display.RefreshDisplay()
                    btnSnapCenterVerify.Enabled = False
                    'Snap the picture, try 2nd time if unsuccessful
                    If Not GetCameraImage(Side) Then GetCameraImage(Side)
                    HSDisplayCenterBracketVerify.RefreshDisplay()
                    btnSnapCenterVerify.Enabled = True
                    lblCameraTimeBracketVerify.Text = (VB.Timer - StartTimer).ToString("N2") & " Secs."
            End Select
            'Snap the picture
            GC.Collect()
            HSAcq.Execute()
            '  Application.DoEvents()
            InRoutine = False
        Catch ex As Exception
            ShowVBErrors("Snap" & " " & Side, ex.Message)
        End Try
    End Sub

    Private Sub resetLabels()
        lblBracketInspection.BackColor = System.Drawing.SystemColors.Control
        lblBracketConveyorCameraWarning.BackColor = System.Drawing.SystemColors.Control
        lblBracketInspectionVerify.BackColor = System.Drawing.SystemColors.Control
        lblDriverInspection.BackColor = System.Drawing.SystemColors.Control
        lblCenterInspection.BackColor = System.Drawing.SystemColors.Control
        lblPassengerInspection.BackColor = System.Drawing.SystemColors.Control
        lblBracketInspectionConveyor.BackColor = System.Drawing.SystemColors.Control
        lblBracketInspectionTape.BackColor = System.Drawing.SystemColors.Control
        lblGlueApplication.BackColor = System.Drawing.SystemColors.Control
        lblBracketInspectionPrimer.BackColor = System.Drawing.SystemColors.Control
    End Sub

    Public Sub SaveAreas(sender As Object, e As EventArgs) Handles btnSaveDriverBlobArea.Click, btnSaveCenterBlobArea.Click, btnSavePassengerBlobArea.Click
        Try
            Dim Butt As Button
            Butt = DirectCast(sender, Button)
            Select Case Butt.Name
                Case btnSaveDriverBlobArea.Name
                    HSApp.ProcessManager.Execute("Driver Locate", "Driver Locate")
                    HSApp.ProcessManager.Execute("Driver Blob", "Driver Blob")
                    HSBlob = HSApp.ProcessManager.Process("Driver Blob")
                    SavedDriverBlobArea = HSBlob.BlobArea(0)
                    frmDataBase.SetValue("Partdata", "Value", "Driver Blob Area", CStr(SavedDriverBlobArea))
                    frmDataBase.SetValue("Partdata", "Value", "Driver Blob Variance", trkDriverBlob.Value)
                    lblDriverBlobArea.Text = "Saved Area: " & SavedDriverBlobArea
                Case btnSaveCenterBlobArea.Name
                    HSApp.ProcessManager.Execute("Center Locate", "Center Locate")
                    HSApp.ProcessManager.Execute("Center Blob", "Center Blob")
                    HSBlob = HSApp.ProcessManager.Process("Center Blob")
                    SavedCenterBlobArea = HSBlob.BlobArea(0)
                    frmDataBase.SetValue("Partdata", "Value", "Center Blob Area", CStr(SavedCenterBlobArea))
                    frmDataBase.SetValue("Partdata", "Value", "Center Blob Variance", trkCenterBlob.Value)
                    lblCenterBlobArea.Text = "Saved Area: " & SavedCenterBlobArea
                Case btnSavePassengerBlobArea.Name
                    HSApp.ProcessManager.Execute("Passenger Locate", "Passenger Locate")
                    HSApp.ProcessManager.Execute("Passenger Blob", "Passenger Blob")
                    HSBlob = HSApp.ProcessManager.Process("Passenger Blob")
                    SavedPassengerBlobArea = HSBlob.BlobArea(0)
                    frmDataBase.SetValue("Partdata", "Value", "Passenger Blob Area", CStr(SavedPassengerBlobArea))
                    frmDataBase.SetValue("Partdata", "Value", "Passenger Blob Variance", trkPassengerBlob.Value)
                    lblPassengerBlobArea.Text = "Saved Area: " & SavedPassengerBlobArea
            End Select
        Catch ex As Exception
            ShowVBErrors("Save Train", ex.Message)
        End Try
    End Sub

    Private Function Blob(ByVal Side As Int32, ByRef BlobName As String, Locator As String, Optional Blobindex As Int16 = 0, Optional BlobNum As Int16 = 1) As Integer
        Try
            HSApp.ProcessManager.Execute(Locator, Locator)
            'HSApp.ProcessManager.Execute(BlobName, BlobName)
            HSBlob = HSApp.ProcessManager.Process(BlobName)
            'Set the upper and lower threshold limits for each blob
            Select Case Side
                Case Camera.Driver
                    HSBlob.SegmentationInside(HSBLOBANALYZERLib.hsSegmentationInsidePoint.hsInsideBottomLeft) = updnDriverBlobThresholdMin.Value
                    HSBlob.SegmentationInside(HSBLOBANALYZERLib.hsSegmentationInsidePoint.hsInsideTopLeft) = updnDriverBlobThresholdMin.Value
                    HSBlob.SegmentationInside(HSBLOBANALYZERLib.hsSegmentationInsidePoint.hsInsideBottomRight) = updnDriverBlobThresholdMax.Value
                    HSBlob.SegmentationInside(HSBLOBANALYZERLib.hsSegmentationInsidePoint.hsInsideTopRight) = updnDriverBlobThresholdMax.Value
                    lblDriverCurrentBlobArea.Text = "0"
                    HSBlob.Execute()
                    DrawBlobRectangles(BlobName)
                    Try
                        If HSBlob.BlobArea(0) = vbNullString Then
                            Return 0
                            Exit Function
                        End If
                    Catch ex As Exception
                        lblVisionMessageDriver.Text = "No Primer was Found"
                        lblVisionMessageDriver.BackColor = Color.Red
                        Return 0
                    End Try
                Case Camera.Center
                    HSBlob.SegmentationInside(HSBLOBANALYZERLib.hsSegmentationInsidePoint.hsInsideBottomLeft) = updnCenterBlobThresholdMin.Value
                    HSBlob.SegmentationInside(HSBLOBANALYZERLib.hsSegmentationInsidePoint.hsInsideTopLeft) = updnCenterBlobThresholdMin.Value
                    HSBlob.SegmentationInside(HSBLOBANALYZERLib.hsSegmentationInsidePoint.hsInsideBottomRight) = updnCenterBlobThresholdMax.Value
                    HSBlob.SegmentationInside(HSBLOBANALYZERLib.hsSegmentationInsidePoint.hsInsideTopRight) = updnCenterBlobThresholdMax.Value
                    lblCenterCurrentBlobArea.Text = "0"
                    HSBlob.Execute()
                    DrawBlobRectangles(BlobName)
                    Try
                        If HSBlob.BlobArea(0) = vbNullString Then
                            Return 0
                            Exit Function
                        End If
                    Catch ex As Exception
                        lblVisionMessageCenter.Text = "No Primer was Found"
                        lblVisionMessageCenter.BackColor = Color.Red
                        Return 0
                    End Try
                Case Camera.Passenger
                    HSBlob.SegmentationInside(HSBLOBANALYZERLib.hsSegmentationInsidePoint.hsInsideBottomLeft) = updnPassengerBlobThresholdMin.Value
                    HSBlob.SegmentationInside(HSBLOBANALYZERLib.hsSegmentationInsidePoint.hsInsideTopLeft) = updnPassengerBlobThresholdMin.Value
                    HSBlob.SegmentationInside(HSBLOBANALYZERLib.hsSegmentationInsidePoint.hsInsideBottomRight) = updnPassengerBlobThresholdMax.Value
                    HSBlob.SegmentationInside(HSBLOBANALYZERLib.hsSegmentationInsidePoint.hsInsideTopRight) = updnPassengerBlobThresholdMax.Value
                    lblPassengerCurrentBlobArea.Text = "0"
                    HSBlob.Execute()
                    DrawBlobRectangles(BlobName)
                    Try
                        If HSBlob.BlobArea(0) = vbNullString Then
                            Return 0
                            Exit Function
                        End If
                    Catch ex As Exception
                        lblVisionMessagePassenger.Text = "No Primer was Found"
                        lblVisionMessagePassenger.BackColor = Color.Red
                        Return 0
                    End Try
            End Select
            'verify that blob area is not equal to zero if so return a 0 
            'count the number of blobs we have for the current image
            If HSBlob.BlobCount > 0 Then
                For i As Int16 = 0 To HSBlob.BlobCount - 1
                    Select Case Side
                        Case Camera.Driver
                            lblDriverCurrentBlobArea.Text = HSBlob.BlobArea(0)
                            With HSDisplayDriver
                                .set_ImagePalette(1, HSDISPLAYLib.hsImagePalette.hsPaletteNone)
                                .set_ImagePaletteType(0, HSDISPLAYLib.hsImagePaletteType.hsPaletteTypeColor1)
                                .set_ImagePaletteColor(0, 0, RGB(255, 128, 0))
                                .set_ImagePalette(1, HSDISPLAYLib.hsImagePalette.hsPalette0)
                                .set_ImageDatabase(1, HSApp.Database.Handle)
                                .set_ImageViewName(1, HSBlob.OutputBlobView)
                                .set_ImageName(1, HSBlob.OutputBlobImage)
                            End With
                        Case Camera.Center
                            'Add all the blobs together
                            Dim BlobCount As Integer = HSBlob.BlobCount
                            Dim Count As Integer = 0
                            Dim TotalArea As Single = 0
                            For Count = 0 To BlobCount - 1
                                TotalArea += HSBlob.BlobArea(Count)
                            Next Count
                            lblCenterCurrentBlobArea.Text = TotalArea
                            'Display the Blobs
                            With HSDisplayCenter
                                .set_ImagePalette(1, HSDISPLAYLib.hsImagePalette.hsPaletteNone)
                                .set_ImagePaletteType(0, HSDISPLAYLib.hsImagePaletteType.hsPaletteTypeColor1)
                                .set_ImagePaletteColor(0, 0, RGB(255, 128, 0))
                                .set_ImagePalette(1, HSDISPLAYLib.hsImagePalette.hsPalette0)
                                .set_ImageDatabase(1, HSApp.Database.Handle)
                                .set_ImageViewName(1, HSBlob.OutputBlobView)
                                .set_ImageName(1, HSBlob.OutputBlobImage)
                            End With
                            Return CInt(TotalArea)
                        Case Camera.Passenger
                            lblPassengerCurrentBlobArea.Text = HSBlob.BlobArea(0)
                            With HSDisplayPassenger
                                .set_ImagePalette(1, HSDISPLAYLib.hsImagePalette.hsPaletteNone)
                                .set_ImagePaletteType(0, HSDISPLAYLib.hsImagePaletteType.hsPaletteTypeColor1)
                                .set_ImagePaletteColor(0, 0, RGB(255, 128, 0))
                                .set_ImagePalette(1, HSDISPLAYLib.hsImagePalette.hsPalette0)
                                .set_ImageDatabase(1, HSApp.Database.Handle)
                                .set_ImageViewName(1, HSBlob.OutputBlobView)
                                .set_ImageName(1, HSBlob.OutputBlobImage)
                            End With
                    End Select
                Next i
                Dim RTvalue As Int64
                RTvalue = CInt(HSBlob.BlobArea(0))
                Return RTvalue
            End If
        Catch ex As Exception
            ShowVBErrors("Blob", ex.Message)
            Return False
        End Try
    End Function

    Private Sub Find(ByRef Side As Int32)
        Dim StartTimer As Single
        Dim OutputText As String
        Dim Temp As Short = 0
        'Dim HSModel As HSLOCATORLib.HSModelEditorInterface
        Try
            'If the gray scale image was sucessfully acquired
            If HSAcq.ErrorDescription = "" Then
                HSLoc(Side).Execute()
                'If an instance was 
                Select Case Side 'Set the display control details
                    Case Camera.LocateGlass
                        StartTimer = VB.Timer()
                        HSDisplayLocateGlass.set_SceneViewName(0, HSLoc(Camera.LocateGlass).OutputDetailSceneView)
                        HSDisplayLocateGlass.set_SceneViewName(1, HSLoc(Camera.LocateGlass).OutputInstanceSceneView)
                        HSDisplayLocateGlass.set_ScenePenWidth(0, HSDISPLAYLib.hsPenWidth.hsPenWidthThin)
                        HSDisplayLocateGlass.set_ScenePenWidth(1, HSDISPLAYLib.hsPenWidth.hsPenWidthThin)
                        lblLocateTime.Text = (VB.Timer - StartTimer).ToString("N2") & " Secs."
                    Case Camera.Driver
                        StartTimer = VB.Timer()
                        HSDisplayDriver.set_ScenePenWidth(0, HSDISPLAYLib.hsPenWidth.hsPenWidthThin)
                        HSDisplayDriver.set_ScenePenWidth(1, HSDISPLAYLib.hsPenWidth.hsPenWidthThin)
                        lblLocateTimeDriver.Text = (VB.Timer - StartTimer).ToString("N2") & " Secs."
                    Case Camera.Center
                        StartTimer = VB.Timer()
                        HSDisplayCenter.set_ScenePenWidth(0, HSDISPLAYLib.hsPenWidth.hsPenWidthThin)
                        HSDisplayCenter.set_ScenePenWidth(1, HSDISPLAYLib.hsPenWidth.hsPenWidthThin)
                        lblLocateTimeCenter.Text = (VB.Timer - StartTimer).ToString("N2") & " Secs."
                    Case Camera.BracketVerify
                        StartTimer = VB.Timer()
                        HSDisplayCenterBracketVerify.set_ScenePenWidth(0, HSDISPLAYLib.hsPenWidth.hsPenWidthThin)
                        HSDisplayCenterBracketVerify.set_ScenePenWidth(1, HSDISPLAYLib.hsPenWidth.hsPenWidthThin)
                        lblLocateTimeCenterVerify.Text = (VB.Timer - StartTimer).ToString("N2") & " Secs."
                    Case Camera.Passenger
                        StartTimer = VB.Timer()
                        HSDisplayPassenger.set_ScenePenWidth(0, HSDISPLAYLib.hsPenWidth.hsPenWidthThin)
                        HSDisplayPassenger.set_ScenePenWidth(1, HSDISPLAYLib.hsPenWidth.hsPenWidthThin)
                        lblLocateTimePassenger.Text = (VB.Timer - StartTimer).ToString("N2") & " Secs."
                    Case Camera.BracketAtDialTable 'use the same hsdisplay
                        StartTimer = VB.Timer()
                        HSDisplayBracketConveyor.set_SceneViewName(0, HSLoc(Camera.BracketAtDialTable).OutputDetailSceneView)
                        HSDisplayBracketConveyor.set_SceneViewName(1, HSLoc(Camera.BracketAtDialTable).OutputInstanceSceneView)
                        HSDisplayBracketConveyor.set_ScenePenWidth(0, HSDISPLAYLib.hsPenWidth.hsPenWidthThin)
                        HSDisplayBracketConveyor.set_ScenePenWidth(1, HSDISPLAYLib.hsPenWidth.hsPenWidthThin)
                        lblLocateTimeBracketconveyor.Text = (VB.Timer - StartTimer).ToString("N2") & " Secs."
                End Select
                ' LocatorResults(Side).Status = 0
                If HSLoc(Side).InstanceCount > 0 Then
                    LocatorResults(Side).Point.X = HSLoc(Side).InstanceTranslationX(0)
                    LocatorResults(Side).Point.Y = HSLoc(Side).InstanceTranslationY(0)
                    LocatorResults(Side).Angle = HSLoc(Side).InstanceRotation(0)
                    LocatorResults(Side).Score = (HSLoc(Side).InstanceMatchQuality(0) * 100)
                    LocatorResults(Side).Fit = (HSLoc(Side).InstanceFitQuality(0) * 100)
                    'retreive the results of the locate process.
                    'Update labels on the vision controls
                    Select Case Side
                        Case Camera.LocateGlass
                            lblVisionMessageBracket.Text = HSLoc(Side).MessageNumber(0) & " " & HSLoc(Side).MessageDescription(0)
                            lblVisionPoseXBracket.Text = LocatorResults(Side).Point.X.ToString("N2")
                            lblVisionPoseYBracket.Text = LocatorResults(Side).Point.Y.ToString("N2")
                            lblVisionPoseRBracket.Text = LocatorResults(Side).Angle.ToString("N2")
                            lblVisionPoseScoreBracket.Text = LocatorResults(Side).Score.ToString("N2")
                            lblVisionPoseFitBracket.Text = LocatorResults(Side).Fit.ToString("N2")
                            UpdateLabelsAndStatus(Side)
                            ''
                            PLC_IO_Write_Bracket(0).Vision_Data_X = LocatorResults(Side).Point.X * 10
                            PLC_IO_Write_Bracket(0).Vision_Data_Y = LocatorResults(Side).Point.Y * 10
                            PLC_IO_Write_Bracket(0).Vision_Data_R = LocatorResults(Side).Angle * 100
                            PLC_IO_Write_Bracket(0).VisStat = LocatorResults(Side).Status
                            '
                            Try
                                RefLocate0.Y = HSLoc(Side).InstanceReferencePointPositionY(0, 0)
                                RefLocate0.X = HSLoc(Side).InstanceReferencePointPositionX(0, 0)
                                RefLocate1.Y = HSLoc(Side).InstanceReferencePointPositionY(0, 1)
                                RefLocate1.X = HSLoc(Side).InstanceReferencePointPositionX(0, 1)
                                RefLocate2.X = HSLoc(Side).InstanceReferencePointPositionX(0, 2)
                                RefLocate2.Y = HSLoc(Side).InstanceReferencePointPositionY(0, 2)
                            Catch ex As Exception
                                ShowVBErrors("No Reference Markers", ex.Message)
                            End Try
                            DrawPointMarkers(Side)
                            HSDisplayLocateGlass.RefreshMarkers()
                        Case Camera.BracketVerify
                            'save data 
                            lblVisionMessageBracketVerify.Text = HSLoc(Side).MessageNumber(0) & " " & HSLoc(Side).MessageDescription(0)
                            lblVisionPoseXBracketVerify.Text = LocatorResults(Side).Point.X.ToString("N2")
                            lblVisionPoseYBracketVerify.Text = LocatorResults(Side).Point.Y.ToString("N2")
                            lblVisionPoseRBracketVerify.Text = LocatorResults(Side).Angle.ToString("N2")
                            lblVisionPoseScoreBracketVerify.Text = LocatorResults(Side).Score.ToString("N2")
                            lblVisionPoseFitBracketVerify.Text = LocatorResults(Side).Fit.ToString("N2")
                            RefVerify0.Y = HSLoc(Side).InstanceReferencePointPositionY(0, 0)
                            RefVerify0.X = HSLoc(Side).InstanceReferencePointPositionX(0, 0)
                            RefVerify1.Y = HSLoc(Side).InstanceReferencePointPositionY(0, 1)
                            RefVerify1.X = HSLoc(Side).InstanceReferencePointPositionX(0, 1)
                            RefVerify2.X = HSLoc(Side).InstanceReferencePointPositionX(0, 2)
                            RefVerify2.Y = HSLoc(Side).InstanceReferencePointPositionY(0, 2)
                            UpdateLabelsAndStatus(Side)
                            DrawPointMarkers(Side)
                            HSDisplayLocateGlass.RefreshMarkers()
                        Case Camera.Driver
                            lblVisionMessageDriver.Text = HSLoc(Side).MessageNumber(0) & " " & HSLoc(Side).MessageDescription(0)
                            lblVisionPoseXDriver.Text = LocatorResults(Side).Point.X.ToString("N2")
                            lblVisionPoseYDriver.Text = LocatorResults(Side).Point.Y.ToString("N2")
                            lblVisionPoseRDriver.Text = LocatorResults(Side).Angle.ToString("N2")
                            lblVisionPoseScoreDriver.Text = LocatorResults(Side).Score.ToString("N2")
                            lblVisionPoseFitDriver.Text = LocatorResults(Side).Fit.ToString("N2")
                            UpdateLabelsAndStatus(Side)
                            DrawPointMarkers(Side)
                            HSDisplayDriver.RefreshMarkers()
                        Case Camera.Center
                            lblVisionMessageCenter.Text = HSLoc(Side).MessageNumber(0) & " " & HSLoc(Side).MessageDescription(0)
                            lblVisionPoseXCenter.Text = LocatorResults(Side).Point.X.ToString("N2")
                            lblVisionPoseYCenter.Text = LocatorResults(Side).Point.Y.ToString("N2")
                            lblVisionPoseRCenter.Text = LocatorResults(Side).Angle.ToString("N2")
                            lblVisionPoseScoreCenter.Text = LocatorResults(Side).Score.ToString("N2")
                            lblVisionPoseFitCenter.Text = LocatorResults(Side).Fit.ToString("N2")
                            UpdateLabelsAndStatus(Side)
                            DrawPointMarkers(Side)
                            HSDisplayCenter.RefreshMarkers()
                        Case Camera.Passenger
                            lblVisionMessagePassenger.Text = HSLoc(Side).MessageNumber(0) & " " & HSLoc(Side).MessageDescription(0)
                            lblVisionPoseXPassenger.Text = LocatorResults(Side).Point.X.ToString("N2")
                            lblVisionPoseYPassenger.Text = LocatorResults(Side).Point.Y.ToString("N2")
                            lblVisionPoseRPassenger.Text = LocatorResults(Side).Angle.ToString("N2")
                            lblVisionPoseScorePassenger.Text = LocatorResults(Side).Score.ToString("N2")
                            lblVisionPoseFitPassenger.Text = LocatorResults(Side).Fit.ToString("N2")
                            UpdateLabelsAndStatus(Side)
                            DrawPointMarkers(Side)
                            HSDisplayPassenger.RefreshMarkers()
                        Case Camera.BracketAtDialTable
                            lblVisionMessageBracketConveyor.Text = HSLoc(Side).MessageNumber(0) & " " & HSLoc(Side).MessageDescription(0)
                            lblVisionPoseXBracketConveyor.Text = LocatorResults(Side).Point.X.ToString("N2")
                            lblVisionPoseYBracketConveyor.Text = LocatorResults(Side).Point.Y.ToString("N2")
                            lblVisionPoseRBracketConveyor.Text = LocatorResults(Side).Angle.ToString("N2")
                            lblVisionPoseScoreBracketConveyor.Text = LocatorResults(Side).Score.ToString("N2")
                            lblVisionPoseFitBracketConveyor.Text = LocatorResults(Side).Fit.ToString("N2")
                            UpdateLabelsAndStatus(Side)
                            PLC_IO_Write_Bracket(1).Vision_Data_X = LocatorResults(Side).Point.X * 10
                            PLC_IO_Write_Bracket(1).Vision_Data_Y = LocatorResults(Side).Point.Y * 10
                            PLC_IO_Write_Bracket(1).Vision_Data_R = LocatorResults(Side).Angle * 100
                            PLC_IO_Write_Bracket(1).VisStat = LocatorResults(Side).Status
                            DrawPointMarkers(Side)
                            HSDisplayBracketConveyor.RefreshMarkers()
                    End Select
                Else
                    Select Case Side
                        Case Camera.LocateGlass
                            lblVisionMessageBracket.Text = "Image was Not located - " & CStr(HSLoc(Camera.LocateGlass).MessageDescription(0))
                            lblBracketInspection.BackColor = Color.Red
                            lblVisionMessageBracket.BackColor = Color.Red
                            PLC_IO_Write_Bracket(0).VisStat = LocatorResults(Side).Status
                        Case Camera.Driver
                            lblVisionMessageDriver.Text = "Image was Not located - " & CStr(HSLoc(Camera.Driver).MessageDescription(0))
                            lblDriverInspection.BackColor = Color.Red
                            lblVisionMessageDriver.BackColor = Color.Red
                            LocatorResults(Side).Status = 2
                        Case Camera.Center
                            lblVisionMessageCenter.Text = "Image was Not located - " & CStr(HSLoc(Camera.Center).MessageDescription(0))
                            lblCenterInspection.BackColor = Color.Red
                            lblVisionMessageCenter.BackColor = Color.Red
                            LocatorResults(Side).Status = 2
                        Case Camera.Passenger
                            lblVisionMessagePassenger.Text = "Image was Not located - " & CStr(HSLoc(Camera.Passenger).MessageDescription(0))
                            lblPassengerInspection.BackColor = Color.Red
                            lblVisionMessagePassenger.BackColor = Color.Red
                            LocatorResults(Side).Status = 2
                        Case Camera.BracketAtDialTable
                            lblVisionMessageBracketConveyor.Text = "Image was Not located - " & CStr(HSLoc(Camera.BracketAtDialTable).MessageDescription(0))
                            lblBracketInspectionConveyor.BackColor = Color.Red
                            lblVisionMessageBracketConveyor.BackColor = Color.Red
                            PLC_IO_Write_Bracket(1).VisStat = LocatorResults(Side).Status
                        Case Camera.BracketVerify
                            lblVisionMessageBracketVerify.Text = "Image was Not located - " & CStr(HSLoc(Camera.BracketVerify).MessageDescription(0))
                            lblBracketInspectionVerify.BackColor = Color.Red
                            lblVisionMessageBracketVerify.BackColor = Color.Red
                    End Select
                End If
            Else
                'Display the HS error 
                Select Case Side
                    Case Camera.LocateGlass
                        HSDisplayLocateGlass.set_ScenePenWidth(1, HSDISPLAYLib.hsPenWidth.hsPenWidthNone)
                        lblVisionMessageBracket.Text = CStr(HSAcq.ErrorDescription)
                        lblBracketInspection.BackColor = Color.Red
                        lblVisionMessageBracket.BackColor = Color.Red
                    Case Camera.BracketVerify
                        HSDisplayCenterBracketVerify.set_ScenePenWidth(1, HSDISPLAYLib.hsPenWidth.hsPenWidthNone)
                        lblVisionMessageBracketVerify.Text = CStr(HSAcq.ErrorDescription)
                        lblBracketInspectionVerify.BackColor = Color.Red
                        lblVisionMessageBracketVerify.BackColor = Color.Red
                    Case Camera.Driver
                        HSDisplayDriver.set_ScenePenWidth(1, HSDISPLAYLib.hsPenWidth.hsPenWidthNone)
                        lblVisionMessageDriver.Text = CStr(HSAcq.ErrorDescription)
                        lblDriverInspection.BackColor = Color.Red
                        lblVisionMessageDriver.BackColor = Color.Red
                    Case Camera.Center
                        HSDisplayCenter.set_ScenePenWidth(1, HSDISPLAYLib.hsPenWidth.hsPenWidthNone)
                        lblVisionMessageCenter.Text = CStr(HSAcq.ErrorDescription)
                        lblVisionMessageCenter.BackColor = Color.Red
                    Case Camera.Passenger
                        HSDisplayPassenger.set_ScenePenWidth(1, HSDISPLAYLib.hsPenWidth.hsPenWidthNone)
                        lblVisionMessagePassenger.Text = CStr(HSAcq.ErrorDescription)
                        lblCenterInspection.BackColor = Color.Red
                        lblVisionMessagePassenger.BackColor = Color.Red
                    Case Camera.BracketAtDialTable
                        HSDisplayBracketConveyor.set_ScenePenWidth(1, HSDISPLAYLib.hsPenWidth.hsPenWidthNone)
                        lblVisionMessageBracketConveyor.Text = CStr(HSAcq.ErrorDescription)
                        lblBracketInspectionConveyor.BackColor = Color.Red
                        lblVisionMessageBracketConveyor.BackColor = Color.Red
                End Select
            End If
            If eText Then
                Select Case Side
                    Case Camera.LocateGlass
                        HSDisplayLocateGlass.RemoveAllMarker()
                        eText = False
                    Case Camera.Driver
                        HSDisplayDriver.RemoveAllMarker()
                        eText = False
                    Case Camera.Center
                        HSDisplayCenter.RemoveAllMarker()
                        eText = False
                    Case Camera.Passenger
                        HSDisplayPassenger.RemoveAllMarker()
                        eText = False
                    Case Camera.BracketAtDialTable
                        HSDisplayBracketConveyor.RemoveAllMarker()
                        eText = False
                    Case Camera.BracketVerify
                        HSDisplayCenterBracketVerify.RemoveAllMarker()
                        eText = False
                End Select
            Else
                DrawPointMarkers(Side)
            End If
            GC.Collect()
        Catch ex As Exception
            OutputText = Str(HSLoc(Side).ErrorObject.Number) & HSLoc(Side).ErrorObject.Description & vbCr & HSLoc(Side).ErrorObject.Source
            ShowVBErrors("Find", OutputText)
        End Try
    End Sub

    Private Function CheckFails() As Boolean
        If lblVisionMessageBracket.BackColor = Color.Red Or lblVisionMessageDriver.BackColor = Color.Red Or lblVisionMessageCenter.BackColor = Color.Red _
                Or lblVisionMessagePassenger.BackColor = Color.Red Or lblVisionMessageBracketConveyor.BackColor = Color.Red Or
                lblVisionMessageBracketTape.BackColor = Color.Red Or lblVisionMessageBracketVerify.BackColor = Color.Red Then
            Return True
        End If
        Return False
    End Function

    Private Sub LightControls(sender As Object, e As EventArgs) Handles btnBacklight.Click, btnOverheadLight.Click, btnBacklightPrimer.Click
        Dim btn As Button
        btn = DirectCast(sender, Button)
        Select Case btn.Name
            Case btnBacklight.Name
                If PLC_DriverCLX.Read(PLC_Tags.plcTag_Backlight) Then
                    PLC_DriverCLX.Write("Vis_Lights.2", 0)
                Else
                    PLC_DriverCLX.Write("Vis_Lights.2", 1)
                End If
            Case btnOverheadLight.Name
                If PLC_DriverCLX.Read(PLC_Tags.plcTag_OverLight) Then
                    PLC_DriverCLX.Write("Vis_Lights.0", 0)
                Else
                    PLC_DriverCLX.Write("Vis_Lights.0", 1)
                End If
            Case btnBacklightPrimer.Name
                If PLC_DriverCLX.Read(PLC_Tags.plcTag_PrimerLight) Then
                    PLC_DriverCLX.Write("Vis_Lights.6", 0)
                Else
                    PLC_DriverCLX.Write("Vis_Lights.6", 1)
                End If
        End Select
        GC.Collect()
    End Sub

    Private Sub UpdateLabelsAndStatus(ByRef Side As Integer)
        Try
            'Check Score
            LocatorResults(Side).Status = 0
            Select Case Side
                Case Camera.LocateGlass
                    If LocatorResults(Side).Score >= CDbl(updnScoreLimit.Value) Then
                        lblVisionMessageBracket.Text = "Image was successfully located" & vbCrLf & Date.Now
                        lblVisionMessageBracket.BackColor = System.Drawing.SystemColors.Control
                        lblVisionPoseXBracket.BackColor = System.Drawing.SystemColors.Control
                        lblVisionPoseYBracket.BackColor = System.Drawing.SystemColors.Control
                        lblVisionPoseRBracket.BackColor = System.Drawing.SystemColors.Control
                        LocatorResults(Side).Status = 1
                        lblBracketInspection.BackColor = Color.YellowGreen
                    Else
                        lblVisionMessageBracket.Text = "Score was too low"
                        eText = True
                        lblVisionMessageBracket.BackColor = System.Drawing.Color.Red
                        lblBracketInspection.BackColor = Color.Red
                        LocatorResults(Side).Status = 2
                    End If
                Case Camera.BracketVerify
                    If LocatorResults(Side).Score >= CDbl(updnScoreLimitCenterVerify.Value) Then
                        lblVisionMessageBracketVerify.Text = "Image was successfully located" & vbCrLf & Date.Now
                        lblVisionMessageBracketVerify.BackColor = System.Drawing.SystemColors.Control
                        lblVisionPoseXBracketVerify.BackColor = System.Drawing.SystemColors.Control
                        lblVisionPoseYBracketVerify.BackColor = System.Drawing.SystemColors.Control
                        lblVisionPoseRBracketVerify.BackColor = System.Drawing.SystemColors.Control
                        LocatorResults(Side).Status = 1
                        lblBracketInspectionVerify.BackColor = Color.YellowGreen
                    Else
                        lblVisionMessageBracketVerify.Text = "Score was too low"
                        eText = True
                        lblVisionMessageBracketVerify.BackColor = System.Drawing.Color.Red
                        lblBracketInspectionVerify.BackColor = Color.Red
                        LocatorResults(Side).Status = 2
                    End If
                Case Camera.BracketAtDialTable
                    If LocatorResults(Side).Score >= CDbl(updnScoreLimitBracketconveyor.Value) Then
                        lblVisionMessageBracketConveyor.Text = "Image was successfully located" & vbCrLf & Date.Now
                        lblVisionMessageBracketConveyor.BackColor = System.Drawing.SystemColors.Control
                        lblVisionPoseXBracket.BackColor = System.Drawing.SystemColors.Control
                        lblVisionPoseYBracket.BackColor = System.Drawing.SystemColors.Control
                        lblVisionPoseRBracket.BackColor = System.Drawing.SystemColors.Control
                        LocatorResults(Side).Status = 1
                        lblBracketInspectionConveyor.BackColor = Color.YellowGreen
                    Else
                        lblVisionMessageBracketConveyor.Text = "Score was too low"
                        eText = True
                        lblVisionMessageBracketConveyor.BackColor = System.Drawing.Color.Red
                        lblBracketInspectionConveyor.BackColor = Color.Red
                        LocatorResults(Side).Status = 2
                    End If
                Case Camera.Driver
                    If LocatorResults(Side).Score >= CDbl(updnScoreLimitDriver.Value) Then
                        lblVisionMessageDriver.Text = "Image was successfully located" & vbCrLf & Date.Now
                        lblVisionMessageDriver.BackColor = System.Drawing.SystemColors.Control
                        lblVisionPoseXDriver.BackColor = System.Drawing.SystemColors.Control
                        lblVisionPoseYDriver.BackColor = System.Drawing.SystemColors.Control
                        lblVisionPoseRDriver.BackColor = System.Drawing.SystemColors.Control
                        LocatorResults(Side).Status = 1
                    Else
                        lblVisionMessageDriver.Text = "Score was too low"
                        eText = True
                        lblVisionMessageDriver.BackColor = System.Drawing.Color.Red
                        lblDriverInspection.BackColor = Color.Red
                        LocatorResults(Side).Status = 2
                    End If
                Case Camera.Center
                    If LocatorResults(Side).Score >= CDbl(updnScoreLimitCenter.Value) Then
                        lblVisionMessageCenter.Text = "Image was successfully located" & vbCrLf & Date.Now
                        lblVisionMessageCenter.BackColor = System.Drawing.SystemColors.Control
                        lblVisionPoseXCenter.BackColor = System.Drawing.SystemColors.Control
                        lblVisionPoseYCenter.BackColor = System.Drawing.SystemColors.Control
                        lblVisionPoseRCenter.BackColor = System.Drawing.SystemColors.Control
                        LocatorResults(Side).Status = 1
                    Else
                        lblVisionMessageCenter.Text = "Score was too low"
                        eText = True
                        lblVisionMessageCenter.BackColor = System.Drawing.Color.Red
                        lblCenterInspection.BackColor = Color.Red
                        LocatorResults(Side).Status = 2
                    End If
                Case Camera.Passenger
                    If LocatorResults(Side).Score >= CDbl(updnScoreLimitPassenger.Value) Then
                        lblVisionMessagePassenger.Text = "Image was successfully located" & vbCrLf & Date.Now
                        lblVisionMessagePassenger.BackColor = System.Drawing.SystemColors.Control
                        lblVisionPoseXPassenger.BackColor = System.Drawing.SystemColors.Control
                        lblVisionPoseYPassenger.BackColor = System.Drawing.SystemColors.Control
                        lblVisionPoseRPassenger.BackColor = System.Drawing.SystemColors.Control
                        LocatorResults(Side).Status = 1
                    Else
                        lblVisionMessagePassenger.Text = "Score was too low"
                        eText = True
                        lblPassengerInspection.BackColor = Color.Red
                        lblVisionMessagePassenger.BackColor = System.Drawing.Color.Red
                        LocatorResults(Side).Status = 2
                    End If
            End Select
            GC.Collect()
        Catch ex As Exception
            ShowVBErrors("CheckThresholds ", Err.Description)
        End Try
    End Sub

#End Region

#Region "Hexsight Display Markers"

    Private Sub DrawPointMarkers(ByVal Side As Int32)
        Try
            ' Display an axes marker for pickup
            Select Case Side
                Case Camera.LocateGlass
                    With HSDisplayLocateGlass
                        'TODO Code is redundant , call the next subrouting to do the same thing.
                        .AddAxesMarker("Placement", LocatorResults(Side).Point.X, LocatorResults(Side).Point.Y, 50, 50, LocatorResults(Side).Angle, 90, True)
                        .set_MarkerDisplayName("Placement", True)
                        .set_MarkerColor("Placement", HSDISPLAYLib.hsColor.hsBlue)
                    End With
                Case Camera.BracketVerify
                    With HSDisplayCenterBracketVerify
                        .AddAxesMarker("Verification", LocatorResults(Side).Point.X, LocatorResults(Side).Point.Y, 50, 50, LocatorResults(Side).Angle, 90, True)
                        .set_MarkerDisplayName("Verification", True)
                        .set_MarkerColor("Verification", HSDISPLAYLib.hsColor.hsMagenta)
                    End With
                Case Camera.BracketAtDialTable
                    With HSDisplayBracketConveyor
                        .AddAxesMarker("Pickup", LocatorResults(Side).Point.X, LocatorResults(Side).Point.Y, 50, 50, LocatorResults(Side).Angle, 90, True)
                        .set_MarkerDisplayName("Pickup", True)
                        .set_MarkerColor("Pickup", HSDISPLAYLib.hsColor.hsYellow)
                    End With
            End Select
        Catch ex As Exception
            ShowVBErrors("UpdatePointMarkers", ex.Message)
        End Try
    End Sub

    Private Sub DrawPointMarker(Display As Object, Side As Integer, MarkerName As String)
        Display.AddAxesMarker(MarkerName, LocatorResults(Side).Point.X, LocatorResults(Side).Point.Y, 50, 50, LocatorResults(Side).Angle, 90, True)
        Display.set_MarkerDisplayName(MarkerName, True)
        Display.set_MarkerColor(MarkerName, HSDISPLAYLib.hsColor.hsYellow)
    End Sub

    Private Sub DrawAxisMarker(ByRef Side As Int32)
        Try
            ' Display an axes marker for pickup
            Select Case Side
                Case Camera.LocateGlass
                    With HSDisplayLocateGlass
                        .RemoveMarker("New Pickup")
                        .AddAxesMarker("New Pickup", LocatorResults(Side).Point.X + updnLocationX.Value, LocatorResults(Side).Point.Y + updnLocationY.Value, 50, 50, LocatorResults(Side).Angle + updnLocationR.Value, 90, True)
                        .set_MarkerDisplayName("New Pickup", True)
                        .set_MarkerColor("New Pickup", HSDISPLAYLib.hsColor.hsGreen)
                    End With
                Case Camera.BracketAtDialTable
                    With HSDisplayBracketConveyor
                        .RemoveMarker("New Pickup")
                        .AddAxesMarker("New Pickup", LocatorResults(Side).Point.X + updnLocationX.Value, LocatorResults(Side).Point.Y + updnLocationY.Value, 50, 50, LocatorResults(Side).Angle + updnLocationR.Value, 90, True)
                        .set_MarkerDisplayName("New Pickup", True)
                        .set_MarkerColor("New Pickup", HSDISPLAYLib.hsColor.hsGreen)
                    End With
            End Select
        Catch ex As Exception
            ShowVBErrors("UpdateAxisMarkers", ex.Message)
        End Try
    End Sub

    Private Sub DrawBlobRectangles(BlobName As String)
        'Dim butn As Button
        'butn = DirectCast(Sender, Button)lo
        'Dim X, Y, R, Width, height As Single
        Dim Display As Object = HSDisplayCenter
        Try
            Select Case BlobName
                Case "Driver Blob"
                    Display = HSDisplayDriver
                Case "Center Blob"
                    Display = HSDisplayCenter
                Case "Passenger Blob"
                    Display = HSDisplayPassenger
            End Select
            'Get the Region of Interest Rectangle
            HSBlob = HSApp.ProcessManager.Process(BlobName)
            'Get tool position info
            Dim toolx As Single = HSBlob.ToolPositionX
            Dim tooly As Single = HSBlob.ToolPositionY
            Dim toolr As Single = HSBlob.ToolRotation
            Dim toolwidth As Single = HSBlob.ToolWidth
            Dim toolheight As Single = HSBlob.ToolHeight
            'Get transform info, this is the position of the instance
            Dim transformx As Single = HSBlob.TransformTranslationX
            Dim transformy As Single = HSBlob.TransformTranslationY
            Dim transformr As Single = HSBlob.TransformRotation
            'Apply the rotation of the transform to the tool position
            Dim cos As Single = (Math.Cos(transformr * Math.PI / 180.0))
            Dim sin As Single = Math.Sin(transformr * Math.PI / 180.0)
            Dim x As Single = toolx * cos - tooly * sin
            Dim y As Single = toolx * sin + tooly * cos
            ' Translate the rotated tool position to the instance position
            x += transformx
            y += transformy
            'Compute the final rotation of the tool position
            Dim rotation As Single = transformr + toolr
            'Display the Region of Interest Rectangle
            DrawRectangleMarker(Display, BlobName, x, y, rotation, toolwidth, toolheight, hsColor.hsGreen, hsRectangleMarkerConstraints.hsRectangleCornerBasedEdition)
            HSDisplayDriver.ChangeRectangleMarker(BlobName, x, y, toolwidth, toolheight, True)
            'TODO Remove rectangle info
            'Display.set_RectangleMarkerrRotation(BlobName, rotation)
            ''Display.set_RectangleMarkerConstraints(BlobName, HSDISPLAYLib.hsRectangleMarkerConstraints.hsRectangleNoConstraints)
            'Display.set_MarkerColor(BlobName, HSDISPLAYLib.hsColor.hsGreen)
        Catch ex As Exception
            ShowVBErrors("Blob Training", ex.Message)
        End Try
    End Sub

    Private Sub DrawRectangleMarker(display As AxHSDisplay, name As String, x As Single, y As Single, r As String, toolwidth As Single, toolheight As Single, ByVal color As Int32, ByVal constraints As Int32)
        ' Draws a Hexsight Rectangle on the display
        display.AddRectangleMarker(name, x, y, toolwidth, toolheight, True) 'user drawable box
        display.set_RectangleMarkerHeight(name, toolheight)
        display.set_RectangleMarkerWidth(name, toolwidth)
        display.set_RectangleMarkerRotation(name, r)
        display.set_MarkerColor(name, color)
        display.set_RectangleMarkerConstraints(name, constraints)
    End Sub

    Private Sub HSMain_RectangleMarkerChange(ByVal sender As Object, ByVal e As AxHSDISPLAYLib._DHSDisplayEvents_RectangleMarkerChangeEvent) Handles _
    HSDisplayBracketConveyor.RectangleMarkerChange
        'TODO add code to save to the Bracket Database, we may need to do the actual save x number of seconds after this event occurs.
        'If Not PasswordValue Then Exit Sub
        If sender.name.contains("BracketConveyor") Then
            'Update the Locator Search Area
            HSLoc(Camera.BracketVerify).ToolPositionX = e.x
            HSLoc(Camera.BracketVerify).ToolPositionY = e.y
            HSLoc(Camera.BracketVerify).ToolWidth = e.width
            HSLoc(Camera.BracketVerify).ToolHeight = e.height
            'Save Limits in Settings Database
            frmDataBase.SetValue("Bracket", "Value", "X", CSng(e.x))
            frmDataBase.SetValue("Bracket", "Value", "Y", CSng(e.y))
            frmDataBase.SetValue("Bracket", "Value", "Width", CSng(e.width))
            frmDataBase.SetValue("Bracket", "Value", "Height", CSng(e.height))
        End If
    End Sub

    Private Sub AddSearchRangeArea(Display As AxHSDisplay, ByVal Side As Int16)
        With Display
            .AddRectangleMarker("Search Area", HSLoc(Side).ToolPositionX, HSLoc(Side).ToolPositionY, HSLoc(Side).ToolWidth, HSLoc(Side).ToolHeight, True)
            .set_MarkerDisplayName("Search Area", True)
            .set_MarkerColor("Search Area", HSDISPLAYLib.hsColor.hsGreen)
            If True Then 'PasswordValue Then
                .set_RectangleMarkerConstraints("Search Area", HSDISPLAYLib.hsRectangleMarkerConstraints.hsRectangleCornerBasedEdition)
                .set_MarkerLineStyle("Search Area", HSDISPLAYLib.hsMarkerLineStyle.hsSolid)
            Else
                .set_RectangleMarkerConstraints("Search Area", HSDISPLAYLib.hsRectangleMarkerConstraints.hsRectangleNoEdit)
                .set_MarkerLineStyle("Search Area", HSDISPLAYLib.hsMarkerLineStyle.hsDash)
            End If
            .Refresh()
        End With
    End Sub

#End Region

#Region "Timers"

    Private Sub IOTimer_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles IOTimer.Tick
        Try
            If PLCIO(0) = True Then
                PLC_Check_Glass_Primer("PLC")
                PLCIO(0) = False
            End If
            If PLCIO(1) = True Then
                PLC_Check_H_Primer()
                PLCIO(1) = False
            End If
            If PLCIO(2) = True Then
                PLC_Glass_Location()
                PLCIO(2) = False
            End If
            If PLCIO(3) = True Then
                PLC_Bracket_DialTable_Location()
                PLCIO(3) = False
            End If
            If PLCIO(4) = True Then
                PLC_Glass_Location()
                PLC_Vision_Camera_Verify()
                PLCIO(4) = False
            End If
            If PLCIO(6) = True Then
                resetLabels()
                PLCIO(6) = False
            End If
            'Check_Temp()
        Catch ex As Exception
            ShowVBErrors("IOTimer", ex.Message)
        End Try
    End Sub

    Private Sub tmrDelay_Tick1(ByVal sender As Object, ByVal e As System.EventArgs) Handles tmrDelay.Tick
        Try
            tmrDelay.Enabled = False
        Catch ex As Exception
            ShowVBErrors("tmrDelat_Tick1", ex.Message)
        End Try
    End Sub

    Public Sub DelayTimer(ByRef TimeInterval As Integer)
        Try
            tmrDelay.Interval = TimeInterval
            tmrDelay.Enabled = True
            Do
                System.Windows.Forms.Application.DoEvents()
            Loop While tmrDelay.Enabled
        Catch ex As Exception
            ShowVBErrors("DelayTimer", ex.Message)
        End Try

    End Sub
#End Region

#Region "Up Downs"

    Private Sub updnScoreLimit_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles updnScoreLimit.ValueChanged, updnScoreLimitBracketconveyor.ValueChanged, updnScoreLimitBracketPrimer.ValueChanged, updnScoreLimitCenter.ValueChanged, updnScoreLimitCenterVerify.ValueChanged, updnScoreLimitDriver.ValueChanged, updnScoreLimitPassenger.ValueChanged,
        updnBottomLeftVerifyVariance.ValueChanged, updnTopRightVerifyVariance.ValueChanged, updnBottomRightVerifyVariance.ValueChanged, updnScoreLimitTapeBracketLocator.ValueChanged
        Try
            Dim updn As NumericUpDown
            If InitializingForm Then Exit Sub
            updn = DirectCast(sender, NumericUpDown)
            Select Case updn.Name
                Case updnScoreLimit.Name
                    frmDataBase.SetValue("Partdata", "Value", updn.Name, updn.Value)
                Case updnScoreLimitDriver.Name
                    frmDataBase.SetValue("Partdata", "Value", updn.Name, updn.Value)
                Case updnScoreLimitCenter.Name
                    frmDataBase.SetValue("Partdata", "Value", updn.Name, updn.Value)
                Case updnScoreLimitPassenger.Name
                    frmDataBase.SetValue("Partdata", "Value", updn.Name, updn.Value)
                Case updnScoreLimitBracketconveyor.Name
                    frmDataBase.SetValue("Partdata", "Value", updn.Name, updn.Value)
                Case updnScoreLimitTapeBracketLocator.Name
                    frmDataBase.SetValue("Bracket", "Value", updn.Name, updn.Value)
                Case updnScoreLimitCenterVerify.Name
                    frmDataBase.SetValue("Partdata", "Value", updn.Name, updn.Value)
                Case updnScoreLimitBracketPrimer.Name
                    frmDataBase.SetValue("Bracket", "Value", updn.Name, updn.Value)
                Case updnBottomLeftVerifyVariance.Name
                    frmDataBase.SetValue("Partdata", "Value", updn.Name, updn.Value)
                Case updnBottomRightVerifyVariance.Name
                    frmDataBase.SetValue("Partdata", "Value", updn.Name, updn.Value)
                Case updnTopRightVerifyVariance.Name
                    frmDataBase.SetValue("Partdata", "Value", updn.Name, updn.Value)
            End Select
        Catch ex As Exception
            ShowVBErrors("Score Limit Change", ex.Message)
        End Try
    End Sub

    Public Function FindDistance(X1 As Integer, Y1 As Integer, X2 As Integer, Y2 As Integer) As Integer
        Dim NewX, NewY As Double
        Dim Value As String
        NewX = Math.Sqrt(Math.Abs(X2 - X1))
        NewY = Math.Sqrt(Math.Abs(Y2 - Y1))
        Value = Math.Sqrt(NewX * NewX) + (NewY * NewY)
        Return Value
    End Function

    Private Sub updnPrimerSettings_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles updnCenterBlobThresholdMin.ValueChanged, updnCenterBlobThresholdMax.ValueChanged,
                    updnDriverBlobThresholdMax.ValueChanged, updnDriverBlobThresholdMin.ValueChanged, updnPassengerBlobThresholdMax.ValueChanged, updnPassengerBlobThresholdMin.ValueChanged
        Dim updn As NumericUpDown
        updn = DirectCast(sender, NumericUpDown)
        If Not InitializingForm Then
            If Not UpdatingPartData Then frmDataBase.SetValue("Partdata", "Value", updn.Name, updn.Value)
        End If
    End Sub

    Private Sub updnBlobSettings_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles updnCenterBlobThresholdMin.ValueChanged, updnCenterBlobThresholdMax.ValueChanged,
                             updnDriverBlobThresholdMax.ValueChanged, updnDriverBlobThresholdMin.ValueChanged, updnPassengerBlobThresholdMax.ValueChanged, updnPassengerBlobThresholdMin.ValueChanged,
                             updnBracketPrimer1Deviation.ValueChanged, updnBracketPrimer2Deviation.ValueChanged, updnBracketPrimer3Deviation.ValueChanged, updnBracketPrimer4Deviation.ValueChanged, updnBracketPrimer5Deviation.ValueChanged,
                             updnTapeBlobMinTopLeft.ValueChanged, updnTapeBlobMaxTopLeft.ValueChanged, updnTapeBlobMinTopRight.ValueChanged, updnTapeBlobMaxTopRight.ValueChanged, updnTapeBlobMinBottomLeft.ValueChanged,
                             updnTapeBlobMaxBottomLeft.ValueChanged, updnTapeBlobMinBottomRight.ValueChanged, updnTapeBlobMaxBottomRight.ValueChanged
        Dim updn As NumericUpDown
        updn = DirectCast(sender, NumericUpDown)
        Select Case updn.Name
            Case updnBracketPrimer1Deviation.Name, updnBracketPrimer2Deviation.Name, updnBracketPrimer3Deviation.Name, updnBracketPrimer4Deviation.Name, updnBracketPrimer5Deviation.Name
                BlobDeviation = updn.Value
        End Select
        If Not InitializingForm Then
            If Not UpdatingPartData Then frmDataBase.SetValue("Bracket", "Value", updn.Name, updn.Value)
        End If
    End Sub

    Private Sub updnCoverSettings_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _
            updnCoverBlobMinBottomLeft.ValueChanged, updnCoverBlobMinBottomRight.ValueChanged, updnCoverBlobMinTopLeft.ValueChanged, updnCoverBlobMinTopRight.ValueChanged,
            updnCoverMaxAreaBottomLeft.ValueChanged, updnCoverMaxAreaBottomRight.ValueChanged, updnCoverMaxAreaTopLeft.ValueChanged, updnCoverMaxAreaTopRight.ValueChanged
        Dim updn As NumericUpDown
        updn = DirectCast(sender, NumericUpDown)
        If Not InitializingForm Then
            If Not UpdatingPartData Then frmDataBase.SetValue("Bracket", "Value", updn.Name, updn.Value)
        End If
    End Sub

    Private Sub CameraSettings_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles updnContrastLocateGlass.ValueChanged, updnExposureLocateGlass.ValueChanged,
                updnContrastBracketTape.ValueChanged, updnContrastBracketConveyor.ValueChanged, updnContrastCenterVerify.ValueChanged, updnContrastDriver.ValueChanged,
                updnContrastCenter.ValueChanged, updnContrastPassenger.ValueChanged, updnExposureBracketConveyor.ValueChanged, updnExposureBracketTape.ValueChanged,
                updnExposureCenter.ValueChanged, updnExposureCenterVerify.ValueChanged, updnExposureDriver.ValueChanged, updnExposurePassenger.ValueChanged

        Dim updn As NumericUpDown
        Dim Success As Boolean
        Static InRoutine As Boolean
        '
        'Initialize
        If InRoutine Then Exit Sub
        InRoutine = True
        Try
            If Not InitializingForm And Not UpdatingPartData Then
                'Change the camera setting
                updn = DirectCast(sender, NumericUpDown)
                Select Case updn.Name
                    'set camera contrast
                    Case updnContrastLocateGlass.Name
                        Success = HelperCamCenter.SetSimpleFeature("gain", CSng(updn.Value), Side)
                        If Not UpdatingPartData Then frmDataBase.SetValue("Partdata", "Value", updn.Name, updn.Value)
                        If Not UpdatingPartData Then frmDataBase.SetValue("Bracket", "Value", updn.Name, updn.Value)
                    Case updnContrastBracketConveyor.Name
                        Success = HelperCamBracket.SetSimpleFeature("gain", CSng(updn.Value), Side)
                        If Not UpdatingPartData Then frmDataBase.SetValue("Bracket", "Value", updn.Name, updn.Value)
                    Case updnContrastDriver.Name
                        Success = HelperCamDriver.SetSimpleFeature("gain", CSng(updn.Value), Side)
                        If Not UpdatingPartData Then frmDataBase.SetValue("Partdata", "Value", updn.Name, updn.Value)
                    Case updnContrastCenter.Name
                        Success = HelperCamCenter.SetSimpleFeature("gain", CSng(updn.Value), Side)
                        If Not UpdatingPartData Then frmDataBase.SetValue("Partdata", "Value", updn.Name, updn.Value)
                    Case updnContrastPassenger.Name
                        Success = HelperCamPassenger.SetSimpleFeature("gain", CSng(updn.Value), Side)
                        If Not UpdatingPartData Then frmDataBase.SetValue("Partdata", "Value", updn.Name, updn.Value)
                    Case updnContrastCenterVerify.Name
                        Success = HelperCamCenter.SetSimpleFeature("gain", CSng(updn.Value), Side)
                        If Not UpdatingPartData Then frmDataBase.SetValue("Partdata", "Value", updn.Name, updn.Value)
                        'set camera exposure
                    Case updnExposureLocateGlass.Name
                        Success = HelperCamCenter.SetSimpleFeature("exposure", CSng(updn.Value), Side)
                        If Not UpdatingPartData Then frmDataBase.SetValue("Partdata", "Value", updn.Name, updn.Value)
                    Case updnExposureBracketConveyor.Name
                        Success = HelperCamBracket.SetSimpleFeature("exposure", CSng(updn.Value), Side)
                        If Not UpdatingPartData Then frmDataBase.SetValue("Bracket", "Value", updn.Name, updn.Value)
                    Case updnExposureDriver.Name
                        Success = HelperCamDriver.SetSimpleFeature("exposure", CSng(updn.Value), Side)
                        If Not UpdatingPartData Then frmDataBase.SetValue("Partdata", "Value", updn.Name, updn.Value)
                    Case updnExposureCenter.Name
                        Success = HelperCamCenter.SetSimpleFeature("exposure", CSng(updn.Value), Side)
                        If Not UpdatingPartData Then frmDataBase.SetValue("Partdata", "Value", updn.Name, updn.Value)
                    Case updnExposurePassenger.Name
                        Success = HelperCamPassenger.SetSimpleFeature("exposure", CSng(updn.Value), Side)
                        If Not UpdatingPartData Then frmDataBase.SetValue("Partdata", "Value", updn.Name, updn.Value)
                    Case updnExposureCenterVerify.Name
                        Success = HelperCamPassenger.SetSimpleFeature("exposure", CSng(updn.Value), Side)
                        If Not UpdatingPartData Then frmDataBase.SetValue("Partdata", "Value", updn.Name, updn.Value)
                End Select
                DelayTimer(250)
            End If
            InRoutine = False
            Exit Sub
        Catch ex As Exception
            InRoutine = False
            ShowVBErrors("CameraSettings_ValueChanged ", ex.Message)
        End Try
    End Sub

#End Region

#Region "Menus"

    Public Sub mnuDeletePart_DropDownItemClicked(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles _
        deleteABC.DropDownItemClicked,
        deleteDEF.DropDownItemClicked,
        deleteGHI.DropDownItemClicked,
        deleteJKL.DropDownItemClicked,
        deleteMNO.DropDownItemClicked,
        deletePQR.DropDownItemClicked,
        deleteSTU.DropDownItemClicked,
        deleteVWX.DropDownItemClicked,
        deleteYZ.DropDownItemClicked,
        deleteOther.DropDownItemClicked
        '
        Dim DeleteName As String
        Dim Answer As Integer
        Dim KillPath As String
        Dim FSO As Scripting.FileSystemObject
        'See if this is the current part
        mnuFile.HideDropDown()
        DeleteName = e.ClickedItem.Text
        If PartName = DeleteName Then
            MsgBox("You can't delete the current part file", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        'Are you sure
        Answer = MsgBox("Are you sure you want to delete the part " & DeleteName, MsgBoxStyle.OkCancel)
        If Answer = MsgBoxResult.Ok Then
            KillPath = PartsPath & DeleteName
            FSO = New Scripting.FileSystemObject
            Try
                FSO.DeleteFolder(KillPath, True)
            Catch ex As Exception
                ShowVBErrors(ex.Message, "Error Deleting the Directory")
                Exit Sub
            End Try
            MsgBox("Part was permanently deleted", MsgBoxStyle.OkOnly)
        Else
            MsgBox("No files were deleted", MsgBoxStyle.OkOnly)
        End If
    End Sub

    Private Sub mnuLoadPart_DropDownItemClicked(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles _
                    loadABC.DropDownItemClicked,
                    loadDEF.DropDownItemClicked,
                    loadGHI.DropDownItemClicked,
                    loadJKL.DropDownItemClicked,
                    loadMNO.DropDownItemClicked,
                    loadPQR.DropDownItemClicked,
                    loadSTU.DropDownItemClicked,
                    loadVWX.DropDownItemClicked,
                    loadYZ.DropDownItemClicked,
                    loadOther.DropDownItemClicked
        mnuFile.HideDropDown()
        LoadPart(e.ClickedItem.Text)
    End Sub

    Public Sub mnuQuit_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuQuit.Click
        Application.Exit()
    End Sub

    Public Sub mnuFile_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuFile.Click
        PartList.GetFileList()
    End Sub

    Public Sub mnuNew_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuNew.Click
        Dim FSO As Scripting.FileSystemObject
        Dim TempPartName As String
        Dim OldPath As String
        Dim NewPath As String
        'Store the old part path
        OldPath = VB.Left(CurrentFilePath, Len(CurrentFilePath) - 1)
        'Get the new part name
        TempPartName = InputBox("Enter the new part name" & vbCr & "The part name will be truncated to 25 characters" & vbCr & "Case is not important.  The part name will be converted to upper case.", "Create a New Part")
        'Verify the new part name is good
        TempPartName = UCase(TempPartName)
        'Create the vision database
        Try
            If TempPartName <> "" Then
                frmDataBase.SetValue("Partdata", "Value", "PrimerTrained", "False") 'set primer training value to false
                PartName = TempPartName
                lblPartTitle.Text = PartName
                CurrentFilePath = PartsPath & PartName & "\"
                FSO = New Scripting.FileSystemObject
                NewPath = VB.Left(CurrentFilePath, Len(CurrentFilePath) - 1)
                FSO.CreateFolder(NewPath)
                FSO.CopyFile(OldPath & "\Partdata.sdf", NewPath & "\Partdata.sdf")
                FSO.CopyFile(OldPath & "\Glass Locate.hdb", NewPath & "\Glass Locate.hdb")
                FSO.CopyFile(OldPath & "\Driver Locate.hdb", NewPath & "\Driver Locate.hdb")
                FSO.CopyFile(OldPath & "\Center Locate.hdb", NewPath & "\Center Locate.hdb")
                FSO.CopyFile(OldPath & "\Passenger Locate.hdb", NewPath & "\Passenger Locate.hdb")
                FSO.CopyFile(OldPath & "\Bracket Verify.hdb", NewPath & "\Bracket Verify.hdb")
                frmDataBase.SetValue("Settings", "Value", "Current Part Name", PartName)
            End If
            frmPartSettings.Show()
        Catch ex As Exception
            MsgBox("There was a problem creating the new directory, no changes were made" & vbCr &
                                                                        "Error: " & Err.Description, MsgBoxStyle.SystemModal, "New Part Creation Error")
        End Try
    End Sub

    Public Sub mnuPassword_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuPassword.Click
        If mnuPassword.Checked Then
            mnuPassword.Checked = False
            ActivatePassword(OperPassword)
        Else
            frmPassword.Show()
            frmPassword.txtPassword.Focus()
        End If
    End Sub
#End Region

#Region "Configuration"

    Public Sub mnuGeneralSettings_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuGeneralDatabaseSettings.Click
        Try
            TableName = "Settings"
            frmDataBase.Show()
        Catch ex As Exception
            ShowVBErrors("mnuGeneralSettings", ex.Message)
        End Try
    End Sub

    Private Sub mnuBracketSettings_Click(sender As Object, e As EventArgs) Handles mnuBracketSettings.Click
        Try
            TableName = "Bracket"
            frmDataBase.Show()
        Catch ex As Exception
            ShowVBErrors("mnuBracketSettings", ex.Message)
        End Try
    End Sub

    Public Sub mnuPartSettings_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuPositionalSettings.Click
        Try
            TableName = "Partdata"
            frmDataBase.Show()
        Catch ex As Exception
            ShowVBErrors("mnuPartSettings", ex.Message)
        End Try
    End Sub

    Private Sub mnuModifyHexsightControls_Click_1(sender As Object, e As EventArgs) Handles mnuModifyHexsightControls.Click
        Try
            frmSetupVision.Show()
        Catch ex As Exception
            ShowVBErrors("mnuModifyHexsightControls", ex.Message)
        End Try
    End Sub

#End Region

#Region "Help"

    Private Sub StartHelp(ByRef HelpFile As String, Optional ByRef ShowNote As Boolean = True)
        Try
            If ShowNote Then
                MsgBox("Note : Click on the page number in the table" & vbCr &
                                                                            " of contents to jump to that item.", MsgBoxStyle.SystemModal)
            End If
            Dim myProcess As System.Diagnostics.Process = New System.Diagnostics.Process()
            myProcess.StartInfo.FileName = HelpFile
            myProcess.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Maximized
            myProcess.Start()
        Catch ex As Exception
            ShowVBErrors("StartHelpFile", ex.Message)
            MsgBox("The file that you tried to open was not available" & vbCr &
                                                                "It should be located:" & vbCr & HelpFile, MsgBoxStyle.SystemModal)
        End Try
    End Sub

    Private Sub mnuCameraCalibration_Click(sender As Object, e As EventArgs) Handles mnuCameraCalibration.Click
        Try
            StartHelp(HelpPath & "Calibration.pdf", False)
        Catch ex As Exception
            ShowVBErrors("mnuHowToCalibrateHelp", ex.Message)
        End Try
    End Sub

    Public Sub mnuSquaringTrainingProcedure_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        Try
            StartHelp(HelpPath & "SquaringTrainingProcedure.pdf", False)
        Catch ex As Exception
            ShowVBErrors("mnuSquaringTrainingProcedure", ex.Message)
        End Try

    End Sub

    Public Function PartFind(PLCPartString As String) As String
        Dim pNames As List(Of String) = New List(Of String)(Directory.EnumerateDirectories(PartsPath))
        Dim dirName, NewString As String
        Dim Counter As Int16 = 0
        For Each dirName In pNames
            Counter += 1
            NewString = dirName.Remove(0, Len(PartsPath))
            If NewString.StartsWith(PLCPartString & "_") Then
                dirName = NewString.Remove(0, Len(PLCPartString) + 1)
                MsgBox(dirName)
                Return dirName
            End If
        Next
        Return "Not Found"
    End Function

    Public Sub mnuHexsightUserGuideHelp_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        Try
            StartHelp("C:\Program Files\HexSight 4.1\Documentation\4.1.1.28-HexSight_User_Guide.pdf", False)
        Catch ex As Exception
            ShowVBErrors("mnuHexsightUserGuideHelp", ex.Message)
        End Try
    End Sub

#End Region

#Region "File System"

    Public Function LoadPart(Optional ByVal TempPartName As String = "") As Boolean
        Dim Success As Boolean = False
        LoadPart = False
        ChangingPart = True
        Try
            If Not PartList.CheckforFile(TempPartName) Then
                MsgBox("The Part Name '" & TempPartName & "' does not exist on this computer" & vbCr &
                            "You will need to manually create this part from another part" & vbCr &
                            "or select a different part from the HMI", MsgBoxStyle.SystemModal)
                Exit Function
            Else
                PartName = TempPartName
            End If
            lblPartTitle.Text = "'" & PartName & "'"
            CurrentFilePath = PartsPath & PartName & "\"
            frmDataBase.SetValue("Settings", "Value", "Current Part Name", PartName)
            'Load the Locators
            Try
                For i As Int16 = 1 To NumCams
                    Select Case i
                        Case 1

                        Case 2
                            Success = HSLoc(Camera.Driver).LoadModelDatabase(CurrentFilePath & "Driver Locate.hdb")
                            If Not Success Then
                                MsgBox("Unable to load the model file for the Driver Side")
                            End If
                        Case 3
                            Success = HSLoc(Camera.Center).LoadModelDatabase(CurrentFilePath & "Center Locate.hdb")
                            If Not Success Then
                                MsgBox("Unable to load the model file for the Center Side")
                            End If
                            Success = HSLoc(Camera.LocateGlass).LoadModelDatabase(CurrentFilePath & "Glass Locate.hdb")
                            If Not Success Then
                                MsgBox("Unable to load the model file for the Glass Locate")
                            End If
                            Success = HSLoc(Camera.BracketVerify).LoadModelDatabase(CurrentFilePath & "Bracket Verify.hdb")
                            If Not Success Then
                                MsgBox("Unable to load the model file for the Bracket Verify Side")
                            End If
                        Case 4
                            Success = HSLoc(Camera.Passenger).LoadModelDatabase(CurrentFilePath & "Passenger Locate.hdb")
                            If Not Success Then
                                MsgBox("Unable to load the model file for the Passenger Side")
                            End If
                    End Select
                Next
            Catch ex As Exception
                MsgBox("Unable to load the model file for the Bracket Side" & vbCr & ex.Message, MsgBoxStyle.SystemModal)
            End Try
            'remove all display markers
            HSDisplayLocateGlass.RemoveAllMarker()
            HSDisplayBracketConveyor.RemoveAllMarker()
            HSDisplayBracketTape.RemoveAllMarker()
            HSDisplayDriver.RemoveAllMarker()
            HSDisplayCenter.RemoveAllMarker()
            HSDisplayPassenger.RemoveAllMarker()
            HSDisplayBracketPrimer.RemoveAllMarker()
            'Driver Blob Saved Values
            SavedDriverBlobArea = CInt(frmDataBase.GetValue("Partdata", "Value", "Driver Blob Area"))
            lblDriverBlobArea.Text = "Saved Area: " & SavedDriverBlobArea
            trkDriverBlob.Value = CDbl(frmDataBase.GetValue("Partdata", "Value", "Driver Blob Variance"))
            '   lblTrackDriverValue.Text = "Variance Percentage " & trkDriverBlob.Value & "%"
            DriverBlobVariance = SavedDriverBlobArea * (0.01 * trkDriverBlob.Value)
            'Driver Blob Search Area
            HSBlob = HSApp.ProcessManager.Process("Driver Blob")
            HSBlob.ToolPositionX = frmDataBase.GetValue("Partdata", "Value", "DriverBlobToolPosX")
            HSBlob.ToolPositionY = frmDataBase.GetValue("Partdata", "Value", "DriverBlobToolPosY")
            HSBlob.ToolWidth = frmDataBase.GetValue("Partdata", "Value", "DriverBlobToolWidth")
            HSBlob.ToolHeight = frmDataBase.GetValue("Partdata", "Value", "DriverBlobToolHeight")
            HSBlob.ToolRotation = frmDataBase.GetValue("Partdata", "Value", "DriverBlobToolPosR")
            'Center Blob Saved Values
            SavedCenterBlobArea = CInt(frmDataBase.GetValue("Partdata", "Value", "Center Blob Area"))
            lblCenterBlobArea.Text = "Saved Area: " & SavedCenterBlobArea
            trkCenterBlob.Value = CDbl(frmDataBase.GetValue("Partdata", "Value", "Center Blob Variance"))
            '  lblTrackCenterValue.Text = "Variance Percentage " & trkCenterBlob.Value & "%"
            CenterBlobVariance = SavedCenterBlobArea * (0.01 * trkCenterBlob.Value)
            'Center Blob Search Area
            HSBlob = HSApp.ProcessManager.Process("Center Blob")
            HSBlob.ToolPositionX = frmDataBase.GetValue("Partdata", "Value", "CenterBlobToolPosX")
            HSBlob.ToolPositionY = frmDataBase.GetValue("Partdata", "Value", "CenterBlobToolPosY")
            HSBlob.ToolWidth = frmDataBase.GetValue("Partdata", "Value", "CenterBlobToolWidth")
            HSBlob.ToolHeight = frmDataBase.GetValue("Partdata", "Value", "CenterBlobToolHeight")
            HSBlob.ToolRotation = frmDataBase.GetValue("Partdata", "Value", "CenterBlobToolPosR")
            'Passenger Blob Saved Values
            SavedPassengerBlobArea = CInt(frmDataBase.GetValue("Partdata", "Value", "Passenger Blob Area"))
            lblPassengerBlobArea.Text = "Saved Area: " & SavedPassengerBlobArea
            trkPassengerBlob.Value = CDbl(frmDataBase.GetValue("Partdata", "Value", "Passenger Blob Variance"))
            PassengerBlobVariance = SavedPassengerBlobArea * (0.01 * trkPassengerBlob.Value)
            'Passenger Blob Search Area
            HSBlob = HSApp.ProcessManager.Process("Passenger Blob")
            HSBlob.ToolPositionX = frmDataBase.GetValue("Partdata", "Value", "PassengerBlobToolPosX")
            HSBlob.ToolPositionY = frmDataBase.GetValue("Partdata", "Value", "PassengerBlobToolPosY")
            HSBlob.ToolWidth = frmDataBase.GetValue("Partdata", "Value", "PassengerBlobToolWidth")
            HSBlob.ToolHeight = frmDataBase.GetValue("Partdata", "Value", "PassengerBlobToolHeight")
            HSBlob.ToolRotation = frmDataBase.GetValue("Partdata", "Value", "PassengerBlobToolPosR")
            'Update Camera Images with current exposures, contrast, gain  
            frmSplash.lblStatus.Text = "Camera Settings"
            txtVerifySavedDiffBottomLeft.Text = frmDataBase.GetValue("Partdata", "Value", txtVerifySavedDiffBottomLeft.Name)
            txtVerifySavedDiffBottomRight.Text = frmDataBase.GetValue("Partdata", "Value", txtVerifySavedDiffBottomRight.Name)
            txtVerifySavedDiffTopRight.Text = CStr(frmDataBase.GetValue("Partdata", "Value", txtVerifySavedDiffTopRight.Name))
            ''Bracket Name and Robot ID for this part to send to plc
            PartSettingsBracketName = frmDataBase.GetValue("Partdata", "Value", frmPartSettings.txtPartSettingsCurrentBracketType.Name)
            PartSettingsRobotID = frmDataBase.GetValue("Partdata", "Value", frmPartSettings.txtBracketID.Name)
            PartUseBracket = frmDataBase.GetValue("Partdata", "Value", frmPartSettings.chkBracket.Name)
            PartPrimer = frmDataBase.GetValue("Partdata", "Value", frmPartSettings.chkPrimer.Name)
            'Set the blob training button 
            PrimerTrained = frmDataBase.GetValue("Partdata", "Value", "PrimerTrained")
            BtnTrain(PrimerTrained)
            'Get the bracket Z deposit value
            PartSettingLocationZ = CInt(frmDataBase.GetValue("Partdata", "Value", updnLocationZ.Name))
            'update the updown controls
            UpdateUpDownControls()
            'set the camera setting
            SetCameraSettings()
            'send the data to the plc
            PLC_DriverCLX.Write("vis_pc_recipe_name", PartName)
            PLC_DriverCLX.Write("vis_pc_Bracket_Type", PartSettingsBracketName)
            PLC_DriverCLX.Write("vis_pc_Robot_Prog", PartSettingsRobotID)
            If PartUseBracket Then
                PLC_DriverCLX.Write("Vis_PC_Inspections.1", CInt(PartUseBracket) * -1)
            Else
                PLC_DriverCLX.Write("Vis_PC_Inspections.1", CInt(PartUseBracket))
            End If
            If PartPrimer Then
                PLC_DriverCLX.Write("Vis_PC_Inspections.0", CInt(PartPrimer) * -1)
            Else
                PLC_DriverCLX.Write("Vis_PC_Inspections.0", CInt(PartPrimer))
            End If
            LoadPart = True
            ChangingPart = False
        Catch ex As Exception
            ShowVBErrors("LoadPart", ex.Message)
            ChangingPart = False
            LoadPart = False
        End Try
    End Function

    Public Function LoadBracket() As Boolean
        Dim Success As Boolean = False
        LoadBracket = False
        Try
            'remove display markers
            HSDisplayBracketConveyor.RemoveAllMarker()
            HSDisplayBracketTape.RemoveAllMarker()
            HSDisplayBracketPrimer.RemoveAllMarker()
            'Load the locators
            Success = HSLoc(Camera.BracketAtDialTable).LoadModelDatabase(ConfigPath & "Bracket Conveyor Locate.hdb")
            If Not Success Then
                MsgBox("Unable to load the model file for the Bracket Side Conveyor")
            End If

            'Bracket Primer 1-5 load
            'TODO Modify the code below to use the bracket database so that Value is replaced by X,Y,R,ToolWidth,ToolHeight
            For i As Int16 = 1 To 5
                HSBlob = HSApp.ProcessManager.Process("Bracket Primer Blob " & i)
                HSBlob.ToolPositionX = frmDataBase.GetValue("Bracket", "Value", "BracketPrimerBlobToolPosX" & i)
                HSBlob.ToolPositionY = frmDataBase.GetValue("Bracket", "Value", "BracketPrimerBlobToolPosY" & i)
                HSBlob.ToolWidth = frmDataBase.GetValue("Bracket", "Value", "BracketPrimerBlobToolWidth" & i)
                HSBlob.ToolHeight = frmDataBase.GetValue("Bracket", "Value", "BracketPrimerBlobToolHeight" & i)
                HSBlob.ToolRotation = frmDataBase.GetValue("Bracket", "Value", "BracketPrimerBlobToolPosR" & i)
            Next
            HSBlob = HSApp.ProcessManager.Process("Bracket Primer Blob Reference")
            HSBlob.ToolPositionX = frmDataBase.GetValue("Bracket", "Value", "BracketPrimerBlobToolPosXRef")
            HSBlob.ToolPositionY = frmDataBase.GetValue("Bracket", "Value", "BracketPrimerBlobToolPosYRef")
            HSBlob.ToolWidth = frmDataBase.GetValue("Bracket", "Value", "BracketPrimerBlobToolWidthRef")
            HSBlob.ToolHeight = frmDataBase.GetValue("Bracket", "Value", "BracketPrimerBlobToolHeightRef")
            HSBlob.ToolRotation = frmDataBase.GetValue("Bracket", "Value", "BracketPrimerBlobToolPosRRef")
            'Tape Blobs
            updnTapeMinAreaTopLeft.Value = CDbl(frmDataBase.GetValue("Bracket", "Value", "Tape Blob Variance Top Left"))
            '
            updnTapeMinAreaTopRight.Value = CDbl(frmDataBase.GetValue("Bracket", "Value", "Tape Blob Variance Top Right"))
            '
            updnTapeMinAreaBottomLeft.Value = CDbl(frmDataBase.GetValue("Bracket", "Value", "Tape Blob Variance Bottom Left"))
            '
            updnTapeMinAreaBottomRight.Value = CDbl(frmDataBase.GetValue("Bracket", "Value", "Tape Blob Variance Bottom Right"))
            '
            'updnTapeVarianceTopLeft.Value = CDbl(frmDataBase.GetValue("Bracket", "Value", "Tape Blob Variance Top Left"))
            'lblupdnTapeValueTopleft.Text = "Top Left Area: " & updnTapeVarianceTopLeft.Value
            '
            'updnTapeVarianceTopRight.Value = CDbl(frmDataBase.GetValue("Bracket", "Value", "Tape Blob Variance Top Right"))
            'lblupdnTapeValueTopRight.Text = "Top right Area: " & updnTapeVarianceTopRight.Value
            '
            'updnTapeVarianceBottomLeft.Value = CDbl(frmDataBase.GetValue("Bracket", "Value", "Tape Blob Variance Bottom Left"))
            'lblupdnTapeValueBottomLeft.Text = "Bottom Left Area: " & updnTapeVarianceBottomLeft.Value
            '
            'updnTapeVarianceBottomRight.Value = CDbl(frmDataBase.GetValue("Bracket", "Value", "Tape Blob Variance Bottom Right"))
            'lblupdnTapeValueBottomRight.Text = "Bottom Right Area: " & updnTapeVarianceBottomRight.Value
            For i As Int16 = 1 To 4
                HSBlob = HSApp.ProcessManager.Process("Bracket Tape Blob " & i)
                HSBlob.ToolPositionX = frmDataBase.GetValue("Bracket", "Value", "Bracket Tape Blob " & i & " PosXRef")
                HSBlob.ToolPositionY = frmDataBase.GetValue("Bracket", "Value", "Bracket Tape Blob " & i & " PosYRef")
                HSBlob.ToolWidth = frmDataBase.GetValue("Bracket", "Value", "Bracket Tape Blob " & i & " WidthRef")
                HSBlob.ToolHeight = frmDataBase.GetValue("Bracket", "Value", "Bracket Tape Blob " & i & " HeightRef")
                HSBlob.ToolRotation = frmDataBase.GetValue("Bracket", "Value", "Bracket Tape Blob " & i & " PosRRef")
                'HSBlob = HSApp.ProcessManager.Process("Bracket Cover Blob " & i)
                'HSBlob.ToolPositionX = frmDataBase.GetValue("Bracket", "Value", "Bracket Cover Blob " & i & " PosXRef")
                'HSBlob.ToolPositionY = frmDataBase.GetValue("Bracket", "Value", "Bracket Cover Blob " & i & " PosYRef")
                'HSBlob.ToolWidth = frmDataBase.GetValue("Bracket", "Value", "Bracket Cover Blob " & i & " WidthRef")
                'HSBlob.ToolHeight = frmDataBase.GetValue("Bracket", "Value", "Bracket Cover Blob " & i & " HeightRef")
                'HSBlob.ToolRotation = frmDataBase.GetValue("Bracket", "Value", "Bracket Cover Blob " & i & " PosRRef")
            Next
            rdoTapeTopLeft.Checked = True
            'Get the bracket Z deposit value
            PartSettingLocationZ = CInt(frmDataBase.GetValue("Bracket", "Value", updnLocationZ.Name))
            'update the updown controls
            UpdateBracketUpDownControls()
            LoadBracket = True
        Catch ex As Exception
            ShowVBErrors("LoadBracket", ex.Message)
        End Try
    End Function

    Private Sub trkDriverBlob_Scroll(sender As Object, e As EventArgs) Handles trkDriverBlob.Scroll, trkDriverBlob.ValueChanged
        'lblTrackDriverValue.Text = "Variance Percentage " & trkDriverBlob.Value '& "%"
        DriverBlobVariance = (SavedDriverBlobArea * (0.01 * trkDriverBlob.Value))
        lblTrackDriverValue.Text = "Minimum Area " & DriverBlobVariance '& "%"
    End Sub

    Private Sub trkCenterBlob_Scroll(sender As Object, e As EventArgs) Handles trkCenterBlob.Scroll, trkCenterBlob.ValueChanged
        'lblTrackCenterValue.Text = "Variance Percentage " & trkCenterBlob.Value '& "%"
        CenterBlobVariance = (SavedCenterBlobArea * (0.01 * trkCenterBlob.Value))
        lblTrackCenterValue.Text = "Minimum Area " & CenterBlobVariance '& "%"
    End Sub

    Private Sub trkPassengerBlob_Scroll(sender As Object, e As EventArgs) Handles trkPassengerBlob.Scroll, trkPassengerBlob.ValueChanged
        'lblTrackPassengerValue.Text = "Variance Percentage " & trkPassengerBlob.Value ' & "%"
        PassengerBlobVariance = (SavedPassengerBlobArea * (0.01 * trkPassengerBlob.Value))
        lblTrackPassengerValue.Text = "Minimum Area " & PassengerBlobVariance ' & "%"
    End Sub



    'Private Sub trkTape(sender As Object, e As EventArgs) Handles trkTapeVarianceBottomLeft.Scroll, trkTapeVarianceBottomRight.Scroll, trkTapeVarianceTopLeft.Scroll,
    '      trkTapeVarianceTopRight.Scroll
    '   Dim Track As TrackBar
    '   Track = DirectCast(sender, TrackBar)

    '   Select Case Track.Name
    '      Case trkTapeVarianceBottomLeft.Name
    '	frmDataBase.SetValue("Bracket", "Value", "Tape Blob Variance Bottom Left", trkTapeVarianceBottomLeft.Value)
    '         TapeBlobVarianceBottomLeft = (SavedTapeBlobAreaBottomLeft * (0.01 * trkTapeVarianceBottomLeft.Value))
    '         lblTrackTapeValueBottomLeft.Text = "Bottom Left Area: " & trkTapeVarianceBottomLeft.Value

    '      Case trkTapeVarianceBottomRight.Name
    '	frmDataBase.SetValue("Bracket", "Value", "Tape Blob Variance Bottom Right", trkTapeVarianceBottomRight.Value)
    '         TapeBlobVarianceBottomRight = (SavedTapeBlobAreaBottomRight * (0.01 * trkTapeVarianceBottomRight.Value))
    '         lblTrackTapeValueBottomRight.Text = "Bottom Right Area: " & trkTapeVarianceBottomRight.Value

    '      Case trkTapeVarianceTopLeft.Name
    '	frmDataBase.SetValue("Bracket", "Value", "Tape Blob Variance Top Left", trkTapeVarianceTopLeft.Value)
    '         TapeBlobVarianceTopRight = (SavedTapeBlobAreaTopLeft * (0.01 * trkTapeVarianceTopLeft.Value))
    '         lblTrackTapeValueTopLeft.Text = "Top Left Area: " & trkTapeVarianceTopLeft.Value

    '      Case trkTapeVarianceTopRight.Name
    '	frmDataBase.SetValue("Bracket", "Value", "Tape Blob Variance Top Right", trkTapeVarianceTopRight.Value)
    '         TapeBlobVarianceTopLeft = (SavedTapeBlobAreaTopRight * (0.01 * trkTapeVarianceTopRight.Value))
    '         lblTrackTapeValueTopRight.Text = "Top Right Area: " & trkTapeVarianceTopRight.Value
    '   End Select
    'End Sub

    Private Sub BtnTrain(value As Boolean)
        btnPassengerTrainBlob.Enabled = Not value
        btnCenterTrainBlob.Enabled = Not value
        btnDriverTrainBlob.Enabled = Not value
    End Sub

    Private Sub UpdateUpDownControls()
        Dim UpDown As NumericUpDown
        Dim Obj As New Object
        'This updates all of the slider values and labels
        Try
            For Each GroupBox As Windows.Forms.GroupBox In grpVisionGlassLocate.Controls
                For Each Obj In GroupBox.Controls
                    Debug.Print(Obj.name)
                    If Obj.GetType.Name = "NumericUpDown" Then
                        UpDown = DirectCast(Obj, NumericUpDown)
                        Try
                            UpDown.Value = CSng(frmDataBase.GetValue("Partdata", "Value", UpDown.Name))
                        Catch
                            MsgBox("Error Updating Up Down Control " & UpDown.Name & Err.Description, MsgBoxStyle.SystemModal)
                        End Try
                    End If
                Next Obj
            Next GroupBox
            For Each GroupBox As Windows.Forms.GroupBox In grpVisionCenterVerify.Controls
                Debug.Print(GroupBox.Name)
                For Each Obj In GroupBox.Controls
                    Debug.Print(Obj.name)
                    If Obj.GetType.Name = "NumericUpDown" Then
                        UpDown = DirectCast(Obj, NumericUpDown)
                        Try
                            UpDown.Value = CSng(frmDataBase.GetValue("Partdata", "Value", UpDown.Name))
                        Catch
                            MsgBox("Error Updating Up Down Control " & UpDown.Name & Err.Description, MsgBoxStyle.SystemModal)
                        End Try
                    End If
                Next Obj
            Next GroupBox
            For Each GroupBox As Windows.Forms.GroupBox In grpVisionDriver.Controls
                For Each Obj In GroupBox.Controls
                    Debug.Print(Obj.name)
                    If Obj.GetType.Name = "NumericUpDown" Then
                        UpDown = DirectCast(Obj, NumericUpDown)
                        Try
                            UpDown.Value = CSng(frmDataBase.GetValue("Partdata", "Value", UpDown.Name))
                        Catch
                            MsgBox("Error Updating Up Down Control " & UpDown.Name & Err.Description, MsgBoxStyle.SystemModal)
                        End Try
                    End If
                Next Obj
            Next GroupBox
            For Each GroupBox As Windows.Forms.GroupBox In grpVisionCenter.Controls
                For Each Obj In GroupBox.Controls
                    Debug.Print(Obj.name)
                    If Obj.GetType.Name = "NumericUpDown" Then
                        UpDown = DirectCast(Obj, NumericUpDown)
                        Try
                            UpDown.Value = CSng(frmDataBase.GetValue("Partdata", "Value", UpDown.Name))
                        Catch
                            MsgBox("Error Updating Up Down Control " & UpDown.Name & Err.Description, MsgBoxStyle.SystemModal)
                        End Try
                    End If
                Next Obj
            Next GroupBox
            For Each GroupBox As Windows.Forms.GroupBox In grpVisionPassenger.Controls
                For Each Obj In GroupBox.Controls
                    Debug.Print(Obj.name)
                    If Obj.GetType.Name = "NumericUpDown" Then
                        UpDown = DirectCast(Obj, NumericUpDown)
                        Try
                            UpDown.Value = CSng(frmDataBase.GetValue("Partdata", "Value", UpDown.Name))
                        Catch
                            MsgBox("Error Updating Up Down Control " & UpDown.Name & Err.Description, MsgBoxStyle.SystemModal)
                        End Try
                    End If
                Next Obj
            Next GroupBox
            SavedGlassVariance = frmDataBase.GetValue("Partdata", "Value", "Glass Bracket Variance")
        Catch ex As Exception
            ShowVBErrors("UpdateUpDownControls", Obj.Name & ex.Message)
        End Try
    End Sub

    Private Sub UpdateBracketUpDownControls()
        Dim UpDown As NumericUpDown
        'This updates all of the slider values and labels
        Try
            For Each GroupBox As Windows.Forms.GroupBox In grpVisionBracketPrimer.Controls
                For Each Obj As Object In GroupBox.Controls
                    If Obj.GetType.Name = "NumericUpDown" Then
                        UpDown = DirectCast(Obj, NumericUpDown)
                        Try
                            UpDown.Value = CSng(frmDataBase.GetValue("Bracket", "Value", UpDown.Name))
                        Catch
                            MsgBox("Error Updating Up Down Control " & UpDown.Name & Err.Description, MsgBoxStyle.SystemModal)
                        End Try
                    End If
                Next Obj
            Next GroupBox
            For Each GroupBox As Windows.Forms.GroupBox In grpVisionBracketLocateTape.Controls
                For Each Obj As Object In GroupBox.Controls
                    If Obj.GetType.Name = "NumericUpDown" Then
                        UpDown = DirectCast(Obj, NumericUpDown)
                        Try
                            UpDown.Value = CSng(frmDataBase.GetValue("Bracket", "Value", UpDown.Name))
                        Catch
                            MsgBox("Error Updating Up Down Control " & UpDown.Name & Err.Description, MsgBoxStyle.SystemModal)
                        End Try
                    End If
                Next Obj
            Next GroupBox
            For Each GroupBox As Windows.Forms.GroupBox In grpVisionBracketLocateatConveyor.Controls
                For Each Obj As Object In GroupBox.Controls
                    If Obj.GetType.Name = "NumericUpDown" Then
                        UpDown = DirectCast(Obj, NumericUpDown)
                        Try
                            UpDown.Value = CSng(frmDataBase.GetValue("Bracket", "Value", UpDown.Name))
                        Catch
                            MsgBox("Error Updating Up Down Control " & UpDown.Name & Err.Description, MsgBoxStyle.SystemModal)
                        End Try
                    End If
                Next Obj
            Next GroupBox
        Catch ex As Exception
            ShowVBErrors("UpdateBracketUpDownControls", ex.Message)
        End Try
    End Sub

    Private Sub GetSettings()
        Try
            mnuTabSwitching.Checked = frmDataBase.GetValue("Settings", "Value", mnuTabSwitching.Name)
            PartName = frmDataBase.GetValue("Settings", "Value", "Current Part Name")
            CurrentFilePath = PartsPath & PartName & "\"
            Application.DoEvents()
        Catch ex As Exception
            ShowVBErrors("GetSettings", ex.Message)
        End Try
    End Sub

    Private Sub TrainBlobs(Sender As Object, e As EventArgs) Handles btnDriverTrainBlob.Click, btnCenterTrainBlob.Click, btnPassengerTrainBlob.Click,
                                    btnTrainBracketPrimer1.Click, btnTrainBracketPrimer2.Click, btnTrainBracketPrimer3.Click, btnTrainBracketPrimer4.Click, btnTrainBracketPrimer5.Click, btnTrainBracketPrimerReference.Click,
                                    btnTrainTapeArea.Click, btnTrainCoverArea.Click
        Dim butn As Button
        butn = DirectCast(Sender, Button)
        'Dim X, Y, R, Width, height As Single
        Dim BlobName As String = ""
        Dim Display As Object = HSDisplayCenter
        '
        'This routine changes the color of the ROI to be moved and then
        ' records the location of ROI so it can be used to shift the Master trained ROI in the SavedBlobs routine
        Try
            Select Case butn.Name
                Case btnDriverTrainBlob.Name, btnDriverSaveBlob.Name
                    btnDriverSaveBlob.Enabled = True
                    BlobName = "Driver Blob"
                    Display = HSDisplayDriver
                Case btnCenterTrainBlob.Name, btnCenterSaveBlob.Name
                    btnCenterSaveBlob.Enabled = True
                    BlobName = "Center Blob"
                    Display = HSDisplayCenter
                Case btnPassengerTrainBlob.Name, btnPassengerSaveBlob.Name
                    btnPassengerSaveBlob.Enabled = True
                    BlobName = "Passenger Blob"
                    Display = HSDisplayPassenger
                Case btnTrainBracketPrimer1.Name
                    btnSaveBracketPrimer1.Enabled = True
                    BlobName = "Bracket Primer Blob 1"
                    Display = HSDisplayBracketPrimer
                Case btnTrainBracketPrimer2.Name
                    btnSaveBracketPrimer2.Enabled = True
                    BlobName = "Bracket Primer Blob 2"
                    Display = HSDisplayBracketPrimer
                Case btnTrainBracketPrimer3.Name
                    btnSaveBracketPrimer3.Enabled = True
                    BlobName = "Bracket Primer Blob 3"
                    Display = HSDisplayBracketPrimer
                Case btnTrainBracketPrimer4.Name
                    btnSaveBracketPrimer4.Enabled = True
                    BlobName = "Bracket Primer Blob 4"
                    Display = HSDisplayBracketPrimer
                Case btnTrainBracketPrimer5.Name
                    btnSaveBracketPrimer5.Enabled = True
                    BlobName = "Bracket Primer Blob 5"
                    Display = HSDisplayBracketPrimer
                Case btnTrainBracketPrimerReference.Name
                    btnSaveBracketPrimerReference.Enabled = True
                    BlobName = "Bracket Primer Blob Reference"
                    Display = HSDisplayBracketPrimer
                Case btnTrainTapeArea.Name
                    btnSaveTapeArea.Enabled = True
                    Display = HSDisplayBracketTape
                    If rdoTapeTopLeft.Checked Then
                        BlobName = "Bracket Tape Blob 1" 'the blob name
                    End If
                    If rdoTapeTopRight.Checked Then
                        BlobName = "Bracket Tape Blob 2" 'the blob name
                    End If
                    If rdoTapeBottomLeft.Checked Then
                        BlobName = "Bracket Tape Blob 3" 'the blob name
                    End If
                    If rdoTapeBottomRight.Checked Then
                        BlobName = "Bracket Tape Blob 4" 'the blob name
                    End If
                Case btnTrainCoverArea.Name
                    btnSaveTapeArea.Enabled = True
                    Display = HSDisplayBracketTape
                    If rdoCoverTopLeft.Checked Then
                        BlobName = "Tape Cover Blob Top Left" 'the blob name
                    End If
                    If rdoCoverTopRight.Checked Then
                        BlobName = "Tape Cover Blob Top Right" 'the blob name
                    End If
                    If rdoCoverBottomLeft.Checked Then
                        BlobName = "Tape Cover Blob Bottom Left" 'the blob name
                    End If
                    If rdoCoverBottomRight.Checked Then
                        BlobName = "Tape Cover Blob Bottom Right" 'the blob name
                    End If
            End Select
            HSBlob = HSApp.ProcessManager.Process(BlobName)
            DrawBlobRectangles(BlobName)
            'Get the location of the Rectangle before it is moved
            OriginalRectX = Display.get_MarkerX(BlobName)
            OriginalRectY = Display.get_MarkerY(BlobName)
            OriginalRectR = Display.get_RectangleMarkerRotation(BlobName)
            '
            Display.set_RectangleMarkerConstraints(BlobName, HSDISPLAYLib.hsRectangleMarkerConstraints.hsRectangleNoConstraints)
            Display.set_MarkerColor(BlobName, HSDISPLAYLib.hsColor.hsBlue)
        Catch ex As Exception
            ShowVBErrors("Blob Training", ex.Message)
        End Try
    End Sub

    Private Sub SaveBlobs(sender As Object, e As EventArgs) Handles btnPassengerSaveBlob.Click, btnCenterSaveBlob.Click, btnDriverSaveBlob.Click,
                                    btnSaveBracketPrimer1.Click, btnSaveBracketPrimer2.Click, btnSaveBracketPrimer3.Click, btnSaveBracketPrimer4.Click, btnSaveBracketPrimer5.Click, btnSaveBracketPrimerReference.Click,
                                    btnSaveTapeArea.Click, btnSaveCoverArea.Click
        Dim butn As Button
        butn = DirectCast(sender, Button)
        'This routine saves the master ROI after the ROI on the screen has been moved.
        'After the ROI bounding box has been drawn save the dimensions of the box and set the blob tools accordingly
        Try
            Select Case butn.Name
                Case btnDriverSaveBlob.Name
                    btnDriverSaveBlob.Enabled = False
                    ShiftRegionOfInterest("Driver Blob", HSDisplayDriver, DriverBlobDataBaseNames, "Partdata")
                Case btnCenterSaveBlob.Name
                    btnCenterSaveBlob.Enabled = False
                    ShiftRegionOfInterest("Center Blob", HSDisplayCenter, CenterBlobDataBaseNames, "Partdata")
                Case btnPassengerSaveBlob.Name
                    btnPassengerSaveBlob.Enabled = False
                    ShiftRegionOfInterest("Passenger Blob", HSDisplayPassenger, PassengerBlobDataBaseNames, "Partdata")
                Case btnSaveBracketPrimer1.Name
                    btnSaveBracketPrimer1.Enabled = False
                    ShiftRegionOfInterest("Bracket Primer Blob 1", HSDisplayBracketPrimer, BracketPrimer1BlobDataBaseNames, "Bracket")
                Case btnSaveBracketPrimer2.Name
                    btnSaveBracketPrimer2.Enabled = False
                    ShiftRegionOfInterest("Bracket Primer Blob 2", HSDisplayBracketPrimer, BracketPrimer2BlobDataBaseNames, "Bracket")
                Case btnSaveBracketPrimer3.Name
                    btnSaveBracketPrimer3.Enabled = False
                    ShiftRegionOfInterest("Bracket Primer Blob 3", HSDisplayBracketPrimer, BracketPrimer3BlobDataBaseNames, "Bracket")
                Case btnSaveBracketPrimer4.Name
                    btnSaveBracketPrimer4.Enabled = False
                    ShiftRegionOfInterest("Bracket Primer Blob 4", HSDisplayBracketPrimer, BracketPrimer4BlobDataBaseNames, "Bracket")
                Case btnSaveBracketPrimer5.Name
                    btnSaveBracketPrimer5.Enabled = False
                    ShiftRegionOfInterest("Bracket Primer Blob 5", HSDisplayBracketPrimer, BracketPrimer5BlobDataBaseNames, "Bracket")
                Case btnSaveBracketPrimerReference.Name
                    btnSaveBracketPrimerReference.Enabled = False
                    ShiftRegionOfInterest("Bracket Primer Blob Reference", HSDisplayBracketPrimer, BracketPrimerRefBlobDataBaseNames, "Bracket")
                Case btnSaveTapeArea.Name
                    btnSaveTapeArea.Enabled = False
                    If rdoTapeTopLeft.Checked Then
                        ShiftRegionOfInterest("Bracket Tape Blob 1", HSDisplayBracketTape, BracketTape1BlobDataBaseNames, "Bracket")
                    End If
                    If rdoTapeTopRight.Checked Then
                        ShiftRegionOfInterest("Bracket Tape Blob 2", HSDisplayBracketTape, BracketTape2BlobDataBaseNames, "Bracket")
                    End If
                    If rdoTapeBottomLeft.Checked Then
                        ShiftRegionOfInterest("Bracket Tape Blob 3", HSDisplayBracketTape, BracketTape3BlobDataBaseNames, "Bracket")
                    End If
                    If rdoTapeBottomRight.Checked Then
                        ShiftRegionOfInterest("Bracket Tape Blob 4", HSDisplayBracketTape, BracketTape4BlobDataBaseNames, "Bracket")
                    End If
                Case btnSaveCoverArea.Name
                    btnSaveTapeArea.Enabled = False
                    If rdoCoverTopLeft.Checked Then
                        ShiftRegionOfInterest("Tape Cover Blob Top Left", HSDisplayBracketTape, BracketCover1BlobDataBaseNames, "Bracket")
                        SaveHexsight()
                    End If
                    If rdoCoverTopRight.Checked Then
                        ShiftRegionOfInterest("Tape Cover Blob Top Right", HSDisplayBracketTape, BracketCover2BlobDataBaseNames, "Bracket")
                        SaveHexsight()
                    End If
                    If rdoCoverBottomLeft.Checked Then
                        ShiftRegionOfInterest("Tape Cover Blob Bottom Left", HSDisplayBracketTape, BracketCover3BlobDataBaseNames, "Bracket")
                        SaveHexsight()
                    End If
                    If rdoCoverBottomRight.Checked Then
                        ShiftRegionOfInterest("Tape Cover Blob Bottom Right", HSDisplayBracketTape, BracketCover4BlobDataBaseNames, "Bracket")
                        SaveHexsight()
                    End If
            End Select
        Catch ex As Exception
            ShowVBErrors("Saving Blob", ex.Message)
        End Try
    End Sub

    Private Sub ShiftRegionOfInterest(BlobName As String, Display As Object, BlobDatabaseNames() As String, Database As String)
        Dim OffsetX, OffsetY, OffsetR As Single
        Dim RectX, RectY, RectWidth, RectHeight, RectR As Single
        Try
            '
            'This routine takes the saved ROI (Region of Interest) before it has been shifted and
            'subtracts the master region location from that to find the offset.  It then adds this 
            'offset to the saved master region to shift it accordingly.
            HSBlob = HSApp.ProcessManager.Process(BlobName)
            'Get the current location of the shifted rectangle
            RectX = Display.get_MarkerX(BlobName)
            RectY = Display.get_MarkerY(BlobName)
            RectR = Display.get_RectangleMarkerRotation(BlobName)
            RectWidth = Display.get_RectangleMarkerWidth(BlobName)
            RectHeight = Display.get_RectangleMarkerHeight(BlobName)
            'RectWidth = Display.get
            'Find out how much the original rectangle was shifted
            OffsetX = RectX - OriginalRectX
            OffsetY = RectY - OriginalRectY
            OffsetR = RectR - OriginalRectR
            'Add the shifted amount to the Hexsight Blob Location to train the master tool
            HSBlob.ToolPositionX += OffsetX
            HSBlob.ToolPositionY += OffsetY
            HSBlob.ToolRotation += OffsetR
            HSBlob.ToolWidth = RectWidth
            HSBlob.ToolHeight = RectHeight
            'Change color of the rectangle and make it unmovable
            Display.set_MarkerColor(BlobName, HSDISPLAYLib.hsColor.hsGreen)
            Display.set_RectangleMarkerConstraints(BlobName, hsRectangleMarkerConstraints.hsRectangleNoEdit)
            'Save the blob location to the database
            SaveBlobRegionsToDatabase(Database, BlobDatabaseNames)
        Catch ex As Exception
            ShowVBErrors("ShiftRegionOfInterest", ex.Message)
        End Try
    End Sub

    Private Sub SaveBlobRegionsToDatabase(Database As String, BlobDatabaseNames() As String)
        'Save the blob location to the database
        frmDataBase.SetValue(Database, "Value", BlobDatabaseNames(0), HSBlob.ToolPositionX)
        frmDataBase.SetValue(Database, "Value", BlobDatabaseNames(1), HSBlob.ToolPositionY)
        frmDataBase.SetValue(Database, "Value", BlobDatabaseNames(2), HSBlob.ToolWidth)
        frmDataBase.SetValue(Database, "Value", BlobDatabaseNames(3), HSBlob.ToolHeight)
        frmDataBase.SetValue(Database, "Value", BlobDatabaseNames(4), HSBlob.ToolRotation)
    End Sub

    Private Sub LoadBlobRegionsFromDatabase(Database As String, BlobDatabaseNames() As String)
        'Load the blob location from the database
        'and populate the Hexsight blob control
        HSBlob.ToolPositionX = frmDataBase.GetValue(Database, "Value", BlobDatabaseNames(0))
        HSBlob.ToolPositionY = frmDataBase.GetValue(Database, "Value", BlobDatabaseNames(1))
        HSBlob.ToolWidth = frmDataBase.GetValue(Database, "Value", BlobDatabaseNames(2))
        HSBlob.ToolHeight = frmDataBase.GetValue(Database, "Value", BlobDatabaseNames(3))
        HSBlob.ToolRotation = frmDataBase.GetValue(Database, "Value", BlobDatabaseNames(4))
    End Sub

    Private Sub mnuCalibrateClick(sender As Object, e As EventArgs) Handles mnuCalibrateDriver.Click, mnuCalibratePassenger.Click, mnuCalibrateCenter.Click, mnuCalibrateBracket.Click
        Try
            Dim Mnu As ToolStripMenuItem
            Mnu = DirectCast(sender, ToolStripMenuItem)
            Select Case Mnu.Name
                Case mnuCalibrateBracket.Name
                    Snap(Camera.BracketAtDialTable)
                    CalibrateCam(Camera.BracketAtDialTable)
                Case mnuCalibrateCenter.Name
                    Snap(Camera.LocateGlass)
                    CalibrateCam(Camera.LocateGlass)
                Case mnuCalibrateDriver.Name
                    Snap(Camera.Driver)
                    CalibrateCam(Camera.Driver)
                Case mnuCalibratePassenger.Name
                    Snap(Camera.Passenger)
                    CalibrateCam(Camera.Passenger)
            End Select
        Catch ex As Exception
            ShowVBErrors("Calibrate Camera", ex.Message)
        End Try
    End Sub

    Private Sub btnSaveVerifyDifference_Click(sender As Object, e As EventArgs) Handles btnSaveVerifyDifference.Click
        Try
            If IsNumeric(txtVerifySavedDiffBottomLeft.Text) And IsNumeric(txtVerifySavedDiffBottomRight.Text) And IsNumeric(txtVerifySavedDiffTopRight.Text) Then
                frmDataBase.SetValue("Partdata", "Value", txtVerifySavedDiffBottomLeft.Name, txtVerifySavedDiffBottomLeft.Text)
                frmDataBase.SetValue("Partdata", "Value", txtVerifySavedDiffBottomRight.Name, txtVerifySavedDiffBottomRight.Text)
                frmDataBase.SetValue("Partdata", "Value", txtVerifySavedDiffTopRight.Name, txtVerifySavedDiffTopRight.Text)
            Else
                If Not IsNumeric(txtVerifySavedDiffBottomLeft.Text) Then txtVerifySavedDiffBottomLeft.Focus()
                If Not IsNumeric(txtVerifySavedDiffBottomRight.Text) Then txtVerifySavedDiffBottomRight.Focus()
                If Not IsNumeric(txtVerifySavedDiffTopRight.Text) Then txtVerifySavedDiffTopRight.Focus()
                MsgBox("Please Enter a Numeric Value", vbExclamation)
            End If
        Catch ex As Exception
            ShowVBErrors("Save Verify Difference", ex.Message)
        End Try
    End Sub

    Private Sub mnuPartSettings_Click_1(sender As Object, e As EventArgs) Handles mnuPartSettings.Click
        frmPartSettings.Show()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        GC.Collect()
        'TabControlsMain.SelectedTab = tabPageGocator
        About.Show()
    End Sub

    Private Sub mnuSystemDocumentation_Click_1(sender As Object, e As EventArgs) Handles mnuSystemDocumentation.Click
        Try
            StartHelp(HelpPath & "TrainVision.pdf", False)
        Catch ex As Exception
            ShowVBErrors("mnuSystemDocumentation", ex.Message)
        End Try
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lblHeartBeat.Click
        BtnTrain(False)
        resetLabels()
    End Sub

#End Region

#Region "Robot"

    Private Sub ClearPositionData(Optional side As Int16 = 1)
        Try
            PLC_IO_Write_Bracket(side).Vision_Data_X = "0"
            PLC_IO_Write_Bracket(side).Vision_Data_Y = "0"
            PLC_IO_Write_Bracket(side).Vision_Data_R = "0"
            PLC_IO_Write_Bracket(side).VisStat = "0"
        Catch ex As Exception
            ShowVBErrors("ClearPositions", ex.Message)
        End Try

    End Sub

    Private Sub mnuTabSwitching_Click(sender As Object, e As EventArgs) Handles mnuTabSwitching.Click
        mnuTabSwitching.Checked = Not mnuTabSwitching.Checked
        frmDataBase.SetValue("Settings", "Value", mnuTabSwitching.Name, mnuTabSwitching.Checked)
    End Sub

    Private Sub BtnLocationAdjustment_click(sender As Object, e As EventArgs) Handles btnDepositAdjYPlus.Click, btnDepositAdjYMinus.Click, btnDepositAdjXPlus.Click,
                btnDepositAdjXMinus.Click, btnDepositAdjRPlus.Click, btnDepositAdjRMinus.Click
        Dim LocationAdj As Button
        HSDisplayLocateGlass.RemoveMarker("Placement")
        Try
            LocationAdj = DirectCast(sender, Button)
            Select Case LocationAdj.Name
                Case Is = btnDepositAdjXPlus.Name
                    updnLocationX.Value = updnLocationX.Value + 0.1
                Case Is = btnDepositAdjXMinus.Name
                    updnLocationX.Value = updnLocationX.Value - 0.1
                Case Is = btnDepositAdjYPlus.Name
                    updnLocationY.Value = updnLocationY.Value + 0.1
                Case Is = btnDepositAdjYMinus.Name
                    updnLocationY.Value = updnLocationY.Value - 0.1
                Case Is = btnDepositAdjRPlus.Name
                    updnLocationR.Value = updnLocationR.Value + 0.1
                Case Is = btnDepositAdjRMinus.Name
                    updnLocationR.Value = updnLocationR.Value - 0.1
                Case Else
            End Select
            Side = Camera.LocateGlass
            DrawAxisMarker(Side)
        Catch ex As Exception
            ShowVBErrors("BtnLocationAdjustment ", ex.Message)
        End Try
    End Sub

    Private Sub updnGocator_ValueChanged(sender As Object, e As EventArgs) Handles updnGocator.ValueChanged
        'need plc tag
        Try
            'PLC_DriverCLX.Write("Vis_PC_Robot_Laser_Z", CInt(updnGocator.Value))
        Catch ex As Exception
            ShowVBErrors("UpdnGoCator Test", ex.Message)
        End Try
    End Sub

    Private Sub btnLocationAdjOK_Click(sender As Object, e As EventArgs) Handles btnLocationAdjOK.Click
        Dim HSModel As HSLOCATORLib.HSModelEditorInterface
        Try
            Side = Camera.LocateGlass
            HSModel = HSLoc(Side).ShowModelEditor(False, CamLocation(Side))
            HSModel.OriginPositionX += updnLocationX.Value
            HSModel.OriginPositionY += updnLocationY.Value
            HSModel.OriginRotation += updnLocationR.Value
            HSModel.Apply()
            HSLoc(Side).SaveModelDatabase(CurrentFilePath & CamLocation(Side) & ".hdb")
            HSLoc(Side).HideModelEditor()
            DrawAxisMarker(Side)
            PartSettingLocationZ = updnLocationZ.Value
            'PLC_DriverCLX.Write("Vis_PC_Robot_GLS_Z", updnLocationZ.Value)
            frmDataBase.SetValue("Partdata", "Value", updnLocationZ.Name, PartSettingLocationZ)
            updnLocationX.Value = 0
            updnLocationY.Value = 0
            updnLocationR.Value = 0
        Catch ex As Exception
            ShowVBErrors("btnLocationAdjOK", ex.Message)
        End Try
    End Sub

    Private Sub btnCalcAngle_Click(sender As Object, e As EventArgs) Handles btnCalcAngle.Click
        frmCalculateAngle.Show()
    End Sub

    Private Sub mnuSaveVerification_Click(sender As Object, e As EventArgs) Handles mnuSaveVerification.Click
        'mnuSaveVerification.Checked = Not mnuSaveVerification.Checked
    End Sub

    Private Sub SystemManualToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SystemManualToolStripMenuItem.Click
        Try
            StartHelp(HelpPath & "BracketManual.pdf", False)
        Catch ex As Exception
            ShowVBErrors("mnuHowToCalibrateHelp", ex.Message)
        End Try
    End Sub

    Private Sub btnLocationAdjCancel_Click(sender As Object, e As EventArgs) Handles btnLocationAdjCancel.Click
        updnLocationY.Value = 0
        updnLocationX.Value = 0
        updnLocationR.Value = 0
        HSDisplayLocateGlass.RemoveAllMarker()
    End Sub

    Private Sub TmrPassword_Tick(sender As Object, e As EventArgs) Handles TmrPassword.Tick
        ActivatePassword(OperPassword)
    End Sub

    Private Sub btnShiftCntrs_Click(sender As Object, e As EventArgs) Handles btnShiftCntrs.Click
        frmShiftCnts.Show()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LoadBracket()
    End Sub

    Private Sub btnClearOffsets_Click(sender As Object, e As EventArgs)
        Dim Result As Int16
        Result = MsgBox("Are you sure this will clear all offsets!", vbYesNo + vbExclamation, "Midwest Motion Inc")
        If Result = vbYes Then
            updnLocationX.Value = 0
            updnLocationY.Value = 0
            updnLocationR.Value = 0
        Else
        End If
    End Sub

#End Region

#Region "PLC"
    Private Sub UpdatePLCTags()
        Try
            'Aron Mighty
            PLC_Tags.plcTag_PrimerCheckStart = "Vis_Cam_PrimerChk.Start"
            PLC_Tags.plcTag_PrimerCheckPass = "Vis_Cam_PrimerChk.Passed"
            PLC_Tags.plcTag_PrimerCheckFail = "Vis_Cam_PrimerChk.Failed"
            PLC_Tags.plcTag_PrimerCheckDone = "Vis_Cam_PrimerChk.Done"
            'heartbeat
            PLC_Tags.plcTag_Heartbeat = "Vis_PC_Heartbeat"
            'Glass Location 
            PLC_Tags.plcTag_BracketGlassLocationStart = "Vis_Cam_GlassLoc.Start"
            PLC_Tags.plcTag_BracketGlassLocationX = "Vis_Cam_GlassLoc.X"
            PLC_Tags.plcTag_BracketGlassLocationY = "Vis_Cam_GlassLoc.Y"
            PLC_Tags.plcTag_BracketGlassLocationR = "Vis_Cam_GlassLoc.R"
            PLC_Tags.plcTag_BracketGlassLocationStat = "Vis_Cam_GlassLoc.Stat"
            PLC_Tags.plcTag_BracketGlassLocationDone = "Vis_Cam_GlassLoc.Done"
            'Bracket Conveyor Pick
            PLC_Tags.plcTag_BracketConveyorLocationStart = "Vis_Cam_BracketLoc.Start"
            PLC_Tags.plcTag_BracketDialTableLocationX = "Vis_Cam_BracketLoc.X"
            PLC_Tags.plcTag_BracketDialTableLocationY = "Vis_Cam_BracketLoc.Y"
            PLC_Tags.plcTag_BracketDialTableLocationR = "Vis_Cam_BracketLoc.R"
            PLC_Tags.plcTag_BracketDialTableLocationStat = "Vis_Cam_BracketLoc.Stat"
            PLC_Tags.plcTag_BracketDialTableLocationDone = "Vis_Cam_BracketLoc.Done"
            'Bracket Placement Verification
            PLC_Tags.plcTag_BracketVerifyStart = "Vis_Cam_Verify.Start"
            PLC_Tags.plcTag_BracketVerifyPass = "Vis_Cam_Verify.Passed"
            PLC_Tags.plcTag_BracketVerifyFail = "Vis_Cam_Verify.Failed"
            PLC_Tags.plcTag_BracketVerifyDone = "Vis_Cam_Verify.Done"
            'Lights
            PLC_Tags.plcTag_OverLight = "Vis_Lights.1"
            PLC_Tags.plcTag_Backlight = "Vis_Lights.3"
            PLC_Tags.plcTag_ConveyorLight = "Vis_Lights.5"
            PLC_Tags.plcTag_PrimerLight = "Vis_Lights.6"
            'HPrimer
            PLC_Tags.plcTag_HPrimerStart = "Vis_Cam_H_Primerchk.Start"
            PLC_Tags.plcTag_HPrimerPass = "Vis_Cam_H_Primerchk.Passed"
            PLC_Tags.plcTag_HPrimerFail = "Vis_Cam_H_Primerchk.Failed"
            'Misc Controls
            PLC_Tags.plcTag_ShiftClr = "HMI_ShiftClr"
            'init bg worker
            PLC_Bworker.WorkerSupportsCancellation = True
            Control.CheckForIllegalCrossThreadCalls = False
            'PLC Ip Address
            PLCIPAddress = frmDataBase.GetValue("Settings", "Value", "PLC_Address")
            PLC_DriverCLX.IPAddress = PLCIPAddress
            PLC_Start()
        Catch ex As Exception
            ShowVBErrors("PLC_Init ", ex.Message)
        End Try
    End Sub

    Public Sub PLC_Start()
        Try
            If Not PLC_Bworker.IsBusy Then
                PLC_Bworker.RunWorkerAsync()
            End If
        Catch ex As Exception
            ShowVBErrors("PLC_Start", ex.Message)
        End Try
    End Sub

    Public Function PLC_HeartBeat() As Boolean
        Try
            'TODO Uncomment when needing the PLC
            'Dim HB As Boolean = PLC_DriverCLX.Read(PLC_Tags.plcTag_Heartbeat)
            'PLC_DriverCLX.Write(PLC_Tags.plcTag_Heartbeat, CInt(Not HB))
            'lblHeartBeat.ForeColor = Color.Black
            'lblHeartBeat.Text = "Heartbeat " & HB
            Return True
        Catch ex As Exception
            ShowVBErrors("PLC Heartbeat ", ex.Message)
            lblHeartBeat.ForeColor = Color.Red
            lblHeartBeat.Text = "No PLC Communication"
            DelayTimer(250)
            Return False
        End Try
    End Function

    Public Sub PLC_Bworker_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles PLC_Bworker.DoWork
        Try
            Do While PLC_Bworker.CancellationPending = False
                If PLC_HeartBeat() Then
                    If Not INRoutines Then PLC_Read_IO()
                    If Not INRoutines Then
                        If (VB.Timer > 0) And (VB.Timer < 60) Then
                            ClearPLCCountData()
                        End If
                    End If
                    If PLC_Bworker.CancellationPending = True Then PLC_Bworker.CancelAsync()
                End If
            Loop
        Catch ex As Exception
            ShowVBErrors("PLC_Bracket_Worker_Work ", ex.Message)
            PLC_Bworker.CancelAsync()
        End Try
    End Sub

    Private Sub ClearPLCCountData()
        Try
            PLC_DriverCLX.Write("HMI_Shift_Reset", 0)
            DelayTimer(250)
            PLC_DriverCLX.Write("HMI_Shift_Reset", 1)
            Application.DoEvents()
        Catch ex As Exception
            ShowVBErrors("ClearPLCCountData", ex.Message)
        End Try
    End Sub

    Public Sub Check_Temp()
        Try
            If InitSuccessBracket Then GetTemperature(HelperCamBracket, lblTemperatureBracketAtConveyor) 'Camera Temperature for the Bracketconveyor Camera
            If InitSuccessDriver Then GetTemperature(HelperCamDriver, lblTemperatureDriver) 'Camera Temperature for the Driver Side Camera
            If InitSuccessPassenger Then GetTemperature(HelperCamPassenger, lblTemperaturePassenger) 'Camera Temperature for the Passenger Side Camera
            If InitSuccessCenter Then
                GetTemperature(HelperCamCenter, lblTemperatureCenter)
                lblTemperatureBracketVerify.Text = lblTemperatureCenter.Text
                lblTemperatureBracketVerify.BackColor = lblTemperatureCenter.BackColor
                lblTemperatureBracket.Text = lblTemperatureCenter.Text
                lblTemperatureBracket.BackColor = lblTemperatureCenter.BackColor
            End If
            tmrDisplayUpdate.Enabled = True
        Catch ex As Exception
            ShowVBErrors("tmrDisplayUpdate", ex.Message)
        End Try
    End Sub

    Public Sub PLC_Read_IO()
        'TODO Remove when needing PLC communication
        Exit Sub
        Try
            'Primer Check Start Recieved
            If CBool(PLC_DriverCLX.Read(PLC_Tags.plcTag_PrimerCheckStart)) Then
                lblmessagedesc.Text = "Primer Check Start Recieved"
                If Not INRoutines Then
                    Do While PLC_DriverCLX.Read(PLC_Tags.plcTag_PrimerCheckStart)
                        PLC_DriverCLX.Write(PLC_Tags.plcTag_PrimerCheckStart, 0)
                    Loop
                    PLCIO(0) = True
                End If
            End If
            If CBool(PLC_DriverCLX.Read(PLC_Tags.plcTag_HPrimerStart)) Then
                lblmessagedesc.Text = "Center Primer Start Recieved"
                If Not INRoutines Then
                    Do While PLC_DriverCLX.Read(PLC_Tags.plcTag_HPrimerStart)
                        PLC_DriverCLX.Write(PLC_Tags.plcTag_HPrimerStart, 0)
                    Loop
                    PLCIO(1) = True
                End If
            End If
            'Glass Locator Start Recieved
            If CBool(PLC_DriverCLX.Read(PLC_Tags.plcTag_BracketGlassLocationStart)) Then
                lblmessagedesc.Text = "Glass Location Start Recieved"
                If Not INRoutines Then
                    Do While PLC_DriverCLX.Read(PLC_Tags.plcTag_BracketGlassLocationStart)
                        PLC_DriverCLX.Write(PLC_Tags.plcTag_BracketGlassLocationStart, 0)
                    Loop
                    PLCIO(2) = True
                End If
            End If
            'Bracket Locator Conveyor Start Recieved
            If PLC_DriverCLX.Read(PLC_Tags.plcTag_BracketConveyorLocationStart) Then
                lblmessagedesc.Text = "Bracket Locator Conveyor Start Recieved"
                If Not INRoutines Then
                    Do While PLC_DriverCLX.Read(PLC_Tags.plcTag_BracketConveyorLocationStart)
                        PLC_DriverCLX.Write(PLC_Tags.plcTag_BracketConveyorLocationStart, 0)
                    Loop
                    PLCIO(3) = True
                End If
            End If
            'Vision Camera Verification
            If PLC_DriverCLX.Read(PLC_Tags.plcTag_BracketVerifyStart) Then
                lblmessagedesc.Text = "Vision Camera Verification Recieved"
                If Not INRoutines Then
                    Do While PLC_DriverCLX.Read(PLC_Tags.plcTag_BracketVerifyStart)
                        PLC_DriverCLX.Write(PLC_Tags.plcTag_BracketVerifyStart, 0)
                    Loop
                    PLCIO(4) = True
                End If
            End If
            '
            'Light Controls
            If PLC_DriverCLX.Read(PLC_Tags.plcTag_OverLight) Then 'Main Conveyor overhead light
                lblOverheadLight.BackColor = Color.White
            Else
                lblOverheadLight.BackColor = System.Drawing.SystemColors.Control
            End If
            '
            If PLC_DriverCLX.Read(PLC_Tags.plcTag_Backlight) Then 'Conveyor Backlight
                lblbacklight.BackColor = Color.White
            Else
                lblbacklight.BackColor = System.Drawing.SystemColors.Control
            End If

            If PLC_DriverCLX.Read("Vis_Lights.7") Then 'Turn the Bracket Primer/Tape Light 
                lblbacklightPrimer.BackColor = Color.White
            Else
                lblbacklightPrimer.BackColor = System.Drawing.SystemColors.Control
            End If

            'all cameras are online now check for gocator
            Dim GoCatorResult As Boolean
            GoCatorResult = My.Computer.Network.Ping("192.168.1.10")
            If GoCatorResult Then
                lblLaser.BackColor = Color.YellowGreen
            Else
                DebugGocator = DebugGocator + 1
                lblGocater.Text = "Gocator Offline Times: " & DebugGocator
                lblLaser.BackColor = Color.Red
            End If
            'Check Passfail on the trademark inspection system
            If PLC_DriverCLX.Read("Vis_Cam_TM.Passed") Then
                lblTrademarkInspection.BackColor = Color.YellowGreen
            ElseIf PLC_DriverCLX.Read("Vis_Cam_TM.Failed") Then
                lblTrademarkInspection.BackColor = Color.Red
            End If
            'Reset Label colors to default
            If PLC_DriverCLX.Read("Vis_PC_Inspections.15") Then
                PLCIO(6) = True
                PLC_DriverCLX.Write("Vis_PC_Inspections.15", 0)
            End If
        Catch ex As Exception
            ShowVBErrors("PLC_Read_IO", ex.Message)
        End Try
    End Sub

    Public Sub PLC_Glass_Location()
        'Locate Paint Patch for Bracket Location
        If mnuTabSwitching.Checked Then TabControlsMain.SelectedTab = tabPageBracketLocate
        Dim Success As Boolean
        Try
            INRoutines = True
            Success = HelperCamCenter.SetSimpleFeature("exposure", updnExposureLocateGlass.Value, Camera.LocateGlass)
            Success = HelperCamCenter.SetSimpleFeature("gain", updnContrastLocateGlass.Value, Camera.LocateGlass)
            Snap(Camera.LocateGlass)
            If Not Success Then ShowVBErrors("PLC_Glass_Location", "Exposure/Gain glass location Unable to set")
            '
            Success = Locate(Camera.LocateGlass, True, False)
            '
            If Success Then
                ''PLC_DriverCLX.Write(PLC_Tags.plcTag_BracketGlassLocationX, PLC_IO_Write_Bracket(0).Vision_Data_X)
                ''PLC_DriverCLX.Write(PLC_Tags.plcTag_BracketGlassLocationY, PLC_IO_Write_Bracket(0).Vision_Data_Y)
                ''PLC_DriverCLX.Write(PLC_Tags.plcTag_BracketGlassLocationR, PLC_IO_Write_Bracket(0).Vision_Data_R)
                '	'PLC_DriverCLX.Write(PLC_Tags.plcTag_BracketGlassLocationStat, PLC_IO_Write_Bracket(0).VisStat)
                ''PLC_DriverCLX.Write(PLC_Tags.plcTag_BracketGlassLocationDone, 1)
                lblmessagedesc.Text = "Glass Locate Passed"
            Else
                ''PLC_DriverCLX.Write(PLC_Tags.plcTag_BracketGlassLocationStat, PLC_IO_Write_Bracket(0).VisStat)
                lblmessagedesc.Text = "Glass Locate Failed"
                ''PLC_DriverCLX.Write(PLC_Tags.plcTag_BracketGlassLocationDone, 1)
            End If
            INRoutines = False
        Catch ex As Exception
            ShowVBErrors("PLC_Bracket_Glass_Location", ex.Message)
            INRoutines = False
        End Try
    End Sub

    Public Sub PLC_Check_Glass_Primer(ButtonName As String)
        Dim SuccessDriver As Boolean = False
        Dim SuccessPassenger As Boolean = False
        Dim Fail As Boolean = True
        'This Routines inspects both the Driver and Passenger Arron Mighty Primer
        Try
            INRoutines = True
            '
            'Select the tab based on if the "RUN" button was pushed or if the Driver inspection failed
            If ButtonName = btnMainRunDriverInspec.Name Then TabControlsMain.SelectedTab = tabPageDriverCam
            SuccessDriver = Locate(Camera.Driver, True, True)
            If Not SuccessDriver Then TabControlsMain.SelectedTab = tabPageDriverCam
            '
            'Select the tab based on if the "RUN" button was pushed or if the Passenger inspection failed
            If ButtonName = btnMainRunPassengerInspec.Name Then TabControlsMain.SelectedTab = tabPagePassCam
            SuccessPassenger = Locate(Camera.Passenger, True, True)
            If Not SuccessPassenger Then TabControlsMain.SelectedTab = tabPagePassCam
            '
            If SuccessDriver And SuccessPassenger Then
                PLC_DriverCLX.Write(PLC_Tags.plcTag_PrimerCheckPass, 1)
                PLC_DriverCLX.Write(PLC_Tags.plcTag_PrimerCheckDone, 1)
                lblmessagedesc.Text = "Primer Check Inpection Passed"
            Else
                PLC_DriverCLX.Write(PLC_Tags.plcTag_PrimerCheckFail, 1)
                PLC_DriverCLX.Write(PLC_Tags.plcTag_PrimerCheckDone, 1)
                lblmessagedesc.Text = "Primer Check Inpection Failed"
            End If
            If DriverBlobArea > 0 Then
                If (DriverBlobArea > DriverBlobVariance) Then
                    lblDriverInspection.BackColor = Color.YellowGreen
                Else
                    lblDriverInspection.BackColor = Color.Red
                    lblVisionMessageDriver.Text = "Primer Area Below Threshold levels"
                    lblVisionMessageDriver.BackColor = Color.Red
                End If
            Else
                lblVisionMessageDriver.BackColor = Color.Red
            End If
            INRoutines = False
        Catch ex As Exception
            ShowVBErrors("PLC_Check_Primer", ex.Message)
            INRoutines = False
        End Try
    End Sub

    Public Sub PLC_Check_H_Primer()
        Dim Success As Boolean
        Try
            INRoutines = True
            If mnuTabSwitching.Checked Then TabControlsMain.SelectedTab = tabPageCenterCam
            Success = Locate(Camera.Center, True, True)
            If Not Success Then
                PLC_DriverCLX.Write(PLC_Tags.plcTag_HPrimerFail, 1)
                PLC_DriverCLX.Write(PLC_Tags.plcTag_HPrimerDone, 1)
                lblmessagedesc.Text = "H Primer Check Inpection Failed"
            Else
                PLC_DriverCLX.Write(PLC_Tags.plcTag_HPrimerPass, 1)
                PLC_DriverCLX.Write(PLC_Tags.plcTag_HPrimerDone, 1)
                lblmessagedesc.Text = "H Primer Check Inpection Passed"
            End If
            INRoutines = False
        Catch ex As Exception
            ShowVBErrors("PLC_Check_H_Primer", ex.Message)
            INRoutines = False
        End Try
    End Sub

    Public Sub PLC_Bracket_DialTable_Location()
        Try
            If mnuTabSwitching.Checked Then TabControlsMain.SelectedTab = tabpageBracketLocateAtConveyor

            INRoutines = True
            Dim Success As Boolean
            '
            Success = HelperCamBracket.SetSimpleFeature("exposure", updnExposureBracketConveyor.Value, Camera.BracketAtDialTable)
            Success = HelperCamBracket.SetSimpleFeature("gain", updnContrastBracketConveyor.Value, Camera.BracketAtDialTable)
            Snap(Camera.BracketAtDialTable)
            If Not Success Then ShowVBErrors("PLC_Bracket_Conveyor_Location", "Exposure/Gain Conveyor Location Unable to set")
            '
            Success = Locate(Camera.BracketAtDialTable, True, False)
            If Success Then
                PLC_DriverCLX.Write((PLC_Tags.plcTag_BracketDialTableLocationX), PLC_IO_Write_Bracket(1).Vision_Data_X)
                PLC_DriverCLX.Write((PLC_Tags.plcTag_BracketDialTableLocationY), PLC_IO_Write_Bracket(1).Vision_Data_Y)
                PLC_DriverCLX.Write((PLC_Tags.plcTag_BracketDialTableLocationR), PLC_IO_Write_Bracket(1).Vision_Data_R)
                PLC_DriverCLX.Write(PLC_Tags.plcTag_BracketDialTableLocationDone, 1)
                PLC_DriverCLX.Write(PLC_Tags.plcTag_BracketDialTableLocationStat, PLC_IO_Write_Bracket(1).VisStat)
                lblmessagedesc.Text = "Bracket Conveyor Locator Passed"
            Else
                PLC_DriverCLX.Write(PLC_Tags.plcTag_BracketDialTableLocationStat, PLC_IO_Write_Bracket(1).VisStat)
                lblmessagedesc.Text = "Bracket Conveyor Locator Failed"
                PLC_DriverCLX.Write(PLC_Tags.plcTag_BracketDialTableLocationDone, 1)
            End If
            INRoutines = False
        Catch ex As Exception
            ShowVBErrors("PLC_Bracket_Conveyor_Location", ex.Message)
            INRoutines = False
        End Try
    End Sub

    Public Sub PLC_Vision_Camera_Verify()
        Try
            If mnuTabSwitching.Checked Then TabControlsMain.SelectedTab = tabPageCenterBracketVerify
            Dim Success As Boolean
            INRoutines = True
            '
            Success = HelperCamCenter.SetSimpleFeature("exposure", updnExposureCenterVerify.Value, Camera.BracketVerify)
            Success = HelperCamCenter.SetSimpleFeature("gain", updnContrastCenterVerify.Value, Camera.BracketVerify)
            Snap(Camera.BracketVerify)
            If Not Success Then ShowVBErrors("PLC_Vision_Camera_Verify", "Exposure/Gain Camera Verify Unable to set")
            '
            Success = Locate(Camera.BracketVerify, True, True)
            If Not Success Then
                PLC_DriverCLX.Write(PLC_Tags.plcTag_BracketVerifyFail, 1)
                PLC_DriverCLX.Write(PLC_Tags.plcTag_BracketVerifyDone, 1)
                lblmessagedesc.Text = "Bracket Verification Failed "
                lblBracketInspectionVerify.BackColor = Color.Red
            Else
                PLC_DriverCLX.Write(PLC_Tags.plcTag_BracketVerifyPass, 1)
                PLC_DriverCLX.Write(PLC_Tags.plcTag_BracketVerifyDone, 1)
                lblmessagedesc.Text = "Bracket Verification Passed "
                lblBracketInspectionVerify.BackColor = Color.YellowGreen
            End If
            INRoutines = False
        Catch ex As Exception
            ShowVBErrors("PLC_Vision_Camera_Verify", ex.Message)
            INRoutines = False
        End Try

    End Sub

    Public Sub lblReset(sender As Object, e As EventArgs) Handles lblmessagedesc.DoubleClick, lblVisionMessageBracket.DoubleClick, lblVisionMessageBracketConveyor.DoubleClick,
                                    lblVisionMessageBracketPrimer.DoubleClick, lblVisionMessageBracketTape.DoubleClick, lblVisionMessageBracketVerify.DoubleClick, lblVisionMessageCenter.DoubleClick,
                                    lblVisionMessageDriver.DoubleClick, lblVisionMessagePassenger.DoubleClick
        Dim lbl As Label
        lbl = DirectCast(sender, Label)
        lbl.Text = ""
        lbl.BackColor = SystemColors.Control
    End Sub

    Private Sub TabControlsMain_DrawItem(sender As Object, e As DrawItemEventArgs) Handles TabControlsMain.DrawItem
        Dim tabBounds As Rectangle = e.Bounds
        Select Case e.Index
            Case 0
                e.Graphics.FillRectangle(New SolidBrush(Color.OldLace), e.Bounds)
            Case 1
                e.Graphics.FillRectangle(New SolidBrush(Color.OldLace), e.Bounds)
            Case 2
                e.Graphics.FillRectangle(New SolidBrush(Color.OldLace), e.Bounds)
            Case 3
                e.Graphics.FillRectangle(New SolidBrush(Color.NavajoWhite), e.Bounds)
            Case 4
                e.Graphics.FillRectangle(New SolidBrush(Color.NavajoWhite), e.Bounds)
            Case 5
                e.Graphics.FillRectangle(New SolidBrush(Color.Aquamarine), e.Bounds)
            Case 6
                e.Graphics.FillRectangle(New SolidBrush(Color.Aquamarine), e.Bounds)
            Case 7
                e.Graphics.FillRectangle(New SolidBrush(Color.Aquamarine), e.Bounds)
            Case 8
                e.Graphics.FillRectangle(New SolidBrush(Color.PaleTurquoise), e.Bounds)
            Case 9
                e.Graphics.FillRectangle(New SolidBrush(Color.PaleTurquoise), e.Bounds)
        End Select
        tabBounds.Inflate(-2, -2)
        e.Graphics.DrawString(TabControlsMain.TabPages(e.Index).Text, Me.Font, SystemBrushes.WindowText, tabBounds)
    End Sub

    Private Sub HSDisplayLocateGlass_DisplayMouseDown(sender As Object, e As _DHSDisplayEvents_DisplayMouseDownEvent) Handles HSDisplayLocateGlass.DisplayMouseDown
        LocX = e.x
        LocY = e.y
    End Sub

    Private Sub HSDisplayLocateGlass_DblClick(sender As Object, e As EventArgs) Handles HSDisplayLocateGlass.DblClick
        'MsgBox("X " & LocX & " Y " & LocY)
    End Sub

    Public Function pythagoreanTheorem(side1 As Int16, side2 As Int16, side3 As Int16) As String
        Dim Value As String = ""
        If side1 = 0 Then
            side1 = Math.Sqrt((side2 ^ 2) - (side3 ^ 2))
            Value = side1
            Return Value
        ElseIf side2 = 0 Then
            side2 = Math.Sqrt((side1 ^ 2) + (side3 ^ 2))
            Value = side2
            Return Value
        ElseIf side3 = 0 Then
            side3 = Math.Sqrt((side2 ^ 2) - (side1 ^ 2))
            Value = side3
            Return Value
        End If
        Return Value
    End Function

#End Region

    Private Sub BtnTest_Click(sender As Object, e As EventArgs) Handles btnTest.Click
        DrawRectangleMarker(HSDisplayBracketConveyor, "Search Region 1", 100, 100, 0, 100, 200, HSDISPLAYLib.hsColor.hsGreen, hsRectangleMarkerConstraints.hsRectangleCornerBasedEdition)
    End Sub

#Region "Upgrade SQL CE Engine 3.5 - 4.0"

    Public Shared Sub Upgrade(ByVal fileName As String, ByVal password As String)
        If String.IsNullOrEmpty(fileName) OrElse password Is Nothing Then Throw New Exception("Unable to create connection string because filename or password was not defined")

        Try
            Dim connectionString = String.Format("Data source={0};Password={1};Persist Security Info=False;", fileName, password)
            Dim engine = New SqlCeEngine(connectionString)
            engine.Upgrade()
        Catch ex As Exception
            Throw (ex)
        End Try
    End Sub

#End Region

End Class
