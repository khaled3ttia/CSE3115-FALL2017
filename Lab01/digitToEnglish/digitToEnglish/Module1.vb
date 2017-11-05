Module Module1

    Sub Main()
        Console.WriteLine("Enter a digit from 0-9")
        Dim number As Integer = Integer.Parse(Console.ReadLine())
        Select Case number
            Case 0
                Console.WriteLine("Zero")
            Case 1
                Console.WriteLine("One")
            Case 2
                Console.WriteLine("Two")
            Case 3
                Console.WriteLine("Three")
            Case 4
                Console.WriteLine("Four")
            Case 5
                Console.WriteLine("Five")
            Case 6
                Console.WriteLine("Six")
            Case 7
                Console.WriteLine("Seven")
            Case 8
                Console.WriteLine("Eight")
            Case 9
                Console.WriteLine("Nine")
            Case Else
                Console.WriteLine("You didn't enter a valid number")
        End Select



    End Sub

End Module
