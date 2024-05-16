Imports System.Text.RegularExpressions

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "Mobile No"
        Label2.Text = "Email ID"
        Button1.Text = " Validate"

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ValidateMobileNumber()
        ValidateEmailAddress()
    End Sub
    Private Sub ValidateMobileNumber()
        Dim mobileNumber As String = TextBox1.Text.Trim()

        If String.IsNullOrEmpty(mobileNumber) Then
            ErrorProvider1.SetError(TextBox1, "Mobile number is required.")
        ElseIf Not Regex.IsMatch(mobileNumber, "^\d{10}$") Then
            ErrorProvider1.SetError(TextBox1, "Invalid mobile number format. Please enter 10 digits.")
        Else
            ErrorProvider1.SetError(TextBox1, "")
            MsgBox("Valid Phone Number")
        End If
    End Sub

    Private Sub ValidateEmailAddress()
        Dim email As String = TextBox2.Text.Trim()

        If String.IsNullOrEmpty(email) Then
            ErrorProvider1.SetError(TextBox2, "Email address is required.")
        ElseIf Not Regex.IsMatch(email, "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$") Then
            ErrorProvider1.SetError(TextBox2, "Invalid email address format.")
        Else
            ErrorProvider1.SetError(TextBox2, "")
            MsgBox("Valid E-mail ID")
        End If
    End Sub

End Class
