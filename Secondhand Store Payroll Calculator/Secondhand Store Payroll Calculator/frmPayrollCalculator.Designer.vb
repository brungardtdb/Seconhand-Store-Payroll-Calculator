<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPayrollCalculator
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radFamily = New System.Windows.Forms.RadioButton()
        Me.radSingle = New System.Windows.Forms.RadioButton()
        Me.lblHourlyRate = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblHoursWorked = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtHours = New System.Windows.Forms.TextBox()
        Me.txtHourlyRate = New System.Windows.Forms.TextBox()
        Me.lblDollarSign = New System.Windows.Forms.Label()
        Me.lblGrossPayLabel = New System.Windows.Forms.Label()
        Me.lblTaxLabel = New System.Windows.Forms.Label()
        Me.lblNetPayLabel = New System.Windows.Forms.Label()
        Me.lblGrossPay = New System.Windows.Forms.Label()
        Me.lblTotalTax = New System.Windows.Forms.Label()
        Me.lblNetPay = New System.Windows.Forms.Label()
        Me.btnCalculatePay = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblEmployeeNameLabel = New System.Windows.Forms.Label()
        Me.lblEmployeeName = New System.Windows.Forms.Label()
        Me.lblTest = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Simplex_IV25", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(86, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(256, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Payroll Calculator"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Firebrick
        Me.GroupBox1.Controls.Add(Me.radFamily)
        Me.GroupBox1.Controls.Add(Me.radSingle)
        Me.GroupBox1.Location = New System.Drawing.Point(38, 231)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(322, 121)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tax Rate"
        '
        'radFamily
        '
        Me.radFamily.AutoSize = True
        Me.radFamily.Location = New System.Drawing.Point(20, 72)
        Me.radFamily.Name = "radFamily"
        Me.radFamily.Size = New System.Drawing.Size(135, 26)
        Me.radFamily.TabIndex = 1
        Me.radFamily.TabStop = True
        Me.radFamily.Text = "Family Rate"
        Me.radFamily.UseVisualStyleBackColor = True
        '
        'radSingle
        '
        Me.radSingle.AutoSize = True
        Me.radSingle.Location = New System.Drawing.Point(20, 30)
        Me.radSingle.Name = "radSingle"
        Me.radSingle.Size = New System.Drawing.Size(131, 26)
        Me.radSingle.TabIndex = 0
        Me.radSingle.TabStop = True
        Me.radSingle.Text = "Single Rate"
        Me.radSingle.UseVisualStyleBackColor = True
        '
        'lblHourlyRate
        '
        Me.lblHourlyRate.AutoSize = True
        Me.lblHourlyRate.Location = New System.Drawing.Point(68, 165)
        Me.lblHourlyRate.Name = "lblHourlyRate"
        Me.lblHourlyRate.Size = New System.Drawing.Size(125, 22)
        Me.lblHourlyRate.TabIndex = 2
        Me.lblHourlyRate.Text = "Hourly Rate:"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(68, 101)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(68, 22)
        Me.lblName.TabIndex = 3
        Me.lblName.Text = "Name:"
        '
        'lblHoursWorked
        '
        Me.lblHoursWorked.AutoSize = True
        Me.lblHoursWorked.Location = New System.Drawing.Point(68, 134)
        Me.lblHoursWorked.Name = "lblHoursWorked"
        Me.lblHoursWorked.Size = New System.Drawing.Size(141, 22)
        Me.lblHoursWorked.TabIndex = 4
        Me.lblHoursWorked.Text = "Hours Worked:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(236, 98)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(203, 30)
        Me.txtName.TabIndex = 5
        '
        'txtHours
        '
        Me.txtHours.Location = New System.Drawing.Point(236, 131)
        Me.txtHours.Name = "txtHours"
        Me.txtHours.Size = New System.Drawing.Size(61, 30)
        Me.txtHours.TabIndex = 6
        '
        'txtHourlyRate
        '
        Me.txtHourlyRate.Location = New System.Drawing.Point(236, 162)
        Me.txtHourlyRate.Name = "txtHourlyRate"
        Me.txtHourlyRate.Size = New System.Drawing.Size(61, 30)
        Me.txtHourlyRate.TabIndex = 7
        '
        'lblDollarSign
        '
        Me.lblDollarSign.AutoSize = True
        Me.lblDollarSign.Location = New System.Drawing.Point(209, 165)
        Me.lblDollarSign.Name = "lblDollarSign"
        Me.lblDollarSign.Size = New System.Drawing.Size(21, 22)
        Me.lblDollarSign.TabIndex = 8
        Me.lblDollarSign.Text = "$"
        '
        'lblGrossPayLabel
        '
        Me.lblGrossPayLabel.AutoSize = True
        Me.lblGrossPayLabel.Location = New System.Drawing.Point(100, 414)
        Me.lblGrossPayLabel.Name = "lblGrossPayLabel"
        Me.lblGrossPayLabel.Size = New System.Drawing.Size(109, 22)
        Me.lblGrossPayLabel.TabIndex = 9
        Me.lblGrossPayLabel.Text = "Gross Pay:"
        '
        'lblTaxLabel
        '
        Me.lblTaxLabel.AutoSize = True
        Me.lblTaxLabel.Location = New System.Drawing.Point(106, 450)
        Me.lblTaxLabel.Name = "lblTaxLabel"
        Me.lblTaxLabel.Size = New System.Drawing.Size(103, 22)
        Me.lblTaxLabel.TabIndex = 10
        Me.lblTaxLabel.Text = "Total Tax:"
        '
        'lblNetPayLabel
        '
        Me.lblNetPayLabel.AutoSize = True
        Me.lblNetPayLabel.Location = New System.Drawing.Point(118, 484)
        Me.lblNetPayLabel.Name = "lblNetPayLabel"
        Me.lblNetPayLabel.Size = New System.Drawing.Size(91, 22)
        Me.lblNetPayLabel.TabIndex = 11
        Me.lblNetPayLabel.Text = "Net Pay:"
        '
        'lblGrossPay
        '
        Me.lblGrossPay.AutoSize = True
        Me.lblGrossPay.Location = New System.Drawing.Point(235, 414)
        Me.lblGrossPay.Name = "lblGrossPay"
        Me.lblGrossPay.Size = New System.Drawing.Size(0, 22)
        Me.lblGrossPay.TabIndex = 12
        '
        'lblTotalTax
        '
        Me.lblTotalTax.AutoSize = True
        Me.lblTotalTax.Location = New System.Drawing.Point(235, 450)
        Me.lblTotalTax.Name = "lblTotalTax"
        Me.lblTotalTax.Size = New System.Drawing.Size(0, 22)
        Me.lblTotalTax.TabIndex = 12
        '
        'lblNetPay
        '
        Me.lblNetPay.AutoSize = True
        Me.lblNetPay.Location = New System.Drawing.Point(235, 484)
        Me.lblNetPay.Name = "lblNetPay"
        Me.lblNetPay.Size = New System.Drawing.Size(0, 22)
        Me.lblNetPay.TabIndex = 12
        '
        'btnCalculatePay
        '
        Me.btnCalculatePay.Location = New System.Drawing.Point(31, 531)
        Me.btnCalculatePay.Name = "btnCalculatePay"
        Me.btnCalculatePay.Size = New System.Drawing.Size(134, 30)
        Me.btnCalculatePay.TabIndex = 13
        Me.btnCalculatePay.Text = "Calculate"
        Me.btnCalculatePay.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClear.Location = New System.Drawing.Point(171, 531)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(134, 30)
        Me.btnClear.TabIndex = 14
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(311, 531)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(134, 30)
        Me.btnExit.TabIndex = 15
        Me.btnExit.Text = "Exit Window"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblEmployeeNameLabel
        '
        Me.lblEmployeeNameLabel.AutoSize = True
        Me.lblEmployeeNameLabel.Location = New System.Drawing.Point(47, 382)
        Me.lblEmployeeNameLabel.Name = "lblEmployeeNameLabel"
        Me.lblEmployeeNameLabel.Size = New System.Drawing.Size(162, 22)
        Me.lblEmployeeNameLabel.TabIndex = 9
        Me.lblEmployeeNameLabel.Text = "Employee Name:"
        '
        'lblEmployeeName
        '
        Me.lblEmployeeName.AutoSize = True
        Me.lblEmployeeName.Location = New System.Drawing.Point(235, 382)
        Me.lblEmployeeName.Name = "lblEmployeeName"
        Me.lblEmployeeName.Size = New System.Drawing.Size(0, 22)
        Me.lblEmployeeName.TabIndex = 12
        '
        'lblTest
        '
        Me.lblTest.AutoSize = True
        Me.lblTest.Location = New System.Drawing.Point(12, 484)
        Me.lblTest.Name = "lblTest"
        Me.lblTest.Size = New System.Drawing.Size(91, 22)
        Me.lblTest.TabIndex = 11
        Me.lblTest.Text = "Net Pay:"
        '
        'frmPayrollCalculator
        '
        Me.AcceptButton = Me.btnCalculatePay
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.IndianRed
        Me.CancelButton = Me.btnClear
        Me.ClientSize = New System.Drawing.Size(477, 583)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculatePay)
        Me.Controls.Add(Me.lblNetPay)
        Me.Controls.Add(Me.lblTotalTax)
        Me.Controls.Add(Me.lblEmployeeName)
        Me.Controls.Add(Me.lblGrossPay)
        Me.Controls.Add(Me.lblTest)
        Me.Controls.Add(Me.lblNetPayLabel)
        Me.Controls.Add(Me.lblTaxLabel)
        Me.Controls.Add(Me.lblEmployeeNameLabel)
        Me.Controls.Add(Me.lblGrossPayLabel)
        Me.Controls.Add(Me.lblDollarSign)
        Me.Controls.Add(Me.txtHourlyRate)
        Me.Controls.Add(Me.txtHours)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblHoursWorked)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblHourlyRate)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Simplex_IV25", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "frmPayrollCalculator"
        Me.Text = "Seconhand Store Payroll Calculator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radFamily As RadioButton
    Friend WithEvents radSingle As RadioButton
    Friend WithEvents lblHourlyRate As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblHoursWorked As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtHours As TextBox
    Friend WithEvents txtHourlyRate As TextBox
    Friend WithEvents lblDollarSign As Label
    Friend WithEvents lblGrossPayLabel As Label
    Friend WithEvents lblTaxLabel As Label
    Friend WithEvents lblNetPayLabel As Label
    Friend WithEvents lblGrossPay As Label
    Friend WithEvents lblTotalTax As Label
    Friend WithEvents lblNetPay As Label
    Friend WithEvents btnCalculatePay As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblEmployeeNameLabel As Label
    Friend WithEvents lblEmployeeName As Label
    Friend WithEvents lblTest As Label
End Class
