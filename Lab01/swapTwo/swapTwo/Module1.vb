Module Module1

    Sub Main()
        Dim a, b, temp As Integer
        Console.WriteLine("Enter the first Number")
        a = Integer.Parse(Console.ReadLine())
        Console.WriteLine("Enter the second Number")
        b = Integer.Parse(Console.ReadLine())

        temp = a
        a = b
        b = temp

        Console.WriteLine("First Number : {0}", a)
        Console.WriteLine("Second Number: {0} ", b)

    End Sub

End Module
