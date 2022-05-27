using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSITIVO_NEGATIVO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Ingrese el Numero a Evaluar");
            int num = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Yellow;
            if (num > 0)
                Console.WriteLine("El Numero es Positivo");
            else
                Console.WriteLine("El Numero es Negativo");

            Console.ReadLine();
        }
    }
}
