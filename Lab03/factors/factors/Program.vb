Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Enter number")
        Dim n As Integer = Integer.Parse(Console.ReadLine())

        Console.WriteLine("The factors of {0} are: ", n)
        For i = 1 To n
            If n Mod i = 0 Then
                Console.WriteLine(i)
            End If
        Next
    End Sub
End Module
