Public Class Form1
    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Panel1.Enabled = False
        Panel2.Enabled = True

        lblName.Text = txtName.Text
        lblAge.Text = txtAge.Text
        lblCivilStatus.Text = txtCivilStatus.Text

        txtName.Clear()
        txtAge.Clear()
        txtCivilStatus.Clear()

        Panel1.BackColor = Color.White

        Panel2.BackColor = Color.SlateBlue
        Panel3.BackColor = Color.DarkSlateBlue

        lblBasePrice.ForeColor = Color.White
        lblSeniorDiscount.ForeColor = Color.White
        lblPromoDiscount.ForeColor = Color.White
        lblTotalPrice.ForeColor = Color.White

        lblName2.ForeColor = Color.White
        lblAge2.ForeColor = Color.White
        lblCivilStatus2.ForeColor = Color.White

        lblName.ForeColor = Color.LightGray
        lblAge.ForeColor = Color.LightGray
        lblCivilStatus.ForeColor = Color.LightGray

        lblMenu.ForeColor = Color.White

        lblChicken.ForeColor = Color.White
        lblChickenPrice.ForeColor = Color.White

        lblDuck.ForeColor = Color.White
        lblDuckPrice.ForeColor = Color.White

        lblTurkey.ForeColor = Color.White
        lblTurkeyPrice.ForeColor = Color.White

        lblPayment.ForeColor = Color.White
    End Sub

    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        Dim ChickenPrice As Integer = 350
        Dim DuckPrice As Integer = 400
        Dim TurkeyPrice As Integer = 500

        Dim BasePrice As Integer = (Val(txtChickenQty.Text * ChickenPrice) + Val(txtDuckQty.Text * DuckPrice) + Val(txtTurkeyQty.Text * TurkeyPrice))

        txtBasePrice.Text = BasePrice

        If lblAge.Text >= 60 And txtBasePrice.Text >= 1000 Then
            txtSeniorDiscount.Text = 250
            txtPromoDiscount.Text = 0
        ElseIf lblAge.Text >= 60 Then
            txtSeniorDiscount.Text = 250
            txtPromoDiscount.Text = 0
        ElseIf txtBasePrice.Text >= 1000 Then
            txtPromoDiscount.Text = 200
            txtSeniorDiscount.Text = 0
        Else
            txtSeniorDiscount.Text = 0
            txtPromoDiscount.Text = 0
        End If

        txtTotalPrice.Text = (Val(txtBasePrice.Text) - Val(txtSeniorDiscount.Text) - Val(txtPromoDiscount.Text))
    End Sub

    Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click
        If Val(txtBasePrice.Text) = 0 Then
            MsgBox("Buy something first!", vbCritical, "Error!")
            Return
        End If

        If Val(txtPayment.Text) < Val(txtTotalPrice.Text) Then
            MsgBox("Insufficient Payment!", vbCritical, "Error!")
        Else
            MsgBox("Payment Confirmed. Your Change is: " & (Val(txtPayment.Text) - Val(txtTotalPrice.Text)), vbOKOnly, "Payment Confirmed")
            txtChickenQty.Text = 0
            txtDuckQty.Text = 0
            txtTurkeyQty.Text = 0
            txtBasePrice.Clear()
            txtSeniorDiscount.Clear()
            txtPromoDiscount.Clear()
            txtTotalPrice.Clear()
            txtPayment.Clear()
        End If
    End Sub
End Class
