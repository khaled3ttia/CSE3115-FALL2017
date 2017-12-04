Module Module1

    Sub Main()
        Console.WriteLine("Enter A string")
        Dim word = Console.ReadLine()
        Console.WriteLine("Enter a character")
        Dim ch As Char = Char.Parse(Console.ReadLine())
        Dim count = countOccurances(word, ch)
        Console.WriteLine("Character {0} appears in {1} : {2} times", ch, word, count)
    End Sub

    Function countOccurances(ByVal word As String, ByVal ch As Char)
        Dim count = 0
        For Each x In word
            If x = ch Then
                count += 1
            End If
        Next
        countOccurances = count
    End Function


End Module
