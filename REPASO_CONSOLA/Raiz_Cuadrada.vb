Module Raiz_Cuadrada
    Sub main()
        Dim num, r As Decimal
        Console.ForegroundColor = ConsoleColor.White
        Console.WriteLine("Ingrese el Numero a Evaluar")
        num = Console.ReadLine
        r = (num) ^ (1 / 2)
        Console.ForegroundColor = ConsoleColor.Yellow
        Console.WriteLine("El resultado de la Evaluacion es : " & r)
        Console.ReadLine()
    End Sub
End Module
