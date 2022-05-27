Module Edad_Mayor
    Sub main()
        Dim nombre As String
        Dim edad As Integer
        Console.WriteLine()
        Console.WriteLine("Ingrese su Nombre por Favor ")
        nombre = Console.ReadLine
        Console.WriteLine("Ingrese su Edad por Favor ")
        edad = Console.ReadLine
        If edad >= 18 Then
            Console.ForegroundColor = ConsoleColor.Yellow
            Console.WriteLine(nombre & " Usted es Mayor de Edad")
        Else
            Console.ForegroundColor = ConsoleColor.Yellow
            Console.WriteLine(nombre & " Usted es Menor de Edad")
        End If
        Console.ReadLine()

    End Sub
End Module
