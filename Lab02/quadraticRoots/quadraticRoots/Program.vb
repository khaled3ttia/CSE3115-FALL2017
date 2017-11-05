Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Enter cooefficient of x^2")
        Dim a As Double = Double.Parse(Console.ReadLine())

        Console.WriteLine("Enter the cofficient of x")
        Dim b As Double = Double.Parse(Console.ReadLine())

        Console.WriteLine("Enter the absolute term")
        Dim c As Double = Double.Parse(Console.ReadLine())

        Dim disc = (b ^ 2) - (4 * a * c)

        If disc < 0 Then
            Console.WriteLine("No real roots")
        ElseIf disc = 0 Then
            Dim sol = (-b + Math.Sqrt(disc)) / (2 * a)
            Console.WriteLine("The solution is : {0}", sol)
        Else
            Dim sol1 = (-b + Math.Sqrt(disc)) / (2 * a)
            Dim sol2 = (-b - Math.Sqrt(disc)) / (2 * a)
            Console.WriteLine("The first root is {0} and the second root is {1} ", sol1, sol2)
        End If

    End Sub
End Module
