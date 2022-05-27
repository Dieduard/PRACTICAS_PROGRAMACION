Module CambiarLetraNombre
    Sub main()
        Dim nombre As String
        Dim a, e, i, o, u As String
        Console.WriteLine("Bienvenido")
        Console.WriteLine("Escriba su nombre: ")
        nombre = Console.ReadLine()
        Console.ForegroundColor = ConsoleColor.White
        nombre = Replace(nombre, "a", "*")
        nombre = Replace(nombre, "e", "%")
        nombre = Replace(nombre, "i", "$")
        nombre = Replace(nombre, "o", "#")
        nombre = Replace(nombre, "u", "/")
        Console.WriteLine("Nuevo nombre: " & nombre)
        Console.ReadLine()
    End Sub
End Module
