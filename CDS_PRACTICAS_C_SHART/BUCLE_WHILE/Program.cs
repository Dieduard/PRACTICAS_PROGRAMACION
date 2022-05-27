using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUCLE_WHILE
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            x = 1;
            while (x <= 5)
            {
                Console.WriteLine("");
                Console.WriteLine("          " + 1 +"."+x + "          " + 2 + "." + x + "          " + 3 + "." + x + "          " + 4 + "." + x + "          " + 5 + "." + x);
                x = x + 1;
            }
            Console.ReadKey();
        }
    }
}
