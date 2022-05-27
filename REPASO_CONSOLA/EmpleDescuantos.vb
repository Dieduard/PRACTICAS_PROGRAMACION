Module EmpleDescuantos
    Sub main()
        Dim nombre As String
        Dim sueldo, ISS, AFP, RENTA, total As Decimal
        Console.WriteLine()
        Console.WriteLine("Ingrese su nombre por favor ")
        nombre = Console.ReadLine
        Console.WriteLine("Ingrese su sueldo por favor")
        sueldo = Console.ReadLine
        Console.Clear()
        Console.WriteLine("DATOS CLIENTE")
        Console.ForegroundColor = ConsoleColor.Blue
        Console.WriteLine("Nombre Emple:" & nombre + " Sueldo :" & sueldo)
        Console.ForegroundColor = ConsoleColor.Yellow
        ISS = ISS + sueldo * 0.1
        Console.WriteLine("El Descuento del Seguro es de " & ISS)
        AFP = AFP + sueldo * 0.15
        Console.WriteLine("El Descuento del AFP es de " & AFP)
        RENTA = RENTA + sueldo * 0.05
        Console.WriteLine("El Descuento del seguro es de " & RENTA)
        total = total + sueldo - ISS - RENTA - AFP
        Console.ForegroundColor = ConsoleColor.Red
        Console.WriteLine("El sueldo a Recibir es de : " & total)
        Console.ReadLine()


    End Sub
End Module
