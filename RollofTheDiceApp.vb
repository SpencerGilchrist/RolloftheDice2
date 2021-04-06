Option Explicit On
Option Strict On
'Spencer Gilchrist
'RCET 0265
'3-11-21
'RollofTheDiceForm

Public Class RollofTheDiceForm

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click, ExitToolStripMenuItem.Click
        Me.Close()
        'This closes the program when exit, or escape is pressed
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click, ClearToolStripMenuItem.Click
        DisplayListBox.Items.Clear()
        'This clears the program when the clear button is pressed
    End Sub

    Private Sub RollButton_Click(sender As Object, e As EventArgs) Handles RollButton.Click, RollToolStripMenuItem.Click
        DisplayListBox.Items.Clear()
        Dim RandomNumbers(10) As Integer
        'This makes a RandomNumbers array ^^^^
        DisplayListBox.Items.Add("                                Random Numbers!")
        'This statement above is centerd using space which can look a little tacky but it works so im going with it
        For i = 1 To 1000
            RandomNumbers(GetRandomNumber(11)) += 1
            'This for loop rolls 2 dice 1000 times
        Next

        DisplayListBox.Items.Add(StrDup(77, "-")) 'These duplicate the dash 77 times

        Dim TopRow As String

        For i = 1 To 11
            TopRow &= CStr((i) + 1).PadLeft(6) & "|"
            'This For loop sets up the top row from 2 to 12
            'It is important to put CStr in or padLeft wont be declared and everything will look bad
        Next
        DisplayListBox.Items.Add(TopRow)
        'DisplayListBox.Items.Add(Numbers)
        DisplayListBox.Items.Add(StrDup(77, "-")) 'Look at line 20 for info

        Dim BottomRow As String

        For i = 0 To UBound(RandomNumbers)
            BottomRow &= CStr(RandomNumbers(i)).PadLeft(6) & "|"
            'This forloop is our bottom numbers that are "random"
        Next
        DisplayListBox.Items.Add(BottomRow)
        'This Puts the random numbers in the bottom row^^^^
        DisplayListBox.Items.Add(StrDup(77, "-"))
    End Sub
    Function GetRandomNumber(MaxNumber As Integer) As Integer
        Randomize()
        Dim FirstNumber As Integer
        Dim SecondNumber As Integer
        FirstNumber = CInt(Int((6 * Rnd() * +1)))
        SecondNumber = CInt(Int((6 * Rnd() * +1)))
        Return (FirstNumber + SecondNumber)
        'This Function Simply rolls 2 dice and adds them together
        'Then when i call to it i can roll both dice 1000 times and add them up
    End Function

    Private Sub AboutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem1.Click
        MsgBox("This program was created on 3/11/21 for my Visual Basic Class." & vbNewLine &
            "Press Roll to display dice rolls, Press Clear to clear the menu,and Press Exit to leave program.")

    End Sub
End Class
