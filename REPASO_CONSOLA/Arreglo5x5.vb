Module Arreglo5x5
    Sub main()
        Console.WriteLine("Arreglo 1:")
        Dim n(4, 4) As Integer
        Dim sum1, sum2, total As Integer
        For f = 0 To 4
            For c = 0 To 4
                Console.WriteLine("Valor para: (" & f & ", " & c & ")")
                n(f, c) = Console.ReadLine()
            Next
        Next
        For f = 0 To 4
            For c = 0 To 4
                sum1 = sum1 + n(f, c)
            Next
        Next
        Console.WriteLine()
        Console.WriteLine("La suma del primer arreglo es: " & sum1)
        Console.ReadLine()
        Console.Clear()
        Console.WriteLine("Arreglo 2: ")
        Dim d(3, 3) As Integer
        For s = 0 To 4
            For p = 0 To 4
                Console.WriteLine("Valor para: (" & s & ", " & p & ")")
                d(s, p) = Console.ReadLine()
            Next
        Next
        For s = 0 To 4
            For p = 0 To 4
                sum2 = sum2 + n(s, p)
            Next
        Next
        Console.WriteLine()
        Console.WriteLine("La suma del segundo arreglo es: " & sum2)
        Console.ReadLine()
        Console.Clear()
        total = sum1 + sum2
        Console.WriteLine("La suma de los arreglos es: " & sum1 & " + " & sum2 & " = " & total)
        Console.ReadLine()
    End Sub
End Module
