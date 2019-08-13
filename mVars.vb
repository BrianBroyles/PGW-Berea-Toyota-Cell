Option Strict Off
Option Explicit On
Module mVars
	'General Constants
	Public Const Rad As Double = 180 / Math.PI

	'Paths
	Public AppPath As String = My.Application.Info.DirectoryPath
	Public OpenOfficePath As String = "C:\Program Files\OpenOffice.org 2.4\program\swriter.exe "
	Public ConfigPath As String = AppPath & "\..\..\Config Data\"	'AppPath.Replace("\VB Code\bin", "") & "\Config Data\"
	Public PartsPath As String = AppPath & "\..\..\Parts\" 'AppPath.Replace("\VB Code\bin", "") & "\Parts\"
	Public PartsPath2 As String = AppPath.Replace("\VB Code\Bin", "\Parts\")
	Public HelpPath As String = AppPath & "\..\..\Help\" 'AppPath.Replace("\VB Code\bin", "") & "\Help\"
	Public CurrentFilePath As String
	Public CurrentImagePath As String
	Public DriverBlobVariance As Integer
	Public CenterBlobVariance As Integer
	Public PassengerBlobVariance As Integer
	Public TapeBlobVarianceTopLeft As Integer = 0
	Public TapeBlobVarianceTopRight As Integer = 0
	Public TapeBlobVarianceBottomLeft As Integer = 0
	Public TapeBlobVarianceBottomRight As Integer = 0

	Public DriverBlobArea As Int64
	Public CenterBlobArea As Int64
	Public PassengerBlobArea As Int64
	Public TapeBlobArea(5) As Int64
	Public TapeCoverArea(5) As Int64
	Public BracketPrimer(5) As Int64
	Public SavedCenterBlobArea As Int64
	Public SavedDriverBlobArea As Int64
	Public SavedPassengerBlobArea As Int64
	Public SavedTapeBlobAreaTopLeft As Int64
	Public SavedTapeBlobAreaTopRight As Int64
	Public SavedTapeBlobAreaBottomLeft As Int64
	Public SavedTapeBlobAreaBottomRight As Int64

	Public CurrentTapeArea(8) As Boolean
	Public eText As Boolean
	Public CamLocation(12) As String
	Public ConfigName(12) As String

	'General Variables
	Public PrimerTrained As Boolean
	Public PartName As String
	Public TableName As String
	Public s32Cam As Integer
	Public HeartBeat As Boolean = True
	Public count As Integer = 0
	Public InTraining As Boolean = False
	Public INRoutines As Boolean
	Public INRoutine As Boolean
	'Public BlobLocation As _BlobLocation
	Public OnlineMessage As String = ""
	Public SavedGlassVariance As Double
	Public ChangingPart As Boolean = False
	Public BracketTapeInspectionNumber As Int16 = 0
	' Debbug Vars
	Public DebugTimer3 As Single
	Public DebugGocator As Single = 0
	Public PLCIO(8) As Boolean
	'
	Public CurrentVisionTab As Integer
	Public NumCams As Integer
	Public PartUseBracket As Boolean
	Public PartPrimer As Boolean
	Public PartSettingsBracketName As String
	Public PartSettingsRobotID As Int16
	Public PartSettingLocationZ As Int16
	'
	Public LocX As Int16
	Public LocY As Int16

	Public Deposit As PointData
	Public SavedDeposit As PointData
	Public OriginalDeposit As PointData
	'
	Public Side As PointGroup
	Public Pick As PointGroup
	'
	Public LocatorResults(12) As VisionData

	Public GoTab As Boolean
	Public BlobDeviation As Integer = 0
	Public ReferenceMean As Int64
	Public BracketPrimerFail As Boolean = False

	

	'Servo related
	Public PickupLimit As LimitStruct
	'
	' Camera Related
	Public InitSuccessBracket As Boolean 'cam 1
	Public InitSuccessDriver As Boolean	'cam 1
	Public InitSuccessCenter As Boolean	'cam 1
	Public InitSuccessPassenger As Boolean 'cam 1
	Public InitSuccessPrimerTape As Boolean	'cam 1
	'
	'Gocator
	Public GoCatorIP As String = "192.168.1.10"
	Public PLCDriver As String

	Public PLC_Tags As _PLC_Tags
	Public PLCIPAddress As String
	'  PLC  Related
	Public Structure _PLC_Tags
		Public plcTag_Heartbeat As String
		Public test_heartbeat As String
		Public plcTag_ShiftClr As String
		'
		Public plcTag_PrimerCheckStart As String
		Public plcTag_PrimerCheckPass As String
		Public plcTag_PrimerCheckFail As String
		Public plcTag_PrimerCheckDone As String
		'
		Public plcTag_BracketGlassLocationStart As String
		Public plcTag_BracketGlassLocationX As String
		Public plcTag_BracketGlassLocationY As String
		Public plcTag_BracketGlassLocationR As String
		Public plcTag_BracketGlassLocationDone As String
		Public plcTag_BracketGlassLocationStat As String
		'Location of Bracket at conveyor
		Public plcTag_BracketConveyorLocationStart As String
		Public plcTag_BracketConveyorLocationX As String
		Public plcTag_BracketConveyorLocationY As String
		Public plcTag_BracketConveyorLocationR As String
		Public plcTag_BracketConveyorLocationDone As String
		Public plcTag_BracketConveyorLocationStat As String
		'Location of Bracket on Glass
		Public plcTag_BracketVerifyStart As String
		Public plcTag_BracketVerifyPass As String
		Public plcTag_BracketVerifyFail As String
		Public plcTag_BracketVerifyDone As String
		'bracket Tape Verification
		Public plcTag_BracketTapeStart As String
		Public plcTag_BracketTapePass As String
		Public plcTag_BracketTapeFail As String
		Public plcTag_BracketTapeDone As String
		'Glue
		Public plcTag_LaserGluePass As String
		Public plcTag_LaserGlueFail As String
		'Lighting
		Public plcTag_OverLight As String
		Public plcTag_Backlight As String
		Public plcTag_ConveyorLight As String
		Public plcTag_PrimerLight As String
		'Center Primer Only
		Public plcTag_HPrimerStart As String
		Public plcTag_HPrimerPass As String
		Public plcTag_HPrimerFail As String
		Public plcTag_HPrimerDone As String
		'Bracket Primer Check
		Public plcTag_BracketPrimerStart As String
		Public plcTag_BracketPrimerDone As String
		Public plcTag_BracketPrimerPassed As String
		Public plcTag_BracketPrimerFail As String
	End Structure

	Public DebugValue As String
	Public debugtime As Integer
	Public CurrentLineRecipe As Integer = 0
	Public PLC_IO_Write_Bracket(2) As _PLC_IO_Write_Bracket
	Public Heartbeat_Tick As Boolean = False
	Public Heartbeat_IRQ As Integer = 0
	'
	'used in FrmCalc
	Public Origin As Point_
	Public RefAnchor As Point_
	Public Offset As Point_
	'
	'Verify program completion
	Public isdone As Double

	'used in frmMain
	Public RefVerify0 As Point_
	Public RefVerify1 As Point_
	Public RefVerify2 As Point_
	Public RefLocate0 As Point_
	Public RefLocate1 As Point_
	Public RefLocate2 As Point_
	Public Upper As Point_
	Public Lower As Point_
	Public NewRef As Point_

	'Database names used to save Blob Location Information
	Public DriverBlobDataBaseNames = {"DriverBlobToolPosX", "DriverBlobToolPosY", "DriverBlobToolWidth", "DriverBlobToolHeight", "DriverBlobToolPosR"}
	Public PassengerBlobDataBaseNames = {"PassengerBlobToolPosX", "PassengerBlobToolPosY", "PassengerBlobToolWidth", "PassengerBlobToolHeight", "PassengerBlobToolPosR"}
	Public CenterBlobDataBaseNames = {"CenterBlobToolPosX", "CenterBlobToolPosY", "CenterBlobToolWidth", "CenterBlobToolHeight", "CenterBlobToolPosR"}
	Public BracketPrimer1BlobDataBaseNames = {"BracketPrimerBlobToolPosX1", "BracketPrimerBlobToolPosY1", "BracketPrimerBlobToolWidth1", "BracketPrimerBlobToolHeight1", "BracketPrimerBlobToolPosR1"}
	Public BracketPrimer2BlobDataBaseNames = {"BracketPrimerBlobToolPosX2", "BracketPrimerBlobToolPosY2", "BracketPrimerBlobToolWidth2", "BracketPrimerBlobToolHeight2", "BracketPrimerBlobToolPosR2"}
	Public BracketPrimer3BlobDataBaseNames = {"BracketPrimerBlobToolPosX3", "BracketPrimerBlobToolPosY3", "BracketPrimerBlobToolWidth3", "BracketPrimerBlobToolHeight3", "BracketPrimerBlobToolPosR3"}
	Public BracketPrimer4BlobDataBaseNames = {"BracketPrimerBlobToolPosX4", "BracketPrimerBlobToolPosY4", "BracketPrimerBlobToolWidth4", "BracketPrimerBlobToolHeight4", "BracketPrimerBlobToolPosR4"}
	Public BracketPrimer5BlobDataBaseNames = {"BracketPrimerBlobToolPosX5", "BracketPrimerBlobToolPosY5", "BracketPrimerBlobToolWidth5", "BracketPrimerBlobToolHeight5", "BracketPrimerBlobToolPosR5"}
	Public BracketPrimerRefBlobDataBaseNames = {"BracketPrimerBlobToolPosXRef", "BracketPrimerBlobToolPosYRef", "BracketPrimerBlobToolWidthRef", "BracketPrimerBlobToolHeightRef", "BracketPrimerBlobToolPosRRef"}
	Public BracketTape1BlobDataBaseNames = {"Bracket Tape Blob 1 PosXRef", "Bracket Tape Blob 1 PosYRef", "Bracket Tape Blob 1 WidthRef", "Bracket Tape Blob 1 HeightRef", "Bracket Tape Blob 1 PosRRef"}
	Public BracketTape2BlobDataBaseNames = {"Bracket Tape Blob 2 PosXRef", "Bracket Tape Blob 2 PosYRef", "Bracket Tape Blob 2 WidthRef", "Bracket Tape Blob 2 HeightRef", "Bracket Tape Blob 2 PosRRef"}
	Public BracketTape3BlobDataBaseNames = {"Bracket Tape Blob 3 PosXRef", "Bracket Tape Blob 3 PosYRef", "Bracket Tape Blob 3 WidthRef", "Bracket Tape Blob 3 HeightRef", "Bracket Tape Blob 3 PosRRef"}
   Public BracketTape4BlobDataBaseNames = {"Bracket Tape Blob 4 PosXRef", "Bracket Tape Blob 4 PosYRef", "Bracket Tape Blob 4 WidthRef", "Bracket Tape Blob 4 HeightRef", "Bracket Tape Blob 4 PosRRef"}
   Public BracketCover1BlobDataBaseNames = {"Bracket Cover Blob 1 PosXRef", "Bracket Cover Blob 1 PosYRef", "Bracket Cover Blob 1 WidthRef", "Bracket Cover Blob 1 HeightRef", "Bracket Cover Blob 1 PosRRef"}
   Public BracketCover2BlobDataBaseNames = {"Bracket Cover Blob 2 PosXRef", "Bracket Cover Blob 2 PosYRef", "Bracket Cover Blob 2 WidthRef", "Bracket Cover Blob 2 HeightRef", "Bracket Cover Blob 2 PosRRef"}
   Public BracketCover3BlobDataBaseNames = {"Bracket Cover Blob 3 PosXRef", "Bracket Cover Blob 3 PosYRef", "Bracket Cover Blob 3 WidthRef", "Bracket Cover Blob 3 HeightRef", "Bracket Cover Blob 3 PosRRef"}
   Public BracketCover4BlobDataBaseNames = {"Bracket Cover Blob 4 PosXRef", "Bracket Cover Blob 4 PosYRef", "Bracket Cover Blob 4 WidthRef", "Bracket Cover Blob 4 HeightRef", "Bracket Cover Blob 4 PosRRef"}

   'User defined types
   Public Structure Point_
		Dim X As Single
		Dim Y As Single
	End Structure

	Public Structure _TagNames
		Dim Vision_Data_X As String	'[0]= "Vision_A_Data[0]"
		Dim Vision_Data_Y As String	'[1]
		Dim Vision_DataR As String ' [2]
		Dim Vision_DataStatus As String	'[3]
	End Structure

	Public Structure PointData
		Dim Point As Point_
		Dim Angle As Single
		Dim Length As Single
		Dim Height As Single
	End Structure

	Public Structure PointGroup
		Dim Original As PointData
		Dim Zeroed As PointData
		Dim Shifted As PointData
		Dim Difference As PointData
	End Structure

	Public Structure VisionData
		Dim Point As Point_
		Dim Angle As Single
		Dim Status As Integer
		Dim Score As Single
		Dim Fit As Single
	End Structure

	Public Structure LimitStruct
		Dim XUpper As Single
		Dim XLower As Single
		Dim YUpper As Single
		Dim YLower As Single
		Dim RUpper As Single
		Dim Rlower As Single
	End Structure

	Public Structure PointStruct
		Dim Row As Integer
		Dim Column As Integer
	End Structure

	Public Structure Rect_
		Dim X As Double
		Dim Y As Double
		Dim R As Double
		Dim Height As Double
		Dim Width As Double
	End Structure

	Public Structure _PLC_IO_Read
		Dim Snap As Boolean
		Dim EarlySnap As Boolean
	End Structure

	Public Structure _PLC_IO_Write_Bracket
		Dim ManTrigger As Boolean
		Dim Vision_Data_X As String
		Dim Vision_Data_Y As String
		Dim Vision_Data_R As String
		Dim VisStat As String
		Dim Pickup_Z As String
	End Structure

	Public Enum Camera
		LocateGlass = 0
		Driver = 1
		Center = 2
		Passenger = 3
		BracketAtConveyor = 4
		GoCator = 5
		BracketTape = 6
		BracketVerify = 7
		BracketPrimer = 8
	End Enum

End Module