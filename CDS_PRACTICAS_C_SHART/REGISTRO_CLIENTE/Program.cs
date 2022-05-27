using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REGISTRO_CLIENTE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" Ingrese su Nombre por Favor ");
            string nombre = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            if (nombre == "diego huete")
            {
                Console.WriteLine(" Hola que tal :" + nombre);
            }
            else
            {
                Console.WriteLine(" Disculpa No te conozco : " + nombre);
            }
            Console.ReadLine();
        }
    }
}
