Module Module1

    Sub Main()
        Console.WriteLine("Enter date in the format dd/mm/yyyy")
        Dim string_d = Console.ReadLine()
        Dim split_date() = string_d.Split("/")
        Dim d = New DateTime(split_date(2), split_date(1), split_date(0))
        Console.WriteLine(d.DayOfWeek.ToString())
    End Sub

End Module
