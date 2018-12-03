Public Class frmLab1

    Private Sub btnKum_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKum.Click
        lblyear.Text = Val(txtMuney.Text) * 12
        lbltax.Text = Val(lblyear.Text) * 0.05
        lblbalance.Text = lblyear.Text - lbltax.Text

    End Sub


    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class
