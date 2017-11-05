Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Enter number of elements")
        Dim n As Integer = Integer.Parse(Console.ReadLine())

        Dim numbers(n - 1) As Integer

        For i = 0 To n - 1
            Console.WriteLine("Enter element {0}", i + 1)
            numbers(i) = Integer.Parse(Console.ReadLine())
        Next

        Dim max = numbers(0)
        For i = 1 To n - 1
            If numbers(i) > max Then
                max = numbers(i)
            End If
        Next

        Console.WriteLine("The maximum number is : {0}", max)
    End Sub
End Module
