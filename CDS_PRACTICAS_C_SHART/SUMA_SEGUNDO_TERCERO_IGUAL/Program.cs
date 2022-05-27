using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUMA_SEGUNDO_TERCERO_IGUAL
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Ingrese el Primer Numero a Evaluar");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el Segundo Numero a Evaluar");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el Tercero Numero a Evaluar");
            int num3 = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Yellow;
            int suma = num1 + num2;
            if (suma == num3)
                Console.WriteLine("Los Numeros son Iguales");
            else
                Console.WriteLine("Los Numeros no son Iguales ");
            Console.ReadLine();
        }
    }
}
