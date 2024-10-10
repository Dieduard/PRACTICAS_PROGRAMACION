using System;

namespace CURSO_PROGRAMACION
{
    class Program
    {
        static void Main(string[] args)
        {
            #region USO EN C# DE : TIPOS DE COMENTARIOS
            // PRUEBA # 2 : TIPO DE COMENTARIOS EN C#

            // ESTA ES LA FORMA PARA COMENTAR UNA SOLA LINEA DE CODIGO
            /* ESTA ES LA FORMA DE COMENTAR MAS DE UNA LINEA DE CODIGO */
            #endregion

            #region USO EN C# DE : COMO MOSTRAR UN MENSAJE EN C#
            //Console.WriteLine("Hello World!");
            //Console.ReadLine(); 
            #endregion

            #region USO EN C# DE : TIPOS DE VARIABLES EN C#
            //PRUEBA # 3 : TIPOS DE VARIABLES EN C#
            /*
            --------------------------------------------------------------------------------------
             * TIPO NUMERICO SERIAN:
             
            --> byte = TIPO DE DATO QUE VA DE 0 - 255

            --> int = TIPO DE DATO QUE VA DE 2147,483 ,648 NEGATIVOS a 2147,483 ,648 POSITIVO

            --> double = ESTE ACEPTA NUMEROS CON PUNTO DECIMAL 8.75 ETC 

            --> decimal = ACEPTA NUMEROS DECIMALES

            --> long = ACEPTA NUMEROS ENTEROS BIEN GRANDES

            --> float = ACEPTA NUMEROS DECIMALES

            --------------------------------------------------------------------------------------
            * TIPO TEXTO SERIAN:
            --> String = ACEPTA UNA CADENA DE TEXTO MAS AMPLIO

            --> Char = SOLO ACEPTA UN CARACTER COMO NOMBRE DE VARIABLE 

            --> Bool = ACEPTA SOLO DOS CONDICIONES YA SEA FALSE O TRUE 
             */
            #endregion

            #region USO EN C# DE : OPERADORES DE ASIGNACION 
            //// Operadores de Asignacion

            //int edad = 20; // Forma de Asignarle un valor a una variable tipo variable + nombre variable = Asignamos un valor
            //string nombre = "Josue";
            //int num1 = 10, num2 = 10, num3 = 5, num4 = 100;
            //// Forma de sumar, restar, multiplicar y dividir de forma mas rapida 
            //num1 += 5;
            //num2 -= 5;
            //num3 *= 5;
            //num4 /= 2;
            //// Aqui Edad tiene el valor de 100 y se dividira entre 2
            //edad = edad + 9;
            //Console.WriteLine(nombre + " " + "tu edad es : " + edad);
            //Console.WriteLine();
            //Console.WriteLine("Incremento, decremento, divicion y multiplicacion de Numero :" + num4);
            //Console.ReadLine(); 
            #endregion

            #region USO EN C# DE : OPERADORES ARITMETICOS  
            // OPERADORES ARITMETICOS EN C#
            /* Los operadores aritmeticos son todos aquellos que los permite realizar cualquier operacion Matematica
               Suma - Resta -  Multiplicacion - Divicion */

            //int suma,resta,multiplicacion,divicion;
            //suma = 10 + 15;
            //resta = 100 - 15;
            //multiplicacion = 25 * 2;
            //divicion = 100/2;
            //Console.WriteLine("La Suma de sus Numeros es de :" + suma);
            //Console.WriteLine("La Resta de sus Numeros es de :" + resta);
            //Console.WriteLine("La Multiplicacion de sus Numeros es de :" + multiplicacion);
            //Console.WriteLine("La Division de sus Numeros es de :" + divicion);
            //Console.ReadLine(); 
            #endregion

            #region USO EN C# DE : OPERADORES RELACIONALES = > < !=
            //// Operadores Relacionales 
            ///* Son todos aquellos que los permiten realizar calculos entre los numeros y que los hacen de terminar 
            //   si son mayores o iguales -->( >= ) ó menores o iguales --> ( <= ) ó simplemente iguales ( == ) o diferentes ( != ) */
            //int num1 = 10, num2 = 5;
            //if (num1 == num2)
            //{
            //    Console.WriteLine("Los Numeros son Iguales");
            //}
            //else
            //{
            //    Console.WriteLine("Los Numeros son Diferentes");
            //}
            //Console.ReadLine(); 
            #endregion

            #region USO EN C# DE : LA SENTENCIA IF ELSE 
            //// USO DEL IF SIMPLE + IF ELSE
            //Console.WriteLine("Ingrese su Nombre");
            //string nombre = Console.ReadLine();

            //Console.WriteLine("Ingrese su Edad");
            //int edad = int.Parse(Console.ReadLine());

            //if (edad >= 18)
            //{
            //    Console.WriteLine(nombre + " " + "Usted es mayor de Edad");
            //}
            //else
            //{
            //    Console.WriteLine(nombre + " " + "Usted es menor de Edad");
            //}
            //Console.ReadLine(); 
            #endregion

            #region USO EN C# DE : TRY CATCH
            /* Forma de Usar el Try Catch este los viene a ayudar de tal forma que no permite que el programa explote
                   y los saque del proyecto dejandonos avergonzadosjejejeje  */
            //try
            //{
            //    Console.WriteLine("Ingrese su Nombre");
            //    string nombre = Console.ReadLine();

            //    Console.WriteLine("Ingrese su Edad");
            //    int edad = int.Parse(Console.ReadLine());

            //    if (edad >= 18)
            //    {
            //        Console.WriteLine(nombre + " " + "Usted es mayor de Edad");
            //    }
            //    else
            //    {
            //        Console.WriteLine(nombre + " " + "Usted es menor de Edad");
            //    }
            //}
            //catch (Exception e)
            //{

            //    Console.WriteLine("Error en Ingresar MAL los Datos ");
            //}
            //Console.ReadLine();

            #endregion

            #region USO EN C# DE : SHITCH CASE 
            // USO DEL SHITCH CASE 
            //int num1, num2, Suma, Resta, Multi, Divi;
            //Console.WriteLine("*******************************************");
            //Console.WriteLine("LAS OPCIONES DEL MENÚ SON :");
            //Console.WriteLine("Realizar una Suma   ---->(1)");
            //Console.WriteLine("Realizar una Resta  ---->(2)");
            //Console.WriteLine("Realizar una Multi  ---->(3)");
            //Console.WriteLine("Realizar una Divi   ---->(4)");
            //Console.WriteLine("*******************************************");
            //Console.WriteLine("Ingrese la Opcion que desea Realizar ?");
            //int Opcion = int.Parse(Console.ReadLine());
            //Console.WriteLine("*******************************************");
            //switch (Opcion)
            //{
            //    case 1:
            //        Console.WriteLine("Ingrese el Primer Numero");
            //        num1 = int.Parse(Console.ReadLine());

            //        Console.WriteLine("Ingrese el Segundo Numero");
            //        num2 = int.Parse(Console.ReadLine());
            //        Console.WriteLine("*******************************************");
            //        Suma = num1 + num2;
            //        Console.WriteLine("El Resultado de la Suma es de :" + Suma); break;

            //    case 2:

            //        Console.WriteLine("Ingrese el Primer Numero");
            //        num1 = int.Parse(Console.ReadLine());

            //        Console.WriteLine("Ingrese el Segundo Numero");
            //        num2 = int.Parse(Console.ReadLine());
            //        Console.WriteLine("*******************************************");
            //        Resta = num1 - num2;
            //        Console.WriteLine("El Resultado de la Suma es de :" + Resta); break;

            //    case 3:

            //        Console.WriteLine("Ingrese el Primer Numero");
            //        num1 = int.Parse(Console.ReadLine());

            //        Console.WriteLine("Ingrese el Segundo Numero");
            //        num2 = int.Parse(Console.ReadLine());
            //        Console.WriteLine("*******************************************");
            //        Multi = num1 * num2;
            //        Console.WriteLine("El Resultado de la Suma es de :" + Multi); break;

            //    case 4:

            //        Console.WriteLine("Ingrese el Primer Numero");
            //        num1 = int.Parse(Console.ReadLine());

            //        Console.WriteLine("Ingrese el Segundo Numero");
            //        num2 = int.Parse(Console.ReadLine());
            //        Console.WriteLine("*******************************************");
            //        Divi = num1 / num2;
            //        Console.WriteLine("El Resultado de la Suma es de :" + Divi); break;

            //    default: Console.WriteLine(" El Numero que Ingreso esta Fuera de los Limites "); break;
            //}
            //Console.WriteLine("*******************************************");
            //Console.ReadLine(); 
            #endregion

            #region USO EN C# DE : FOR FOREACH 
            // USO DEL FOR Y FOREACH

            //// USO DEL CICLO FOR 
            //Console.WriteLine("*************************************");
            //Console.Write("Ingrese de la tabla de Multiplicar : ");
            //int num = int.Parse(Console.ReadLine());
            //Console.WriteLine("*************************************");
            //Console.WriteLine("La Tabla de Multiplicar es :");
            //Console.WriteLine("*************************************");
            //for (int i = 1; i < 11; i++)
            //{
            //    Console.WriteLine(num + "X" + i + "=" + i * num);
            //}
            //Console.WriteLine("*************************************");
            //Console.ReadLine(); 

            //// USO DE FOREACH EN C#

            //string nombre = "Diego";

            //foreach (char letra in nombre)
            //{
            //    Console.Write(" " + letra + " ");
            //}
            //Console.ReadLine();
            #endregion

            #region USO EN C# DE : BREAK - CONTINUE - GOTO 
            //    // USO DEL BREAK CONTINUE GOTO

            //    for (int i = 1; i < 11; i++)
            //    {
            //        Thread.Sleep(800);
            //        if (i == 5)
            //        {
            //            //Console.WriteLine("Números ha mostrar serian hasta el : 5");
            //            //break; // --> Con este podemos salir del programa hasta el limite que le pongamos el BREAK detiene el programa 

            //            //Console.WriteLine("El empleado con el Número 5 se ha retirado ");
            //            //continue; // Con este podemos saltar una opcion como si el empleado se dio de baja 

            //            goto Mensaje;
            //        }
            //        Console.WriteLine("->" + i);
            //    }
            //Mensaje: Console.WriteLine("Ese Empleado se mando a casa con GOTO");
            //    Console.ReadLine(); 
            #endregion

            #region USO EN C# DE : WHILE - DO WHILE 
            // USO DE WHILE DO WHILE
            //int i=0;
            //Console.WriteLine("ingrese numero de multiplicar :");
            //int num = int.Parse(Console.ReadLine());
            // Console.WriteLine("La Tabla de Multiplicar es :");
            //while (i <=9)
            //{
            //    i++;
            //    Console.WriteLine(num + "x" + i + "=" + i * num);
            //}
            //Console.ReadLine();

            // USO DE DO WHILE
            //int i = 0;
            //Console.WriteLine("ingrese numero de multiplicar :");
            //int num = int.Parse(Console.ReadLine());
            //Console.WriteLine("La Tabla de Multiplicar es :");
            //do
            //{
            //    i++;
            //    Console.WriteLine(num + "x" + i + "=" + i * num);
            //} while (i <= 9);
            //Console.ReadLine(); 
            #endregion

            #region USO EN C# DE : ARREGLOS UNIDIMENCIONALES Y BIDIMENCIONALES 
            // ARREGLOS UNIDIMENCIONAL - BIDIMENCIONAL

            //// ARREGLO UNIDIMENCIONAL
            //Console.WriteLine("***************************************");
            //Console.WriteLine("Ingrese el tamaño del Arreglo");
            //int tamanio = int.Parse(Console.ReadLine());
            //Console.WriteLine("***************************************");
            //string[] MiArreglo;
            //MiArreglo = new string[tamanio];
            //Console.WriteLine("Ingrese los Datos al Arreglo por Favor :");
            //for (int i = 0; i < tamanio; i++)
            //{
            //    MiArreglo[i] = Console.ReadLine();
            //}
            //Console.Clear();
            //Console.WriteLine("***************************************");
            //Console.WriteLine("Los Datos Ingresados en el Arreglo son :");
            //Console.WriteLine("***************************************");
            //for (int i = 0; i < tamanio; i++)
            //{
            //    Console.WriteLine("->" + MiArreglo[i]);
            //}

            //Console.WriteLine("***************************************");
            //Console.ReadLine();
            ///////////////////////////////////////////////////////////////////////////////////
            //// ARREGLO BIDIMENCIONAL

            //Console.WriteLine("Ingresa el Numero de Filas");
            //int FILAS = int.Parse(Console.ReadLine());

            //Console.WriteLine("Ingresa el Numero de Columnas");
            //int COLUMNAS = int.Parse(Console.ReadLine());

            //int[,] MiArreglo;
            //MiArreglo = new int[FILAS, COLUMNAS];
            //Console.WriteLine("Ingrese los Datos del Arreglo");
            //for (int filas = 0; filas < FILAS; filas++)
            //{
            //    for (int columnas = 0; columnas < COLUMNAS; columnas++)
            //    {
            //        MiArreglo[filas, columnas] = int.Parse(Console.ReadLine());
            //    }
            //}
            //Console.Clear();
            //Console.WriteLine("Los Datos del Arreglo son :");
            //for (int filas = 0; filas < FILAS; filas++)
            //{
            //    for (int columnas = 0; columnas < COLUMNAS; columnas++)
            //    {
            //        Console.Write(MiArreglo[filas, columnas]);
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadLine();
            #endregion

            #region USO EN C# DE : COMO CREAR UN ARCHIVO 
            //// CREACION DE UN ARCHIVO
            //TextWriter archivo;
            //archivo = new StreamWriter("archivo.txt");
            //string mensaje;
            //mensaje = Console.ReadLine();
            //archivo.WriteLine(mensaje);
            //archivo.Close();
            //Console.Clear();
            //Console.WriteLine("Se ha Guardado el Archivo .......");
            //Console.ReadLine(); 
            #endregion

            #region USO EN C# DE : COMO LEER UN ARCHIVO 
            //// COMO LEER UN ARCHIVO 
            //TextReader LeerArchivo;
            //LeerArchivo = new StreamReader("archivo.txt");
            //Console.WriteLine(LeerArchivo.ReadToEnd()); // ReadToLine --> Para que lea solo una linea ** ReadToEnd -> Para que lea todo
            //LeerArchivo.Close();
            //Console.ReadLine(); 
            #endregion

            #region USO EN C# DE : COMO AGREGAR TEXTO A UN ARCHIVO
            ////// COMO AGREGAR TEXTO A UN ARCHIVO 
            //StreamWriter archivo = File.AppendText("archivo.txt");
            //string mensaje;
            //mensaje = Console.ReadLine();
            //archivo.WriteLine(mensaje);
            //archivo.Close();
            //Console.ReadLine();
            #endregion

            #region USO EN C# DE : CREACION DE CLASES CON INSTANCIAS 
            /////// USO DE CLASES Y INSTANCIAS
            //Clase_Instancias MiClase = new Clase_Instancias();
            //MiClase.MiClaseCurso();
            #endregion

            #region USO EN C# DE : METODO CONSTRUCTOR Y DESTRUCTOR
            ////// Forma de hacer Nuestro Método constructor y destructor
            //Clase__Constructor_Destructor Constructor = new Clase__Constructor_Destructor();
            //Constructor.Mostrar_Informacion_Metodo_Constructor(); 
            #endregion

            #region USO EN C# DE : HERENCIAS DE DOS CLASES PADRE HE HIJO 
            //// HERENCIA EN C# 
            //Clase_Hija CorrerOperacion = new Clase_Hija();
            //CorrerOperacion.Operacion(); 
            #endregion

            #region USO EN C#: COMO USAR UNA CONSTANTE
            /// USO DE UNA CONSTANTE 

            //const double PI = 3.1416;
            //double radio = 0, Area = 0;
            //Console.WriteLine("Ingrese el Numero del Radio :");
            //radio = double.Parse(Console.ReadLine());
            //Area = Math.Pow(radio, 2) * PI;
            //Console.WriteLine("El Area de su Radio es " + Area);
            //Console.ReadLine(); 
            #endregion

            #region USO EN C# DE : COMO MOSTRAR LO QUE TIENE UN METODO 
            //int SumaNumeros()
            //{
            //    int num1 = 10;
            //    int num2 = 2;
            //    int resultado;
            //    resultado = num1 + num2;
            //    return resultado;

            //}

            //// FORMA DE MOSTRAR LO QUE TIENE UN METODO CREADO ARRIBA
            //Console.WriteLine(SumaNumeros());
            //Console.ReadLine(); 
            #endregion

            #region COMO GUARDAR UNA FECHA AQUI EN VISUAL
            //DateTime Fecha = DateTime.Today;
            //Console.WriteLine(Fecha.ToString());
            //Console.ReadLine(); 
            #endregion

            #region COMO HACER UN ARREGLO
            //const string Mi_Nombre = "Diego"; // FORMA DE MANTENER UNA VARIABLE CONSTANTE 

            //int[] Numeros = new int[5];
            //Numeros[0] = 111111;
            //Numeros[1] = 222222;
            //Numeros[2] = 333333;
            //Numeros[3] = 444444;
            //Numeros[4] = 555555;

            //for (int i = 0; i < Numeros.Length; i++)
            //{
            //    Console.WriteLine(Numeros[i].ToString());
            //}

            //Console.ReadLine(); 
            #endregion

            Console.WriteLine("Ingrese el primer numero ");
            int NumUno = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero ");
            int NumDos = int.Parse(Console.ReadLine());
            if (NumUno == NumDos & NumDos == NumUno)
            {
                Console.WriteLine("Los Numeros son iguales ");
            }else if(NumUno <= NumDos)
            {
                Console.WriteLine("El Numero Dos es Mayor ");
            }else{
                Console.WriteLine("El Numero Uno es Mayor ");
            }
            Console.ReadLine();

        }
    }
}
