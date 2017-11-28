Module Module1

    Sub Main()
        Console.WriteLine("Enter number of rows")
        Dim rows = Integer.Parse(Console.ReadLine())
        Console.WriteLine("Enter number of columns")
        Dim cols = Integer.Parse(Console.ReadLine())

        Dim sum As Integer = 0
        Dim avg As Double = 0

        Dim arr(rows - 1, cols - 1) As Integer
        For i = 0 To rows - 1
            For j = 0 To cols - 1
                Console.WriteLine("Enter element ({0},{1})", i, j)
                arr(i, j) = Integer.Parse(Console.ReadLine())
                sum += arr(i, j)
            Next
        Next

        avg = sum / arr.Length
        Console.WriteLine("Average of all elements is : {0} ", avg)

    End Sub

End Module
