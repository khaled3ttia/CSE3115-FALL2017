Module Module1

    Sub Main()
        Dim x As Integer
        Console.WriteLine("Enter the number:")
        x = Integer.Parse(Console.ReadLine())

        If (x Mod 2) = 0 Then
            Console.WriteLine("Even Number")
        Else
            Console.WriteLine("Odd Number")
        End If
    End Sub

End Module
