Public Class Form1

    Private Sub btnDisplay_Click(sender As System.Object, e As System.EventArgs) Handles btnDisplay.Click

        lstResult.Items.Clear()


        Dim number As Integer
        Dim squarednumber As Integer

        Do While number <= 10
            lstResult.Items.Add("Number is " & number ^ 2)
            number = number + 1
        Loop


    End Sub
End Class
