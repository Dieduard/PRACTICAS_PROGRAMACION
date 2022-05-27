using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAYOR_DE_EDAD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" Ingrese su Nombre por Favor");
            string nombre = Console.ReadLine();

            Console.WriteLine(" Ingrese su Edad por Favor ");
            int edad = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Yellow;
            if(edad >= 18)
            {
                Console.WriteLine(nombre + " Usted es Mayor de Edad ");
            }
            else
            {
                Console.WriteLine(nombre + " Usted es Menor de Edad ");
            }
            Console.ReadLine();
        }
    }
}
