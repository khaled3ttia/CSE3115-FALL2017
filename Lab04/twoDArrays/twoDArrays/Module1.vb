Module Module1

    Sub Main()
        Console.WriteLine("Enter number of rows")
        Dim rows = Integer.Parse(Console.ReadLine())
        Console.WriteLine("Enter number of columns")
        Dim cols = Integer.Parse(Console.ReadLine())

        Dim arr(rows - 1, cols - 1) As Integer
        For i = 0 To rows - 1
            For j = 0 To cols - 1
                Console.WriteLine("Enter element ({0},{1})", i, j)
                arr(i, j) = Integer.Parse(Console.ReadLine())
            Next
        Next

        Console.WriteLine("Visual Representation")
        For i = 0 To rows - 1
            For j = 0 To cols - 1
                Console.Write(" {0} ", arr(i, j))
            Next
            Console.WriteLine("")
        Next

        Dim diagonalElements As New ArrayList
        Console.WriteLine("Diagonal Elements")
        For i = 0 To rows - 1
            Console.WriteLine(arr(i, i))
            diagonalElements.Add(arr(i, i))
        Next

        diagonalElements.Sort()
        Console.WriteLine("Minimum diagonal element is : {0}", diagonalElements(0))
        diagonalElements.Reverse()
        Console.WriteLine("Maximum diagonal element is : {0}", diagonalElements(0))



    End Sub

End Module
