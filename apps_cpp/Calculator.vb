Public Class Calculator

    Dim firstvalue, secondvalue, result As Double
    Dim op As String

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        Me.Hide()
        menu.Show()
    End Sub

    Private Sub Number_Click(sender As Object, e As EventArgs) Handles Button6.Click, Button7.Click, Button8.Click, Button10.Click, Button11.Click, Button12.Click, Button14.Click, Button15.Click, Button16.Click, Button19.Click, Button20.Click
        Dim b As Button = sender

        If (TextBox1.Text = "0") Then
            TextBox1.Text = ""
            TextBox1.Text = b.Text

        ElseIf (b.Text = ".") Then
            If (Not TextBox1.Text.Contains(".")) Then
                TextBox1.Text = TextBox1.Text + b.Text
            End If
        Else
            TextBox1.Text = TextBox1.Text + b.Text
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (TextBox1.Text.Length > 0) Then
            TextBox1.Text = TextBox1.Text.Remove(TextBox1.Text.Length - 1, 1)
        End If
        If (TextBox1.Text = "") Then
            TextBox1.Text = "0"
        End If
    End Sub

    Private Sub Operator_Click(sender As Object, e As EventArgs) Handles Button5.Click, Button9.Click, Button13.Click, Button17.Click

        Dim b As Button = sender
        firstvalue = TextBox1.Text
        op = b.Text
        TextBox1.Text = ""

    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        secondvalue = TextBox1.Text

        If op = "+" Then
            result = firstvalue + secondvalue
            TextBox1.Text = result

        ElseIf op = "-" Then
            result = firstvalue - secondvalue
            TextBox1.Text = result

        ElseIf op = "*" Then
            result = firstvalue * secondvalue
            TextBox1.Text = result

        ElseIf op = "/" Then
            result = firstvalue / secondvalue
            TextBox1.Text = result
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If (TextBox1.Text.Contains("-")) Then
            TextBox1.Text = TextBox1.Text.Remove(0, 1)
        Else
            TextBox1.Text = "-" + TextBox1.Text
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.Text = "0"
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = "0"
    End Sub
End Class