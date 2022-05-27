using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MENU_OPCIONES
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------Menu Opciones--------");
            Console.WriteLine("SUMAR  ---->(1)");
            Console.WriteLine("RESTAR ---->(2)");
            Console.WriteLine("MULTIP ---->(3)");
            Console.WriteLine("DIVID  ---->(4)");
            Console.WriteLine("Salir  ---->(5)");
            Console.Write("Digite una opcion: ");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    {
                        Console.WriteLine("Ingrese el primer numero a evaluar");
                        int num1 = int.Parse(Console.ReadLine());

                        Console.WriteLine("Ingrese el segundo numero a evaluar");
                        int num2 = int.Parse(Console.ReadLine());

                        int suma = num1 + num2;
                        Console.WriteLine("la suma de sus numeros es de :" + suma);
                        break;

                    }
                case 2:
                    {
                        Console.WriteLine("Ingrese el primer numero a evaluar");
                        int num1 = int.Parse(Console.ReadLine());

                        Console.WriteLine("Ingrese el segundo numero a evaluar");
                        int num2 = int.Parse(Console.ReadLine());

                        int resta = num1 - num2;
                        Console.WriteLine("la suma de sus numeros es de :" + resta);
                        break;

                    }
                case 3:
                    {
                        Console.WriteLine("Ingrese el primer numero a evaluar");
                        int num1 = int.Parse(Console.ReadLine());

                        Console.WriteLine("Ingrese el segundo numero a evaluar");
                        int num2 = int.Parse(Console.ReadLine());

                        int multi = num1 * num2;
                        Console.WriteLine("la suma de sus numeros es de :" + multi);
                        break;

                    }
                case 4:
                    {
                        Console.WriteLine("Ingrese el primer numero a evaluar");
                        int num1 = int.Parse(Console.ReadLine());

                        Console.WriteLine("Ingrese el segundo numero a evaluar");
                        int num2 = int.Parse(Console.ReadLine());

                        int divi = num1 / num2;
                        Console.WriteLine("la suma de sus numeros es de :" + divi);
                        break;

                    }
                case 5:
                    {
                        Mensaje_Salida();
                        break;

                    }
                    
            }
            Console.ReadLine();
        }
        static void Mensaje_Salida()
        {
            Console.WriteLine("Saliendo del Programa!....");
        }
    }
}
