Public Class Form1

    Private Sub btnDisplay_Click(sender As System.Object, e As System.EventArgs) Handles btnDisplay.Click
        Dim num As Integer = 1
        Dim square As Double
        Do While num <= 10
            square = num * num
            num += 1
            lstResult.Items.Add(square)
        Loop



    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
