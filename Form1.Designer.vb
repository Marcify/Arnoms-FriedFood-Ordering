<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        btnConfirm = New Button()
        txtCivilStatus = New TextBox()
        txtAge = New TextBox()
        txtName = New TextBox()
        lblCustomerInfo = New Label()
        Panel2 = New Panel()
        btnPay = New Button()
        lblPayment = New Label()
        Panel3 = New Panel()
        txtTotalPrice = New TextBox()
        txtPromoDiscount = New TextBox()
        txtSeniorDiscount = New TextBox()
        lblTotalPrice = New Label()
        lblPromoDiscount = New Label()
        lblSeniorDiscount = New Label()
        txtBasePrice = New TextBox()
        lblBasePrice = New Label()
        txtPayment = New TextBox()
        txtTurkeyQty = New TextBox()
        txtDuckQty = New TextBox()
        txtChickenQty = New TextBox()
        lblTurkeyPrice = New Label()
        lblDuckPrice = New Label()
        lblChickenPrice = New Label()
        lblTurkey = New Label()
        lblDuck = New Label()
        lblChicken = New Label()
        lblMenu = New Label()
        lblCivilStatus = New Label()
        lblAge = New Label()
        lblName = New Label()
        lblCivilStatus2 = New Label()
        lblAge2 = New Label()
        lblName2 = New Label()
        btnCompute = New Button()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.SlateBlue
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(btnConfirm)
        Panel1.Controls.Add(txtCivilStatus)
        Panel1.Controls.Add(txtAge)
        Panel1.Controls.Add(txtName)
        Panel1.Controls.Add(lblCustomerInfo)
        Panel1.Location = New Point(-4, -1)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(233, 474)
        Panel1.TabIndex = 0
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.ForeColor = Color.White
        Label4.Location = New Point(15, 240)
        Label4.Name = "Label4"
        Label4.Size = New Size(68, 15)
        Label4.TabIndex = 7
        Label4.Text = "Civil Status:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ForeColor = Color.White
        Label3.Location = New Point(15, 200)
        Label3.Name = "Label3"
        Label3.Size = New Size(31, 15)
        Label3.TabIndex = 6
        Label3.Text = "Age:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = Color.White
        Label2.Location = New Point(15, 160)
        Label2.Name = "Label2"
        Label2.Size = New Size(42, 15)
        Label2.TabIndex = 5
        Label2.Text = "Name:"
        ' 
        ' btnConfirm
        ' 
        btnConfirm.BackColor = Color.White
        btnConfirm.FlatAppearance.BorderColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        btnConfirm.FlatStyle = FlatStyle.Flat
        btnConfirm.Font = New Font("Segoe UI", 20F)
        btnConfirm.Location = New Point(40, 322)
        btnConfirm.Name = "btnConfirm"
        btnConfirm.Size = New Size(152, 91)
        btnConfirm.TabIndex = 4
        btnConfirm.Text = "Confirm"
        btnConfirm.UseVisualStyleBackColor = False
        ' 
        ' txtCivilStatus
        ' 
        txtCivilStatus.Location = New Point(84, 237)
        txtCivilStatus.Name = "txtCivilStatus"
        txtCivilStatus.Size = New Size(131, 23)
        txtCivilStatus.TabIndex = 3
        ' 
        ' txtAge
        ' 
        txtAge.Location = New Point(63, 197)
        txtAge.Name = "txtAge"
        txtAge.Size = New Size(152, 23)
        txtAge.TabIndex = 2
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(63, 157)
        txtName.Name = "txtName"
        txtName.Size = New Size(152, 23)
        txtName.TabIndex = 1
        ' 
        ' lblCustomerInfo
        ' 
        lblCustomerInfo.Font = New Font("Segoe UI", 24F, FontStyle.Bold)
        lblCustomerInfo.ForeColor = Color.White
        lblCustomerInfo.Location = New Point(12, 10)
        lblCustomerInfo.Name = "lblCustomerInfo"
        lblCustomerInfo.Size = New Size(208, 113)
        lblCustomerInfo.TabIndex = 0
        lblCustomerInfo.Text = "Customer Information"
        lblCustomerInfo.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Controls.Add(btnPay)
        Panel2.Controls.Add(lblPayment)
        Panel2.Controls.Add(Panel3)
        Panel2.Controls.Add(txtPayment)
        Panel2.Controls.Add(txtTurkeyQty)
        Panel2.Controls.Add(txtDuckQty)
        Panel2.Controls.Add(txtChickenQty)
        Panel2.Controls.Add(lblTurkeyPrice)
        Panel2.Controls.Add(lblDuckPrice)
        Panel2.Controls.Add(lblChickenPrice)
        Panel2.Controls.Add(lblTurkey)
        Panel2.Controls.Add(lblDuck)
        Panel2.Controls.Add(lblChicken)
        Panel2.Controls.Add(lblMenu)
        Panel2.Controls.Add(lblCivilStatus)
        Panel2.Controls.Add(lblAge)
        Panel2.Controls.Add(lblName)
        Panel2.Controls.Add(lblCivilStatus2)
        Panel2.Controls.Add(lblAge2)
        Panel2.Controls.Add(lblName2)
        Panel2.Controls.Add(btnCompute)
        Panel2.Enabled = False
        Panel2.Location = New Point(226, -1)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(264, 474)
        Panel2.TabIndex = 1
        ' 
        ' btnPay
        ' 
        btnPay.BackColor = Color.White
        btnPay.FlatAppearance.BorderColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        btnPay.FlatStyle = FlatStyle.Flat
        btnPay.Font = New Font("Segoe UI", 16F)
        btnPay.Location = New Point(26, 416)
        btnPay.Name = "btnPay"
        btnPay.Size = New Size(212, 43)
        btnPay.TabIndex = 24
        btnPay.Text = "Pay"
        btnPay.UseVisualStyleBackColor = False
        ' 
        ' lblPayment
        ' 
        lblPayment.AutoSize = True
        lblPayment.ForeColor = Color.Black
        lblPayment.Location = New Point(21, 391)
        lblPayment.Name = "lblPayment"
        lblPayment.Size = New Size(57, 15)
        lblPayment.TabIndex = 9
        lblPayment.Text = "Payment:"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = SystemColors.ActiveBorder
        Panel3.Controls.Add(txtTotalPrice)
        Panel3.Controls.Add(txtPromoDiscount)
        Panel3.Controls.Add(txtSeniorDiscount)
        Panel3.Controls.Add(lblTotalPrice)
        Panel3.Controls.Add(lblPromoDiscount)
        Panel3.Controls.Add(lblSeniorDiscount)
        Panel3.Controls.Add(txtBasePrice)
        Panel3.Controls.Add(lblBasePrice)
        Panel3.Location = New Point(13, 256)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(238, 122)
        Panel3.TabIndex = 23
        ' 
        ' txtTotalPrice
        ' 
        txtTotalPrice.Location = New Point(96, 92)
        txtTotalPrice.Name = "txtTotalPrice"
        txtTotalPrice.ReadOnly = True
        txtTotalPrice.Size = New Size(129, 23)
        txtTotalPrice.TabIndex = 32
        ' 
        ' txtPromoDiscount
        ' 
        txtPromoDiscount.Location = New Point(126, 63)
        txtPromoDiscount.Name = "txtPromoDiscount"
        txtPromoDiscount.ReadOnly = True
        txtPromoDiscount.Size = New Size(99, 23)
        txtPromoDiscount.TabIndex = 31
        ' 
        ' txtSeniorDiscount
        ' 
        txtSeniorDiscount.Location = New Point(126, 35)
        txtSeniorDiscount.Name = "txtSeniorDiscount"
        txtSeniorDiscount.ReadOnly = True
        txtSeniorDiscount.Size = New Size(99, 23)
        txtSeniorDiscount.TabIndex = 30
        ' 
        ' lblTotalPrice
        ' 
        lblTotalPrice.AutoSize = True
        lblTotalPrice.Location = New Point(8, 95)
        lblTotalPrice.Name = "lblTotalPrice"
        lblTotalPrice.Size = New Size(61, 15)
        lblTotalPrice.TabIndex = 29
        lblTotalPrice.Text = "Total Price"
        ' 
        ' lblPromoDiscount
        ' 
        lblPromoDiscount.AutoSize = True
        lblPromoDiscount.Location = New Point(8, 66)
        lblPromoDiscount.Name = "lblPromoDiscount"
        lblPromoDiscount.Size = New Size(93, 15)
        lblPromoDiscount.TabIndex = 28
        lblPromoDiscount.Text = "Promo Discount"
        ' 
        ' lblSeniorDiscount
        ' 
        lblSeniorDiscount.AutoSize = True
        lblSeniorDiscount.Location = New Point(8, 38)
        lblSeniorDiscount.Name = "lblSeniorDiscount"
        lblSeniorDiscount.Size = New Size(90, 15)
        lblSeniorDiscount.TabIndex = 27
        lblSeniorDiscount.Text = "Senior Discount"
        ' 
        ' txtBasePrice
        ' 
        txtBasePrice.Location = New Point(126, 8)
        txtBasePrice.Name = "txtBasePrice"
        txtBasePrice.ReadOnly = True
        txtBasePrice.Size = New Size(99, 23)
        txtBasePrice.TabIndex = 26
        ' 
        ' lblBasePrice
        ' 
        lblBasePrice.AutoSize = True
        lblBasePrice.Location = New Point(8, 11)
        lblBasePrice.Name = "lblBasePrice"
        lblBasePrice.Size = New Size(63, 15)
        lblBasePrice.TabIndex = 25
        lblBasePrice.Text = "Base Price:"
        ' 
        ' txtPayment
        ' 
        txtPayment.ForeColor = Color.Black
        txtPayment.Location = New Point(126, 387)
        txtPayment.Name = "txtPayment"
        txtPayment.Size = New Size(112, 23)
        txtPayment.TabIndex = 8
        ' 
        ' txtTurkeyQty
        ' 
        txtTurkeyQty.Location = New Point(184, 188)
        txtTurkeyQty.Name = "txtTurkeyQty"
        txtTurkeyQty.Size = New Size(67, 23)
        txtTurkeyQty.TabIndex = 22
        txtTurkeyQty.Text = "0"
        ' 
        ' txtDuckQty
        ' 
        txtDuckQty.Location = New Point(184, 160)
        txtDuckQty.Name = "txtDuckQty"
        txtDuckQty.Size = New Size(67, 23)
        txtDuckQty.TabIndex = 21
        txtDuckQty.Text = "0"
        ' 
        ' txtChickenQty
        ' 
        txtChickenQty.Location = New Point(184, 132)
        txtChickenQty.Name = "txtChickenQty"
        txtChickenQty.Size = New Size(67, 23)
        txtChickenQty.TabIndex = 8
        txtChickenQty.Text = "0"
        ' 
        ' lblTurkeyPrice
        ' 
        lblTurkeyPrice.AutoSize = True
        lblTurkeyPrice.Location = New Point(109, 196)
        lblTurkeyPrice.Name = "lblTurkeyPrice"
        lblTurkeyPrice.Size = New Size(32, 15)
        lblTurkeyPrice.TabIndex = 20
        lblTurkeyPrice.Text = "P500"
        ' 
        ' lblDuckPrice
        ' 
        lblDuckPrice.AutoSize = True
        lblDuckPrice.Location = New Point(109, 165)
        lblDuckPrice.Name = "lblDuckPrice"
        lblDuckPrice.Size = New Size(32, 15)
        lblDuckPrice.TabIndex = 19
        lblDuckPrice.Text = "P400"
        ' 
        ' lblChickenPrice
        ' 
        lblChickenPrice.AutoSize = True
        lblChickenPrice.Location = New Point(109, 135)
        lblChickenPrice.Name = "lblChickenPrice"
        lblChickenPrice.Size = New Size(32, 15)
        lblChickenPrice.TabIndex = 18
        lblChickenPrice.Text = "P350"
        ' 
        ' lblTurkey
        ' 
        lblTurkey.AutoSize = True
        lblTurkey.Location = New Point(13, 196)
        lblTurkey.Name = "lblTurkey"
        lblTurkey.Size = New Size(42, 15)
        lblTurkey.TabIndex = 17
        lblTurkey.Text = "Turkey"
        ' 
        ' lblDuck
        ' 
        lblDuck.AutoSize = True
        lblDuck.Location = New Point(13, 165)
        lblDuck.Name = "lblDuck"
        lblDuck.Size = New Size(34, 15)
        lblDuck.TabIndex = 16
        lblDuck.Text = "Duck"
        ' 
        ' lblChicken
        ' 
        lblChicken.AutoSize = True
        lblChicken.Location = New Point(13, 135)
        lblChicken.Name = "lblChicken"
        lblChicken.Size = New Size(50, 15)
        lblChicken.TabIndex = 15
        lblChicken.Text = "Chicken"
        ' 
        ' lblMenu
        ' 
        lblMenu.AutoSize = True
        lblMenu.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        lblMenu.Location = New Point(9, 99)
        lblMenu.Name = "lblMenu"
        lblMenu.Size = New Size(72, 30)
        lblMenu.TabIndex = 14
        lblMenu.Text = "Menu"
        ' 
        ' lblCivilStatus
        ' 
        lblCivilStatus.ForeColor = Color.DimGray
        lblCivilStatus.Location = New Point(93, 55)
        lblCivilStatus.Name = "lblCivilStatus"
        lblCivilStatus.Size = New Size(158, 15)
        lblCivilStatus.TabIndex = 13
        ' 
        ' lblAge
        ' 
        lblAge.ForeColor = Color.DimGray
        lblAge.Location = New Point(52, 32)
        lblAge.Name = "lblAge"
        lblAge.Size = New Size(199, 15)
        lblAge.TabIndex = 12
        ' 
        ' lblName
        ' 
        lblName.ForeColor = Color.DimGray
        lblName.Location = New Point(63, 12)
        lblName.Name = "lblName"
        lblName.Size = New Size(188, 15)
        lblName.TabIndex = 11
        ' 
        ' lblCivilStatus2
        ' 
        lblCivilStatus2.AutoSize = True
        lblCivilStatus2.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        lblCivilStatus2.ForeColor = Color.Black
        lblCivilStatus2.Location = New Point(9, 53)
        lblCivilStatus2.Name = "lblCivilStatus2"
        lblCivilStatus2.Size = New Size(86, 19)
        lblCivilStatus2.TabIndex = 10
        lblCivilStatus2.Text = "Civil Status:"
        ' 
        ' lblAge2
        ' 
        lblAge2.AutoSize = True
        lblAge2.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        lblAge2.ForeColor = Color.Black
        lblAge2.Location = New Point(9, 30)
        lblAge2.Name = "lblAge2"
        lblAge2.Size = New Size(40, 19)
        lblAge2.TabIndex = 9
        lblAge2.Text = "Age:"
        ' 
        ' lblName2
        ' 
        lblName2.AutoSize = True
        lblName2.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        lblName2.ForeColor = Color.Black
        lblName2.Location = New Point(9, 10)
        lblName2.Name = "lblName2"
        lblName2.Size = New Size(53, 19)
        lblName2.TabIndex = 8
        lblName2.Text = "Name:"
        ' 
        ' btnCompute
        ' 
        btnCompute.BackColor = Color.White
        btnCompute.FlatAppearance.BorderColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        btnCompute.FlatStyle = FlatStyle.Flat
        btnCompute.Location = New Point(13, 222)
        btnCompute.Name = "btnCompute"
        btnCompute.Size = New Size(75, 28)
        btnCompute.TabIndex = 5
        btnCompute.Text = "Compute"
        btnCompute.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(489, 470)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Arnoms Fried Food"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtCivilStatus As TextBox
    Friend WithEvents txtAge As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblCustomerInfo As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnConfirm As Button
    Friend WithEvents btnCompute As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblMenu As Label
    Friend WithEvents lblCivilStatus As Label
    Friend WithEvents lblAge As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblCivilStatus2 As Label
    Friend WithEvents lblAge2 As Label
    Friend WithEvents lblName2 As Label
    Friend WithEvents txtTurkeyQty As TextBox
    Friend WithEvents txtDuckQty As TextBox
    Friend WithEvents txtChickenQty As TextBox
    Friend WithEvents lblTurkeyPrice As Label
    Friend WithEvents lblDuckPrice As Label
    Friend WithEvents lblChickenPrice As Label
    Friend WithEvents lblTurkey As Label
    Friend WithEvents lblDuck As Label
    Friend WithEvents lblChicken As Label
    Friend WithEvents btnPay As Button
    Friend WithEvents lblPayment As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtPayment As TextBox
    Friend WithEvents txtBasePrice As TextBox
    Friend WithEvents lblBasePrice As Label
    Friend WithEvents txtTotalPrice As TextBox
    Friend WithEvents txtPromoDiscount As TextBox
    Friend WithEvents txtSeniorDiscount As TextBox
    Friend WithEvents lblTotalPrice As Label
    Friend WithEvents lblPromoDiscount As Label
    Friend WithEvents lblSeniorDiscount As Label

End Class
