Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Enter the first number")
        Dim a As Integer = Integer.Parse(Console.ReadLine())
        Console.WriteLine("Enter the second number")
        Dim b As Integer = Integer.Parse(Console.ReadLine())
        Console.WriteLine("Enter the third number")
        Dim c As Integer = Integer.Parse(Console.ReadLine())

        Dim sum = a + b + c
        Dim product = a * b * c

        Console.WriteLine("The sum of the three numbers is : {0}", sum)
        Console.WriteLine("The product of the three numbers is " & product)

    End Sub
End Module
