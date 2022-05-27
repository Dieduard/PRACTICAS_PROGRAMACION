using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAIZ_CUADRADA
{
    class Program
    {
        static void Main(string[] args)
        {
            double num, r;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Ingrese el Numero a Evaluar");
            num = double.Parse(Console.ReadLine());
            r = Math.Round(Math.Sqrt(num), 2);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("El resultado de la Evaluacion es : " + r);
            Console.ReadLine();
        }
    }
}
