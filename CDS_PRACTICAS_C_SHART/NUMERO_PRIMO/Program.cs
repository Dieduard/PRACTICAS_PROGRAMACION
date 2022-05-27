using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUMERO_PRIMO
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, i, n;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Ingrese el Numero a Evaluar ");
            n = int.Parse(Console.ReadLine());

            for (i = 1; i < (n + 1); i++)
            {
                if (n % i == 0)
                {
                    a++;
                }
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            if (a != 2)
            {
                Console.WriteLine("Este Numero no es Primo");
            }
            else
            {
                Console.WriteLine("Este Numero Si es Primo");
            }
            Console.ReadLine();
        }
    }
}
