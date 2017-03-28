Public Class frmMain
    Dim intInitialNo As Integer
    Dim booEven As Boolean
    Dim intNoIterations As Integer = 0
    Dim intFinalNo As Integer

    Private Sub txtInitialNo_TextChanged(sender As Object, e As EventArgs) Handles txtInitialNo.TextChanged
        If Not txtInitialNo.Text = "" Then
            If IsNumeric(txtInitialNo.Text) = False Then
                txtInitialNo.Text = Mid(txtInitialNo.Text, 1, Len(txtInitialNo.Text) - 1)
                txtInitialNo.Select(txtInitialNo.Text.Length, 0)
            End If
        End If

    End Sub

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        If txtInitialNo.Text = "" Then
            txtInitialNo.Text = ""
            MsgBox("Your initial number must be an integer greater than 1 and must not lead to an iteration of an integer greater than the limit of a 32-bit integer.")
        Else
            intInitialNo = CInt(txtInitialNo.Text)
            If intInitialNo < 2 Then
                txtInitialNo.Text = ""
                MsgBox("Your initial number must be an integer greater than 1 and must not lead to an iteration of an integer greater than the limit of a 32-bit integer.")
            Else
                intFinalNo = intInitialNo
                ProcCollatz()
            End If
        End If

    End Sub

    Sub ProcCollatz()
        intNoIterations = 0
        txtIterations.Text = "Initial Number = " & intInitialNo
        Do While intFinalNo <> 1
            If intFinalNo Mod 2 = 1 Then
                intFinalNo = (intFinalNo * 3) + 1
                txtIterations.AppendText(Environment.NewLine & intNoIterations + 1 & ". " & intFinalNo)
            Else
                intFinalNo = intFinalNo / 2
                txtIterations.AppendText(Environment.NewLine & intNoIterations + 1 & ". " & intFinalNo)
            End If
            intNoIterations += 1
        Loop

    End Sub
End Class
