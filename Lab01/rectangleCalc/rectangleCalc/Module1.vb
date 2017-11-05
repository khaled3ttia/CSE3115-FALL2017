Module Module1

    Sub Main()
        Console.WriteLine("Enter the height of the rectangle")
        Dim x As Double = Double.Parse(Console.ReadLine())

        Console.WriteLine("Enter the width of the rectangle")
        Dim y As Double = Double.Parse(Console.ReadLine())

        Dim area As Double = x * y
        Dim perimeter As Double = 2 * (x + y)

        Console.WriteLine("Area is: {0} And Perimeter is: {1}", area, perimeter)

    End Sub

End Module
