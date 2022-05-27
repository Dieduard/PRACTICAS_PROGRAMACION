using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LETRA_VOCAL_CONSONANTE
{
    class Program
    {
        static void Main(string[] args)
        {
            string letra;
            Console.WriteLine("Ingrese una letra por Favor");
            letra = Console.ReadLine();

            if (letra == "a")
                Console.WriteLine("La letra ingresada es una Vocal");
            else if (letra == "e")
                Console.WriteLine("La letra ingresada es una Vocal");
            else if (letra == "i")
                Console.WriteLine("La letra ingresada es una Vocal");
            else  if (letra == "o")
                Console.WriteLine("La letra ingresada es una Vocal");
            else  if (letra == "u")
                Console.WriteLine("La letra ingresada es una Vocal");
                else
                Console.WriteLine("La letra ingresada es una Consonante");
            Console.ReadLine();
        }
    }
}
