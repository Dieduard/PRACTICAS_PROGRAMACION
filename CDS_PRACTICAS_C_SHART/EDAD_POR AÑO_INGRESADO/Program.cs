using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDAD_POR_AÑO_INGRESADO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" Ingrese su Año de Nacimiento por Favor");
            int anio = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Yellow;
            if (anio <= 2018)
            {
                int edad = (2018 - anio);
                Console.WriteLine(" Su Edad es :" + edad);
            }
            else
            {
                Console.WriteLine("Usted no ha Nacido Aun ");
            }
            Console.ReadLine();
        }
    }
}
