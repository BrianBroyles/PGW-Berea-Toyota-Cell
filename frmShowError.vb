Public Class frmShowError
    Private Sub btnErrorOK_Click(sender As Object, e As EventArgs) Handles btnErrorOK.Click
        Dim Fail As Boolean
        Fail = frmMain.HelperCamPassenger.isOnline
        If  Fail Then
            lblMessageDesc.Text = "Unable to communicate with:"
            lblErrorMessage.Text = ""
			Me.Hide()
		End If

    End Sub
End Class