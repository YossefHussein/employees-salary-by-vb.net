Public Class Form1
    Dim mainSalary, sum, additionalSalary, c As Double

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        mainSalary = Val(TextBox1.Text)
        additionalSalary = Val(TextBox2.Text)
        c = sadditionalSalary + mainSalary
        If c <= 1500 Then
            sum = (mainSalary + additionalSalary) - (0.1 * (mainSalary + additionalSalary))
            MessageBox.Show(sum)
        Else
            sum = (mainSalary + additionalSalary) - (0.15 * (mainSalary + additionalSalary))
            MessageBox.Show(sum)
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class
