using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MESES_DEL_AÑO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" >>> Ingrese un Numero del 1 al 12 <<<");
            Console.WriteLine(" >>> para saber el MES <<<");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Ingrese un Numero por Favor");
            int dia = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("****************************");
            int caseSwitch = dia;

            switch (caseSwitch)
            {
                case 1:
                    Console.WriteLine("Este Mes es Enero");
                    break;
                case 2:
                    Console.WriteLine("Este Mes es Febrero");
                    break;
                case 3:
                    Console.WriteLine("Este Mes es Marzo");
                    break;
                case 4:
                    Console.WriteLine("Este Mes es Abril");
                    break;
                case 5:
                    Console.WriteLine("Este Mes es Mayo");
                    break;
                case 6:
                    Console.WriteLine("Este Mes es Junio");
                    break;
                case 7:
                    Console.WriteLine("Este Mes es Julio");
                    break;
                case 8:
                    Console.WriteLine("Este Mes es Agosto");
                    break;
                case 9:
                    Console.WriteLine("Este Mes es Septiembre");
                    break;
                case 10:
                    Console.WriteLine("Este Mes es Octubre");
                    break;
                case 11:
                    Console.WriteLine("Este Mes es Noviembre");
                    break;
                case 12:
                    Console.WriteLine("Este Mes es Diciembre");
                    break;
                default:
                    break;
            }
            Console.WriteLine("****************************");
            Console.ReadLine();
        }
    }
}
