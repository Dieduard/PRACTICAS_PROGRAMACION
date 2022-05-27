using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUMERO_MAYOR
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" Ingrese el primer Numero a Evaluar ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine(" Ingrese el segundo Numero a Evaluar ");
            int num2 = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Yellow;
            if(num1 > num2)
            {
                Console.WriteLine("El Numero Mayor es :" + num1);
                Console.WriteLine("El Numero Menor es :" + num2);
            }
            else
            {
                Console.WriteLine("El Numero Mayor es :" + num2);
                Console.WriteLine("El Numero Menor es :" + num1);
            }
            Console.ReadLine();
        }
    }
}
