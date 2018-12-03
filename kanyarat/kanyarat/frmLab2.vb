Public Class frmLab2

    Private Sub btnCalcurate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcurate.Click

        Dim vistra As Long
        Dim fristra As Long
        Dim sum As Long
        Dim com1 As Long
        Dim com2 As Long
        Dim commis As Long

        vistra = Val(txtvistra.Text)
        fristra = Val(txtfrista.Text)
        sum = vistra + fristra

        lblsum.Text = sum

        com1 = vistra * 5 / 100
        com2 = fristra * 5 / 100
        commis = com1 + com2

        lblcom1.Text = com1
        lblcom2.Text = com2
        lblcommis.Text = commis


    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub
End Class