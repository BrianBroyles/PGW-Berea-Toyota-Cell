Imports System.Data
Imports System.IO

Public Class frmPartSettings


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim BracketName As String
        Dim TempText As String
        Dim RobotID As Int16
        Try
            'Save Bracket and Primer Choices 
            frmDataBase.SetValue("Partdata", "Value", chkBracket.Name, CBool(chkBracket.Checked))
            frmDataBase.SetValue("Partdata", "Value", chkPrimer.Name, CBool(chkPrimer.Checked))
            TempText = lstBracket.SelectedItem
            BracketName = Mid(TempText, 1, InStr(TempText, ":") - 1)
            RobotID = Mid(TempText, InStr(TempText, "ID:") + 4, Len(TempText))
            'Save Bracket Name
            If lstBracket.SelectedItem <> "" And IsNumeric(RobotID) Then
                frmDataBase.SetValue("Partdata", "Value", txtPartSettingsCurrentBracketType.Name, BracketName)
                frmDataBase.SetValue("Partdata", "Value", txtBracketID.Name, RobotID)
            Else
                MsgBox("No Bracket was Selected")
            End If
            'write values to txt file
            Dim FS As StreamWriter
            FS = New StreamWriter(ConfigPath & "\Brackets.txt")
            Dim FileText As String
            For i As Int16 = 0 To lstBracket.Items.Count - 1
                FileText = lstBracket.Items.Item(i)
                FS.WriteLine(FileText)
            Next i
            FS.Close()
            '
            PartSettingsBracketName = BracketName
            PartSettingsRobotID = RobotID
            'send the data to the plc
            If chkBracket.Checked Then
                frmMain.PLC_DriverCLX.Write("vis_pc_inspections.1", CInt(chkBracket.Checked) * -1)
            Else
                frmMain.PLC_DriverCLX.Write("vis_pc_inspections.1", CInt(chkBracket.Checked))
            End If
            If chkPrimer.Checked Then
                frmMain.PLC_DriverCLX.Write("vis_pc_inspections.0", CInt(chkPrimer.Checked) * -1)
            Else
                frmMain.PLC_DriverCLX.Write("vis_pc_inspections.0", CInt(chkPrimer.Checked))
            End If
         '
         frmMain.PLC_DriverCLX.Write("vis_pc_Bracket_Type", PartSettingsBracketName)
         frmMain.PLC_DriverCLX.Write("vis_pc_Robot_Prog", PartSettingsRobotID)
            '
            Me.Hide()
        Catch ex As Exception
            frmMain.ShowVBErrors("Save Value Partsettings", ex.Message)
        End Try
    End Sub

    Private Sub chkBracket_CheckedChanged(sender As Object, e As EventArgs) Handles chkBracket.CheckedChanged
        Try
            If chkBracket.Checked Then
                btnAddNewBracket.Enabled = True
                btnRemoveItem.Enabled = True
                lstBracket.Enabled = True
                txtPartSettingsCurrentBracketType.Enabled = True
                txtBracketID.Enabled = True
            Else
                btnAddNewBracket.Enabled = False
                btnRemoveItem.Enabled = False
                lstBracket.Enabled = False
                txtPartSettingsCurrentBracketType.Enabled = False
                txtBracketID.Enabled = False
            End If
        Catch ex As Exception
            frmMain.ShowVBErrors("Part Settings Bracket Checked ", ex.Message)
        End Try

    End Sub


    Private Sub txtBracketID_TextChanged(sender As Object, e As EventArgs) Handles txtBracketID.TextChanged
        If Not IsNumeric(txtBracketID.Text) Then
            txtBracketID.Text = ""
            txtBracketID.Focus()
        End If
    End Sub

    Private Sub btnAddNewBracket_Click(sender As Object, e As EventArgs) Handles btnAddNewBracket.Click
        Dim NewString As String = txtPartSettingsCurrentBracketType.Text & ":" & " ID: " & txtBracketID.Text
        lstBracket.Items.Add(NewString)
        For i As Int16 = 0 To lstBracket.Items.Count - 1
            If lstBracket.Items.Item(i) = NewString Then
                lstBracket.SelectedIndex = i
            End If
        Next i

    End Sub

    Private Sub btnRemoveItem_Click(sender As Object, e As EventArgs) Handles btnRemoveItem.Click
        lstBracket.Items.Remove(lstBracket.SelectedItem)
        lstBracket.SelectedIndex = 1
        lstBracket.Refresh()
    End Sub

    Private Sub frmPartSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        chkBracket.Checked = frmDataBase.GetValue("Partdata", "Value", chkBracket.Name)
        chkPrimer.Checked = frmDataBase.GetValue("Partdata", "Value", chkPrimer.Name)
        Try
            Dim FS As StreamReader
            FS = New StreamReader(ConfigPath & "\Brackets.txt")
            Do While Not FS.EndOfStream
                lstBracket.Items.Add(FS.ReadLine())
            Loop
            FS.Close()
            'select index of current bracket name
            For i As Int16 = 0 To lstBracket.Items.Count - 1
                If lstBracket.Items.Item(i) = PartSettingsBracketName & ":" & " ID: " & PartSettingsRobotID Then
                    lstBracket.SelectedIndex = i
                End If
            Next i
        Catch ex As Exception
            frmMain.ShowVBErrors("Part Settings Load ", ex.Message)
        End Try
    End Sub

    Private Sub lstBracket_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstBracket.SelectedIndexChanged

    End Sub
End Class