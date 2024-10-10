using System;

namespace _2.EJERCICIOS_PDF
{
    class Program
    {
        static void Main(string[] args)
        {
            /// EJERCICIOS PLANTEADOS EN EL PDF DESCARGADOS DE https://es.slideshare.net/marthaleo36/ejercicios-c-42375507

            #region EJERCICIO # 1 PDF EN C# : SALUDO NORMAL EN C#
            ////Bienvenido Nº1
            //Console.WriteLine("Bienvenido a C#");
            //Console.ReadLine(); 
            #endregion

            #region EJERCICIO # 2 PDF EN C# : 2 MENSAJES EN UNO SOLO SALUDO
            ///// DOBLE MENSAJE ASIENDO UNO SOLO
            //Console.Write("Bienvenido");
            //Console.WriteLine(" este es mi primer Programa en C#");
            //Console.ReadLine(); 
            #endregion

            #region EJERCICIO # 3 PDF EN C# : MENSAJE EN C# USANDO SALTO DE LINEA 
            //// MENSAJE EN C# USANDO SALTO DE LINEA 
            //Console.WriteLine("Hola \nEste es un Mensaje\nUsando salto de Linea en C#");
            //Console.ReadLine(); 
            #endregion

            #region EJERCICIO # 4 EN C# : TEXTO DE 5 LETRAS MOSTRANDOLAS LETRA POR LETRA HACIA ABAJO
            //// Digitar un texto de 4 cifras y que luego te muestre de forma horizontal la frase.
            //string cadena;
            //Console.Write("Ingrese el Texto de 5 Cifras :");
            //cadena = Console.ReadLine();
            //Console.WriteLine(cadena[0]);
            //Console.WriteLine(cadena[1]);
            //Console.WriteLine(cadena[2]);
            //Console.WriteLine(cadena[3]);
            //Console.WriteLine(cadena[4]);
            //Console.ReadLine();
            #endregion

            #region EJERCICIO # 5 EN C# : ADIVINA LA PALABRA SIN INTENTOS 
            ///// ADIVINANDO LA PALABRA USANDO WHILE 
            //string palabra = "hola";
            //string adivina = "";
            //Console.ForegroundColor = ConsoleColor.White;
            //while (adivina != palabra)
            //{
            //    Console.WriteLine("************************************");
            //        Console.WriteLine("Ingrese la Palabra Correcta");
            //        adivina = Console.ReadLine();
            //}
            //Console.WriteLine("************************************");
            //Console.ForegroundColor = ConsoleColor.Yellow;
            //Console.WriteLine("Correcto la palabra es :" + palabra);
            //Console.ForegroundColor = ConsoleColor.White;
            //Console.WriteLine("************************************");
            //Console.ReadLine(); 
            #endregion

            #region EJERCICIO # 6 EN C# : ADIVINA LA PALABRA CON INTENTOS 
            //string palabra = "hola";
            //string adivina = "";
            //int contador = 0;
            //Console.ForegroundColor = ConsoleColor.White;
            //while (contador < 3)
            //{
            //    Console.WriteLine("************************************");
            //    Console.WriteLine("Ingrese la Palabra Correcta");
            //    adivina = Console.ReadLine();
            //    if (adivina != palabra)
            //    {
            //        Console.WriteLine("************************************");
            //        Console.ForegroundColor = ConsoleColor.Yellow;
            //        Console.WriteLine("La palabra es Incorrecta");
            //        Console.ForegroundColor = ConsoleColor.White;
            //        contador++;
            //    }
            //    else
            //    {
            //        Console.WriteLine("************************************");
            //        Console.ForegroundColor = ConsoleColor.Yellow;
            //        Console.WriteLine("Correcto la palabra es :" + palabra);
            //        Console.ForegroundColor = ConsoleColor.White;
            //        Console.WriteLine("************************************");
            //        break;
            //    }

            //}
            //Console.WriteLine("Has Superado los Intentos");
            //Console.ReadLine();
            #endregion

            #region EJERCICIO # 7 EN C# : SACAR EL PROMEDIO DE NOTAS DE UN ALUMNO DE DICHA MATERIA 
            //// SACAR EL PROMEDIO DE NOTAS DE UN ALUMNO DE DICHA MATERIA 
            //Console.WriteLine("Ingrese el Nombre del Alumno");
            //string Nombre = Console.ReadLine();
            //Console.WriteLine("Ingrese el Nombre de la Materia a Evaluar");
            //string NomMateria = Console.ReadLine();
            //Console.WriteLine("Ingrese el Numero de las Notas que Evaluara ?");
            //int NumNotasEvaluar = int.Parse(Console.ReadLine());
            //double promedio = 0;
            //for (int i = 0; i < NumNotasEvaluar; i++)
            //{
            //    Console.WriteLine("Ingrese la Nota # " + i);
            //    double Nota = double.Parse(Console.ReadLine());
            //    promedio = promedio + Nota;
            //}
            //Console.WriteLine("El promedio de el Alumno es:" + promedio / NumNotasEvaluar);
            //Console.ReadLine(); 
            #endregion

            #region EJERCICIO # 8 EN C# : CREACION DE ARREGLO BIDIMENCIONAL
            ////Console.WriteLine("Ingrese las Filas del Arreglo");
            ////int FILA = int.Parse(Console.ReadLine());
            ////Console.WriteLine("Ingrese las Columnas del Arreglo");
            ////int COLUMNA = int.Parse(Console.ReadLine());
            ////int[,] arreglo;
            ////arreglo = new int[FILA, COLUMNA];

            ////for (int fila = 0; fila < FILA; fila++)
            ////{
            ////    for (int columna = 0; columna < COLUMNA; columna++)
            ////    {
            ////        Console.WriteLine("Ingresar los Datos");
            ////        arreglo[fila, columna] = int.Parse(Console.ReadLine());
            ////    }
            ////}
            ////Console.Clear();
            ////Console.WriteLine("Los Datos ingresados son :");
            ////for (int fila = 0; fila < FILA; fila++)
            ////{
            ////    for (int columna = 0; columna < COLUMNA; columna++)
            ////    {
            ////        Console.Write(arreglo[fila, columna]);
            ////    }
            ////    Console.WriteLine();
            ////}
            ////Console.ReadLine(); 
            #endregion

            #region EJERCICIO # 9 EN C# : COMPRA DE PRODCUTO + IVA Y CUOTA MENSUAL A PAGAR
            //Console.ForegroundColor = ConsoleColor.White;
            //Console.WriteLine("******************************************");
            //Console.WriteLine("Ingrese el Nombre del Cliente");
            //string Nombre = Console.ReadLine();
            //Console.WriteLine("******************************************");
            //Console.WriteLine("Ingrese la Fecha de Cancelación");
            //string Fecha = Console.ReadLine();
            //Console.WriteLine("******************************************");
            //Console.WriteLine("Ingrese el Precio del Producto a Cancelar");
            //double PrecioP = double.Parse(Console.ReadLine());
            //Console.WriteLine("******************************************");
            //Console.WriteLine("Ingrese la Prima de Cancelación");
            //double Prima = double.Parse(Console.ReadLine());
            //Console.WriteLine("******************************************");
            //Console.WriteLine("Ingrese Cantidad de Plan de Cuotas a Pagar");
            //double cuota = double.Parse(Console.ReadLine());
            //Console.WriteLine("******************************************");
            //double Monto_Iva = (PrecioP + 0.15);
            //Console.Clear();
            //Console.ForegroundColor = ConsoleColor.White;
            //Console.WriteLine("*******************************************************************");
            //Console.WriteLine("DATOS A CANCELAR POR EL PLAN OPCIONAL POR CLIENTE");
            //Console.WriteLine("*************************************************************************");
            //Console.WriteLine("Precio del Producto sin Iva es de :" + PrecioP);
            //Console.WriteLine("Precio del Producto con Iva es de :" + Monto_Iva);
            //Console.WriteLine("Cantidad de Cuotas :" + cuota);
            //Console.WriteLine("Cantidad Mensual a Pagar por el Producto con Prima es de :" + ((Monto_Iva - Prima) / cuota));
            //Console.WriteLine("Cantidad Mensual a Pagar por el Producto sin Prima es de :" + ((Monto_Iva / cuota)));
            //Console.WriteLine("*************************************************************************");
            //Console.ReadLine();
            #endregion

            #region EJERCICIO # 10 EN C# : INVERTIR DOS NUMEROS INGRESADOS POR UNA PERSONA EN C#
            //int NumIzquierda,NumDerecha, Numero;
            //string Mensaje;
            //Console.WriteLine("Ingrese el Numero a Invertir");
            //Numero = int.Parse(Console.ReadLine());

            //NumIzquierda = Numero / 10; // Aqui lo dividimos y obtenemos el Numero de la Izquierda elimina el residuo
            //NumDerecha = Numero % 10; // Aqui lo dividimos y obtenemos el Numero de la Derecha toma el residuo


            //Mensaje = NumDerecha + "" + NumIzquierda;
            //Console.WriteLine("El Numero Invertido es :" + Mensaje);
            //Console.ReadLine(); 
            #endregion

            #region EJERCICIO # 11 EN C# : CALCULANDO LONGITUD DE CIRCUFERENCIA Y AREA TRIANGULO
            //double r, diam, lc, area;
            //Console.Write("ingrese el valor de la radio :");
            //r = double.Parse(Console.ReadLine());
            //diam = 2 * r;
            //lc = 2 * Math.PI * r;
            //area = Math.PI * r * r;
            //Console.WriteLine("diametro : {0}", diam);
            //Console.WriteLine("longitud de la circunferencia :{0}", lc);
            //Console.WriteLine("area : {0}", area);
            //Console.ReadLine(); 
            #endregion

            #region EJERCICIO # 12 EN C# : ENCONTRANDO HIPOTENUSA DE UN TRIANGULO 
            //double Base, Altura, h;
            //Console.WriteLine("*********************************");
            //Console.WriteLine("INGRESE LOS DATOS DEL TRIANGULO");
            //Console.WriteLine("*********************************");
            //Console.WriteLine("Ingrese la Base del Triangulo:");
            //Base = double.Parse(Console.ReadLine());
            //Console.WriteLine("Ingrese la Altura del Triangulo:");
            //Altura = double.Parse(Console.ReadLine());
            //Console.WriteLine("*********************************");
            //h = Math.Sqrt(Base * Altura);
            //Console.WriteLine("Hipotenusa : {0}", h);
            //Console.WriteLine("*********************************");
            //Console.ReadLine(); 
            #endregion

            #region EJERCICIO # 13 EN C# : SACAR PROMEDIO DE NOTAS DE UN ALUMNO
            //Console.WriteLine("*********************************************************");
            //Console.WriteLine("INGRESE LAS NOTAS DEL ALUMNO Y VERIFICAREMOS SU PROMEDIO");
            //Console.WriteLine("*********************************************************");
            //double promedio = 0, SumaNotas = 0;
            //for (int i = 1; i < 3 + 1; i++)
            //{
            //    Console.WriteLine("Ingrese la Nota # :" + i);
            //    double nota = double.Parse(Console.ReadLine());
            //    SumaNotas = SumaNotas + nota;
            //    promedio = SumaNotas / 3;

            //}
            //if (promedio >= 6)
            //{
            //    Console.WriteLine("Su promedio es de :" + promedio + " " + "Felicidades usted Aprobo");
            //}
            //else
            //{
            //    Console.WriteLine("Su promedio es de:" + promedio + " " + "Lo Sentimos usted Reprobo");
            //}
            //Console.WriteLine("*********************************************************");
            //Console.ReadKey(); 
            #endregion

            #region EJERCICIO # 14 EN C# : DETERMINAR NUMERO NEGATIVO - NEUTRO - POSITIVO
            //Console.WriteLine("Ingrese el Numero");
            //int num = int.Parse(Console.ReadLine());
            //if (num == 0)
            //{
            //    Console.WriteLine("Este Numero es Neutro");
            //}
            //else if (num < 0)
            //{
            //    Console.WriteLine("Este Numero es Negativo");
            //}
            //else
            //{
            //    Console.WriteLine("Este Numero es Positivo");
            //}
            //Console.ReadLine(); 
            #endregion

            #region EJERCICIO # 15 EN C# : DETERMINAR SI UN NUMERO ES PAR O IMPAR
            //Console.WriteLine("Ingrese el Numero a evaluar");
            //int num = int.Parse(Console.ReadLine());
            //if (num % 2 == 0)
            //{
            //    Console.WriteLine("El Numero es Par");
            //}
            //else
            //{
            //    Console.WriteLine("El Numero es Impar");
            //}
            //Console.ReadLine(); 
            #endregion

            /// NUEVOS EJERCICIOS PARA PRACTICAR 

            #region EJERCICIO # 16 EN C# : SALUDO A PERSONA QUE INGRESA DATOS 
            ///* Pedir por consola un nombre de persona y el nombre de una ciudad(no hace falta que sean reales o comprobarlos) 
            //y mostrar por pantalla, el siguiente mensaje “Hola ” < nombre > ” bienvenido a ” < ciudad >*/

            //Console.WriteLine("Ingrese su Nombre por favor");
            //string Nombre = Console.ReadLine();
            //Console.WriteLine("Ingrese el Nombre de la Ciudad donde vive");
            //string Ciudad = Console.ReadLine();

            //Console.WriteLine("Hola " + " " + Nombre + " " + "Bienvenido a " + " " + Ciudad);
            //Console.ReadLine(); 
            #endregion

            #region EJERCICIO # 17 EN C# : DIAS DE LA SEMANA NOMAS INGRESAS 
            //Console.WriteLine("Ingrese un Numero del 1 - 7 y se dira que dia es de la semana");
            //int NumDia = int.Parse(Console.ReadLine());
            //switch (NumDia)
            //{
            //    case 1:
            //        Console.WriteLine("El Numero Representa el dia >> LUNES << "); break;
            //    case 2:
            //        Console.WriteLine("El Numero Representa el dia >> MARTES << "); break;
            //    case 3:
            //        Console.WriteLine("El Numero Representa el dia >> MIERCOLES << "); break;
            //    case 4:
            //        Console.WriteLine("El Numero Representa el dia >> JUEVES << "); break;
            //    case 5:
            //        Console.WriteLine("El Numero Representa el dia >> VIERNES << "); break;
            //    case 6:
            //        Console.WriteLine("El Numero Representa el dia >> SABADO << "); break;
            //    case 7:
            //        Console.WriteLine("El Numero Representa el dia >> DOMINGO << "); break;
            //    default:
            //        Console.WriteLine("Número Fuera del RANGO ESTIPULADO");
            //        break;

            //}
            //Console.ReadLine(); 
            #endregion

            #region EJERCICIO # 18 EN C# : TABLAS DE MULTIPLICAR USANDO WHILE 
            //Console.WriteLine("Ingrese tabla de Multiplicar");
            //int num = int.Parse(Console.ReadLine());
            //int i = 1;
            //Console.WriteLine("La Tabla de Multiplicar es :");
            //Console.WriteLine();
            //while (i <= 10)
            //{
            //    Console.WriteLine(num + "X" + i + "=" + num * i);
            //    i++;
            //}
            //Console.ReadLine(); 
            #endregion

            #region EJERCICIO # 19 EN C# : CALCULAR IVA DE PRODUCTO EN C#
            ///*Crea un programa que calcule el IVA de un producto. El valor de este producto 
            //    se pasará por teclado y nos mostrará por pantalla el valor del IVA y su valor 
            //    final. El IVA es el 21 %.Por ejemplo, 
            //    si introducimos 100como valor de producto, el IVA es 21 y el valor final es 121*/

            //Console.WriteLine("*************************************");
            //Console.WriteLine("Ingrese el Nombre de Producto");
            //string NombreProducto = Console.ReadLine();
            //Console.WriteLine("*************************************");
            //Console.WriteLine("Ingrese el Precio del Producto");
            //double PrecioProducto = double.Parse(Console.ReadLine());
            //Console.WriteLine("***********************************************");
            //double IVA = 0.21;
            //double ProductoIva = 0;
            //ProductoIva = PrecioProducto + (PrecioProducto * IVA);
            //Console.WriteLine("El Iva que se le aplico al producto es :" + IVA);
            //Console.WriteLine("Estes es el precio del producto sin Iva:" + PrecioProducto);
            //Console.WriteLine("Estes es el precio del producto con Iva:" + ProductoIva);
            //Console.WriteLine("***********************************************");
            //Console.ReadLine(); 
            #endregion

            #region EJERCICIO # 20 EN C# : CALCULAR EL RADIO DE UN CIRCULO 
            //// PROGRAMA PARA CALCULAR EL RADIO DE UN CIRCULO 
            //Console.WriteLine("***********************************************");
            //Console.WriteLine("Ingrese el area de el circulo a evaluar");
            //int Radio = int.Parse(Console.ReadLine());

            //double area = Math.PI * Math.Pow(Radio, 2);
            //Console.WriteLine("***********************************************");
            //Console.WriteLine("El Area de el Circulo es :" + area);
            //Console.WriteLine("***********************************************");
            //Console.ReadLine(); 
            #endregion

            #region EJERCICIO # 21 EN C# : VER SI EL PRIMER NUMERO ES DIVICIBLE ENTRE EL SEGUNDO NUMERO
            ///* Pide dos números por teclado.Indica si el primer número es divisible por el segundo. 
            //Por ejemplo, si introduzco 10 y 2, si es divisible, por que si divides 10 entre 2, el resto es 0 */

            //Console.WriteLine("Ingrese el primer numero x favor");
            //double num1 = double.Parse(Console.ReadLine());
            //Console.WriteLine("Ingrese el segundo numero x favor");
            //double num2 = double.Parse(Console.ReadLine());

            //if (num1 % num2 == 0)
            //{
            //    Console.WriteLine("El Primero Numero es Divisible con el Segundo Numero");
            //}
            //else
            //{
            //    Console.WriteLine("El Primero Numero no es Divisible con el Segundo Numero");
            //}
            //Console.ReadLine(); 
            #endregion

            #region EJERCICIO # 22 EN C# : NUMERO QUE NO SON DIVISIBLES ENTRE 2 USANDO FOR 
            //Console.WriteLine("*********************************************");
            //Console.WriteLine("NUMEROS QUE NO SON DIVISIBLES ENTRE 2 ");
            //Console.WriteLine("*********************************************");
            //Console.WriteLine("Ingrese cuantos numeros quiere generar ");
            //int num = int.Parse(Console.ReadLine());
            //Console.WriteLine("*********************************************");
            //Console.WriteLine("LOS NUMEROS SON :");
            //for (int i = 0; i < num; i++)
            //{
            //    if (i % 2 != 0)
            //    {
            //        Console.WriteLine("-> " + i);
            //    }
            //}
            //Console.WriteLine("*********************************************");
            //Console.ReadLine(); 
            #endregion

            #region EJERCICIO # 23 EN C# : NUMEROS QUE NO SON DIVISIBLES ENTRE 2 USANDO WHILE
            //Console.WriteLine("*********************************************");
            //Console.WriteLine("NUMEROS QUE NO SON DIVISIBLES ENTRE 2 ");
            //Console.WriteLine("*********************************************");
            //Console.WriteLine("Ingrese cuantos numeros quiere generar ");
            //int num = int.Parse(Console.ReadLine());
            //Console.WriteLine("*********************************************");
            //int i = 0;
            //Console.WriteLine("LOS NUMEROS SON :");
            //while (i <= num)
            //{
            //    if (i % 2 != 0)
            //    {
            //        Console.WriteLine("-> " + i);
            //    }
            //    i = i + 1;
            //}
            //Console.WriteLine("*********************************************");
            //Console.ReadLine(); 
            #endregion

            #region EJERCICIO # 24 EN C# : MESES DEL AÑO CON SOLO DIGITAR UN NUMERO USO DEL SWHITCH
            //Console.WriteLine("Ingrese un numero del 1 - 12");
            //int num = int.Parse(Console.ReadLine());

            //switch (num)
            //{
            //    case 1: Console.WriteLine("Este representa el mes de ENERO"); break;
            //    case 2: Console.WriteLine("Este representa el mes de FEBREO"); break;
            //    case 3: Console.WriteLine("Este representa el mes de MARZO"); break;
            //    case 4: Console.WriteLine("Este representa el mes de ABRIL"); break;
            //    case 5: Console.WriteLine("Este representa el mes de MAYO"); break;
            //    case 6: Console.WriteLine("Este representa el mes de JUNIO"); break;
            //    case 7: Console.WriteLine("Este representa el mes de JULIO"); break;
            //    case 8: Console.WriteLine("Este representa el mes de AGOSTO"); break;
            //    case 9: Console.WriteLine("Este representa el mes de SEPTIEMBRE"); break;
            //    case 10: Console.WriteLine("Este representa el mes de OCTUBRE"); break;
            //    case 11: Console.WriteLine("Este representa el mes de NOVIEMBRE"); break;
            //    case 12: Console.WriteLine("Este representa el mes de DICIEMBRE"); break;
            //    default: Console.WriteLine("Numero Fuera del Rango"); break;
            //}
            //Console.ReadLine();
            #endregion

            #region EJERCICIO # 25 EN C# : SUMA DE NUMEROS DENTRO DE UN CICLO FOR 
            //int numero, suma, resultado = 0;

            //Console.Write("Ingrese cantidad numeros a evaluar :");
            //numero = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= numero; i++)
            //{
            //    Console.Write("-> Numero :");
            //    suma = int.Parse(Console.ReadLine());
            //    resultado = suma + resultado;
            //}
            //Console.WriteLine("Resultado de la Suma : {0}", resultado);
            //Console.ReadLine(); 
            #endregion

            // NUEVOS EJERCICIOS HECHOS EN C#

            #region EJERCICIO # 26 EN C# : LECTOR DE UNA CANTIDAD DE NOTAS Y SACANDO PROMEDIO
            ///*  Que lea 5 calificaciones, calcule el promedio y nos diga si el alumno
            //     aprobó o reprobó */
            //double NumNotas, Nota, SumaNotas = 0, Promedio;
            //Console.WriteLine("******************************************");
            //Console.WriteLine("Ingrese el Numerod de Notas a Evaluar ?");
            //NumNotas = double.Parse(Console.ReadLine());
            //Console.WriteLine("******************************************");
            //for (int i = 0; i < NumNotas; i++)
            //{
            //    Console.WriteLine("Ingrese la Nota a registrar ");
            //    Nota = double.Parse(Console.ReadLine());
            //    SumaNotas = SumaNotas + Nota;
            //}
            //Promedio = SumaNotas / NumNotas;
            //if (Promedio >=6)
            //{
            //    Console.WriteLine("******************************************");
            //    Console.WriteLine("FELICIDADES USTED APROBO LA MATERIA");
            //    Console.WriteLine("El promedio del Alumno es de :" + Promedio);
            //    Console.WriteLine("******************************************");
            //}else
            //{ 
            //    Console.WriteLine("******************************************");
            //    Console.WriteLine("LO SENTIMOS USTED REPROBO LA MATERIA");
            //    Console.WriteLine("El promedio del Alumno es de :" + Promedio);
            //    Console.WriteLine("******************************************");
            //}

            //Console.ReadLine();
            #endregion

            #region EJERCICIO # 27 EN C# : SACAR NUMERO MAYOR DE DOS NUMEROS INGRESADOS
            ///* Que lea 2 números y nos dé el mayor */
            //Console.WriteLine("**********************************");
            //Console.Write(">> Ingrese el Primer Numero: ");
            //int NumUno = int.Parse(Console.ReadLine());

            //Console.Write(">> Ingrese el Segundo Numero: ");
            //int NumDos = int.Parse(Console.ReadLine());
            //Console.WriteLine("**********************************");
            //if (NumUno>NumDos)
            //{
            //    Console.WriteLine("El Primer Numero es el MAYOR");
            //}
            //else
            //{
            //    Console.WriteLine("El Segundo Numero es el MAYOR");
            //}
            //Console.WriteLine("**********************************");
            //Console.ReadLine(); 
            #endregion

            #region EJERCICIO # 28 EN C# : LEER TRES NUMEROS Y DECIR EL MENOR DE ELLOS 
            ///* Que lea 3 números y nos dé el menor */
            //int NumUno, NumDos, NumTres;
            //Console.WriteLine("******************************");
            //Console.Write(" Ingrese el Primero Numero: ");
            //NumUno = int.Parse(Console.ReadLine());
            //Console.Write(" Ingrese el Segundo Numero: ");
            //NumDos = int.Parse(Console.ReadLine());
            //Console.Write(" Ingrese el Primero Numero: ");
            //NumTres = int.Parse(Console.ReadLine());
            //Console.WriteLine("******************************");
            //if (NumUno < NumDos & NumUno < NumTres)
            //{
            //    Console.WriteLine(" El Numero Manor es el Primero ");
            //}
            //else if (NumDos < NumUno & NumDos < NumTres)
            //{
            //    Console.WriteLine(" El Numero Manor es el Segundo ");
            //}
            //else
            //{
            //    Console.WriteLine("El Numero Manor es el Tercero ");
            //}
            //Console.WriteLine("******************************");
            //Console.ReadLine(); 
            #endregion

            #region EJERCICIO # 29 EN C# : LEER EL SEXO, EDAD DE UNA PERSONA Y DECIR SI ES MAYOR O MENOR DE EDAD 
            ///*  Que lea la edad de una persona y el sexo de la misma(1.Masculino, 2.Femenino) y nos diga 
            //     si la persona es mayor de edad de sexo masculino de entre 18 y 30 años */
            //Console.WriteLine("*********************************************");
            //Console.WriteLine("Ingrese su Nombre x Favor ");
            //string nombre = Console.ReadLine();
            //Console.WriteLine("Ingrese su Sexo x Favor ");
            //string sexo = Console.ReadLine();
            //Console.WriteLine("Ingrese la Edad por Favor ");
            //int edad = int.Parse(Console.ReadLine());
            //Console.WriteLine("*********************************************");
            //if (edad >= 18)
            //{
            //    Console.WriteLine(nombre + " Usted es MAYOR de Edad y su Sexo es : " + sexo);
            //}
            //else
            //{
            //    Console.WriteLine(nombre + " Usted es MENOR de Edad y su Sexo es : " + sexo);
            //}
            //Console.WriteLine("*********************************************");
            //Console.ReadLine(); 
            #endregion

            #region EJERCICIO # 30 EN C# : INGRESAR TRES LADOS DEL TRIANGULO Y DECIR SU NOMBRE 
            ///* Que lea los tres lados de un triángulo y nos diga si es Equilátero,
            //      Isósceles o Escaleno  */
            //Console.WriteLine("**************************************************");
            //Console.WriteLine("Ingrese el Primer lado del Triangulo x Favor ");
            //int LadoUno = int.Parse(Console.ReadLine());
            //Console.WriteLine("Ingrese el Segundo lado del Triangulo x Favor ");
            //int LadoDos = int.Parse(Console.ReadLine());
            //Console.WriteLine("Ingrese el Tercer lado del Triangulo x Favor ");
            //int LadoTres = int.Parse(Console.ReadLine());
            //Console.WriteLine("**************************************************");
            //if (LadoUno == LadoDos & LadoDos == LadoTres)
            //{
            //    Console.WriteLine("El Triangulo Ingresado es un >> EQUILATERO << ");
            //}
            //else if (LadoUno != LadoDos & LadoDos != LadoTres & LadoTres == LadoUno)
            //{
            //    Console.WriteLine("El Triangulo Ingresado es un >> ISOSCELES << ");
            //}
            //else
            //{
            //    Console.WriteLine("El Triangulo Ingresado es un >> ESCALENO << ");
            //}
            //Console.WriteLine("**************************************************");
            //Console.ReadLine(); 
            #endregion

            #region EJERCICIO # 31 EN C# : PROGRAMA QUE DETERMINE PAGO POR HORAS DE SERVICIO DE CUIDO DE NIÑOS 
            ///*Una empresa vende horas de servicios para cuidar niños existen 3 tarifas dependiendo
            //      del horario, básica, intermedia, residencial. La primera se cobra a 20 pesos por hora si las
            //      horas exceden a más de 10 debe cobrarse cada hora restante a 25 pesos, la segunda se cobra a
            //      30 pesos por hora si las horas exceden a 15 cada hora extra debe cobrarse a 40 pesos, la última
            //      se cobra a 50 pesos por hora si excede de 20 horas debe pagar a 60 pesos cada hora extra; Escriba 
            //      un programa que lea las horas que un trabajador estuvo en un servicio así como el tipo de servicio
            //      y determine cuanto debe pagar  */
            //int Hora, CuotaUno = 20, CuotaDos = 30, CuotaTres = 50, Pago;
            //Console.WriteLine("****************************************************");
            //Console.WriteLine(" VENTA DE HORAS DE SERVICIO PARA CUIDAR NIÑOS ");
            //Console.WriteLine(" OPCIONES DE CUIDO DE NIÑOS QUE OFRECEMOS  ");
            //Console.WriteLine("****************************************************");
            //Console.WriteLine("Cuido de Niños BASICO      ($20.00 x Hora)------> (1)");
            //Console.WriteLine("Cuido de Niños INTERMEDIO  ($30.00 x Hora)------> (2)");
            //Console.WriteLine("Cuido de Niños RESIDENCIAL ($50.00 x Hora)------> (3)");
            //Console.WriteLine("****************************************************");
            //Console.WriteLine("ingrese la Opcion que desea Adquirir");
            //int Opcion = int.Parse(Console.ReadLine());
            //Console.WriteLine("****************************************************");
            //switch (Opcion)
            //{
            //    case 1:
            //        Console.WriteLine("Ingrese Cuantas Horas Cuidara al Niño ?");
            //        Hora = int.Parse(Console.ReadLine());
            //        if (Hora <= 10)
            //        {
            //            Pago = CuotaUno * Hora;
            //            Console.WriteLine("La Cantidad a Pagar es de :" + Pago);
            //        }
            //        else
            //        {
            //            Pago = (Hora - 10) * 25 + 200;
            //            Console.WriteLine("La Cantidad a Pagar es de :" + Pago);
            //        }
            //        break;
            //    ///////////// LA SEGUNDA AOPCION ES ESTA //////////////////
            //    case 2:
            //        Console.WriteLine("Ingrese Cuantas Horas Cuidara al Niño ?");
            //        Hora = int.Parse(Console.ReadLine());
            //        if (Hora <= 15)
            //        {
            //            Pago = CuotaDos * Hora;
            //            Console.WriteLine("La Cantidad a Pagar es de :" + Pago);
            //        }
            //        else
            //        {
            //            Pago = (Hora - 15) * 40 + 450;
            //            Console.WriteLine("La Cantidad a Pagar es de :" + Pago);
            //        }
            //        break;
            //    ///////////// LA TERCERA AOPCION ES ESTA //////////////////
            //    case 3:
            //        Console.WriteLine("Ingrese Cuantas Horas Cuidara al Niño ?");
            //        Hora = int.Parse(Console.ReadLine());
            //        if (Hora <= 20)
            //        {
            //            Pago = CuotaTres * Hora;
            //            Console.WriteLine("La Cantidad a Pagar es de :" + Pago);
            //        }
            //        else
            //        {
            //            Pago = (Hora - 20) * 60 + 1000;
            //            Console.WriteLine("La Cantidad a Pagar es de :" + Pago);
            //        }
            //        break;
            //}
            //Console.WriteLine("****************************************************");
            //Console.ReadLine(); 
            #endregion

            #region EJERCICIO # 32 EN C# VENTA DE PRODUCTO + DESCUENTO POR COMPRA DE DOCENA
            /* Una tienda ha puesto en oferta la venta al por mayor de cierto producto, ofreciendo un
                   descuento del 15% por la compra de más de 3 docenas y 10% en caso contrario. Además por la compra
                    de más de 3 docenas se obsequia una unidad del producto por cada docena en exceso sobre 3.
                    Diseñe un programa que determine el monto de la compra, el monto del descuento, el monto a pagar
                    y el número de unidades de obsequio por la compra de cierta cantidad de docenas del producto. */
            //double CantProducto, PrecioDocena, Descuento;

            //Console.WriteLine("Ingrese la cantidad de docenas que compro");
            //CantProducto = double.Parse(Console.ReadLine());
            //Console.WriteLine("Ingrese el precio por docena");
            //PrecioDocena = double.Parse(Console.ReadLine());
            //if (CantProducto >= 3)
            //{
            //    int regalo;
            //    regalo = +1;
            //    Descuento = (CantProducto * PrecioDocena) - 0.15;
            //    Console.WriteLine("Cantidad de Prodcutos Comprados :" + CantProducto);
            //    Console.WriteLine("Descuento Realizado por Compra Producto :" + "0.15 %");
            //    Console.WriteLine("Un Producto de Regalia por mas de 3 Docenas :" + regalo);
            //    Console.WriteLine("Cantidad que tiene que pagar por productos es de :" + Descuento);
            //}
            //else
            //{
            //    Descuento = (CantProducto * PrecioDocena) - 0.10;
            //    Console.WriteLine("Cantidad que tiene que pagar por productos es de :" + Descuento);
            //}
            //Console.ReadLine(); 
            #endregion

            #region EJERCICIO # 33 EN C# : PROGRAMA CALCULA ALQUILER DE CARRO POR KILOMETRO RECORRIDO
            ///* Una compañía dedicada al alquiler de automóviles cobra un monto fijo de $30 para los primeros
            //      300 km de recorrido. Para más de 300 km y hasta 1000 km, cobra un monto adicional de $ 0.15 por
            //      cada kilómetro en exceso sobre 300. Para más de 1000 km cobra un monto adicional de $ 0.10 por
            //      cada kilómetro en exceso sobre 1000. Los precios ya incluyen el 18% del impuesto general a las
            //      ventas, IGV. Diseñe un programa que determine el monto a pagar por el alquiler de un vehículo y 
            //      el monto incluido del impuesto.   */

            //double Tarifa = 30, Kilometro, Adicional;
            //Console.WriteLine("Ingrese los Kilometros a Recorrer");
            //Kilometro = double.Parse(Console.ReadLine());
            //if (Kilometro == 300)
            //{
            //    Console.WriteLine("El monto a pagar es de :" + Tarifa);
            //}
            //else if (Kilometro > 300 & Kilometro < 1000)
            //{
            //    Adicional = (Tarifa * 0.15) + Tarifa;
            //    Console.WriteLine("El monto a pagar es de :" + Tarifa);
            //}
            //else if (Kilometro > 300 & Kilometro > 1000)
            //{
            //    Adicional = (Tarifa * 0.10) + Tarifa;
            //    Console.WriteLine("El monto a pagar es de :" + Tarifa);
            //}
            //Console.ReadLine(); 
            #endregion

            #region EJERCICIO # 34 EN C# : OBTENCION DEL AREA DE UN CIRCULO EN C#
            //// Que nos de el area y perimetro de un circulo
            //double area, radio;
            //Console.WriteLine("Ingrese el Radio del Circulo");
            //radio = double.Parse(Console.ReadLine());

            //// Aqui uso la libreria Math obteniendo el valor de Math.PI y multiplicandolo por el Radio
            //// con el Math.Pow Elevo el Radio ^2 y con Math.Round redondeo el resultado a 3 decimales 
            //area = Math.Round(Math.PI * Math.Pow(radio, 2), 3);
            //Console.WriteLine("El Area del Circulo :" + area);
            //Console.ReadLine();
            #endregion

            #region EJERCICIO # 35 EN C# : CONVERSION DE COLON A DOLARES 
            //double Dolar = 8.75, Conversion;
            //Console.WriteLine("CONVERSION DE COLON A DOLAR");
            //Console.WriteLine("Ingrese la Cantidad de Colones ?");
            //double Colones = double.Parse(Console.ReadLine());

            //Conversion = Colones * Dolar;
            //Console.WriteLine("La Conversion de sus Colones a Dolares es de :" + Conversion);
            //Console.ReadLine(); 
            #endregion

            // NUEVOS EJERCICIOS  HECHOS EN C#

            #region EJERCICIO # 36 EN C# : 100 NUMEROS REALES
            //int contador = 0;
            //while (contador <= 100)
            //{
            //    Console.WriteLine("->" + contador);
            //    contador = contador + 1;
            //}
            //Console.ReadKey();
            #endregion;

            #region EJERCICIO # 37 EN C# : 100 NUMEROS IMPARES
            //int i, impar = 0;
            //Console.WriteLine("LOS NUNEROS IMPARES SON :");
            //for (i = 0; i < 100; i++)
            //{
            //    if (i % 2 != 0)
            //    {
            //        Console.ForegroundColor = ConsoleColor.White;
            //        Console.WriteLine("-->" + i);
            //        impar++;
            //    }
            //}
            //Console.ReadKey();
            #endregion

            #region EJERCICIO # 38 EN C# : FIGURA FIBONACCI
            //int n, x = 0, y = 1, z = 1;
            //Console.ForegroundColor = ConsoleColor.White;
            //Console.WriteLine("     ---->> BIENVENIDO <<----     ");
            //Console.WriteLine("*******************************************************");
            //Console.WriteLine("Ingrese el Numero de Elementos de la figura FIBONACCI");
            //n = int.Parse(Console.ReadLine());
            //Console.WriteLine("********************************************************");
            //Console.WriteLine(" ----->> LA FIGURA FIBONACCI ES <<-----");
            //Console.WriteLine("********************************************************");
            //Console.ForegroundColor = ConsoleColor.Yellow;
            //Console.Write(" 1");
            //for (int i = 1; i < n; i++)
            //{
            //    z = x + y;
            //    Console.Write("->" + z);
            //    x = y;
            //    y = z;

            //}
            //Console.ReadLine();
            //Console.WriteLine("********************************************************"); 
            #endregion

            #region EJERCICIO # 39 EN C# : FIGURA FIBONACCI # 2
            //int Cantidad, Contador = 0, atras = 1, siguiente = 1;
            //Console.ForegroundColor = ConsoleColor.White;
            //Console.WriteLine("     ---->> BIENVENIDO <<----     ");
            //Console.WriteLine("Ingrese el Numero de Elementos de la figura FIBONACCI");
            //Cantidad = int.Parse(Console.ReadLine());

            //Console.WriteLine("->1");
            //int i = 1;
            //while (i < Cantidad)
            //{
            //    i++;
            //    siguiente = Contador + atras;
            //    Console.WriteLine("->" + siguiente);
            //    Contador = siguiente;
            //    atras = siguiente;
            //}
            //Console.ReadKey(); 
            #endregion

            #region EJERCICIO # 40 EN C# : REGISTRO DE PERSONAS HOMBRE Y MUJERES DICIENDO CUANTOS SE REGISTRARON POR GENERO
            //string nombre, sexo;
            //int edad, canEmple;
            //int Hombre, Mujer;
            //Console.WriteLine();
            //Console.ForegroundColor = ConsoleColor.White;
            //Console.WriteLine("Ingrese la Cantidad de Empleados a Evaluar");
            //canEmple = int.Parse(Console.ReadLine());

            //// (int i = 0; i < 5; i++)
            //for (int i = 1; i < canEmple; i++)
            //{

            //    Console.ForegroundColor = ConsoleColor.White;
            //    Console.WriteLine("**********************************************");
            //    Console.WriteLine("Ingrese su Nombre por Favor ");
            //    nombre = Console.ReadLine();
            //    Console.WriteLine("Ingrese su Edad ");
            //    edad = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Ingrese su Genero");
            //    sexo = Console.ReadLine();

            //    if (sexo == "h")
            //    {
            //        Hombre = +1;
            //        Hombre = int.Parse(Console.ReadLine());

            //    }
            //    else
            //        if (sexo == "m")
            //    {
            //        Mujer = +1;

            //    }

            //}
            //Console.WriteLine("**********************************************");
            //// Console.WriteLine(value: "La Cantidad de Hombres es de: " + (Hombre));
            ////Console.WriteLine("La Cantidad de Mujeres es de: "  + Mujer);
            //Console.ReadLine(); 
            #endregion


            // NUEVOS EJERCICIOS DE: https://aprenderaprogramar.com/foros/index.php?topic=1544.0

            #region EJERCICIO # 41 EN C# : NUMEROS DEL 0 - 100 IMPARES USO FOR,WHILE, DO WHILE
            //// MOSTRAR LOS NUMEROS IMAPRES DEL 0 - 100 USANDO EL CICLO FOR
            //Console.WriteLine("Los Numeros Pares son: ");
            //for (int i = 0; i < 101; i++)
            //{
            //    if (i % 2 != 0)
            //    {
            //        Console.Write("->" + i);
            //    }
            //}
            //Console.ReadLine(); 


            ////// MOSTRAR LOS NUMEROS IMAPRES DEL 0 - 100 USANDO EL CICLO WHILE
            //int i = 0;
            //Console.WriteLine("Los Numeros Pares son: ");
            //while (i<101)
            //{
            //    i++;
            //    if (i % 2 != 0)
            //    {
            //        Console.Write("->" + i);
            //    }
            //}
            //Console.ReadLine();

            ////// MOSTRAR LOS NUMEROS IMAPRES DEL 0 - 100 USANDO EL CICLO DO - WHILE
            //int i = 0;
            //Console.WriteLine("Los Numeros Pares son: ");
            //do
            //{
            //    i++;
            //    if (i % 2 != 0)
            //    {
            //        Console.Write("->" + i);
            //    }
            //} while (i < 101);
            //Console.ReadLine();
            #endregion

            #region EJERCICIO # 42 EN C# : NUMEROS PARES DEL 0 - 100 USANDO FOR, WHILE 
            //// MOSTRAR LOS NUMEROS PARES DE 0 - 100 USANDO CICLO FOR
            //Console.WriteLine("Los Numeros pares son :");
            //for (int i = 0; i < 101; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.Write("->" + i);
            //    }
            //}
            //Console.ReadLine(); 


            //// MOSTRAR LOS NUMEROS PARES DE 0 - 100 USANDO CICLO WHILE
            //int i = 0;
            //Console.WriteLine("Los Numeros pares son :");
            //while (i <101)
            //{
            //    i++;
            //    if (i%2==0)
            //    {
            //        Console.Write("->" + i);
            //    }
            //}
            //Console.ReadLine();

            #endregion

            #region EJERCICIO # 43 EN C# : MOSTRAR NUMERO DE 0 - 20 Y DE 20 - 0
            //// MOSTRAR NUMEROS DE 0 - 20 Y DE 20 - 0
            //for (int i = 0; i < 20; i++)
            //{
            //    Console.WriteLine("->" + i);
            //}
            //Console.ReadLine();


            ////// MOSTRAR NUMEROS DE 0 - 20 Y DE 20 - 0
            //for (int i = 20; i > 0; i--)
            //{
            //    Console.WriteLine("->" + i);
            //}
            //Console.ReadLine(); 
            #endregion

            #region EJERCICIO # 44 EN C# : NUMEROS DIVISIBLES DE 3
            //// NUMEROS DIVICIBLES ENTRE 3
            //for (int i = 0; i < 20; i++)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine("->" + i);
            //    }
            //}
            //Console.ReadLine(); 
            #endregion

            #region EJERCICIO # 45 EN C# : AGREGAR 10 NUMEROS Y QUE SE SUMEN 
            //double num, mayor = 0, menor = 1;
            //int cont = 0;

            //while (cont < 10)
            //{
            //    do
            //    {
            //        Console.Write("Número:");
            //        num = float.Parse(Console.ReadLine());

            //    } while (num == 0);

            //    if (num > 0)
            //        mayor = mayor + num;
            //    if (num < 0)
            //        menor = menor * num;
            //    cont++;
            //}
            //if (menor == 1)// En caso de que se ingrese todos +
            //    menor = 0;
            //Console.Write("La suma de los números + es {0} y el producto de los - es {1}", mayor, menor);
            //Console.ReadLine(); 
            #endregion





            // COMO CORRER FUNCIONES EN C#:

            #region FORMA DE CORRER UNA FUNCION CREADA FUERA DEL MAIN()
            //EjecutarFuncion();
            //Console.ReadLine();
            #endregion

            #region FORMA DE RETORNAR UNA FUNCION QUE RETORNA ALGO
            //Console.WriteLine("La Suma de los Numeros es de :" + RegresarFuncion());
            //Console.ReadLine();
            #endregion

            #region FUNCION QUE RECIBE DOS NUMERO Y COMO EJECUTARLA
            //RecibeFuncion(10, 2);
            //Console.ReadLine();
            #endregion

            #region FORMA DE CREAR UN ARREGLO SIMPLE 
            //// DETERMINACION DE UN ARREGLOS EN C# 
            //// Tipo[] Nombre Arreglo = new Tipo[Tamaño que tendra];
            //int[] Arreglo = new int[5];

            //Arreglo[0] = 10;
            //Arreglo[1] = 9;
            //Arreglo[2] = 8;
            //Arreglo[3] = 6;
            //Arreglo[4] = 3;

            //Console.WriteLine(Arreglo[0]);
            //Console.ReadLine();
            #endregion

            #region COMO CREAR UN ARREGLO Y COMO RECORRERLO
            //// DETERMINACION DE UN ARREGLOS EN C# 
            //// Tipo[] Nombre Arreglo = new Tipo[Tamaño que tendra];
            //int[] arreglo = new int[10];

            //arreglo[0] = 10;

            //for (int i = 0; i < 10; i++)
            //{
            //    arreglo[i] = i + 1;
            //}

            //for (int x = 0; x < 10; x++)
            //{
            //    Console.WriteLine(arreglo[x]);
            //}
            //Console.ReadLine(); 
            #endregion
 
        }

        // FUNCIONES QUE ESTA FUERA DE ESTE MAIN()
        #region COMO CREAR FUNCIONES QUE ESTAN FUERA DEL MAIN()
        // FUNCION QUE PUEDE EJECUTAR CODIGO
        //static void EjecutarFuncion()
        //{
        //    Console.WriteLine("Aqui estamos Corriendo una Funcion llamada MENSAJE en tu MAIN()");
        //}
        //// FUNCION QUe RETORNA UN VALOR QUE LE INDIQUEMOS 
        //static int RegresarFuncion()
        //{
        //    int NumUno = 5, NumDos = 10, suma = 0;
        //    suma = NumUno + NumDos;
        //    return suma;
        //}
        //// FUNCION QUE RECIBE DOS PARAMETROS Y QUE RECIBE Y DEVUELVE LOS VALORES 
        //static void RecibeFuncion(int NumUno, int NumDos)
        //{
        //    int resta = 0;
        //    resta = NumUno - NumDos;
        //    Console.WriteLine("La Resta de los dos Numeros en la Funcion es de: " + resta);

        //}
        #endregion

       
    }
}

