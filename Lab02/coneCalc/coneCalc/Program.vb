Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Enter radius")
        Dim r As Double = Double.Parse(Console.ReadLine())
        Console.WriteLine("Enter height")
        Dim h As Double = Double.Parse(Console.ReadLine())

        Dim volume As Double = Math.PI * (r ^ 2) * (h / 3)
        Dim area As Double = Math.PI * r * (r + Math.Sqrt(h ^ 2 + r ^ 2))

        Console.WriteLine("Volume of cone is {0} and area is {1}", volume, area)

    End Sub
End Module
