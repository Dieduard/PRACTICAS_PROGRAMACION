using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORDEN_NUMEROS
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int num3;
            int mayor;
            int menor;
            int medio;

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" Ingrese el primer numero a evaluar");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine(" Ingrese el segundo numero a evaluar");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine(" Ingrese el tercer numero a evaluar");
            num3 = int.Parse(Console.ReadLine());

            if (num1 > num2)
                mayor = num1;
            else
                mayor = num2;

            if (num3 > mayor)
                mayor = num3;

            if (num1 < num2)
                menor = num1;
            else
                menor = num2;

            if (num3 < menor)
                menor = num3;

            if ((num1 != mayor) & (num1 != menor))
                medio = num1;
            else
                if ((num2 != mayor) & (num2 != menor))
            {
                medio = num2;
            }
            else medio = num3;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("El Orden de los Numeros es:");
            Console.WriteLine("El Numero Menor es :" + menor);
            Console.WriteLine("El Numero Medio es :" + medio);
            Console.WriteLine("El Numero Mayor es :" + mayor);
            Console.ReadLine();
        }
    }
}
