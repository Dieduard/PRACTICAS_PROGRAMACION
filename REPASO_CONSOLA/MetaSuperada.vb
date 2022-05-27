Module MetaSuperada
    Sub main()
        Dim nombre As String
        Dim sueldo As Decimal
        Console.WriteLine()
        Console.WriteLine("Ingrese el Nombre del Empleado por Favor ")
        nombre = Console.ReadLine
        Console.WriteLine("Ingrese su Sueldo por Favor ")
        sueldo = Console.ReadLine
        If sueldo >= 25000 Then
            Console.ForegroundColor = ConsoleColor.Yellow
            Console.WriteLine("Felicidades " & nombre & " Meta Superada")
        Else
            Console.ForegroundColor = ConsoleColor.Yellow
            Console.WriteLine("Lo Sentimos " & nombre & " Meta NO Superada")
        End If
        Console.ReadLine()

    End Sub
End Module
