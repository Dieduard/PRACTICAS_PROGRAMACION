using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAR_IMPAR
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Ingrese el Numero que Evaluara");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
                Console.WriteLine("El Numero es Par");
            else
                Console.WriteLine("El Numero es Impar");

            Console.ReadLine();
        }
    }
}
