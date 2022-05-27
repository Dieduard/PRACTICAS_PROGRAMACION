Module Empleados
    Sub main()
        Dim numEmple As Integer
        Dim sal, salpro, mayor, menor, suma As Decimal
        Console.WriteLine()
        Console.WriteLine("Ingrese el Numero de Empleados a Evaluar")
        numEmple = Console.ReadLine
        For i = 1 To numEmple
            Console.WriteLine("Salario de Empleado # :" & i)
            sal = Console.ReadLine
            suma = suma + sal
        Next
        Console.WriteLine("Suma de los salarios de los Empleados es de :" & suma)
        Console.WriteLine("Promedio de los salarios de los Empleados es de :" & suma / numEmple)
        Console.WriteLine()
        Console.ReadLine()

    End Sub
End Module
