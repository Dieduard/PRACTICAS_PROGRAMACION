Module Cant_Empleados
    Sub main()
        Dim emple As Integer
        Dim nombre As String
        Dim cantidad As Decimal
        Dim inver As Decimal
        Console.ForegroundColor = ConsoleColor.White
        Console.WriteLine("Ingrese la Cantidad de Empleados a Evaluar")
        emple = Console.ReadLine
        For i = 1 To emple
            Console.WriteLine("-------------------------------------------")
            Console.WriteLine("Ingrese el Nombre del Empleado # :" & i)
            nombre = Console.ReadLine
            Console.WriteLine("Ingrese el Cantidad del Empleado # :" & i)
            cantidad = Console.ReadLine
            inver = inver + cantidad

        Next
        Console.WriteLine("-------------------------------------------")
        Console.ForegroundColor = ConsoleColor.Yellow
        Console.WriteLine("La cantidad invertida por Empleados es de :" & inver)
        Console.WriteLine("El Sueldo Promedio de los Empleados es de :" & inver / emple)
        Console.ReadLine()


    End Sub
End Module
