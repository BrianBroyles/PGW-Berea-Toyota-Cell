Public Class frmCalculateAngle
    Public angle1 As Double = 90
    Public angle2 As Double
    Public angle3 As Double
    Public side1 As Double
    Public side2 As Double
    Public side3 As Double
    Private Sub frmCalculateAngle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim NewX, NewY As Double
        Dim Value As Double
        NewX = Math.Abs(RefVerify0.X - RefVerify1.X)
        NewY = Math.Sqrt(Math.Abs(RefVerify0.Y - RefVerify1.Y))
        Value = Math.Sqrt(NewX * NewX) + (NewY * NewY)

        lblDistanceBottomValue.Text = FormatNumber(Value, 1)
        lblDistanceRightValue.Text = frmMain.FindDistance(RefVerify2.X, RefVerify2.Y, RefVerify1.X, RefVerify1.Y)
    End Sub

    Public Sub feedValues()
        If txtSide1.Text = vbNullString Then
            side1 = 0
        Else
            side1 = txtSide1.Text
        End If
        If txtSide2.Text = vbNullString Then
            side2 = 0
        Else
            side2 = txtSide2.Text
        End If
        If txtSide3.Text = vbNullString Then
            side3 = 0
        Else
            side3 = txtSide3.Text
        End If

        If txtAngle2.Text = vbNullString Then
            angle2 = 0
        Else
            angle2 = txtAngle2.Text
        End If

        If txtAngle3.Text = vbNullString Then
            angle3 = 0
        Else
            angle3 = txtAngle3.Text
        End If
    End Sub
    Public Function degreesToRadians(ByVal degrees As Double) As Double
        Dim radians As Double
        radians = (Math.PI * degrees) / 180
        Return radians
    End Function
    Public Function radiansToDegrees(ByVal radians As Double) As Double
        Dim degrees As Double
        degrees = radians * (180 / Math.PI)
        Return degrees
    End Function
    Public Sub noMoreNaNs()
        For Each txtBox As Control In Me.Controls
            If txtBox.Text = "NaN" Then txtBox.Text = 0
        Next
    End Sub
    Public Sub pythagorean()
        If side1 = 0 Then
            side1 = Math.Sqrt((side2 ^ 2) - (side3 ^ 2))
            txtSide1.Text = FormatNumber(side1, 2)
        ElseIf side2 = 0 Then
            side2 = Math.Sqrt((side1 ^ 2) + (side3 ^ 2))
            txtSide2.Text = FormatNumber(side2, 2)
        ElseIf side3 = 0 Then
            side3 = Math.Sqrt((side2 ^ 2) - (side1 ^ 2))
            txtSide3.Text = FormatNumber(side3, 2)
        End If
    End Sub
    Public Sub angle3Value()
        'Cosine
        If angle3 <> 0 And side2 = 0 Then
            side2 = side3 / Math.Cos(degreesToRadians(angle3))
            txtSide2.Text = FormatNumber(side2, 2)
        End If
        If angle3 <> 0 And side3 = 0 Then
            side3 = side2 * Math.Cos(degreesToRadians(angle3))
            txtSide3.Text = FormatNumber(side3, 2)
        End If
        'Sine
        If angle3 <> 0 And side1 = 0 Then
            side1 = side2 / Math.Sin(degreesToRadians(angle3))
            txtSide1.Text = FormatNumber(side1, 2)
        End If
        If angle3 <> 0 And side2 = 0 Then
            side2 = side1 * (Math.Sin(degreesToRadians(angle3)))
            txtSide2.Text = FormatNumber(side2, 2)
        End If
        'Tangence
        If angle3 <> 0 And side1 = 0 Then
            side1 = side3 / Math.Tan(degreesToRadians(angle3))
            txtSide1.Text = FormatNumber(side1, 2)
        End If
        If angle3 <> 0 And side3 = 0 Then
            side3 = side1 * (Math.Tan(degreesToRadians(angle3)))
            txtSide3.Text = FormatNumber(side3, 2)
        End If
    End Sub
    Public Sub angle2Value()
        'Cosine
        If angle2 <> 0 And side2 = 0 Then
            side2 = side1 / Math.Cos(degreesToRadians(angle2))
            txtSide2.Text = FormatNumber(side2, 2)
        End If
        If angle2 <> 0 And side1 = 0 Then
            side1 = side2 / Math.Cos(degreesToRadians(angle2))
            txtSide1.Text = FormatNumber(side1, 2)
        End If

        'Sine
        If angle2 <> 0 And side2 = 0 Then
            side2 = side3 / Math.Sin(degreesToRadians(angle2))
            txtSide2.Text = FormatNumber(side2, 2)
        End If
        If angle2 <> 0 And side3 = 0 Then
            side3 = side2 / Math.Sin(degreesToRadians(angle2))
            txtSide3.Text = FormatNumber(side3, 2)
        End If
        'Tangence
        If angle2 <> 0 And side3 = 0 Then
            side3 = side1 / Math.Tan(degreesToRadians(angle2))
            txtSide3.Text = FormatNumber(side3, 2)
        End If
        If angle2 <> 0 And side1 = 0 Then
            side1 = side3 / Math.Tan(degreesToRadians(angle2))
            txtSide1.Text = FormatNumber(side1, 2)
        End If
    End Sub
    Public Sub Angle3Locate()
        If angle3 = 0 And side3 <> 0 And side2 <> 0 Then
            'Cos
            angle3 = radiansToDegrees(Math.Acos(side3 / side2))
            txtAngle3.Text = FormatNumber(angle3, 2)
        End If
        If angle3 = 0 And side1 <> 0 And side2 <> 0 Then
            'Sin
            angle3 = radiansToDegrees(Math.Asin(side1 / side2))
            txtAngle3.Text = FormatNumber(angle3, 2)
        End If
        If angle3 = 0 And side3 <> 0 And side1 <> 0 Then
            'Tan
            angle3 = radiansToDegrees(Math.Atan(side1 / side3))
            txtAngle3.Text = FormatNumber(angle3, 2)
        End If
    End Sub
    Public Sub Angle2Locate()
        If angle2 = 0 And side1 <> 0 And side2 <> 0 Then
            'cos
            angle2 = radiansToDegrees(Math.Acos(side1 / side2))
            txtAngle2.Text = FormatNumber(angle2, 2)
        End If

        If angle2 = 0 And side1 <> 0 And side3 <> 0 Then
            'tan
            angle2 = radiansToDegrees(Math.Atan(side3 / side1))

            txtAngle2.Text = FormatNumber(angle2, 2)
        End If

        If angle2 = 0 And side2 <> 0 And side3 <> 0 Then
            'sin
            angle2 = radiansToDegrees(Math.Asin(side3 / side2))
            txtAngle2.Text = FormatNumber(angle2, 2)
        End If
    End Sub
    Public Sub angleSums()
        If angle2 = 0 And angle3 <> 0 Then
            angle2 = 180 - angle1 - angle3
            txtAngle2.Text = FormatNumber(angle2, 2)
        End If
        If angle3 = 0 And angle2 <> 0 Then
            angle3 = 180 - angle1 - angle2
            txtAngle3.Text = FormatNumber(angle3, 2)
        End If
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        For I As Integer = 0 To 2
            feedValues()
            pythagorean()
            noMoreNaNs()
            angleSums()
            noMoreNaNs()
            angle3Value()
            noMoreNaNs()
            angle2Value()
            noMoreNaNs()
            Angle3Locate()
            noMoreNaNs()
            Angle2Locate()
            noMoreNaNs()
        Next
    End Sub


	Private Sub txtAngle2_TextChanged(sender As Object, e As EventArgs) Handles txtAngle2.TextChanged

	End Sub
End Class