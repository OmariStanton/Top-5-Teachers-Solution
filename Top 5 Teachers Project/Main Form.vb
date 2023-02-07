Public Class frmMain
    Private Sub lstTop5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstTop5.SelectedIndexChanged
        If lstTop5.SelectedIndex = 0 Then
            picTeacher.Image = My.Resources.myportrait
        ElseIf lstTop5.SelectedIndex = 1 Then
            picTeacher.Image = My.Resources.IMG_0418
        ElseIf lstTop5.SelectedIndex = 2 Then
            picTeacher.Image = My.Resources._18950952_10100174549997740_5334887257537245901_n
        ElseIf lstTop5.SelectedIndex = 3 Then
            picTeacher.Image = My.Resources.Ms__Jones
        ElseIf lstTop5.SelectedIndex = 4 Then
            picTeacher.Image = My.Resources.Alaskaaaa
        End If

    End Sub
End Class
