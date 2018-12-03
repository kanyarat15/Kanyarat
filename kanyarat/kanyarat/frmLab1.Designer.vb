<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLab1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblsalary = New System.Windows.Forms.Label()
        Me.Laincome = New System.Windows.Forms.Label()
        Me.txtMuney = New System.Windows.Forms.TextBox()
        Me.lbltax = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Latax = New System.Windows.Forms.Label()
        Me.btnKum = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Labalance = New System.Windows.Forms.Label()
        Me.lblbalance = New System.Windows.Forms.Label()
        Me.lblyear = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblsalary
        '
        Me.lblsalary.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblsalary.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblsalary.Location = New System.Drawing.Point(176, 81)
        Me.lblsalary.Name = "lblsalary"
        Me.lblsalary.Size = New System.Drawing.Size(109, 23)
        Me.lblsalary.TabIndex = 0
        Me.lblsalary.Text = "เงินเดือน"
        '
        'Laincome
        '
        Me.Laincome.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Laincome.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Laincome.Location = New System.Drawing.Point(176, 140)
        Me.Laincome.Name = "Laincome"
        Me.Laincome.Size = New System.Drawing.Size(109, 42)
        Me.Laincome.TabIndex = 0
        Me.Laincome.Text = "รายได้ทั้งปี"
        '
        'txtMuney
        '
        Me.txtMuney.Location = New System.Drawing.Point(451, 84)
        Me.txtMuney.Name = "txtMuney"
        Me.txtMuney.Size = New System.Drawing.Size(100, 20)
        Me.txtMuney.TabIndex = 1
        '
        'lbltax
        '
        Me.lbltax.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbltax.Location = New System.Drawing.Point(448, 219)
        Me.lbltax.Name = "lbltax"
        Me.lbltax.Size = New System.Drawing.Size(121, 39)
        Me.lbltax.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(255, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(177, 32)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "โปรแกรมคำนวนค่าจ้าง"
        '
        'Latax
        '
        Me.Latax.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Latax.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Latax.Location = New System.Drawing.Point(200, 219)
        Me.Latax.Name = "Latax"
        Me.Latax.Size = New System.Drawing.Size(66, 39)
        Me.Latax.TabIndex = 0
        Me.Latax.Text = "ภาษี"
        '
        'btnKum
        '
        Me.btnKum.BackColor = System.Drawing.Color.White
        Me.btnKum.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnKum.Location = New System.Drawing.Point(246, 417)
        Me.btnKum.Name = "btnKum"
        Me.btnKum.Size = New System.Drawing.Size(94, 44)
        Me.btnKum.TabIndex = 2
        Me.btnKum.Text = "คำนวน"
        Me.btnKum.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.White
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnClose.Location = New System.Drawing.Point(442, 417)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(90, 44)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "ปิด"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'Labalance
        '
        Me.Labalance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Labalance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Labalance.Location = New System.Drawing.Point(166, 300)
        Me.Labalance.Name = "Labalance"
        Me.Labalance.Size = New System.Drawing.Size(119, 36)
        Me.Labalance.TabIndex = 0
        Me.Labalance.Text = "เงินได้หลังหักภาษี"
        '
        'lblbalance
        '
        Me.lblbalance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblbalance.Location = New System.Drawing.Point(448, 300)
        Me.lblbalance.Name = "lblbalance"
        Me.lblbalance.Size = New System.Drawing.Size(121, 36)
        Me.lblbalance.TabIndex = 0
        '
        'lblyear
        '
        Me.lblyear.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblyear.Location = New System.Drawing.Point(448, 140)
        Me.lblyear.Name = "lblyear"
        Me.lblyear.Size = New System.Drawing.Size(121, 42)
        Me.lblyear.TabIndex = 0
        '
        'frmLab1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(730, 508)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnKum)
        Me.Controls.Add(Me.txtMuney)
        Me.Controls.Add(Me.Labalance)
        Me.Controls.Add(Me.Latax)
        Me.Controls.Add(Me.lblbalance)
        Me.Controls.Add(Me.lblyear)
        Me.Controls.Add(Me.lbltax)
        Me.Controls.Add(Me.Laincome)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblsalary)
        Me.Name = "frmLab1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblsalary As System.Windows.Forms.Label
    Friend WithEvents Laincome As System.Windows.Forms.Label
    Friend WithEvents txtMuney As System.Windows.Forms.TextBox
    Friend WithEvents lbltax As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Latax As System.Windows.Forms.Label
    Friend WithEvents btnKum As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Labalance As System.Windows.Forms.Label
    Friend WithEvents lblbalance As System.Windows.Forms.Label
    Friend WithEvents lblyear As System.Windows.Forms.Label

End Class
