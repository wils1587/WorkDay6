Option Strict On

Public Class Form1

    Private Sub btnPopulation_Click(sender As System.Object, e As System.EventArgs) Handles btnPopulation.Click
        Dim population As Double = 6700000000
        Dim years As Integer = 2013
        Do While population >= 6000000
            population = population / 2
            years -= 50

        Loop
        MessageBox.Show("The world population was less than 6 million in year " & years & ".", "Population")

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
