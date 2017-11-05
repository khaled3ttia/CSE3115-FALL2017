Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Enter number")
        Dim n As Integer = Integer.Parse(Console.ReadLine())
        Dim factorial = 1
        For i = 2 To n
            factorial *= i
        Next

        Console.WriteLine("The factorial of {0} is {1}", n, factorial)

    End Sub
End Module
