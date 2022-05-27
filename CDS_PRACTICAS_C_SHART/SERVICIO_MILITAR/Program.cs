using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERVICIO_MILITAR
{
    class Program
    {
        static void Main(string[] args)
        {
         
            string genero ;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Ingrese su nombre por favor ");
            string nombre = Console.ReadLine();

            Console.WriteLine("Ingrese su edad por favor ");
            int edad = int.Parse(Console.ReadLine());
            Console.WriteLine(" Ingrese su Genero segun las letras por Favor ");
            Console.WriteLine(" H = Hombre Y M = Mujer ");
            genero = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            if (edad >= 18 && edad <= 25 && genero.ToUpper() == "H")
                Console.WriteLine(nombre + " Usted puede prestar servicio Militar");
            else
                Console.WriteLine(nombre + " Lo sentimos Usted no esta apto para prestar servicio");

            Console.ReadLine();
        }
    }
}
