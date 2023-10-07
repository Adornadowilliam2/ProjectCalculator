Public Class Calculator
    Dim num1 As Double
    Dim num2 As Double
    Dim Operation As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbresult.Text = "0"
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button9.Click, Button7.Click, Button6.Click, Button5.Click, Button18.Click, Button15.Click, Button14.Click, Button13.Click, Button11.Click, Button10.Click
        If tbresult.Text = "0" Then
            tbresult.Text = ""
        End If
        Dim btn = CType(sender, Button)
        If btn.Text = "." Then
            btnDecimal_Click(sender, e)
        Else
            tbresult.Text &= btn.Text
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        tbresult.Text = tbresult.Text.Remove(tbresult.Text.Count - 1)
    End Sub

    Private Sub tbresult_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs)

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        num1 = Double.Parse(tbresult.Text)
        Operation = "+"
        tbresult.Text = ""
    End Sub

    Private Sub btnSubtract_Click(sender As Object, e As EventArgs) Handles btnSubtract.Click
        num1 = Double.Parse(tbresult.Text)
        Operation = "-"
        tbresult.Text = ""
    End Sub

    Private Sub btnMultiply_Click(sender As Object, e As EventArgs) Handles btnMultiply.Click
        num1 = Double.Parse(tbresult.Text)
        Operation = "*"
        tbresult.Text = ""
    End Sub

    Private Sub BtnDivide_Click(sender As Object, e As EventArgs) Handles BtnDivide.Click
        num1 = Double.Parse(tbresult.Text)
        Operation = "/"
        tbresult.Text = ""
    End Sub

    Private Sub btnClearEmpty_Click(sender As Object, e As EventArgs) Handles btnClearEmpty.Click
        tbresult.Text = ""
    End Sub

    Private Sub btnEqual_Click(sender As Object, e As EventArgs) Handles btnEqual.Click
        num2 = Double.Parse(tbresult.Text)
        Dim result As Double
        Select Case Operation
            Case "/"
                result = num1 / num2
            Case "*"
                result = num1 * num2
            Case "-"
                result = num1 - num2
            Case "+"
                result = num1 + num2
        End Select
        tbresult.Text = result.ToString()
    End Sub

    Private Sub btnPower_Click(sender As Object, e As EventArgs) Handles btnPower.Click
        num1 = Double.Parse(tbresult.Text)
        Dim result As Double = num1 * num1
        tbresult.Text = result.ToString()
    End Sub

    Private Sub btnNegative_Click(sender As Object, e As EventArgs) Handles btnNegative.Click
        If tbresult.Text <> "0" Then
            num1 = Double.Parse(tbresult.Text)
            num1 = -num1
            tbresult.Text = num1.ToString()
        End If
    End Sub

    Private Sub btnDecimal_Click(sender As Object, e As EventArgs) Handles btnDecimal.Click
        If Not tbresult.Text.Contains(".") Then
            tbresult.Text &= "."
        End If
    End Sub

    Private Sub tbresult_KeyPress(sender As Object, e As KeyPressEventArgs)
        Dim DS As String = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = 8 Or (e.KeyChar = DS And sender.Text.IndexOf(DS) = -1))
    End Sub

    Private Sub tbresult_TextChanged(sender As Object, e As EventArgs) Handles tbresult.TextChanged

    End Sub
End Class