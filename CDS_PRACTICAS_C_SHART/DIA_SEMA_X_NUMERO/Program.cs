using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIA_SEMA_X_NUMERO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" >>> Ingrese un Numero del 1 al 7 por Favor");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Ingrese un Numero por Favor");
            int dia = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Yellow;
            if (dia == 1)
                Console.WriteLine("Hoy es Lunes");
            else if (dia == 2)
                Console.WriteLine("Hoy es Martes");
            else if (dia == 3)
                Console.WriteLine("Hoy es Miercoles");
            else if (dia == 4)
                Console.WriteLine("Hoy es Jueves");
            else if (dia == 5)
                Console.WriteLine("Hoy es Viernes");
            else if (dia == 6)
                Console.WriteLine("Hoy es Sabado");
            else if (dia == 7)
                Console.WriteLine("Hoy es Domingo");
            else
                Console.WriteLine("Ese dia NO Existe");
            Console.ReadLine();
        }
    }
}
