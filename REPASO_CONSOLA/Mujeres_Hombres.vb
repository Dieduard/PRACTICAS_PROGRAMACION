Module Mujeres_Hombres
    Sub main()
        Dim nombre, sexo As String
        Dim edad, canEmple As Integer
        Dim hombre, mujer As Integer
        Console.WriteLine()
        Console.ForegroundColor = ConsoleColor.White
        Console.WriteLine("Ingrese la Cantidad de Empleados a Evaluar")
        canEmple = Console.ReadLine
        For i = 1 To canEmple
            Console.ForegroundColor = ConsoleColor.White
            Console.WriteLine("**********************************************")
            Console.WriteLine("Ingrese su Nombre por Favor ")
            nombre = Console.ReadLine
            Console.WriteLine("Ingrese su Edad ")
            edad = Console.ReadLine
            Console.WriteLine("Ingrese su Genero")
            sexo = Console.ReadLine
            If sexo = "h" Then
                hombre = hombre + 1
            ElseIf sexo = "m" Then
                mujer = mujer + 1
            End If
        Next
        Console.WriteLine("**********************************************")
        Console.ForegroundColor = ConsoleColor.Yellow
        Console.WriteLine("La Cantidad de Hombres es de: " & hombre)
        Console.WriteLine("La Cantidad de Mujeres es de: " & mujer)
        Console.WriteLine("La Cantidad de Perosnas es de: " & hombre + mujer)
        Console.ForegroundColor = ConsoleColor.White
        Console.WriteLine("**********************************************")
        Console.ReadLine()

    End Sub
End Module
