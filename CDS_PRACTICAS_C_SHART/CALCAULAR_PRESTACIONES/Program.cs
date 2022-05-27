using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CALCAULAR_PRESTACIONES
{
    class Program
    {
        static void Main(string[] args)
        {
            double sueldo = 4500;
            double resp =0;
            int tiempo;
            Console.WriteLine("Ingrese su Nombre");
            string nombre = Console.ReadLine();

            Console.WriteLine("Ingrese su Tiempo Laboral");
            tiempo = int.Parse(Console.ReadLine());

            if (tiempo >= 10)
                resp = (sueldo * 0.10)+sueldo;
            else if (tiempo < 10 && tiempo > 5)
                resp = (sueldo * 0.07)+sueldo;
            else if (tiempo < 5 && tiempo > 3)
                resp = (sueldo * 0.05)+sueldo;
            else if (tiempo < 3)
                resp = (sueldo * 0.03)+sueldo;
            else
                Console.WriteLine("Usted acaba de entrar");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("El aumento de su sueldo es de : " + resp);
            Console.ReadLine();

        }
    }
}
