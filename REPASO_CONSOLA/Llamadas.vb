Module Llamadas
    Sub main()
        Dim zona As Integer
        Dim pago, duracion As Decimal
        Console.WriteLine()
        Console.ForegroundColor = ConsoleColor.White
        Console.WriteLine("************************************")
        Console.WriteLine(" Zona Oriental -------------->> (1)")
        Console.WriteLine(" Zona Central  -------------->> (2)")
        Console.WriteLine(" Zona Occidental ------------>> (3)")
        Console.WriteLine("************************************")
        Console.WriteLine("Ingrese la Zona a LLamar por Favor ")
        zona = Console.ReadLine
        Select Case zona
            Case Is = 1
                Console.WriteLine("Ingrese la duracion de la llamada ")
                duracion = Console.ReadLine
                pago = duracion * 0.3
            Case Is = 2
                Console.WriteLine("Ingrese la duracion de la llamada ")
                duracion = Console.ReadLine
                pago = duracion * 0.27
            Case Is = 3
                Console.WriteLine("Ingrese la duracion de la llamada ")
                duracion = Console.ReadLine
                pago = duracion * 0.36

        End Select
        Console.WriteLine("************************************")
        Console.WriteLine(" El costo por la llamada es de :" & pago)
        Console.WriteLine("************************************")
        Console.ReadLine()

    End Sub
End Module
