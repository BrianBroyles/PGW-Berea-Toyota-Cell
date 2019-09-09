'UPGRADE_WARNING: The entire project must be compiled once before a form with an ActiveX Control Array can be displayed

Imports System.ComponentModel

<ProvideProperty("Index",GetType(AxHSDISPLAYLib.AxHSDisplay))> Public Class AxHSDisplayArray
  Inherits Microsoft.VisualBasic.Compatibility.VB6.BaseOcxArray
	Implements IExtenderProvider

	Public Sub New()
		MyBase.New()
	End Sub

	Public Sub New(ByVal Container As IContainer)
		MyBase.New(Container)
	End Sub

	Public Shadows Event [Error] (ByVal sender As System.Object, ByVal e As AxHSDISPLAYLib._DHSDisplayEvents_ErrorEvent)
	Public Shadows Event [AskData] (ByVal sender As System.Object, ByVal e As System.EventArgs)
	Public Shadows Event [ZoomChange] (ByVal sender As System.Object, ByVal e As System.EventArgs)
	Public Shadows Event [FocusChange] (ByVal sender As System.Object, ByVal e As System.EventArgs)
	Public Shadows Event [PointMarkerChange] (ByVal sender As System.Object, ByVal e As AxHSDISPLAYLib._DHSDisplayEvents_PointMarkerChangeEvent)
	Public Shadows Event [LineMarkerChange] (ByVal sender As System.Object, ByVal e As AxHSDISPLAYLib._DHSDisplayEvents_LineMarkerChangeEvent)
	Public Shadows Event [RectangleMarkerChange] (ByVal sender As System.Object, ByVal e As AxHSDISPLAYLib._DHSDisplayEvents_RectangleMarkerChangeEvent)
	Public Shadows Event [InteractiveSelectionChange] (ByVal sender As System.Object, ByVal e As AxHSDISPLAYLib._DHSDisplayEvents_InteractiveSelectionChangeEvent)
	Public Shadows Event [TargetMarkerChange] (ByVal sender As System.Object, ByVal e As AxHSDISPLAYLib._DHSDisplayEvents_TargetMarkerChangeEvent)
	Public Shadows Event [PropertiesChange] (ByVal sender As System.Object, ByVal e As AxHSDISPLAYLib._DHSDisplayEvents_PropertiesChangeEvent)
	Public Shadows Event [AxesMarkerChange] (ByVal sender As System.Object, ByVal e As AxHSDISPLAYLib._DHSDisplayEvents_AxesMarkerChangeEvent)
	Public Shadows Event [CircularArcMarkerChange] (ByVal sender As System.Object, ByVal e As AxHSDISPLAYLib._DHSDisplayEvents_CircularArcMarkerChangeEvent)
	Public Shadows Event [ClickEvent] (ByVal sender As System.Object, ByVal e As System.EventArgs)
	Public Shadows Event [DblClick] (ByVal sender As System.Object, ByVal e As System.EventArgs)
	Public Shadows Event [KeyDownEvent] (ByVal sender As System.Object, ByVal e As AxHSDISPLAYLib._DHSDisplayEvents_KeyDownEvent)
	Public Shadows Event [KeyPressEvent] (ByVal sender As System.Object, ByVal e As AxHSDISPLAYLib._DHSDisplayEvents_KeyPressEvent)
	Public Shadows Event [KeyUpEvent] (ByVal sender As System.Object, ByVal e As AxHSDISPLAYLib._DHSDisplayEvents_KeyUpEvent)
	Public Shadows Event [DisplayMouseDown] (ByVal sender As System.Object, ByVal e As AxHSDISPLAYLib._DHSDisplayEvents_DisplayMouseDownEvent)
	Public Shadows Event [DisplayMouseMove] (ByVal sender As System.Object, ByVal e As AxHSDISPLAYLib._DHSDisplayEvents_DisplayMouseMoveEvent)
	Public Shadows Event [DisplayMouseUp] (ByVal sender As System.Object, ByVal e As AxHSDISPLAYLib._DHSDisplayEvents_DisplayMouseUpEvent)
	Public Shadows Event [CalibratedUnitsChange] (ByVal sender As System.Object, ByVal e As System.EventArgs)
	Public Shadows Event [InteractionModeChange] (ByVal sender As System.Object, ByVal e As System.EventArgs)
	Public Shadows Event [EntitySelectionChange] (ByVal sender As System.Object, ByVal e As AxHSDISPLAYLib._DHSDisplayEvents_EntitySelectionChangeEvent)

	<System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)> Public Function CanExtend(ByVal target As Object) As Boolean Implements IExtenderProvider.CanExtend
		If TypeOf target Is AxHSDISPLAYLib.AxHSDisplay Then
			Return BaseCanExtend(target)
		End If
	End Function

	Public Function GetIndex(ByVal o As AxHSDISPLAYLib.AxHSDisplay) As Short
		Return BaseGetIndex(o)
	End Function

	<System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)> Public Sub SetIndex(ByVal o As AxHSDISPLAYLib.AxHSDisplay, ByVal Index As Short)
		BaseSetIndex(o, Index)
	End Sub

	<System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)> Public Function ShouldSerializeIndex(ByVal o As AxHSDISPLAYLib.AxHSDisplay) As Boolean
		Return BaseShouldSerializeIndex(o)
	End Function

	<System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)> Public Sub ResetIndex(ByVal o As AxHSDISPLAYLib.AxHSDisplay)
		BaseResetIndex(o)
	End Sub

	Default Public ReadOnly Property Item(ByVal Index As Short) As AxHSDISPLAYLib.AxHSDisplay
		Get
			Item = CType(BaseGetItem(Index), AxHSDISPLAYLib.AxHSDisplay)
		End Get
	End Property

	Protected Overrides Function GetControlInstanceType() As System.Type
		Return GetType(AxHSDISPLAYLib.AxHSDisplay)
	End Function

	Protected Overrides Sub HookUpControlEvents(ByVal o As Object)
		Dim ctl As AxHSDISPLAYLib.AxHSDisplay = CType(o, AxHSDISPLAYLib.AxHSDisplay)
		MyBase.HookUpControlEvents(o)
		If Not ErrorEvent Is Nothing Then
			AddHandler ctl.Error, New AxHSDISPLAYLib._DHSDisplayEvents_ErrorEventHandler(AddressOf HandleError)
		End If
		If Not AskDataEvent Is Nothing Then
			AddHandler ctl.AskData, New System.EventHandler(AddressOf HandleAskData)
		End If
		If Not ZoomChangeEvent Is Nothing Then
			AddHandler ctl.ZoomChange, New System.EventHandler(AddressOf HandleZoomChange)
		End If
		If Not FocusChangeEvent Is Nothing Then
			AddHandler ctl.FocusChange, New System.EventHandler(AddressOf HandleFocusChange)
		End If
		If Not PointMarkerChangeEvent Is Nothing Then
			AddHandler ctl.PointMarkerChange, New AxHSDISPLAYLib._DHSDisplayEvents_PointMarkerChangeEventHandler(AddressOf HandlePointMarkerChange)
		End If
		If Not LineMarkerChangeEvent Is Nothing Then
			AddHandler ctl.LineMarkerChange, New AxHSDISPLAYLib._DHSDisplayEvents_LineMarkerChangeEventHandler(AddressOf HandleLineMarkerChange)
		End If
		If Not RectangleMarkerChangeEvent Is Nothing Then
			AddHandler ctl.RectangleMarkerChange, New AxHSDISPLAYLib._DHSDisplayEvents_RectangleMarkerChangeEventHandler(AddressOf HandleRectangleMarkerChange)
		End If
		If Not InteractiveSelectionChangeEvent Is Nothing Then
			AddHandler ctl.InteractiveSelectionChange, New AxHSDISPLAYLib._DHSDisplayEvents_InteractiveSelectionChangeEventHandler(AddressOf HandleInteractiveSelectionChange)
		End If
		If Not TargetMarkerChangeEvent Is Nothing Then
			AddHandler ctl.TargetMarkerChange, New AxHSDISPLAYLib._DHSDisplayEvents_TargetMarkerChangeEventHandler(AddressOf HandleTargetMarkerChange)
		End If
		If Not PropertiesChangeEvent Is Nothing Then
			AddHandler ctl.PropertiesChange, New AxHSDISPLAYLib._DHSDisplayEvents_PropertiesChangeEventHandler(AddressOf HandlePropertiesChange)
		End If
		If Not AxesMarkerChangeEvent Is Nothing Then
			AddHandler ctl.AxesMarkerChange, New AxHSDISPLAYLib._DHSDisplayEvents_AxesMarkerChangeEventHandler(AddressOf HandleAxesMarkerChange)
		End If
		If Not CircularArcMarkerChangeEvent Is Nothing Then
			AddHandler ctl.CircularArcMarkerChange, New AxHSDISPLAYLib._DHSDisplayEvents_CircularArcMarkerChangeEventHandler(AddressOf HandleCircularArcMarkerChange)
		End If
		If Not ClickEventEvent Is Nothing Then
			AddHandler ctl.ClickEvent, New System.EventHandler(AddressOf HandleClickEvent)
		End If
		If Not DblClickEvent Is Nothing Then
			AddHandler ctl.DblClick, New System.EventHandler(AddressOf HandleDblClick)
		End If
		If Not KeyDownEventEvent Is Nothing Then
			AddHandler ctl.KeyDownEvent, New AxHSDISPLAYLib._DHSDisplayEvents_KeyDownEventHandler(AddressOf HandleKeyDownEvent)
		End If
		If Not KeyPressEventEvent Is Nothing Then
			AddHandler ctl.KeyPressEvent, New AxHSDISPLAYLib._DHSDisplayEvents_KeyPressEventHandler(AddressOf HandleKeyPressEvent)
		End If
		If Not KeyUpEventEvent Is Nothing Then
			AddHandler ctl.KeyUpEvent, New AxHSDISPLAYLib._DHSDisplayEvents_KeyUpEventHandler(AddressOf HandleKeyUpEvent)
		End If
		If Not DisplayMouseDownEvent Is Nothing Then
			AddHandler ctl.DisplayMouseDown, New AxHSDISPLAYLib._DHSDisplayEvents_DisplayMouseDownEventHandler(AddressOf HandleDisplayMouseDown)
		End If
		If Not DisplayMouseMoveEvent Is Nothing Then
			AddHandler ctl.DisplayMouseMove, New AxHSDISPLAYLib._DHSDisplayEvents_DisplayMouseMoveEventHandler(AddressOf HandleDisplayMouseMove)
		End If
		If Not DisplayMouseUpEvent Is Nothing Then
			AddHandler ctl.DisplayMouseUp, New AxHSDISPLAYLib._DHSDisplayEvents_DisplayMouseUpEventHandler(AddressOf HandleDisplayMouseUp)
		End If
		If Not CalibratedUnitsChangeEvent Is Nothing Then
			AddHandler ctl.CalibratedUnitsChange, New System.EventHandler(AddressOf HandleCalibratedUnitsChange)
		End If
		If Not InteractionModeChangeEvent Is Nothing Then
			AddHandler ctl.InteractionModeChange, New System.EventHandler(AddressOf HandleInteractionModeChange)
		End If
		If Not EntitySelectionChangeEvent Is Nothing Then
			AddHandler ctl.EntitySelectionChange, New AxHSDISPLAYLib._DHSDisplayEvents_EntitySelectionChangeEventHandler(AddressOf HandleEntitySelectionChange)
		End If
	End Sub

	Private Sub HandleError (ByVal sender As System.Object, ByVal e As AxHSDISPLAYLib._DHSDisplayEvents_ErrorEvent) 
		RaiseEvent [Error] (sender, e)
	End Sub

	Private Sub HandleAskData (ByVal sender As System.Object, ByVal e As System.EventArgs) 
		RaiseEvent [AskData] (sender, e)
	End Sub

	Private Sub HandleZoomChange (ByVal sender As System.Object, ByVal e As System.EventArgs) 
		RaiseEvent [ZoomChange] (sender, e)
	End Sub

	Private Sub HandleFocusChange (ByVal sender As System.Object, ByVal e As System.EventArgs) 
		RaiseEvent [FocusChange] (sender, e)
	End Sub

	Private Sub HandlePointMarkerChange (ByVal sender As System.Object, ByVal e As AxHSDISPLAYLib._DHSDisplayEvents_PointMarkerChangeEvent) 
		RaiseEvent [PointMarkerChange] (sender, e)
	End Sub

	Private Sub HandleLineMarkerChange (ByVal sender As System.Object, ByVal e As AxHSDISPLAYLib._DHSDisplayEvents_LineMarkerChangeEvent) 
		RaiseEvent [LineMarkerChange] (sender, e)
	End Sub

	Private Sub HandleRectangleMarkerChange (ByVal sender As System.Object, ByVal e As AxHSDISPLAYLib._DHSDisplayEvents_RectangleMarkerChangeEvent) 
		RaiseEvent [RectangleMarkerChange] (sender, e)
	End Sub

	Private Sub HandleInteractiveSelectionChange (ByVal sender As System.Object, ByVal e As AxHSDISPLAYLib._DHSDisplayEvents_InteractiveSelectionChangeEvent) 
		RaiseEvent [InteractiveSelectionChange] (sender, e)
	End Sub

	Private Sub HandleTargetMarkerChange (ByVal sender As System.Object, ByVal e As AxHSDISPLAYLib._DHSDisplayEvents_TargetMarkerChangeEvent) 
		RaiseEvent [TargetMarkerChange] (sender, e)
	End Sub

	Private Sub HandlePropertiesChange (ByVal sender As System.Object, ByVal e As AxHSDISPLAYLib._DHSDisplayEvents_PropertiesChangeEvent) 
		RaiseEvent [PropertiesChange] (sender, e)
	End Sub

	Private Sub HandleAxesMarkerChange (ByVal sender As System.Object, ByVal e As AxHSDISPLAYLib._DHSDisplayEvents_AxesMarkerChangeEvent) 
		RaiseEvent [AxesMarkerChange] (sender, e)
	End Sub

	Private Sub HandleCircularArcMarkerChange (ByVal sender As System.Object, ByVal e As AxHSDISPLAYLib._DHSDisplayEvents_CircularArcMarkerChangeEvent) 
		RaiseEvent [CircularArcMarkerChange] (sender, e)
	End Sub

	Private Sub HandleClickEvent (ByVal sender As System.Object, ByVal e As System.EventArgs) 
		RaiseEvent [ClickEvent] (sender, e)
	End Sub

	Private Sub HandleDblClick (ByVal sender As System.Object, ByVal e As System.EventArgs) 
		RaiseEvent [DblClick] (sender, e)
	End Sub

	Private Sub HandleKeyDownEvent (ByVal sender As System.Object, ByVal e As AxHSDISPLAYLib._DHSDisplayEvents_KeyDownEvent) 
		RaiseEvent [KeyDownEvent] (sender, e)
	End Sub

	Private Sub HandleKeyPressEvent (ByVal sender As System.Object, ByVal e As AxHSDISPLAYLib._DHSDisplayEvents_KeyPressEvent) 
		RaiseEvent [KeyPressEvent] (sender, e)
	End Sub

	Private Sub HandleKeyUpEvent (ByVal sender As System.Object, ByVal e As AxHSDISPLAYLib._DHSDisplayEvents_KeyUpEvent) 
		RaiseEvent [KeyUpEvent] (sender, e)
	End Sub

	Private Sub HandleDisplayMouseDown (ByVal sender As System.Object, ByVal e As AxHSDISPLAYLib._DHSDisplayEvents_DisplayMouseDownEvent) 
		RaiseEvent [DisplayMouseDown] (sender, e)
	End Sub

	Private Sub HandleDisplayMouseMove (ByVal sender As System.Object, ByVal e As AxHSDISPLAYLib._DHSDisplayEvents_DisplayMouseMoveEvent) 
		RaiseEvent [DisplayMouseMove] (sender, e)
	End Sub

	Private Sub HandleDisplayMouseUp (ByVal sender As System.Object, ByVal e As AxHSDISPLAYLib._DHSDisplayEvents_DisplayMouseUpEvent) 
		RaiseEvent [DisplayMouseUp] (sender, e)
	End Sub

	Private Sub HandleCalibratedUnitsChange (ByVal sender As System.Object, ByVal e As System.EventArgs) 
		RaiseEvent [CalibratedUnitsChange] (sender, e)
	End Sub

	Private Sub HandleInteractionModeChange (ByVal sender As System.Object, ByVal e As System.EventArgs) 
		RaiseEvent [InteractionModeChange] (sender, e)
	End Sub

	Private Sub HandleEntitySelectionChange (ByVal sender As System.Object, ByVal e As AxHSDISPLAYLib._DHSDisplayEvents_EntitySelectionChangeEvent) 
		RaiseEvent [EntitySelectionChange] (sender, e)
	End Sub

End Class

