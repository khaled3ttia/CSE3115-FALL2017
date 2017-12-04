Module Module1
    Sub Main()
        Console.WriteLine("Enter number of elements")
        Dim n As Integer = Console.ReadLine()
        Dim arr(n - 1) As Integer
        InputArray(arr)
        SortArray(arr)
        PrintArray(arr)
    End Sub
    Sub InputArray(ByRef arr() As Integer)
        For i = 0 To arr.Length - 1
            Console.WriteLine("Enter element ({0})", i)
            arr(i) = Console.ReadLine()
        Next
    End Sub
    Sub SortArray(ByRef arr() As Integer)
        Dim temp As Integer
        For i = 0 To arr.Length - 1
            For j = i + 1 To arr.Length - 1
                If arr(i) > arr(j) Then
                    temp = arr(i)
                    arr(i) = arr(j)
                    arr(j) = temp
                End If
            Next
        Next
    End Sub
    Sub PrintArray(ByVal arr() As Integer)
        For i = 0 To arr.Length - 1
            Console.WriteLine(arr(i))
        Next
    End Sub
End Module
