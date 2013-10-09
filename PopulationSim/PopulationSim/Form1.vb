Option Strict On

Public Class Form1

    Private Sub btnPopulation_Click(sender As System.Object, e As System.EventArgs) Handles btnPopulation.Click

        Dim CurYear As Integer
        Dim CurPop As Double

        CurYear = 2012
        CurPop = 7000000000.0

        Do While (CurPop > 6000000)
            CurPop = CurPop / 2
            CurYear = CurYear - 50


        Loop
        MessageBox.Show("The year is " & CurYear, "Error")

    End Sub
End Class
