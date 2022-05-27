using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TABLA_MULTIPLICAR
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int num;
                Console.WriteLine(" ------->> BIENVENIDO <<-------");
                Console.WriteLine("Ingrese un Numero entre 0 y 10:");
                num = int.Parse(Console.ReadLine());

                for (int i = 1; i < 11; i++)
                    Console.WriteLine("{0} x {1} = {2}", num, i, num * i);
            }
            catch (Exception ex)
            {

                Console.WriteLine(" Favor Ingresar Numeros no Letras por Favor ", ex);
            }
            Console.ReadKey();
        }
    }
}
