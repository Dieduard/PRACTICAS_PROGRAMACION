Module Aumento_Emple
    Sub main()
        Dim nombre As String
        Dim sueldo, aum As Double
        Console.WriteLine()
        Console.WriteLine("Ingrese el Nombre del Empleado por Favor ")
        nombre = Console.ReadLine
        Console.WriteLine("Ingrese su Sueldo por Favor ")
        sueldo = Console.ReadLine
        If sueldo >= 400 Then
            aum = sueldo + sueldo * 0.1
        Else
            aum = sueldo + sueldo * 0.05
        End If

        Console.ForegroundColor = ConsoleColor.Yellow
        Console.WriteLine("El Aumento de su Sueldo es de :" & aum)
        Console.ReadLine()
    End Sub
End Module
