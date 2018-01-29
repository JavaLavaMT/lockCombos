Public Class Form1
    Private first(-1) As Integer
    Private sec(-1) As Integer
    Private third(-1) As Integer



    Private Sub btnCal_Click(sender As Object, e As EventArgs) Handles btnCal.Click

        For Each firstCom As Integer In first
            For Each secCom As Integer In sec
                For Each thirdCom As Integer In third

                    lstCombo.Items.Add(firstCom & "," & secCom & "," & thirdCom)

                Next thirdCom
            Next secCom
        Next firstCom
        MessageBox.Show(lstCombo.Items.Count & "combos")

    End Sub

    Private Sub btnFirst_Click(sender As Object, e As EventArgs) Handles btnFirst.Click

        Dim up As Integer = (first.Length - 1)
        ReDim Preserve first(up + 1)
        first(up + 1) = txtFirst.Text
        txtFirst.Clear()
        txtFirst.Focus()
        lblFirst.Text = first.Length & " numbers"
        lblTotal.Text = first.Length + sec.Length + third.Length & " Total numbers"

    End Sub

    Private Sub btnSec_Click(sender As Object, e As EventArgs) Handles btnSec.Click
        Dim up As Integer = (sec.Length - 1)
        ReDim Preserve sec(up + 1)
        sec(up + 1) = txtSec.Text
        txtSec.Clear()
        txtSec.Focus()
        lblSec.Text = sec.Length & " numbers"
        lblTotal.Text = first.Length + sec.Length + third.Length & " Total numbers"
    End Sub

    Private Sub btnThird_Click(sender As Object, e As EventArgs) Handles btnThird.Click
        Dim up As Integer = (third.Length - 1)
        ReDim Preserve third(up + 1)
        third(up + 1) = txtThird.Text
        txtThird.Clear()
        txtThird.Focus()
        lblThird.Text = third.Length & " numbers"
        lblTotal.Text = first.Length + sec.Length + third.Length & " Total numbers"
    End Sub
End Class
