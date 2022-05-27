using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIBONACII
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, x = 0, y = 1, z = 1;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("     ---->> BIENVENIDO <<----     ");
            Console.WriteLine("*******************************************************");
            Console.WriteLine("Ingrese el Numero de Elementos de la figura FIBONACCI");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("********************************************************");
            Console.WriteLine(" ----->> LA FIGURA FIBONACCI ES <<-----");
            Console.WriteLine("********************************************************");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(" 1");
            for (int i = 1; i < n; i++)
            {
                z = x + y;
                Console.Write("->" + z);
                x = y;
                y = z;

            }
            Console.ReadLine();
            Console.WriteLine("********************************************************");
        }
    }
}
