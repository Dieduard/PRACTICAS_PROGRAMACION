using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VOCAL
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" Ingrese la Letra que desea Evaluar ");
            string letra = Console.ReadLine();
            letra.ToUpper();
            Console.ForegroundColor = ConsoleColor.Yellow;
            if ( letra == "a,e,i,o,u")
            {
                Console.WriteLine(" La letra es una Vocal");
            }
            else
            {
                Console.WriteLine(" La letra es una Consonante");
            }
            Console.ReadLine();
        }
    }
}
