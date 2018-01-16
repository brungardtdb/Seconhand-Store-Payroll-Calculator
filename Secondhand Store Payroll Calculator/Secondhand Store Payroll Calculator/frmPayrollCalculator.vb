' Program Name: Seconhand Store Payroll Calculator
' Author:   David Brungardt
' Date:     12/03/2017
' Purpose:  This windows application computes the 
'           gross pay, total tax and net pay for 
'           a seconhand store based on wage, hours
'           worked, and tax rate (Single or Family)

Option Strict On

Public Class frmPayrollCalculator
    Private Sub frmPayrollCalculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' This event handler is executed when
        ' the form is loaded at the start of
        ' the program. It sets the focus
        ' to the Name text box and 
        ' clears the Gross Pay, Total Tax
        ' and Net Pay labels.

        txtName.Focus()
        lblGrossPay.Text = ""
        lblTotalTax.Text = ""
        lblNetPay.Text = ""

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' This event handler is executed when
        ' the user selects the Clear button, 
        ' It clears the Name textbox, Hours 
        ' textbox, and Hourly Wage textbox.
        ' It clears the Employee Name label
        ' the Gross Pay label, the Total 
        ' Tax label, and the Net Pay label
        ' It resets the radio butons with 
        ' the Single tax rate selected and sets
        ' the focus to the Name textbox

        txtName.Clear()
        txtHourlyRate.Clear()
        txtHours.Clear()
        lblName.Text = ""
        lblGrossPay.Text = ""
        lblTotalTax.Text = ""
        lblNetPay.Text = ""
        radSingle.Checked = True
        radFamily.Checked = False
        txtName.Focus()


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Closes the window and terminates the application
        Close()

    End Sub

    Private Sub btnCalculatePay_Click(sender As Object, e As EventArgs) Handles btnCalculatePay.Click
        ' The btnCalculate event handler calculates the gross pay,
        ' total tax, and net pay of the employee based on the hourly
        ' rate, hours worked, and tax rate selected.

        'Declaration Section
        Dim decSingleRate As Decimal = 0.19D
        Dim decFamilyRate As Decimal = 0.16D
        Dim decGrossPay As Decimal
        Dim decTaxDeduction As Decimal
        Dim decNetPay As Decimal
        Dim decHoursWorked As Decimal
        Dim decHourlyRate As Decimal
        Dim decTaxRate As Decimal
        Dim decOverTime As Decimal = 1.5D

        ' Did the user enter a name?
        If txtName.Text <> "" Then
            lblEmployeeName.Text = txtName.Text

            ' Did the user enter a numeric value for hours?
            If IsNumeric(txtHours.Text) Then
                decHoursWorked = Convert.ToDecimal(txtHours.Text)

                'Did the user enter a numeric value for the hourly rate?
                If IsNumeric(txtHourlyRate.Text) Then
                    decHourlyRate = Convert.ToDecimal(txtHourlyRate.Text)

                    ' Are hours worked between 5 and 60?
                    If decHoursWorked >= 5 And decHoursWorked <= 60 Then

                        ' Is Hourly wage between $8.00/hr and $40.00/hr
                        If decHourlyRate >= 8.0 And decHourlyRate <= 40.0 Then

                            ' Calculate and display the gross pay, net pay, and total taxes
                            If decHoursWorked <= 40D Then
                                decGrossPay = decHoursWorked * decHourlyRate
                            Else
                                decGrossPay = (decHoursWorked + ((decHoursWorked - 40D) * 0.5D)) * decHourlyRate
                            End If

                            ' Calculate Pay based on Tax Rate
                            If radSingle.Checked Then
                                decTaxRate = decSingleRate
                            ElseIf radFamily.Checked Then
                                decTaxRate = decFamilyRate
                            End If

                            lblName.Text = txtName.Text
                            lblGrossPay.Text = decGrossPay.ToString("C")
                            decTaxDeduction = decGrossPay * decTaxRate
                            lblTotalTax.Text = decTaxDeduction.ToString("C")
                            decNetPay = decGrossPay - decTaxDeduction
                            lblNetPay.Text = decNetPay.ToString("C")

                        Else
                            ' Display the error message if the user didn't enter a wage between $8.00/hr and $40.00/hr
                            MsgBox("You Entered " & decHourlyRate.ToString() & ". Enter a dollar amount between $8.00/hr and $40.00/hr", , "Input Error")
                        End If
                    Else
                        ' Display the error message if the user didn't enter a number of hours between 5 and 60
                        MsgBox("You Entered " & decHoursWorked.ToString() & ". Enter a number of hours between 5.00 and 60.00", , "Input Error")
                    End If
                Else
                    MsgBox("Enter the Hourly Rate", , "Input Error")
                    txtHourlyRate.Text = ""
                    txtHourlyRate.Focus()

                End If

            Else
                ' Display the error message if the user didn't enter a numeric value
                MsgBox("Enter the Hours Worked", , "Input Error")
                txtHours.Text = ""
                txtHours.Focus()

            End If
        Else
            MsgBox("Enter the Employee Name", , "Input Error")
            txtName.Text = ""
            txtName.Focus()
        End If


    End Sub

    Private Sub lblEmployeeName_Click(sender As Object, e As EventArgs) Handles lblEmployeeName.Click

    End Sub
End Class
