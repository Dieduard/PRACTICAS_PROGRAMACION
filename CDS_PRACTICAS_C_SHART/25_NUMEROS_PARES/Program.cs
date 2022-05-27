using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_NUMEROS_PARES
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 25; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine("->"+i);
            }
            Console.ReadLine();
        }
    }
}
