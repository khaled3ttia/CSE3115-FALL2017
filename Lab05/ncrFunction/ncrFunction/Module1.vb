Module Module1
    Sub Main()
        Console.WriteLine("Enter n")
        Dim n As Integer = Console.ReadLine()
        Console.WriteLine("Enter r")
        Dim r As Integer = Console.ReadLine()
        Dim result As Double = factorial(n) / (factorial(n - r) * factorial(r))
        Console.WriteLine("Result is: {0} ", result)
    End Sub
    Function factorial(ByVal num) As Integer
        If num = 1 Then
            Return 1
        Else
            Return factorial(num - 1) * num
        End If
    End Function
End Module
