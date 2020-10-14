Public Class Form1
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub RollButton_Click(sender As Object, e As EventArgs) Handles RollButton.Click
        Randomize()
        Dim randomNumber As Integer
        Dim txt1, txt2, dashes As String
        Dim data(10) As Integer


        For i = 1 To 1000
            randomNumber = CInt(GetRandomNumber(1, 6))
            data(randomNumber - 2) += 1
            'has to be randomnumber - 2 or it would be outside the bounds of the array.
        Next

        For i = 2 To 12
            txt1 = txt1 & String.Format("{0, 11}", i) & "|"
        Next

        RTDListBox.Items.Add("Numbers:       " & txt1)
        dashes = (StrDup(177, "-"))
        RTDListBox.Items.Add(dashes)

        For i = 0 To 10
            txt2 = txt2 & String.Format("{0,10}", data(i)) & "|"
        Next

        RTDListBox.Items.Add("Times Rolled:" & txt2)
        RTDListBox.Items.Add(dashes)
        RTDListBox.Items.Add("")
        RTDListBox.Items.Add("")
    End Sub
    Function GetRandomNumber(ByVal minimum As Single,
                             ByVal maximum As Single) As Single

        Dim value1, value2 As Double
        Dim sum As Integer
        'rolls two 'dice'  each gives a number from 0.5 to 6.5 and rounds to the nearest whole number
        'they are then added together like real dice for a number between 2 and 12
        Do
            value1 = (maximum * Rnd()) + 0.5
            value2 = (maximum * Rnd()) + 0.5
        Loop While value1 < minimum - 0.5 Or value1 >= maximum + 0.5 Or
            value2 < minimum - 0.5 Or value2 >= maximum + 0.5

        sum = CInt(value1) + CInt(value2)
        Return sum

    End Function

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        RTDListBox.Items.Clear()
    End Sub
End Class
