<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmMain
#Region "Windows Form Designer generated code "
  <System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
    MyBase.New()
    'This call is required by the Windows Form Designer.
    InitializeComponent()
  End Sub
  'Form overrides dispose to clean up the component list.
  <System.Diagnostics.DebuggerNonUserCode()> Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
    If Disposing Then
      If Not components Is Nothing Then
        components.Dispose()
      End If
    End If
    MyBase.Dispose(Disposing)
  End Sub
  'Required by the Windows Form Designer
  Public InitializingForm As Boolean = True
  Private components As System.ComponentModel.IContainer
  Public WithEvents mnuLoadPart As System.Windows.Forms.ToolStripMenuItem
  Public WithEvents mnuNew As System.Windows.Forms.ToolStripMenuItem
  Public WithEvents mnuDeletePart As System.Windows.Forms.ToolStripMenuItem
  Public WithEvents mnuSeperator1 As System.Windows.Forms.ToolStripSeparator
  Public WithEvents mnuPassword As System.Windows.Forms.ToolStripMenuItem
  Public WithEvents mnuQuit As System.Windows.Forms.ToolStripMenuItem
  Public WithEvents mnuFile As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuGeneralDatabaseSettings As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuPositionalSettings As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuSeperator3 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents mnuConfig As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuHelp As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents MainMenu1 As System.Windows.Forms.MenuStrip
	Public WithEvents tmrLocateTime As System.Windows.Forms.Timer
	Public WithEvents tmrSnapDelay As System.Windows.Forms.Timer
	Public WithEvents lblPartLoaded As System.Windows.Forms.Label
	Public WithEvents lblPartTitle As System.Windows.Forms.Label

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
		Me.MainMenu1 = New System.Windows.Forms.MenuStrip()
		Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuLoadPart = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuNew = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuPartSettings = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuDeletePart = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuSeperator1 = New System.Windows.Forms.ToolStripSeparator()
		Me.mnuPassword = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuQuit = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuConfig = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuGeneralDatabaseSettings = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuBracketSettings = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuPositionalSettings = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuSeperator3 = New System.Windows.Forms.ToolStripSeparator()
		Me.mnuCalibration = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuModifyHexsightControls = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuCalibrateBracket = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuCalibrateCenter = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuCalibrateDriver = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuCalibratePassenger = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuSeperator2 = New System.Windows.Forms.ToolStripSeparator()
		Me.mnuVerifyVisionAccuracy = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuTabSwitching = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuSaveVerification = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem()
		Me.SystemManualToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuCameraCalibration = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuSystemDocumentation = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
		Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.lblPartLoaded = New System.Windows.Forms.Label()
		Me.lblPartTitle = New System.Windows.Forms.Label()
		Me.tmrDelay = New System.Windows.Forms.Timer(Me.components)
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
		Me.lblVisionMessageBracket = New System.Windows.Forms.Label()
		Me.btnDetailsBracket = New System.Windows.Forms.Button()
		Me.btnSnapLocateGlass = New System.Windows.Forms.Button()
		Me.btnTrainExistingLocateGlass = New System.Windows.Forms.Button()
		Me.btnTrainNewLocateGlass = New System.Windows.Forms.Button()
		Me.btnSearchSettingsLocateGlass = New System.Windows.Forms.Button()
		Me.updnScoreLimit = New System.Windows.Forms.NumericUpDown()
		Me.btnLocateLocateGlass = New System.Windows.Forms.Button()
		Me.btnLocateOnlyLocateGlass = New System.Windows.Forms.Button()
		Me.updnLocationX = New System.Windows.Forms.NumericUpDown()
		Me.updnLocationY = New System.Windows.Forms.NumericUpDown()
		Me.updnLocationR = New System.Windows.Forms.NumericUpDown()
		Me.btnLocationAdjCancel = New System.Windows.Forms.Button()
		Me.btnLocationAdjOK = New System.Windows.Forms.Button()
		Me.btnDetailsDriver = New System.Windows.Forms.Button()
		Me.lblVisionMessageDriver = New System.Windows.Forms.Label()
		Me.btnDetailsCenter = New System.Windows.Forms.Button()
		Me.lblVisionMessageCenter = New System.Windows.Forms.Label()
		Me.btnDetailsPassenger = New System.Windows.Forms.Button()
		Me.lblVisionMessagePassenger = New System.Windows.Forms.Label()
		Me.btnDetailsBracketConveyor = New System.Windows.Forms.Button()
		Me.lblVisionMessageBracketConveyor = New System.Windows.Forms.Label()
		Me.btnDetailsBracketTape = New System.Windows.Forms.Button()
		Me.lblVisionMessageBracketTape = New System.Windows.Forms.Label()
		Me.btnDetailsBracketVerify = New System.Windows.Forms.Button()
		Me.lblVisionMessageBracketVerify = New System.Windows.Forms.Label()
		Me.btnSnapBracketConveyor = New System.Windows.Forms.Button()
		Me.btnLocateOnlyBracketConveyor = New System.Windows.Forms.Button()
		Me.btnLocateBracketConveyor = New System.Windows.Forms.Button()
		Me.updnScoreLimitBracketconveyor = New System.Windows.Forms.NumericUpDown()
		Me.btnSearchSettingsBracketConveyor = New System.Windows.Forms.Button()
		Me.btnTrainNewBracketconveyor = New System.Windows.Forms.Button()
		Me.btnTrainExistingBracketConveyor = New System.Windows.Forms.Button()
		Me.btnSnapBracketTape = New System.Windows.Forms.Button()
		Me.btnLocateOnlyBracketTape = New System.Windows.Forms.Button()
		Me.btnLocateBracketTape = New System.Windows.Forms.Button()
		Me.btnSearchSettingsBracketTape = New System.Windows.Forms.Button()
		Me.btnTrainNewBracketTape = New System.Windows.Forms.Button()
		Me.btnTrainExistingBracketTape = New System.Windows.Forms.Button()
		Me.btnSnapCenterVerify = New System.Windows.Forms.Button()
		Me.btnLocateOnlyBracketVerify = New System.Windows.Forms.Button()
		Me.btnLocateBracketVerify = New System.Windows.Forms.Button()
		Me.updnScoreLimitCenterVerify = New System.Windows.Forms.NumericUpDown()
		Me.btnSearchSettingsCenterVerify = New System.Windows.Forms.Button()
		Me.btnTrainNewCenterVerify = New System.Windows.Forms.Button()
		Me.btnTrainExistingCenterVerify = New System.Windows.Forms.Button()
		Me.btnSnapDriver = New System.Windows.Forms.Button()
		Me.btnLocateOnlyDriver = New System.Windows.Forms.Button()
		Me.btnLocateDriver = New System.Windows.Forms.Button()
		Me.updnScoreLimitDriver = New System.Windows.Forms.NumericUpDown()
		Me.btnSearchSettingsDriver = New System.Windows.Forms.Button()
		Me.btnTrainNewDriver = New System.Windows.Forms.Button()
		Me.btnTrainExistingDriver = New System.Windows.Forms.Button()
		Me.btnSnapCenter = New System.Windows.Forms.Button()
		Me.btnLocateOnlyCenter = New System.Windows.Forms.Button()
		Me.btnLocateCenter = New System.Windows.Forms.Button()
		Me.updnScoreLimitCenter = New System.Windows.Forms.NumericUpDown()
		Me.btnSearchSettingsCenter = New System.Windows.Forms.Button()
		Me.btnTrainNewCenter = New System.Windows.Forms.Button()
		Me.btnTrainExistingCenter = New System.Windows.Forms.Button()
		Me.btnSnapPassenger = New System.Windows.Forms.Button()
		Me.btnLocateOnlyPassenger = New System.Windows.Forms.Button()
		Me.btnLocatePassenger = New System.Windows.Forms.Button()
		Me.updnScoreLimitPassenger = New System.Windows.Forms.NumericUpDown()
		Me.btnSearchSettingsPassenger = New System.Windows.Forms.Button()
		Me.btnTrainNewPassenger = New System.Windows.Forms.Button()
		Me.btnTrainExistingPassenger = New System.Windows.Forms.Button()
		Me.btnDriverTrainBlob = New System.Windows.Forms.Button()
		Me.btnDriverSaveBlob = New System.Windows.Forms.Button()
		Me.btnCenterSaveBlob = New System.Windows.Forms.Button()
		Me.btnCenterTrainBlob = New System.Windows.Forms.Button()
		Me.btnPassengerSaveBlob = New System.Windows.Forms.Button()
		Me.btnPassengerTrainBlob = New System.Windows.Forms.Button()
		Me.btnSnapBracketPrimer = New System.Windows.Forms.Button()
		Me.btnBracketPrimerDetails = New System.Windows.Forms.Button()
		Me.lblVisionMessageBracketPrimer = New System.Windows.Forms.Label()
		Me.btnLocateOnlyBracketPrimer = New System.Windows.Forms.Button()
		Me.btnLocateBracketPrimer = New System.Windows.Forms.Button()
		Me.updnScoreLimitBracketPrimer = New System.Windows.Forms.NumericUpDown()
		Me.btnSearchSettingsBracketPrimer = New System.Windows.Forms.Button()
		Me.btnTrainNewBracketPrimer = New System.Windows.Forms.Button()
		Me.btnTrainExistingBracketPrimer = New System.Windows.Forms.Button()
		Me.updnLocationZ = New System.Windows.Forms.NumericUpDown()
		Me.btnDepositAdjRPlus = New System.Windows.Forms.Button()
		Me.btnDepositAdjRMinus = New System.Windows.Forms.Button()
		Me.btnDepositAdjYPlus = New System.Windows.Forms.Button()
		Me.btnDepositAdjYMinus = New System.Windows.Forms.Button()
		Me.btnDepositAdjXPlus = New System.Windows.Forms.Button()
		Me.btnDepositAdjXMinus = New System.Windows.Forms.Button()
		Me.btnSaveBracketPrimer1 = New System.Windows.Forms.Button()
		Me.btnTrainBracketPrimer1 = New System.Windows.Forms.Button()
		Me.btnSaveBracketPrimer2 = New System.Windows.Forms.Button()
		Me.btnTrainBracketPrimer2 = New System.Windows.Forms.Button()
		Me.btnSaveBracketPrimer3 = New System.Windows.Forms.Button()
		Me.btnTrainBracketPrimer3 = New System.Windows.Forms.Button()
		Me.btnSaveBracketPrimer4 = New System.Windows.Forms.Button()
		Me.btnTrainBracketPrimer4 = New System.Windows.Forms.Button()
		Me.btnSaveBracketPrimer5 = New System.Windows.Forms.Button()
		Me.btnTrainBracketPrimer5 = New System.Windows.Forms.Button()
		Me.btnSaveBracketPrimerReference = New System.Windows.Forms.Button()
		Me.btnTrainBracketPrimerReference = New System.Windows.Forms.Button()
		Me.updnScoreLimitTapeBracketLocator = New System.Windows.Forms.NumericUpDown()
		Me.TmrPassword = New System.Windows.Forms.Timer(Me.components)
		Me.tmrDisplayUpdate = New System.Windows.Forms.Timer(Me.components)
		Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
		Me.tabVisionRobot = New System.Windows.Forms.TabControl()
		Me.tabPageRobot = New System.Windows.Forms.TabPage()
		Me.GrpRobot = New System.Windows.Forms.GroupBox()
		Me.Label24 = New System.Windows.Forms.Label()
		Me.Label23 = New System.Windows.Forms.Label()
		Me.Label22 = New System.Windows.Forms.Label()
		Me.Label21 = New System.Windows.Forms.Label()
		Me.Label20 = New System.Windows.Forms.Label()
		Me.Label19 = New System.Windows.Forms.Label()
		Me.Label18 = New System.Windows.Forms.Label()
		Me.Label17 = New System.Windows.Forms.Label()
		Me.Label16 = New System.Windows.Forms.Label()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.lblStatus = New System.Windows.Forms.Label()
		Me.lblHeartBeat = New System.Windows.Forms.Label()
		Me.lblmessagedesc = New System.Windows.Forms.Label()
		Me.grpResults = New System.Windows.Forms.GroupBox()
		Me.btnShiftCntrs = New System.Windows.Forms.Button()
		Me.lblCenterInspection = New System.Windows.Forms.Label()
		Me.btnMainRunGlassInspection = New System.Windows.Forms.Button()
		Me.btnMainRunCenterInspec = New System.Windows.Forms.Button()
		Me.lblBracketInspection = New System.Windows.Forms.Label()
		Me.lblGocater = New System.Windows.Forms.Label()
		Me.btnMainRunTrademark = New System.Windows.Forms.Button()
		Me.updnGocator = New System.Windows.Forms.NumericUpDown()
		Me.lblBracketInspectionVerify = New System.Windows.Forms.Label()
		Me.btnMainRunBracketVerify = New System.Windows.Forms.Button()
		Me.lblTrademarkInspection = New System.Windows.Forms.Label()
		Me.btnBacklightPrimer = New System.Windows.Forms.Button()
		Me.lblbacklightPrimer = New System.Windows.Forms.Label()
		Me.lblLaser = New System.Windows.Forms.Label()
		Me.lblBracketInspectionPrimer = New System.Windows.Forms.Label()
		Me.btnMainRunBracketInspectionPrimer = New System.Windows.Forms.Button()
		Me.lblbacklight = New System.Windows.Forms.Label()
		Me.btnBacklight = New System.Windows.Forms.Button()
		Me.lblOverheadLight = New System.Windows.Forms.Label()
		Me.btnOverheadLight = New System.Windows.Forms.Button()
		Me.lblGlueApplication = New System.Windows.Forms.Label()
		Me.lblBracketInspectionTape = New System.Windows.Forms.Label()
		Me.btnMainRunPassengerInspec = New System.Windows.Forms.Button()
		Me.lblBracketInspectionConveyor = New System.Windows.Forms.Label()
		Me.btnMainRunDriverInspec = New System.Windows.Forms.Button()
		Me.btnMainRunBracketInspectionTape = New System.Windows.Forms.Button()
		Me.lblPassengerInspection = New System.Windows.Forms.Label()
		Me.btnMainRunBracketInspectionConveyor = New System.Windows.Forms.Button()
		Me.lblDriverInspection = New System.Windows.Forms.Label()
		Me.lblPhone = New System.Windows.Forms.Label()
		Me.picLogo = New System.Windows.Forms.PictureBox()
		Me.TabControlsMain = New System.Windows.Forms.TabControl()
		Me.tabPageBracketLocateTape = New System.Windows.Forms.TabPage()
		Me.grpVisionBracketLocateTape = New System.Windows.Forms.GroupBox()
		Me.gprBracketTapeCoverSettings = New System.Windows.Forms.GroupBox()
		Me.lblCoverFoundArea = New System.Windows.Forms.Label()
		Me.rdoCoverTopRight = New System.Windows.Forms.RadioButton()
		Me.lblCoverAreaTopLeft = New System.Windows.Forms.Label()
		Me.rdoCoverBottomLeft = New System.Windows.Forms.RadioButton()
		Me.lblCoverMaxArea = New System.Windows.Forms.Label()
		Me.rdoCoverBottomRight = New System.Windows.Forms.RadioButton()
		Me.lblCoverAreaBottomRight = New System.Windows.Forms.Label()
		Me.btnTrainCoverArea = New System.Windows.Forms.Button()
		Me.rdoCoverTopLeft = New System.Windows.Forms.RadioButton()
		Me.btnSaveCoverArea = New System.Windows.Forms.Button()
		Me.lblCoverAreaBottomLeft = New System.Windows.Forms.Label()
		Me.lblCoverMinThreshold = New System.Windows.Forms.Label()
		Me.updnCoverMaxAreaBottomRight = New System.Windows.Forms.NumericUpDown()
		Me.updnCoverBlobMinBottomRight = New System.Windows.Forms.NumericUpDown()
		Me.lblCoverAreaTopRight = New System.Windows.Forms.Label()
		Me.updnCoverMaxAreaBottomLeft = New System.Windows.Forms.NumericUpDown()
		Me.updnCoverBlobMinTopLeft = New System.Windows.Forms.NumericUpDown()
		Me.lblCoverTopLeft = New System.Windows.Forms.Label()
		Me.updnCoverMaxAreaTopRight = New System.Windows.Forms.NumericUpDown()
		Me.lblCoverTopRight = New System.Windows.Forms.Label()
		Me.lblCoverBottomLeft = New System.Windows.Forms.Label()
		Me.updnCoverMaxAreaTopLeft = New System.Windows.Forms.NumericUpDown()
		Me.updnCoverBlobMinTopRight = New System.Windows.Forms.NumericUpDown()
		Me.updnCoverBlobMinBottomLeft = New System.Windows.Forms.NumericUpDown()
		Me.lblCoverBottomRight = New System.Windows.Forms.Label()
		Me.gprBracketTapeBlobControls = New System.Windows.Forms.GroupBox()
		Me.lblTapeFoundArea = New System.Windows.Forms.Label()
		Me.rdoTapeTopRight = New System.Windows.Forms.RadioButton()
		Me.lblTapeAreaTopLeft = New System.Windows.Forms.Label()
		Me.rdoTapeBottomLeft = New System.Windows.Forms.RadioButton()
		Me.lblTapeMinArea = New System.Windows.Forms.Label()
		Me.rdoTapeBottomRight = New System.Windows.Forms.RadioButton()
		Me.lblTapeAreaBottomRight = New System.Windows.Forms.Label()
		Me.btnTrainTapeArea = New System.Windows.Forms.Button()
		Me.rdoTapeTopLeft = New System.Windows.Forms.RadioButton()
		Me.btnSaveTapeArea = New System.Windows.Forms.Button()
		Me.lblTapeAreaBottomLeft = New System.Windows.Forms.Label()
		Me.lblTapeMinThreshold = New System.Windows.Forms.Label()
		Me.updnTapeMinAreaBottomRight = New System.Windows.Forms.NumericUpDown()
		Me.updnTapeBlobMinBottomRight = New System.Windows.Forms.NumericUpDown()
		Me.lblTapeMaxThreshold = New System.Windows.Forms.Label()
		Me.lblTapeAreaTopRight = New System.Windows.Forms.Label()
		Me.updnTapeBlobMaxBottomRight = New System.Windows.Forms.NumericUpDown()
		Me.updnTapeBlobMaxBottomLeft = New System.Windows.Forms.NumericUpDown()
		Me.updnTapeMinAreaBottomLeft = New System.Windows.Forms.NumericUpDown()
		Me.updnTapeBlobMinTopLeft = New System.Windows.Forms.NumericUpDown()
		Me.lblTapeTopLeft = New System.Windows.Forms.Label()
		Me.updnTapeBlobMaxTopLeft = New System.Windows.Forms.NumericUpDown()
		Me.updnTapeMinAreaTopRight = New System.Windows.Forms.NumericUpDown()
		Me.updnTapeBlobMaxTopRight = New System.Windows.Forms.NumericUpDown()
		Me.lblTapeTopRight = New System.Windows.Forms.Label()
		Me.lblTapeBottomLeft = New System.Windows.Forms.Label()
		Me.updnTapeMinAreaTopLeft = New System.Windows.Forms.NumericUpDown()
		Me.updnTapeBlobMinTopRight = New System.Windows.Forms.NumericUpDown()
		Me.updnTapeBlobMinBottomLeft = New System.Windows.Forms.NumericUpDown()
		Me.lblTapeBottomRight = New System.Windows.Forms.Label()
		Me.grpStatusBracketLocateTape = New System.Windows.Forms.GroupBox()
		Me.grpCameraControlLocateTape = New System.Windows.Forms.GroupBox()
		Me.lblCamControlAcqTimeBracketTape = New System.Windows.Forms.Label()
		Me.lblContrastBracketTape = New System.Windows.Forms.Label()
		Me.lblExposureBracketTape = New System.Windows.Forms.Label()
		Me.updnContrastBracketTape = New System.Windows.Forms.NumericUpDown()
		Me.updnExposureBracketTape = New System.Windows.Forms.NumericUpDown()
		Me.chkSnapRepeatBracketTape = New System.Windows.Forms.CheckBox()
		Me.lblCameraTimeBracketTape = New System.Windows.Forms.Label()
		Me.grpBracketTapeCamera = New System.Windows.Forms.GroupBox()
		Me.lblBracketTapeCameraWarning = New System.Windows.Forms.Label()
		Me.lblTemperatureBracketTape = New System.Windows.Forms.Label()
		Me.pbBracketTape = New System.Windows.Forms.PictureBox()
		Me.grpLocatorControlsBracketTape = New System.Windows.Forms.GroupBox()
		Me.lblVisionTapeScoreData = New System.Windows.Forms.Label()
		Me.Label9 = New System.Windows.Forms.Label()
		Me.lblVisionTapeTimeData = New System.Windows.Forms.Label()
		Me.lblVisionTapeRData = New System.Windows.Forms.Label()
		Me.lblVisionTapeYData = New System.Windows.Forms.Label()
		Me.lblVisionTapeXData = New System.Windows.Forms.Label()
		Me.chkLocateBracketTape = New System.Windows.Forms.CheckBox()
		Me.lblVisionTapeX = New System.Windows.Forms.Label()
		Me.lblVisionTapeY = New System.Windows.Forms.Label()
		Me.lblVisionTapeR = New System.Windows.Forms.Label()
		Me.lblLocateTimeBracketTape = New System.Windows.Forms.Label()
		Me.lblVisionTapeTime = New System.Windows.Forms.Label()
		Me.lblLocatorTimeBracketTape = New System.Windows.Forms.Label()
		Me.lblVisionTapeScore = New System.Windows.Forms.Label()
		Me.grpHSDisplayBracketTape = New System.Windows.Forms.GroupBox()
		Me.HSDisplayBracketTape = New AxHSDISPLAYLib.AxHSDisplay()
		Me.tabpageBracketPrimerVerify = New System.Windows.Forms.TabPage()
		Me.grpVisionBracketPrimer = New System.Windows.Forms.GroupBox()
		Me.grpBracketPrimerReference = New System.Windows.Forms.GroupBox()
		Me.lblBracketPrimerMeanValue = New System.Windows.Forms.Label()
		Me.grpBracketPrimer = New System.Windows.Forms.GroupBox()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.updnBracketPrimer5Deviation = New System.Windows.Forms.NumericUpDown()
		Me.updnBracketPrimer4Deviation = New System.Windows.Forms.NumericUpDown()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.updnBracketPrimer3Deviation = New System.Windows.Forms.NumericUpDown()
		Me.updnBracketPrimer2Deviation = New System.Windows.Forms.NumericUpDown()
		Me.updnBracketPrimer1Deviation = New System.Windows.Forms.NumericUpDown()
		Me.grpCameraControlPrimer = New System.Windows.Forms.GroupBox()
		Me.lblCamControlAcqTimeBracketPrimerDesc = New System.Windows.Forms.Label()
		Me.lblContrastBracketPrimer = New System.Windows.Forms.Label()
		Me.lblExposureBracketPrimer = New System.Windows.Forms.Label()
		Me.updnContrastBracketPrimer = New System.Windows.Forms.NumericUpDown()
		Me.updnExposureBracketPrimer = New System.Windows.Forms.NumericUpDown()
		Me.chkSnapRepeatBracketPrimer = New System.Windows.Forms.CheckBox()
		Me.lblCameraTimeBracketPrimer = New System.Windows.Forms.Label()
		Me.grpBracketPrimerCamera = New System.Windows.Forms.GroupBox()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.lblBracketPrimerCameraWarning = New System.Windows.Forms.Label()
		Me.lblTemperatureBracketPrimer = New System.Windows.Forms.Label()
		Me.pbBracketPrimer = New System.Windows.Forms.PictureBox()
		Me.grpStatusBracketLocatePrimer = New System.Windows.Forms.GroupBox()
		Me.lblFitBracketPrimer = New System.Windows.Forms.Label()
		Me.lblVisionPoseFirBracketPrimer = New System.Windows.Forms.Label()
		Me.lblVisionPoseFitBracketPrimer = New System.Windows.Forms.Label()
		Me.lblVisionPoseScoreBracketPrimer = New System.Windows.Forms.Label()
		Me.lblVisionPoseTimeBracketPrimer = New System.Windows.Forms.Label()
		Me.lblVisionPoseRBracketPrimer = New System.Windows.Forms.Label()
		Me.lblVisionPoseYBracketPrimer = New System.Windows.Forms.Label()
		Me.lblVisionPoseXBracketPrimer = New System.Windows.Forms.Label()
		Me.lblVisionXBracketPrimer = New System.Windows.Forms.Label()
		Me.lblVisionYBracketPrimer = New System.Windows.Forms.Label()
		Me.lblVisionAngleBracketPrimer = New System.Windows.Forms.Label()
		Me.lblVisionTimeBracketPrimer = New System.Windows.Forms.Label()
		Me.lblVisionScoreBracketPrimer = New System.Windows.Forms.Label()
		Me.grpLocatorControlsBracketPrimer = New System.Windows.Forms.GroupBox()
		Me.lblScoreLimitBracketPrimer = New System.Windows.Forms.Label()
		Me.chkLocateBracketPrimer = New System.Windows.Forms.CheckBox()
		Me.lblLocateTimeBracketPrimer = New System.Windows.Forms.Label()
		Me.lblLocatorTime2 = New System.Windows.Forms.Label()
		Me.grpHSDisplayBracketPrimer = New System.Windows.Forms.GroupBox()
		Me.HSDisplayBracketPrimer = New AxHSDISPLAYLib.AxHSDisplay()
		Me.tabpageBracketLocateAtConveyor = New System.Windows.Forms.TabPage()
		Me.grpVisionBracketLocateatConveyor = New System.Windows.Forms.GroupBox()
		Me.grpCameraControlLocateConveyor = New System.Windows.Forms.GroupBox()
		Me.lblCamControlAcqTimeBracketConveyor = New System.Windows.Forms.Label()
		Me.lblContrastBracketConveyor = New System.Windows.Forms.Label()
		Me.lblExposureBracketConveyor = New System.Windows.Forms.Label()
		Me.updnContrastBracketConveyor = New System.Windows.Forms.NumericUpDown()
		Me.updnExposureBracketConveyor = New System.Windows.Forms.NumericUpDown()
		Me.chkSnapRepeatBracketconveyor = New System.Windows.Forms.CheckBox()
		Me.lblCameraTimeBracketConveyor = New System.Windows.Forms.Label()
		Me.grpLocatorControlsBracketConveyor = New System.Windows.Forms.GroupBox()
		Me.lblScoreLimitBracketconveyor = New System.Windows.Forms.Label()
		Me.chkLocateBracketConveyor = New System.Windows.Forms.CheckBox()
		Me.lblLocateTimeBracketconveyor = New System.Windows.Forms.Label()
		Me.lblLocatorTimeBracketConveyor = New System.Windows.Forms.Label()
		Me.grpBrackConveyorCamera = New System.Windows.Forms.GroupBox()
		Me.lblBracketConveyorCameraWarning = New System.Windows.Forms.Label()
		Me.lblTemperatureBracketAtConveyor = New System.Windows.Forms.Label()
		Me.pbBracketConveyorCamera = New System.Windows.Forms.PictureBox()
		Me.grpStatusBracketLocateAtConveoyr = New System.Windows.Forms.GroupBox()
		Me.lblFitBracketConveyor = New System.Windows.Forms.Label()
		Me.lblVisionPoseFirBracketConveyor = New System.Windows.Forms.Label()
		Me.lblVisionPoseFitBracketConveyor = New System.Windows.Forms.Label()
		Me.lblVisionPoseScoreBracketConveyor = New System.Windows.Forms.Label()
		Me.lblVisionPoseTimeBracketConveyor = New System.Windows.Forms.Label()
		Me.lblVisionPoseRBracketConveyor = New System.Windows.Forms.Label()
		Me.lblVisionPoseYBracketConveyor = New System.Windows.Forms.Label()
		Me.lblVisionPoseXBracketConveyor = New System.Windows.Forms.Label()
		Me.lblVisionXBracketConveyor = New System.Windows.Forms.Label()
		Me.lblVisionYBracketConveyor = New System.Windows.Forms.Label()
		Me.lblVisionAngleBracketConveyor = New System.Windows.Forms.Label()
		Me.lblVisionTimeBracketConveyor = New System.Windows.Forms.Label()
		Me.lblVisionScoreBracketConveyor = New System.Windows.Forms.Label()
		Me.grpHSDisplayBracketConveyor = New System.Windows.Forms.GroupBox()
		Me.HSDisplayBracketConveyor = New AxHSDISPLAYLib.AxHSDisplay()
		Me.tabPageBracketLocate = New System.Windows.Forms.TabPage()
		Me.grpVisionGlassLocate = New System.Windows.Forms.GroupBox()
		Me.grpCameraControl = New System.Windows.Forms.GroupBox()
		Me.lblCamControlAcqTime = New System.Windows.Forms.Label()
		Me.lblContrastValueWest = New System.Windows.Forms.Label()
		Me.lblBrightnessValueWest = New System.Windows.Forms.Label()
		Me.lblExposureValueWest = New System.Windows.Forms.Label()
		Me.lblContrast = New System.Windows.Forms.Label()
		Me.lblExposure = New System.Windows.Forms.Label()
		Me.updnContrastLocateGlass = New System.Windows.Forms.NumericUpDown()
		Me.updnExposureLocateGlass = New System.Windows.Forms.NumericUpDown()
		Me.chkSnapRepeatLocateGlass = New System.Windows.Forms.CheckBox()
		Me.lblCameraTime = New System.Windows.Forms.Label()
		Me.grpLocatorControls = New System.Windows.Forms.GroupBox()
		Me.lblScoreLimit = New System.Windows.Forms.Label()
		Me.chkLocateRepeatLocateGlass = New System.Windows.Forms.CheckBox()
		Me.lblLocateTime = New System.Windows.Forms.Label()
		Me.lblLocatorTime = New System.Windows.Forms.Label()
		Me.grpGlassLocate = New System.Windows.Forms.GroupBox()
		Me.btnCalcAngle = New System.Windows.Forms.Button()
		Me.lblPositionZ = New System.Windows.Forms.Label()
		Me.lblPositionRDesc = New System.Windows.Forms.Label()
		Me.lblPositionRDescminus = New System.Windows.Forms.Label()
		Me.lblPositionRDeg = New System.Windows.Forms.Label()
		Me.lblPositionYPlusDesc = New System.Windows.Forms.Label()
		Me.lblPositionXMMDesc = New System.Windows.Forms.Label()
		Me.lblPositionYDesc = New System.Windows.Forms.Label()
		Me.lblPositionModifyY = New System.Windows.Forms.Label()
		Me.lblPositionModiftX = New System.Windows.Forms.Label()
		Me.lblPositionModifyXMinus = New System.Windows.Forms.Label()
		Me.grpCameraStatus = New System.Windows.Forms.GroupBox()
		Me.lblCameraStatus = New System.Windows.Forms.Label()
		Me.lblTemperatureBracket = New System.Windows.Forms.Label()
		Me.pctTemperature = New System.Windows.Forms.PictureBox()
		Me.grpVisionStatus = New System.Windows.Forms.GroupBox()
		Me.lblFitBracket = New System.Windows.Forms.Label()
		Me.lblVisionPoseFirBracket = New System.Windows.Forms.Label()
		Me.lblVisionPoseFitBracket = New System.Windows.Forms.Label()
		Me.lblVisionPoseScoreBracket = New System.Windows.Forms.Label()
		Me.lblVisionPoseTimeBracket = New System.Windows.Forms.Label()
		Me.lblVisionPoseRBracket = New System.Windows.Forms.Label()
		Me.lblVisionPoseYBracket = New System.Windows.Forms.Label()
		Me.lblVisionPoseXBracket = New System.Windows.Forms.Label()
		Me.lblVisionXBracket = New System.Windows.Forms.Label()
		Me.lblVisionYBracket = New System.Windows.Forms.Label()
		Me.lblVisionAngleBracket = New System.Windows.Forms.Label()
		Me.lblVisionTimeBracket = New System.Windows.Forms.Label()
		Me.lblVisionScoreBracket = New System.Windows.Forms.Label()
		Me.grpHSDisplayGlassLocation = New System.Windows.Forms.GroupBox()
		Me.HSDisplayLocateGlass = New AxHSDISPLAYLib.AxHSDisplay()
		Me.tabPageCenterBracketVerify = New System.Windows.Forms.TabPage()
		Me.grpVisionCenterVerify = New System.Windows.Forms.GroupBox()
		Me.grpGlassVerifyValues = New System.Windows.Forms.GroupBox()
		Me.lblTopRight = New System.Windows.Forms.Label()
		Me.Label11 = New System.Windows.Forms.Label()
		Me.lblBottomLeft = New System.Windows.Forms.Label()
		Me.lblLength = New System.Windows.Forms.Label()
		Me.lblBottomLeftDifference = New System.Windows.Forms.Label()
		Me.lblTopRighttDifference = New System.Windows.Forms.Label()
		Me.lblBottomRightDifference = New System.Windows.Forms.Label()
		Me.Label10 = New System.Windows.Forms.Label()
		Me.txtVerifySavedDiffTopRight = New System.Windows.Forms.TextBox()
		Me.btnSaveVerifyDifference = New System.Windows.Forms.Button()
		Me.txtVerifySavedDiffBottomRight = New System.Windows.Forms.TextBox()
		Me.txtVerifySavedDiffBottomLeft = New System.Windows.Forms.TextBox()
		Me.lblVerifyMasterLengths = New System.Windows.Forms.Label()
		Me.lblAllowedVariance = New System.Windows.Forms.Label()
		Me.updnTopRightVerifyVariance = New System.Windows.Forms.NumericUpDown()
		Me.updnBottomRightVerifyVariance = New System.Windows.Forms.NumericUpDown()
		Me.updnBottomLeftVerifyVariance = New System.Windows.Forms.NumericUpDown()
		Me.lblVerifyTopRight = New System.Windows.Forms.Label()
		Me.lblVerifyBottomRight = New System.Windows.Forms.Label()
		Me.lblVerifyBottomLeft = New System.Windows.Forms.Label()
		Me.grpCameraControlBrackeyVerify = New System.Windows.Forms.GroupBox()
		Me.lblCamControlAcqTimeCenterVerify = New System.Windows.Forms.Label()
		Me.lblContrastCenterVerify = New System.Windows.Forms.Label()
		Me.lblExposureCenterVerify = New System.Windows.Forms.Label()
		Me.updnContrastCenterVerify = New System.Windows.Forms.NumericUpDown()
		Me.updnExposureCenterVerify = New System.Windows.Forms.NumericUpDown()
		Me.chkSnapRepeatBrackeyVerify = New System.Windows.Forms.CheckBox()
		Me.lblCameraTimeBracketVerify = New System.Windows.Forms.Label()
		Me.grpCameraStatusVerify = New System.Windows.Forms.GroupBox()
		Me.lblCameraStatusVerify = New System.Windows.Forms.Label()
		Me.lblTemperatureBracketVerify = New System.Windows.Forms.Label()
		Me.pctTemperatureVerify = New System.Windows.Forms.PictureBox()
		Me.grpLocatorControlsBracketVerify = New System.Windows.Forms.GroupBox()
		Me.lblScoreLimitCenterVerify = New System.Windows.Forms.Label()
		Me.chkLocateGlassVerify = New System.Windows.Forms.CheckBox()
		Me.lblLocateTimeCenterVerify = New System.Windows.Forms.Label()
		Me.lblLocatorTimeCenterVerify = New System.Windows.Forms.Label()
		Me.grpVisionStatusVerify = New System.Windows.Forms.GroupBox()
		Me.lblFitBracketVerify = New System.Windows.Forms.Label()
		Me.lblVisionPoseFirBracketVerify = New System.Windows.Forms.Label()
		Me.lblVisionPoseFitBracketVerify = New System.Windows.Forms.Label()
		Me.lblVisionPoseScoreBracketVerify = New System.Windows.Forms.Label()
		Me.lblVisionPoseTimeBracketVerify = New System.Windows.Forms.Label()
		Me.lblVisionPoseRBracketVerify = New System.Windows.Forms.Label()
		Me.lblVisionPoseYBracketVerify = New System.Windows.Forms.Label()
		Me.lblVisionPoseXBracketVerify = New System.Windows.Forms.Label()
		Me.lblVisionXBracketVerify = New System.Windows.Forms.Label()
		Me.lblVisionYBracketVerify = New System.Windows.Forms.Label()
		Me.lblVisionRBracketVerify = New System.Windows.Forms.Label()
		Me.lblVisionTimeBracketVerify = New System.Windows.Forms.Label()
		Me.lblVisionScoreBracketVerify = New System.Windows.Forms.Label()
		Me.grpHSDisplayBracketVerify = New System.Windows.Forms.GroupBox()
		Me.HSDisplayCenterBracketVerify = New AxHSDISPLAYLib.AxHSDisplay()
		Me.tabPageDriverCam = New System.Windows.Forms.TabPage()
		Me.grpVisionDriver = New System.Windows.Forms.GroupBox()
		Me.grpCameraControlDriver = New System.Windows.Forms.GroupBox()
		Me.lblCamControlAcqTimeDriver = New System.Windows.Forms.Label()
		Me.lblContrastDriver = New System.Windows.Forms.Label()
		Me.lblExposureDriver = New System.Windows.Forms.Label()
		Me.updnContrastDriver = New System.Windows.Forms.NumericUpDown()
		Me.updnExposureDriver = New System.Windows.Forms.NumericUpDown()
		Me.chkSnapRepeatDriver = New System.Windows.Forms.CheckBox()
		Me.lblCameraTimeDriver = New System.Windows.Forms.Label()
		Me.grpDriveBlob = New System.Windows.Forms.GroupBox()
		Me.lblTrackDriverValue = New System.Windows.Forms.Label()
		Me.trkDriverBlob = New System.Windows.Forms.TrackBar()
		Me.lblDriverBlobArea = New System.Windows.Forms.Label()
		Me.btnSaveDriverBlobArea = New System.Windows.Forms.Button()
		Me.lblDriverMaxBlobCount = New System.Windows.Forms.Label()
		Me.lblDriverMinBlobCount = New System.Windows.Forms.Label()
		Me.updnDriverBlobThresholdMax = New System.Windows.Forms.NumericUpDown()
		Me.updnDriverBlobThresholdMin = New System.Windows.Forms.NumericUpDown()
		Me.grpLocatorControlsDriver = New System.Windows.Forms.GroupBox()
		Me.lblScoreLimitDriver = New System.Windows.Forms.Label()
		Me.chkLocateDriver = New System.Windows.Forms.CheckBox()
		Me.lblLocateTimeDriver = New System.Windows.Forms.Label()
		Me.lblLocatorTimeDriver = New System.Windows.Forms.Label()
		Me.grpDriverCameraStatus = New System.Windows.Forms.GroupBox()
		Me.lblCameraStatusDriver = New System.Windows.Forms.Label()
		Me.lblTemperatureDriver = New System.Windows.Forms.Label()
		Me.pbDriverTemperature = New System.Windows.Forms.PictureBox()
		Me.grpStatusDriver = New System.Windows.Forms.GroupBox()
		Me.lblDriverBlobAreaDesc = New System.Windows.Forms.Label()
		Me.lblDriverCurrentBlobArea = New System.Windows.Forms.Label()
		Me.lblFitDriver = New System.Windows.Forms.Label()
		Me.lblVisionPoseFirDriver = New System.Windows.Forms.Label()
		Me.lblVisionPoseFitDriver = New System.Windows.Forms.Label()
		Me.lblVisionPoseScoreDriver = New System.Windows.Forms.Label()
		Me.lblVisionPoseTimeDriver = New System.Windows.Forms.Label()
		Me.lblVisionPoseRDriver = New System.Windows.Forms.Label()
		Me.lblVisionPoseYDriver = New System.Windows.Forms.Label()
		Me.lblVisionPoseXDriver = New System.Windows.Forms.Label()
		Me.lblVisionXDriver = New System.Windows.Forms.Label()
		Me.lblVisionYDriver = New System.Windows.Forms.Label()
		Me.lblVisionAngleDriver = New System.Windows.Forms.Label()
		Me.lblVisionTimeDriver = New System.Windows.Forms.Label()
		Me.lblVisionScoreDriver = New System.Windows.Forms.Label()
		Me.grpHSDisplayDriver = New System.Windows.Forms.GroupBox()
		Me.HSDisplayDriver = New AxHSDISPLAYLib.AxHSDisplay()
		Me.tabPageCenterCam = New System.Windows.Forms.TabPage()
		Me.grpVisionCenter = New System.Windows.Forms.GroupBox()
		Me.grpCameraControlCenter = New System.Windows.Forms.GroupBox()
		Me.lblCamControlAcqTimeCenter = New System.Windows.Forms.Label()
		Me.lblContrastCenter = New System.Windows.Forms.Label()
		Me.lblExposureCenter = New System.Windows.Forms.Label()
		Me.updnContrastCenter = New System.Windows.Forms.NumericUpDown()
		Me.updnExposureCenter = New System.Windows.Forms.NumericUpDown()
		Me.chkSnapRepeatCenter = New System.Windows.Forms.CheckBox()
		Me.lblCameraTimeCenter = New System.Windows.Forms.Label()
		Me.grpLocatorControlsCenter = New System.Windows.Forms.GroupBox()
		Me.lblScoreLimitCenter = New System.Windows.Forms.Label()
		Me.chkLocateCenter = New System.Windows.Forms.CheckBox()
		Me.lblLocateTimeCenter = New System.Windows.Forms.Label()
		Me.lblLocatorTimeCenter = New System.Windows.Forms.Label()
		Me.grpCenterBlob = New System.Windows.Forms.GroupBox()
		Me.lblTrackCenterValue = New System.Windows.Forms.Label()
		Me.trkCenterBlob = New System.Windows.Forms.TrackBar()
		Me.lblCenterBlobArea = New System.Windows.Forms.Label()
		Me.btnSaveCenterBlobArea = New System.Windows.Forms.Button()
		Me.lblMaxBlobCountCenter = New System.Windows.Forms.Label()
		Me.lblMinimumBlobCountCenter = New System.Windows.Forms.Label()
		Me.updnCenterBlobThresholdMax = New System.Windows.Forms.NumericUpDown()
		Me.updnCenterBlobThresholdMin = New System.Windows.Forms.NumericUpDown()
		Me.grpCameraStatusCenter = New System.Windows.Forms.GroupBox()
		Me.lblCameraStatusCenterWarning = New System.Windows.Forms.Label()
		Me.lblTemperatureCenter = New System.Windows.Forms.Label()
		Me.pbCenterCameraStatus = New System.Windows.Forms.PictureBox()
		Me.grpCenterVisStatus = New System.Windows.Forms.GroupBox()
		Me.lblCenterCurrentBlobAreaDesc = New System.Windows.Forms.Label()
		Me.lblCenterCurrentBlobArea = New System.Windows.Forms.Label()
		Me.lblFitCenter = New System.Windows.Forms.Label()
		Me.lblVisionPoseFirCenter = New System.Windows.Forms.Label()
		Me.lblVisionPoseFitCenter = New System.Windows.Forms.Label()
		Me.lblVisionPoseScoreCenter = New System.Windows.Forms.Label()
		Me.lblVisionPoseTimeCenter = New System.Windows.Forms.Label()
		Me.lblVisionPoseRCenter = New System.Windows.Forms.Label()
		Me.lblVisionPoseYCenter = New System.Windows.Forms.Label()
		Me.lblVisionPoseXCenter = New System.Windows.Forms.Label()
		Me.lblVisionXCenter = New System.Windows.Forms.Label()
		Me.lblVisionYCenter = New System.Windows.Forms.Label()
		Me.lblVisionAngleCenter = New System.Windows.Forms.Label()
		Me.lblVisionTimeCenter = New System.Windows.Forms.Label()
		Me.lblVisionScoreCenter = New System.Windows.Forms.Label()
		Me.grpHSDisplayCenter = New System.Windows.Forms.GroupBox()
		Me.HSDisplayCenter = New AxHSDISPLAYLib.AxHSDisplay()
		Me.tabPagePassCam = New System.Windows.Forms.TabPage()
		Me.grpVisionPassenger = New System.Windows.Forms.GroupBox()
		Me.grpCameraControlPassenger = New System.Windows.Forms.GroupBox()
		Me.lblCamControlAcqTimePassenger = New System.Windows.Forms.Label()
		Me.lblContrastPassenger = New System.Windows.Forms.Label()
		Me.lblExposurePassenger = New System.Windows.Forms.Label()
		Me.updnContrastPassenger = New System.Windows.Forms.NumericUpDown()
		Me.updnExposurePassenger = New System.Windows.Forms.NumericUpDown()
		Me.chkSnapRepeatPassenger = New System.Windows.Forms.CheckBox()
		Me.lblCameraTimePassenger = New System.Windows.Forms.Label()
		Me.grpLocatorControlsPassenger = New System.Windows.Forms.GroupBox()
		Me.lblScoreLimitPassenger = New System.Windows.Forms.Label()
		Me.chkLocatePassenger = New System.Windows.Forms.CheckBox()
		Me.lblLocateTimePassenger = New System.Windows.Forms.Label()
		Me.lblLocatorTimePassenger = New System.Windows.Forms.Label()
		Me.grpPassengerThreshold = New System.Windows.Forms.GroupBox()
		Me.lblTrackPassengerValue = New System.Windows.Forms.Label()
		Me.trkPassengerBlob = New System.Windows.Forms.TrackBar()
		Me.lblPassengerBlobArea = New System.Windows.Forms.Label()
		Me.btnSavePassengerBlobArea = New System.Windows.Forms.Button()
		Me.lblPassThresholdMax = New System.Windows.Forms.Label()
		Me.lblPassThresholdMin = New System.Windows.Forms.Label()
		Me.updnPassengerBlobThresholdMax = New System.Windows.Forms.NumericUpDown()
		Me.updnPassengerBlobThresholdMin = New System.Windows.Forms.NumericUpDown()
		Me.grpPassengerCameraStatus = New System.Windows.Forms.GroupBox()
		Me.lblCameraStatusPassenger = New System.Windows.Forms.Label()
		Me.lblTemperaturePassenger = New System.Windows.Forms.Label()
		Me.pbPassengerTemperature = New System.Windows.Forms.PictureBox()
		Me.grpPassengerVisStatus = New System.Windows.Forms.GroupBox()
		Me.lblPAssengerBlobAreaDesc = New System.Windows.Forms.Label()
		Me.lblPassengerCurrentBlobArea = New System.Windows.Forms.Label()
		Me.lblFitPassenger = New System.Windows.Forms.Label()
		Me.lblVisionPoseFirPassenger = New System.Windows.Forms.Label()
		Me.lblVisionPoseFitPassenger = New System.Windows.Forms.Label()
		Me.lblVisionPoseScorePassenger = New System.Windows.Forms.Label()
		Me.lblVisionPoseTimePassenger = New System.Windows.Forms.Label()
		Me.lblVisionPoseRPassenger = New System.Windows.Forms.Label()
		Me.lblVisionPoseYPassenger = New System.Windows.Forms.Label()
		Me.lblVisionPoseXPassenger = New System.Windows.Forms.Label()
		Me.lblVisionXPassenger = New System.Windows.Forms.Label()
		Me.lblVisionYPassenger = New System.Windows.Forms.Label()
		Me.lblVisionAnglePassenger = New System.Windows.Forms.Label()
		Me.lblVisionTimePassenger = New System.Windows.Forms.Label()
		Me.lblVisionScorePassenger = New System.Windows.Forms.Label()
		Me.grpHSDisplayPassenger = New System.Windows.Forms.GroupBox()
		Me.HSDisplayPassenger = New AxHSDISPLAYLib.AxHSDisplay()
		Me.tabPagePosition = New System.Windows.Forms.TabPage()
		Me.grpPosition = New System.Windows.Forms.GroupBox()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.txtDistance3 = New System.Windows.Forms.TextBox()
		Me.txtDistance2 = New System.Windows.Forms.TextBox()
		Me.txtDistance1 = New System.Windows.Forms.TextBox()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.grpVBErrors = New System.Windows.Forms.GroupBox()
		Me.lstVBError = New System.Windows.Forms.ListBox()
		Me.lblCurrentUser = New System.Windows.Forms.Label()
		Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
		Me.MainMenu1.SuspendLayout
		CType(Me.updnScoreLimit, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.updnLocationX, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.updnLocationY, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.updnLocationR, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.updnScoreLimitBracketconveyor, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.updnScoreLimitCenterVerify, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.updnScoreLimitDriver, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.updnScoreLimitCenter, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.updnScoreLimitPassenger, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.updnScoreLimitBracketPrimer, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.updnLocationZ, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.updnScoreLimitTapeBracketLocator, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit
		Me.tabVisionRobot.SuspendLayout
		Me.tabPageRobot.SuspendLayout
		Me.GrpRobot.SuspendLayout
		Me.grpResults.SuspendLayout
		CType(Me.updnGocator, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit
		Me.TabControlsMain.SuspendLayout
		Me.tabPageBracketLocateTape.SuspendLayout
		Me.grpVisionBracketLocateTape.SuspendLayout
		Me.gprBracketTapeCoverSettings.SuspendLayout
		CType(Me.updnCoverMaxAreaBottomRight, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.updnCoverBlobMinBottomRight, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.updnCoverMaxAreaBottomLeft, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.updnCoverBlobMinTopLeft, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.updnCoverMaxAreaTopRight, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.updnCoverMaxAreaTopLeft, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.updnCoverBlobMinTopRight, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.updnCoverBlobMinBottomLeft, System.ComponentModel.ISupportInitialize).BeginInit
		Me.gprBracketTapeBlobControls.SuspendLayout
		CType(Me.updnTapeMinAreaBottomRight, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.updnTapeBlobMinBottomRight, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.updnTapeBlobMaxBottomRight, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.updnTapeBlobMaxBottomLeft, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.updnTapeMinAreaBottomLeft, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.updnTapeBlobMinTopLeft, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.updnTapeBlobMaxTopLeft, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.updnTapeMinAreaTopRight, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.updnTapeBlobMaxTopRight, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.updnTapeMinAreaTopLeft, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.updnTapeBlobMinTopRight, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.updnTapeBlobMinBottomLeft, System.ComponentModel.ISupportInitialize).BeginInit
		Me.grpStatusBracketLocateTape.SuspendLayout
		Me.grpCameraControlLocateTape.SuspendLayout
		CType(Me.updnContrastBracketTape, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.updnExposureBracketTape, System.ComponentModel.ISupportInitialize).BeginInit
		Me.grpBracketTapeCamera.SuspendLayout
		CType(Me.pbBracketTape, System.ComponentModel.ISupportInitialize).BeginInit
		Me.grpLocatorControlsBracketTape.SuspendLayout
		Me.grpHSDisplayBracketTape.SuspendLayout
		CType(Me.HSDisplayBracketTape, System.ComponentModel.ISupportInitialize).BeginInit
		Me.tabpageBracketPrimerVerify.SuspendLayout
		Me.grpVisionBracketPrimer.SuspendLayout
		Me.grpBracketPrimerReference.SuspendLayout
		Me.grpBracketPrimer.SuspendLayout
		CType(Me.updnBracketPrimer5Deviation, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.updnBracketPrimer4Deviation, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.updnBracketPrimer3Deviation, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.updnBracketPrimer2Deviation, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.updnBracketPrimer1Deviation, System.ComponentModel.ISupportInitialize).BeginInit
		Me.grpCameraControlPrimer.SuspendLayout
		CType(Me.updnContrastBracketPrimer, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.updnExposureBracketPrimer, System.ComponentModel.ISupportInitialize).BeginInit
		Me.grpBracketPrimerCamera.SuspendLayout
		CType(Me.pbBracketPrimer, System.ComponentModel.ISupportInitialize).BeginInit
		Me.grpStatusBracketLocatePrimer.SuspendLayout
		Me.grpLocatorControlsBracketPrimer.SuspendLayout
		Me.grpHSDisplayBracketPrimer.SuspendLayout
		CType(Me.HSDisplayBracketPrimer, System.ComponentModel.ISupportInitialize).BeginInit
		Me.tabpageBracketLocateAtConveyor.SuspendLayout
		Me.grpVisionBracketLocateatConveyor.SuspendLayout
		Me.grpCameraControlLocateConveyor.SuspendLayout
		CType(Me.updnContrastBracketConveyor, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.updnExposureBracketConveyor, System.ComponentModel.ISupportInitialize).BeginInit
		Me.grpLocatorControlsBracketConveyor.SuspendLayout
		Me.grpBrackConveyorCamera.SuspendLayout
		CType(Me.pbBracketConveyorCamera, System.ComponentModel.ISupportInitialize).BeginInit
		Me.grpStatusBracketLocateAtConveoyr.SuspendLayout
		Me.grpHSDisplayBracketConveyor.SuspendLayout
		CType(Me.HSDisplayBracketConveyor, System.ComponentModel.ISupportInitialize).BeginInit
		Me.tabPageBracketLocate.SuspendLayout
		Me.grpVisionGlassLocate.SuspendLayout
		Me.grpCameraControl.SuspendLayout
		CType(Me.updnContrastLocateGlass, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.updnExposureLocateGlass, System.ComponentModel.ISupportInitialize).BeginInit
		Me.grpLocatorControls.SuspendLayout
		Me.grpGlassLocate.SuspendLayout
		Me.grpCameraStatus.SuspendLayout
		CType(Me.pctTemperature, System.ComponentModel.ISupportInitialize).BeginInit
		Me.grpVisionStatus.SuspendLayout
		Me.grpHSDisplayGlassLocation.SuspendLayout
		CType(Me.HSDisplayLocateGlass, System.ComponentModel.ISupportInitialize).BeginInit
		Me.tabPageCenterBracketVerify.SuspendLayout
		Me.grpVisionCenterVerify.SuspendLayout
		Me.grpGlassVerifyValues.SuspendLayout
		CType(Me.updnTopRightVerifyVariance, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.updnBottomRightVerifyVariance, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.updnBottomLeftVerifyVariance, System.ComponentModel.ISupportInitialize).BeginInit
		Me.grpCameraControlBrackeyVerify.SuspendLayout
		CType(Me.updnContrastCenterVerify, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.updnExposureCenterVerify, System.ComponentModel.ISupportInitialize).BeginInit
		Me.grpCameraStatusVerify.SuspendLayout
		CType(Me.pctTemperatureVerify, System.ComponentModel.ISupportInitialize).BeginInit
		Me.grpLocatorControlsBracketVerify.SuspendLayout
		Me.grpVisionStatusVerify.SuspendLayout
		Me.grpHSDisplayBracketVerify.SuspendLayout
		CType(Me.HSDisplayCenterBracketVerify, System.ComponentModel.ISupportInitialize).BeginInit
		Me.tabPageDriverCam.SuspendLayout
		Me.grpVisionDriver.SuspendLayout
		Me.grpCameraControlDriver.SuspendLayout
		CType(Me.updnContrastDriver, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.updnExposureDriver, System.ComponentModel.ISupportInitialize).BeginInit
		Me.grpDriveBlob.SuspendLayout
		CType(Me.trkDriverBlob, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.updnDriverBlobThresholdMax, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.updnDriverBlobThresholdMin, System.ComponentModel.ISupportInitialize).BeginInit
		Me.grpLocatorControlsDriver.SuspendLayout
		Me.grpDriverCameraStatus.SuspendLayout
		CType(Me.pbDriverTemperature, System.ComponentModel.ISupportInitialize).BeginInit
		Me.grpStatusDriver.SuspendLayout
		Me.grpHSDisplayDriver.SuspendLayout
		CType(Me.HSDisplayDriver, System.ComponentModel.ISupportInitialize).BeginInit
		Me.tabPageCenterCam.SuspendLayout
		Me.grpVisionCenter.SuspendLayout
		Me.grpCameraControlCenter.SuspendLayout
		CType(Me.updnContrastCenter, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.updnExposureCenter, System.ComponentModel.ISupportInitialize).BeginInit
		Me.grpLocatorControlsCenter.SuspendLayout
		Me.grpCenterBlob.SuspendLayout
		CType(Me.trkCenterBlob, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.updnCenterBlobThresholdMax, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.updnCenterBlobThresholdMin, System.ComponentModel.ISupportInitialize).BeginInit
		Me.grpCameraStatusCenter.SuspendLayout
		CType(Me.pbCenterCameraStatus, System.ComponentModel.ISupportInitialize).BeginInit
		Me.grpCenterVisStatus.SuspendLayout
		Me.grpHSDisplayCenter.SuspendLayout
		CType(Me.HSDisplayCenter, System.ComponentModel.ISupportInitialize).BeginInit
		Me.tabPagePassCam.SuspendLayout
		Me.grpVisionPassenger.SuspendLayout
		Me.grpCameraControlPassenger.SuspendLayout
		CType(Me.updnContrastPassenger, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.updnExposurePassenger, System.ComponentModel.ISupportInitialize).BeginInit
		Me.grpLocatorControlsPassenger.SuspendLayout
		Me.grpPassengerThreshold.SuspendLayout
		CType(Me.trkPassengerBlob, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.updnPassengerBlobThresholdMax, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.updnPassengerBlobThresholdMin, System.ComponentModel.ISupportInitialize).BeginInit
		Me.grpPassengerCameraStatus.SuspendLayout
		CType(Me.pbPassengerTemperature, System.ComponentModel.ISupportInitialize).BeginInit
		Me.grpPassengerVisStatus.SuspendLayout
		Me.grpHSDisplayPassenger.SuspendLayout
		CType(Me.HSDisplayPassenger, System.ComponentModel.ISupportInitialize).BeginInit
		Me.tabPagePosition.SuspendLayout
		Me.grpPosition.SuspendLayout
		Me.GroupBox1.SuspendLayout
		Me.grpVBErrors.SuspendLayout
		Me.SuspendLayout
		'
		'MainMenu1
		'
		Me.MainMenu1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuConfig, Me.mnuHelp})
		Me.MainMenu1.Location = New System.Drawing.Point(0, 0)
		Me.MainMenu1.Name = "MainMenu1"
		Me.MainMenu1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
		Me.MainMenu1.Size = New System.Drawing.Size(1904, 24)
		Me.MainMenu1.TabIndex = 48
		'
		'mnuFile
		'
		Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuLoadPart, Me.mnuNew, Me.mnuPartSettings, Me.mnuDeletePart, Me.mnuSeperator1, Me.mnuPassword, Me.mnuQuit})
		Me.mnuFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.mnuFile.Name = "mnuFile"
		Me.mnuFile.Size = New System.Drawing.Size(42, 20)
		Me.mnuFile.Text = "File"
		'
		'mnuLoadPart
		'
		Me.mnuLoadPart.Name = "mnuLoadPart"
		Me.mnuLoadPart.Size = New System.Drawing.Size(244, 22)
		Me.mnuLoadPart.Text = "Load a Part"
		'
		'mnuNew
		'
		Me.mnuNew.Name = "mnuNew"
		Me.mnuNew.Size = New System.Drawing.Size(244, 22)
		Me.mnuNew.Text = "Create a Part From This Part"
		'
		'mnuPartSettings
		'
		Me.mnuPartSettings.Name = "mnuPartSettings"
		Me.mnuPartSettings.Size = New System.Drawing.Size(244, 22)
		Me.mnuPartSettings.Text = "Part Settings"
		'
		'mnuDeletePart
		'
		Me.mnuDeletePart.Name = "mnuDeletePart"
		Me.mnuDeletePart.Size = New System.Drawing.Size(244, 22)
		Me.mnuDeletePart.Text = "Delete a Part"
		'
		'mnuSeperator1
		'
		Me.mnuSeperator1.Name = "mnuSeperator1"
		Me.mnuSeperator1.Size = New System.Drawing.Size(241, 6)
		'
		'mnuPassword
		'
		Me.mnuPassword.Name = "mnuPassword"
		Me.mnuPassword.Size = New System.Drawing.Size(244, 22)
		Me.mnuPassword.Text = "Enter Password"
		'
		'mnuQuit
		'
		Me.mnuQuit.Name = "mnuQuit"
		Me.mnuQuit.Size = New System.Drawing.Size(244, 22)
		Me.mnuQuit.Text = "Quit"
		'
		'mnuConfig
		'
		Me.mnuConfig.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuGeneralDatabaseSettings, Me.mnuBracketSettings, Me.mnuPositionalSettings, Me.mnuSeperator3, Me.mnuCalibration, Me.mnuSeperator2, Me.mnuVerifyVisionAccuracy, Me.mnuTabSwitching, Me.mnuSaveVerification})
		Me.mnuConfig.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.mnuConfig.Name = "mnuConfig"
		Me.mnuConfig.Size = New System.Drawing.Size(98, 20)
		Me.mnuConfig.Text = "Configuration"
		'
		'mnuGeneralDatabaseSettings
		'
		Me.mnuGeneralDatabaseSettings.Name = "mnuGeneralDatabaseSettings"
		Me.mnuGeneralDatabaseSettings.Size = New System.Drawing.Size(238, 22)
		Me.mnuGeneralDatabaseSettings.Text = "General Database Settings"
		'
		'mnuBracketSettings
		'
		Me.mnuBracketSettings.Name = "mnuBracketSettings"
		Me.mnuBracketSettings.Size = New System.Drawing.Size(238, 22)
		Me.mnuBracketSettings.Text = "Bracket Settings"
		'
		'mnuPositionalSettings
		'
		Me.mnuPositionalSettings.Name = "mnuPositionalSettings"
		Me.mnuPositionalSettings.Size = New System.Drawing.Size(238, 22)
		Me.mnuPositionalSettings.Text = "Part Settings Database"
		'
		'mnuSeperator3
		'
		Me.mnuSeperator3.Name = "mnuSeperator3"
		Me.mnuSeperator3.Size = New System.Drawing.Size(235, 6)
		'
		'mnuCalibration
		'
		Me.mnuCalibration.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuModifyHexsightControls, Me.mnuCalibrateBracket, Me.mnuCalibrateCenter, Me.mnuCalibrateDriver, Me.mnuCalibratePassenger})
		Me.mnuCalibration.Name = "mnuCalibration"
		Me.mnuCalibration.Size = New System.Drawing.Size(238, 22)
		Me.mnuCalibration.Text = "Vision Settings"
		'
		'mnuModifyHexsightControls
		'
		Me.mnuModifyHexsightControls.Name = "mnuModifyHexsightControls"
		Me.mnuModifyHexsightControls.Size = New System.Drawing.Size(250, 22)
		Me.mnuModifyHexsightControls.Text = "Modify Hexsight Controls"
		'
		'mnuCalibrateBracket
		'
		Me.mnuCalibrateBracket.Name = "mnuCalibrateBracket"
		Me.mnuCalibrateBracket.Size = New System.Drawing.Size(250, 22)
		Me.mnuCalibrateBracket.Text = "Calibrate Bracket Camera"
		'
		'mnuCalibrateCenter
		'
		Me.mnuCalibrateCenter.Name = "mnuCalibrateCenter"
		Me.mnuCalibrateCenter.Size = New System.Drawing.Size(250, 22)
		Me.mnuCalibrateCenter.Text = "Calibrate Center Camera"
		'
		'mnuCalibrateDriver
		'
		Me.mnuCalibrateDriver.Name = "mnuCalibrateDriver"
		Me.mnuCalibrateDriver.Size = New System.Drawing.Size(250, 22)
		Me.mnuCalibrateDriver.Text = "Calibrate Driver Camera"
		'
		'mnuCalibratePassenger
		'
		Me.mnuCalibratePassenger.Name = "mnuCalibratePassenger"
		Me.mnuCalibratePassenger.Size = New System.Drawing.Size(250, 22)
		Me.mnuCalibratePassenger.Text = "Calibrate Passenger Camera"
		'
		'mnuSeperator2
		'
		Me.mnuSeperator2.Name = "mnuSeperator2"
		Me.mnuSeperator2.Size = New System.Drawing.Size(235, 6)
		'
		'mnuVerifyVisionAccuracy
		'
		Me.mnuVerifyVisionAccuracy.Name = "mnuVerifyVisionAccuracy"
		Me.mnuVerifyVisionAccuracy.Size = New System.Drawing.Size(238, 22)
		Me.mnuVerifyVisionAccuracy.Text = "Verify Vision Accuracy"
		'
		'mnuTabSwitching
		'
		Me.mnuTabSwitching.Name = "mnuTabSwitching"
		Me.mnuTabSwitching.Size = New System.Drawing.Size(238, 22)
		Me.mnuTabSwitching.Text = "Automatic Tab Switching"
		'
		'mnuSaveVerification
		'
		Me.mnuSaveVerification.Name = "mnuSaveVerification"
		Me.mnuSaveVerification.Size = New System.Drawing.Size(238, 22)
		Me.mnuSaveVerification.Text = "Save Verification Data"
		'
		'mnuHelp
		'
		Me.mnuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SystemManualToolStripMenuItem, Me.mnuCameraCalibration, Me.mnuSystemDocumentation, Me.ToolStripMenuItem2, Me.AboutToolStripMenuItem})
		Me.mnuHelp.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.mnuHelp.Name = "mnuHelp"
		Me.mnuHelp.Size = New System.Drawing.Size(45, 20)
		Me.mnuHelp.Text = "Help"
		'
		'SystemManualToolStripMenuItem
		'
		Me.SystemManualToolStripMenuItem.Name = "SystemManualToolStripMenuItem"
		Me.SystemManualToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
		Me.SystemManualToolStripMenuItem.Text = "System Manual"
		'
		'mnuCameraCalibration
		'
		Me.mnuCameraCalibration.Name = "mnuCameraCalibration"
		Me.mnuCameraCalibration.Size = New System.Drawing.Size(206, 22)
		Me.mnuCameraCalibration.Text = "Camera Calibration"
		'
		'mnuSystemDocumentation
		'
		Me.mnuSystemDocumentation.Name = "mnuSystemDocumentation"
		Me.mnuSystemDocumentation.Size = New System.Drawing.Size(206, 22)
		Me.mnuSystemDocumentation.Text = "Vision Training Manual"
		'
		'ToolStripMenuItem2
		'
		Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
		Me.ToolStripMenuItem2.Size = New System.Drawing.Size(203, 6)
		'
		'AboutToolStripMenuItem
		'
		Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
		Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
		Me.AboutToolStripMenuItem.Text = "&About"
		'
		'lblPartLoaded
		'
		Me.lblPartLoaded.BackColor = System.Drawing.SystemColors.Control
		Me.lblPartLoaded.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblPartLoaded.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPartLoaded.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.lblPartLoaded.Location = New System.Drawing.Point(317, 1)
		Me.lblPartLoaded.Name = "lblPartLoaded"
		Me.lblPartLoaded.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblPartLoaded.Size = New System.Drawing.Size(118, 24)
		Me.lblPartLoaded.TabIndex = 33
		Me.lblPartLoaded.Text = "Current Part:"
		'
		'lblPartTitle
		'
		Me.lblPartTitle.BackColor = System.Drawing.SystemColors.Control
		Me.lblPartTitle.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblPartTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPartTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.lblPartTitle.Location = New System.Drawing.Point(435, 1)
		Me.lblPartTitle.Name = "lblPartTitle"
		Me.lblPartTitle.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblPartTitle.Size = New System.Drawing.Size(306, 24)
		Me.lblPartTitle.TabIndex = 32
		Me.lblPartTitle.Text = "Nothing"
		'
		'tmrDelay
		'
		Me.tmrDelay.Interval = 1
		'
		'ToolTip1
		'
		Me.ToolTip1.AutoPopDelay = 32000
		Me.ToolTip1.InitialDelay = 500
		Me.ToolTip1.ReshowDelay = 100
		'
		'lblVisionMessageBracket
		'
		Me.lblVisionMessageBracket.BackColor = System.Drawing.SystemColors.Control
		Me.lblVisionMessageBracket.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblVisionMessageBracket.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblVisionMessageBracket.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblVisionMessageBracket.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblVisionMessageBracket.Location = New System.Drawing.Point(9, 18)
		Me.lblVisionMessageBracket.Name = "lblVisionMessageBracket"
		Me.lblVisionMessageBracket.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblVisionMessageBracket.Size = New System.Drawing.Size(299, 43)
		Me.lblVisionMessageBracket.TabIndex = 56
		Me.lblVisionMessageBracket.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.ToolTip1.SetToolTip(Me.lblVisionMessageBracket, "The status of the most recent locate attempt.  Click the Details button for more " &
				"information. ")
		'
		'btnDetailsBracket
		'
		Me.btnDetailsBracket.BackColor = System.Drawing.Color.Transparent
		Me.btnDetailsBracket.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnDetailsBracket.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.btnDetailsBracket.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnDetailsBracket.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnDetailsBracket.Location = New System.Drawing.Point(11, 65)
		Me.btnDetailsBracket.Name = "btnDetailsBracket"
		Me.btnDetailsBracket.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnDetailsBracket.Size = New System.Drawing.Size(54, 24)
		Me.btnDetailsBracket.TabIndex = 144
		Me.btnDetailsBracket.Text = "Details"
		Me.ToolTip1.SetToolTip(Me.btnDetailsBracket, "Click for the full description of the vision status of the most recent locate att" &
				"empt")
		Me.btnDetailsBracket.UseVisualStyleBackColor = False
		'
		'btnSnapLocateGlass
		'
		Me.btnSnapLocateGlass.BackColor = System.Drawing.Color.Transparent
		Me.btnSnapLocateGlass.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnSnapLocateGlass.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.btnSnapLocateGlass.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnSnapLocateGlass.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnSnapLocateGlass.Location = New System.Drawing.Point(5, 18)
		Me.btnSnapLocateGlass.Name = "btnSnapLocateGlass"
		Me.btnSnapLocateGlass.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnSnapLocateGlass.Size = New System.Drawing.Size(99, 26)
		Me.btnSnapLocateGlass.TabIndex = 73
		Me.btnSnapLocateGlass.TabStop = False
		Me.btnSnapLocateGlass.Text = "Take a Picture"
		Me.ToolTip1.SetToolTip(Me.btnSnapLocateGlass, "Momentarily turns on the light and snaps a picture.  Will repeat as long as the r" &
				"epeat box is checked next to it. ")
		Me.btnSnapLocateGlass.UseVisualStyleBackColor = False
		'
		'btnTrainExistingLocateGlass
		'
		Me.btnTrainExistingLocateGlass.BackColor = System.Drawing.Color.Transparent
		Me.btnTrainExistingLocateGlass.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnTrainExistingLocateGlass.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.btnTrainExistingLocateGlass.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnTrainExistingLocateGlass.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnTrainExistingLocateGlass.Location = New System.Drawing.Point(5, 76)
		Me.btnTrainExistingLocateGlass.Name = "btnTrainExistingLocateGlass"
		Me.btnTrainExistingLocateGlass.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnTrainExistingLocateGlass.Size = New System.Drawing.Size(114, 22)
		Me.btnTrainExistingLocateGlass.TabIndex = 58
		Me.btnTrainExistingLocateGlass.TabStop = False
		Me.btnTrainExistingLocateGlass.Text = "Train Existing"
		Me.ToolTip1.SetToolTip(Me.btnTrainExistingLocateGlass, "Train Existing - Edits the existing model in the database.  Changes can be made t" &
				"o the current model without discarding any previous data.")
		Me.btnTrainExistingLocateGlass.UseVisualStyleBackColor = False
		'
		'btnTrainNewLocateGlass
		'
		Me.btnTrainNewLocateGlass.BackColor = System.Drawing.Color.Transparent
		Me.btnTrainNewLocateGlass.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnTrainNewLocateGlass.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.btnTrainNewLocateGlass.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnTrainNewLocateGlass.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnTrainNewLocateGlass.Location = New System.Drawing.Point(5, 97)
		Me.btnTrainNewLocateGlass.Name = "btnTrainNewLocateGlass"
		Me.btnTrainNewLocateGlass.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnTrainNewLocateGlass.Size = New System.Drawing.Size(114, 22)
		Me.btnTrainNewLocateGlass.TabIndex = 59
		Me.btnTrainNewLocateGlass.TabStop = False
		Me.btnTrainNewLocateGlass.Text = "Train New"
		Me.ToolTip1.SetToolTip(Me.btnTrainNewLocateGlass, "Train New - Discards the old model and takes a picture to teach a new one.  This " &
				"is used to locate the glass on the incoming position and determine its pick up p" &
				"oint.")
		Me.btnTrainNewLocateGlass.UseVisualStyleBackColor = False
		'
		'btnSearchSettingsLocateGlass
		'
		Me.btnSearchSettingsLocateGlass.BackColor = System.Drawing.Color.Transparent
		Me.btnSearchSettingsLocateGlass.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnSearchSettingsLocateGlass.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.btnSearchSettingsLocateGlass.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnSearchSettingsLocateGlass.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnSearchSettingsLocateGlass.Location = New System.Drawing.Point(5, 118)
		Me.btnSearchSettingsLocateGlass.Name = "btnSearchSettingsLocateGlass"
		Me.btnSearchSettingsLocateGlass.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnSearchSettingsLocateGlass.Size = New System.Drawing.Size(114, 22)
		Me.btnSearchSettingsLocateGlass.TabIndex = 62
		Me.btnSearchSettingsLocateGlass.Text = "Search Settings"
		Me.ToolTip1.SetToolTip(Me.btnSearchSettingsLocateGlass, "Search Settings - Advanced settings for the search process can by modified here. " &
				" Should not be modified unless completely necessary")
		Me.btnSearchSettingsLocateGlass.UseVisualStyleBackColor = False
		'
		'updnScoreLimit
		'
		Me.updnScoreLimit.Location = New System.Drawing.Point(141, 70)
		Me.updnScoreLimit.Minimum = New Decimal(New Integer() {70, 0, 0, 0})
		Me.updnScoreLimit.Name = "updnScoreLimit"
		Me.updnScoreLimit.Size = New System.Drawing.Size(50, 20)
		Me.updnScoreLimit.TabIndex = 69
		Me.ToolTip1.SetToolTip(Me.updnScoreLimit, "The minimum score required to pick up the glass")
		Me.updnScoreLimit.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
		Me.updnScoreLimit.Value = New Decimal(New Integer() {95, 0, 0, 0})
		'
		'btnLocateLocateGlass
		'
		Me.btnLocateLocateGlass.BackColor = System.Drawing.Color.Transparent
		Me.btnLocateLocateGlass.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnLocateLocateGlass.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.btnLocateLocateGlass.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnLocateLocateGlass.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnLocateLocateGlass.Location = New System.Drawing.Point(5, 13)
		Me.btnLocateLocateGlass.Name = "btnLocateLocateGlass"
		Me.btnLocateLocateGlass.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnLocateLocateGlass.Size = New System.Drawing.Size(114, 26)
		Me.btnLocateLocateGlass.TabIndex = 61
		Me.btnLocateLocateGlass.TabStop = False
		Me.btnLocateLocateGlass.Text = "Inspect with Snap"
		Me.ToolTip1.SetToolTip(Me.btnLocateLocateGlass, "Will locate the glass based on the trained model associated with the part.  Will " &
				"continuously repeat if the repeat box is checked")
		Me.btnLocateLocateGlass.UseVisualStyleBackColor = False
		'
		'btnLocateOnlyLocateGlass
		'
		Me.btnLocateOnlyLocateGlass.BackColor = System.Drawing.Color.Transparent
		Me.btnLocateOnlyLocateGlass.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnLocateOnlyLocateGlass.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.btnLocateOnlyLocateGlass.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnLocateOnlyLocateGlass.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnLocateOnlyLocateGlass.Location = New System.Drawing.Point(183, 9)
		Me.btnLocateOnlyLocateGlass.Name = "btnLocateOnlyLocateGlass"
		Me.btnLocateOnlyLocateGlass.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnLocateOnlyLocateGlass.Size = New System.Drawing.Size(43, 33)
		Me.btnLocateOnlyLocateGlass.TabIndex = 166
		Me.btnLocateOnlyLocateGlass.TabStop = False
		Me.btnLocateOnlyLocateGlass.Text = "Locate Only"
		Me.ToolTip1.SetToolTip(Me.btnLocateOnlyLocateGlass, "Will locate the glass based on the trained model associated with the part.  Will " &
				"continuously repeat if the repeat box is checked")
		Me.btnLocateOnlyLocateGlass.UseVisualStyleBackColor = False
		'
		'updnLocationX
		'
		Me.updnLocationX.DecimalPlaces = 2
		Me.updnLocationX.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
		Me.updnLocationX.Location = New System.Drawing.Point(290, 32)
		Me.updnLocationX.Maximum = New Decimal(New Integer() {2000, 0, 0, 0})
		Me.updnLocationX.Minimum = New Decimal(New Integer() {2000, 0, 0, -2147483648})
		Me.updnLocationX.Name = "updnLocationX"
		Me.updnLocationX.Size = New System.Drawing.Size(67, 20)
		Me.updnLocationX.TabIndex = 211
		Me.updnLocationX.Tag = "dont save"
		Me.updnLocationX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.ToolTip1.SetToolTip(Me.updnLocationX, "Each click moves glass 0.1mm " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "to the 'Away from Operator' side " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "of the line. Pr" &
				"ess the [OK] button" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "to accept movement changes." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Range : +/- 50mm")
		Me.updnLocationX.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
		'
		'updnLocationY
		'
		Me.updnLocationY.DecimalPlaces = 2
		Me.updnLocationY.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
		Me.updnLocationY.Location = New System.Drawing.Point(293, 74)
		Me.updnLocationY.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
		Me.updnLocationY.Minimum = New Decimal(New Integer() {1000, 0, 0, -2147483648})
		Me.updnLocationY.Name = "updnLocationY"
		Me.updnLocationY.Size = New System.Drawing.Size(64, 20)
		Me.updnLocationY.TabIndex = 212
		Me.updnLocationY.Tag = "dont save"
		Me.updnLocationY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.ToolTip1.SetToolTip(Me.updnLocationY, "Each click moves glass 0.1mm " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "to the ' Upstream' side " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "of the line. Press the [" &
				"OK] button" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "to accept movement changes." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Range : +/- 50mm")
		Me.updnLocationY.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
		'
		'updnLocationR
		'
		Me.updnLocationR.DecimalPlaces = 2
		Me.updnLocationR.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
		Me.updnLocationR.Location = New System.Drawing.Point(290, 118)
		Me.updnLocationR.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
		Me.updnLocationR.Minimum = New Decimal(New Integer() {20, 0, 0, -2147483648})
		Me.updnLocationR.Name = "updnLocationR"
		Me.updnLocationR.Size = New System.Drawing.Size(67, 20)
		Me.updnLocationR.TabIndex = 213
		Me.updnLocationR.Tag = "dont save"
		Me.updnLocationR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.ToolTip1.SetToolTip(Me.updnLocationR, "Each click moves glass 0.01 degree" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "of Counter Clockwise rotation." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " Press the " &
				"[OK] button" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "to accept movement changes." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Range : +/- 20mm")
		Me.updnLocationR.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
		'
		'btnLocationAdjCancel
		'
		Me.btnLocationAdjCancel.BackColor = System.Drawing.Color.White
		Me.btnLocationAdjCancel.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnLocationAdjCancel.Font = New System.Drawing.Font("Arial", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnLocationAdjCancel.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnLocationAdjCancel.Location = New System.Drawing.Point(471, 66)
		Me.btnLocationAdjCancel.Name = "btnLocationAdjCancel"
		Me.btnLocationAdjCancel.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnLocationAdjCancel.Size = New System.Drawing.Size(58, 29)
		Me.btnLocationAdjCancel.TabIndex = 223
		Me.btnLocationAdjCancel.TabStop = False
		Me.btnLocationAdjCancel.Text = "Cancel"
		Me.ToolTip1.SetToolTip(Me.btnLocationAdjCancel, "Click to reset all numbers back to 0. ")
		Me.btnLocationAdjCancel.UseVisualStyleBackColor = False
		'
		'btnLocationAdjOK
		'
		Me.btnLocationAdjOK.BackColor = System.Drawing.Color.White
		Me.btnLocationAdjOK.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnLocationAdjOK.Font = New System.Drawing.Font("Arial", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnLocationAdjOK.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnLocationAdjOK.Location = New System.Drawing.Point(471, 21)
		Me.btnLocationAdjOK.Name = "btnLocationAdjOK"
		Me.btnLocationAdjOK.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnLocationAdjOK.Size = New System.Drawing.Size(58, 29)
		Me.btnLocationAdjOK.TabIndex = 224
		Me.btnLocationAdjOK.TabStop = False
		Me.btnLocationAdjOK.Text = "OK"
		Me.ToolTip1.SetToolTip(Me.btnLocationAdjOK, "Click to Apply Changes")
		Me.btnLocationAdjOK.UseVisualStyleBackColor = False
		'
		'btnDetailsDriver
		'
		Me.btnDetailsDriver.BackColor = System.Drawing.Color.Transparent
		Me.btnDetailsDriver.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnDetailsDriver.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.btnDetailsDriver.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnDetailsDriver.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnDetailsDriver.Location = New System.Drawing.Point(11, 65)
		Me.btnDetailsDriver.Name = "btnDetailsDriver"
		Me.btnDetailsDriver.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnDetailsDriver.Size = New System.Drawing.Size(54, 24)
		Me.btnDetailsDriver.TabIndex = 144
		Me.btnDetailsDriver.Text = "Details"
		Me.ToolTip1.SetToolTip(Me.btnDetailsDriver, "Click for the full description of the vision status of the most recent locate att" &
				"empt")
		Me.btnDetailsDriver.UseVisualStyleBackColor = False
		'
		'lblVisionMessageDriver
		'
		Me.lblVisionMessageDriver.BackColor = System.Drawing.SystemColors.Control
		Me.lblVisionMessageDriver.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblVisionMessageDriver.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblVisionMessageDriver.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblVisionMessageDriver.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblVisionMessageDriver.Location = New System.Drawing.Point(9, 18)
		Me.lblVisionMessageDriver.Name = "lblVisionMessageDriver"
		Me.lblVisionMessageDriver.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblVisionMessageDriver.Size = New System.Drawing.Size(299, 43)
		Me.lblVisionMessageDriver.TabIndex = 56
		Me.lblVisionMessageDriver.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.ToolTip1.SetToolTip(Me.lblVisionMessageDriver, "The status of the most recent locate attempt.  Click the Details button for more " &
				"information. ")
		'
		'btnDetailsCenter
		'
		Me.btnDetailsCenter.BackColor = System.Drawing.Color.Transparent
		Me.btnDetailsCenter.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnDetailsCenter.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.btnDetailsCenter.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnDetailsCenter.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnDetailsCenter.Location = New System.Drawing.Point(11, 65)
		Me.btnDetailsCenter.Name = "btnDetailsCenter"
		Me.btnDetailsCenter.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnDetailsCenter.Size = New System.Drawing.Size(54, 24)
		Me.btnDetailsCenter.TabIndex = 144
		Me.btnDetailsCenter.Text = "Details"
		Me.ToolTip1.SetToolTip(Me.btnDetailsCenter, "Click for the full description of the vision status of the most recent locate att" &
				"empt")
		Me.btnDetailsCenter.UseVisualStyleBackColor = False
		'
		'lblVisionMessageCenter
		'
		Me.lblVisionMessageCenter.BackColor = System.Drawing.SystemColors.Control
		Me.lblVisionMessageCenter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblVisionMessageCenter.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblVisionMessageCenter.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblVisionMessageCenter.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblVisionMessageCenter.Location = New System.Drawing.Point(9, 18)
		Me.lblVisionMessageCenter.Name = "lblVisionMessageCenter"
		Me.lblVisionMessageCenter.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblVisionMessageCenter.Size = New System.Drawing.Size(299, 43)
		Me.lblVisionMessageCenter.TabIndex = 56
		Me.lblVisionMessageCenter.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.ToolTip1.SetToolTip(Me.lblVisionMessageCenter, "The status of the most recent locate attempt.  Click the Details button for more " &
				"information. ")
		'
		'btnDetailsPassenger
		'
		Me.btnDetailsPassenger.BackColor = System.Drawing.Color.Transparent
		Me.btnDetailsPassenger.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnDetailsPassenger.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.btnDetailsPassenger.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnDetailsPassenger.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnDetailsPassenger.Location = New System.Drawing.Point(11, 65)
		Me.btnDetailsPassenger.Name = "btnDetailsPassenger"
		Me.btnDetailsPassenger.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnDetailsPassenger.Size = New System.Drawing.Size(54, 24)
		Me.btnDetailsPassenger.TabIndex = 144
		Me.btnDetailsPassenger.Text = "Details"
		Me.ToolTip1.SetToolTip(Me.btnDetailsPassenger, "Click for the full description of the vision status of the most recent locate att" &
				"empt")
		Me.btnDetailsPassenger.UseVisualStyleBackColor = False
		'
		'lblVisionMessagePassenger
		'
		Me.lblVisionMessagePassenger.BackColor = System.Drawing.SystemColors.Control
		Me.lblVisionMessagePassenger.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblVisionMessagePassenger.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblVisionMessagePassenger.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblVisionMessagePassenger.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblVisionMessagePassenger.Location = New System.Drawing.Point(9, 18)
		Me.lblVisionMessagePassenger.Name = "lblVisionMessagePassenger"
		Me.lblVisionMessagePassenger.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblVisionMessagePassenger.Size = New System.Drawing.Size(299, 43)
		Me.lblVisionMessagePassenger.TabIndex = 56
		Me.lblVisionMessagePassenger.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.ToolTip1.SetToolTip(Me.lblVisionMessagePassenger, "The status of the most recent locate attempt.  Click the Details button for more " &
				"information. ")
		'
		'btnDetailsBracketConveyor
		'
		Me.btnDetailsBracketConveyor.BackColor = System.Drawing.Color.Transparent
		Me.btnDetailsBracketConveyor.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnDetailsBracketConveyor.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.btnDetailsBracketConveyor.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnDetailsBracketConveyor.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnDetailsBracketConveyor.Location = New System.Drawing.Point(11, 65)
		Me.btnDetailsBracketConveyor.Name = "btnDetailsBracketConveyor"
		Me.btnDetailsBracketConveyor.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnDetailsBracketConveyor.Size = New System.Drawing.Size(54, 24)
		Me.btnDetailsBracketConveyor.TabIndex = 144
		Me.btnDetailsBracketConveyor.Text = "Details"
		Me.ToolTip1.SetToolTip(Me.btnDetailsBracketConveyor, "Click for the full description of the vision status of the most recent locate att" &
				"empt")
		Me.btnDetailsBracketConveyor.UseVisualStyleBackColor = False
		'
		'lblVisionMessageBracketConveyor
		'
		Me.lblVisionMessageBracketConveyor.BackColor = System.Drawing.SystemColors.Control
		Me.lblVisionMessageBracketConveyor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblVisionMessageBracketConveyor.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblVisionMessageBracketConveyor.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblVisionMessageBracketConveyor.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblVisionMessageBracketConveyor.Location = New System.Drawing.Point(9, 18)
		Me.lblVisionMessageBracketConveyor.Name = "lblVisionMessageBracketConveyor"
		Me.lblVisionMessageBracketConveyor.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblVisionMessageBracketConveyor.Size = New System.Drawing.Size(299, 43)
		Me.lblVisionMessageBracketConveyor.TabIndex = 56
		Me.lblVisionMessageBracketConveyor.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.ToolTip1.SetToolTip(Me.lblVisionMessageBracketConveyor, "The status of the most recent locate attempt.  Click the Details button for more " &
				"information. ")
		'
		'btnDetailsBracketTape
		'
		Me.btnDetailsBracketTape.BackColor = System.Drawing.Color.Transparent
		Me.btnDetailsBracketTape.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnDetailsBracketTape.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.btnDetailsBracketTape.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnDetailsBracketTape.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnDetailsBracketTape.Location = New System.Drawing.Point(9, 139)
		Me.btnDetailsBracketTape.Name = "btnDetailsBracketTape"
		Me.btnDetailsBracketTape.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnDetailsBracketTape.Size = New System.Drawing.Size(54, 24)
		Me.btnDetailsBracketTape.TabIndex = 144
		Me.btnDetailsBracketTape.Text = "Details"
		Me.ToolTip1.SetToolTip(Me.btnDetailsBracketTape, "Click for the full description of the vision status of the most recent locate att" &
				"empt")
		Me.btnDetailsBracketTape.UseVisualStyleBackColor = False
		'
		'lblVisionMessageBracketTape
		'
		Me.lblVisionMessageBracketTape.BackColor = System.Drawing.SystemColors.Control
		Me.lblVisionMessageBracketTape.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblVisionMessageBracketTape.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblVisionMessageBracketTape.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblVisionMessageBracketTape.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblVisionMessageBracketTape.Location = New System.Drawing.Point(9, 21)
		Me.lblVisionMessageBracketTape.Name = "lblVisionMessageBracketTape"
		Me.lblVisionMessageBracketTape.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblVisionMessageBracketTape.Size = New System.Drawing.Size(269, 114)
		Me.lblVisionMessageBracketTape.TabIndex = 56
		Me.lblVisionMessageBracketTape.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.ToolTip1.SetToolTip(Me.lblVisionMessageBracketTape, "The status of the most recent locate attempt.  Click the Details button for more " &
				"information. ")
		'
		'btnDetailsBracketVerify
		'
		Me.btnDetailsBracketVerify.BackColor = System.Drawing.Color.Transparent
		Me.btnDetailsBracketVerify.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnDetailsBracketVerify.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.btnDetailsBracketVerify.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnDetailsBracketVerify.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnDetailsBracketVerify.Location = New System.Drawing.Point(11, 65)
		Me.btnDetailsBracketVerify.Name = "btnDetailsBracketVerify"
		Me.btnDetailsBracketVerify.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnDetailsBracketVerify.Size = New System.Drawing.Size(54, 24)
		Me.btnDetailsBracketVerify.TabIndex = 144
		Me.btnDetailsBracketVerify.Text = "Details"
		Me.ToolTip1.SetToolTip(Me.btnDetailsBracketVerify, "Click for the full description of the vision status of the most recent locate att" &
				"empt")
		Me.btnDetailsBracketVerify.UseVisualStyleBackColor = False
		'
		'lblVisionMessageBracketVerify
		'
		Me.lblVisionMessageBracketVerify.BackColor = System.Drawing.SystemColors.Control
		Me.lblVisionMessageBracketVerify.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblVisionMessageBracketVerify.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblVisionMessageBracketVerify.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblVisionMessageBracketVerify.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblVisionMessageBracketVerify.Location = New System.Drawing.Point(9, 18)
		Me.lblVisionMessageBracketVerify.Name = "lblVisionMessageBracketVerify"
		Me.lblVisionMessageBracketVerify.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblVisionMessageBracketVerify.Size = New System.Drawing.Size(299, 43)
		Me.lblVisionMessageBracketVerify.TabIndex = 56
		Me.lblVisionMessageBracketVerify.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.ToolTip1.SetToolTip(Me.lblVisionMessageBracketVerify, "The status of the most recent locate attempt.  Click the Details button for more " &
				"information. ")
		'
		'btnSnapBracketConveyor
		'
		Me.btnSnapBracketConveyor.BackColor = System.Drawing.Color.Transparent
		Me.btnSnapBracketConveyor.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnSnapBracketConveyor.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.btnSnapBracketConveyor.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnSnapBracketConveyor.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnSnapBracketConveyor.Location = New System.Drawing.Point(5, 18)
		Me.btnSnapBracketConveyor.Name = "btnSnapBracketConveyor"
		Me.btnSnapBracketConveyor.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnSnapBracketConveyor.Size = New System.Drawing.Size(99, 26)
		Me.btnSnapBracketConveyor.TabIndex = 73
		Me.btnSnapBracketConveyor.TabStop = False
		Me.btnSnapBracketConveyor.Text = "Take a Picture"
		Me.ToolTip1.SetToolTip(Me.btnSnapBracketConveyor, "Momentarily turns on the light and snaps a picture.  Will repeat as long as the r" &
				"epeat box is checked next to it. ")
		Me.btnSnapBracketConveyor.UseVisualStyleBackColor = False
		'
		'btnLocateOnlyBracketConveyor
		'
		Me.btnLocateOnlyBracketConveyor.BackColor = System.Drawing.Color.Transparent
		Me.btnLocateOnlyBracketConveyor.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnLocateOnlyBracketConveyor.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.btnLocateOnlyBracketConveyor.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnLocateOnlyBracketConveyor.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnLocateOnlyBracketConveyor.Location = New System.Drawing.Point(183, 9)
		Me.btnLocateOnlyBracketConveyor.Name = "btnLocateOnlyBracketConveyor"
		Me.btnLocateOnlyBracketConveyor.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnLocateOnlyBracketConveyor.Size = New System.Drawing.Size(43, 33)
		Me.btnLocateOnlyBracketConveyor.TabIndex = 166
		Me.btnLocateOnlyBracketConveyor.TabStop = False
		Me.btnLocateOnlyBracketConveyor.Text = "Locate Only"
		Me.ToolTip1.SetToolTip(Me.btnLocateOnlyBracketConveyor, "Will locate the glass based on the trained model associated with the part.  Will " &
				"continuously repeat if the repeat box is checked")
		Me.btnLocateOnlyBracketConveyor.UseVisualStyleBackColor = False
		'
		'btnLocateBracketConveyor
		'
		Me.btnLocateBracketConveyor.BackColor = System.Drawing.Color.Transparent
		Me.btnLocateBracketConveyor.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnLocateBracketConveyor.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.btnLocateBracketConveyor.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnLocateBracketConveyor.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnLocateBracketConveyor.Location = New System.Drawing.Point(5, 13)
		Me.btnLocateBracketConveyor.Name = "btnLocateBracketConveyor"
		Me.btnLocateBracketConveyor.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnLocateBracketConveyor.Size = New System.Drawing.Size(114, 26)
		Me.btnLocateBracketConveyor.TabIndex = 61
		Me.btnLocateBracketConveyor.TabStop = False
		Me.btnLocateBracketConveyor.Text = "Inspect with Snap"
		Me.ToolTip1.SetToolTip(Me.btnLocateBracketConveyor, "Will locate the glass based on the trained model associated with the part.  Will " &
				"continuously repeat if the repeat box is checked")
		Me.btnLocateBracketConveyor.UseVisualStyleBackColor = False
		'
		'updnScoreLimitBracketconveyor
		'
		Me.updnScoreLimitBracketconveyor.Location = New System.Drawing.Point(141, 70)
		Me.updnScoreLimitBracketconveyor.Minimum = New Decimal(New Integer() {70, 0, 0, 0})
		Me.updnScoreLimitBracketconveyor.Name = "updnScoreLimitBracketconveyor"
		Me.updnScoreLimitBracketconveyor.Size = New System.Drawing.Size(50, 20)
		Me.updnScoreLimitBracketconveyor.TabIndex = 69
		Me.ToolTip1.SetToolTip(Me.updnScoreLimitBracketconveyor, "The minimum score required to pick up the glass")
		Me.updnScoreLimitBracketconveyor.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
		Me.updnScoreLimitBracketconveyor.Value = New Decimal(New Integer() {95, 0, 0, 0})
		'
		'btnSearchSettingsBracketConveyor
		'
		Me.btnSearchSettingsBracketConveyor.BackColor = System.Drawing.Color.Transparent
		Me.btnSearchSettingsBracketConveyor.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnSearchSettingsBracketConveyor.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.btnSearchSettingsBracketConveyor.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnSearchSettingsBracketConveyor.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnSearchSettingsBracketConveyor.Location = New System.Drawing.Point(5, 118)
		Me.btnSearchSettingsBracketConveyor.Name = "btnSearchSettingsBracketConveyor"
		Me.btnSearchSettingsBracketConveyor.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnSearchSettingsBracketConveyor.Size = New System.Drawing.Size(114, 22)
		Me.btnSearchSettingsBracketConveyor.TabIndex = 62
		Me.btnSearchSettingsBracketConveyor.Text = "Search Settings"
		Me.ToolTip1.SetToolTip(Me.btnSearchSettingsBracketConveyor, "Search Settings - Advanced settings for the search process can by modified here. " &
				" Should not be modified unless completely necessary")
		Me.btnSearchSettingsBracketConveyor.UseVisualStyleBackColor = False
		'
		'btnTrainNewBracketconveyor
		'
		Me.btnTrainNewBracketconveyor.BackColor = System.Drawing.Color.Transparent
		Me.btnTrainNewBracketconveyor.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnTrainNewBracketconveyor.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.btnTrainNewBracketconveyor.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnTrainNewBracketconveyor.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnTrainNewBracketconveyor.Location = New System.Drawing.Point(5, 97)
		Me.btnTrainNewBracketconveyor.Name = "btnTrainNewBracketconveyor"
		Me.btnTrainNewBracketconveyor.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnTrainNewBracketconveyor.Size = New System.Drawing.Size(114, 22)
		Me.btnTrainNewBracketconveyor.TabIndex = 59
		Me.btnTrainNewBracketconveyor.TabStop = False
		Me.btnTrainNewBracketconveyor.Text = "Train New"
		Me.ToolTip1.SetToolTip(Me.btnTrainNewBracketconveyor, "Train New - Discards the old model and takes a picture to teach a new one.  This " &
				"is used to locate the glass on the incoming position and determine its pick up p" &
				"oint.")
		Me.btnTrainNewBracketconveyor.UseVisualStyleBackColor = False
		'
		'btnTrainExistingBracketConveyor
		'
		Me.btnTrainExistingBracketConveyor.BackColor = System.Drawing.Color.Transparent
		Me.btnTrainExistingBracketConveyor.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnTrainExistingBracketConveyor.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.btnTrainExistingBracketConveyor.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnTrainExistingBracketConveyor.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnTrainExistingBracketConveyor.Location = New System.Drawing.Point(5, 76)
		Me.btnTrainExistingBracketConveyor.Name = "btnTrainExistingBracketConveyor"
		Me.btnTrainExistingBracketConveyor.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnTrainExistingBracketConveyor.Size = New System.Drawing.Size(114, 22)
		Me.btnTrainExistingBracketConveyor.TabIndex = 58
		Me.btnTrainExistingBracketConveyor.TabStop = False
		Me.btnTrainExistingBracketConveyor.Text = "Train Existing"
		Me.ToolTip1.SetToolTip(Me.btnTrainExistingBracketConveyor, "Train Existing - Edits the existing model in the database.  Changes can be made t" &
				"o the current model without discarding any previous data.")
		Me.btnTrainExistingBracketConveyor.UseVisualStyleBackColor = False
		'
		'btnSnapBracketTape
		'
		Me.btnSnapBracketTape.BackColor = System.Drawing.Color.Transparent
		Me.btnSnapBracketTape.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnSnapBracketTape.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.btnSnapBracketTape.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnSnapBracketTape.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnSnapBracketTape.Location = New System.Drawing.Point(5, 18)
		Me.btnSnapBracketTape.Name = "btnSnapBracketTape"
		Me.btnSnapBracketTape.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnSnapBracketTape.Size = New System.Drawing.Size(99, 26)
		Me.btnSnapBracketTape.TabIndex = 73
		Me.btnSnapBracketTape.TabStop = False
		Me.btnSnapBracketTape.Text = "Take a Picture"
		Me.ToolTip1.SetToolTip(Me.btnSnapBracketTape, "Momentarily turns on the light and snaps a picture.  Will repeat as long as the r" &
				"epeat box is checked next to it. ")
		Me.btnSnapBracketTape.UseVisualStyleBackColor = False
		'
		'btnLocateOnlyBracketTape
		'
		Me.btnLocateOnlyBracketTape.BackColor = System.Drawing.Color.Transparent
		Me.btnLocateOnlyBracketTape.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnLocateOnlyBracketTape.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.btnLocateOnlyBracketTape.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnLocateOnlyBracketTape.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnLocateOnlyBracketTape.Location = New System.Drawing.Point(171, 53)
		Me.btnLocateOnlyBracketTape.Name = "btnLocateOnlyBracketTape"
		Me.btnLocateOnlyBracketTape.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnLocateOnlyBracketTape.Size = New System.Drawing.Size(43, 33)
		Me.btnLocateOnlyBracketTape.TabIndex = 166
		Me.btnLocateOnlyBracketTape.TabStop = False
		Me.btnLocateOnlyBracketTape.Text = "Locate Only"
		Me.ToolTip1.SetToolTip(Me.btnLocateOnlyBracketTape, "Will locate the glass based on the trained model associated with the part.  Will " &
				"continuously repeat if the repeat box is checked")
		Me.btnLocateOnlyBracketTape.UseVisualStyleBackColor = False
		'
		'btnLocateBracketTape
		'
		Me.btnLocateBracketTape.BackColor = System.Drawing.Color.Transparent
		Me.btnLocateBracketTape.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnLocateBracketTape.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.btnLocateBracketTape.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnLocateBracketTape.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnLocateBracketTape.Location = New System.Drawing.Point(171, 91)
		Me.btnLocateBracketTape.Name = "btnLocateBracketTape"
		Me.btnLocateBracketTape.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnLocateBracketTape.Size = New System.Drawing.Size(114, 22)
		Me.btnLocateBracketTape.TabIndex = 61
		Me.btnLocateBracketTape.TabStop = False
		Me.btnLocateBracketTape.Text = "Inspect with Snap"
		Me.ToolTip1.SetToolTip(Me.btnLocateBracketTape, "Will locate the glass based on the trained model associated with the part.  Will " &
				"continuously repeat if the repeat box is checked")
		Me.btnLocateBracketTape.UseVisualStyleBackColor = False
		'
		'btnSearchSettingsBracketTape
		'
		Me.btnSearchSettingsBracketTape.BackColor = System.Drawing.Color.Transparent
		Me.btnSearchSettingsBracketTape.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnSearchSettingsBracketTape.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.btnSearchSettingsBracketTape.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnSearchSettingsBracketTape.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnSearchSettingsBracketTape.Location = New System.Drawing.Point(171, 113)
		Me.btnSearchSettingsBracketTape.Name = "btnSearchSettingsBracketTape"
		Me.btnSearchSettingsBracketTape.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnSearchSettingsBracketTape.Size = New System.Drawing.Size(114, 22)
		Me.btnSearchSettingsBracketTape.TabIndex = 62
		Me.btnSearchSettingsBracketTape.Text = "Search Settings"
		Me.ToolTip1.SetToolTip(Me.btnSearchSettingsBracketTape, "Search Settings - Advanced settings for the search process can by modified here. " &
				" Should not be modified unless completely necessary")
		Me.btnSearchSettingsBracketTape.UseVisualStyleBackColor = False
		'
		'btnTrainNewBracketTape
		'
		Me.btnTrainNewBracketTape.BackColor = System.Drawing.Color.Transparent
		Me.btnTrainNewBracketTape.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnTrainNewBracketTape.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.btnTrainNewBracketTape.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnTrainNewBracketTape.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnTrainNewBracketTape.Location = New System.Drawing.Point(16, 92)
		Me.btnTrainNewBracketTape.Name = "btnTrainNewBracketTape"
		Me.btnTrainNewBracketTape.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnTrainNewBracketTape.Size = New System.Drawing.Size(114, 22)
		Me.btnTrainNewBracketTape.TabIndex = 59
		Me.btnTrainNewBracketTape.TabStop = False
		Me.btnTrainNewBracketTape.Text = "Train New"
		Me.ToolTip1.SetToolTip(Me.btnTrainNewBracketTape, "Train New - Discards the old model and takes a picture to teach a new one.  This " &
				"is used to locate the glass on the incoming position and determine its pick up p" &
				"oint.")
		Me.btnTrainNewBracketTape.UseVisualStyleBackColor = False
		'
		'btnTrainExistingBracketTape
		'
		Me.btnTrainExistingBracketTape.BackColor = System.Drawing.Color.Transparent
		Me.btnTrainExistingBracketTape.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnTrainExistingBracketTape.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.btnTrainExistingBracketTape.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnTrainExistingBracketTape.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnTrainExistingBracketTape.Location = New System.Drawing.Point(16, 113)
		Me.btnTrainExistingBracketTape.Name = "btnTrainExistingBracketTape"
		Me.btnTrainExistingBracketTape.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnTrainExistingBracketTape.Size = New System.Drawing.Size(114, 22)
		Me.btnTrainExistingBracketTape.TabIndex = 58
		Me.btnTrainExistingBracketTape.TabStop = False
		Me.btnTrainExistingBracketTape.Text = "Train Existing"
		Me.ToolTip1.SetToolTip(Me.btnTrainExistingBracketTape, "Train Existing - Edits the existing model in the database.  Changes can be made t" &
				"o the current model without discarding any previous data.")
		Me.btnTrainExistingBracketTape.UseVisualStyleBackColor = False
		'
		'btnSnapCenterVerify
		'
		Me.btnSnapCenterVerify.BackColor = System.Drawing.Color.Transparent
		Me.btnSnapCenterVerify.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnSnapCenterVerify.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.btnSnapCenterVerify.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnSnapCenterVerify.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnSnapCenterVerify.Location = New System.Drawing.Point(5, 18)
		Me.btnSnapCenterVerify.Name = "btnSnapCenterVerify"
		Me.btnSnapCenterVerify.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnSnapCenterVerify.Size = New System.Drawing.Size(99, 26)
		Me.btnSnapCenterVerify.TabIndex = 73
		Me.btnSnapCenterVerify.TabStop = False
		Me.btnSnapCenterVerify.Text = "Take a Picture"
		Me.ToolTip1.SetToolTip(Me.btnSnapCenterVerify, "Momentarily turns on the light and snaps a picture.  Will repeat as long as the r" &
				"epeat box is checked next to it. ")
		Me.btnSnapCenterVerify.UseVisualStyleBackColor = False
		'
		'btnLocateOnlyBracketVerify
		'
		Me.btnLocateOnlyBracketVerify.BackColor = System.Drawing.Color.Transparent
		Me.btnLocateOnlyBracketVerify.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnLocateOnlyBracketVerify.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.btnLocateOnlyBracketVerify.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnLocateOnlyBracketVerify.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnLocateOnlyBracketVerify.Location = New System.Drawing.Point(183, 9)
		Me.btnLocateOnlyBracketVerify.Name = "btnLocateOnlyBracketVerify"
		Me.btnLocateOnlyBracketVerify.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnLocateOnlyBracketVerify.Size = New System.Drawing.Size(43, 33)
		Me.btnLocateOnlyBracketVerify.TabIndex = 166
		Me.btnLocateOnlyBracketVerify.TabStop = False
		Me.btnLocateOnlyBracketVerify.Text = "Locate Only"
		Me.ToolTip1.SetToolTip(Me.btnLocateOnlyBracketVerify, "Will locate the glass based on the trained model associated with the part.  Will " &
				"continuously repeat if the repeat box is checked")
		Me.btnLocateOnlyBracketVerify.UseVisualStyleBackColor = False
		'
		'btnLocateBracketVerify
		'
		Me.btnLocateBracketVerify.BackColor = System.Drawing.Color.Transparent
		Me.btnLocateBracketVerify.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnLocateBracketVerify.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.btnLocateBracketVerify.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnLocateBracketVerify.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnLocateBracketVerify.Location = New System.Drawing.Point(5, 13)
		Me.btnLocateBracketVerify.Name = "btnLocateBracketVerify"
		Me.btnLocateBracketVerify.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnLocateBracketVerify.Size = New System.Drawing.Size(114, 26)
		Me.btnLocateBracketVerify.TabIndex = 61
		Me.btnLocateBracketVerify.TabStop = False
		Me.btnLocateBracketVerify.Text = "Inspect with Snap"
		Me.ToolTip1.SetToolTip(Me.btnLocateBracketVerify, "Will locate the glass based on the trained model associated with the part.  Will " &
				"continuously repeat if the repeat box is checked")
		Me.btnLocateBracketVerify.UseVisualStyleBackColor = False
		'
		'updnScoreLimitCenterVerify
		'
		Me.updnScoreLimitCenterVerify.Location = New System.Drawing.Point(141, 70)
		Me.updnScoreLimitCenterVerify.Minimum = New Decimal(New Integer() {70, 0, 0, 0})
		Me.updnScoreLimitCenterVerify.Name = "updnScoreLimitCenterVerify"
		Me.updnScoreLimitCenterVerify.Size = New System.Drawing.Size(50, 20)
		Me.updnScoreLimitCenterVerify.TabIndex = 69
		Me.ToolTip1.SetToolTip(Me.updnScoreLimitCenterVerify, "The minimum score required to pick up the glass")
		Me.updnScoreLimitCenterVerify.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
		Me.updnScoreLimitCenterVerify.Value = New Decimal(New Integer() {95, 0, 0, 0})
		'
		'btnSearchSettingsCenterVerify
		'
		Me.btnSearchSettingsCenterVerify.BackColor = System.Drawing.Color.Transparent
		Me.btnSearchSettingsCenterVerify.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnSearchSettingsCenterVerify.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.btnSearchSettingsCenterVerify.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnSearchSettingsCenterVerify.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnSearchSettingsCenterVerify.Location = New System.Drawing.Point(5, 118)
		Me.btnSearchSettingsCenterVerify.Name = "btnSearchSettingsCenterVerify"
		Me.btnSearchSettingsCenterVerify.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnSearchSettingsCenterVerify.Size = New System.Drawing.Size(114, 22)
		Me.btnSearchSettingsCenterVerify.TabIndex = 62
		Me.btnSearchSettingsCenterVerify.Text = "Search Settings"
		Me.ToolTip1.SetToolTip(Me.btnSearchSettingsCenterVerify, "Search Settings - Advanced settings for the search process can by modified here. " &
				" Should not be modified unless completely necessary")
		Me.btnSearchSettingsCenterVerify.UseVisualStyleBackColor = False
		'
		'btnTrainNewCenterVerify
		'
		Me.btnTrainNewCenterVerify.BackColor = System.Drawing.Color.Transparent
		Me.btnTrainNewCenterVerify.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnTrainNewCenterVerify.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.btnTrainNewCenterVerify.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnTrainNewCenterVerify.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnTrainNewCenterVerify.Location = New System.Drawing.Point(5, 97)
		Me.btnTrainNewCenterVerify.Name = "btnTrainNewCenterVerify"
		Me.btnTrainNewCenterVerify.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnTrainNewCenterVerify.Size = New System.Drawing.Size(114, 22)
		Me.btnTrainNewCenterVerify.TabIndex = 59
		Me.btnTrainNewCenterVerify.TabStop = False
		Me.btnTrainNewCenterVerify.Text = "Train New"
		Me.ToolTip1.SetToolTip(Me.btnTrainNewCenterVerify, "Train New - Discards the old model and takes a picture to teach a new one.  This " &
				"is used to locate the glass on the incoming position and determine its pick up p" &
				"oint.")
		Me.btnTrainNewCenterVerify.UseVisualStyleBackColor = False
		'
		'btnTrainExistingCenterVerify
		'
		Me.btnTrainExistingCenterVerify.BackColor = System.Drawing.Color.Transparent
		Me.btnTrainExistingCenterVerify.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnTrainExistingCenterVerify.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.btnTrainExistingCenterVerify.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnTrainExistingCenterVerify.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnTrainExistingCenterVerify.Location = New System.Drawing.Point(5, 76)
		Me.btnTrainExistingCenterVerify.Name = "btnTrainExistingCenterVerify"
		Me.btnTrainExistingCenterVerify.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnTrainExistingCenterVerify.Size = New System.Drawing.Size(114, 22)
		Me.btnTrainExistingCenterVerify.TabIndex = 58
		Me.btnTrainExistingCenterVerify.TabStop = False
		Me.btnTrainExistingCenterVerify.Text = "Train Existing"
		Me.ToolTip1.SetToolTip(Me.btnTrainExistingCenterVerify, "Train Existing - Edits the existing model in the database.  Changes can be made t" &
				"o the current model without discarding any previous data.")
		Me.btnTrainExistingCenterVerify.UseVisualStyleBackColor = False
		'
		'btnSnapDriver
		'
		Me.btnSnapDriver.BackColor = System.Drawing.Color.Transparent
		Me.btnSnapDriver.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnSnapDriver.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.btnSnapDriver.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnSnapDriver.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnSnapDriver.Location = New System.Drawing.Point(5, 18)
		Me.btnSnapDriver.Name = "btnSnapDriver"
		Me.btnSnapDriver.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnSnapDriver.Size = New System.Drawing.Size(99, 26)
		Me.btnSnapDriver.TabIndex = 73
		Me.btnSnapDriver.TabStop = False
		Me.btnSnapDriver.Text = "Take a Picture"
		Me.ToolTip1.SetToolTip(Me.btnSnapDriver, "Momentarily turns on the light and snaps a picture.  Will repeat as long as the r" &
				"epeat box is checked next to it. ")
		Me.btnSnapDriver.UseVisualStyleBackColor = False
		'
		'btnLocateOnlyDriver
		'
		Me.btnLocateOnlyDriver.BackColor = System.Drawing.Color.Transparent
		Me.btnLocateOnlyDriver.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnLocateOnlyDriver.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.btnLocateOnlyDriver.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnLocateOnlyDriver.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnLocateOnlyDriver.Location = New System.Drawing.Point(183, 9)
		Me.btnLocateOnlyDriver.Name = "btnLocateOnlyDriver"
		Me.btnLocateOnlyDriver.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnLocateOnlyDriver.Size = New System.Drawing.Size(43, 33)
		Me.btnLocateOnlyDriver.TabIndex = 166
		Me.btnLocateOnlyDriver.TabStop = False
		Me.btnLocateOnlyDriver.Text = "Locate Only"
		Me.ToolTip1.SetToolTip(Me.btnLocateOnlyDriver, "Will locate the glass based on the trained model associated with the part.  Will " &
				"continuously repeat if the repeat box is checked")
		Me.btnLocateOnlyDriver.UseVisualStyleBackColor = False
		'
		'btnLocateDriver
		'
		Me.btnLocateDriver.BackColor = System.Drawing.Color.Transparent
		Me.btnLocateDriver.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnLocateDriver.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.btnLocateDriver.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnLocateDriver.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnLocateDriver.Location = New System.Drawing.Point(5, 13)
		Me.btnLocateDriver.Name = "btnLocateDriver"
		Me.btnLocateDriver.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnLocateDriver.Size = New System.Drawing.Size(114, 26)
		Me.btnLocateDriver.TabIndex = 61
		Me.btnLocateDriver.TabStop = False
		Me.btnLocateDriver.Text = "Inspect with Snap"
		Me.ToolTip1.SetToolTip(Me.btnLocateDriver, "Will locate the glass based on the trained model associated with the part.  Will " &
				"continuously repeat if the repeat box is checked")
		Me.btnLocateDriver.UseVisualStyleBackColor = False
		'
		'updnScoreLimitDriver
		'
		Me.updnScoreLimitDriver.Location = New System.Drawing.Point(141, 70)
		Me.updnScoreLimitDriver.Minimum = New Decimal(New Integer() {70, 0, 0, 0})
		Me.updnScoreLimitDriver.Name = "updnScoreLimitDriver"
		Me.updnScoreLimitDriver.Size = New System.Drawing.Size(50, 20)
		Me.updnScoreLimitDriver.TabIndex = 69
		Me.ToolTip1.SetToolTip(Me.updnScoreLimitDriver, "The minimum score required to pick up the glass")
		Me.updnScoreLimitDriver.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
		Me.updnScoreLimitDriver.Value = New Decimal(New Integer() {95, 0, 0, 0})
		'
		'btnSearchSettingsDriver
		'
		Me.btnSearchSettingsDriver.BackColor = System.Drawing.Color.Transparent
		Me.btnSearchSettingsDriver.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnSearchSettingsDriver.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.btnSearchSettingsDriver.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnSearchSettingsDriver.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnSearchSettingsDriver.Location = New System.Drawing.Point(5, 118)
		Me.btnSearchSettingsDriver.Name = "btnSearchSettingsDriver"
		Me.btnSearchSettingsDriver.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnSearchSettingsDriver.Size = New System.Drawing.Size(114, 22)
		Me.btnSearchSettingsDriver.TabIndex = 62
		Me.btnSearchSettingsDriver.Text = "Search Settings"
		Me.ToolTip1.SetToolTip(Me.btnSearchSettingsDriver, "Search Settings - Advanced settings for the search process can by modified here. " &
				" Should not be modified unless completely necessary")
		Me.btnSearchSettingsDriver.UseVisualStyleBackColor = False
		'
		'btnTrainNewDriver
		'
		Me.btnTrainNewDriver.BackColor = System.Drawing.Color.Transparent
		Me.btnTrainNewDriver.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnTrainNewDriver.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.btnTrainNewDriver.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnTrainNewDriver.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnTrainNewDriver.Location = New System.Drawing.Point(5, 97)
		Me.btnTrainNewDriver.Name = "btnTrainNewDriver"
		Me.btnTrainNewDriver.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnTrainNewDriver.Size = New System.Drawing.Size(114, 22)
		Me.btnTrainNewDriver.TabIndex = 59
		Me.btnTrainNewDriver.TabStop = False
		Me.btnTrainNewDriver.Text = "Train New"
		Me.ToolTip1.SetToolTip(Me.btnTrainNewDriver, "Train New - Discards the old model and takes a picture to teach a new one.  This " &
				"is used to locate the glass on the incoming position and determine its pick up p" &
				"oint.")
		Me.btnTrainNewDriver.UseVisualStyleBackColor = False
		'
		'btnTrainExistingDriver
		'
		Me.btnTrainExistingDriver.BackColor = System.Drawing.Color.Transparent
		Me.btnTrainExistingDriver.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnTrainExistingDriver.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.btnTrainExistingDriver.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnTrainExistingDriver.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnTrainExistingDriver.Location = New System.Drawing.Point(5, 76)
		Me.btnTrainExistingDriver.Name = "btnTrainExistingDriver"
		Me.btnTrainExistingDriver.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnTrainExistingDriver.Size = New System.Drawing.Size(114, 22)
		Me.btnTrainExistingDriver.TabIndex = 58
		Me.btnTrainExistingDriver.TabStop = False
		Me.btnTrainExistingDriver.Text = "Train Existing"
		Me.ToolTip1.SetToolTip(Me.btnTrainExistingDriver, "Train Existing - Edits the existing model in the database.  Changes can be made t" &
				"o the current model without discarding any previous data.")
		Me.btnTrainExistingDriver.UseVisualStyleBackColor = False
		'
		'btnSnapCenter
		'
		Me.btnSnapCenter.BackColor = System.Drawing.Color.Transparent
		Me.btnSnapCenter.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnSnapCenter.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.btnSnapCenter.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnSnapCenter.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnSnapCenter.Location = New System.Drawing.Point(5, 18)
		Me.btnSnapCenter.Name = "btnSnapCenter"
		Me.btnSnapCenter.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnSnapCenter.Size = New System.Drawing.Size(99, 26)
		Me.btnSnapCenter.TabIndex = 73
		Me.btnSnapCenter.TabStop = False
		Me.btnSnapCenter.Text = "Take a Picture"
		Me.ToolTip1.SetToolTip(Me.btnSnapCenter, "Momentarily turns on the light and snaps a picture.  Will repeat as long as the r" &
				"epeat box is checked next to it. ")
		Me.btnSnapCenter.UseVisualStyleBackColor = False
		'
		'btnLocateOnlyCenter
		'
		Me.btnLocateOnlyCenter.BackColor = System.Drawing.Color.Transparent
		Me.btnLocateOnlyCenter.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnLocateOnlyCenter.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.btnLocateOnlyCenter.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnLocateOnlyCenter.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnLocateOnlyCenter.Location = New System.Drawing.Point(183, 9)
		Me.btnLocateOnlyCenter.Name = "btnLocateOnlyCenter"
		Me.btnLocateOnlyCenter.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnLocateOnlyCenter.Size = New System.Drawing.Size(43, 33)
		Me.btnLocateOnlyCenter.TabIndex = 166
		Me.btnLocateOnlyCenter.TabStop = False
		Me.btnLocateOnlyCenter.Text = "Locate Only"
		Me.ToolTip1.SetToolTip(Me.btnLocateOnlyCenter, "Will locate the glass based on the trained model associated with the part.  Will " &
				"continuously repeat if the repeat box is checked")
		Me.btnLocateOnlyCenter.UseVisualStyleBackColor = False
		'
		'btnLocateCenter
		'
		Me.btnLocateCenter.BackColor = System.Drawing.Color.Transparent
		Me.btnLocateCenter.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnLocateCenter.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.btnLocateCenter.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnLocateCenter.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnLocateCenter.Location = New System.Drawing.Point(5, 13)
		Me.btnLocateCenter.Name = "btnLocateCenter"
		Me.btnLocateCenter.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnLocateCenter.Size = New System.Drawing.Size(114, 26)
		Me.btnLocateCenter.TabIndex = 61
		Me.btnLocateCenter.TabStop = False
		Me.btnLocateCenter.Text = "Inspect with Snap"
		Me.ToolTip1.SetToolTip(Me.btnLocateCenter, "Will locate the glass based on the trained model associated with the part.  Will " &
				"continuously repeat if the repeat box is checked")
		Me.btnLocateCenter.UseVisualStyleBackColor = False
		'
		'updnScoreLimitCenter
		'
		Me.updnScoreLimitCenter.Location = New System.Drawing.Point(141, 70)
		Me.updnScoreLimitCenter.Minimum = New Decimal(New Integer() {70, 0, 0, 0})
		Me.updnScoreLimitCenter.Name = "updnScoreLimitCenter"
		Me.updnScoreLimitCenter.Size = New System.Drawing.Size(50, 20)
		Me.updnScoreLimitCenter.TabIndex = 69
		Me.ToolTip1.SetToolTip(Me.updnScoreLimitCenter, "The minimum score required to pick up the glass")
		Me.updnScoreLimitCenter.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
		Me.updnScoreLimitCenter.Value = New Decimal(New Integer() {95, 0, 0, 0})
		'
		'btnSearchSettingsCenter
		'
		Me.btnSearchSettingsCenter.BackColor = System.Drawing.Color.Transparent
		Me.btnSearchSettingsCenter.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnSearchSettingsCenter.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.btnSearchSettingsCenter.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnSearchSettingsCenter.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnSearchSettingsCenter.Location = New System.Drawing.Point(5, 118)
		Me.btnSearchSettingsCenter.Name = "btnSearchSettingsCenter"
		Me.btnSearchSettingsCenter.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnSearchSettingsCenter.Size = New System.Drawing.Size(114, 22)
		Me.btnSearchSettingsCenter.TabIndex = 62
		Me.btnSearchSettingsCenter.Text = "Search Settings"
		Me.ToolTip1.SetToolTip(Me.btnSearchSettingsCenter, "Search Settings - Advanced settings for the search process can by modified here. " &
				" Should not be modified unless completely necessary")
		Me.btnSearchSettingsCenter.UseVisualStyleBackColor = False
		'
		'btnTrainNewCenter
		'
		Me.btnTrainNewCenter.BackColor = System.Drawing.Color.Transparent
		Me.btnTrainNewCenter.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnTrainNewCenter.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.btnTrainNewCenter.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnTrainNewCenter.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnTrainNewCenter.Location = New System.Drawing.Point(5, 97)
		Me.btnTrainNewCenter.Name = "btnTrainNewCenter"
		Me.btnTrainNewCenter.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnTrainNewCenter.Size = New System.Drawing.Size(114, 22)
		Me.btnTrainNewCenter.TabIndex = 59
		Me.btnTrainNewCenter.TabStop = False
		Me.btnTrainNewCenter.Text = "Train New"
		Me.ToolTip1.SetToolTip(Me.btnTrainNewCenter, "Train New - Discards the old model and takes a picture to teach a new one.  This " &
				"is used to locate the glass on the incoming position and determine its pick up p" &
				"oint.")
		Me.btnTrainNewCenter.UseVisualStyleBackColor = False
		'
		'btnTrainExistingCenter
		'
		Me.btnTrainExistingCenter.BackColor = System.Drawing.Color.Transparent
		Me.btnTrainExistingCenter.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnTrainExistingCenter.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.btnTrainExistingCenter.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnTrainExistingCenter.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnTrainExistingCenter.Location = New System.Drawing.Point(5, 76)
		Me.btnTrainExistingCenter.Name = "btnTrainExistingCenter"
		Me.btnTrainExistingCenter.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnTrainExistingCenter.Size = New System.Drawing.Size(114, 22)
		Me.btnTrainExistingCenter.TabIndex = 58
		Me.btnTrainExistingCenter.TabStop = False
		Me.btnTrainExistingCenter.Text = "Train Existing"
		Me.ToolTip1.SetToolTip(Me.btnTrainExistingCenter, "Train Existing - Edits the existing model in the database.  Changes can be made t" &
				"o the current model without discarding any previous data.")
		Me.btnTrainExistingCenter.UseVisualStyleBackColor = False
		'
		'btnSnapPassenger
		'
		Me.btnSnapPassenger.BackColor = System.Drawing.Color.Transparent
		Me.btnSnapPassenger.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnSnapPassenger.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.btnSnapPassenger.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnSnapPassenger.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnSnapPassenger.Location = New System.Drawing.Point(5, 18)
		Me.btnSnapPassenger.Name = "btnSnapPassenger"
		Me.btnSnapPassenger.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnSnapPassenger.Size = New System.Drawing.Size(99, 26)
		Me.btnSnapPassenger.TabIndex = 73
		Me.btnSnapPassenger.TabStop = False
		Me.btnSnapPassenger.Text = "Take a Picture"
		Me.ToolTip1.SetToolTip(Me.btnSnapPassenger, "Momentarily turns on the light and snaps a picture.  Will repeat as long as the r" &
				"epeat box is checked next to it. ")
		Me.btnSnapPassenger.UseVisualStyleBackColor = False
		'
		'btnLocateOnlyPassenger
		'
		Me.btnLocateOnlyPassenger.BackColor = System.Drawing.Color.Transparent
		Me.btnLocateOnlyPassenger.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnLocateOnlyPassenger.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.btnLocateOnlyPassenger.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnLocateOnlyPassenger.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnLocateOnlyPassenger.Location = New System.Drawing.Point(183, 9)
		Me.btnLocateOnlyPassenger.Name = "btnLocateOnlyPassenger"
		Me.btnLocateOnlyPassenger.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnLocateOnlyPassenger.Size = New System.Drawing.Size(43, 33)
		Me.btnLocateOnlyPassenger.TabIndex = 166
		Me.btnLocateOnlyPassenger.TabStop = False
		Me.btnLocateOnlyPassenger.Text = "Locate Only"
		Me.ToolTip1.SetToolTip(Me.btnLocateOnlyPassenger, "Will locate the glass based on the trained model associated with the part.  Will " &
				"continuously repeat if the repeat box is checked")
		Me.btnLocateOnlyPassenger.UseVisualStyleBackColor = False
		'
		'btnLocatePassenger
		'
		Me.btnLocatePassenger.BackColor = System.Drawing.Color.Transparent
		Me.btnLocatePassenger.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnLocatePassenger.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.btnLocatePassenger.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnLocatePassenger.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnLocatePassenger.Location = New System.Drawing.Point(5, 13)
		Me.btnLocatePassenger.Name = "btnLocatePassenger"
		Me.btnLocatePassenger.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnLocatePassenger.Size = New System.Drawing.Size(114, 26)
		Me.btnLocatePassenger.TabIndex = 61
		Me.btnLocatePassenger.TabStop = False
		Me.btnLocatePassenger.Text = "Inspect with Snap"
		Me.ToolTip1.SetToolTip(Me.btnLocatePassenger, "Will locate the glass based on the trained model associated with the part.  Will " &
				"continuously repeat if the repeat box is checked")
		Me.btnLocatePassenger.UseVisualStyleBackColor = False
		'
		'updnScoreLimitPassenger
		'
		Me.updnScoreLimitPassenger.Location = New System.Drawing.Point(141, 70)
		Me.updnScoreLimitPassenger.Minimum = New Decimal(New Integer() {70, 0, 0, 0})
		Me.updnScoreLimitPassenger.Name = "updnScoreLimitPassenger"
		Me.updnScoreLimitPassenger.Size = New System.Drawing.Size(50, 20)
		Me.updnScoreLimitPassenger.TabIndex = 69
		Me.ToolTip1.SetToolTip(Me.updnScoreLimitPassenger, "The minimum score required to pick up the glass")
		Me.updnScoreLimitPassenger.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
		Me.updnScoreLimitPassenger.Value = New Decimal(New Integer() {95, 0, 0, 0})
		'
		'btnSearchSettingsPassenger
		'
		Me.btnSearchSettingsPassenger.BackColor = System.Drawing.Color.Transparent
		Me.btnSearchSettingsPassenger.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnSearchSettingsPassenger.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.btnSearchSettingsPassenger.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnSearchSettingsPassenger.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnSearchSettingsPassenger.Location = New System.Drawing.Point(5, 118)
		Me.btnSearchSettingsPassenger.Name = "btnSearchSettingsPassenger"
		Me.btnSearchSettingsPassenger.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnSearchSettingsPassenger.Size = New System.Drawing.Size(114, 22)
		Me.btnSearchSettingsPassenger.TabIndex = 62
		Me.btnSearchSettingsPassenger.Text = "Search Settings"
		Me.ToolTip1.SetToolTip(Me.btnSearchSettingsPassenger, "Search Settings - Advanced settings for the search process can by modified here. " &
				" Should not be modified unless completely necessary")
		Me.btnSearchSettingsPassenger.UseVisualStyleBackColor = False
		'
		'btnTrainNewPassenger
		'
		Me.btnTrainNewPassenger.BackColor = System.Drawing.Color.Transparent
		Me.btnTrainNewPassenger.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnTrainNewPassenger.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.btnTrainNewPassenger.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnTrainNewPassenger.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnTrainNewPassenger.Location = New System.Drawing.Point(5, 97)
		Me.btnTrainNewPassenger.Name = "btnTrainNewPassenger"
		Me.btnTrainNewPassenger.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnTrainNewPassenger.Size = New System.Drawing.Size(114, 22)
		Me.btnTrainNewPassenger.TabIndex = 59
		Me.btnTrainNewPassenger.TabStop = False
		Me.btnTrainNewPassenger.Text = "Train New"
		Me.ToolTip1.SetToolTip(Me.btnTrainNewPassenger, "Train New - Discards the old model and takes a picture to teach a new one.  This " &
				"is used to locate the glass on the incoming position and determine its pick up p" &
				"oint.")
		Me.btnTrainNewPassenger.UseVisualStyleBackColor = False
		'
		'btnTrainExistingPassenger
		'
		Me.btnTrainExistingPassenger.BackColor = System.Drawing.Color.Transparent
		Me.btnTrainExistingPassenger.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnTrainExistingPassenger.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.btnTrainExistingPassenger.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnTrainExistingPassenger.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnTrainExistingPassenger.Location = New System.Drawing.Point(5, 76)
		Me.btnTrainExistingPassenger.Name = "btnTrainExistingPassenger"
		Me.btnTrainExistingPassenger.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnTrainExistingPassenger.Size = New System.Drawing.Size(114, 22)
		Me.btnTrainExistingPassenger.TabIndex = 58
		Me.btnTrainExistingPassenger.TabStop = False
		Me.btnTrainExistingPassenger.Text = "Train Existing"
		Me.ToolTip1.SetToolTip(Me.btnTrainExistingPassenger, "Train Existing - Edits the existing model in the database.  Changes can be made t" &
				"o the current model without discarding any previous data.")
		Me.btnTrainExistingPassenger.UseVisualStyleBackColor = False
		'
		'btnDriverTrainBlob
		'
		Me.btnDriverTrainBlob.BackColor = System.Drawing.Color.Transparent
		Me.btnDriverTrainBlob.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnDriverTrainBlob.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.btnDriverTrainBlob.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnDriverTrainBlob.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnDriverTrainBlob.Location = New System.Drawing.Point(265, 17)
		Me.btnDriverTrainBlob.Name = "btnDriverTrainBlob"
		Me.btnDriverTrainBlob.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnDriverTrainBlob.Size = New System.Drawing.Size(79, 22)
		Me.btnDriverTrainBlob.TabIndex = 167
		Me.btnDriverTrainBlob.TabStop = False
		Me.btnDriverTrainBlob.Text = "Train Primer"
		Me.ToolTip1.SetToolTip(Me.btnDriverTrainBlob, "Train Existing - Edits the existing model in the database.  Changes can be made t" &
				"o the current model without discarding any previous data.")
		Me.btnDriverTrainBlob.UseVisualStyleBackColor = False
		'
		'btnDriverSaveBlob
		'
		Me.btnDriverSaveBlob.BackColor = System.Drawing.Color.Transparent
		Me.btnDriverSaveBlob.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnDriverSaveBlob.Enabled = False
		Me.btnDriverSaveBlob.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.btnDriverSaveBlob.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnDriverSaveBlob.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnDriverSaveBlob.Location = New System.Drawing.Point(265, 51)
		Me.btnDriverSaveBlob.Name = "btnDriverSaveBlob"
		Me.btnDriverSaveBlob.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnDriverSaveBlob.Size = New System.Drawing.Size(79, 22)
		Me.btnDriverSaveBlob.TabIndex = 168
		Me.btnDriverSaveBlob.TabStop = False
		Me.btnDriverSaveBlob.Text = "Save Primer"
		Me.ToolTip1.SetToolTip(Me.btnDriverSaveBlob, "Train Existing - Edits the existing model in the database.  Changes can be made t" &
				"o the current model without discarding any previous data.")
		Me.btnDriverSaveBlob.UseVisualStyleBackColor = False
		'
		'btnCenterSaveBlob
		'
		Me.btnCenterSaveBlob.BackColor = System.Drawing.Color.Transparent
		Me.btnCenterSaveBlob.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnCenterSaveBlob.Enabled = False
		Me.btnCenterSaveBlob.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.btnCenterSaveBlob.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnCenterSaveBlob.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnCenterSaveBlob.Location = New System.Drawing.Point(265, 51)
		Me.btnCenterSaveBlob.Name = "btnCenterSaveBlob"
		Me.btnCenterSaveBlob.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnCenterSaveBlob.Size = New System.Drawing.Size(79, 22)
		Me.btnCenterSaveBlob.TabIndex = 170
		Me.btnCenterSaveBlob.TabStop = False
		Me.btnCenterSaveBlob.Text = "Save Primer"
		Me.ToolTip1.SetToolTip(Me.btnCenterSaveBlob, "Train Existing - Edits the existing model in the database.  Changes can be made t" &
				"o the current model without discarding any previous data.")
		Me.btnCenterSaveBlob.UseVisualStyleBackColor = False
		'
		'btnCenterTrainBlob
		'
		Me.btnCenterTrainBlob.BackColor = System.Drawing.Color.Transparent
		Me.btnCenterTrainBlob.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnCenterTrainBlob.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.btnCenterTrainBlob.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnCenterTrainBlob.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnCenterTrainBlob.Location = New System.Drawing.Point(265, 17)
		Me.btnCenterTrainBlob.Name = "btnCenterTrainBlob"
		Me.btnCenterTrainBlob.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnCenterTrainBlob.Size = New System.Drawing.Size(79, 22)
		Me.btnCenterTrainBlob.TabIndex = 169
		Me.btnCenterTrainBlob.TabStop = False
		Me.btnCenterTrainBlob.Text = "Train Primer"
		Me.ToolTip1.SetToolTip(Me.btnCenterTrainBlob, "Train Existing - Edits the existing model in the database.  Changes can be made t" &
				"o the current model without discarding any previous data.")
		Me.btnCenterTrainBlob.UseVisualStyleBackColor = False
		'
		'btnPassengerSaveBlob
		'
		Me.btnPassengerSaveBlob.BackColor = System.Drawing.Color.Transparent
		Me.btnPassengerSaveBlob.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnPassengerSaveBlob.Enabled = False
		Me.btnPassengerSaveBlob.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.btnPassengerSaveBlob.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnPassengerSaveBlob.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnPassengerSaveBlob.Location = New System.Drawing.Point(265, 51)
		Me.btnPassengerSaveBlob.Name = "btnPassengerSaveBlob"
		Me.btnPassengerSaveBlob.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnPassengerSaveBlob.Size = New System.Drawing.Size(79, 22)
		Me.btnPassengerSaveBlob.TabIndex = 172
		Me.btnPassengerSaveBlob.TabStop = False
		Me.btnPassengerSaveBlob.Text = "Save Primer"
		Me.ToolTip1.SetToolTip(Me.btnPassengerSaveBlob, "Train Existing - Edits the existing model in the database.  Changes can be made t" &
				"o the current model without discarding any previous data.")
		Me.btnPassengerSaveBlob.UseVisualStyleBackColor = False
		'
		'btnPassengerTrainBlob
		'
		Me.btnPassengerTrainBlob.BackColor = System.Drawing.Color.Transparent
		Me.btnPassengerTrainBlob.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnPassengerTrainBlob.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.btnPassengerTrainBlob.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnPassengerTrainBlob.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnPassengerTrainBlob.Location = New System.Drawing.Point(265, 19)
		Me.btnPassengerTrainBlob.Name = "btnPassengerTrainBlob"
		Me.btnPassengerTrainBlob.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnPassengerTrainBlob.Size = New System.Drawing.Size(79, 22)
		Me.btnPassengerTrainBlob.TabIndex = 171
		Me.btnPassengerTrainBlob.TabStop = False
		Me.btnPassengerTrainBlob.Text = "Train Primer"
		Me.ToolTip1.SetToolTip(Me.btnPassengerTrainBlob, "Train Existing - Edits the existing model in the database.  Changes can be made t" &
				"o the current model without discarding any previous data.")
		Me.btnPassengerTrainBlob.UseVisualStyleBackColor = False
		'
		'btnSnapBracketPrimer
		'
		Me.btnSnapBracketPrimer.BackColor = System.Drawing.Color.Transparent
		Me.btnSnapBracketPrimer.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnSnapBracketPrimer.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.btnSnapBracketPrimer.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnSnapBracketPrimer.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnSnapBracketPrimer.Location = New System.Drawing.Point(5, 18)
		Me.btnSnapBracketPrimer.Name = "btnSnapBracketPrimer"
		Me.btnSnapBracketPrimer.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnSnapBracketPrimer.Size = New System.Drawing.Size(99, 26)
		Me.btnSnapBracketPrimer.TabIndex = 73
		Me.btnSnapBracketPrimer.TabStop = False
		Me.btnSnapBracketPrimer.Text = "Take a Picture"
		Me.ToolTip1.SetToolTip(Me.btnSnapBracketPrimer, "Momentarily turns on the light and snaps a picture.  Will repeat as long as the r" &
				"epeat box is checked next to it. ")
		Me.btnSnapBracketPrimer.UseVisualStyleBackColor = False
		'
		'btnBracketPrimerDetails
		'
		Me.btnBracketPrimerDetails.BackColor = System.Drawing.Color.Transparent
		Me.btnBracketPrimerDetails.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnBracketPrimerDetails.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.btnBracketPrimerDetails.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnBracketPrimerDetails.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnBracketPrimerDetails.Location = New System.Drawing.Point(11, 65)
		Me.btnBracketPrimerDetails.Name = "btnBracketPrimerDetails"
		Me.btnBracketPrimerDetails.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnBracketPrimerDetails.Size = New System.Drawing.Size(54, 24)
		Me.btnBracketPrimerDetails.TabIndex = 144
		Me.btnBracketPrimerDetails.Text = "Details"
		Me.ToolTip1.SetToolTip(Me.btnBracketPrimerDetails, "Click for the full description of the vision status of the most recent locate att" &
				"empt")
		Me.btnBracketPrimerDetails.UseVisualStyleBackColor = False
		'
		'lblVisionMessageBracketPrimer
		'
		Me.lblVisionMessageBracketPrimer.BackColor = System.Drawing.SystemColors.Control
		Me.lblVisionMessageBracketPrimer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblVisionMessageBracketPrimer.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblVisionMessageBracketPrimer.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblVisionMessageBracketPrimer.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblVisionMessageBracketPrimer.Location = New System.Drawing.Point(9, 18)
		Me.lblVisionMessageBracketPrimer.Name = "lblVisionMessageBracketPrimer"
		Me.lblVisionMessageBracketPrimer.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblVisionMessageBracketPrimer.Size = New System.Drawing.Size(299, 43)
		Me.lblVisionMessageBracketPrimer.TabIndex = 56
		Me.lblVisionMessageBracketPrimer.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.ToolTip1.SetToolTip(Me.lblVisionMessageBracketPrimer, "The status of the most recent locate attempt.  Click the Details button for more " &
				"information. ")
		'
		'btnLocateOnlyBracketPrimer
		'
		Me.btnLocateOnlyBracketPrimer.BackColor = System.Drawing.Color.Transparent
		Me.btnLocateOnlyBracketPrimer.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnLocateOnlyBracketPrimer.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.btnLocateOnlyBracketPrimer.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnLocateOnlyBracketPrimer.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnLocateOnlyBracketPrimer.Location = New System.Drawing.Point(183, 9)
		Me.btnLocateOnlyBracketPrimer.Name = "btnLocateOnlyBracketPrimer"
		Me.btnLocateOnlyBracketPrimer.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnLocateOnlyBracketPrimer.Size = New System.Drawing.Size(43, 33)
		Me.btnLocateOnlyBracketPrimer.TabIndex = 166
		Me.btnLocateOnlyBracketPrimer.TabStop = False
		Me.btnLocateOnlyBracketPrimer.Text = "Locate Only"
		Me.ToolTip1.SetToolTip(Me.btnLocateOnlyBracketPrimer, "Will locate the glass based on the trained model associated with the part.  Will " &
				"continuously repeat if the repeat box is checked")
		Me.btnLocateOnlyBracketPrimer.UseVisualStyleBackColor = False
		'
		'btnLocateBracketPrimer
		'
		Me.btnLocateBracketPrimer.BackColor = System.Drawing.Color.Transparent
		Me.btnLocateBracketPrimer.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnLocateBracketPrimer.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.btnLocateBracketPrimer.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnLocateBracketPrimer.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnLocateBracketPrimer.Location = New System.Drawing.Point(5, 13)
		Me.btnLocateBracketPrimer.Name = "btnLocateBracketPrimer"
		Me.btnLocateBracketPrimer.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnLocateBracketPrimer.Size = New System.Drawing.Size(114, 26)
		Me.btnLocateBracketPrimer.TabIndex = 61
		Me.btnLocateBracketPrimer.TabStop = False
		Me.btnLocateBracketPrimer.Text = "Inspect with Snap"
		Me.ToolTip1.SetToolTip(Me.btnLocateBracketPrimer, "Will locate the glass based on the trained model associated with the part.  Will " &
				"continuously repeat if the repeat box is checked")
		Me.btnLocateBracketPrimer.UseVisualStyleBackColor = False
		'
		'updnScoreLimitBracketPrimer
		'
		Me.updnScoreLimitBracketPrimer.Location = New System.Drawing.Point(141, 70)
		Me.updnScoreLimitBracketPrimer.Minimum = New Decimal(New Integer() {70, 0, 0, 0})
		Me.updnScoreLimitBracketPrimer.Name = "updnScoreLimitBracketPrimer"
		Me.updnScoreLimitBracketPrimer.Size = New System.Drawing.Size(50, 20)
		Me.updnScoreLimitBracketPrimer.TabIndex = 69
		Me.ToolTip1.SetToolTip(Me.updnScoreLimitBracketPrimer, "The minimum score required to pick up the glass")
		Me.updnScoreLimitBracketPrimer.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
		Me.updnScoreLimitBracketPrimer.Value = New Decimal(New Integer() {95, 0, 0, 0})
		'
		'btnSearchSettingsBracketPrimer
		'
		Me.btnSearchSettingsBracketPrimer.BackColor = System.Drawing.Color.Transparent
		Me.btnSearchSettingsBracketPrimer.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnSearchSettingsBracketPrimer.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.btnSearchSettingsBracketPrimer.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnSearchSettingsBracketPrimer.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnSearchSettingsBracketPrimer.Location = New System.Drawing.Point(5, 118)
		Me.btnSearchSettingsBracketPrimer.Name = "btnSearchSettingsBracketPrimer"
		Me.btnSearchSettingsBracketPrimer.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnSearchSettingsBracketPrimer.Size = New System.Drawing.Size(114, 22)
		Me.btnSearchSettingsBracketPrimer.TabIndex = 62
		Me.btnSearchSettingsBracketPrimer.Text = "Search Settings"
		Me.ToolTip1.SetToolTip(Me.btnSearchSettingsBracketPrimer, "Search Settings - Advanced settings for the search process can by modified here. " &
				" Should not be modified unless completely necessary")
		Me.btnSearchSettingsBracketPrimer.UseVisualStyleBackColor = False
		'
		'btnTrainNewBracketPrimer
		'
		Me.btnTrainNewBracketPrimer.BackColor = System.Drawing.Color.Transparent
		Me.btnTrainNewBracketPrimer.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnTrainNewBracketPrimer.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.btnTrainNewBracketPrimer.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnTrainNewBracketPrimer.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnTrainNewBracketPrimer.Location = New System.Drawing.Point(5, 97)
		Me.btnTrainNewBracketPrimer.Name = "btnTrainNewBracketPrimer"
		Me.btnTrainNewBracketPrimer.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnTrainNewBracketPrimer.Size = New System.Drawing.Size(114, 22)
		Me.btnTrainNewBracketPrimer.TabIndex = 59
		Me.btnTrainNewBracketPrimer.TabStop = False
		Me.btnTrainNewBracketPrimer.Text = "Train New"
		Me.ToolTip1.SetToolTip(Me.btnTrainNewBracketPrimer, "Train New - Discards the old model and takes a picture to teach a new one.  This " &
				"is used to locate the glass on the incoming position and determine its pick up p" &
				"oint.")
		Me.btnTrainNewBracketPrimer.UseVisualStyleBackColor = False
		'
		'btnTrainExistingBracketPrimer
		'
		Me.btnTrainExistingBracketPrimer.BackColor = System.Drawing.Color.Transparent
		Me.btnTrainExistingBracketPrimer.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnTrainExistingBracketPrimer.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.btnTrainExistingBracketPrimer.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnTrainExistingBracketPrimer.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnTrainExistingBracketPrimer.Location = New System.Drawing.Point(5, 76)
		Me.btnTrainExistingBracketPrimer.Name = "btnTrainExistingBracketPrimer"
		Me.btnTrainExistingBracketPrimer.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnTrainExistingBracketPrimer.Size = New System.Drawing.Size(114, 22)
		Me.btnTrainExistingBracketPrimer.TabIndex = 58
		Me.btnTrainExistingBracketPrimer.TabStop = False
		Me.btnTrainExistingBracketPrimer.Text = "Train Existing"
		Me.ToolTip1.SetToolTip(Me.btnTrainExistingBracketPrimer, "Train Existing - Edits the existing model in the database.  Changes can be made t" &
				"o the current model without discarding any previous data.")
		Me.btnTrainExistingBracketPrimer.UseVisualStyleBackColor = False
		'
		'updnLocationZ
		'
		Me.updnLocationZ.Location = New System.Drawing.Point(384, 72)
		Me.updnLocationZ.Maximum = New Decimal(New Integer() {25, 0, 0, 0})
		Me.updnLocationZ.Minimum = New Decimal(New Integer() {25, 0, 0, -2147483648})
		Me.updnLocationZ.Name = "updnLocationZ"
		Me.updnLocationZ.Size = New System.Drawing.Size(64, 20)
		Me.updnLocationZ.TabIndex = 230
		Me.updnLocationZ.Tag = "dont save"
		Me.updnLocationZ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.ToolTip1.SetToolTip(Me.updnLocationZ, "Each click moves glass 0.1mm " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "to the ' Upstream' side " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "of the line. Press the [" &
				"OK] button" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "to accept movement changes." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Range : +/- 50mm")
		Me.updnLocationZ.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
		'
		'btnDepositAdjRPlus
		'
		Me.btnDepositAdjRPlus.BackColor = System.Drawing.Color.PaleGoldenrod
		Me.btnDepositAdjRPlus.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnDepositAdjRPlus.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnDepositAdjRPlus.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnDepositAdjRPlus.Image = CType(resources.GetObject("btnDepositAdjRPlus.Image"), System.Drawing.Image)
		Me.btnDepositAdjRPlus.Location = New System.Drawing.Point(8, 42)
		Me.btnDepositAdjRPlus.Name = "btnDepositAdjRPlus"
		Me.btnDepositAdjRPlus.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnDepositAdjRPlus.Size = New System.Drawing.Size(36, 40)
		Me.btnDepositAdjRPlus.TabIndex = 184
		Me.btnDepositAdjRPlus.TabStop = False
		Me.btnDepositAdjRPlus.Tag = "-0.01"
		Me.ToolTip1.SetToolTip(Me.btnDepositAdjRPlus, "Each click moves glass 0.01 degree" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "of Counter Clockwise rotation." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " Press the " &
				"[OK] button" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "to accept movement changes.")
		Me.btnDepositAdjRPlus.UseVisualStyleBackColor = False
		'
		'btnDepositAdjRMinus
		'
		Me.btnDepositAdjRMinus.BackColor = System.Drawing.Color.PaleGoldenrod
		Me.btnDepositAdjRMinus.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnDepositAdjRMinus.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnDepositAdjRMinus.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnDepositAdjRMinus.Image = CType(resources.GetObject("btnDepositAdjRMinus.Image"), System.Drawing.Image)
		Me.btnDepositAdjRMinus.Location = New System.Drawing.Point(44, 42)
		Me.btnDepositAdjRMinus.Name = "btnDepositAdjRMinus"
		Me.btnDepositAdjRMinus.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnDepositAdjRMinus.Size = New System.Drawing.Size(33, 40)
		Me.btnDepositAdjRMinus.TabIndex = 179
		Me.btnDepositAdjRMinus.TabStop = False
		Me.btnDepositAdjRMinus.Tag = "0.01"
		Me.ToolTip1.SetToolTip(Me.btnDepositAdjRMinus, "Each click moves glass 0.01 degree" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "of Clockwise rotation." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " Press the [OK] but" &
				"ton" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "to accept movement changes.")
		Me.btnDepositAdjRMinus.UseVisualStyleBackColor = False
		'
		'btnDepositAdjYPlus
		'
		Me.btnDepositAdjYPlus.BackColor = System.Drawing.Color.PaleGoldenrod
		Me.btnDepositAdjYPlus.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnDepositAdjYPlus.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnDepositAdjYPlus.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnDepositAdjYPlus.Image = CType(resources.GetObject("btnDepositAdjYPlus.Image"), System.Drawing.Image)
		Me.btnDepositAdjYPlus.Location = New System.Drawing.Point(161, 27)
		Me.btnDepositAdjYPlus.Name = "btnDepositAdjYPlus"
		Me.btnDepositAdjYPlus.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnDepositAdjYPlus.Size = New System.Drawing.Size(42, 41)
		Me.btnDepositAdjYPlus.TabIndex = 219
		Me.btnDepositAdjYPlus.TabStop = False
		Me.btnDepositAdjYPlus.Tag = "-0.1"
		Me.ToolTip1.SetToolTip(Me.btnDepositAdjYPlus, "Each click moves glass 0.1mm " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "to the ' Near Operator' side " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "of the line. Press " &
				"the [OK] button" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "to accept movement changes.")
		Me.btnDepositAdjYPlus.UseVisualStyleBackColor = False
		'
		'btnDepositAdjYMinus
		'
		Me.btnDepositAdjYMinus.BackColor = System.Drawing.Color.PaleGoldenrod
		Me.btnDepositAdjYMinus.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnDepositAdjYMinus.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnDepositAdjYMinus.ForeColor = System.Drawing.Color.Magenta
		Me.btnDepositAdjYMinus.Image = CType(resources.GetObject("btnDepositAdjYMinus.Image"), System.Drawing.Image)
		Me.btnDepositAdjYMinus.Location = New System.Drawing.Point(161, 73)
		Me.btnDepositAdjYMinus.Name = "btnDepositAdjYMinus"
		Me.btnDepositAdjYMinus.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnDepositAdjYMinus.Size = New System.Drawing.Size(42, 41)
		Me.btnDepositAdjYMinus.TabIndex = 222
		Me.btnDepositAdjYMinus.TabStop = False
		Me.btnDepositAdjYMinus.Tag = ".1"
		Me.ToolTip1.SetToolTip(Me.btnDepositAdjYMinus, "Each click moves glass 0.1mm " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "to the 'Away from Operator' side " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "of the line. Pr" &
				"ess the [OK] button" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "to accept movement changes.")
		Me.btnDepositAdjYMinus.UseVisualStyleBackColor = False
		'
		'btnDepositAdjXPlus
		'
		Me.btnDepositAdjXPlus.BackColor = System.Drawing.Color.PaleGoldenrod
		Me.btnDepositAdjXPlus.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnDepositAdjXPlus.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnDepositAdjXPlus.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnDepositAdjXPlus.Image = CType(resources.GetObject("btnDepositAdjXPlus.Image"), System.Drawing.Image)
		Me.btnDepositAdjXPlus.Location = New System.Drawing.Point(204, 49)
		Me.btnDepositAdjXPlus.Name = "btnDepositAdjXPlus"
		Me.btnDepositAdjXPlus.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnDepositAdjXPlus.Size = New System.Drawing.Size(44, 37)
		Me.btnDepositAdjXPlus.TabIndex = 221
		Me.btnDepositAdjXPlus.TabStop = False
		Me.btnDepositAdjXPlus.Tag = "0.1"
		Me.ToolTip1.SetToolTip(Me.btnDepositAdjXPlus, "Each click moves glass 0.1mm " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "to the ' Upstream' side " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "of the line. Press the [" &
				"OK] button" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "to accept movement changes.")
		Me.btnDepositAdjXPlus.UseVisualStyleBackColor = False
		'
		'btnDepositAdjXMinus
		'
		Me.btnDepositAdjXMinus.BackColor = System.Drawing.Color.PaleGoldenrod
		Me.btnDepositAdjXMinus.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnDepositAdjXMinus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
		Me.btnDepositAdjXMinus.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnDepositAdjXMinus.Image = CType(resources.GetObject("btnDepositAdjXMinus.Image"), System.Drawing.Image)
		Me.btnDepositAdjXMinus.Location = New System.Drawing.Point(117, 47)
		Me.btnDepositAdjXMinus.Name = "btnDepositAdjXMinus"
		Me.btnDepositAdjXMinus.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnDepositAdjXMinus.Size = New System.Drawing.Size(42, 37)
		Me.btnDepositAdjXMinus.TabIndex = 220
		Me.btnDepositAdjXMinus.TabStop = False
		Me.btnDepositAdjXMinus.Tag = "-0.1"
		Me.ToolTip1.SetToolTip(Me.btnDepositAdjXMinus, "Each click moves glass 0.1mm " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "to the ' Downstream' side " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "of the line. Press the" &
				" [OK] button" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "to accept movement changes.")
		Me.btnDepositAdjXMinus.UseVisualStyleBackColor = False
		'
		'btnSaveBracketPrimer1
		'
		Me.btnSaveBracketPrimer1.BackColor = System.Drawing.Color.Transparent
		Me.btnSaveBracketPrimer1.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnSaveBracketPrimer1.Enabled = False
		Me.btnSaveBracketPrimer1.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.btnSaveBracketPrimer1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnSaveBracketPrimer1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnSaveBracketPrimer1.Location = New System.Drawing.Point(330, 14)
		Me.btnSaveBracketPrimer1.Name = "btnSaveBracketPrimer1"
		Me.btnSaveBracketPrimer1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnSaveBracketPrimer1.Size = New System.Drawing.Size(43, 22)
		Me.btnSaveBracketPrimer1.TabIndex = 174
		Me.btnSaveBracketPrimer1.TabStop = False
		Me.btnSaveBracketPrimer1.Text = "Save"
		Me.ToolTip1.SetToolTip(Me.btnSaveBracketPrimer1, "Train Existing - Edits the existing model in the database.  Changes can be made t" &
				"o the current model without discarding any previous data.")
		Me.btnSaveBracketPrimer1.UseVisualStyleBackColor = False
		'
		'btnTrainBracketPrimer1
		'
		Me.btnTrainBracketPrimer1.BackColor = System.Drawing.Color.Transparent
		Me.btnTrainBracketPrimer1.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnTrainBracketPrimer1.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.btnTrainBracketPrimer1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnTrainBracketPrimer1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnTrainBracketPrimer1.Location = New System.Drawing.Point(200, 14)
		Me.btnTrainBracketPrimer1.Name = "btnTrainBracketPrimer1"
		Me.btnTrainBracketPrimer1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnTrainBracketPrimer1.Size = New System.Drawing.Size(124, 22)
		Me.btnTrainBracketPrimer1.TabIndex = 173
		Me.btnTrainBracketPrimer1.TabStop = False
		Me.btnTrainBracketPrimer1.Text = "Train Bottom Left"
		Me.ToolTip1.SetToolTip(Me.btnTrainBracketPrimer1, "Train Existing - Edits the existing model in the database.  Changes can be made t" &
				"o the current model without discarding any previous data.")
		Me.btnTrainBracketPrimer1.UseVisualStyleBackColor = False
		'
		'btnSaveBracketPrimer2
		'
		Me.btnSaveBracketPrimer2.BackColor = System.Drawing.Color.Transparent
		Me.btnSaveBracketPrimer2.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnSaveBracketPrimer2.Enabled = False
		Me.btnSaveBracketPrimer2.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.btnSaveBracketPrimer2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnSaveBracketPrimer2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnSaveBracketPrimer2.Location = New System.Drawing.Point(330, 42)
		Me.btnSaveBracketPrimer2.Name = "btnSaveBracketPrimer2"
		Me.btnSaveBracketPrimer2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnSaveBracketPrimer2.Size = New System.Drawing.Size(43, 22)
		Me.btnSaveBracketPrimer2.TabIndex = 176
		Me.btnSaveBracketPrimer2.TabStop = False
		Me.btnSaveBracketPrimer2.Text = "Save"
		Me.ToolTip1.SetToolTip(Me.btnSaveBracketPrimer2, "Train Existing - Edits the existing model in the database.  Changes can be made t" &
				"o the current model without discarding any previous data.")
		Me.btnSaveBracketPrimer2.UseVisualStyleBackColor = False
		'
		'btnTrainBracketPrimer2
		'
		Me.btnTrainBracketPrimer2.BackColor = System.Drawing.Color.Transparent
		Me.btnTrainBracketPrimer2.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnTrainBracketPrimer2.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.btnTrainBracketPrimer2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnTrainBracketPrimer2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnTrainBracketPrimer2.Location = New System.Drawing.Point(200, 43)
		Me.btnTrainBracketPrimer2.Name = "btnTrainBracketPrimer2"
		Me.btnTrainBracketPrimer2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnTrainBracketPrimer2.Size = New System.Drawing.Size(124, 22)
		Me.btnTrainBracketPrimer2.TabIndex = 175
		Me.btnTrainBracketPrimer2.TabStop = False
		Me.btnTrainBracketPrimer2.Text = "Train Bottom Right"
		Me.ToolTip1.SetToolTip(Me.btnTrainBracketPrimer2, "Train Existing - Edits the existing model in the database.  Changes can be made t" &
				"o the current model without discarding any previous data.")
		Me.btnTrainBracketPrimer2.UseVisualStyleBackColor = False
		'
		'btnSaveBracketPrimer3
		'
		Me.btnSaveBracketPrimer3.BackColor = System.Drawing.Color.Transparent
		Me.btnSaveBracketPrimer3.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnSaveBracketPrimer3.Enabled = False
		Me.btnSaveBracketPrimer3.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.btnSaveBracketPrimer3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnSaveBracketPrimer3.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnSaveBracketPrimer3.Location = New System.Drawing.Point(330, 72)
		Me.btnSaveBracketPrimer3.Name = "btnSaveBracketPrimer3"
		Me.btnSaveBracketPrimer3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnSaveBracketPrimer3.Size = New System.Drawing.Size(43, 22)
		Me.btnSaveBracketPrimer3.TabIndex = 178
		Me.btnSaveBracketPrimer3.TabStop = False
		Me.btnSaveBracketPrimer3.Text = "Save"
		Me.ToolTip1.SetToolTip(Me.btnSaveBracketPrimer3, "Train Existing - Edits the existing model in the database.  Changes can be made t" &
				"o the current model without discarding any previous data.")
		Me.btnSaveBracketPrimer3.UseVisualStyleBackColor = False
		'
		'btnTrainBracketPrimer3
		'
		Me.btnTrainBracketPrimer3.BackColor = System.Drawing.Color.Transparent
		Me.btnTrainBracketPrimer3.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnTrainBracketPrimer3.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.btnTrainBracketPrimer3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnTrainBracketPrimer3.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnTrainBracketPrimer3.Location = New System.Drawing.Point(200, 72)
		Me.btnTrainBracketPrimer3.Name = "btnTrainBracketPrimer3"
		Me.btnTrainBracketPrimer3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnTrainBracketPrimer3.Size = New System.Drawing.Size(124, 22)
		Me.btnTrainBracketPrimer3.TabIndex = 177
		Me.btnTrainBracketPrimer3.TabStop = False
		Me.btnTrainBracketPrimer3.Text = "Train Top Left"
		Me.ToolTip1.SetToolTip(Me.btnTrainBracketPrimer3, "Train Existing - Edits the existing model in the database.  Changes can be made t" &
				"o the current model without discarding any previous data.")
		Me.btnTrainBracketPrimer3.UseVisualStyleBackColor = False
		'
		'btnSaveBracketPrimer4
		'
		Me.btnSaveBracketPrimer4.BackColor = System.Drawing.Color.Transparent
		Me.btnSaveBracketPrimer4.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnSaveBracketPrimer4.Enabled = False
		Me.btnSaveBracketPrimer4.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.btnSaveBracketPrimer4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnSaveBracketPrimer4.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnSaveBracketPrimer4.Location = New System.Drawing.Point(330, 101)
		Me.btnSaveBracketPrimer4.Name = "btnSaveBracketPrimer4"
		Me.btnSaveBracketPrimer4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnSaveBracketPrimer4.Size = New System.Drawing.Size(43, 22)
		Me.btnSaveBracketPrimer4.TabIndex = 180
		Me.btnSaveBracketPrimer4.TabStop = False
		Me.btnSaveBracketPrimer4.Text = "Save"
		Me.ToolTip1.SetToolTip(Me.btnSaveBracketPrimer4, "Train Existing - Edits the existing model in the database.  Changes can be made t" &
				"o the current model without discarding any previous data.")
		Me.btnSaveBracketPrimer4.UseVisualStyleBackColor = False
		'
		'btnTrainBracketPrimer4
		'
		Me.btnTrainBracketPrimer4.BackColor = System.Drawing.Color.Transparent
		Me.btnTrainBracketPrimer4.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnTrainBracketPrimer4.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.btnTrainBracketPrimer4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnTrainBracketPrimer4.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnTrainBracketPrimer4.Location = New System.Drawing.Point(200, 101)
		Me.btnTrainBracketPrimer4.Name = "btnTrainBracketPrimer4"
		Me.btnTrainBracketPrimer4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnTrainBracketPrimer4.Size = New System.Drawing.Size(124, 22)
		Me.btnTrainBracketPrimer4.TabIndex = 179
		Me.btnTrainBracketPrimer4.TabStop = False
		Me.btnTrainBracketPrimer4.Text = "Train Top Right"
		Me.ToolTip1.SetToolTip(Me.btnTrainBracketPrimer4, "Train Existing - Edits the existing model in the database.  Changes can be made t" &
				"o the current model without discarding any previous data.")
		Me.btnTrainBracketPrimer4.UseVisualStyleBackColor = False
		'
		'btnSaveBracketPrimer5
		'
		Me.btnSaveBracketPrimer5.BackColor = System.Drawing.Color.Transparent
		Me.btnSaveBracketPrimer5.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnSaveBracketPrimer5.Enabled = False
		Me.btnSaveBracketPrimer5.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.btnSaveBracketPrimer5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnSaveBracketPrimer5.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnSaveBracketPrimer5.Location = New System.Drawing.Point(330, 130)
		Me.btnSaveBracketPrimer5.Name = "btnSaveBracketPrimer5"
		Me.btnSaveBracketPrimer5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnSaveBracketPrimer5.Size = New System.Drawing.Size(43, 22)
		Me.btnSaveBracketPrimer5.TabIndex = 182
		Me.btnSaveBracketPrimer5.TabStop = False
		Me.btnSaveBracketPrimer5.Text = "Save"
		Me.ToolTip1.SetToolTip(Me.btnSaveBracketPrimer5, "Train Existing - Edits the existing model in the database.  Changes can be made t" &
				"o the current model without discarding any previous data.")
		Me.btnSaveBracketPrimer5.UseVisualStyleBackColor = False
		'
		'btnTrainBracketPrimer5
		'
		Me.btnTrainBracketPrimer5.BackColor = System.Drawing.Color.Transparent
		Me.btnTrainBracketPrimer5.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnTrainBracketPrimer5.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.btnTrainBracketPrimer5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnTrainBracketPrimer5.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnTrainBracketPrimer5.Location = New System.Drawing.Point(200, 130)
		Me.btnTrainBracketPrimer5.Name = "btnTrainBracketPrimer5"
		Me.btnTrainBracketPrimer5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnTrainBracketPrimer5.Size = New System.Drawing.Size(124, 22)
		Me.btnTrainBracketPrimer5.TabIndex = 181
		Me.btnTrainBracketPrimer5.TabStop = False
		Me.btnTrainBracketPrimer5.Text = "Train Center Dot"
		Me.ToolTip1.SetToolTip(Me.btnTrainBracketPrimer5, "Train Existing - Edits the existing model in the database.  Changes can be made t" &
				"o the current model without discarding any previous data.")
		Me.btnTrainBracketPrimer5.UseVisualStyleBackColor = False
		'
		'btnSaveBracketPrimerReference
		'
		Me.btnSaveBracketPrimerReference.BackColor = System.Drawing.Color.Transparent
		Me.btnSaveBracketPrimerReference.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnSaveBracketPrimerReference.Enabled = False
		Me.btnSaveBracketPrimerReference.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.btnSaveBracketPrimerReference.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnSaveBracketPrimerReference.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnSaveBracketPrimerReference.Location = New System.Drawing.Point(31, 90)
		Me.btnSaveBracketPrimerReference.Name = "btnSaveBracketPrimerReference"
		Me.btnSaveBracketPrimerReference.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnSaveBracketPrimerReference.Size = New System.Drawing.Size(125, 22)
		Me.btnSaveBracketPrimerReference.TabIndex = 184
		Me.btnSaveBracketPrimerReference.TabStop = False
		Me.btnSaveBracketPrimerReference.Text = "Save Primer Reference"
		Me.ToolTip1.SetToolTip(Me.btnSaveBracketPrimerReference, "Train Existing - Edits the existing model in the database.  Changes can be made t" &
				"o the current model without discarding any previous data.")
		Me.btnSaveBracketPrimerReference.UseVisualStyleBackColor = False
		'
		'btnTrainBracketPrimerReference
		'
		Me.btnTrainBracketPrimerReference.BackColor = System.Drawing.Color.Transparent
		Me.btnTrainBracketPrimerReference.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnTrainBracketPrimerReference.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.btnTrainBracketPrimerReference.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnTrainBracketPrimerReference.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnTrainBracketPrimerReference.Location = New System.Drawing.Point(31, 39)
		Me.btnTrainBracketPrimerReference.Name = "btnTrainBracketPrimerReference"
		Me.btnTrainBracketPrimerReference.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnTrainBracketPrimerReference.Size = New System.Drawing.Size(125, 22)
		Me.btnTrainBracketPrimerReference.TabIndex = 183
		Me.btnTrainBracketPrimerReference.TabStop = False
		Me.btnTrainBracketPrimerReference.Text = "Train Primer Reference"
		Me.ToolTip1.SetToolTip(Me.btnTrainBracketPrimerReference, "Train Existing - Edits the existing model in the database.  Changes can be made t" &
				"o the current model without discarding any previous data.")
		Me.btnTrainBracketPrimerReference.UseVisualStyleBackColor = False
		'
		'updnScoreLimitTapeBracketLocator
		'
		Me.updnScoreLimitTapeBracketLocator.Location = New System.Drawing.Point(45, 54)
		Me.updnScoreLimitTapeBracketLocator.Minimum = New Decimal(New Integer() {20, 0, 0, 0})
		Me.updnScoreLimitTapeBracketLocator.Name = "updnScoreLimitTapeBracketLocator"
		Me.updnScoreLimitTapeBracketLocator.Size = New System.Drawing.Size(50, 20)
		Me.updnScoreLimitTapeBracketLocator.TabIndex = 172
		Me.ToolTip1.SetToolTip(Me.updnScoreLimitTapeBracketLocator, "The minimum score required to pick up the glass")
		Me.updnScoreLimitTapeBracketLocator.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
		Me.updnScoreLimitTapeBracketLocator.Value = New Decimal(New Integer() {95, 0, 0, 0})
		'
		'TmrPassword
		'
		Me.TmrPassword.Interval = 600000
		'
		'tmrDisplayUpdate
		'
		Me.tmrDisplayUpdate.Interval = 2000
		'
		'ErrorProvider1
		'
		Me.ErrorProvider1.ContainerControl = Me
		'
		'tabVisionRobot
		'
		Me.tabVisionRobot.Controls.Add(Me.tabPageRobot)
		Me.tabVisionRobot.Location = New System.Drawing.Point(0, 27)
		Me.tabVisionRobot.Name = "tabVisionRobot"
		Me.tabVisionRobot.SelectedIndex = 0
		Me.tabVisionRobot.Size = New System.Drawing.Size(1920, 1080)
		Me.tabVisionRobot.TabIndex = 165
		'
		'tabPageRobot
		'
		Me.tabPageRobot.BackColor = System.Drawing.Color.PaleGoldenrod
		Me.tabPageRobot.Controls.Add(Me.GrpRobot)
		Me.tabPageRobot.Location = New System.Drawing.Point(4, 25)
		Me.tabPageRobot.Name = "tabPageRobot"
		Me.tabPageRobot.Padding = New System.Windows.Forms.Padding(3)
		Me.tabPageRobot.Size = New System.Drawing.Size(1912, 1051)
		Me.tabPageRobot.TabIndex = 0
		'
		'GrpRobot
		'
		Me.GrpRobot.BackColor = System.Drawing.Color.PaleGoldenrod
		Me.GrpRobot.Controls.Add(Me.Label24)
		Me.GrpRobot.Controls.Add(Me.Label23)
		Me.GrpRobot.Controls.Add(Me.Label22)
		Me.GrpRobot.Controls.Add(Me.Label21)
		Me.GrpRobot.Controls.Add(Me.Label20)
		Me.GrpRobot.Controls.Add(Me.Label19)
		Me.GrpRobot.Controls.Add(Me.Label18)
		Me.GrpRobot.Controls.Add(Me.Label17)
		Me.GrpRobot.Controls.Add(Me.Label16)
		Me.GrpRobot.Controls.Add(Me.Button2)
		Me.GrpRobot.Controls.Add(Me.lblStatus)
		Me.GrpRobot.Controls.Add(Me.lblHeartBeat)
		Me.GrpRobot.Controls.Add(Me.lblmessagedesc)
		Me.GrpRobot.Controls.Add(Me.grpResults)
		Me.GrpRobot.Controls.Add(Me.lblPhone)
		Me.GrpRobot.Controls.Add(Me.picLogo)
		Me.GrpRobot.Controls.Add(Me.TabControlsMain)
		Me.GrpRobot.Controls.Add(Me.grpVBErrors)
		Me.GrpRobot.Location = New System.Drawing.Point(3, 6)
		Me.GrpRobot.Name = "GrpRobot"
		Me.GrpRobot.Size = New System.Drawing.Size(1920, 1080)
		Me.GrpRobot.TabIndex = 165
		Me.GrpRobot.TabStop = False
		'
		'Label24
		'
		Me.Label24.AutoSize = True
		Me.Label24.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label24.Location = New System.Drawing.Point(1601, -3)
		Me.Label24.Name = "Label24"
		Me.Label24.Size = New System.Drawing.Size(46, 14)
		Me.Label24.TabIndex = 270
		Me.Label24.Text = "Gocator"
		Me.Label24.Visible = False
		'
		'Label23
		'
		Me.Label23.AutoSize = True
		Me.Label23.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label23.Location = New System.Drawing.Point(1436, -2)
		Me.Label23.Name = "Label23"
		Me.Label23.Size = New System.Drawing.Size(124, 14)
		Me.Label23.TabIndex = 269
		Me.Label23.Text = "Arron Mighty Passenger"
		Me.Label23.Visible = False
		'
		'Label22
		'
		Me.Label22.AutoSize = True
		Me.Label22.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label22.Location = New System.Drawing.Point(1302, -2)
		Me.Label22.Name = "Label22"
		Me.Label22.Size = New System.Drawing.Size(104, 14)
		Me.Label22.TabIndex = 268
		Me.Label22.Text = "Arron Mighty Center"
		Me.Label22.Visible = False
		'
		'Label21
		'
		Me.Label21.AutoSize = True
		Me.Label21.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label21.Location = New System.Drawing.Point(1168, -2)
		Me.Label21.Name = "Label21"
		Me.Label21.Size = New System.Drawing.Size(101, 14)
		Me.Label21.TabIndex = 267
		Me.Label21.Text = "Arron Mighty Driver"
		Me.Label21.Visible = False
		'
		'Label20
		'
		Me.Label20.AutoSize = True
		Me.Label20.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label20.Location = New System.Drawing.Point(994, -3)
		Me.Label20.Name = "Label20"
		Me.Label20.Size = New System.Drawing.Size(144, 14)
		Me.Label20.TabIndex = 266
		Me.Label20.Text = "Locate Bracket on the Glass"
		Me.Label20.Visible = False
		'
		'Label19
		'
		Me.Label19.AutoSize = True
		Me.Label19.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label19.Location = New System.Drawing.Point(894, -2)
		Me.Label19.Name = "Label19"
		Me.Label19.Size = New System.Drawing.Size(71, 14)
		Me.Label19.TabIndex = 265
		Me.Label19.Text = "Locate Glass"
		Me.Label19.Visible = False
		'
		'Label18
		'
		Me.Label18.AutoSize = True
		Me.Label18.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label18.Location = New System.Drawing.Point(705, -3)
		Me.Label18.Name = "Label18"
		Me.Label18.Size = New System.Drawing.Size(167, 14)
		Me.Label18.TabIndex = 264
		Me.Label18.Text = "Locate Brackets on the Turntable"
		Me.Label18.Visible = False
		'
		'Label17
		'
		Me.Label17.AutoSize = True
		Me.Label17.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label17.Location = New System.Drawing.Point(557, -2)
		Me.Label17.Name = "Label17"
		Me.Label17.Size = New System.Drawing.Size(109, 14)
		Me.Label17.TabIndex = 263
		Me.Label17.Text = "Bracket Verify Primer"
		Me.Label17.Visible = False
		'
		'Label16
		'
		Me.Label16.AutoSize = True
		Me.Label16.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label16.Location = New System.Drawing.Point(384, -2)
		Me.Label16.Name = "Label16"
		Me.Label16.Size = New System.Drawing.Size(106, 14)
		Me.Label16.TabIndex = 262
		Me.Label16.Text = "Bracket Locate Tape"
		Me.Label16.Visible = False
		'
		'Button2
		'
		Me.Button2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button2.Location = New System.Drawing.Point(10, 133)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(66, 35)
		Me.Button2.TabIndex = 243
		Me.Button2.Text = "Run"
		Me.Button2.UseVisualStyleBackColor = True
		Me.Button2.Visible = False
		'
		'lblStatus
		'
		Me.lblStatus.AutoSize = True
		Me.lblStatus.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblStatus.Location = New System.Drawing.Point(10, 172)
		Me.lblStatus.Name = "lblStatus"
		Me.lblStatus.Size = New System.Drawing.Size(62, 18)
		Me.lblStatus.TabIndex = 252
		Me.lblStatus.Text = "Status:"
		'
		'lblHeartBeat
		'
		Me.lblHeartBeat.AutoSize = True
		Me.lblHeartBeat.Location = New System.Drawing.Point(10, 200)
		Me.lblHeartBeat.Name = "lblHeartBeat"
		Me.lblHeartBeat.Size = New System.Drawing.Size(66, 16)
		Me.lblHeartBeat.TabIndex = 249
		Me.lblHeartBeat.Text = "HeartBeat"
		'
		'lblmessagedesc
		'
		Me.lblmessagedesc.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblmessagedesc.Location = New System.Drawing.Point(82, 159)
		Me.lblmessagedesc.Name = "lblmessagedesc"
		Me.lblmessagedesc.Size = New System.Drawing.Size(278, 64)
		Me.lblmessagedesc.TabIndex = 251
		Me.lblmessagedesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'grpResults
		'
		Me.grpResults.Controls.Add(Me.btnShiftCntrs)
		Me.grpResults.Controls.Add(Me.lblCenterInspection)
		Me.grpResults.Controls.Add(Me.btnMainRunGlassInspection)
		Me.grpResults.Controls.Add(Me.btnMainRunCenterInspec)
		Me.grpResults.Controls.Add(Me.lblBracketInspection)
		Me.grpResults.Controls.Add(Me.lblGocater)
		Me.grpResults.Controls.Add(Me.btnMainRunTrademark)
		Me.grpResults.Controls.Add(Me.updnGocator)
		Me.grpResults.Controls.Add(Me.lblBracketInspectionVerify)
		Me.grpResults.Controls.Add(Me.btnMainRunBracketVerify)
		Me.grpResults.Controls.Add(Me.lblTrademarkInspection)
		Me.grpResults.Controls.Add(Me.btnBacklightPrimer)
		Me.grpResults.Controls.Add(Me.lblbacklightPrimer)
		Me.grpResults.Controls.Add(Me.lblLaser)
		Me.grpResults.Controls.Add(Me.lblBracketInspectionPrimer)
		Me.grpResults.Controls.Add(Me.btnMainRunBracketInspectionPrimer)
		Me.grpResults.Controls.Add(Me.lblbacklight)
		Me.grpResults.Controls.Add(Me.btnBacklight)
		Me.grpResults.Controls.Add(Me.lblOverheadLight)
		Me.grpResults.Controls.Add(Me.btnOverheadLight)
		Me.grpResults.Controls.Add(Me.lblGlueApplication)
		Me.grpResults.Controls.Add(Me.lblBracketInspectionTape)
		Me.grpResults.Controls.Add(Me.btnMainRunPassengerInspec)
		Me.grpResults.Controls.Add(Me.lblBracketInspectionConveyor)
		Me.grpResults.Controls.Add(Me.btnMainRunDriverInspec)
		Me.grpResults.Controls.Add(Me.btnMainRunBracketInspectionTape)
		Me.grpResults.Controls.Add(Me.lblPassengerInspection)
		Me.grpResults.Controls.Add(Me.btnMainRunBracketInspectionConveyor)
		Me.grpResults.Controls.Add(Me.lblDriverInspection)
		Me.grpResults.Location = New System.Drawing.Point(5, 226)
		Me.grpResults.Name = "grpResults"
		Me.grpResults.Size = New System.Drawing.Size(356, 629)
		Me.grpResults.TabIndex = 248
		Me.grpResults.TabStop = False
		'
		'btnShiftCntrs
		'
		Me.btnShiftCntrs.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnShiftCntrs.Location = New System.Drawing.Point(138, 418)
		Me.btnShiftCntrs.Name = "btnShiftCntrs"
		Me.btnShiftCntrs.Size = New System.Drawing.Size(118, 60)
		Me.btnShiftCntrs.TabIndex = 262
		Me.btnShiftCntrs.Text = "Shift Reject Counters"
		Me.btnShiftCntrs.UseVisualStyleBackColor = True
		'
		'lblCenterInspection
		'
		Me.lblCenterInspection.BackColor = System.Drawing.SystemColors.Control
		Me.lblCenterInspection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.lblCenterInspection.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCenterInspection.Location = New System.Drawing.Point(78, 206)
		Me.lblCenterInspection.Name = "lblCenterInspection"
		Me.lblCenterInspection.Size = New System.Drawing.Size(270, 35)
		Me.lblCenterInspection.TabIndex = 235
		Me.lblCenterInspection.Text = "Inspect H Shaped Primer - Center"
		Me.lblCenterInspection.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'btnMainRunGlassInspection
		'
		Me.btnMainRunGlassInspection.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnMainRunGlassInspection.Location = New System.Drawing.Point(6, 242)
		Me.btnMainRunGlassInspection.Name = "btnMainRunGlassInspection"
		Me.btnMainRunGlassInspection.Size = New System.Drawing.Size(66, 35)
		Me.btnMainRunGlassInspection.TabIndex = 237
		Me.btnMainRunGlassInspection.Text = "Run"
		Me.btnMainRunGlassInspection.UseVisualStyleBackColor = True
		'
		'btnMainRunCenterInspec
		'
		Me.btnMainRunCenterInspec.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnMainRunCenterInspec.Location = New System.Drawing.Point(6, 204)
		Me.btnMainRunCenterInspec.Name = "btnMainRunCenterInspec"
		Me.btnMainRunCenterInspec.Size = New System.Drawing.Size(66, 35)
		Me.btnMainRunCenterInspec.TabIndex = 239
		Me.btnMainRunCenterInspec.Text = "Run"
		Me.btnMainRunCenterInspec.UseVisualStyleBackColor = True
		'
		'lblBracketInspection
		'
		Me.lblBracketInspection.BackColor = System.Drawing.SystemColors.Control
		Me.lblBracketInspection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.lblBracketInspection.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblBracketInspection.Location = New System.Drawing.Point(78, 243)
		Me.lblBracketInspection.Name = "lblBracketInspection"
		Me.lblBracketInspection.Size = New System.Drawing.Size(270, 35)
		Me.lblBracketInspection.TabIndex = 241
		Me.lblBracketInspection.Text = "Locate the Glass"
		Me.lblBracketInspection.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblGocater
		'
		Me.lblGocater.AutoSize = True
		Me.lblGocater.Location = New System.Drawing.Point(13, 497)
		Me.lblGocater.Name = "lblGocater"
		Me.lblGocater.Size = New System.Drawing.Size(54, 16)
		Me.lblGocater.TabIndex = 261
		Me.lblGocater.Text = "Gocater"
		'
		'btnMainRunTrademark
		'
		Me.btnMainRunTrademark.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnMainRunTrademark.Location = New System.Drawing.Point(6, 354)
		Me.btnMainRunTrademark.Name = "btnMainRunTrademark"
		Me.btnMainRunTrademark.Size = New System.Drawing.Size(66, 35)
		Me.btnMainRunTrademark.TabIndex = 260
		Me.btnMainRunTrademark.Text = "Run"
		Me.btnMainRunTrademark.UseVisualStyleBackColor = True
		'
		'updnGocator
		'
		Me.updnGocator.Location = New System.Drawing.Point(12, 516)
		Me.updnGocator.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
		Me.updnGocator.Minimum = New Decimal(New Integer() {35, 0, 0, -2147483648})
		Me.updnGocator.Name = "updnGocator"
		Me.updnGocator.Size = New System.Drawing.Size(59, 22)
		Me.updnGocator.TabIndex = 254
		Me.updnGocator.Visible = False
		'
		'lblBracketInspectionVerify
		'
		Me.lblBracketInspectionVerify.BackColor = System.Drawing.SystemColors.Control
		Me.lblBracketInspectionVerify.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.lblBracketInspectionVerify.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblBracketInspectionVerify.Location = New System.Drawing.Point(78, 317)
		Me.lblBracketInspectionVerify.Name = "lblBracketInspectionVerify"
		Me.lblBracketInspectionVerify.Size = New System.Drawing.Size(270, 35)
		Me.lblBracketInspectionVerify.TabIndex = 246
		Me.lblBracketInspectionVerify.Text = "Locate the Bracket on the Glass"
		Me.lblBracketInspectionVerify.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'btnMainRunBracketVerify
		'
		Me.btnMainRunBracketVerify.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnMainRunBracketVerify.Location = New System.Drawing.Point(6, 318)
		Me.btnMainRunBracketVerify.Name = "btnMainRunBracketVerify"
		Me.btnMainRunBracketVerify.Size = New System.Drawing.Size(66, 35)
		Me.btnMainRunBracketVerify.TabIndex = 247
		Me.btnMainRunBracketVerify.Text = "Run"
		Me.btnMainRunBracketVerify.UseVisualStyleBackColor = True
		'
		'lblTrademarkInspection
		'
		Me.lblTrademarkInspection.BackColor = System.Drawing.SystemColors.Control
		Me.lblTrademarkInspection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.lblTrademarkInspection.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblTrademarkInspection.Location = New System.Drawing.Point(78, 354)
		Me.lblTrademarkInspection.Name = "lblTrademarkInspection"
		Me.lblTrademarkInspection.Size = New System.Drawing.Size(270, 35)
		Me.lblTrademarkInspection.TabIndex = 259
		Me.lblTrademarkInspection.Text = "Trademark Inspection"
		Me.lblTrademarkInspection.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'btnBacklightPrimer
		'
		Me.btnBacklightPrimer.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnBacklightPrimer.Location = New System.Drawing.Point(5, 598)
		Me.btnBacklightPrimer.Name = "btnBacklightPrimer"
		Me.btnBacklightPrimer.Size = New System.Drawing.Size(66, 28)
		Me.btnBacklightPrimer.TabIndex = 258
		Me.btnBacklightPrimer.Text = "Toggle"
		Me.btnBacklightPrimer.UseVisualStyleBackColor = True
		'
		'lblbacklightPrimer
		'
		Me.lblbacklightPrimer.BackColor = System.Drawing.SystemColors.Control
		Me.lblbacklightPrimer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.lblbacklightPrimer.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblbacklightPrimer.Location = New System.Drawing.Point(77, 601)
		Me.lblbacklightPrimer.Name = "lblbacklightPrimer"
		Me.lblbacklightPrimer.Size = New System.Drawing.Size(270, 26)
		Me.lblbacklightPrimer.TabIndex = 257
		Me.lblbacklightPrimer.Text = "Primer Backlight"
		Me.lblbacklightPrimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblLaser
		'
		Me.lblLaser.BackColor = System.Drawing.SystemColors.Control
		Me.lblLaser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.lblLaser.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblLaser.Location = New System.Drawing.Point(77, 512)
		Me.lblLaser.Name = "lblLaser"
		Me.lblLaser.Size = New System.Drawing.Size(270, 26)
		Me.lblLaser.TabIndex = 256
		Me.lblLaser.Text = "Laser is Online (Status)"
		Me.lblLaser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'lblBracketInspectionPrimer
		'
		Me.lblBracketInspectionPrimer.BackColor = System.Drawing.SystemColors.Control
		Me.lblBracketInspectionPrimer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.lblBracketInspectionPrimer.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblBracketInspectionPrimer.Location = New System.Drawing.Point(77, 95)
		Me.lblBracketInspectionPrimer.Name = "lblBracketInspectionPrimer"
		Me.lblBracketInspectionPrimer.Size = New System.Drawing.Size(270, 35)
		Me.lblBracketInspectionPrimer.TabIndex = 256
		Me.lblBracketInspectionPrimer.Text = "Inspect the Primer on the Bracket"
		Me.lblBracketInspectionPrimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'btnMainRunBracketInspectionPrimer
		'
		Me.btnMainRunBracketInspectionPrimer.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnMainRunBracketInspectionPrimer.Location = New System.Drawing.Point(5, 93)
		Me.btnMainRunBracketInspectionPrimer.Name = "btnMainRunBracketInspectionPrimer"
		Me.btnMainRunBracketInspectionPrimer.Size = New System.Drawing.Size(66, 35)
		Me.btnMainRunBracketInspectionPrimer.TabIndex = 255
		Me.btnMainRunBracketInspectionPrimer.Text = "Run"
		Me.btnMainRunBracketInspectionPrimer.UseVisualStyleBackColor = True
		'
		'lblbacklight
		'
		Me.lblbacklight.BackColor = System.Drawing.SystemColors.Control
		Me.lblbacklight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.lblbacklight.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblbacklight.Location = New System.Drawing.Point(77, 573)
		Me.lblbacklight.Name = "lblbacklight"
		Me.lblbacklight.Size = New System.Drawing.Size(270, 26)
		Me.lblbacklight.TabIndex = 252
		Me.lblbacklight.Text = "Backlight Light"
		Me.lblbacklight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'btnBacklight
		'
		Me.btnBacklight.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnBacklight.Location = New System.Drawing.Point(5, 571)
		Me.btnBacklight.Name = "btnBacklight"
		Me.btnBacklight.Size = New System.Drawing.Size(66, 28)
		Me.btnBacklight.TabIndex = 251
		Me.btnBacklight.Text = "Toggle"
		Me.btnBacklight.UseVisualStyleBackColor = True
		'
		'lblOverheadLight
		'
		Me.lblOverheadLight.BackColor = System.Drawing.SystemColors.Control
		Me.lblOverheadLight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.lblOverheadLight.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblOverheadLight.Location = New System.Drawing.Point(77, 545)
		Me.lblOverheadLight.Name = "lblOverheadLight"
		Me.lblOverheadLight.Size = New System.Drawing.Size(270, 26)
		Me.lblOverheadLight.TabIndex = 250
		Me.lblOverheadLight.Text = "Overhead Light"
		Me.lblOverheadLight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'btnOverheadLight
		'
		Me.btnOverheadLight.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnOverheadLight.Location = New System.Drawing.Point(5, 544)
		Me.btnOverheadLight.Name = "btnOverheadLight"
		Me.btnOverheadLight.Size = New System.Drawing.Size(66, 28)
		Me.btnOverheadLight.TabIndex = 249
		Me.btnOverheadLight.Text = "Toggle"
		Me.btnOverheadLight.UseVisualStyleBackColor = True
		'
		'lblGlueApplication
		'
		Me.lblGlueApplication.BackColor = System.Drawing.SystemColors.Control
		Me.lblGlueApplication.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.lblGlueApplication.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblGlueApplication.Location = New System.Drawing.Point(78, 280)
		Me.lblGlueApplication.Name = "lblGlueApplication"
		Me.lblGlueApplication.Size = New System.Drawing.Size(270, 35)
		Me.lblGlueApplication.TabIndex = 248
		Me.lblGlueApplication.Text = "Gocator Laser Result"
		Me.lblGlueApplication.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblBracketInspectionTape
		'
		Me.lblBracketInspectionTape.BackColor = System.Drawing.SystemColors.Control
		Me.lblBracketInspectionTape.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.lblBracketInspectionTape.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblBracketInspectionTape.Location = New System.Drawing.Point(77, 58)
		Me.lblBracketInspectionTape.Name = "lblBracketInspectionTape"
		Me.lblBracketInspectionTape.Size = New System.Drawing.Size(270, 35)
		Me.lblBracketInspectionTape.TabIndex = 245
		Me.lblBracketInspectionTape.Text = "Inspect the Tape on the Bracket"
		Me.lblBracketInspectionTape.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'btnMainRunPassengerInspec
		'
		Me.btnMainRunPassengerInspec.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnMainRunPassengerInspec.Location = New System.Drawing.Point(6, 168)
		Me.btnMainRunPassengerInspec.Name = "btnMainRunPassengerInspec"
		Me.btnMainRunPassengerInspec.Size = New System.Drawing.Size(66, 35)
		Me.btnMainRunPassengerInspec.TabIndex = 240
		Me.btnMainRunPassengerInspec.Text = "Run"
		Me.btnMainRunPassengerInspec.UseVisualStyleBackColor = True
		'
		'lblBracketInspectionConveyor
		'
		Me.lblBracketInspectionConveyor.BackColor = System.Drawing.SystemColors.Control
		Me.lblBracketInspectionConveyor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.lblBracketInspectionConveyor.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblBracketInspectionConveyor.Location = New System.Drawing.Point(77, 21)
		Me.lblBracketInspectionConveyor.Name = "lblBracketInspectionConveyor"
		Me.lblBracketInspectionConveyor.Size = New System.Drawing.Size(270, 35)
		Me.lblBracketInspectionConveyor.TabIndex = 244
		Me.lblBracketInspectionConveyor.Text = "Locate Bracket On Small Conv."
		Me.lblBracketInspectionConveyor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'btnMainRunDriverInspec
		'
		Me.btnMainRunDriverInspec.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnMainRunDriverInspec.Location = New System.Drawing.Point(5, 131)
		Me.btnMainRunDriverInspec.Name = "btnMainRunDriverInspec"
		Me.btnMainRunDriverInspec.Size = New System.Drawing.Size(66, 35)
		Me.btnMainRunDriverInspec.TabIndex = 238
		Me.btnMainRunDriverInspec.Text = "Run"
		Me.btnMainRunDriverInspec.UseVisualStyleBackColor = True
		'
		'btnMainRunBracketInspectionTape
		'
		Me.btnMainRunBracketInspectionTape.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnMainRunBracketInspectionTape.Location = New System.Drawing.Point(5, 57)
		Me.btnMainRunBracketInspectionTape.Name = "btnMainRunBracketInspectionTape"
		Me.btnMainRunBracketInspectionTape.Size = New System.Drawing.Size(66, 35)
		Me.btnMainRunBracketInspectionTape.TabIndex = 243
		Me.btnMainRunBracketInspectionTape.Text = "Run"
		Me.btnMainRunBracketInspectionTape.UseVisualStyleBackColor = True
		'
		'lblPassengerInspection
		'
		Me.lblPassengerInspection.BackColor = System.Drawing.SystemColors.Control
		Me.lblPassengerInspection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.lblPassengerInspection.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPassengerInspection.Location = New System.Drawing.Point(78, 169)
		Me.lblPassengerInspection.Name = "lblPassengerInspection"
		Me.lblPassengerInspection.Size = New System.Drawing.Size(270, 35)
		Me.lblPassengerInspection.TabIndex = 236
		Me.lblPassengerInspection.Text = "Inspect Aron Mighty - Passenger"
		Me.lblPassengerInspection.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'btnMainRunBracketInspectionConveyor
		'
		Me.btnMainRunBracketInspectionConveyor.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnMainRunBracketInspectionConveyor.Location = New System.Drawing.Point(5, 20)
		Me.btnMainRunBracketInspectionConveyor.Name = "btnMainRunBracketInspectionConveyor"
		Me.btnMainRunBracketInspectionConveyor.Size = New System.Drawing.Size(66, 35)
		Me.btnMainRunBracketInspectionConveyor.TabIndex = 242
		Me.btnMainRunBracketInspectionConveyor.Text = "Run"
		Me.btnMainRunBracketInspectionConveyor.UseVisualStyleBackColor = True
		'
		'lblDriverInspection
		'
		Me.lblDriverInspection.BackColor = System.Drawing.SystemColors.Control
		Me.lblDriverInspection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.lblDriverInspection.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDriverInspection.Location = New System.Drawing.Point(77, 132)
		Me.lblDriverInspection.Name = "lblDriverInspection"
		Me.lblDriverInspection.Size = New System.Drawing.Size(270, 35)
		Me.lblDriverInspection.TabIndex = 234
		Me.lblDriverInspection.Text = "Inspect Aron Mighty - Driver"
		Me.lblDriverInspection.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblPhone
		'
		Me.lblPhone.AutoSize = True
		Me.lblPhone.Font = New System.Drawing.Font("Arial", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPhone.Location = New System.Drawing.Point(98, 100)
		Me.lblPhone.Name = "lblPhone"
		Me.lblPhone.Size = New System.Drawing.Size(163, 24)
		Me.lblPhone.TabIndex = 169
		Me.lblPhone.Text = "1-888-774-5306"
		'
		'picLogo
		'
		Me.picLogo.Image = CType(resources.GetObject("picLogo.Image"), System.Drawing.Image)
		Me.picLogo.Location = New System.Drawing.Point(-3, 13)
		Me.picLogo.Name = "picLogo"
		Me.picLogo.Size = New System.Drawing.Size(361, 117)
		Me.picLogo.TabIndex = 170
		Me.picLogo.TabStop = False
		'
		'TabControlsMain
		'
		Me.TabControlsMain.Controls.Add(Me.tabPageBracketLocateTape)
		Me.TabControlsMain.Controls.Add(Me.tabpageBracketPrimerVerify)
		Me.TabControlsMain.Controls.Add(Me.tabpageBracketLocateAtConveyor)
		Me.TabControlsMain.Controls.Add(Me.tabPageBracketLocate)
		Me.TabControlsMain.Controls.Add(Me.tabPageCenterBracketVerify)
		Me.TabControlsMain.Controls.Add(Me.tabPageDriverCam)
		Me.TabControlsMain.Controls.Add(Me.tabPageCenterCam)
		Me.TabControlsMain.Controls.Add(Me.tabPagePassCam)
		Me.TabControlsMain.Controls.Add(Me.tabPagePosition)
		Me.TabControlsMain.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed
		Me.TabControlsMain.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TabControlsMain.Location = New System.Drawing.Point(367, 21)
		Me.TabControlsMain.Name = "TabControlsMain"
		Me.TabControlsMain.Padding = New System.Drawing.Point(8, 4)
		Me.TabControlsMain.SelectedIndex = 0
		Me.TabControlsMain.Size = New System.Drawing.Size(1530, 958)
		Me.TabControlsMain.TabIndex = 165
		'
		'tabPageBracketLocateTape
		'
		Me.tabPageBracketLocateTape.Controls.Add(Me.grpVisionBracketLocateTape)
		Me.tabPageBracketLocateTape.Location = New System.Drawing.Point(4, 27)
		Me.tabPageBracketLocateTape.Name = "tabPageBracketLocateTape"
		Me.tabPageBracketLocateTape.Size = New System.Drawing.Size(1522, 927)
		Me.tabPageBracketLocateTape.TabIndex = 9
		Me.tabPageBracketLocateTape.Text = "Bracket - Locate Tape"
		Me.tabPageBracketLocateTape.UseVisualStyleBackColor = True
		'
		'grpVisionBracketLocateTape
		'
		Me.grpVisionBracketLocateTape.BackColor = System.Drawing.SystemColors.Control
		Me.grpVisionBracketLocateTape.Controls.Add(Me.gprBracketTapeCoverSettings)
		Me.grpVisionBracketLocateTape.Controls.Add(Me.gprBracketTapeBlobControls)
		Me.grpVisionBracketLocateTape.Controls.Add(Me.grpStatusBracketLocateTape)
		Me.grpVisionBracketLocateTape.Controls.Add(Me.grpCameraControlLocateTape)
		Me.grpVisionBracketLocateTape.Controls.Add(Me.grpBracketTapeCamera)
		Me.grpVisionBracketLocateTape.Controls.Add(Me.grpLocatorControlsBracketTape)
		Me.grpVisionBracketLocateTape.Controls.Add(Me.grpHSDisplayBracketTape)
		Me.grpVisionBracketLocateTape.Location = New System.Drawing.Point(6, 4)
		Me.grpVisionBracketLocateTape.Name = "grpVisionBracketLocateTape"
		Me.grpVisionBracketLocateTape.Size = New System.Drawing.Size(1522, 939)
		Me.grpVisionBracketLocateTape.TabIndex = 1
		Me.grpVisionBracketLocateTape.TabStop = False
		'
		'gprBracketTapeCoverSettings
		'
		Me.gprBracketTapeCoverSettings.BackColor = System.Drawing.SystemColors.Control
		Me.gprBracketTapeCoverSettings.Controls.Add(Me.lblCoverFoundArea)
		Me.gprBracketTapeCoverSettings.Controls.Add(Me.rdoCoverTopRight)
		Me.gprBracketTapeCoverSettings.Controls.Add(Me.lblCoverAreaTopLeft)
		Me.gprBracketTapeCoverSettings.Controls.Add(Me.rdoCoverBottomLeft)
		Me.gprBracketTapeCoverSettings.Controls.Add(Me.lblCoverMaxArea)
		Me.gprBracketTapeCoverSettings.Controls.Add(Me.rdoCoverBottomRight)
		Me.gprBracketTapeCoverSettings.Controls.Add(Me.lblCoverAreaBottomRight)
		Me.gprBracketTapeCoverSettings.Controls.Add(Me.btnTrainCoverArea)
		Me.gprBracketTapeCoverSettings.Controls.Add(Me.rdoCoverTopLeft)
		Me.gprBracketTapeCoverSettings.Controls.Add(Me.btnSaveCoverArea)
		Me.gprBracketTapeCoverSettings.Controls.Add(Me.lblCoverAreaBottomLeft)
		Me.gprBracketTapeCoverSettings.Controls.Add(Me.lblCoverMinThreshold)
		Me.gprBracketTapeCoverSettings.Controls.Add(Me.updnCoverMaxAreaBottomRight)
		Me.gprBracketTapeCoverSettings.Controls.Add(Me.updnCoverBlobMinBottomRight)
		Me.gprBracketTapeCoverSettings.Controls.Add(Me.lblCoverAreaTopRight)
		Me.gprBracketTapeCoverSettings.Controls.Add(Me.updnCoverMaxAreaBottomLeft)
		Me.gprBracketTapeCoverSettings.Controls.Add(Me.updnCoverBlobMinTopLeft)
		Me.gprBracketTapeCoverSettings.Controls.Add(Me.lblCoverTopLeft)
		Me.gprBracketTapeCoverSettings.Controls.Add(Me.updnCoverMaxAreaTopRight)
		Me.gprBracketTapeCoverSettings.Controls.Add(Me.lblCoverTopRight)
		Me.gprBracketTapeCoverSettings.Controls.Add(Me.lblCoverBottomLeft)
		Me.gprBracketTapeCoverSettings.Controls.Add(Me.updnCoverMaxAreaTopLeft)
		Me.gprBracketTapeCoverSettings.Controls.Add(Me.updnCoverBlobMinTopRight)
		Me.gprBracketTapeCoverSettings.Controls.Add(Me.updnCoverBlobMinBottomLeft)
		Me.gprBracketTapeCoverSettings.Controls.Add(Me.lblCoverBottomRight)
		Me.gprBracketTapeCoverSettings.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.gprBracketTapeCoverSettings.ForeColor = System.Drawing.SystemColors.Highlight
		Me.gprBracketTapeCoverSettings.Location = New System.Drawing.Point(928, 463)
		Me.gprBracketTapeCoverSettings.Name = "gprBracketTapeCoverSettings"
		Me.gprBracketTapeCoverSettings.Padding = New System.Windows.Forms.Padding(0)
		Me.gprBracketTapeCoverSettings.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.gprBracketTapeCoverSettings.Size = New System.Drawing.Size(538, 206)
		Me.gprBracketTapeCoverSettings.TabIndex = 90
		Me.gprBracketTapeCoverSettings.TabStop = False
		Me.gprBracketTapeCoverSettings.Text = "Tape Adhesive Settings"
		'
		'lblCoverFoundArea
		'
		Me.lblCoverFoundArea.AutoSize = True
		Me.lblCoverFoundArea.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCoverFoundArea.Location = New System.Drawing.Point(31, 178)
		Me.lblCoverFoundArea.Name = "lblCoverFoundArea"
		Me.lblCoverFoundArea.Size = New System.Drawing.Size(74, 16)
		Me.lblCoverFoundArea.TabIndex = 210
		Me.lblCoverFoundArea.Text = "Found Area"
		'
		'rdoCoverTopRight
		'
		Me.rdoCoverTopRight.AutoSize = True
		Me.rdoCoverTopRight.Location = New System.Drawing.Point(197, 24)
		Me.rdoCoverTopRight.Name = "rdoCoverTopRight"
		Me.rdoCoverTopRight.Size = New System.Drawing.Size(76, 18)
		Me.rdoCoverTopRight.TabIndex = 169
		Me.rdoCoverTopRight.TabStop = True
		Me.rdoCoverTopRight.Tag = """Bracket Tape Blob 2"""
		Me.rdoCoverTopRight.Text = "Top Right"
		Me.rdoCoverTopRight.UseVisualStyleBackColor = True
		'
		'lblCoverAreaTopLeft
		'
		Me.lblCoverAreaTopLeft.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblCoverAreaTopLeft.Location = New System.Drawing.Point(109, 176)
		Me.lblCoverAreaTopLeft.Name = "lblCoverAreaTopLeft"
		Me.lblCoverAreaTopLeft.Size = New System.Drawing.Size(70, 20)
		Me.lblCoverAreaTopLeft.TabIndex = 163
		'
		'rdoCoverBottomLeft
		'
		Me.rdoCoverBottomLeft.AutoSize = True
		Me.rdoCoverBottomLeft.Location = New System.Drawing.Point(101, 49)
		Me.rdoCoverBottomLeft.Name = "rdoCoverBottomLeft"
		Me.rdoCoverBottomLeft.Size = New System.Drawing.Size(90, 18)
		Me.rdoCoverBottomLeft.TabIndex = 168
		Me.rdoCoverBottomLeft.TabStop = True
		Me.rdoCoverBottomLeft.Tag = """Bracket Tape Blob 3"" "
		Me.rdoCoverBottomLeft.Text = "Bottom Left"
		Me.rdoCoverBottomLeft.UseVisualStyleBackColor = True
		'
		'lblCoverMaxArea
		'
		Me.lblCoverMaxArea.AutoSize = True
		Me.lblCoverMaxArea.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCoverMaxArea.Location = New System.Drawing.Point(44, 156)
		Me.lblCoverMaxArea.Name = "lblCoverMaxArea"
		Me.lblCoverMaxArea.Size = New System.Drawing.Size(63, 16)
		Me.lblCoverMaxArea.TabIndex = 209
		Me.lblCoverMaxArea.Text = "Max Area"
		'
		'rdoCoverBottomRight
		'
		Me.rdoCoverBottomRight.AutoSize = True
		Me.rdoCoverBottomRight.Location = New System.Drawing.Point(197, 49)
		Me.rdoCoverBottomRight.Name = "rdoCoverBottomRight"
		Me.rdoCoverBottomRight.Size = New System.Drawing.Size(96, 18)
		Me.rdoCoverBottomRight.TabIndex = 170
		Me.rdoCoverBottomRight.TabStop = True
		Me.rdoCoverBottomRight.Tag = """Bracket Tape Blob 4"" "
		Me.rdoCoverBottomRight.Text = "Bottom Right"
		Me.rdoCoverBottomRight.UseVisualStyleBackColor = True
		'
		'lblCoverAreaBottomRight
		'
		Me.lblCoverAreaBottomRight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblCoverAreaBottomRight.Location = New System.Drawing.Point(360, 176)
		Me.lblCoverAreaBottomRight.Name = "lblCoverAreaBottomRight"
		Me.lblCoverAreaBottomRight.Size = New System.Drawing.Size(70, 20)
		Me.lblCoverAreaBottomRight.TabIndex = 169
		'
		'btnTrainCoverArea
		'
		Me.btnTrainCoverArea.Location = New System.Drawing.Point(17, 19)
		Me.btnTrainCoverArea.Name = "btnTrainCoverArea"
		Me.btnTrainCoverArea.Size = New System.Drawing.Size(67, 23)
		Me.btnTrainCoverArea.TabIndex = 174
		Me.btnTrainCoverArea.Text = "Train"
		Me.btnTrainCoverArea.UseVisualStyleBackColor = True
		'
		'rdoCoverTopLeft
		'
		Me.rdoCoverTopLeft.AutoSize = True
		Me.rdoCoverTopLeft.Location = New System.Drawing.Point(101, 25)
		Me.rdoCoverTopLeft.Name = "rdoCoverTopLeft"
		Me.rdoCoverTopLeft.Size = New System.Drawing.Size(70, 18)
		Me.rdoCoverTopLeft.TabIndex = 167
		Me.rdoCoverTopLeft.TabStop = True
		Me.rdoCoverTopLeft.Tag = " ""Bracket Tape Blob 1"""
		Me.rdoCoverTopLeft.Text = "Top Left"
		Me.rdoCoverTopLeft.UseVisualStyleBackColor = True
		'
		'btnSaveCoverArea
		'
		Me.btnSaveCoverArea.Location = New System.Drawing.Point(17, 51)
		Me.btnSaveCoverArea.Name = "btnSaveCoverArea"
		Me.btnSaveCoverArea.Size = New System.Drawing.Size(67, 22)
		Me.btnSaveCoverArea.TabIndex = 175
		Me.btnSaveCoverArea.Text = "Save"
		Me.btnSaveCoverArea.UseVisualStyleBackColor = True
		'
		'lblCoverAreaBottomLeft
		'
		Me.lblCoverAreaBottomLeft.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblCoverAreaBottomLeft.Location = New System.Drawing.Point(275, 176)
		Me.lblCoverAreaBottomLeft.Name = "lblCoverAreaBottomLeft"
		Me.lblCoverAreaBottomLeft.Size = New System.Drawing.Size(70, 20)
		Me.lblCoverAreaBottomLeft.TabIndex = 167
		'
		'lblCoverMinThreshold
		'
		Me.lblCoverMinThreshold.AutoSize = True
		Me.lblCoverMinThreshold.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCoverMinThreshold.Location = New System.Drawing.Point(14, 135)
		Me.lblCoverMinThreshold.Name = "lblCoverMinThreshold"
		Me.lblCoverMinThreshold.Size = New System.Drawing.Size(89, 16)
		Me.lblCoverMinThreshold.TabIndex = 195
		Me.lblCoverMinThreshold.Text = "Min Threshold"
		'
		'updnCoverMaxAreaBottomRight
		'
		Me.updnCoverMaxAreaBottomRight.Location = New System.Drawing.Point(360, 153)
		Me.updnCoverMaxAreaBottomRight.Maximum = New Decimal(New Integer() {1500, 0, 0, 0})
		Me.updnCoverMaxAreaBottomRight.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.updnCoverMaxAreaBottomRight.Name = "updnCoverMaxAreaBottomRight"
		Me.updnCoverMaxAreaBottomRight.Size = New System.Drawing.Size(70, 20)
		Me.updnCoverMaxAreaBottomRight.TabIndex = 208
		Me.updnCoverMaxAreaBottomRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.updnCoverMaxAreaBottomRight.Value = New Decimal(New Integer() {1, 0, 0, 0})
		'
		'updnCoverBlobMinBottomRight
		'
		Me.updnCoverBlobMinBottomRight.Location = New System.Drawing.Point(359, 131)
		Me.updnCoverBlobMinBottomRight.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
		Me.updnCoverBlobMinBottomRight.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.updnCoverBlobMinBottomRight.Name = "updnCoverBlobMinBottomRight"
		Me.updnCoverBlobMinBottomRight.Size = New System.Drawing.Size(70, 20)
		Me.updnCoverBlobMinBottomRight.TabIndex = 193
		Me.updnCoverBlobMinBottomRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.updnCoverBlobMinBottomRight.Value = New Decimal(New Integer() {1, 0, 0, 0})
		'
		'lblCoverAreaTopRight
		'
		Me.lblCoverAreaTopRight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblCoverAreaTopRight.Location = New System.Drawing.Point(189, 176)
		Me.lblCoverAreaTopRight.Name = "lblCoverAreaTopRight"
		Me.lblCoverAreaTopRight.Size = New System.Drawing.Size(70, 20)
		Me.lblCoverAreaTopRight.TabIndex = 165
		'
		'updnCoverMaxAreaBottomLeft
		'
		Me.updnCoverMaxAreaBottomLeft.Location = New System.Drawing.Point(275, 153)
		Me.updnCoverMaxAreaBottomLeft.Maximum = New Decimal(New Integer() {1500, 0, 0, 0})
		Me.updnCoverMaxAreaBottomLeft.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.updnCoverMaxAreaBottomLeft.Name = "updnCoverMaxAreaBottomLeft"
		Me.updnCoverMaxAreaBottomLeft.Size = New System.Drawing.Size(70, 20)
		Me.updnCoverMaxAreaBottomLeft.TabIndex = 206
		Me.updnCoverMaxAreaBottomLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.updnCoverMaxAreaBottomLeft.Value = New Decimal(New Integer() {1, 0, 0, 0})
		'
		'updnCoverBlobMinTopLeft
		'
		Me.updnCoverBlobMinTopLeft.Location = New System.Drawing.Point(109, 131)
		Me.updnCoverBlobMinTopLeft.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
		Me.updnCoverBlobMinTopLeft.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.updnCoverBlobMinTopLeft.Name = "updnCoverBlobMinTopLeft"
		Me.updnCoverBlobMinTopLeft.Size = New System.Drawing.Size(70, 20)
		Me.updnCoverBlobMinTopLeft.TabIndex = 188
		Me.updnCoverBlobMinTopLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.updnCoverBlobMinTopLeft.Value = New Decimal(New Integer() {1, 0, 0, 0})
		'
		'lblCoverTopLeft
		'
		Me.lblCoverTopLeft.AutoSize = True
		Me.lblCoverTopLeft.ForeColor = System.Drawing.SystemColors.Desktop
		Me.lblCoverTopLeft.Location = New System.Drawing.Point(115, 110)
		Me.lblCoverTopLeft.Name = "lblCoverTopLeft"
		Me.lblCoverTopLeft.Size = New System.Drawing.Size(52, 14)
		Me.lblCoverTopLeft.TabIndex = 202
		Me.lblCoverTopLeft.Text = "Top Left"
		'
		'updnCoverMaxAreaTopRight
		'
		Me.updnCoverMaxAreaTopRight.Location = New System.Drawing.Point(189, 154)
		Me.updnCoverMaxAreaTopRight.Maximum = New Decimal(New Integer() {1500, 0, 0, 0})
		Me.updnCoverMaxAreaTopRight.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.updnCoverMaxAreaTopRight.Name = "updnCoverMaxAreaTopRight"
		Me.updnCoverMaxAreaTopRight.Size = New System.Drawing.Size(70, 20)
		Me.updnCoverMaxAreaTopRight.TabIndex = 207
		Me.updnCoverMaxAreaTopRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.updnCoverMaxAreaTopRight.Value = New Decimal(New Integer() {1, 0, 0, 0})
		'
		'lblCoverTopRight
		'
		Me.lblCoverTopRight.AutoSize = True
		Me.lblCoverTopRight.ForeColor = System.Drawing.SystemColors.Desktop
		Me.lblCoverTopRight.Location = New System.Drawing.Point(193, 110)
		Me.lblCoverTopRight.Name = "lblCoverTopRight"
		Me.lblCoverTopRight.Size = New System.Drawing.Size(58, 14)
		Me.lblCoverTopRight.TabIndex = 203
		Me.lblCoverTopRight.Text = "Top Right"
		'
		'lblCoverBottomLeft
		'
		Me.lblCoverBottomLeft.AutoSize = True
		Me.lblCoverBottomLeft.ForeColor = System.Drawing.SystemColors.Desktop
		Me.lblCoverBottomLeft.Location = New System.Drawing.Point(273, 110)
		Me.lblCoverBottomLeft.Name = "lblCoverBottomLeft"
		Me.lblCoverBottomLeft.Size = New System.Drawing.Size(72, 14)
		Me.lblCoverBottomLeft.TabIndex = 203
		Me.lblCoverBottomLeft.Text = "Bottom Left"
		'
		'updnCoverMaxAreaTopLeft
		'
		Me.updnCoverMaxAreaTopLeft.Location = New System.Drawing.Point(109, 154)
		Me.updnCoverMaxAreaTopLeft.Maximum = New Decimal(New Integer() {1500, 0, 0, 0})
		Me.updnCoverMaxAreaTopLeft.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.updnCoverMaxAreaTopLeft.Name = "updnCoverMaxAreaTopLeft"
		Me.updnCoverMaxAreaTopLeft.Size = New System.Drawing.Size(70, 20)
		Me.updnCoverMaxAreaTopLeft.TabIndex = 205
		Me.updnCoverMaxAreaTopLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.updnCoverMaxAreaTopLeft.Value = New Decimal(New Integer() {1, 0, 0, 0})
		'
		'updnCoverBlobMinTopRight
		'
		Me.updnCoverBlobMinTopRight.Location = New System.Drawing.Point(189, 131)
		Me.updnCoverBlobMinTopRight.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
		Me.updnCoverBlobMinTopRight.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.updnCoverBlobMinTopRight.Name = "updnCoverBlobMinTopRight"
		Me.updnCoverBlobMinTopRight.Size = New System.Drawing.Size(70, 20)
		Me.updnCoverBlobMinTopRight.TabIndex = 191
		Me.updnCoverBlobMinTopRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.updnCoverBlobMinTopRight.Value = New Decimal(New Integer() {1, 0, 0, 0})
		'
		'updnCoverBlobMinBottomLeft
		'
		Me.updnCoverBlobMinBottomLeft.Location = New System.Drawing.Point(275, 131)
		Me.updnCoverBlobMinBottomLeft.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
		Me.updnCoverBlobMinBottomLeft.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.updnCoverBlobMinBottomLeft.Name = "updnCoverBlobMinBottomLeft"
		Me.updnCoverBlobMinBottomLeft.Size = New System.Drawing.Size(70, 20)
		Me.updnCoverBlobMinBottomLeft.TabIndex = 189
		Me.updnCoverBlobMinBottomLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.updnCoverBlobMinBottomLeft.Value = New Decimal(New Integer() {1, 0, 0, 0})
		'
		'lblCoverBottomRight
		'
		Me.lblCoverBottomRight.AutoSize = True
		Me.lblCoverBottomRight.ForeColor = System.Drawing.SystemColors.Desktop
		Me.lblCoverBottomRight.Location = New System.Drawing.Point(354, 110)
		Me.lblCoverBottomRight.Name = "lblCoverBottomRight"
		Me.lblCoverBottomRight.Size = New System.Drawing.Size(78, 14)
		Me.lblCoverBottomRight.TabIndex = 204
		Me.lblCoverBottomRight.Text = "Bottom Right"
		'
		'gprBracketTapeBlobControls
		'
		Me.gprBracketTapeBlobControls.BackColor = System.Drawing.SystemColors.Control
		Me.gprBracketTapeBlobControls.Controls.Add(Me.lblTapeFoundArea)
		Me.gprBracketTapeBlobControls.Controls.Add(Me.rdoTapeTopRight)
		Me.gprBracketTapeBlobControls.Controls.Add(Me.lblTapeAreaTopLeft)
		Me.gprBracketTapeBlobControls.Controls.Add(Me.rdoTapeBottomLeft)
		Me.gprBracketTapeBlobControls.Controls.Add(Me.lblTapeMinArea)
		Me.gprBracketTapeBlobControls.Controls.Add(Me.rdoTapeBottomRight)
		Me.gprBracketTapeBlobControls.Controls.Add(Me.lblTapeAreaBottomRight)
		Me.gprBracketTapeBlobControls.Controls.Add(Me.btnTrainTapeArea)
		Me.gprBracketTapeBlobControls.Controls.Add(Me.rdoTapeTopLeft)
		Me.gprBracketTapeBlobControls.Controls.Add(Me.btnSaveTapeArea)
		Me.gprBracketTapeBlobControls.Controls.Add(Me.lblTapeAreaBottomLeft)
		Me.gprBracketTapeBlobControls.Controls.Add(Me.lblTapeMinThreshold)
		Me.gprBracketTapeBlobControls.Controls.Add(Me.updnTapeMinAreaBottomRight)
		Me.gprBracketTapeBlobControls.Controls.Add(Me.updnTapeBlobMinBottomRight)
		Me.gprBracketTapeBlobControls.Controls.Add(Me.lblTapeMaxThreshold)
		Me.gprBracketTapeBlobControls.Controls.Add(Me.lblTapeAreaTopRight)
		Me.gprBracketTapeBlobControls.Controls.Add(Me.updnTapeBlobMaxBottomRight)
		Me.gprBracketTapeBlobControls.Controls.Add(Me.updnTapeBlobMaxBottomLeft)
		Me.gprBracketTapeBlobControls.Controls.Add(Me.updnTapeMinAreaBottomLeft)
		Me.gprBracketTapeBlobControls.Controls.Add(Me.updnTapeBlobMinTopLeft)
		Me.gprBracketTapeBlobControls.Controls.Add(Me.lblTapeTopLeft)
		Me.gprBracketTapeBlobControls.Controls.Add(Me.updnTapeBlobMaxTopLeft)
		Me.gprBracketTapeBlobControls.Controls.Add(Me.updnTapeMinAreaTopRight)
		Me.gprBracketTapeBlobControls.Controls.Add(Me.updnTapeBlobMaxTopRight)
		Me.gprBracketTapeBlobControls.Controls.Add(Me.lblTapeTopRight)
		Me.gprBracketTapeBlobControls.Controls.Add(Me.lblTapeBottomLeft)
		Me.gprBracketTapeBlobControls.Controls.Add(Me.updnTapeMinAreaTopLeft)
		Me.gprBracketTapeBlobControls.Controls.Add(Me.updnTapeBlobMinTopRight)
		Me.gprBracketTapeBlobControls.Controls.Add(Me.updnTapeBlobMinBottomLeft)
		Me.gprBracketTapeBlobControls.Controls.Add(Me.lblTapeBottomRight)
		Me.gprBracketTapeBlobControls.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.gprBracketTapeBlobControls.ForeColor = System.Drawing.SystemColors.Highlight
		Me.gprBracketTapeBlobControls.Location = New System.Drawing.Point(928, 218)
		Me.gprBracketTapeBlobControls.Name = "gprBracketTapeBlobControls"
		Me.gprBracketTapeBlobControls.Padding = New System.Windows.Forms.Padding(0)
		Me.gprBracketTapeBlobControls.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.gprBracketTapeBlobControls.Size = New System.Drawing.Size(538, 234)
		Me.gprBracketTapeBlobControls.TabIndex = 89
		Me.gprBracketTapeBlobControls.TabStop = False
		Me.gprBracketTapeBlobControls.Text = "Tape Adhesive Settings"
		'
		'lblTapeFoundArea
		'
		Me.lblTapeFoundArea.AutoSize = True
		Me.lblTapeFoundArea.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblTapeFoundArea.Location = New System.Drawing.Point(31, 207)
		Me.lblTapeFoundArea.Name = "lblTapeFoundArea"
		Me.lblTapeFoundArea.Size = New System.Drawing.Size(74, 16)
		Me.lblTapeFoundArea.TabIndex = 210
		Me.lblTapeFoundArea.Text = "Found Area"
		'
		'rdoTapeTopRight
		'
		Me.rdoTapeTopRight.AutoSize = True
		Me.rdoTapeTopRight.Location = New System.Drawing.Point(197, 24)
		Me.rdoTapeTopRight.Name = "rdoTapeTopRight"
		Me.rdoTapeTopRight.Size = New System.Drawing.Size(76, 18)
		Me.rdoTapeTopRight.TabIndex = 169
		Me.rdoTapeTopRight.TabStop = True
		Me.rdoTapeTopRight.Tag = """Bracket Tape Blob 2"""
		Me.rdoTapeTopRight.Text = "Top Right"
		Me.rdoTapeTopRight.UseVisualStyleBackColor = True
		'
		'lblTapeAreaTopLeft
		'
		Me.lblTapeAreaTopLeft.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblTapeAreaTopLeft.Location = New System.Drawing.Point(109, 205)
		Me.lblTapeAreaTopLeft.Name = "lblTapeAreaTopLeft"
		Me.lblTapeAreaTopLeft.Size = New System.Drawing.Size(70, 20)
		Me.lblTapeAreaTopLeft.TabIndex = 163
		'
		'rdoTapeBottomLeft
		'
		Me.rdoTapeBottomLeft.AutoSize = True
		Me.rdoTapeBottomLeft.Location = New System.Drawing.Point(101, 49)
		Me.rdoTapeBottomLeft.Name = "rdoTapeBottomLeft"
		Me.rdoTapeBottomLeft.Size = New System.Drawing.Size(90, 18)
		Me.rdoTapeBottomLeft.TabIndex = 168
		Me.rdoTapeBottomLeft.TabStop = True
		Me.rdoTapeBottomLeft.Tag = """Bracket Tape Blob 3"" "
		Me.rdoTapeBottomLeft.Text = "Bottom Left"
		Me.rdoTapeBottomLeft.UseVisualStyleBackColor = True
		'
		'lblTapeMinArea
		'
		Me.lblTapeMinArea.AutoSize = True
		Me.lblTapeMinArea.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblTapeMinArea.Location = New System.Drawing.Point(44, 185)
		Me.lblTapeMinArea.Name = "lblTapeMinArea"
		Me.lblTapeMinArea.Size = New System.Drawing.Size(59, 16)
		Me.lblTapeMinArea.TabIndex = 209
		Me.lblTapeMinArea.Text = "Min Area"
		'
		'rdoTapeBottomRight
		'
		Me.rdoTapeBottomRight.AutoSize = True
		Me.rdoTapeBottomRight.Location = New System.Drawing.Point(197, 49)
		Me.rdoTapeBottomRight.Name = "rdoTapeBottomRight"
		Me.rdoTapeBottomRight.Size = New System.Drawing.Size(96, 18)
		Me.rdoTapeBottomRight.TabIndex = 170
		Me.rdoTapeBottomRight.TabStop = True
		Me.rdoTapeBottomRight.Tag = """Bracket Tape Blob 4"" "
		Me.rdoTapeBottomRight.Text = "Bottom Right"
		Me.rdoTapeBottomRight.UseVisualStyleBackColor = True
		'
		'lblTapeAreaBottomRight
		'
		Me.lblTapeAreaBottomRight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblTapeAreaBottomRight.Location = New System.Drawing.Point(360, 205)
		Me.lblTapeAreaBottomRight.Name = "lblTapeAreaBottomRight"
		Me.lblTapeAreaBottomRight.Size = New System.Drawing.Size(70, 20)
		Me.lblTapeAreaBottomRight.TabIndex = 169
		'
		'btnTrainTapeArea
		'
		Me.btnTrainTapeArea.Location = New System.Drawing.Point(17, 19)
		Me.btnTrainTapeArea.Name = "btnTrainTapeArea"
		Me.btnTrainTapeArea.Size = New System.Drawing.Size(67, 23)
		Me.btnTrainTapeArea.TabIndex = 174
		Me.btnTrainTapeArea.Text = "Train"
		Me.btnTrainTapeArea.UseVisualStyleBackColor = True
		'
		'rdoTapeTopLeft
		'
		Me.rdoTapeTopLeft.AutoSize = True
		Me.rdoTapeTopLeft.Location = New System.Drawing.Point(101, 25)
		Me.rdoTapeTopLeft.Name = "rdoTapeTopLeft"
		Me.rdoTapeTopLeft.Size = New System.Drawing.Size(70, 18)
		Me.rdoTapeTopLeft.TabIndex = 167
		Me.rdoTapeTopLeft.TabStop = True
		Me.rdoTapeTopLeft.Tag = " ""Bracket Tape Blob 1"""
		Me.rdoTapeTopLeft.Text = "Top Left"
		Me.rdoTapeTopLeft.UseVisualStyleBackColor = True
		'
		'btnSaveTapeArea
		'
		Me.btnSaveTapeArea.Location = New System.Drawing.Point(17, 51)
		Me.btnSaveTapeArea.Name = "btnSaveTapeArea"
		Me.btnSaveTapeArea.Size = New System.Drawing.Size(67, 22)
		Me.btnSaveTapeArea.TabIndex = 175
		Me.btnSaveTapeArea.Text = "Save"
		Me.btnSaveTapeArea.UseVisualStyleBackColor = True
		'
		'lblTapeAreaBottomLeft
		'
		Me.lblTapeAreaBottomLeft.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblTapeAreaBottomLeft.Location = New System.Drawing.Point(275, 205)
		Me.lblTapeAreaBottomLeft.Name = "lblTapeAreaBottomLeft"
		Me.lblTapeAreaBottomLeft.Size = New System.Drawing.Size(70, 20)
		Me.lblTapeAreaBottomLeft.TabIndex = 167
		'
		'lblTapeMinThreshold
		'
		Me.lblTapeMinThreshold.AutoSize = True
		Me.lblTapeMinThreshold.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblTapeMinThreshold.Location = New System.Drawing.Point(14, 135)
		Me.lblTapeMinThreshold.Name = "lblTapeMinThreshold"
		Me.lblTapeMinThreshold.Size = New System.Drawing.Size(89, 16)
		Me.lblTapeMinThreshold.TabIndex = 195
		Me.lblTapeMinThreshold.Text = "Min Threshold"
		'
		'updnTapeMinAreaBottomRight
		'
		Me.updnTapeMinAreaBottomRight.Location = New System.Drawing.Point(360, 182)
		Me.updnTapeMinAreaBottomRight.Maximum = New Decimal(New Integer() {1500, 0, 0, 0})
		Me.updnTapeMinAreaBottomRight.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.updnTapeMinAreaBottomRight.Name = "updnTapeMinAreaBottomRight"
		Me.updnTapeMinAreaBottomRight.Size = New System.Drawing.Size(70, 20)
		Me.updnTapeMinAreaBottomRight.TabIndex = 208
		Me.updnTapeMinAreaBottomRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.updnTapeMinAreaBottomRight.Value = New Decimal(New Integer() {1, 0, 0, 0})
		'
		'updnTapeBlobMinBottomRight
		'
		Me.updnTapeBlobMinBottomRight.Location = New System.Drawing.Point(359, 131)
		Me.updnTapeBlobMinBottomRight.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
		Me.updnTapeBlobMinBottomRight.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.updnTapeBlobMinBottomRight.Name = "updnTapeBlobMinBottomRight"
		Me.updnTapeBlobMinBottomRight.Size = New System.Drawing.Size(70, 20)
		Me.updnTapeBlobMinBottomRight.TabIndex = 193
		Me.updnTapeBlobMinBottomRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.updnTapeBlobMinBottomRight.Value = New Decimal(New Integer() {1, 0, 0, 0})
		'
		'lblTapeMaxThreshold
		'
		Me.lblTapeMaxThreshold.AutoSize = True
		Me.lblTapeMaxThreshold.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblTapeMaxThreshold.Location = New System.Drawing.Point(10, 161)
		Me.lblTapeMaxThreshold.Name = "lblTapeMaxThreshold"
		Me.lblTapeMaxThreshold.Size = New System.Drawing.Size(93, 16)
		Me.lblTapeMaxThreshold.TabIndex = 188
		Me.lblTapeMaxThreshold.Text = "Max Threshold"
		'
		'lblTapeAreaTopRight
		'
		Me.lblTapeAreaTopRight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblTapeAreaTopRight.Location = New System.Drawing.Point(189, 205)
		Me.lblTapeAreaTopRight.Name = "lblTapeAreaTopRight"
		Me.lblTapeAreaTopRight.Size = New System.Drawing.Size(70, 20)
		Me.lblTapeAreaTopRight.TabIndex = 165
		'
		'updnTapeBlobMaxBottomRight
		'
		Me.updnTapeBlobMaxBottomRight.Location = New System.Drawing.Point(359, 156)
		Me.updnTapeBlobMaxBottomRight.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
		Me.updnTapeBlobMaxBottomRight.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.updnTapeBlobMaxBottomRight.Name = "updnTapeBlobMaxBottomRight"
		Me.updnTapeBlobMaxBottomRight.Size = New System.Drawing.Size(70, 20)
		Me.updnTapeBlobMaxBottomRight.TabIndex = 194
		Me.updnTapeBlobMaxBottomRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.updnTapeBlobMaxBottomRight.Value = New Decimal(New Integer() {1, 0, 0, 0})
		'
		'updnTapeBlobMaxBottomLeft
		'
		Me.updnTapeBlobMaxBottomLeft.Location = New System.Drawing.Point(276, 157)
		Me.updnTapeBlobMaxBottomLeft.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
		Me.updnTapeBlobMaxBottomLeft.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.updnTapeBlobMaxBottomLeft.Name = "updnTapeBlobMaxBottomLeft"
		Me.updnTapeBlobMaxBottomLeft.Size = New System.Drawing.Size(70, 20)
		Me.updnTapeBlobMaxBottomLeft.TabIndex = 190
		Me.updnTapeBlobMaxBottomLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.updnTapeBlobMaxBottomLeft.Value = New Decimal(New Integer() {1, 0, 0, 0})
		'
		'updnTapeMinAreaBottomLeft
		'
		Me.updnTapeMinAreaBottomLeft.Location = New System.Drawing.Point(276, 182)
		Me.updnTapeMinAreaBottomLeft.Maximum = New Decimal(New Integer() {1500, 0, 0, 0})
		Me.updnTapeMinAreaBottomLeft.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.updnTapeMinAreaBottomLeft.Name = "updnTapeMinAreaBottomLeft"
		Me.updnTapeMinAreaBottomLeft.Size = New System.Drawing.Size(70, 20)
		Me.updnTapeMinAreaBottomLeft.TabIndex = 206
		Me.updnTapeMinAreaBottomLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.updnTapeMinAreaBottomLeft.Value = New Decimal(New Integer() {1, 0, 0, 0})
		'
		'updnTapeBlobMinTopLeft
		'
		Me.updnTapeBlobMinTopLeft.Location = New System.Drawing.Point(109, 131)
		Me.updnTapeBlobMinTopLeft.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
		Me.updnTapeBlobMinTopLeft.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.updnTapeBlobMinTopLeft.Name = "updnTapeBlobMinTopLeft"
		Me.updnTapeBlobMinTopLeft.Size = New System.Drawing.Size(70, 20)
		Me.updnTapeBlobMinTopLeft.TabIndex = 188
		Me.updnTapeBlobMinTopLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.updnTapeBlobMinTopLeft.Value = New Decimal(New Integer() {1, 0, 0, 0})
		'
		'lblTapeTopLeft
		'
		Me.lblTapeTopLeft.AutoSize = True
		Me.lblTapeTopLeft.ForeColor = System.Drawing.SystemColors.Desktop
		Me.lblTapeTopLeft.Location = New System.Drawing.Point(115, 110)
		Me.lblTapeTopLeft.Name = "lblTapeTopLeft"
		Me.lblTapeTopLeft.Size = New System.Drawing.Size(52, 14)
		Me.lblTapeTopLeft.TabIndex = 202
		Me.lblTapeTopLeft.Text = "Top Left"
		'
		'updnTapeBlobMaxTopLeft
		'
		Me.updnTapeBlobMaxTopLeft.Location = New System.Drawing.Point(109, 157)
		Me.updnTapeBlobMaxTopLeft.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
		Me.updnTapeBlobMaxTopLeft.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.updnTapeBlobMaxTopLeft.Name = "updnTapeBlobMaxTopLeft"
		Me.updnTapeBlobMaxTopLeft.Size = New System.Drawing.Size(70, 20)
		Me.updnTapeBlobMaxTopLeft.TabIndex = 188
		Me.updnTapeBlobMaxTopLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.updnTapeBlobMaxTopLeft.Value = New Decimal(New Integer() {1, 0, 0, 0})
		'
		'updnTapeMinAreaTopRight
		'
		Me.updnTapeMinAreaTopRight.Location = New System.Drawing.Point(190, 183)
		Me.updnTapeMinAreaTopRight.Maximum = New Decimal(New Integer() {1500, 0, 0, 0})
		Me.updnTapeMinAreaTopRight.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.updnTapeMinAreaTopRight.Name = "updnTapeMinAreaTopRight"
		Me.updnTapeMinAreaTopRight.Size = New System.Drawing.Size(70, 20)
		Me.updnTapeMinAreaTopRight.TabIndex = 207
		Me.updnTapeMinAreaTopRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.updnTapeMinAreaTopRight.Value = New Decimal(New Integer() {1, 0, 0, 0})
		'
		'updnTapeBlobMaxTopRight
		'
		Me.updnTapeBlobMaxTopRight.Location = New System.Drawing.Point(189, 157)
		Me.updnTapeBlobMaxTopRight.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
		Me.updnTapeBlobMaxTopRight.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.updnTapeBlobMaxTopRight.Name = "updnTapeBlobMaxTopRight"
		Me.updnTapeBlobMaxTopRight.Size = New System.Drawing.Size(70, 20)
		Me.updnTapeBlobMaxTopRight.TabIndex = 192
		Me.updnTapeBlobMaxTopRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.updnTapeBlobMaxTopRight.Value = New Decimal(New Integer() {1, 0, 0, 0})
		'
		'lblTapeTopRight
		'
		Me.lblTapeTopRight.AutoSize = True
		Me.lblTapeTopRight.ForeColor = System.Drawing.SystemColors.Desktop
		Me.lblTapeTopRight.Location = New System.Drawing.Point(193, 110)
		Me.lblTapeTopRight.Name = "lblTapeTopRight"
		Me.lblTapeTopRight.Size = New System.Drawing.Size(58, 14)
		Me.lblTapeTopRight.TabIndex = 203
		Me.lblTapeTopRight.Text = "Top Right"
		'
		'lblTapeBottomLeft
		'
		Me.lblTapeBottomLeft.AutoSize = True
		Me.lblTapeBottomLeft.ForeColor = System.Drawing.SystemColors.Desktop
		Me.lblTapeBottomLeft.Location = New System.Drawing.Point(273, 110)
		Me.lblTapeBottomLeft.Name = "lblTapeBottomLeft"
		Me.lblTapeBottomLeft.Size = New System.Drawing.Size(72, 14)
		Me.lblTapeBottomLeft.TabIndex = 203
		Me.lblTapeBottomLeft.Text = "Bottom Left"
		'
		'updnTapeMinAreaTopLeft
		'
		Me.updnTapeMinAreaTopLeft.Location = New System.Drawing.Point(109, 183)
		Me.updnTapeMinAreaTopLeft.Maximum = New Decimal(New Integer() {1500, 0, 0, 0})
		Me.updnTapeMinAreaTopLeft.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.updnTapeMinAreaTopLeft.Name = "updnTapeMinAreaTopLeft"
		Me.updnTapeMinAreaTopLeft.Size = New System.Drawing.Size(70, 20)
		Me.updnTapeMinAreaTopLeft.TabIndex = 205
		Me.updnTapeMinAreaTopLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.updnTapeMinAreaTopLeft.Value = New Decimal(New Integer() {1, 0, 0, 0})
		'
		'updnTapeBlobMinTopRight
		'
		Me.updnTapeBlobMinTopRight.Location = New System.Drawing.Point(189, 131)
		Me.updnTapeBlobMinTopRight.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
		Me.updnTapeBlobMinTopRight.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.updnTapeBlobMinTopRight.Name = "updnTapeBlobMinTopRight"
		Me.updnTapeBlobMinTopRight.Size = New System.Drawing.Size(70, 20)
		Me.updnTapeBlobMinTopRight.TabIndex = 191
		Me.updnTapeBlobMinTopRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.updnTapeBlobMinTopRight.Value = New Decimal(New Integer() {1, 0, 0, 0})
		'
		'updnTapeBlobMinBottomLeft
		'
		Me.updnTapeBlobMinBottomLeft.Location = New System.Drawing.Point(275, 131)
		Me.updnTapeBlobMinBottomLeft.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
		Me.updnTapeBlobMinBottomLeft.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.updnTapeBlobMinBottomLeft.Name = "updnTapeBlobMinBottomLeft"
		Me.updnTapeBlobMinBottomLeft.Size = New System.Drawing.Size(70, 20)
		Me.updnTapeBlobMinBottomLeft.TabIndex = 189
		Me.updnTapeBlobMinBottomLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.updnTapeBlobMinBottomLeft.Value = New Decimal(New Integer() {1, 0, 0, 0})
		'
		'lblTapeBottomRight
		'
		Me.lblTapeBottomRight.AutoSize = True
		Me.lblTapeBottomRight.ForeColor = System.Drawing.SystemColors.Desktop
		Me.lblTapeBottomRight.Location = New System.Drawing.Point(354, 110)
		Me.lblTapeBottomRight.Name = "lblTapeBottomRight"
		Me.lblTapeBottomRight.Size = New System.Drawing.Size(78, 14)
		Me.lblTapeBottomRight.TabIndex = 204
		Me.lblTapeBottomRight.Text = "Bottom Right"
		'
		'grpStatusBracketLocateTape
		'
		Me.grpStatusBracketLocateTape.BackColor = System.Drawing.SystemColors.Control
		Me.grpStatusBracketLocateTape.Controls.Add(Me.btnDetailsBracketTape)
		Me.grpStatusBracketLocateTape.Controls.Add(Me.lblVisionMessageBracketTape)
		Me.grpStatusBracketLocateTape.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.grpStatusBracketLocateTape.ForeColor = System.Drawing.SystemColors.Highlight
		Me.grpStatusBracketLocateTape.Location = New System.Drawing.Point(687, 15)
		Me.grpStatusBracketLocateTape.Name = "grpStatusBracketLocateTape"
		Me.grpStatusBracketLocateTape.Padding = New System.Windows.Forms.Padding(0)
		Me.grpStatusBracketLocateTape.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.grpStatusBracketLocateTape.Size = New System.Drawing.Size(294, 188)
		Me.grpStatusBracketLocateTape.TabIndex = 50
		Me.grpStatusBracketLocateTape.TabStop = False
		Me.grpStatusBracketLocateTape.Text = "Status"
		'
		'grpCameraControlLocateTape
		'
		Me.grpCameraControlLocateTape.BackColor = System.Drawing.SystemColors.Control
		Me.grpCameraControlLocateTape.Controls.Add(Me.lblCamControlAcqTimeBracketTape)
		Me.grpCameraControlLocateTape.Controls.Add(Me.lblContrastBracketTape)
		Me.grpCameraControlLocateTape.Controls.Add(Me.lblExposureBracketTape)
		Me.grpCameraControlLocateTape.Controls.Add(Me.updnContrastBracketTape)
		Me.grpCameraControlLocateTape.Controls.Add(Me.updnExposureBracketTape)
		Me.grpCameraControlLocateTape.Controls.Add(Me.btnSnapBracketTape)
		Me.grpCameraControlLocateTape.Controls.Add(Me.chkSnapRepeatBracketTape)
		Me.grpCameraControlLocateTape.Controls.Add(Me.lblCameraTimeBracketTape)
		Me.grpCameraControlLocateTape.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.grpCameraControlLocateTape.ForeColor = System.Drawing.SystemColors.Highlight
		Me.grpCameraControlLocateTape.Location = New System.Drawing.Point(134, 15)
		Me.grpCameraControlLocateTape.Name = "grpCameraControlLocateTape"
		Me.grpCameraControlLocateTape.Padding = New System.Windows.Forms.Padding(0)
		Me.grpCameraControlLocateTape.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.grpCameraControlLocateTape.Size = New System.Drawing.Size(186, 189)
		Me.grpCameraControlLocateTape.TabIndex = 87
		Me.grpCameraControlLocateTape.TabStop = False
		Me.grpCameraControlLocateTape.Text = "Camera Controls"
		'
		'lblCamControlAcqTimeBracketTape
		'
		Me.lblCamControlAcqTimeBracketTape.AutoSize = True
		Me.lblCamControlAcqTimeBracketTape.Location = New System.Drawing.Point(36, 54)
		Me.lblCamControlAcqTimeBracketTape.Name = "lblCamControlAcqTimeBracketTape"
		Me.lblCamControlAcqTimeBracketTape.Size = New System.Drawing.Size(59, 14)
		Me.lblCamControlAcqTimeBracketTape.TabIndex = 165
		Me.lblCamControlAcqTimeBracketTape.Text = "Acq Time"
		'
		'lblContrastBracketTape
		'
		Me.lblContrastBracketTape.AutoSize = True
		Me.lblContrastBracketTape.Location = New System.Drawing.Point(40, 99)
		Me.lblContrastBracketTape.Name = "lblContrastBracketTape"
		Me.lblContrastBracketTape.Size = New System.Drawing.Size(55, 14)
		Me.lblContrastBracketTape.TabIndex = 148
		Me.lblContrastBracketTape.Text = "Contrast"
		'
		'lblExposureBracketTape
		'
		Me.lblExposureBracketTape.AutoSize = True
		Me.lblExposureBracketTape.Location = New System.Drawing.Point(36, 77)
		Me.lblExposureBracketTape.Name = "lblExposureBracketTape"
		Me.lblExposureBracketTape.Size = New System.Drawing.Size(59, 14)
		Me.lblExposureBracketTape.TabIndex = 146
		Me.lblExposureBracketTape.Text = "Exposure"
		'
		'updnContrastBracketTape
		'
		Me.updnContrastBracketTape.Increment = New Decimal(New Integer() {10, 0, 0, 0})
		Me.updnContrastBracketTape.Location = New System.Drawing.Point(101, 97)
		Me.updnContrastBracketTape.Name = "updnContrastBracketTape"
		Me.updnContrastBracketTape.Size = New System.Drawing.Size(49, 20)
		Me.updnContrastBracketTape.TabIndex = 145
		Me.updnContrastBracketTape.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
		Me.updnContrastBracketTape.Value = New Decimal(New Integer() {9, 0, 0, 0})
		'
		'updnExposureBracketTape
		'
		Me.updnExposureBracketTape.Increment = New Decimal(New Integer() {25, 0, 0, 0})
		Me.updnExposureBracketTape.Location = New System.Drawing.Point(101, 75)
		Me.updnExposureBracketTape.Maximum = New Decimal(New Integer() {1500, 0, 0, 0})
		Me.updnExposureBracketTape.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
		Me.updnExposureBracketTape.Name = "updnExposureBracketTape"
		Me.updnExposureBracketTape.Size = New System.Drawing.Size(49, 20)
		Me.updnExposureBracketTape.TabIndex = 142
		Me.updnExposureBracketTape.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
		Me.updnExposureBracketTape.Value = New Decimal(New Integer() {10, 0, 0, 0})
		'
		'chkSnapRepeatBracketTape
		'
		Me.chkSnapRepeatBracketTape.BackColor = System.Drawing.SystemColors.Control
		Me.chkSnapRepeatBracketTape.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkSnapRepeatBracketTape.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkSnapRepeatBracketTape.ForeColor = System.Drawing.SystemColors.Highlight
		Me.chkSnapRepeatBracketTape.Location = New System.Drawing.Point(115, 14)
		Me.chkSnapRepeatBracketTape.Name = "chkSnapRepeatBracketTape"
		Me.chkSnapRepeatBracketTape.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkSnapRepeatBracketTape.Size = New System.Drawing.Size(62, 24)
		Me.chkSnapRepeatBracketTape.TabIndex = 72
		Me.chkSnapRepeatBracketTape.TabStop = False
		Me.chkSnapRepeatBracketTape.Text = "Repeat"
		Me.chkSnapRepeatBracketTape.UseVisualStyleBackColor = False
		'
		'lblCameraTimeBracketTape
		'
		Me.lblCameraTimeBracketTape.BackColor = System.Drawing.SystemColors.Control
		Me.lblCameraTimeBracketTape.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblCameraTimeBracketTape.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblCameraTimeBracketTape.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCameraTimeBracketTape.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblCameraTimeBracketTape.Location = New System.Drawing.Point(101, 52)
		Me.lblCameraTimeBracketTape.Name = "lblCameraTimeBracketTape"
		Me.lblCameraTimeBracketTape.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblCameraTimeBracketTape.Size = New System.Drawing.Size(48, 18)
		Me.lblCameraTimeBracketTape.TabIndex = 75
		'
		'grpBracketTapeCamera
		'
		Me.grpBracketTapeCamera.Controls.Add(Me.lblBracketTapeCameraWarning)
		Me.grpBracketTapeCamera.Controls.Add(Me.lblTemperatureBracketTape)
		Me.grpBracketTapeCamera.Controls.Add(Me.pbBracketTape)
		Me.grpBracketTapeCamera.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
		Me.grpBracketTapeCamera.ForeColor = System.Drawing.SystemColors.Highlight
		Me.grpBracketTapeCamera.Location = New System.Drawing.Point(10, 15)
		Me.grpBracketTapeCamera.Name = "grpBracketTapeCamera"
		Me.grpBracketTapeCamera.Size = New System.Drawing.Size(123, 189)
		Me.grpBracketTapeCamera.TabIndex = 84
		Me.grpBracketTapeCamera.TabStop = False
		Me.grpBracketTapeCamera.Text = "Camera Status"
		'
		'lblBracketTapeCameraWarning
		'
		Me.lblBracketTapeCameraWarning.AutoSize = True
		Me.lblBracketTapeCameraWarning.Font = New System.Drawing.Font("Arial Black", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblBracketTapeCameraWarning.ForeColor = System.Drawing.Color.DarkRed
		Me.lblBracketTapeCameraWarning.Location = New System.Drawing.Point(6, 21)
		Me.lblBracketTapeCameraWarning.Name = "lblBracketTapeCameraWarning"
		Me.lblBracketTapeCameraWarning.Size = New System.Drawing.Size(114, 51)
		Me.lblBracketTapeCameraWarning.TabIndex = 161
		Me.lblBracketTapeCameraWarning.Text = "       Warning! " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  The Camera is " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  not connected"
		Me.lblBracketTapeCameraWarning.Visible = False
		'
		'lblTemperatureBracketTape
		'
		Me.lblTemperatureBracketTape.BackColor = System.Drawing.SystemColors.ButtonShadow
		Me.lblTemperatureBracketTape.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblTemperatureBracketTape.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblTemperatureBracketTape.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblTemperatureBracketTape.Location = New System.Drawing.Point(6, 97)
		Me.lblTemperatureBracketTape.Name = "lblTemperatureBracketTape"
		Me.lblTemperatureBracketTape.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblTemperatureBracketTape.Size = New System.Drawing.Size(39, 48)
		Me.lblTemperatureBracketTape.TabIndex = 160
		Me.lblTemperatureBracketTape.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'pbBracketTape
		'
		Me.pbBracketTape.Image = CType(resources.GetObject("pbBracketTape.Image"), System.Drawing.Image)
		Me.pbBracketTape.Location = New System.Drawing.Point(11, 32)
		Me.pbBracketTape.Name = "pbBracketTape"
		Me.pbBracketTape.Size = New System.Drawing.Size(25, 60)
		Me.pbBracketTape.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.pbBracketTape.TabIndex = 159
		Me.pbBracketTape.TabStop = False
		'
		'grpLocatorControlsBracketTape
		'
		Me.grpLocatorControlsBracketTape.BackColor = System.Drawing.SystemColors.Control
		Me.grpLocatorControlsBracketTape.Controls.Add(Me.lblVisionTapeScoreData)
		Me.grpLocatorControlsBracketTape.Controls.Add(Me.Label9)
		Me.grpLocatorControlsBracketTape.Controls.Add(Me.lblVisionTapeTimeData)
		Me.grpLocatorControlsBracketTape.Controls.Add(Me.updnScoreLimitTapeBracketLocator)
		Me.grpLocatorControlsBracketTape.Controls.Add(Me.lblVisionTapeRData)
		Me.grpLocatorControlsBracketTape.Controls.Add(Me.btnLocateOnlyBracketTape)
		Me.grpLocatorControlsBracketTape.Controls.Add(Me.lblVisionTapeYData)
		Me.grpLocatorControlsBracketTape.Controls.Add(Me.btnLocateBracketTape)
		Me.grpLocatorControlsBracketTape.Controls.Add(Me.lblVisionTapeXData)
		Me.grpLocatorControlsBracketTape.Controls.Add(Me.chkLocateBracketTape)
		Me.grpLocatorControlsBracketTape.Controls.Add(Me.lblVisionTapeX)
		Me.grpLocatorControlsBracketTape.Controls.Add(Me.btnSearchSettingsBracketTape)
		Me.grpLocatorControlsBracketTape.Controls.Add(Me.lblVisionTapeY)
		Me.grpLocatorControlsBracketTape.Controls.Add(Me.btnTrainNewBracketTape)
		Me.grpLocatorControlsBracketTape.Controls.Add(Me.lblVisionTapeR)
		Me.grpLocatorControlsBracketTape.Controls.Add(Me.lblLocateTimeBracketTape)
		Me.grpLocatorControlsBracketTape.Controls.Add(Me.lblVisionTapeTime)
		Me.grpLocatorControlsBracketTape.Controls.Add(Me.lblLocatorTimeBracketTape)
		Me.grpLocatorControlsBracketTape.Controls.Add(Me.lblVisionTapeScore)
		Me.grpLocatorControlsBracketTape.Controls.Add(Me.btnTrainExistingBracketTape)
		Me.grpLocatorControlsBracketTape.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.grpLocatorControlsBracketTape.ForeColor = System.Drawing.SystemColors.Highlight
		Me.grpLocatorControlsBracketTape.Location = New System.Drawing.Point(334, 15)
		Me.grpLocatorControlsBracketTape.Name = "grpLocatorControlsBracketTape"
		Me.grpLocatorControlsBracketTape.Padding = New System.Windows.Forms.Padding(0)
		Me.grpLocatorControlsBracketTape.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.grpLocatorControlsBracketTape.Size = New System.Drawing.Size(337, 188)
		Me.grpLocatorControlsBracketTape.TabIndex = 88
		Me.grpLocatorControlsBracketTape.TabStop = False
		Me.grpLocatorControlsBracketTape.Text = "Tape Setup"
		'
		'lblVisionTapeScoreData
		'
		Me.lblVisionTapeScoreData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblVisionTapeScoreData.Location = New System.Drawing.Point(250, 158)
		Me.lblVisionTapeScoreData.Name = "lblVisionTapeScoreData"
		Me.lblVisionTapeScoreData.Size = New System.Drawing.Size(59, 23)
		Me.lblVisionTapeScoreData.TabIndex = 219
		'
		'Label9
		'
		Me.Label9.AutoSize = True
		Me.Label9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label9.ForeColor = System.Drawing.SystemColors.Desktop
		Me.Label9.Location = New System.Drawing.Point(13, 33)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(115, 14)
		Me.Label9.TabIndex = 173
		Me.Label9.Text = "Bracket Score Limit"
		'
		'lblVisionTapeTimeData
		'
		Me.lblVisionTapeTimeData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblVisionTapeTimeData.Location = New System.Drawing.Point(190, 158)
		Me.lblVisionTapeTimeData.Name = "lblVisionTapeTimeData"
		Me.lblVisionTapeTimeData.Size = New System.Drawing.Size(59, 23)
		Me.lblVisionTapeTimeData.TabIndex = 218
		'
		'lblVisionTapeRData
		'
		Me.lblVisionTapeRData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblVisionTapeRData.Location = New System.Drawing.Point(130, 158)
		Me.lblVisionTapeRData.Name = "lblVisionTapeRData"
		Me.lblVisionTapeRData.Size = New System.Drawing.Size(59, 23)
		Me.lblVisionTapeRData.TabIndex = 217
		'
		'lblVisionTapeYData
		'
		Me.lblVisionTapeYData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblVisionTapeYData.Location = New System.Drawing.Point(70, 158)
		Me.lblVisionTapeYData.Name = "lblVisionTapeYData"
		Me.lblVisionTapeYData.Size = New System.Drawing.Size(59, 23)
		Me.lblVisionTapeYData.TabIndex = 216
		'
		'lblVisionTapeXData
		'
		Me.lblVisionTapeXData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblVisionTapeXData.Location = New System.Drawing.Point(10, 158)
		Me.lblVisionTapeXData.Name = "lblVisionTapeXData"
		Me.lblVisionTapeXData.Size = New System.Drawing.Size(59, 23)
		Me.lblVisionTapeXData.TabIndex = 215
		'
		'chkLocateBracketTape
		'
		Me.chkLocateBracketTape.BackColor = System.Drawing.SystemColors.Control
		Me.chkLocateBracketTape.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkLocateBracketTape.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkLocateBracketTape.ForeColor = System.Drawing.SystemColors.Highlight
		Me.chkLocateBracketTape.Location = New System.Drawing.Point(231, 62)
		Me.chkLocateBracketTape.Name = "chkLocateBracketTape"
		Me.chkLocateBracketTape.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkLocateBracketTape.Size = New System.Drawing.Size(66, 24)
		Me.chkLocateBracketTape.TabIndex = 60
		Me.chkLocateBracketTape.TabStop = False
		Me.chkLocateBracketTape.Text = "Repeat"
		Me.chkLocateBracketTape.UseVisualStyleBackColor = False
		'
		'lblVisionTapeX
		'
		Me.lblVisionTapeX.BackColor = System.Drawing.SystemColors.Control
		Me.lblVisionTapeX.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblVisionTapeX.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblVisionTapeX.ForeColor = System.Drawing.SystemColors.Highlight
		Me.lblVisionTapeX.Location = New System.Drawing.Point(28, 139)
		Me.lblVisionTapeX.Name = "lblVisionTapeX"
		Me.lblVisionTapeX.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblVisionTapeX.Size = New System.Drawing.Size(34, 17)
		Me.lblVisionTapeX.TabIndex = 214
		Me.lblVisionTapeX.Text = "X"
		'
		'lblVisionTapeY
		'
		Me.lblVisionTapeY.BackColor = System.Drawing.SystemColors.Control
		Me.lblVisionTapeY.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblVisionTapeY.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblVisionTapeY.ForeColor = System.Drawing.SystemColors.Highlight
		Me.lblVisionTapeY.Location = New System.Drawing.Point(88, 139)
		Me.lblVisionTapeY.Name = "lblVisionTapeY"
		Me.lblVisionTapeY.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblVisionTapeY.Size = New System.Drawing.Size(34, 17)
		Me.lblVisionTapeY.TabIndex = 213
		Me.lblVisionTapeY.Text = "Y"
		'
		'lblVisionTapeR
		'
		Me.lblVisionTapeR.BackColor = System.Drawing.SystemColors.Control
		Me.lblVisionTapeR.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblVisionTapeR.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblVisionTapeR.ForeColor = System.Drawing.SystemColors.Highlight
		Me.lblVisionTapeR.Location = New System.Drawing.Point(139, 139)
		Me.lblVisionTapeR.Name = "lblVisionTapeR"
		Me.lblVisionTapeR.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblVisionTapeR.Size = New System.Drawing.Size(50, 17)
		Me.lblVisionTapeR.TabIndex = 212
		Me.lblVisionTapeR.Text = "Angle"
		'
		'lblLocateTimeBracketTape
		'
		Me.lblLocateTimeBracketTape.BackColor = System.Drawing.SystemColors.Control
		Me.lblLocateTimeBracketTape.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblLocateTimeBracketTape.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblLocateTimeBracketTape.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblLocateTimeBracketTape.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblLocateTimeBracketTape.Location = New System.Drawing.Point(209, 32)
		Me.lblLocateTimeBracketTape.Name = "lblLocateTimeBracketTape"
		Me.lblLocateTimeBracketTape.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblLocateTimeBracketTape.Size = New System.Drawing.Size(55, 18)
		Me.lblLocateTimeBracketTape.TabIndex = 67
		'
		'lblVisionTapeTime
		'
		Me.lblVisionTapeTime.BackColor = System.Drawing.SystemColors.Control
		Me.lblVisionTapeTime.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblVisionTapeTime.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblVisionTapeTime.ForeColor = System.Drawing.SystemColors.Highlight
		Me.lblVisionTapeTime.Location = New System.Drawing.Point(200, 139)
		Me.lblVisionTapeTime.Name = "lblVisionTapeTime"
		Me.lblVisionTapeTime.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblVisionTapeTime.Size = New System.Drawing.Size(50, 17)
		Me.lblVisionTapeTime.TabIndex = 211
		Me.lblVisionTapeTime.Text = "Time"
		'
		'lblLocatorTimeBracketTape
		'
		Me.lblLocatorTimeBracketTape.AutoSize = True
		Me.lblLocatorTimeBracketTape.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblLocatorTimeBracketTape.ForeColor = System.Drawing.SystemColors.Desktop
		Me.lblLocatorTimeBracketTape.Location = New System.Drawing.Point(174, 33)
		Me.lblLocatorTimeBracketTape.Name = "lblLocatorTimeBracketTape"
		Me.lblLocatorTimeBracketTape.Size = New System.Drawing.Size(29, 14)
		Me.lblLocatorTimeBracketTape.TabIndex = 157
		Me.lblLocatorTimeBracketTape.Text = "Time"
		'
		'lblVisionTapeScore
		'
		Me.lblVisionTapeScore.BackColor = System.Drawing.SystemColors.Control
		Me.lblVisionTapeScore.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblVisionTapeScore.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblVisionTapeScore.ForeColor = System.Drawing.SystemColors.Highlight
		Me.lblVisionTapeScore.Location = New System.Drawing.Point(259, 139)
		Me.lblVisionTapeScore.Name = "lblVisionTapeScore"
		Me.lblVisionTapeScore.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblVisionTapeScore.Size = New System.Drawing.Size(50, 17)
		Me.lblVisionTapeScore.TabIndex = 210
		Me.lblVisionTapeScore.Text = "Score"
		'
		'grpHSDisplayBracketTape
		'
		Me.grpHSDisplayBracketTape.Controls.Add(Me.HSDisplayBracketTape)
		Me.grpHSDisplayBracketTape.Location = New System.Drawing.Point(6, 209)
		Me.grpHSDisplayBracketTape.Name = "grpHSDisplayBracketTape"
		Me.grpHSDisplayBracketTape.Size = New System.Drawing.Size(908, 714)
		Me.grpHSDisplayBracketTape.TabIndex = 1
		Me.grpHSDisplayBracketTape.TabStop = False
		'
		'HSDisplayBracketTape
		'
		Me.HSDisplayBracketTape.Enabled = True
		Me.HSDisplayBracketTape.Location = New System.Drawing.Point(6, 96)
		Me.HSDisplayBracketTape.Name = "HSDisplayBracketTape"
		Me.HSDisplayBracketTape.OcxState = CType(resources.GetObject("HSDisplayBracketTape.OcxState"), System.Windows.Forms.AxHost.State)
		Me.HSDisplayBracketTape.Size = New System.Drawing.Size(891, 578)
		Me.HSDisplayBracketTape.TabIndex = 82
		'
		'tabpageBracketPrimerVerify
		'
		Me.tabpageBracketPrimerVerify.BackColor = System.Drawing.SystemColors.Control
		Me.tabpageBracketPrimerVerify.Controls.Add(Me.grpVisionBracketPrimer)
		Me.tabpageBracketPrimerVerify.Location = New System.Drawing.Point(4, 27)
		Me.tabpageBracketPrimerVerify.Name = "tabpageBracketPrimerVerify"
		Me.tabpageBracketPrimerVerify.Size = New System.Drawing.Size(1522, 927)
		Me.tabpageBracketPrimerVerify.TabIndex = 11
		Me.tabpageBracketPrimerVerify.Text = "Bracket - Verify Primer"
		'
		'grpVisionBracketPrimer
		'
		Me.grpVisionBracketPrimer.BackColor = System.Drawing.SystemColors.Control
		Me.grpVisionBracketPrimer.Controls.Add(Me.grpBracketPrimerReference)
		Me.grpVisionBracketPrimer.Controls.Add(Me.grpBracketPrimer)
		Me.grpVisionBracketPrimer.Controls.Add(Me.grpCameraControlPrimer)
		Me.grpVisionBracketPrimer.Controls.Add(Me.grpBracketPrimerCamera)
		Me.grpVisionBracketPrimer.Controls.Add(Me.grpStatusBracketLocatePrimer)
		Me.grpVisionBracketPrimer.Controls.Add(Me.grpLocatorControlsBracketPrimer)
		Me.grpVisionBracketPrimer.Controls.Add(Me.grpHSDisplayBracketPrimer)
		Me.grpVisionBracketPrimer.Location = New System.Drawing.Point(6, 4)
		Me.grpVisionBracketPrimer.Name = "grpVisionBracketPrimer"
		Me.grpVisionBracketPrimer.Size = New System.Drawing.Size(1522, 939)
		Me.grpVisionBracketPrimer.TabIndex = 2
		Me.grpVisionBracketPrimer.TabStop = False
		'
		'grpBracketPrimerReference
		'
		Me.grpBracketPrimerReference.Controls.Add(Me.lblBracketPrimerMeanValue)
		Me.grpBracketPrimerReference.Controls.Add(Me.btnTrainBracketPrimerReference)
		Me.grpBracketPrimerReference.Controls.Add(Me.btnSaveBracketPrimerReference)
		Me.grpBracketPrimerReference.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
		Me.grpBracketPrimerReference.ForeColor = System.Drawing.SystemColors.Highlight
		Me.grpBracketPrimerReference.Location = New System.Drawing.Point(1335, 15)
		Me.grpBracketPrimerReference.Name = "grpBracketPrimerReference"
		Me.grpBracketPrimerReference.Size = New System.Drawing.Size(172, 154)
		Me.grpBracketPrimerReference.TabIndex = 90
		Me.grpBracketPrimerReference.TabStop = False
		Me.grpBracketPrimerReference.Text = "Bracket Primer Reference"
		'
		'lblBracketPrimerMeanValue
		'
		Me.lblBracketPrimerMeanValue.AutoSize = True
		Me.lblBracketPrimerMeanValue.Location = New System.Drawing.Point(6, 126)
		Me.lblBracketPrimerMeanValue.Name = "lblBracketPrimerMeanValue"
		Me.lblBracketPrimerMeanValue.Size = New System.Drawing.Size(133, 14)
		Me.lblBracketPrimerMeanValue.TabIndex = 185
		Me.lblBracketPrimerMeanValue.Text = "Reference Mean Value:"
		'
		'grpBracketPrimer
		'
		Me.grpBracketPrimer.Controls.Add(Me.Label8)
		Me.grpBracketPrimer.Controls.Add(Me.Label7)
		Me.grpBracketPrimer.Controls.Add(Me.Label6)
		Me.grpBracketPrimer.Controls.Add(Me.Label2)
		Me.grpBracketPrimer.Controls.Add(Me.updnBracketPrimer5Deviation)
		Me.grpBracketPrimer.Controls.Add(Me.updnBracketPrimer4Deviation)
		Me.grpBracketPrimer.Controls.Add(Me.Label5)
		Me.grpBracketPrimer.Controls.Add(Me.btnSaveBracketPrimer5)
		Me.grpBracketPrimer.Controls.Add(Me.updnBracketPrimer3Deviation)
		Me.grpBracketPrimer.Controls.Add(Me.btnTrainBracketPrimer5)
		Me.grpBracketPrimer.Controls.Add(Me.btnSaveBracketPrimer4)
		Me.grpBracketPrimer.Controls.Add(Me.btnTrainBracketPrimer4)
		Me.grpBracketPrimer.Controls.Add(Me.btnSaveBracketPrimer3)
		Me.grpBracketPrimer.Controls.Add(Me.btnTrainBracketPrimer3)
		Me.grpBracketPrimer.Controls.Add(Me.btnSaveBracketPrimer2)
		Me.grpBracketPrimer.Controls.Add(Me.btnTrainBracketPrimer2)
		Me.grpBracketPrimer.Controls.Add(Me.btnSaveBracketPrimer1)
		Me.grpBracketPrimer.Controls.Add(Me.btnTrainBracketPrimer1)
		Me.grpBracketPrimer.Controls.Add(Me.updnBracketPrimer2Deviation)
		Me.grpBracketPrimer.Controls.Add(Me.updnBracketPrimer1Deviation)
		Me.grpBracketPrimer.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
		Me.grpBracketPrimer.ForeColor = System.Drawing.SystemColors.Highlight
		Me.grpBracketPrimer.Location = New System.Drawing.Point(947, 15)
		Me.grpBracketPrimer.Name = "grpBracketPrimer"
		Me.grpBracketPrimer.Size = New System.Drawing.Size(382, 154)
		Me.grpBracketPrimer.TabIndex = 89
		Me.grpBracketPrimer.TabStop = False
		Me.grpBracketPrimer.Text = "Bracket Primer Setup"
		'
		'Label8
		'
		Me.Label8.AutoSize = True
		Me.Label8.Location = New System.Drawing.Point(18, 134)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(98, 14)
		Me.Label8.TabIndex = 193
		Me.Label8.Text = "Primer Deviation"
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Location = New System.Drawing.Point(18, 106)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(98, 14)
		Me.Label7.TabIndex = 192
		Me.Label7.Text = "Primer Deviation"
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Location = New System.Drawing.Point(18, 76)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(98, 14)
		Me.Label6.TabIndex = 191
		Me.Label6.Text = "Primer Deviation"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(18, 47)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(98, 14)
		Me.Label2.TabIndex = 190
		Me.Label2.Text = "Primer Deviation"
		'
		'updnBracketPrimer5Deviation
		'
		Me.updnBracketPrimer5Deviation.Location = New System.Drawing.Point(122, 130)
		Me.updnBracketPrimer5Deviation.Maximum = New Decimal(New Integer() {200, 0, 0, 0})
		Me.updnBracketPrimer5Deviation.Minimum = New Decimal(New Integer() {50, 0, 0, -2147483648})
		Me.updnBracketPrimer5Deviation.Name = "updnBracketPrimer5Deviation"
		Me.updnBracketPrimer5Deviation.Size = New System.Drawing.Size(70, 20)
		Me.updnBracketPrimer5Deviation.TabIndex = 189
		Me.updnBracketPrimer5Deviation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.updnBracketPrimer5Deviation.Value = New Decimal(New Integer() {1, 0, 0, 0})
		'
		'updnBracketPrimer4Deviation
		'
		Me.updnBracketPrimer4Deviation.Location = New System.Drawing.Point(122, 103)
		Me.updnBracketPrimer4Deviation.Maximum = New Decimal(New Integer() {200, 0, 0, 0})
		Me.updnBracketPrimer4Deviation.Minimum = New Decimal(New Integer() {50, 0, 0, -2147483648})
		Me.updnBracketPrimer4Deviation.Name = "updnBracketPrimer4Deviation"
		Me.updnBracketPrimer4Deviation.Size = New System.Drawing.Size(70, 20)
		Me.updnBracketPrimer4Deviation.TabIndex = 188
		Me.updnBracketPrimer4Deviation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.updnBracketPrimer4Deviation.Value = New Decimal(New Integer() {1, 0, 0, 0})
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Location = New System.Drawing.Point(18, 18)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(98, 14)
		Me.Label5.TabIndex = 171
		Me.Label5.Text = "Primer Deviation"
		'
		'updnBracketPrimer3Deviation
		'
		Me.updnBracketPrimer3Deviation.Location = New System.Drawing.Point(122, 72)
		Me.updnBracketPrimer3Deviation.Maximum = New Decimal(New Integer() {200, 0, 0, 0})
		Me.updnBracketPrimer3Deviation.Minimum = New Decimal(New Integer() {50, 0, 0, -2147483648})
		Me.updnBracketPrimer3Deviation.Name = "updnBracketPrimer3Deviation"
		Me.updnBracketPrimer3Deviation.Size = New System.Drawing.Size(70, 20)
		Me.updnBracketPrimer3Deviation.TabIndex = 186
		Me.updnBracketPrimer3Deviation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.updnBracketPrimer3Deviation.Value = New Decimal(New Integer() {1, 0, 0, 0})
		'
		'updnBracketPrimer2Deviation
		'
		Me.updnBracketPrimer2Deviation.Location = New System.Drawing.Point(122, 43)
		Me.updnBracketPrimer2Deviation.Maximum = New Decimal(New Integer() {200, 0, 0, 0})
		Me.updnBracketPrimer2Deviation.Minimum = New Decimal(New Integer() {50, 0, 0, -2147483648})
		Me.updnBracketPrimer2Deviation.Name = "updnBracketPrimer2Deviation"
		Me.updnBracketPrimer2Deviation.Size = New System.Drawing.Size(70, 20)
		Me.updnBracketPrimer2Deviation.TabIndex = 170
		Me.updnBracketPrimer2Deviation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.updnBracketPrimer2Deviation.Value = New Decimal(New Integer() {1, 0, 0, 0})
		'
		'updnBracketPrimer1Deviation
		'
		Me.updnBracketPrimer1Deviation.Location = New System.Drawing.Point(122, 14)
		Me.updnBracketPrimer1Deviation.Maximum = New Decimal(New Integer() {200, 0, 0, 0})
		Me.updnBracketPrimer1Deviation.Minimum = New Decimal(New Integer() {50, 0, 0, -2147483648})
		Me.updnBracketPrimer1Deviation.Name = "updnBracketPrimer1Deviation"
		Me.updnBracketPrimer1Deviation.Size = New System.Drawing.Size(70, 20)
		Me.updnBracketPrimer1Deviation.TabIndex = 169
		Me.updnBracketPrimer1Deviation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.updnBracketPrimer1Deviation.Value = New Decimal(New Integer() {1, 0, 0, 0})
		'
		'grpCameraControlPrimer
		'
		Me.grpCameraControlPrimer.BackColor = System.Drawing.SystemColors.Control
		Me.grpCameraControlPrimer.Controls.Add(Me.lblCamControlAcqTimeBracketPrimerDesc)
		Me.grpCameraControlPrimer.Controls.Add(Me.lblContrastBracketPrimer)
		Me.grpCameraControlPrimer.Controls.Add(Me.lblExposureBracketPrimer)
		Me.grpCameraControlPrimer.Controls.Add(Me.updnContrastBracketPrimer)
		Me.grpCameraControlPrimer.Controls.Add(Me.updnExposureBracketPrimer)
		Me.grpCameraControlPrimer.Controls.Add(Me.btnSnapBracketPrimer)
		Me.grpCameraControlPrimer.Controls.Add(Me.chkSnapRepeatBracketPrimer)
		Me.grpCameraControlPrimer.Controls.Add(Me.lblCameraTimeBracketPrimer)
		Me.grpCameraControlPrimer.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.grpCameraControlPrimer.ForeColor = System.Drawing.SystemColors.Highlight
		Me.grpCameraControlPrimer.Location = New System.Drawing.Point(189, 15)
		Me.grpCameraControlPrimer.Name = "grpCameraControlPrimer"
		Me.grpCameraControlPrimer.Padding = New System.Windows.Forms.Padding(0)
		Me.grpCameraControlPrimer.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.grpCameraControlPrimer.Size = New System.Drawing.Size(187, 154)
		Me.grpCameraControlPrimer.TabIndex = 87
		Me.grpCameraControlPrimer.TabStop = False
		Me.grpCameraControlPrimer.Text = "Camera Controls"
		'
		'lblCamControlAcqTimeBracketPrimerDesc
		'
		Me.lblCamControlAcqTimeBracketPrimerDesc.AutoSize = True
		Me.lblCamControlAcqTimeBracketPrimerDesc.Location = New System.Drawing.Point(36, 54)
		Me.lblCamControlAcqTimeBracketPrimerDesc.Name = "lblCamControlAcqTimeBracketPrimerDesc"
		Me.lblCamControlAcqTimeBracketPrimerDesc.Size = New System.Drawing.Size(59, 14)
		Me.lblCamControlAcqTimeBracketPrimerDesc.TabIndex = 165
		Me.lblCamControlAcqTimeBracketPrimerDesc.Text = "Acq Time"
		'
		'lblContrastBracketPrimer
		'
		Me.lblContrastBracketPrimer.AutoSize = True
		Me.lblContrastBracketPrimer.Location = New System.Drawing.Point(40, 99)
		Me.lblContrastBracketPrimer.Name = "lblContrastBracketPrimer"
		Me.lblContrastBracketPrimer.Size = New System.Drawing.Size(55, 14)
		Me.lblContrastBracketPrimer.TabIndex = 148
		Me.lblContrastBracketPrimer.Text = "Contrast"
		'
		'lblExposureBracketPrimer
		'
		Me.lblExposureBracketPrimer.AutoSize = True
		Me.lblExposureBracketPrimer.Location = New System.Drawing.Point(36, 77)
		Me.lblExposureBracketPrimer.Name = "lblExposureBracketPrimer"
		Me.lblExposureBracketPrimer.Size = New System.Drawing.Size(59, 14)
		Me.lblExposureBracketPrimer.TabIndex = 146
		Me.lblExposureBracketPrimer.Text = "Exposure"
		'
		'updnContrastBracketPrimer
		'
		Me.updnContrastBracketPrimer.Increment = New Decimal(New Integer() {10, 0, 0, 0})
		Me.updnContrastBracketPrimer.Location = New System.Drawing.Point(101, 97)
		Me.updnContrastBracketPrimer.Name = "updnContrastBracketPrimer"
		Me.updnContrastBracketPrimer.Size = New System.Drawing.Size(49, 20)
		Me.updnContrastBracketPrimer.TabIndex = 145
		Me.updnContrastBracketPrimer.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
		Me.updnContrastBracketPrimer.Value = New Decimal(New Integer() {100, 0, 0, 65536})
		'
		'updnExposureBracketPrimer
		'
		Me.updnExposureBracketPrimer.Increment = New Decimal(New Integer() {25, 0, 0, 0})
		Me.updnExposureBracketPrimer.Location = New System.Drawing.Point(101, 75)
		Me.updnExposureBracketPrimer.Maximum = New Decimal(New Integer() {1500, 0, 0, 0})
		Me.updnExposureBracketPrimer.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
		Me.updnExposureBracketPrimer.Name = "updnExposureBracketPrimer"
		Me.updnExposureBracketPrimer.Size = New System.Drawing.Size(49, 20)
		Me.updnExposureBracketPrimer.TabIndex = 142
		Me.updnExposureBracketPrimer.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
		Me.updnExposureBracketPrimer.Value = New Decimal(New Integer() {10, 0, 0, 0})
		'
		'chkSnapRepeatBracketPrimer
		'
		Me.chkSnapRepeatBracketPrimer.BackColor = System.Drawing.SystemColors.Control
		Me.chkSnapRepeatBracketPrimer.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkSnapRepeatBracketPrimer.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkSnapRepeatBracketPrimer.ForeColor = System.Drawing.SystemColors.Highlight
		Me.chkSnapRepeatBracketPrimer.Location = New System.Drawing.Point(115, 14)
		Me.chkSnapRepeatBracketPrimer.Name = "chkSnapRepeatBracketPrimer"
		Me.chkSnapRepeatBracketPrimer.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkSnapRepeatBracketPrimer.Size = New System.Drawing.Size(62, 24)
		Me.chkSnapRepeatBracketPrimer.TabIndex = 72
		Me.chkSnapRepeatBracketPrimer.TabStop = False
		Me.chkSnapRepeatBracketPrimer.Text = "Repeat"
		Me.chkSnapRepeatBracketPrimer.UseVisualStyleBackColor = False
		'
		'lblCameraTimeBracketPrimer
		'
		Me.lblCameraTimeBracketPrimer.BackColor = System.Drawing.SystemColors.Control
		Me.lblCameraTimeBracketPrimer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblCameraTimeBracketPrimer.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblCameraTimeBracketPrimer.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCameraTimeBracketPrimer.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblCameraTimeBracketPrimer.Location = New System.Drawing.Point(101, 52)
		Me.lblCameraTimeBracketPrimer.Name = "lblCameraTimeBracketPrimer"
		Me.lblCameraTimeBracketPrimer.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblCameraTimeBracketPrimer.Size = New System.Drawing.Size(48, 18)
		Me.lblCameraTimeBracketPrimer.TabIndex = 75
		'
		'grpBracketPrimerCamera
		'
		Me.grpBracketPrimerCamera.Controls.Add(Me.Button1)
		Me.grpBracketPrimerCamera.Controls.Add(Me.lblBracketPrimerCameraWarning)
		Me.grpBracketPrimerCamera.Controls.Add(Me.lblTemperatureBracketPrimer)
		Me.grpBracketPrimerCamera.Controls.Add(Me.pbBracketPrimer)
		Me.grpBracketPrimerCamera.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
		Me.grpBracketPrimerCamera.ForeColor = System.Drawing.SystemColors.Highlight
		Me.grpBracketPrimerCamera.Location = New System.Drawing.Point(10, 15)
		Me.grpBracketPrimerCamera.Name = "grpBracketPrimerCamera"
		Me.grpBracketPrimerCamera.Size = New System.Drawing.Size(173, 154)
		Me.grpBracketPrimerCamera.TabIndex = 84
		Me.grpBracketPrimerCamera.TabStop = False
		Me.grpBracketPrimerCamera.Text = "Camera Status"
		'
		'Button1
		'
		Me.Button1.Location = New System.Drawing.Point(89, 97)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(75, 23)
		Me.Button1.TabIndex = 162
		Me.Button1.Text = "Button1"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'lblBracketPrimerCameraWarning
		'
		Me.lblBracketPrimerCameraWarning.AutoSize = True
		Me.lblBracketPrimerCameraWarning.Font = New System.Drawing.Font("Arial Black", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblBracketPrimerCameraWarning.ForeColor = System.Drawing.Color.DarkRed
		Me.lblBracketPrimerCameraWarning.Location = New System.Drawing.Point(37, 21)
		Me.lblBracketPrimerCameraWarning.Name = "lblBracketPrimerCameraWarning"
		Me.lblBracketPrimerCameraWarning.Size = New System.Drawing.Size(114, 51)
		Me.lblBracketPrimerCameraWarning.TabIndex = 161
		Me.lblBracketPrimerCameraWarning.Text = "       Warning! " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  The Camera is " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  not connected"
		Me.lblBracketPrimerCameraWarning.Visible = False
		'
		'lblTemperatureBracketPrimer
		'
		Me.lblTemperatureBracketPrimer.BackColor = System.Drawing.SystemColors.ButtonShadow
		Me.lblTemperatureBracketPrimer.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblTemperatureBracketPrimer.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblTemperatureBracketPrimer.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblTemperatureBracketPrimer.Location = New System.Drawing.Point(6, 97)
		Me.lblTemperatureBracketPrimer.Name = "lblTemperatureBracketPrimer"
		Me.lblTemperatureBracketPrimer.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblTemperatureBracketPrimer.Size = New System.Drawing.Size(39, 48)
		Me.lblTemperatureBracketPrimer.TabIndex = 160
		Me.lblTemperatureBracketPrimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'pbBracketPrimer
		'
		Me.pbBracketPrimer.Image = CType(resources.GetObject("pbBracketPrimer.Image"), System.Drawing.Image)
		Me.pbBracketPrimer.Location = New System.Drawing.Point(11, 32)
		Me.pbBracketPrimer.Name = "pbBracketPrimer"
		Me.pbBracketPrimer.Size = New System.Drawing.Size(25, 60)
		Me.pbBracketPrimer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.pbBracketPrimer.TabIndex = 159
		Me.pbBracketPrimer.TabStop = False
		'
		'grpStatusBracketLocatePrimer
		'
		Me.grpStatusBracketLocatePrimer.BackColor = System.Drawing.SystemColors.Control
		Me.grpStatusBracketLocatePrimer.Controls.Add(Me.lblFitBracketPrimer)
		Me.grpStatusBracketLocatePrimer.Controls.Add(Me.lblVisionPoseFirBracketPrimer)
		Me.grpStatusBracketLocatePrimer.Controls.Add(Me.lblVisionPoseFitBracketPrimer)
		Me.grpStatusBracketLocatePrimer.Controls.Add(Me.lblVisionPoseScoreBracketPrimer)
		Me.grpStatusBracketLocatePrimer.Controls.Add(Me.lblVisionPoseTimeBracketPrimer)
		Me.grpStatusBracketLocatePrimer.Controls.Add(Me.lblVisionPoseRBracketPrimer)
		Me.grpStatusBracketLocatePrimer.Controls.Add(Me.lblVisionPoseYBracketPrimer)
		Me.grpStatusBracketLocatePrimer.Controls.Add(Me.lblVisionPoseXBracketPrimer)
		Me.grpStatusBracketLocatePrimer.Controls.Add(Me.btnBracketPrimerDetails)
		Me.grpStatusBracketLocatePrimer.Controls.Add(Me.lblVisionMessageBracketPrimer)
		Me.grpStatusBracketLocatePrimer.Controls.Add(Me.lblVisionXBracketPrimer)
		Me.grpStatusBracketLocatePrimer.Controls.Add(Me.lblVisionYBracketPrimer)
		Me.grpStatusBracketLocatePrimer.Controls.Add(Me.lblVisionAngleBracketPrimer)
		Me.grpStatusBracketLocatePrimer.Controls.Add(Me.lblVisionTimeBracketPrimer)
		Me.grpStatusBracketLocatePrimer.Controls.Add(Me.lblVisionScoreBracketPrimer)
		Me.grpStatusBracketLocatePrimer.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.grpStatusBracketLocatePrimer.ForeColor = System.Drawing.SystemColors.Highlight
		Me.grpStatusBracketLocatePrimer.Location = New System.Drawing.Point(621, 15)
		Me.grpStatusBracketLocatePrimer.Name = "grpStatusBracketLocatePrimer"
		Me.grpStatusBracketLocatePrimer.Padding = New System.Windows.Forms.Padding(0)
		Me.grpStatusBracketLocatePrimer.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.grpStatusBracketLocatePrimer.Size = New System.Drawing.Size(320, 154)
		Me.grpStatusBracketLocatePrimer.TabIndex = 50
		Me.grpStatusBracketLocatePrimer.TabStop = False
		Me.grpStatusBracketLocatePrimer.Text = "Status"
		'
		'lblFitBracketPrimer
		'
		Me.lblFitBracketPrimer.BackColor = System.Drawing.SystemColors.Control
		Me.lblFitBracketPrimer.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblFitBracketPrimer.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblFitBracketPrimer.ForeColor = System.Drawing.SystemColors.Highlight
		Me.lblFitBracketPrimer.Location = New System.Drawing.Point(230, 66)
		Me.lblFitBracketPrimer.Name = "lblFitBracketPrimer"
		Me.lblFitBracketPrimer.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblFitBracketPrimer.Size = New System.Drawing.Size(10, 21)
		Me.lblFitBracketPrimer.TabIndex = 160
		Me.lblFitBracketPrimer.Text = ":"
		'
		'lblVisionPoseFirBracketPrimer
		'
		Me.lblVisionPoseFirBracketPrimer.BackColor = System.Drawing.SystemColors.Control
		Me.lblVisionPoseFirBracketPrimer.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblVisionPoseFirBracketPrimer.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblVisionPoseFirBracketPrimer.ForeColor = System.Drawing.SystemColors.Highlight
		Me.lblVisionPoseFirBracketPrimer.Location = New System.Drawing.Point(202, 67)
		Me.lblVisionPoseFirBracketPrimer.Name = "lblVisionPoseFirBracketPrimer"
		Me.lblVisionPoseFirBracketPrimer.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblVisionPoseFirBracketPrimer.Size = New System.Drawing.Size(20, 17)
		Me.lblVisionPoseFirBracketPrimer.TabIndex = 159
		Me.lblVisionPoseFirBracketPrimer.Text = "Fit"
		'
		'lblVisionPoseFitBracketPrimer
		'
		Me.lblVisionPoseFitBracketPrimer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblVisionPoseFitBracketPrimer.Location = New System.Drawing.Point(246, 64)
		Me.lblVisionPoseFitBracketPrimer.Name = "lblVisionPoseFitBracketPrimer"
		Me.lblVisionPoseFitBracketPrimer.Size = New System.Drawing.Size(62, 23)
		Me.lblVisionPoseFitBracketPrimer.TabIndex = 158
		'
		'lblVisionPoseScoreBracketPrimer
		'
		Me.lblVisionPoseScoreBracketPrimer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblVisionPoseScoreBracketPrimer.Location = New System.Drawing.Point(249, 114)
		Me.lblVisionPoseScoreBracketPrimer.Name = "lblVisionPoseScoreBracketPrimer"
		Me.lblVisionPoseScoreBracketPrimer.Size = New System.Drawing.Size(59, 23)
		Me.lblVisionPoseScoreBracketPrimer.TabIndex = 154
		'
		'lblVisionPoseTimeBracketPrimer
		'
		Me.lblVisionPoseTimeBracketPrimer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblVisionPoseTimeBracketPrimer.Location = New System.Drawing.Point(189, 114)
		Me.lblVisionPoseTimeBracketPrimer.Name = "lblVisionPoseTimeBracketPrimer"
		Me.lblVisionPoseTimeBracketPrimer.Size = New System.Drawing.Size(59, 23)
		Me.lblVisionPoseTimeBracketPrimer.TabIndex = 153
		'
		'lblVisionPoseRBracketPrimer
		'
		Me.lblVisionPoseRBracketPrimer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblVisionPoseRBracketPrimer.Location = New System.Drawing.Point(129, 114)
		Me.lblVisionPoseRBracketPrimer.Name = "lblVisionPoseRBracketPrimer"
		Me.lblVisionPoseRBracketPrimer.Size = New System.Drawing.Size(59, 23)
		Me.lblVisionPoseRBracketPrimer.TabIndex = 152
		'
		'lblVisionPoseYBracketPrimer
		'
		Me.lblVisionPoseYBracketPrimer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblVisionPoseYBracketPrimer.Location = New System.Drawing.Point(69, 114)
		Me.lblVisionPoseYBracketPrimer.Name = "lblVisionPoseYBracketPrimer"
		Me.lblVisionPoseYBracketPrimer.Size = New System.Drawing.Size(59, 23)
		Me.lblVisionPoseYBracketPrimer.TabIndex = 151
		'
		'lblVisionPoseXBracketPrimer
		'
		Me.lblVisionPoseXBracketPrimer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblVisionPoseXBracketPrimer.Location = New System.Drawing.Point(9, 114)
		Me.lblVisionPoseXBracketPrimer.Name = "lblVisionPoseXBracketPrimer"
		Me.lblVisionPoseXBracketPrimer.Size = New System.Drawing.Size(59, 23)
		Me.lblVisionPoseXBracketPrimer.TabIndex = 150
		'
		'lblVisionXBracketPrimer
		'
		Me.lblVisionXBracketPrimer.BackColor = System.Drawing.SystemColors.Control
		Me.lblVisionXBracketPrimer.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblVisionXBracketPrimer.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblVisionXBracketPrimer.ForeColor = System.Drawing.SystemColors.Highlight
		Me.lblVisionXBracketPrimer.Location = New System.Drawing.Point(27, 95)
		Me.lblVisionXBracketPrimer.Name = "lblVisionXBracketPrimer"
		Me.lblVisionXBracketPrimer.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblVisionXBracketPrimer.Size = New System.Drawing.Size(34, 17)
		Me.lblVisionXBracketPrimer.TabIndex = 55
		Me.lblVisionXBracketPrimer.Text = "X"
		'
		'lblVisionYBracketPrimer
		'
		Me.lblVisionYBracketPrimer.BackColor = System.Drawing.SystemColors.Control
		Me.lblVisionYBracketPrimer.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblVisionYBracketPrimer.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblVisionYBracketPrimer.ForeColor = System.Drawing.SystemColors.Highlight
		Me.lblVisionYBracketPrimer.Location = New System.Drawing.Point(87, 95)
		Me.lblVisionYBracketPrimer.Name = "lblVisionYBracketPrimer"
		Me.lblVisionYBracketPrimer.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblVisionYBracketPrimer.Size = New System.Drawing.Size(34, 17)
		Me.lblVisionYBracketPrimer.TabIndex = 54
		Me.lblVisionYBracketPrimer.Text = "Y"
		'
		'lblVisionAngleBracketPrimer
		'
		Me.lblVisionAngleBracketPrimer.BackColor = System.Drawing.SystemColors.Control
		Me.lblVisionAngleBracketPrimer.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblVisionAngleBracketPrimer.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblVisionAngleBracketPrimer.ForeColor = System.Drawing.SystemColors.Highlight
		Me.lblVisionAngleBracketPrimer.Location = New System.Drawing.Point(138, 95)
		Me.lblVisionAngleBracketPrimer.Name = "lblVisionAngleBracketPrimer"
		Me.lblVisionAngleBracketPrimer.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblVisionAngleBracketPrimer.Size = New System.Drawing.Size(50, 17)
		Me.lblVisionAngleBracketPrimer.TabIndex = 53
		Me.lblVisionAngleBracketPrimer.Text = "Angle"
		'
		'lblVisionTimeBracketPrimer
		'
		Me.lblVisionTimeBracketPrimer.BackColor = System.Drawing.SystemColors.Control
		Me.lblVisionTimeBracketPrimer.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblVisionTimeBracketPrimer.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblVisionTimeBracketPrimer.ForeColor = System.Drawing.SystemColors.Highlight
		Me.lblVisionTimeBracketPrimer.Location = New System.Drawing.Point(199, 95)
		Me.lblVisionTimeBracketPrimer.Name = "lblVisionTimeBracketPrimer"
		Me.lblVisionTimeBracketPrimer.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblVisionTimeBracketPrimer.Size = New System.Drawing.Size(50, 17)
		Me.lblVisionTimeBracketPrimer.TabIndex = 52
		Me.lblVisionTimeBracketPrimer.Text = "Time"
		'
		'lblVisionScoreBracketPrimer
		'
		Me.lblVisionScoreBracketPrimer.BackColor = System.Drawing.SystemColors.Control
		Me.lblVisionScoreBracketPrimer.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblVisionScoreBracketPrimer.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblVisionScoreBracketPrimer.ForeColor = System.Drawing.SystemColors.Highlight
		Me.lblVisionScoreBracketPrimer.Location = New System.Drawing.Point(258, 95)
		Me.lblVisionScoreBracketPrimer.Name = "lblVisionScoreBracketPrimer"
		Me.lblVisionScoreBracketPrimer.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblVisionScoreBracketPrimer.Size = New System.Drawing.Size(50, 17)
		Me.lblVisionScoreBracketPrimer.TabIndex = 50
		Me.lblVisionScoreBracketPrimer.Text = "Score"
		'
		'grpLocatorControlsBracketPrimer
		'
		Me.grpLocatorControlsBracketPrimer.BackColor = System.Drawing.SystemColors.Control
		Me.grpLocatorControlsBracketPrimer.Controls.Add(Me.lblScoreLimitBracketPrimer)
		Me.grpLocatorControlsBracketPrimer.Controls.Add(Me.btnLocateOnlyBracketPrimer)
		Me.grpLocatorControlsBracketPrimer.Controls.Add(Me.btnLocateBracketPrimer)
		Me.grpLocatorControlsBracketPrimer.Controls.Add(Me.updnScoreLimitBracketPrimer)
		Me.grpLocatorControlsBracketPrimer.Controls.Add(Me.chkLocateBracketPrimer)
		Me.grpLocatorControlsBracketPrimer.Controls.Add(Me.btnSearchSettingsBracketPrimer)
		Me.grpLocatorControlsBracketPrimer.Controls.Add(Me.btnTrainNewBracketPrimer)
		Me.grpLocatorControlsBracketPrimer.Controls.Add(Me.lblLocateTimeBracketPrimer)
		Me.grpLocatorControlsBracketPrimer.Controls.Add(Me.lblLocatorTime2)
		Me.grpLocatorControlsBracketPrimer.Controls.Add(Me.btnTrainExistingBracketPrimer)
		Me.grpLocatorControlsBracketPrimer.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.grpLocatorControlsBracketPrimer.ForeColor = System.Drawing.SystemColors.Highlight
		Me.grpLocatorControlsBracketPrimer.Location = New System.Drawing.Point(382, 15)
		Me.grpLocatorControlsBracketPrimer.Name = "grpLocatorControlsBracketPrimer"
		Me.grpLocatorControlsBracketPrimer.Padding = New System.Windows.Forms.Padding(0)
		Me.grpLocatorControlsBracketPrimer.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.grpLocatorControlsBracketPrimer.Size = New System.Drawing.Size(233, 154)
		Me.grpLocatorControlsBracketPrimer.TabIndex = 88
		Me.grpLocatorControlsBracketPrimer.TabStop = False
		Me.grpLocatorControlsBracketPrimer.Text = "Locator Controls"
		'
		'lblScoreLimitBracketPrimer
		'
		Me.lblScoreLimitBracketPrimer.AutoSize = True
		Me.lblScoreLimitBracketPrimer.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblScoreLimitBracketPrimer.ForeColor = System.Drawing.SystemColors.Desktop
		Me.lblScoreLimitBracketPrimer.Location = New System.Drawing.Point(128, 55)
		Me.lblScoreLimitBracketPrimer.Name = "lblScoreLimitBracketPrimer"
		Me.lblScoreLimitBracketPrimer.Size = New System.Drawing.Size(70, 14)
		Me.lblScoreLimitBracketPrimer.TabIndex = 158
		Me.lblScoreLimitBracketPrimer.Text = "Score Limit"
		'
		'chkLocateBracketPrimer
		'
		Me.chkLocateBracketPrimer.BackColor = System.Drawing.SystemColors.Control
		Me.chkLocateBracketPrimer.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkLocateBracketPrimer.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkLocateBracketPrimer.ForeColor = System.Drawing.SystemColors.Highlight
		Me.chkLocateBracketPrimer.Location = New System.Drawing.Point(123, 14)
		Me.chkLocateBracketPrimer.Name = "chkLocateBracketPrimer"
		Me.chkLocateBracketPrimer.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkLocateBracketPrimer.Size = New System.Drawing.Size(68, 24)
		Me.chkLocateBracketPrimer.TabIndex = 60
		Me.chkLocateBracketPrimer.TabStop = False
		Me.chkLocateBracketPrimer.Text = "Repeat"
		Me.chkLocateBracketPrimer.UseVisualStyleBackColor = False
		'
		'lblLocateTimeBracketPrimer
		'
		Me.lblLocateTimeBracketPrimer.BackColor = System.Drawing.SystemColors.Control
		Me.lblLocateTimeBracketPrimer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblLocateTimeBracketPrimer.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblLocateTimeBracketPrimer.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblLocateTimeBracketPrimer.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblLocateTimeBracketPrimer.Location = New System.Drawing.Point(51, 54)
		Me.lblLocateTimeBracketPrimer.Name = "lblLocateTimeBracketPrimer"
		Me.lblLocateTimeBracketPrimer.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblLocateTimeBracketPrimer.Size = New System.Drawing.Size(55, 18)
		Me.lblLocateTimeBracketPrimer.TabIndex = 67
		'
		'lblLocatorTime2
		'
		Me.lblLocatorTime2.AutoSize = True
		Me.lblLocatorTime2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblLocatorTime2.ForeColor = System.Drawing.SystemColors.Desktop
		Me.lblLocatorTime2.Location = New System.Drawing.Point(20, 56)
		Me.lblLocatorTime2.Name = "lblLocatorTime2"
		Me.lblLocatorTime2.Size = New System.Drawing.Size(29, 14)
		Me.lblLocatorTime2.TabIndex = 157
		Me.lblLocatorTime2.Text = "Time"
		'
		'grpHSDisplayBracketPrimer
		'
		Me.grpHSDisplayBracketPrimer.Controls.Add(Me.HSDisplayBracketPrimer)
		Me.grpHSDisplayBracketPrimer.Location = New System.Drawing.Point(6, 174)
		Me.grpHSDisplayBracketPrimer.Name = "grpHSDisplayBracketPrimer"
		Me.grpHSDisplayBracketPrimer.Size = New System.Drawing.Size(1502, 749)
		Me.grpHSDisplayBracketPrimer.TabIndex = 1
		Me.grpHSDisplayBracketPrimer.TabStop = False
		'
		'HSDisplayBracketPrimer
		'
		Me.HSDisplayBracketPrimer.Enabled = True
		Me.HSDisplayBracketPrimer.Location = New System.Drawing.Point(14, 22)
		Me.HSDisplayBracketPrimer.Name = "HSDisplayBracketPrimer"
		Me.HSDisplayBracketPrimer.OcxState = CType(resources.GetObject("HSDisplayBracketPrimer.OcxState"), System.Windows.Forms.AxHost.State)
		Me.HSDisplayBracketPrimer.Size = New System.Drawing.Size(468, 293)
		Me.HSDisplayBracketPrimer.TabIndex = 82
		'
		'tabpageBracketLocateAtConveyor
		'
		Me.tabpageBracketLocateAtConveyor.BackColor = System.Drawing.Color.Transparent
		Me.tabpageBracketLocateAtConveyor.Controls.Add(Me.grpVisionBracketLocateatConveyor)
		Me.tabpageBracketLocateAtConveyor.ForeColor = System.Drawing.Color.Maroon
		Me.tabpageBracketLocateAtConveyor.Location = New System.Drawing.Point(4, 27)
		Me.tabpageBracketLocateAtConveyor.Name = "tabpageBracketLocateAtConveyor"
		Me.tabpageBracketLocateAtConveyor.Size = New System.Drawing.Size(1522, 927)
		Me.tabpageBracketLocateAtConveyor.TabIndex = 8
		Me.tabpageBracketLocateAtConveyor.Text = "Bracket - Locate at Conveyor"
		'
		'grpVisionBracketLocateatConveyor
		'
		Me.grpVisionBracketLocateatConveyor.BackColor = System.Drawing.SystemColors.Control
		Me.grpVisionBracketLocateatConveyor.Controls.Add(Me.grpCameraControlLocateConveyor)
		Me.grpVisionBracketLocateatConveyor.Controls.Add(Me.grpLocatorControlsBracketConveyor)
		Me.grpVisionBracketLocateatConveyor.Controls.Add(Me.grpBrackConveyorCamera)
		Me.grpVisionBracketLocateatConveyor.Controls.Add(Me.grpStatusBracketLocateAtConveoyr)
		Me.grpVisionBracketLocateatConveyor.Controls.Add(Me.grpHSDisplayBracketConveyor)
		Me.grpVisionBracketLocateatConveyor.Location = New System.Drawing.Point(6, 4)
		Me.grpVisionBracketLocateatConveyor.Name = "grpVisionBracketLocateatConveyor"
		Me.grpVisionBracketLocateatConveyor.Size = New System.Drawing.Size(1522, 939)
		Me.grpVisionBracketLocateatConveyor.TabIndex = 0
		Me.grpVisionBracketLocateatConveyor.TabStop = False
		'
		'grpCameraControlLocateConveyor
		'
		Me.grpCameraControlLocateConveyor.BackColor = System.Drawing.SystemColors.Control
		Me.grpCameraControlLocateConveyor.Controls.Add(Me.lblCamControlAcqTimeBracketConveyor)
		Me.grpCameraControlLocateConveyor.Controls.Add(Me.lblContrastBracketConveyor)
		Me.grpCameraControlLocateConveyor.Controls.Add(Me.lblExposureBracketConveyor)
		Me.grpCameraControlLocateConveyor.Controls.Add(Me.updnContrastBracketConveyor)
		Me.grpCameraControlLocateConveyor.Controls.Add(Me.updnExposureBracketConveyor)
		Me.grpCameraControlLocateConveyor.Controls.Add(Me.btnSnapBracketConveyor)
		Me.grpCameraControlLocateConveyor.Controls.Add(Me.chkSnapRepeatBracketconveyor)
		Me.grpCameraControlLocateConveyor.Controls.Add(Me.lblCameraTimeBracketConveyor)
		Me.grpCameraControlLocateConveyor.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.grpCameraControlLocateConveyor.ForeColor = System.Drawing.SystemColors.Highlight
		Me.grpCameraControlLocateConveyor.Location = New System.Drawing.Point(189, 15)
		Me.grpCameraControlLocateConveyor.Name = "grpCameraControlLocateConveyor"
		Me.grpCameraControlLocateConveyor.Padding = New System.Windows.Forms.Padding(0)
		Me.grpCameraControlLocateConveyor.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.grpCameraControlLocateConveyor.Size = New System.Drawing.Size(187, 154)
		Me.grpCameraControlLocateConveyor.TabIndex = 68
		Me.grpCameraControlLocateConveyor.TabStop = False
		Me.grpCameraControlLocateConveyor.Text = "Camera Controls"
		'
		'lblCamControlAcqTimeBracketConveyor
		'
		Me.lblCamControlAcqTimeBracketConveyor.AutoSize = True
		Me.lblCamControlAcqTimeBracketConveyor.Location = New System.Drawing.Point(36, 54)
		Me.lblCamControlAcqTimeBracketConveyor.Name = "lblCamControlAcqTimeBracketConveyor"
		Me.lblCamControlAcqTimeBracketConveyor.Size = New System.Drawing.Size(59, 14)
		Me.lblCamControlAcqTimeBracketConveyor.TabIndex = 165
		Me.lblCamControlAcqTimeBracketConveyor.Text = "Acq Time"
		'
		'lblContrastBracketConveyor
		'
		Me.lblContrastBracketConveyor.AutoSize = True
		Me.lblContrastBracketConveyor.Location = New System.Drawing.Point(40, 99)
		Me.lblContrastBracketConveyor.Name = "lblContrastBracketConveyor"
		Me.lblContrastBracketConveyor.Size = New System.Drawing.Size(55, 14)
		Me.lblContrastBracketConveyor.TabIndex = 148
		Me.lblContrastBracketConveyor.Text = "Contrast"
		'
		'lblExposureBracketConveyor
		'
		Me.lblExposureBracketConveyor.AutoSize = True
		Me.lblExposureBracketConveyor.Location = New System.Drawing.Point(36, 77)
		Me.lblExposureBracketConveyor.Name = "lblExposureBracketConveyor"
		Me.lblExposureBracketConveyor.Size = New System.Drawing.Size(59, 14)
		Me.lblExposureBracketConveyor.TabIndex = 146
		Me.lblExposureBracketConveyor.Text = "Exposure"
		'
		'updnContrastBracketConveyor
		'
		Me.updnContrastBracketConveyor.Increment = New Decimal(New Integer() {10, 0, 0, 0})
		Me.updnContrastBracketConveyor.Location = New System.Drawing.Point(101, 97)
		Me.updnContrastBracketConveyor.Name = "updnContrastBracketConveyor"
		Me.updnContrastBracketConveyor.Size = New System.Drawing.Size(49, 20)
		Me.updnContrastBracketConveyor.TabIndex = 145
		Me.updnContrastBracketConveyor.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
		Me.updnContrastBracketConveyor.Value = New Decimal(New Integer() {100, 0, 0, 65536})
		'
		'updnExposureBracketConveyor
		'
		Me.updnExposureBracketConveyor.Increment = New Decimal(New Integer() {25, 0, 0, 0})
		Me.updnExposureBracketConveyor.Location = New System.Drawing.Point(101, 75)
		Me.updnExposureBracketConveyor.Maximum = New Decimal(New Integer() {1500, 0, 0, 0})
		Me.updnExposureBracketConveyor.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
		Me.updnExposureBracketConveyor.Name = "updnExposureBracketConveyor"
		Me.updnExposureBracketConveyor.Size = New System.Drawing.Size(49, 20)
		Me.updnExposureBracketConveyor.TabIndex = 142
		Me.updnExposureBracketConveyor.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
		Me.updnExposureBracketConveyor.Value = New Decimal(New Integer() {10, 0, 0, 0})
		'
		'chkSnapRepeatBracketconveyor
		'
		Me.chkSnapRepeatBracketconveyor.BackColor = System.Drawing.SystemColors.Control
		Me.chkSnapRepeatBracketconveyor.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkSnapRepeatBracketconveyor.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkSnapRepeatBracketconveyor.ForeColor = System.Drawing.SystemColors.Highlight
		Me.chkSnapRepeatBracketconveyor.Location = New System.Drawing.Point(115, 14)
		Me.chkSnapRepeatBracketconveyor.Name = "chkSnapRepeatBracketconveyor"
		Me.chkSnapRepeatBracketconveyor.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkSnapRepeatBracketconveyor.Size = New System.Drawing.Size(62, 24)
		Me.chkSnapRepeatBracketconveyor.TabIndex = 72
		Me.chkSnapRepeatBracketconveyor.TabStop = False
		Me.chkSnapRepeatBracketconveyor.Text = "Repeat"
		Me.chkSnapRepeatBracketconveyor.UseVisualStyleBackColor = False
		'
		'lblCameraTimeBracketConveyor
		'
		Me.lblCameraTimeBracketConveyor.BackColor = System.Drawing.SystemColors.Control
		Me.lblCameraTimeBracketConveyor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblCameraTimeBracketConveyor.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblCameraTimeBracketConveyor.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCameraTimeBracketConveyor.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblCameraTimeBracketConveyor.Location = New System.Drawing.Point(101, 52)
		Me.lblCameraTimeBracketConveyor.Name = "lblCameraTimeBracketConveyor"
		Me.lblCameraTimeBracketConveyor.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblCameraTimeBracketConveyor.Size = New System.Drawing.Size(48, 18)
		Me.lblCameraTimeBracketConveyor.TabIndex = 75
		'
		'grpLocatorControlsBracketConveyor
		'
		Me.grpLocatorControlsBracketConveyor.BackColor = System.Drawing.SystemColors.Control
		Me.grpLocatorControlsBracketConveyor.Controls.Add(Me.lblScoreLimitBracketconveyor)
		Me.grpLocatorControlsBracketConveyor.Controls.Add(Me.btnLocateOnlyBracketConveyor)
		Me.grpLocatorControlsBracketConveyor.Controls.Add(Me.btnLocateBracketConveyor)
		Me.grpLocatorControlsBracketConveyor.Controls.Add(Me.updnScoreLimitBracketconveyor)
		Me.grpLocatorControlsBracketConveyor.Controls.Add(Me.chkLocateBracketConveyor)
		Me.grpLocatorControlsBracketConveyor.Controls.Add(Me.btnSearchSettingsBracketConveyor)
		Me.grpLocatorControlsBracketConveyor.Controls.Add(Me.btnTrainNewBracketconveyor)
		Me.grpLocatorControlsBracketConveyor.Controls.Add(Me.lblLocateTimeBracketconveyor)
		Me.grpLocatorControlsBracketConveyor.Controls.Add(Me.lblLocatorTimeBracketConveyor)
		Me.grpLocatorControlsBracketConveyor.Controls.Add(Me.btnTrainExistingBracketConveyor)
		Me.grpLocatorControlsBracketConveyor.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.grpLocatorControlsBracketConveyor.ForeColor = System.Drawing.SystemColors.Highlight
		Me.grpLocatorControlsBracketConveyor.Location = New System.Drawing.Point(382, 15)
		Me.grpLocatorControlsBracketConveyor.Name = "grpLocatorControlsBracketConveyor"
		Me.grpLocatorControlsBracketConveyor.Padding = New System.Windows.Forms.Padding(0)
		Me.grpLocatorControlsBracketConveyor.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.grpLocatorControlsBracketConveyor.Size = New System.Drawing.Size(233, 154)
		Me.grpLocatorControlsBracketConveyor.TabIndex = 82
		Me.grpLocatorControlsBracketConveyor.TabStop = False
		Me.grpLocatorControlsBracketConveyor.Text = "Locator Controls"
		'
		'lblScoreLimitBracketconveyor
		'
		Me.lblScoreLimitBracketconveyor.AutoSize = True
		Me.lblScoreLimitBracketconveyor.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblScoreLimitBracketconveyor.ForeColor = System.Drawing.SystemColors.Desktop
		Me.lblScoreLimitBracketconveyor.Location = New System.Drawing.Point(128, 55)
		Me.lblScoreLimitBracketconveyor.Name = "lblScoreLimitBracketconveyor"
		Me.lblScoreLimitBracketconveyor.Size = New System.Drawing.Size(70, 14)
		Me.lblScoreLimitBracketconveyor.TabIndex = 158
		Me.lblScoreLimitBracketconveyor.Text = "Score Limit"
		'
		'chkLocateBracketConveyor
		'
		Me.chkLocateBracketConveyor.BackColor = System.Drawing.SystemColors.Control
		Me.chkLocateBracketConveyor.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkLocateBracketConveyor.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkLocateBracketConveyor.ForeColor = System.Drawing.SystemColors.Highlight
		Me.chkLocateBracketConveyor.Location = New System.Drawing.Point(123, 14)
		Me.chkLocateBracketConveyor.Name = "chkLocateBracketConveyor"
		Me.chkLocateBracketConveyor.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkLocateBracketConveyor.Size = New System.Drawing.Size(68, 24)
		Me.chkLocateBracketConveyor.TabIndex = 60
		Me.chkLocateBracketConveyor.TabStop = False
		Me.chkLocateBracketConveyor.Text = "Repeat"
		Me.chkLocateBracketConveyor.UseVisualStyleBackColor = False
		'
		'lblLocateTimeBracketconveyor
		'
		Me.lblLocateTimeBracketconveyor.BackColor = System.Drawing.SystemColors.Control
		Me.lblLocateTimeBracketconveyor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblLocateTimeBracketconveyor.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblLocateTimeBracketconveyor.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblLocateTimeBracketconveyor.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblLocateTimeBracketconveyor.Location = New System.Drawing.Point(51, 54)
		Me.lblLocateTimeBracketconveyor.Name = "lblLocateTimeBracketconveyor"
		Me.lblLocateTimeBracketconveyor.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblLocateTimeBracketconveyor.Size = New System.Drawing.Size(55, 18)
		Me.lblLocateTimeBracketconveyor.TabIndex = 67
		'
		'lblLocatorTimeBracketConveyor
		'
		Me.lblLocatorTimeBracketConveyor.AutoSize = True
		Me.lblLocatorTimeBracketConveyor.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblLocatorTimeBracketConveyor.ForeColor = System.Drawing.SystemColors.Desktop
		Me.lblLocatorTimeBracketConveyor.Location = New System.Drawing.Point(20, 56)
		Me.lblLocatorTimeBracketConveyor.Name = "lblLocatorTimeBracketConveyor"
		Me.lblLocatorTimeBracketConveyor.Size = New System.Drawing.Size(29, 14)
		Me.lblLocatorTimeBracketConveyor.TabIndex = 157
		Me.lblLocatorTimeBracketConveyor.Text = "Time"
		'
		'grpBrackConveyorCamera
		'
		Me.grpBrackConveyorCamera.Controls.Add(Me.lblBracketConveyorCameraWarning)
		Me.grpBrackConveyorCamera.Controls.Add(Me.lblTemperatureBracketAtConveyor)
		Me.grpBrackConveyorCamera.Controls.Add(Me.pbBracketConveyorCamera)
		Me.grpBrackConveyorCamera.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
		Me.grpBrackConveyorCamera.ForeColor = System.Drawing.SystemColors.Highlight
		Me.grpBrackConveyorCamera.Location = New System.Drawing.Point(10, 15)
		Me.grpBrackConveyorCamera.Name = "grpBrackConveyorCamera"
		Me.grpBrackConveyorCamera.Size = New System.Drawing.Size(173, 154)
		Me.grpBrackConveyorCamera.TabIndex = 84
		Me.grpBrackConveyorCamera.TabStop = False
		Me.grpBrackConveyorCamera.Text = "Camera Status"
		'
		'lblBracketConveyorCameraWarning
		'
		Me.lblBracketConveyorCameraWarning.AutoSize = True
		Me.lblBracketConveyorCameraWarning.Font = New System.Drawing.Font("Arial Black", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblBracketConveyorCameraWarning.ForeColor = System.Drawing.Color.DarkRed
		Me.lblBracketConveyorCameraWarning.Location = New System.Drawing.Point(37, 21)
		Me.lblBracketConveyorCameraWarning.Name = "lblBracketConveyorCameraWarning"
		Me.lblBracketConveyorCameraWarning.Size = New System.Drawing.Size(114, 51)
		Me.lblBracketConveyorCameraWarning.TabIndex = 161
		Me.lblBracketConveyorCameraWarning.Text = "       Warning! " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  The Camera is " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  not connected"
		Me.lblBracketConveyorCameraWarning.Visible = False
		'
		'lblTemperatureBracketAtConveyor
		'
		Me.lblTemperatureBracketAtConveyor.BackColor = System.Drawing.SystemColors.ButtonShadow
		Me.lblTemperatureBracketAtConveyor.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblTemperatureBracketAtConveyor.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblTemperatureBracketAtConveyor.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblTemperatureBracketAtConveyor.Location = New System.Drawing.Point(6, 97)
		Me.lblTemperatureBracketAtConveyor.Name = "lblTemperatureBracketAtConveyor"
		Me.lblTemperatureBracketAtConveyor.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblTemperatureBracketAtConveyor.Size = New System.Drawing.Size(39, 48)
		Me.lblTemperatureBracketAtConveyor.TabIndex = 160
		Me.lblTemperatureBracketAtConveyor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'pbBracketConveyorCamera
		'
		Me.pbBracketConveyorCamera.Image = CType(resources.GetObject("pbBracketConveyorCamera.Image"), System.Drawing.Image)
		Me.pbBracketConveyorCamera.Location = New System.Drawing.Point(11, 32)
		Me.pbBracketConveyorCamera.Name = "pbBracketConveyorCamera"
		Me.pbBracketConveyorCamera.Size = New System.Drawing.Size(25, 60)
		Me.pbBracketConveyorCamera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.pbBracketConveyorCamera.TabIndex = 159
		Me.pbBracketConveyorCamera.TabStop = False
		'
		'grpStatusBracketLocateAtConveoyr
		'
		Me.grpStatusBracketLocateAtConveoyr.BackColor = System.Drawing.SystemColors.Control
		Me.grpStatusBracketLocateAtConveoyr.Controls.Add(Me.lblFitBracketConveyor)
		Me.grpStatusBracketLocateAtConveoyr.Controls.Add(Me.lblVisionPoseFirBracketConveyor)
		Me.grpStatusBracketLocateAtConveoyr.Controls.Add(Me.lblVisionPoseFitBracketConveyor)
		Me.grpStatusBracketLocateAtConveoyr.Controls.Add(Me.lblVisionPoseScoreBracketConveyor)
		Me.grpStatusBracketLocateAtConveoyr.Controls.Add(Me.lblVisionPoseTimeBracketConveyor)
		Me.grpStatusBracketLocateAtConveoyr.Controls.Add(Me.lblVisionPoseRBracketConveyor)
		Me.grpStatusBracketLocateAtConveoyr.Controls.Add(Me.lblVisionPoseYBracketConveyor)
		Me.grpStatusBracketLocateAtConveoyr.Controls.Add(Me.lblVisionPoseXBracketConveyor)
		Me.grpStatusBracketLocateAtConveoyr.Controls.Add(Me.btnDetailsBracketConveyor)
		Me.grpStatusBracketLocateAtConveoyr.Controls.Add(Me.lblVisionMessageBracketConveyor)
		Me.grpStatusBracketLocateAtConveoyr.Controls.Add(Me.lblVisionXBracketConveyor)
		Me.grpStatusBracketLocateAtConveoyr.Controls.Add(Me.lblVisionYBracketConveyor)
		Me.grpStatusBracketLocateAtConveoyr.Controls.Add(Me.lblVisionAngleBracketConveyor)
		Me.grpStatusBracketLocateAtConveoyr.Controls.Add(Me.lblVisionTimeBracketConveyor)
		Me.grpStatusBracketLocateAtConveoyr.Controls.Add(Me.lblVisionScoreBracketConveyor)
		Me.grpStatusBracketLocateAtConveoyr.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.grpStatusBracketLocateAtConveoyr.ForeColor = System.Drawing.SystemColors.Highlight
		Me.grpStatusBracketLocateAtConveoyr.Location = New System.Drawing.Point(621, 15)
		Me.grpStatusBracketLocateAtConveoyr.Name = "grpStatusBracketLocateAtConveoyr"
		Me.grpStatusBracketLocateAtConveoyr.Padding = New System.Windows.Forms.Padding(0)
		Me.grpStatusBracketLocateAtConveoyr.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.grpStatusBracketLocateAtConveoyr.Size = New System.Drawing.Size(320, 154)
		Me.grpStatusBracketLocateAtConveoyr.TabIndex = 49
		Me.grpStatusBracketLocateAtConveoyr.TabStop = False
		Me.grpStatusBracketLocateAtConveoyr.Text = "Status"
		'
		'lblFitBracketConveyor
		'
		Me.lblFitBracketConveyor.BackColor = System.Drawing.SystemColors.Control
		Me.lblFitBracketConveyor.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblFitBracketConveyor.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblFitBracketConveyor.ForeColor = System.Drawing.SystemColors.Highlight
		Me.lblFitBracketConveyor.Location = New System.Drawing.Point(230, 66)
		Me.lblFitBracketConveyor.Name = "lblFitBracketConveyor"
		Me.lblFitBracketConveyor.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblFitBracketConveyor.Size = New System.Drawing.Size(10, 21)
		Me.lblFitBracketConveyor.TabIndex = 160
		Me.lblFitBracketConveyor.Text = ":"
		'
		'lblVisionPoseFirBracketConveyor
		'
		Me.lblVisionPoseFirBracketConveyor.BackColor = System.Drawing.SystemColors.Control
		Me.lblVisionPoseFirBracketConveyor.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblVisionPoseFirBracketConveyor.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblVisionPoseFirBracketConveyor.ForeColor = System.Drawing.SystemColors.Highlight
		Me.lblVisionPoseFirBracketConveyor.Location = New System.Drawing.Point(202, 67)
		Me.lblVisionPoseFirBracketConveyor.Name = "lblVisionPoseFirBracketConveyor"
		Me.lblVisionPoseFirBracketConveyor.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblVisionPoseFirBracketConveyor.Size = New System.Drawing.Size(20, 17)
		Me.lblVisionPoseFirBracketConveyor.TabIndex = 159
		Me.lblVisionPoseFirBracketConveyor.Text = "Fit"
		'
		'lblVisionPoseFitBracketConveyor
		'
		Me.lblVisionPoseFitBracketConveyor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblVisionPoseFitBracketConveyor.Location = New System.Drawing.Point(246, 64)
		Me.lblVisionPoseFitBracketConveyor.Name = "lblVisionPoseFitBracketConveyor"
		Me.lblVisionPoseFitBracketConveyor.Size = New System.Drawing.Size(62, 23)
		Me.lblVisionPoseFitBracketConveyor.TabIndex = 158
		'
		'lblVisionPoseScoreBracketConveyor
		'
		Me.lblVisionPoseScoreBracketConveyor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblVisionPoseScoreBracketConveyor.Location = New System.Drawing.Point(249, 114)
		Me.lblVisionPoseScoreBracketConveyor.Name = "lblVisionPoseScoreBracketConveyor"
		Me.lblVisionPoseScoreBracketConveyor.Size = New System.Drawing.Size(59, 23)
		Me.lblVisionPoseScoreBracketConveyor.TabIndex = 154
		'
		'lblVisionPoseTimeBracketConveyor
		'
		Me.lblVisionPoseTimeBracketConveyor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblVisionPoseTimeBracketConveyor.Location = New System.Drawing.Point(189, 114)
		Me.lblVisionPoseTimeBracketConveyor.Name = "lblVisionPoseTimeBracketConveyor"
		Me.lblVisionPoseTimeBracketConveyor.Size = New System.Drawing.Size(59, 23)
		Me.lblVisionPoseTimeBracketConveyor.TabIndex = 153
		'
		'lblVisionPoseRBracketConveyor
		'
		Me.lblVisionPoseRBracketConveyor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblVisionPoseRBracketConveyor.Location = New System.Drawing.Point(129, 114)
		Me.lblVisionPoseRBracketConveyor.Name = "lblVisionPoseRBracketConveyor"
		Me.lblVisionPoseRBracketConveyor.Size = New System.Drawing.Size(59, 23)
		Me.lblVisionPoseRBracketConveyor.TabIndex = 152
		'
		'lblVisionPoseYBracketConveyor
		'
		Me.lblVisionPoseYBracketConveyor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblVisionPoseYBracketConveyor.Location = New System.Drawing.Point(69, 114)
		Me.lblVisionPoseYBracketConveyor.Name = "lblVisionPoseYBracketConveyor"
		Me.lblVisionPoseYBracketConveyor.Size = New System.Drawing.Size(59, 23)
		Me.lblVisionPoseYBracketConveyor.TabIndex = 151
		'
		'lblVisionPoseXBracketConveyor
		'
		Me.lblVisionPoseXBracketConveyor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblVisionPoseXBracketConveyor.Location = New System.Drawing.Point(9, 114)
		Me.lblVisionPoseXBracketConveyor.Name = "lblVisionPoseXBracketConveyor"
		Me.lblVisionPoseXBracketConveyor.Size = New System.Drawing.Size(59, 23)
		Me.lblVisionPoseXBracketConveyor.TabIndex = 150
		'
		'lblVisionXBracketConveyor
		'
		Me.lblVisionXBracketConveyor.BackColor = System.Drawing.SystemColors.Control
		Me.lblVisionXBracketConveyor.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblVisionXBracketConveyor.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblVisionXBracketConveyor.ForeColor = System.Drawing.SystemColors.Highlight
		Me.lblVisionXBracketConveyor.Location = New System.Drawing.Point(27, 95)
		Me.lblVisionXBracketConveyor.Name = "lblVisionXBracketConveyor"
		Me.lblVisionXBracketConveyor.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblVisionXBracketConveyor.Size = New System.Drawing.Size(34, 17)
		Me.lblVisionXBracketConveyor.TabIndex = 55
		Me.lblVisionXBracketConveyor.Text = "X"
		'
		'lblVisionYBracketConveyor
		'
		Me.lblVisionYBracketConveyor.BackColor = System.Drawing.SystemColors.Control
		Me.lblVisionYBracketConveyor.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblVisionYBracketConveyor.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblVisionYBracketConveyor.ForeColor = System.Drawing.SystemColors.Highlight
		Me.lblVisionYBracketConveyor.Location = New System.Drawing.Point(87, 95)
		Me.lblVisionYBracketConveyor.Name = "lblVisionYBracketConveyor"
		Me.lblVisionYBracketConveyor.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblVisionYBracketConveyor.Size = New System.Drawing.Size(34, 17)
		Me.lblVisionYBracketConveyor.TabIndex = 54
		Me.lblVisionYBracketConveyor.Text = "Y"
		'
		'lblVisionAngleBracketConveyor
		'
		Me.lblVisionAngleBracketConveyor.BackColor = System.Drawing.SystemColors.Control
		Me.lblVisionAngleBracketConveyor.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblVisionAngleBracketConveyor.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblVisionAngleBracketConveyor.ForeColor = System.Drawing.SystemColors.Highlight
		Me.lblVisionAngleBracketConveyor.Location = New System.Drawing.Point(138, 95)
		Me.lblVisionAngleBracketConveyor.Name = "lblVisionAngleBracketConveyor"
		Me.lblVisionAngleBracketConveyor.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblVisionAngleBracketConveyor.Size = New System.Drawing.Size(50, 17)
		Me.lblVisionAngleBracketConveyor.TabIndex = 53
		Me.lblVisionAngleBracketConveyor.Text = "Angle"
		'
		'lblVisionTimeBracketConveyor
		'
		Me.lblVisionTimeBracketConveyor.BackColor = System.Drawing.SystemColors.Control
		Me.lblVisionTimeBracketConveyor.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblVisionTimeBracketConveyor.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblVisionTimeBracketConveyor.ForeColor = System.Drawing.SystemColors.Highlight
		Me.lblVisionTimeBracketConveyor.Location = New System.Drawing.Point(199, 95)
		Me.lblVisionTimeBracketConveyor.Name = "lblVisionTimeBracketConveyor"
		Me.lblVisionTimeBracketConveyor.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblVisionTimeBracketConveyor.Size = New System.Drawing.Size(50, 17)
		Me.lblVisionTimeBracketConveyor.TabIndex = 52
		Me.lblVisionTimeBracketConveyor.Text = "Time"
		'
		'lblVisionScoreBracketConveyor
		'
		Me.lblVisionScoreBracketConveyor.BackColor = System.Drawing.SystemColors.Control
		Me.lblVisionScoreBracketConveyor.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblVisionScoreBracketConveyor.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblVisionScoreBracketConveyor.ForeColor = System.Drawing.SystemColors.Highlight
		Me.lblVisionScoreBracketConveyor.Location = New System.Drawing.Point(258, 95)
		Me.lblVisionScoreBracketConveyor.Name = "lblVisionScoreBracketConveyor"
		Me.lblVisionScoreBracketConveyor.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblVisionScoreBracketConveyor.Size = New System.Drawing.Size(50, 17)
		Me.lblVisionScoreBracketConveyor.TabIndex = 50
		Me.lblVisionScoreBracketConveyor.Text = "Score"
		'
		'grpHSDisplayBracketConveyor
		'
		Me.grpHSDisplayBracketConveyor.Controls.Add(Me.HSDisplayBracketConveyor)
		Me.grpHSDisplayBracketConveyor.Location = New System.Drawing.Point(6, 174)
		Me.grpHSDisplayBracketConveyor.Name = "grpHSDisplayBracketConveyor"
		Me.grpHSDisplayBracketConveyor.Size = New System.Drawing.Size(1502, 745)
		Me.grpHSDisplayBracketConveyor.TabIndex = 0
		Me.grpHSDisplayBracketConveyor.TabStop = False
		'
		'HSDisplayBracketConveyor
		'
		Me.HSDisplayBracketConveyor.Enabled = True
		Me.HSDisplayBracketConveyor.Location = New System.Drawing.Point(14, 22)
		Me.HSDisplayBracketConveyor.Name = "HSDisplayBracketConveyor"
		Me.HSDisplayBracketConveyor.OcxState = CType(resources.GetObject("HSDisplayBracketConveyor.OcxState"), System.Windows.Forms.AxHost.State)
		Me.HSDisplayBracketConveyor.Size = New System.Drawing.Size(468, 293)
		Me.HSDisplayBracketConveyor.TabIndex = 82
		'
		'tabPageBracketLocate
		'
		Me.tabPageBracketLocate.Controls.Add(Me.grpVisionGlassLocate)
		Me.tabPageBracketLocate.Location = New System.Drawing.Point(4, 27)
		Me.tabPageBracketLocate.Name = "tabPageBracketLocate"
		Me.tabPageBracketLocate.Padding = New System.Windows.Forms.Padding(3)
		Me.tabPageBracketLocate.Size = New System.Drawing.Size(1522, 927)
		Me.tabPageBracketLocate.TabIndex = 1
		Me.tabPageBracketLocate.Text = "Locate Glass"
		Me.tabPageBracketLocate.UseVisualStyleBackColor = True
		'
		'grpVisionGlassLocate
		'
		Me.grpVisionGlassLocate.BackColor = System.Drawing.SystemColors.Control
		Me.grpVisionGlassLocate.Controls.Add(Me.grpCameraControl)
		Me.grpVisionGlassLocate.Controls.Add(Me.grpLocatorControls)
		Me.grpVisionGlassLocate.Controls.Add(Me.grpGlassLocate)
		Me.grpVisionGlassLocate.Controls.Add(Me.grpCameraStatus)
		Me.grpVisionGlassLocate.Controls.Add(Me.grpVisionStatus)
		Me.grpVisionGlassLocate.Controls.Add(Me.grpHSDisplayGlassLocation)
		Me.grpVisionGlassLocate.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.grpVisionGlassLocate.ForeColor = System.Drawing.SystemColors.ControlText
		Me.grpVisionGlassLocate.Location = New System.Drawing.Point(6, 4)
		Me.grpVisionGlassLocate.Name = "grpVisionGlassLocate"
		Me.grpVisionGlassLocate.Padding = New System.Windows.Forms.Padding(0)
		Me.grpVisionGlassLocate.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.grpVisionGlassLocate.Size = New System.Drawing.Size(1522, 939)
		Me.grpVisionGlassLocate.TabIndex = 50
		Me.grpVisionGlassLocate.TabStop = False
		'
		'grpCameraControl
		'
		Me.grpCameraControl.BackColor = System.Drawing.SystemColors.Control
		Me.grpCameraControl.Controls.Add(Me.lblCamControlAcqTime)
		Me.grpCameraControl.Controls.Add(Me.lblContrastValueWest)
		Me.grpCameraControl.Controls.Add(Me.lblBrightnessValueWest)
		Me.grpCameraControl.Controls.Add(Me.lblExposureValueWest)
		Me.grpCameraControl.Controls.Add(Me.lblContrast)
		Me.grpCameraControl.Controls.Add(Me.lblExposure)
		Me.grpCameraControl.Controls.Add(Me.updnContrastLocateGlass)
		Me.grpCameraControl.Controls.Add(Me.updnExposureLocateGlass)
		Me.grpCameraControl.Controls.Add(Me.btnSnapLocateGlass)
		Me.grpCameraControl.Controls.Add(Me.chkSnapRepeatLocateGlass)
		Me.grpCameraControl.Controls.Add(Me.lblCameraTime)
		Me.grpCameraControl.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.grpCameraControl.ForeColor = System.Drawing.SystemColors.Highlight
		Me.grpCameraControl.Location = New System.Drawing.Point(189, 15)
		Me.grpCameraControl.Name = "grpCameraControl"
		Me.grpCameraControl.Padding = New System.Windows.Forms.Padding(0)
		Me.grpCameraControl.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.grpCameraControl.Size = New System.Drawing.Size(187, 154)
		Me.grpCameraControl.TabIndex = 68
		Me.grpCameraControl.TabStop = False
		Me.grpCameraControl.Text = "Camera Controls"
		'
		'lblCamControlAcqTime
		'
		Me.lblCamControlAcqTime.AutoSize = True
		Me.lblCamControlAcqTime.Location = New System.Drawing.Point(36, 54)
		Me.lblCamControlAcqTime.Name = "lblCamControlAcqTime"
		Me.lblCamControlAcqTime.Size = New System.Drawing.Size(59, 14)
		Me.lblCamControlAcqTime.TabIndex = 165
		Me.lblCamControlAcqTime.Text = "Acq Time"
		'
		'lblContrastValueWest
		'
		Me.lblContrastValueWest.AutoSize = True
		Me.lblContrastValueWest.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblContrastValueWest.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblContrastValueWest.Location = New System.Drawing.Point(169, 116)
		Me.lblContrastValueWest.Name = "lblContrastValueWest"
		Me.lblContrastValueWest.Size = New System.Drawing.Size(0, 14)
		Me.lblContrastValueWest.TabIndex = 152
		'
		'lblBrightnessValueWest
		'
		Me.lblBrightnessValueWest.AutoSize = True
		Me.lblBrightnessValueWest.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblBrightnessValueWest.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblBrightnessValueWest.Location = New System.Drawing.Point(169, 83)
		Me.lblBrightnessValueWest.Name = "lblBrightnessValueWest"
		Me.lblBrightnessValueWest.Size = New System.Drawing.Size(0, 14)
		Me.lblBrightnessValueWest.TabIndex = 151
		'
		'lblExposureValueWest
		'
		Me.lblExposureValueWest.AutoSize = True
		Me.lblExposureValueWest.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblExposureValueWest.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblExposureValueWest.Location = New System.Drawing.Point(169, 56)
		Me.lblExposureValueWest.Name = "lblExposureValueWest"
		Me.lblExposureValueWest.Size = New System.Drawing.Size(0, 14)
		Me.lblExposureValueWest.TabIndex = 150
		'
		'lblContrast
		'
		Me.lblContrast.AutoSize = True
		Me.lblContrast.Location = New System.Drawing.Point(40, 99)
		Me.lblContrast.Name = "lblContrast"
		Me.lblContrast.Size = New System.Drawing.Size(55, 14)
		Me.lblContrast.TabIndex = 148
		Me.lblContrast.Text = "Contrast"
		'
		'lblExposure
		'
		Me.lblExposure.AutoSize = True
		Me.lblExposure.Location = New System.Drawing.Point(36, 77)
		Me.lblExposure.Name = "lblExposure"
		Me.lblExposure.Size = New System.Drawing.Size(59, 14)
		Me.lblExposure.TabIndex = 146
		Me.lblExposure.Text = "Exposure"
		'
		'updnContrastLocateGlass
		'
		Me.updnContrastLocateGlass.Increment = New Decimal(New Integer() {10, 0, 0, 0})
		Me.updnContrastLocateGlass.Location = New System.Drawing.Point(101, 97)
		Me.updnContrastLocateGlass.Name = "updnContrastLocateGlass"
		Me.updnContrastLocateGlass.Size = New System.Drawing.Size(49, 20)
		Me.updnContrastLocateGlass.TabIndex = 145
		Me.updnContrastLocateGlass.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
		Me.updnContrastLocateGlass.Value = New Decimal(New Integer() {100, 0, 0, 65536})
		'
		'updnExposureLocateGlass
		'
		Me.updnExposureLocateGlass.Increment = New Decimal(New Integer() {25, 0, 0, 0})
		Me.updnExposureLocateGlass.Location = New System.Drawing.Point(101, 75)
		Me.updnExposureLocateGlass.Maximum = New Decimal(New Integer() {1500, 0, 0, 0})
		Me.updnExposureLocateGlass.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
		Me.updnExposureLocateGlass.Name = "updnExposureLocateGlass"
		Me.updnExposureLocateGlass.Size = New System.Drawing.Size(49, 20)
		Me.updnExposureLocateGlass.TabIndex = 142
		Me.updnExposureLocateGlass.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
		Me.updnExposureLocateGlass.Value = New Decimal(New Integer() {10, 0, 0, 0})
		'
		'chkSnapRepeatLocateGlass
		'
		Me.chkSnapRepeatLocateGlass.BackColor = System.Drawing.SystemColors.Control
		Me.chkSnapRepeatLocateGlass.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkSnapRepeatLocateGlass.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkSnapRepeatLocateGlass.ForeColor = System.Drawing.SystemColors.Highlight
		Me.chkSnapRepeatLocateGlass.Location = New System.Drawing.Point(115, 14)
		Me.chkSnapRepeatLocateGlass.Name = "chkSnapRepeatLocateGlass"
		Me.chkSnapRepeatLocateGlass.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkSnapRepeatLocateGlass.Size = New System.Drawing.Size(62, 24)
		Me.chkSnapRepeatLocateGlass.TabIndex = 72
		Me.chkSnapRepeatLocateGlass.TabStop = False
		Me.chkSnapRepeatLocateGlass.Text = "Repeat"
		Me.chkSnapRepeatLocateGlass.UseVisualStyleBackColor = False
		'
		'lblCameraTime
		'
		Me.lblCameraTime.BackColor = System.Drawing.SystemColors.Control
		Me.lblCameraTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblCameraTime.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblCameraTime.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCameraTime.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblCameraTime.Location = New System.Drawing.Point(101, 52)
		Me.lblCameraTime.Name = "lblCameraTime"
		Me.lblCameraTime.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblCameraTime.Size = New System.Drawing.Size(48, 18)
		Me.lblCameraTime.TabIndex = 75
		'
		'grpLocatorControls
		'
		Me.grpLocatorControls.BackColor = System.Drawing.SystemColors.Control
		Me.grpLocatorControls.Controls.Add(Me.lblScoreLimit)
		Me.grpLocatorControls.Controls.Add(Me.btnLocateOnlyLocateGlass)
		Me.grpLocatorControls.Controls.Add(Me.btnLocateLocateGlass)
		Me.grpLocatorControls.Controls.Add(Me.updnScoreLimit)
		Me.grpLocatorControls.Controls.Add(Me.chkLocateRepeatLocateGlass)
		Me.grpLocatorControls.Controls.Add(Me.btnSearchSettingsLocateGlass)
		Me.grpLocatorControls.Controls.Add(Me.btnTrainNewLocateGlass)
		Me.grpLocatorControls.Controls.Add(Me.lblLocateTime)
		Me.grpLocatorControls.Controls.Add(Me.lblLocatorTime)
		Me.grpLocatorControls.Controls.Add(Me.btnTrainExistingLocateGlass)
		Me.grpLocatorControls.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.grpLocatorControls.ForeColor = System.Drawing.SystemColors.Highlight
		Me.grpLocatorControls.Location = New System.Drawing.Point(382, 15)
		Me.grpLocatorControls.Name = "grpLocatorControls"
		Me.grpLocatorControls.Padding = New System.Windows.Forms.Padding(0)
		Me.grpLocatorControls.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.grpLocatorControls.Size = New System.Drawing.Size(233, 154)
		Me.grpLocatorControls.TabIndex = 82
		Me.grpLocatorControls.TabStop = False
		Me.grpLocatorControls.Text = "Locator Controls"
		'
		'lblScoreLimit
		'
		Me.lblScoreLimit.AutoSize = True
		Me.lblScoreLimit.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblScoreLimit.ForeColor = System.Drawing.SystemColors.Desktop
		Me.lblScoreLimit.Location = New System.Drawing.Point(128, 55)
		Me.lblScoreLimit.Name = "lblScoreLimit"
		Me.lblScoreLimit.Size = New System.Drawing.Size(70, 14)
		Me.lblScoreLimit.TabIndex = 158
		Me.lblScoreLimit.Text = "Score Limit"
		'
		'chkLocateRepeatLocateGlass
		'
		Me.chkLocateRepeatLocateGlass.BackColor = System.Drawing.SystemColors.Control
		Me.chkLocateRepeatLocateGlass.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkLocateRepeatLocateGlass.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkLocateRepeatLocateGlass.ForeColor = System.Drawing.SystemColors.Highlight
		Me.chkLocateRepeatLocateGlass.Location = New System.Drawing.Point(123, 14)
		Me.chkLocateRepeatLocateGlass.Name = "chkLocateRepeatLocateGlass"
		Me.chkLocateRepeatLocateGlass.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkLocateRepeatLocateGlass.Size = New System.Drawing.Size(68, 24)
		Me.chkLocateRepeatLocateGlass.TabIndex = 60
		Me.chkLocateRepeatLocateGlass.TabStop = False
		Me.chkLocateRepeatLocateGlass.Text = "Repeat"
		Me.chkLocateRepeatLocateGlass.UseVisualStyleBackColor = False
		'
		'lblLocateTime
		'
		Me.lblLocateTime.BackColor = System.Drawing.SystemColors.Control
		Me.lblLocateTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblLocateTime.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblLocateTime.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblLocateTime.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblLocateTime.Location = New System.Drawing.Point(51, 54)
		Me.lblLocateTime.Name = "lblLocateTime"
		Me.lblLocateTime.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblLocateTime.Size = New System.Drawing.Size(55, 18)
		Me.lblLocateTime.TabIndex = 67
		'
		'lblLocatorTime
		'
		Me.lblLocatorTime.AutoSize = True
		Me.lblLocatorTime.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblLocatorTime.ForeColor = System.Drawing.SystemColors.Desktop
		Me.lblLocatorTime.Location = New System.Drawing.Point(20, 56)
		Me.lblLocatorTime.Name = "lblLocatorTime"
		Me.lblLocatorTime.Size = New System.Drawing.Size(29, 14)
		Me.lblLocatorTime.TabIndex = 157
		Me.lblLocatorTime.Text = "Time"
		'
		'grpGlassLocate
		'
		Me.grpGlassLocate.Controls.Add(Me.btnCalcAngle)
		Me.grpGlassLocate.Controls.Add(Me.lblPositionZ)
		Me.grpGlassLocate.Controls.Add(Me.updnLocationZ)
		Me.grpGlassLocate.Controls.Add(Me.lblPositionRDesc)
		Me.grpGlassLocate.Controls.Add(Me.btnDepositAdjRPlus)
		Me.grpGlassLocate.Controls.Add(Me.lblPositionRDescminus)
		Me.grpGlassLocate.Controls.Add(Me.btnLocationAdjOK)
		Me.grpGlassLocate.Controls.Add(Me.btnDepositAdjRMinus)
		Me.grpGlassLocate.Controls.Add(Me.btnLocationAdjCancel)
		Me.grpGlassLocate.Controls.Add(Me.btnDepositAdjYPlus)
		Me.grpGlassLocate.Controls.Add(Me.lblPositionRDeg)
		Me.grpGlassLocate.Controls.Add(Me.lblPositionYPlusDesc)
		Me.grpGlassLocate.Controls.Add(Me.updnLocationR)
		Me.grpGlassLocate.Controls.Add(Me.lblPositionXMMDesc)
		Me.grpGlassLocate.Controls.Add(Me.lblPositionYDesc)
		Me.grpGlassLocate.Controls.Add(Me.updnLocationY)
		Me.grpGlassLocate.Controls.Add(Me.btnDepositAdjYMinus)
		Me.grpGlassLocate.Controls.Add(Me.lblPositionModifyY)
		Me.grpGlassLocate.Controls.Add(Me.lblPositionModiftX)
		Me.grpGlassLocate.Controls.Add(Me.updnLocationX)
		Me.grpGlassLocate.Controls.Add(Me.btnDepositAdjXPlus)
		Me.grpGlassLocate.Controls.Add(Me.lblPositionModifyXMinus)
		Me.grpGlassLocate.Controls.Add(Me.btnDepositAdjXMinus)
		Me.grpGlassLocate.Location = New System.Drawing.Point(947, 15)
		Me.grpGlassLocate.Name = "grpGlassLocate"
		Me.grpGlassLocate.Size = New System.Drawing.Size(561, 154)
		Me.grpGlassLocate.TabIndex = 84
		Me.grpGlassLocate.TabStop = False
		'
		'btnCalcAngle
		'
		Me.btnCalcAngle.Location = New System.Drawing.Point(9, 128)
		Me.btnCalcAngle.Name = "btnCalcAngle"
		Me.btnCalcAngle.Size = New System.Drawing.Size(95, 22)
		Me.btnCalcAngle.TabIndex = 231
		Me.btnCalcAngle.Text = "Calculate Angle"
		Me.btnCalcAngle.UseVisualStyleBackColor = True
		'
		'lblPositionZ
		'
		Me.lblPositionZ.AutoSize = True
		Me.lblPositionZ.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPositionZ.Location = New System.Drawing.Point(387, 56)
		Me.lblPositionZ.Name = "lblPositionZ"
		Me.lblPositionZ.Size = New System.Drawing.Size(43, 16)
		Me.lblPositionZ.TabIndex = 229
		Me.lblPositionZ.Text = "Z mm"
		'
		'lblPositionRDesc
		'
		Me.lblPositionRDesc.AutoSize = True
		Me.lblPositionRDesc.Font = New System.Drawing.Font("Arial Black", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPositionRDesc.Location = New System.Drawing.Point(9, 81)
		Me.lblPositionRDesc.Name = "lblPositionRDesc"
		Me.lblPositionRDesc.Size = New System.Drawing.Size(32, 22)
		Me.lblPositionRDesc.TabIndex = 202
		Me.lblPositionRDesc.Text = "+R"
		'
		'lblPositionRDescminus
		'
		Me.lblPositionRDescminus.AutoSize = True
		Me.lblPositionRDescminus.Font = New System.Drawing.Font("Arial Black", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPositionRDescminus.Location = New System.Drawing.Point(48, 81)
		Me.lblPositionRDescminus.Name = "lblPositionRDescminus"
		Me.lblPositionRDescminus.Size = New System.Drawing.Size(27, 22)
		Me.lblPositionRDescminus.TabIndex = 201
		Me.lblPositionRDescminus.Text = "-R"
		'
		'lblPositionRDeg
		'
		Me.lblPositionRDeg.AutoSize = True
		Me.lblPositionRDeg.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPositionRDeg.Location = New System.Drawing.Point(294, 99)
		Me.lblPositionRDeg.Name = "lblPositionRDeg"
		Me.lblPositionRDeg.Size = New System.Drawing.Size(45, 16)
		Me.lblPositionRDeg.TabIndex = 210
		Me.lblPositionRDeg.Text = "R deg"
		'
		'lblPositionYPlusDesc
		'
		Me.lblPositionYPlusDesc.AutoSize = True
		Me.lblPositionYPlusDesc.Font = New System.Drawing.Font("Arial Black", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPositionYPlusDesc.Location = New System.Drawing.Point(168, 6)
		Me.lblPositionYPlusDesc.Name = "lblPositionYPlusDesc"
		Me.lblPositionYPlusDesc.Size = New System.Drawing.Size(32, 22)
		Me.lblPositionYPlusDesc.TabIndex = 218
		Me.lblPositionYPlusDesc.Text = "+Y"
		'
		'lblPositionXMMDesc
		'
		Me.lblPositionXMMDesc.AutoSize = True
		Me.lblPositionXMMDesc.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPositionXMMDesc.Location = New System.Drawing.Point(293, 13)
		Me.lblPositionXMMDesc.Name = "lblPositionXMMDesc"
		Me.lblPositionXMMDesc.Size = New System.Drawing.Size(45, 16)
		Me.lblPositionXMMDesc.TabIndex = 208
		Me.lblPositionXMMDesc.Text = "X mm"
		'
		'lblPositionYDesc
		'
		Me.lblPositionYDesc.AutoSize = True
		Me.lblPositionYDesc.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPositionYDesc.Location = New System.Drawing.Point(293, 58)
		Me.lblPositionYDesc.Name = "lblPositionYDesc"
		Me.lblPositionYDesc.Size = New System.Drawing.Size(44, 16)
		Me.lblPositionYDesc.TabIndex = 209
		Me.lblPositionYDesc.Text = "Y mm"
		'
		'lblPositionModifyY
		'
		Me.lblPositionModifyY.AutoSize = True
		Me.lblPositionModifyY.Font = New System.Drawing.Font("Arial Black", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPositionModifyY.Location = New System.Drawing.Point(168, 116)
		Me.lblPositionModifyY.Name = "lblPositionModifyY"
		Me.lblPositionModifyY.Size = New System.Drawing.Size(27, 22)
		Me.lblPositionModifyY.TabIndex = 216
		Me.lblPositionModifyY.Text = "-Y"
		'
		'lblPositionModiftX
		'
		Me.lblPositionModiftX.AutoSize = True
		Me.lblPositionModiftX.Font = New System.Drawing.Font("Arial Black", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPositionModiftX.Location = New System.Drawing.Point(248, 56)
		Me.lblPositionModiftX.Name = "lblPositionModiftX"
		Me.lblPositionModiftX.Size = New System.Drawing.Size(32, 22)
		Me.lblPositionModiftX.TabIndex = 215
		Me.lblPositionModiftX.Text = "+X"
		'
		'lblPositionModifyXMinus
		'
		Me.lblPositionModifyXMinus.AutoSize = True
		Me.lblPositionModifyXMinus.Font = New System.Drawing.Font("Arial Black", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPositionModifyXMinus.Location = New System.Drawing.Point(84, 54)
		Me.lblPositionModifyXMinus.Name = "lblPositionModifyXMinus"
		Me.lblPositionModifyXMinus.Size = New System.Drawing.Size(27, 22)
		Me.lblPositionModifyXMinus.TabIndex = 217
		Me.lblPositionModifyXMinus.Text = "-X"
		'
		'grpCameraStatus
		'
		Me.grpCameraStatus.Controls.Add(Me.lblCameraStatus)
		Me.grpCameraStatus.Controls.Add(Me.lblTemperatureBracket)
		Me.grpCameraStatus.Controls.Add(Me.pctTemperature)
		Me.grpCameraStatus.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
		Me.grpCameraStatus.ForeColor = System.Drawing.SystemColors.Highlight
		Me.grpCameraStatus.Location = New System.Drawing.Point(10, 15)
		Me.grpCameraStatus.Name = "grpCameraStatus"
		Me.grpCameraStatus.Size = New System.Drawing.Size(173, 154)
		Me.grpCameraStatus.TabIndex = 83
		Me.grpCameraStatus.TabStop = False
		Me.grpCameraStatus.Text = "Camera Status"
		'
		'lblCameraStatus
		'
		Me.lblCameraStatus.AutoSize = True
		Me.lblCameraStatus.Font = New System.Drawing.Font("Arial Black", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCameraStatus.ForeColor = System.Drawing.Color.DarkRed
		Me.lblCameraStatus.Location = New System.Drawing.Point(37, 21)
		Me.lblCameraStatus.Name = "lblCameraStatus"
		Me.lblCameraStatus.Size = New System.Drawing.Size(114, 51)
		Me.lblCameraStatus.TabIndex = 161
		Me.lblCameraStatus.Text = "       Warning! " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  The Camera is " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  not connected"
		Me.lblCameraStatus.Visible = False
		'
		'lblTemperatureBracket
		'
		Me.lblTemperatureBracket.BackColor = System.Drawing.SystemColors.ButtonShadow
		Me.lblTemperatureBracket.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblTemperatureBracket.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblTemperatureBracket.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblTemperatureBracket.Location = New System.Drawing.Point(6, 97)
		Me.lblTemperatureBracket.Name = "lblTemperatureBracket"
		Me.lblTemperatureBracket.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblTemperatureBracket.Size = New System.Drawing.Size(39, 48)
		Me.lblTemperatureBracket.TabIndex = 160
		Me.lblTemperatureBracket.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'pctTemperature
		'
		Me.pctTemperature.Image = CType(resources.GetObject("pctTemperature.Image"), System.Drawing.Image)
		Me.pctTemperature.Location = New System.Drawing.Point(11, 32)
		Me.pctTemperature.Name = "pctTemperature"
		Me.pctTemperature.Size = New System.Drawing.Size(25, 60)
		Me.pctTemperature.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.pctTemperature.TabIndex = 159
		Me.pctTemperature.TabStop = False
		'
		'grpVisionStatus
		'
		Me.grpVisionStatus.BackColor = System.Drawing.SystemColors.Control
		Me.grpVisionStatus.Controls.Add(Me.lblFitBracket)
		Me.grpVisionStatus.Controls.Add(Me.lblVisionPoseFirBracket)
		Me.grpVisionStatus.Controls.Add(Me.lblVisionPoseFitBracket)
		Me.grpVisionStatus.Controls.Add(Me.lblVisionPoseScoreBracket)
		Me.grpVisionStatus.Controls.Add(Me.lblVisionPoseTimeBracket)
		Me.grpVisionStatus.Controls.Add(Me.lblVisionPoseRBracket)
		Me.grpVisionStatus.Controls.Add(Me.lblVisionPoseYBracket)
		Me.grpVisionStatus.Controls.Add(Me.lblVisionPoseXBracket)
		Me.grpVisionStatus.Controls.Add(Me.btnDetailsBracket)
		Me.grpVisionStatus.Controls.Add(Me.lblVisionMessageBracket)
		Me.grpVisionStatus.Controls.Add(Me.lblVisionXBracket)
		Me.grpVisionStatus.Controls.Add(Me.lblVisionYBracket)
		Me.grpVisionStatus.Controls.Add(Me.lblVisionAngleBracket)
		Me.grpVisionStatus.Controls.Add(Me.lblVisionTimeBracket)
		Me.grpVisionStatus.Controls.Add(Me.lblVisionScoreBracket)
		Me.grpVisionStatus.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.grpVisionStatus.ForeColor = System.Drawing.SystemColors.Highlight
		Me.grpVisionStatus.Location = New System.Drawing.Point(621, 15)
		Me.grpVisionStatus.Name = "grpVisionStatus"
		Me.grpVisionStatus.Padding = New System.Windows.Forms.Padding(0)
		Me.grpVisionStatus.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.grpVisionStatus.Size = New System.Drawing.Size(320, 154)
		Me.grpVisionStatus.TabIndex = 48
		Me.grpVisionStatus.TabStop = False
		Me.grpVisionStatus.Text = "Status"
		'
		'lblFitBracket
		'
		Me.lblFitBracket.BackColor = System.Drawing.SystemColors.Control
		Me.lblFitBracket.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblFitBracket.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblFitBracket.ForeColor = System.Drawing.SystemColors.Highlight
		Me.lblFitBracket.Location = New System.Drawing.Point(230, 66)
		Me.lblFitBracket.Name = "lblFitBracket"
		Me.lblFitBracket.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblFitBracket.Size = New System.Drawing.Size(10, 21)
		Me.lblFitBracket.TabIndex = 160
		Me.lblFitBracket.Text = ":"
		'
		'lblVisionPoseFirBracket
		'
		Me.lblVisionPoseFirBracket.BackColor = System.Drawing.SystemColors.Control
		Me.lblVisionPoseFirBracket.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblVisionPoseFirBracket.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblVisionPoseFirBracket.ForeColor = System.Drawing.SystemColors.Highlight
		Me.lblVisionPoseFirBracket.Location = New System.Drawing.Point(202, 67)
		Me.lblVisionPoseFirBracket.Name = "lblVisionPoseFirBracket"
		Me.lblVisionPoseFirBracket.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblVisionPoseFirBracket.Size = New System.Drawing.Size(20, 17)
		Me.lblVisionPoseFirBracket.TabIndex = 159
		Me.lblVisionPoseFirBracket.Text = "Fit"
		'
		'lblVisionPoseFitBracket
		'
		Me.lblVisionPoseFitBracket.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblVisionPoseFitBracket.Location = New System.Drawing.Point(246, 64)
		Me.lblVisionPoseFitBracket.Name = "lblVisionPoseFitBracket"
		Me.lblVisionPoseFitBracket.Size = New System.Drawing.Size(62, 23)
		Me.lblVisionPoseFitBracket.TabIndex = 158
		'
		'lblVisionPoseScoreBracket
		'
		Me.lblVisionPoseScoreBracket.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblVisionPoseScoreBracket.Location = New System.Drawing.Point(249, 114)
		Me.lblVisionPoseScoreBracket.Name = "lblVisionPoseScoreBracket"
		Me.lblVisionPoseScoreBracket.Size = New System.Drawing.Size(59, 23)
		Me.lblVisionPoseScoreBracket.TabIndex = 154
		'
		'lblVisionPoseTimeBracket
		'
		Me.lblVisionPoseTimeBracket.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblVisionPoseTimeBracket.Location = New System.Drawing.Point(189, 114)
		Me.lblVisionPoseTimeBracket.Name = "lblVisionPoseTimeBracket"
		Me.lblVisionPoseTimeBracket.Size = New System.Drawing.Size(59, 23)
		Me.lblVisionPoseTimeBracket.TabIndex = 153
		'
		'lblVisionPoseRBracket
		'
		Me.lblVisionPoseRBracket.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblVisionPoseRBracket.Location = New System.Drawing.Point(129, 114)
		Me.lblVisionPoseRBracket.Name = "lblVisionPoseRBracket"
		Me.lblVisionPoseRBracket.Size = New System.Drawing.Size(59, 23)
		Me.lblVisionPoseRBracket.TabIndex = 152
		'
		'lblVisionPoseYBracket
		'
		Me.lblVisionPoseYBracket.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblVisionPoseYBracket.Location = New System.Drawing.Point(69, 114)
		Me.lblVisionPoseYBracket.Name = "lblVisionPoseYBracket"
		Me.lblVisionPoseYBracket.Size = New System.Drawing.Size(59, 23)
		Me.lblVisionPoseYBracket.TabIndex = 151
		'
		'lblVisionPoseXBracket
		'
		Me.lblVisionPoseXBracket.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblVisionPoseXBracket.Location = New System.Drawing.Point(9, 114)
		Me.lblVisionPoseXBracket.Name = "lblVisionPoseXBracket"
		Me.lblVisionPoseXBracket.Size = New System.Drawing.Size(59, 23)
		Me.lblVisionPoseXBracket.TabIndex = 150
		'
		'lblVisionXBracket
		'
		Me.lblVisionXBracket.BackColor = System.Drawing.SystemColors.Control
		Me.lblVisionXBracket.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblVisionXBracket.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblVisionXBracket.ForeColor = System.Drawing.SystemColors.Highlight
		Me.lblVisionXBracket.Location = New System.Drawing.Point(27, 95)
		Me.lblVisionXBracket.Name = "lblVisionXBracket"
		Me.lblVisionXBracket.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblVisionXBracket.Size = New System.Drawing.Size(34, 17)
		Me.lblVisionXBracket.TabIndex = 55
		Me.lblVisionXBracket.Text = "X"
		'
		'lblVisionYBracket
		'
		Me.lblVisionYBracket.BackColor = System.Drawing.SystemColors.Control
		Me.lblVisionYBracket.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblVisionYBracket.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblVisionYBracket.ForeColor = System.Drawing.SystemColors.Highlight
		Me.lblVisionYBracket.Location = New System.Drawing.Point(87, 95)
		Me.lblVisionYBracket.Name = "lblVisionYBracket"
		Me.lblVisionYBracket.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblVisionYBracket.Size = New System.Drawing.Size(34, 17)
		Me.lblVisionYBracket.TabIndex = 54
		Me.lblVisionYBracket.Text = "Y"
		'
		'lblVisionAngleBracket
		'
		Me.lblVisionAngleBracket.BackColor = System.Drawing.SystemColors.Control
		Me.lblVisionAngleBracket.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblVisionAngleBracket.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblVisionAngleBracket.ForeColor = System.Drawing.SystemColors.Highlight
		Me.lblVisionAngleBracket.Location = New System.Drawing.Point(138, 95)
		Me.lblVisionAngleBracket.Name = "lblVisionAngleBracket"
		Me.lblVisionAngleBracket.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblVisionAngleBracket.Size = New System.Drawing.Size(50, 17)
		Me.lblVisionAngleBracket.TabIndex = 53
		Me.lblVisionAngleBracket.Text = "Angle"
		'
		'lblVisionTimeBracket
		'
		Me.lblVisionTimeBracket.BackColor = System.Drawing.SystemColors.Control
		Me.lblVisionTimeBracket.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblVisionTimeBracket.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblVisionTimeBracket.ForeColor = System.Drawing.SystemColors.Highlight
		Me.lblVisionTimeBracket.Location = New System.Drawing.Point(199, 95)
		Me.lblVisionTimeBracket.Name = "lblVisionTimeBracket"
		Me.lblVisionTimeBracket.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblVisionTimeBracket.Size = New System.Drawing.Size(50, 17)
		Me.lblVisionTimeBracket.TabIndex = 52
		Me.lblVisionTimeBracket.Text = "Time"
		'
		'lblVisionScoreBracket
		'
		Me.lblVisionScoreBracket.BackColor = System.Drawing.SystemColors.Control
		Me.lblVisionScoreBracket.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblVisionScoreBracket.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblVisionScoreBracket.ForeColor = System.Drawing.SystemColors.Highlight
		Me.lblVisionScoreBracket.Location = New System.Drawing.Point(258, 95)
		Me.lblVisionScoreBracket.Name = "lblVisionScoreBracket"
		Me.lblVisionScoreBracket.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblVisionScoreBracket.Size = New System.Drawing.Size(50, 17)
		Me.lblVisionScoreBracket.TabIndex = 50
		Me.lblVisionScoreBracket.Text = "Score"
		'
		'grpHSDisplayGlassLocation
		'
		Me.grpHSDisplayGlassLocation.BackColor = System.Drawing.SystemColors.Control
		Me.grpHSDisplayGlassLocation.Controls.Add(Me.HSDisplayLocateGlass)
		Me.grpHSDisplayGlassLocation.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.grpHSDisplayGlassLocation.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.grpHSDisplayGlassLocation.ForeColor = System.Drawing.SystemColors.ControlText
		Me.grpHSDisplayGlassLocation.Location = New System.Drawing.Point(6, 175)
		Me.grpHSDisplayGlassLocation.Name = "grpHSDisplayGlassLocation"
		Me.grpHSDisplayGlassLocation.Padding = New System.Windows.Forms.Padding(0)
		Me.grpHSDisplayGlassLocation.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.grpHSDisplayGlassLocation.Size = New System.Drawing.Size(1502, 743)
		Me.grpHSDisplayGlassLocation.TabIndex = 77
		Me.grpHSDisplayGlassLocation.TabStop = False
		'
		'HSDisplayLocateGlass
		'
		Me.HSDisplayLocateGlass.Enabled = True
		Me.HSDisplayLocateGlass.Location = New System.Drawing.Point(14, 22)
		Me.HSDisplayLocateGlass.Name = "HSDisplayLocateGlass"
		Me.HSDisplayLocateGlass.OcxState = CType(resources.GetObject("HSDisplayLocateGlass.OcxState"), System.Windows.Forms.AxHost.State)
		Me.HSDisplayLocateGlass.Size = New System.Drawing.Size(481, 290)
		Me.HSDisplayLocateGlass.TabIndex = 81
		'
		'tabPageCenterBracketVerify
		'
		Me.tabPageCenterBracketVerify.Controls.Add(Me.grpVisionCenterVerify)
		Me.tabPageCenterBracketVerify.Location = New System.Drawing.Point(4, 27)
		Me.tabPageCenterBracketVerify.Name = "tabPageCenterBracketVerify"
		Me.tabPageCenterBracketVerify.Size = New System.Drawing.Size(1522, 927)
		Me.tabPageCenterBracketVerify.TabIndex = 10
		Me.tabPageCenterBracketVerify.Text = "Locate Bracket on Glass"
		Me.tabPageCenterBracketVerify.UseVisualStyleBackColor = True
		'
		'grpVisionCenterVerify
		'
		Me.grpVisionCenterVerify.BackColor = System.Drawing.SystemColors.Control
		Me.grpVisionCenterVerify.Controls.Add(Me.grpGlassVerifyValues)
		Me.grpVisionCenterVerify.Controls.Add(Me.grpCameraControlBrackeyVerify)
		Me.grpVisionCenterVerify.Controls.Add(Me.grpCameraStatusVerify)
		Me.grpVisionCenterVerify.Controls.Add(Me.grpLocatorControlsBracketVerify)
		Me.grpVisionCenterVerify.Controls.Add(Me.grpVisionStatusVerify)
		Me.grpVisionCenterVerify.Controls.Add(Me.grpHSDisplayBracketVerify)
		Me.grpVisionCenterVerify.Location = New System.Drawing.Point(6, 4)
		Me.grpVisionCenterVerify.Name = "grpVisionCenterVerify"
		Me.grpVisionCenterVerify.Size = New System.Drawing.Size(1522, 933)
		Me.grpVisionCenterVerify.TabIndex = 80
		Me.grpVisionCenterVerify.TabStop = False
		'
		'grpGlassVerifyValues
		'
		Me.grpGlassVerifyValues.Controls.Add(Me.lblTopRight)
		Me.grpGlassVerifyValues.Controls.Add(Me.Label11)
		Me.grpGlassVerifyValues.Controls.Add(Me.lblBottomLeft)
		Me.grpGlassVerifyValues.Controls.Add(Me.lblLength)
		Me.grpGlassVerifyValues.Controls.Add(Me.lblBottomLeftDifference)
		Me.grpGlassVerifyValues.Controls.Add(Me.lblTopRighttDifference)
		Me.grpGlassVerifyValues.Controls.Add(Me.lblBottomRightDifference)
		Me.grpGlassVerifyValues.Controls.Add(Me.Label10)
		Me.grpGlassVerifyValues.Controls.Add(Me.txtVerifySavedDiffTopRight)
		Me.grpGlassVerifyValues.Controls.Add(Me.btnSaveVerifyDifference)
		Me.grpGlassVerifyValues.Controls.Add(Me.txtVerifySavedDiffBottomRight)
		Me.grpGlassVerifyValues.Controls.Add(Me.txtVerifySavedDiffBottomLeft)
		Me.grpGlassVerifyValues.Controls.Add(Me.lblVerifyMasterLengths)
		Me.grpGlassVerifyValues.Controls.Add(Me.lblAllowedVariance)
		Me.grpGlassVerifyValues.Controls.Add(Me.updnTopRightVerifyVariance)
		Me.grpGlassVerifyValues.Controls.Add(Me.updnBottomRightVerifyVariance)
		Me.grpGlassVerifyValues.Controls.Add(Me.updnBottomLeftVerifyVariance)
		Me.grpGlassVerifyValues.Controls.Add(Me.lblVerifyTopRight)
		Me.grpGlassVerifyValues.Controls.Add(Me.lblVerifyBottomRight)
		Me.grpGlassVerifyValues.Controls.Add(Me.lblVerifyBottomLeft)
		Me.grpGlassVerifyValues.Location = New System.Drawing.Point(947, 15)
		Me.grpGlassVerifyValues.Name = "grpGlassVerifyValues"
		Me.grpGlassVerifyValues.Size = New System.Drawing.Size(561, 154)
		Me.grpGlassVerifyValues.TabIndex = 85
		Me.grpGlassVerifyValues.TabStop = False
		'
		'lblTopRight
		'
		Me.lblTopRight.AutoSize = True
		Me.lblTopRight.ForeColor = System.Drawing.SystemColors.Highlight
		Me.lblTopRight.Location = New System.Drawing.Point(38, 107)
		Me.lblTopRight.Name = "lblTopRight"
		Me.lblTopRight.Size = New System.Drawing.Size(68, 16)
		Me.lblTopRight.TabIndex = 25
		Me.lblTopRight.Text = "Top Right"
		'
		'Label11
		'
		Me.Label11.AutoSize = True
		Me.Label11.ForeColor = System.Drawing.SystemColors.Highlight
		Me.Label11.Location = New System.Drawing.Point(38, 75)
		Me.Label11.Name = "Label11"
		Me.Label11.Size = New System.Drawing.Size(90, 16)
		Me.Label11.TabIndex = 24
		Me.Label11.Text = "Bottom Right"
		'
		'lblBottomLeft
		'
		Me.lblBottomLeft.AutoSize = True
		Me.lblBottomLeft.ForeColor = System.Drawing.SystemColors.Highlight
		Me.lblBottomLeft.Location = New System.Drawing.Point(38, 47)
		Me.lblBottomLeft.Name = "lblBottomLeft"
		Me.lblBottomLeft.Size = New System.Drawing.Size(81, 16)
		Me.lblBottomLeft.TabIndex = 23
		Me.lblBottomLeft.Text = "Bottom Left"
		'
		'lblLength
		'
		Me.lblLength.AutoSize = True
		Me.lblLength.ForeColor = System.Drawing.SystemColors.Highlight
		Me.lblLength.Location = New System.Drawing.Point(135, 20)
		Me.lblLength.Name = "lblLength"
		Me.lblLength.Size = New System.Drawing.Size(52, 16)
		Me.lblLength.TabIndex = 22
		Me.lblLength.Text = "Length"
		'
		'lblBottomLeftDifference
		'
		Me.lblBottomLeftDifference.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.lblBottomLeftDifference.Location = New System.Drawing.Point(327, 45)
		Me.lblBottomLeftDifference.Name = "lblBottomLeftDifference"
		Me.lblBottomLeftDifference.Size = New System.Drawing.Size(75, 22)
		Me.lblBottomLeftDifference.TabIndex = 21
		Me.lblBottomLeftDifference.Text = "Not Found"
		'
		'lblTopRighttDifference
		'
		Me.lblTopRighttDifference.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.lblTopRighttDifference.Location = New System.Drawing.Point(327, 105)
		Me.lblTopRighttDifference.Name = "lblTopRighttDifference"
		Me.lblTopRighttDifference.Size = New System.Drawing.Size(75, 22)
		Me.lblTopRighttDifference.TabIndex = 20
		Me.lblTopRighttDifference.Text = "Not Found"
		'
		'lblBottomRightDifference
		'
		Me.lblBottomRightDifference.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.lblBottomRightDifference.Location = New System.Drawing.Point(327, 73)
		Me.lblBottomRightDifference.Name = "lblBottomRightDifference"
		Me.lblBottomRightDifference.Size = New System.Drawing.Size(75, 22)
		Me.lblBottomRightDifference.TabIndex = 19
		Me.lblBottomRightDifference.Text = "Not Found"
		'
		'Label10
		'
		Me.Label10.AutoSize = True
		Me.Label10.ForeColor = System.Drawing.SystemColors.Highlight
		Me.Label10.Location = New System.Drawing.Point(324, 21)
		Me.Label10.Name = "Label10"
		Me.Label10.Size = New System.Drawing.Size(73, 16)
		Me.Label10.TabIndex = 17
		Me.Label10.Text = "Difference"
		'
		'txtVerifySavedDiffTopRight
		'
		Me.txtVerifySavedDiffTopRight.Location = New System.Drawing.Point(231, 103)
		Me.txtVerifySavedDiffTopRight.Name = "txtVerifySavedDiffTopRight"
		Me.txtVerifySavedDiffTopRight.Size = New System.Drawing.Size(71, 22)
		Me.txtVerifySavedDiffTopRight.TabIndex = 16
		'
		'btnSaveVerifyDifference
		'
		Me.btnSaveVerifyDifference.Location = New System.Drawing.Point(232, 129)
		Me.btnSaveVerifyDifference.Name = "btnSaveVerifyDifference"
		Me.btnSaveVerifyDifference.Size = New System.Drawing.Size(71, 22)
		Me.btnSaveVerifyDifference.TabIndex = 9
		Me.btnSaveVerifyDifference.Text = "Update"
		Me.btnSaveVerifyDifference.UseVisualStyleBackColor = True
		'
		'txtVerifySavedDiffBottomRight
		'
		Me.txtVerifySavedDiffBottomRight.Location = New System.Drawing.Point(231, 73)
		Me.txtVerifySavedDiffBottomRight.Name = "txtVerifySavedDiffBottomRight"
		Me.txtVerifySavedDiffBottomRight.Size = New System.Drawing.Size(71, 22)
		Me.txtVerifySavedDiffBottomRight.TabIndex = 15
		'
		'txtVerifySavedDiffBottomLeft
		'
		Me.txtVerifySavedDiffBottomLeft.Location = New System.Drawing.Point(231, 44)
		Me.txtVerifySavedDiffBottomLeft.Name = "txtVerifySavedDiffBottomLeft"
		Me.txtVerifySavedDiffBottomLeft.Size = New System.Drawing.Size(71, 22)
		Me.txtVerifySavedDiffBottomLeft.TabIndex = 14
		'
		'lblVerifyMasterLengths
		'
		Me.lblVerifyMasterLengths.AutoSize = True
		Me.lblVerifyMasterLengths.ForeColor = System.Drawing.SystemColors.Highlight
		Me.lblVerifyMasterLengths.Location = New System.Drawing.Point(214, 20)
		Me.lblVerifyMasterLengths.Name = "lblVerifyMasterLengths"
		Me.lblVerifyMasterLengths.Size = New System.Drawing.Size(104, 16)
		Me.lblVerifyMasterLengths.TabIndex = 13
		Me.lblVerifyMasterLengths.Text = "Master Lengths"
		'
		'lblAllowedVariance
		'
		Me.lblAllowedVariance.AutoSize = True
		Me.lblAllowedVariance.ForeColor = System.Drawing.SystemColors.Highlight
		Me.lblAllowedVariance.Location = New System.Drawing.Point(422, 22)
		Me.lblAllowedVariance.Name = "lblAllowedVariance"
		Me.lblAllowedVariance.Size = New System.Drawing.Size(40, 16)
		Me.lblAllowedVariance.TabIndex = 6
		Me.lblAllowedVariance.Text = "Limit"
		'
		'updnTopRightVerifyVariance
		'
		Me.updnTopRightVerifyVariance.DecimalPlaces = 1
		Me.updnTopRightVerifyVariance.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
		Me.updnTopRightVerifyVariance.Location = New System.Drawing.Point(422, 105)
		Me.updnTopRightVerifyVariance.Minimum = New Decimal(New Integer() {1, 0, 0, 65536})
		Me.updnTopRightVerifyVariance.Name = "updnTopRightVerifyVariance"
		Me.updnTopRightVerifyVariance.Size = New System.Drawing.Size(58, 22)
		Me.updnTopRightVerifyVariance.TabIndex = 5
		Me.updnTopRightVerifyVariance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.updnTopRightVerifyVariance.Value = New Decimal(New Integer() {1, 0, 0, 65536})
		'
		'updnBottomRightVerifyVariance
		'
		Me.updnBottomRightVerifyVariance.DecimalPlaces = 1
		Me.updnBottomRightVerifyVariance.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
		Me.updnBottomRightVerifyVariance.Location = New System.Drawing.Point(422, 73)
		Me.updnBottomRightVerifyVariance.Minimum = New Decimal(New Integer() {1, 0, 0, 65536})
		Me.updnBottomRightVerifyVariance.Name = "updnBottomRightVerifyVariance"
		Me.updnBottomRightVerifyVariance.Size = New System.Drawing.Size(58, 22)
		Me.updnBottomRightVerifyVariance.TabIndex = 4
		Me.updnBottomRightVerifyVariance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.updnBottomRightVerifyVariance.Value = New Decimal(New Integer() {1, 0, 0, 65536})
		'
		'updnBottomLeftVerifyVariance
		'
		Me.updnBottomLeftVerifyVariance.DecimalPlaces = 1
		Me.updnBottomLeftVerifyVariance.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
		Me.updnBottomLeftVerifyVariance.Location = New System.Drawing.Point(422, 45)
		Me.updnBottomLeftVerifyVariance.Minimum = New Decimal(New Integer() {1, 0, 0, 65536})
		Me.updnBottomLeftVerifyVariance.Name = "updnBottomLeftVerifyVariance"
		Me.updnBottomLeftVerifyVariance.Size = New System.Drawing.Size(58, 22)
		Me.updnBottomLeftVerifyVariance.TabIndex = 3
		Me.updnBottomLeftVerifyVariance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.updnBottomLeftVerifyVariance.Value = New Decimal(New Integer() {1, 0, 0, 65536})
		'
		'lblVerifyTopRight
		'
		Me.lblVerifyTopRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.lblVerifyTopRight.Location = New System.Drawing.Point(134, 105)
		Me.lblVerifyTopRight.Name = "lblVerifyTopRight"
		Me.lblVerifyTopRight.Size = New System.Drawing.Size(75, 22)
		Me.lblVerifyTopRight.TabIndex = 2
		Me.lblVerifyTopRight.Text = "Not Found"
		'
		'lblVerifyBottomRight
		'
		Me.lblVerifyBottomRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.lblVerifyBottomRight.Location = New System.Drawing.Point(134, 73)
		Me.lblVerifyBottomRight.Name = "lblVerifyBottomRight"
		Me.lblVerifyBottomRight.Size = New System.Drawing.Size(75, 22)
		Me.lblVerifyBottomRight.TabIndex = 1
		Me.lblVerifyBottomRight.Text = "Not Found"
		'
		'lblVerifyBottomLeft
		'
		Me.lblVerifyBottomLeft.BackColor = System.Drawing.SystemColors.Control
		Me.lblVerifyBottomLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.lblVerifyBottomLeft.Location = New System.Drawing.Point(134, 45)
		Me.lblVerifyBottomLeft.Name = "lblVerifyBottomLeft"
		Me.lblVerifyBottomLeft.Size = New System.Drawing.Size(75, 22)
		Me.lblVerifyBottomLeft.TabIndex = 0
		Me.lblVerifyBottomLeft.Text = "Not Found"
		'
		'grpCameraControlBrackeyVerify
		'
		Me.grpCameraControlBrackeyVerify.BackColor = System.Drawing.SystemColors.Control
		Me.grpCameraControlBrackeyVerify.Controls.Add(Me.lblCamControlAcqTimeCenterVerify)
		Me.grpCameraControlBrackeyVerify.Controls.Add(Me.lblContrastCenterVerify)
		Me.grpCameraControlBrackeyVerify.Controls.Add(Me.lblExposureCenterVerify)
		Me.grpCameraControlBrackeyVerify.Controls.Add(Me.updnContrastCenterVerify)
		Me.grpCameraControlBrackeyVerify.Controls.Add(Me.updnExposureCenterVerify)
		Me.grpCameraControlBrackeyVerify.Controls.Add(Me.btnSnapCenterVerify)
		Me.grpCameraControlBrackeyVerify.Controls.Add(Me.chkSnapRepeatBrackeyVerify)
		Me.grpCameraControlBrackeyVerify.Controls.Add(Me.lblCameraTimeBracketVerify)
		Me.grpCameraControlBrackeyVerify.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.grpCameraControlBrackeyVerify.ForeColor = System.Drawing.SystemColors.Highlight
		Me.grpCameraControlBrackeyVerify.Location = New System.Drawing.Point(189, 15)
		Me.grpCameraControlBrackeyVerify.Name = "grpCameraControlBrackeyVerify"
		Me.grpCameraControlBrackeyVerify.Padding = New System.Windows.Forms.Padding(0)
		Me.grpCameraControlBrackeyVerify.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.grpCameraControlBrackeyVerify.Size = New System.Drawing.Size(187, 154)
		Me.grpCameraControlBrackeyVerify.TabIndex = 83
		Me.grpCameraControlBrackeyVerify.TabStop = False
		Me.grpCameraControlBrackeyVerify.Text = "Camera Controls"
		'
		'lblCamControlAcqTimeCenterVerify
		'
		Me.lblCamControlAcqTimeCenterVerify.AutoSize = True
		Me.lblCamControlAcqTimeCenterVerify.Location = New System.Drawing.Point(36, 54)
		Me.lblCamControlAcqTimeCenterVerify.Name = "lblCamControlAcqTimeCenterVerify"
		Me.lblCamControlAcqTimeCenterVerify.Size = New System.Drawing.Size(59, 14)
		Me.lblCamControlAcqTimeCenterVerify.TabIndex = 165
		Me.lblCamControlAcqTimeCenterVerify.Text = "Acq Time"
		'
		'lblContrastCenterVerify
		'
		Me.lblContrastCenterVerify.AutoSize = True
		Me.lblContrastCenterVerify.Location = New System.Drawing.Point(40, 99)
		Me.lblContrastCenterVerify.Name = "lblContrastCenterVerify"
		Me.lblContrastCenterVerify.Size = New System.Drawing.Size(55, 14)
		Me.lblContrastCenterVerify.TabIndex = 148
		Me.lblContrastCenterVerify.Text = "Contrast"
		'
		'lblExposureCenterVerify
		'
		Me.lblExposureCenterVerify.AutoSize = True
		Me.lblExposureCenterVerify.Location = New System.Drawing.Point(36, 77)
		Me.lblExposureCenterVerify.Name = "lblExposureCenterVerify"
		Me.lblExposureCenterVerify.Size = New System.Drawing.Size(59, 14)
		Me.lblExposureCenterVerify.TabIndex = 146
		Me.lblExposureCenterVerify.Text = "Exposure"
		'
		'updnContrastCenterVerify
		'
		Me.updnContrastCenterVerify.Increment = New Decimal(New Integer() {10, 0, 0, 0})
		Me.updnContrastCenterVerify.Location = New System.Drawing.Point(101, 97)
		Me.updnContrastCenterVerify.Name = "updnContrastCenterVerify"
		Me.updnContrastCenterVerify.Size = New System.Drawing.Size(49, 20)
		Me.updnContrastCenterVerify.TabIndex = 145
		Me.updnContrastCenterVerify.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
		Me.updnContrastCenterVerify.Value = New Decimal(New Integer() {100, 0, 0, 65536})
		'
		'updnExposureCenterVerify
		'
		Me.updnExposureCenterVerify.Increment = New Decimal(New Integer() {25, 0, 0, 0})
		Me.updnExposureCenterVerify.Location = New System.Drawing.Point(101, 75)
		Me.updnExposureCenterVerify.Maximum = New Decimal(New Integer() {1500, 0, 0, 0})
		Me.updnExposureCenterVerify.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
		Me.updnExposureCenterVerify.Name = "updnExposureCenterVerify"
		Me.updnExposureCenterVerify.Size = New System.Drawing.Size(49, 20)
		Me.updnExposureCenterVerify.TabIndex = 142
		Me.updnExposureCenterVerify.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
		Me.updnExposureCenterVerify.Value = New Decimal(New Integer() {10, 0, 0, 0})
		'
		'chkSnapRepeatBrackeyVerify
		'
		Me.chkSnapRepeatBrackeyVerify.BackColor = System.Drawing.SystemColors.Control
		Me.chkSnapRepeatBrackeyVerify.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkSnapRepeatBrackeyVerify.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkSnapRepeatBrackeyVerify.ForeColor = System.Drawing.SystemColors.Highlight
		Me.chkSnapRepeatBrackeyVerify.Location = New System.Drawing.Point(115, 14)
		Me.chkSnapRepeatBrackeyVerify.Name = "chkSnapRepeatBrackeyVerify"
		Me.chkSnapRepeatBrackeyVerify.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkSnapRepeatBrackeyVerify.Size = New System.Drawing.Size(62, 24)
		Me.chkSnapRepeatBrackeyVerify.TabIndex = 72
		Me.chkSnapRepeatBrackeyVerify.TabStop = False
		Me.chkSnapRepeatBrackeyVerify.Text = "Repeat"
		Me.chkSnapRepeatBrackeyVerify.UseVisualStyleBackColor = False
		'
		'lblCameraTimeBracketVerify
		'
		Me.lblCameraTimeBracketVerify.BackColor = System.Drawing.SystemColors.Control
		Me.lblCameraTimeBracketVerify.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblCameraTimeBracketVerify.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblCameraTimeBracketVerify.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCameraTimeBracketVerify.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblCameraTimeBracketVerify.Location = New System.Drawing.Point(101, 52)
		Me.lblCameraTimeBracketVerify.Name = "lblCameraTimeBracketVerify"
		Me.lblCameraTimeBracketVerify.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblCameraTimeBracketVerify.Size = New System.Drawing.Size(48, 18)
		Me.lblCameraTimeBracketVerify.TabIndex = 75
		'
		'grpCameraStatusVerify
		'
		Me.grpCameraStatusVerify.Controls.Add(Me.lblCameraStatusVerify)
		Me.grpCameraStatusVerify.Controls.Add(Me.lblTemperatureBracketVerify)
		Me.grpCameraStatusVerify.Controls.Add(Me.pctTemperatureVerify)
		Me.grpCameraStatusVerify.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
		Me.grpCameraStatusVerify.ForeColor = System.Drawing.SystemColors.Highlight
		Me.grpCameraStatusVerify.Location = New System.Drawing.Point(10, 15)
		Me.grpCameraStatusVerify.Name = "grpCameraStatusVerify"
		Me.grpCameraStatusVerify.Size = New System.Drawing.Size(173, 154)
		Me.grpCameraStatusVerify.TabIndex = 84
		Me.grpCameraStatusVerify.TabStop = False
		Me.grpCameraStatusVerify.Text = "Camera Status"
		'
		'lblCameraStatusVerify
		'
		Me.lblCameraStatusVerify.AutoSize = True
		Me.lblCameraStatusVerify.Font = New System.Drawing.Font("Arial Black", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCameraStatusVerify.ForeColor = System.Drawing.Color.DarkRed
		Me.lblCameraStatusVerify.Location = New System.Drawing.Point(37, 21)
		Me.lblCameraStatusVerify.Name = "lblCameraStatusVerify"
		Me.lblCameraStatusVerify.Size = New System.Drawing.Size(114, 51)
		Me.lblCameraStatusVerify.TabIndex = 161
		Me.lblCameraStatusVerify.Text = "       Warning! " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  The Camera is " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  not connected"
		Me.lblCameraStatusVerify.Visible = False
		'
		'lblTemperatureBracketVerify
		'
		Me.lblTemperatureBracketVerify.BackColor = System.Drawing.SystemColors.ButtonShadow
		Me.lblTemperatureBracketVerify.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblTemperatureBracketVerify.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblTemperatureBracketVerify.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblTemperatureBracketVerify.Location = New System.Drawing.Point(6, 97)
		Me.lblTemperatureBracketVerify.Name = "lblTemperatureBracketVerify"
		Me.lblTemperatureBracketVerify.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblTemperatureBracketVerify.Size = New System.Drawing.Size(39, 48)
		Me.lblTemperatureBracketVerify.TabIndex = 160
		Me.lblTemperatureBracketVerify.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'pctTemperatureVerify
		'
		Me.pctTemperatureVerify.Image = CType(resources.GetObject("pctTemperatureVerify.Image"), System.Drawing.Image)
		Me.pctTemperatureVerify.Location = New System.Drawing.Point(11, 32)
		Me.pctTemperatureVerify.Name = "pctTemperatureVerify"
		Me.pctTemperatureVerify.Size = New System.Drawing.Size(25, 60)
		Me.pctTemperatureVerify.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.pctTemperatureVerify.TabIndex = 159
		Me.pctTemperatureVerify.TabStop = False
		'
		'grpLocatorControlsBracketVerify
		'
		Me.grpLocatorControlsBracketVerify.BackColor = System.Drawing.SystemColors.Control
		Me.grpLocatorControlsBracketVerify.Controls.Add(Me.lblScoreLimitCenterVerify)
		Me.grpLocatorControlsBracketVerify.Controls.Add(Me.btnLocateOnlyBracketVerify)
		Me.grpLocatorControlsBracketVerify.Controls.Add(Me.btnLocateBracketVerify)
		Me.grpLocatorControlsBracketVerify.Controls.Add(Me.updnScoreLimitCenterVerify)
		Me.grpLocatorControlsBracketVerify.Controls.Add(Me.chkLocateGlassVerify)
		Me.grpLocatorControlsBracketVerify.Controls.Add(Me.btnSearchSettingsCenterVerify)
		Me.grpLocatorControlsBracketVerify.Controls.Add(Me.btnTrainNewCenterVerify)
		Me.grpLocatorControlsBracketVerify.Controls.Add(Me.lblLocateTimeCenterVerify)
		Me.grpLocatorControlsBracketVerify.Controls.Add(Me.lblLocatorTimeCenterVerify)
		Me.grpLocatorControlsBracketVerify.Controls.Add(Me.btnTrainExistingCenterVerify)
		Me.grpLocatorControlsBracketVerify.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.grpLocatorControlsBracketVerify.ForeColor = System.Drawing.SystemColors.Highlight
		Me.grpLocatorControlsBracketVerify.Location = New System.Drawing.Point(382, 15)
		Me.grpLocatorControlsBracketVerify.Name = "grpLocatorControlsBracketVerify"
		Me.grpLocatorControlsBracketVerify.Padding = New System.Windows.Forms.Padding(0)
		Me.grpLocatorControlsBracketVerify.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.grpLocatorControlsBracketVerify.Size = New System.Drawing.Size(233, 154)
		Me.grpLocatorControlsBracketVerify.TabIndex = 84
		Me.grpLocatorControlsBracketVerify.TabStop = False
		Me.grpLocatorControlsBracketVerify.Text = "Locator Controls"
		'
		'lblScoreLimitCenterVerify
		'
		Me.lblScoreLimitCenterVerify.AutoSize = True
		Me.lblScoreLimitCenterVerify.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblScoreLimitCenterVerify.ForeColor = System.Drawing.SystemColors.Desktop
		Me.lblScoreLimitCenterVerify.Location = New System.Drawing.Point(128, 55)
		Me.lblScoreLimitCenterVerify.Name = "lblScoreLimitCenterVerify"
		Me.lblScoreLimitCenterVerify.Size = New System.Drawing.Size(70, 14)
		Me.lblScoreLimitCenterVerify.TabIndex = 158
		Me.lblScoreLimitCenterVerify.Text = "Score Limit"
		'
		'chkLocateGlassVerify
		'
		Me.chkLocateGlassVerify.BackColor = System.Drawing.SystemColors.Control
		Me.chkLocateGlassVerify.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkLocateGlassVerify.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkLocateGlassVerify.ForeColor = System.Drawing.SystemColors.Highlight
		Me.chkLocateGlassVerify.Location = New System.Drawing.Point(123, 14)
		Me.chkLocateGlassVerify.Name = "chkLocateGlassVerify"
		Me.chkLocateGlassVerify.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkLocateGlassVerify.Size = New System.Drawing.Size(68, 24)
		Me.chkLocateGlassVerify.TabIndex = 60
		Me.chkLocateGlassVerify.TabStop = False
		Me.chkLocateGlassVerify.Text = "Repeat"
		Me.chkLocateGlassVerify.UseVisualStyleBackColor = False
		'
		'lblLocateTimeCenterVerify
		'
		Me.lblLocateTimeCenterVerify.BackColor = System.Drawing.SystemColors.Control
		Me.lblLocateTimeCenterVerify.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblLocateTimeCenterVerify.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblLocateTimeCenterVerify.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblLocateTimeCenterVerify.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblLocateTimeCenterVerify.Location = New System.Drawing.Point(51, 54)
		Me.lblLocateTimeCenterVerify.Name = "lblLocateTimeCenterVerify"
		Me.lblLocateTimeCenterVerify.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblLocateTimeCenterVerify.Size = New System.Drawing.Size(55, 18)
		Me.lblLocateTimeCenterVerify.TabIndex = 67
		'
		'lblLocatorTimeCenterVerify
		'
		Me.lblLocatorTimeCenterVerify.AutoSize = True
		Me.lblLocatorTimeCenterVerify.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblLocatorTimeCenterVerify.ForeColor = System.Drawing.SystemColors.Desktop
		Me.lblLocatorTimeCenterVerify.Location = New System.Drawing.Point(20, 56)
		Me.lblLocatorTimeCenterVerify.Name = "lblLocatorTimeCenterVerify"
		Me.lblLocatorTimeCenterVerify.Size = New System.Drawing.Size(29, 14)
		Me.lblLocatorTimeCenterVerify.TabIndex = 157
		Me.lblLocatorTimeCenterVerify.Text = "Time"
		'
		'grpVisionStatusVerify
		'
		Me.grpVisionStatusVerify.BackColor = System.Drawing.SystemColors.Control
		Me.grpVisionStatusVerify.Controls.Add(Me.lblFitBracketVerify)
		Me.grpVisionStatusVerify.Controls.Add(Me.lblVisionPoseFirBracketVerify)
		Me.grpVisionStatusVerify.Controls.Add(Me.lblVisionPoseFitBracketVerify)
		Me.grpVisionStatusVerify.Controls.Add(Me.lblVisionPoseScoreBracketVerify)
		Me.grpVisionStatusVerify.Controls.Add(Me.lblVisionPoseTimeBracketVerify)
		Me.grpVisionStatusVerify.Controls.Add(Me.lblVisionPoseRBracketVerify)
		Me.grpVisionStatusVerify.Controls.Add(Me.lblVisionPoseYBracketVerify)
		Me.grpVisionStatusVerify.Controls.Add(Me.lblVisionPoseXBracketVerify)
		Me.grpVisionStatusVerify.Controls.Add(Me.btnDetailsBracketVerify)
		Me.grpVisionStatusVerify.Controls.Add(Me.lblVisionMessageBracketVerify)
		Me.grpVisionStatusVerify.Controls.Add(Me.lblVisionXBracketVerify)
		Me.grpVisionStatusVerify.Controls.Add(Me.lblVisionYBracketVerify)
		Me.grpVisionStatusVerify.Controls.Add(Me.lblVisionRBracketVerify)
		Me.grpVisionStatusVerify.Controls.Add(Me.lblVisionTimeBracketVerify)
		Me.grpVisionStatusVerify.Controls.Add(Me.lblVisionScoreBracketVerify)
		Me.grpVisionStatusVerify.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.grpVisionStatusVerify.ForeColor = System.Drawing.SystemColors.Highlight
		Me.grpVisionStatusVerify.Location = New System.Drawing.Point(621, 15)
		Me.grpVisionStatusVerify.Name = "grpVisionStatusVerify"
		Me.grpVisionStatusVerify.Padding = New System.Windows.Forms.Padding(0)
		Me.grpVisionStatusVerify.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.grpVisionStatusVerify.Size = New System.Drawing.Size(320, 154)
		Me.grpVisionStatusVerify.TabIndex = 79
		Me.grpVisionStatusVerify.TabStop = False
		Me.grpVisionStatusVerify.Text = "Status"
		'
		'lblFitBracketVerify
		'
		Me.lblFitBracketVerify.BackColor = System.Drawing.SystemColors.Control
		Me.lblFitBracketVerify.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblFitBracketVerify.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblFitBracketVerify.ForeColor = System.Drawing.SystemColors.Highlight
		Me.lblFitBracketVerify.Location = New System.Drawing.Point(230, 66)
		Me.lblFitBracketVerify.Name = "lblFitBracketVerify"
		Me.lblFitBracketVerify.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblFitBracketVerify.Size = New System.Drawing.Size(10, 21)
		Me.lblFitBracketVerify.TabIndex = 160
		Me.lblFitBracketVerify.Text = ":"
		'
		'lblVisionPoseFirBracketVerify
		'
		Me.lblVisionPoseFirBracketVerify.BackColor = System.Drawing.SystemColors.Control
		Me.lblVisionPoseFirBracketVerify.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblVisionPoseFirBracketVerify.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblVisionPoseFirBracketVerify.ForeColor = System.Drawing.SystemColors.Highlight
		Me.lblVisionPoseFirBracketVerify.Location = New System.Drawing.Point(202, 67)
		Me.lblVisionPoseFirBracketVerify.Name = "lblVisionPoseFirBracketVerify"
		Me.lblVisionPoseFirBracketVerify.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblVisionPoseFirBracketVerify.Size = New System.Drawing.Size(20, 17)
		Me.lblVisionPoseFirBracketVerify.TabIndex = 159
		Me.lblVisionPoseFirBracketVerify.Text = "Fit"
		'
		'lblVisionPoseFitBracketVerify
		'
		Me.lblVisionPoseFitBracketVerify.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblVisionPoseFitBracketVerify.Location = New System.Drawing.Point(246, 64)
		Me.lblVisionPoseFitBracketVerify.Name = "lblVisionPoseFitBracketVerify"
		Me.lblVisionPoseFitBracketVerify.Size = New System.Drawing.Size(62, 23)
		Me.lblVisionPoseFitBracketVerify.TabIndex = 158
		'
		'lblVisionPoseScoreBracketVerify
		'
		Me.lblVisionPoseScoreBracketVerify.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblVisionPoseScoreBracketVerify.Location = New System.Drawing.Point(249, 114)
		Me.lblVisionPoseScoreBracketVerify.Name = "lblVisionPoseScoreBracketVerify"
		Me.lblVisionPoseScoreBracketVerify.Size = New System.Drawing.Size(59, 23)
		Me.lblVisionPoseScoreBracketVerify.TabIndex = 154
		'
		'lblVisionPoseTimeBracketVerify
		'
		Me.lblVisionPoseTimeBracketVerify.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblVisionPoseTimeBracketVerify.Location = New System.Drawing.Point(189, 114)
		Me.lblVisionPoseTimeBracketVerify.Name = "lblVisionPoseTimeBracketVerify"
		Me.lblVisionPoseTimeBracketVerify.Size = New System.Drawing.Size(59, 23)
		Me.lblVisionPoseTimeBracketVerify.TabIndex = 153
		'
		'lblVisionPoseRBracketVerify
		'
		Me.lblVisionPoseRBracketVerify.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblVisionPoseRBracketVerify.Location = New System.Drawing.Point(129, 114)
		Me.lblVisionPoseRBracketVerify.Name = "lblVisionPoseRBracketVerify"
		Me.lblVisionPoseRBracketVerify.Size = New System.Drawing.Size(59, 23)
		Me.lblVisionPoseRBracketVerify.TabIndex = 152
		'
		'lblVisionPoseYBracketVerify
		'
		Me.lblVisionPoseYBracketVerify.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblVisionPoseYBracketVerify.Location = New System.Drawing.Point(69, 114)
		Me.lblVisionPoseYBracketVerify.Name = "lblVisionPoseYBracketVerify"
		Me.lblVisionPoseYBracketVerify.Size = New System.Drawing.Size(59, 23)
		Me.lblVisionPoseYBracketVerify.TabIndex = 151
		'
		'lblVisionPoseXBracketVerify
		'
		Me.lblVisionPoseXBracketVerify.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblVisionPoseXBracketVerify.Location = New System.Drawing.Point(9, 114)
		Me.lblVisionPoseXBracketVerify.Name = "lblVisionPoseXBracketVerify"
		Me.lblVisionPoseXBracketVerify.Size = New System.Drawing.Size(59, 23)
		Me.lblVisionPoseXBracketVerify.TabIndex = 150
		'
		'lblVisionXBracketVerify
		'
		Me.lblVisionXBracketVerify.BackColor = System.Drawing.SystemColors.Control
		Me.lblVisionXBracketVerify.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblVisionXBracketVerify.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblVisionXBracketVerify.ForeColor = System.Drawing.SystemColors.Highlight
		Me.lblVisionXBracketVerify.Location = New System.Drawing.Point(27, 95)
		Me.lblVisionXBracketVerify.Name = "lblVisionXBracketVerify"
		Me.lblVisionXBracketVerify.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblVisionXBracketVerify.Size = New System.Drawing.Size(34, 17)
		Me.lblVisionXBracketVerify.TabIndex = 55
		Me.lblVisionXBracketVerify.Text = "X"
		'
		'lblVisionYBracketVerify
		'
		Me.lblVisionYBracketVerify.BackColor = System.Drawing.SystemColors.Control
		Me.lblVisionYBracketVerify.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblVisionYBracketVerify.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblVisionYBracketVerify.ForeColor = System.Drawing.SystemColors.Highlight
		Me.lblVisionYBracketVerify.Location = New System.Drawing.Point(87, 95)
		Me.lblVisionYBracketVerify.Name = "lblVisionYBracketVerify"
		Me.lblVisionYBracketVerify.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblVisionYBracketVerify.Size = New System.Drawing.Size(34, 17)
		Me.lblVisionYBracketVerify.TabIndex = 54
		Me.lblVisionYBracketVerify.Text = "Y"
		'
		'lblVisionRBracketVerify
		'
		Me.lblVisionRBracketVerify.BackColor = System.Drawing.SystemColors.Control
		Me.lblVisionRBracketVerify.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblVisionRBracketVerify.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblVisionRBracketVerify.ForeColor = System.Drawing.SystemColors.Highlight
		Me.lblVisionRBracketVerify.Location = New System.Drawing.Point(138, 95)
		Me.lblVisionRBracketVerify.Name = "lblVisionRBracketVerify"
		Me.lblVisionRBracketVerify.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblVisionRBracketVerify.Size = New System.Drawing.Size(50, 17)
		Me.lblVisionRBracketVerify.TabIndex = 53
		Me.lblVisionRBracketVerify.Text = "Angle"
		'
		'lblVisionTimeBracketVerify
		'
		Me.lblVisionTimeBracketVerify.BackColor = System.Drawing.SystemColors.Control
		Me.lblVisionTimeBracketVerify.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblVisionTimeBracketVerify.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblVisionTimeBracketVerify.ForeColor = System.Drawing.SystemColors.Highlight
		Me.lblVisionTimeBracketVerify.Location = New System.Drawing.Point(199, 95)
		Me.lblVisionTimeBracketVerify.Name = "lblVisionTimeBracketVerify"
		Me.lblVisionTimeBracketVerify.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblVisionTimeBracketVerify.Size = New System.Drawing.Size(50, 17)
		Me.lblVisionTimeBracketVerify.TabIndex = 52
		Me.lblVisionTimeBracketVerify.Text = "Time"
		'
		'lblVisionScoreBracketVerify
		'
		Me.lblVisionScoreBracketVerify.BackColor = System.Drawing.SystemColors.Control
		Me.lblVisionScoreBracketVerify.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblVisionScoreBracketVerify.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblVisionScoreBracketVerify.ForeColor = System.Drawing.SystemColors.Highlight
		Me.lblVisionScoreBracketVerify.Location = New System.Drawing.Point(258, 95)
		Me.lblVisionScoreBracketVerify.Name = "lblVisionScoreBracketVerify"
		Me.lblVisionScoreBracketVerify.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblVisionScoreBracketVerify.Size = New System.Drawing.Size(50, 17)
		Me.lblVisionScoreBracketVerify.TabIndex = 50
		Me.lblVisionScoreBracketVerify.Text = "Score"
		'
		'grpHSDisplayBracketVerify
		'
		Me.grpHSDisplayBracketVerify.BackColor = System.Drawing.SystemColors.Control
		Me.grpHSDisplayBracketVerify.Controls.Add(Me.HSDisplayCenterBracketVerify)
		Me.grpHSDisplayBracketVerify.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.grpHSDisplayBracketVerify.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.grpHSDisplayBracketVerify.ForeColor = System.Drawing.SystemColors.ControlText
		Me.grpHSDisplayBracketVerify.Location = New System.Drawing.Point(6, 174)
		Me.grpHSDisplayBracketVerify.Name = "grpHSDisplayBracketVerify"
		Me.grpHSDisplayBracketVerify.Padding = New System.Windows.Forms.Padding(0)
		Me.grpHSDisplayBracketVerify.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.grpHSDisplayBracketVerify.Size = New System.Drawing.Size(1502, 745)
		Me.grpHSDisplayBracketVerify.TabIndex = 78
		Me.grpHSDisplayBracketVerify.TabStop = False
		'
		'HSDisplayCenterBracketVerify
		'
		Me.HSDisplayCenterBracketVerify.Enabled = True
		Me.HSDisplayCenterBracketVerify.Location = New System.Drawing.Point(14, 22)
		Me.HSDisplayCenterBracketVerify.Name = "HSDisplayCenterBracketVerify"
		Me.HSDisplayCenterBracketVerify.OcxState = CType(resources.GetObject("HSDisplayCenterBracketVerify.OcxState"), System.Windows.Forms.AxHost.State)
		Me.HSDisplayCenterBracketVerify.Size = New System.Drawing.Size(468, 293)
		Me.HSDisplayCenterBracketVerify.TabIndex = 81
		'
		'tabPageDriverCam
		'
		Me.tabPageDriverCam.BackColor = System.Drawing.SystemColors.Control
		Me.tabPageDriverCam.Controls.Add(Me.grpVisionDriver)
		Me.tabPageDriverCam.Location = New System.Drawing.Point(4, 27)
		Me.tabPageDriverCam.Name = "tabPageDriverCam"
		Me.tabPageDriverCam.Size = New System.Drawing.Size(1522, 927)
		Me.tabPageDriverCam.TabIndex = 2
		Me.tabPageDriverCam.Text = "Aron Mighty - Driver"
		'
		'grpVisionDriver
		'
		Me.grpVisionDriver.Controls.Add(Me.grpCameraControlDriver)
		Me.grpVisionDriver.Controls.Add(Me.grpDriveBlob)
		Me.grpVisionDriver.Controls.Add(Me.grpLocatorControlsDriver)
		Me.grpVisionDriver.Controls.Add(Me.grpDriverCameraStatus)
		Me.grpVisionDriver.Controls.Add(Me.grpStatusDriver)
		Me.grpVisionDriver.Controls.Add(Me.grpHSDisplayDriver)
		Me.grpVisionDriver.Location = New System.Drawing.Point(6, 4)
		Me.grpVisionDriver.Name = "grpVisionDriver"
		Me.grpVisionDriver.Size = New System.Drawing.Size(1522, 933)
		Me.grpVisionDriver.TabIndex = 79
		Me.grpVisionDriver.TabStop = False
		'
		'grpCameraControlDriver
		'
		Me.grpCameraControlDriver.BackColor = System.Drawing.SystemColors.Control
		Me.grpCameraControlDriver.Controls.Add(Me.lblCamControlAcqTimeDriver)
		Me.grpCameraControlDriver.Controls.Add(Me.lblContrastDriver)
		Me.grpCameraControlDriver.Controls.Add(Me.lblExposureDriver)
		Me.grpCameraControlDriver.Controls.Add(Me.updnContrastDriver)
		Me.grpCameraControlDriver.Controls.Add(Me.updnExposureDriver)
		Me.grpCameraControlDriver.Controls.Add(Me.btnSnapDriver)
		Me.grpCameraControlDriver.Controls.Add(Me.chkSnapRepeatDriver)
		Me.grpCameraControlDriver.Controls.Add(Me.lblCameraTimeDriver)
		Me.grpCameraControlDriver.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.grpCameraControlDriver.ForeColor = System.Drawing.SystemColors.Highlight
		Me.grpCameraControlDriver.Location = New System.Drawing.Point(189, 15)
		Me.grpCameraControlDriver.Name = "grpCameraControlDriver"
		Me.grpCameraControlDriver.Padding = New System.Windows.Forms.Padding(0)
		Me.grpCameraControlDriver.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.grpCameraControlDriver.Size = New System.Drawing.Size(187, 154)
		Me.grpCameraControlDriver.TabIndex = 85
		Me.grpCameraControlDriver.TabStop = False
		Me.grpCameraControlDriver.Text = "Camera Controls"
		'
		'lblCamControlAcqTimeDriver
		'
		Me.lblCamControlAcqTimeDriver.AutoSize = True
		Me.lblCamControlAcqTimeDriver.Location = New System.Drawing.Point(36, 54)
		Me.lblCamControlAcqTimeDriver.Name = "lblCamControlAcqTimeDriver"
		Me.lblCamControlAcqTimeDriver.Size = New System.Drawing.Size(59, 14)
		Me.lblCamControlAcqTimeDriver.TabIndex = 165
		Me.lblCamControlAcqTimeDriver.Text = "Acq Time"
		'
		'lblContrastDriver
		'
		Me.lblContrastDriver.AutoSize = True
		Me.lblContrastDriver.Location = New System.Drawing.Point(40, 99)
		Me.lblContrastDriver.Name = "lblContrastDriver"
		Me.lblContrastDriver.Size = New System.Drawing.Size(55, 14)
		Me.lblContrastDriver.TabIndex = 148
		Me.lblContrastDriver.Text = "Contrast"
		'
		'lblExposureDriver
		'
		Me.lblExposureDriver.AutoSize = True
		Me.lblExposureDriver.Location = New System.Drawing.Point(36, 77)
		Me.lblExposureDriver.Name = "lblExposureDriver"
		Me.lblExposureDriver.Size = New System.Drawing.Size(59, 14)
		Me.lblExposureDriver.TabIndex = 146
		Me.lblExposureDriver.Text = "Exposure"
		'
		'updnContrastDriver
		'
		Me.updnContrastDriver.Increment = New Decimal(New Integer() {10, 0, 0, 0})
		Me.updnContrastDriver.Location = New System.Drawing.Point(101, 97)
		Me.updnContrastDriver.Name = "updnContrastDriver"
		Me.updnContrastDriver.Size = New System.Drawing.Size(49, 20)
		Me.updnContrastDriver.TabIndex = 145
		Me.updnContrastDriver.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
		Me.updnContrastDriver.Value = New Decimal(New Integer() {100, 0, 0, 65536})
		'
		'updnExposureDriver
		'
		Me.updnExposureDriver.Increment = New Decimal(New Integer() {25, 0, 0, 0})
		Me.updnExposureDriver.Location = New System.Drawing.Point(101, 75)
		Me.updnExposureDriver.Maximum = New Decimal(New Integer() {1500, 0, 0, 0})
		Me.updnExposureDriver.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
		Me.updnExposureDriver.Name = "updnExposureDriver"
		Me.updnExposureDriver.Size = New System.Drawing.Size(49, 20)
		Me.updnExposureDriver.TabIndex = 142
		Me.updnExposureDriver.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
		Me.updnExposureDriver.Value = New Decimal(New Integer() {10, 0, 0, 0})
		'
		'chkSnapRepeatDriver
		'
		Me.chkSnapRepeatDriver.BackColor = System.Drawing.SystemColors.Control
		Me.chkSnapRepeatDriver.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkSnapRepeatDriver.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkSnapRepeatDriver.ForeColor = System.Drawing.SystemColors.Highlight
		Me.chkSnapRepeatDriver.Location = New System.Drawing.Point(115, 14)
		Me.chkSnapRepeatDriver.Name = "chkSnapRepeatDriver"
		Me.chkSnapRepeatDriver.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkSnapRepeatDriver.Size = New System.Drawing.Size(62, 24)
		Me.chkSnapRepeatDriver.TabIndex = 72
		Me.chkSnapRepeatDriver.TabStop = False
		Me.chkSnapRepeatDriver.Text = "Repeat"
		Me.chkSnapRepeatDriver.UseVisualStyleBackColor = False
		'
		'lblCameraTimeDriver
		'
		Me.lblCameraTimeDriver.BackColor = System.Drawing.SystemColors.Control
		Me.lblCameraTimeDriver.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblCameraTimeDriver.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblCameraTimeDriver.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCameraTimeDriver.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblCameraTimeDriver.Location = New System.Drawing.Point(101, 52)
		Me.lblCameraTimeDriver.Name = "lblCameraTimeDriver"
		Me.lblCameraTimeDriver.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblCameraTimeDriver.Size = New System.Drawing.Size(48, 18)
		Me.lblCameraTimeDriver.TabIndex = 75
		'
		'grpDriveBlob
		'
		Me.grpDriveBlob.Controls.Add(Me.btnDriverSaveBlob)
		Me.grpDriveBlob.Controls.Add(Me.lblTrackDriverValue)
		Me.grpDriveBlob.Controls.Add(Me.btnDriverTrainBlob)
		Me.grpDriveBlob.Controls.Add(Me.trkDriverBlob)
		Me.grpDriveBlob.Controls.Add(Me.lblDriverBlobArea)
		Me.grpDriveBlob.Controls.Add(Me.btnSaveDriverBlobArea)
		Me.grpDriveBlob.Controls.Add(Me.lblDriverMaxBlobCount)
		Me.grpDriveBlob.Controls.Add(Me.lblDriverMinBlobCount)
		Me.grpDriveBlob.Controls.Add(Me.updnDriverBlobThresholdMax)
		Me.grpDriveBlob.Controls.Add(Me.updnDriverBlobThresholdMin)
		Me.grpDriveBlob.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.grpDriveBlob.Location = New System.Drawing.Point(947, 15)
		Me.grpDriveBlob.Name = "grpDriveBlob"
		Me.grpDriveBlob.Size = New System.Drawing.Size(350, 154)
		Me.grpDriveBlob.TabIndex = 86
		Me.grpDriveBlob.TabStop = False
		'
		'lblTrackDriverValue
		'
		Me.lblTrackDriverValue.AutoSize = True
		Me.lblTrackDriverValue.Location = New System.Drawing.Point(123, 115)
		Me.lblTrackDriverValue.Name = "lblTrackDriverValue"
		Me.lblTrackDriverValue.Size = New System.Drawing.Size(91, 16)
		Me.lblTrackDriverValue.TabIndex = 7
		Me.lblTrackDriverValue.Text = "Minimum Area"
		Me.lblTrackDriverValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'trkDriverBlob
		'
		Me.trkDriverBlob.Location = New System.Drawing.Point(126, 86)
		Me.trkDriverBlob.Maximum = 100
		Me.trkDriverBlob.Name = "trkDriverBlob"
		Me.trkDriverBlob.Size = New System.Drawing.Size(147, 45)
		Me.trkDriverBlob.TabIndex = 6
		'
		'lblDriverBlobArea
		'
		Me.lblDriverBlobArea.AutoSize = True
		Me.lblDriverBlobArea.Location = New System.Drawing.Point(6, 80)
		Me.lblDriverBlobArea.Name = "lblDriverBlobArea"
		Me.lblDriverBlobArea.Size = New System.Drawing.Size(77, 16)
		Me.lblDriverBlobArea.TabIndex = 5
		Me.lblDriverBlobArea.Text = "Saved Area:"
		'
		'btnSaveDriverBlobArea
		'
		Me.btnSaveDriverBlobArea.Location = New System.Drawing.Point(4, 100)
		Me.btnSaveDriverBlobArea.Name = "btnSaveDriverBlobArea"
		Me.btnSaveDriverBlobArea.Size = New System.Drawing.Size(105, 32)
		Me.btnSaveDriverBlobArea.TabIndex = 4
		Me.btnSaveDriverBlobArea.Text = "Save Blob Area"
		Me.btnSaveDriverBlobArea.UseVisualStyleBackColor = True
		'
		'lblDriverMaxBlobCount
		'
		Me.lblDriverMaxBlobCount.AutoSize = True
		Me.lblDriverMaxBlobCount.Location = New System.Drawing.Point(16, 55)
		Me.lblDriverMaxBlobCount.Name = "lblDriverMaxBlobCount"
		Me.lblDriverMaxBlobCount.Size = New System.Drawing.Size(173, 16)
		Me.lblDriverMaxBlobCount.TabIndex = 3
		Me.lblDriverMaxBlobCount.Text = "Maximum Primer Brightness"
		'
		'lblDriverMinBlobCount
		'
		Me.lblDriverMinBlobCount.AutoSize = True
		Me.lblDriverMinBlobCount.Location = New System.Drawing.Point(16, 22)
		Me.lblDriverMinBlobCount.Name = "lblDriverMinBlobCount"
		Me.lblDriverMinBlobCount.Size = New System.Drawing.Size(169, 16)
		Me.lblDriverMinBlobCount.TabIndex = 2
		Me.lblDriverMinBlobCount.Text = "Minimum Primer Brightness"
		'
		'updnDriverBlobThresholdMax
		'
		Me.updnDriverBlobThresholdMax.Location = New System.Drawing.Point(189, 52)
		Me.updnDriverBlobThresholdMax.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
		Me.updnDriverBlobThresholdMax.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.updnDriverBlobThresholdMax.Name = "updnDriverBlobThresholdMax"
		Me.updnDriverBlobThresholdMax.Size = New System.Drawing.Size(70, 22)
		Me.updnDriverBlobThresholdMax.TabIndex = 1
		Me.updnDriverBlobThresholdMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.updnDriverBlobThresholdMax.Value = New Decimal(New Integer() {1, 0, 0, 0})
		'
		'updnDriverBlobThresholdMin
		'
		Me.updnDriverBlobThresholdMin.Location = New System.Drawing.Point(189, 19)
		Me.updnDriverBlobThresholdMin.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.updnDriverBlobThresholdMin.Name = "updnDriverBlobThresholdMin"
		Me.updnDriverBlobThresholdMin.Size = New System.Drawing.Size(70, 22)
		Me.updnDriverBlobThresholdMin.TabIndex = 0
		Me.updnDriverBlobThresholdMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.updnDriverBlobThresholdMin.Value = New Decimal(New Integer() {1, 0, 0, 0})
		'
		'grpLocatorControlsDriver
		'
		Me.grpLocatorControlsDriver.BackColor = System.Drawing.SystemColors.Control
		Me.grpLocatorControlsDriver.Controls.Add(Me.lblScoreLimitDriver)
		Me.grpLocatorControlsDriver.Controls.Add(Me.btnLocateOnlyDriver)
		Me.grpLocatorControlsDriver.Controls.Add(Me.btnLocateDriver)
		Me.grpLocatorControlsDriver.Controls.Add(Me.updnScoreLimitDriver)
		Me.grpLocatorControlsDriver.Controls.Add(Me.chkLocateDriver)
		Me.grpLocatorControlsDriver.Controls.Add(Me.btnSearchSettingsDriver)
		Me.grpLocatorControlsDriver.Controls.Add(Me.btnTrainNewDriver)
		Me.grpLocatorControlsDriver.Controls.Add(Me.lblLocateTimeDriver)
		Me.grpLocatorControlsDriver.Controls.Add(Me.lblLocatorTimeDriver)
		Me.grpLocatorControlsDriver.Controls.Add(Me.btnTrainExistingDriver)
		Me.grpLocatorControlsDriver.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.grpLocatorControlsDriver.ForeColor = System.Drawing.SystemColors.Highlight
		Me.grpLocatorControlsDriver.Location = New System.Drawing.Point(382, 15)
		Me.grpLocatorControlsDriver.Name = "grpLocatorControlsDriver"
		Me.grpLocatorControlsDriver.Padding = New System.Windows.Forms.Padding(0)
		Me.grpLocatorControlsDriver.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.grpLocatorControlsDriver.Size = New System.Drawing.Size(233, 154)
		Me.grpLocatorControlsDriver.TabIndex = 86
		Me.grpLocatorControlsDriver.TabStop = False
		Me.grpLocatorControlsDriver.Text = "Locator Controls"
		'
		'lblScoreLimitDriver
		'
		Me.lblScoreLimitDriver.AutoSize = True
		Me.lblScoreLimitDriver.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblScoreLimitDriver.ForeColor = System.Drawing.SystemColors.Desktop
		Me.lblScoreLimitDriver.Location = New System.Drawing.Point(128, 55)
		Me.lblScoreLimitDriver.Name = "lblScoreLimitDriver"
		Me.lblScoreLimitDriver.Size = New System.Drawing.Size(70, 14)
		Me.lblScoreLimitDriver.TabIndex = 158
		Me.lblScoreLimitDriver.Text = "Score Limit"
		'
		'chkLocateDriver
		'
		Me.chkLocateDriver.BackColor = System.Drawing.SystemColors.Control
		Me.chkLocateDriver.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkLocateDriver.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkLocateDriver.ForeColor = System.Drawing.SystemColors.Highlight
		Me.chkLocateDriver.Location = New System.Drawing.Point(123, 14)
		Me.chkLocateDriver.Name = "chkLocateDriver"
		Me.chkLocateDriver.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkLocateDriver.Size = New System.Drawing.Size(68, 24)
		Me.chkLocateDriver.TabIndex = 60
		Me.chkLocateDriver.TabStop = False
		Me.chkLocateDriver.Text = "Repeat"
		Me.chkLocateDriver.UseVisualStyleBackColor = False
		'
		'lblLocateTimeDriver
		'
		Me.lblLocateTimeDriver.BackColor = System.Drawing.SystemColors.Control
		Me.lblLocateTimeDriver.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblLocateTimeDriver.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblLocateTimeDriver.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblLocateTimeDriver.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblLocateTimeDriver.Location = New System.Drawing.Point(51, 54)
		Me.lblLocateTimeDriver.Name = "lblLocateTimeDriver"
		Me.lblLocateTimeDriver.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblLocateTimeDriver.Size = New System.Drawing.Size(55, 18)
		Me.lblLocateTimeDriver.TabIndex = 67
		'
		'lblLocatorTimeDriver
		'
		Me.lblLocatorTimeDriver.AutoSize = True
		Me.lblLocatorTimeDriver.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblLocatorTimeDriver.ForeColor = System.Drawing.SystemColors.Desktop
		Me.lblLocatorTimeDriver.Location = New System.Drawing.Point(20, 56)
		Me.lblLocatorTimeDriver.Name = "lblLocatorTimeDriver"
		Me.lblLocatorTimeDriver.Size = New System.Drawing.Size(29, 14)
		Me.lblLocatorTimeDriver.TabIndex = 157
		Me.lblLocatorTimeDriver.Text = "Time"
		'
		'grpDriverCameraStatus
		'
		Me.grpDriverCameraStatus.Controls.Add(Me.lblCameraStatusDriver)
		Me.grpDriverCameraStatus.Controls.Add(Me.lblTemperatureDriver)
		Me.grpDriverCameraStatus.Controls.Add(Me.pbDriverTemperature)
		Me.grpDriverCameraStatus.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
		Me.grpDriverCameraStatus.ForeColor = System.Drawing.SystemColors.Highlight
		Me.grpDriverCameraStatus.Location = New System.Drawing.Point(10, 15)
		Me.grpDriverCameraStatus.Name = "grpDriverCameraStatus"
		Me.grpDriverCameraStatus.Size = New System.Drawing.Size(173, 154)
		Me.grpDriverCameraStatus.TabIndex = 84
		Me.grpDriverCameraStatus.TabStop = False
		Me.grpDriverCameraStatus.Text = "Camera Status"
		'
		'lblCameraStatusDriver
		'
		Me.lblCameraStatusDriver.AutoSize = True
		Me.lblCameraStatusDriver.Font = New System.Drawing.Font("Arial Black", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCameraStatusDriver.ForeColor = System.Drawing.Color.DarkRed
		Me.lblCameraStatusDriver.Location = New System.Drawing.Point(37, 21)
		Me.lblCameraStatusDriver.Name = "lblCameraStatusDriver"
		Me.lblCameraStatusDriver.Size = New System.Drawing.Size(114, 51)
		Me.lblCameraStatusDriver.TabIndex = 161
		Me.lblCameraStatusDriver.Text = "       Warning! " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  The Camera is " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  not connected"
		Me.lblCameraStatusDriver.Visible = False
		'
		'lblTemperatureDriver
		'
		Me.lblTemperatureDriver.BackColor = System.Drawing.SystemColors.ButtonShadow
		Me.lblTemperatureDriver.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblTemperatureDriver.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblTemperatureDriver.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblTemperatureDriver.Location = New System.Drawing.Point(6, 97)
		Me.lblTemperatureDriver.Name = "lblTemperatureDriver"
		Me.lblTemperatureDriver.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblTemperatureDriver.Size = New System.Drawing.Size(39, 48)
		Me.lblTemperatureDriver.TabIndex = 160
		Me.lblTemperatureDriver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'pbDriverTemperature
		'
		Me.pbDriverTemperature.Image = CType(resources.GetObject("pbDriverTemperature.Image"), System.Drawing.Image)
		Me.pbDriverTemperature.Location = New System.Drawing.Point(11, 32)
		Me.pbDriverTemperature.Name = "pbDriverTemperature"
		Me.pbDriverTemperature.Size = New System.Drawing.Size(25, 60)
		Me.pbDriverTemperature.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.pbDriverTemperature.TabIndex = 159
		Me.pbDriverTemperature.TabStop = False
		'
		'grpStatusDriver
		'
		Me.grpStatusDriver.BackColor = System.Drawing.SystemColors.Control
		Me.grpStatusDriver.Controls.Add(Me.lblDriverBlobAreaDesc)
		Me.grpStatusDriver.Controls.Add(Me.lblDriverCurrentBlobArea)
		Me.grpStatusDriver.Controls.Add(Me.lblFitDriver)
		Me.grpStatusDriver.Controls.Add(Me.lblVisionPoseFirDriver)
		Me.grpStatusDriver.Controls.Add(Me.lblVisionPoseFitDriver)
		Me.grpStatusDriver.Controls.Add(Me.lblVisionPoseScoreDriver)
		Me.grpStatusDriver.Controls.Add(Me.lblVisionPoseTimeDriver)
		Me.grpStatusDriver.Controls.Add(Me.lblVisionPoseRDriver)
		Me.grpStatusDriver.Controls.Add(Me.lblVisionPoseYDriver)
		Me.grpStatusDriver.Controls.Add(Me.lblVisionPoseXDriver)
		Me.grpStatusDriver.Controls.Add(Me.btnDetailsDriver)
		Me.grpStatusDriver.Controls.Add(Me.lblVisionMessageDriver)
		Me.grpStatusDriver.Controls.Add(Me.lblVisionXDriver)
		Me.grpStatusDriver.Controls.Add(Me.lblVisionYDriver)
		Me.grpStatusDriver.Controls.Add(Me.lblVisionAngleDriver)
		Me.grpStatusDriver.Controls.Add(Me.lblVisionTimeDriver)
		Me.grpStatusDriver.Controls.Add(Me.lblVisionScoreDriver)
		Me.grpStatusDriver.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.grpStatusDriver.ForeColor = System.Drawing.SystemColors.Highlight
		Me.grpStatusDriver.Location = New System.Drawing.Point(621, 15)
		Me.grpStatusDriver.Name = "grpStatusDriver"
		Me.grpStatusDriver.Padding = New System.Windows.Forms.Padding(0)
		Me.grpStatusDriver.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.grpStatusDriver.Size = New System.Drawing.Size(320, 154)
		Me.grpStatusDriver.TabIndex = 79
		Me.grpStatusDriver.TabStop = False
		Me.grpStatusDriver.Text = "Status"
		'
		'lblDriverBlobAreaDesc
		'
		Me.lblDriverBlobAreaDesc.BackColor = System.Drawing.SystemColors.Control
		Me.lblDriverBlobAreaDesc.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDriverBlobAreaDesc.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDriverBlobAreaDesc.ForeColor = System.Drawing.SystemColors.Highlight
		Me.lblDriverBlobAreaDesc.Location = New System.Drawing.Point(71, 70)
		Me.lblDriverBlobAreaDesc.Name = "lblDriverBlobAreaDesc"
		Me.lblDriverBlobAreaDesc.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDriverBlobAreaDesc.Size = New System.Drawing.Size(66, 17)
		Me.lblDriverBlobAreaDesc.TabIndex = 164
		Me.lblDriverBlobAreaDesc.Text = "Blob Area"
		'
		'lblDriverCurrentBlobArea
		'
		Me.lblDriverCurrentBlobArea.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDriverCurrentBlobArea.Location = New System.Drawing.Point(141, 64)
		Me.lblDriverCurrentBlobArea.Name = "lblDriverCurrentBlobArea"
		Me.lblDriverCurrentBlobArea.Size = New System.Drawing.Size(59, 23)
		Me.lblDriverCurrentBlobArea.TabIndex = 163
		'
		'lblFitDriver
		'
		Me.lblFitDriver.BackColor = System.Drawing.SystemColors.Control
		Me.lblFitDriver.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblFitDriver.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblFitDriver.ForeColor = System.Drawing.SystemColors.Highlight
		Me.lblFitDriver.Location = New System.Drawing.Point(230, 66)
		Me.lblFitDriver.Name = "lblFitDriver"
		Me.lblFitDriver.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblFitDriver.Size = New System.Drawing.Size(10, 21)
		Me.lblFitDriver.TabIndex = 160
		Me.lblFitDriver.Text = ":"
		'
		'lblVisionPoseFirDriver
		'
		Me.lblVisionPoseFirDriver.BackColor = System.Drawing.SystemColors.Control
		Me.lblVisionPoseFirDriver.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblVisionPoseFirDriver.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblVisionPoseFirDriver.ForeColor = System.Drawing.SystemColors.Highlight
		Me.lblVisionPoseFirDriver.Location = New System.Drawing.Point(202, 67)
		Me.lblVisionPoseFirDriver.Name = "lblVisionPoseFirDriver"
		Me.lblVisionPoseFirDriver.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblVisionPoseFirDriver.Size = New System.Drawing.Size(20, 17)
		Me.lblVisionPoseFirDriver.TabIndex = 159
		Me.lblVisionPoseFirDriver.Text = "Fit"
		'
		'lblVisionPoseFitDriver
		'
		Me.lblVisionPoseFitDriver.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblVisionPoseFitDriver.Location = New System.Drawing.Point(246, 64)
		Me.lblVisionPoseFitDriver.Name = "lblVisionPoseFitDriver"
		Me.lblVisionPoseFitDriver.Size = New System.Drawing.Size(62, 23)
		Me.lblVisionPoseFitDriver.TabIndex = 158
		'
		'lblVisionPoseScoreDriver
		'
		Me.lblVisionPoseScoreDriver.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblVisionPoseScoreDriver.Location = New System.Drawing.Point(249, 114)
		Me.lblVisionPoseScoreDriver.Name = "lblVisionPoseScoreDriver"
		Me.lblVisionPoseScoreDriver.Size = New System.Drawing.Size(59, 23)
		Me.lblVisionPoseScoreDriver.TabIndex = 154
		'
		'lblVisionPoseTimeDriver
		'
		Me.lblVisionPoseTimeDriver.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblVisionPoseTimeDriver.Location = New System.Drawing.Point(189, 114)
		Me.lblVisionPoseTimeDriver.Name = "lblVisionPoseTimeDriver"
		Me.lblVisionPoseTimeDriver.Size = New System.Drawing.Size(59, 23)
		Me.lblVisionPoseTimeDriver.TabIndex = 153
		'
		'lblVisionPoseRDriver
		'
		Me.lblVisionPoseRDriver.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblVisionPoseRDriver.Location = New System.Drawing.Point(129, 114)
		Me.lblVisionPoseRDriver.Name = "lblVisionPoseRDriver"
		Me.lblVisionPoseRDriver.Size = New System.Drawing.Size(59, 23)
		Me.lblVisionPoseRDriver.TabIndex = 152
		'
		'lblVisionPoseYDriver
		'
		Me.lblVisionPoseYDriver.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblVisionPoseYDriver.Location = New System.Drawing.Point(69, 114)
		Me.lblVisionPoseYDriver.Name = "lblVisionPoseYDriver"
		Me.lblVisionPoseYDriver.Size = New System.Drawing.Size(59, 23)
		Me.lblVisionPoseYDriver.TabIndex = 151
		'
		'lblVisionPoseXDriver
		'
		Me.lblVisionPoseXDriver.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblVisionPoseXDriver.Location = New System.Drawing.Point(9, 114)
		Me.lblVisionPoseXDriver.Name = "lblVisionPoseXDriver"
		Me.lblVisionPoseXDriver.Size = New System.Drawing.Size(59, 23)
		Me.lblVisionPoseXDriver.TabIndex = 150
		'
		'lblVisionXDriver
		'
		Me.lblVisionXDriver.BackColor = System.Drawing.SystemColors.Control
		Me.lblVisionXDriver.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblVisionXDriver.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblVisionXDriver.ForeColor = System.Drawing.SystemColors.Highlight
		Me.lblVisionXDriver.Location = New System.Drawing.Point(27, 95)
		Me.lblVisionXDriver.Name = "lblVisionXDriver"
		Me.lblVisionXDriver.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblVisionXDriver.Size = New System.Drawing.Size(34, 17)
		Me.lblVisionXDriver.TabIndex = 55
		Me.lblVisionXDriver.Text = "X"
		'
		'lblVisionYDriver
		'
		Me.lblVisionYDriver.BackColor = System.Drawing.SystemColors.Control
		Me.lblVisionYDriver.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblVisionYDriver.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblVisionYDriver.ForeColor = System.Drawing.SystemColors.Highlight
		Me.lblVisionYDriver.Location = New System.Drawing.Point(87, 95)
		Me.lblVisionYDriver.Name = "lblVisionYDriver"
		Me.lblVisionYDriver.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblVisionYDriver.Size = New System.Drawing.Size(34, 17)
		Me.lblVisionYDriver.TabIndex = 54
		Me.lblVisionYDriver.Text = "Y"
		'
		'lblVisionAngleDriver
		'
		Me.lblVisionAngleDriver.BackColor = System.Drawing.SystemColors.Control
		Me.lblVisionAngleDriver.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblVisionAngleDriver.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblVisionAngleDriver.ForeColor = System.Drawing.SystemColors.Highlight
		Me.lblVisionAngleDriver.Location = New System.Drawing.Point(138, 95)
		Me.lblVisionAngleDriver.Name = "lblVisionAngleDriver"
		Me.lblVisionAngleDriver.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblVisionAngleDriver.Size = New System.Drawing.Size(50, 17)
		Me.lblVisionAngleDriver.TabIndex = 53
		Me.lblVisionAngleDriver.Text = "Angle"
		'
		'lblVisionTimeDriver
		'
		Me.lblVisionTimeDriver.BackColor = System.Drawing.SystemColors.Control
		Me.lblVisionTimeDriver.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblVisionTimeDriver.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblVisionTimeDriver.ForeColor = System.Drawing.SystemColors.Highlight
		Me.lblVisionTimeDriver.Location = New System.Drawing.Point(199, 95)
		Me.lblVisionTimeDriver.Name = "lblVisionTimeDriver"
		Me.lblVisionTimeDriver.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblVisionTimeDriver.Size = New System.Drawing.Size(50, 17)
		Me.lblVisionTimeDriver.TabIndex = 52
		Me.lblVisionTimeDriver.Text = "Time"
		'
		'lblVisionScoreDriver
		'
		Me.lblVisionScoreDriver.BackColor = System.Drawing.SystemColors.Control
		Me.lblVisionScoreDriver.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblVisionScoreDriver.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblVisionScoreDriver.ForeColor = System.Drawing.SystemColors.Highlight
		Me.lblVisionScoreDriver.Location = New System.Drawing.Point(258, 95)
		Me.lblVisionScoreDriver.Name = "lblVisionScoreDriver"
		Me.lblVisionScoreDriver.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblVisionScoreDriver.Size = New System.Drawing.Size(50, 17)
		Me.lblVisionScoreDriver.TabIndex = 50
		Me.lblVisionScoreDriver.Text = "Score"
		'
		'grpHSDisplayDriver
		'
		Me.grpHSDisplayDriver.BackColor = System.Drawing.SystemColors.Control
		Me.grpHSDisplayDriver.Controls.Add(Me.HSDisplayDriver)
		Me.grpHSDisplayDriver.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.grpHSDisplayDriver.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.grpHSDisplayDriver.ForeColor = System.Drawing.SystemColors.ControlText
		Me.grpHSDisplayDriver.Location = New System.Drawing.Point(6, 174)
		Me.grpHSDisplayDriver.Name = "grpHSDisplayDriver"
		Me.grpHSDisplayDriver.Padding = New System.Windows.Forms.Padding(0)
		Me.grpHSDisplayDriver.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.grpHSDisplayDriver.Size = New System.Drawing.Size(1502, 745)
		Me.grpHSDisplayDriver.TabIndex = 78
		Me.grpHSDisplayDriver.TabStop = False
		'
		'HSDisplayDriver
		'
		Me.HSDisplayDriver.Enabled = True
		Me.HSDisplayDriver.Location = New System.Drawing.Point(14, 22)
		Me.HSDisplayDriver.Name = "HSDisplayDriver"
		Me.HSDisplayDriver.OcxState = CType(resources.GetObject("HSDisplayDriver.OcxState"), System.Windows.Forms.AxHost.State)
		Me.HSDisplayDriver.Size = New System.Drawing.Size(468, 293)
		Me.HSDisplayDriver.TabIndex = 81
		'
		'tabPageCenterCam
		'
		Me.tabPageCenterCam.BackColor = System.Drawing.SystemColors.Control
		Me.tabPageCenterCam.Controls.Add(Me.grpVisionCenter)
		Me.tabPageCenterCam.Location = New System.Drawing.Point(4, 27)
		Me.tabPageCenterCam.Name = "tabPageCenterCam"
		Me.tabPageCenterCam.Size = New System.Drawing.Size(1522, 927)
		Me.tabPageCenterCam.TabIndex = 3
		Me.tabPageCenterCam.Text = "H Primer - Center"
		'
		'grpVisionCenter
		'
		Me.grpVisionCenter.Controls.Add(Me.grpCameraControlCenter)
		Me.grpVisionCenter.Controls.Add(Me.grpLocatorControlsCenter)
		Me.grpVisionCenter.Controls.Add(Me.grpCenterBlob)
		Me.grpVisionCenter.Controls.Add(Me.grpCameraStatusCenter)
		Me.grpVisionCenter.Controls.Add(Me.grpCenterVisStatus)
		Me.grpVisionCenter.Controls.Add(Me.grpHSDisplayCenter)
		Me.grpVisionCenter.Location = New System.Drawing.Point(6, 4)
		Me.grpVisionCenter.Name = "grpVisionCenter"
		Me.grpVisionCenter.Size = New System.Drawing.Size(1522, 933)
		Me.grpVisionCenter.TabIndex = 80
		Me.grpVisionCenter.TabStop = False
		'
		'grpCameraControlCenter
		'
		Me.grpCameraControlCenter.BackColor = System.Drawing.SystemColors.Control
		Me.grpCameraControlCenter.Controls.Add(Me.lblCamControlAcqTimeCenter)
		Me.grpCameraControlCenter.Controls.Add(Me.lblContrastCenter)
		Me.grpCameraControlCenter.Controls.Add(Me.lblExposureCenter)
		Me.grpCameraControlCenter.Controls.Add(Me.updnContrastCenter)
		Me.grpCameraControlCenter.Controls.Add(Me.updnExposureCenter)
		Me.grpCameraControlCenter.Controls.Add(Me.btnSnapCenter)
		Me.grpCameraControlCenter.Controls.Add(Me.chkSnapRepeatCenter)
		Me.grpCameraControlCenter.Controls.Add(Me.lblCameraTimeCenter)
		Me.grpCameraControlCenter.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.grpCameraControlCenter.ForeColor = System.Drawing.SystemColors.Highlight
		Me.grpCameraControlCenter.Location = New System.Drawing.Point(189, 15)
		Me.grpCameraControlCenter.Name = "grpCameraControlCenter"
		Me.grpCameraControlCenter.Padding = New System.Windows.Forms.Padding(0)
		Me.grpCameraControlCenter.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.grpCameraControlCenter.Size = New System.Drawing.Size(187, 154)
		Me.grpCameraControlCenter.TabIndex = 83
		Me.grpCameraControlCenter.TabStop = False
		Me.grpCameraControlCenter.Text = "Camera Controls"
		'
		'lblCamControlAcqTimeCenter
		'
		Me.lblCamControlAcqTimeCenter.AutoSize = True
		Me.lblCamControlAcqTimeCenter.Location = New System.Drawing.Point(36, 54)
		Me.lblCamControlAcqTimeCenter.Name = "lblCamControlAcqTimeCenter"
		Me.lblCamControlAcqTimeCenter.Size = New System.Drawing.Size(59, 14)
		Me.lblCamControlAcqTimeCenter.TabIndex = 165
		Me.lblCamControlAcqTimeCenter.Text = "Acq Time"
		'
		'lblContrastCenter
		'
		Me.lblContrastCenter.AutoSize = True
		Me.lblContrastCenter.Location = New System.Drawing.Point(40, 99)
		Me.lblContrastCenter.Name = "lblContrastCenter"
		Me.lblContrastCenter.Size = New System.Drawing.Size(55, 14)
		Me.lblContrastCenter.TabIndex = 148
		Me.lblContrastCenter.Text = "Contrast"
		'
		'lblExposureCenter
		'
		Me.lblExposureCenter.AutoSize = True
		Me.lblExposureCenter.Location = New System.Drawing.Point(36, 77)
		Me.lblExposureCenter.Name = "lblExposureCenter"
		Me.lblExposureCenter.Size = New System.Drawing.Size(59, 14)
		Me.lblExposureCenter.TabIndex = 146
		Me.lblExposureCenter.Text = "Exposure"
		'
		'updnContrastCenter
		'
		Me.updnContrastCenter.Increment = New Decimal(New Integer() {10, 0, 0, 0})
		Me.updnContrastCenter.Location = New System.Drawing.Point(101, 97)
		Me.updnContrastCenter.Name = "updnContrastCenter"
		Me.updnContrastCenter.Size = New System.Drawing.Size(49, 20)
		Me.updnContrastCenter.TabIndex = 145
		Me.updnContrastCenter.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
		Me.updnContrastCenter.Value = New Decimal(New Integer() {100, 0, 0, 65536})
		'
		'updnExposureCenter
		'
		Me.updnExposureCenter.Increment = New Decimal(New Integer() {25, 0, 0, 0})
		Me.updnExposureCenter.Location = New System.Drawing.Point(101, 75)
		Me.updnExposureCenter.Maximum = New Decimal(New Integer() {1500, 0, 0, 0})
		Me.updnExposureCenter.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
		Me.updnExposureCenter.Name = "updnExposureCenter"
		Me.updnExposureCenter.Size = New System.Drawing.Size(49, 20)
		Me.updnExposureCenter.TabIndex = 142
		Me.updnExposureCenter.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
		Me.updnExposureCenter.Value = New Decimal(New Integer() {10, 0, 0, 0})
		'
		'chkSnapRepeatCenter
		'
		Me.chkSnapRepeatCenter.BackColor = System.Drawing.SystemColors.Control
		Me.chkSnapRepeatCenter.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkSnapRepeatCenter.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkSnapRepeatCenter.ForeColor = System.Drawing.SystemColors.Highlight
		Me.chkSnapRepeatCenter.Location = New System.Drawing.Point(115, 14)
		Me.chkSnapRepeatCenter.Name = "chkSnapRepeatCenter"
		Me.chkSnapRepeatCenter.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkSnapRepeatCenter.Size = New System.Drawing.Size(62, 24)
		Me.chkSnapRepeatCenter.TabIndex = 72
		Me.chkSnapRepeatCenter.TabStop = False
		Me.chkSnapRepeatCenter.Text = "Repeat"
		Me.chkSnapRepeatCenter.UseVisualStyleBackColor = False
		'
		'lblCameraTimeCenter
		'
		Me.lblCameraTimeCenter.BackColor = System.Drawing.SystemColors.Control
		Me.lblCameraTimeCenter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblCameraTimeCenter.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblCameraTimeCenter.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCameraTimeCenter.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblCameraTimeCenter.Location = New System.Drawing.Point(101, 52)
		Me.lblCameraTimeCenter.Name = "lblCameraTimeCenter"
		Me.lblCameraTimeCenter.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblCameraTimeCenter.Size = New System.Drawing.Size(48, 18)
		Me.lblCameraTimeCenter.TabIndex = 75
		'
		'grpLocatorControlsCenter
		'
		Me.grpLocatorControlsCenter.BackColor = System.Drawing.SystemColors.Control
		Me.grpLocatorControlsCenter.Controls.Add(Me.lblScoreLimitCenter)
		Me.grpLocatorControlsCenter.Controls.Add(Me.btnLocateOnlyCenter)
		Me.grpLocatorControlsCenter.Controls.Add(Me.btnLocateCenter)
		Me.grpLocatorControlsCenter.Controls.Add(Me.updnScoreLimitCenter)
		Me.grpLocatorControlsCenter.Controls.Add(Me.chkLocateCenter)
		Me.grpLocatorControlsCenter.Controls.Add(Me.btnSearchSettingsCenter)
		Me.grpLocatorControlsCenter.Controls.Add(Me.btnTrainNewCenter)
		Me.grpLocatorControlsCenter.Controls.Add(Me.lblLocateTimeCenter)
		Me.grpLocatorControlsCenter.Controls.Add(Me.lblLocatorTimeCenter)
		Me.grpLocatorControlsCenter.Controls.Add(Me.btnTrainExistingCenter)
		Me.grpLocatorControlsCenter.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.grpLocatorControlsCenter.ForeColor = System.Drawing.SystemColors.Highlight
		Me.grpLocatorControlsCenter.Location = New System.Drawing.Point(382, 15)
		Me.grpLocatorControlsCenter.Name = "grpLocatorControlsCenter"
		Me.grpLocatorControlsCenter.Padding = New System.Windows.Forms.Padding(0)
		Me.grpLocatorControlsCenter.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.grpLocatorControlsCenter.Size = New System.Drawing.Size(233, 154)
		Me.grpLocatorControlsCenter.TabIndex = 84
		Me.grpLocatorControlsCenter.TabStop = False
		Me.grpLocatorControlsCenter.Text = "Locator Controls"
		'
		'lblScoreLimitCenter
		'
		Me.lblScoreLimitCenter.AutoSize = True
		Me.lblScoreLimitCenter.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblScoreLimitCenter.ForeColor = System.Drawing.SystemColors.Desktop
		Me.lblScoreLimitCenter.Location = New System.Drawing.Point(128, 55)
		Me.lblScoreLimitCenter.Name = "lblScoreLimitCenter"
		Me.lblScoreLimitCenter.Size = New System.Drawing.Size(70, 14)
		Me.lblScoreLimitCenter.TabIndex = 158
		Me.lblScoreLimitCenter.Text = "Score Limit"
		'
		'chkLocateCenter
		'
		Me.chkLocateCenter.BackColor = System.Drawing.SystemColors.Control
		Me.chkLocateCenter.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkLocateCenter.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkLocateCenter.ForeColor = System.Drawing.SystemColors.Highlight
		Me.chkLocateCenter.Location = New System.Drawing.Point(123, 14)
		Me.chkLocateCenter.Name = "chkLocateCenter"
		Me.chkLocateCenter.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkLocateCenter.Size = New System.Drawing.Size(68, 24)
		Me.chkLocateCenter.TabIndex = 60
		Me.chkLocateCenter.TabStop = False
		Me.chkLocateCenter.Text = "Repeat"
		Me.chkLocateCenter.UseVisualStyleBackColor = False
		'
		'lblLocateTimeCenter
		'
		Me.lblLocateTimeCenter.BackColor = System.Drawing.SystemColors.Control
		Me.lblLocateTimeCenter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblLocateTimeCenter.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblLocateTimeCenter.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblLocateTimeCenter.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblLocateTimeCenter.Location = New System.Drawing.Point(51, 54)
		Me.lblLocateTimeCenter.Name = "lblLocateTimeCenter"
		Me.lblLocateTimeCenter.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblLocateTimeCenter.Size = New System.Drawing.Size(55, 18)
		Me.lblLocateTimeCenter.TabIndex = 67
		'
		'lblLocatorTimeCenter
		'
		Me.lblLocatorTimeCenter.AutoSize = True
		Me.lblLocatorTimeCenter.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblLocatorTimeCenter.ForeColor = System.Drawing.SystemColors.Desktop
		Me.lblLocatorTimeCenter.Location = New System.Drawing.Point(20, 56)
		Me.lblLocatorTimeCenter.Name = "lblLocatorTimeCenter"
		Me.lblLocatorTimeCenter.Size = New System.Drawing.Size(29, 14)
		Me.lblLocatorTimeCenter.TabIndex = 157
		Me.lblLocatorTimeCenter.Text = "Time"
		'
		'grpCenterBlob
		'
		Me.grpCenterBlob.Controls.Add(Me.btnCenterTrainBlob)
		Me.grpCenterBlob.Controls.Add(Me.btnCenterSaveBlob)
		Me.grpCenterBlob.Controls.Add(Me.lblTrackCenterValue)
		Me.grpCenterBlob.Controls.Add(Me.trkCenterBlob)
		Me.grpCenterBlob.Controls.Add(Me.lblCenterBlobArea)
		Me.grpCenterBlob.Controls.Add(Me.btnSaveCenterBlobArea)
		Me.grpCenterBlob.Controls.Add(Me.lblMaxBlobCountCenter)
		Me.grpCenterBlob.Controls.Add(Me.lblMinimumBlobCountCenter)
		Me.grpCenterBlob.Controls.Add(Me.updnCenterBlobThresholdMax)
		Me.grpCenterBlob.Controls.Add(Me.updnCenterBlobThresholdMin)
		Me.grpCenterBlob.Location = New System.Drawing.Point(947, 15)
		Me.grpCenterBlob.Name = "grpCenterBlob"
		Me.grpCenterBlob.Size = New System.Drawing.Size(350, 154)
		Me.grpCenterBlob.TabIndex = 85
		Me.grpCenterBlob.TabStop = False
		'
		'lblTrackCenterValue
		'
		Me.lblTrackCenterValue.AutoSize = True
		Me.lblTrackCenterValue.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblTrackCenterValue.Location = New System.Drawing.Point(123, 115)
		Me.lblTrackCenterValue.Name = "lblTrackCenterValue"
		Me.lblTrackCenterValue.Size = New System.Drawing.Size(91, 16)
		Me.lblTrackCenterValue.TabIndex = 11
		Me.lblTrackCenterValue.Text = "Minimum Area"
		Me.lblTrackCenterValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'trkCenterBlob
		'
		Me.trkCenterBlob.Location = New System.Drawing.Point(126, 86)
		Me.trkCenterBlob.Maximum = 100
		Me.trkCenterBlob.Name = "trkCenterBlob"
		Me.trkCenterBlob.Size = New System.Drawing.Size(152, 45)
		Me.trkCenterBlob.TabIndex = 10
		'
		'lblCenterBlobArea
		'
		Me.lblCenterBlobArea.AutoSize = True
		Me.lblCenterBlobArea.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCenterBlobArea.Location = New System.Drawing.Point(6, 80)
		Me.lblCenterBlobArea.Name = "lblCenterBlobArea"
		Me.lblCenterBlobArea.Size = New System.Drawing.Size(77, 16)
		Me.lblCenterBlobArea.TabIndex = 9
		Me.lblCenterBlobArea.Text = "Saved Area:"
		'
		'btnSaveCenterBlobArea
		'
		Me.btnSaveCenterBlobArea.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnSaveCenterBlobArea.Location = New System.Drawing.Point(4, 100)
		Me.btnSaveCenterBlobArea.Name = "btnSaveCenterBlobArea"
		Me.btnSaveCenterBlobArea.Size = New System.Drawing.Size(105, 32)
		Me.btnSaveCenterBlobArea.TabIndex = 8
		Me.btnSaveCenterBlobArea.Text = "Save Blob Area"
		Me.btnSaveCenterBlobArea.UseVisualStyleBackColor = True
		'
		'lblMaxBlobCountCenter
		'
		Me.lblMaxBlobCountCenter.AutoSize = True
		Me.lblMaxBlobCountCenter.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblMaxBlobCountCenter.Location = New System.Drawing.Point(16, 52)
		Me.lblMaxBlobCountCenter.Name = "lblMaxBlobCountCenter"
		Me.lblMaxBlobCountCenter.Size = New System.Drawing.Size(173, 16)
		Me.lblMaxBlobCountCenter.TabIndex = 3
		Me.lblMaxBlobCountCenter.Text = "Maximum Primer Brightness"
		'
		'lblMinimumBlobCountCenter
		'
		Me.lblMinimumBlobCountCenter.AutoSize = True
		Me.lblMinimumBlobCountCenter.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblMinimumBlobCountCenter.Location = New System.Drawing.Point(16, 18)
		Me.lblMinimumBlobCountCenter.Name = "lblMinimumBlobCountCenter"
		Me.lblMinimumBlobCountCenter.Size = New System.Drawing.Size(169, 16)
		Me.lblMinimumBlobCountCenter.TabIndex = 2
		Me.lblMinimumBlobCountCenter.Text = "Minimum Primer Brightness"
		'
		'updnCenterBlobThresholdMax
		'
		Me.updnCenterBlobThresholdMax.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.updnCenterBlobThresholdMax.Location = New System.Drawing.Point(189, 52)
		Me.updnCenterBlobThresholdMax.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
		Me.updnCenterBlobThresholdMax.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.updnCenterBlobThresholdMax.Name = "updnCenterBlobThresholdMax"
		Me.updnCenterBlobThresholdMax.Size = New System.Drawing.Size(70, 22)
		Me.updnCenterBlobThresholdMax.TabIndex = 1
		Me.updnCenterBlobThresholdMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.updnCenterBlobThresholdMax.Value = New Decimal(New Integer() {1, 0, 0, 0})
		'
		'updnCenterBlobThresholdMin
		'
		Me.updnCenterBlobThresholdMin.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.updnCenterBlobThresholdMin.Location = New System.Drawing.Point(189, 17)
		Me.updnCenterBlobThresholdMin.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
		Me.updnCenterBlobThresholdMin.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.updnCenterBlobThresholdMin.Name = "updnCenterBlobThresholdMin"
		Me.updnCenterBlobThresholdMin.Size = New System.Drawing.Size(70, 22)
		Me.updnCenterBlobThresholdMin.TabIndex = 0
		Me.updnCenterBlobThresholdMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.updnCenterBlobThresholdMin.Value = New Decimal(New Integer() {1, 0, 0, 0})
		'
		'grpCameraStatusCenter
		'
		Me.grpCameraStatusCenter.Controls.Add(Me.lblCameraStatusCenterWarning)
		Me.grpCameraStatusCenter.Controls.Add(Me.lblTemperatureCenter)
		Me.grpCameraStatusCenter.Controls.Add(Me.pbCenterCameraStatus)
		Me.grpCameraStatusCenter.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
		Me.grpCameraStatusCenter.ForeColor = System.Drawing.SystemColors.Highlight
		Me.grpCameraStatusCenter.Location = New System.Drawing.Point(10, 15)
		Me.grpCameraStatusCenter.Name = "grpCameraStatusCenter"
		Me.grpCameraStatusCenter.Size = New System.Drawing.Size(173, 154)
		Me.grpCameraStatusCenter.TabIndex = 84
		Me.grpCameraStatusCenter.TabStop = False
		Me.grpCameraStatusCenter.Text = "Camera Status"
		'
		'lblCameraStatusCenterWarning
		'
		Me.lblCameraStatusCenterWarning.AutoSize = True
		Me.lblCameraStatusCenterWarning.Font = New System.Drawing.Font("Arial Black", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCameraStatusCenterWarning.ForeColor = System.Drawing.Color.DarkRed
		Me.lblCameraStatusCenterWarning.Location = New System.Drawing.Point(37, 21)
		Me.lblCameraStatusCenterWarning.Name = "lblCameraStatusCenterWarning"
		Me.lblCameraStatusCenterWarning.Size = New System.Drawing.Size(114, 51)
		Me.lblCameraStatusCenterWarning.TabIndex = 161
		Me.lblCameraStatusCenterWarning.Text = "       Warning! " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  The Camera is " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  not connected"
		Me.lblCameraStatusCenterWarning.Visible = False
		'
		'lblTemperatureCenter
		'
		Me.lblTemperatureCenter.BackColor = System.Drawing.SystemColors.ButtonShadow
		Me.lblTemperatureCenter.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblTemperatureCenter.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblTemperatureCenter.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblTemperatureCenter.Location = New System.Drawing.Point(6, 97)
		Me.lblTemperatureCenter.Name = "lblTemperatureCenter"
		Me.lblTemperatureCenter.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblTemperatureCenter.Size = New System.Drawing.Size(39, 48)
		Me.lblTemperatureCenter.TabIndex = 160
		Me.lblTemperatureCenter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'pbCenterCameraStatus
		'
		Me.pbCenterCameraStatus.Image = CType(resources.GetObject("pbCenterCameraStatus.Image"), System.Drawing.Image)
		Me.pbCenterCameraStatus.Location = New System.Drawing.Point(11, 32)
		Me.pbCenterCameraStatus.Name = "pbCenterCameraStatus"
		Me.pbCenterCameraStatus.Size = New System.Drawing.Size(25, 60)
		Me.pbCenterCameraStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.pbCenterCameraStatus.TabIndex = 159
		Me.pbCenterCameraStatus.TabStop = False
		'
		'grpCenterVisStatus
		'
		Me.grpCenterVisStatus.BackColor = System.Drawing.SystemColors.Control
		Me.grpCenterVisStatus.Controls.Add(Me.lblCenterCurrentBlobAreaDesc)
		Me.grpCenterVisStatus.Controls.Add(Me.lblCenterCurrentBlobArea)
		Me.grpCenterVisStatus.Controls.Add(Me.lblFitCenter)
		Me.grpCenterVisStatus.Controls.Add(Me.lblVisionPoseFirCenter)
		Me.grpCenterVisStatus.Controls.Add(Me.lblVisionPoseFitCenter)
		Me.grpCenterVisStatus.Controls.Add(Me.lblVisionPoseScoreCenter)
		Me.grpCenterVisStatus.Controls.Add(Me.lblVisionPoseTimeCenter)
		Me.grpCenterVisStatus.Controls.Add(Me.lblVisionPoseRCenter)
		Me.grpCenterVisStatus.Controls.Add(Me.lblVisionPoseYCenter)
		Me.grpCenterVisStatus.Controls.Add(Me.lblVisionPoseXCenter)
		Me.grpCenterVisStatus.Controls.Add(Me.btnDetailsCenter)
		Me.grpCenterVisStatus.Controls.Add(Me.lblVisionMessageCenter)
		Me.grpCenterVisStatus.Controls.Add(Me.lblVisionXCenter)
		Me.grpCenterVisStatus.Controls.Add(Me.lblVisionYCenter)
		Me.grpCenterVisStatus.Controls.Add(Me.lblVisionAngleCenter)
		Me.grpCenterVisStatus.Controls.Add(Me.lblVisionTimeCenter)
		Me.grpCenterVisStatus.Controls.Add(Me.lblVisionScoreCenter)
		Me.grpCenterVisStatus.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.grpCenterVisStatus.ForeColor = System.Drawing.SystemColors.Highlight
		Me.grpCenterVisStatus.Location = New System.Drawing.Point(621, 15)
		Me.grpCenterVisStatus.Name = "grpCenterVisStatus"
		Me.grpCenterVisStatus.Padding = New System.Windows.Forms.Padding(0)
		Me.grpCenterVisStatus.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.grpCenterVisStatus.Size = New System.Drawing.Size(320, 154)
		Me.grpCenterVisStatus.TabIndex = 80
		Me.grpCenterVisStatus.TabStop = False
		Me.grpCenterVisStatus.Text = "Status"
		'
		'lblCenterCurrentBlobAreaDesc
		'
		Me.lblCenterCurrentBlobAreaDesc.BackColor = System.Drawing.SystemColors.Control
		Me.lblCenterCurrentBlobAreaDesc.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblCenterCurrentBlobAreaDesc.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCenterCurrentBlobAreaDesc.ForeColor = System.Drawing.SystemColors.Highlight
		Me.lblCenterCurrentBlobAreaDesc.Location = New System.Drawing.Point(71, 70)
		Me.lblCenterCurrentBlobAreaDesc.Name = "lblCenterCurrentBlobAreaDesc"
		Me.lblCenterCurrentBlobAreaDesc.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblCenterCurrentBlobAreaDesc.Size = New System.Drawing.Size(66, 17)
		Me.lblCenterCurrentBlobAreaDesc.TabIndex = 166
		Me.lblCenterCurrentBlobAreaDesc.Text = "Blob Area"
		'
		'lblCenterCurrentBlobArea
		'
		Me.lblCenterCurrentBlobArea.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblCenterCurrentBlobArea.Location = New System.Drawing.Point(141, 64)
		Me.lblCenterCurrentBlobArea.Name = "lblCenterCurrentBlobArea"
		Me.lblCenterCurrentBlobArea.Size = New System.Drawing.Size(59, 23)
		Me.lblCenterCurrentBlobArea.TabIndex = 165
		'
		'lblFitCenter
		'
		Me.lblFitCenter.BackColor = System.Drawing.SystemColors.Control
		Me.lblFitCenter.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblFitCenter.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblFitCenter.ForeColor = System.Drawing.SystemColors.Highlight
		Me.lblFitCenter.Location = New System.Drawing.Point(230, 66)
		Me.lblFitCenter.Name = "lblFitCenter"
		Me.lblFitCenter.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblFitCenter.Size = New System.Drawing.Size(10, 21)
		Me.lblFitCenter.TabIndex = 160
		Me.lblFitCenter.Text = ":"
		'
		'lblVisionPoseFirCenter
		'
		Me.lblVisionPoseFirCenter.BackColor = System.Drawing.SystemColors.Control
		Me.lblVisionPoseFirCenter.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblVisionPoseFirCenter.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblVisionPoseFirCenter.ForeColor = System.Drawing.SystemColors.Highlight
		Me.lblVisionPoseFirCenter.Location = New System.Drawing.Point(202, 67)
		Me.lblVisionPoseFirCenter.Name = "lblVisionPoseFirCenter"
		Me.lblVisionPoseFirCenter.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblVisionPoseFirCenter.Size = New System.Drawing.Size(20, 17)
		Me.lblVisionPoseFirCenter.TabIndex = 159
		Me.lblVisionPoseFirCenter.Text = "Fit"
		'
		'lblVisionPoseFitCenter
		'
		Me.lblVisionPoseFitCenter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblVisionPoseFitCenter.Location = New System.Drawing.Point(246, 64)
		Me.lblVisionPoseFitCenter.Name = "lblVisionPoseFitCenter"
		Me.lblVisionPoseFitCenter.Size = New System.Drawing.Size(62, 23)
		Me.lblVisionPoseFitCenter.TabIndex = 158
		'
		'lblVisionPoseScoreCenter
		'
		Me.lblVisionPoseScoreCenter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblVisionPoseScoreCenter.Location = New System.Drawing.Point(249, 114)
		Me.lblVisionPoseScoreCenter.Name = "lblVisionPoseScoreCenter"
		Me.lblVisionPoseScoreCenter.Size = New System.Drawing.Size(59, 23)
		Me.lblVisionPoseScoreCenter.TabIndex = 154
		'
		'lblVisionPoseTimeCenter
		'
		Me.lblVisionPoseTimeCenter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblVisionPoseTimeCenter.Location = New System.Drawing.Point(189, 114)
		Me.lblVisionPoseTimeCenter.Name = "lblVisionPoseTimeCenter"
		Me.lblVisionPoseTimeCenter.Size = New System.Drawing.Size(59, 23)
		Me.lblVisionPoseTimeCenter.TabIndex = 153
		'
		'lblVisionPoseRCenter
		'
		Me.lblVisionPoseRCenter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblVisionPoseRCenter.Location = New System.Drawing.Point(129, 114)
		Me.lblVisionPoseRCenter.Name = "lblVisionPoseRCenter"
		Me.lblVisionPoseRCenter.Size = New System.Drawing.Size(59, 23)
		Me.lblVisionPoseRCenter.TabIndex = 152
		'
		'lblVisionPoseYCenter
		'
		Me.lblVisionPoseYCenter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblVisionPoseYCenter.Location = New System.Drawing.Point(69, 114)
		Me.lblVisionPoseYCenter.Name = "lblVisionPoseYCenter"
		Me.lblVisionPoseYCenter.Size = New System.Drawing.Size(59, 23)
		Me.lblVisionPoseYCenter.TabIndex = 151
		'
		'lblVisionPoseXCenter
		'
		Me.lblVisionPoseXCenter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblVisionPoseXCenter.Location = New System.Drawing.Point(9, 114)
		Me.lblVisionPoseXCenter.Name = "lblVisionPoseXCenter"
		Me.lblVisionPoseXCenter.Size = New System.Drawing.Size(59, 23)
		Me.lblVisionPoseXCenter.TabIndex = 150
		'
		'lblVisionXCenter
		'
		Me.lblVisionXCenter.BackColor = System.Drawing.SystemColors.Control
		Me.lblVisionXCenter.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblVisionXCenter.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblVisionXCenter.ForeColor = System.Drawing.SystemColors.Highlight
		Me.lblVisionXCenter.Location = New System.Drawing.Point(27, 95)
		Me.lblVisionXCenter.Name = "lblVisionXCenter"
		Me.lblVisionXCenter.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblVisionXCenter.Size = New System.Drawing.Size(34, 17)
		Me.lblVisionXCenter.TabIndex = 55
		Me.lblVisionXCenter.Text = "X"
		'
		'lblVisionYCenter
		'
		Me.lblVisionYCenter.BackColor = System.Drawing.SystemColors.Control
		Me.lblVisionYCenter.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblVisionYCenter.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblVisionYCenter.ForeColor = System.Drawing.SystemColors.Highlight
		Me.lblVisionYCenter.Location = New System.Drawing.Point(87, 95)
		Me.lblVisionYCenter.Name = "lblVisionYCenter"
		Me.lblVisionYCenter.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblVisionYCenter.Size = New System.Drawing.Size(34, 17)
		Me.lblVisionYCenter.TabIndex = 54
		Me.lblVisionYCenter.Text = "Y"
		'
		'lblVisionAngleCenter
		'
		Me.lblVisionAngleCenter.BackColor = System.Drawing.SystemColors.Control
		Me.lblVisionAngleCenter.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblVisionAngleCenter.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblVisionAngleCenter.ForeColor = System.Drawing.SystemColors.Highlight
		Me.lblVisionAngleCenter.Location = New System.Drawing.Point(138, 95)
		Me.lblVisionAngleCenter.Name = "lblVisionAngleCenter"
		Me.lblVisionAngleCenter.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblVisionAngleCenter.Size = New System.Drawing.Size(50, 17)
		Me.lblVisionAngleCenter.TabIndex = 53
		Me.lblVisionAngleCenter.Text = "Angle"
		'
		'lblVisionTimeCenter
		'
		Me.lblVisionTimeCenter.BackColor = System.Drawing.SystemColors.Control
		Me.lblVisionTimeCenter.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblVisionTimeCenter.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblVisionTimeCenter.ForeColor = System.Drawing.SystemColors.Highlight
		Me.lblVisionTimeCenter.Location = New System.Drawing.Point(199, 95)
		Me.lblVisionTimeCenter.Name = "lblVisionTimeCenter"
		Me.lblVisionTimeCenter.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblVisionTimeCenter.Size = New System.Drawing.Size(50, 17)
		Me.lblVisionTimeCenter.TabIndex = 52
		Me.lblVisionTimeCenter.Text = "Time"
		'
		'lblVisionScoreCenter
		'
		Me.lblVisionScoreCenter.BackColor = System.Drawing.SystemColors.Control
		Me.lblVisionScoreCenter.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblVisionScoreCenter.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblVisionScoreCenter.ForeColor = System.Drawing.SystemColors.Highlight
		Me.lblVisionScoreCenter.Location = New System.Drawing.Point(258, 95)
		Me.lblVisionScoreCenter.Name = "lblVisionScoreCenter"
		Me.lblVisionScoreCenter.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblVisionScoreCenter.Size = New System.Drawing.Size(50, 17)
		Me.lblVisionScoreCenter.TabIndex = 50
		Me.lblVisionScoreCenter.Text = "Score"
		'
		'grpHSDisplayCenter
		'
		Me.grpHSDisplayCenter.BackColor = System.Drawing.SystemColors.Control
		Me.grpHSDisplayCenter.Controls.Add(Me.HSDisplayCenter)
		Me.grpHSDisplayCenter.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.grpHSDisplayCenter.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.grpHSDisplayCenter.ForeColor = System.Drawing.SystemColors.ControlText
		Me.grpHSDisplayCenter.Location = New System.Drawing.Point(6, 174)
		Me.grpHSDisplayCenter.Name = "grpHSDisplayCenter"
		Me.grpHSDisplayCenter.Padding = New System.Windows.Forms.Padding(0)
		Me.grpHSDisplayCenter.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.grpHSDisplayCenter.Size = New System.Drawing.Size(1502, 745)
		Me.grpHSDisplayCenter.TabIndex = 79
		Me.grpHSDisplayCenter.TabStop = False
		'
		'HSDisplayCenter
		'
		Me.HSDisplayCenter.Enabled = True
		Me.HSDisplayCenter.Location = New System.Drawing.Point(14, 22)
		Me.HSDisplayCenter.Name = "HSDisplayCenter"
		Me.HSDisplayCenter.OcxState = CType(resources.GetObject("HSDisplayCenter.OcxState"), System.Windows.Forms.AxHost.State)
		Me.HSDisplayCenter.Size = New System.Drawing.Size(468, 293)
		Me.HSDisplayCenter.TabIndex = 81
		'
		'tabPagePassCam
		'
		Me.tabPagePassCam.BackColor = System.Drawing.SystemColors.Control
		Me.tabPagePassCam.Controls.Add(Me.grpVisionPassenger)
		Me.tabPagePassCam.Location = New System.Drawing.Point(4, 27)
		Me.tabPagePassCam.Name = "tabPagePassCam"
		Me.tabPagePassCam.Size = New System.Drawing.Size(1522, 927)
		Me.tabPagePassCam.TabIndex = 4
		Me.tabPagePassCam.Text = "Aron Mighty - Passenger"
		'
		'grpVisionPassenger
		'
		Me.grpVisionPassenger.Controls.Add(Me.grpCameraControlPassenger)
		Me.grpVisionPassenger.Controls.Add(Me.grpLocatorControlsPassenger)
		Me.grpVisionPassenger.Controls.Add(Me.grpPassengerThreshold)
		Me.grpVisionPassenger.Controls.Add(Me.grpPassengerCameraStatus)
		Me.grpVisionPassenger.Controls.Add(Me.grpPassengerVisStatus)
		Me.grpVisionPassenger.Controls.Add(Me.grpHSDisplayPassenger)
		Me.grpVisionPassenger.Location = New System.Drawing.Point(6, 4)
		Me.grpVisionPassenger.Name = "grpVisionPassenger"
		Me.grpVisionPassenger.Size = New System.Drawing.Size(1522, 933)
		Me.grpVisionPassenger.TabIndex = 81
		Me.grpVisionPassenger.TabStop = False
		'
		'grpCameraControlPassenger
		'
		Me.grpCameraControlPassenger.BackColor = System.Drawing.SystemColors.Control
		Me.grpCameraControlPassenger.Controls.Add(Me.lblCamControlAcqTimePassenger)
		Me.grpCameraControlPassenger.Controls.Add(Me.lblContrastPassenger)
		Me.grpCameraControlPassenger.Controls.Add(Me.lblExposurePassenger)
		Me.grpCameraControlPassenger.Controls.Add(Me.updnContrastPassenger)
		Me.grpCameraControlPassenger.Controls.Add(Me.updnExposurePassenger)
		Me.grpCameraControlPassenger.Controls.Add(Me.btnSnapPassenger)
		Me.grpCameraControlPassenger.Controls.Add(Me.chkSnapRepeatPassenger)
		Me.grpCameraControlPassenger.Controls.Add(Me.lblCameraTimePassenger)
		Me.grpCameraControlPassenger.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.grpCameraControlPassenger.ForeColor = System.Drawing.SystemColors.Highlight
		Me.grpCameraControlPassenger.Location = New System.Drawing.Point(189, 15)
		Me.grpCameraControlPassenger.Name = "grpCameraControlPassenger"
		Me.grpCameraControlPassenger.Padding = New System.Windows.Forms.Padding(0)
		Me.grpCameraControlPassenger.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.grpCameraControlPassenger.Size = New System.Drawing.Size(187, 154)
		Me.grpCameraControlPassenger.TabIndex = 83
		Me.grpCameraControlPassenger.TabStop = False
		Me.grpCameraControlPassenger.Text = "Camera Controls"
		'
		'lblCamControlAcqTimePassenger
		'
		Me.lblCamControlAcqTimePassenger.AutoSize = True
		Me.lblCamControlAcqTimePassenger.Location = New System.Drawing.Point(36, 54)
		Me.lblCamControlAcqTimePassenger.Name = "lblCamControlAcqTimePassenger"
		Me.lblCamControlAcqTimePassenger.Size = New System.Drawing.Size(59, 14)
		Me.lblCamControlAcqTimePassenger.TabIndex = 165
		Me.lblCamControlAcqTimePassenger.Text = "Acq Time"
		'
		'lblContrastPassenger
		'
		Me.lblContrastPassenger.AutoSize = True
		Me.lblContrastPassenger.Location = New System.Drawing.Point(40, 99)
		Me.lblContrastPassenger.Name = "lblContrastPassenger"
		Me.lblContrastPassenger.Size = New System.Drawing.Size(55, 14)
		Me.lblContrastPassenger.TabIndex = 148
		Me.lblContrastPassenger.Text = "Contrast"
		'
		'lblExposurePassenger
		'
		Me.lblExposurePassenger.AutoSize = True
		Me.lblExposurePassenger.Location = New System.Drawing.Point(36, 77)
		Me.lblExposurePassenger.Name = "lblExposurePassenger"
		Me.lblExposurePassenger.Size = New System.Drawing.Size(59, 14)
		Me.lblExposurePassenger.TabIndex = 146
		Me.lblExposurePassenger.Text = "Exposure"
		'
		'updnContrastPassenger
		'
		Me.updnContrastPassenger.Increment = New Decimal(New Integer() {10, 0, 0, 0})
		Me.updnContrastPassenger.Location = New System.Drawing.Point(101, 97)
		Me.updnContrastPassenger.Name = "updnContrastPassenger"
		Me.updnContrastPassenger.Size = New System.Drawing.Size(49, 20)
		Me.updnContrastPassenger.TabIndex = 145
		Me.updnContrastPassenger.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
		Me.updnContrastPassenger.Value = New Decimal(New Integer() {100, 0, 0, 65536})
		'
		'updnExposurePassenger
		'
		Me.updnExposurePassenger.Increment = New Decimal(New Integer() {25, 0, 0, 0})
		Me.updnExposurePassenger.Location = New System.Drawing.Point(101, 75)
		Me.updnExposurePassenger.Maximum = New Decimal(New Integer() {1500, 0, 0, 0})
		Me.updnExposurePassenger.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
		Me.updnExposurePassenger.Name = "updnExposurePassenger"
		Me.updnExposurePassenger.Size = New System.Drawing.Size(49, 20)
		Me.updnExposurePassenger.TabIndex = 142
		Me.updnExposurePassenger.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
		Me.updnExposurePassenger.Value = New Decimal(New Integer() {10, 0, 0, 0})
		'
		'chkSnapRepeatPassenger
		'
		Me.chkSnapRepeatPassenger.BackColor = System.Drawing.SystemColors.Control
		Me.chkSnapRepeatPassenger.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkSnapRepeatPassenger.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkSnapRepeatPassenger.ForeColor = System.Drawing.SystemColors.Highlight
		Me.chkSnapRepeatPassenger.Location = New System.Drawing.Point(115, 14)
		Me.chkSnapRepeatPassenger.Name = "chkSnapRepeatPassenger"
		Me.chkSnapRepeatPassenger.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkSnapRepeatPassenger.Size = New System.Drawing.Size(62, 24)
		Me.chkSnapRepeatPassenger.TabIndex = 72
		Me.chkSnapRepeatPassenger.TabStop = False
		Me.chkSnapRepeatPassenger.Text = "Repeat"
		Me.chkSnapRepeatPassenger.UseVisualStyleBackColor = False
		'
		'lblCameraTimePassenger
		'
		Me.lblCameraTimePassenger.BackColor = System.Drawing.SystemColors.Control
		Me.lblCameraTimePassenger.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblCameraTimePassenger.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblCameraTimePassenger.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCameraTimePassenger.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblCameraTimePassenger.Location = New System.Drawing.Point(101, 52)
		Me.lblCameraTimePassenger.Name = "lblCameraTimePassenger"
		Me.lblCameraTimePassenger.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblCameraTimePassenger.Size = New System.Drawing.Size(48, 18)
		Me.lblCameraTimePassenger.TabIndex = 75
		'
		'grpLocatorControlsPassenger
		'
		Me.grpLocatorControlsPassenger.BackColor = System.Drawing.SystemColors.Control
		Me.grpLocatorControlsPassenger.Controls.Add(Me.lblScoreLimitPassenger)
		Me.grpLocatorControlsPassenger.Controls.Add(Me.btnLocateOnlyPassenger)
		Me.grpLocatorControlsPassenger.Controls.Add(Me.btnLocatePassenger)
		Me.grpLocatorControlsPassenger.Controls.Add(Me.updnScoreLimitPassenger)
		Me.grpLocatorControlsPassenger.Controls.Add(Me.chkLocatePassenger)
		Me.grpLocatorControlsPassenger.Controls.Add(Me.btnSearchSettingsPassenger)
		Me.grpLocatorControlsPassenger.Controls.Add(Me.btnTrainNewPassenger)
		Me.grpLocatorControlsPassenger.Controls.Add(Me.lblLocateTimePassenger)
		Me.grpLocatorControlsPassenger.Controls.Add(Me.lblLocatorTimePassenger)
		Me.grpLocatorControlsPassenger.Controls.Add(Me.btnTrainExistingPassenger)
		Me.grpLocatorControlsPassenger.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.grpLocatorControlsPassenger.ForeColor = System.Drawing.SystemColors.Highlight
		Me.grpLocatorControlsPassenger.Location = New System.Drawing.Point(382, 15)
		Me.grpLocatorControlsPassenger.Name = "grpLocatorControlsPassenger"
		Me.grpLocatorControlsPassenger.Padding = New System.Windows.Forms.Padding(0)
		Me.grpLocatorControlsPassenger.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.grpLocatorControlsPassenger.Size = New System.Drawing.Size(233, 154)
		Me.grpLocatorControlsPassenger.TabIndex = 84
		Me.grpLocatorControlsPassenger.TabStop = False
		Me.grpLocatorControlsPassenger.Text = "Locator Controls"
		'
		'lblScoreLimitPassenger
		'
		Me.lblScoreLimitPassenger.AutoSize = True
		Me.lblScoreLimitPassenger.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblScoreLimitPassenger.ForeColor = System.Drawing.SystemColors.Desktop
		Me.lblScoreLimitPassenger.Location = New System.Drawing.Point(128, 55)
		Me.lblScoreLimitPassenger.Name = "lblScoreLimitPassenger"
		Me.lblScoreLimitPassenger.Size = New System.Drawing.Size(70, 14)
		Me.lblScoreLimitPassenger.TabIndex = 158
		Me.lblScoreLimitPassenger.Text = "Score Limit"
		'
		'chkLocatePassenger
		'
		Me.chkLocatePassenger.BackColor = System.Drawing.SystemColors.Control
		Me.chkLocatePassenger.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkLocatePassenger.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkLocatePassenger.ForeColor = System.Drawing.SystemColors.Highlight
		Me.chkLocatePassenger.Location = New System.Drawing.Point(123, 14)
		Me.chkLocatePassenger.Name = "chkLocatePassenger"
		Me.chkLocatePassenger.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkLocatePassenger.Size = New System.Drawing.Size(68, 24)
		Me.chkLocatePassenger.TabIndex = 60
		Me.chkLocatePassenger.TabStop = False
		Me.chkLocatePassenger.Text = "Repeat"
		Me.chkLocatePassenger.UseVisualStyleBackColor = False
		'
		'lblLocateTimePassenger
		'
		Me.lblLocateTimePassenger.BackColor = System.Drawing.SystemColors.Control
		Me.lblLocateTimePassenger.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblLocateTimePassenger.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblLocateTimePassenger.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblLocateTimePassenger.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblLocateTimePassenger.Location = New System.Drawing.Point(51, 54)
		Me.lblLocateTimePassenger.Name = "lblLocateTimePassenger"
		Me.lblLocateTimePassenger.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblLocateTimePassenger.Size = New System.Drawing.Size(55, 18)
		Me.lblLocateTimePassenger.TabIndex = 67
		'
		'lblLocatorTimePassenger
		'
		Me.lblLocatorTimePassenger.AutoSize = True
		Me.lblLocatorTimePassenger.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblLocatorTimePassenger.ForeColor = System.Drawing.SystemColors.Desktop
		Me.lblLocatorTimePassenger.Location = New System.Drawing.Point(20, 56)
		Me.lblLocatorTimePassenger.Name = "lblLocatorTimePassenger"
		Me.lblLocatorTimePassenger.Size = New System.Drawing.Size(29, 14)
		Me.lblLocatorTimePassenger.TabIndex = 157
		Me.lblLocatorTimePassenger.Text = "Time"
		'
		'grpPassengerThreshold
		'
		Me.grpPassengerThreshold.Controls.Add(Me.btnPassengerSaveBlob)
		Me.grpPassengerThreshold.Controls.Add(Me.lblTrackPassengerValue)
		Me.grpPassengerThreshold.Controls.Add(Me.btnPassengerTrainBlob)
		Me.grpPassengerThreshold.Controls.Add(Me.trkPassengerBlob)
		Me.grpPassengerThreshold.Controls.Add(Me.lblPassengerBlobArea)
		Me.grpPassengerThreshold.Controls.Add(Me.btnSavePassengerBlobArea)
		Me.grpPassengerThreshold.Controls.Add(Me.lblPassThresholdMax)
		Me.grpPassengerThreshold.Controls.Add(Me.lblPassThresholdMin)
		Me.grpPassengerThreshold.Controls.Add(Me.updnPassengerBlobThresholdMax)
		Me.grpPassengerThreshold.Controls.Add(Me.updnPassengerBlobThresholdMin)
		Me.grpPassengerThreshold.Location = New System.Drawing.Point(947, 15)
		Me.grpPassengerThreshold.Name = "grpPassengerThreshold"
		Me.grpPassengerThreshold.Size = New System.Drawing.Size(350, 154)
		Me.grpPassengerThreshold.TabIndex = 87
		Me.grpPassengerThreshold.TabStop = False
		'
		'lblTrackPassengerValue
		'
		Me.lblTrackPassengerValue.AutoSize = True
		Me.lblTrackPassengerValue.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblTrackPassengerValue.Location = New System.Drawing.Point(123, 115)
		Me.lblTrackPassengerValue.Name = "lblTrackPassengerValue"
		Me.lblTrackPassengerValue.Size = New System.Drawing.Size(91, 16)
		Me.lblTrackPassengerValue.TabIndex = 15
		Me.lblTrackPassengerValue.Text = "Minimum Area"
		Me.lblTrackPassengerValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'trkPassengerBlob
		'
		Me.trkPassengerBlob.Location = New System.Drawing.Point(126, 86)
		Me.trkPassengerBlob.Maximum = 100
		Me.trkPassengerBlob.Name = "trkPassengerBlob"
		Me.trkPassengerBlob.Size = New System.Drawing.Size(152, 45)
		Me.trkPassengerBlob.TabIndex = 14
		'
		'lblPassengerBlobArea
		'
		Me.lblPassengerBlobArea.AutoSize = True
		Me.lblPassengerBlobArea.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPassengerBlobArea.Location = New System.Drawing.Point(6, 80)
		Me.lblPassengerBlobArea.Name = "lblPassengerBlobArea"
		Me.lblPassengerBlobArea.Size = New System.Drawing.Size(77, 16)
		Me.lblPassengerBlobArea.TabIndex = 13
		Me.lblPassengerBlobArea.Text = "Saved Area:"
		'
		'btnSavePassengerBlobArea
		'
		Me.btnSavePassengerBlobArea.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnSavePassengerBlobArea.Location = New System.Drawing.Point(4, 100)
		Me.btnSavePassengerBlobArea.Name = "btnSavePassengerBlobArea"
		Me.btnSavePassengerBlobArea.Size = New System.Drawing.Size(105, 32)
		Me.btnSavePassengerBlobArea.TabIndex = 12
		Me.btnSavePassengerBlobArea.Text = "Save Blob Area"
		Me.btnSavePassengerBlobArea.UseVisualStyleBackColor = True
		'
		'lblPassThresholdMax
		'
		Me.lblPassThresholdMax.AutoSize = True
		Me.lblPassThresholdMax.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPassThresholdMax.Location = New System.Drawing.Point(6, 55)
		Me.lblPassThresholdMax.Name = "lblPassThresholdMax"
		Me.lblPassThresholdMax.Size = New System.Drawing.Size(173, 16)
		Me.lblPassThresholdMax.TabIndex = 3
		Me.lblPassThresholdMax.Text = "Maximum Primer Brightness"
		'
		'lblPassThresholdMin
		'
		Me.lblPassThresholdMin.AutoSize = True
		Me.lblPassThresholdMin.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPassThresholdMin.Location = New System.Drawing.Point(6, 20)
		Me.lblPassThresholdMin.Name = "lblPassThresholdMin"
		Me.lblPassThresholdMin.Size = New System.Drawing.Size(169, 16)
		Me.lblPassThresholdMin.TabIndex = 2
		Me.lblPassThresholdMin.Text = "Minimum Primer Brightness"
		'
		'updnPassengerBlobThresholdMax
		'
		Me.updnPassengerBlobThresholdMax.Location = New System.Drawing.Point(189, 51)
		Me.updnPassengerBlobThresholdMax.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
		Me.updnPassengerBlobThresholdMax.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.updnPassengerBlobThresholdMax.Name = "updnPassengerBlobThresholdMax"
		Me.updnPassengerBlobThresholdMax.Size = New System.Drawing.Size(70, 22)
		Me.updnPassengerBlobThresholdMax.TabIndex = 1
		Me.updnPassengerBlobThresholdMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.updnPassengerBlobThresholdMax.Value = New Decimal(New Integer() {1, 0, 0, 0})
		'
		'updnPassengerBlobThresholdMin
		'
		Me.updnPassengerBlobThresholdMin.Location = New System.Drawing.Point(189, 17)
		Me.updnPassengerBlobThresholdMin.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.updnPassengerBlobThresholdMin.Name = "updnPassengerBlobThresholdMin"
		Me.updnPassengerBlobThresholdMin.Size = New System.Drawing.Size(70, 22)
		Me.updnPassengerBlobThresholdMin.TabIndex = 0
		Me.updnPassengerBlobThresholdMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.updnPassengerBlobThresholdMin.Value = New Decimal(New Integer() {1, 0, 0, 0})
		'
		'grpPassengerCameraStatus
		'
		Me.grpPassengerCameraStatus.Controls.Add(Me.lblCameraStatusPassenger)
		Me.grpPassengerCameraStatus.Controls.Add(Me.lblTemperaturePassenger)
		Me.grpPassengerCameraStatus.Controls.Add(Me.pbPassengerTemperature)
		Me.grpPassengerCameraStatus.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
		Me.grpPassengerCameraStatus.ForeColor = System.Drawing.SystemColors.Highlight
		Me.grpPassengerCameraStatus.Location = New System.Drawing.Point(10, 15)
		Me.grpPassengerCameraStatus.Name = "grpPassengerCameraStatus"
		Me.grpPassengerCameraStatus.Size = New System.Drawing.Size(173, 154)
		Me.grpPassengerCameraStatus.TabIndex = 84
		Me.grpPassengerCameraStatus.TabStop = False
		Me.grpPassengerCameraStatus.Text = "Camera Status"
		'
		'lblCameraStatusPassenger
		'
		Me.lblCameraStatusPassenger.AutoSize = True
		Me.lblCameraStatusPassenger.Font = New System.Drawing.Font("Arial Black", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCameraStatusPassenger.ForeColor = System.Drawing.Color.DarkRed
		Me.lblCameraStatusPassenger.Location = New System.Drawing.Point(37, 21)
		Me.lblCameraStatusPassenger.Name = "lblCameraStatusPassenger"
		Me.lblCameraStatusPassenger.Size = New System.Drawing.Size(114, 51)
		Me.lblCameraStatusPassenger.TabIndex = 161
		Me.lblCameraStatusPassenger.Text = "       Warning! " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  The Camera is " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  not connected"
		Me.lblCameraStatusPassenger.Visible = False
		'
		'lblTemperaturePassenger
		'
		Me.lblTemperaturePassenger.BackColor = System.Drawing.SystemColors.ButtonShadow
		Me.lblTemperaturePassenger.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblTemperaturePassenger.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblTemperaturePassenger.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblTemperaturePassenger.Location = New System.Drawing.Point(6, 97)
		Me.lblTemperaturePassenger.Name = "lblTemperaturePassenger"
		Me.lblTemperaturePassenger.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblTemperaturePassenger.Size = New System.Drawing.Size(39, 48)
		Me.lblTemperaturePassenger.TabIndex = 160
		Me.lblTemperaturePassenger.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'pbPassengerTemperature
		'
		Me.pbPassengerTemperature.Image = CType(resources.GetObject("pbPassengerTemperature.Image"), System.Drawing.Image)
		Me.pbPassengerTemperature.Location = New System.Drawing.Point(11, 32)
		Me.pbPassengerTemperature.Name = "pbPassengerTemperature"
		Me.pbPassengerTemperature.Size = New System.Drawing.Size(25, 60)
		Me.pbPassengerTemperature.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.pbPassengerTemperature.TabIndex = 159
		Me.pbPassengerTemperature.TabStop = False
		'
		'grpPassengerVisStatus
		'
		Me.grpPassengerVisStatus.BackColor = System.Drawing.SystemColors.Control
		Me.grpPassengerVisStatus.Controls.Add(Me.lblPAssengerBlobAreaDesc)
		Me.grpPassengerVisStatus.Controls.Add(Me.lblPassengerCurrentBlobArea)
		Me.grpPassengerVisStatus.Controls.Add(Me.lblFitPassenger)
		Me.grpPassengerVisStatus.Controls.Add(Me.lblVisionPoseFirPassenger)
		Me.grpPassengerVisStatus.Controls.Add(Me.lblVisionPoseFitPassenger)
		Me.grpPassengerVisStatus.Controls.Add(Me.lblVisionPoseScorePassenger)
		Me.grpPassengerVisStatus.Controls.Add(Me.lblVisionPoseTimePassenger)
		Me.grpPassengerVisStatus.Controls.Add(Me.lblVisionPoseRPassenger)
		Me.grpPassengerVisStatus.Controls.Add(Me.lblVisionPoseYPassenger)
		Me.grpPassengerVisStatus.Controls.Add(Me.lblVisionPoseXPassenger)
		Me.grpPassengerVisStatus.Controls.Add(Me.btnDetailsPassenger)
		Me.grpPassengerVisStatus.Controls.Add(Me.lblVisionMessagePassenger)
		Me.grpPassengerVisStatus.Controls.Add(Me.lblVisionXPassenger)
		Me.grpPassengerVisStatus.Controls.Add(Me.lblVisionYPassenger)
		Me.grpPassengerVisStatus.Controls.Add(Me.lblVisionAnglePassenger)
		Me.grpPassengerVisStatus.Controls.Add(Me.lblVisionTimePassenger)
		Me.grpPassengerVisStatus.Controls.Add(Me.lblVisionScorePassenger)
		Me.grpPassengerVisStatus.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.grpPassengerVisStatus.ForeColor = System.Drawing.SystemColors.Highlight
		Me.grpPassengerVisStatus.Location = New System.Drawing.Point(621, 15)
		Me.grpPassengerVisStatus.Name = "grpPassengerVisStatus"
		Me.grpPassengerVisStatus.Padding = New System.Windows.Forms.Padding(0)
		Me.grpPassengerVisStatus.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.grpPassengerVisStatus.Size = New System.Drawing.Size(320, 154)
		Me.grpPassengerVisStatus.TabIndex = 81
		Me.grpPassengerVisStatus.TabStop = False
		Me.grpPassengerVisStatus.Text = "Status"
		'
		'lblPAssengerBlobAreaDesc
		'
		Me.lblPAssengerBlobAreaDesc.BackColor = System.Drawing.SystemColors.Control
		Me.lblPAssengerBlobAreaDesc.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblPAssengerBlobAreaDesc.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPAssengerBlobAreaDesc.ForeColor = System.Drawing.SystemColors.Highlight
		Me.lblPAssengerBlobAreaDesc.Location = New System.Drawing.Point(71, 70)
		Me.lblPAssengerBlobAreaDesc.Name = "lblPAssengerBlobAreaDesc"
		Me.lblPAssengerBlobAreaDesc.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblPAssengerBlobAreaDesc.Size = New System.Drawing.Size(66, 17)
		Me.lblPAssengerBlobAreaDesc.TabIndex = 162
		Me.lblPAssengerBlobAreaDesc.Text = "Blob Area"
		'
		'lblPassengerCurrentBlobArea
		'
		Me.lblPassengerCurrentBlobArea.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblPassengerCurrentBlobArea.Location = New System.Drawing.Point(141, 64)
		Me.lblPassengerCurrentBlobArea.Name = "lblPassengerCurrentBlobArea"
		Me.lblPassengerCurrentBlobArea.Size = New System.Drawing.Size(59, 23)
		Me.lblPassengerCurrentBlobArea.TabIndex = 161
		'
		'lblFitPassenger
		'
		Me.lblFitPassenger.BackColor = System.Drawing.SystemColors.Control
		Me.lblFitPassenger.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblFitPassenger.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblFitPassenger.ForeColor = System.Drawing.SystemColors.Highlight
		Me.lblFitPassenger.Location = New System.Drawing.Point(230, 66)
		Me.lblFitPassenger.Name = "lblFitPassenger"
		Me.lblFitPassenger.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblFitPassenger.Size = New System.Drawing.Size(10, 21)
		Me.lblFitPassenger.TabIndex = 160
		Me.lblFitPassenger.Text = ":"
		'
		'lblVisionPoseFirPassenger
		'
		Me.lblVisionPoseFirPassenger.BackColor = System.Drawing.SystemColors.Control
		Me.lblVisionPoseFirPassenger.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblVisionPoseFirPassenger.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblVisionPoseFirPassenger.ForeColor = System.Drawing.SystemColors.Highlight
		Me.lblVisionPoseFirPassenger.Location = New System.Drawing.Point(202, 67)
		Me.lblVisionPoseFirPassenger.Name = "lblVisionPoseFirPassenger"
		Me.lblVisionPoseFirPassenger.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblVisionPoseFirPassenger.Size = New System.Drawing.Size(20, 17)
		Me.lblVisionPoseFirPassenger.TabIndex = 159
		Me.lblVisionPoseFirPassenger.Text = "Fit"
		'
		'lblVisionPoseFitPassenger
		'
		Me.lblVisionPoseFitPassenger.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblVisionPoseFitPassenger.Location = New System.Drawing.Point(246, 64)
		Me.lblVisionPoseFitPassenger.Name = "lblVisionPoseFitPassenger"
		Me.lblVisionPoseFitPassenger.Size = New System.Drawing.Size(62, 23)
		Me.lblVisionPoseFitPassenger.TabIndex = 158
		'
		'lblVisionPoseScorePassenger
		'
		Me.lblVisionPoseScorePassenger.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblVisionPoseScorePassenger.Location = New System.Drawing.Point(249, 114)
		Me.lblVisionPoseScorePassenger.Name = "lblVisionPoseScorePassenger"
		Me.lblVisionPoseScorePassenger.Size = New System.Drawing.Size(59, 23)
		Me.lblVisionPoseScorePassenger.TabIndex = 154
		'
		'lblVisionPoseTimePassenger
		'
		Me.lblVisionPoseTimePassenger.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblVisionPoseTimePassenger.Location = New System.Drawing.Point(189, 114)
		Me.lblVisionPoseTimePassenger.Name = "lblVisionPoseTimePassenger"
		Me.lblVisionPoseTimePassenger.Size = New System.Drawing.Size(59, 23)
		Me.lblVisionPoseTimePassenger.TabIndex = 153
		'
		'lblVisionPoseRPassenger
		'
		Me.lblVisionPoseRPassenger.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblVisionPoseRPassenger.Location = New System.Drawing.Point(129, 114)
		Me.lblVisionPoseRPassenger.Name = "lblVisionPoseRPassenger"
		Me.lblVisionPoseRPassenger.Size = New System.Drawing.Size(59, 23)
		Me.lblVisionPoseRPassenger.TabIndex = 152
		'
		'lblVisionPoseYPassenger
		'
		Me.lblVisionPoseYPassenger.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblVisionPoseYPassenger.Location = New System.Drawing.Point(69, 114)
		Me.lblVisionPoseYPassenger.Name = "lblVisionPoseYPassenger"
		Me.lblVisionPoseYPassenger.Size = New System.Drawing.Size(59, 23)
		Me.lblVisionPoseYPassenger.TabIndex = 151
		'
		'lblVisionPoseXPassenger
		'
		Me.lblVisionPoseXPassenger.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblVisionPoseXPassenger.Location = New System.Drawing.Point(9, 114)
		Me.lblVisionPoseXPassenger.Name = "lblVisionPoseXPassenger"
		Me.lblVisionPoseXPassenger.Size = New System.Drawing.Size(59, 23)
		Me.lblVisionPoseXPassenger.TabIndex = 150
		'
		'lblVisionXPassenger
		'
		Me.lblVisionXPassenger.BackColor = System.Drawing.SystemColors.Control
		Me.lblVisionXPassenger.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblVisionXPassenger.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblVisionXPassenger.ForeColor = System.Drawing.SystemColors.Highlight
		Me.lblVisionXPassenger.Location = New System.Drawing.Point(27, 95)
		Me.lblVisionXPassenger.Name = "lblVisionXPassenger"
		Me.lblVisionXPassenger.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblVisionXPassenger.Size = New System.Drawing.Size(34, 17)
		Me.lblVisionXPassenger.TabIndex = 55
		Me.lblVisionXPassenger.Text = "X"
		'
		'lblVisionYPassenger
		'
		Me.lblVisionYPassenger.BackColor = System.Drawing.SystemColors.Control
		Me.lblVisionYPassenger.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblVisionYPassenger.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblVisionYPassenger.ForeColor = System.Drawing.SystemColors.Highlight
		Me.lblVisionYPassenger.Location = New System.Drawing.Point(87, 95)
		Me.lblVisionYPassenger.Name = "lblVisionYPassenger"
		Me.lblVisionYPassenger.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblVisionYPassenger.Size = New System.Drawing.Size(34, 17)
		Me.lblVisionYPassenger.TabIndex = 54
		Me.lblVisionYPassenger.Text = "Y"
		'
		'lblVisionAnglePassenger
		'
		Me.lblVisionAnglePassenger.BackColor = System.Drawing.SystemColors.Control
		Me.lblVisionAnglePassenger.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblVisionAnglePassenger.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblVisionAnglePassenger.ForeColor = System.Drawing.SystemColors.Highlight
		Me.lblVisionAnglePassenger.Location = New System.Drawing.Point(138, 95)
		Me.lblVisionAnglePassenger.Name = "lblVisionAnglePassenger"
		Me.lblVisionAnglePassenger.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblVisionAnglePassenger.Size = New System.Drawing.Size(50, 17)
		Me.lblVisionAnglePassenger.TabIndex = 53
		Me.lblVisionAnglePassenger.Text = "Angle"
		'
		'lblVisionTimePassenger
		'
		Me.lblVisionTimePassenger.BackColor = System.Drawing.SystemColors.Control
		Me.lblVisionTimePassenger.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblVisionTimePassenger.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblVisionTimePassenger.ForeColor = System.Drawing.SystemColors.Highlight
		Me.lblVisionTimePassenger.Location = New System.Drawing.Point(199, 95)
		Me.lblVisionTimePassenger.Name = "lblVisionTimePassenger"
		Me.lblVisionTimePassenger.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblVisionTimePassenger.Size = New System.Drawing.Size(50, 17)
		Me.lblVisionTimePassenger.TabIndex = 52
		Me.lblVisionTimePassenger.Text = "Time"
		'
		'lblVisionScorePassenger
		'
		Me.lblVisionScorePassenger.BackColor = System.Drawing.SystemColors.Control
		Me.lblVisionScorePassenger.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblVisionScorePassenger.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblVisionScorePassenger.ForeColor = System.Drawing.SystemColors.Highlight
		Me.lblVisionScorePassenger.Location = New System.Drawing.Point(258, 95)
		Me.lblVisionScorePassenger.Name = "lblVisionScorePassenger"
		Me.lblVisionScorePassenger.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblVisionScorePassenger.Size = New System.Drawing.Size(50, 17)
		Me.lblVisionScorePassenger.TabIndex = 50
		Me.lblVisionScorePassenger.Text = "Score"
		'
		'grpHSDisplayPassenger
		'
		Me.grpHSDisplayPassenger.BackColor = System.Drawing.SystemColors.Control
		Me.grpHSDisplayPassenger.Controls.Add(Me.HSDisplayPassenger)
		Me.grpHSDisplayPassenger.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.grpHSDisplayPassenger.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.grpHSDisplayPassenger.ForeColor = System.Drawing.SystemColors.ControlText
		Me.grpHSDisplayPassenger.Location = New System.Drawing.Point(6, 174)
		Me.grpHSDisplayPassenger.Name = "grpHSDisplayPassenger"
		Me.grpHSDisplayPassenger.Padding = New System.Windows.Forms.Padding(0)
		Me.grpHSDisplayPassenger.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.grpHSDisplayPassenger.Size = New System.Drawing.Size(1502, 745)
		Me.grpHSDisplayPassenger.TabIndex = 80
		Me.grpHSDisplayPassenger.TabStop = False
		'
		'HSDisplayPassenger
		'
		Me.HSDisplayPassenger.Enabled = True
		Me.HSDisplayPassenger.Location = New System.Drawing.Point(14, 22)
		Me.HSDisplayPassenger.Name = "HSDisplayPassenger"
		Me.HSDisplayPassenger.OcxState = CType(resources.GetObject("HSDisplayPassenger.OcxState"), System.Windows.Forms.AxHost.State)
		Me.HSDisplayPassenger.Size = New System.Drawing.Size(468, 293)
		Me.HSDisplayPassenger.TabIndex = 81
		'
		'tabPagePosition
		'
		Me.tabPagePosition.Controls.Add(Me.grpPosition)
		Me.tabPagePosition.Location = New System.Drawing.Point(4, 27)
		Me.tabPagePosition.Name = "tabPagePosition"
		Me.tabPagePosition.Size = New System.Drawing.Size(1522, 927)
		Me.tabPagePosition.TabIndex = 7
		Me.tabPagePosition.Text = "Pickup Position"
		Me.tabPagePosition.UseVisualStyleBackColor = True
		'
		'grpPosition
		'
		Me.grpPosition.BackColor = System.Drawing.SystemColors.Control
		Me.grpPosition.Controls.Add(Me.GroupBox1)
		Me.grpPosition.Location = New System.Drawing.Point(3, 3)
		Me.grpPosition.Name = "grpPosition"
		Me.grpPosition.Size = New System.Drawing.Size(1501, 920)
		Me.grpPosition.TabIndex = 247
		Me.grpPosition.TabStop = False
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.txtDistance3)
		Me.GroupBox1.Controls.Add(Me.txtDistance2)
		Me.GroupBox1.Controls.Add(Me.txtDistance1)
		Me.GroupBox1.Controls.Add(Me.Label4)
		Me.GroupBox1.Controls.Add(Me.Label3)
		Me.GroupBox1.Controls.Add(Me.Label1)
		Me.GroupBox1.Location = New System.Drawing.Point(18, 19)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(846, 548)
		Me.GroupBox1.TabIndex = 0
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Bracket Setup"
		'
		'txtDistance3
		'
		Me.txtDistance3.Location = New System.Drawing.Point(220, 191)
		Me.txtDistance3.Name = "txtDistance3"
		Me.txtDistance3.Size = New System.Drawing.Size(76, 22)
		Me.txtDistance3.TabIndex = 6
		Me.txtDistance3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'txtDistance2
		'
		Me.txtDistance2.Location = New System.Drawing.Point(220, 142)
		Me.txtDistance2.Name = "txtDistance2"
		Me.txtDistance2.Size = New System.Drawing.Size(76, 22)
		Me.txtDistance2.TabIndex = 5
		Me.txtDistance2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'txtDistance1
		'
		Me.txtDistance1.Location = New System.Drawing.Point(220, 85)
		Me.txtDistance1.Name = "txtDistance1"
		Me.txtDistance1.Size = New System.Drawing.Size(76, 22)
		Me.txtDistance1.TabIndex = 4
		Me.txtDistance1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(37, 197)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(161, 16)
		Me.Label4.TabIndex = 3
		Me.Label4.Text = "Distance Marker 3 Value"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(37, 145)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(161, 16)
		Me.Label3.TabIndex = 2
		Me.Label3.Text = "Distance Marker 2 Value"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(37, 92)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(161, 16)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Distance Marker 1 Value"
		'
		'grpVBErrors
		'
		Me.grpVBErrors.BackColor = System.Drawing.Color.PaleGoldenrod
		Me.grpVBErrors.Controls.Add(Me.lstVBError)
		Me.grpVBErrors.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.grpVBErrors.ForeColor = System.Drawing.Color.DarkRed
		Me.grpVBErrors.Location = New System.Drawing.Point(6, 861)
		Me.grpVBErrors.Name = "grpVBErrors"
		Me.grpVBErrors.Padding = New System.Windows.Forms.Padding(0)
		Me.grpVBErrors.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.grpVBErrors.Size = New System.Drawing.Size(355, 119)
		Me.grpVBErrors.TabIndex = 23
		Me.grpVBErrors.TabStop = False
		Me.grpVBErrors.Text = "Program Notifications   (Double Click to Clear)"
		'
		'lstVBError
		'
		Me.lstVBError.BackColor = System.Drawing.Color.PaleGoldenrod
		Me.lstVBError.Cursor = System.Windows.Forms.Cursors.Default
		Me.lstVBError.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lstVBError.ForeColor = System.Drawing.SystemColors.WindowText
		Me.lstVBError.HorizontalScrollbar = True
		Me.lstVBError.ItemHeight = 14
		Me.lstVBError.Location = New System.Drawing.Point(4, 16)
		Me.lstVBError.Name = "lstVBError"
		Me.lstVBError.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lstVBError.ScrollAlwaysVisible = True
		Me.lstVBError.Size = New System.Drawing.Size(355, 102)
		Me.lstVBError.TabIndex = 24
		Me.lstVBError.TabStop = False
		'
		'lblCurrentUser
		'
		Me.lblCurrentUser.BackColor = System.Drawing.SystemColors.Control
		Me.lblCurrentUser.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblCurrentUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCurrentUser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.lblCurrentUser.Location = New System.Drawing.Point(767, 0)
		Me.lblCurrentUser.Name = "lblCurrentUser"
		Me.lblCurrentUser.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblCurrentUser.Size = New System.Drawing.Size(348, 24)
		Me.lblCurrentUser.TabIndex = 166
		Me.lblCurrentUser.Text = "Current Password Level: Not logged in yet"
		'
		'ImageList1
		'
		Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
		Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
		Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
		'
		'frmMain
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.AutoSize = True
		Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
		Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
		Me.CausesValidation = False
		Me.ClientSize = New System.Drawing.Size(1904, 1041)
		Me.Controls.Add(Me.lblCurrentUser)
		Me.Controls.Add(Me.tabVisionRobot)
		Me.Controls.Add(Me.lblPartLoaded)
		Me.Controls.Add(Me.lblPartTitle)
		Me.Controls.Add(Me.MainMenu1)
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.KeyPreview = True
		Me.MaximumSize = New System.Drawing.Size(1920, 1080)
		Me.Name = "frmMain"
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
		Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
		Me.Text = "Bracket Placement"
		Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
		Me.MainMenu1.ResumeLayout(False)
		Me.MainMenu1.PerformLayout
		CType(Me.updnScoreLimit, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.updnLocationX, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.updnLocationY, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.updnLocationR, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.updnScoreLimitBracketconveyor, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.updnScoreLimitCenterVerify, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.updnScoreLimitDriver, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.updnScoreLimitCenter, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.updnScoreLimitPassenger, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.updnScoreLimitBracketPrimer, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.updnLocationZ, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.updnScoreLimitTapeBracketLocator, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit
		Me.tabVisionRobot.ResumeLayout(False)
		Me.tabPageRobot.ResumeLayout(False)
		Me.GrpRobot.ResumeLayout(False)
		Me.GrpRobot.PerformLayout
		Me.grpResults.ResumeLayout(False)
		Me.grpResults.PerformLayout
		CType(Me.updnGocator, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit
		Me.TabControlsMain.ResumeLayout(False)
		Me.tabPageBracketLocateTape.ResumeLayout(False)
		Me.grpVisionBracketLocateTape.ResumeLayout(False)
		Me.gprBracketTapeCoverSettings.ResumeLayout(False)
		Me.gprBracketTapeCoverSettings.PerformLayout
		CType(Me.updnCoverMaxAreaBottomRight, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.updnCoverBlobMinBottomRight, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.updnCoverMaxAreaBottomLeft, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.updnCoverBlobMinTopLeft, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.updnCoverMaxAreaTopRight, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.updnCoverMaxAreaTopLeft, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.updnCoverBlobMinTopRight, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.updnCoverBlobMinBottomLeft, System.ComponentModel.ISupportInitialize).EndInit
		Me.gprBracketTapeBlobControls.ResumeLayout(False)
		Me.gprBracketTapeBlobControls.PerformLayout
		CType(Me.updnTapeMinAreaBottomRight, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.updnTapeBlobMinBottomRight, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.updnTapeBlobMaxBottomRight, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.updnTapeBlobMaxBottomLeft, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.updnTapeMinAreaBottomLeft, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.updnTapeBlobMinTopLeft, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.updnTapeBlobMaxTopLeft, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.updnTapeMinAreaTopRight, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.updnTapeBlobMaxTopRight, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.updnTapeMinAreaTopLeft, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.updnTapeBlobMinTopRight, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.updnTapeBlobMinBottomLeft, System.ComponentModel.ISupportInitialize).EndInit
		Me.grpStatusBracketLocateTape.ResumeLayout(False)
		Me.grpCameraControlLocateTape.ResumeLayout(False)
		Me.grpCameraControlLocateTape.PerformLayout
		CType(Me.updnContrastBracketTape, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.updnExposureBracketTape, System.ComponentModel.ISupportInitialize).EndInit
		Me.grpBracketTapeCamera.ResumeLayout(False)
		Me.grpBracketTapeCamera.PerformLayout
		CType(Me.pbBracketTape, System.ComponentModel.ISupportInitialize).EndInit
		Me.grpLocatorControlsBracketTape.ResumeLayout(False)
		Me.grpLocatorControlsBracketTape.PerformLayout
		Me.grpHSDisplayBracketTape.ResumeLayout(False)
		CType(Me.HSDisplayBracketTape, System.ComponentModel.ISupportInitialize).EndInit
		Me.tabpageBracketPrimerVerify.ResumeLayout(False)
		Me.grpVisionBracketPrimer.ResumeLayout(False)
		Me.grpBracketPrimerReference.ResumeLayout(False)
		Me.grpBracketPrimerReference.PerformLayout
		Me.grpBracketPrimer.ResumeLayout(False)
		Me.grpBracketPrimer.PerformLayout
		CType(Me.updnBracketPrimer5Deviation, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.updnBracketPrimer4Deviation, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.updnBracketPrimer3Deviation, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.updnBracketPrimer2Deviation, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.updnBracketPrimer1Deviation, System.ComponentModel.ISupportInitialize).EndInit
		Me.grpCameraControlPrimer.ResumeLayout(False)
		Me.grpCameraControlPrimer.PerformLayout
		CType(Me.updnContrastBracketPrimer, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.updnExposureBracketPrimer, System.ComponentModel.ISupportInitialize).EndInit
		Me.grpBracketPrimerCamera.ResumeLayout(False)
		Me.grpBracketPrimerCamera.PerformLayout
		CType(Me.pbBracketPrimer, System.ComponentModel.ISupportInitialize).EndInit
		Me.grpStatusBracketLocatePrimer.ResumeLayout(False)
		Me.grpLocatorControlsBracketPrimer.ResumeLayout(False)
		Me.grpLocatorControlsBracketPrimer.PerformLayout
		Me.grpHSDisplayBracketPrimer.ResumeLayout(False)
		CType(Me.HSDisplayBracketPrimer, System.ComponentModel.ISupportInitialize).EndInit
		Me.tabpageBracketLocateAtConveyor.ResumeLayout(False)
		Me.grpVisionBracketLocateatConveyor.ResumeLayout(False)
		Me.grpCameraControlLocateConveyor.ResumeLayout(False)
		Me.grpCameraControlLocateConveyor.PerformLayout
		CType(Me.updnContrastBracketConveyor, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.updnExposureBracketConveyor, System.ComponentModel.ISupportInitialize).EndInit
		Me.grpLocatorControlsBracketConveyor.ResumeLayout(False)
		Me.grpLocatorControlsBracketConveyor.PerformLayout
		Me.grpBrackConveyorCamera.ResumeLayout(False)
		Me.grpBrackConveyorCamera.PerformLayout
		CType(Me.pbBracketConveyorCamera, System.ComponentModel.ISupportInitialize).EndInit
		Me.grpStatusBracketLocateAtConveoyr.ResumeLayout(False)
		Me.grpHSDisplayBracketConveyor.ResumeLayout(False)
		CType(Me.HSDisplayBracketConveyor, System.ComponentModel.ISupportInitialize).EndInit
		Me.tabPageBracketLocate.ResumeLayout(False)
		Me.grpVisionGlassLocate.ResumeLayout(False)
		Me.grpCameraControl.ResumeLayout(False)
		Me.grpCameraControl.PerformLayout
		CType(Me.updnContrastLocateGlass, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.updnExposureLocateGlass, System.ComponentModel.ISupportInitialize).EndInit
		Me.grpLocatorControls.ResumeLayout(False)
		Me.grpLocatorControls.PerformLayout
		Me.grpGlassLocate.ResumeLayout(False)
		Me.grpGlassLocate.PerformLayout
		Me.grpCameraStatus.ResumeLayout(False)
		Me.grpCameraStatus.PerformLayout
		CType(Me.pctTemperature, System.ComponentModel.ISupportInitialize).EndInit
		Me.grpVisionStatus.ResumeLayout(False)
		Me.grpHSDisplayGlassLocation.ResumeLayout(False)
		CType(Me.HSDisplayLocateGlass, System.ComponentModel.ISupportInitialize).EndInit
		Me.tabPageCenterBracketVerify.ResumeLayout(False)
		Me.grpVisionCenterVerify.ResumeLayout(False)
		Me.grpGlassVerifyValues.ResumeLayout(False)
		Me.grpGlassVerifyValues.PerformLayout
		CType(Me.updnTopRightVerifyVariance, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.updnBottomRightVerifyVariance, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.updnBottomLeftVerifyVariance, System.ComponentModel.ISupportInitialize).EndInit
		Me.grpCameraControlBrackeyVerify.ResumeLayout(False)
		Me.grpCameraControlBrackeyVerify.PerformLayout
		CType(Me.updnContrastCenterVerify, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.updnExposureCenterVerify, System.ComponentModel.ISupportInitialize).EndInit
		Me.grpCameraStatusVerify.ResumeLayout(False)
		Me.grpCameraStatusVerify.PerformLayout
		CType(Me.pctTemperatureVerify, System.ComponentModel.ISupportInitialize).EndInit
		Me.grpLocatorControlsBracketVerify.ResumeLayout(False)
		Me.grpLocatorControlsBracketVerify.PerformLayout
		Me.grpVisionStatusVerify.ResumeLayout(False)
		Me.grpHSDisplayBracketVerify.ResumeLayout(False)
		CType(Me.HSDisplayCenterBracketVerify, System.ComponentModel.ISupportInitialize).EndInit
		Me.tabPageDriverCam.ResumeLayout(False)
		Me.grpVisionDriver.ResumeLayout(False)
		Me.grpCameraControlDriver.ResumeLayout(False)
		Me.grpCameraControlDriver.PerformLayout
		CType(Me.updnContrastDriver, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.updnExposureDriver, System.ComponentModel.ISupportInitialize).EndInit
		Me.grpDriveBlob.ResumeLayout(False)
		Me.grpDriveBlob.PerformLayout
		CType(Me.trkDriverBlob, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.updnDriverBlobThresholdMax, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.updnDriverBlobThresholdMin, System.ComponentModel.ISupportInitialize).EndInit
		Me.grpLocatorControlsDriver.ResumeLayout(False)
		Me.grpLocatorControlsDriver.PerformLayout
		Me.grpDriverCameraStatus.ResumeLayout(False)
		Me.grpDriverCameraStatus.PerformLayout
		CType(Me.pbDriverTemperature, System.ComponentModel.ISupportInitialize).EndInit
		Me.grpStatusDriver.ResumeLayout(False)
		Me.grpHSDisplayDriver.ResumeLayout(False)
		CType(Me.HSDisplayDriver, System.ComponentModel.ISupportInitialize).EndInit
		Me.tabPageCenterCam.ResumeLayout(False)
		Me.grpVisionCenter.ResumeLayout(False)
		Me.grpCameraControlCenter.ResumeLayout(False)
		Me.grpCameraControlCenter.PerformLayout
		CType(Me.updnContrastCenter, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.updnExposureCenter, System.ComponentModel.ISupportInitialize).EndInit
		Me.grpLocatorControlsCenter.ResumeLayout(False)
		Me.grpLocatorControlsCenter.PerformLayout
		Me.grpCenterBlob.ResumeLayout(False)
		Me.grpCenterBlob.PerformLayout
		CType(Me.trkCenterBlob, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.updnCenterBlobThresholdMax, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.updnCenterBlobThresholdMin, System.ComponentModel.ISupportInitialize).EndInit
		Me.grpCameraStatusCenter.ResumeLayout(False)
		Me.grpCameraStatusCenter.PerformLayout
		CType(Me.pbCenterCameraStatus, System.ComponentModel.ISupportInitialize).EndInit
		Me.grpCenterVisStatus.ResumeLayout(False)
		Me.grpHSDisplayCenter.ResumeLayout(False)
		CType(Me.HSDisplayCenter, System.ComponentModel.ISupportInitialize).EndInit
		Me.tabPagePassCam.ResumeLayout(False)
		Me.grpVisionPassenger.ResumeLayout(False)
		Me.grpCameraControlPassenger.ResumeLayout(False)
		Me.grpCameraControlPassenger.PerformLayout
		CType(Me.updnContrastPassenger, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.updnExposurePassenger, System.ComponentModel.ISupportInitialize).EndInit
		Me.grpLocatorControlsPassenger.ResumeLayout(False)
		Me.grpLocatorControlsPassenger.PerformLayout
		Me.grpPassengerThreshold.ResumeLayout(False)
		Me.grpPassengerThreshold.PerformLayout
		CType(Me.trkPassengerBlob, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.updnPassengerBlobThresholdMax, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.updnPassengerBlobThresholdMin, System.ComponentModel.ISupportInitialize).EndInit
		Me.grpPassengerCameraStatus.ResumeLayout(False)
		Me.grpPassengerCameraStatus.PerformLayout
		CType(Me.pbPassengerTemperature, System.ComponentModel.ISupportInitialize).EndInit
		Me.grpPassengerVisStatus.ResumeLayout(False)
		Me.grpHSDisplayPassenger.ResumeLayout(False)
		CType(Me.HSDisplayPassenger, System.ComponentModel.ISupportInitialize).EndInit
		Me.tabPagePosition.ResumeLayout(False)
		Me.grpPosition.ResumeLayout(False)
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout
		Me.grpVBErrors.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout

	End Sub
	Public WithEvents tmrDelay As System.Windows.Forms.Timer
	Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
	Public WithEvents mnuSeperator2 As System.Windows.Forms.ToolStripSeparator
	Friend WithEvents mnuVerifyVisionAccuracy As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents TmrPassword As System.Windows.Forms.Timer
	Friend WithEvents tmrDisplayUpdate As System.Windows.Forms.Timer
	Friend WithEvents mnuCalibration As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents mnuModifyHexsightControls As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents ErrorProvider1 As ErrorProvider
	Friend WithEvents mnuCalibrateBracket As ToolStripMenuItem
	Friend WithEvents tabVisionRobot As TabControl
	Friend WithEvents tabPageRobot As TabPage
	Friend WithEvents GrpRobot As GroupBox
	Friend WithEvents grpPosition As GroupBox
	Public WithEvents btnLocationAdjOK As Button
	Friend WithEvents lblPositionModifyXMinus As Label
	Public WithEvents btnDepositAdjYPlus As Button
	Friend WithEvents lblPositionYPlusDesc As Label
	Public WithEvents btnDepositAdjXPlus As Button
	Friend WithEvents lblPositionModifyY As Label
	Public WithEvents btnDepositAdjYMinus As Button
	Public WithEvents btnLocationAdjCancel As Button
	Public WithEvents btnDepositAdjXMinus As Button
	Friend WithEvents lblPositionModiftX As Label
	Public WithEvents btnDepositAdjRPlus As Button
	Public WithEvents btnDepositAdjRMinus As Button
	Friend WithEvents lblPositionRDesc As Label
	Friend WithEvents lblPositionRDescminus As Label
	Public WithEvents updnLocationR As NumericUpDown
	Public WithEvents updnLocationY As NumericUpDown
	Public WithEvents updnLocationX As NumericUpDown
	Friend WithEvents lblPositionYDesc As Label
	Friend WithEvents lblPositionXMMDesc As Label
	Friend WithEvents lblPositionRDeg As Label
	Friend WithEvents lblPhone As Label
	Friend WithEvents picLogo As PictureBox
	Friend WithEvents TabControlsMain As TabControl
	Friend WithEvents tabPageBracketLocate As TabPage
	Public WithEvents grpVisionGlassLocate As GroupBox
	Friend WithEvents grpCameraStatus As GroupBox
	Friend WithEvents lblCameraStatus As Label
	Public WithEvents lblTemperatureBracket As Label
	Friend WithEvents pctTemperature As PictureBox
	Public WithEvents grpLocatorControls As GroupBox
	Friend WithEvents lblScoreLimit As Label
	Public WithEvents btnLocateOnlyLocateGlass As Button
	Public WithEvents btnLocateLocateGlass As Button
	Friend WithEvents updnScoreLimit As NumericUpDown
	Public WithEvents chkLocateRepeatLocateGlass As CheckBox
	Public WithEvents btnSearchSettingsLocateGlass As Button
	Public WithEvents btnTrainNewLocateGlass As Button
	Public WithEvents lblLocateTime As Label
	Friend WithEvents lblLocatorTime As Label
	Public WithEvents btnTrainExistingLocateGlass As Button
	Public WithEvents grpHSDisplayGlassLocation As GroupBox
	Public WithEvents HSDisplayLocateGlass As AxHSDisplay
	Public WithEvents grpCameraControl As GroupBox
	Friend WithEvents lblCamControlAcqTime As Label
	Friend WithEvents lblContrastValueWest As Label
	Friend WithEvents lblBrightnessValueWest As Label
	Friend WithEvents lblExposureValueWest As Label
	Friend WithEvents lblContrast As Label
	Friend WithEvents lblExposure As Label
	Public WithEvents updnContrastLocateGlass As NumericUpDown
	Public WithEvents updnExposureLocateGlass As NumericUpDown
	Public WithEvents btnSnapLocateGlass As Button
	Public WithEvents chkSnapRepeatLocateGlass As CheckBox
	Public WithEvents lblCameraTime As Label
	Public WithEvents grpVisionStatus As GroupBox
	Public WithEvents lblFitBracket As Label
	Public WithEvents lblVisionPoseFirBracket As Label
	Friend WithEvents lblVisionPoseFitBracket As Label
	Friend WithEvents lblVisionPoseScoreBracket As Label
	Friend WithEvents lblVisionPoseTimeBracket As Label
	Friend WithEvents lblVisionPoseRBracket As Label
	Friend WithEvents lblVisionPoseYBracket As Label
	Friend WithEvents lblVisionPoseXBracket As Label
	Public WithEvents btnDetailsBracket As Button
	Public WithEvents lblVisionMessageBracket As Label
	Public WithEvents lblVisionXBracket As Label
	Public WithEvents lblVisionYBracket As Label
	Public WithEvents lblVisionAngleBracket As Label
	Public WithEvents lblVisionTimeBracket As Label
	Public WithEvents lblVisionScoreBracket As Label
	Friend WithEvents tabPageDriverCam As TabPage
	Friend WithEvents tabPageCenterCam As TabPage
	Friend WithEvents tabPagePassCam As TabPage
	Public WithEvents grpVBErrors As GroupBox
	Public WithEvents lstVBError As ListBox
	Public WithEvents grpHSDisplayDriver As GroupBox
	Public WithEvents HSDisplayDriver As AxHSDisplay
	Public WithEvents grpHSDisplayCenter As GroupBox
	Public WithEvents HSDisplayCenter As AxHSDisplay
	Public WithEvents grpHSDisplayPassenger As GroupBox
	Public WithEvents HSDisplayPassenger As AxHSDisplay
	Friend WithEvents grpVisionDriver As GroupBox
	Friend WithEvents grpVisionCenter As GroupBox
	Friend WithEvents grpVisionPassenger As GroupBox
	Friend WithEvents grpResults As GroupBox
	Friend WithEvents lblPassengerInspection As Label
	Friend WithEvents lblCenterInspection As Label
	Friend WithEvents lblDriverInspection As Label
	Friend WithEvents lblBracketInspection As Label
	Friend WithEvents btnMainRunPassengerInspec As Button
	Friend WithEvents btnMainRunCenterInspec As Button
	Friend WithEvents btnMainRunDriverInspec As Button
	Friend WithEvents btnMainRunGlassInspection As Button
	Friend WithEvents tabPagePosition As TabPage
	Friend WithEvents grpGlassLocate As GroupBox
	Public WithEvents grpStatusDriver As GroupBox
	Public WithEvents lblFitDriver As Label
	Public WithEvents lblVisionPoseFirDriver As Label
	Friend WithEvents lblVisionPoseFitDriver As Label
	Friend WithEvents lblVisionPoseScoreDriver As Label
	Friend WithEvents lblVisionPoseTimeDriver As Label
	Friend WithEvents lblVisionPoseRDriver As Label
	Friend WithEvents lblVisionPoseYDriver As Label
	Friend WithEvents lblVisionPoseXDriver As Label
	Public WithEvents btnDetailsDriver As Button
	Public WithEvents lblVisionMessageDriver As Label
	Public WithEvents lblVisionXDriver As Label
	Public WithEvents lblVisionYDriver As Label
	Public WithEvents lblVisionAngleDriver As Label
	Public WithEvents lblVisionTimeDriver As Label
	Public WithEvents lblVisionScoreDriver As Label
	Public WithEvents grpCenterVisStatus As GroupBox
	Public WithEvents lblFitCenter As Label
	Public WithEvents lblVisionPoseFirCenter As Label
	Friend WithEvents lblVisionPoseFitCenter As Label
	Friend WithEvents lblVisionPoseScoreCenter As Label
	Friend WithEvents lblVisionPoseTimeCenter As Label
	Friend WithEvents lblVisionPoseRCenter As Label
	Friend WithEvents lblVisionPoseYCenter As Label
	Friend WithEvents lblVisionPoseXCenter As Label
	Public WithEvents btnDetailsCenter As Button
	Public WithEvents lblVisionMessageCenter As Label
	Public WithEvents lblVisionXCenter As Label
	Public WithEvents lblVisionYCenter As Label
	Public WithEvents lblVisionAngleCenter As Label
	Public WithEvents lblVisionTimeCenter As Label
	Public WithEvents lblVisionScoreCenter As Label
	Public WithEvents grpPassengerVisStatus As GroupBox
	Public WithEvents lblFitPassenger As Label
	Public WithEvents lblVisionPoseFirPassenger As Label
	Friend WithEvents lblVisionPoseFitPassenger As Label
	Friend WithEvents lblVisionPoseScorePassenger As Label
	Friend WithEvents lblVisionPoseTimePassenger As Label
	Friend WithEvents lblVisionPoseRPassenger As Label
	Friend WithEvents lblVisionPoseYPassenger As Label
	Friend WithEvents lblVisionPoseXPassenger As Label
	Public WithEvents btnDetailsPassenger As Button
	Public WithEvents lblVisionMessagePassenger As Label
	Public WithEvents lblVisionXPassenger As Label
	Public WithEvents lblVisionYPassenger As Label
	Public WithEvents lblVisionAnglePassenger As Label
	Public WithEvents lblVisionTimePassenger As Label
	Public WithEvents lblVisionScorePassenger As Label
	Friend WithEvents grpDriverCameraStatus As GroupBox
	Friend WithEvents lblCameraStatusDriver As Label
	Public WithEvents lblTemperatureDriver As Label
	Friend WithEvents pbDriverTemperature As PictureBox
	Friend WithEvents grpCameraStatusCenter As GroupBox
	Friend WithEvents lblCameraStatusCenterWarning As Label
	Public WithEvents lblTemperatureCenter As Label
	Friend WithEvents pbCenterCameraStatus As PictureBox
	Friend WithEvents grpPassengerCameraStatus As GroupBox
	Friend WithEvents lblCameraStatusPassenger As Label
	Public WithEvents lblTemperaturePassenger As Label
	Friend WithEvents pbPassengerTemperature As PictureBox
	Friend WithEvents grpCenterBlob As GroupBox
	Friend WithEvents lblMaxBlobCountCenter As Label
	Friend WithEvents lblMinimumBlobCountCenter As Label
	Friend WithEvents updnCenterBlobThresholdMax As NumericUpDown
	Friend WithEvents updnCenterBlobThresholdMin As NumericUpDown
	Friend WithEvents grpDriveBlob As GroupBox
	Friend WithEvents lblDriverMaxBlobCount As Label
	Friend WithEvents lblDriverMinBlobCount As Label
	Friend WithEvents updnDriverBlobThresholdMax As NumericUpDown
	Friend WithEvents updnDriverBlobThresholdMin As NumericUpDown
	Friend WithEvents lblHeartBeat As Label
	Friend WithEvents grpPassengerThreshold As GroupBox
	Friend WithEvents lblPassThresholdMax As Label
	Friend WithEvents lblPassThresholdMin As Label
	Friend WithEvents updnPassengerBlobThresholdMax As NumericUpDown
	Friend WithEvents updnPassengerBlobThresholdMin As NumericUpDown
	Friend WithEvents btnSaveDriverBlobArea As Button
	Friend WithEvents lblDriverBlobArea As Label
	Friend WithEvents trkDriverBlob As TrackBar
	Friend WithEvents lblTrackDriverValue As Label
	Friend WithEvents tabpageBracketLocateAtConveyor As TabPage
	Friend WithEvents grpVisionBracketLocateatConveyor As GroupBox
	Friend WithEvents tabPageBracketLocateTape As TabPage
	Friend WithEvents grpVisionBracketLocateTape As GroupBox
	Friend WithEvents grpHSDisplayBracketConveyor As GroupBox
	Public WithEvents HSDisplayBracketConveyor As AxHSDisplay
	Public WithEvents grpStatusBracketLocateAtConveoyr As GroupBox
	Public WithEvents lblFitBracketConveyor As Label
	Public WithEvents lblVisionPoseFirBracketConveyor As Label
	Friend WithEvents lblVisionPoseFitBracketConveyor As Label
	Friend WithEvents lblVisionPoseScoreBracketConveyor As Label
	Friend WithEvents lblVisionPoseTimeBracketConveyor As Label
	Friend WithEvents lblVisionPoseRBracketConveyor As Label
	Friend WithEvents lblVisionPoseYBracketConveyor As Label
	Friend WithEvents lblVisionPoseXBracketConveyor As Label
	Public WithEvents btnDetailsBracketConveyor As Button
	Public WithEvents lblVisionMessageBracketConveyor As Label
	Public WithEvents lblVisionXBracketConveyor As Label
	Public WithEvents lblVisionYBracketConveyor As Label
	Public WithEvents lblVisionAngleBracketConveyor As Label
	Public WithEvents lblVisionTimeBracketConveyor As Label
	Public WithEvents lblVisionScoreBracketConveyor As Label
	Friend WithEvents lblBracketInspectionTape As Label
	Friend WithEvents lblBracketInspectionConveyor As Label
	Friend WithEvents btnMainRunBracketInspectionTape As Button
	Friend WithEvents btnMainRunBracketInspectionConveyor As Button
	Public WithEvents grpStatusBracketLocateTape As GroupBox
	Public WithEvents btnDetailsBracketTape As Button
	Public WithEvents lblVisionMessageBracketTape As Label
	Friend WithEvents grpHSDisplayBracketTape As GroupBox
	Public WithEvents HSDisplayBracketTape As AxHSDisplay
	Friend WithEvents lblTrackCenterValue As Label
	Friend WithEvents trkCenterBlob As TrackBar
	Friend WithEvents lblCenterBlobArea As Label
	Friend WithEvents btnSaveCenterBlobArea As Button
	Friend WithEvents grpBrackConveyorCamera As GroupBox
	Friend WithEvents lblBracketConveyorCameraWarning As Label
	Public WithEvents lblTemperatureBracketAtConveyor As Label
	Friend WithEvents pbBracketConveyorCamera As PictureBox
	Friend WithEvents grpBracketTapeCamera As GroupBox
	Friend WithEvents lblBracketTapeCameraWarning As Label
	Public WithEvents lblTemperatureBracketTape As Label
	Friend WithEvents pbBracketTape As PictureBox
	Friend WithEvents lblTrackPassengerValue As Label
	Friend WithEvents trkPassengerBlob As TrackBar
	Friend WithEvents lblPassengerBlobArea As Label
	Friend WithEvents btnSavePassengerBlobArea As Button
	Friend WithEvents tabPageCenterBracketVerify As TabPage
	Friend WithEvents grpVisionCenterVerify As GroupBox
	Friend WithEvents grpCameraStatusVerify As GroupBox
	Friend WithEvents lblCameraStatusVerify As Label
	Public WithEvents lblTemperatureBracketVerify As Label
	Friend WithEvents pctTemperatureVerify As PictureBox
	Public WithEvents grpVisionStatusVerify As GroupBox
	Public WithEvents lblFitBracketVerify As Label
	Public WithEvents lblVisionPoseFirBracketVerify As Label
	Friend WithEvents lblVisionPoseFitBracketVerify As Label
	Friend WithEvents lblVisionPoseScoreBracketVerify As Label
	Friend WithEvents lblVisionPoseTimeBracketVerify As Label
	Friend WithEvents lblVisionPoseRBracketVerify As Label
	Friend WithEvents lblVisionPoseYBracketVerify As Label
	Friend WithEvents lblVisionPoseXBracketVerify As Label
	Public WithEvents btnDetailsBracketVerify As Button
	Public WithEvents lblVisionMessageBracketVerify As Label
	Public WithEvents lblVisionXBracketVerify As Label
	Public WithEvents lblVisionYBracketVerify As Label
	Public WithEvents lblVisionRBracketVerify As Label
	Public WithEvents lblVisionTimeBracketVerify As Label
	Public WithEvents lblVisionScoreBracketVerify As Label
	Public WithEvents grpHSDisplayBracketVerify As GroupBox
	Public WithEvents HSDisplayCenterBracketVerify As AxHSDisplay
	Friend WithEvents btnMainRunBracketVerify As Button
	Friend WithEvents lblBracketInspectionVerify As Label
	Public WithEvents grpCameraControlLocateConveyor As GroupBox
	Friend WithEvents lblCamControlAcqTimeBracketConveyor As Label
	Friend WithEvents lblContrastBracketConveyor As Label
	Friend WithEvents lblExposureBracketConveyor As Label
	Public WithEvents updnContrastBracketConveyor As NumericUpDown
	Public WithEvents updnExposureBracketConveyor As NumericUpDown
	Public WithEvents btnSnapBracketConveyor As Button
	Public WithEvents chkSnapRepeatBracketconveyor As CheckBox
	Public WithEvents lblCameraTimeBracketConveyor As Label
	Public WithEvents grpLocatorControlsBracketConveyor As GroupBox
	Friend WithEvents lblScoreLimitBracketconveyor As Label
	Public WithEvents btnLocateOnlyBracketConveyor As Button
	Public WithEvents btnLocateBracketConveyor As Button
	Friend WithEvents updnScoreLimitBracketconveyor As NumericUpDown
	Public WithEvents chkLocateBracketConveyor As CheckBox
	Public WithEvents btnSearchSettingsBracketConveyor As Button
	Public WithEvents btnTrainNewBracketconveyor As Button
	Public WithEvents lblLocateTimeBracketconveyor As Label
	Friend WithEvents lblLocatorTimeBracketConveyor As Label
	Public WithEvents btnTrainExistingBracketConveyor As Button
	Public WithEvents grpCameraControlLocateTape As GroupBox
	Friend WithEvents lblCamControlAcqTimeBracketTape As Label
	Friend WithEvents lblContrastBracketTape As Label
	Friend WithEvents lblExposureBracketTape As Label
	Public WithEvents updnContrastBracketTape As NumericUpDown
	Public WithEvents updnExposureBracketTape As NumericUpDown
	Public WithEvents btnSnapBracketTape As Button
	Public WithEvents chkSnapRepeatBracketTape As CheckBox
	Public WithEvents lblCameraTimeBracketTape As Label
	Public WithEvents grpLocatorControlsBracketTape As GroupBox
	Public WithEvents btnLocateOnlyBracketTape As Button
	Public WithEvents btnLocateBracketTape As Button
	Public WithEvents chkLocateBracketTape As CheckBox
	Public WithEvents btnSearchSettingsBracketTape As Button
	Public WithEvents btnTrainNewBracketTape As Button
	Public WithEvents lblLocateTimeBracketTape As Label
	Friend WithEvents lblLocatorTimeBracketTape As Label
	Public WithEvents btnTrainExistingBracketTape As Button
	Public WithEvents grpCameraControlBrackeyVerify As GroupBox
	Friend WithEvents lblCamControlAcqTimeCenterVerify As Label
	Friend WithEvents lblContrastCenterVerify As Label
	Friend WithEvents lblExposureCenterVerify As Label
	Public WithEvents updnContrastCenterVerify As NumericUpDown
	Public WithEvents updnExposureCenterVerify As NumericUpDown
	Public WithEvents btnSnapCenterVerify As Button
	Public WithEvents chkSnapRepeatBrackeyVerify As CheckBox
	Public WithEvents lblCameraTimeBracketVerify As Label
	Public WithEvents grpLocatorControlsBracketVerify As GroupBox
	Friend WithEvents lblScoreLimitCenterVerify As Label
	Public WithEvents btnLocateOnlyBracketVerify As Button
	Public WithEvents btnLocateBracketVerify As Button
	Friend WithEvents updnScoreLimitCenterVerify As NumericUpDown
	Public WithEvents chkLocateGlassVerify As CheckBox
	Public WithEvents btnSearchSettingsCenterVerify As Button
	Public WithEvents btnTrainNewCenterVerify As Button
	Public WithEvents lblLocateTimeCenterVerify As Label
	Friend WithEvents lblLocatorTimeCenterVerify As Label
	Public WithEvents btnTrainExistingCenterVerify As Button
	Public WithEvents grpCameraControlDriver As GroupBox
	Friend WithEvents lblCamControlAcqTimeDriver As Label
	Friend WithEvents lblContrastDriver As Label
	Friend WithEvents lblExposureDriver As Label
	Public WithEvents updnContrastDriver As NumericUpDown
	Public WithEvents updnExposureDriver As NumericUpDown
	Public WithEvents btnSnapDriver As Button
	Public WithEvents chkSnapRepeatDriver As CheckBox
	Public WithEvents lblCameraTimeDriver As Label
	Public WithEvents grpLocatorControlsDriver As GroupBox
	Friend WithEvents lblScoreLimitDriver As Label
	Public WithEvents btnLocateOnlyDriver As Button
	Public WithEvents btnLocateDriver As Button
	Friend WithEvents updnScoreLimitDriver As NumericUpDown
	Public WithEvents chkLocateDriver As CheckBox
	Public WithEvents btnSearchSettingsDriver As Button
	Public WithEvents btnTrainNewDriver As Button
	Public WithEvents lblLocateTimeDriver As Label
	Friend WithEvents lblLocatorTimeDriver As Label
	Public WithEvents btnTrainExistingDriver As Button
	Public WithEvents grpCameraControlCenter As GroupBox
	Friend WithEvents lblCamControlAcqTimeCenter As Label
	Friend WithEvents lblContrastCenter As Label
	Friend WithEvents lblExposureCenter As Label
	Public WithEvents updnContrastCenter As NumericUpDown
	Public WithEvents updnExposureCenter As NumericUpDown
	Public WithEvents btnSnapCenter As Button
	Public WithEvents chkSnapRepeatCenter As CheckBox
	Public WithEvents lblCameraTimeCenter As Label
	Public WithEvents grpLocatorControlsCenter As GroupBox
	Friend WithEvents lblScoreLimitCenter As Label
	Public WithEvents btnLocateOnlyCenter As Button
	Public WithEvents btnLocateCenter As Button
	Friend WithEvents updnScoreLimitCenter As NumericUpDown
	Public WithEvents chkLocateCenter As CheckBox
	Public WithEvents btnSearchSettingsCenter As Button
	Public WithEvents btnTrainNewCenter As Button
	Public WithEvents lblLocateTimeCenter As Label
	Friend WithEvents lblLocatorTimeCenter As Label
	Public WithEvents btnTrainExistingCenter As Button
	Public WithEvents grpCameraControlPassenger As GroupBox
	Friend WithEvents lblCamControlAcqTimePassenger As Label
	Friend WithEvents lblContrastPassenger As Label
	Friend WithEvents lblExposurePassenger As Label
	Public WithEvents updnContrastPassenger As NumericUpDown
	Public WithEvents updnExposurePassenger As NumericUpDown
	Public WithEvents btnSnapPassenger As Button
	Public WithEvents chkSnapRepeatPassenger As CheckBox
	Public WithEvents lblCameraTimePassenger As Label
	Public WithEvents grpLocatorControlsPassenger As GroupBox
	Friend WithEvents lblScoreLimitPassenger As Label
	Public WithEvents btnLocateOnlyPassenger As Button
	Public WithEvents btnLocatePassenger As Button
	Friend WithEvents updnScoreLimitPassenger As NumericUpDown
	Public WithEvents chkLocatePassenger As CheckBox
	Public WithEvents btnSearchSettingsPassenger As Button
	Public WithEvents btnTrainNewPassenger As Button
	Public WithEvents lblLocateTimePassenger As Label
	Friend WithEvents lblLocatorTimePassenger As Label
	Public WithEvents btnTrainExistingPassenger As Button
	Friend WithEvents lblGlueApplication As Label
	Friend WithEvents lblbacklight As Label
	Friend WithEvents btnBacklight As Button
	Friend WithEvents lblOverheadLight As Label
	Friend WithEvents btnOverheadLight As Button
	Friend WithEvents lblStatus As Label
	Friend WithEvents lblmessagedesc As Label
	Friend WithEvents mnuCalibrateCenter As ToolStripMenuItem
	Public WithEvents lblDriverBlobAreaDesc As Label
	Friend WithEvents lblDriverCurrentBlobArea As Label
	Public WithEvents lblCenterCurrentBlobAreaDesc As Label
	Friend WithEvents lblCenterCurrentBlobArea As Label
	Public WithEvents lblPAssengerBlobAreaDesc As Label
	Friend WithEvents lblPassengerCurrentBlobArea As Label
	Friend WithEvents lblLaser As Label
	Public WithEvents btnDriverTrainBlob As Button
	Public WithEvents btnDriverSaveBlob As Button
	Public WithEvents btnCenterSaveBlob As Button
	Public WithEvents btnCenterTrainBlob As Button
	Public WithEvents btnPassengerSaveBlob As Button
	Public WithEvents btnPassengerTrainBlob As Button
	Friend WithEvents mnuCalibrateDriver As ToolStripMenuItem
	Friend WithEvents mnuCalibratePassenger As ToolStripMenuItem
	Public WithEvents lblCurrentUser As Label
	Friend WithEvents tabpageBracketPrimerVerify As TabPage
	Friend WithEvents grpVisionBracketPrimer As GroupBox
	Public WithEvents grpCameraControlPrimer As GroupBox
	Friend WithEvents lblCamControlAcqTimeBracketPrimerDesc As Label
	Friend WithEvents lblContrastBracketPrimer As Label
	Friend WithEvents lblExposureBracketPrimer As Label
	Public WithEvents updnContrastBracketPrimer As NumericUpDown
	Public WithEvents updnExposureBracketPrimer As NumericUpDown
	Public WithEvents btnSnapBracketPrimer As Button
	Public WithEvents chkSnapRepeatBracketPrimer As CheckBox
	Public WithEvents lblCameraTimeBracketPrimer As Label
	Friend WithEvents grpBracketPrimerCamera As GroupBox
	Friend WithEvents lblBracketPrimerCameraWarning As Label
	Public WithEvents lblTemperatureBracketPrimer As Label
	Friend WithEvents pbBracketPrimer As PictureBox
	Public WithEvents grpStatusBracketLocatePrimer As GroupBox
	Public WithEvents lblFitBracketPrimer As Label
	Public WithEvents lblVisionPoseFirBracketPrimer As Label
	Friend WithEvents lblVisionPoseFitBracketPrimer As Label
	Friend WithEvents lblVisionPoseScoreBracketPrimer As Label
	Friend WithEvents lblVisionPoseTimeBracketPrimer As Label
	Friend WithEvents lblVisionPoseRBracketPrimer As Label
	Friend WithEvents lblVisionPoseYBracketPrimer As Label
	Friend WithEvents lblVisionPoseXBracketPrimer As Label
	Public WithEvents btnBracketPrimerDetails As Button
	Public WithEvents lblVisionMessageBracketPrimer As Label
	Public WithEvents lblVisionXBracketPrimer As Label
	Public WithEvents lblVisionYBracketPrimer As Label
	Public WithEvents lblVisionAngleBracketPrimer As Label
	Public WithEvents lblVisionTimeBracketPrimer As Label
	Public WithEvents lblVisionScoreBracketPrimer As Label
	Public WithEvents grpLocatorControlsBracketPrimer As GroupBox
	Friend WithEvents lblScoreLimitBracketPrimer As Label
	Public WithEvents btnLocateOnlyBracketPrimer As Button
	Public WithEvents btnLocateBracketPrimer As Button
	Friend WithEvents updnScoreLimitBracketPrimer As NumericUpDown
	Public WithEvents chkLocateBracketPrimer As CheckBox
	Public WithEvents btnSearchSettingsBracketPrimer As Button
	Public WithEvents btnTrainNewBracketPrimer As Button
	Public WithEvents lblLocateTimeBracketPrimer As Label
	Friend WithEvents lblLocatorTime2 As Label
	Public WithEvents btnTrainExistingBracketPrimer As Button
	Friend WithEvents grpHSDisplayBracketPrimer As GroupBox
	Public WithEvents HSDisplayBracketPrimer As AxHSDisplay
	Friend WithEvents lblBracketInspectionPrimer As Label
	Friend WithEvents btnMainRunBracketInspectionPrimer As Button
	Friend WithEvents grpGlassVerifyValues As GroupBox
	Friend WithEvents lblVerifyTopRight As Label
	Friend WithEvents lblVerifyBottomRight As Label
	Friend WithEvents lblVerifyBottomLeft As Label
	Friend WithEvents ImageList1 As ImageList
	Friend WithEvents lblAllowedVariance As Label
	Friend WithEvents updnTopRightVerifyVariance As NumericUpDown
	Friend WithEvents updnBottomRightVerifyVariance As NumericUpDown
	Friend WithEvents updnBottomLeftVerifyVariance As NumericUpDown
	Friend WithEvents btnSaveVerifyDifference As Button
	Friend WithEvents lblVerifyMasterLengths As Label
	Friend WithEvents mnuPartSettings As ToolStripMenuItem
	Friend WithEvents mnuSystemDocumentation As ToolStripMenuItem
	Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
	Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents txtVerifySavedDiffTopRight As TextBox
	Friend WithEvents txtVerifySavedDiffBottomRight As TextBox
	Friend WithEvents txtVerifySavedDiffBottomLeft As TextBox
	Friend WithEvents mnuTabSwitching As ToolStripMenuItem
	Friend WithEvents mnuCameraCalibration As ToolStripMenuItem
	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents txtDistance3 As TextBox
	Friend WithEvents txtDistance2 As TextBox
	Friend WithEvents txtDistance1 As TextBox
	Friend WithEvents Label4 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents Label1 As Label
	Friend WithEvents lblPositionZ As Label
	Public WithEvents updnLocationZ As NumericUpDown
	Friend WithEvents updnGocator As NumericUpDown
	Friend WithEvents btnCalcAngle As Button
	Friend WithEvents mnuSaveVerification As ToolStripMenuItem
	Friend WithEvents SystemManualToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents grpBracketPrimer As GroupBox
	Public WithEvents btnSaveBracketPrimer4 As Button
	Public WithEvents btnTrainBracketPrimer4 As Button
	Public WithEvents btnSaveBracketPrimer3 As Button
	Public WithEvents btnTrainBracketPrimer3 As Button
	Public WithEvents btnSaveBracketPrimer2 As Button
	Public WithEvents btnTrainBracketPrimer2 As Button
	Public WithEvents btnSaveBracketPrimer1 As Button
	Public WithEvents btnTrainBracketPrimer1 As Button
	Friend WithEvents Label5 As Label
	Friend WithEvents updnBracketPrimer2Deviation As NumericUpDown
	Friend WithEvents updnBracketPrimer1Deviation As NumericUpDown
	Public WithEvents btnSaveBracketPrimer5 As Button
	Public WithEvents btnTrainBracketPrimer5 As Button
	Public WithEvents btnSaveBracketPrimerReference As Button
	Public WithEvents btnTrainBracketPrimerReference As Button
	Friend WithEvents grpBracketPrimerReference As GroupBox
	Friend WithEvents updnBracketPrimer4Deviation As NumericUpDown
	Friend WithEvents updnBracketPrimer3Deviation As NumericUpDown
	Friend WithEvents Label8 As Label
	Friend WithEvents Label7 As Label
	Friend WithEvents Label6 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents updnBracketPrimer5Deviation As NumericUpDown
	Friend WithEvents lblBracketPrimerMeanValue As Label
	Friend WithEvents btnBacklightPrimer As Button
	Friend WithEvents lblbacklightPrimer As Label
	Friend WithEvents btnMainRunTrademark As Button
	Friend WithEvents lblTrademarkInspection As Label
	Friend WithEvents rdoTapeBottomRight As RadioButton
	Friend WithEvents rdoTapeTopRight As RadioButton
	Friend WithEvents rdoTapeBottomLeft As RadioButton
	Friend WithEvents rdoTapeTopLeft As RadioButton
	Friend WithEvents Label9 As Label
	Friend WithEvents updnScoreLimitTapeBracketLocator As NumericUpDown
	Friend WithEvents btnSaveTapeArea As Button
	Friend WithEvents btnTrainTapeArea As Button
   Friend WithEvents lblTapeAreaBottomRight As Label
   Friend WithEvents lblTapeAreaBottomLeft As Label
   Friend WithEvents lblTapeAreaTopRight As Label
   Friend WithEvents lblTapeAreaTopLeft As Label
   Friend WithEvents mnuBracketSettings As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents Button1 As Button
	Friend WithEvents lblGocater As System.Windows.Forms.Label
   Friend WithEvents lblTopRighttDifference As Label
   Friend WithEvents lblBottomRightDifference As Label
   Friend WithEvents Label10 As Label
   Friend WithEvents lblBottomLeftDifference As System.Windows.Forms.Label
   Friend WithEvents lblLength As System.Windows.Forms.Label
   Friend WithEvents lblTopRight As System.Windows.Forms.Label
   Friend WithEvents Label11 As System.Windows.Forms.Label
   Friend WithEvents lblBottomLeft As System.Windows.Forms.Label
   Friend WithEvents lblTapeMaxThreshold As Label
   Friend WithEvents lblTapeMinThreshold As Label
   Friend WithEvents updnTapeBlobMaxBottomRight As NumericUpDown
   Friend WithEvents updnTapeBlobMinBottomRight As NumericUpDown
   Friend WithEvents updnTapeBlobMaxTopRight As NumericUpDown
   Friend WithEvents updnTapeBlobMinTopRight As NumericUpDown
   Friend WithEvents updnTapeBlobMaxBottomLeft As NumericUpDown
   Friend WithEvents updnTapeBlobMinBottomLeft As NumericUpDown
   Friend WithEvents updnTapeBlobMaxTopLeft As NumericUpDown
   Friend WithEvents updnTapeBlobMinTopLeft As NumericUpDown
   Friend WithEvents lblTapeBottomRight As Label
   Friend WithEvents lblTapeBottomLeft As Label
   Friend WithEvents lblTapeTopRight As Label
   Friend WithEvents lblTapeTopLeft As Label
   Friend WithEvents lblTapeMinArea As Label
   Friend WithEvents updnTapeMinAreaBottomRight As NumericUpDown
   Friend WithEvents updnTapeMinAreaBottomLeft As NumericUpDown
   Friend WithEvents updnTapeMinAreaTopRight As NumericUpDown
   Friend WithEvents updnTapeMinAreaTopLeft As NumericUpDown
   Friend WithEvents btnShiftCntrs As Button
   Friend WithEvents Button2 As System.Windows.Forms.Button
   Friend WithEvents lblVisionTapeScoreData As System.Windows.Forms.Label
   Friend WithEvents lblVisionTapeTimeData As System.Windows.Forms.Label
   Friend WithEvents lblVisionTapeRData As System.Windows.Forms.Label
   Friend WithEvents lblVisionTapeYData As System.Windows.Forms.Label
   Friend WithEvents lblVisionTapeXData As System.Windows.Forms.Label
   Public WithEvents lblVisionTapeX As System.Windows.Forms.Label
   Public WithEvents lblVisionTapeY As System.Windows.Forms.Label
   Public WithEvents lblVisionTapeR As System.Windows.Forms.Label
   Public WithEvents lblVisionTapeTime As System.Windows.Forms.Label
   Public WithEvents lblVisionTapeScore As System.Windows.Forms.Label
   Friend WithEvents Label24 As Label
   Friend WithEvents Label23 As Label
   Friend WithEvents Label22 As Label
   Friend WithEvents Label21 As Label
   Friend WithEvents Label20 As Label
   Friend WithEvents Label19 As Label
   Friend WithEvents Label18 As Label
   Friend WithEvents Label17 As Label
   Friend WithEvents Label16 As Label
	Friend WithEvents lblTapeFoundArea As Label
	Public WithEvents gprBracketTapeBlobControls As System.Windows.Forms.GroupBox
	Public WithEvents gprBracketTapeCoverSettings As System.Windows.Forms.GroupBox
	Friend WithEvents lblCoverFoundArea As System.Windows.Forms.Label
	Friend WithEvents rdoCoverTopRight As System.Windows.Forms.RadioButton
	Friend WithEvents lblCoverAreaTopLeft As System.Windows.Forms.Label
	Friend WithEvents rdoCoverBottomLeft As System.Windows.Forms.RadioButton
	Friend WithEvents lblCoverMaxArea As System.Windows.Forms.Label
	Friend WithEvents rdoCoverBottomRight As System.Windows.Forms.RadioButton
	Friend WithEvents lblCoverAreaBottomRight As System.Windows.Forms.Label
	Friend WithEvents btnTrainCoverArea As System.Windows.Forms.Button
	Friend WithEvents rdoCoverTopLeft As System.Windows.Forms.RadioButton
	Friend WithEvents btnSaveCoverArea As System.Windows.Forms.Button
	Friend WithEvents lblCoverAreaBottomLeft As System.Windows.Forms.Label
	Friend WithEvents lblCoverMinThreshold As System.Windows.Forms.Label
	Friend WithEvents updnCoverMaxAreaBottomRight As System.Windows.Forms.NumericUpDown
	Friend WithEvents updnCoverBlobMinBottomRight As System.Windows.Forms.NumericUpDown
	Friend WithEvents lblCoverAreaTopRight As System.Windows.Forms.Label
	Friend WithEvents updnCoverMaxAreaBottomLeft As System.Windows.Forms.NumericUpDown
	Friend WithEvents updnCoverBlobMinTopLeft As System.Windows.Forms.NumericUpDown
	Friend WithEvents lblCoverTopLeft As System.Windows.Forms.Label
	Friend WithEvents updnCoverMaxAreaTopRight As System.Windows.Forms.NumericUpDown
	Friend WithEvents lblCoverTopRight As System.Windows.Forms.Label
	Friend WithEvents lblCoverBottomLeft As System.Windows.Forms.Label
	Friend WithEvents updnCoverMaxAreaTopLeft As System.Windows.Forms.NumericUpDown
	Friend WithEvents updnCoverBlobMinTopRight As System.Windows.Forms.NumericUpDown
	Friend WithEvents updnCoverBlobMinBottomLeft As System.Windows.Forms.NumericUpDown
	Friend WithEvents lblCoverBottomRight As System.Windows.Forms.Label
#End Region
End Class